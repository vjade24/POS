USE [pos_db]
GO

/****** Object:  Table [dbo].[ProductQuantity]    Script Date: 7/7/2023 9:35:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductQuantity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [varchar](20) NULL,
	[ProductName] [varchar](100) NULL,
	[OldQuantity] [int] NULL,
	[NewQuantity] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [varchar](20) NULL,
	[TotalQuantity] [int] NULL,
 CONSTRAINT [PK_ProductQuantity] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


