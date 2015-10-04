USE [master]
GO
/****** Object:  Database [EarthPopulation]    Script Date: 2015-10-04 09:45:35 ******/
CREATE DATABASE [EarthPopulation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EarthPopulation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EarthPopulation.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EarthPopulation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EarthPopulation_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EarthPopulation] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EarthPopulation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EarthPopulation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EarthPopulation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EarthPopulation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EarthPopulation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EarthPopulation] SET ARITHABORT OFF 
GO
ALTER DATABASE [EarthPopulation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EarthPopulation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EarthPopulation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EarthPopulation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EarthPopulation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EarthPopulation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EarthPopulation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EarthPopulation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EarthPopulation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EarthPopulation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EarthPopulation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EarthPopulation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EarthPopulation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EarthPopulation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EarthPopulation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EarthPopulation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EarthPopulation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EarthPopulation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EarthPopulation] SET  MULTI_USER 
GO
ALTER DATABASE [EarthPopulation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EarthPopulation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EarthPopulation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EarthPopulation] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EarthPopulation] SET DELAYED_DURABILITY = DISABLED 
GO
USE [EarthPopulation]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 2015-10-04 09:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[AddressText] [nvarchar](150) NOT NULL,
	[TownId] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 2015-10-04 09:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 2015-10-04 09:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentId] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[People]    Script Date: 2015-10-04 09:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 2015-10-04 09:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([AddressId], [AddressText], [TownId]) VALUES (1, N'Address in Sofia', 1)
INSERT [dbo].[Addresses] ([AddressId], [AddressText], [TownId]) VALUES (2, N'Another address in Sofia', 1)
INSERT [dbo].[Addresses] ([AddressId], [AddressText], [TownId]) VALUES (3, N'Some Address in Plovdiv', 2)
INSERT [dbo].[Addresses] ([AddressId], [AddressText], [TownId]) VALUES (4, N'Address in Plovdiv', 2)
INSERT [dbo].[Addresses] ([AddressId], [AddressText], [TownId]) VALUES (5, N'Address in Munich', 5)
INSERT [dbo].[Addresses] ([AddressId], [AddressText], [TownId]) VALUES (6, N'Other address in Munich', 5)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (2, N'Asia')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (3, N'Africa')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (4, N'Australia')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryId], [Name], [ContinentId]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinentId]) VALUES (2, N'Germany', 1)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinentId]) VALUES (3, N'China', 2)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinentId]) VALUES (4, N'Japan', 2)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinentId]) VALUES (5, N'Algeria', 3)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinentId]) VALUES (6, N'Nigeria', 3)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinentId]) VALUES (7, N'Australia', 4)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (1, N'Pesho', N'Peshov', 1)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (2, N'Gosho', N'Goshov', 2)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (3, N'Pesho', N'Goshov', 3)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (4, N'Gosho', N'Peshov', 4)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (5, N'Ivan', N'Ivanov', 5)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (6, N'Pesho', N'Ivanov', 6)
SET IDENTITY_INSERT [dbo].[People] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (2, N'Plovdiv', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (3, N'Melbourne', 7)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (4, N'Berlin', 2)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (5, N'Munich', 2)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (6, N'Dortmund', 2)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (7, N'Burgas', 1)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([TownId])
REFERENCES [dbo].[Towns] ([TownId])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[Continents] ([ContinentID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Addresses] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([AddressId])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([CountryId])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
USE [master]
GO
ALTER DATABASE [EarthPopulation] SET  READ_WRITE 
GO
