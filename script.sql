USE [CompuTrabajo]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 18/11/2019 6:50:28 p. m. ******/
DROP TABLE [dbo].[employees]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 18/11/2019 6:50:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[CompanyId] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[DeletedOn] [datetime] NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Fax] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Lastlogin] [datetime] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[PortalId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[Telephone] [nvarchar](50) NOT NULL,
	[UpdatedOn] [datetime] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
