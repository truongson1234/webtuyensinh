USE [Webtuyensinh]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admissions]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admissions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[EducationLevel] [int] NOT NULL,
	[TypeOfTraining] [int] NOT NULL,
	[Desire] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Admissions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NOT NULL,
	[ParentID] [int] NULL,
	[Name] [nvarchar](250) NOT NULL,
	[URL] [nvarchar](500) NULL,
	[Controller] [nvarchar](250) NULL,
	[Action] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[DisplayCondition] [int] NOT NULL,
	[Target] [nvarchar](10) NULL,
	[Status] [bit] NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_MenuItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Avartar] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostTags]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostTags](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PostID] [int] NOT NULL,
	[TagID] [int] NOT NULL,
 CONSTRAINT [PK_PostTags] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Slug] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 8/10/2023 4:18:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Role] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230731043132_Init', N'7.0.9')
GO
SET IDENTITY_INSERT [dbo].[Admissions] ON 

INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (1, N'Nguyễn Văn A1', N'Hà Nội', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404498' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (2, N'Nguyễn Văn A2', N'Đà Nẵng', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404505' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (3, N'Nguyễn Văn A3', N'Hà Nội', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404510' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (4, N'Nguyễn Văn A4', N'HCM', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404515' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (5, N'Nguyễn Văn A5', N'HCM', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404519' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (6, N'Nguyễn Văn A6', N'HCM', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404524' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (7, N'Nguyễn Văn A7', N'Hà Nội', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404529' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (8, N'Nguyễn Văn A8', N'Hà Nội', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404533' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (9, N'Nguyễn Văn A9', N'Đà Nẵng', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404538' AS DateTime2), NULL)
INSERT [dbo].[Admissions] ([Id], [Name], [Address], [PhoneNumber], [EducationLevel], [TypeOfTraining], [Desire], [CreatedAt], [UpdatedAt]) VALUES (10, N'Nguyễn Văn A10', N'Hà Nội', N'0369109466', 5, 0, N'......', CAST(N'2023-07-31T11:31:32.5404543' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Admissions] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (1, N'Danh mục tin tức 1', N'......', CAST(N'2023-07-31T11:31:32.5404621' AS DateTime2), NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (2, N'Tuyển sinh', N'......', NULL, CAST(N'2023-08-10T10:30:27.5820477' AS DateTime2))
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (3, N'Danh mục tin tức 3', N'......', CAST(N'2023-07-31T11:31:32.5404631' AS DateTime2), NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (4, N'Danh mục tin tức 4', N'......', CAST(N'2023-07-31T11:31:32.5404635' AS DateTime2), NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (5, N'Danh mục tin tức 5', N'......', CAST(N'2023-07-31T11:31:32.5404638' AS DateTime2), NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (6, N'Danh mục tin tức 6', N'......', CAST(N'2023-07-31T11:31:32.5404642' AS DateTime2), NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (7, N'Danh mục tin tức 7', N'......', CAST(N'2023-07-31T11:31:32.5404646' AS DateTime2), NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (8, N'Danh mục tin tức 8', N'......', CAST(N'2023-07-31T11:31:32.5404650' AS DateTime2), NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (9, N'Danh mục tin tức 9', N'......', CAST(N'2023-07-31T11:31:32.5404654' AS DateTime2), NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [CreatedAt], [UpdatedAt]) VALUES (10, N'Danh mục tin tức 10', N'......', CAST(N'2023-07-31T11:31:32.5404657' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuItems] ON 

INSERT [dbo].[MenuItems] ([Id], [GroupID], [ParentID], [Name], [URL], [Controller], [Action], [DisplayOrder], [DisplayCondition], [Target], [Status], [CreatedAt], [UpdatedAt]) VALUES (6, 2, NULL, N'Du học Úc', N'/categories/1', NULL, NULL, 1, 0, NULL, NULL, CAST(N'2023-08-10T13:55:02.6696328' AS DateTime2), NULL)
INSERT [dbo].[MenuItems] ([Id], [GroupID], [ParentID], [Name], [URL], [Controller], [Action], [DisplayOrder], [DisplayCondition], [Target], [Status], [CreatedAt], [UpdatedAt]) VALUES (7, 2, NULL, N'Tuyển sinh', N'/categories/2', NULL, NULL, NULL, 0, NULL, NULL, CAST(N'2023-08-10T13:55:26.1335924' AS DateTime2), NULL)
INSERT [dbo].[MenuItems] ([Id], [GroupID], [ParentID], [Name], [URL], [Controller], [Action], [DisplayOrder], [DisplayCondition], [Target], [Status], [CreatedAt], [UpdatedAt]) VALUES (8, 2, NULL, N'Khóa học', N'/categories/3', NULL, NULL, NULL, 0, NULL, NULL, NULL, CAST(N'2023-08-10T13:56:06.3595704' AS DateTime2))
SET IDENTITY_INSERT [dbo].[MenuItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Name], [CreatedAt], [UpdatedAt]) VALUES (2, N'PostDetails', CAST(N'2023-08-10T13:52:49.1629395' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[Posts] ON 

INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (1, 2, N'Du học Đài Loan: Hệ vừa học vừa làm tại Đài Loan khởi động tuyển sinh khóa tháng 9/2022', N'news-avartar.jpg', N'Cộng đồng người Việt Nam ở Đài Loan ngày càng đông, theo đó là nhu cầu muốn con em họ sang Đài Loan học cũng tăng về số lượng. Nếu như trước đây, người Việt sang Đài Loan chủ yếu là đi theo diện hợp tác lao động thì nay nhiều bạn trẻ chọn lựa Đài Loan là nơi học tập, nâng cao trình độ, cũng là nơi có thể gửi gắm tương lai của bản thân.', N'<h2 style="font-weight: 500; line-height: 1.2; font-size: 1.25rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;">Ưu điểm của chương trình vừa học vừa làm tại Đài Loan</h2><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">– Điều kiện nhập học đơn giản, yêu cầu tiếng đầu vào không cao.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">– Học bổng và hỗ trợ từ 50% – 100% học phí cho năm đầu tiên.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">– Học sinh có thể tự chi trả học phí, sinh hoạt phí mà không phụ thuộc gia đình thông qua thu nhập từ việc làm thêm hàng tháng có trong chương trình.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">– Tích lũy kinh nghiệm làm việc tương đương với người đi làm từ 4 – 5 năm.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">– Sau khi ra trường, học sinh được bố trí công việc theo kinh nghiệm đã làm trong quá trình học mà không cần nộp hồ sơ xin việc.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">– Học sinh có nhiều cơ hội để tìm cho mình một công việc chính thức với mức lương trên&nbsp;2000 USD&nbsp;tại Đài Loan hoặc Việt Nam.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">– Sử dụng thông thạo tiếng Trung – ngôn ngữ được nhiều người sử dụng nhất trên thế giới.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">– Trong quá trình học tập, sau khi nhận thẻ cư trú ARC (sau 4 – 6 tuần sang Đài Loan) nhà trường cam kết sắp xếp công việc cho học sinh với mức lương cơ bản 25.000 NTD/tháng (tương đường 20 triệu VND). Vào thời gian nghỉ hè và nghỉ đông, học sinh có cơ hội tăng ca với mức lương cao hơn.</p><h2 style="font-weight: 500; line-height: 1.2; font-size: 1.25rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;">Điều kiện đăng ký chương trình</h2><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Học sinh phải có chứng chỉ TOCFL A1 (nếu chưa có sẽ được đào tạo)</li><li>Độ tuổi từ 18 – 28, tuổi càng trẻ càng có lợi thế hơn vì bạn có thể tốt nghiệp sớm hơn</li><li>Học vấn: Điểm trung bình học bạ THPT đạt từ 6.0 trở lên</li></ul><h2 style="font-weight: 500; line-height: 1.2; font-size: 1.25rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;">Ký túc xá và chi phí sinh hoạt tại Đài Loan</h2><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;">Ký túc xá (bắt buộc ở 4 năm)</h3><h2 style="font-weight: 500; line-height: 1.2; font-size: 1.25rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><p style="font-family: SF-Pro-Display-Regular; font-size: 16px;">Thông thường khi du học hệ vừa học vừa làm tại Đài Loan, các bạn sẽ được sắp xếp ở ký túc xá ngay trong khuôn viên trường để có thể tiết kiệm chi phí đi lại cũng như an ninh sẽ quản lý chặt chẽ. Có nhiều trường sẽ miễn phí ký túc xá cho học sinh 1 kỳ hoặc 1 năm. Nếu trường nào không miễn phí thì mức phí sẽ dao động từ 1 – 15 triệu VND/người/tháng.</p><p style="font-family: SF-Pro-Display-Regular; font-size: 16px;">Các ký túc xá cũng thường cấm sinh viên nấu ăn và uống bia rượu. Bạn có thể yêu cầu bố trí chung phòng với sinh viên Đài Loan nếu muốn. Một vấn đề đáng lưu ý nữa là “phân loại rác”, đặc biệt là ở ký túc xá nữ vì đây là một trong những tiêu chuẩn đánh giá trường học. Nhờ những quy định nghiêm ngặt nên các ký túc xá đảm bảo điều kiện sống tốt và an toàn.</p></h2><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;">Chi phí ăn uống và sinh hoạt</h3><h2 style="font-weight: 500; line-height: 1.2; font-size: 1.25rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><ul style="font-family: SF-Pro-Display-Regular; font-size: 16px;"><li>Suất ăn tại căn tin trường: 35.000 VND/suất</li><li>Tổng chi phí sinh hoạt và ăn uống khoảng 4 – 6 triệu VND/tháng</li></ul></h2><h2 style="font-weight: 500; line-height: 1.2; font-size: 1.25rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;">Việc làm thêm dành cho sinh viên</h2><h2 style="font-weight: 500; line-height: 1.2; font-size: 1.25rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><p style="font-family: SF-Pro-Display-Regular; font-size: 16px;">Với hệ vừa học vừa làm, trường sẽ chịu trách nhiệm tìm việc làm và giới thiệu nơi thực tập hưởng lương cho sinh viên của trường. Mỗi ngày sẽ làm 4 tiếng, theo quy định là 20 giờ/tuần. Sau khi nhập trường có thẻ sinh viên và giấy của trường sẽ giới thiệu công việc cho các bạn. Trung bình 1 tháng thu nhập khoảng 13 – 20 triệu VND tùy công việc và năng lực tiếng từng bạn.</p><p style="font-family: SF-Pro-Display-Regular; font-size: 16px;">Ngoài thời gian làm việc theo quy định, thời gian tự do sinh viên có thể kiếm thêm việc khác để tăng thêm thu nhập.</p></h2>', NULL, CAST(N'2023-08-10T16:05:33.7067270' AS DateTime2))
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (2, 2, N'Tổng hợp các chuyên ngành học bậc cử nhân – ĐH New South Wales', N'news-avartar.jpg', N'Là 1 trong 8 trường Đại học hàng đầu nước Úc ở ngay thành phố Sydney, ĐH New South Wales là nơi nâng tầm mọi ước mơ của bạn! Cho dù bạn đã đọc hàng trăm bài viết giới', N'<h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">I/ Đại học New South Wales Úc – TOP 8 trường hàng đầu tại xứ sở chuột túi</span></h3><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Bạn có biết Đại học New South Wales là một trong những sáng lập viên nhóm Group of Eight (G8) – nhóm các trường đại học nghiên cứu hàng đầu Úc và là một trong 3 trường duy nhất của Úc thuộc nhóm 21 trường đại học danh tiếng thế giới.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Thành lập năm 1949, UNSW là một trong những trường ĐH hàng đầu thế giới. UNSW luôn giữ vị trí Top về mức lương khởi điểm của sinh viên tốt nghiệp (Australian Graduate Survey). Nằm ở phía Đông Nam Sydney, thành phố được bầu chọn là đô thị sinh viên thứ 4 thế giới và đô thị sinh viên hàng đầu nước Úc (Đô thị Sinh viên Tốt nhất QS 2015). Tại đây, hệ thống giáo dục luôn được chú trọng nhằm phát triển song song cùng nền kinh tế. Vì vậy, các chương trình đào tạo đều được thiết kế dựa trên nhu cầu thực tế của xã hội và phù hợp với thế mạnh của bang.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Mới đây trường đã khai trương Trung tâm Đổi mới Michael Crouch, trụ sở mới cho sáng tạo ở UNSW, nơi sinh viên có thể phát triển ý tưởng trong không gian làm việc tiên tiến, gặp gỡ các nhà tiên phong với tầm nhìn xa trông rộng và liên hệ với các công ty đối tác để biến ý tưởng thành sản phẩm, công trình thương mại. Trường đứng thứ 27 thế giới về uy tín đối với nhà tuyển dụng (Xếp hạng QS 2020). Cộng đồng 250.000 cựu sinh viên đông đảo của trường ra làm việc tại những công ty lớn nhất và thịnh đạt nhất thế giới như Google, Penguin, Ernst &amp; Young, PayPal, Rio Tinto, HSBC, NASA và Oxfam.</p><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">II. Các thành tích đáng tự hào của&nbsp;trường đại học University of New South Wales UNSW</span></h3><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Đại học New South Wales nằm trong TOP 44 trường đại học hàng đầu thế giới (theo QS World University Rankings 2021) cũng như là một trong 4 trường đại học hàng đầu Úc</li><li>Top Trường đại học đầu tiên trên thế giới được xếp hạng AS Five Star Plus tối đa theo QS World University Rankings, 2019</li><li>Xếp hạng 1 Ở Sydney &amp; NSW vì Danh tiếng của Nhà tuyển dụng. (Xếp hạng khả năng tuyển dụng sau đại học của QS, năm 2020)</li><li>Xếp hạng 38 thế giới về danh tiếng và học thuật theo QS World University Rankings, 2020.</li><li>Xếp hạng 27 thế giới về khả năng tuyển sinh sau đại học. (theo Xếp hạng khả năng tuyển dụng sau đại học của QS, năm 2020)</li><li>23 trong số 50 môn học của trường được xếp hạng thế giới. Theo Xếp hạng Đại học Thế giới của QS theo chủ đề, năm 2020</li><li>77,9% Sinh viên được làm toàn thời gian bốn tháng sau khi tốt nghiệp, theo Good Universities Guide, 2019.</li><li>Xếp hạng 1 tại Úc về nghiên cứu (Báo cáo xuất sắc trong nghiên cứu ở Úc, 2018/19)</li><li>Trường có chương trình bằng kép (cử nhân và thạc sĩ) giúp tiết kiệm chi phí và thời gian học</li></ul><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">III. 8 ngành học nổi tiếng làm nên tên tuổi Đại học New South Wales</span></h3><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Đại học New South Wales sở hữu 900 chương trình đào tạo và được chia thành 9 khoa thành viên là: Khoa Văn và Khoa học Xã hội; Môi trường Xây dựng; Khoa Kinh doanh UNSW; Nghệ thuật và Thiết kế UNSW; Kỹ thuật; Luật; Y khoa; Khoa học và UNSW Canberra. Trường có 8 ngành học có xếp hạng cực cao trên thế giới và làm nên tên tuổi của New South Wales là:</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">1/ Kinh Doanh – Trường Kinh doanh UNSW</span>&nbsp;là một trong các trường đào tạo về kinh doanh hàng đầu của Úc với chương trình đào tạo MBA đứng số 1 Úc. Trường là đối tác về nghiên cứu của Tập đoàn tư vấn như Boston, Qantas, Deloitte và PwC.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;"><em>Xếp hạng Trường Kinh doanh UNSW năm 2021:</em></span></p><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Xếp thứ nhất ở Úc về Tài chính (theo Xếp hạng Toàn cầu của Thượng Hải về các môn học)</li><li>Hạng nhất ở Úc về Quản lý (theo Xếp hạng Toàn cầu của Thượng Hải về các môn học)</li><li>Đứng thứ 2 ở Úc và thứ 19 trên toàn thế giới về Kế toán và Tài chính (Theo QS rankings)</li><li>Đứng thứ 2 ở Úc và thứ 40 trên toàn thế giới về Nghiên cứu Kinh doanh và Quản lý (theo QS rankings)</li><li>Được xếp hạng trong Top 50 trên toàn thế giới về Kinh tế lượng và Kinh tế lượng, và trong Top 100 trên toàn thế giới về Khoa học Máy tính và Hệ thống Thông tin (theo QS rankings)</li></ul><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">2/ Cơ Khí – Khoa cơ khí UNSW</span>&nbsp;hoạt động mạnh mẽ ở cả cấp quốc gia và quốc tế là nơi đào tạo 22% kỹ sư có tầm ảnh hưởng nhất Australia. Khoa hiện nay đang đứng số 1 tại Úc, thứ 39 thế giới và cung cấp chương trình kỹ thuật đa dạng nhất</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">3/ Môi trường xây dựng – Khoa môi trường xây dựng UNSW (Top 23 tại Úc)</span>&nbsp;chú trọng đào tạo về thiết kế, thi công và quản lý đô thị bao gồm những chuyên ngành cụ thể: Khoa học kiến trúc, Tính toán kiến trúc, Quản lý thi công và Bất động sản, Thiết kế công nghiệp, Kiến trúc nội thất, Kiến trúc và Quy hoạch cảnh quan.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">4/ Luật – Trường luật UNSW</span>&nbsp;đứng thứ 14 trên thế giới và đi đầu Úc về giáo dục và nghiên cứu pháp lý. Sinh viên tốt nghiệp Trường luật UNSW có mức lương khởi điểm cao nhất bang New South Wales</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">5/ Y học – Khoa y học UNSW</span>&nbsp;là một trong 30 Khoa Y hàng đầu thế giới. với chất lượng giáo dục hàng đầu Khoa Y đang biến các sinh viên thành các chuyên gia y tế tận tụy với trình độ được thế giới công nhận.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">6/ Khoa học – Khoa khoa học</span>&nbsp;có 9 thuộc 100 ngành hàng đầu (Theo xếp hạng Đại học thế giới QS 2014). Trung tâm của trường gồm có: Trung tâm phân tích UNSW, các trạm nghiên cứu thực địa ở Cowan, Hồ Smiths và Fowlers Gap. Ngoài ra khoa còn là đối tác của Viện khoa học biển Sydney.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">7/ Nghệ thuật và Thiết kế – Khoa nghệ thuật và thiết kế UNSW</span>&nbsp;được xếp hàng đầu tại Úc. Với những chuyên ngành đạt tiêu chuẩn cao của thế giới như Lý luận nghệ thuật, Phê bình và Điện ảnh, Truyền hình và Phương tiện số, Nghệ thuật và Kỹ xảo hình ảnh.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">8/ Văn khoa và Khoa học xã hội – Trường văn khoa và khoa học xã hội UNSW</span>&nbsp;là một cộng đồng sôi nổi với các học giả táo bạo và sinh viên khám phá những tư tưởng lớn. Cán bộ giảng dạy đều là chuyên gia đầu ngành, kiến tạo tri thức mới và dạng thức hiểu biết mới. Trường kết hợp các truyền thống học thuật đã được kiểm nghiệm qua thời gian với các phương thức tư duy mới, tiên tiến, và áp dụng kiến thức đó vào giải quyết các thách thức của thế giới đương đại.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Đối với sinh viên chưa đạt yêu cầu nhập học UNSW cung cấp Chương trình Tiếng Anh và Dự bị đại học với nhiều cấp độ và thời gian giảng dạy linh hoạt.</p><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">IV/ Điều kiện đầu vào của Đại học New South Wales</span></h3><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Là trường thuộc TOP thế giới và TOP của Úc nên chương trình học tương đối nặng, phù hợp với những sinh viên có thành tích học tập tốt và cố gắng trong học tập và rèn luyện. Vậy trường có những yêu cầu đầu vào nào dành cho sinh viên quốc tế?</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Đối với du học sinh Việt Nam nên theo học các chương trình dự bị để có thể dễ dàng thích nghi hơn với chương trình đại học tại trường.</p><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Tiếng Anh: tùy trình độ đầu vào xét lớp phù hợp;</li><li>Dự bị đại học: GPA (lớp 11, 12): 6.0-8.0 (tùy ngành), IELTS 5.0-6.0 (tùy ngành);</li><li>Cao đẳng: GPA 8.0, IELTS: 6 (kĩ năng viết 6.0, không kĩ năng nào dưới 5.5);</li><li>Đại học: tốt nghiệp THPT với GPA lớp 12 trên 8.5 (thuộc nhóm 12 trường được công nhận tuyển thẳng), hoặc hoàn tất năm nhất Đại học hoặc tốt nghiệp chương trình Cao đẳng tại trường được công nhận; hoặc IELTS 6.5-7.0 (tùy ngành);</li><li>Thạc sỹ: tốt nghiệp Đại học, IELTS 6.5-7.0 (tùy ngành);</li><li>Tiến sỹ: Tốt nghiệp Đại học bằng danh dự, hoặc hoàn thành Thạc sỹ nghiên cứu của UNSW, IELTS 6.5-7.0 (tùy ngành).</li></ul><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Xem chi tiết về yêu cầu đầu vào cho từng chương trình học&nbsp;<a href="http://www.international.unsw.edu.au/entry-requirements" style="color: var(--bs-link-color); transition: all 0.3s ease 0s;">tại đây</a></p><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">V/ Kỳ nhập học:</span></h3><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Tiếng Anh: khai giảng hàng tháng;</li><li>Dự bị đại học: tháng 2, 3, 4, 6, 7, 9, 10, 11;</li><li>Cao đẳng: tháng 1, 8;</li><li>Đại học: tháng 2, 6, 9;</li><li>Sau đại học: tháng 2, 6, 7, 9.</li></ul><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">VI/ Hồ sơ xin học:</span></h3><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">Chung:</span></p><ol style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Bằng của cấp học cao nhất;</li><li>Học bạ của 2 năm gần nhất</li><li>Chứng chỉ tiếng Anh- nếu có;</li><li>Hộ chiếu (trang có ảnh và chữ kí)- nếu có;</li><li>Thành tích học tập- phấn đấu khác- nếu nhắm học bổng</li></ol><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">Sinh viên đăng ký học khóa Thạc sĩ cần nộp thêm:</span></p><ol style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>CV;</li><li>02 Thư giới thiệu;</li></ol><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">VII/ Học phí:</span></h3><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Học phí 2022:</p><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Tiếng Anh: $2,300-11,300 AUD;</li><li>Dự bị đại học: $22,800-45,800 AUD;</li><li>Đại học: $785-1,620 AUD/tín chỉ, trung bình 48 tín chỉ/năm;</li><li>Sau đại học: $775-1,035 AUD/tín chỉ, trung bình 48 tín chỉ/năm.</li></ul><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Cập nhật chi tiết về học phí dành cho sinh viên quốc tế&nbsp;<a href="https://www.student.unsw.edu.au/fees/international" style="color: var(--bs-link-color); transition: all 0.3s ease 0s;">tại đây</a></p><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">VIII/ Học bổng:</span></h3><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;">Cũng giống như những trường đại học nổi tiếng khác, New South Wales cũng dành rất nhiều chương trình học bổng dành cho sinh viên có thành tích học tập xuất sắc.</p><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li><span style="font-weight: 700 !important;">Học bổng&nbsp;20.000 AUD/ năm- 100% học phí&nbsp;toàn bộ khóa học</span>– International Scientia Coursework Scholarship: áp dụng cho các chương trình Cử nhân hoặc Thạc sỹ tín chỉ (trừ chương trình Sau đại học Online và tại UNSW cơ sở Canberra). Học bổng được xét dựa trên thành tích học tập, khả năng lãnh đạo, hoạt động ngoại khóa, lí do chọn học UNSW;</li><li><span style="font-weight: 700 !important;">Học bổng&nbsp;5.000- 10.000 AUD&nbsp;cho 1 năm học</span>– Australia’s Global University Award: áp dụng cho các chương trình Cử nhân hoặc Thạc sỹ tín chỉ (trừ chương trình Sau đại học Online và tại UNSW cơ sở Canberra). Học bổng được xét dựa trên thành tích học tập, không yêu cầu hồ sơ xin học bổng;</li><li><span style="font-weight: 700 !important;">Học bổng&nbsp;5.000- 10.000 AUD&nbsp;cho 1 năm học-&nbsp;</span>UNSW Global Academic Award: dành cho sinh viên đã hoàn thành xong chương trình Dự bị Đại học tại UNSW Global và chuyển tiếp lên 1 chương trình Cử nhân bất kỳ (trừ chương trình tại UNSW Canberra);</li><li><span style="font-weight: 700 !important;">Học bổng&nbsp;5.000 AUD/ năm, cho toàn khóa học</span>– UNSW Arts, Architecture &amp; Design Global Academic Scholarship: dành cho sinh viên đã hoàn thành xong chương trình Dự bị Đại học tại UNSW Global và chuyển tiếp lên 1 chương trình Cử nhân Khoa Arts, Architecture &amp; Design;</li><li><span style="font-weight: 700 !important;">Học bổng&nbsp;5.000 AUD/ năm, cho toàn khóa học</span>– UNSW Arts, Architecture &amp; Design International Articulation Scholarship: dành cho sinh viên đã hoàn thành xong chương trình Liên thông lên Đại học tại 1 tổ chức đối tác và chuyển tiếp lên chương trình Cử nhân Khoa Arts, Architecture &amp; Design;</li><li><span style="font-weight: 700 !important;">Học bổng 15.000 AUD cho 1 năm học</span>– UNSW Business School International Pathway Award: dành cho sinh viên đã hoàn thành xong chương trình Cử nhân/Thạc sĩ tại 1 tổ chức đối tác hoặc chương trình Dự bị Đại học tại UNSW Global và chuyển tiếp lên chương trình Cử nhân/ Thạc sĩ tín chỉ Khoa Kinh doanh;</li><li><span style="font-weight: 700 !important;">Học bổng&nbsp;5.000 AUD/ năm, cho toàn khóa học</span>– UNSW Business School International Scholarship: dành cho sinh viên đăng ký chương trình Cử nhân/ Thạc sĩ tín chỉ Khoa Kinh doanh;</li><li><span style="font-weight: 700 !important;">Học bổng 10.000 AUD cho 1 năm học</span>– UNSW Law &amp; Justice International&nbsp;Award: dành cho sinh viên đăng ký chương trình Cử nhân/ Thạc sĩ tín chỉ Luật (chương trình&nbsp;LLB, JD or LLM);</li><li><span style="font-weight: 700 !important;">Học bổng&nbsp;5.000- 7.500 AUD</span>: áp dụng cho chương trình Dự bị Đại học &amp; Cao đẳng tại UNSW Global;</li><li><span style="font-weight: 700 !important;">Học bổng 10.000 AUD mỗi năm</span>– Dr Vincent Lo Asia Undergraduate Scholarships: áp dụng cho toàn bộ thời gian học của chương trình cử nhân (lên đến 5 năm).</li></ul>', NULL, CAST(N'2023-08-10T11:11:38.6000765' AS DateTime2))
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (3, 3, N'Bài viết 3', N'news-avartar.jpg', N'......', N'<p>Đây là nội dung bài viết</p>', CAST(N'2023-07-31T11:31:32.5404736' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (4, 3, N'Bài viết 4', N'news-avartar.jpg', N'......', N'<p>Đây là nội dung bài viết</p>', CAST(N'2023-07-31T11:31:32.5404741' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (5, 5, N'Bài viết 5', N'news-avartar.jpg', N'......', N'<p>Đây là nội dung bài viết</p>', CAST(N'2023-07-31T11:31:32.5404745' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (6, 5, N'Bài viết 6', N'news-avartar.jpg', N'......', N'<p>Đây là nội dung bài viết</p>', CAST(N'2023-07-31T11:31:32.5404749' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (7, 9, N'Bài viết 7', N'news-avartar.jpg', N'......', N'<p>Đây là nội dung bài viết</p>', CAST(N'2023-07-31T11:31:32.5404754' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (8, 8, N'Bài viết 8', N'news-avartar.jpg', N'......', N'<p>Đây là nội dung bài viết</p>', CAST(N'2023-07-31T11:31:32.5404759' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (9, 10, N'Bài viết 9', N'news-avartar.jpg', N'......', N'<p>Đây là nội dung bài viết</p>', CAST(N'2023-07-31T11:31:32.5404763' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (10, 1, N'Bài viết 10', N'news-avartar.jpg', N'......', N'<p>Đây là nội dung bài viết</p>', CAST(N'2023-07-31T11:31:32.5404767' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (11, 3, N'Chào các bạn', N'z4534623375513_31f986aef6789f13b600e7fcd3bcc09c.jpg', N'hehe', N'....', CAST(N'2023-08-01T10:54:46.1876744' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (12, 2, N'Tuyển sinh du học cao đẳng nghề, vừa học vừa làm tại Úc, lên đường ngay', N'108904125_p0_master1200.png', N'Công ty Tư vấn Du học VIP thông báo chương trình tuyển sinh, hỗ trợ học sinh Việt Nam du học cao đẳng nghề, vừa học vừa làm tại Úc như sau: 1/ Đối tượng tuyển sinh Yêu', N'<h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">1/ Đối tượng tuyển sinh</span></h3><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">Yêu cầu</span>: Có mục đích du học nghiêm túc, sức khỏe tốt, tài chính tốt,</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">Yêu cầu tiếng Anh</span>: có trình độ ielts tối thiểu 5.5 -6.0 trở lên &amp; đã tốt nghiệp đại học.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">Giới hạn độ tuổi:&nbsp;</span>Học sinh từ 21 – 30 tuổi.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">Thời gian học:&nbsp;</span>2 năm. Khai giảng liên tục nhiều lần/năm.</p><p style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular; font-size: 16px;"><span style="font-weight: 700 !important;">Địa điểm học tập:&nbsp;</span>Tại thành phố lớn của Úc: Sydney, Melbourne, Brisbane, Adelaide,</p><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">2/ Khi du học chương trình Thạc sĩ vừa học vừa làm tại Úc, bạn được gì?</span></h3><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Học tập kiến thức và kỹ năng mới đúng với chuyên ngành mà bạn chọn. Các ngành học phổ biến có: Quản trị nhà hàng khách sạn và du lịch, Quản trị marketing, Tài chính ứng dụng, Kế toán, Định và, đầu tư và quản lý Bất động sản, Công nghệ thông tin, An ninh mạng, Khởi nghiệp, Phân tích kinh doanh, Tài chính và Đầu tư, Quản lý nhân sự, Kỹ thuật thông tin và truyền thông, Đối mới và Khởi nghiệp, Kinh doanh bền vững, Cung ứng hậu cần/Logistics, Quản trị kinh doanh, Kinh doanh quốc tế…</li><li>Bạn sẽ trải nghiệm cuộc sống tại Úc – một trong những quốc gia đáng sống nhất trên thế giới</li><li>Bạn có thể vừa học vừa đi làm thêm để tự trang trải tiền ăn ở.</li><li>Một số ngành học có sắp xếp thực tập chuyên nghiệp trong quá trình học.</li><li>Bạn có thể xin visa làm việc tại Úc 3 năm trở lên sau khi tốt nghiệp thạc sĩ nếu bạn học tại Úc với tổng thời gian tối thiểu từ 2 năm trở lên.</li><li>Bạn có thể xin việc làm chuyên nghiệp tại Úc với mức lương tối thiểu từ 60.000 AUD/năm trở lên sau khi tốt nghiệp thạc sĩ.</li></ul><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">3/ Học phí ước tính năm 2023 – 2024 như sau:</span></h3><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Học phí rất phải chăng, chỉ từ 20.000 – 30.000 AUD/năm học. Thời gian học 1, 1.5, 2 năm tùy vào ngành bạn đăng ký học.</li><li>Bảo hiểm y tế cho sinh viên quốc tế tại Úc: khoảng 800 – 1.000 AUD/năm/1 học sinh.</li><li>Tiền ăn ở, ước tính: từ 16.000 – 20.000 AUD/năm tùy khu vực bạn ở và cách bạn chi tiêu.</li></ul><h3 style="font-weight: 500; line-height: 1.2; font-size: 1.125rem; font-family: &quot;Open Sans&quot;, -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; color: rgb(33, 37, 41); letter-spacing: normal;"><span style="font-weight: 700 !important;">4/ Hồ sơ đăng ký du học bao gồm:</span></h3><ul style="color: rgb(33, 37, 41); font-family: SF-Pro-Display-Regular;"><li>Hộ chiếu, còn hạn ít nhất 4 năm</li><li>Bằng và bảng điểm đại học</li><li>Nếu bạn đã tốt nghiệp đi làm thì cần nộp thêm CV.</li><li>Bạn có thể gửi hồ sơ scan màu qua email tới duhocvip@gmail.com để tư vấn miễn phí về chương trình du học thạc sĩ vừa học vừa làm tại Úc.</li></ul>', NULL, CAST(N'2023-08-10T16:14:27.4733973' AS DateTime2))
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (13, 2, N'aa', N'z4492835176819_db41f214e1a8ac52d0622dbd0fad6bb5.jpg', N'hehe', N'aa', CAST(N'2023-08-01T17:17:12.8570275' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (14, 2, N'aaaa', N'19577100_440190186361139_4891012437503064054_o.jpg', N'bb', N'aa', CAST(N'2023-08-02T08:23:17.2106808' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (15, 5, N'aa', N'z4492835176819_db41f214e1a8ac52d0622dbd0fad6bb5.jpg', N'hehe', N'aa', CAST(N'2023-08-02T09:25:58.5833797' AS DateTime2), NULL)
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (20, 4, N'ad', N'z4535343888355_840751af01d0d65e87c7e5389ae10270.jpg', N'dd', N'd', NULL, CAST(N'2023-08-03T10:44:28.9247579' AS DateTime2))
INSERT [dbo].[Posts] ([Id], [CategoryId], [Title], [Avartar], [Description], [Content], [CreatedAt], [UpdatedAt]) VALUES (21, 5, N'Các mốc thời gian năm học 2023 - 2024: Tựu trường sớm nhất trước khai giảng 1 tuần', N'Thiết kế chưa có tên (1).png', N'hehe', N'HHT - Khung kế hoạch năm học 2023 - 2024 cho tất cả các bậc mầm non, giáo dục phổ thông, giáo dục thường xuyên trên cả nước mới đây đã được Bộ GD&ĐT công bố. Lễ khai giảng sẽ diễn ra vào ngày 5/9/2023.
Bộ GD&ĐT ban hành khung kế hoạch thời gian năm học 2023-2024 đối với giáo dục mầm non, giáo dục phổ thông và giáo dục thường xuyên áp dụng trong toàn quốc như sau:

1. Tựu trường sớm nhất trước 1 tuần so với ngày tổ chức khai giảng. Riêng đối với lớp 1, tựu trường sớm nhất trước 2 tuần so với ngày tổ chức khai giảng.

2. Tổ chức khai giảng vào ngày 05 tháng 09 năm 2023.

3. Kết thúc học kỳ I trước ngày 15 tháng 01 năm 2024, hoàn thành kế hoạch giáo dục học kỳ II trước ngày 25 tháng 05 năm 2024 và kết thúc năm học trước ngày 31 tháng 05 năm 2024.', NULL, CAST(N'2023-08-03T11:06:13.4848004' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Posts] OFF
GO
SET IDENTITY_INSERT [dbo].[PostTags] ON 

INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (108, 20, 2)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (109, 20, 5)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (110, 20, 63)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (122, 21, 5)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (123, 21, 63)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (124, 21, 1)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (142, 2, 5)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (143, 2, 2)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (145, 1, 5)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (146, 1, 1)
INSERT [dbo].[PostTags] ([ID], [PostID], [TagID]) VALUES (147, 12, 5)
SET IDENTITY_INSERT [dbo].[PostTags] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name], [Slug], [CreatedAt], [UpdatedAt]) VALUES (1, N'tuyển sinh', NULL, NULL, NULL)
INSERT [dbo].[Tags] ([Id], [Name], [Slug], [CreatedAt], [UpdatedAt]) VALUES (2, N'khóa học', NULL, NULL, NULL)
INSERT [dbo].[Tags] ([Id], [Name], [Slug], [CreatedAt], [UpdatedAt]) VALUES (3, N'bằng cấp', NULL, NULL, NULL)
INSERT [dbo].[Tags] ([Id], [Name], [Slug], [CreatedAt], [UpdatedAt]) VALUES (4, N'chuyên nghành', NULL, NULL, NULL)
INSERT [dbo].[Tags] ([Id], [Name], [Slug], [CreatedAt], [UpdatedAt]) VALUES (5, N'du học', NULL, NULL, NULL)
INSERT [dbo].[Tags] ([Id], [Name], [Slug], [CreatedAt], [UpdatedAt]) VALUES (63, N'dd', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Email], [Phone], [Address], [UserName], [Password], [Role], [CreatedAt], [UpdatedAt]) VALUES (1, NULL, NULL, NULL, N'user11', N'123123', N'Admin', CAST(N'2023-07-31T11:31:32.5403869' AS DateTime2), NULL)
INSERT [dbo].[Users] ([Id], [Email], [Phone], [Address], [UserName], [Password], [Role], [CreatedAt], [UpdatedAt]) VALUES (2, NULL, NULL, NULL, N'user22', N'123123', N'User', CAST(N'2023-07-31T11:31:32.5403893' AS DateTime2), NULL)
INSERT [dbo].[Users] ([Id], [Email], [Phone], [Address], [UserName], [Password], [Role], [CreatedAt], [UpdatedAt]) VALUES (3, NULL, NULL, NULL, N'user33', N'123123', N'User', CAST(N'2023-07-31T11:31:32.5403896' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[MenuItems]  WITH CHECK ADD  CONSTRAINT [FK_MenuItems_Menus_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Menus] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MenuItems] CHECK CONSTRAINT [FK_MenuItems_Menus_GroupID]
GO
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_Posts_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_Posts_Categories_CategoryId]
GO
ALTER TABLE [dbo].[PostTags]  WITH CHECK ADD  CONSTRAINT [FK_PostTags_Posts_PostID] FOREIGN KEY([PostID])
REFERENCES [dbo].[Posts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PostTags] CHECK CONSTRAINT [FK_PostTags_Posts_PostID]
GO
ALTER TABLE [dbo].[PostTags]  WITH CHECK ADD  CONSTRAINT [FK_PostTags_Tags_TagID] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tags] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PostTags] CHECK CONSTRAINT [FK_PostTags_Tags_TagID]
GO
