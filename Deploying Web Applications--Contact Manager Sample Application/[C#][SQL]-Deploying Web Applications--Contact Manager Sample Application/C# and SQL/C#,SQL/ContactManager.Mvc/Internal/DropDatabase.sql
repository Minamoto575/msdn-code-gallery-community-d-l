USE [ContactManagerTarget]
GO
/****** Object:  ForeignKey [Contact_Address]    Script Date: 08/19/2011 09:21:32 ******/
ALTER TABLE [dbo].[Contacts] DROP CONSTRAINT [Contact_Address]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 08/19/2011 09:21:32 ******/
ALTER TABLE [dbo].[Contacts] DROP CONSTRAINT [Contact_Address]
GO
DROP TABLE [dbo].[Contacts]
GO
/****** Object:  Table [dbo].[EdmMetadata]    Script Date: 08/19/2011 09:21:32 ******/
DROP TABLE [dbo].[EdmMetadata]
GO
/****** Object:  Table [dbo].[States]    Script Date: 08/19/2011 09:21:32 ******/
DROP TABLE [dbo].[States]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 08/19/2011 09:21:32 ******/
DROP TABLE [dbo].[Addresses]
GO
