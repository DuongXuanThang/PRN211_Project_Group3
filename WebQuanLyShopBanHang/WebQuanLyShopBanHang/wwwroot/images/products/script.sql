USE [master]
GO
/****** Object:  Database [Group3]    Script Date: 3/25/2022 5:19:49 PM ******/
CREATE DATABASE [Group3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Group3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Group3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Group3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Group3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Group3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Group3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Group3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Group3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Group3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Group3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Group3] SET ARITHABORT OFF 
GO
ALTER DATABASE [Group3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Group3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Group3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Group3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Group3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Group3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Group3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Group3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Group3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Group3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Group3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Group3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Group3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Group3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Group3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Group3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Group3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Group3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Group3] SET  MULTI_USER 
GO
ALTER DATABASE [Group3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Group3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Group3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Group3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Group3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Group3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Group3] SET QUERY_STORE = OFF
GO
USE [Group3]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 3/25/2022 5:19:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Phone] [varchar](12) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Active] [bit] NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[RoleID] [int] NULL,
	[CreateDate] [datetime] NULL,
	[LastLogin] [datetime] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 3/25/2022 5:19:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CatID] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [nvarchar](250) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 3/25/2022 5:19:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](255) NULL,
	[Birthday] [datetime] NULL,
	[Avatar] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Email] [nchar](150) NULL,
	[Phone] [varchar](12) NULL,
	[CreateDate] [datetime] NULL,
	[Password] [nvarchar](50) NULL,
	[Salt] [nchar](8) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 3/25/2022 5:19:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[OrderNumber] [int] NULL,
	[Amount] [int] NULL,
	[Discount] [int] NULL,
	[TotalMoney] [int] NULL,
	[CreateDate] [datetime] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/25/2022 5:19:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[Deleted] [bit] NOT NULL,
	[TotalMoney] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/25/2022 5:19:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](255) NOT NULL,
	[ShortDesc] [nvarchar](255) NULL,
	[Description] [nvarchar](max) NULL,
	[CatID] [int] NULL,
	[Price] [int] NULL,
	[Discount] [int] NULL,
	[Thumb] [nvarchar](255) NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[BestSellers] [bit] NOT NULL,
	[HomeFlag] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Alias] [nvarchar](255) NULL,
	[UnitsInStock] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/25/2022 5:19:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([AccountID], [Phone], [Email], [Password], [Active], [FullName], [RoleID], [CreateDate], [LastLogin]) VALUES (1, N'0362306429', N'thangdxse04839@fpt.edu.vn', N'hoilamgi', 1, N'Duong Xuan Thang', 1, CAST(N'2022-07-06T00:00:00.000' AS DateTime), CAST(N'2022-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Accounts] ([AccountID], [Phone], [Email], [Password], [Active], [FullName], [RoleID], [CreateDate], [LastLogin]) VALUES (5, N'0362306429', N'xuan thang123', N'hoilamgi', 0, N'Kim Oanh', 2, CAST(N'2022-07-07T00:00:00.000' AS DateTime), CAST(N'2022-07-07T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CatID], [CatName], [Description]) VALUES (1, N'rau', N'rau')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [FullName], [Birthday], [Avatar], [Address], [Email], [Phone], [CreateDate], [Password], [Salt], [Active]) VALUES (14, N'xuan thang', NULL, NULL, NULL, N'thangxuan@gmail.com                                                                                                                                   ', N'0362306429', CAST(N'2022-03-23T22:06:35.570' AS DateTime), N'123', N'        ', 1)
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Birthday], [Avatar], [Address], [Email], [Phone], [CreateDate], [Password], [Salt], [Active]) VALUES (15, N'duong xuan thang', NULL, NULL, NULL, N'thang123@gmail.com                                                                                                                                    ', N'3623064229', CAST(N'2022-03-23T22:23:47.827' AS DateTime), N'123123', N'        ', 1)
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Birthday], [Avatar], [Address], [Email], [Phone], [CreateDate], [Password], [Salt], [Active]) VALUES (16, N'duong xuan thang', NULL, NULL, NULL, N'thang1234@gmail.com                                                                                                                                   ', N'3623064229', CAST(N'2022-03-24T08:26:59.903' AS DateTime), N'1234', N'        ', 1)
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Birthday], [Avatar], [Address], [Email], [Phone], [CreateDate], [Password], [Salt], [Active]) VALUES (17, N'duong xuan thang', NULL, NULL, NULL, N'xuanthang1909972@gmail.com                                                                                                                            ', N'3623064229', CAST(N'2022-03-24T08:30:20.930' AS DateTime), N'123', N'        ', 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [Thumb], [DateCreated], [DateModified], [BestSellers], [HomeFlag], [Active], [Title], [Alias], [UnitsInStock]) VALUES (2, N'rau', N'rau', N'rau', 1, 100000, 5, N'aaa', CAST(N'2022-01-01T00:00:00.000' AS DateTime), CAST(N'2022-02-02T00:00:00.000' AS DateTime), 1, 1, 1, N'aaaaa', N'aaaa', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [Thumb], [DateCreated], [DateModified], [BestSellers], [HomeFlag], [Active], [Title], [Alias], [UnitsInStock]) VALUES (3, N'Xoai', N'aaaa', NULL, 1, 10000, 2, N'xoai.jpg', CAST(N'2022-03-18T01:01:02.020' AS DateTime), CAST(N'2022-03-18T01:01:02.017' AS DateTime), 1, 1, 1, N'aaaaaaaaaa', N'xoai', 12)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [Thumb], [DateCreated], [DateModified], [BestSellers], [HomeFlag], [Active], [Title], [Alias], [UnitsInStock]) VALUES (4, N'Nhan', N'aaaa', NULL, 1, 10000, 2, N'nhan.jpg', CAST(N'2022-03-18T10:09:17.477' AS DateTime), CAST(N'2022-03-18T10:09:17.477' AS DateTime), 1, 1, 1, N'aaaaaaaaa', N'nhan', 12)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [Thumb], [DateCreated], [DateModified], [BestSellers], [HomeFlag], [Active], [Title], [Alias], [UnitsInStock]) VALUES (5, N'Xoai2', N'aaaa', NULL, 1, 10000, 2, N'xoai2.jpg', CAST(N'2022-03-23T01:24:15.020' AS DateTime), CAST(N'2022-03-23T01:24:15.017' AS DateTime), 1, 1, 1, NULL, N'xoai2', 12)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ShortDesc], [Description], [CatID], [Price], [Discount], [Thumb], [DateCreated], [DateModified], [BestSellers], [HomeFlag], [Active], [Title], [Alias], [UnitsInStock]) VALUES (6, N'Xoai2', N'aaaa', NULL, 1, 10000, 2, N'xoai2.jpg', CAST(N'2022-03-24T21:16:02.603' AS DateTime), CAST(N'2022-03-24T21:16:02.603' AS DateTime), 1, 1, 1, N'aaaaa', N'xoai2', 12)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (1, N'Admin', N'Admin')
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (2, N'Staff', N'Nhân viên')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Roles]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers1] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers1]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CatID])
REFERENCES [dbo].[Categories] ([CatID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
USE [master]
GO
ALTER DATABASE [Group3] SET  READ_WRITE 
GO
