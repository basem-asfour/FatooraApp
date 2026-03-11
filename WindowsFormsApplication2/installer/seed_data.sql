-- =============================================================
-- FatooraApp - Seed Data
-- Run after database and tables are created
-- =============================================================
USE [mostafa_helth];
GO

-- 1. Seed default user
IF NOT EXISTS (SELECT 1 FROM [dbo].[Table_users] WHERE id = N'basem')
BEGIN
    INSERT INTO [dbo].[Table_users] (id, pwd, [full name])
    VALUES (N'basem', N'asfour', N'basem asfour');
    PRINT 'Inserted default user: basem';
END
GO

-- 2. Seed default cash customer (بيع نقدي)
IF NOT EXISTS (SELECT 1 FROM [dbo].[cstmrs] WHERE id_cstmr = 1)
BEGIN
    SET IDENTITY_INSERT [dbo].[cstmrs] ON;
    INSERT INTO [dbo].[cstmrs] (id_cstmr, [اسم العميل], [التليفون], [العنوان], [اقصي حساب سابق], [المندوب])
    VALUES (1, N'بيع نقدي', N'0', N'بيع نقدي', 100000, NULL);
    SET IDENTITY_INSERT [dbo].[cstmrs] OFF;
    PRINT 'Inserted default customer: cash sale';
END
GO

-- 3. Seed systemType (licensed, not demo)
IF NOT EXISTS (SELECT 1 FROM [dbo].[systemType])
BEGIN
    INSERT INTO [dbo].[systemType] (firstDate, avMonth, status, isValid)
    VALUES (GETUTCDATE(), 0, N'licensed', 1);
    PRINT 'Inserted default systemType: licensed';
END
GO

PRINT 'Seed data complete.';
GO
