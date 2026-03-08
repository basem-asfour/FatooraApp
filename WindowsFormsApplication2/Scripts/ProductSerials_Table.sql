-- =============================================================================
-- Product Serials Table and Stored Procedures
-- Run this script in SQL Server Management Studio against your database.
-- Adjust table name 'products' if your schema uses a different name.
-- =============================================================================

-- 1. Create product_serials table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'product_serials')
BEGIN
    CREATE TABLE product_serials (
        id INT IDENTITY(1,1) PRIMARY KEY,
        product_id INT NOT NULL,
        serial NVARCHAR(500) NOT NULL,
        notes NVARCHAR(500) NULL
    );
END

-- 2. Stored procedure: add_product_serial
IF OBJECT_ID('add_product_serial', 'P') IS NOT NULL
    DROP PROCEDURE add_product_serial;
GO
CREATE PROCEDURE add_product_serial
    @product_id INT,
    @serial NVARCHAR(500),
    @notes NVARCHAR(500) = NULL
AS
    INSERT INTO product_serials (product_id, serial, notes)
    VALUES (@product_id, @serial, @notes);
GO

-- 3. Stored procedure: update_product_serial
IF OBJECT_ID('update_product_serial', 'P') IS NOT NULL
    DROP PROCEDURE update_product_serial;
GO
CREATE PROCEDURE update_product_serial
    @id INT,
    @serial NVARCHAR(500),
    @notes NVARCHAR(500) = NULL
AS
    UPDATE product_serials
    SET serial = @serial, notes = @notes
    WHERE id = @id;
GO

-- 4. Stored procedure: delete_product_serial
IF OBJECT_ID('delete_product_serial', 'P') IS NOT NULL
    DROP PROCEDURE delete_product_serial;
GO
CREATE PROCEDURE delete_product_serial
    @id INT
AS
    DELETE FROM product_serials WHERE id = @id;
GO

-- 5. Stored procedure: get_serials_by_product
IF OBJECT_ID('get_serials_by_product', 'P') IS NOT NULL
    DROP PROCEDURE get_serials_by_product;
GO
CREATE PROCEDURE get_serials_by_product
    @product_id INT
AS
    SELECT id, product_id, serial, notes
    FROM product_serials
    WHERE product_id = @product_id
    ORDER BY id;
GO

-- Product IDs that have at least one serial in product_serials (for filtering)
IF OBJECT_ID('get_product_ids_with_serials', 'P') IS NOT NULL
    DROP PROCEDURE get_product_ids_with_serials;
GO
CREATE PROCEDURE get_product_ids_with_serials
AS
    SELECT DISTINCT product_id FROM product_serials;
GO
