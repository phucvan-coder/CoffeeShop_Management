CREATE DATABASE QuanLyQuanCafe
GO
USE [QuanLyQuanCafe]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 06/08/2020 11:15:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 06/08/2020 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 06/08/2020 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 06/08/2020 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 06/08/2020 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 06/08/2020 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Kter') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Bàn chưa có tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO

-- Thêm bàn
DECLARE @i INT = 0

WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood ( name)VALUES  ( N'Bàn ' + CAST(@i+1 AS nvarchar(100)))
	SET @i = @i + 1
END
GO

Create PROC USP_GetTableList 
AS SELECT * from dbo.TableFood
Go
EXEC dbo.USP_GetTableList

-- Thêm category
INSERT dbo.FoodCategory
		( name )
VALUES  ( N'Coffee' )

INSERT dbo.FoodCategory
		( name )
VALUES  ( N'Sinh tố' )

INSERT dbo.FoodCategory
		( name )
VALUES  ( N'Trà sữa' )

INSERT dbo.FoodCategory
		( name )
VALUES  ( N'Nước ngọt' )

SELECT * FROM dbo.FoodCategory

-- Thêm món ăn
INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'White coffee',
			1,
			15000)

INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Espresso coffee',
			1,
			15000)

INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Cappuccino',
			1,
			20000)

INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Sinh tố chanh dây',
			2,
			25000)

INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Sinh tố dâu',
			2,
			25000)

INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Sinh tố xoài',
			2,
			25000)

INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Trà sữa Oreo Cake Cream',
			3,
			30000)
			
INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Trà sữa trân châu đường đen',
			3,
			30000)

INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Red bull',
			4,
			14000)
			
INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Coca cola',
			4,
			10000)

INSERT dbo.Food
		( name, idCategory, price )
VALUES	( N'Pepsi',
			4,
			10000)

SELECT * FROM dbo.Food

-- Thêm bill
INSERT dbo.Bill
		( DateCheckIn, DateCheckOut, idTable, status )
VALUES	(GETDATE(),
			NULL,
			1,
			0)

INSERT dbo.Bill
		( DateCheckIn, DateCheckOut, idTable, status )
VALUES	(GETDATE(),
			NULL,
			1,
			0)

INSERT dbo.Bill
		( DateCheckIn, DateCheckOut, idTable, status )
VALUES	(GETDATE(),
		 GETDATE(),
			2,
			1)

SELECT * FROM dbo.Bill

--Thêm bill info
INSERT dbo.BillInfo
		( idBill, idFood, count )
VALUES	( 1,
		  1,
		  2)

INSERT dbo.BillInfo
		( idBill, idFood, count )
VALUES	( 1,
		  3,
		  4)

INSERT dbo.BillInfo
		( idBill, idFood, count )
VALUES	( 1,
		  4,
		  1)

INSERT dbo.BillInfo
		( idBill, idFood, count )
VALUES	( 2,
		  1,
		  2)

INSERT dbo.BillInfo
		( idBill, idFood, count )
VALUES	( 2,
		  4,
		  2)

INSERT dbo.BillInfo
		( idBill, idFood, count )
VALUES	( 3,
		  3,
		  2)

SELECT * FROM dbo.BillInfo

-- Tạo procedure cho Bill
ALTER PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
		( DateCheckIn,
		  DateCheckOut,
		  idTable,
		  status,
		  discount
		  )
	VALUES ( GETDATE(),
			NULL,
			@idTable,
			0,
			0
			)

END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	INSERT dbo.BillInfo
		( idBill, idFood, count )
	VALUES	( @idBill,
			  @idFood,
			  @count)
END
GO

--Update BillInfo
ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1

	SELECT @isExitsBillInfo = id, @foodCount = b.count
	FROM dbo.BillInfo AS b
	WHERE idBill = @idBill AND idFood = @idFood

	IF(@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount > 0)
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT dbo.BillInfo
			( idBill, idFood, count )
		VALUES	( @idBill,
				  @idFood,
			   	  @count)
	END
END
GO

-- Tạo TRIGGER cho Bill và BillInfo
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM Inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM Inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	IF(@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

DELETE dbo.BillInfo
DELETE dbo.Bill


-- Thêm discount cho Bill
ALTER TABLE dbo.Bill
ADD discount INT

UPDATE dbo.Bill SET discount = 0

SELECT * FROM dbo.Bill

--//////////////////

ALTER PROC USP_SwitchTable
@idTable1 int, @idTable2 int
AS BEGIN
	DECLARE @idFirstBill int
	DECLARE @idSecondBill int

	DECLARE @isFirstEmpty INT = 1
	DECLARE @isSecondEmpty INT = 1

	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	IF(@idFirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill
			( DateCheckIn ,
			  DateCheckOut ,
			  idTable ,
			  status
			)
		VALUES ( GETDATE() ,
				 NULL ,
				 @idTable1 ,
				 0
				 )
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	END
		SELECT @isFirstEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	IF(@idSecondBill IS NULL)
	BEGIN
		INSERT dbo.Bill
			( DateCheckIn ,
			  DateCheckOut ,
			  idTable ,
			  status
			)
		VALUES ( GETDATE() ,
				 NULL ,
				 @idTable2 ,
				 0
				 )
		SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	END
		SELECT @isSecondEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSecondBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSecondBill
	UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	DROP TABLE IDBillInfoTable

	IF (@isFirstEmpty = 0) 
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
	IF (@isSecondEmpty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

--Tạo TRIGGER UPDATE TABLE
/*DROP 
TRIGGER UTG_UpdateTable
ON dbo.TableFood FOR UPDATE
AS
BEGIN
	DECLARE @idTable INT
	DECLARE @status NVARCHAR(100)

	SELECT @idTable = id FROM inserted

	DECLARE @idBill INT
	SELECT @idBill = id FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	DECLARE @countBillInfo INT
	SELECT @countBillInfo = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF (@countBillInfo > 0 AND @status <> N'Có người')
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	ELSE IF (@countBillInfo <= 0 AND @status <> N'Trống' )
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO*/
ALTER TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM Inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF (@count > 0)
	BEGIN
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
	END
	ELSE
	BEGIN
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	END
END
GO