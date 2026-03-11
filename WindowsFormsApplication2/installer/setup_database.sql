-- =============================================
-- AUTO-GENERATED SCHEMA EXPORT
-- Database: mostafa_helth
-- Date: 2026-03-08 21:56:38
-- =============================================
 
-- Create database with Arabic collation
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'mostafa_helth')
BEGIN
    CREATE DATABASE [mostafa_helth] COLLATE Arabic_CI_AS;
END
GO
USE [mostafa_helth];
GO
 
-- Set database collation to Arabic if not already
IF (SELECT collation_name FROM sys.databases WHERE name = N'mostafa_helth') <> N'Arabic_CI_AS'
BEGIN
    ALTER DATABASE [mostafa_helth] COLLATE Arabic_CI_AS;
END
GO
 
-- =============================================
-- TABLES
-- =============================================
 
-- Table: catogry
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'catogry')
BEGIN
    CREATE TABLE [dbo].[catogry] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[النوع] NVARCHAR(MAX) NULL
       ,CONSTRAINT [PK_catogry] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: corrupted
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'corrupted')
BEGIN
    CREATE TABLE [dbo].[corrupted] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[كود الصنف] INT NULL
       ,[كمية الهالك] INT NULL
       ,[السبب] NVARCHAR(MAX) NULL
       ,[التاريخ] NVARCHAR(50) NULL
       ,CONSTRAINT [PK_corrupted] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: cstmr_pays
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'cstmr_pays')
BEGIN
    CREATE TABLE [dbo].[cstmr_pays] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[كود العميل] INT NULL
       ,[رصيد اول] FLOAT NULL
       ,[المدفوع] FLOAT NULL
       ,[رصيد اخر] FLOAT NULL
       ,[التاريخ] NVARCHAR(50) NULL
       ,[اسم المندوب] NVARCHAR(100) NULL
       ,[نوع العملية] NVARCHAR(50) NULL
       ,[ملاحظات] NVARCHAR(MAX) NULL
       ,CONSTRAINT [PK_cstmr_pays] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: cstmrs
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'cstmrs')
BEGIN
    CREATE TABLE [dbo].[cstmrs] (
        [id_cstmr] INT IDENTITY(1,1) NOT NULL
       ,[اسم العميل] VARCHAR(50) NULL
       ,[التليفون] VARCHAR(50) NULL
       ,[العنوان] VARCHAR(MAX) NULL
       ,[اقصي حساب سابق] FLOAT NULL
       ,[المندوب] NVARCHAR(100) NULL
       ,CONSTRAINT [PK_cstmrs] PRIMARY KEY ([id_cstmr])
    );
END
GO
 
-- Table: cstmrs_fatora_product
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'cstmrs_fatora_product')
BEGIN
    CREATE TABLE [dbo].[cstmrs_fatora_product] (
        [fatora_id] INT NOT NULL
       ,[prd_id] INT NOT NULL
       ,[quantity] INT NULL
       ,[price] FLOAT NULL
       ,CONSTRAINT [PK_cstmrs_fatora_product] PRIMARY KEY ([fatora_id],[prd_id])
    );
END
GO
 
-- Table: cstmrs_mrtg3
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'cstmrs_mrtg3')
BEGIN
    CREATE TABLE [dbo].[cstmrs_mrtg3] (
        [fatora_id] INT IDENTITY(1,1) NOT NULL
       ,[cstmr_id] INT NULL
       ,[total_price] FLOAT NULL DEFAULT ((0))
       ,[timestamp] DATETIME NULL
       ,[الخصم] FLOAT NULL
       ,[نوع الخصم] NVARCHAR(50) NULL
       ,[الاجمالي بعد الخصم] FLOAT NULL
       ,CONSTRAINT [PK_cstmrs_mrtg3] PRIMARY KEY ([fatora_id])
    );
END
GO
 
-- Table: elbank
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'elbank')
BEGIN
    CREATE TABLE [dbo].[elbank] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[النوع] NVARCHAR(50) NULL
       ,[القيمة] VARCHAR(50) NULL
       ,[الوصف] NVARCHAR(50) NULL
       ,[التاريخ] VARCHAR(50) NULL
       ,[رصيد اول] FLOAT NULL
       ,[رصيد اخر] FLOAT NULL
       ,CONSTRAINT [PK_elbank] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: expenses
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'expenses')
BEGIN
    CREATE TABLE [dbo].[expenses] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[النوع] NVARCHAR(50) NULL
       ,[المبلغ] FLOAT NULL
       ,[التفاصيل] NVARCHAR(MAX) NULL
       ,[التاريخ] DATE NULL
       ,CONSTRAINT [PK_expenses] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: fwateer_mwrd
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'fwateer_mwrd')
BEGIN
    CREATE TABLE [dbo].[fwateer_mwrd] (
        [id] INT NOT NULL
       ,[اسم المورد] NVARCHAR(50) NULL
       ,[التاريخ] NVARCHAR(50) NULL
       ,[قيمة الفاتورة] NVARCHAR(50) NULL
       ,[المسدد] NVARCHAR(50) NULL
       ,[المتبقي] NVARCHAR(50) NULL
       ,CONSTRAINT [PK_fwateer_mwrd] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: m5azen
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'm5azen')
BEGIN
    CREATE TABLE [dbo].[m5azen] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[اسم المخزن] NVARCHAR(100) NULL
       ,CONSTRAINT [PK_m5azen] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: md5lat
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'md5lat')
BEGIN
    CREATE TABLE [dbo].[md5lat] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[القيمة] VARCHAR(50) NULL
       ,[التاريخ] VARCHAR(50) NULL
       ,[الوصف] VARCHAR(200) NULL
       ,CONSTRAINT [PK_md5lat] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: mndob
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'mndob')
BEGIN
    CREATE TABLE [dbo].[mndob] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[اسم المندوب] NVARCHAR(100) NULL
       ,[التليفون] NVARCHAR(50) NULL
       ,[الرصيد] FLOAT NULL
       ,CONSTRAINT [PK_mndob] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: mrtg3_mshtriat
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'mrtg3_mshtriat')
BEGIN
    CREATE TABLE [dbo].[mrtg3_mshtriat] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[كود الصنف] INT NULL
       ,[اسم الصنف] NVARCHAR(100) NULL
       ,[الكمية] INT NULL
       ,[السعر] FLOAT NULL
       ,[رقم فاتورة الشراء] INT NULL
       ,[التاريخ] DATE NULL
       ,CONSTRAINT [PK_mrtg3_mshtriat] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: mwrd_pays
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'mwrd_pays')
BEGIN
    CREATE TABLE [dbo].[mwrd_pays] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[كود المورد] INT NULL
       ,[رصيد اول] FLOAT NULL
       ,[المدفوع] FLOAT NULL
       ,[رصيد اخر] FLOAT NULL
       ,[التاريخ] NVARCHAR(50) NULL
       ,[نوع العملية] NVARCHAR(50) NULL
       ,[ملاحظات] NVARCHAR(MAX) NULL
       ,CONSTRAINT [PK_mwrd_pays] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: mwrdeen
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'mwrdeen')
BEGIN
    CREATE TABLE [dbo].[mwrdeen] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[اسم المورد] NVARCHAR(50) NULL
       ,[التليفون] NVARCHAR(50) NULL
       ,[العنوان] NVARCHAR(200) NULL
       ,CONSTRAINT [PK_mwrdeen] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: new_orders
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'new_orders')
BEGIN
    CREATE TABLE [dbo].[new_orders] (
        [id_order] INT NOT NULL
       ,[تاريخ الفاتورة] VARCHAR(50) NULL
       ,[cstmr_id] INT NULL
       ,[المبلغ المسدد] VARCHAR(50) NULL
       ,[المبلغ المتبقي] VARCHAR(50) NULL
       ,[اجمالي الفاتورة] VARCHAR(50) NULL
       ,[صافي الربح] VARCHAR(50) NULL
       ,[كود المندوب] INT NULL
       ,[مصاريف النقل] FLOAT NULL
       ,[ملاحظات] NVARCHAR(MAX) NULL
       ,CONSTRAINT [PK_new_orders] PRIMARY KEY ([id_order])
    );
END
GO
 
-- Table: order_details
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'order_details')
BEGIN
    CREATE TABLE [dbo].[order_details] (
        [رقم الفاتورة] INT NULL
       ,[كود الصنف] INT NULL
       ,[الكميه] INT NULL
       ,[السعر] VARCHAR(50) NULL
       ,[الخصم] FLOAT NULL
       ,[سعر المستهلك] VARCHAR(50) NULL
       ,[السعر الكلي] VARCHAR(50) NULL
       ,[المبلغ المسدد] VARCHAR(50) NULL
       ,[المبلغ المتبقي] VARCHAR(50) NULL
       ,[serials] NVARCHAR(MAX) NULL
    );
END
GO
 
-- Table: orders
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'orders')
BEGIN
    CREATE TABLE [dbo].[orders] (
        [id_order] INT NOT NULL
       ,[تاريخ الفاتورة] DATETIME NULL
       ,[cstmr_id] INT NULL
       ,[البائع] VARCHAR(50) NULL
       ,CONSTRAINT [PK_orders] PRIMARY KEY ([id_order])
    );
END
GO
 
-- Table: prd_first_rseed
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'prd_first_rseed')
BEGIN
    CREATE TABLE [dbo].[prd_first_rseed] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[كود الصنف] INT NULL
       ,[اسم الصنف] NVARCHAR(100) NULL
       ,[الكمية] INT NULL
       ,[السعر] FLOAT NULL
       ,[اجمالي المدفوع] FLOAT NULL
       ,[تاريخ الاضافة] NVARCHAR(50) NULL
       ,CONSTRAINT [PK_prd_first_rseed] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: product_serials
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'product_serials')
BEGIN
    CREATE TABLE [dbo].[product_serials] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[product_id] INT NOT NULL
       ,[serial] NVARCHAR(500) NOT NULL
       ,[notes] NVARCHAR(500) NULL
       ,CONSTRAINT [PK__product___3213E83F9A7868EB] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: products
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'products')
BEGIN
    CREATE TABLE [dbo].[products] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[اسم الصنف] VARCHAR(50) NULL
       ,[الكميه] INT NULL
       ,[سعر الشراء] VARCHAR(50) NULL
       ,[سعر الجمله] VARCHAR(50) NULL
       ,[سعر البيع] VARCHAR(50) NULL
       ,[سعر المستهلك] VARCHAR(50) NULL
       ,[اجمالي المدفوع] VARCHAR(50) NULL
       ,[صوره] IMAGE NULL
       ,[النوع] NVARCHAR(50) NULL
       ,[اسم المورد] NVARCHAR(50) NULL
       ,[رقم فاتورة الشراء] NVARCHAR(50) NULL
       ,[store] NVARCHAR(100) NULL
       ,[deleted] BIT NULL DEFAULT ((0))
       ,[سيريال] NVARCHAR(MAX) NULL
       ,[serial_number_mode] TINYINT NOT NULL DEFAULT ((0))
       ,CONSTRAINT [PK_products] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: purchases
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'purchases')
BEGIN
    CREATE TABLE [dbo].[purchases] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[اسم الصنف] VARCHAR(50) NULL
       ,[الكميه] INT NULL
       ,[سعر الشراء] VARCHAR(50) NULL
       ,[سعر الجمله] VARCHAR(50) NULL
       ,[سعر البيع] VARCHAR(50) NULL
       ,[سعر المستهلك] VARCHAR(50) NULL
       ,[اجمالي المدفوع] VARCHAR(50) NULL
       ,[صوره] IMAGE NULL
       ,[النوع] NVARCHAR(50) NULL
       ,[اسم المورد] NVARCHAR(50) NULL
       ,[رقم فاتورة الشراء] NVARCHAR(50) NULL
       ,[store] NVARCHAR(100) NULL
       ,[deleted] BIT NULL DEFAULT ((0))
       ,CONSTRAINT [PK_purchases] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: systemType
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'systemType')
BEGIN
    CREATE TABLE [dbo].[systemType] (
        [id] INT IDENTITY(1,1) NOT NULL
       ,[firstDate] DATE NULL
       ,[avMonth] INT NULL
       ,[status] NVARCHAR(MAX) NULL
       ,[isValid] BIT NULL DEFAULT ((1))
       ,CONSTRAINT [PK_systemType] PRIMARY KEY ([id])
    );
END
GO
 
-- Table: Table_users
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Table_users')
BEGIN
    CREATE TABLE [dbo].[Table_users] (
        [id] VARCHAR(50) NOT NULL
       ,[pwd] VARCHAR(50) NULL
       ,[full name] VARCHAR(50) NULL
       ,CONSTRAINT [PK_Table_users] PRIMARY KEY ([id])
    );
END
GO
 
-- =============================================
-- STORED PROCEDURES
-- =============================================
 
-- Stored Procedure: ad_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'ad_order')
    DROP PROCEDURE [dbo].[ad_order];
GO
CREATE proc [dbo].[ad_order]
@id_order int,
@order_date datetime,
@cstmr_id int,
@saleman varchar(50)

as
INSERT INTO [dbo].[orders]
           ([id_order]
           ,[تاريخ الفاتورة]
           ,[cstmr_id]
           ,[البائع])
     VALUES
           
		  ( @id_order,
		   @order_date,
		   @cstmr_id,
		   @saleman)

GO
 
-- Stored Procedure: add_catogry
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_catogry')
    DROP PROCEDURE [dbo].[add_catogry];
GO
CREATE proc [dbo].[add_catogry]
@name nvarchar(200)
as

INSERT INTO [dbo].[catogry]
           ([النوع])
     VALUES
           (@name)
GO
 
-- Stored Procedure: add_corrupted_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_corrupted_product')
    DROP PROCEDURE [dbo].[add_corrupted_product];
GO
CREATE proc add_corrupted_product
@prd_id int ,
@qte int ,
@reason nvarchar(500),
@dte nvarchar(50)
as
INSERT INTO [dbo].[corrupted]
           ([كود الصنف]
           ,[كمية الهالك]
           ,[السبب]
           ,[التاريخ])
     VALUES
           (@prd_id,
    	   @qte ,
		   @reason,
		   @dte )
GO
 
-- Stored Procedure: add_cstmr
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_cstmr')
    DROP PROCEDURE [dbo].[add_cstmr];
GO
CREATE proc [dbo].[add_cstmr]
@nme varchar(50),
@phone int,
@adress varchar(50),
@max float,
@mndb nvarchar(100)
as


INSERT INTO [dbo].[cstmrs]
           ([اسم العميل]
           ,[التليفون]
           ,[العنوان]
		   ,[اقصي حساب سابق]
		   ,المندوب)
values
(@nme,
@phone,
@adress,
@max,
@mndb)


GO
 
-- Stored Procedure: add_cstmr_fatora
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_cstmr_fatora')
    DROP PROCEDURE [dbo].[add_cstmr_fatora];
GO
create proc [dbo].[add_cstmr_fatora]
@cstmr_id int,
@timastamp datetime
as

INSERT INTO [dbo].[cstmrs_mrtg3]
           ([cstmr_id]
           ,[timestamp])
     VALUES
(@cstmr_id,
@timastamp)

GO
 
-- Stored Procedure: add_cstmr_pay
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_cstmr_pay')
    DROP PROCEDURE [dbo].[add_cstmr_pay];
GO
CREATE proc [dbo].[add_cstmr_pay]
@cstmr_id int,
@first_rseed float,
@mdfo3 float,
@last_rseed float,
@dte nvarchar(50),
@mndb_nme nvarchar(100),
@type nvarchar(50),
@notes nvarchar(max)
as

INSERT INTO [dbo].[cstmr_pays]
           ([كود العميل]
           ,[رصيد اول]
           ,[المدفوع]
           ,[رصيد اخر]
           ,[التاريخ]
		   ,[اسم المندوب]
		   ,[نوع العملية]
		   ,[ملاحظات])
     VALUES
           (@cstmr_id ,
		   @first_rseed,
		   @mdfo3 ,
		   @last_rseed,
		   @dte,
		   @mndb_nme ,
		   @type,
		   @notes)
GO
 
-- Stored Procedure: add_elbank
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_elbank')
    DROP PROCEDURE [dbo].[add_elbank];
GO
CREATE proc [dbo].[add_elbank]
@type nvarchar(50),
@first float,
@value varchar(50),
@last float,
@dscrpshn nvarchar(50),
@date varchar(50)

as


INSERT INTO [dbo].[elbank]
           ([النوع]
		   ,[رصيد اول]
           ,[القيمة]
		   ,[رصيد اخر]
           ,[الوصف]
           ,[التاريخ])
     VALUES
           
		  ( @type ,
		  @first,
		@value,
		@last,
		@dscrpshn ,
		@date )
GO
 
-- Stored Procedure: add_expenses
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_expenses')
    DROP PROCEDURE [dbo].[add_expenses];
GO
create proc add_expenses
@type nvarchar(50),
@cach float,
@details nvarchar(max),
@dte date
as

INSERT INTO [dbo].[expenses]
           ([النوع]
           ,[المبلغ]
           ,[التفاصيل]
           ,[التاريخ])
     VALUES
           (@type,
		   @cach,
		   @details,
		   @dte)

GO
 
-- Stored Procedure: add_fwateer_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_fwateer_mwrd')
    DROP PROCEDURE [dbo].[add_fwateer_mwrd];
GO
CREATE proc [dbo].[add_fwateer_mwrd]
@id int,
@nme nvarchar(50),
@date nvarchar(50),
@value nvarchar(50),
@msdd nvarchar(50),
@mtbaki nvarchar(50)

as 

INSERT INTO [dbo].[fwateer_mwrd]
           (id,
		   [اسم المورد]
           ,[التاريخ]
           ,[قيمة الفاتورة]
		   ,المسدد
		   ,المتبقي)
     VALUES
           (@id,
		   @nme,
		   @date,
		   @value,
		   @msdd,
		   @mtbaki)

GO
 
-- Stored Procedure: add_m5zn
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_m5zn')
    DROP PROCEDURE [dbo].[add_m5zn];
GO
create proc add_m5zn
@nme nvarchar(100)
as

INSERT INTO [dbo].[m5azen]
           ([اسم المخزن])
     VALUES
           (@nme)
GO
 
-- Stored Procedure: add_md5al
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_md5al')
    DROP PROCEDURE [dbo].[add_md5al];
GO
CREATE proc [dbo].[add_md5al]
@value varchar(50),
@date varchar(50),
@dskrpshn varchar(200)
as

INSERT INTO [dbo].[md5lat]
           ([القيمة]
           ,[التاريخ]
           ,[الوصف])
     VALUES
	( @value
	 ,@date
	 ,@dskrpshn)
GO
 
-- Stored Procedure: add_mndoob
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_mndoob')
    DROP PROCEDURE [dbo].[add_mndoob];
GO
create proc add_mndoob
@nme nvarchar(100),
@phone nvarchar(50),
@rseed float
as

INSERT INTO [dbo].[mndob]
           ([اسم المندوب]
           ,[التليفون]
           ,[الرصيد])
     VALUES
           (@nme,@phone,@rseed)
GO
 
-- Stored Procedure: add_mrtg3_mshtriat
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_mrtg3_mshtriat')
    DROP PROCEDURE [dbo].[add_mrtg3_mshtriat];
GO
CREATE proc add_mrtg3_mshtriat
@prd_id int,
@nme nvarchar(100),
@qte int,
@price float,
@fatora_id int ,
@dte date
as
INSERT INTO [dbo].[mrtg3_mshtriat]
           ([كود الصنف]
           ,[اسم الصنف]
           ,[الكمية]
           ,[السعر]
           ,[رقم فاتورة الشراء]
           ,[التاريخ])
     VALUES
           (@prd_id,
			@nme,
			@qte ,
			@price ,
			@fatora_id  ,
			@dte)
GO
 
-- Stored Procedure: add_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_mwrd')
    DROP PROCEDURE [dbo].[add_mwrd];
GO
create proc [dbo].[add_mwrd]
@nme nvarchar(50),
@phone nvarchar(50),
@adress nvarchar(50)

as

INSERT INTO [dbo].[mwrdeen]
           ([اسم المورد]
           ,[التليفون]
           ,[العنوان])
     VALUES
           (@nme,
		   @phone,
		   @adress)



GO
 
-- Stored Procedure: add_mwrd_pays
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_mwrd_pays')
    DROP PROCEDURE [dbo].[add_mwrd_pays];
GO
CREATE proc [dbo].[add_mwrd_pays]
@mwrd_id int,
@first_rseed float,
@payed float,
@last_rseed float,
@dte nvarchar(50),
@kind nvarchar(50),
@notes nvarchar(max)

as

INSERT INTO [dbo].[mwrd_pays]
           ([كود المورد]
           ,[رصيد اول]
           ,[المدفوع]
           ,[رصيد اخر]
           ,[التاريخ]
		   ,[نوع العملية]
		   ,[ملاحظات])
     VALUES
          
		 (@mwrd_id,
		  @first_rseed,
		  @payed,
		  @last_rseed,
		  @dte,
		  @kind,
		  @notes)

GO
 
-- Stored Procedure: add_order_details
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_order_details')
    DROP PROCEDURE [dbo].[add_order_details];
GO
CREATE proc [dbo].[add_order_details]
@id_order int,
@id_product int,
@qte int,
@price varchar(50),
@disc float,
@pmsthlk varchar(50),
@totalp varchar(50),
@msdd varchar(50),
@mtbki varchar(50),
@serials NVARCHAR(MAX) = NULL
as


INSERT INTO [dbo].[order_details]
           ([رقم الفاتورة]
           ,[كود الصنف]
           ,[الكميه]
           ,[السعر]
           ,[الخصم]
		   ,[سعر المستهلك]
           ,[السعر الكلي]
           ,[المبلغ المسدد]
           ,[المبلغ المتبقي]
		   ,serials)
     VALUES
           
		 ( @id_order
			,@id_product 
			,@qte
			,@price
			,@disc
			,@pmsthlk
			,@totalp
			,@msdd
			,@mtbki
			,@serials)

update products set الكميه=الكميه-@qte --,[اجمالي المدفوع]=[اجمالي المدفوع]-(@qte*[سعر الشراء])
where id=@id_product

GO
 
-- Stored Procedure: add_prd_first_rseed
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_prd_first_rseed')
    DROP PROCEDURE [dbo].[add_prd_first_rseed];
GO
create proc add_prd_first_rseed
@prd_id int,
@prd_nme nvarchar(100),
@qte int ,
@price float,
@toal_mdfo3 float,
@dte nvarchar(50)
as

INSERT INTO [dbo].[prd_first_rseed]
           ([كود الصنف]
           ,[اسم الصنف]
           ,[الكمية]
           ,[السعر]
           ,[اجمالي المدفوع]
           ,[تاريخ الاضافة])
     VALUES
          ( @prd_id ,
		   @prd_nme ,
		   @qte ,
		   @price ,
		   @toal_mdfo3,
		   @dte )
GO
 
-- Stored Procedure: add_preExist_prd_to_cstmr_fatora
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_preExist_prd_to_cstmr_fatora')
    DROP PROCEDURE [dbo].[add_preExist_prd_to_cstmr_fatora];
GO
CREATE proc [dbo].[add_preExist_prd_to_cstmr_fatora]
@prd_id int ,
@price float,
@quantity int,
@cstmr_id int,
@dte date
as
begin
declare @fatora_id int
set @fatora_id=(select fatora_id from cstmrs_mrtg3 where cstmr_id=@cstmr_id and convert(date,timestamp)=@dte)

update products 
set 
[سعر الشراء]=((convert(float,[سعر الشراء])*الكميه)+(@price*@quantity))/(@quantity+الكميه),
الكميه= الكميه+@quantity,
[اجمالي المدفوع]=(convert(float,[اجمالي المدفوع])+(@price*@quantity))
where id=@prd_id

if @fatora_id is not null
	begin

	update cstmrs_mrtg3
	set total_price=total_price+(@quantity*@price)
	where fatora_id=@fatora_id --(select MAX(fatora_id)from cstmrs_mrtg3)

	INSERT INTO [dbo].[cstmrs_fatora_product]
			   ([fatora_id]
			   ,[prd_id]
			   ,[quantity]
			   ,[price])
		 VALUES
			   (@fatora_id,--(select max(fatora_id)from cstmrs_mrtg3),
			   @prd_id,
			   @quantity,
			   @price)
	end
else
	begin

		INSERT INTO [dbo].[cstmrs_mrtg3]
				   ([cstmr_id]
				   ,[timestamp])
			 VALUES
					(@cstmr_id,
					@dte)

			update cstmrs_mrtg3
	set total_price=total_price+(@quantity*@price)
	where fatora_id=(select MAX(fatora_id)from cstmrs_mrtg3)

	INSERT INTO [dbo].[cstmrs_fatora_product]
			   ([fatora_id]
			   ,[prd_id]
			   ,[quantity]
			   ,[price])
		 VALUES
			   ((select max(fatora_id)from cstmrs_mrtg3),
			   @prd_id,
			   @quantity,
			   @price)


	end
		   
end
--update new_orders 
--set [المبلغ المسدد]=isnull(convert(float,[المبلغ المسدد]),0) +(select total_price from cstmrs_mrtg3 where fatora_id= (select MAX(fatora_id)from cstmrs_mrtg3)),
--[المبلغ المتبقي]=isnull(convert(float,[المبلغ المتبقي]),0)-(select total_price from cstmrs_mrtg3 where fatora_id= (select MAX(fatora_id)from cstmrs_mrtg3))
--where id_order= ( select max(id_order) from new_orders
--where  cstmr_id=(select cstmr_id from cstmrs_mrtg3 where fatora_id=(select MAX(fatora_id)from cstmrs_mrtg3)))
---- and cstmr_id=(select cstmr_id from cstmrs_mrtg3 where fatora_id=(select MAX(fatora_id)from cstmrs_mrtg3))

--update order_details 
--set [المبلغ المسدد]=isnull(convert(float,[المبلغ المسدد]),0) +(select total_price from cstmrs_mrtg3 where fatora_id= (select MAX(fatora_id)from cstmrs_mrtg3)),
--[المبلغ المتبقي]=isnull(convert(float,[المبلغ المتبقي]),0)-(select total_price from cstmrs_mrtg3 where fatora_id= (select MAX(fatora_id)from cstmrs_mrtg3))

--where [رقم الفاتورة]= ( select max(id_order) from new_orders
--where  cstmr_id=(select cstmr_id from cstmrs_mrtg3 where fatora_id=(select MAX(fatora_id)from cstmrs_mrtg3)))
 



GO
 
-- Stored Procedure: add_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_product')
    DROP PROCEDURE [dbo].[add_product];
GO
CREATE proc [dbo].[add_product]

@nme varchar(50),
@qte int,
@pshr varchar(50),
@pg varchar(50),
@pb varchar(50),
@pmsthlk varchar(50),
@tmd varchar(50),
@img image,
@kind nvarchar(50),
@store nvarchar(100),
  @serial NVARCHAR(2000), @serial_number_mode TINYINT = 0
  as 


INSERT INTO [dbo].[products]
           ([اسم الصنف]
           ,[الكميه]
           ,[سعر الشراء]
           ,[سعر الجمله]
		   ,[سعر البيع]
		   ,[سعر المستهلك]
           ,[اجمالي المدفوع]
           ,[صوره]
		   ,النوع
		   ,deleted
		   ,store,
		   [سيريال],
           serial_number_mode)
     VALUES
           (@nme
           ,@qte
		   ,@pshr
           ,@pg
           ,@pb
		   ,@pmsthlk
           ,@tmd
           ,@img
		   ,@kind
		   ,0
		   ,@store
		   ,@serial, @serial_number_mode)


GO
 
-- Stored Procedure: add_product_serial
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_product_serial')
    DROP PROCEDURE [dbo].[add_product_serial];
GO
CREATE PROCEDURE add_product_serial
    @product_id INT,
    @serial NVARCHAR(500),
    @notes NVARCHAR(500) = NULL
AS
    INSERT INTO product_serials (product_id, serial, notes)
    VALUES (@product_id, @serial, @notes);
GO
 
-- Stored Procedure: add_product_to_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_product_to_order')
    DROP PROCEDURE [dbo].[add_product_to_order];
GO
CREATE proc [dbo].[add_product_to_order]
@id_order varchar(50),
@prd_id int,
@qte int,
@price varchar(50),
@disc float(50),
@price_msthlk varchar(50),
@totl_price varchar(50),
@price_msdd varchar(50),
@price_mtpkii varchar(50)
as 
--بيزود الكميات تاني وبعدين يمسح الفاتورة القديمه ويدخل الفاتوره الجديده بنفس الرقم باضافه الصنف الجديد ضمن الاصناف القديمه 

INSERT INTO [dbo].[order_details]
           ([رقم الفاتورة]
           ,[كود الصنف]
           ,[الكميه]
           ,[السعر]
           ,[الخصم]
		   ,[سعر المستهلك]
           ,[السعر الكلي]
           ,[المبلغ المسدد]
           ,[المبلغ المتبقي])
     VALUES
           
		 ( @id_order
			,@prd_id 
			,@qte
			,@price
			,@disc
			,@price_msthlk
			,@totl_price
			,@price_msdd
			,@price_mtpkii )

update products set الكميه=الكميه-@qte --,[اجمالي المدفوع]=[اجمالي المدفوع]-(@qte*[سعر الشراء])
where id=@prd_id





GO
 
-- Stored Procedure: add_product_with_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_product_with_mwrd')
    DROP PROCEDURE [dbo].[add_product_with_mwrd];
GO

CREATE proc [dbo].[add_product_with_mwrd]

@nme varchar(50),
@qte int,
@pshr varchar(50),
@pg varchar(50),
@pb varchar(50),
@pmsthlk varchar(50),
@tmd varchar(50),
@img image,
@kind nvarchar(50),
@mwrd_name nvarchar(50),
@id_order nvarchar(50),
@store nvarchar(100)
as 


INSERT INTO [dbo].[products]
           ([اسم الصنف]
           ,[الكميه ]
           ,[سعر الشراء]
           ,[سعر الجمله]
		   ,[سعر البيع]
		   ,[سعر المستهلك]
           ,[اجمالي المدفوع]
           ,[صوره]
		   ,النوع
		   ,[اسم المورد]
		   ,[رقم فاتورة الشراء]
		   ,deleted
		   ,store)
		   
     VALUES
           (@nme
           ,@qte
		   ,@pshr
           ,@pg
           ,@pb
		   ,@pmsthlk
           ,@tmd
           ,@img
		   ,@kind
		   ,@mwrd_name
		   ,@id_order
		   ,0
		   ,@store)

GO
 
-- Stored Procedure: add_purshase
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_purshase')
    DROP PROCEDURE [dbo].[add_purshase];
GO
CREATE proc [dbo].[add_purshase]
@nme varchar(50),
@qte int,
@pshr varchar(50),
@pg varchar(50),
@pb varchar(50),
@pmsthlk varchar(50),
@tmd varchar(50),
@img image,
@kind nvarchar(50),
@mwrd_name nvarchar(50),
@id_order nvarchar(50),
@store nvarchar(100)
as 

INSERT INTO [dbo].[purchases]
           ([اسم الصنف]
           ,[الكميه]
           ,[سعر الشراء]
           ,[سعر الجمله]
           ,[سعر البيع]
           ,[سعر المستهلك]
           ,[اجمالي المدفوع]
           ,[صوره]
           ,[النوع]
           ,[اسم المورد]
           ,[رقم فاتورة الشراء]
		   ,[deleted]
           ,[store]
           )
     VALUES
          (@nme
           ,@qte
		   ,@pshr
           ,@pg
           ,@pb
		   ,@pmsthlk
           ,@tmd
           ,@img
		   ,@kind
		   ,@mwrd_name
		   ,@id_order
		   ,0
		   ,@store)


GO
 
-- Stored Procedure: add_system_type
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_system_type')
    DROP PROCEDURE [dbo].[add_system_type];
GO
CREATE proc add_system_type
@firstDate date,
@months int,
@status nvarchar(50),
@isValid bit
as
INSERT INTO [dbo].[systemType]
           ([firstDate]
           ,[avMonth]
           ,[status]
		   ,[isValid])
     VALUES
           (@firstDate,@months,@status,@isValid)
GO
 
-- Stored Procedure: add_to_new_orders
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_to_new_orders')
    DROP PROCEDURE [dbo].[add_to_new_orders];
GO
CREATE proc [dbo].[add_to_new_orders]
@id_order int,
@order_date varchar(50),
@cstmr_id int,
@msdd varchar(50),
@mtpakii varchar(50),
@total varchar(50),
@mksab varchar(50),
@mndb_id int,
@transport float,
@notes nvarchar(max)
as
/*
--نظرا لتوفير الوقت فعدلت عليه وخلاص
update new_orders
set [صافي الربح]=@mksab
where id_order=@id_order
*/
INSERT INTO [dbo].[new_orders]
           ([id_order]
           ,[تاريخ الفاتورة]
           ,[cstmr_id]
           ,[المبلغ المسدد]
           ,[المبلغ المتبقي]
           ,[اجمالي الفاتورة]
		   ,[صافي الربح]
		   ,[كود المندوب]
		   ,[مصاريف النقل]
		   ,ملاحظات)




     VALUES
           
		  ( @id_order,
		   @order_date,
		   @cstmr_id,
		   @msdd,
		   @mtpakii,
		   @total,
		   @mksab,
		   @mndb_id,
		   @transport,
		   @notes)
GO
 
-- Stored Procedure: add_users
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'add_users')
    DROP PROCEDURE [dbo].[add_users];
GO
create proc [dbo].[add_users]
@id varchar(50),
@pwd varchar(50),
@totalnme varchar(50)
as 

INSERT INTO [dbo].[Table_users]
           ([id]
           ,[pwd]
           ,[full name])
     VALUES
           (@id
		   ,@pwd
		   ,@totalnme)


GO
 
-- Stored Procedure: after_add_notExist_prd_to_cstmr_fatora
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'after_add_notExist_prd_to_cstmr_fatora')
    DROP PROCEDURE [dbo].[after_add_notExist_prd_to_cstmr_fatora];
GO
create proc after_add_notExist_prd_to_cstmr_fatora
--@prd_id int ,
@price float,
@quantity int,
@cstmr_id int,
@dte date
as
begin
declare @fatora_id int ,@prd_id int
set @fatora_id=(select fatora_id from cstmrs_mrtg3 where cstmr_id=@cstmr_id and convert(date,timestamp)=@dte)
set @prd_id=(select max(id)from products)

if @fatora_id is not null
	begin

	update cstmrs_mrtg3
	set total_price=total_price+(@quantity*@price)
	where fatora_id=@fatora_id --(select MAX(fatora_id)from cstmrs_mrtg3)

	INSERT INTO [dbo].[cstmrs_fatora_product]
			   ([fatora_id]
			   ,[prd_id]
			   ,[quantity]
			   ,[price])
		 VALUES
			   (@fatora_id,--(select max(fatora_id)from cstmrs_mrtg3),
			   @prd_id,
			   @quantity,
			   @price)
	end
else
	begin

		INSERT INTO [dbo].[cstmrs_mrtg3]
				   ([cstmr_id]
				   ,[timestamp])
			 VALUES
					(@cstmr_id,
					@dte)

			update cstmrs_mrtg3
	set total_price=total_price+(@quantity*@price)
	where fatora_id=(select MAX(fatora_id)from cstmrs_mrtg3)

	INSERT INTO [dbo].[cstmrs_fatora_product]
			   ([fatora_id]
			   ,[prd_id]
			   ,[quantity]
			   ,[price])
		 VALUES
			   ((select max(fatora_id)from cstmrs_mrtg3),
			   @prd_id,
			   @quantity,
			   @price)


	end
		   
end
GO
 
-- Stored Procedure: after_delete_mrtg3_mbe3at
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'after_delete_mrtg3_mbe3at')
    DROP PROCEDURE [dbo].[after_delete_mrtg3_mbe3at];
GO
CREATE proc [dbo].[after_delete_mrtg3_mbe3at]
@prd_id int,
@fatora_id int
as 
update products
set [الكميه] =[الكميه]-(select quantity from cstmrs_fatora_product where prd_id=@prd_id and fatora_id=@fatora_id)
where id=@prd_id
GO
 
-- Stored Procedure: avoid_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'avoid_order')
    DROP PROCEDURE [dbo].[avoid_order];
GO
CREATE proc [dbo].[avoid_order]
@id varchar(50)

as

DELETE FROM [dbo].[orders]
      WHERE id_order=@id
	  --تعديل
	  delete from order_details
	  where [رقم الفاتورة]=@id

	  delete from new_orders
	  where id_order=@id



--SELECT [رقم الفاتورة]
     --,[كود الصنف]
	-- ,الكميه
 --FROM [dbo].[order_details]
--where order_details.[رقم الفاتورة]=@id



--update products
--set الكميه=الكميه+order_details.الكميه
--where products.id=order_details.[كود الصنف]



GO
 
-- Stored Procedure: avoid_prduct_from_specific_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'avoid_prduct_from_specific_order')
    DROP PROCEDURE [dbo].[avoid_prduct_from_specific_order];
GO
CREATE proc [dbo].[avoid_prduct_from_specific_order]
@custmer_id int,
@order_id int,
@product_id int,
@quantity int 
as 

update products 
set 
الكميه= الكميه+@quantity,
[اجمالي المدفوع]=(convert(float,[اجمالي المدفوع])+(convert(float,[سعر الشراء])*@quantity))
where id=@product_id 

--update new_orders
--set
--[اجمالي الفاتورة]=[اجمالي الفاتورة]-((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity)),
--[صافي الربح]=[صافي الربح]-((((select السعر from order_details where [كود الصنف]=@product_id and [رقم الفاتورة]=@order_id)-(convert(float,(select [سعر الشراء] from products where id=@product_id)))*@quantity)))
--where id_order= @order_id

--update new_orders 
--set [المبلغ المسدد]=isnull(convert(float,[المبلغ المسدد]),0) +((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity)),
--[المبلغ المتبقي]=isnull(convert(float,[المبلغ المتبقي]),0)-((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity))
--where id_order= ( select max(id_order) from new_orders where  cstmr_id=@custmer_id)

--update order_details 
--set [المبلغ المسدد]=isnull(convert(float,[المبلغ المسدد]),0) +((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity)),
--[المبلغ المتبقي]=isnull(convert(float,[المبلغ المتبقي]),0)-((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity))

--where [رقم الفاتورة]= ( select max(id_order) from new_orders
--where  cstmr_id=@custmer_id)

--	DELETE FROM [dbo].[order_details]
--	  WHERE [كود الصنف]=@product_id and [رقم الفاتورة]=@order_id
GO
 
-- Stored Procedure: avoid_prduct_from_specific_order_notall_qnt
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'avoid_prduct_from_specific_order_notall_qnt')
    DROP PROCEDURE [dbo].[avoid_prduct_from_specific_order_notall_qnt];
GO
CREATE proc [dbo].[avoid_prduct_from_specific_order_notall_qnt]
@custmer_id int,
@order_id int,
@product_id int,
@quantity int 
as 

update products 
set 
الكميه= الكميه+@quantity,
[اجمالي المدفوع]=(convert(float,[اجمالي المدفوع])+(convert(float,[سعر الشراء])*@quantity))
where id=@product_id 

--update new_orders
--set
--[اجمالي الفاتورة]=[اجمالي الفاتورة]-((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity)),
--[صافي الربح]=[صافي الربح]-((((select السعر from order_details where [كود الصنف]=@product_id and [رقم الفاتورة]=@order_id)-(convert(float,(select [سعر الشراء] from products where id=@product_id)))*@quantity)))
--where id_order= @order_id

--update new_orders 
--set [المبلغ المسدد]=isnull(convert(float,[المبلغ المسدد]),0) +((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity)),
--[المبلغ المتبقي]=isnull(convert(float,[المبلغ المتبقي]),0)-((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity))
--where id_order= ( select max(id_order) from new_orders where  cstmr_id=@custmer_id)

--update order_details 
--set [المبلغ المسدد]=isnull(convert(float,[المبلغ المسدد]),0) +((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity)),
--[المبلغ المتبقي]=isnull(convert(float,[المبلغ المتبقي]),0)-((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity))

--where [رقم الفاتورة]= ( select max(id_order) from new_orders
--where  cstmr_id=@custmer_id)


-- update order_details 
--  set الكميه=الكميه-@quantity,
--  [السعر الكلي]= CONVERT(float,[السعر الكلي]) -((convert(float,(select[سعر الشراء] from products where id=@product_id))*@quantity))

--  WHERE [كود الصنف]=@product_id and [رقم الفاتورة]=@order_id


GO
 
-- Stored Procedure: change_cstmr
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'change_cstmr')
    DROP PROCEDURE [dbo].[change_cstmr];
GO
create proc [dbo].[change_cstmr]
@order_id int,
@cstmr_id int
as
update orders
set orders.cstmr_id=@cstmr_id
where orders.id_order=@order_id
GO
 
-- Stored Procedure: change_store
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'change_store')
    DROP PROCEDURE [dbo].[change_store];
GO
CREATE proc [dbo].[change_store]
@prd_id int,
@store_id int,
@qte int
as
begin
declare @prd_num int ,@prd_name varchar(50) , @price_shr varchar(50),@price_gmla varchar(50),
@price_pee3 varchar(50),@price_msthlk nvarchar(50),@total_mdfo3 varchar(50),
--@pic image,
@kind varchar(50),@mwrd_nme varchar(50),@fatora_num varchar(50)

set @prd_num =(select COUNT(*) from products where store =(
			select [اسم المخزن] from m5azen where m5azen.id=@store_id)
			and products.[اسم الصنف]=(select [اسم الصنف] from products where id=@prd_id))

declare @new_prd_id int
set @new_prd_id=(select MAX(id) from products where store =(
				select [اسم المخزن] from m5azen where m5azen.id=@store_id)
				and products.[اسم الصنف]=(select [اسم الصنف] from products where id=@prd_id))

set @prd_name=(select [اسم الصنف] from products where id=@prd_id)
set @price_shr=(select [سعر الشراء] from products where id=@prd_id)
set @price_gmla=(select [سعر الجمله] from products where id=@prd_id)
set @price_pee3=(select [سعر البيع] from products where id=@prd_id)
set @price_msthlk=(select [سعر المستهلك] from products where id=@prd_id)
set @total_mdfo3=(convert(float,@price_shr)*@qte)-----------------
--set @pic=(select صوره from products where id=@prd_id)
set @kind =(select النوع from products where id=@prd_id)
set @mwrd_nme=(select [اسم المورد] from products where id=@prd_id)
set @fatora_num=(select [رقم فاتورة الشراء] from products where id=@prd_id)

if (@prd_num=0)

begin
	INSERT INTO [dbo].[products]
			   ([اسم الصنف]
			   ,[الكميه]
			   ,[سعر الشراء]
			   ,[سعر الجمله]
			   ,[سعر البيع]
			   ,[سعر المستهلك]
			   ,[اجمالي المدفوع]
			   ,[صوره]
			   ,[النوع]
			   ,[اسم المورد]
			   ,[رقم فاتورة الشراء]
			   ,[store]
			   ,[deleted])
		 VALUES
			   (
				 @prd_name,
				 @qte,
				 @price_shr,
				 @price_gmla,
				 @price_pee3,
				 @price_msthlk,
				 @total_mdfo3,
				 (select صوره from products where id=@prd_id),
				 @kind,
				 @mwrd_nme,
				 @fatora_num,
				 (select [اسم المخزن] from m5azen where m5azen.id=@store_id),
				 0
			   )

	update products 
	set الكميه= الكميه-@qte,
	 [اجمالي المدفوع] =convert(nvarchar(50), convert(float,[اجمالي المدفوع])-convert(float,@total_mdfo3))
	where id=@prd_id

end

else if (@prd_num<>0)

begin
	
	
	update products 
	set الكميه= الكميه+@qte,
	 [اجمالي المدفوع] =convert(nvarchar(50), convert(float,[اجمالي المدفوع])+convert(float,@total_mdfo3))
	where id=@new_prd_id


	update products 
	set الكميه= الكميه-@qte,
	 [اجمالي المدفوع] =convert(nvarchar(50), convert(float,[اجمالي المدفوع])-convert(float,@total_mdfo3))
	where id=@prd_id
end

end
GO
 
-- Stored Procedure: delete_bank
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_bank')
    DROP PROCEDURE [dbo].[delete_bank];
GO
create proc [dbo].[delete_bank]
@id int
as
delete from elbank
where id=@id
GO
 
-- Stored Procedure: delete_catogry
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_catogry')
    DROP PROCEDURE [dbo].[delete_catogry];
GO
create proc delete_catogry
@id int
as

delete from catogry
where id =@id

GO
 
-- Stored Procedure: delete_corrupted_prd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_corrupted_prd')
    DROP PROCEDURE [dbo].[delete_corrupted_prd];
GO
CREATE proc delete_corrupted_prd
@id int
as

update products
set الكميه=الكميه+(select c.[كمية الهالك] from corrupted c where id=@id),
	[اجمالي المدفوع]=CONVERT(float, [اجمالي المدفوع])+((select c.[كمية الهالك] from corrupted c where id=@id)*convert(float,[سعر الشراء]))

	where id=(select c.[كود الصنف] from corrupted c where id=@id)


DELETE FROM [dbo].[corrupted]
      WHERE id=@id


GO
 
-- Stored Procedure: delete_cstmr
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_cstmr')
    DROP PROCEDURE [dbo].[delete_cstmr];
GO
create proc [dbo].[delete_cstmr]
@id varchar(50)
as

DELETE FROM [dbo].[cstmrs]
      WHERE  convert(varchar(50),id_cstmr)=@id



GO
 
-- Stored Procedure: delete_cstmr_fatora
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_cstmr_fatora')
    DROP PROCEDURE [dbo].[delete_cstmr_fatora];
GO
create proc delete_cstmr_fatora
@id int
as delete from cstmrs_mrtg3
where fatora_id=@id
GO
 
-- Stored Procedure: delete_cstmr_fatora_with_products
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_cstmr_fatora_with_products')
    DROP PROCEDURE [dbo].[delete_cstmr_fatora_with_products];
GO
create proc delete_cstmr_fatora_with_products
@id int
as delete from cstmrs_mrtg3
where fatora_id=@id

delete from cstmrs_fatora_product
where fatora_id=@id
GO
 
-- Stored Procedure: delete_cstmr_pay
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_cstmr_pay')
    DROP PROCEDURE [dbo].[delete_cstmr_pay];
GO
create proc delete_cstmr_pay
@id int
as

DELETE FROM [dbo].[cstmr_pays]
      WHERE id=@id
GO
 
-- Stored Procedure: delete_expenses
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_expenses')
    DROP PROCEDURE [dbo].[delete_expenses];
GO
create proc delete_expenses
@id int
as
DELETE FROM [dbo].[expenses]
      WHERE id=@id
GO
 
-- Stored Procedure: delete_fwateer_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_fwateer_mwrd')
    DROP PROCEDURE [dbo].[delete_fwateer_mwrd];
GO
CREATE proc [dbo].[delete_fwateer_mwrd]
@id int
as

DELETE FROM [dbo].[fwateer_mwrd]
      WHERE id=@id

	  update  products 
	  set الكميه=الكميه-(select الكميه from purchases pr where [رقم فاتورة الشراء]=@id and pr.[اسم الصنف]=products.[اسم الصنف])
		where [اسم الصنف] in (select [اسم الصنف] from purchases where [رقم فاتورة الشراء]=@id)

		delete from purchases
		where [رقم فاتورة الشراء]=@id
GO
 
-- Stored Procedure: delete_m5rgat
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_m5rgat')
    DROP PROCEDURE [dbo].[delete_m5rgat];
GO
create proc [dbo].[delete_m5rgat]
@id varchar(50)
as


DELETE FROM [dbo].[new_orders]
      WHERE id_order=@id



GO
 
-- Stored Procedure: delete_m5zn
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_m5zn')
    DROP PROCEDURE [dbo].[delete_m5zn];
GO
create proc delete_m5zn
@id int
as
DELETE FROM [dbo].[m5azen]
      WHERE id=@id
GO
 
-- Stored Procedure: delete_md5al
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_md5al')
    DROP PROCEDURE [dbo].[delete_md5al];
GO
create proc [dbo].[delete_md5al]
@id int

as


DELETE FROM [dbo].[md5lat]
      WHERE id=@id


GO
 
-- Stored Procedure: delete_mndoop
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_mndoop')
    DROP PROCEDURE [dbo].[delete_mndoop];
GO
create proc delete_mndoop
@id int
as
DELETE FROM [dbo].[mndob]
      WHERE id=@id
GO
 
-- Stored Procedure: delete_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_mwrd')
    DROP PROCEDURE [dbo].[delete_mwrd];
GO
create proc [dbo].[delete_mwrd]
@id int
as


DELETE FROM [dbo].[mwrdeen]
      WHERE id=@id



GO
 
-- Stored Procedure: delete_mwrd_pays
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_mwrd_pays')
    DROP PROCEDURE [dbo].[delete_mwrd_pays];
GO
create proc delete_mwrd_pays
@id int
as
DELETE FROM [dbo].[mwrd_pays]
      WHERE id=@id
GO
 
-- Stored Procedure: Delete_prd_first_rseed
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'Delete_prd_first_rseed')
    DROP PROCEDURE [dbo].[Delete_prd_first_rseed];
GO
create proc Delete_prd_first_rseed
@id int
as
DELETE FROM [dbo].[prd_first_rseed]
      WHERE id=@id
GO
 
-- Stored Procedure: delete_product_from_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_product_from_order')
    DROP PROCEDURE [dbo].[delete_product_from_order];
GO
CREATE proc [dbo].[delete_product_from_order]
@id_product int,
@order_id int
as

update products
set الكميه=الكميه+(select distinct الكميه from order_details where [كود الصنف]=@id_product and [رقم الفاتورة]=@order_id)
--,[اجمالي المدفوع]=[اجمالي المدفوع]+((select distinct الكميه from order_details where [كود الصنف]=@id_product and [رقم الفاتورة]=@order_id)*[سعر الشراء])
where products.id=@id_product


DELETE FROM [dbo].[order_details]
      WHERE [كود الصنف]=@id_product and [رقم الفاتورة]=@order_id




GO
 
-- Stored Procedure: delete_product_serial
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_product_serial')
    DROP PROCEDURE [dbo].[delete_product_serial];
GO
CREATE PROCEDURE delete_product_serial
    @id INT
AS
    DELETE FROM product_serials WHERE id = @id;
GO
 
-- Stored Procedure: delete_purchase
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_purchase')
    DROP PROCEDURE [dbo].[delete_purchase];
GO
CREATE proc delete_purchase
@id int
as

update  [dbo].[purchases]
set deleted=1
      WHERE id=@id



GO
 
-- Stored Procedure: delete_users
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'delete_users')
    DROP PROCEDURE [dbo].[delete_users];
GO
create proc [dbo].[delete_users]
@id varchar(50)

as

DELETE FROM [dbo].[Table_users]
  where id=@id



GO
 
-- Stored Procedure: deleteproduct
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'deleteproduct')
    DROP PROCEDURE [dbo].[deleteproduct];
GO
CREATE proc [dbo].[deleteproduct]
@id int
as 
update products
set deleted=1
where id=@id

GO
 
-- Stored Procedure: edit_catogry
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_catogry')
    DROP PROCEDURE [dbo].[edit_catogry];
GO
CREATE proc [dbo].[edit_catogry]
@id int,
@name nvarchar(200)
as

UPDATE [dbo].[catogry]
   SET [النوع] = @name
 WHERE id=@id
GO
 
-- Stored Procedure: edit_corrupted_prd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_corrupted_prd')
    DROP PROCEDURE [dbo].[edit_corrupted_prd];
GO
create proc edit_corrupted_prd
@id int ,
@prd_id int ,
@qte int ,
@reason nvarchar(500),
@dte nvarchar(50)
as

UPDATE [dbo].[corrupted]
   SET [كود الصنف] = @prd_id
      ,[كمية الهالك] = @qte
      ,[السبب] = @reason
      ,[التاريخ] = @dte
 WHERE id=@id
GO
 
-- Stored Procedure: edit_cstmr_pay
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_cstmr_pay')
    DROP PROCEDURE [dbo].[edit_cstmr_pay];
GO
CREATE proc [dbo].[edit_cstmr_pay]
@id int,
@cstmr_id int,
@first_rseed float,
@mdfo3 float,
@last_rseed float,
@dte nvarchar(50),
@notes nvarchar(max)
as

UPDATE [dbo].[cstmr_pays]
   SET [كود العميل] = @cstmr_id
      ,[رصيد اول] = @first_rseed
      ,[المدفوع] = @mdfo3
      ,[رصيد اخر] = @last_rseed
      ,[التاريخ] = @dte
	  ,[ملاحظات]=@notes
 WHERE id=@id
GO
 
-- Stored Procedure: edit_cstmrs
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_cstmrs')
    DROP PROCEDURE [dbo].[edit_cstmrs];
GO
CREATE proc [dbo].[edit_cstmrs]
@id int,
@nme varchar(50),
@pho varchar(50),
@adrs varchar(50),
@max float,
@mndb nvarchar(50)
as


UPDATE [dbo].[cstmrs]
   SET [اسم العميل] = @nme
      ,[التليفون] = @pho
      ,[العنوان] =@adrs
	  ,[اقصي حساب سابق]=@max,
	  المندوب=@mndb
 WHERE id_cstmr=@id



GO
 
-- Stored Procedure: edit_elbank
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_elbank')
    DROP PROCEDURE [dbo].[edit_elbank];
GO
CREATE proc [dbo].[edit_elbank]
@id int,
@type nvarchar(50),
@first float,
@value varchar(50),
@last float,
@dscrpshn nvarchar(50),
@date varchar(50)
as


UPDATE [dbo].[elbank]
   SET [النوع] = @type
		,[رصيد اول]=@first
      ,[القيمة] = @value
	  ,[رصيد اخر]=@last
      ,[الوصف] = @dscrpshn
      ,[التاريخ] = @date
where id=@id

GO
 
-- Stored Procedure: edit_expenses
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_expenses')
    DROP PROCEDURE [dbo].[edit_expenses];
GO
create proc edit_expenses
@id int ,
@type nvarchar(50),
@cach float,
@details nvarchar(max),
@dte date
as

UPDATE [dbo].[expenses]
   SET [النوع] = @type
      ,[المبلغ] = @cach
      ,[التفاصيل] = @details
      ,[التاريخ] =@dte
 WHERE id=@id
GO
 
-- Stored Procedure: edit_fwateer_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_fwateer_mwrd')
    DROP PROCEDURE [dbo].[edit_fwateer_mwrd];
GO
CREATE proc [dbo].[edit_fwateer_mwrd]
@id int,
@nme nvarchar(50),
@date nvarchar(50),
@value nvarchar(50),
@msdd nvarchar(50),
@mtbaki nvarchar(50)

as


UPDATE [dbo].[fwateer_mwrd]
   SET [اسم المورد] = @nme
      ,[التاريخ] =@date
      ,[قيمة الفاتورة]=@value
	  ,المسدد=@msdd
	  ,المتبقي=@mtbaki
 WHERE id=@id



GO
 
-- Stored Procedure: edit_m5zn
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_m5zn')
    DROP PROCEDURE [dbo].[edit_m5zn];
GO
create proc edit_m5zn
@id int ,
@nme nvarchar(100)
as
UPDATE [dbo].[m5azen]
   SET [اسم المخزن] = @nme
 WHERE id=@id
GO
 
-- Stored Procedure: edit_md5al
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_md5al')
    DROP PROCEDURE [dbo].[edit_md5al];
GO
CREATE proc [dbo].[edit_md5al]
@id int,
@value varchar(50),
@date varchar(50),
@dskrpshn varchar(200)
as


UPDATE [dbo].[md5lat]
   SET [القيمة] = @value
      ,[التاريخ] = @date
      ,[الوصف] =@dskrpshn
 WHERE id=@id



GO
 
-- Stored Procedure: Edit_mksb
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'Edit_mksb')
    DROP PROCEDURE [dbo].[Edit_mksb];
GO
create proc [dbo].[Edit_mksb]
@id_order int,
@mksab varchar(50)

as

update new_orders
set [صافي الربح]=@mksab
where id_order=@id_order

GO
 
-- Stored Procedure: edit_mndoob
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_mndoob')
    DROP PROCEDURE [dbo].[edit_mndoob];
GO
create proc edit_mndoob
@id int,
@nme nvarchar(100),
@phone nvarchar(50),
@rseed float
as


UPDATE [dbo].[mndob]
   SET [اسم المندوب] = @nme
      ,[التليفون] =@phone
      ,[الرصيد] = @rseed
	  where id=@id


GO
 
-- Stored Procedure: edit_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_mwrd')
    DROP PROCEDURE [dbo].[edit_mwrd];
GO
create proc [dbo].[edit_mwrd]
@id int,
@nme nvarchar(50),
@phone nvarchar(50),
@adress nvarchar(50)

as


UPDATE [dbo].[mwrdeen]
   SET [اسم المورد] =@nme
      ,[التليفون] =@phone
      ,[العنوان] = @adress
 WHERE 
 id=@id

GO
 
-- Stored Procedure: edit_mwrd_pays
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_mwrd_pays')
    DROP PROCEDURE [dbo].[edit_mwrd_pays];
GO

create proc edit_mwrd_pays
@id int,
@mwrd_id int,
@first_rseed float,
@payed float,
@last_rseed float,
@dte nvarchar(50)
as

UPDATE [dbo].[mwrd_pays]
   SET [كود المورد] = @mwrd_id
      ,[رصيد اول] =@first_rseed
      ,[المدفوع] = @payed
      ,[رصيد اخر] =@last_rseed
      ,[التاريخ] = @dte
 WHERE id=@id
GO
 
-- Stored Procedure: edit_new_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_new_order')
    DROP PROCEDURE [dbo].[edit_new_order];
GO
CREATE proc [dbo].[edit_new_order]
@id int,
@msdd varchar(50),
@mtbaki varchar(50),
@total varchar(50),
@reb7 varchar(50),
@mndb_id int,
@transport float
as 
update new_orders
set [المبلغ المسدد]=@msdd
,[المبلغ المتبقي]=@mtbaki
,[اجمالي الفاتورة]=@total
,[صافي الربح]=@reb7
,[كود المندوب]=@mndb_id
,[مصاريف النقل]=@transport
where id_order=@id
GO
 
-- Stored Procedure: Edit_order_Date
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'Edit_order_Date')
    DROP PROCEDURE [dbo].[Edit_order_Date];
GO
CREATE proc Edit_order_Date
@id int,
@date nvarchar(50),
@datetme datetime
as
update orders
set [تاريخ الفاتورة]=@datetme
where id_order=@id

update new_orders 
set [تاريخ الفاتورة]=@date
where id_order=@id
GO
 
-- Stored Procedure: edit_order_mndob
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_order_mndob')
    DROP PROCEDURE [dbo].[edit_order_mndob];
GO
create proc edit_order_mndob
@id_order int ,
@id_mndob int 
as 
update new_orders
set [كود المندوب]=@id_mndob
where [id_order]=@id_order
GO
 
-- Stored Procedure: edit_prd_qte_for_gard
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_prd_qte_for_gard')
    DROP PROCEDURE [dbo].[edit_prd_qte_for_gard];
GO
create proc edit_prd_qte_for_gard
@id int ,
@qte int
as
update products
set [الكميه]=@qte
where id=@id
GO
 
-- Stored Procedure: edit_purchase
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_purchase')
    DROP PROCEDURE [dbo].[edit_purchase];
GO
create proc edit_purchase
@nme varchar(50),
@qte int,
@pshr varchar(50),
@pg varchar(50),
@pb varchar(50),
@pmsthlk varchar(50),
@tmd varchar(50),
@img image,
 @id varchar (50),
 @kind nvarchar(50),
 @store nvarchar(100)
as 

UPDATE [dbo].[purchases]
set [اسم الصنف]  =@nme,
 [الكميه]=@qte,
 [سعر الشراء]=@pshr,
 [سعر الجمله] =@pg,
[سعر البيع] =@pb,
[سعر المستهلك]=@pmsthlk,
 [اجمالي المدفوع] =@tmd,
 صوره =@img,
 النوع=@kind,
 store=@store
 
 WHERE convert (varchar,id)=@id 

GO
 
-- Stored Procedure: edit_system_type
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'edit_system_type')
    DROP PROCEDURE [dbo].[edit_system_type];
GO
create proc edit_system_type
@id int,
@months int,
@status nvarchar(50),
@isValid bit
 as
UPDATE [dbo].[systemType]
set
      [avMonth] =  @months 
      ,[status] =  @status 
      ,[isValid] = @isValid
 WHERE id=@id
GO
 
-- Stored Procedure: filter_by_store
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'filter_by_store')
    DROP PROCEDURE [dbo].[filter_by_store];
GO
create proc filter_by_store
@store nvarchar(100)
as
select 
id,
[اسم الصنف],
الكميه,
[سعر الشراء],
[سعر الجمله],
[سعر البيع],
[اجمالي المدفوع],
النوع,
[اسم المورد]
from products
where store like '%'+@store+'%'
GO
 
-- Stored Procedure: filter_elbank_by_date
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'filter_elbank_by_date')
    DROP PROCEDURE [dbo].[filter_elbank_by_date];
GO
CREATE proc filter_elbank_by_date
@dte nvarchar(50) 
as
SELECT [id]
      ,[النوع]
	  ,[رصيد اول]
      ,[القيمة]
      ,[رصيد اخر]
      ,[الوصف]
      ,[التاريخ]
      
  FROM [dbo].[elbank]
  where [التاريخ] like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_7sab_sabk
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_7sab_sabk')
    DROP PROCEDURE [dbo].[get_7sab_sabk];
GO
CREATE proc [dbo].[get_7sab_sabk]
@nme varchar(50)
as

SELECT [المبلغ المتبقي] 
      
  FROM [dbo].[new_orders] n inner join cstmrs c on n.cstmr_id=c.id_cstmr
  where c.[اسم العميل]=@nme


GO
 
-- Stored Procedure: get_all_7sab_sabk
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_7sab_sabk')
    DROP PROCEDURE [dbo].[get_all_7sab_sabk];
GO
create proc get_all_7sab_sabk
@id int 
as 
select sum(convert(float,[المبلغ المتبقي])) from new_orders 
where cstmr_id=@id
GO
 
-- Stored Procedure: get_all_catogries
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_catogries')
    DROP PROCEDURE [dbo].[get_all_catogries];
GO
create proc get_all_catogries
as
SELECT [id]
      ,[النوع]
  FROM [dbo].[catogry]
GO
 
-- Stored Procedure: get_all_cstmr_pays
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_cstmr_pays')
    DROP PROCEDURE [dbo].[get_all_cstmr_pays];
GO
CREATE proc [dbo].[get_all_cstmr_pays]
@cstmr_id int
as
SELECT [id]
      ,[كود العميل]
      ,[رصيد اول]
      ,[المدفوع]
      ,[رصيد اخر]
      ,[التاريخ]
	  ,[نوع العملية]
	  ,[ملاحظات]
  FROM [dbo].[cstmr_pays]
  where [كود العميل]=@cstmr_id
GO
 
-- Stored Procedure: get_all_cstmr_pays_for_mndb
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_cstmr_pays_for_mndb')
    DROP PROCEDURE [dbo].[get_all_cstmr_pays_for_mndb];
GO
CREATE proc [dbo].[get_all_cstmr_pays_for_mndb]
@mndb_name nvarchar(100)
as

SELECT [id] as 'كود العملية'
      ,c.[اسم العميل]
      ,[رصيد اول]
      ,[المدفوع]
      ,[رصيد اخر]
      ,[التاريخ]
	  ,[نوع العملية]
	  ,[ملاحظات]
  FROM [dbo].[cstmr_pays] cp
  inner join cstmrs c on c.id_cstmr=cp.[كود العميل]
  where [اسم المندوب] = @mndb_name
  
GO
 
-- Stored Procedure: get_all_cstmr_pays_for_mndb_by_date
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_cstmr_pays_for_mndb_by_date')
    DROP PROCEDURE [dbo].[get_all_cstmr_pays_for_mndb_by_date];
GO
CREATE proc [dbo].[get_all_cstmr_pays_for_mndb_by_date]
@mndb_name nvarchar(100),
@dte nvarchar(50)
as

SELECT [id] as 'كود العملية'
      ,c.[اسم العميل]
      ,[رصيد اول]
      ,[المدفوع]
      ,[رصيد اخر]
      ,[التاريخ]
	  ,[نوع العملية]
	  ,[ملاحظات]
  FROM [dbo].[cstmr_pays] cp
  inner join cstmrs c on c.id_cstmr=cp.[كود العميل]
  where [اسم المندوب] = @mndb_name and [التاريخ] like '%'+@dte+'%'
  
GO
 
-- Stored Procedure: get_all_cstmrs
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_cstmrs')
    DROP PROCEDURE [dbo].[get_all_cstmrs];
GO
CREATE proc [dbo].[get_all_cstmrs]
as
select [id_cstmr] 
, [اسم العميل] as 'اسم العميل'
  ,[التليفون]  as 'رقم التليفون'
  ,[العنوان]  as 'العنوان'
  ,[المندوب]
 from cstmrs
GO
 
-- Stored Procedure: get_all_cstmrs_pays_bydate
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_cstmrs_pays_bydate')
    DROP PROCEDURE [dbo].[get_all_cstmrs_pays_bydate];
GO
CREATE proc [dbo].[get_all_cstmrs_pays_bydate]
@dte nvarchar(50)
as
SELECT [id] as 'كود التحصيل'
      ,c.[اسم العميل]
      ,[رصيد اول]
      ,[المدفوع]
      ,[رصيد اخر]
      ,[التاريخ]
	  ,[اسم المندوب]
	  ,[نوع العملية]
	  ,[ملاحظات]
  FROM [dbo].[cstmr_pays] cp
  inner join cstmrs c on c.id_cstmr=cp.[كود العميل]
  where [التاريخ] like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_all_cstnrs_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_cstnrs_report')
    DROP PROCEDURE [dbo].[get_all_cstnrs_report];
GO
CREATE PROC [dbo].[get_all_cstnrs_report]
@cstmr_id int
as 
declare @first_rseed float=0 ,@bee3 float =0,@rd float =0
declare @t7seel float=0 ,@msdd float=0 ,@khsm_msmo7 float=0 ,@mrtg3 float=0 ,@mrtg3_after_khsm float =0
declare @final float=0

set @first_rseed= (select SUM( [رصيد اخر]) from cstmr_pays where [كود العميل]=@cstmr_id  and [المدفوع]=0)
set @bee3= (select sum( convert(float,[اجمالي الفاتورة])) from new_orders where cstmr_id=@cstmr_id )
set @rd=(select SUM(abs( [المدفوع] )) from cstmr_pays where [كود العميل]=@cstmr_id and [المدفوع]<>0 and [نوع العملية] ='رد للعميل' 
or [كود العميل]=@cstmr_id and [المدفوع]<0 and [نوع العملية] is null)

set @t7seel=(select sum([المدفوع] )from cstmr_pays where [كود العميل]=@cstmr_id  and [المدفوع]<>0 and [نوع العملية] ='تحصيل' 
or [كود العميل]=@cstmr_id  and [المدفوع]>0 and [نوع العملية] is null)

set @msdd=(select sum(convert(float,[المبلغ المسدد]) )from new_orders where cstmr_id=@cstmr_id )
set @khsm_msmo7=(select sum ([المدفوع] ) from cstmr_pays where [كود العميل]=@cstmr_id and [المدفوع]<>0 and [نوع العملية] ='خصم مسموح به' )

set @mrtg3=(select sum(total_price) from cstmrs_mrtg3 where cstmr_id=@cstmr_id and [الاجمالي بعد الخصم] is null )
set @mrtg3_after_khsm=(select sum([الاجمالي بعد الخصم]) from cstmrs_mrtg3 where cstmr_id=@cstmr_id and [الاجمالي بعد الخصم] is not null )

if(@first_rseed is null)
set @first_rseed=0
if(@bee3 is null)
set @bee3=0
if(@rd is null)
set @rd=0
if(@t7seel is null)
set @t7seel=0
if(@msdd is null)
set @msdd=0
if(@khsm_msmo7 is null)
set @khsm_msmo7=0
if(@mrtg3 is null)
set @mrtg3=0
if(@mrtg3_after_khsm is null)
set @mrtg3_after_khsm=0


set @final=(@first_rseed+@bee3+abs(@rd))-(@t7seel+@msdd+@khsm_msmo7+@mrtg3+@mrtg3_after_khsm)

if(@final is null)
set @final=0


select @cstmr_id as 'كود العميل',
(select [اسم العميل] from cstmrs where id_cstmr=@cstmr_id) as 'اسم العميل',
@first_rseed as 'رصيد أول',
@bee3 as'مبيعات',
abs(@rd) as 'رد للعميل',
(@t7seel +@msdd )as'تحصيل + مسدد فواتير',
@khsm_msmo7 as 'خصم مسموح به',
(@mrtg3+@mrtg3_after_khsm) as 'مرتجع',
@final as 'الرصيد',
'رصيد'as'نوع الرصيد'

GO
 
-- Stored Procedure: get_all_deleted_products
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_deleted_products')
    DROP PROCEDURE [dbo].[get_all_deleted_products];
GO
create proc [dbo].[get_all_deleted_products]
as
select * from products
where deleted=1
GO
 
-- Stored Procedure: get_all_elbank
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_elbank')
    DROP PROCEDURE [dbo].[get_all_elbank];
GO
CREATE proc [dbo].[get_all_elbank]
as 
SELECT [id]
      ,[النوع]
	  ,[رصيد اول]
      ,[القيمة]
      ,[رصيد اخر]
      ,[الوصف]
      ,[التاريخ]
from elbank
GO
 
-- Stored Procedure: get_all_expenses
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_expenses')
    DROP PROCEDURE [dbo].[get_all_expenses];
GO

create proc get_all_expenses
as

SELECT [id] as 'كود المصروف'
      ,[النوع]
      ,[المبلغ]
      ,[التفاصيل]
      ,[التاريخ]
  FROM [dbo].[expenses]
GO
 
-- Stored Procedure: get_all_expenses_for_details
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_expenses_for_details')
    DROP PROCEDURE [dbo].[get_all_expenses_for_details];
GO
  
create proc [dbo].[get_all_expenses_for_details]
@kind nvarchar(50)
as

SELECT [id] as 'كود المصروف'
      ,[النوع]
      ,[المبلغ]
      ,[التفاصيل]
      ,[التاريخ]
  FROM [dbo].[expenses]
  where [التفاصيل] like '%'+@kind+'%'
GO
 
-- Stored Procedure: get_all_expenses_for_kind
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_expenses_for_kind')
    DROP PROCEDURE [dbo].[get_all_expenses_for_kind];
GO
CREATE proc [dbo].[get_all_expenses_for_kind]
@kind nvarchar(50)
as

SELECT [id] as 'كود المصروف'
      ,[النوع]
      ,[المبلغ]
      ,[التفاصيل]
      ,[التاريخ]
  FROM [dbo].[expenses]
  where [النوع]+[التفاصيل] like '%'+@kind+'%'

GO
 
-- Stored Procedure: get_all_expenses_for_kind_by_date
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_expenses_for_kind_by_date')
    DROP PROCEDURE [dbo].[get_all_expenses_for_kind_by_date];
GO

create proc [dbo].[get_all_expenses_for_kind_by_date]
@kind nvarchar(50),
@dte date
as

SELECT [id] as 'كود المصروف'
      ,[النوع]
      ,[المبلغ]
      ,[التفاصيل]
      ,[التاريخ]
  FROM [dbo].[expenses]
  where [النوع]+[التفاصيل] like '%'+@kind+'%' and [التاريخ]=@dte
GO
 
-- Stored Procedure: get_all_expenses_for_specific_date
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_expenses_for_specific_date')
    DROP PROCEDURE [dbo].[get_all_expenses_for_specific_date];
GO

create proc get_all_expenses_for_specific_date
@dte date
as

SELECT [id] as 'كود المصروف'
      ,[النوع]
      ,[المبلغ]
      ,[التفاصيل]
      ,[التاريخ]
  FROM [dbo].[expenses]
  where التاريخ=@dte
GO
 
-- Stored Procedure: get_all_fatora_mrtg3_products
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_fatora_mrtg3_products')
    DROP PROCEDURE [dbo].[get_all_fatora_mrtg3_products];
GO
create proc get_all_fatora_mrtg3_products
@id int
as
select c.fatora_id as 'رقم الفاتورة'
,c.prd_id as'كود الصنف'
,c.quantity as 'الكمية'
,c.price as 'سعر الاسترجاع'
,p.[اسم الصنف]
 from cstmrs_fatora_product c
 inner join products p
 on c.prd_id=p.id
 where fatora_id=@id
GO
 
-- Stored Procedure: get_all_fatora_mwrd_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_fatora_mwrd_product')
    DROP PROCEDURE [dbo].[get_all_fatora_mwrd_product];
GO
CREATE proc [dbo].[get_all_fatora_mwrd_product]
@id_order nvarchar(50)

as

SELECT [id]
      ,[اسم الصنف]
      ,[الكميه]
      ,[سعر الشراء]
      ,[سعر الجمله]
      ,[سعر البيع]
      ,[سعر المستهلك]
      ,[اجمالي المدفوع]
      ,[النوع]
  FROM [dbo].[products]
where products. [رقم فاتورة الشراء]=@id_order and deleted =0
GO
 
-- Stored Procedure: get_all_fatora_mwrd_purchases
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_fatora_mwrd_purchases')
    DROP PROCEDURE [dbo].[get_all_fatora_mwrd_purchases];
GO
CREATE proc [dbo].[get_all_fatora_mwrd_purchases]
@fatora_id nvarchar(50)
as
SELECT [id]
      ,[اسم الصنف]
      ,[الكميه]
      ,[سعر الشراء]
      ,[سعر الجمله]
      ,[سعر البيع]
      ,[سعر المستهلك]
      ,[اجمالي المدفوع]
      --,[صوره]
      ,[النوع]
      ,[اسم المورد]
      ,[رقم فاتورة الشراء]
      ,[store] as 'المخزن'
      
  FROM [dbo].[purchases]
  where deleted =0 and [رقم فاتورة الشراء]=@fatora_id
GO
 
-- Stored Procedure: get_all_fwareer_mrtg3
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_fwareer_mrtg3')
    DROP PROCEDURE [dbo].[get_all_fwareer_mrtg3];
GO
create proc [dbo].[get_all_fwareer_mrtg3]
as
select fatora_id as 'رقم الفاتورة'
,total_price as'اجمالي الفاتورة'
,timestamp as 'تاريخ الفاتورة'
,[الخصم]
,[نوع الخصم]
,[الاجمالي بعد الخصم]
 from cstmrs_mrtg3
GO
 
-- Stored Procedure: get_all_fwareer_mrtg3_for_cstmr
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_fwareer_mrtg3_for_cstmr')
    DROP PROCEDURE [dbo].[get_all_fwareer_mrtg3_for_cstmr];
GO
CREATE proc [dbo].[get_all_fwareer_mrtg3_for_cstmr]
@id int
as
select fatora_id as 'رقم الفاتورة'
,total_price as'اجمالي الفاتورة'
,timestamp as 'تاريخ الفاتورة'
,[الخصم]
,[نوع الخصم]
,[الاجمالي بعد الخصم]
 from cstmrs_mrtg3
 where cstmr_id=@id
GO
 
-- Stored Procedure: get_all_fwateer_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_fwateer_mwrd')
    DROP PROCEDURE [dbo].[get_all_fwateer_mwrd];
GO
CREATE proc [dbo].[get_all_fwateer_mwrd]
@nme nvarchar(50)
as
SELECT [id]
      ,[اسم المورد]
      ,[التاريخ]
      ,[قيمة الفاتورة]
	  ,المسدد
	  ,المتبقي
  FROM [dbo].[fwateer_mwrd]
  where [اسم المورد]=@nme



GO
 
-- Stored Procedure: get_all_late_cstmr_pays
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_late_cstmr_pays')
    DROP PROCEDURE [dbo].[get_all_late_cstmr_pays];
GO
CREATE proc get_all_late_cstmr_pays
@dte nvarchar(50)
as
set @dte=REVERSE( replace(@dte,'/',''))
select * from cstmrs where [id_cstmr] not in (select [كود العميل] from cstmr_pays
where [نوع العملية]='تحصيل' and
 convert(float,REVERSE( replace(التاريخ,'/','')))<=  convert(float, @dte)
  group by [كود العميل])

GO
 
-- Stored Procedure: get_all_m5azen
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_m5azen')
    DROP PROCEDURE [dbo].[get_all_m5azen];
GO
create proc get_all_m5azen
as
SELECT [id]
      ,[اسم المخزن]
  FROM [dbo].[m5azen]
GO
 
-- Stored Procedure: get_all_md5lat
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_md5lat')
    DROP PROCEDURE [dbo].[get_all_md5lat];
GO
create proc [dbo].[get_all_md5lat]

as

SELECT [id]
      ,[القيمة]
      ,[التاريخ]
      ,[الوصف]
  FROM [dbo].[md5lat]



GO
 
-- Stored Procedure: get_all_mndopeen
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_mndopeen')
    DROP PROCEDURE [dbo].[get_all_mndopeen];
GO
create proc get_all_mndopeen
as
SELECT [id]
      ,[اسم المندوب]
      ,[التليفون]
      ,[الرصيد]
  FROM [dbo].[mndob]



GO
 
-- Stored Procedure: get_all_mrtg3_mshtriat_for_card
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_mrtg3_mshtriat_for_card')
    DROP PROCEDURE [dbo].[get_all_mrtg3_mshtriat_for_card];
GO
create proc get_all_mrtg3_mshtriat_for_card
@nme nvarchar(100)
as
SELECT [كود الصنف]
      ,[اسم الصنف]
      ,[الكمية]
      ,[السعر]
      ,[رقم فاتورة الشراء]
      ,[التاريخ]
  FROM [dbo].[mrtg3_mshtriat] m
  
  where m.[اسم الصنف] like '%'+@nme+'%'
GO
 
-- Stored Procedure: get_all_mrtg3_mshtriat_for_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_mrtg3_mshtriat_for_mwrd')
    DROP PROCEDURE [dbo].[get_all_mrtg3_mshtriat_for_mwrd];
GO
CREATE proc get_all_mrtg3_mshtriat_for_mwrd
@mwrd_nme nvarchar(50)
as 
select m.[كود الصنف],
 m.[اسم الصنف],
m.الكمية ,
m.السعر ,
m.التاريخ ,
m.[رقم فاتورة الشراء]

from mrtg3_mshtriat m
inner join fwateer_mwrd f 
on f.id=m.[رقم فاتورة الشراء]
where [اسم المورد]=@mwrd_nme
GO
 
-- Stored Procedure: get_all_mwrd_pays
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_mwrd_pays')
    DROP PROCEDURE [dbo].[get_all_mwrd_pays];
GO
CREATE proc [dbo].[get_all_mwrd_pays]
@id int
as
SELECT [id]
      ,[كود المورد]
      ,[رصيد اول]
      ,[المدفوع]
      ,[رصيد اخر]
      ,[التاريخ]
	  ,[نوع العملية]
	  ,[ملاحظات]
  FROM [dbo].[mwrd_pays]
  where [كود المورد]=@id
GO
 
-- Stored Procedure: get_all_mwrdeen
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_mwrdeen')
    DROP PROCEDURE [dbo].[get_all_mwrdeen];
GO
create proc [dbo].[get_all_mwrdeen]
as
select * from mwrdeen

GO
 
-- Stored Procedure: get_all_mwrdeen_pays_bydate
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_mwrdeen_pays_bydate')
    DROP PROCEDURE [dbo].[get_all_mwrdeen_pays_bydate];
GO
CREATE proc [dbo].[get_all_mwrdeen_pays_bydate]
@dte nvarchar(50)
as
SELECT mp.[id] as 'كود التحصيل'
      ,m.[اسم المورد]
      ,[رصيد اول]
      ,[المدفوع]
      ,[رصيد اخر]
      ,[التاريخ]
	  ,[نوع العملية]
  FROM [dbo].[mwrd_pays] mp
  inner join mwrdeen m on m.id=mp.[كود المورد]
  where [التاريخ] like '%'+@dte+'%'



GO
 
-- Stored Procedure: get_all_mwrdeen_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_mwrdeen_report')
    DROP PROCEDURE [dbo].[get_all_mwrdeen_report];
GO
create PROC [dbo].[get_all_mwrdeen_report]
@mwrd_id int,
@mwrd_name nvarchar(100)
as 
declare @first_rseed float=0 ,@bee3 float =0,@rd float =0
declare @t7seel float=0 ,@msdd float=0 ,@khsm_msmo7 float=0 ,@mrtg3 float=0 ,@mrtg3_after_khsm float =0
declare @final float=0

set @first_rseed= (select SUM( [رصيد اخر]) from mwrd_pays where [كود المورد]=@mwrd_id  and [المدفوع]=0)
set @bee3= (select sum( convert(float,[قيمة الفاتورة])) from fwateer_mwrd where [اسم المورد] =@mwrd_name )
set @rd=(select SUM(abs( [المدفوع] )) from mwrd_pays where [كود المورد]=@mwrd_id and [المدفوع]<>0 and [نوع العملية] ='استرجاع من المورد' 
or [كود المورد]=@mwrd_id and [المدفوع]<0 and [نوع العملية] is null)

set @t7seel=(select sum([المدفوع] )from mwrd_pays where [كود المورد]=@mwrd_id  and [المدفوع]<>0 and [نوع العملية] ='دفع' 
or [كود المورد]=@mwrd_id  and [المدفوع]>0 and [نوع العملية] is null)

set @msdd=(select sum(convert(float,المسدد) )from fwateer_mwrd where [اسم المورد]=@mwrd_name )
set @khsm_msmo7=(select sum ([المدفوع] ) from mwrd_pays where [كود المورد]=@mwrd_id and [المدفوع]<>0 and [نوع العملية] ='خصم مكتسب' )

set @mrtg3=(select sum(السعر*الكمية) from mrtg3_mshtriat m inner join fwateer_mwrd f on m.[رقم فاتورة الشراء]=f.id where f.[اسم المورد]=@mwrd_name)


if(@first_rseed is null)
set @first_rseed=0
if(@bee3 is null)
set @bee3=0
if(@rd is null)
set @rd=0
if(@t7seel is null)
set @t7seel=0
if(@msdd is null)
set @msdd=0
if(@khsm_msmo7 is null)
set @khsm_msmo7=0
if(@mrtg3 is null)
set @mrtg3=0
if(@mrtg3_after_khsm is null)
set @mrtg3_after_khsm=0


set @final=(@first_rseed+@bee3+abs(@rd))-(@t7seel+@msdd+@khsm_msmo7+@mrtg3+@mrtg3_after_khsm)

if(@final is null)
set @final=0


select @mwrd_id as 'كود المورد',
 @mwrd_name as 'اسم المورد',
@first_rseed as 'رصيد أول',
@bee3 as'مشتريات',
abs(@rd) as 'استرجاع من المورد',
(@t7seel +@msdd )as'دفع + مسدد فواتير',
@khsm_msmo7 as 'خصم مكتسب',
(@mrtg3+@mrtg3_after_khsm) as 'مرتجع',
@final as 'الرصيد',
'رصيد'as'نوع الرصيد'
GO
 
-- Stored Procedure: get_all_new_orders
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_new_orders')
    DROP PROCEDURE [dbo].[get_all_new_orders];
GO
CREATE proc [dbo].[get_all_new_orders]
as


SELECT [id_order] as 'رقم الفاتورة'
      ,[تاريخ الفاتورة]
      ,cstmrs.[اسم العميل]
      ,[المبلغ المسدد]
      ,[المبلغ المتبقي]
      ,[اجمالي الفاتورة]
	  ,[صافي الربح]
	  ,m.[اسم المندوب]
	  ,[مصاريف النقل]
  FROM [dbo].[new_orders]
    inner join cstmrs
  on cstmrs.id_cstmr=new_orders.cstmr_id

  left join mndob m
  on m.id=new_orders.[كود المندوب]
GO
 
-- Stored Procedure: get_all_order_details_for_card
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_order_details_for_card')
    DROP PROCEDURE [dbo].[get_all_order_details_for_card];
GO
CREATE proc [dbo].[get_all_order_details_for_card]
@nme nvarchar(50)
as 
select [كود الصنف]
,o.الكميه
,السعر
,الخصم
,[السعر الكلي]
,[رقم الفاتورة]
,n.[تاريخ الفاتورة]
 from order_details o

 inner join products p on o.[كود الصنف]=p.id
  left outer join new_orders n on o.[رقم الفاتورة]=n.id_order

 where p.[اسم الصنف] like '%'+ @nme +'%'
GO
 
-- Stored Procedure: get_all_order_details_for_mndb
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_order_details_for_mndb')
    DROP PROCEDURE [dbo].[get_all_order_details_for_mndb];
GO
create proc [dbo].[get_all_order_details_for_mndb]
@id_order varchar(50)
as


SELECT 
	  o.[رقم الفاتورة]
	  ,n.[تاريخ الفاتورة]
	  ,c.[اسم العميل]
      ,[كود الصنف]
	  ,products.[اسم الصنف]
      ,o.[الكميه]
      ,[السعر]
      ,[الخصم]
      ,o.[سعر المستهلك]
      ,[السعر الكلي]

  FROM [dbo].[order_details] o
    inner join products
  on products.id=o.[كود الصنف]
  inner join new_orders n 
  on n.id_order=o.[رقم الفاتورة]
  inner join cstmrs c
  on c.id_cstmr=n.cstmr_id
where convert(varchar(50),[رقم الفاتورة])=@id_order
GO
 
-- Stored Procedure: get_all_orders_for_mandob
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_orders_for_mandob')
    DROP PROCEDURE [dbo].[get_all_orders_for_mandob];
GO
create proc get_all_orders_for_mandob
@id int
as
SELECT [id_order]
      ,[تاريخ الفاتورة]
      ,c.[اسم العميل]
      ,[المبلغ المسدد]
      ,[المبلغ المتبقي]
      ,[اجمالي الفاتورة]
      ,[صافي الربح]
  FROM [dbo].[new_orders]
  inner join cstmrs c
  on c.id_cstmr=cstmr_id
where new_orders.[كود المندوب] =@id
GO
 
-- Stored Procedure: get_all_orders_for_mandob_by_date
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_orders_for_mandob_by_date')
    DROP PROCEDURE [dbo].[get_all_orders_for_mandob_by_date];
GO
create proc [dbo].[get_all_orders_for_mandob_by_date]
@id int,
@dte nvarchar(50)
as
SELECT [id_order]
      ,[تاريخ الفاتورة]
      ,c.[اسم العميل]
      ,[المبلغ المسدد]
      ,[المبلغ المتبقي]
      ,[اجمالي الفاتورة]
      ,[صافي الربح]
  FROM [dbo].[new_orders]
  inner join cstmrs c
  on c.id_cstmr=cstmr_id
where new_orders.[كود المندوب] =@id and  [تاريخ الفاتورة] like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_all_products
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_products')
    DROP PROCEDURE [dbo].[get_all_products];
GO

CREATE proc [dbo].[get_all_products]
as
SELECT [id]
      ,[اسم الصنف]
      ,[الكميه]
      ,[سعر الشراء]
      ,[سعر الجمله]
      ,[سعر البيع]
      ,[سعر المستهلك]
      ,[اجمالي المدفوع] --cast([اجمالي المدفوع]as float) as 'اجمالي المدفوع'
	  ,[صوره]
      ,[النوع]
      ,[اسم المورد]
      ,[رقم فاتورة الشراء]
      ,[store] as 'المخزن'
	  ,سيريال
      , serial_number_mode AS serial_number_mode
from products where deleted <>1

GO
 
-- Stored Procedure: get_all_products_first_rseed
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_products_first_rseed')
    DROP PROCEDURE [dbo].[get_all_products_first_rseed];
GO
create proc get_all_products_first_rseed
as
select 
p.id as 'كود الصنف',
p.[اسم الصنف],
f.الكمية as 'رصيد اول',
p.الكميه as 'كمية ادارة الأصناف'
from products p left outer join prd_first_rseed f
on p.id=f.[كود الصنف]
GO
 
-- Stored Procedure: get_all_products_for_gard
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_products_for_gard')
    DROP PROCEDURE [dbo].[get_all_products_for_gard];
GO
CREATE proc [dbo].[get_all_products_for_gard]
--@nme nvarchar(100),
@id int
as
begin
declare @check_first_purchase BIGINT,@check_first_rseed BIGINT, @final_qte BIGINT=0,@nme nvarchar(100)
declare @qte_mshtriat BIGINT,@qte_orders BIGINT,@qte_mrtg3_mshtriat BIGINT,
@qte_mrtg3_mbe3at BIGINT,@qte_first_rseed BIGINT ,@qte_corrupted BIGINT

set @nme=(select [اسم الصنف] from products where id=@id)
set @qte_mshtriat =(select SUM(CONVERT(BIGINT,[الكميه]))  FROM [dbo].[purchases]  where deleted =0 and [اسم الصنف] like '%'+@nme+'%')
set @qte_orders=(select SUM(CONVERT(BIGINT,o.الكميه)) from order_details o inner join products p on o.[كود الصنف]=p.id where p.[اسم الصنف] like '%'+ @nme +'%')
set @qte_mrtg3_mbe3at=(select SUM(CONVERT(BIGINT,c.quantity))  from cstmrs_fatora_product c inner join products p on p.id=c.prd_id  where p.[اسم الصنف] like '%'+@nme+'%')
set @qte_mrtg3_mshtriat=(select SUM(CONVERT(BIGINT,m.الكمية)) FROM [dbo].[mrtg3_mshtriat] m where m.[اسم الصنف] like '%'+@nme+'%')
set @qte_first_rseed=(select SUM(CONVERT(BIGINT,[الكمية])) FROM [dbo].[prd_first_rseed] where [اسم الصنف] like '%'+@nme+'%')
set @qte_corrupted=(select SUM(CONVERT(BIGINT,c.[كمية الهالك]))   FROM [dbo].[corrupted] c inner join products p on p.id=c.[كود الصنف] where p.[اسم الصنف] like '%'+@nme+'%')

set @check_first_purchase =(select top 1 [الكميه] FROM [dbo].[purchases]  where deleted =0 and [اسم الصنف] like '%'+@nme+'%')
set @check_first_rseed=(select top 1 [الكمية] FROM [dbo].[prd_first_rseed] where [اسم الصنف] like '%'+@nme+'%')

if(@qte_mshtriat is null)
set @qte_mshtriat=0
if(@qte_orders is null)
set @qte_orders=0
if(@qte_mrtg3_mbe3at is null)
set @qte_mrtg3_mbe3at=0
if(@qte_mrtg3_mshtriat is null)
set @qte_mrtg3_mshtriat=0
if(@qte_first_rseed is null)
set @qte_first_rseed=0
if(@qte_corrupted is null)
set @qte_corrupted=0
if(@check_first_purchase is null)
set @check_first_purchase=0
if(@check_first_rseed is null)
set @check_first_rseed=0
if (@check_first_purchase<>@check_first_rseed or @check_first_purchase=0 or @check_first_purchase is null)
begin
set @final_qte=@qte_first_rseed+@qte_mshtriat+@qte_mrtg3_mbe3at-@qte_orders-@qte_mrtg3_mshtriat-@qte_corrupted
end
else if(@check_first_purchase=@check_first_rseed)
begin
set @final_qte=@qte_mshtriat+@qte_mrtg3_mbe3at-@qte_orders-@qte_mrtg3_mshtriat-@qte_corrupted
end
else
begin
set @final_qte=@qte_mshtriat+@qte_mrtg3_mbe3at-@qte_orders-@qte_mrtg3_mshtriat-@qte_corrupted
end
--set @final_qte=convert(BIGINT, @qte_first_rseed)+convert(BIGINT,@qte_mshtriat)+convert(BIGINT,@qte_mrtg3_mbe3at)-
--convert(BIGINT,@qte_orders)-convert(BIGINT,@qte_mrtg3_mshtriat)-convert(BIGINT,@qte_corrupted)
select
id as 'كود الصنف'
,[اسم الصنف],
@final_qte as 'كمية كارت الصنف',
[الكميه] as 'كمية ادارة الاصناف',
@qte_mshtriat as 'مشتريات',
@qte_orders as 'مبيعات',
@qte_mrtg3_mbe3at as 'مرتجع مبيعات',
@qte_mrtg3_mshtriat as 'مرتجع مشتريات',
@qte_first_rseed as 'رصيد أول',
@qte_corrupted as 'هالك'

 from products 
 where id=@id --like '%'+@nme+'%'
 end
GO
 
-- Stored Procedure: get_all_purchases
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_all_purchases')
    DROP PROCEDURE [dbo].[get_all_purchases];
GO
CREATE proc [dbo].[get_all_purchases]
@nme nvarchar(50)
as
SELECT [id]
      ,[اسم الصنف]
      ,[الكميه]
      ,[سعر الشراء]
      ,[سعر الجمله]
      ,[سعر البيع]
      ,[سعر المستهلك]
      ,[اجمالي المدفوع]
      ,[صوره]
      ,[النوع]
      ,[اسم المورد]
      ,[رقم فاتورة الشراء]
      ,[store] as 'المخزن'
      
  FROM [dbo].[purchases]
  where deleted =0 
GO
 
-- Stored Procedure: get_available_serials_for_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_available_serials_for_product')
    DROP PROCEDURE [dbo].[get_available_serials_for_product];
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
 
-- Stored Procedure: get_cstmr_adress
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_cstmr_adress')
    DROP PROCEDURE [dbo].[get_cstmr_adress];
GO
create proc [dbo].[get_cstmr_adress]
@nme varchar(50)
as
select العنوان from cstmrs
where @nme=[اسم العميل]
GO
 
-- Stored Procedure: get_cstmr_id
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_cstmr_id')
    DROP PROCEDURE [dbo].[get_cstmr_id];
GO
create proc [dbo].[get_cstmr_id]
@nme varchar(50)
as
select id_cstmr from cstmrs
where @nme=[اسم العميل]
GO
 
-- Stored Procedure: get_cstmr_mrtg3_for_cstmr_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_cstmr_mrtg3_for_cstmr_report')
    DROP PROCEDURE [dbo].[get_cstmr_mrtg3_for_cstmr_report];
GO
CREATE proc [dbo].[get_cstmr_mrtg3_for_cstmr_report]
@cstmr_id int,
@dte nvarchar(50)
as 
declare @type nvarchar(50) 
set @type ='مرتجع'
select 
fatora_id as 'كود العملية',
@type  as 'نوع العملية',
 convert(date,[timestamp],103) as'التاريخ',
'رصيد اول'as'رصيد اول',
total_price as'القيمة',
[الاجمالي بعد الخصم],
'رصيد اخر'as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from cstmrs_mrtg3
where cstmr_id=@cstmr_id and convert(nvarchar(50), convert(date,[timestamp]),103) like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_cstmr_orders
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_cstmr_orders')
    DROP PROCEDURE [dbo].[get_cstmr_orders];
GO
CREATE proc [dbo].[get_cstmr_orders]
@id varchar(50)
as 


SELECT [id_order]
      ,[تاريخ الفاتورة]
    --  ,[cstmr_id]
      ,convert(float, [المبلغ المسدد])as 'المبلغ المسدد'
      , [المبلغ المتبقي]
      ,convert(float, [اجمالي الفاتورة]) as 'اجمالي الفاتورة'
      ,[صافي الربح]
	  ,[مصاريف النقل]
	  ,[ملاحظات]
  FROM [dbo].[new_orders]


  where [cstmr_id]=@id
  
GO
 
-- Stored Procedure: get_cstmr_orders_for_cstmr_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_cstmr_orders_for_cstmr_report')
    DROP PROCEDURE [dbo].[get_cstmr_orders_for_cstmr_report];
GO
CREATE proc [dbo].[get_cstmr_orders_for_cstmr_report]
@cstmr_id int,
@dte nvarchar(50)
as 
declare @type nvarchar(50)
set @type ='فاتورة بيع'
select 
id_order as 'كود العملية',
@type as 'نوع العملية',
convert(date,[تاريخ الفاتورة],103)as'التاريخ',
'رصيد اول'as'رصيد اول',
convert(float,[اجمالي الفاتورة]) as'القيمة',
'رصيد اخر'as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from new_orders
where cstmr_id=@cstmr_id and [تاريخ الفاتورة] like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_cstmr_orders_msdd_for_cstmr_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_cstmr_orders_msdd_for_cstmr_report')
    DROP PROCEDURE [dbo].[get_cstmr_orders_msdd_for_cstmr_report];
GO
CREATE proc [dbo].[get_cstmr_orders_msdd_for_cstmr_report]
@cstmr_id int,
@dte nvarchar(50)
as 
declare @type nvarchar(50)
set @type ='مسدد من فاتورة بيع رقم : '
select 
id_order as 'كود العملية',
@type +convert(nvarchar(50), id_order) as 'نوع العملية',
convert(date,[تاريخ الفاتورة],105)as'التاريخ',
'رصيد اول'as'رصيد اول',
convert(float,[المبلغ المسدد]) as'القيمة',
'رصيد اخر'as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from new_orders
where cstmr_id=@cstmr_id and [تاريخ الفاتورة] like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_cstmr_pays_first_rseed_for_cstmr_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_cstmr_pays_first_rseed_for_cstmr_report')
    DROP PROCEDURE [dbo].[get_cstmr_pays_first_rseed_for_cstmr_report];
GO
create proc [dbo].[get_cstmr_pays_first_rseed_for_cstmr_report]
@cstmr_id int,
@dte nvarchar(50)
as 
select 
id as 'كود العملية',
[نوع العملية],
convert(date,[التاريخ],103)as'التاريخ',
convert(nvarchar(50),[رصيد اول])as'رصيد اول',
[المدفوع] as'القيمة',
convert(nvarchar(50),[رصيد اخر])as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from cstmr_pays
where [كود العميل]=@cstmr_id and [التاريخ] like '%'+@dte+'%' and [المدفوع]=0
GO
 
-- Stored Procedure: get_cstmr_pays_for_cstmr_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_cstmr_pays_for_cstmr_report')
    DROP PROCEDURE [dbo].[get_cstmr_pays_for_cstmr_report];
GO
CREATE proc [dbo].[get_cstmr_pays_for_cstmr_report]
@cstmr_id int,
@dte nvarchar(50)
as 
select 
id as 'كود العملية',
[نوع العملية],
convert(date,[التاريخ],103)as'التاريخ',
convert(nvarchar(50),[رصيد اول])as'رصيد اول',
[المدفوع] as'القيمة',
convert(nvarchar(50),[رصيد اخر])as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from cstmr_pays
where [كود العميل]=@cstmr_id and [التاريخ] like '%'+@dte+'%' and [المدفوع]<>0
GO
 
-- Stored Procedure: get_image_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_image_product')
    DROP PROCEDURE [dbo].[get_image_product];
GO
CREATE proc [dbo].[get_image_product]
@id varchar(50)
as
select صوره
from products
where id=@id

GO
 
-- Stored Procedure: get_last_date_for_cstmr
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_last_date_for_cstmr')
    DROP PROCEDURE [dbo].[get_last_date_for_cstmr];
GO
CREATE proc [dbo].[get_last_date_for_cstmr]
@cstmr_id int
as
declare @last_order NVARCHAR(50) ,@last_t7seel NVARCHAR(50) 

declare @first_rseed float=0 ,@bee3 float =0,@rd float =0
declare @t7seel float=0 ,@msdd float=0 ,@khsm_msmo7 float=0 ,@mrtg3 float=0 ,@mrtg3_after_khsm float =0
declare @final float=0

set @first_rseed= (select SUM( [رصيد اخر]) from cstmr_pays where [كود العميل]=@cstmr_id  and [المدفوع]=0)
set @bee3= (select sum( convert(float,[اجمالي الفاتورة])) from new_orders where cstmr_id=@cstmr_id )
set @rd=(select SUM(abs( [المدفوع] )) from cstmr_pays where [كود العميل]=@cstmr_id and [المدفوع]<>0 and [نوع العملية] ='رد للعميل' 
or [كود العميل]=@cstmr_id and [المدفوع]<0 and [نوع العملية] is null)

set @t7seel=(select sum([المدفوع] )from cstmr_pays where [كود العميل]=@cstmr_id  and [المدفوع]<>0 and [نوع العملية] ='تحصيل' 
or [كود العميل]=@cstmr_id  and [المدفوع]>0 and [نوع العملية] is null)

set @msdd=(select sum(convert(float,[المبلغ المسدد]) )from new_orders where cstmr_id=@cstmr_id )
set @khsm_msmo7=(select sum ([المدفوع] ) from cstmr_pays where [كود العميل]=@cstmr_id and [المدفوع]<>0 and [نوع العملية] ='خصم مسموح به' )

set @mrtg3=(select sum(total_price) from cstmrs_mrtg3 where cstmr_id=@cstmr_id and [الاجمالي بعد الخصم] is null )
set @mrtg3_after_khsm=(select sum([الاجمالي بعد الخصم]) from cstmrs_mrtg3 where cstmr_id=@cstmr_id and [الاجمالي بعد الخصم] is not null )

if(@first_rseed is null)
set @first_rseed=0
if(@bee3 is null)
set @bee3=0
if(@rd is null)
set @rd=0
if(@t7seel is null)
set @t7seel=0
if(@msdd is null)
set @msdd=0
if(@khsm_msmo7 is null)
set @khsm_msmo7=0
if(@mrtg3 is null)
set @mrtg3=0
if(@mrtg3_after_khsm is null)
set @mrtg3_after_khsm=0


set @final=(@first_rseed+@bee3+abs(@rd))-(@t7seel+@msdd+@khsm_msmo7+@mrtg3+@mrtg3_after_khsm)

if(@final is null)
set @final=0





set @last_order =(select  [تاريخ الفاتورة] from new_orders  where id_order IN (SELECT MAX(id_order ) FROM new_orders)and cstmr_id=@cstmr_id)
set @last_t7seel=(select  التاريخ from cstmr_pays where  id IN (SELECT MAX(ID ) FROM cstmr_pays)and [كود العميل]=@cstmr_id)
SELECT c.id_cstmr as 'كود العميل'
, c.[اسم العميل] 
,c.المندوب
,@last_order as 'تاريخ اخر فاتورة'
--,datediff(DAY,convert(date,@last_order),GETDATE()) as 'عدد ايام'

,@last_t7seel as 'تاريخ اخر عملية تحصيل'
--,datediff(DAY,convert(date,@last_order),GETDATE())as 'عدد ايام'
,@final as 'الرصيد'
  FROM [dbo].cstmrs c
  where id_cstmr =@cstmr_id


GO
 
-- Stored Procedure: get_last_order_forprint
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_last_order_forprint')
    DROP PROCEDURE [dbo].[get_last_order_forprint];
GO
create proc [dbo].[get_last_order_forprint]
as
select max(id_order) from orders
GO
 
-- Stored Procedure: get_last_order_id
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_last_order_id')
    DROP PROCEDURE [dbo].[get_last_order_id];
GO
create proc [dbo].[get_last_order_id]
as
select isnull(max(id_order)+1,1) from orders
GO
 
-- Stored Procedure: get_last_order_id_mwrd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_last_order_id_mwrd')
    DROP PROCEDURE [dbo].[get_last_order_id_mwrd];
GO
create proc [dbo].[get_last_order_id_mwrd]
as
select isnull(max(id)+1,1) from fwateer_mwrd
GO
 
-- Stored Procedure: get_last_prd_id
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_last_prd_id')
    DROP PROCEDURE [dbo].[get_last_prd_id];
GO
create proc [dbo].[get_last_prd_id]
as
select max(id)from products
GO
 
-- Stored Procedure: get_max_for_cstmr
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_max_for_cstmr')
    DROP PROCEDURE [dbo].[get_max_for_cstmr];
GO
create proc get_max_for_cstmr
@id int
as 
select [اقصي حساب سابق] from cstmrs
where id_cstmr=@id
GO
 
-- Stored Procedure: Get_month_details
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'Get_month_details')
    DROP PROCEDURE [dbo].[Get_month_details];
GO
CREATE proc [dbo].[Get_month_details]
@date nvarchar(50)
as 
select sum(convert(float,[اجمالي الفاتورة]))as 'اجمالي المبيعات',
sum(convert(float,[صافي الربح]))as'اجمالي الارباح' from new_orders
where [تاريخ الفاتورة] like '%'+@date+'%'




GO
 
-- Stored Procedure: get_mrtg3_mbe3at_for_catogry_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mrtg3_mbe3at_for_catogry_report')
    DROP PROCEDURE [dbo].[get_mrtg3_mbe3at_for_catogry_report];
GO
create proc get_mrtg3_mbe3at_for_catogry_report
@cat nvarchar(100)
as
select c.fatora_id as 'رقم فاتورة المرتجع',
	c.prd_id as 'كود الصنف',
	c.quantity as 'كمية المرتجع',
	c.price as 'سعر الإسترجاع',
	cm.timestamp as 'تاريخ الإسترجاع',
	cstmrs.[اسم العميل]

 from cstmrs_fatora_product c inner join products p
on c.prd_id=p.id
left outer join cstmrs_mrtg3 cm
on cm.fatora_id=c.fatora_id 
left outer join cstmrs on cstmrs.id_cstmr=cm.cstmr_id
where p.النوع=@cat and p.deleted=0

GO
 
-- Stored Procedure: get_mrtg3_mbe3at_for_catogry_report_date_filter
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mrtg3_mbe3at_for_catogry_report_date_filter')
    DROP PROCEDURE [dbo].[get_mrtg3_mbe3at_for_catogry_report_date_filter];
GO
create proc get_mrtg3_mbe3at_for_catogry_report_date_filter
@cat nvarchar(100),
@dte date
as
select c.fatora_id as 'رقم فاتورة المرتجع',
	c.prd_id as 'كود الصنف',
	c.quantity as 'كمية المرتجع',
	c.price as 'سعر الإسترجاع',
	cm.timestamp as 'تاريخ الإسترجاع',
	cstmrs.[اسم العميل]

 from cstmrs_fatora_product c inner join products p
on c.prd_id=p.id
left outer join cstmrs_mrtg3 cm
on cm.fatora_id=c.fatora_id 
left outer join cstmrs on cstmrs.id_cstmr=cm.cstmr_id
where p.النوع=@cat and p.deleted=0 and cm.timestamp =@dte


GO
 
-- Stored Procedure: get_mrtg3_mshtriat_for_catogry_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mrtg3_mshtriat_for_catogry_report')
    DROP PROCEDURE [dbo].[get_mrtg3_mshtriat_for_catogry_report];
GO
CREATE proc [dbo].[get_mrtg3_mshtriat_for_catogry_report]
@cat nvarchar(100)
as
select m.id as 'كود المرتجع',
	m.[كود الصنف],
	m.[اسم الصنف],
	m.الكمية,
	m.السعر,
	m.[رقم فاتورة الشراء],
	m.التاريخ
	
 from mrtg3_mshtriat m inner join products p
on m.[اسم الصنف] =p.[اسم الصنف]
where p.النوع=@cat and p.deleted=0

GO
 
-- Stored Procedure: get_mrtg3_mshtriat_for_catogry_report_date_filter
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mrtg3_mshtriat_for_catogry_report_date_filter')
    DROP PROCEDURE [dbo].[get_mrtg3_mshtriat_for_catogry_report_date_filter];
GO
CREATE proc [dbo].[get_mrtg3_mshtriat_for_catogry_report_date_filter]
@cat nvarchar(100),
@dte date
as
select m.id as 'كود المرتجع',
	m.[كود الصنف],
	m.[اسم الصنف],
	m.الكمية,
	m.السعر,
	m.[رقم فاتورة الشراء],
	m.التاريخ
	
 from mrtg3_mshtriat m inner join products p
on m.[اسم الصنف] =p.[اسم الصنف]
where p.النوع=@cat and p.deleted=0 and m.التاريخ=@dte


GO
 
-- Stored Procedure: get_mrtg3_mshtriat_for_single_fatora
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mrtg3_mshtriat_for_single_fatora')
    DROP PROCEDURE [dbo].[get_mrtg3_mshtriat_for_single_fatora];
GO
create proc get_mrtg3_mshtriat_for_single_fatora
@fatora_id int
as 
select * 
from mrtg3_mshtriat 
where [رقم فاتورة الشراء]=@fatora_id
GO
 
-- Stored Procedure: get_mwrd_fwateer_for_mwrd_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mwrd_fwateer_for_mwrd_report')
    DROP PROCEDURE [dbo].[get_mwrd_fwateer_for_mwrd_report];
GO
CREATE proc [dbo].[get_mwrd_fwateer_for_mwrd_report]
@mwrd_nme nvarchar(100),
@dte nvarchar(50)
as 
declare @type nvarchar(50)
set @type ='فاتورة شراء'
select 
id as 'كود العملية',
@type as 'نوع العملية',
convert(date,التاريخ,103)as'التاريخ',
'رصيد اول'as'رصيد اول',
convert(float,[قيمة الفاتورة]) as'القيمة',
'0'as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from fwateer_mwrd
where [اسم المورد]=@mwrd_nme and التاريخ like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_mwrd_fwateer_msdd_for_mwrd_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mwrd_fwateer_msdd_for_mwrd_report')
    DROP PROCEDURE [dbo].[get_mwrd_fwateer_msdd_for_mwrd_report];
GO
CREATE proc [dbo].[get_mwrd_fwateer_msdd_for_mwrd_report]
@mwrd_nme nvarchar(100),
@dte nvarchar(50)
as 
declare @type nvarchar(50)
set @type ='مسدد من فاتورة شراء رقم : '
select 
id as 'كود العملية',
@type +convert(nvarchar(50), id) as 'نوع العملية',
convert(date,التاريخ,105)as'التاريخ',
'رصيد اول'as'رصيد اول',
convert(float,المسدد) as'القيمة',
'0'as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from fwateer_mwrd
where [اسم المورد]=@mwrd_nme and التاريخ like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_mwrd_mrtg3_for_mwrd_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mwrd_mrtg3_for_mwrd_report')
    DROP PROCEDURE [dbo].[get_mwrd_mrtg3_for_mwrd_report];
GO
CREATE proc [dbo].[get_mwrd_mrtg3_for_mwrd_report]
@mwrd_nme nvarchar(100),
@dte nvarchar(50)
as 
declare @type nvarchar(50) 
set @type ='مرتجع من فاتورة شراء رقم : '
select 
m.id as 'كود العملية',
@type+convert(nvarchar,m.[رقم فاتورة الشراء])  as 'نوع العملية',
 convert(date,m.التاريخ,103) as'التاريخ',
'رصيد اول'as'رصيد اول',
(m.الكمية*m.السعر) as'القيمة',
'0'as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from mrtg3_mshtriat m
inner join fwateer_mwrd f on m.[رقم فاتورة الشراء]=f.id
where f.[اسم المورد]=@mwrd_nme and convert(nvarchar(50), convert(date,m.[التاريخ]),103) like '%'+@dte+'%'
GO
 
-- Stored Procedure: get_mwrd_pays_first_rseed_for_mwrd_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mwrd_pays_first_rseed_for_mwrd_report')
    DROP PROCEDURE [dbo].[get_mwrd_pays_first_rseed_for_mwrd_report];
GO
create proc [dbo].[get_mwrd_pays_first_rseed_for_mwrd_report]
@mwrd_id int,
@dte nvarchar(50)
as 
select 
id as 'كود العملية',
[نوع العملية],
convert(date,[التاريخ],103)as'التاريخ',
convert(nvarchar(50),[رصيد اول])as'رصيد اول',
[المدفوع] as'القيمة',
convert(nvarchar(50),[رصيد اخر])as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from mwrd_pays
where [كود المورد]=@mwrd_id and [التاريخ] like '%'+@dte+'%'and  [المدفوع]=0
GO
 
-- Stored Procedure: get_mwrd_pays_for_mwrd_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_mwrd_pays_for_mwrd_report')
    DROP PROCEDURE [dbo].[get_mwrd_pays_for_mwrd_report];
GO
CREATE proc [dbo].[get_mwrd_pays_for_mwrd_report]
@mwrd_id int,
@dte nvarchar(50)
as 
select 
id as 'كود العملية',
[نوع العملية],
convert(date,[التاريخ],103)as'التاريخ',
convert(nvarchar(50),[رصيد اول])as'رصيد اول',
[المدفوع] as'القيمة',
convert(nvarchar(50),[رصيد اخر])as'رصيد اخر',
'نوع الرصيد'as'نوع الرصيد'
from mwrd_pays
where [كود المورد]=@mwrd_id and [التاريخ] like '%'+@dte+'%'and [المدفوع]<>0
GO
 
-- Stored Procedure: get_nme_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_nme_product')
    DROP PROCEDURE [dbo].[get_nme_product];
GO
create proc [dbo].[get_nme_product]
@dscrbshn varchar(50)
as


SELECT 
      [اسم الصنف]

  FROM [dbo].[products]
where [اسم الصنف]
like '%'+@dscrbshn+'%'


GO
 
-- Stored Procedure: get_order_details_for_catogry_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_order_details_for_catogry_report')
    DROP PROCEDURE [dbo].[get_order_details_for_catogry_report];
GO
CREATE proc [dbo].[get_order_details_for_catogry_report]
@cat nvarchar(100)
as
select o.[رقم الفاتورة]
      ,o.[كود الصنف]
	  ,p.[اسم الصنف]
      ,o.[الكميه]
      ,o.[السعر]
      ,o.[الخصم]
      ,o.[السعر الكلي]
	  ,s.[تاريخ الفاتورة]
 from order_details o inner join products p
on p.id=o.[كود الصنف]
left outer join orders s
on s.id_order=o.[رقم الفاتورة]
where p.النوع=@cat and p.deleted=0



GO
 
-- Stored Procedure: get_order_details_for_catogry_report_date_filter
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_order_details_for_catogry_report_date_filter')
    DROP PROCEDURE [dbo].[get_order_details_for_catogry_report_date_filter];
GO
CREATE proc [dbo].[get_order_details_for_catogry_report_date_filter]
@cat nvarchar(100),
@dte date
as
select o.[رقم الفاتورة]
      ,o.[كود الصنف]
	  ,p.[اسم الصنف]
      ,o.[الكميه]
      ,o.[السعر]
      ,o.[الخصم]
      ,o.[السعر الكلي]
	  ,s.[تاريخ الفاتورة]
 from order_details o inner join products p
on o.[كود الصنف]=p.id
left outer join orders s
on s.id_order=o.[رقم الفاتورة]
where p.النوع=@cat and p.deleted=0 and convert(date, s.[تاريخ الفاتورة])=@dte


GO
 
-- Stored Procedure: get_order_details_for_edit
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_order_details_for_edit')
    DROP PROCEDURE [dbo].[get_order_details_for_edit];
GO
CREATE proc [dbo].[get_order_details_for_edit]
@id_order varchar(50)
as


SELECT 

      [كود الصنف]
	  ,products.[اسم الصنف]
      ,o.[الكميه]
      ,[السعر]
      ,[الخصم]
      ,o.[سعر المستهلك]
      ,[السعر الكلي]
	  ,o.[رقم الفاتورة]
	  ,n.[تاريخ الفاتورة]
	  ,c.[اسم العميل]
      ,o.serials
  FROM [dbo].[order_details] o
    inner join products
  on products.id=o.[كود الصنف]
  inner join new_orders n 
  on n.id_order=o.[رقم الفاتورة]
  inner join cstmrs c
  on c.id_cstmr=n.cstmr_id
where convert(varchar(50),[رقم الفاتورة])=@id_order
GO
 
-- Stored Procedure: get_prd_by_serial
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_prd_by_serial')
    DROP PROCEDURE [dbo].[get_prd_by_serial];
GO
CREATE proc [dbo].[get_prd_by_serial]
@serial nvarchar(max)
as

SELECT p.[id]
      ,[اسم الصنف]
      ,[الكميه]
      ,[سعر الشراء]
      ,[سعر الجمله]
      ,[سعر البيع]
      ,[سعر المستهلك]
      ,[اجمالي المدفوع]
      ,[صوره]
      ,[النوع]
      ,[اسم المورد]
      ,[رقم فاتورة الشراء]
      ,[store]
      ,[deleted]
      ,[سيريال]
      , serial_number_mode
  FROM [dbo].[products] p
  left outer join dbo.product_serials s on s.product_id=p.id
  where [سيريال] = @serial or s.serial=@serial
GO
 
-- Stored Procedure: get_prd_purchases_for_card
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_prd_purchases_for_card')
    DROP PROCEDURE [dbo].[get_prd_purchases_for_card];
GO
CREATE proc [dbo].[get_prd_purchases_for_card]
@nme nvarchar(50)
as
SELECT p.[id]
      ,[اسم الصنف]
      ,[الكميه]
      ,[سعر الشراء]
      ,[سعر الجمله]
      ,[سعر البيع]
      --,[سعر المستهلك]
      ,[اجمالي المدفوع]
      --,[صوره]
      ,[النوع]
      ,p.[اسم المورد]
      ,[رقم فاتورة الشراء]
      ,[store] as 'المخزن'
	  ,f.[التاريخ]
      
  FROM [dbo].[purchases] p
  left outer join fwateer_mwrd f on f.id=p.[رقم فاتورة الشراء]

  where deleted =0 and [اسم الصنف] like '%'+@nme+'%'
GO
 
-- Stored Procedure: get_price_msdd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_price_msdd')
    DROP PROCEDURE [dbo].[get_price_msdd];
GO
CREATE proc [dbo].[get_price_msdd]
@id varchar(50)
as SELECT  [المبلغ المسدد]
      
  FROM [dbo].new_orders
where @id=id_order


GO
 
-- Stored Procedure: get_price_mtbkii
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_price_mtbkii')
    DROP PROCEDURE [dbo].[get_price_mtbkii];
GO
CREATE proc [dbo].[get_price_mtbkii]
@id varchar(50)
as SELECT  [المبلغ المتبقي]
      
  FROM [dbo].new_orders
where @id=id_order

GO
 
-- Stored Procedure: get_price_shraa_for_mksb
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_price_shraa_for_mksb')
    DROP PROCEDURE [dbo].[get_price_shraa_for_mksb];
GO
-- Batch submitted through debugger: SQLQuery1.sql|7|0|C:\Users\3S4\AppData\Local\Temp\~vs87B8.sql
CREATE proc [dbo].[get_price_shraa_for_mksb]
@id_order varchar(50)
as
SELECT 
      [كود الصنف]
	  ,products.[اسم الصنف]
      ,order_details.[الكميه]
	  ,products.[سعر الشراء]
      ,[السعر]
      ,[الخصم]
      ,order_details.[سعر المستهلك]
      ,[السعر الكلي]

  FROM [dbo].[order_details]
    inner join products
  on products.id=order_details.[كود الصنف]
where convert(varchar(50),[رقم الفاتورة])=@id_order

GO
 
-- Stored Procedure: get_price_shraa_formksab_in_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_price_shraa_formksab_in_order')
    DROP PROCEDURE [dbo].[get_price_shraa_formksab_in_order];
GO
create proc [dbo].[get_price_shraa_formksab_in_order]
@id_product int
as

SELECT 
      [سعر الشراء]

  FROM [dbo].[products]



where id=@id_product
GO
 
-- Stored Procedure: get_product_ids_with_serials
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_product_ids_with_serials')
    DROP PROCEDURE [dbo].[get_product_ids_with_serials];
GO
CREATE PROCEDURE get_product_ids_with_serials
AS
    SELECT DISTINCT product_id FROM product_serials;
GO
 
-- Stored Procedure: get_product_mwrd_for_card
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_product_mwrd_for_card')
    DROP PROCEDURE [dbo].[get_product_mwrd_for_card];
GO
CREATE proc get_product_mwrd_for_card
@nme nvarchar(100)
as
select p.id ,p.الكميه , p.[سعر الشراء] 
 ,p.[سعر الجمله] ,p.[اجمالي المدفوع] 
 ,p.store as'المخزن' ,p.[رقم فاتورة الشراء] 
 , p.[اسم المورد] ,f.التاريخ 
 
  from products p
  left join fwateer_mwrd f on p.[رقم فاتورة الشراء]=f.id
  where p.[اسم الصنف] like '%'+ @nme +'%'
GO
 
-- Stored Procedure: get_purchases_for_catogry_report
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_purchases_for_catogry_report')
    DROP PROCEDURE [dbo].[get_purchases_for_catogry_report];
GO
CREATE proc [dbo].[get_purchases_for_catogry_report]
@cat nvarchar(100)
as
select pu.id as'كود الصنف',
	pu.[اسم الصنف],
	pu.الكميه,
	pu.[سعر الشراء],
	pu.[اجمالي المدفوع],
	pu.store as'المخزن',
	pu.[اسم المورد],
	pu.[رقم فاتورة الشراء],
	f.التاريخ
 from purchases pu inner join products p
on pu.[اسم الصنف]=p.[اسم الصنف]
left outer join fwateer_mwrd f
on f.id=pu.[رقم فاتورة الشراء]
where p.النوع=@cat and p.deleted=0
GO
 
-- Stored Procedure: get_purchases_for_catogry_report_date_filter
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_purchases_for_catogry_report_date_filter')
    DROP PROCEDURE [dbo].[get_purchases_for_catogry_report_date_filter];
GO


CREATE proc [dbo].[get_purchases_for_catogry_report_date_filter]
@cat nvarchar(100),
@dte nvarchar(50)
as
select pu.id as'كود الصنف',
	pu.[اسم الصنف],
	pu.الكميه,
	pu.[سعر الشراء],
	pu.[اجمالي المدفوع],
	pu.store as'المخزن',
	pu.[اسم المورد],
	pu.[رقم فاتورة الشراء],
	f.التاريخ
 from purchases pu inner join products p
on pu.[اسم الصنف]=p.[اسم الصنف]
left outer join fwateer_mwrd f
on f.id=pu.[رقم فاتورة الشراء]
where p.النوع=@cat and p.deleted=0 and f.التاريخ like '%'+@dte+'%'


GO
 
-- Stored Procedure: get_serials_by_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_serials_by_product')
    DROP PROCEDURE [dbo].[get_serials_by_product];
GO
CREATE PROCEDURE get_serials_by_product
    @product_id INT
AS
    SELECT id, product_id, serial, notes
    FROM product_serials
    WHERE product_id = @product_id
    ORDER BY id;
GO
 
-- Stored Procedure: Get_single_cstmr_pay_by_id
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'Get_single_cstmr_pay_by_id')
    DROP PROCEDURE [dbo].[Get_single_cstmr_pay_by_id];
GO
create proc Get_single_cstmr_pay_by_id
@id int
as
SELECT [id] as 'كود العملية'
      ,[كود العميل]
	  ,c.[اسم العميل]
      ,[رصيد اول]
      ,[المدفوع]
      ,[رصيد اخر]
      ,[التاريخ]
      ,[اسم المندوب]
      ,[نوع العملية]
      ,[ملاحظات]
  FROM [dbo].[cstmr_pays] p
  inner join cstmrs c
  on c.id_cstmr=p.[كود العميل]
  where p.id=@id
GO
 
-- Stored Procedure: get_single_expenses
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_single_expenses')
    DROP PROCEDURE [dbo].[get_single_expenses];
GO
create proc [dbo].[get_single_expenses]
@id int
as
SELECT *
  FROM [dbo].[expenses]
  where id=@id
GO
 
-- Stored Procedure: get_single_new_order_mndb
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_single_new_order_mndb')
    DROP PROCEDURE [dbo].[get_single_new_order_mndb];
GO
CREATE proc get_single_new_order_mndb
@id int
as 
select [كود المندوب],
		m.[اسم المندوب],
		m.[الرصيد],
		m.التليفون
		
 from new_orders n
 inner join mndob m
 on m.id=[كود المندوب]

 where n.id_order=@id
GO
 
-- Stored Procedure: get_single_new_orders
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_single_new_orders')
    DROP PROCEDURE [dbo].[get_single_new_orders];
GO
CREATE proc [dbo].[get_single_new_orders]
@order_id int
as

SELECT [id_order]
      ,[تاريخ الفاتورة]
      ,[cstmr_id]
      ,[المبلغ المسدد]
      ,[المبلغ المتبقي]
      ,[اجمالي الفاتورة]
      ,[صافي الربح]
      ,[كود المندوب]
      ,[مصاريف النقل]
	  ,ملاحظات
  FROM [dbo].[new_orders]
where id_order=@order_id


GO
 
-- Stored Procedure: get_single_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_single_product')
    DROP PROCEDURE [dbo].[get_single_product];
GO
CREATE proc [dbo].[get_single_product]
@id int
as
SELECT   [اسم الصنف]
           ,[الكميه]
           ,[سعر الشراء]
           ,[سعر الجمله]
		   ,[سعر البيع]
		   ,[سعر المستهلك]
           ,[اجمالي المدفوع]
           ,[صوره]
		   ,store as'المخزن'
           , serial_number_mode
  FROM [dbo].[products]
where id=@id


GO
 
-- Stored Procedure: get_single_purchase_id
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_single_purchase_id')
    DROP PROCEDURE [dbo].[get_single_purchase_id];
GO
create proc get_single_purchase_id
@nme nvarchar(max)
as 
select id from purchases where [اسم الصنف]=@nme
GO
 
-- Stored Procedure: get_system_type
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'get_system_type')
    DROP PROCEDURE [dbo].[get_system_type];
GO
CREATE proc [dbo].[get_system_type]
as
SELECT [id]
      ,[firstDate]
      ,[avMonth]
      ,[status]
	  ,isValid
  FROM [dbo].[systemType]
  where id = (select max(id) from [systemType])
GO
 
-- Stored Procedure: getorderdetails
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'getorderdetails')
    DROP PROCEDURE [dbo].[getorderdetails];
GO
CREATE proc [dbo].[getorderdetails]
@id_order int
as


SELECT [رقم الفاتورة]
      ,[كود الصنف]
	  ,products.[اسم الصنف]
      ,[order_details].[الكميه]
      ,[السعر]
      ,[الخصم]
	  ,products.[سعر المستهلك]
      ,convert(float,[السعر الكلي]) as'اجمالي'
      ,[المبلغ المسدد]
      ,[المبلغ المتبقي]
	  ,[تاريخ الفاتورة]
	  ,البائع
	  ,id_cstmr as 'كود العميل'
	  ,[اسم العميل]
	  ,التليفون
	  ,العنوان
  FROM [dbo].[order_details]
  inner join orders
  on orders.id_order=order_details.[رقم الفاتورة]
  inner join cstmrs
  on cstmrs.id_cstmr=orders.cstmr_id
  inner join products
  on products.id=order_details.[كود الصنف]
  where order_details.[رقم الفاتورة] =@id_order


GO
 
-- Stored Procedure: getorderdetails_forprint
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'getorderdetails_forprint')
    DROP PROCEDURE [dbo].[getorderdetails_forprint];
GO
CREATE proc [dbo].[getorderdetails_forprint]

as


SELECT [رقم الفاتورة]
      ,[كود الصنف]
	  ,products.[اسم الصنف] 
      ,[order_details].[الكميه]
      ,[السعر]
      ,[الخصم]
	  ,products.[سعر المستهلك]
      ,convert(float,[السعر الكلي]) as'اجمالي'
      ,[المبلغ المسدد]
      ,[المبلغ المتبقي]
	  ,[تاريخ الفاتورة]
	  ,البائع
	  ,id_cstmr as 'كود العميل'
	  ,[اسم العميل]
	  ,التليفون
	  ,العنوان
  FROM [dbo].[order_details]
  inner join orders
  on orders.id_order=order_details.[رقم الفاتورة]
  inner join cstmrs
  on cstmrs.id_cstmr=orders.cstmr_id
  inner join products
  on products.id=order_details.[كود الصنف]


GO
 
-- Stored Procedure: is_serial_sold
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'is_serial_sold')
    DROP PROCEDURE [dbo].[is_serial_sold];
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
 
-- Stored Procedure: mrtg3_mbe3at_for_card
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'mrtg3_mbe3at_for_card')
    DROP PROCEDURE [dbo].[mrtg3_mbe3at_for_card];
GO
create proc mrtg3_mbe3at_for_card
@nme nvarchar(100)
as 
select c.prd_id as 'كود الصنف',c.price as 'السعر' ,
c.quantity as 'الكمية' ,c.fatora_id as'رقم فاتورة المرتجع'
,cs.timestamp as'التاريخ', cstmrs.[اسم العميل]
 from cstmrs_fatora_product c
 inner join products p
 on p.id=c.prd_id
 left join cstmrs_mrtg3 cs
 on cs.fatora_id=c.fatora_id
 left join cstmrs on cs.cstmr_id=cstmrs.id_cstmr
 where p.[اسم الصنف] like '%'+@nme+'%'
GO
 
-- Stored Procedure: one_order_for_each_day
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'one_order_for_each_day')
    DROP PROCEDURE [dbo].[one_order_for_each_day];
GO
CREATE proc [dbo].[one_order_for_each_day]
@date varchar(50)
as 
select  id_order ,[المبلغ المسدد] ,[المبلغ المتبقي],[اجمالي الفاتورة],[صافي الربح]
from new_orders
where [تاريخ الفاتورة]=@date




GO
 
-- Stored Procedure: prd_permenant_delete
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'prd_permenant_delete')
    DROP PROCEDURE [dbo].[prd_permenant_delete];
GO

CREATE proc prd_permenant_delete
@id int,
@nme nvarchar(100)
as

DELETE FROM [dbo].[products]
      WHERE id=@id

delete from order_details
	where [كود الصنف] =@id

delete from purchases 
	where [اسم الصنف]=@nme

delete from mrtg3_mshtriat
where [اسم الصنف]=@nme

delete from cstmrs_fatora_product
where prd_id=@id

delete from corrupted
where [كود الصنف]=@id

delete from prd_first_rseed
where [اسم الصنف]=@nme
GO
 
-- Stored Procedure: re_calc_total_price_for_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 're_calc_total_price_for_order')
    DROP PROCEDURE [dbo].[re_calc_total_price_for_order];
GO
create proc [dbo].[re_calc_total_price_for_order]
@id int
as 
update order_details
set [السعر الكلي]=الكميه*convert(float,السعر)
where [رقم الفاتورة]=@id
GO
 
-- Stored Procedure: search_corrupted_prd
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_corrupted_prd')
    DROP PROCEDURE [dbo].[search_corrupted_prd];
GO
CREATE proc search_corrupted_prd
@nme nvarchar(100)
as

SELECT c.id as'كود الهالك',
      c.[كود الصنف]
	  ,p.[اسم الصنف]
      ,c.[كمية الهالك]
      ,c.[السبب]
      ,c.[التاريخ]
  FROM [dbo].[corrupted] c
  inner join products p
  on p.id=c.[كود الصنف]
  where p.[اسم الصنف] like '%'+@nme+'%'
GO
 
-- Stored Procedure: search_cstmrs
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_cstmrs')
    DROP PROCEDURE [dbo].[search_cstmrs];
GO
CREATE proc [dbo].[search_cstmrs]
@dscrbshn varchar(50)
as


SELECT [id_cstmr] as 'id'
      ,[اسم العميل]
      ,[التليفون]
      ,[العنوان]
	  ,[اقصي حساب سابق]
	  ,المندوب
  FROM [dbo].[cstmrs]
where convert(varchar(50),id_cstmr)+[اسم العميل]+التليفون+العنوان
like '%' +@dscrbshn+'%'
GO
 
-- Stored Procedure: search_cstmrs_mrtg3_bydate
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_cstmrs_mrtg3_bydate')
    DROP PROCEDURE [dbo].[search_cstmrs_mrtg3_bydate];
GO
CREATE proc search_cstmrs_mrtg3_bydate
@dte date
as

SELECT  [fatora_id] as 'رقم الفاتورة'
,[total_price] as'اجمالي الفاتورة'
,[timestamp] as 'تاريخ الفاتورة'
      ,[الخصم]
      ,[نوع الخصم]
      ,[الاجمالي بعد الخصم]
  FROM [dbo].[cstmrs_mrtg3]
  where [timestamp] =@dte
GO
 
-- Stored Procedure: search_fwateer_mwrd_bydate
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_fwateer_mwrd_bydate')
    DROP PROCEDURE [dbo].[search_fwateer_mwrd_bydate];
GO
create proc search_fwateer_mwrd_bydate
@dte nvarchar(50)
as
SELECT [id]
      ,[اسم المورد]
      ,[التاريخ]
      ,[قيمة الفاتورة]
      ,[المسدد]
      ,[المتبقي]
  FROM [dbo].[fwateer_mwrd]
  where [التاريخ] like '%'+@dte+'%'
GO
 
-- Stored Procedure: search_m5zn
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_m5zn')
    DROP PROCEDURE [dbo].[search_m5zn];
GO
CREATE proc [dbo].[search_m5zn]

@dscrpshn varchar(100)
as

SELECT *
  FROM m5azen
where id+ [اسم المخزن]
like '%'+@dscrpshn+'%'
GO
 
-- Stored Procedure: search_md5lat_bydate
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_md5lat_bydate')
    DROP PROCEDURE [dbo].[search_md5lat_bydate];
GO
create proc [dbo].[search_md5lat_bydate]
@date varchar(50)
as

SELECT [id]
      ,[القيمة]
      ,[التاريخ]
      ,[الوصف]
  FROM [dbo].[md5lat]

where convert(varchar(50),التاريخ)
like '%' +@date+'%'
GO
 
-- Stored Procedure: search_mndobeen
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_mndobeen')
    DROP PROCEDURE [dbo].[search_mndobeen];
GO
CREATE proc [dbo].[search_mndobeen]

@dscrpshn varchar(100)
as

SELECT *
  FROM mndob
where convert(nvarchar(50), id)+ [اسم المندوب]
like '%'+@dscrpshn+'%'
GO
 
-- Stored Procedure: search_mrtg3_mshtriat_bydate
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_mrtg3_mshtriat_bydate')
    DROP PROCEDURE [dbo].[search_mrtg3_mshtriat_bydate];
GO
CREATE proc [dbo].[search_mrtg3_mshtriat_bydate]
@dte date
as
SELECT 
      [كود الصنف]
      ,[اسم الصنف]
      ,[الكمية]
      ,[السعر]
      ,[رقم فاتورة الشراء]
      ,[التاريخ]
  FROM [dbo].[mrtg3_mshtriat]
  where [التاريخ] =@dte
GO
 
-- Stored Procedure: search_mwrdeen
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_mwrdeen')
    DROP PROCEDURE [dbo].[search_mwrdeen];
GO
create proc search_mwrdeen
@nme nvarchar(50)
as

SELECT [id]
      ,[اسم المورد]
      ,[التليفون]
      ,[العنوان]
  FROM [dbo].[mwrdeen]
  where [اسم المورد] like '%'+@nme+'%'
GO
 
-- Stored Procedure: search_new_orders_bydate
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_new_orders_bydate')
    DROP PROCEDURE [dbo].[search_new_orders_bydate];
GO
CREATE proc [dbo].[search_new_orders_bydate]

@dscrpshn varchar(50)
as

SELECT [id_order] as 'رقم الفاتورة'
      ,[تاريخ الفاتورة]
      ,cstmrs.[اسم العميل]
      ,[المبلغ المسدد]
      ,[المبلغ المتبقي]
      ,[اجمالي الفاتورة]
	  ,[صافي الربح]
	  ,m.[اسم المندوب]
	  ,[مصاريف النقل]
  FROM [dbo].[new_orders]
    inner join cstmrs 
  on cstmrs.id_cstmr=new_orders.cstmr_id
  left join mndob m
  on m.id=new_orders.[كود المندوب]

where [تاريخ الفاتورة]
like '%'+@dscrpshn+'%'
GO
 
-- Stored Procedure: search_order
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_order')
    DROP PROCEDURE [dbo].[search_order];
GO
CREATE proc [dbo].[search_order]
@dscrpshn varchar(50)
as 


SELECT [id_order] as 'رقم الفاتورة'
      ,[اسم العميل]
	  ,[تاريخ الفاتورة]
      ,[البائع]
  FROM [dbo].[orders]
  inner join cstmrs
  on cstmrs.id_cstmr=orders.cstmr_id
  where convert(varchar,id_order)+[اسم العميل]+البائع
  like '%' + @dscrpshn +'%'


GO
 
-- Stored Procedure: search_prd_first_rseed
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_prd_first_rseed')
    DROP PROCEDURE [dbo].[search_prd_first_rseed];
GO
create proc search_prd_first_rseed
@nme nvarchar(100)
as

SELECT [id]
      ,[كود الصنف]
      ,[اسم الصنف]
      ,[الكمية]
      ,[السعر]
      ,[اجمالي المدفوع]
      ,[تاريخ الاضافة]
  FROM [dbo].[prd_first_rseed]
  where [اسم الصنف] like '%'+@nme+'%'
GO
 
-- Stored Procedure: search_users
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'search_users')
    DROP PROCEDURE [dbo].[search_users];
GO
CREATE proc [dbo].[search_users]

@dscrpshn varchar(50)
as

SELECT [id] as'اسم المستخدم'
      --,[pwd] as 'الباسورد'
      ,[full name] as'الاسم الكامل'
  FROM [dbo].[Table_users]
where id+[full name]
like '%'+@dscrpshn+'%'
GO
 
-- Stored Procedure: searchproduct
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'searchproduct')
    DROP PROCEDURE [dbo].[searchproduct];
GO
CREATE proc [dbo].[searchproduct]
@ID varchar (50)
as
select p.[id]
      ,[اسم الصنف]
      ,[الكميه]
      ,[سعر الشراء]
      ,[سعر الجمله]
      ,[سعر البيع]
      ,[سعر المستهلك]
      ,cast([اجمالي المدفوع]as float) as 'اجمالي المدفوع'
	  ,[صوره]
      ,[النوع]
      ,[اسم المورد]
      ,[رقم فاتورة الشراء]
      ,[store] as 'المخزن'
	  ,[سيريال]
from products p
  left outer join dbo.product_serials s on s.product_id=p.id
where
([اسم الصنف] +
النوع+
سيريال+
CONVERT(varchar, [الكميه])+
store
like '%'+@ID+'%' or s.serial=@ID)
and deleted!=1


GO
 
-- Stored Procedure: select_prd_nme_for_compo
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'select_prd_nme_for_compo')
    DROP PROCEDURE [dbo].[select_prd_nme_for_compo];
GO
CREATE proc [dbo].[select_prd_nme_for_compo]
as 
select [اسم الصنف]
from products
where deleted<>1
GO
 
-- Stored Procedure: sp_login
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_login')
    DROP PROCEDURE [dbo].[sp_login];
GO
create proc [dbo].[sp_login]
@id varchar(50) , @pwd varchar(50)
As
select * from Table_users
 where id=@id And pwd=@pwd

GO
 
-- Stored Procedure: total_asnaf
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'total_asnaf')
    DROP PROCEDURE [dbo].[total_asnaf];
GO
CREATE proc [dbo].[total_asnaf]
as 
select SUM(convert(float,[اجمالي المدفوع])) from products
where deleted<>1
GO
 
-- Stored Procedure: tzbeet_qte
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'tzbeet_qte')
    DROP PROCEDURE [dbo].[tzbeet_qte];
GO
CREATE proc [dbo].[tzbeet_qte]
@id varchar(50),
@qte int
as
update products
set الكميه=الكميه+@qte
where products.id=@id
GO
 
-- Stored Procedure: un_delete_purchase
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'un_delete_purchase')
    DROP PROCEDURE [dbo].[un_delete_purchase];
GO
create proc un_delete_purchase
@id int
as

update  [dbo].[purchases]
set deleted=0
      WHERE id=@id



GO
 
-- Stored Procedure: undelete_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'undelete_product')
    DROP PROCEDURE [dbo].[undelete_product];
GO
create proc [dbo].[undelete_product]
@id int
as 
update products
set deleted=0
where id=@id
GO
 
-- Stored Procedure: update_cstmr_fatora
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_cstmr_fatora')
    DROP PROCEDURE [dbo].[update_cstmr_fatora];
GO
create proc update_cstmr_fatora
@id int,
@total float,
@khsm float,
@type nvarchar(50),
@final_total float
as
update cstmrs_mrtg3
set [total_price]=@total,
[الخصم]=@khsm,
[نوع الخصم]=@type,
[الاجمالي بعد الخصم]=@final_total
where fatora_id=@id
GO
 
-- Stored Procedure: update_msdd_mtpakii
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_msdd_mtpakii')
    DROP PROCEDURE [dbo].[update_msdd_mtpakii];
GO
create proc [dbo].[update_msdd_mtpakii]
@id varchar(50),
@pmsdd varchar(50),
@pmtpakii varchar(50)
as update order_details
set [المبلغ المسدد]=@pmsdd,
[المبلغ المتبقي]=@pmtpakii
where [رقم الفاتورة]=@id
GO
 
-- Stored Procedure: update_msdd_mtpakii_in_new_orders
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_msdd_mtpakii_in_new_orders')
    DROP PROCEDURE [dbo].[update_msdd_mtpakii_in_new_orders];
GO
create proc [dbo].[update_msdd_mtpakii_in_new_orders]
@id varchar(50),
@pmsdd varchar(50),
@pmtpakii varchar(50)
as update new_orders
set [المبلغ المسدد]=@pmsdd,
[المبلغ المتبقي]=@pmtpakii
where id_order=@id
GO
 
-- Stored Procedure: update_prd_first_rseed
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_prd_first_rseed')
    DROP PROCEDURE [dbo].[update_prd_first_rseed];
GO
create proc update_prd_first_rseed
@prd_id int ,
@dte nvarchar(50)
as 

UPDATE [dbo].[prd_first_rseed]
   SET [الكمية] = (select الكميه from products where id=@prd_id)
      ,[السعر] = (select convert(float,[سعر الشراء]) from products where id=@prd_id)
      ,[اجمالي المدفوع] = (select convert(float,[اجمالي المدفوع]) from products where id=@prd_id)
      ,[تاريخ الاضافة] = @dte
 WHERE [كود الصنف]=@prd_id
GO
 
-- Stored Procedure: update_prd_name
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_prd_name')
    DROP PROCEDURE [dbo].[update_prd_name];
GO
CREATE proc update_prd_name
@nme nvarchar(max),
@prd_id int
as
--declare @prd_num int
--set @prd_num =(select id from purchases where [اسم الصنف]=@nme)
update mrtg3_mshtriat set [اسم الصنف]=@nme where [كود الصنف]=@prd_id
update prd_first_rseed set [اسم الصنف]=@nme where [كود الصنف]=@prd_id
update purchases set [اسم الصنف]=@nme where [اسم الصنف]=(select [اسم الصنف] from products where id=@prd_id)
update products set [اسم الصنف]=@nme where [id]=@prd_id
GO
 
-- Stored Procedure: update_product
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_product')
    DROP PROCEDURE [dbo].[update_product];
GO

CREATE proc [dbo].[update_product]
@nme varchar(50),
@qte int,
@pshr varchar(50),
@pg varchar(50),
@pb varchar(50),
@pmsthlk varchar(50),
@tmd varchar(50),
@img image,
 @id varchar (50),
 @kind nvarchar(50),
 @store nvarchar(100),
 @serial nvarchar(2000),
 @serial_number_mode TINYINT = 0
as 
UPDATE  products
set [اسم الصنف]  =@nme,
 [الكميه]=@qte,
 [سعر الشراء]=@pshr,
 [سعر الجمله] =@pg,
[سعر البيع] =@pb,
[سعر المستهلك]=@pmsthlk,
 [اجمالي المدفوع] =@tmd,
 صوره =@img,
 النوع=@kind,
 store=@store,
 سيريال=@serial
 , serial_number_mode = @serial_number_mode
 WHERE convert (varchar,id)=@id 

 



GO
 
-- Stored Procedure: update_product_after_mrtg3_mshtriat
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_product_after_mrtg3_mshtriat')
    DROP PROCEDURE [dbo].[update_product_after_mrtg3_mshtriat];
GO
create proc update_product_after_mrtg3_mshtriat
@id int,
@qte int
as
update products
set الكميه=الكميه-@qte,
	[اجمالي المدفوع]=CONVERT(float, [اجمالي المدفوع])-(@qte*convert(float,[سعر الشراء]))

	where id=@id
GO
 
-- Stored Procedure: update_product_serial
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_product_serial')
    DROP PROCEDURE [dbo].[update_product_serial];
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
 
-- Stored Procedure: update_products_first_rseed
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_products_first_rseed')
    DROP PROCEDURE [dbo].[update_products_first_rseed];
GO
create proc update_products_first_rseed
@prd_id int,
@qte int
as
begin
declare @exixts int
set @exixts=(select COUNT(*) from prd_first_rseed where [كود الصنف]=@prd_id)
if(@exixts>0)
begin
update prd_first_rseed set الكمية =@qte where [كود الصنف]= @prd_id 
end
else
begin
INSERT INTO [dbo].[prd_first_rseed]
           ([كود الصنف]
           ,[اسم الصنف]
           ,[الكمية]
           ,[السعر]
           ,[اجمالي المدفوع]
           ,[تاريخ الاضافة])
     VALUES
           (@prd_id
           ,(select [اسم الصنف] from products where id=@prd_id)
           ,@qte
           ,(select [سعر الشراء] from products where id=@prd_id)
           ,(@qte*convert(float,(select [سعر الشراء] from products where id=@prd_id)))
           ,convert(nvarchar(50),GETDATE()))
end

end
GO
 
-- Stored Procedure: update_total_mdfo3
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_total_mdfo3')
    DROP PROCEDURE [dbo].[update_total_mdfo3];
GO

create proc update_total_mdfo3
as
update products
set [اجمالي المدفوع]=convert(nvarchar(50),(الكميه*convert(float,[سعر الشراء])))

GO
 
-- Stored Procedure: update_total_mdfo3_to_zero
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_total_mdfo3_to_zero')
    DROP PROCEDURE [dbo].[update_total_mdfo3_to_zero];
GO

create proc [dbo].[update_total_mdfo3_to_zero]
@id int
as
update products
set [اجمالي المدفوع]=0
where products.id=@id
GO
 
-- Stored Procedure: update_total_w_msdd_fwateer_mwrd_case_add
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_total_w_msdd_fwateer_mwrd_case_add')
    DROP PROCEDURE [dbo].[update_total_w_msdd_fwateer_mwrd_case_add];
GO
CREATE proc update_total_w_msdd_fwateer_mwrd_case_add
@id int ,
@value float
as
update fwateer_mwrd set
[قيمة الفاتورة]=convert(nvarchar(50),(@value+convert(float,[قيمة الفاتورة]))),
المتبقي=convert(nvarchar(50),(@value+convert(float,المتبقي)))
where id=@id

update md5lat set
القيمة=convert(nvarchar(50),(@value+convert(float,القيمة)))
where id=@id
GO
 
-- Stored Procedure: update_total_w_reb7
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_total_w_reb7')
    DROP PROCEDURE [dbo].[update_total_w_reb7];
GO
CREATE proc [dbo].[update_total_w_reb7]
@id int,
@total varchar(50),
@reb7 varchar(50),
@mtbaki varchar(50)

as


UPDATE [dbo].[new_orders]
   SET
      [اجمالي الفاتورة] = @total
      ,[صافي الربح] = @reb7
	  ,[المبلغ المتبقي]=@mtbaki
 WHERE id_order=@id



GO
 
-- Stored Procedure: update_users
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'update_users')
    DROP PROCEDURE [dbo].[update_users];
GO
CREATE proc [dbo].[update_users]
@id varchar(50),
@pwd varchar(50),
@fullnme varchar(50)
as


UPDATE [dbo].[Table_users]
   SET 
      [pwd] =@pwd
      ,[full name] = @fullnme
	  where id=@id



GO
 
-- Stored Procedure: verifyqte
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'verifyqte')
    DROP PROCEDURE [dbo].[verifyqte];
GO
CREATE proc [dbo].[verifyqte]
@id_product int , @qte_entered int
as
select * from products
where id=@id_product and الكميه >= @qte_entered
GO
 
-- =============================================
-- EXPORT COMPLETE
-- =============================================

Completion time: 2026-03-08T21:56:39.7707250+02:00
