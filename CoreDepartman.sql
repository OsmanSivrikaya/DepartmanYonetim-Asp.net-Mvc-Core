USE [corepersonel1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27.02.2022 22:04:34 ******/
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
/****** Object:  Table [dbo].[Admins]    Script Date: 27.02.2022 22:04:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici] [varchar](20) NULL,
	[Sifre] [varchar](10) NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departman]    Script Date: 27.02.2022 22:04:34 ******/
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
/****** Object:  Table [dbo].[personel]    Script Date: 27.02.2022 22:04:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personel](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PerAd] [nvarchar](max) NULL,
	[PerSoyad] [nvarchar](max) NULL,
	[PerSehir] [nvarchar](max) NULL,
	[DepartmanID] [int] NULL,
 CONSTRAINT [PK_personel] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220221125803_deneme', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220222125436_yenideneme', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220222130339_sutunkaldir', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220222130621_detaykaldir', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220222130845_yenideneme', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220222130931_yenideneme2', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220222131339_yenideneme1', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220222131419_yenideneme2', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220222132214_yenimigration3', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220225182636_deneme2', N'5.0.0')
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([AdminID], [Kullanici], [Sifre]) VALUES (1, N'osivrikaya', N'12345')
INSERT [dbo].[Admins] ([AdminID], [Kullanici], [Sifre]) VALUES (2, N'okahraman', N'123456789')
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[departman] ON 

INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (1, N'Muhasebe')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (2, N'Satın Alma')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (3, N'Müdür')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (4, N'Müdür Yardımcısı')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (5, N'Danışma')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (6, N'Sekreterr')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (8, N'Depo Satınalma')
INSERT [dbo].[departman] ([DepartmanID], [DepartmanAd]) VALUES (9, N'Yazılım Geliştirme')
SET IDENTITY_INSERT [dbo].[departman] OFF
GO
SET IDENTITY_INSERT [dbo].[personel] ON 

INSERT [dbo].[personel] ([PersonelID], [PerAd], [PerSoyad], [PerSehir], [DepartmanID]) VALUES (1, N'Osman', N'Sivrikaya', N'İstanbul', 3)
INSERT [dbo].[personel] ([PersonelID], [PerAd], [PerSoyad], [PerSehir], [DepartmanID]) VALUES (2, N'Melisa ', N'Alan ', N'Mersin', 4)
INSERT [dbo].[personel] ([PersonelID], [PerAd], [PerSoyad], [PerSehir], [DepartmanID]) VALUES (3, N'Hasan ', N'Can', N'Adana ', 1)
INSERT [dbo].[personel] ([PersonelID], [PerAd], [PerSoyad], [PerSehir], [DepartmanID]) VALUES (20, N'asdasd', N'asdasd', N'asdasd', 4)
SET IDENTITY_INSERT [dbo].[personel] OFF
GO
ALTER TABLE [dbo].[personel]  WITH CHECK ADD  CONSTRAINT [FK_personel_departman_DepartmanID] FOREIGN KEY([DepartmanID])
REFERENCES [dbo].[departman] ([DepartmanID])
GO
ALTER TABLE [dbo].[personel] CHECK CONSTRAINT [FK_personel_departman_DepartmanID]
GO
