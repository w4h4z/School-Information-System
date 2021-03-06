USE [master]
GO
/****** Object:  Database [DBLKS]    Script Date: 16/09/2017 15:03:50 ******/
CREATE DATABASE [DBLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBLKS.mdf' , SIZE = 7168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBLKS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBLKS] SET  MULTI_USER 
GO
ALTER DATABASE [DBLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBLKS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBLKS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBLKS]
GO
/****** Object:  Table [dbo].[Barang]    Script Date: 16/09/2017 15:03:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barang](
	[id_barang] [int] IDENTITY(1,1) NOT NULL,
	[nama_barang] [varchar](50) NOT NULL,
	[stock] [int] NOT NULL,
	[jual] [int] NOT NULL,
	[beli] [int] NOT NULL,
 CONSTRAINT [PK_Barang] PRIMARY KEY CLUSTERED 
(
	[id_barang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Beli]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beli](
	[id_beli] [int] IDENTITY(1,1) NOT NULL,
	[id_barang] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_Beli] PRIMARY KEY CLUSTERED 
(
	[id_beli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Class]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[Name_c] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetailClass]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailClass](
	[ClassID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
 CONSTRAINT [PK_DetailClass] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC,
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HeaderSchedule]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeaderSchedule](
	[ScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
	[Day] [varchar](50) NOT NULL,
	[Time] [varchar](50) NOT NULL,
 CONSTRAINT [PK_schedule] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Jual]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jual](
	[id_jual] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[TeacherID] [int] NOT NULL,
	[id_barang] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[total] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_Jual] PRIMARY KEY CLUSTERED 
(
	[id_jual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Name_st] [varchar](50) NOT NULL,
	[DateofBirth] [date] NOT NULL,
	[Gender] [varchar](7) NOT NULL,
	[Address] [text] NOT NULL,
	[NoHp] [varchar](12) NOT NULL,
 CONSTRAINT [PK_siswa] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subject]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[Name_sb] [varchar](50) NOT NULL,
	[Description] [text] NOT NULL,
	[Assignment] [int] NOT NULL,
	[Mid_Exam] [int] NOT NULL,
	[Final_Exam] [int] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherID] [int] IDENTITY(1,1) NOT NULL,
	[Name_t] [varchar](50) NOT NULL,
	[DateofBirth] [date] NOT NULL,
	[Gender] [varchar](7) NOT NULL,
	[Address] [text] NOT NULL,
	[NoHp] [varchar](12) NOT NULL,
 CONSTRAINT [PK_guru] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transaksi]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaksi](
	[nama_barang] [varchar](50) NOT NULL,
	[jual] [int] NOT NULL,
	[beli] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[total] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_Transaksi] PRIMARY KEY CLUSTERED 
(
	[nama_barang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 16/09/2017 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Role] [varchar](10) NOT NULL,
	[StudentID] [int] NULL,
	[TeacherID] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Barang] ON 

INSERT [dbo].[Barang] ([id_barang], [nama_barang], [stock], [jual], [beli]) VALUES (1, N'pencil', 7, 2000, 1500)
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [stock], [jual], [beli]) VALUES (2, N'pen', 10, 2500, 2000)
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [stock], [jual], [beli]) VALUES (3, N'book', 13, 3000, 2500)
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [stock], [jual], [beli]) VALUES (4, N'soap', 10, 3000, 2800)
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [stock], [jual], [beli]) VALUES (7, N'shampoo', 10, 2000, 1000)
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [stock], [jual], [beli]) VALUES (9, N'computer', 5, 4000000, 4500000)
SET IDENTITY_INSERT [dbo].[Barang] OFF
SET IDENTITY_INSERT [dbo].[Beli] ON 

INSERT [dbo].[Beli] ([id_beli], [id_barang], [quantity], [date]) VALUES (1, 3, 0, CAST(N'2017-09-16' AS Date))
INSERT [dbo].[Beli] ([id_beli], [id_barang], [quantity], [date]) VALUES (2, 1, 2, CAST(N'2017-09-16' AS Date))
INSERT [dbo].[Beli] ([id_beli], [id_barang], [quantity], [date]) VALUES (3, 1, 2, CAST(N'2017-09-16' AS Date))
INSERT [dbo].[Beli] ([id_beli], [id_barang], [quantity], [date]) VALUES (4, 2, 6, CAST(N'2017-09-16' AS Date))
SET IDENTITY_INSERT [dbo].[Beli] OFF
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ClassID], [Name_c]) VALUES (1, N'XII RPL 1')
INSERT [dbo].[Class] ([ClassID], [Name_c]) VALUES (2, N'XII RPL 2')
INSERT [dbo].[Class] ([ClassID], [Name_c]) VALUES (3, N'XII RPL 3')
INSERT [dbo].[Class] ([ClassID], [Name_c]) VALUES (4, N'XII RPL 4')
SET IDENTITY_INSERT [dbo].[Class] OFF
INSERT [dbo].[DetailClass] ([ClassID], [StudentID]) VALUES (1, 37)
INSERT [dbo].[DetailClass] ([ClassID], [StudentID]) VALUES (1, 48)
INSERT [dbo].[DetailClass] ([ClassID], [StudentID]) VALUES (2, 6)
INSERT [dbo].[DetailClass] ([ClassID], [StudentID]) VALUES (2, 31)
INSERT [dbo].[DetailClass] ([ClassID], [StudentID]) VALUES (3, 28)
INSERT [dbo].[DetailClass] ([ClassID], [StudentID]) VALUES (4, 1)
INSERT [dbo].[DetailClass] ([ClassID], [StudentID]) VALUES (4, 2)
SET IDENTITY_INSERT [dbo].[HeaderSchedule] ON 

INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (1, 1, 1, 1, N'Monday', N'06.15-08.30')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (2, 2, 2, 2, N'Monday', N'06.15-08.30')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (3, 3, 3, 3, N'Monday', N'06.15-08.30')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (4, 4, 4, 4, N'Monday', N'06.15-08.30')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (5, 2, 2, 1, N'Monday', N'09.00-11.15')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (6, 3, 3, 2, N'Monday', N'09.00-11.15')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (7, 4, 4, 3, N'Monday', N'09.00-11.15')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (8, 1, 1, 4, N'Monday', N'09.00-11.15')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (9, 3, 3, 1, N'Tuesday', N'06.15-08.30')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (10, 4, 4, 2, N'Tuesday', N'06.15-08.30')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (11, 1, 1, 3, N'Tuesday', N'06.15-08.30')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (12, 2, 2, 4, N'Tuesday', N'06.15-08.30')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (13, 4, 4, 1, N'Tuesday', N'09.00-11.15')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (14, 1, 1, 2, N'Tuesday', N'09.00-11.15')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (15, 2, 2, 3, N'Tuesday', N'09.00-11.15')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (16, 3, 3, 4, N'Tuesday', N'09.00-11.15')
INSERT [dbo].[HeaderSchedule] ([ScheduleID], [TeacherID], [SubjectID], [ClassID], [Day], [Time]) VALUES (17, 4, 1, 4, N'Monday', N'06.15-08.30')
SET IDENTITY_INSERT [dbo].[HeaderSchedule] OFF
SET IDENTITY_INSERT [dbo].[Jual] ON 

INSERT [dbo].[Jual] ([id_jual], [StudentID], [TeacherID], [id_barang], [quantity], [total], [date]) VALUES (1, 1, 1, 1, 2, 4000, CAST(N'2017-10-10' AS Date))
INSERT [dbo].[Jual] ([id_jual], [StudentID], [TeacherID], [id_barang], [quantity], [total], [date]) VALUES (5, 1, 1, 2, 3, 7500, CAST(N'2017-09-16' AS Date))
INSERT [dbo].[Jual] ([id_jual], [StudentID], [TeacherID], [id_barang], [quantity], [total], [date]) VALUES (6, 1, 1, 1, 1, 2000, CAST(N'2017-09-16' AS Date))
INSERT [dbo].[Jual] ([id_jual], [StudentID], [TeacherID], [id_barang], [quantity], [total], [date]) VALUES (7, 1, 1, 1, 3, 6000, CAST(N'2017-09-16' AS Date))
INSERT [dbo].[Jual] ([id_jual], [StudentID], [TeacherID], [id_barang], [quantity], [total], [date]) VALUES (8, 1, 1, 2, 2, 5000, CAST(N'2017-09-16' AS Date))
INSERT [dbo].[Jual] ([id_jual], [StudentID], [TeacherID], [id_barang], [quantity], [total], [date]) VALUES (9, 1, 1, 2, 3, 7500, CAST(N'2017-09-16' AS Date))
INSERT [dbo].[Jual] ([id_jual], [StudentID], [TeacherID], [id_barang], [quantity], [total], [date]) VALUES (10, 1, 1, 3, 3, 9000, CAST(N'2017-09-16' AS Date))
SET IDENTITY_INSERT [dbo].[Jual] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (1, N'Achmad Maulana Wisudatama', CAST(N'1999-03-29' AS Date), N'L', N'Jl. Danau Tambingan G6/G20', N'085708900788')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (2, N'Achmad Rama Wicaksono', CAST(N'1999-04-21' AS Date), N'P', N'Jl. Pepaya RT02/01 No.52 Tangkil-Wlingi-Blitar', N'081233591222')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (3, N'Adika Moratalent', CAST(N'1999-03-01' AS Date), N'P', N'Jl. Danau Ranau G5 E28', N'08123210706')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (4, N'Ardy Wicaksono', CAST(N'1999-10-29' AS Date), N'P', N'Jl. Danau Ranau XII', N'082142788256')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (5, N'Aditya Eka Pratama', CAST(N'1998-08-23' AS Date), N'L', N'Jl. Danau Bratan G6 J15 Sawojajar Malang', N'08121681281')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (6, N'Alfain Azzaria Bustami', CAST(N'1999-01-31' AS Date), N'P', N'JL. Danau Kerinci IV G6B15, Sawojajar - Malang ', N'0341-7387665')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (7, N'AURELIA ANINDYA KRESNADEWATI', CAST(N'1999-01-08' AS Date), N'P', N'Jl. Kyai Matlap no.5 Tempeh Lor - Lumajang', N'087757054302')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (8, N'Bagas Gerry Caesario', CAST(N'1998-03-14' AS Date), N'P', N'Jl. Danau Sarangan Atas F6 B33', N'085231696592')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (9, N'Bagus Prakoso Pujiantono', CAST(N'1998-09-21' AS Date), N'P', N'Jl. Danau Buyan Sawojajar', N'086648314567')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (10, N'CINDY KARTIKA DWI ARMINIA', CAST(N'1999-04-27' AS Date), N'L', N'Jl. Danau Tawuti 4 G5C-11', N'0341-7729777')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (11, N'DARIL MAYDA NURHIDAYAH', CAST(N'1998-06-17' AS Date), N'L', N'Jl.Raya Minggiran No.4 Dsn Rejowinanggun Ds Minggiran Kec Papar Kab Kediri ', N'081335214344')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (12, N'Dedik Pujianto', CAST(N'1999-06-30' AS Date), N'P', N'Jl. Danau Belayan C3 E15', N'082331386201')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (13, N'DENDA HAYU ARTIKA', CAST(N'1999-08-17' AS Date), N'P', N'Kayangan Gg.1 Diwek Jombang', N'0865566')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (14, N'DEVINA ANDHITA JAYA SOEGIARTO', CAST(N'1999-09-15' AS Date), N'L', N'Jl. Candi Telagawangi no. 69', N'082335858574')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (15, N'Dimas Dwi Mei Jaya Wijaya', CAST(N'1999-10-03' AS Date), N'P', N'Jl. Danau Towuti Sawojajar Malang', N'081615603305')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (16, N'Doni Wahyu Nugraha ', CAST(N'1998-10-04' AS Date), N'L', N'Jl. Danau Ranau G7G1 Sawojajar', N'085733985444')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (17, N'Dzaky Achmad Fauzan', CAST(N'1999-06-05' AS Date), N'P', N'Jl. Danau Kerinci Sawojajar Malang', N'085330580104')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (18, N'ENI RUSLI', CAST(N'2000-04-05' AS Date), N'P', N'Jl. Danau Laut Tawar II', N'03414494749')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (19, N'Estellito Deodatus Balalamaronga Kaloge', CAST(N'1999-04-24' AS Date), N'P', N'Jl. Danau Laut Tawar IV blog G5 A4', N'081259286306')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (20, N'EVYRA RIZKI SAFITRI', CAST(N'1999-03-31' AS Date), N'L', N'Jl. Danau Tambingan G6H16', N'082332133959')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (21, N'FERRANI HAYA FEBI NATASYA', CAST(N'1999-04-05' AS Date), N'L', N'Jl. Sawojajar XIII no 60', N'081231085974')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (22, N'Haniva Naina Zein', CAST(N'1999-06-16' AS Date), N'L', N'Jl. Danau Tambingan No. ', N'0341-511978')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (23, N'JASMIN RAISA PUTRI', CAST(N'1998-10-03' AS Date), N'P', N'Dsn.Krajan,rt.2,rw.1,desa laju kidul kecamatan singgahan,kabupaten tuban', N'082139776704')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (24, N'METHA DAIENA', CAST(N'1998-10-29' AS Date), N'P', N'Jl. Danau Laut Tawar IV ', N'081553462345')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (25, N'Moch Aril Bachtiar', CAST(N'1999-05-20' AS Date), N'P', N'Jl. Danau Ranau I No. 09 Sawojajar Malang', N'081259365177')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (26, N'Muchamad Akbar Fajar Ramadhan', CAST(N'1998-02-25' AS Date), N'P', N'Jl.flamboyan desa babadan RT 04 RW 01,Kec Balerejo,Kab Madiun', N'081335301303')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (27, N'Muhammad Ali Zufan', CAST(N'1999-07-25' AS Date), N'P', N'Jalan Danau Ranau Gang 9 No. 1', N'085791391515')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (28, N'Muhammad Daffa Zakky Eka Pradana', CAST(N'1998-09-21' AS Date), N'L', N'Jl. Ir. Soekarno nomor 221 . Blitar', N'085735242211')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (29, N'NIKEN ANDHITA IBRAHIM', CAST(N'1998-10-04' AS Date), N'P', N'Jl. Danau Laut Tawar II ', N'08123475571')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (30, N'OCHA FATANJALI', CAST(N'1999-01-01' AS Date), N'P', N'Jl. Danau Ranau 7 G1 B19 Sawojajar Malang', N'082131856418')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (31, N'Ramadhani Laili Ansori', CAST(N'1998-09-24' AS Date), N'L', N'Jl. Danau Kerinci IV G6F no 13', N'081230652400')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (32, N'Revanza Devha Ramadhan', CAST(N'1990-10-07' AS Date), N'L', N'Jl. Trs Danau Maninjau Barat IV B3 H11 Sawojajar Malang', N'082233832442')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (33, N'Rina Nur'' Aini', CAST(N'1998-06-22' AS Date), N'L', N'Jl. Danau Ranau GX', N'085233365359')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (34, N'Rizaldo Frendy Kurniawan', CAST(N'1998-11-12' AS Date), N'P', N'Perumahan Sulfat Agung 9 No. 33 Malang', N'082115588515')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (35, N'SERLY SETYANI', CAST(N'1999-09-27' AS Date), N'P', N'Jl. Danau Buyan Sawojajar Malang', N'085250136103')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (36, N'TANIA INDRI MAHARANI', CAST(N'1999-02-10' AS Date), N'P', N'Jl. Danau Kerinci V No G6G15', N'082114893434')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (37, N'Windi Anggita Sari', CAST(N'1999-04-24' AS Date), N'L', N'Jl. Danau Tambingan V No G6D19', N'085101177889')
INSERT [dbo].[Student] ([StudentID], [Name_st], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (48, N'wahaz', CAST(N'2017-09-09' AS Date), N'L', N'Malang', N'08763')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([SubjectID], [Name_sb], [Description], [Assignment], [Mid_Exam], [Final_Exam]) VALUES (1, N'Agama', N'ini pelajaran agama yang mempelajari agama islam', 20, 30, 50)
INSERT [dbo].[Subject] ([SubjectID], [Name_sb], [Description], [Assignment], [Mid_Exam], [Final_Exam]) VALUES (2, N'P K n', N'ini pelajaran pendidikan dan kewarganegaraan', 30, 20, 50)
INSERT [dbo].[Subject] ([SubjectID], [Name_sb], [Description], [Assignment], [Mid_Exam], [Final_Exam]) VALUES (3, N'Bahasa Indonesia', N'ini pelajaran bahasa indonesia', 40, 10, 50)
INSERT [dbo].[Subject] ([SubjectID], [Name_sb], [Description], [Assignment], [Mid_Exam], [Final_Exam]) VALUES (4, N'Matematika', N'ini pelajaran matematika', 30, 30, 40)
SET IDENTITY_INSERT [dbo].[Subject] OFF
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([TeacherID], [Name_t], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (1, N'Achmad Nasikin, M.Pd.', CAST(N'1970-06-30' AS Date), N'L', N'Jl. Danau Belayan C3 E15', N'082331386201')
INSERT [dbo].[Teacher] ([TeacherID], [Name_t], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (2, N'Drs. Trileksono Tj.', CAST(N'1975-06-02' AS Date), N'L', N'Jl. Danau Ranau G7G1 Sawojajar', N'085733985444')
INSERT [dbo].[Teacher] ([TeacherID], [Name_t], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (3, N'Noer Hidayat, S.Pd.', CAST(N'1982-07-10' AS Date), N'L', N'Jl. Danau Kerinci Sawojajar Malang', N'085330580104')
INSERT [dbo].[Teacher] ([TeacherID], [Name_t], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (4, N'Tulus Andrianto, S.Pd.', CAST(N'1985-07-03' AS Date), N'L', N'Jl. Danau Laut Tawar II', N'03414494749')
INSERT [dbo].[Teacher] ([TeacherID], [Name_t], [DateofBirth], [Gender], [Address], [NoHp]) VALUES (10, N'rizal', CAST(N'2017-01-09' AS Date), N'L', N'malang', N'08654')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [Username], [Password], [Role], [StudentID], [TeacherID]) VALUES (1, N'admin', N'admin', N'admin', NULL, 1)
INSERT [dbo].[User] ([UserID], [Username], [Password], [Role], [StudentID], [TeacherID]) VALUES (2, N'teacher', N'teacher', N'teacher', NULL, 2)
INSERT [dbo].[User] ([UserID], [Username], [Password], [Role], [StudentID], [TeacherID]) VALUES (3, N'student', N'student', N'student', 1, NULL)
INSERT [dbo].[User] ([UserID], [Username], [Password], [Role], [StudentID], [TeacherID]) VALUES (8, N'48', N'student', N'student', 48, NULL)
INSERT [dbo].[User] ([UserID], [Username], [Password], [Role], [StudentID], [TeacherID]) VALUES (9, N'10', N'teacher', N'teacher', NULL, 10)
INSERT [dbo].[User] ([UserID], [Username], [Password], [Role], [StudentID], [TeacherID]) VALUES (10, N'1', N'store', N'store', NULL, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Beli]  WITH CHECK ADD  CONSTRAINT [FK_Beli_Barang] FOREIGN KEY([id_barang])
REFERENCES [dbo].[Barang] ([id_barang])
GO
ALTER TABLE [dbo].[Beli] CHECK CONSTRAINT [FK_Beli_Barang]
GO
ALTER TABLE [dbo].[DetailClass]  WITH CHECK ADD  CONSTRAINT [FK_DetailClass_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[DetailClass] CHECK CONSTRAINT [FK_DetailClass_Class]
GO
ALTER TABLE [dbo].[DetailClass]  WITH CHECK ADD  CONSTRAINT [FK_DetailClass_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
ALTER TABLE [dbo].[DetailClass] CHECK CONSTRAINT [FK_DetailClass_Student]
GO
ALTER TABLE [dbo].[HeaderSchedule]  WITH CHECK ADD  CONSTRAINT [FK_HeaderSchedule_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[HeaderSchedule] CHECK CONSTRAINT [FK_HeaderSchedule_Class]
GO
ALTER TABLE [dbo].[HeaderSchedule]  WITH CHECK ADD  CONSTRAINT [FK_HeaderSchedule_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
GO
ALTER TABLE [dbo].[HeaderSchedule] CHECK CONSTRAINT [FK_HeaderSchedule_Subject]
GO
ALTER TABLE [dbo].[HeaderSchedule]  WITH CHECK ADD  CONSTRAINT [FK_HeaderSchedule_Teacher1] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO
ALTER TABLE [dbo].[HeaderSchedule] CHECK CONSTRAINT [FK_HeaderSchedule_Teacher1]
GO
ALTER TABLE [dbo].[Jual]  WITH CHECK ADD  CONSTRAINT [FK_Jual_Barang] FOREIGN KEY([id_barang])
REFERENCES [dbo].[Barang] ([id_barang])
GO
ALTER TABLE [dbo].[Jual] CHECK CONSTRAINT [FK_Jual_Barang]
GO
ALTER TABLE [dbo].[Jual]  WITH CHECK ADD  CONSTRAINT [FK_Jual_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
ALTER TABLE [dbo].[Jual] CHECK CONSTRAINT [FK_Jual_Student]
GO
ALTER TABLE [dbo].[Jual]  WITH CHECK ADD  CONSTRAINT [FK_Jual_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO
ALTER TABLE [dbo].[Jual] CHECK CONSTRAINT [FK_Jual_Teacher]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Student]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Teacher]
GO
USE [master]
GO
ALTER DATABASE [DBLKS] SET  READ_WRITE 
GO
