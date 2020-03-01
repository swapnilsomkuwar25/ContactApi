USE [Contact]
GO

/****** Object:  Table [dbo].[ContactDetails]    Script Date: 29-02-2020 23:30:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ContactDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](10) NOT NULL,
	[isactive] [bit] NOT NULL
) ON [PRIMARY]
GO

/****** Object:  Index [PK_contactdetails]    Script Date: 29-02-2020 23:30:55 ******/
ALTER TABLE [dbo].[ContactDetails] ADD  CONSTRAINT [PK_contactdetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO


