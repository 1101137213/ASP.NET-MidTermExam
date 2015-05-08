
CREATE DATABASE [ASPNETMID]
GO

USE [ASPNETMID]
GO

CREATE TABLE [dbo].[Course](
	[Course ID]   [nvarchar](20) NOT NULL,
	[Course Name] [nvarchar](200) NOT NULL,
	[Course Description]  [nvarchar](1000) NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Course ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Course] ([Course ID], [Course Name], [Course Description]) VALUES (N'c1101137213'  , N'Calculus', 'hard');
INSERT [dbo].[Course] ([Course ID], [Course Name], [Course Description]) VALUES (N'c1101137214', N'Statistics', 'god..');
INSERT [dbo].[Course] ([Course ID], [Course Name], [Course Description]) VALUES (N'c1101137215'  , N'ASP.NET', 'Dameon');
GO
