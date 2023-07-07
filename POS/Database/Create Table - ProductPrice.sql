USE [pos_db]
GO

/****** Object:  Table [dbo].[ProductPrice]    Script Date: 7/7/2023 9:35:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductPrice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [varchar](20) NULL,
	[ProductName] [varchar](100) NULL,
	[OldOriginalPrice] [money] NULL,
	[OldFinalPrice] [money] NULL,
	[NewOriginalPrice] [money] NULL,
	[NewFinalPrice] [money] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [varchar](20) NULL,
 CONSTRAINT [PK_ProductPrice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


