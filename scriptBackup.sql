USE [master]
GO
/****** Object:  Database [БД Телестудии]    Script Date: 24.11.2024 19:20:29 ******/
CREATE DATABASE [БД Телестудии]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'БД Телестудии', FILENAME = N'F:\SQLSERVER\MSSQL16.MSSQLSERVER\MSSQL\DATA\БД Телестудии.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'БД Телестудии_log', FILENAME = N'F:\SQLSERVER\MSSQL16.MSSQLSERVER\MSSQL\DATA\БД Телестудии_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [БД Телестудии] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [БД Телестудии].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [БД Телестудии] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [БД Телестудии] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [БД Телестудии] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [БД Телестудии] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [БД Телестудии] SET ARITHABORT OFF 
GO
ALTER DATABASE [БД Телестудии] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [БД Телестудии] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [БД Телестудии] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [БД Телестудии] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [БД Телестудии] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [БД Телестудии] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [БД Телестудии] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [БД Телестудии] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [БД Телестудии] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [БД Телестудии] SET  DISABLE_BROKER 
GO
ALTER DATABASE [БД Телестудии] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [БД Телестудии] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [БД Телестудии] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [БД Телестудии] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [БД Телестудии] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [БД Телестудии] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [БД Телестудии] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [БД Телестудии] SET RECOVERY FULL 
GO
ALTER DATABASE [БД Телестудии] SET  MULTI_USER 
GO
ALTER DATABASE [БД Телестудии] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [БД Телестудии] SET DB_CHAINING OFF 
GO
ALTER DATABASE [БД Телестудии] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [БД Телестудии] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [БД Телестудии] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [БД Телестудии] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'БД Телестудии', N'ON'
GO
ALTER DATABASE [БД Телестудии] SET QUERY_STORE = ON
GO
ALTER DATABASE [БД Телестудии] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [БД Телестудии]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[ID_Event] [smallint] NOT NULL,
	[ID_Broadcast] [smallint] NOT NULL,
	[ID_Videomaterial] [smallint] NOT NULL,
	[Start_time] [time](7) NOT NULL,
	[Playback_duration] [int] NOT NULL,
	[Transition_type] [varchar](25) NULL,
	[Recording_source] [varchar](35) NULL,
	[Transition_duration] [int] NULL,
	[Delay_duration] [int] NULL,
	[Event_description] [varchar](125) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Event] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[EventView]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[EventView]
AS
SELECT                      ID_Event, Start_time, Playback_duration, Transition_type, Recording_source, Transition_duration, Delay_duration, Event_description, ID_Broadcast
FROM                         dbo.Event
GO
/****** Object:  Table [dbo].[Category]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID_Category] [smallint] NOT NULL,
	[Title] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Broadcast]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Broadcast](
	[ID_Broadcast] [smallint] NOT NULL,
	[ID_Category] [smallint] NOT NULL,
	[External_Channel] [varchar](45) NOT NULL,
	[Playback_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Broadcast] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Director_BroadcastsPlaybackPlan]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Director_BroadcastsPlaybackPlan]
AS
SELECT DISTINCT 
                                      dbo.Broadcast.ID_Broadcast AS ID, dbo.Category.Title AS Категория, dbo.Broadcast.External_Channel AS [Внешний канал], 
                                      dbo.Broadcast.Playback_date AS [Дата воспроизведения]
FROM                         dbo.Broadcast INNER JOIN
                                      dbo.Category ON dbo.Broadcast.ID_Category = dbo.Category.ID_Category
GO
/****** Object:  Table [dbo].[Videomaterial]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videomaterial](
	[ID_Videomaterial] [smallint] NOT NULL,
	[Idea_description] [varchar](125) NOT NULL,
	[Upload_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Videomaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video_Editing]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video_Editing](
	[ID_Editing] [smallint] NOT NULL,
	[Duration] [int] NOT NULL,
	[Framerate] [smallint] NOT NULL,
	[Author] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Editing] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videomaterial_Usage]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videomaterial_Usage](
	[ID_Videomaterial] [smallint] NOT NULL,
	[ID_Editing] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Videomaterial] ASC,
	[ID_Editing] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VideoProps]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VideoProps]
AS
SELECT                      dbo.Videomaterial.Idea_description, dbo.Video_Editing.Framerate, dbo.Video_Editing.Author
FROM                         dbo.Videomaterial INNER JOIN
                                      dbo.Videomaterial_Usage ON dbo.Videomaterial.ID_Videomaterial = dbo.Videomaterial_Usage.ID_Videomaterial INNER JOIN
                                      dbo.Video_Editing ON dbo.Videomaterial_Usage.ID_Editing = dbo.Video_Editing.ID_Editing
GO
/****** Object:  View [dbo].[Manager_BroadcastsPlaybackPlan]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Manager_BroadcastsPlaybackPlan]
AS
SELECT                      dbo.Broadcast.ID_Broadcast AS ID, dbo.Category.Title AS Категория, dbo.Broadcast.External_Channel AS [Внешний канал], 
                                      dbo.Broadcast.Playback_date AS [Дата воспроизведения]
FROM                         dbo.Broadcast INNER JOIN
                                      dbo.Category ON dbo.Broadcast.ID_Category = dbo.Category.ID_Category
GO
/****** Object:  View [dbo].[BroadcastsPlaybackPlan]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BroadcastsPlaybackPlan]
AS
SELECT DISTINCT 
                                      dbo.Broadcast.ID_Broadcast AS ID, dbo.Category.Title AS Категория, dbo.Broadcast.External_Channel AS [Внешний канал], 
                                      dbo.Broadcast.Playback_date AS [Дата воспроизведения]
FROM                         dbo.Broadcast INNER JOIN
                                      dbo.Category ON dbo.Broadcast.ID_Category = dbo.Category.ID_Category
GO
/****** Object:  View [dbo].[UsedVideomaterials]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UsedVideomaterials]
AS
SELECT                      t1.Idea_description AS Описание, t1.Upload_date AS [Дата загрузки]
FROM                         dbo.Videomaterial_Usage AS t2 RIGHT OUTER JOIN
                                      dbo.Videomaterial AS t1 ON t2.ID_Videomaterial = t1.ID_Videomaterial
WHERE                       (t2.ID_Editing IS NOT NULL)
GROUP BY              t1.Idea_description, t1.Upload_date
GO
/****** Object:  View [dbo].[UnusedVideomaterials]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UnusedVideomaterials]
AS
SELECT                      t1.Idea_description AS Описание, t1.Upload_date AS [Дата загрузки]
FROM                         dbo.Videomaterial_Usage AS t2 RIGHT OUTER JOIN
                                      dbo.Videomaterial AS t1 ON t2.ID_Videomaterial = t1.ID_Videomaterial
WHERE                       (t2.ID_Editing IS NULL)
GROUP BY              t1.Idea_description, t1.Upload_date
GO
/****** Object:  Table [dbo].[Auth]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auth](
	[userLogin] [varchar](35) NOT NULL,
	[userPassword] [varchar](35) NOT NULL,
	[userPosition] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userLogin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Creation_Stage]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Creation_Stage](
	[ID_Stage] [smallint] NOT NULL,
	[ID_Videomaterial] [smallint] NULL,
	[Stage_description] [varchar](155) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Stage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Auth] ([userLogin], [userPassword], [userPosition]) VALUES (N'crew1', N'test', N'crew')
INSERT [dbo].[Auth] ([userLogin], [userPassword], [userPosition]) VALUES (N'crew2', N'test1234', N'crew')
INSERT [dbo].[Auth] ([userLogin], [userPassword], [userPosition]) VALUES (N'dir', N'test', N'director')
INSERT [dbo].[Auth] ([userLogin], [userPassword], [userPosition]) VALUES (N'edit', N'1234', N'edit')
INSERT [dbo].[Auth] ([userLogin], [userPassword], [userPosition]) VALUES (N'editor', N'12345', N'edit')
INSERT [dbo].[Auth] ([userLogin], [userPassword], [userPosition]) VALUES (N'manager1', N'1', N'manager')
INSERT [dbo].[Auth] ([userLogin], [userPassword], [userPosition]) VALUES (N'prod', N'1', N'producer')
GO
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (1, 1, N'SIP Глобал', CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (2, 5, N'МегаКоннект', CAST(N'2024-09-06' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (3, 8, N'ТехноКоммуникации', CAST(N'2024-11-14' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (4, 2, N'МегаКоннект', CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (5, 6, N'SIP Глобал', CAST(N'2024-09-01' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (6, 3, N'SIP Глобал', CAST(N'2024-08-21' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (7, 1, N'МегаКоннект', CAST(N'2024-08-09' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (8, 1, N'МегаКоннект', CAST(N'2024-11-18' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (9, 4, N'SIP Глобал', CAST(N'2024-11-20' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (10, 3, N'ТехноКоммуникации', CAST(N'2024-11-18' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (11, 5, N'КулиГули', CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Broadcast] ([ID_Broadcast], [ID_Category], [External_Channel], [Playback_date]) VALUES (12, 3, N'СолнечныеДети', CAST(N'2024-11-30' AS Date))
GO
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (1, N'Спортивная')
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (2, N'Музыкальная')
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (3, N'Образовательная')
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (4, N'Новостная')
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (5, N'Кулинарная')
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (6, N'Развлекательная')
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (7, N'Документальная')
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (8, N'Разговорная')
INSERT [dbo].[Category] ([ID_Category], [Title]) VALUES (9, N'Благотворительная')
GO
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (1, 1, N'Тщательное планирование маршрута')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (2, 2, N'Во время шоу, снимается каждый шаг: от выбора ингредиентов на рынке до процесса готовки в студии, обеспечивая живописные кадры приготовления блюд')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (3, 3, N'Анализируется материал, исследуются найденные фильмы и сериалы')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (4, 4, N'Команда профессионалов создает уникальную сценографию, планирует эффектные световые решения и работает над визуальными аспектами шоу.')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (5, 5, N'Команда разрабатывает тесты, планирует съемочный процесс')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (6, 6, N'Съемочная группа работает с инновационными устройствами')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (7, 7, N'Инструктор работает над разработкой программы занятий, аудиовизуального материала и экспертных комментариев')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (8, 8, N'Съемочная группа планирует кадры матча, работает с режиссером по созданию драматизма и динамики')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (9, 9, N'Команда звукорежиссеров создает идеальное звуковое сопровождение, световые спецэффекты')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (10, 10, N'Съёмочная группа снимает панорамные виды и детали замков')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (11, 11, N'Планирование визуальных материалов и аудиоподдержки, создание комфортной обстановки для лектора и зрителей')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (12, 12, N'Команда работает с телескопами и специальным оборудованием, создает впечатляющие визуальные эффекты и воспроизводит научные открытия')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (13, 13, N'Съемочная группа фиксирует процесс создания украшений, детали работы с материалами и инструментами')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (14, 14, N'Интервьюер работает над созданием доверительной атмосферы, проведением беседы и реакцией на ответы гостя')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (15, 15, N'Команда работает с учеными и экспертами, снимает уникальные видеоматериалы о поведении животных в природной среде')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (16, 16, N'Разработка концепции шоу, выбор жюри и участников')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (17, 17, N'Команда снимает интересные экспонаты')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (18, 18, N'Начинается с подготовки сценария и выбора комиков, организации зрительской аудитории, создания комичных сценариев и веселых моментов')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (19, 19, N'Консультации с инструкторами')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (20, 20, N'Производство воспроизводит условия выживания, планирует рабочие задания и процессы')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (21, 21, N'Разработка концепции выступления, подбор важных тем для обсуждения, работы с презентациями')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (22, 22, N'Анализ последних новостей и событий, исследование популярных фильмов и театральных постановок')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (23, 23, N'Команда танцоров и хореографов работает над созданием хореографии')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (24, 1, N'Выбор камер, оборудования и техники для съемки')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (25, 3, N'Составляется план обсуждений, репитируются диалоги')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (26, 5, N'Команда обеспечивает безопасность участников и создает драматические моменты для захватывающего контента')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (27, 6, N'Команда проводит интервью с изобретателями и специалистами в области технологий')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (28, 8, N'Съёмочная группа снимает реакции болельщиков')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (29, 9, N'Команда разрабатывает концепцию сцены и атмосферы выступления')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (30, 10, N'Команда работает над цветовой гаммой и музыкальным сопровождением')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (31, 11, N'Разрабатывается сценарий лекции')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (32, 14, N'Командой подготавливаются вопросы')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (33, 16, N'Создание тестовых блюд и эффектного презентация кулинарных шедевров')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (34, 18, N'Команда проводит интервью с куратором музея')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (35, 19, N'Съемки тренировок')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (36, 20, N'Команда снимает участников в экстремальных ситуациях')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (37, 22, N'Интервью с звездами и рецензии экспертов')
INSERT [dbo].[Creation_Stage] ([ID_Stage], [ID_Videomaterial], [Stage_description]) VALUES (38, 23, N'Практика танцевальных номеров и создани оригинальных постановок')
GO
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (1, 1, 1, CAST(N'00:00:00' AS Time), 1512, N'Мягкий', NULL, 7, 0, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (2, 1, 1, CAST(N'00:25:12' AS Time), 4788, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (3, 2, 2, CAST(N'00:00:00' AS Time), 5100, NULL, N'Ritmix RDM #1', NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (4, 3, 3, CAST(N'00:00:00' AS Time), 600, N'Затемнение', N'Fifine #3', 5, 2, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (5, 3, 3, CAST(N'00:10:00' AS Time), 1740, N'Скачок', N'Fifine #2', 1, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (6, 3, 3, CAST(N'00:39:00' AS Time), 600, NULL, N'Fifine #2', NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (7, 4, 4, CAST(N'00:00:00' AS Time), 420, N'Мягкий', NULL, 0, 2, N'test')
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (8, 5, 5, CAST(N'00:00:00' AS Time), 900, N'Затемнение', NULL, 10, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (9, 5, 5, CAST(N'00:10:00' AS Time), 2880, NULL, NULL, NULL, NULL, N'Подведение итогов')
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (10, 6, 6, CAST(N'00:00:00' AS Time), 600, N'Склейка встык', NULL, 2, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (11, 6, 6, CAST(N'00:10:00' AS Time), 1500, N'Мягкий', NULL, 5, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (12, 6, 6, CAST(N'00:35:00' AS Time), 1800, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (13, 7, 8, CAST(N'00:00:00' AS Time), 1200, N'Затемнение', NULL, 3, 1, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (14, 7, 8, CAST(N'00:20:00' AS Time), 2160, N'Затемнение', NULL, 5, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (15, 7, 8, CAST(N'00:56:00' AS Time), 1440, NULL, NULL, NULL, NULL, N'Реакция болельщиков')
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (17, 9, 1, CAST(N'00:00:00' AS Time), 360, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (18, 4, 4, CAST(N'00:06:00' AS Time), 180, N'Затемнение', N'FIFINE 1', 1, 0, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (19, 9, 22, CAST(N'00:06:00' AS Time), 180, N'Скачок', NULL, 0, 3, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (20, 4, 4, CAST(N'00:09:00' AS Time), 660, NULL, NULL, NULL, NULL, N'Проверка')
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (21, 4, 4, CAST(N'00:20:00' AS Time), 720, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (22, 4, 1, CAST(N'00:32:00' AS Time), 900, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (23, 4, 4, CAST(N'00:47:00' AS Time), 600, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (24, 5, 5, CAST(N'00:58:00' AS Time), 660, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (25, 6, 7, CAST(N'01:05:00' AS Time), 660, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (26, 12, 1, CAST(N'00:00:00' AS Time), 600, NULL, N'FIFE', NULL, NULL, N'test')
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (27, 11, 1, CAST(N'00:00:00' AS Time), 720, N'Затемнение', NULL, 3, 1, N'Test')
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (28, 11, 1, CAST(N'00:12:00' AS Time), 60, N'Мягкий', NULL, 5, 0, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (29, 12, 1, CAST(N'00:10:00' AS Time), 600, N'Мягкий', NULL, 3, 0, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (30, 11, 14, CAST(N'00:13:00' AS Time), 60, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Event] ([ID_Event], [ID_Broadcast], [ID_Videomaterial], [Start_time], [Playback_duration], [Transition_type], [Recording_source], [Transition_duration], [Delay_duration], [Event_description]) VALUES (31, 10, 20, CAST(N'00:00:00' AS Time), 360, N'Затемнение', NULL, 3, 1, NULL)
GO
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (1, 95, 144, N'Иванов И.П.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (2, 85, 60, N'Смирнова О.А.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (3, 49, 60, N'Попов Д.В.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (4, 58, 270, N'Кузнецова Е.С.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (5, 74, 144, N'Соколов М.И.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (6, 76, 144, N'Лебедева Т.Л.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (7, 80, 60, N'Новикова Л.М.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (9, 9, 60, N'Морозов В.Г.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (10, 6, 144, N'Сорокин И.А.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (11, 14, 144, N'Михайлов И.В.')
INSERT [dbo].[Video_Editing] ([ID_Editing], [Duration], [Framerate], [Author]) VALUES (12, 20, 60, N'Сорокин В.О.')
GO
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (1, N'Экскурсия по самым известным достопримечательностям', CAST(N'2024-02-03' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (2, N'Кулинарное шоу с известными шеф-поварами', CAST(N'2024-04-05' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (3, N'Разбор самых популярных фильмов и сериалов', CAST(N'2024-03-12' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (4, N'Концерт популярной рок-группы с фейерверками и спецэффектами', CAST(N'2024-02-21' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (5, N'Реалити-шоу, где участники проходят различные испытания.', CAST(N'2024-02-16' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (6, N'Программа о новейших технологических изобретениях', CAST(N'2024-04-25' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (7, N'Тренировочный видеокурс по йоге для начинающих', CAST(N'2024-04-13' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (8, N'Спортивный матч по футболу между двумя соперниками', CAST(N'2024-02-07' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (9, N'Музыкальное шоу с выступлениями талантливых певцов', CAST(N'2024-03-09' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (10, N'Живописное путешествие по древним замкам Европы', CAST(N'2024-03-22' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (11, N'Лекция известного психолога о секретах счастливой жизни', CAST(N'2024-03-15' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (12, N'Документальный фильм о космосе и звездах', CAST(N'2024-02-01' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (13, N'Творческий мастер-класс по изготовлению украшений', CAST(N'2024-02-24' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (14, N'Интервью с известным актером', CAST(N'2024-02-28' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (15, N'Познавательное шоу о мире животных и природе', CAST(N'2024-04-12' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (16, N'Кулинарная битва между известными поваренными школами', CAST(N'2024-04-11' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (17, N'Экскурсия в музей с древними артефактами и культурой', CAST(N'2024-02-18' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (18, N'Живое шоу с комиками', CAST(N'2024-05-17' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (19, N'Программа о фитнесе и здоровом образе жизни', CAST(N'2024-05-04' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (20, N'Реалити-шоу, в котором участники выживают на необитаемом острове', CAST(N'2024-05-01' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (21, N'Лекция ученого о будущем, науке', CAST(N'2024-05-14' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (22, N'Обзор новинок киноиндустрии и культурных событий', CAST(N'2024-02-14' AS Date))
INSERT [dbo].[Videomaterial] ([ID_Videomaterial], [Idea_description], [Upload_date]) VALUES (23, N'Танцевальное шоу с яркими номерами и хореографией', CAST(N'2024-05-08' AS Date))
GO
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (1, 1)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (1, 4)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (1, 9)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (1, 11)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (1, 12)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (2, 2)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (3, 3)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (5, 5)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (6, 6)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (7, 6)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (8, 7)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (14, 11)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (18, 12)
INSERT [dbo].[Videomaterial_Usage] ([ID_Videomaterial], [ID_Editing]) VALUES (20, 10)
GO
ALTER TABLE [dbo].[Event] ADD  DEFAULT ((600)) FOR [Playback_duration]
GO
ALTER TABLE [dbo].[Video_Editing] ADD  DEFAULT ((0)) FOR [Duration]
GO
ALTER TABLE [dbo].[Video_Editing] ADD  DEFAULT ((60)) FOR [Framerate]
GO
ALTER TABLE [dbo].[Broadcast]  WITH CHECK ADD FOREIGN KEY([ID_Category])
REFERENCES [dbo].[Category] ([ID_Category])
GO
ALTER TABLE [dbo].[Creation_Stage]  WITH CHECK ADD FOREIGN KEY([ID_Videomaterial])
REFERENCES [dbo].[Videomaterial] ([ID_Videomaterial])
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD FOREIGN KEY([ID_Broadcast])
REFERENCES [dbo].[Broadcast] ([ID_Broadcast])
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD FOREIGN KEY([ID_Videomaterial])
REFERENCES [dbo].[Videomaterial] ([ID_Videomaterial])
GO
ALTER TABLE [dbo].[Videomaterial_Usage]  WITH CHECK ADD FOREIGN KEY([ID_Editing])
REFERENCES [dbo].[Video_Editing] ([ID_Editing])
GO
ALTER TABLE [dbo].[Videomaterial_Usage]  WITH CHECK ADD FOREIGN KEY([ID_Videomaterial])
REFERENCES [dbo].[Videomaterial] ([ID_Videomaterial])
GO
ALTER TABLE [dbo].[Broadcast]  WITH NOCHECK ADD  CONSTRAINT [CK_Broadcast_date] CHECK  (([Playback_date]>=CONVERT([date],getdate())))
GO
ALTER TABLE [dbo].[Broadcast] CHECK CONSTRAINT [CK_Broadcast_date]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD CHECK  (([Delay_duration]<=(45)))
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD CHECK  (([Playback_duration]<=(86400)))
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD CHECK  (([Transition_duration]<=(45)))
GO
ALTER TABLE [dbo].[Video_Editing]  WITH CHECK ADD CHECK  (([Duration]<=(86400)))
GO
ALTER TABLE [dbo].[Video_Editing]  WITH CHECK ADD CHECK  (([Framerate]<=(360) AND [Framerate]>=(60)))
GO
ALTER TABLE [dbo].[Videomaterial]  WITH CHECK ADD CHECK  (([Upload_date]<=getdate()))
GO
/****** Object:  StoredProcedure [dbo].[AddBaseEvent]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddBaseEvent]
   @broadcastID INT, @videoTitle VARCHAR(300)
AS
BEGIN
	DECLARE @eventID INT
	SELECT @eventID = ID_Event FROM Event WHERE ID_Event=(SELECT max(ID_Event) FROM Event)
	SET @eventID = @eventID + 1

	DECLARE @editingID INT
	SELECT @editingID = ID_Editing FROM Video_Editing WHERE ID_Editing=(SELECT max(ID_Editing) FROM Video_Editing)
	SET @editingID = @editingID + 1

	DECLARE @videoID INT
	SELECT @videoID = ID_Videomaterial FROM Videomaterial WHERE Idea_description = @videoTitle

	INSERT INTO Event(ID_Event, ID_Broadcast, ID_Videomaterial, Start_time, Playback_duration)
	VALUES(@eventID, @broadcastID, @videoID, '00:00:00.0000000', 0)

	INSERT INTO Video_Editing VALUES(@editingID, 0, 60, '')

	INSERT INTO Videomaterial_Usage VALUES(@videoID, @editingID)
END
GO
/****** Object:  StoredProcedure [dbo].[AddNewBroadcast]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddNewBroadcast]
   @broadcast_id INT, @category VARCHAR(70), @channel VARCHAR(100) , @play_date DATE
AS
BEGIN
	DECLARE @categ_id INT
	SELECT @categ_id = ID_Category FROM Category WHERE Title = @category
	INSERT INTO Broadcast VALUES (@broadcast_id, @categ_id, @channel, @play_date)
END
GO
/****** Object:  StoredProcedure [dbo].[AddNewEvent]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddNewEvent]
   @broadcastID INT, @videoID INT, @startTime TIME(7), @duration INT, @transitionType VARCHAR(25), @transitionDuration INT, @transitionDelay INT,
   @description VARCHAR(125), @recSource VARCHAR(35), @eventID INT OUTPUT
AS
BEGIN
	SELECT @eventID = ID_Event FROM Event WHERE ID_Event=(SELECT max(ID_Event) FROM Event)
	SET @eventID = @eventID + 1

	INSERT INTO Event VALUES(@eventID, @broadcastID, @videoID, @startTime, @duration, @transitionType, @recSource, @transitionDuration, @transitionDelay, @description)

	DECLARE @editingID INT
	SELECT @editingID = @broadcastID

	IF NOT EXISTS (SELECT * FROM Videomaterial_Usage WHERE ID_Videomaterial = @videoID)
	BEGIN
		IF NOT EXISTS (SELECT * FROM Video_Editing WHERE ID_Editing = @editingID)
		BEGIN
			INSERT INTO Video_Editing VALUES(@editingID, @duration / 60, 60, '')
		END
		
		INSERT INTO Videomaterial_Usage VALUES(@videoID, @editingID)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[AddStage]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddStage]
  @stage_id INT, @video_id INT, @desc VARCHAR(300) 
AS
BEGIN
	INSERT INTO Creation_Stage VALUES (@stage_id, @video_id, @desc)
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeBroadcast]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChangeBroadcast]
  @broadcast_id INT, @category VARCHAR(40), @channel VARCHAR(55), @playDate DATETIME, @res VARCHAR(10) OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Broadcast WHERE ID_Broadcast = @broadcast_id)
	BEGIN
		SET @res = 'GOOD'

		UPDATE Broadcast
		SET ID_Category = (SELECT ID_Category FROM Category WHERE Title = @category),
		External_Channel = @channel, Playback_date = @playDate
		WHERE ID_Broadcast = @broadcast_id
	END
	ELSE
		SET @res = 'BAD'
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeEvent]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChangeEvent]
  @eventID INT, @startTime TIME(7), @duration INT, @transitionType VARCHAR(25), @transitionDuration INT, @transitionDelay INT,
  @description VARCHAR(125), @recSource VARCHAR(35), @videoID INT, @editingID INT OUTPUT
AS
BEGIN
	DECLARE @oldVideoID INT
	SELECT @oldVideoID = ID_Videomaterial FROM Event WHERE ID_Event = @eventID

	SELECT @editingID = ID_Broadcast FROM Event WHERE ID_Event = @eventID

	UPDATE Event
	SET Start_time = @startTime, Playback_duration = @duration, 
	Transition_type = @transitionType, Transition_duration = @transitionDuration, Delay_duration = @transitionDelay,
	Event_description = @description, Recording_source = @recSource, ID_Videomaterial = @videoID
	WHERE ID_Event = @eventID

	IF EXISTS (SELECT * FROM Videomaterial_Usage WHERE ID_Videomaterial = @oldVideoID AND ID_Editing = @editingID)
	BEGIN
		UPDATE Videomaterial_Usage
		SET ID_Videomaterial = @videoID
		WHERE ID_Editing = @editingID AND ID_Videomaterial = @oldVideoID
	END
	ELSE
		INSERT INTO Videomaterial_Usage VALUES(@oldVideoID, @editingID)
	-- если есть запись в videomaterial_usage с oldvideoid, то меняем на videoid, иначе добавляем запись с videoid и id_editing
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeUserPassword]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChangeUserPassword]
  @login VARCHAR(35), @newPassword VARCHAR(35), @res VARCHAR(10) OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Auth WHERE userLogin = @login)
	BEGIN
		SET @res = 'GOOD'
		UPDATE Auth
		SET userPassword = @newPassword
		WHERE userLogin = @login
	END
	ELSE
		SET @res = 'BAD'
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeUserRole]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChangeUserRole]
  @login VARCHAR(35), @newRole VARCHAR(35), @res VARCHAR(10) OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Auth WHERE userLogin = @login)
	BEGIN
		SET @res = 'GOOD'
		UPDATE Auth
		SET userPosition = @newRole
		WHERE userLogin = @login
	END
	ELSE
		SET @res = 'BAD'
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeVideomaterialProps]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChangeVideomaterialProps]
  @broadcastID INT, @newFramerate INT, @newAuthor VARCHAR(150)
AS
BEGIN
	UPDATE Video_Editing
	SET Framerate = @newFramerate, Author = @newAuthor
	WHERE ID_Editing = @broadcastID
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeVideomaterialTitle]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChangeVideomaterialTitle]
  @video_id INT, @newTitle VARCHAR(200), @res VARCHAR(10) OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Videomaterial WHERE ID_Videomaterial = @video_id)
	BEGIN
		SET @res = 'GOOD'

		UPDATE Videomaterial
		SET Idea_description = @newTitle
		WHERE ID_Videomaterial = @video_id
	END
	ELSE
		SET @res = 'BAD'
END
GO
/****** Object:  StoredProcedure [dbo].[GetBroadcastAndVideoIDByTitle]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetBroadcastAndVideoIDByTitle]
  @title VARCHAR(200), @video_id INT OUTPUT, @broadcast_id INT OUTPUT
AS
BEGIN
	SELECT @video_id = ID_Videomaterial FROM Videomaterial WHERE Idea_description = @title
	SELECT DISTINCT @broadcast_id = dbo.Broadcast.ID_Broadcast FROM dbo.Broadcast INNER JOIN dbo.Event ON dbo.Broadcast.ID_Broadcast = dbo.Event.ID_Broadcast INNER JOIN  
	dbo.Videomaterial ON dbo.Event.ID_Videomaterial = dbo.Videomaterial.ID_Videomaterial INNER JOIN 
	dbo.Category ON dbo.Broadcast.ID_Category = dbo.Category.ID_Category WHERE dbo.Videomaterial.ID_Videomaterial = @video_id
END
GO
/****** Object:  StoredProcedure [dbo].[GetEventInfo]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetEventInfo]
  @eventID INT, @startTime TIME(7) OUTPUT, @duration INT OUTPUT, @transitionType VARCHAR(25) OUTPUT, 
  @transitionDuration INT OUTPUT, @transitionDelay INT OUTPUT, @description VARCHAR(125) OUTPUT, @recSource VARCHAR(35) OUTPUT, @videoTitle VARCHAR(250) OUTPUT
AS
BEGIN
	SELECT @startTime = Start_time FROM Event WHERE ID_Event = @eventID
	SELECT @duration = Playback_duration FROM Event WHERE ID_Event = @eventID
	SELECT @transitionType = Transition_type FROM Event WHERE ID_Event = @eventID
	SELECT @transitionDuration = Transition_duration FROM Event WHERE ID_Event = @eventID
	SELECT @transitionDelay = Delay_duration FROM Event WHERE ID_Event = @eventID
	SELECT @description = Event_description FROM Event WHERE ID_Event = @eventID
	SELECT @recSource = Recording_source FROM Event WHERE ID_Event = @eventID
	SELECT @videoTitle = Idea_description FROM Videomaterial WHERE ID_Videomaterial = (SELECT ID_Videomaterial FROM Event WHERE ID_Event = @eventID)
END
GO
/****** Object:  StoredProcedure [dbo].[GetLastBroadcastId]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetLastBroadcastId]
   @last_id INT OUTPUT
AS
BEGIN
	SELECT @last_id = ID_Broadcast FROM Broadcast WHERE ID_Broadcast=(SELECT max(ID_Broadcast) FROM Broadcast)
END
GO
/****** Object:  StoredProcedure [dbo].[NewUser]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewUser]
	@login VARCHAR(35), @password VARCHAR(35), @role VARCHAR(25), @res VARCHAR(10) OUTPUT
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Auth WHERE userLogin = @login)
	BEGIN
		SET @res = 'GOOD'
		INSERT INTO Auth VALUES (@login, @password, @role)
	END
	ELSE
		SET @res = 'BAD'
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateVideoEditingSumDuration]    Script Date: 24.11.2024 19:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateVideoEditingSumDuration]
  @broadcastID INT, @eventID INT, @editingID INT
AS
BEGIN
	DECLARE @newSum INT
	SELECT @newSum = SUM(Playback_duration) / 60 FROM Event WHERE ID_Broadcast = @broadcastID

	DECLARE @videoID INT
	SELECT @videoID = ID_Videomaterial FROM Event WHERE ID_Event = @eventID

	IF EXISTS (SELECT * FROM Video_Editing WHERE ID_Editing = @editingID)
	BEGIN
		UPDATE Video_Editing
		SET Duration = @newSum
		WHERE ID_Editing = @editingID
	END
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Broadcast"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 137
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Category"
            Begin Extent = 
               Top = 173
               Left = 255
               Bottom = 269
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4305
         Alias = 2235
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 2610
         SortOrder = 2835
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BroadcastsPlaybackPlan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BroadcastsPlaybackPlan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Broadcast"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Category"
            Begin Extent = 
               Top = 26
               Left = 407
               Bottom = 122
               Right = 581
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Director_BroadcastsPlaybackPlan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Director_BroadcastsPlaybackPlan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Event"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'EventView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'EventView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Broadcast"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Category"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 136
               Right = 529
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Manager_BroadcastsPlaybackPlan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Manager_BroadcastsPlaybackPlan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "t2"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 216
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t1"
            Begin Extent = 
               Top = 6
               Left = 254
               Bottom = 119
               Right = 432
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 1905
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UnusedVideomaterials'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UnusedVideomaterials'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "t2"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 151
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t1"
            Begin Extent = 
               Top = 6
               Left = 254
               Bottom = 171
               Right = 527
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2535
         Alias = 2745
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UsedVideomaterials'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UsedVideomaterials'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Videomaterial"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 156
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Videomaterial_Usage"
            Begin Extent = 
               Top = 7
               Left = 254
               Bottom = 165
               Right = 432
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Video_Editing"
            Begin Extent = 
               Top = 85
               Left = 571
               Bottom = 215
               Right = 745
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VideoProps'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VideoProps'
GO
USE [master]
GO
ALTER DATABASE [БД Телестудии] SET  READ_WRITE 
GO
