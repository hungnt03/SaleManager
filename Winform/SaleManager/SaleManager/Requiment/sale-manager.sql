USE [HungTest]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [DF__Product__PriceBu__2EFAF1E2]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[Unit]
GO
/****** Object:  Table [dbo].[TransactionDetail]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[TransactionDetail]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[Transaction]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[Supplier]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[Product]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[Discount]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[ConvertProduct]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[ConvertProduct]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020/10/21 15:33:39 ******/
DROP TABLE [dbo].[Category]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Name] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConvertProduct]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConvertProduct](
	[Barcode] [nvarchar](16) NOT NULL,
	[Unit1] [int] NOT NULL,
	[Quantity1] [int] NOT NULL,
	[Unit2] [int] NOT NULL,
	[Quantity2] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_Convert] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[Unit1] ASC,
	[Unit2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Name] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[Contact] [nvarchar](250) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Barcode] [nvarchar](10) NULL,
	[Type] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Barcode] [nvarchar](16) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Name] [nvarchar](250) NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[SupplierId] [int] NOT NULL,
	[Pin] [bit] NULL,
	[Enable] [bit] NOT NULL,
	[ExpirationDate] [datetime2](7) NULL,
	[Unit] [int] NOT NULL,
	[Img] [nvarchar](max) NULL,
	[PriceBuy] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[Unit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Name] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[Contact1] [nvarchar](250) NULL,
	[Contact2] [nvarchar](250) NULL,
	[Note] [nvarchar](256) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Type] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[SuplierId] [int] NOT NULL,
	[IsPayment] [bit] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Payment] [decimal](18, 2) NOT NULL,
	[PayBack] [decimal](18, 2) NOT NULL,
	[BillNumber] [nvarchar](15) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetail]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetail](
	[Barcode] [nvarchar](12) NOT NULL,
	[TracsactionId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[SuplierId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[IsPayment] [bit] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TransactionDetail] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[TracsactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 2020/10/21 15:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (1, CAST(N'2020-07-10T09:39:16.0383993' AS DateTime2), N'administrator', NULL, NULL, N'Thực phẩm', N'Các loại hàng về Thực phẩm')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (2, CAST(N'2020-07-10T09:39:16.0399686' AS DateTime2), N'administrator', NULL, NULL, N'Rượu bia', N'Các loại hàng về Rượu bia')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (3, CAST(N'2020-07-10T09:39:16.0399714' AS DateTime2), N'administrator', NULL, NULL, N'Thuốc lá', N'Các loại hàng về Thuốc lá')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (4, CAST(N'2020-07-10T09:39:16.0399716' AS DateTime2), N'administrator', CAST(N'2020-09-28T11:34:06.7690996' AS DateTime2), N'administrator', N'Mỹ phẩm2', N'hàng về Mỹ phẩm')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (7, CAST(N'2020-09-28T11:43:41.5675390' AS DateTime2), N'administrator', CAST(N'2020-09-28T11:45:31.3207012' AS DateTime2), N'administrator', N'Nguyễn Trọng Hưng2', N'testtesttest2')
SET IDENTITY_INSERT [dbo].[Category] OFF
INSERT [dbo].[ConvertProduct] ([Barcode], [Unit1], [Quantity1], [Unit2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'3110354325000', 16, 1, 30, 100, CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[ConvertProduct] ([Barcode], [Unit1], [Quantity1], [Unit2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'3110354325000', 28, 1, 31, 20, CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[ConvertProduct] ([Barcode], [Unit1], [Quantity1], [Unit2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'3110354325000', 30, 1, 28, 10, CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (1, CAST(N'2020-07-10T09:39:16.0413281' AS DateTime2), N'administrator', NULL, NULL, N'Nguyễn Hữu Hoà', N'11b Cát Linh, Quốc Tử Giám, Đống Đa, Hà Nội', N'02438267984')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (2, CAST(N'2020-07-10T09:39:16.0413347' AS DateTime2), N'administrator', NULL, NULL, N'Trần Danh Mạnh', N'59 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội', N'02438226676')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (3, CAST(N'2020-07-10T09:39:16.0413349' AS DateTime2), N'administrator', NULL, NULL, N'Hoàng Tố Như', N'35 Lô 1A, đường, Trung Yên 11B, Trung Hoà, Cầu Giấy, Hà Nội', N'02436230311')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (4, CAST(N'2020-07-10T11:47:57.2482026' AS DateTime2), NULL, CAST(N'2020-07-10T11:56:18.4419081' AS DateTime2), N'administrator', N'Nguyễn Trường Linh', N'tòa nhà Hòa Bình, KCN Hoàng Mai, Hoàng Mai, Hà Nội', N'0963123192')
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'3110354325000', CAST(N'2020-07-10T09:39:16.0418435' AS DateTime2), N'administrator', NULL, NULL, N'Thuốc lá Thăng Long', 63, 10000, 3, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0415131' AS DateTime2), 28, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8004800008152', CAST(N'2020-07-10T09:39:16.0418541' AS DateTime2), N'administrator', NULL, NULL, N'Bánh Sampa Balocco Savoiardi 200g', 20, 59000, 1, 1, 0, 1, CAST(N'2021-07-10T09:39:16.0418475' AS DateTime2), 19, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8934637514871', CAST(N'2020-07-10T09:39:16.0418548' AS DateTime2), N'administrator', NULL, NULL, N'Sốt ướp thịt nướng', 30, 16000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418544' AS DateTime2), 27, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8934752060109', CAST(N'2020-07-10T09:39:16.0418552' AS DateTime2), N'administrator', NULL, NULL, N'Dấm trung thành 500ml', 50, 10400, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418550' AS DateTime2), 18, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8934804004044', CAST(N'2020-07-10T09:39:16.0418555' AS DateTime2), N'administrator', NULL, NULL, N'Dầu hào 350g', 30, 21000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418553' AS DateTime2), 18, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8934988021028', CAST(N'2020-07-10T09:39:16.0418558' AS DateTime2), N'administrator', NULL, NULL, N'Dầu ăn simply 2l', 10, 130000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418556' AS DateTime2), 18, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8935009922225', CAST(N'2020-07-10T09:39:16.0418562' AS DateTime2), N'administrator', NULL, NULL, N'Kẹo gấu thiên hồng 1kg', 15, 95000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418559' AS DateTime2), 19, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8936017364113', CAST(N'2020-07-10T09:39:16.0418565' AS DateTime2), N'administrator', NULL, NULL, N'Nước mắm Cá cốt ABC', 15, 12000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418563' AS DateTime2), 18, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8936017367046', CAST(N'2020-07-10T09:39:16.0418568' AS DateTime2), N'administrator', NULL, NULL, N'Tương cà chinsu 250g', 50, 12000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418566' AS DateTime2), 18, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8936028040426', CAST(N'2020-07-10T09:39:16.0418571' AS DateTime2), N'administrator', NULL, NULL, N'Sốt gia vị chinsu', 100, 15000, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418569' AS DateTime2), 18, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8936124472008', CAST(N'2020-07-10T09:39:16.0418574' AS DateTime2), N'administrator', NULL, NULL, N'Đậu phộng nước cốt dừa Tân Tân gói 75g', 30, 10000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418572' AS DateTime2), 19, N'', NULL)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy]) VALUES (N'8938503112147', CAST(N'2020-07-10T09:39:16.0418578' AS DateTime2), N'administrator', NULL, NULL, N'Mít sấy Vinamit gói 500g', 20, 143600, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418575' AS DateTime2), 19, N'', NULL)
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (1, CAST(N'2020-07-10T09:39:16.0420751' AS DateTime2), N'administrator', NULL, NULL, N'Nguyễn Thị Thuỷ(bibica)', N'183 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội', N'02437281476', NULL, NULL)
INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (2, CAST(N'2020-07-10T09:39:16.0420758' AS DateTime2), N'administrator', NULL, NULL, N'Nguyễn Đức Cảnh(ĐL cấp 1)', N'25 Văn Miếu, Đống Đa, Hà Nội, Vietnam', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (16, N'thùng', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (17, N'bịch', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (18, N'chai', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (19, N'gói', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (20, N'túi', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (21, N'viên', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (22, N'kg', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (23, N'gram', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (24, N'lạng', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (25, N'lít', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (26, N'ml', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (27, N'lọ', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (28, N'bao', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (29, N'cái', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (30, N'cây', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (31, N'điếu', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Unit] OFF
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [PriceBuy]
GO
