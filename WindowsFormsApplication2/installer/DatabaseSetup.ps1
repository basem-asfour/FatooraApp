param(
    [string]$ScriptDir
)

$logFile = Join-Path $ScriptDir "setup_log.txt"
$masterConnStr = "Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True"
$dbConnStr = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mostafa_helth;Integrated Security=True"

function Write-Log($msg) {
    $timestamp = Get-Date -Format "yyyy-MM-dd HH:mm:ss"
    "$timestamp - $msg" | Out-File -Append -FilePath $logFile -Encoding UTF8
    Write-Host $msg
}

function Execute-SqlBatches($connectionString, $batches) {
    $conn = New-Object System.Data.SqlClient.SqlConnection($connectionString)
    $conn.Open()

    $successCount = 0
    $errorCount = 0

    foreach ($batch in $batches) {
        $trimmed = $batch.Trim()
        if ($trimmed -eq '' -or $trimmed -eq '--' -or $trimmed.StartsWith('-- ===') -or $trimmed.StartsWith('-- skipped')) { continue }

        try {
            $cmd = $conn.CreateCommand()
            $cmd.CommandText = $trimmed
            $cmd.CommandTimeout = 120
            $cmd.ExecuteNonQuery() | Out-Null
            $successCount++
        }
        catch {
            $errorCount++
            $preview = $trimmed.Substring(0, [Math]::Min(300, $trimmed.Length))
            Write-Log "SQL Error: $_ | Batch: $preview"
        }
    }

    $conn.Close()
    Write-Log "Batches: $successCount OK, $errorCount errors."
}

try {
    Write-Log "=== FatooraApp Database Setup Started ==="

    # Step 1: Ensure database exists
    Write-Log "Checking database..."
    $conn = New-Object System.Data.SqlClient.SqlConnection($masterConnStr)
    $conn.Open()
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'mostafa_helth') CREATE DATABASE [mostafa_helth] COLLATE Arabic_CI_AS"
    $cmd.CommandTimeout = 120
    $cmd.ExecuteNonQuery() | Out-Null
    $conn.Close()
    Write-Log "Database ready."
    Start-Sleep -Seconds 1

    # Step 2: Run setup_database.sql (tables + stored procedures)
    $setupFile = Join-Path $ScriptDir "setup_database.sql"
    if (Test-Path $setupFile) {
        Write-Log "Running schema script..."
        $sql = Get-Content $setupFile -Raw -Encoding UTF8

        # Split on GO (case-insensitive, handles trailing whitespace)
        $allBatches = $sql -split '(?mi)^\s*GO\s*$'

        # Filter out database-level commands (CREATE/ALTER DATABASE, USE)
        # These are handled above - keep only table and SP batches
        $dbBatches = @()
        foreach ($batch in $allBatches) {
            $trimmed = $batch.Trim()
            if ($trimmed -match '(?i)CREATE\s+DATABASE') { continue }
            if ($trimmed -match '(?i)ALTER\s+DATABASE') { continue }
            if ($trimmed -match '(?i)^\s*USE\s+\[') { continue }
            if ($trimmed -match '(?i)SELECT\s+name\s+FROM\s+sys\.databases') { continue }
            if ($trimmed -match '(?i)SELECT\s+collation_name\s+FROM\s+sys\.databases') { continue }
            $dbBatches += $trimmed
        }

        Write-Log "Found $($dbBatches.Count) SQL batches to execute..."
        Execute-SqlBatches $dbConnStr $dbBatches
        Write-Log "Schema setup complete."
    }
    else {
        Write-Log "ERROR: setup_database.sql not found!"
        exit 1
    }

    # Step 3: Run seed data
    $seedFile = Join-Path $ScriptDir "seed_data.sql"
    if (Test-Path $seedFile) {
        Write-Log "Inserting seed data..."
        $sql = Get-Content $seedFile -Raw -Encoding UTF8
        $batches = $sql -split '(?mi)^\s*GO\s*$'
        # Filter USE statements
        $seedBatches = @()
        foreach ($batch in $batches) {
            $trimmed = $batch.Trim()
            if ($trimmed -match '(?i)^\s*USE\s+\[') { continue }
            $seedBatches += $trimmed
        }
        Execute-SqlBatches $dbConnStr $seedBatches
        Write-Log "Seed data complete."
    }

    Write-Log "=== Database Setup Completed Successfully ==="
    exit 0
}
catch {
    Write-Log "FATAL ERROR: $_"
    exit 1
}
