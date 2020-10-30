alter table [HungTest].[dbo].[Product] add PriceBuy int default 0
alter table [HungTest].[dbo].[Supplier] add Note [nvarchar](256)
alter table [dbo].[Product] add Interest int default 0

ALTER TABLE [HungTest].[dbo].[Product]
ALTER COLUMN Unit int not null;

ALTER TABLE [HungTest].[dbo].[Product] DROP CONSTRAINT [PK_Product]
ALTER TABLE [HungTest].[dbo].[Product] ADD CONSTRAINT [PK_Product] PRIMARY KEY (Barcode,Unit);

CREATE TABLE [HungTest].[dbo].[ConvertProduct](
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
	[Barcode],Unit1,Unit2 ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
);

CREATE TABLE [HungTest].[dbo].[Unit](
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
) 


--20201030
CREATE TABLE [dbo].[ProductHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [int] NOT NULL,
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
	
 CONSTRAINT [PK_ProductHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO