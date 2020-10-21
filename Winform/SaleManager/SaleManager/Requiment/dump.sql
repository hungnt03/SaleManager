alter table [HungTest].[dbo].[Product] add PriceBuy int default 0
alter table [HungTest].[dbo].[Supplier] add Note [nvarchar](256)

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