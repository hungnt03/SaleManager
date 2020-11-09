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
/****** Object:  Table [dbo].[Unit]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[Unit]
GO
/****** Object:  Table [dbo].[TransactionDetail]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[TransactionDetail]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[Transaction]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[Supplier]
GO
/****** Object:  Table [dbo].[ProductHistory]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[ProductHistory]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[Product]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[Discount]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[ConvertProduct]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[ConvertProduct]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[Category]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[AspNetUserTokens]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[AspNetUsers]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[AspNetUserRoles]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[AspNetUserLogins]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[AspNetUserClaims]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[AspNetRoles]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[AspNetRoleClaims]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2020/11/09 10:43:39 ******/
DROP TABLE [dbo].[__EFMigrationsHistory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[Category]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[ConvertProduct]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[Customer]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[Discount]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 2020/11/09 10:43:39 ******/
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
	[IsDefault] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[Unit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductHistory]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[Supplier]    Script Date: 2020/11/09 10:43:39 ******/
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
/****** Object:  Table [dbo].[Transaction]    Script Date: 2020/11/09 10:43:39 ******/
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
	[Amount] [decimal](18, 2) NOT NULL,
	[Payment] [decimal](18, 2) NOT NULL,
	[PayBack] [decimal](18, 2) NOT NULL,
	[BillNumber] [nvarchar](15) NULL,
	[Note] [varchar](255) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetail]    Script Date: 2020/11/09 10:43:39 ******/
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
 CONSTRAINT [PK_TransactionDetail] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[TracsactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 2020/11/09 10:43:39 ******/
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
INSERT [dbo].[ConvertProduct] ([Barcode], [Unit1], [Quantity1], [Unit2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'3110354325000', 16, 1, 28, 1000, NULL, NULL, NULL, NULL)
INSERT [dbo].[ConvertProduct] ([Barcode], [Unit1], [Quantity1], [Unit2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'3110354325000', 16, 1, 30, 100, NULL, NULL, NULL, NULL)
INSERT [dbo].[ConvertProduct] ([Barcode], [Unit1], [Quantity1], [Unit2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'3110354325000', 28, 1, 31, 20, NULL, NULL, NULL, NULL)
INSERT [dbo].[ConvertProduct] ([Barcode], [Unit1], [Quantity1], [Unit2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'3110354325000', 30, 1, 28, 10, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (1, CAST(N'2020-07-10T09:39:16.0413281' AS DateTime2), N'administrator', NULL, NULL, N'Nguyễn Hữu Hoà', N'11b Cát Linh, Quốc Tử Giám, Đống Đa, Hà Nội', N'02438267984')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (2, CAST(N'2020-07-10T09:39:16.0413347' AS DateTime2), N'administrator', NULL, NULL, N'Trần Danh Mạnh', N'59 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội', N'02438226676')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (3, CAST(N'2020-07-10T09:39:16.0413349' AS DateTime2), N'administrator', NULL, NULL, N'Hoàng Tố Như', N'35 Lô 1A, đường, Trung Yên 11B, Trung Hoà, Cầu Giấy, Hà Nội', N'02436230311')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (4, CAST(N'2020-07-10T11:47:57.2482026' AS DateTime2), NULL, CAST(N'2020-07-10T11:56:18.4419081' AS DateTime2), N'administrator', N'Nguyễn Trường Linh', N'tòa nhà Hòa Bình, KCN Hoàng Mai, Hoàng Mai, Hà Nội', N'0963123192')
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'3110354325000', CAST(N'2020-11-02T15:39:04.2294760' AS DateTime2), N'Administrator', CAST(N'2020-11-07T11:05:04.8067696' AS DateTime2), N'Administrator', N'Thuốc lá Thăng Long', 463, 1100000, 3, 2, 0, 1, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), 16, N'3110354325000.jpg', 1000000, 100000, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'3110354325000', CAST(N'2020-07-10T09:39:16.0418435' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8078045' AS DateTime2), N'Administrator', N'Thuốc lá Thăng Long', 463, 10000, 3, 1, 0, 1, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), 28, N'3110354325000.jpg', 8000, 2000, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8004800008152', CAST(N'2020-07-10T09:39:16.0418541' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8087694' AS DateTime2), N'Administrator', N'Bánh Sampa Balocco Savoiardi 200g', 60, 59000, 1, 2, 0, 1, CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), 19, N'8004800008152.jpg', 55000, 4000, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8934637514871', CAST(N'2020-07-10T09:39:16.0418548' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8087694' AS DateTime2), N'Administrator', N'Sốt ướp thịt nướng', 30, 16000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418544' AS DateTime2), 27, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8934752060109', CAST(N'2020-07-10T09:39:16.0418552' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8097683' AS DateTime2), N'Administrator', N'Dấm trung thành 500ml', 50, 10400, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418550' AS DateTime2), 18, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8934804004044', CAST(N'2020-07-10T09:39:16.0418555' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8097683' AS DateTime2), N'Administrator', N'Dầu hào 350g', 30, 21000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418553' AS DateTime2), 18, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8934988021028', CAST(N'2020-07-10T09:39:16.0418558' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8107671' AS DateTime2), N'Administrator', N'Dầu ăn simply 2l', 10, 130000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418556' AS DateTime2), 18, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8935009922225', CAST(N'2020-07-10T09:39:16.0418562' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8107671' AS DateTime2), N'Administrator', N'Kẹo gấu thiên hồng 1kg', 15, 95000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418559' AS DateTime2), 19, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8936017364113', CAST(N'2020-07-10T09:39:16.0418565' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8117683' AS DateTime2), N'Administrator', N'Nước mắm Cá cốt ABC', 13, 12000, 1, 2, 1, 1, CAST(N'2022-03-10T09:39:16.0418563' AS DateTime2), 18, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8936017367046', CAST(N'2020-07-10T09:39:16.0418568' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8117683' AS DateTime2), N'Administrator', N'Tương cà chinsu 250g', 50, 12000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418566' AS DateTime2), 18, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8936028040426', CAST(N'2020-07-10T09:39:16.0418571' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8127682' AS DateTime2), N'Administrator', N'Sốt gia vị chinsu', 96, 15000, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418569' AS DateTime2), 18, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8936124472008', CAST(N'2020-07-10T09:39:16.0418574' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8127682' AS DateTime2), N'Administrator', N'Đậu phộng nước cốt dừa Tân Tân gói 75g', 28, 10000, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418572' AS DateTime2), 19, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'8938503112147', CAST(N'2020-07-10T09:39:16.0418578' AS DateTime2), N'administrator', CAST(N'2020-11-07T11:05:04.8137689' AS DateTime2), N'Administrator', N'Mít sấy Vinamit gói 500g', 17, 143600, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418575' AS DateTime2), 19, NULL, 0, 0, 1)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest], [IsDefault]) VALUES (N'9991294713579', CAST(N'2020-11-07T10:15:28.0261900' AS DateTime2), N'Administrator', CAST(N'2020-11-07T11:05:04.8137689' AS DateTime2), N'Administrator', N'Mi tom hh', 20, 3000, 1, 1, 1, 1, CAST(N'2021-05-12T10:14:40.0000000' AS DateTime2), 19, NULL, 2800, 200, 0)
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
SET IDENTITY_INSERT [dbo].[ProductHistory] OFF
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (1, CAST(N'2020-07-10T09:39:16.0420751' AS DateTime2), N'administrator', NULL, NULL, N'Nguyễn Thị Thuỷ(bibica)', N'183 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội', N'02437281476', NULL, NULL)
INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (2, CAST(N'2020-07-10T09:39:16.0420758' AS DateTime2), N'administrator', NULL, NULL, N'Nguyễn Đức Cảnh(ĐL cấp 1)', N'25 Văn Miếu, Đống Đa, Hà Nội, Vietnam', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (1, CAST(N'2020-10-31T08:43:51.5854096' AS DateTime2), N'Administrator', NULL, NULL, 0, 0, 0, 1, CAST(630000.00 AS Decimal(18, 2)), CAST(650000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (3, CAST(N'2020-10-31T08:56:28.2056954' AS DateTime2), N'Administrator', NULL, NULL, 0, 0, 0, 0, CAST(630000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(-630000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (4, CAST(N'2020-10-31T08:57:13.8253684' AS DateTime2), N'Administrator', NULL, NULL, 0, 0, 0, 0, CAST(630000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(-630000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (5, CAST(N'2020-11-09T10:30:57.7633712' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 0, CAST(42000.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (7, CAST(N'2020-11-09T10:33:08.9779534' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 0, CAST(10000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (8, CAST(N'2020-11-09T10:34:49.3842674' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 0, CAST(143600.00 AS Decimal(18, 2)), CAST(150000.00 AS Decimal(18, 2)), CAST(6400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (9, CAST(N'2020-11-09T10:36:28.9302514' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, CAST(173600.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), CAST(26400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (10, CAST(N'2020-11-09T10:39:29.3390138' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, CAST(155600.00 AS Decimal(18, 2)), CAST(160000.00 AS Decimal(18, 2)), CAST(4400.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (11, CAST(N'2020-11-09T10:41:48.5909245' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 0, CAST(10000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(-10000.00 AS Decimal(18, 2)), NULL, N'co X no 10000')
SET IDENTITY_INSERT [dbo].[Transaction] OFF
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'3110354325000', 0, CAST(N'2020-10-31T08:43:51.5824082' AS DateTime2), N'Administrator', NULL, NULL, 0, 100, 1, CAST(80000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'3110354325000', 2, CAST(N'2020-10-31T08:56:28.2026968' AS DateTime2), N'Administrator', NULL, NULL, 0, 100, 0, CAST(80000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'3110354325000', 4, CAST(N'2020-10-31T08:57:13.8243650' AS DateTime2), N'Administrator', NULL, NULL, 0, 100, 0, CAST(80000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8004800008152', 0, CAST(N'2020-10-31T08:43:51.5834113' AS DateTime2), N'Administrator', NULL, NULL, 0, 10, 1, CAST(550000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8004800008152', 2, CAST(N'2020-10-31T08:56:28.2026968' AS DateTime2), N'Administrator', NULL, NULL, 0, 10, 0, CAST(550000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8004800008152', 4, CAST(N'2020-10-31T08:57:13.8243650' AS DateTime2), N'Administrator', NULL, NULL, 0, 10, 0, CAST(550000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8936017364113', 0, CAST(N'2020-11-09T10:30:57.7673452' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 0, CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8936017364113', 10, CAST(N'2020-11-09T10:39:29.3629324' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8936028040426', 0, CAST(N'2020-11-09T10:30:57.7683479' AS DateTime2), N'Administrator', NULL, NULL, 0, 2, 0, CAST(30000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8936028040426', 9, CAST(N'2020-11-09T10:36:36.7032914' AS DateTime2), N'Administrator', NULL, NULL, 0, 2, 1, CAST(30000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8936124472008', 7, CAST(N'2020-11-09T10:33:16.0479146' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 0, CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8936124472008', 11, CAST(N'2020-11-09T10:41:48.6230845' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 0, CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8938503112147', 8, CAST(N'2020-11-09T10:35:12.6740872' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 0, CAST(143600.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8938503112147', 9, CAST(N'2020-11-09T10:36:36.7022918' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(143600.00 AS Decimal(18, 2)))
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount]) VALUES (N'8938503112147', 10, CAST(N'2020-11-09T10:39:29.3639324' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(143600.00 AS Decimal(18, 2)))
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
