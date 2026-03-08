-- =============================================================================
-- Serial Selection for Order Support
-- Run this script in SQL Server Management Studio against your database.
-- Requires: product_serials table, order_details.serials column (NVARCHAR(MAX))
-- Compatible with SQL Server 2008+ (uses LIKE instead of STRING_SPLIT).
-- =============================================================================

-- 1. get_available_serials_for_product
-- Returns serials from product_serials that are NOT in any order_details.serials
IF OBJECT_ID('get_available_serials_for_product', 'P') IS NOT NULL
    DROP PROCEDURE get_available_serials_for_product;
GO
CREATE PROCEDURE get_available_serials_for_product
    @product_id INT
AS
    SELECT ps.id, ps.product_id, ps.serial, ps.notes
    FROM product_serials ps
    WHERE ps.product_id = @product_id
    AND NOT EXISTS (
        SELECT 1
        FROM order_details od
        WHERE od.serials IS NOT NULL AND LTRIM(RTRIM(od.serials)) != ''
        AND (',' + LTRIM(RTRIM(od.serials)) + ',') LIKE ('%,' + REPLACE(REPLACE(REPLACE(LTRIM(RTRIM(ps.serial)), '[', '[[]'), '%', '[%]'), '_', '[_]') + ',%')
    )
    ORDER BY ps.id;
GO

-- 2. is_serial_sold
-- Returns 1 if serial exists in any order_details.serials, else 0
IF OBJECT_ID('is_serial_sold', 'P') IS NOT NULL
    DROP PROCEDURE is_serial_sold;
GO
CREATE PROCEDURE is_serial_sold
    @serial NVARCHAR(500)
AS
    DECLARE @serialTrimmed NVARCHAR(500) = LTRIM(RTRIM(@serial));
    DECLARE @pattern NVARCHAR(1000);
    -- Escape LIKE wildcards: [ -> [[]], % -> [%], _ -> [_]
    SET @pattern = '%,' + REPLACE(REPLACE(REPLACE(@serialTrimmed, '[', '[[]'), '%', '[%]'), '_', '[_]') + ',%';

    IF EXISTS (
        SELECT 1
        FROM order_details od
        WHERE od.serials IS NOT NULL AND LTRIM(RTRIM(od.serials)) != ''
        AND (',' + LTRIM(RTRIM(od.serials)) + ',') LIKE @pattern
    )
        SELECT 1 AS is_sold;
    ELSE
        SELECT 0 AS is_sold;
GO
