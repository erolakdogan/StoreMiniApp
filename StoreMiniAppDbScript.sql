USE [StoreMiniAppDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16.05.2022 06:41:03 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discounts]    Script Date: 16.05.2022 06:41:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Type] [int] NOT NULL,
	[Rate] [decimal](18, 2) NOT NULL,
	[IsRatePercentage] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Discounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 16.05.2022 06:41:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[InvoiceNumber] [nvarchar](25) NOT NULL,
	[OrderId] [int] NOT NULL,
	[OrderTotal] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 16.05.2022 06:41:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[ProductName] [nvarchar](30) NOT NULL,
	[ProductPrice] [decimal](18, 2) NOT NULL,
	[ProductQuantity] [int] NOT NULL,
	[DerivedProductCost] [decimal](18, 2) NOT NULL,
	[DiscountPrice] [decimal](18, 2) NOT NULL,
	[TotalDerivedCost] [decimal](18, 2) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_InvoiceDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 16.05.2022 06:41:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](25) NOT NULL,
	[LastName] [nvarchar](25) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[PhoneNumber] [nvarchar](13) NOT NULL,
	[UserType] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220516033856_mig1', N'6.0.5')
GO
SET IDENTITY_INSERT [dbo].[Discounts] ON 

INSERT [dbo].[Discounts] ([Id], [Name], [Type], [Rate], [IsRatePercentage], [CreatedDate]) VALUES (1, N'Affiliate Discount', 1, CAST(10.00 AS Decimal(18, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Discounts] ([Id], [Name], [Type], [Rate], [IsRatePercentage], [CreatedDate]) VALUES (2, N'Employee Discount', 2, CAST(30.00 AS Decimal(18, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Discounts] ([Id], [Name], [Type], [Rate], [IsRatePercentage], [CreatedDate]) VALUES (3, N'Loyal Customer Discount', 3, CAST(5.00 AS Decimal(18, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Discounts] ([Id], [Name], [Type], [Rate], [IsRatePercentage], [CreatedDate]) VALUES (4, N'Price Discount', 4, CAST(5.00 AS Decimal(18, 2)), 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Discounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([Id], [UserId], [InvoiceNumber], [OrderId], [OrderTotal], [Total], [CreatedDate]) VALUES (1, 1, N'BJK010', 1, CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Invoice] ([Id], [UserId], [InvoiceNumber], [OrderId], [OrderTotal], [Total], [CreatedDate]) VALUES (2, 2, N'BJK011', 2, CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Invoice] ([Id], [UserId], [InvoiceNumber], [OrderId], [OrderTotal], [Total], [CreatedDate]) VALUES (3, 3, N'BJK012', 3, CAST(0.00 AS Decimal(18, 2)), CAST(990.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Invoice] ([Id], [UserId], [InvoiceNumber], [OrderId], [OrderTotal], [Total], [CreatedDate]) VALUES (4, 4, N'BJK013', 4, CAST(0.00 AS Decimal(18, 2)), CAST(920.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[InvoiceDetails] ON 

INSERT [dbo].[InvoiceDetails] ([Id], [InvoiceId], [ProductId], [ProductName], [ProductPrice], [ProductQuantity], [DerivedProductCost], [DiscountPrice], [TotalDerivedCost], [CreatedDate]) VALUES (1, 1, 2, N'Item 2', CAST(20.00 AS Decimal(18, 2)), 2, CAST(40.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(38.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[InvoiceDetails] ([Id], [InvoiceId], [ProductId], [ProductName], [ProductPrice], [ProductQuantity], [DerivedProductCost], [DiscountPrice], [TotalDerivedCost], [CreatedDate]) VALUES (2, 1, 4, N'Item 4', CAST(482.00 AS Decimal(18, 2)), 1, CAST(482.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(462.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[InvoiceDetails] ([Id], [InvoiceId], [ProductId], [ProductName], [ProductPrice], [ProductQuantity], [DerivedProductCost], [DiscountPrice], [TotalDerivedCost], [CreatedDate]) VALUES (3, 2, 40, N'Item 40', CAST(50.00 AS Decimal(18, 2)), 5, CAST(250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[InvoiceDetails] ([Id], [InvoiceId], [ProductId], [ProductName], [ProductPrice], [ProductQuantity], [DerivedProductCost], [DiscountPrice], [TotalDerivedCost], [CreatedDate]) VALUES (4, 4, 3, N'Item 3', CAST(50.00 AS Decimal(18, 2)), 5, CAST(250.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[InvoiceDetails] ([Id], [InvoiceId], [ProductId], [ProductName], [ProductPrice], [ProductQuantity], [DerivedProductCost], [DiscountPrice], [TotalDerivedCost], [CreatedDate]) VALUES (5, 3, 5, N'Item 5', CAST(400.00 AS Decimal(18, 2)), 1, CAST(400.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(380.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[InvoiceDetails] ([Id], [InvoiceId], [ProductId], [ProductName], [ProductPrice], [ProductQuantity], [DerivedProductCost], [DiscountPrice], [TotalDerivedCost], [CreatedDate]) VALUES (6, 3, 15, N'Item 15', CAST(77.00 AS Decimal(18, 2)), 5, CAST(385.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(385.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[InvoiceDetails] ([Id], [InvoiceId], [ProductId], [ProductName], [ProductPrice], [ProductQuantity], [DerivedProductCost], [DiscountPrice], [TotalDerivedCost], [CreatedDate]) VALUES (7, 4, 105, N'Item 105', CAST(200.00 AS Decimal(18, 2)), 5, CAST(1000.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(920.00 AS Decimal(18, 2)), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[InvoiceDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [Email], [PhoneNumber], [UserType], [CreatedDate]) VALUES (1, N'Sergen ', N'Yalçın', N'İstanbul', N'sergen@email.com', N'123456789', 1, CAST(N'2021-05-16T06:38:56.3342660' AS DateTime2))
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [Email], [PhoneNumber], [UserType], [CreatedDate]) VALUES (2, N'İlhan ', N'Mansız', N'Samsun', N'ilhan@email.com', N'505542210', 1, CAST(N'2020-05-16T06:38:56.3342674' AS DateTime2))
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [Email], [PhoneNumber], [UserType], [CreatedDate]) VALUES (3, N'Metin ', N'Tekin', N'Ankara', N'metin@email.com', N'504425102', 2, CAST(N'2019-05-16T06:38:56.3342677' AS DateTime2))
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [Email], [PhoneNumber], [UserType], [CreatedDate]) VALUES (4, N'Ali ', N'Gültekin', N'İstanbul', N'ali@email.com', N'5057581801', 3, CAST(N'2022-02-16T06:38:56.3342678' AS DateTime2))
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [Email], [PhoneNumber], [UserType], [CreatedDate]) VALUES (5, N'Feyyaz ', N'Uçar', N'İstanbul', N'feyyaz@email.com', N'5064581806', 2, CAST(N'2019-05-16T06:38:56.3342682' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
