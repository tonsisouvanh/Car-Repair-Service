USE [GarageServiceDB]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_CalImportPrice]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_CalImportPrice]
(@quantity int, @partID int)
RETURNS money
AS
BEGIN
	declare @ImportPrice money;
	declare @result money;
	set @ImportPrice = 0;
	set @result = 0;


	select @ImportPrice = import_price from Part
	where partID = @partID
	
	set @result = @result + (@ImportPrice * @quantity)

	RETURN @result;

END;
GO
/****** Object:  UserDefinedFunction [dbo].[fn_CalPrice]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_CalPrice]
(@quantity int, @partID int)
RETURNS money
AS
BEGIN
	declare @price money;
	declare @result money;
	set @price = 0;
	set @result = 0;


	select @price = price from Part
	where partID = @partID
	
	set @result = @result + (@price * @quantity)

	RETURN @result;

END;
GO
/****** Object:  UserDefinedFunction [dbo].[fn_CalSellPrice]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_CalSellPrice]
(@quantity int, @partID int)
RETURNS money
AS
BEGIN
	declare @sellPrice money;
	declare @result money;
	set @sellPrice = 0;
	set @result = 0;


	select @sellPrice = price from Part
	where partID = @partID
	
	set @result = @result + (@sellPrice * @quantity)

	RETURN @result;

END;
GO
/****** Object:  Table [dbo].[Account]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[accountID] [int] IDENTITY(100,1) NOT NULL,
	[username] [varchar](125) NULL,
	[password] [varchar](8) NULL,
	[name] [nvarchar](125) NULL,
PRIMARY KEY CLUSTERED 
(
	[accountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customerID] [int] IDENTITY(100,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[email] [varchar](45) NULL,
	[phone] [varchar](20) NOT NULL,
	[province] [nvarchar](150) NULL,
	[district] [nvarchar](150) NULL,
	[address_detail] [nvarchar](250) NULL,
	[created_date] [date] NULL,
	[updated_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Districts]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Districts](
	[districtID] [int] IDENTITY(100,1) NOT NULL,
	[name] [nvarchar](55) NULL,
PRIMARY KEY CLUSTERED 
(
	[districtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Part]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Part](
	[partID] [int] IDENTITY(100,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[stock] [int] NULL,
	[import_price] [money] NULL,
	[price] [money] NULL,
	[currency] [varchar](12) NULL,
	[cal_unit] [nvarchar](50) NULL,
	[descriptions] [nvarchar](255) NULL,
	[part_type] [int] NULL,
	[brand] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[partID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartImportBill]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartImportBill](
	[importbillID] [int] IDENTITY(100,1) NOT NULL,
	[supplier] [nvarchar](255) NULL,
	[supplier_contact] [varchar](125) NULL,
	[status] [nvarchar](125) NULL,
	[payment] [nvarchar](25) NULL,
	[descriptions] [nvarchar](255) NULL,
	[total] [money] NULL,
	[created_date] [datetime] NULL,
	[updated_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[importbillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartImportBillDetail]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartImportBillDetail](
	[importbilldetailID] [int] IDENTITY(100,1) NOT NULL,
	[partID] [int] NOT NULL,
	[importbillID] [int] NOT NULL,
	[quantity] [int] NULL,
	[import_price] [money] NULL,
	[subtotal] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[importbilldetailID] ASC,
	[partID] ASC,
	[importbillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartType]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartType](
	[parttypeID] [int] IDENTITY(100,1) NOT NULL,
	[name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[parttypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[provinceID] [int] IDENTITY(100,1) NOT NULL,
	[name] [nvarchar](55) NULL,
PRIMARY KEY CLUSTERED 
(
	[provinceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RepairBill]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RepairBill](
	[repairbillID] [int] IDENTITY(100,1) NOT NULL,
	[customerID] [int] NULL,
	[status] [nvarchar](125) NULL,
	[payment] [nvarchar](25) NULL,
	[descriptions] [nvarchar](255) NULL,
	[total] [money] NULL,
	[created_date] [datetime] NULL,
	[updated_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[repairbillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RepairBillDetail]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RepairBillDetail](
	[repairbilldetailID] [int] IDENTITY(100,1) NOT NULL,
	[partID] [int] NOT NULL,
	[repairbillID] [int] NOT NULL,
	[quantity] [int] NULL,
	[part_price] [money] NULL,
	[subtotal] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[repairbilldetailID] ASC,
	[partID] ASC,
	[repairbillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[serviceID] [int] IDENTITY(100,1) NOT NULL,
	[repairbillID] [int] NOT NULL,
	[service] [nvarchar](255) NULL,
	[service_price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[serviceID] ASC,
	[repairbillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[vehicleID] [int] IDENTITY(100,1) NOT NULL,
	[name] [nvarchar](125) NULL,
	[color] [nvarchar](55) NULL,
	[typeID] [int] NULL,
	[brandID] [int] NULL,
	[plate_number] [nvarchar](15) NULL,
	[descriptions] [nvarchar](255) NULL,
	[customerID] [int] NULL,
	[oilchange_date] [date] NULL,
	[required_oilchange_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[vehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleBrand]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleBrand](
	[brandID] [int] IDENTITY(100,1) NOT NULL,
	[brand_name] [nvarchar](125) NULL,
PRIMARY KEY CLUSTERED 
(
	[brandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleType]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleType](
	[typeID] [int] IDENTITY(100,1) NOT NULL,
	[type_name] [nvarchar](125) NULL,
PRIMARY KEY CLUSTERED 
(
	[typeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([accountID], [username], [password], [name]) VALUES (100, N'admin', N'admin', N'Tons')
INSERT [dbo].[Account] ([accountID], [username], [password], [name]) VALUES (101, N'dith', N'12345678', N'ພອນປະດິດ')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([customerID], [name], [email], [phone], [province], [district], [address_detail], [created_date], [updated_date]) VALUES (100, N'ໂຕ້', N'to2022@gmail.com', N'02054433029', N'ອຸດົມໄຊ', N'ສີສັດຕະນາກ', N'14,ສຸພານຸວົງ', CAST(N'2022-08-31' AS Date), CAST(N'2022-09-04' AS Date))
INSERT [dbo].[Customer] ([customerID], [name], [email], [phone], [province], [district], [address_detail], [created_date], [updated_date]) VALUES (101, N'ແຈັກ', N'jack2022@gmail.com', N'02074433029', N'ນະຄອນຫຼວງວຽງຈັນ', N'ສີໂຄດຕະບອງ', N'13,ສຸພານຸວົງ', CAST(N'2022-08-31' AS Date), CAST(N'2022-09-03' AS Date))
INSERT [dbo].[Customer] ([customerID], [name], [email], [phone], [province], [district], [address_detail], [created_date], [updated_date]) VALUES (102, N'ແມັກ', N'mack2022@gmail.com', N'02054433021', N'ນະຄອນຫຼວງວຽງຈັນ', N'ໄຊເສດຖາ', N'12,ສຸພານຸວົງ', CAST(N'2022-08-31' AS Date), CAST(N'2022-08-31' AS Date))
INSERT [dbo].[Customer] ([customerID], [name], [email], [phone], [province], [district], [address_detail], [created_date], [updated_date]) VALUES (103, N'ຕົ້ນ', N'ton@gamil.com', N'02077022880', N'ຈຳປາສັກ', N'ກາສີ', N'', CAST(N'2022-08-31' AS Date), CAST(N'2022-08-31' AS Date))
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Districts] ON 

INSERT [dbo].[Districts] ([districtID], [name]) VALUES (139, N'ກວັນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (126, N'ກະເລິມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (127, N'ກາສີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (138, N'ຂວາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (136, N'ຄູນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (137, N'ຄຼນຄຳ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (135, N'ຄອບ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (131, N'ຄຳ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (132, N'ຄຳເກີດ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (165, N'ງອຍ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (163, N'ງາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (113, N'ຈັນທະບູລີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (114, N'ຈອມເພັດ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (111, N'ຈຳປາສັກ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (112, N'ຈຳພອນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (244, N'ຊົນບູລີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (243, N'ຊ່ອນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (229, N'ຊະນະຄາມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (199, N'ຊະນະສົມບູນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (201, N'ຊານໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (227, N'ຊຳເໜືອ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (228, N'ຊຳໃຕ້')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (242, N'ຊຽງຄໍ້')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (241, N'ຊຽງຮ່ອນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (240, N'ຊຽງເງີນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (166, N'ຍົມມະລາດ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (167, N'ຍອດອູ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (115, N'ດັກຈຶງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (218, N'ຕົ້ນເຜິ້ງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (219, N'ຕຸ້ມລານ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (210, N'ຕະໂອ່ຍ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (216, N'ທົ່ງມີໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (217, N'ທຸລະຄົມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (212, N'ທາພັງທອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (213, N'ທ່າພະບາດ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (211, N'ທ່າແຂກ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (214, N'ທ່າແຕງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (215, N'ທາໂທມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (156, N'ນາກາຍ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (162, N'ນາຊາຍທອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (161, N'ນານ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (157, N'ນາແລ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (159, N'ນາໝໍ້')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (160, N'ນ້ຳທາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (158, N'ນ້ຳບາກ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (107, N'ບຸນເໜືອ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (108, N'ບຸນໃຕ້')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (106, N'ບໍລິຄັນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (110, N'ບົວລະພາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (104, N'ບາຈຽງຈະເລີນສຸກ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (109, N'ບໍ່ແຕນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (181, N'ປະທຸມພອນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (174, N'ປາກກະດິງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (151, N'ປາກງື່ມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (178, N'ປາກຊັນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (176, N'ປາກຊ່ອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (177, N'ປາກທາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (180, N'ປາກລາຍ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (179, N'ປາກອູ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (175, N'ປາກເຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (172, N'ປາກແຊງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (173, N'ປາກແບງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (188, N'ຜົ້ງສາລີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (183, N'ຜາອຸດົມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (185, N'ຜາໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (192, N'ພູກູດ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (193, N'ພູຄູນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (187, N'ພິນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (194, N'ພູວົງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (184, N'ພະລານໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (186, N'ພຽງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (154, N'ມູນລະປະໂມກ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (149, N'ມະຫາໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (144, N'ລອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (146, N'ລ້ອງຊານ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (145, N'ລ້ອງແຈ້ງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (141, N'ລະຄອນເພງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (142, N'ລະມາມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (220, N'ວັງວຽງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (226, N'ວິລະບູລີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (221, N'ວາປີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (222, N'ວຽງຄຳ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (224, N'ວຽງທອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (223, N'ວຽງພູຄາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (225, N'ວຽງໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (209, N'ສຸຂຸມາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (205, N'ສິງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (200, N'ສັງທອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (208, N'ສົບເບົາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (206, N'ສີສັດຕະນາກ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (207, N'ສອງຄອນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (198, N'ສະໜາມໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (197, N'ສະໝ້ວຍ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (195, N'ສາມັກຄີໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (202, N'ສາລະວັນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (196, N'ສຳພັນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (204, N'ສີໂຄດຕະບອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (122, N'ຫົງສາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (119, N'ຫີນບູນ')
GO
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (120, N'ຫີນເຫີບ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (147, N'ຫຼວງພະບາງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (125, N'ຫ້ວຍຊາຍ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (124, N'ຫົວເມືອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (140, N'ຫຼາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (117, N'ຫາດຊາຍຟອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (171, N'ອຸທຸມພອນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (101, N'ອະນຸວົງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (102, N'ອາດສະພັງທອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (103, N'ອາດສະພອນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (123, N'ຮຸນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (121, N'ຮົ່ມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (118, N'ຮ້ຽມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (164, N'ເງີນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (239, N'ເຊບັ້ງໄຟ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (203, N'ເຊໂປນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (116, N'ເຟືອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (153, N'ເມິງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (143, N'ເລົ່າງາມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (129, N'ແກ່ນທ້າວ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (130, N'ແກ້ວອຸດົມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (105, N'ແບງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (182, N'ແປກ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (148, N'ແມດ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (100, N'ແອດ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (133, N'ໂຂງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (134, N'ໂຄງເຊໂດນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (190, N'ໂພນທອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (189, N'ໂພນໂຮງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (191, N'ໂພນໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (150, N'ໃໝ່')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (128, N'ໄກສອນພົມວິຫານ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (230, N'ໄຊ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (234, N'ໄຊຈຳພອນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (231, N'ໄຊຍະບູລີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (238, N'ໄຊທະນີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (233, N'ໄຊບູລີ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (232, N'ໄຊບົວທອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (235, N'ໄຊພູທອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (236, N'ໄຊສະຖານ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (237, N'ໄຊເສດຖາ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (152, N'ໜື່ນ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (155, N'ໜອກໄມ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (168, N'ໜອງ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (170, N'ໜອງແຣດ')
INSERT [dbo].[Districts] ([districtID], [name]) VALUES (169, N'ໝອງບົກ')
SET IDENTITY_INSERT [dbo].[Districts] OFF
GO
SET IDENTITY_INSERT [dbo].[Part] ON 

INSERT [dbo].[Part] ([partID], [name], [stock], [import_price], [price], [currency], [cal_unit], [descriptions], [part_type], [brand]) VALUES (100, N'ກົງລົດ d-max 4x4', 7, 520000.0000, 550000.0000, N'KIP', N'ຄູ່', N'', 100, N'Brano')
INSERT [dbo].[Part] ([partID], [name], [stock], [import_price], [price], [currency], [cal_unit], [descriptions], [part_type], [brand]) VALUES (101, N'ຢາງໃນ', 7, 150000.0000, 170000.0000, N'KIP', N'ອັນ', N'', 102, N'Feadant')
INSERT [dbo].[Part] ([partID], [name], [stock], [import_price], [price], [currency], [cal_unit], [descriptions], [part_type], [brand]) VALUES (102, N'ດອກໄຟ ເກາະ 1 ຈຸດຂາວ', 9, 85000.0000, 90000.0000, N'KIP', N'ກັບ', N'', 103, N'Zenky')
INSERT [dbo].[Part] ([partID], [name], [stock], [import_price], [price], [currency], [cal_unit], [descriptions], [part_type], [brand]) VALUES (103, N'ດອກໄຟ ສຽບ ສົ້ມ', 5, 23000.0000, 30000.0000, N'KIP', N'ກັບ', N'', 103, N'Mall')
INSERT [dbo].[Part] ([partID], [name], [stock], [import_price], [price], [currency], [cal_unit], [descriptions], [part_type], [brand]) VALUES (104, N'ດອກໄຟ HB 3', 3, 80000.0000, 95000.0000, N'KIP', N'ດອກໄຟ HB 3', N'', 103, N'benzo')
INSERT [dbo].[Part] ([partID], [name], [stock], [import_price], [price], [currency], [cal_unit], [descriptions], [part_type], [brand]) VALUES (105, N'ຟິວ 10,15,20,25,30', 4, 160000.0000, 220000.0000, N'KIP', N'ແພັກ', N'', 104, N'Nikky')
INSERT [dbo].[Part] ([partID], [name], [stock], [import_price], [price], [currency], [cal_unit], [descriptions], [part_type], [brand]) VALUES (106, N'ນ້ຳມັນເຄື່ອງ Mazda', 9, 100000.0000, 130000.0000, N'KIP', N'ຕຸກ', N'', 105, N'Bbordy')
INSERT [dbo].[Part] ([partID], [name], [stock], [import_price], [price], [currency], [cal_unit], [descriptions], [part_type], [brand]) VALUES (1101, N'ນ້ຳມັນເບຣກ', 4, 40000.0000, 45000.0000, N'KIP', N'ຕຸກ', N'', 1105, N'ປະເດດ')
SET IDENTITY_INSERT [dbo].[Part] OFF
GO
SET IDENTITY_INSERT [dbo].[PartImportBill] ON 

INSERT [dbo].[PartImportBill] ([importbillID], [supplier], [supplier_contact], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (100, N'ຈິບ ອາໄຫຼ່', N'jip@gmail.com', N'ຍັງບໍ່ຊຳລະ', N'ໂອນ', N'', 4000000.0000, CAST(N'2021-08-31T00:00:00.000' AS DateTime), CAST(N'2022-08-31T00:00:00.000' AS DateTime))
INSERT [dbo].[PartImportBill] ([importbillID], [supplier], [supplier_contact], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (101, N'ດາວວີປະດັບຍົນ', N'020553344291', N'ຈ່າຍແລ້ວ', N'ເງິນສົດ', N'', 1034000.0000, CAST(N'2022-08-31T00:00:00.000' AS DateTime), CAST(N'2022-08-31T00:00:00.000' AS DateTime))
INSERT [dbo].[PartImportBill] ([importbillID], [supplier], [supplier_contact], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (102, N'ເສັງສ້ອມແປງລົດຍົນ', N'seng@gmail.com', N'ຍັງບໍ່ຈ່າຍ', N'ໂອນ', N'', 2475000.0000, CAST(N'2022-08-31T00:00:00.000' AS DateTime), CAST(N'2022-08-31T00:00:00.000' AS DateTime))
INSERT [dbo].[PartImportBill] ([importbillID], [supplier], [supplier_contact], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (103, N'Banna Repair', N'09234693248', N'ຍັງບໍ່ຊຳລະ', N'cash', N'', 285000.0000, CAST(N'2022-09-03T00:00:00.000' AS DateTime), CAST(N'2022-09-03T00:00:00.000' AS DateTime))
INSERT [dbo].[PartImportBill] ([importbillID], [supplier], [supplier_contact], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (104, N'ເກັ່ງລວມອາໄຫຼ່', N'020556655907', N'ຍັງບໍ່ຊຳລະ', N'bcel', N'', 800000.0000, CAST(N'2022-09-04T20:42:50.000' AS DateTime), CAST(N'2022-09-04T20:42:50.087' AS DateTime))
INSERT [dbo].[PartImportBill] ([importbillID], [supplier], [supplier_contact], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (105, N'daf', N'289374', N'ຍັງບໍ່ຊຳລະ', N'', N'', 0.0000, CAST(N'2022-09-04T21:07:33.380' AS DateTime), CAST(N'2022-09-04T21:07:33.380' AS DateTime))
INSERT [dbo].[PartImportBill] ([importbillID], [supplier], [supplier_contact], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (106, N'abc', N'0238948345', N'ຍັງບໍ່ຊຳລະ', N'', N'', 1560000.0000, CAST(N'2022-09-04T21:40:18.327' AS DateTime), CAST(N'2022-09-04T21:40:18.327' AS DateTime))
SET IDENTITY_INSERT [dbo].[PartImportBill] OFF
GO
SET IDENTITY_INSERT [dbo].[PartImportBillDetail] ON 

INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (100, 100, 100, 5, 500000.0000, 2500000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (101, 101, 100, 10, 150000.0000, 1500000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (102, 102, 101, 10, 85000.0000, 850000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (103, 103, 101, 8, 23000.0000, 184000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (104, 104, 102, 5, 75000.0000, 375000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (105, 105, 102, 4, 150000.0000, 600000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (106, 106, 102, 15, 100000.0000, 1500000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (1101, 102, 103, 1, 85000.0000, 85000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (1103, 1101, 103, 5, 40000.0000, 200000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (1104, 105, 104, 3, 160000.0000, 480000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (1105, 104, 104, 4, 80000.0000, 320000.0000)
INSERT [dbo].[PartImportBillDetail] ([importbilldetailID], [partID], [importbillID], [quantity], [import_price], [subtotal]) VALUES (1106, 100, 106, 3, 520000.0000, 1560000.0000)
SET IDENTITY_INSERT [dbo].[PartImportBillDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[PartType] ON 

INSERT [dbo].[PartType] ([parttypeID], [name]) VALUES (100, N'ກົງລົດ')
INSERT [dbo].[PartType] ([parttypeID], [name]) VALUES (103, N'ດອກໄຟ')
INSERT [dbo].[PartType] ([parttypeID], [name]) VALUES (105, N'ນ້ຳມັນເຄື່ອງ')
INSERT [dbo].[PartType] ([parttypeID], [name]) VALUES (1105, N'ນ້ຳມັນເບຣກ')
INSERT [dbo].[PartType] ([parttypeID], [name]) VALUES (104, N'ຟິວ')
INSERT [dbo].[PartType] ([parttypeID], [name]) VALUES (102, N'ຢາງໃນ')
INSERT [dbo].[PartType] ([parttypeID], [name]) VALUES (101, N'ລໍ້ແມັກ')
SET IDENTITY_INSERT [dbo].[PartType] OFF
GO
SET IDENTITY_INSERT [dbo].[Provinces] ON 

INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (105, N'ຄຳມ່ວນ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (103, N'ຈຳປາສັກ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (117, N'ຊຽງຂວາງ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (114, N'ນະຄອນຫຼວງວຽງຈັນ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (102, N'ບໍລິຄຳໄຊ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (101, N'ບໍ່ແກ້ວ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (109, N'ຜົ້ງສາລີ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (113, N'ວຽງຈັນ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (111, N'ສະຫວັນນະເຂດ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (110, N'ສາລະວັນ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (106, N'ຫຼວງນ້ຳທາ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (107, N'ຫຼວງພະບາງ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (104, N'ຫົວພັນ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (100, N'ອັດຕະປື')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (108, N'ອຸດົມໄຊ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (112, N'ເຊກອງ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (115, N'ໄຊຍະບູລີ')
INSERT [dbo].[Provinces] ([provinceID], [name]) VALUES (116, N'ໄຊສົມບູນ')
SET IDENTITY_INSERT [dbo].[Provinces] OFF
GO
SET IDENTITY_INSERT [dbo].[RepairBill] ON 

INSERT [dbo].[RepairBill] ([repairbillID], [customerID], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (100, 103, N'ຊຳລະແລ້ວ', N'ເງິນສົດ', N'', 910000.0000, CAST(N'2022-08-31T00:00:00.000' AS DateTime), CAST(N'2022-08-31T00:00:00.000' AS DateTime))
INSERT [dbo].[RepairBill] ([repairbillID], [customerID], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (101, 103, N'ຊຳລະແລ້ວ', N'BCEL', N'', 318000.0000, CAST(N'2022-08-31T00:00:00.000' AS DateTime), CAST(N'2022-08-31T00:00:00.000' AS DateTime))
INSERT [dbo].[RepairBill] ([repairbillID], [customerID], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (102, 101, N'ຊຳລະແລ້ວ', N'ສົດ', N'', 533000.0000, CAST(N'2022-09-01T00:00:00.000' AS DateTime), CAST(N'2022-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[RepairBill] ([repairbillID], [customerID], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (1101, 102, N'ຊຳລະແລ້ວ', N'ເງິນສົດ', N'', 356000.0000, CAST(N'2022-09-03T00:00:00.000' AS DateTime), CAST(N'2022-09-03T00:00:00.000' AS DateTime))
INSERT [dbo].[RepairBill] ([repairbillID], [customerID], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (1102, 100, N'ຊຳລະແລ້ວ', N'cash', N'', 665000.0000, CAST(N'2022-09-04T20:46:31.000' AS DateTime), CAST(N'2022-09-04T20:46:31.717' AS DateTime))
INSERT [dbo].[RepairBill] ([repairbillID], [customerID], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (1103, 103, N'ຊຳລະແລ້ວ', N'cash', N'', 160000.0000, CAST(N'2022-09-04T21:07:45.000' AS DateTime), CAST(N'2022-09-04T21:07:45.700' AS DateTime))
INSERT [dbo].[RepairBill] ([repairbillID], [customerID], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (1104, 103, N'ຊຳລະແລ້ວ', N'cash', N'', 540000.0000, CAST(N'2022-09-04T21:46:12.710' AS DateTime), CAST(N'2022-09-04T21:46:12.710' AS DateTime))
INSERT [dbo].[RepairBill] ([repairbillID], [customerID], [status], [payment], [descriptions], [total], [created_date], [updated_date]) VALUES (1105, 102, N'ຊຳລະແລ້ວ', N'', N'', 130000.0000, CAST(N'2022-09-04T22:09:26.070' AS DateTime), CAST(N'2022-09-04T22:09:26.070' AS DateTime))
SET IDENTITY_INSERT [dbo].[RepairBill] OFF
GO
SET IDENTITY_INSERT [dbo].[RepairBillDetail] ON 

INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (100, 105, 100, 1, 200000.0000, 200000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (101, 102, 100, 2, 90000.0000, 180000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (103, 106, 100, 1, 130000.0000, 130000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (104, 101, 100, 2, 170000.0000, 340000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (1102, 104, 101, 1, 88000.0000, 88000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (1103, 105, 101, 1, 200000.0000, 200000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (1107, 106, 102, 1, 130000.0000, 130000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (1108, 105, 102, 1, 200000.0000, 200000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (1109, 104, 102, 1, 88000.0000, 88000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (1110, 103, 102, 1, 30000.0000, 30000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2101, 106, 1101, 1, 130000.0000, 130000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2102, 104, 1101, 2, 88000.0000, 176000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2103, 100, 1102, 1, 530000.0000, 530000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2104, 103, 1102, 2, 30000.0000, 60000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2105, 1101, 1102, 1, 45000.0000, 45000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2106, 106, 1103, 1, 130000.0000, 130000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2107, 101, 1104, 1, 170000.0000, 170000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2108, 104, 1104, 2, 95000.0000, 190000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2109, 106, 1104, 1, 130000.0000, 130000.0000)
INSERT [dbo].[RepairBillDetail] ([repairbilldetailID], [partID], [repairbillID], [quantity], [part_price], [subtotal]) VALUES (2112, 106, 1105, 1, 130000.0000, 130000.0000)
SET IDENTITY_INSERT [dbo].[RepairBillDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (100, 100, N'ຄ່າແຮງ', 40000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (101, 101, N'labour', 30000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (102, 102, N'labour', 40000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (1101, 102, N'fix', 25000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (1102, 102, N'asdf', 20000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (1103, 1101, N'ຄ່າແຮງ', 50000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (1104, 100, N'saf', 20000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (1105, 1102, N'labour', 30000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (1106, 1103, N'labour', 30000.0000)
INSERT [dbo].[Services] ([serviceID], [repairbillID], [service], [service_price]) VALUES (1107, 1104, N'ຄ່າແຮງ', 50000.0000)
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehicle] ON 

INSERT [dbo].[Vehicle] ([vehicleID], [name], [color], [typeID], [brandID], [plate_number], [descriptions], [customerID], [oilchange_date], [required_oilchange_date]) VALUES (102, N'Nissan 2022', N'ຂາວ,ແດງ', 101, 100, N'ກຂ 9823', N'ອະທິບາຍ', 100, CAST(N'2022-08-01' AS Date), CAST(N'2023-05-01' AS Date))
INSERT [dbo].[Vehicle] ([vehicleID], [name], [color], [typeID], [brandID], [plate_number], [descriptions], [customerID], [oilchange_date], [required_oilchange_date]) VALUES (103, N'Mazda cx3', N'ດຳ', 101, 102, N'ຂກ 4422', N'', 103, CAST(N'2022-08-31' AS Date), CAST(N'2023-03-31' AS Date))
INSERT [dbo].[Vehicle] ([vehicleID], [name], [color], [typeID], [brandID], [plate_number], [descriptions], [customerID], [oilchange_date], [required_oilchange_date]) VALUES (1103, N'Vigo', N'ຂາວ', 100, 1102, N'ກດ 4539', N'', 101, CAST(N'2022-09-03' AS Date), CAST(N'2022-11-03' AS Date))
INSERT [dbo].[Vehicle] ([vehicleID], [name], [color], [typeID], [brandID], [plate_number], [descriptions], [customerID], [oilchange_date], [required_oilchange_date]) VALUES (1104, N' Testla Model S', N'ດຳ', 100, 1104, N'ກກ 8888', N'', 102, CAST(N'2022-05-03' AS Date), CAST(N'2022-08-03' AS Date))
SET IDENTITY_INSERT [dbo].[Vehicle] OFF
GO
SET IDENTITY_INSERT [dbo].[VehicleBrand] ON 

INSERT [dbo].[VehicleBrand] ([brandID], [brand_name]) VALUES (101, N'Audi')
INSERT [dbo].[VehicleBrand] ([brandID], [brand_name]) VALUES (1103, N'Izuzu')
INSERT [dbo].[VehicleBrand] ([brandID], [brand_name]) VALUES (102, N'Mazda')
INSERT [dbo].[VehicleBrand] ([brandID], [brand_name]) VALUES (1104, N'Tesla')
INSERT [dbo].[VehicleBrand] ([brandID], [brand_name]) VALUES (100, N'TOYOTA')
INSERT [dbo].[VehicleBrand] ([brandID], [brand_name]) VALUES (1102, N'Vigo')
SET IDENTITY_INSERT [dbo].[VehicleBrand] OFF
GO
SET IDENTITY_INSERT [dbo].[VehicleType] ON 

INSERT [dbo].[VehicleType] ([typeID], [type_name]) VALUES (100, N'ລົດກະບະ')
INSERT [dbo].[VehicleType] ([typeID], [type_name]) VALUES (101, N'ລົດເກັງ')
SET IDENTITY_INSERT [dbo].[VehicleType] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Account__F3DBC572E0307825]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[Account] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Customer__AB6E6164FD64BE06]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Customer__B43B145FF5DFE287]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__District__72E12F1BBB00F7E8]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[Districts] ADD UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PartType__72E12F1BBFCA8CB5]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[PartType] ADD UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Province__72E12F1B75918DDC]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[Provinces] ADD UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Vehicle__87EF9F5946A87B81]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[Vehicle] ADD UNIQUE NONCLUSTERED 
(
	[plate_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__VehicleB__0C0C3B58B38EA245]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[VehicleBrand] ADD UNIQUE NONCLUSTERED 
(
	[brand_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__VehicleT__543C4FD95077A133]    Script Date: 9/4/2022 11:03:33 PM ******/
ALTER TABLE [dbo].[VehicleType] ADD UNIQUE NONCLUSTERED 
(
	[type_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (getdate()) FOR [created_date]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (getdate()) FOR [updated_date]
GO
ALTER TABLE [dbo].[Part] ADD  DEFAULT ((0)) FOR [stock]
GO
ALTER TABLE [dbo].[PartImportBill] ADD  DEFAULT ((0)) FOR [total]
GO
ALTER TABLE [dbo].[PartImportBill] ADD  DEFAULT (getdate()) FOR [created_date]
GO
ALTER TABLE [dbo].[PartImportBill] ADD  DEFAULT (getdate()) FOR [updated_date]
GO
ALTER TABLE [dbo].[PartImportBillDetail] ADD  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [dbo].[PartImportBillDetail] ADD  DEFAULT ((0)) FOR [subtotal]
GO
ALTER TABLE [dbo].[RepairBill] ADD  DEFAULT ((0)) FOR [total]
GO
ALTER TABLE [dbo].[RepairBill] ADD  DEFAULT (getdate()) FOR [created_date]
GO
ALTER TABLE [dbo].[RepairBill] ADD  DEFAULT (getdate()) FOR [updated_date]
GO
ALTER TABLE [dbo].[RepairBillDetail] ADD  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [dbo].[RepairBillDetail] ADD  DEFAULT ((0)) FOR [part_price]
GO
ALTER TABLE [dbo].[RepairBillDetail] ADD  DEFAULT ((0)) FOR [subtotal]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT ((0)) FOR [service_price]
GO
ALTER TABLE [dbo].[Part]  WITH CHECK ADD  CONSTRAINT [FK_Part_PartType] FOREIGN KEY([part_type])
REFERENCES [dbo].[PartType] ([parttypeID])
GO
ALTER TABLE [dbo].[Part] CHECK CONSTRAINT [FK_Part_PartType]
GO
ALTER TABLE [dbo].[PartImportBillDetail]  WITH CHECK ADD  CONSTRAINT [FK_PartImportBillDetail_Part] FOREIGN KEY([partID])
REFERENCES [dbo].[Part] ([partID])
GO
ALTER TABLE [dbo].[PartImportBillDetail] CHECK CONSTRAINT [FK_PartImportBillDetail_Part]
GO
ALTER TABLE [dbo].[PartImportBillDetail]  WITH CHECK ADD  CONSTRAINT [FK_PartImportBillDetail_PartImportBill] FOREIGN KEY([importbillID])
REFERENCES [dbo].[PartImportBill] ([importbillID])
GO
ALTER TABLE [dbo].[PartImportBillDetail] CHECK CONSTRAINT [FK_PartImportBillDetail_PartImportBill]
GO
ALTER TABLE [dbo].[RepairBill]  WITH CHECK ADD  CONSTRAINT [FK_RepairBill_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[RepairBill] CHECK CONSTRAINT [FK_RepairBill_Customer]
GO
ALTER TABLE [dbo].[RepairBillDetail]  WITH CHECK ADD  CONSTRAINT [FK_RepairBillDetail_Part] FOREIGN KEY([partID])
REFERENCES [dbo].[Part] ([partID])
GO
ALTER TABLE [dbo].[RepairBillDetail] CHECK CONSTRAINT [FK_RepairBillDetail_Part]
GO
ALTER TABLE [dbo].[RepairBillDetail]  WITH CHECK ADD  CONSTRAINT [FK_RepairBillDetail_RepairBill] FOREIGN KEY([repairbillID])
REFERENCES [dbo].[RepairBill] ([repairbillID])
GO
ALTER TABLE [dbo].[RepairBillDetail] CHECK CONSTRAINT [FK_RepairBillDetail_RepairBill]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_RepairBill] FOREIGN KEY([repairbillID])
REFERENCES [dbo].[RepairBill] ([repairbillID])
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_RepairBill]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Customer]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_VehicleBrand] FOREIGN KEY([brandID])
REFERENCES [dbo].[VehicleBrand] ([brandID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_VehicleBrand]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_VehicleType] FOREIGN KEY([typeID])
REFERENCES [dbo].[VehicleType] ([typeID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_VehicleType]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddBill]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddBill]
	@supplier nvarchar(255), @supplier_contact varchar(125),
	@status nvarchar(125), @payment nvarchar(25),
	@descriptions nvarchar(255)
as
begin

	INSERT INTO PartImportBill(supplier,supplier_contact,status,payment,descriptions)
	VALUES (@supplier, @supplier_contact,@status,@payment,@descriptions)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddCustomer]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddCustomer]
	@name nvarchar(255), @email varchar(45),
	@phone varchar(20), @province nvarchar(150),
	@district nvarchar(150), @address_detail nvarchar(250)
as
begin

	INSERT INTO Customer(name,email,phone,province,district,address_detail) 
	VALUES(@name,@email,@phone,@province,@district,@address_detail)
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddPart]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddPart] 
	@name nvarchar(255), @stock int, 
	@price money,@import_price money,
	@cal_unit nvarchar(55), @description nvarchar(255),
	@part_type int, @brand nvarchar(150),
	@importbillID int
as
begin

	INSERT INTO Part(name,stock,price,import_price,currency,cal_unit,descriptions,part_type,brand)	
	VALUES(@name, @stock,@price,@import_price,N'KIP',@cal_unit,@description,@part_type,@brand)

	Declare @partID int;
	Declare @subtotal money;

	IF(@@ROWCOUNT > 0)
	BEGIN
		set @partID = SCOPE_IDENTITY();
		--set @subtotal = dbo.fn_CalImportPrice(@stock,@partID);
		set @subtotal = @stock * @import_price;


		--handle bill total
		update PartImportBill
		--set total = total + dbo.fn_CalImportPrice(@stock,@partID)
		set total = total + @subtotal
		where importbillID = @importbillID;


		INSERT INTO PartImportBillDetail (partID, importbillID, quantity,import_price, subtotal)
		VALUES(@partID, @importBillID, @stock,@import_price, @subtotal)

		--UPDATE PartImportBillDetail
		--SET quantity = quantity + @quantity, subtotal = subtotal + dbo.fn_CalImportPrice(@quantity, @partID)
		--where importbillID = @importBillID and partID = @partID;

	END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddPartImportBill]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddPartImportBill]
	@supplier nvarchar(255), @supplier_contact varchar(125),
	@status nvarchar(125), @payment nvarchar(25),
	@descriptions nvarchar(255)
as
begin

	INSERT INTO PartImportBill(supplier,supplier_contact,status,payment,descriptions)
	VALUES (@supplier, @supplier_contact,@status,@payment,@descriptions)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddPartImportBillDetail]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddPartImportBillDetail]
	@partID int, @importBillID int, @quantity int, @import_price money
as
begin
	declare @subtotal money;
	set @subtotal = @quantity * @import_price;

	-- add new item
	IF NOT EXISTS(select * from PartImportBillDetail where partID = @partID and importbillID = @importbillID)
	BEGIN
		INSERT INTO PartImportBillDetail (partID, importbillID, quantity,import_price, subtotal)
		VALUES(@partID, @importBillID, @quantity,@import_price, @subtotal)
	END
	ELSE
	BEGIN
		UPDATE PartImportBillDetail
		SET quantity = quantity + @quantity, subtotal = subtotal + @subtotal
		where importbillID = @importBillID and partID = @partID;
	END

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update PartImportBill
		set total = total + @subtotal
		--set total = total + @subtotal
		where importbillID = @importbillID;


		--handle part stock
		update Part
		set stock = stock + @quantity
		where partID = @partID;
	END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddRepairBill]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddRepairBill]
	@customerID int,@status nvarchar(125), @payment nvarchar(25),
	@descriptions nvarchar(255)
as
begin

	INSERT INTO RepairBill(customerID,status,payment,descriptions)
	VALUES (@customerID,@status,@payment,@descriptions)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddRepairBillDetail]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddRepairBillDetail]
	@partID int, @repairbillID int,@quantity int,@part_price money
as
begin
	
	declare @subtotal money;
	set @subtotal = @quantity * @part_price;

	-- add new item
	IF NOT EXISTS(select * from RepairBillDetail where partID = @partID and repairbillID = @repairbillID)
	BEGIN
		INSERT INTO RepairBillDetail(partID, repairbillID, quantity,part_price, subtotal)
		VALUES(@partID, @repairbillID, @quantity,@part_price, @subtotal)
	END
	ELSE
	BEGIN
		UPDATE RepairBillDetail
		SET quantity = quantity + @quantity, subtotal = subtotal + @subtotal
		where repairbillID = @repairbillID and partID = @partID;
	END

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update RepairBill
		set total = total + @subtotal
		where repairbillID = @repairbillID;


		--handle part stock
		update Part
		set stock = stock - @quantity
		where partID = @partID;
	END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_addService]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_addService]
	@repairbillID int,
	@service nvarchar(255),
	@service_price money
as
begin
	INSERT INTO Services(repairbillID,service,service_price)
	VALUES(@repairbillID,@service,@service_price)

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update RepairBill
		set total = total + @service_price
		where repairbillID = @repairbillID;
	END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddVehicle]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddVehicle]
	@name nvarchar(255), @color nvarchar(55),
	@typeID int, @brandID int,
	@plate_number nvarchar(20), @descriptions nvarchar(250),
	@customerID int
as
begin

	INSERT INTO Vehicle(name,color,typeID,brandID,plate_number,descriptions,customerID) 
	VALUES(@name, @color, @typeID, @brandID, @plate_number, @descriptions, @customerID)
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeletePartImportBillDetail]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DeletePartImportBillDetail]
	@importbilldetailID int,@partID int, @importBillID int, @quantity int, @subtotal money
as
begin
	
	DELETE PartImportBillDetail
	WHERE importbilldetailID = @importbilldetailID

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update PartImportBill
		set total = total - @subtotal
		--set total = total + @subtotal
		where importbillID = @importBillID;


		--handle part stock
		update Part
		set stock = stock - @quantity
		where partID = @partID;
	END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteRepairBillDetail]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DeleteRepairBillDetail]
	@repairbilldetailID int,@partID int, @repairbillID int, @quantity int, @subtotal money
as
begin
	
	DELETE RepairBillDetail
	WHERE repairbilldetailID = @repairbilldetailID

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update RepairBill
		set total = total - @subtotal
		where repairbillID = @repairbillID;


		--handle part stock
		update Part
		set stock = stock + @quantity
		where partID = @partID;
	END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteService]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteService]
	@serviceID int,
	@repairbillID int,
	@service_price money
as
begin
	DELETE Services where serviceID = @serviceID;

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update RepairBill
		set total = total - @service_price
		where repairbillID = @repairbillID;
	END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCustomer]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdateCustomer]
	@name nvarchar(255), @email varchar(45),
	@phone varchar(20), @province nvarchar(150),
	@district nvarchar(150), @address_detail nvarchar(250),
	@customerID int
as
begin

	UPDATE Customer
	set name = @name,email = @email,phone = @phone,province = @province,
	district = @district,address_detail = @address_detail, updated_date = getdate()
	where customerID = @customerID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePart]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdatePart] 
	@name nvarchar(255), @stock int, 
	@price money,@import_price money,
	@cal_unit nvarchar(55), @description nvarchar(255),
	@part_type int, @brand nvarchar(150), @partId int
as
begin

	UPDATE Part SET name = @name,
					stock = @stock,
					price = @price,
					import_price = @import_price,
					cal_unit = @cal_unit,
					descriptions = @description,
					part_type = @part_type,
					brand = @brand
	WHERE partID = @partId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePartImportBill]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdatePartImportBill]
	@supplier nvarchar(255), @supplier_contact varchar(125),
	@status nvarchar(125), @payment nvarchar(25), @created_date datetime,
	@descriptions nvarchar(255), @billID int
as
begin

	UPDATE PartImportBill
	SET supplier = @supplier,supplier_contact = @supplier_contact,status = @status,payment = @payment,
	descriptions = @descriptions, created_date = @created_date
	WHERE importbillID = @billID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRepairBill]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdateRepairBill]
	@status nvarchar(125), @payment nvarchar(25), @created_date datetime,
	@descriptions nvarchar(255),@repairbillID int
as
begin

	UPDATE RepairBill
	SET status = @status,payment = @payment,descriptions = @descriptions, created_date = @created_date
	WHERE repairbillID = @repairbillID

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateVehicle]    Script Date: 9/4/2022 11:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdateVehicle]
	@name nvarchar(255), @color nvarchar(55),
	@typeID int, @brandID int,
	@plate_number nvarchar(20), @descriptions nvarchar(250),
	@vehicleID int, @customerID int
as
begin

	UPDATE Vehicle
	SET name = @name,color = @color,typeID = @typeID,brandID = @brandID,
			plate_number = @plate_number,descriptions = @descriptions
			where vehicleID = @vehicleID and customerID = @customerID
	
end
GO
