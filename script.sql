USE [SecureCore]
GO
/****** Object:  Table [dbo].[Agencies]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[DefinedRoutes]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[DeliveryData]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Factories]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Filiations]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[InnerEncryption]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[InnerEncryptionData]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[MilitaryCamps]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[OperationalAreas]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Orders]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[OrdersDetail]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[PlanetKeys]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[PlanetRoutes]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Planets]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Priority]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[References]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Regions]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Routes]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[RouteTypes]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Sectors]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[SpaceShipCategories]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[SpaceShips]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[SpaceShipTypes]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Species]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[UserCategories]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[UserOptions]    Script Date: 21/01/2022 18:15:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOptions](
	[idUser] [nchar](10) NULL,
	[minLevel] [nchar](10) NULL,
	[Descripcio] [varchar](max) NULL,
	[Classe] [varchar](max) NULL,
	[Formulari] [varchar](max) NULL,
	[taula] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRanks]    Script Date: 21/01/2022 18:15:07 ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 21/01/2022 18:15:07 ******/
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
SET IDENTITY_INSERT [dbo].[Agencies] ON 

INSERT [dbo].[Agencies] ([idAgency], [CodeAgency], [DescAgency]) VALUES (1, N'37EA', N'High Command of Strategic
Operations')
INSERT [dbo].[Agencies] ([idAgency], [CodeAgency], [DescAgency]) VALUES (2, N'40A', N'High Jedi Council')
INSERT [dbo].[Agencies] ([idAgency], [CodeAgency], [DescAgency]) VALUES (3, N'FOSB', N'First Order Security Bureau')
INSERT [dbo].[Agencies] ([idAgency], [CodeAgency], [DescAgency]) VALUES (4, N'SOC', N'Sith Order Council')
SET IDENTITY_INSERT [dbo].[Agencies] OFF
GO
SET IDENTITY_INSERT [dbo].[Factories] ON 

INSERT [dbo].[Factories] ([idFactory], [codeFactory], [DescFactory]) VALUES (1, N'NABOSOUTXW02', N'X-Wings Factory Naboo South')
INSERT [dbo].[Factories] ([idFactory], [codeFactory], [DescFactory]) VALUES (2, N'ENDONORTAW01', N'A-Wings Factory Endor North')
INSERT [dbo].[Factories] ([idFactory], [codeFactory], [DescFactory]) VALUES (3, N'MUSTNORTTAF1', N'Advanced Tie-Fighter Factory Mustafar North')
INSERT [dbo].[Factories] ([idFactory], [codeFactory], [DescFactory]) VALUES (4, N'MANDSOUTSD02', N'Stellar Destructor Factory Mandalore South')
SET IDENTITY_INSERT [dbo].[Factories] OFF
GO
SET IDENTITY_INSERT [dbo].[Filiations] ON 

INSERT [dbo].[Filiations] ([idFiliation], [CodeFiliation], [DescFiliations]) VALUES (1, N'REPU', N'Republican')
INSERT [dbo].[Filiations] ([idFiliation], [CodeFiliation], [DescFiliations]) VALUES (2, N'FIOR', N'First Order')
INSERT [dbo].[Filiations] ([idFiliation], [CodeFiliation], [DescFiliations]) VALUES (3, N'NEUT', N'Neutral')
INSERT [dbo].[Filiations] ([idFiliation], [CodeFiliation], [DescFiliations]) VALUES (4, N'UNKN', N'Unknown')
SET IDENTITY_INSERT [dbo].[Filiations] OFF
GO
SET IDENTITY_INSERT [dbo].[OperationalAreas] ON 

INSERT [dbo].[OperationalAreas] ([idOperationalArea], [CodeOperationalArea], [DescOperationalArea]) VALUES (1, N'OUTER', N'Outer Ring')
INSERT [dbo].[OperationalAreas] ([idOperationalArea], [CodeOperationalArea], [DescOperationalArea]) VALUES (2, N'INNER', N'Inner Ring')
INSERT [dbo].[OperationalAreas] ([idOperationalArea], [CodeOperationalArea], [DescOperationalArea]) VALUES (3, N'UNKNO', N'Unknown')
SET IDENTITY_INSERT [dbo].[OperationalAreas] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderInfo] ON 

INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (2, 1, 1, 1)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (3, 2, 1, 1)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (4, 3, 1, 1)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (120, 122, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (121, 123, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (122, 124, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (123, 125, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (124, 126, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (125, 127, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (126, 128, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (218, 220, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (219, 221, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (220, 222, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (221, 223, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (222, 224, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (223, 225, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (224, 226, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (225, 227, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (226, 228, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (227, 229, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (228, 230, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (229, 231, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (230, 232, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (231, 233, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (232, 234, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (318, 320, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (319, 321, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (418, 420, 2, 2)
INSERT [dbo].[OrderInfo] ([idOrderInfo], [idOrder], [idAgency], [idOperationalArea]) VALUES (419, 421, 2, 2)
SET IDENTITY_INSERT [dbo].[OrderInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (1, N'HCSO123456NA', CAST(N'2020-05-12T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (2, N'HCSO123456TA', CAST(N'2010-01-01T00:00:00' AS SmallDateTime), 2, 2)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (3, N'FOSB123456NA', CAST(N'2010-01-01T00:00:00' AS SmallDateTime), 1, 3)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (5, N'Ord04', CAST(N'2010-01-01T00:00:00' AS SmallDateTime), 2, 4)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (7, N'Ord05', CAST(N'2010-01-01T00:00:00' AS SmallDateTime), 1, 2)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (122, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (123, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (124, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (125, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (126, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (127, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (128, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (220, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (221, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (222, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (223, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (224, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (225, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (226, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (227, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (228, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (229, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (230, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (231, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (232, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (233, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (234, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (320, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (321, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (420, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[Orders] ([idOrder], [codeOrder], [dateOrder], [IdPriority], [IdFactory]) VALUES (421, N'061243444000', CAST(N'2018-10-19T00:00:00' AS SmallDateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdersDetail] ON 

INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (1, 1, 1, 1, 12, CAST(N'2020-11-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (2, 1, 2, 1, 23, CAST(N'2020-11-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (3, 1, 3, 3, 35, CAST(N'2020-11-22T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (4, 2, 1, 2, 17, CAST(N'2020-11-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (5, 2, 7, 3, 20, CAST(N'2020-11-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (6, 2, 9, 1, 32, CAST(N'2020-11-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (7, 3, 8, 4, 70, CAST(N'2020-11-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (13, 122, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (14, 122, 1, 1, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (15, 122, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (16, 123, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (17, 123, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (18, 123, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (20, 124, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (21, 124, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (22, 124, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (23, 125, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (24, 125, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (25, 125, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (26, 126, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (27, 126, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (28, 126, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (29, 127, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (30, 127, 1, 2, 666, CAST(N'2018-12-01T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (31, 127, 9, 1, -800, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (32, 128, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (33, 128, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (34, 128, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (109, 220, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (110, 220, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (111, 220, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (112, 221, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (113, 221, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (114, 221, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (115, 222, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (116, 222, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (117, 222, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (118, 223, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (119, 223, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (120, 223, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (121, 224, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (122, 224, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (123, 224, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (124, 225, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (125, 225, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (126, 225, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (127, 226, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (128, 226, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (129, 226, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (130, 227, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (131, 227, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (132, 227, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (133, 228, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (134, 228, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (135, 228, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (136, 229, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (137, 229, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (138, 229, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (139, 230, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (140, 230, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (141, 230, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (142, 231, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (143, 231, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (144, 231, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (145, 232, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (146, 232, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (147, 232, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (148, 233, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (149, 233, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (150, 233, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (151, 234, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (152, 234, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (153, 234, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (209, 320, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (210, 320, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (211, 320, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (212, 321, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (213, 321, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (214, 321, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (309, 420, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (310, 420, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (311, 420, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (312, 421, 2, 1, 250, CAST(N'2018-11-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (313, 421, 1, 2, 400, CAST(N'2018-11-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[OrdersDetail] ([idOrderDetail], [idOrder], [idPlanet], [idReference], [Quantity], [DeliveryDate]) VALUES (314, 421, 9, 1, -1200, CAST(N'2018-11-27T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[OrdersDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[PlanetKeys] ON 

INSERT [dbo].[PlanetKeys] ([idKey], [idPlanet], [XMLKey]) VALUES (1, 2, N'<RSAKeyValue><Modulus>1zAsJ3ENv8+RyZtJE4QEFwQv+a+S4ubpozDLUdc9yaNadokMZXNMlf3UklE0sEzr+t8RvO/PdOKxnZoybIBDHhn4lLtZbxaQFiF7WOERJ3BevCqMnteNENkyShmO8qXuYM0bHzhFuPNn1xvTP2meWx9VyQHzOD46lR8bOLdAacU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>')
INSERT [dbo].[PlanetKeys] ([idKey], [idPlanet], [XMLKey]) VALUES (2, 3, N'<RSAKeyValue><Modulus>sOl/KsyXIGIFIl5uwCUmyO2wz3JxfodJ1R6be7s/UUnHb+vMRGoYJV/ITL1NYmRCXNPdnIuWNgKMohFXtUYGzMvpT35orM8FzR97ka+PPPm3XD2kEAl3Rd8epSmQVmpzWkBNfAXxnuQ4/faFDnvEYsBB1CMl4+wx3nFSKyLJ0YE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>')
SET IDENTITY_INSERT [dbo].[PlanetKeys] OFF
GO
SET IDENTITY_INSERT [dbo].[Planets] ON 

INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (1, N'0000OUTTAKO', N'Takodana', 1, N'82342', N'37542', N'123212', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (2, N'0000INRINABO', N'Naboo', 2, N'66598', N'54321', N'78654', 4, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (3, N'0000INRIDATH', N'Dathomir', 3, N'14555', N'98536', N'67546', 5, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (4, N'KASH', N'Kashyyyk', 4, N'66559', N'43841', N'98634', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (5, N'MANA', N'Manaan', 5, N'54821', N'39348', N'62865', 6, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (6, N'DANT', N'Dantooine', 6, N'99722', N'54762', N'75432', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (7, N'0000OUTTATO', N'Tatooine', 7, N'32732', N'64321', N'15634', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (8, N'0000OUTMUST', N'Mustafar', 8, N'88554', N'23158', N'97643', 7, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (9, N'0000OUTENDO', N'Endor', 9, N'68942', N'45457', N'89473', 8, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (10, N'CORU', N'Coruscant', 10, N'77328', N'61113', N'87432', 1, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (11, N'DAGO', N'Dagobah', 11, N'39824', N'41522', N'75364', 9, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (12, N'JAKK', N'Jakku', 12, N'77213', N'87456', N'43256', 10, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (13, N'MAND', N'Mandalore', 13, N'36177', N'49989', N'63425', 1, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (14, N'KUAT', N'Kuat', 14, N'88688', N'12367', N'34517', 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (15, N'CORE', N'Corellia', 15, N'71923', N'66231', N'73541', 1, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (16, N'HOTH', N'Hoth', 16, N'55339', N'69126', N'34519', 9, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (17, N'TETH', N'Teth', 17, N'99129', N'78177', N'42581', 12, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (18, N'DQAR', N'D''Qar', 18, N'89445', N'65213', N'72892', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (19, N'DEVA', N'Devaron', 19, N'83389', N'82112', N'63428', 13, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (20, N'KESS', N'Kessel', 20, N'57579', N'43893', N'64738', 14, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (21, N'SHIL', N'Shili', 21, N'91872', N'83451', N'23761', 15, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (22, N'JELU', N'Jelucan', 22, N'88558', N'91234', N'34651', 16, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (23, N'BYSS', N'Byss', 23, N'13452', N'27453', N'76534', 1, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (24, N'GYND', N'Gyndine', 24, N'22981', N'34175', N'51723', 1, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[Planets] ([idPlanet], [CodePlanet], [DescPlanet], [idSector], [long], [lat], [parsecs], [idNatives], [idFiliation], [PlanetPicture], [IPPlanet], [PortPlanet], [PortPlanet1]) VALUES (25, N'RAKA', N'Rakata Prime', 25, N'99111', N'28998', N'43524', 17, 4, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Planets] OFF
GO
SET IDENTITY_INSERT [dbo].[Priority] ON 

INSERT [dbo].[Priority] ([idPriority], [CodePriority], [DescPriority]) VALUES (1, N'220', N'Normal Order')
INSERT [dbo].[Priority] ([idPriority], [CodePriority], [DescPriority]) VALUES (2, N'22E', N'Urgent Order')
SET IDENTITY_INSERT [dbo].[Priority] OFF
GO
SET IDENTITY_INSERT [dbo].[References] ON 

INSERT [dbo].[References] ([idReference], [codeReference], [descReference], [Photo], [VideoExplode]) VALUES (1, N'841001009689', N'X-Wings T-65 DAM', N'H3257-L96343217.jpg', NULL)
INSERT [dbo].[References] ([idReference], [codeReference], [descReference], [Photo], [VideoExplode]) VALUES (2, N'841001009692', N'Y-Wings D302', N'Y-Wing-Fighter.jpeg', NULL)
INSERT [dbo].[References] ([idReference], [codeReference], [descReference], [Photo], [VideoExplode]) VALUES (3, N'741001009689', N'Advanced TIE-Fighter', NULL, NULL)
INSERT [dbo].[References] ([idReference], [codeReference], [descReference], [Photo], [VideoExplode]) VALUES (4, N'741001009692', N'Stellar Destructor SD101', NULL, NULL)
SET IDENTITY_INSERT [dbo].[References] OFF
GO
SET IDENTITY_INSERT [dbo].[Regions] ON 

INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (1, N'DECO', N'Deep Core', N'At the very heart of the galaxy, the Deep Core was a region that spanned seven thousand light years, and contained roughly 30 billion stars. Due to the gravitational pull of the vast number of stars, as well as a massive black hole at the center, local space-time was severely warped, making hyperspace travel difficult at best.It''s dangerous to navigate, and few travellers venture this far coreward')
INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (2, N'COWO', N'Core Worlds', N'The Core Worlds was an ancient region bordering the outlying areas of the Deep Core, and included some of the most prestigious, well-developed, well-known, and heavily populated planets in the galaxy. The Galactic Republic and subsequently all galaxywide governments were born in the Core Worlds and spread out over the galaxy. During both the time of the Republic and Empire, Coruscant, a major core world, was the Galactic Capital. The region of the Core Worlds known as the Tetrahedron became the cradle of the early Republic, and simultaneously scouts discovered the Perlemian Trade Route and the Corellian Run emanating from Coruscant, creating a region known as the Arrowhead containing the ancient worlds of Alsakan, Anaxes, Basilisk and Ixtlar')
INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (3, N'COLO', N'Colonies', N'The Colonies, so named because it was among the first areas outside the Core to be colonized, contained many of the galaxy''s wealthiest worlds and prided itself on being the galaxy''s economic engine. Worlds here were typically heavily populated, industrialized, and cultured, and the region was considered the meeting point of Core wealth and Rim raw materials. The Colonies, forming the tip of the Slice, came to include many of the galaxy''s oldest manufacturing worlds, including Balmorra, Commenor and Neimoidia')
INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (4, N'INRI', N'Inner Rim', N'The Inner Rim was a region of the galaxy between the Colonies and the Expansion Region. It was originally just called "The Rim", as it was expected to be the farthest extent of the known galaxy for centuries.The region had minimal cultural influence and had few truly notable planets beyond the ecumenopolis of Denon and the medical worlds of Manaan and Thyferra. As the bridge between the Core and the Rim, the Inner Rim held great strategic value, and during both the Clone Wars and the Galactic Civil War, brutal battles were fought over the region')
INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (5, N'EXRE', N'Expansion Region', N'The Expansion Region began as an experiment in corporate-controlled worlds, known as the Exploitation Region, with powerful corporations exploiting and profiting heavily from the planets for their raw materials, metals and ores. Inhabitants were oppressed while the corporations stripped entire stellar systems along the Corellian Run of all their resources. Expansion Region worlds continued to be producers of raw materials and ores. However, most natural resources were exhausted by the Imperial Period, with Gyndine, Bacrana and Cyrillia being among the few remaining viable ports')
INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (6, N'MIRI', N'Mid-Rim', N'With fewer natural resources (and therefore a smaller population) than many neighboring regions, the Mid Rim was a territory where residents worked hard for everything they had.  Consequently, the Mid Rim built up a successful economy based on low-cost manufacturing and agriculture')
INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (7, N'OURI', N'Outer Rim', N'The Outer Rim Territories was the largest region of the galaxy, and the last widely settled expanse before Wild Space and the Unknown Regions. It was strewn with obscure worlds, and rugged, primitive frontier planets. Due to its distance from the Core, government control was historically the weakest in the Outer Rim Territories, and it was the traditional refuge for dissidents, pilgrims and freedom-seekers, but it was also beset by lawlessness, oppression and violence.  Worlds closest to the major super-hyperroutes tended to be the most civilized, but far from these trade links, they tended to be dominated by the Hutts. Mass settlement of large portions of the Outer Rim did not begin until after 5500 BBY, when colonists took advantage of the new trade routes of the Hydian, the Rimma, and the Corellian Trade Spine. Settlement in the southern quadrant was rapid, but expansion in the northern quadrant was hampered by the Great Galactic War. In 124 BBY, the Senate declared the whole region a Free Trade Zone in an effort to jump-start economic development, but this was exploited by the Trade Federation, and the Senate re-imposing taxation in 33 BBY was the trigger for the Invasion of Naboo and the Separatist Crisis. The Galactic Empire oppressed much of the Outer Rim, leading to greater sympathy for the Alliance to Restore the Republic in the region, but the New Republic and the Galactic Alliance both failed to impose central control in the area, leaving the Outer Rim much as it had been for centuries')
INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (8, N'WISP', N'Wild Space', N'Wild Space was the frontier of galactic society, separating the known parts of the galaxy from the Unknown Regions. It was not a formal label, but was applied to the unsettled galactic fringe and other parts of the galaxy with negligible colonization or development.  Wild Space differed from the Unknown Regions in that some of Wild Space had been explored, though not extensively, and the findings recorded in official logs. The worlds of Wild Space largely ignored the central government, and were generally peaceful, but many acted as criminal hideaways')
INSERT [dbo].[Regions] ([idRegion], [CodeRegion], [DescRegion], [Remarks]) VALUES (9, N'UNRE', N'Unknown Regions', N'The term "Unknown Regions" referred to those areas that had not been directly surveyed by Republic or Imperial scouts. It was most commonly applied to the less-known parts of the galaxy''s western disk, a quadrant stretching roughly between Bakura and the Imperial Remnant')
SET IDENTITY_INSERT [dbo].[Regions] OFF
GO
SET IDENTITY_INSERT [dbo].[Routes] ON 

INSERT [dbo].[Routes] ([idRoute], [CodeRoute], [DescRoute], [idPlanetOr], [idPlanetDest], [idRouteType]) VALUES (1, N'CORU', N'Corellian Run', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Routes] OFF
GO
SET IDENTITY_INSERT [dbo].[RouteTypes] ON 

INSERT [dbo].[RouteTypes] ([idRouteType], [CodeRouteType], [DescRouteType], [Remarks]) VALUES (1, N'MAJOR', N'Major hyperspace route', NULL)
INSERT [dbo].[RouteTypes] ([idRouteType], [CodeRouteType], [DescRouteType], [Remarks]) VALUES (2, N'MINOR', N'Minor hyperspace route', NULL)
SET IDENTITY_INSERT [dbo].[RouteTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Sectors] ON 

INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (1, N'TASH', N'Tashtor', NULL, 6)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (2, N'CHOM', N'Chrommell', NULL, 6)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (3, N'QUEL', N'Quelli', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (4, N'MYTA', N'Mytaranor', NULL, 6)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (5, N'PYRS', N'Pyrshak', NULL, 4)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (6, N'RAIO', N'Raioballo', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (7, N'ARKA', N'Arkanis', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (8, N'ATRA', N'Atravis', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (9, N'MODD', N'Moddell', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (10, N'CORU', N'Corusca', NULL, 2)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (11, N'SLUI', N'Sluis', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (12, N'JAKK', N'Jakku', NULL, 4)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (13, N'MAND', N'Mandalore', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (14, N'KUAT', N'Kuat', NULL, 2)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (15, N'CORE', N'Corellia', NULL, 2)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (16, N'ANOA', N'Anoat', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (17, N'BAXE', N'Baxel', NULL, 8)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (18, N'ILEE', N'Ileenium', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (19, N'DULU', N'Duluur', NULL, 3)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (20, N'KESS', N'Kessel', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (21, N'SHIL', N'Shili', NULL, 5)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (22, N'JELU', N'Jelucan', NULL, 7)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (23, N'BESH', N'Beshqek', NULL, 1)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (24, N'GYND', N'Gyndine', NULL, 5)
INSERT [dbo].[Sectors] ([idSector], [CodeSector], [DescSector], [Remarks], [idRegion]) VALUES (25, N'RAKA', N'Rakata', NULL, 9)
SET IDENTITY_INSERT [dbo].[Sectors] OFF
GO
SET IDENTITY_INSERT [dbo].[SpaceShipCategories] ON 

INSERT [dbo].[SpaceShipCategories] ([idSpaceShipCategory], [CodeSpaceShipCategory], [DescSpaceShipCategory]) VALUES (1, N'CICA', N'Civil Cargo')
INSERT [dbo].[SpaceShipCategories] ([idSpaceShipCategory], [CodeSpaceShipCategory], [DescSpaceShipCategory]) VALUES (2, N'MICA', N'Militar Cargo')
INSERT [dbo].[SpaceShipCategories] ([idSpaceShipCategory], [CodeSpaceShipCategory], [DescSpaceShipCategory]) VALUES (3, N'MISS', N'Militar Space Ship')
INSERT [dbo].[SpaceShipCategories] ([idSpaceShipCategory], [CodeSpaceShipCategory], [DescSpaceShipCategory]) VALUES (4, N'MIDS', N'Militar destructor')
SET IDENTITY_INSERT [dbo].[SpaceShipCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[SpaceShips] ON 

INSERT [dbo].[SpaceShips] ([idSpaceShip], [idSpaceShipType], [CodeSpaceShip], [IPSpaceShip], [PortSpaceShip], [PortSpaceShip1]) VALUES (4, 2, N'FC-G1SP', N'127.0.0.1', NULL, NULL)
INSERT [dbo].[SpaceShips] ([idSpaceShip], [idSpaceShipType], [CodeSpaceShip], [IPSpaceShip], [PortSpaceShip], [PortSpaceShip1]) VALUES (5, 1002, N'FC-G2SP', N'172.17.0.211', NULL, NULL)
INSERT [dbo].[SpaceShips] ([idSpaceShip], [idSpaceShipType], [CodeSpaceShip], [IPSpaceShip], [PortSpaceShip], [PortSpaceShip1]) VALUES (6, 2, N'FA-123', N'X-Wings DAM', NULL, NULL)
SET IDENTITY_INSERT [dbo].[SpaceShips] OFF
GO
SET IDENTITY_INSERT [dbo].[SpaceShipTypes] ON 

INSERT [dbo].[SpaceShipTypes] ([idSpaceShipType], [CodeSpaceShipType], [DescSpaceShipType], [idFiliation], [idSpaceShipCategory]) VALUES (2, N'RACA', N'Freight Space Cargo', 1, 1)
INSERT [dbo].[SpaceShipTypes] ([idSpaceShipType], [CodeSpaceShipType], [DescSpaceShipType], [idFiliation], [idSpaceShipCategory]) VALUES (1002, N'FACA', N'Figther Space Ships', 1, 1)
SET IDENTITY_INSERT [dbo].[SpaceShipTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Species] ON 

INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (1, N'HUMAaaa', N'Human')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (2, N'WOOK', N'Wookiee')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (3, N'BRAV', N'Bravaisian')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (4, N'GUNG', N'Gungan')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (5, N'DATH', N'Dathomirians')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (6, N'SELK', N'Selkath')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (7, N'MUST', N'Mustafarian')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (8, N'EWOK', N'Ewoks')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (9, N'UNKN', N'Unknown')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (10, N'TEED', N'Teedo')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (11, N'KUAT', N'Kuati')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (12, N'HUTT', N'Hutt')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (13, N'DEVA', N'Devaronian')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (14, N'PYKE', N'Pyke')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (15, N'TOGR', N'Togruta')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (16, N'TWIL', N'Twi''lek')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (17, N'RAKA', N'Rakata')
INSERT [dbo].[Species] ([idSpecie], [CodeSpecie], [DescSpecie]) VALUES (18, N'aaaa', N'aaaaaaaaaaaaaaa')
SET IDENTITY_INSERT [dbo].[Species] OFF
GO
SET IDENTITY_INSERT [dbo].[UserCategories] ON 

INSERT [dbo].[UserCategories] ([idUserCategory], [CodeCategory], [DescCategory], [AccessLevel]) VALUES (1, N'PILO', N'Pilot', 50)
INSERT [dbo].[UserCategories] ([idUserCategory], [CodeCategory], [DescCategory], [AccessLevel]) VALUES (2, N'ENGI', N'Engineer', 70)
INSERT [dbo].[UserCategories] ([idUserCategory], [CodeCategory], [DescCategory], [AccessLevel]) VALUES (3, N'JEDI', N'Jedi', 100)
INSERT [dbo].[UserCategories] ([idUserCategory], [CodeCategory], [DescCategory], [AccessLevel]) VALUES (4, N'OPER', N'Factory operator', 30)
INSERT [dbo].[UserCategories] ([idUserCategory], [CodeCategory], [DescCategory], [AccessLevel]) VALUES (5, N'PACS', N'Planetary security ', 20)
SET IDENTITY_INSERT [dbo].[UserCategories] OFF
GO
INSERT [dbo].[UserOptions] ([idUser], [minLevel], [Descripcio], [Classe], [Formulari], [taula]) VALUES (N'1         ', N'20        ', N'Cerca', N'formsAuxiliars.dll', N'formsAuxiliars.frmSimple', N'Agencies')
INSERT [dbo].[UserOptions] ([idUser], [minLevel], [Descripcio], [Classe], [Formulari], [taula]) VALUES (N'2         ', N'30        ', N'Gestió Espècies', N'GestioFormUsers.dll', N'GestioFormUsers.GestioEspecies', N'Species')
INSERT [dbo].[UserOptions] ([idUser], [minLevel], [Descripcio], [Classe], [Formulari], [taula]) VALUES (N'3         ', N'30        ', N'Gestió Usuaris', N'users.dll', N'users.GestioUsers', N'Users')
INSERT [dbo].[UserOptions] ([idUser], [minLevel], [Descripcio], [Classe], [Formulari], [taula]) VALUES (N'4         ', N'50        ', N'Gestió Categories Usuaris', N'categories.dll', N'categories.GestioCategories', N'UserCategories')
INSERT [dbo].[UserOptions] ([idUser], [minLevel], [Descripcio], [Classe], [Formulari], [taula]) VALUES (N'5         ', N'50        ', N'Gestió Sectors', N'sectors.dll', N'sectors.GestioSectors', N'Sectors')
GO
SET IDENTITY_INSERT [dbo].[UserRanks] ON 

INSERT [dbo].[UserRanks] ([idUserRank], [CodeRank], [DescRank]) VALUES (1, N'CAPT', N'Captain')
INSERT [dbo].[UserRanks] ([idUserRank], [CodeRank], [DescRank]) VALUES (2, N'LIEU', N'Lieutenant')
INSERT [dbo].[UserRanks] ([idUserRank], [CodeRank], [DescRank]) VALUES (3, N'GENE', N'General')
INSERT [dbo].[UserRanks] ([idUserRank], [CodeRank], [DescRank]) VALUES (4, N'ENGI', N'Engineer')
INSERT [dbo].[UserRanks] ([idUserRank], [CodeRank], [DescRank]) VALUES (5, N'COLO', N'Colonel')
SET IDENTITY_INSERT [dbo].[UserRanks] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([idUser], [CodeUser], [UserName], [Login], [Password], [idUserRank], [idUserCategory], [Photo], [idPlanet], [idSpecie]) VALUES (1, N'GUTW-138/9A', N'Guti StormLight', N'1', N'1', 1, 1, N'c:\temp\JediGutiDef.png', 1, 1)
INSERT [dbo].[Users] ([idUser], [CodeUser], [UserName], [Login], [Password], [idUserRank], [idUserCategory], [Photo], [idPlanet], [idSpecie]) VALUES (2, N'METX-199/3E', N'Isa Varelis', N'isa', N'hola', 3, 3, N'c:\temp\GutiPilot.png', 3, 2)
INSERT [dbo].[Users] ([idUser], [CodeUser], [UserName], [Login], [Password], [idUserRank], [idUserCategory], [Photo], [idPlanet], [idSpecie]) VALUES (3, N'NSDH-345/5A', N'Sergi carreras', NULL, NULL, 2, 1, NULL, 1, 2)
INSERT [dbo].[Users] ([idUser], [CodeUser], [UserName], [Login], [Password], [idUserRank], [idUserCategory], [Photo], [idPlanet], [idSpecie]) VALUES (4, N'JLSB-444/7E', N'Jose Luis sanchez', NULL, NULL, 2, 2, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
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
