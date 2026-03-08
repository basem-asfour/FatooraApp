-- =============================================================================
-- Serial Number Mode - Database Changes
-- Run this script in SQL Server Management Studio against your database.
-- Adjust table names (products, order_details) if your schema uses different names.
-- =============================================================================

-- 1. Add serial_number_mode to products table
--    0 = OnePerProduct (one serial for all pieces)
--    1 = OnePerPiece (unique serial per piece)
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('products') AND name = 'serial_number_mode')
BEGIN
    ALTER TABLE products ADD serial_number_mode TINYINT NOT NULL DEFAULT 0;
END
-- If your products table has a different name, replace 'products' above and below

-- 2. Add serials column to order_details table (for OnePerPiece mode)
--    Stores comma-separated serials: "SN1,SN2,SN3" when qte=3
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('order_details') AND name = 'serials')
BEGIN
    ALTER TABLE order_details ADD serials NVARCHAR(MAX) NULL;
END
-- If your order_details table has a different name, replace 'order_details' above

-- =============================================================================
-- 3. Update stored procedures
-- You must alter your existing SPs to add the new parameters.
-- Get current definitions with: sp_helptext 'add_product' (etc.)
-- Then add the new parameter and column reference.
-- =============================================================================

-- Example for add_product - add @serial_number_mode parameter:
-- ALTER PROCEDURE add_product
--     @nme VARCHAR(50), @qte INT, @pshr VARCHAR(50), @pg VARCHAR(50), @pb VARCHAR(50),
--     @pmsthlk VARCHAR(50), @tmd VARCHAR(50), @img IMAGE, @kind NVARCHAR(50), @store NVARCHAR(100),
--     @serial NVARCHAR(2000), @serial_number_mode TINYINT = 0
-- AS
-- INSERT INTO products (..., serial, serial_number_mode) VALUES (..., @serial, @serial_number_mode);

-- Example for update_product - add @serial_number_mode parameter:
-- ALTER PROCEDURE update_product
--     ...existing params..., @serial NVARCHAR(500), @serial_number_mode TINYINT = 0
-- AS
-- UPDATE products SET ... serial = @serial, serial_number_mode = @serial_number_mode WHERE id = @id;

-- Example for get_all_products - add serial_number_mode to SELECT:
-- Add: , serial_number_mode (or , ISNULL(serial_number_mode, 0) AS serial_number_mode)
-- at the end of your SELECT list so the new column appears as the last column (index 14 in C#).

-- Example for get_prd_by_serial - add serial_number_mode to SELECT:
-- Add: , serial_number_mode (or , ISNULL(serial_number_mode, 0) AS serial_number_mode)
-- at the end of your SELECT list.

-- Example for get_single_product - add serial_number_mode to SELECT:
-- Add: , serial_number_mode (or , ISNULL(serial_number_mode, 0) AS serial_number_mode)
-- at the end of your SELECT list.

-- Example for add_order_details - add @serials parameter:
-- ALTER PROCEDURE add_order_details
--     @id_order INT, @id_product INT, @qte INT, @price VARCHAR(50), @disc FLOAT,
--     @totalp VARCHAR(50), @pmsthlk VARCHAR(50), @msdd VARCHAR(50), @mtbki VARCHAR(50),
--     @serials NVARCHAR(MAX) = NULL
-- AS
-- INSERT INTO order_details (..., serials) VALUES (..., @serials);
