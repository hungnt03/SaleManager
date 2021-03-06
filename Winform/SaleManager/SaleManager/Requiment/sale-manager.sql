USE [HungTest]
GO
ALTER TABLE [dbo].[AspNetUserTokens] DROP CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims] DROP CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [DF__Product__Interes__369C13AA]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [DF__Product__PriceBu__2EFAF1E2]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[Unit]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[Supplier]
GO
/****** Object:  Table [dbo].[ProductHistory]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[ProductHistory]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[Discount]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[ConvertProduct]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[ConvertProduct]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[Category]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[AspNetUserTokens]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[AspNetUsers]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[AspNetUserRoles]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[AspNetUserLogins]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[AspNetUserClaims]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[AspNetRoles]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[AspNetRoleClaims]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[__EFMigrationsHistory]
GO
/****** Object:  View [dbo].[V_Revenue]    Script Date: 2020/12/25 14:03:25 ******/
DROP VIEW [dbo].[V_Revenue]
GO
/****** Object:  Table [dbo].[TransactionDetail]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[TransactionDetail]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[Transaction]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2020/12/25 14:03:25 ******/
DROP TABLE [dbo].[Product]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2020/12/25 14:03:25 ******/
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
	[Interest] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[Unit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 2020/12/25 14:03:26 ******/
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
	[CustomerId] [int] NULL,
	[SuplierId] [int] NULL,
	[IsPayment] [bit] NOT NULL,
	[Amount] [int] NULL,
	[Payment] [int] NULL,
	[PayBack] [int] NULL,
	[BillNumber] [nvarchar](15) NULL,
	[Note] [varchar](255) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetail]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetail](
	[Barcode] [nvarchar](16) NOT NULL,
	[TracsactionId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[SuplierId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[IsPayment] [bit] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Unit] [int] NULL,
	[IsDiscount] [bit] NULL,
 CONSTRAINT [PK_TransactionDetail] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[TracsactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Revenue]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


  CREATE VIEW [dbo].[V_Revenue] AS
  select tb1.CreateAt, SUM(tb1.Amount) as Amount, sum(tb1.detailTotal) as DetailTotal, sum(tb1.interest) as Interest from
(
SELECT 
	  CONVERT(NVARCHAR,  trans.[CreatedAt], 111) as CreateAt
      ,trans.[Amount]
	  --,detail.[Barcode]
	  ,detail.[Amount] as detailTotal
	  ,(product.Price-product.PriceBuy) as interest
  FROM [HungTest].[dbo].[Transaction] as trans
  join [HungTest].[dbo].[TransactionDetail] as detail on trans.Id = detail.TracsactionId
  join [HungTest].[dbo].[Product] as product on detail.Barcode = product.Barcode
  where [Type] = 1
  ) as tb1
  group by CreateAt
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020/12/25 14:03:26 ******/
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
/****** Object:  Table [dbo].[ConvertProduct]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConvertProduct](
	[Barcode1] [nvarchar](16) NOT NULL,
	[Quantity1] [int] NOT NULL,
	[Barcode2] [nvarchar](16) NOT NULL,
	[Quantity2] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_Convert] PRIMARY KEY CLUSTERED 
(
	[Barcode1] ASC,
	[Barcode2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2020/12/25 14:03:26 ******/
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
/****** Object:  Table [dbo].[Discount]    Script Date: 2020/12/25 14:03:26 ******/
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
	[Barcode] [nvarchar](16) NOT NULL,
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
/****** Object:  Table [dbo].[ProductHistory]    Script Date: 2020/12/25 14:03:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [nvarchar](16) NOT NULL,
	[Unit] [int] NOT NULL,
	[NameOld] [nvarchar](250) NULL,
	[NameNew] [nvarchar](250) NULL,
	[PriceBuyOld] [int] NULL,
	[PriceBuyNew] [int] NULL,
	[InterestOld] [int] NULL,
	[InterestNew] [int] NULL,
	[PriceOld] [int] NULL,
	[PriceNew] [int] NULL,
	[QuantityOld] [int] NULL,
	[QuantityNew] [int] NULL,
	[CategoryIdOld] [int] NULL,
	[CategoryIdNew] [int] NULL,
	[SupplierIdOld] [int] NULL,
	[SupplierIdNew] [int] NULL,
	[PinOld] [bit] NULL,
	[PinNew] [bit] NULL,
	[EnableOld] [bit] NULL,
	[EnableNew] [bit] NULL,
	[ExpirationDateOld] [datetime2](7) NULL,
	[ExpirationDateNew] [datetime2](7) NULL,
	[ImgOld] [nvarchar](max) NULL,
	[ImgNew] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_ProductHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2020/12/25 14:03:26 ******/
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
/****** Object:  Table [dbo].[Unit]    Script Date: 2020/12/25 14:03:26 ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200709013723_init', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200709045716_addMainTable', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710003530_UpdateProduct20200710-1', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710003625_UpdateProduct20200710-2', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710003719_UpdateProduct20200710-3', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710003811_UpdateProduct20200710-4', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710003916_SeddingData20200710-1', N'3.1.5')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1fb6c99f-6fe9-4164-8715-6fd29c7a6be6', N'employee', N'EMPLOYEE', N'8e0f6b43-be9e-48d5-8bd8-985cd24c57b6')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e9aaf1c8-540c-434f-b8fc-122c85d49b75', N'user', N'USER', N'9a873bbd-1215-4085-b62e-9817f0363278')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ef9ac322-6edf-4e35-a7a9-29b54289da72', N'admin', N'ADMIN', N'283eed1d-b7fb-44d0-806b-3817b526078f')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5358fb42-b047-46f4-a4e9-e2a0d02a4e6b', N'ef9ac322-6edf-4e35-a7a9-29b54289da72')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5358fb42-b047-46f4-a4e9-e2a0d02a4e6b', N'hungnt03', N'HUNGNT03', N'hungnt.hut56@gmail.com', N'HUNGNT.HUT56@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAENGefkpCKf1mqan0rGroJZHWnfRSje+s3vM5Zeu2dLxSDbaY9BEnCVdIgUW4ZuCyIQ==', N'WVG6QBPRDD3M3FPA22KZ3D33EAV6IRAK', N'c79d74df-0ef5-4908-ac9b-e452a45666c1', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e3ba8f63-28da-41ec-9fcb-24cb18dc7993', N'hungnt.s18@gmail.com', N'HUNGNT.S18@GMAIL.COM', N'hungnt.s18@gmail.com', N'HUNGNT.S18@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJ30AoiZcmDFjc64jxxnuWZWGP7GKJE5GYPOexnr4mdvdZazNtRZMNq8wmQ4C+9U7w==', N'3Y6A3L57A3I74GB6KBSAOTHOKHL3CDHO', N'fd6a916a-4909-4c5a-8687-ed76bfa01d6c', NULL, 0, 0, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (1, CAST(N'2020-07-10T09:39:16.0383993' AS DateTime2), N'administrator', NULL, NULL, N'Thực phẩm', N'Các loại hàng về Thực phẩm')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (2, CAST(N'2020-07-10T09:39:16.0399686' AS DateTime2), N'administrator', NULL, NULL, N'Rượu bia', N'Các loại hàng về Rượu bia')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (3, CAST(N'2020-07-10T09:39:16.0399714' AS DateTime2), N'administrator', NULL, NULL, N'Thuốc lá', N'Các loại hàng về Thuốc lá')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (4, CAST(N'2020-07-10T09:39:16.0399716' AS DateTime2), N'administrator', CAST(N'2020-09-28T11:34:06.7690996' AS DateTime2), N'administrator', N'Mỹ phẩm2', N'hàng về Mỹ phẩm')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (7, CAST(N'2020-09-28T11:43:41.5675390' AS DateTime2), N'administrator', CAST(N'2020-09-28T11:45:31.3207012' AS DateTime2), N'administrator', N'Nguyễn Trọng Hưng2', N'testtesttest2')
SET IDENTITY_INSERT [dbo].[Category] OFF
INSERT [dbo].[ConvertProduct] ([Barcode1], [Quantity1], [Barcode2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'9991335735726', 1, N'3110354325000', 10, NULL, NULL, NULL, NULL)
INSERT [dbo].[ConvertProduct] ([Barcode1], [Quantity1], [Barcode2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'9991989327852', 1, N'3110354325000', 201, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (1, CAST(N'2020-07-10T09:39:16.0413281' AS DateTime2), N'administrator', NULL, NULL, N'Nguyễn Hữu Hoà', N'11b Cát Linh, Quốc Tử Giám, Đống Đa, Hà Nội', N'02438267984')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (2, CAST(N'2020-07-10T09:39:16.0413347' AS DateTime2), N'administrator', NULL, NULL, N'Trần Danh Mạnh', N'59 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội', N'02438226676')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (3, CAST(N'2020-07-10T09:39:16.0413349' AS DateTime2), N'administrator', NULL, NULL, N'Hoàng Tố Như', N'35 Lô 1A, đường, Trung Yên 11B, Trung Hoà, Cầu Giấy, Hà Nội', N'02436230311')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (4, CAST(N'2020-07-10T11:47:57.2482026' AS DateTime2), NULL, CAST(N'2020-07-10T11:56:18.4419081' AS DateTime2), N'administrator', N'Nguyễn Trường Linh', N'tòa nhà Hòa Bình, KCN Hoàng Mai, Hoàng Mai, Hà Nội', N'0963123192')
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'3110354325000', CAST(N'2020-07-10T09:39:16.0418435' AS DateTime2), N'administrator', CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', N'Thuốc lá Thăng Long(bao)', 685, 10000, 3, 1, 0, 1, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), 28, N'3110354325000.jpg', 8000, 2000)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8004800008152', CAST(N'2020-07-10T09:39:16.0418541' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9726185' AS DateTime2), N'Administrator', N'Bánh Sampa Balocco Savoiardi 200g', 80, 59000, 1, 2, 0, 1, CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), 19, N'8004800008152.jpg', 55000, 4000)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8934637514871', CAST(N'2020-07-10T09:39:16.0418548' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9736199' AS DateTime2), N'Administrator', N'Sốt ướp thịt nướng', 30, 16000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418544' AS DateTime2), 27, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8934752060109', CAST(N'2020-07-10T09:39:16.0418552' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9736199' AS DateTime2), N'Administrator', N'Dấm trung thành 500ml', 50, 10400, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418550' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8934804004044', CAST(N'2020-07-10T09:39:16.0418555' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9746199' AS DateTime2), N'Administrator', N'Dầu hào 350g', 30, 21000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418553' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8934988021028', CAST(N'2020-07-10T09:39:16.0418558' AS DateTime2), N'administrator', CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', N'Dầu ăn simply 2l', 42, 140000, 1, 11, 0, 1, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), 18, NULL, 118200, 21800)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8935009922225', CAST(N'2020-07-10T09:39:16.0418562' AS DateTime2), N'administrator', CAST(N'2020-12-21T16:12:46.9568346' AS DateTime2), N'Administrator', N'Kẹo gấu thiên hồng 1kg', 25, 95000, 1, 9, 0, 1, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), 19, NULL, 90300, 4700)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8936017364113', CAST(N'2020-07-10T09:39:16.0418565' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9756194' AS DateTime2), N'Administrator', N'Nước mắm Cá cốt ABC', 9, 12000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418563' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8936017367046', CAST(N'2020-07-10T09:39:16.0418568' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9756194' AS DateTime2), N'Administrator', N'Tương cà chinsu 250g', 50, 12000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418566' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8936028040426', CAST(N'2020-07-10T09:39:16.0418571' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9766193' AS DateTime2), N'Administrator', N'Sốt gia vị chinsu', 92, 15000, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418569' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8936124472008', CAST(N'2020-07-10T09:39:16.0418574' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9766193' AS DateTime2), N'Administrator', N'Đậu phộng nước cốt dừa Tân Tân gói 75g', 23, 10000, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418572' AS DateTime2), 19, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8938503112147', CAST(N'2020-07-10T09:39:16.0418578' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9776188' AS DateTime2), N'Administrator', N'Mít sấy Vinamit gói 500g', 14, 143600, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418575' AS DateTime2), 19, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'9991294713579', CAST(N'2020-11-07T10:15:28.0261900' AS DateTime2), N'Administrator', CAST(N'2020-12-15T13:10:49.9776188' AS DateTime2), N'Administrator', N'Mi tom hh', 9, 3000, 1, 1, 1, 1, CAST(N'2021-05-12T10:14:40.0000000' AS DateTime2), 19, NULL, 2800, 200)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'9991335735726', CAST(N'2020-12-14T14:12:26.0591473' AS DateTime2), N'Administrator', CAST(N'2020-12-21T16:12:46.9568346' AS DateTime2), N'Administrator', N'Thuốc lá Thăng Long(cây)', 28, 80000, 3, 10, 1, 1, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), 30, NULL, 65400, 14600)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'9991989327852', CAST(N'2020-12-14T14:15:50.6585787' AS DateTime2), N'Administrator', CAST(N'2020-12-15T13:10:49.9786199' AS DateTime2), N'Administrator', N'Thuốc lá Thăng Long(thùng)', 1, 1500000, 3, 2, 1, 1, CAST(N'2021-07-21T14:12:39.0000000' AS DateTime2), 16, NULL, 1400000, 0)
SET IDENTITY_INSERT [dbo].[ProductHistory] ON 

INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (1, N'3110354325000', 28, N'Thuốc lá Thăng Long', N'Thuốc lá Thăng Long', 8000, 8000, 2000, 2000, 10000, 10000, 263, 100, NULL, NULL, NULL, 1, NULL, NULL, NULL, 1, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (2, N'8004800008152', 19, N'Bánh Sampa Balocco Savoiardi 200g', N'Bánh Sampa Balocco Savoiardi 200g', 55000, 55000, 4000, 4000, 59000, 59000, 40, 10, NULL, NULL, NULL, 2, NULL, NULL, NULL, 1, CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (5, N'3110354325000', 28, N'Thuốc lá Thăng Long', N'Thuốc lá Thăng Long', 8000, 8000, 2000, 2000, 10000, 10000, 363, 100, NULL, NULL, NULL, 1, NULL, NULL, NULL, 1, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (6, N'8004800008152', 19, N'Bánh Sampa Balocco Savoiardi 200g', N'Bánh Sampa Balocco Savoiardi 200g', 55000, 55000, 4000, 4000, 59000, 59000, 50, 10, NULL, NULL, NULL, 2, NULL, NULL, NULL, 1, CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (7, N'3110354325000', 28, N'Thuốc lá Thăng Long', N'Thuốc lá Thăng Long', 8000, 8000, 2000, 2000, 10000, 10000, 463, 100, NULL, NULL, NULL, 1, NULL, NULL, NULL, 1, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (8, N'8004800008152', 19, N'Bánh Sampa Balocco Savoiardi 200g', N'Bánh Sampa Balocco Savoiardi 200g', 55000, 55000, 4000, 4000, 59000, 59000, 60, 10, NULL, NULL, NULL, 2, NULL, NULL, NULL, 1, CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (9, N'8936017364113', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 14, 13, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:30:57.7673452' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (10, N'8936028040426', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 98, 96, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:30:57.7683479' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (12, N'8936124472008', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 29, 28, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:33:16.0479146' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (13, N'8938503112147', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 19, 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:35:12.6740872' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (14, N'8938503112147', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 18, 17, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:36:36.7022918' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (15, N'8936028040426', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 96, 94, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:36:36.7032914' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (16, N'8936017364113', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 13, 12, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:39:29.3629324' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (17, N'8938503112147', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 17, 16, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:39:29.3639324' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (18, N'8936124472008', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 28, 27, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-09T10:41:48.6230845' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (19, N'3110354325000', 28, N'Thuốc lá Thăng Long', N'Thuốc lá Thăng Long', 8000, 8000, 2000, 2000, 10000, 10000, 563, 663, NULL, NULL, 1, 1, NULL, NULL, NULL, NULL, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-11T09:29:45.2998976' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (20, N'8004800008152', 19, N'Bánh Sampa Balocco Savoiardi 200g', N'Bánh Sampa Balocco Savoiardi 200g', 55000, 55000, 4000, 4000, 59000, 59000, 70, 80, NULL, NULL, 2, 2, NULL, NULL, NULL, NULL, CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-11T09:29:45.3008974' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (21, N'8936017364113', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 11, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-11T09:30:17.2224389' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (22, N'8936028040426', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 95, 94, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-11T09:30:17.2234376' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (23, N'8938503112147', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 15, 13, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-11T09:30:17.2244389' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (24, N'9991294713579', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 19, 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-11T09:30:17.2244389' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (25, N'8936017364113', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-11T10:05:14.3161378' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (26, N'8936028040426', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 94, 93, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-11T10:05:14.3171355' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (27, N'3110354325000', 28, N'Thuốc lá Thăng Long', N'Thuốc lá Thăng Long', 8000, 8000, 2000, 2000, 10000, 10000, 663, 763, NULL, NULL, 1, 1, NULL, NULL, NULL, NULL, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-11T10:11:11.3552866' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (28, N'8004800008152', 19, N'Bánh Sampa Balocco Savoiardi 200g', N'Bánh Sampa Balocco Savoiardi 200g', 55000, 55000, 4000, 4000, 59000, 59000, 80, 90, NULL, NULL, 2, 2, NULL, NULL, NULL, NULL, CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-11T10:11:11.3562857' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (29, N'8934988021028', 18, N'Dầu ăn simply 2l', N'Dầu ăn simply 2l', 130000, 130000, 10000, 10000, 140000, 140000, 20, 30, NULL, NULL, 1, 1, NULL, NULL, NULL, NULL, CAST(N'2022-12-14T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-14T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-14T13:52:57.0339126' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (30, N'3110354325000', 30, NULL, N'Thuốc lá Thăng Long', NULL, 75000, NULL, 5000, NULL, 80000, NULL, 10, NULL, NULL, NULL, 2, NULL, NULL, NULL, NULL, NULL, CAST(N'2024-04-14T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-14T13:52:57.0359158' AS DateTime2), N'Administrator', NULL, NULL, 1)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (31, N'3110354325000', 28, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 662, 661, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-14T14:06:34.1286854' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (32, N'3110354325000', 28, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 661, 660, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-14T14:08:03.9145991' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (39, N'8934988021028', 18, N'Dầu ăn simply 2l', N'Dầu ăn simply 2l', 118200, 118200, 21800, 21800, 140000, 140000, 30, 40, NULL, NULL, 11, 11, NULL, NULL, NULL, NULL, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-21T16:04:58.7331673' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (40, N'8934988021028', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 30, 31, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (41, N'9991335735726', 30, N'Thuốc lá Thăng Long(cây)', N'Thuốc lá Thăng Long', 65400, 65400, 14600, 14600, 80000, 80000, 18, 28, NULL, NULL, 10, 10, NULL, NULL, NULL, NULL, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-21T16:04:58.7341674' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (42, N'3110354325000', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 681, 683, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (43, N'9991335735726', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 18, 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (44, N'8935009922225', 30, NULL, N'Kẹo gấu thiên hồng 1kg', NULL, 90300, NULL, 4700, NULL, 95000, NULL, 10, NULL, NULL, NULL, 9, NULL, NULL, NULL, NULL, NULL, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-21T16:04:58.7351673' AS DateTime2), N'Administrator', NULL, NULL, 1)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (45, N'8934988021028', 18, N'Dầu ăn simply 2l', N'Dầu ăn simply 2l', 118200, 118200, 21800, 21800, 140000, 140000, 41, 51, NULL, NULL, 11, 11, NULL, NULL, NULL, NULL, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-21T16:12:46.9548332' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (46, N'8934988021028', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 41, 42, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (47, N'9991335735726', 30, N'Thuốc lá Thăng Long(cây)', N'Thuốc lá Thăng Long', 65400, 65400, 14600, 14600, 80000, 80000, 29, 39, NULL, NULL, 10, 10, NULL, NULL, NULL, NULL, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (48, N'3110354325000', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 683, 685, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (49, N'9991335735726', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 29, 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (50, N'8935009922225', 19, N'Kẹo gấu thiên hồng 1kg', N'Kẹo gấu thiên hồng 1kg', 90300, 90300, 4700, 4700, 95000, 95000, 25, 35, NULL, NULL, 9, 9, NULL, NULL, NULL, NULL, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2020-12-21T16:12:46.9568346' AS DateTime2), N'Administrator', NULL, NULL, 2)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (51, N'8938503112147', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 14, 13, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-22T10:44:15.4581045' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (52, N'9991335735726', 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 29, 28, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-22T10:44:15.4591054' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (53, N'8936028040426', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 93, 92, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-22T10:44:26.7775368' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (54, N'8936124472008', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 27, 26, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-22T10:44:26.7785200' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (55, N'9991294713579', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 14, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-22T10:44:37.3998554' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (56, N'8936028040426', 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 92, 91, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-25T08:47:18.1792925' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (57, N'8936124472008', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 26, 25, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-25T08:47:18.1802962' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (58, N'8936124472008', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 23, 20, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-25T08:50:49.1768403' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (59, N'9991335735726', 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 28, 27, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-25T08:51:11.0038577' AS DateTime2), N'Administrator', NULL, NULL, 0)
INSERT [dbo].[ProductHistory] ([Id], [Barcode], [Unit], [NameOld], [NameNew], [PriceBuyOld], [PriceBuyNew], [InterestOld], [InterestNew], [PriceOld], [PriceNew], [QuantityOld], [QuantityNew], [CategoryIdOld], [CategoryIdNew], [SupplierIdOld], [SupplierIdNew], [PinOld], [PinNew], [EnableOld], [EnableNew], [ExpirationDateOld], [ExpirationDateNew], [ImgOld], [ImgNew], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Status]) VALUES (60, N'9991294713579', 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-12-25T08:51:11.0038577' AS DateTime2), N'Administrator', NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[ProductHistory] OFF
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (9, NULL, NULL, NULL, NULL, N'xxx', N'xxxxx', N'0123456789', NULL, NULL)
INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (10, NULL, NULL, NULL, NULL, N'Nguyễn Thị Thuỷ(bibica)', N'183 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội', N'02437281476', NULL, NULL)
INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (11, NULL, NULL, NULL, NULL, N'Nguyễn Đức Cảnh(ĐL cấp 1)', N'25 Văn Miếu, Đống Đa, Hà Nội, Vietnam', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (17, CAST(N'2020-12-11T10:05:14.2911355' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 39000, 40000, 1000, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (20, CAST(N'2020-12-11T10:11:06.3660807' AS DateTime2), N'Administrator', NULL, NULL, 0, NULL, 0, 1, 630000, 630000, 0, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (31, CAST(N'2020-12-21T16:12:46.9248655' AS DateTime2), N'Administrator', NULL, NULL, 0, NULL, 0, 1, 2937500, 3000000, 62500, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (32, CAST(N'2020-12-22T10:44:15.4108130' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 223600, 225000, 1400, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (33, CAST(N'2020-12-22T10:44:26.7675216' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 25000, 25000, 0, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (34, CAST(N'2020-12-22T10:44:37.3838167' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 15000, 15000, 0, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (35, CAST(N'2020-12-25T08:47:17.9792944' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 25000, 25000, 0, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (36, CAST(N'2020-12-25T08:50:49.0361535' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 30000, 50000, 20000, NULL, N'')
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (37, CAST(N'2020-12-25T08:51:10.9948654' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 95000, 100000, 5000, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Transaction] OFF
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'3110354325000', 20, CAST(N'2020-12-11T10:11:11.3552866' AS DateTime2), N'Administrator', NULL, NULL, 0, 100, 1, CAST(80000.00 AS Decimal(18, 2)), 28, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'3110354325000', 31, CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', NULL, NULL, 0, 2, 0, CAST(16000.00 AS Decimal(18, 2)), 28, 1)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8004800008152', 20, CAST(N'2020-12-11T10:11:11.3562857' AS DateTime2), N'Administrator', NULL, NULL, 0, 10, 1, CAST(550000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8934988021028', 31, CAST(N'2020-12-21T16:12:46.9548332' AS DateTime2), N'Administrator', NULL, NULL, 0, 11, 1, CAST(1300000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8935009922225', 31, CAST(N'2020-12-21T16:12:46.9568346' AS DateTime2), N'Administrator', NULL, NULL, 0, 10, 1, CAST(902500.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936017364113', 17, CAST(N'2020-12-11T10:05:14.3161378' AS DateTime2), N'Administrator', NULL, NULL, 0, 2, 1, CAST(24000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936028040426', 17, CAST(N'2020-12-11T10:05:14.3171355' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(15000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936028040426', 33, CAST(N'2020-12-22T10:44:26.7775368' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(15000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936028040426', 35, CAST(N'2020-12-25T08:47:18.1792925' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(15000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936124472008', 33, CAST(N'2020-12-22T10:44:26.7785200' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(10000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936124472008', 35, CAST(N'2020-12-25T08:47:18.1802962' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(10000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936124472008', 36, CAST(N'2020-12-25T08:50:49.1768403' AS DateTime2), N'Administrator', NULL, NULL, 0, 3, 1, CAST(30000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8938503112147', 32, CAST(N'2020-12-22T10:44:15.4581045' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(143600.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991294713579', 34, CAST(N'2020-12-22T10:44:37.3998554' AS DateTime2), N'Administrator', NULL, NULL, 0, 5, 1, CAST(15000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991294713579', 37, CAST(N'2020-12-25T08:51:11.0038577' AS DateTime2), N'Administrator', NULL, NULL, 0, 5, 1, CAST(15000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991335735726', 31, CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', NULL, NULL, 0, 11, 1, CAST(735000.00 AS Decimal(18, 2)), 30, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991335735726', 32, CAST(N'2020-12-22T10:44:15.4591054' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(80000.00 AS Decimal(18, 2)), 30, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991335735726', 37, CAST(N'2020-12-25T08:51:11.0038577' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(80000.00 AS Decimal(18, 2)), 30, NULL)
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
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [Interest]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
