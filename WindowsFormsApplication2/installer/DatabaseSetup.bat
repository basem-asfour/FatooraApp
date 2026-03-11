@echo off
chcp 65001 >nul
echo ============================================
echo   FatooraApp - Database Setup
echo ============================================

REM Start LocalDB instance
echo Starting LocalDB...
sqllocaldb start MSSQLLocalDB 2>nul
if %ERRORLEVEL% neq 0 (
    echo Creating LocalDB instance...
    sqllocaldb create MSSQLLocalDB 2>nul
    sqllocaldb start MSSQLLocalDB
)

REM Wait for instance to be ready
timeout /t 3 /nobreak >nul

REM Run PowerShell script for database setup (sqlcmd is NOT bundled with LocalDB)
echo Running database setup via PowerShell...
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0DatabaseSetup.ps1" -ScriptDir "%~dp0"
if %ERRORLEVEL% neq 0 (
    echo.
    echo ERROR: Database setup failed! Check %~dp0setup_log.txt for details.
    exit /b 1
)

echo.
echo Database setup completed successfully!
exit /b 0
