USE [master]
GO

/****** Object:  Table [dbo].[BookDetails]    Script Date: 26-02-2022 20:13:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BookDetails](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [varchar](100) NULL,
	[Author] [varchar](50) NULL,
	[RegTimeStamp] [timestamp] NOT NULL,
	[Category] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_BookDetails] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


