USE [corepersonel]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21.02.2022 18:31:44 ******/
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
/****** Object:  Table [dbo].[departman]    Script Date: 21.02.2022 18:31:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departman](
	[DepartmanID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmanAd] [nvarchar](max) NULL,
 CONSTRAINT [PK_departman] PRIMARY KEY CLUSTERED 
(
	[DepartmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personel]    Script Date: 21.02.2022 18:31:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personel](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PerAd] [nvarchar](max) NULL,
	[PerSoyad] [nvarchar](max) NULL,
	[PerSehir] [nvarchar](max) NULL,
 CONSTRAINT [PK_personel] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220221125803_deneme', N'5.0.0')
GO
SET IDENTITY_INSERT [dbo].[departman] ON 

INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (1, N'Muhasebe')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (2, N'Satın Alma')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (3, N'Müdür')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (4, N'Müdür Yardımcısı')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (5, N'Danışma')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (6, N'Sekreterr')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (8, N'Depo Satınalma')
SET IDENTITY_INSERT [dbo].[departman] OFF
GO
