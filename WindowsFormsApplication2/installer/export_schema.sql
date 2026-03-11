-- =============================================================
-- Run this script in SSMS against your [mostafa_helth] database
-- It will output the full CREATE TABLE + CREATE PROCEDURE scripts
-- Copy the output (Results tab) and save it as: full_schema.sql
-- =============================================================
-- Switch to text output mode in SSMS: Query > Results To > Results to Text
-- Or press Ctrl+T before running

USE [mostafa_helth];
GO

SET NOCOUNT ON;

-- =============================================
-- PART 1: GENERATE CREATE TABLE STATEMENTS
-- =============================================
PRINT '-- =============================================';
PRINT '-- AUTO-GENERATED SCHEMA EXPORT';
PRINT '-- Database: mostafa_helth';
PRINT '-- Date: ' + CONVERT(VARCHAR, GETDATE(), 120);
PRINT '-- =============================================';
PRINT '';
PRINT '-- Create database with Arabic collation';
PRINT 'IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N''mostafa_helth'')';
PRINT 'BEGIN';
PRINT '    CREATE DATABASE [mostafa_helth] COLLATE Arabic_CI_AS;';
PRINT 'END';
PRINT 'GO';
PRINT 'USE [mostafa_helth];';
PRINT 'GO';
PRINT '';
PRINT '-- Set database collation to Arabic if not already';
PRINT 'IF (SELECT collation_name FROM sys.databases WHERE name = N''mostafa_helth'') <> N''Arabic_CI_AS''';
PRINT 'BEGIN';
PRINT '    ALTER DATABASE [mostafa_helth] COLLATE Arabic_CI_AS;';
PRINT 'END';
PRINT 'GO';
PRINT '';
PRINT '-- =============================================';
PRINT '-- TABLES';
PRINT '-- =============================================';

DECLARE @TableName NVARCHAR(256);
DECLARE @SQL NVARCHAR(MAX);

DECLARE table_cursor CURSOR FOR
SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'dbo'
ORDER BY TABLE_NAME;

OPEN table_cursor;
FETCH NEXT FROM table_cursor INTO @TableName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT '';
    PRINT '-- Table: ' + @TableName;
    PRINT 'IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = ''' + @TableName + ''')';
    PRINT 'BEGIN';

    SET @SQL = '    CREATE TABLE [dbo].[' + @TableName + '] (';
    PRINT @SQL;

    -- Columns
    DECLARE @ColName NVARCHAR(256), @DataType NVARCHAR(256), @MaxLen INT,
            @IsNullable VARCHAR(3), @IsIdentity BIT, @NumPrecision INT, @NumScale INT,
            @ColDefault NVARCHAR(MAX);
    DECLARE @FirstCol BIT = 1;

    DECLARE col_cursor CURSOR FOR
    SELECT
        c.COLUMN_NAME,
        c.DATA_TYPE,
        c.CHARACTER_MAXIMUM_LENGTH,
        c.IS_NULLABLE,
        COLUMNPROPERTY(OBJECT_ID(@TableName), c.COLUMN_NAME, 'IsIdentity'),
        c.NUMERIC_PRECISION,
        c.NUMERIC_SCALE,
        c.COLUMN_DEFAULT
    FROM INFORMATION_SCHEMA.COLUMNS c
    WHERE c.TABLE_NAME = @TableName AND c.TABLE_SCHEMA = 'dbo'
    ORDER BY c.ORDINAL_POSITION;

    OPEN col_cursor;
    FETCH NEXT FROM col_cursor INTO @ColName, @DataType, @MaxLen, @IsNullable, @IsIdentity, @NumPrecision, @NumScale, @ColDefault;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @SQL = '        ';
        IF @FirstCol = 0 SET @SQL = '       ,';
        SET @FirstCol = 0;

        SET @SQL = @SQL + '[' + @ColName + '] ' + UPPER(@DataType);

        -- Add length/precision
        IF @DataType IN ('varchar','nvarchar','char','nchar')
        BEGIN
            IF @MaxLen = -1
                SET @SQL = @SQL + '(MAX)';
            ELSE
                SET @SQL = @SQL + '(' + CAST(@MaxLen AS VARCHAR) + ')';
        END
        ELSE IF @DataType IN ('decimal','numeric')
            SET @SQL = @SQL + '(' + CAST(@NumPrecision AS VARCHAR) + ',' + CAST(@NumScale AS VARCHAR) + ')';
        ELSE IF @DataType IN ('varbinary') AND @MaxLen = -1
            SET @SQL = @SQL + '(MAX)';
        ELSE IF @DataType IN ('varbinary') AND @MaxLen > 0
            SET @SQL = @SQL + '(' + CAST(@MaxLen AS VARCHAR) + ')';

        -- Identity
        IF @IsIdentity = 1
            SET @SQL = @SQL + ' IDENTITY(1,1)';

        -- Nullable
        IF @IsNullable = 'NO'
            SET @SQL = @SQL + ' NOT NULL';
        ELSE
            SET @SQL = @SQL + ' NULL';

        -- Default
        IF @ColDefault IS NOT NULL
            SET @SQL = @SQL + ' DEFAULT ' + @ColDefault;

        PRINT @SQL;

        FETCH NEXT FROM col_cursor INTO @ColName, @DataType, @MaxLen, @IsNullable, @IsIdentity, @NumPrecision, @NumScale, @ColDefault;
    END

    CLOSE col_cursor;
    DEALLOCATE col_cursor;

    -- Primary Key
    DECLARE @PKName NVARCHAR(256), @PKCols NVARCHAR(MAX) = '';
    SELECT @PKName = i.name
    FROM sys.indexes i
    WHERE i.object_id = OBJECT_ID(@TableName) AND i.is_primary_key = 1;

    IF @PKName IS NOT NULL
    BEGIN
        SELECT @PKCols = @PKCols + '[' + COL_NAME(ic.object_id, ic.column_id) + '],'
        FROM sys.index_columns ic
        INNER JOIN sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id
        WHERE i.object_id = OBJECT_ID(@TableName) AND i.is_primary_key = 1
        ORDER BY ic.key_ordinal;

        IF LEN(@PKCols) > 0
        BEGIN
            SET @PKCols = LEFT(@PKCols, LEN(@PKCols) - 1);
            PRINT '       ,CONSTRAINT [' + @PKName + '] PRIMARY KEY (' + @PKCols + ')';
        END
    END

    PRINT '    );';
    PRINT 'END';
    PRINT 'GO';

    FETCH NEXT FROM table_cursor INTO @TableName;
END

CLOSE table_cursor;
DEALLOCATE table_cursor;

-- =============================================
-- PART 2: GENERATE STORED PROCEDURES
-- =============================================
PRINT '';
PRINT '-- =============================================';
PRINT '-- STORED PROCEDURES';
PRINT '-- =============================================';

DECLARE @SPName NVARCHAR(256), @SPDef NVARCHAR(MAX);

DECLARE sp_cursor CURSOR FOR
SELECT name FROM sys.procedures WHERE is_ms_shipped = 0 ORDER BY name;

OPEN sp_cursor;
FETCH NEXT FROM sp_cursor INTO @SPName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT '';
    PRINT '-- Stored Procedure: ' + @SPName;
    PRINT 'IF EXISTS (SELECT * FROM sys.procedures WHERE name = ''' + @SPName + ''')';
    PRINT '    DROP PROCEDURE [dbo].[' + @SPName + '];';
    PRINT 'GO';

    -- Get the SP definition
    SELECT @SPDef = OBJECT_DEFINITION(OBJECT_ID(@SPName));

    IF @SPDef IS NOT NULL
        PRINT @SPDef;
    ELSE
        PRINT '-- WARNING: Could not retrieve definition for ' + @SPName;

    PRINT 'GO';

    FETCH NEXT FROM sp_cursor INTO @SPName;
END

CLOSE sp_cursor;
DEALLOCATE sp_cursor;

PRINT '';
PRINT '-- =============================================';
PRINT '-- EXPORT COMPLETE';
PRINT '-- =============================================';
