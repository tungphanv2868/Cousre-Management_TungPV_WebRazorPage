USE [CousreManagement]
GO
CREATE DATABASE [CousreManagement]
/****** Object:  Table [dbo].[Attendance]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[Id] [varchar](10) NOT NULL,
	[Student_Id] [varchar](10) NULL,
	[Section_Id] [varchar](10) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Subject_Id] [varchar](10) NULL,
	[Semeter_Id] [varchar](10) NULL,
	[Instructor_Id] [varchar](10) NULL,
	[Shedule] [date] NULL,
	[Room] [int] NULL,
	[Decription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollment]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollment](
	[Id] [varchar](10) NOT NULL,
	[Student_Id] [varchar](10) NULL,
	[Course_Id] [varchar](10) NULL,
	[Enrollment_Date] [date] NULL,
 CONSTRAINT [PK_Enrollment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[Id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Decription] [nvarchar](50) NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Major]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Major](
	[Id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Decription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Major] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Section](
	[Id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Course_Id] [varchar](10) NULL,
	[Instructor_Id] [varchar](10) NULL,
	[Attendance_Id] [varchar](10) NULL,
 CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semeter]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semeter](
	[Id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[Start_date] [date] NULL,
	[End_date] [date] NULL,
	[Major_Id] [varchar](10) NULL,
 CONSTRAINT [PK_Semeter] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [varchar](10) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Birthdate] [date] NULL,
	[Major_Id] [varchar](10) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 8/23/2023 6:33:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Major_Id] [varchar](10) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Attendance] ([Id], [Student_Id], [Section_Id], [Status]) VALUES (N'1', N'SE14000', N'S123', N'true')
INSERT [dbo].[Attendance] ([Id], [Student_Id], [Section_Id], [Status]) VALUES (N'2', N'SE15000', N'S123', N'true')
INSERT [dbo].[Attendance] ([Id], [Student_Id], [Section_Id], [Status]) VALUES (N'3', N'SE15111', N'S123', N'true')
GO
INSERT [dbo].[Course] ([Id], [Name], [Subject_Id], [Semeter_Id], [Instructor_Id], [Shedule], [Room], [Decription]) VALUES (N'A123', N'Javaa', N'SE123', N'123', N'I123', CAST(N'2023-07-01' AS Date), 1, N'Java Wed')
INSERT [dbo].[Course] ([Id], [Name], [Subject_Id], [Semeter_Id], [Instructor_Id], [Shedule], [Room], [Decription]) VALUES (N'B123', N'ReactJS', N'SE111', N'123', N'I123', CAST(N'2023-07-01' AS Date), 2, N'ReactJS')
GO
INSERT [dbo].[Enrollment] ([Id], [Student_Id], [Course_Id], [Enrollment_Date]) VALUES (N'E1', N'SE14000', N'A123', CAST(N'2023-07-01' AS Date))
INSERT [dbo].[Enrollment] ([Id], [Student_Id], [Course_Id], [Enrollment_Date]) VALUES (N'E2', N'SE15000', N'A123', CAST(N'2023-07-01' AS Date))
GO
INSERT [dbo].[Instructor] ([Id], [Name], [Decription]) VALUES (N'I111', N'Nam', N'BA')
INSERT [dbo].[Instructor] ([Id], [Name], [Decription]) VALUES (N'I123', N'ABC', N'software development')
GO
INSERT [dbo].[Major] ([Id], [Name], [Decription]) VALUES (N'BA1', N'business administrationnnn', N'business administration')
INSERT [dbo].[Major] ([Id], [Name], [Decription]) VALUES (N'SE1', N'software engineering', N'software engineering')
GO
INSERT [dbo].[Section] ([Id], [Name], [Course_Id], [Instructor_Id], [Attendance_Id]) VALUES (N'S111', N'SAA', N'B123', N'I123', N'2')
INSERT [dbo].[Section] ([Id], [Name], [Course_Id], [Instructor_Id], [Attendance_Id]) VALUES (N'S123', N'SAB', N'A123', N'I123', N'1')
GO
INSERT [dbo].[Semeter] ([Id], [Name], [Description], [Start_date], [End_date], [Major_Id]) VALUES (N'111', N'ae', N'Spring24', CAST(N'2023-01-01' AS Date), CAST(N'2023-03-30' AS Date), N'BA1')
INSERT [dbo].[Semeter] ([Id], [Name], [Description], [Start_date], [End_date], [Major_Id]) VALUES (N'123', N'Summer', N'Summer23', CAST(N'2023-07-01' AS Date), CAST(N'2023-09-01' AS Date), N'SE1')
GO
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Birthdate], [Major_Id]) VALUES (N'SE14000', N'Tung', N'Phan', CAST(N'2000-01-01' AS Date), N'SE1')
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Birthdate], [Major_Id]) VALUES (N'SE15000', N'Ha', N'Le', CAST(N'2000-02-02' AS Date), N'SE1')
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Birthdate], [Major_Id]) VALUES (N'SE15111', N'Uoc', N'Nguyen', CAST(N'2000-01-01' AS Date), N'SE1')
GO
INSERT [dbo].[Subject] ([Id], [Name], [Major_Id]) VALUES (N'SE111', N'FrontEnd', N'SE1')
INSERT [dbo].[Subject] ([Id], [Name], [Major_Id]) VALUES (N'SE123', N'JAVA', N'SE1')
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Section] FOREIGN KEY([Section_Id])
REFERENCES [dbo].[Section] ([Id])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Section]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Student] FOREIGN KEY([Student_Id])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Student]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Instructor] FOREIGN KEY([Instructor_Id])
REFERENCES [dbo].[Instructor] ([Id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Instructor]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Subject] FOREIGN KEY([Subject_Id])
REFERENCES [dbo].[Subject] ([Id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Subject]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Course] FOREIGN KEY([Course_Id])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Course]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Student] FOREIGN KEY([Student_Id])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Student]
GO
ALTER TABLE [dbo].[Section]  WITH CHECK ADD  CONSTRAINT [FK_Section_Course] FOREIGN KEY([Course_Id])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[Section] CHECK CONSTRAINT [FK_Section_Course]
GO
ALTER TABLE [dbo].[Section]  WITH CHECK ADD  CONSTRAINT [FK_Section_Instructor] FOREIGN KEY([Instructor_Id])
REFERENCES [dbo].[Instructor] ([Id])
GO
ALTER TABLE [dbo].[Section] CHECK CONSTRAINT [FK_Section_Instructor]
GO
ALTER TABLE [dbo].[Semeter]  WITH CHECK ADD  CONSTRAINT [FK_Semeter_Major] FOREIGN KEY([Major_Id])
REFERENCES [dbo].[Major] ([Id])
GO
ALTER TABLE [dbo].[Semeter] CHECK CONSTRAINT [FK_Semeter_Major]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Major] FOREIGN KEY([Major_Id])
REFERENCES [dbo].[Major] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Major]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Major] FOREIGN KEY([Major_Id])
REFERENCES [dbo].[Major] ([Id])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_Major]
GO
