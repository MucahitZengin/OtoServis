USE [master]
GO
/****** Object:  Database [OtoServis]    Script Date: 18.07.2023 22:22:01 ******/
CREATE DATABASE [OtoServis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OtoServis', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\OtoServis.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OtoServis_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\OtoServis_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [OtoServis] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OtoServis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OtoServis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OtoServis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OtoServis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OtoServis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OtoServis] SET ARITHABORT OFF 
GO
ALTER DATABASE [OtoServis] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OtoServis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OtoServis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OtoServis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OtoServis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OtoServis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OtoServis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OtoServis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OtoServis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OtoServis] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OtoServis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OtoServis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OtoServis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OtoServis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OtoServis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OtoServis] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OtoServis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OtoServis] SET RECOVERY FULL 
GO
ALTER DATABASE [OtoServis] SET  MULTI_USER 
GO
ALTER DATABASE [OtoServis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OtoServis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OtoServis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OtoServis] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OtoServis] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OtoServis] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'OtoServis', N'ON'
GO
ALTER DATABASE [OtoServis] SET QUERY_STORE = ON
GO
ALTER DATABASE [OtoServis] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [OtoServis]
GO
/****** Object:  Table [dbo].[tbl_Arabalar]    Script Date: 18.07.2023 22:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Arabalar](
	[ArabaID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriID] [int] NULL,
	[Marka] [nvarchar](50) NULL,
	[Model] [nvarchar](50) NULL,
	[Plaka] [nvarchar](50) NULL,
	[UretimYili] [int] NULL,
	[MotorTipi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Arabalar] PRIMARY KEY CLUSTERED 
(
	[ArabaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Islemler]    Script Date: 18.07.2023 22:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Islemler](
	[IslemID] [int] IDENTITY(1,1) NOT NULL,
	[ArabaID] [int] NULL,
	[IslemAciklamasi] [nvarchar](50) NULL,
	[IslemTarihi] [datetime] NULL,
	[IslemUcreti] [money] NULL,
 CONSTRAINT [PK_tbl_Islemler] PRIMARY KEY CLUSTERED 
(
	[IslemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Musteriler]    Script Date: 18.07.2023 22:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Musteriler](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Eposta] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Musteriler] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Odemeler]    Script Date: 18.07.2023 22:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Odemeler](
	[OdemeID] [int] IDENTITY(1,1) NOT NULL,
	[IslemID] [int] NULL,
	[OdemeMiktari] [money] NULL,
	[OdemeTarihi] [datetime] NULL,
	[KalanBorc] [money] NULL,
 CONSTRAINT [PK_tbl_Odemeler] PRIMARY KEY CLUSTERED 
(
	[OdemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Arabalar] ON 

INSERT [dbo].[tbl_Arabalar] ([ArabaID], [MusteriID], [Marka], [Model], [Plaka], [UretimYili], [MotorTipi]) VALUES (1, 1, N'Fiat', N'Egea', N'10AS222', 2023, N'1.3MultiJet')
INSERT [dbo].[tbl_Arabalar] ([ArabaID], [MusteriID], [Marka], [Model], [Plaka], [UretimYili], [MotorTipi]) VALUES (2, 2, N'Renault', N'Clio', N'34DF222', 2022, N'1.4dCi')
SET IDENTITY_INSERT [dbo].[tbl_Arabalar] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Islemler] ON 

INSERT [dbo].[tbl_Islemler] ([IslemID], [ArabaID], [IslemAciklamasi], [IslemTarihi], [IslemUcreti]) VALUES (2, 1, N'10 bin bakımı', CAST(N'2023-07-18T16:08:19.107' AS DateTime), 500.0000)
INSERT [dbo].[tbl_Islemler] ([IslemID], [ArabaID], [IslemAciklamasi], [IslemTarihi], [IslemUcreti]) VALUES (3, 1, N'tramer kayışı değişti', CAST(N'2023-07-18T16:19:32.023' AS DateTime), 1000.0000)
INSERT [dbo].[tbl_Islemler] ([IslemID], [ArabaID], [IslemAciklamasi], [IslemTarihi], [IslemUcreti]) VALUES (4, 1, N'lastik değisti', CAST(N'2023-07-18T16:21:21.130' AS DateTime), 1500.0000)
INSERT [dbo].[tbl_Islemler] ([IslemID], [ArabaID], [IslemAciklamasi], [IslemTarihi], [IslemUcreti]) VALUES (6, 1, N'baska bisey', CAST(N'2023-07-18T16:29:21.800' AS DateTime), 2500.0000)
INSERT [dbo].[tbl_Islemler] ([IslemID], [ArabaID], [IslemAciklamasi], [IslemTarihi], [IslemUcreti]) VALUES (8, 1, N'deneme', CAST(N'2023-07-18T21:20:50.983' AS DateTime), 1000.0000)
SET IDENTITY_INSERT [dbo].[tbl_Islemler] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Musteriler] ON 

INSERT [dbo].[tbl_Musteriler] ([MusteriID], [Adi], [Soyadi], [Adres], [Telefon], [Eposta]) VALUES (1, N'Mehmet', N'Yıldiz', N'Balikesir', N'05555555555', N'my@gmail.com')
INSERT [dbo].[tbl_Musteriler] ([MusteriID], [Adi], [Soyadi], [Adres], [Telefon], [Eposta]) VALUES (2, N'Zeynep', N'Kaya', N'İstanbul', N'05554443322', N'zk@gmail.com')
SET IDENTITY_INSERT [dbo].[tbl_Musteriler] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Odemeler] ON 

INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (3, 3, 500.0000, CAST(N'2023-07-18T20:51:24.173' AS DateTime), 500.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (4, 3, 250.0000, CAST(N'2023-07-18T20:57:13.403' AS DateTime), 250.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (5, 4, 500.0000, CAST(N'2023-07-18T20:58:38.410' AS DateTime), 1000.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (6, 2, 0.0000, CAST(N'2023-07-18T20:59:38.837' AS DateTime), 0.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (7, 6, 2000.0000, CAST(N'2023-07-18T21:00:28.500' AS DateTime), 500.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (8, 3, 250.0000, CAST(N'2023-07-18T21:00:57.020' AS DateTime), 0.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (9, 4, 999.0000, CAST(N'2023-07-18T21:01:27.060' AS DateTime), 1.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (10, 4, 1.0000, CAST(N'2023-07-18T21:01:43.683' AS DateTime), 0.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (12, 8, 500.0000, CAST(N'2023-07-18T21:21:09.033' AS DateTime), 500.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (13, 8, 500.0000, CAST(N'2023-07-18T21:21:23.083' AS DateTime), 0.0000)
INSERT [dbo].[tbl_Odemeler] ([OdemeID], [IslemID], [OdemeMiktari], [OdemeTarihi], [KalanBorc]) VALUES (14, 6, 500.0000, CAST(N'2023-07-18T21:21:36.330' AS DateTime), 0.0000)
SET IDENTITY_INSERT [dbo].[tbl_Odemeler] OFF
GO
ALTER TABLE [dbo].[tbl_Arabalar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Arabalar_tbl_Musteriler] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[tbl_Musteriler] ([MusteriID])
GO
ALTER TABLE [dbo].[tbl_Arabalar] CHECK CONSTRAINT [FK_tbl_Arabalar_tbl_Musteriler]
GO
ALTER TABLE [dbo].[tbl_Islemler]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Islemler_tbl_Arabalar] FOREIGN KEY([ArabaID])
REFERENCES [dbo].[tbl_Arabalar] ([ArabaID])
GO
ALTER TABLE [dbo].[tbl_Islemler] CHECK CONSTRAINT [FK_tbl_Islemler_tbl_Arabalar]
GO
ALTER TABLE [dbo].[tbl_Odemeler]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Odemeler_tbl_Islemler] FOREIGN KEY([IslemID])
REFERENCES [dbo].[tbl_Islemler] ([IslemID])
GO
ALTER TABLE [dbo].[tbl_Odemeler] CHECK CONSTRAINT [FK_tbl_Odemeler_tbl_Islemler]
GO
USE [master]
GO
ALTER DATABASE [OtoServis] SET  READ_WRITE 
GO
