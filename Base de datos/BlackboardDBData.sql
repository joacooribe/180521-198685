USE [master]
GO
/****** Object:  Database [BlackboardDB]    Script Date: 6/22/2017 9:07:07 PM ******/
CREATE DATABASE [BlackboardDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BlackboardDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BlackboardDB.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BlackboardDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BlackboardDB_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BlackboardDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BlackboardDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BlackboardDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BlackboardDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BlackboardDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BlackboardDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BlackboardDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BlackboardDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BlackboardDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BlackboardDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BlackboardDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BlackboardDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BlackboardDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BlackboardDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BlackboardDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BlackboardDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BlackboardDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BlackboardDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BlackboardDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BlackboardDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BlackboardDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BlackboardDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BlackboardDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BlackboardDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BlackboardDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BlackboardDB] SET  MULTI_USER 
GO
ALTER DATABASE [BlackboardDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BlackboardDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BlackboardDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BlackboardDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BlackboardDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BlackboardDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Administrators]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrators](
	[OIDUser] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Administrators] PRIMARY KEY CLUSTERED 
(
	[OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Blackboards]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blackboards](
	[OIDBlackboard] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](max) NULL,
	[height] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[width] [int] NOT NULL,
	[teamOwner_OIDTeam] [int] NULL,
	[userCreator_OIDUser] [int] NULL,
 CONSTRAINT [PK_dbo.Blackboards] PRIMARY KEY CLUSTERED 
(
	[OIDBlackboard] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Colaborators]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colaborators](
	[OIDUser] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Colaborators] PRIMARY KEY CLUSTERED 
(
	[OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comments]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[OIDComment] [int] IDENTITY(1,1) NOT NULL,
	[creationDate] [datetime] NOT NULL,
	[resolvedDate] [datetime] NOT NULL,
	[commentResolved] [bit] NOT NULL,
	[description] [nvarchar](max) NULL,
	[elementOwner_id] [int] NULL,
	[userCreator_OIDUser] [int] NULL,
	[userSolver_OIDUser] [int] NULL,
 CONSTRAINT [PK_dbo.Comments] PRIMARY KEY CLUSTERED 
(
	[OIDComment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Elements]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[width] [int] NOT NULL,
	[height] [int] NOT NULL,
	[originPoint] [int] NOT NULL,
	[blackboardOwner_OIDBlackboard] [int] NULL,
	[creator_OIDUser] [int] NULL,
 CONSTRAINT [PK_dbo.Elements] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Images]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[id] [int] NOT NULL,
	[OIDImage] [int] NOT NULL,
	[format] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Images] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teams]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[OIDTeam] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[creationDate] [datetime] NOT NULL,
	[description] [nvarchar](max) NULL,
	[maxUsers] [int] NOT NULL,
	[creator_OIDUser] [int] NULL,
 CONSTRAINT [PK_dbo.Teams] PRIMARY KEY CLUSTERED 
(
	[OIDTeam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teams_And_Users]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams_And_Users](
	[User] [int] NOT NULL,
	[Team] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Teams_And_Users] PRIMARY KEY CLUSTERED 
(
	[User] ASC,
	[Team] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TextBoxes]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TextBoxes](
	[id] [int] NOT NULL,
	[OIDTextBox] [int] NOT NULL,
	[content] [nvarchar](max) NULL,
	[fontSize] [int] NOT NULL,
	[font] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.TextBoxes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/22/2017 9:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[OIDUser] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[surname] [nvarchar](max) NULL,
	[mail] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[birthday] [datetime] NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_OIDUser]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_OIDUser] ON [dbo].[Administrators]
(
	[OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_teamOwner_OIDTeam]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_teamOwner_OIDTeam] ON [dbo].[Blackboards]
(
	[teamOwner_OIDTeam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_userCreator_OIDUser]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_userCreator_OIDUser] ON [dbo].[Blackboards]
(
	[userCreator_OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OIDUser]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_OIDUser] ON [dbo].[Colaborators]
(
	[OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_elementOwner_id]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_elementOwner_id] ON [dbo].[Comments]
(
	[elementOwner_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_userCreator_OIDUser]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_userCreator_OIDUser] ON [dbo].[Comments]
(
	[userCreator_OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_userSolver_OIDUser]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_userSolver_OIDUser] ON [dbo].[Comments]
(
	[userSolver_OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_blackboardOwner_OIDBlackboard]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_blackboardOwner_OIDBlackboard] ON [dbo].[Elements]
(
	[blackboardOwner_OIDBlackboard] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_creator_OIDUser]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_creator_OIDUser] ON [dbo].[Elements]
(
	[creator_OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_id]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_id] ON [dbo].[Images]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_creator_OIDUser]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_creator_OIDUser] ON [dbo].[Teams]
(
	[creator_OIDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Team]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_Team] ON [dbo].[Teams_And_Users]
(
	[Team] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_User]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_User] ON [dbo].[Teams_And_Users]
(
	[User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_id]    Script Date: 6/22/2017 9:07:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_id] ON [dbo].[TextBoxes]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Administrators_dbo.Users_OIDUser] FOREIGN KEY([OIDUser])
REFERENCES [dbo].[Users] ([OIDUser])
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [FK_dbo.Administrators_dbo.Users_OIDUser]
GO
ALTER TABLE [dbo].[Blackboards]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Blackboards_dbo.Teams_teamOwner_OIDTeam] FOREIGN KEY([teamOwner_OIDTeam])
REFERENCES [dbo].[Teams] ([OIDTeam])
GO
ALTER TABLE [dbo].[Blackboards] CHECK CONSTRAINT [FK_dbo.Blackboards_dbo.Teams_teamOwner_OIDTeam]
GO
ALTER TABLE [dbo].[Blackboards]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Blackboards_dbo.Users_userCreator_OIDUser] FOREIGN KEY([userCreator_OIDUser])
REFERENCES [dbo].[Users] ([OIDUser])
GO
ALTER TABLE [dbo].[Blackboards] CHECK CONSTRAINT [FK_dbo.Blackboards_dbo.Users_userCreator_OIDUser]
GO
ALTER TABLE [dbo].[Colaborators]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Colaborators_dbo.Users_OIDUser] FOREIGN KEY([OIDUser])
REFERENCES [dbo].[Users] ([OIDUser])
GO
ALTER TABLE [dbo].[Colaborators] CHECK CONSTRAINT [FK_dbo.Colaborators_dbo.Users_OIDUser]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Comments_dbo.Elements_elementOwner_id] FOREIGN KEY([elementOwner_id])
REFERENCES [dbo].[Elements] ([id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_dbo.Comments_dbo.Elements_elementOwner_id]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Comments_dbo.Users_userCreator_OIDUser] FOREIGN KEY([userCreator_OIDUser])
REFERENCES [dbo].[Users] ([OIDUser])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_dbo.Comments_dbo.Users_userCreator_OIDUser]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Comments_dbo.Users_userSolver_OIDUser] FOREIGN KEY([userSolver_OIDUser])
REFERENCES [dbo].[Users] ([OIDUser])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_dbo.Comments_dbo.Users_userSolver_OIDUser]
GO
ALTER TABLE [dbo].[Elements]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Elements_dbo.Blackboards_blackboardOwner_OIDBlackboard] FOREIGN KEY([blackboardOwner_OIDBlackboard])
REFERENCES [dbo].[Blackboards] ([OIDBlackboard])
GO
ALTER TABLE [dbo].[Elements] CHECK CONSTRAINT [FK_dbo.Elements_dbo.Blackboards_blackboardOwner_OIDBlackboard]
GO
ALTER TABLE [dbo].[Elements]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Elements_dbo.Users_creator_OIDUser] FOREIGN KEY([creator_OIDUser])
REFERENCES [dbo].[Users] ([OIDUser])
GO
ALTER TABLE [dbo].[Elements] CHECK CONSTRAINT [FK_dbo.Elements_dbo.Users_creator_OIDUser]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Images_dbo.Elements_id] FOREIGN KEY([id])
REFERENCES [dbo].[Elements] ([id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_dbo.Images_dbo.Elements_id]
GO
ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Teams_dbo.Administrators_creator_OIDUser] FOREIGN KEY([creator_OIDUser])
REFERENCES [dbo].[Administrators] ([OIDUser])
GO
ALTER TABLE [dbo].[Teams] CHECK CONSTRAINT [FK_dbo.Teams_dbo.Administrators_creator_OIDUser]
GO
ALTER TABLE [dbo].[Teams_And_Users]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Teams_And_Users_dbo.Teams_Team] FOREIGN KEY([Team])
REFERENCES [dbo].[Teams] ([OIDTeam])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teams_And_Users] CHECK CONSTRAINT [FK_dbo.Teams_And_Users_dbo.Teams_Team]
GO
ALTER TABLE [dbo].[Teams_And_Users]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Teams_And_Users_dbo.Users_User] FOREIGN KEY([User])
REFERENCES [dbo].[Users] ([OIDUser])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teams_And_Users] CHECK CONSTRAINT [FK_dbo.Teams_And_Users_dbo.Users_User]
GO
ALTER TABLE [dbo].[TextBoxes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TextBoxes_dbo.Elements_id] FOREIGN KEY([id])
REFERENCES [dbo].[Elements] ([id])
GO
ALTER TABLE [dbo].[TextBoxes] CHECK CONSTRAINT [FK_dbo.TextBoxes_dbo.Elements_id]
GO
USE [master]
GO
ALTER DATABASE [BlackboardDB] SET  READ_WRITE 
GO
