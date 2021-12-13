USE [master]
GO
/****** Object:  Database [SecureCore]    Script Date: 13/12/2021 19:59:05 ******/
CREATE DATABASE [SecureCore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SecureCore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SecureCore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SecureCore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SecureCore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SecureCore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SecureCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SecureCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SecureCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SecureCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SecureCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SecureCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [SecureCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SecureCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SecureCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SecureCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SecureCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SecureCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SecureCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SecureCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SecureCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SecureCore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SecureCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SecureCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SecureCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SecureCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SecureCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SecureCore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SecureCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SecureCore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SecureCore] SET  MULTI_USER 
GO
ALTER DATABASE [SecureCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SecureCore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SecureCore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SecureCore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SecureCore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SecureCore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SecureCore] SET QUERY_STORE = OFF
GO
USE [SecureCore]
GO
/****** Object:  Table [dbo].[Agencies]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agencies](
	[idAgency] [smallint] IDENTITY(1,1) NOT NULL,
	[CodeAgency] [nvarchar](12) NULL,
	[DescAgency] [nvarchar](50) NULL,
 CONSTRAINT [PK_Agencies] PRIMARY KEY CLUSTERED 
(
	[idAgency] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefinedRoutes]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRoutes](
	[idDefinedRoute] [int] IDENTITY(1,1) NOT NULL,
	[idPlanetOri] [int] NULL,
	[idPlanetDest] [int] NULL,
	[idRoute] [int] NULL,
	[RouteMap] [nvarchar](200) NULL,
 CONSTRAINT [PK_DefinedRoutes] PRIMARY KEY CLUSTERED 
(
	[idDefinedRoute] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryData]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryData](
	[idDeliveryData] [int] IDENTITY(1,1) NOT NULL,
	[CodeDelivery] [nvarchar](12) NULL,
	[DeliveryDate] [smalldatetime] NULL,
	[idPlanet] [int] NOT NULL,
	[idSpaceShip] [int] NOT NULL,
 CONSTRAINT [PK_DeliveryData] PRIMARY KEY CLUSTERED 
(
	[idDeliveryData] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factories]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factories](
	[idFactory] [smallint] IDENTITY(1,1) NOT NULL,
	[codeFactory] [nvarchar](12) NULL,
	[DescFactory] [nvarchar](50) NULL,
 CONSTRAINT [PK_Factories] PRIMARY KEY CLUSTERED 
(
	[idFactory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filiations]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filiations](
	[idFiliation] [int] IDENTITY(1,1) NOT NULL,
	[CodeFiliation] [nvarchar](12) NULL,
	[DescFiliations] [nvarchar](25) NULL,
 CONSTRAINT [PK_Filiations] PRIMARY KEY CLUSTERED 
(
	[idFiliation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InnerEncryption]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InnerEncryption](
	[idInnerEncryption] [int] IDENTITY(1,1) NOT NULL,
	[idPlanet] [int] NULL,
	[ValidationCode] [nvarchar](12) NULL,
 CONSTRAINT [PK_InnerEncryption] PRIMARY KEY CLUSTERED 
(
	[idInnerEncryption] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InnerEncryptionData]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InnerEncryptionData](
	[idInnerEncryptionData] [int] IDENTITY(1,1) NOT NULL,
	[IdInnerEncryption] [int] NULL,
	[Word] [nvarchar](1) NULL,
	[Numbers] [nvarchar](3) NULL,
 CONSTRAINT [PK_InnerEncryptionData] PRIMARY KEY CLUSTERED 
(
	[idInnerEncryptionData] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MilitaryCamps]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MilitaryCamps](
	[idMilitaryCamp] [int] IDENTITY(1,1) NOT NULL,
	[CodeCamp] [nvarchar](12) NULL,
	[DescCamp] [nvarchar](200) NULL,
	[idPlanet] [int] NULL,
 CONSTRAINT [PK_MilitaryCamps] PRIMARY KEY CLUSTERED 
(
	[idMilitaryCamp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationalAreas]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationalAreas](
	[idOperationalArea] [smallint] IDENTITY(1,1) NOT NULL,
	[CodeOperationalArea] [nvarchar](12) NULL,
	[DescOperationalArea] [nvarchar](50) NULL,
 CONSTRAINT [PK_OperationalAreas] PRIMARY KEY CLUSTERED 
(
	[idOperationalArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[idOrderInfo] [smallint] IDENTITY(1,1) NOT NULL,
	[idOrder] [smallint] NOT NULL,
	[idAgency] [smallint] NOT NULL,
	[idOperationalArea] [smallint] NOT NULL,
 CONSTRAINT [PK_OrderInfo] PRIMARY KEY CLUSTERED 
(
	[idOrderInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[idOrder] [smallint] IDENTITY(1,1) NOT NULL,
	[codeOrder] [nvarchar](12) NULL,
	[dateOrder] [smalldatetime] NULL,
	[IdPriority] [smallint] NOT NULL,
	[IdFactory] [smallint] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[idOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersDetail]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersDetail](
	[idOrderDetail] [smallint] IDENTITY(1,1) NOT NULL,
	[idOrder] [smallint] NULL,
	[idPlanet] [int] NULL,
	[idReference] [smallint] NULL,
	[Quantity] [smallint] NULL,
	[DeliveryDate] [smalldatetime] NULL,
 CONSTRAINT [PK_OrdersDetail] PRIMARY KEY CLUSTERED 
(
	[idOrderDetail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanetKeys]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanetKeys](
	[idKey] [int] IDENTITY(1,1) NOT NULL,
	[idPlanet] [int] NOT NULL,
	[XMLKey] [xml] NULL,
 CONSTRAINT [PK_PlanetKeys] PRIMARY KEY CLUSTERED 
(
	[idKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanetRoutes]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanetRoutes](
	[idPlanetRoute] [int] NOT NULL,
	[idPlanet] [int] NULL,
	[idRoute] [int] NULL,
 CONSTRAINT [PK_PlanetRoutes] PRIMARY KEY CLUSTERED 
(
	[idPlanetRoute] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planets]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planets](
	[idPlanet] [int] IDENTITY(1,1) NOT NULL,
	[CodePlanet] [nvarchar](12) NULL,
	[DescPlanet] [nvarchar](50) NULL,
	[idSector] [int] NULL,
	[long] [nvarchar](12) NULL,
	[lat] [nvarchar](12) NULL,
	[parsecs] [nvarchar](12) NULL,
	[idNatives] [int] NULL,
	[idFiliation] [int] NULL,
	[PlanetPicture] [nvarchar](200) NULL,
	[IPPlanet] [nvarchar](15) NULL,
	[PortPlanet] [nvarchar](4) NULL,
	[PortPlanet1] [nvarchar](4) NULL,
 CONSTRAINT [PK_Planets] PRIMARY KEY CLUSTERED 
(
	[idPlanet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Priority]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Priority](
	[idPriority] [smallint] IDENTITY(1,1) NOT NULL,
	[CodePriority] [nvarchar](12) NULL,
	[DescPriority] [nvarchar](50) NULL,
 CONSTRAINT [PK_Priority] PRIMARY KEY CLUSTERED 
(
	[idPriority] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[References]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[References](
	[idReference] [smallint] IDENTITY(1,1) NOT NULL,
	[codeReference] [nvarchar](12) NOT NULL,
	[descReference] [nvarchar](200) NULL,
	[Photo] [nvarchar](200) NULL,
	[VideoExplode] [nvarchar](200) NULL,
 CONSTRAINT [PK_References] PRIMARY KEY CLUSTERED 
(
	[idReference] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regions](
	[idRegion] [int] IDENTITY(1,1) NOT NULL,
	[CodeRegion] [nvarchar](12) NULL,
	[DescRegion] [nvarchar](50) NULL,
	[Remarks] [nvarchar](2000) NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[idRegion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Routes]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Routes](
	[idRoute] [int] IDENTITY(1,1) NOT NULL,
	[CodeRoute] [nvarchar](12) NULL,
	[DescRoute] [nvarchar](50) NULL,
	[idPlanetOr] [int] NULL,
	[idPlanetDest] [int] NULL,
	[idRouteType] [int] NULL,
 CONSTRAINT [PK_Routes] PRIMARY KEY CLUSTERED 
(
	[idRoute] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RouteTypes]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RouteTypes](
	[idRouteType] [int] IDENTITY(1,1) NOT NULL,
	[CodeRouteType] [nvarchar](12) NULL,
	[DescRouteType] [nvarchar](50) NULL,
	[Remarks] [nvarchar](250) NULL,
 CONSTRAINT [PK_RouteTypes] PRIMARY KEY CLUSTERED 
(
	[idRouteType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sectors]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sectors](
	[idSector] [int] IDENTITY(1,1) NOT NULL,
	[CodeSector] [nvarchar](12) NULL,
	[DescSector] [nvarchar](50) NULL,
	[Remarks] [nvarchar](250) NULL,
	[idRegion] [int] NULL,
 CONSTRAINT [PK_Sectors] PRIMARY KEY CLUSTERED 
(
	[idSector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpaceShipCategories]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpaceShipCategories](
	[idSpaceShipCategory] [int] IDENTITY(1,1) NOT NULL,
	[CodeSpaceShipCategory] [nvarchar](12) NULL,
	[DescSpaceShipCategory] [nvarchar](50) NULL,
 CONSTRAINT [PK_SpaceShipCategories] PRIMARY KEY CLUSTERED 
(
	[idSpaceShipCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpaceShips]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpaceShips](
	[idSpaceShip] [int] IDENTITY(1,1) NOT NULL,
	[idSpaceShipType] [int] NULL,
	[CodeSpaceShip] [nvarchar](12) NULL,
	[IPSpaceShip] [nvarchar](15) NULL,
	[PortSpaceShip] [nvarchar](4) NULL,
	[PortSpaceShip1] [nvarchar](4) NULL,
 CONSTRAINT [PK_SpaceShips] PRIMARY KEY CLUSTERED 
(
	[idSpaceShip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpaceShipTypes]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpaceShipTypes](
	[idSpaceShipType] [int] IDENTITY(1,1) NOT NULL,
	[CodeSpaceShipType] [nvarchar](12) NULL,
	[DescSpaceShipType] [nvarchar](200) NULL,
	[idFiliation] [int] NULL,
	[idSpaceShipCategory] [int] NULL,
 CONSTRAINT [PK_SpaceShipTypes] PRIMARY KEY CLUSTERED 
(
	[idSpaceShipType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Species]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Species](
	[idSpecie] [int] IDENTITY(1,1) NOT NULL,
	[CodeSpecie] [nvarchar](12) NULL,
	[DescSpecie] [nvarchar](50) NULL,
 CONSTRAINT [PK_Species] PRIMARY KEY CLUSTERED 
(
	[idSpecie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserCategories]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCategories](
	[idUserCategory] [int] IDENTITY(1,1) NOT NULL,
	[CodeCategory] [nvarchar](12) NULL,
	[DescCategory] [nvarchar](50) NULL,
	[AccessLevel] [int] NULL,
 CONSTRAINT [PK_UserCategories] PRIMARY KEY CLUSTERED 
(
	[idUserCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOptions]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOptions](
	[idUser] [nchar](10) NULL,
	[minLevel] [nchar](10) NULL,
	[Descripcio] [varchar](max) NULL,
	[Classe] [varchar](max) NULL,
	[Formulari] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRanks]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRanks](
	[idUserRank] [int] IDENTITY(1,1) NOT NULL,
	[CodeRank] [nvarchar](12) NULL,
	[DescRank] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserRanks] PRIMARY KEY CLUSTERED 
(
	[idUserRank] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13/12/2021 19:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[CodeUser] [nvarchar](12) NULL,
	[UserName] [nvarchar](100) NULL,
	[Login] [nvarchar](12) NULL,
	[Password] [nvarchar](12) NULL,
	[idUserRank] [int] NULL,
	[idUserCategory] [int] NULL,
	[Photo] [nvarchar](50) NULL,
	[idPlanet] [int] NULL,
	[idSpecie] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DefinedRoutes]  WITH CHECK ADD  CONSTRAINT [FK_DefinedRoutes_Routes] FOREIGN KEY([idRoute])
REFERENCES [dbo].[Routes] ([idRoute])
GO
ALTER TABLE [dbo].[DefinedRoutes] CHECK CONSTRAINT [FK_DefinedRoutes_Routes]
GO
ALTER TABLE [dbo].[DeliveryData]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryData_Planets] FOREIGN KEY([idPlanet])
REFERENCES [dbo].[Planets] ([idPlanet])
GO
ALTER TABLE [dbo].[DeliveryData] CHECK CONSTRAINT [FK_DeliveryData_Planets]
GO
ALTER TABLE [dbo].[DeliveryData]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryData_SpaceShips] FOREIGN KEY([idSpaceShip])
REFERENCES [dbo].[SpaceShips] ([idSpaceShip])
GO
ALTER TABLE [dbo].[DeliveryData] CHECK CONSTRAINT [FK_DeliveryData_SpaceShips]
GO
ALTER TABLE [dbo].[InnerEncryption]  WITH CHECK ADD  CONSTRAINT [FK_InnerEncryption_Planets] FOREIGN KEY([idPlanet])
REFERENCES [dbo].[Planets] ([idPlanet])
GO
ALTER TABLE [dbo].[InnerEncryption] CHECK CONSTRAINT [FK_InnerEncryption_Planets]
GO
ALTER TABLE [dbo].[InnerEncryptionData]  WITH CHECK ADD  CONSTRAINT [FK_InnerEncryptionData_InnerEncryption] FOREIGN KEY([IdInnerEncryption])
REFERENCES [dbo].[InnerEncryption] ([idInnerEncryption])
GO
ALTER TABLE [dbo].[InnerEncryptionData] CHECK CONSTRAINT [FK_InnerEncryptionData_InnerEncryption]
GO
ALTER TABLE [dbo].[MilitaryCamps]  WITH CHECK ADD  CONSTRAINT [FK_MilitaryCamps_Planets] FOREIGN KEY([idPlanet])
REFERENCES [dbo].[Planets] ([idPlanet])
GO
ALTER TABLE [dbo].[MilitaryCamps] CHECK CONSTRAINT [FK_MilitaryCamps_Planets]
GO
ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD  CONSTRAINT [FK_OrderInfo_Agencies] FOREIGN KEY([idAgency])
REFERENCES [dbo].[Agencies] ([idAgency])
GO
ALTER TABLE [dbo].[OrderInfo] CHECK CONSTRAINT [FK_OrderInfo_Agencies]
GO
ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD  CONSTRAINT [FK_OrderInfo_OperationalAreas] FOREIGN KEY([idOperationalArea])
REFERENCES [dbo].[OperationalAreas] ([idOperationalArea])
GO
ALTER TABLE [dbo].[OrderInfo] CHECK CONSTRAINT [FK_OrderInfo_OperationalAreas]
GO
ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD  CONSTRAINT [FK_OrderInfo_Orders] FOREIGN KEY([idOrder])
REFERENCES [dbo].[Orders] ([idOrder])
GO
ALTER TABLE [dbo].[OrderInfo] CHECK CONSTRAINT [FK_OrderInfo_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Factories] FOREIGN KEY([IdFactory])
REFERENCES [dbo].[Factories] ([idFactory])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Factories]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Priority] FOREIGN KEY([IdPriority])
REFERENCES [dbo].[Priority] ([idPriority])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Priority]
GO
ALTER TABLE [dbo].[OrdersDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetail_Orders] FOREIGN KEY([idOrder])
REFERENCES [dbo].[Orders] ([idOrder])
GO
ALTER TABLE [dbo].[OrdersDetail] CHECK CONSTRAINT [FK_OrdersDetail_Orders]
GO
ALTER TABLE [dbo].[OrdersDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetail_Planets] FOREIGN KEY([idPlanet])
REFERENCES [dbo].[Planets] ([idPlanet])
GO
ALTER TABLE [dbo].[OrdersDetail] CHECK CONSTRAINT [FK_OrdersDetail_Planets]
GO
ALTER TABLE [dbo].[OrdersDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetail_References] FOREIGN KEY([idReference])
REFERENCES [dbo].[References] ([idReference])
GO
ALTER TABLE [dbo].[OrdersDetail] CHECK CONSTRAINT [FK_OrdersDetail_References]
GO
ALTER TABLE [dbo].[PlanetKeys]  WITH CHECK ADD  CONSTRAINT [FK_PlanetKeys_Planets] FOREIGN KEY([idPlanet])
REFERENCES [dbo].[Planets] ([idPlanet])
GO
ALTER TABLE [dbo].[PlanetKeys] CHECK CONSTRAINT [FK_PlanetKeys_Planets]
GO
ALTER TABLE [dbo].[PlanetRoutes]  WITH CHECK ADD  CONSTRAINT [FK_PlanetRoutes_Planets] FOREIGN KEY([idPlanet])
REFERENCES [dbo].[Planets] ([idPlanet])
GO
ALTER TABLE [dbo].[PlanetRoutes] CHECK CONSTRAINT [FK_PlanetRoutes_Planets]
GO
ALTER TABLE [dbo].[PlanetRoutes]  WITH CHECK ADD  CONSTRAINT [FK_PlanetRoutes_Routes] FOREIGN KEY([idRoute])
REFERENCES [dbo].[Routes] ([idRoute])
GO
ALTER TABLE [dbo].[PlanetRoutes] CHECK CONSTRAINT [FK_PlanetRoutes_Routes]
GO
ALTER TABLE [dbo].[Planets]  WITH CHECK ADD  CONSTRAINT [FK_Planets_Filiations] FOREIGN KEY([idFiliation])
REFERENCES [dbo].[Filiations] ([idFiliation])
GO
ALTER TABLE [dbo].[Planets] CHECK CONSTRAINT [FK_Planets_Filiations]
GO
ALTER TABLE [dbo].[Planets]  WITH CHECK ADD  CONSTRAINT [FK_Planets_Sectors] FOREIGN KEY([idSector])
REFERENCES [dbo].[Sectors] ([idSector])
GO
ALTER TABLE [dbo].[Planets] CHECK CONSTRAINT [FK_Planets_Sectors]
GO
ALTER TABLE [dbo].[Planets]  WITH CHECK ADD  CONSTRAINT [FK_Planets_Species] FOREIGN KEY([idNatives])
REFERENCES [dbo].[Species] ([idSpecie])
GO
ALTER TABLE [dbo].[Planets] CHECK CONSTRAINT [FK_Planets_Species]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [FK_Routes_RouteTypes] FOREIGN KEY([idRouteType])
REFERENCES [dbo].[RouteTypes] ([idRouteType])
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [FK_Routes_RouteTypes]
GO
ALTER TABLE [dbo].[Sectors]  WITH CHECK ADD  CONSTRAINT [FK_Sectors_Regions] FOREIGN KEY([idRegion])
REFERENCES [dbo].[Regions] ([idRegion])
GO
ALTER TABLE [dbo].[Sectors] CHECK CONSTRAINT [FK_Sectors_Regions]
GO
ALTER TABLE [dbo].[SpaceShips]  WITH CHECK ADD  CONSTRAINT [FK_SpaceShips_SpaceShipTypes] FOREIGN KEY([idSpaceShipType])
REFERENCES [dbo].[SpaceShipTypes] ([idSpaceShipType])
GO
ALTER TABLE [dbo].[SpaceShips] CHECK CONSTRAINT [FK_SpaceShips_SpaceShipTypes]
GO
ALTER TABLE [dbo].[SpaceShipTypes]  WITH CHECK ADD  CONSTRAINT [FK_SpaceShipTypes_Filiations] FOREIGN KEY([idFiliation])
REFERENCES [dbo].[Filiations] ([idFiliation])
GO
ALTER TABLE [dbo].[SpaceShipTypes] CHECK CONSTRAINT [FK_SpaceShipTypes_Filiations]
GO
ALTER TABLE [dbo].[SpaceShipTypes]  WITH CHECK ADD  CONSTRAINT [FK_SpaceShipTypes_SpaceShipCategories] FOREIGN KEY([idSpaceShipCategory])
REFERENCES [dbo].[SpaceShipCategories] ([idSpaceShipCategory])
GO
ALTER TABLE [dbo].[SpaceShipTypes] CHECK CONSTRAINT [FK_SpaceShipTypes_SpaceShipCategories]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Planets] FOREIGN KEY([idPlanet])
REFERENCES [dbo].[Planets] ([idPlanet])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Planets]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Species] FOREIGN KEY([idSpecie])
REFERENCES [dbo].[Species] ([idSpecie])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Species]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserCategories] FOREIGN KEY([idUserCategory])
REFERENCES [dbo].[UserCategories] ([idUserCategory])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserCategories]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserRanks] FOREIGN KEY([idUserRank])
REFERENCES [dbo].[UserRanks] ([idUserRank])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserRanks]
GO
USE [master]
GO
ALTER DATABASE [SecureCore] SET  READ_WRITE 
GO
