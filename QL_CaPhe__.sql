USE [QL_CaPhe]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[MaBan] [varchar](10) NOT NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaMon] [varchar](10) NOT NULL,
	[MaHD] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [varchar](10) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIACHI]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIACHI](
	[SoNha] [int] NOT NULL,
	[Duong] [nvarchar](20) NOT NULL,
	[Quan] [nvarchar](10) NULL,
	[ThanhPho] [nvarchar](50) NULL,
	[MaNV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoNha] ASC,
	[Duong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [varchar](10) NOT NULL,
	[NgayLapHD] [date] NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[MaBan] [varchar](10) NOT NULL,
	[GiamGia] [money] NULL,
	[ThanhTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [varchar](10) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiemTichLuy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIMON]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIMON](
	[Maloai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MON]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MON](
	[MaMon] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[Gia] [money] NULL,
	[TrangThai] [bit] NULL,
	[Maloai] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[MaHang] [varchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[NgayHetHan] [date] NULL,
	[SoLuongNhap] [int] NULL,
	[SoLuongXuat] [int] NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[DonGia] [float] NULL,
	[MaNV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[TenDangNhap] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[SdtNV] [varchar](12) NULL,
	[NgaySinh] [date] NULL,
	[MaCV] [varchar](10) NULL,
 CONSTRAINT [PK__NHANVIEN__2725D70A44110ABB] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUCO]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUCO](
	[MaBienBan] [varchar](10) NOT NULL,
	[TenBienBan] [nvarchar](50) NULL,
	[NgayLap] [date] NULL,
	[GiaiQuyet] [nvarchar](100) NULL,
	[ChiPhi] [money] NULL,
	[MaKH] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBienBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenDangNhap] [varchar](10) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
 CONSTRAINT [PK__TAIKHOAN__55F68FC170742E27] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B01', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B010', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B02', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B03', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B04', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B05', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B06', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B07', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B08', 0)
INSERT [dbo].[BAN] ([MaBan], [TrangThai]) VALUES (N'B09', 0)
GO
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN01', N'HD01', 2, 90000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN01', N'HD05', 2, 90000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN01', N'HD268793', 1, 45000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN01', N'HD558846', 1, 45000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN01', N'HD76719', 1, 45000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN01', N'HD87821', 1, 45000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN02', N'HD268793', 1, 20000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN02', N'HD466578', 1, 20000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN02', N'HD558846', 1, 20000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN02', N'HD87821', 3, 60000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN03', N'HD268793', 1, 20000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN03', N'HD466578', 1, 20000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'BN03', N'HD558846', 1, 20000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP01', N'HD01', 1, 15000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP01', N'HD03', 3, 45000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP01', N'HD04', 1, 15000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP01', N'HD05', 2, 30000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP02', N'HD01', 1, 15000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP02', N'HD05', 3, 45000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP03', N'HD268793', 2, 70000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP03', N'HD558846', 1, 35000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP03', N'HD76719', 1, 35000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'CP04', N'HD02', 2, 90000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'ST01', N'HD06', 1, 20000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaMon], [MaHD], [SoLuong], [ThanhTien]) VALUES (N'ST01', N'HD466578', 1, 20000.0000)
GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenChucVu]) VALUES (N'admin', N'Quyền cao nhất')
INSERT [dbo].[CHUCVU] ([MaCV], [TenChucVu]) VALUES (N'CVQL', N'Quản lý')
INSERT [dbo].[CHUCVU] ([MaCV], [TenChucVu]) VALUES (N'CVQLK', N'Quản lý kho')
INSERT [dbo].[CHUCVU] ([MaCV], [TenChucVu]) VALUES (N'CVTN', N'Thu ngân')
GO
INSERT [dbo].[DIACHI] ([SoNha], [Duong], [Quan], [ThanhPho], [MaNV]) VALUES (87, N'Trường Chinh', N'Tân Phú', N'TP.HCM', N'NV01')
GO
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD01', CAST(N'2022-07-28' AS Date), N'NV01', N'KH02', N'B01', 10000.0000, 110000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD02', CAST(N'2022-07-29' AS Date), N'NV01', N'KH06', N'B03', 20000.0000, 70000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD03', CAST(N'2022-07-29' AS Date), N'NV02', N'KH04', N'B05', 0.0000, 45000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD04', CAST(N'2022-07-30' AS Date), N'NV03', N'KH01', N'B02', 0.0000, 15000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD05', CAST(N'2022-07-30' AS Date), N'NV04', N'KH02', N'B01', 0.0000, 165000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD06', CAST(N'2022-07-30' AS Date), N'NV02', N'KH03', N'B04', 0.0000, 20000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD167135', CAST(N'2022-12-25' AS Date), NULL, N'KH01', N'B01', 23000.0000, 92000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD244813', CAST(N'2022-12-25' AS Date), NULL, N'KH01', N'B01', 17000.0000, 68000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD268793', CAST(N'2022-12-25' AS Date), NULL, N'KH01', N'B07', 31000.0000, 124000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD308476', CAST(N'2022-12-25' AS Date), NULL, N'KH01', N'B01', 31000.0000, 124000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD404947', CAST(N'2022-12-25' AS Date), NULL, NULL, N'B01', 0.0000, 85000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD41884', CAST(N'2022-12-25' AS Date), NULL, NULL, N'B01', 16000.0000, 64000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD466578', CAST(N'2022-12-25' AS Date), NULL, NULL, N'B01', 0.0000, 60000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD505819', CAST(N'2022-12-25' AS Date), NULL, NULL, N'B01', 0.0000, 85000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD513367', CAST(N'2022-12-25' AS Date), NULL, N'KH01', N'B01', 11000.0000, 44000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD558846', CAST(N'2022-12-25' AS Date), NULL, NULL, N'B01', 24000.0000, 96000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD633164', CAST(N'2022-12-25' AS Date), NULL, NULL, N'B01', 13000.0000, 52000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD692753', CAST(N'2022-12-25' AS Date), NULL, N'KH01', N'B01', 24000.0000, 96000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD74796', CAST(N'2022-12-25' AS Date), NULL, N'KH01', N'B01', 28000.0000, 67000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD76719', CAST(N'2022-12-25' AS Date), NULL, N'KH01', N'B01', 16000.0000, 64000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD87821', CAST(N'2022-12-25' AS Date), NULL, NULL, N'B01', 21000.0000, 84000.0000)
INSERT [dbo].[HOADON] ([MaHD], [NgayLapHD], [MaNV], [MaKH], [MaBan], [GiamGia], [ThanhTien]) VALUES (N'HD99192', CAST(N'2022-12-25' AS Date), NULL, NULL, N'B01', 34000.0000, 136000.0000)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [TenKH], [DiemTichLuy]) VALUES (N'KH01', N'0376547867', N'Nguyễn Văn Hùng', 2)
INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [TenKH], [DiemTichLuy]) VALUES (N'KH02', N'0387544523', N'Trần Thành Nam', 2)
INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [TenKH], [DiemTichLuy]) VALUES (N'KH03', N'0876556853', N'Hồ Ngọc Hà', 5)
INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [TenKH], [DiemTichLuy]) VALUES (N'KH04', N'0576347732', N'Cao An Dung', 6)
INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [TenKH], [DiemTichLuy]) VALUES (N'KH05', N'0396547643', N'Nguyễn Thị An', 8)
INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [TenKH], [DiemTichLuy]) VALUES (N'KH06', N'0326547832', N'Thúc Kim Ái', 9)
GO
INSERT [dbo].[LOAIMON] ([Maloai], [TenLoai]) VALUES (N'BN', N'Bánh ngọt')
INSERT [dbo].[LOAIMON] ([Maloai], [TenLoai]) VALUES (N'CP', N'Cà phê')
INSERT [dbo].[LOAIMON] ([Maloai], [TenLoai]) VALUES (N'ST', N'Sinh tố')
GO
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'BN01', N'Bánh vừng', 45000.0000, 1, N'BN')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'BN02', N'Bánh sandwich', 20000.0000, 1, N'BN')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'BN03', N'Bánh dưa hấu', 20000.0000, 1, N'BN')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'BN04', N'Bánh heo', 5000.0000, 1, N'BN')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'CP01', N'Cà phê sữa', 15000.0000, 0, N'CP')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'CP02', N'Cà phê đá', 15000.0000, 1, N'CP')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'CP03', N'Cà phê Mocha', 35000.0000, 1, N'CP')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'CP04', N'Caramel Macchiato', 45000.0000, 1, N'CP')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'CP05', N'Cà phê đen không kem', 20000.0000, 1, N'BN')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'ST01', N'Sinh tố cam', 20000.0000, 1, N'ST')
INSERT [dbo].[MON] ([MaMon], [TenMon], [Gia], [TrangThai], [Maloai]) VALUES (N'ST04', N'Sinh tố dâu', 20000.0000, 1, N'ST')
GO
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H01
', N'Bột cà phê Robusta', CAST(N'2022-07-28' AS Date), CAST(N'2025-03-20' AS Date), 30, 7, N'kg', 30000, N'NV01')
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H02', N'Đường', CAST(N'2022-07-29' AS Date), CAST(N'2025-09-10' AS Date), 10, 5, N'kg', 17000, N'NV04')
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H03', N'Bột cà phê Arabica ', CAST(N'2022-07-30' AS Date), CAST(N'2022-08-03' AS Date), 15, 2, N'kg', 15000, N'NV02')
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H04', N'Sữa đặc', CAST(N'2022-11-21' AS Date), CAST(N'2022-11-22' AS Date), 14, 10, N'lit', 25000, N'NV04')
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H05', N'Bột cacao', CAST(N'2022-07-08' AS Date), CAST(N'2025-05-08' AS Date), 20, 12, N'kg', 28000, N'NV04')
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H06', N'Sữa tươi không đường', CAST(N'2022-07-24' AS Date), CAST(N'2022-12-15' AS Date), 15, 10, N'ml', 40000, N'NV04')
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H07', N'Ly thủy tinh', CAST(N'2022-11-30' AS Date), CAST(N'2025-11-01' AS Date), 10, 0, N'ly', 50000, N'NV03')
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H08', N'Ly', CAST(N'2022-12-10' AS Date), CAST(N'2023-03-21' AS Date), 14, 0, N'chiếc', 40000, N'NV03')
INSERT [dbo].[NGUYENLIEU] ([MaHang], [TenHang], [NgayNhap], [NgayHetHan], [SoLuongNhap], [SoLuongXuat], [DonViTinh], [DonGia], [MaNV]) VALUES (N'H10', N'Bột sữa', CAST(N'2022-12-14' AS Date), CAST(N'2023-02-01' AS Date), 2, 0, N'Bịch', 100000, N'NV03')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenDangNhap], [HoTen], [GioiTinh], [SdtNV], [NgaySinh], [MaCV]) VALUES (N'NV01', N'dang0701', N'Trần Hải Đăng', N'Nam', N'0982345721', CAST(N'1999-09-28' AS Date), N'admin')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenDangNhap], [HoTen], [GioiTinh], [SdtNV], [NgaySinh], [MaCV]) VALUES (N'NV02', N'huong0908', N'Ngô Thị Hương', N'Nữ', N'0932378732', CAST(N'2001-04-02' AS Date), N'CVQL')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenDangNhap], [HoTen], [GioiTinh], [SdtNV], [NgaySinh], [MaCV]) VALUES (N'NV03', N'anh1202', N'Trần Tuấn Anh', N'Nam', N'0382345234', CAST(N'2000-06-15' AS Date), N'CVQLK')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenDangNhap], [HoTen], [GioiTinh], [SdtNV], [NgaySinh], [MaCV]) VALUES (N'NV04', N'tu2012', N'Nguyễn Ngọc Tú', N'Nữ', N'0823245767', CAST(N'1998-02-12' AS Date), N'CVTN')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenDangNhap], [HoTen], [GioiTinh], [SdtNV], [NgaySinh], [MaCV]) VALUES (N'NV08', N'hung012', N'Nguyễn Ngọc Hùng', N'Nữ', N'0923245799', CAST(N'1998-12-02' AS Date), N'CVTN')
GO
INSERT [dbo].[SUCO] ([MaBienBan], [TenBienBan], [NgayLap], [GiaiQuyet], [ChiPhi], [MaKH], [MaNV]) VALUES (N'SC01', N'Gãy bàn', CAST(N'2019-01-20' AS Date), N'2 bên mỗi bên đền 30% số tiền', 900000.0000, N'KH01', N'NV01')
INSERT [dbo].[SUCO] ([MaBienBan], [TenBienBan], [NgayLap], [GiaiQuyet], [ChiPhi], [MaKH], [MaNV]) VALUES (N'SC02', N'Bể bình hoa', CAST(N'2019-01-20' AS Date), N'2 bên mỗi bên đền 50% số tiền', 900000.0000, N'KH01', N'NV01')
INSERT [dbo].[SUCO] ([MaBienBan], [TenBienBan], [NgayLap], [GiaiQuyet], [ChiPhi], [MaKH], [MaNV]) VALUES (N'SC03', N'Hư máy lanh', CAST(N'2020-02-20' AS Date), N'Quán chịu chi phí', 1000000.0000, N'KH04', N'NV02')
INSERT [dbo].[SUCO] ([MaBienBan], [TenBienBan], [NgayLap], [GiaiQuyet], [ChiPhi], [MaKH], [MaNV]) VALUES (N'SC04', N'Gãy ghế', CAST(N'2009-06-23' AS Date), N'Khách đền tiền', 200000.0000, N'KH01', N'NV01')
INSERT [dbo].[SUCO] ([MaBienBan], [TenBienBan], [NgayLap], [GiaiQuyet], [ChiPhi], [MaKH], [MaNV]) VALUES (N'SC05', N'Vỡ ly nước', CAST(N'2020-12-07' AS Date), N'2 bên mỗi bên đền 50% số tiền', 100000.0000, N'KH02', N'NV01')
INSERT [dbo].[SUCO] ([MaBienBan], [TenBienBan], [NgayLap], [GiaiQuyet], [ChiPhi], [MaKH], [MaNV]) VALUES (N'SC06', N'Bể bình hoa', CAST(N'2020-12-15' AS Date), N'2 bên mỗi bên đền 50% số tiền', 100000.0000, N'KH01', N'NV03')
INSERT [dbo].[SUCO] ([MaBienBan], [TenBienBan], [NgayLap], [GiaiQuyet], [ChiPhi], [MaKH], [MaNV]) VALUES (N'SC07', N'Hư quạt', CAST(N'2022-12-11' AS Date), N'Quán chi trả', 140000.0000, N'KH01', N'NV03')
GO
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'admin', N'1')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'anh1202', N'1')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'dang0701', N'1')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'hung012', N'1')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'huong0908', N'1')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'them', N'1')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'them1', N'1')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'them2', N'1')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau]) VALUES (N'them3', N'1')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNI_SDT]    Script Date: 12/25/2022 5:07:30 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [UNI_SDT] UNIQUE NONCLUSTERED 
(
	[SdtNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NHANVIEN__FADCB97769DAB101]    Script Date: 12/25/2022 5:07:30 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [UQ__NHANVIEN__FADCB97769DAB101] UNIQUE NONCLUSTERED 
(
	[SdtNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [Default_GiamGia]  DEFAULT ((0)) FOR [GiamGia]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MON] ([MaMon])
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[DIACHI]  WITH CHECK ADD  CONSTRAINT [FK__DIACHI__MaNV__3E52440B] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[DIACHI] CHECK CONSTRAINT [FK__DIACHI__MaNV__3E52440B]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[BAN] ([MaBan])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__MaNV__412EB0B6] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__MaNV__412EB0B6]
GO
ALTER TABLE [dbo].[MON]  WITH CHECK ADD FOREIGN KEY([Maloai])
REFERENCES [dbo].[LOAIMON] ([Maloai])
GO
ALTER TABLE [dbo].[NGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [FK__NGUYENLIEU__MaNV__4CA06362] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NGUYENLIEU] CHECK CONSTRAINT [FK__NGUYENLIEU__MaNV__4CA06362]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK__NHANVIEN__MaCV__32E0915F] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK__NHANVIEN__MaCV__32E0915F]
GO
ALTER TABLE [dbo].[SUCO]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[SUCO]  WITH CHECK ADD  CONSTRAINT [FK__SUCO__MaNV__398D8EEE] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[SUCO] CHECK CONSTRAINT [FK__SUCO__MaNV__398D8EEE]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [CHK_SL] CHECK  (([SoLuong]>(0)))
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [CHK_SL]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [CHK_TT] CHECK  (([ThanhTien]>(0)))
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [CHK_TT]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [CHK_NgayLapHD] CHECK  (([NgayLapHD]<=getdate()))
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [CHK_NgayLapHD]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [CHECK_TichLuy] CHECK  (([DiemTichLuy]>=(1) AND [DiemTichLuy]<(10)))
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [CHECK_TichLuy]
GO
ALTER TABLE [dbo].[MON]  WITH CHECK ADD  CONSTRAINT [CHK_GIA] CHECK  (([GIA]>(0)))
GO
ALTER TABLE [dbo].[MON] CHECK CONSTRAINT [CHK_GIA]
GO
ALTER TABLE [dbo].[NGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [CHECK_GIA] CHECK  (([DonGia]>(0)))
GO
ALTER TABLE [dbo].[NGUYENLIEU] CHECK CONSTRAINT [CHECK_GIA]
GO
ALTER TABLE [dbo].[NGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [CHECK_NGAY] CHECK  (([NgayHetHan]>[NgayNhap]))
GO
ALTER TABLE [dbo].[NGUYENLIEU] CHECK CONSTRAINT [CHECK_NGAY]
GO
ALTER TABLE [dbo].[NGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [CHECK_SLNhap_SLXuat] CHECK  (([SoLuongNhap]>=[SoLuongXuat]))
GO
ALTER TABLE [dbo].[NGUYENLIEU] CHECK CONSTRAINT [CHECK_SLNhap_SLXuat]
GO
ALTER TABLE [dbo].[NGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [CHECK_SLXuat] CHECK  (([SoLuongXuat]>=(0)))
GO
ALTER TABLE [dbo].[NGUYENLIEU] CHECK CONSTRAINT [CHECK_SLXuat]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [CHK_PHAI] CHECK  (([GioiTinh]=N'Nam' OR [GioiTinh]=N'Nữ'))
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [CHK_PHAI]
GO
ALTER TABLE [dbo].[SUCO]  WITH CHECK ADD  CONSTRAINT [CHK_CHIPHI] CHECK  (([ChiPhi]>(0)))
GO
ALTER TABLE [dbo].[SUCO] CHECK CONSTRAINT [CHK_CHIPHI]
GO
ALTER TABLE [dbo].[SUCO]  WITH CHECK ADD  CONSTRAINT [CHK_NGAYLAPSUCO] CHECK  (([NGAYLAP]<=getdate()))
GO
ALTER TABLE [dbo].[SUCO] CHECK CONSTRAINT [CHK_NGAYLAPSUCO]
GO
/****** Object:  StoredProcedure [dbo].[ChiPhi]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiPhi]
AS
	SET NOCOUNT ON;
SELECT    COUNT(*) AS Expr1
FROM         SUCO
GO
/****** Object:  StoredProcedure [dbo].[ChiPhi_SuCo]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiPhi_SuCo]
AS
	SET NOCOUNT ON;
SELECT    SUM(ChiPhi) AS Expr1
FROM         SUCO
GO
/****** Object:  StoredProcedure [dbo].[ChiTiet_Ma]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiTiet_Ma]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT    MaBienBan, TenBienBan, NgayLap, GiaiQuyet, ChiPhi, MaKH, MaNV
FROM         SUCO
WHERE     (MaBienBan = @ma)
GO
/****** Object:  StoredProcedure [dbo].[ChiTietHD]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ChiTietHD] @ma varchar(10)
as
begin
	select hd.MAHD, ct.SOLUONG, hd.THANHTIEN as TONGTIEN, ct.THANHTIEN , m.TENMON,  GIAMGIA
	from HOADON hd, CHITIETHOADON ct, MON m
	where hd.MAHD = ct.MAHD and m.MAMON = ct.MAMON and hd.MAHD = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[DemSuCo]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DemSuCo]
AS
	SET NOCOUNT ON;
SELECT    COUNT(*) AS Expr1
FROM         SUCO
GO
/****** Object:  StoredProcedure [dbo].[doanhthutheokhoanthoigian_HD]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[doanhthutheokhoanthoigian_HD] @ngaybd datetime, @ngaykt datetime
as
begin
	SELECT MaHD, NgayLapHD, MaNV, MaKH, MaBan, GiamGia, ThanhTien FROM dbo.HOADON
	WHERE    NgayLapHD <= @ngaykt and @ngaybd <= NgayLapHD
end
GO
/****** Object:  StoredProcedure [dbo].[doanhthutheokhoanthoigian_NguyenLieu]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[doanhthutheokhoanthoigian_NguyenLieu] @ngaybd datetime, @ngaykt datetime
as
begin
	SELECT    MaHang, TenHang, NgayNhap, NgayHetHan, SoLuongXuat, SoLuongNhap, DonViTinh, DonGia, MaNV,DonGia * SoLuongNhap AS ThanhTien
	FROM         NGUYENLIEU
	WHERE    NgayNhap <= @ngaykt and @ngaybd <= NgayNhap
end
GO
/****** Object:  StoredProcedure [dbo].[doanhthutheokhoanthoigian_SUCO]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[doanhthutheokhoanthoigian_SUCO] @ngaybd datetime, @ngaykt datetime
as
begin
	select * from SUCO
	where NgayLap <= @ngaykt and @ngaybd <= NgayLap
end
GO
/****** Object:  StoredProcedure [dbo].[getCTHD]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getCTHD]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT MaMon, MaHD, SoLuong, ThanhTien
FROM     CHITIETHOADON
WHERE  (MaHD = @ma)
GO
/****** Object:  StoredProcedure [dbo].[HoaDonByNgay]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HoaDonByNgay]
(
	@ngayBD date,
	@ngayKT date
)
AS
	SET NOCOUNT ON;
SELECT MaHD, NgayLapHD, MaNV, MaKH, MaBan, GiamGia, ThanhTien
FROM     HOADON
WHERE  (NgayLapHD >= @ngayBD) AND (NgayLapHD <= @ngayKT)
GO
/****** Object:  StoredProcedure [dbo].[HoaDonByNhanVien]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HoaDonByNhanVien]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT MaHD, NgayLapHD, MaNV, MaKH, MaBan, GiamGia, ThanhTien
FROM     HOADON
WHERE  (MaNV = @ma)
GO
/****** Object:  StoredProcedure [dbo].[Kiemtra_KH_Sdt]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kiemtra_KH_Sdt]
(
	@sdt varchar(15)
)
AS
	SET NOCOUNT ON;
SELECT    COUNT(*) AS Expr1
FROM         KHACHHANG
WHERE     (SDT = @sdt)
GO
/****** Object:  StoredProcedure [dbo].[KiemtraKH_Sdt]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KiemtraKH_Sdt]
(
	@sdt varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT    COUNT(*) AS Expr1
FROM         KHACHHANG
WHERE     (MaKH = @sdt)
GO
/****** Object:  StoredProcedure [dbo].[KiemtraTaiKhoan]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KiemtraTaiKhoan]
(
	@tendn varchar(10),
	@mk varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT    COUNT(*) AS Expr1
FROM         TAIKHOAN
WHERE     (TenDangNhap = @tendn and MatKhau = @mk)
GO
/****** Object:  StoredProcedure [dbo].[KtraKhoa]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KtraKhoa]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT COUNT(*) FROM NGUYENLIEU
where maHang = @ma
GO
/****** Object:  StoredProcedure [dbo].[KHMoi]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHMoi]
AS
	SET NOCOUNT ON;
SELECT MaKH, SDT, TenKH, DiemTichLuy FROM dbo.KHACHHANG WHERE DIEMTICHLUY < 5
GO
/****** Object:  StoredProcedure [dbo].[KHThanThiet]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHThanThiet]
AS
	SET NOCOUNT ON;
SELECT MaKH, SDT, TenKH, DiemTichLuy
FROM     KHACHHANG
WHERE  (DiemTichLuy > 5)
GO
/****** Object:  StoredProcedure [dbo].[MaLoai_TrangThai_Mon]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaLoai_TrangThai_Mon]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT    MaMon, TenMon, Gia, TrangThai, Maloai
FROM         MON
WHERE     (Maloai = @ma) AND (TrangThai = 1)
GO
/****** Object:  StoredProcedure [dbo].[Phanquyen]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Phanquyen]
(
	@macv varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT    CASE WHEN TenChucVu LIKE N'Thu ngân' THEN 2 WHEN TenChucVu LIKE N'Quản lý kho' THEN 3 WHEN TenChucVu LIKE N'Quản lý' THEN 1 ELSE 0 END AS ketqua
FROM         NHANVIEN AS nv INNER JOIN
                      CHUCVU AS cv ON nv.MaCV = cv.MaCV
WHERE     (cv.MaCV = @macv)
GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery_ThanhTien_Ngay_HD]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery_ThanhTien_Ngay_HD]
(
	@Ngay int, @thang int , @nam int
)
AS
	SET NOCOUNT ON;
SELECT    SUM(ThanhTien) as ap1 
FROM         HOADON
WHERE     (Day(NgayLapHD) = @ngay
and month(NgayLapHD) = @thang
and year(NgayLapHD) = @nam)
GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery_TrungKhoa]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery_TrungKhoa]
(
	@chuoi varchar(10), @kq bit output
)
AS
	set @kq = (
SELECT    COUNT(*)
FROM         MON
WHERE     (MaMon = @chuoi))
GO
/****** Object:  StoredProcedure [dbo].[SelectQuery_ThanhTien]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectQuery_ThanhTien]
AS
	SET NOCOUNT ON;
SELECT    TenHang, NgayNhap, DonGia * SoLuongNhap AS Expr1
FROM         NGUYENLIEU
GO
/****** Object:  StoredProcedure [dbo].[SL_Con]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SL_Con] @sl int output
as
begin

	set @sl = (SELECT    COUNT(*) AS Expr1
	FROM         MON
	WHERE     (TrangThai = 1))
end
GO
/****** Object:  StoredProcedure [dbo].[SL_Het]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SL_Het] @sl int output
as
begin

	set @sl = (SELECT    COUNT(*) AS Expr1
	FROM         MON
	WHERE     (TrangThai = 0))
end
GO
/****** Object:  StoredProcedure [dbo].[SoLuongBan]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SoLuongBan]
AS
	SET NOCOUNT ON;
SELECT COUNT(*) FROM BAN
GO
/****** Object:  StoredProcedure [dbo].[SoLuongLoaiMon]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SoLuongLoaiMon]
AS
	SET NOCOUNT ON;
SELECT COUNT(*) FROM LOAIMON
GO
/****** Object:  StoredProcedure [dbo].[SuCo_NgayLap]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuCo_NgayLap]
(
	@NgayBatDau date,
	@NgayKetThuc date
)
AS
	SET NOCOUNT ON;
SELECT    MaBienBan, TenBienBan, NgayLap, GiaiQuyet, ChiPhi, MaKH, MaNV
FROM         SUCO
WHERE     (NgayLap >= @NgayBatDau) AND (NgayLap <= @NgayKetThuc)
GO
/****** Object:  StoredProcedure [dbo].[SuCo_TimKiem]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuCo_TimKiem]
(
	@chuoi varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT    MaBienBan, TenBienBan, NgayLap, GiaiQuyet, ChiPhi, MaKH, MaNV
FROM         SUCO
WHERE     (MaBienBan LIKE '%' + @chuoi + '%') OR
                      (TenBienBan LIKE '%' + @chuoi + '%') OR
                      (NgayLap LIKE @chuoi) OR
                      (GiaiQuyet LIKE '%' + @chuoi + '%') OR
                      (ChiPhi LIKE  @chuoi) OR
                      (MaKH LIKE '%' + @chuoi + '%') OR
                      (MaNV LIKE '%' + @chuoi + '%')
GO
/****** Object:  StoredProcedure [dbo].[TimKiem]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimKiem] @chuoi nvarchar(5)
as
	Begin
		if @chuoi like N'%còn%' 
			Select * 
			from Mon
			where TrangThai = 1;
		else if @chuoi like N'%hết%'
			 Select * 
			from Mon
			where TrangThai = 0;
			else
				Select * 
				from Mon
				where MaMon like '%'+@chuoi+'%' or TenMon like '%'+@chuoi+'%' or Gia like '%'+@chuoi+'%' or Maloai like '%'+@chuoi+'%'
	End;
GO
/****** Object:  StoredProcedure [dbo].[TimKiem_NguyenLieu]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimKiem_NguyenLieu]
(
	@chuoi varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT    MaHang AS Expr1, TenHang AS Expr2, NgayNhap AS Expr3, NgayHetHan AS Expr4, SoLuongNhap AS Expr5, SoLuongXuat AS Expr6, DonViTinh AS Expr7, DonGia AS Expr8, MaNV AS Expr9, NGUYENLIEU.*
FROM         NGUYENLIEU
WHERE     (MaHang LIKE '%' + @chuoi + '%') OR
                      (TenHang LIKE '%' + @chuoi + '%') OR
                      (NgayNhap LIKE '%' + @chuoi + '%') OR
                      (NgayHetHan LIKE '%' + @chuoi + '%') OR
                      (SoLuongXuat LIKE '%' + @chuoi + '%') OR
                      (SoLuongNhap LIKE  @chuoi ) OR
                      (DonViTinh LIKE @chuoi ) OR
                      (DonGia LIKE '%' + @chuoi + '%') OR
                      (MaNV LIKE '%' + @chuoi + '%')
GO
/****** Object:  StoredProcedure [dbo].[tinhthanhtien]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tinhthanhtien]
as
begin
	Declare @thanhtien money , @MaHD varchar(10)
	Declare tinhthanhtien cursor
	Dynamic
	for select thanhtien, MaHD from HOADON
	open tinhthanhtien
	fetch next from tinhthanhtien into  @thanhtien, @MaHD
	while (@@FETCH_STATUS =0)
		begin
		set @thanhtien = (select sum(thanhtien) from CHITIETHOADON
		where MaHD = @MaHD)
		Update HOADON 
		set ThanhTien = @thanhtien -GiamGia
		Where MaHD =@MaHD
		fetch next from tinhthanhtien into @thanhtien,@maHD
		end;
	close tinhthanhtien
	deallocate tinhthanhtien
end;
GO
/****** Object:  StoredProcedure [dbo].[TongBan]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TongBan]
AS
	SET NOCOUNT ON;
SELECT COUNT(*) FROM BAN
GO
/****** Object:  StoredProcedure [dbo].[tongChiPhi]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tongChiPhi]
AS
	SET NOCOUNT ON;
SELECT    CAST(SUM(ChiPhi) AS int) AS Expr1
FROM         SUCO
GO
/****** Object:  StoredProcedure [dbo].[TongChiPhi_NguyenLieu]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TongChiPhi_NguyenLieu]
AS
	SET NOCOUNT ON;
SELECT    SUM(DonGia * SoLuongNhap) AS Expr1
FROM         NGUYENLIEU
GO
/****** Object:  StoredProcedure [dbo].[TongDTL]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TongDTL]
AS
	SET NOCOUNT ON;
SELECT SUM(DIEMTICHLUY) FROM KHACHHANG
GO
/****** Object:  StoredProcedure [dbo].[TongHang]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TongHang]
AS
	SET NOCOUNT ON;
SELECT    COUNT(*) AS Expr1
FROM         NGUYENLIEU
GO
/****** Object:  StoredProcedure [dbo].[TongHoaDon]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TongHoaDon]
AS
	SET NOCOUNT ON;
SELECT COUNT(*) AS Expr1
FROM     HOADON
GO
/****** Object:  StoredProcedure [dbo].[TongKH]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TongKH]
AS
	SET NOCOUNT ON;
SELECT COUNT(*) FROM KHACHHANG
GO
/****** Object:  StoredProcedure [dbo].[TongSL]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TongSL] @sl int output
as
begin

	set @sl = (SELECT    COUNT(*) AS Expr1
	FROM         MON)
end
GO
/****** Object:  StoredProcedure [dbo].[TongSP]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TongSP]
AS
	SET NOCOUNT ON;
SELECT SUM(SoLuong) AS Expr1
FROM     CHITIETHOADON
GO
/****** Object:  StoredProcedure [dbo].[tongtien_ngay_NL]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tongtien_ngay_NL] @nam int, @thang int, @ngay int
as
begin
	SELECT    SUM(DonGia * SoLuongNhap) AS ThanhTien
FROM         NGUYENLIEU
WHERE     (YEAR(NgayNhap) = @nam) AND (MONTH(NgayNhap) = @thang) AND (DAY(NgayNhap) = @ngay)
end
GO
/****** Object:  StoredProcedure [dbo].[TongThanhTien]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TongThanhTien]
AS
	SET NOCOUNT ON;
SELECT SUM(ThanhTien) AS Expr1
FROM     HOADON
GO
/****** Object:  StoredProcedure [dbo].[TopItChiPhi_SuCo]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TopItChiPhi_SuCo]
AS
	SET NOCOUNT ON;
SELECT    MaBienBan, TenBienBan, NgayLap, GiaiQuyet, ChiPhi, MaKH, MaNV
FROM         SUCO
WHERE     ChiPhi = (select Min(chiphi)
from SUCO)
GO
/****** Object:  StoredProcedure [dbo].[TopNhieuChiPhi_SuCo]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TopNhieuChiPhi_SuCo]
AS
	SET NOCOUNT ON;
SELECT    MaBienBan, TenBienBan, NgayLap, GiaiQuyet, ChiPhi, MaKH, MaNV
FROM         SUCO
WHERE     (ChiPhi =
                          (SELECT    MAX(ChiPhi) AS Expr1
                            FROM         SUCO AS SUCO_1))
GO
/****** Object:  StoredProcedure [dbo].[thanhtien_Ngay]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thanhtien_Ngay]  @nam int, @thang int, @ngay int
as
begin

	SELECT    *
	FROM       SUCO
	WHERE     (YEAR(NgayLap) = @nam) AND (MONTH(NgayLap) = @thang) AND (DAY(NgayLap) = @ngay)
end
GO
/****** Object:  StoredProcedure [dbo].[thanhtien_Ngay_HoaDon]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[thanhtien_Ngay_HoaDon]  @nam int, @thang int, @ngay int
as
begin

	SELECT MaHD, NgayLapHD, MaNV, MaKH, MaBan, GiamGia, ThanhTien FROM dbo.HOADON
	WHERE     (YEAR(NgayLapHD) = @nam) AND (MONTH(NgayLapHD) = @thang) AND (DAY(NgayLapHD) = @ngay)
end
GO
/****** Object:  StoredProcedure [dbo].[thanhtien_ngay_NL]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[thanhtien_ngay_NL] @nam int, @thang int, @ngay int
as
begin
	SELECT    MaHang, TenHang, NgayNhap, NgayHetHan, SoLuongXuat, SoLuongNhap, DonViTinh, DonGia, MaNV,DonGia * SoLuongNhap AS ThanhTien
FROM         NGUYENLIEU
WHERE     (YEAR(NgayNhap) like @nam) AND (MONTH(NgayNhap) like @thang) AND (DAY(NgayNhap) like @ngay)
end
GO
/****** Object:  StoredProcedure [dbo].[thanhtien_Thang_HoaDon]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[thanhtien_Thang_HoaDon] @nam int, @thang int
as
begin
SELECT    MaHD, NgayLapHD, MaNV, MaKH, MaBan, GiamGia, ThanhTien
FROM         HOADON
WHERE     (YEAR(NgayLapHD) = @nam) AND (MONTH(NgayLapHD) = @thang)
end
GO
/****** Object:  StoredProcedure [dbo].[thanhtien_thang_NL]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[thanhtien_thang_NL] @nam int, @thang int
as
begin
	SELECT    MaHang, TenHang, NgayNhap, DonGia * SoLuongNhap AS ThanhTien, NgayHetHan, SoLuongXuat, SoLuongNhap, DonViTinh, DonGia, MaNV
	FROM         NGUYENLIEU
	WHERE     (YEAR(NgayNhap) = @nam) AND (MONTH(NgayNhap) = @thang)
end
GO
/****** Object:  StoredProcedure [dbo].[thanhtien_thang_SC]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thanhtien_thang_SC] @nam int, @thang int
as
begin
	SELECT   *
	FROM         SuCo
	WHERE     (YEAR(NgayLap) = @nam) AND (MONTH(NgayLap) = @thang)
end
GO
/****** Object:  StoredProcedure [dbo].[thanhtien_Thang_SuCo]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thanhtien_Thang_SuCo] @nam int, @thang int
as
begin
SELECT    MaHD, NgayLapHD, MaNV, MaKH, MaBan, GiamGia, ThanhTien
FROM         HOADON
WHERE     (YEAR(NgayLapHD) = @nam) AND (MONTH(NgayLapHD) = @thang)
end
GO
/****** Object:  StoredProcedure [dbo].[ThongTin_NhanVien_MaNV]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongTin_NhanVien_MaNV]
(
	@tendn varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT    MaNV,TenDangNhap, HoTen, GioiTinh, SdtNV, NgaySinh, MaCV
FROM         NHANVIEN
WHERE     (TenDangNhap = @tendn)
GO
/****** Object:  StoredProcedure [dbo].[ThongTin_taikhoan]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongTin_taikhoan]
(
	@tendn varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT TenDangNhap, MatKhau FROM dbo.TAIKHOAN
where tendangnhap = @tendn
GO
/****** Object:  StoredProcedure [dbo].[ThongTinKH_SDT]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongTinKH_SDT]
(
	@sdt varchar(15)
)
AS
	SET NOCOUNT ON;
SELECT    MaKH, SDT, TenKH, DiemTichLuy
FROM         KHACHHANG
WHERE     (SDT = @sdt)
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuerry]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateQuerry] @TenMon nvarchar(50), @Gia decimal, @TrangThai bit, @Maloai varchar(10), @Original_MaMon varchar(10)
as
begin
	UPDATE    MON
	SET       TenMon = @TenMon, Gia = @Gia, TrangThai = @TrangThai, Maloai = @Maloai
	WHERE     (MaMon = @Original_MaMon)
end
GO
/****** Object:  StoredProcedure [dbo].[xuatDSTheoMa]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuatDSTheoMa] @ma varchar(10)
as
begin
	SELECT    MaMon, TenMon, Gia, TrangThai, Maloai
	FROM         MON
	WHERE     (Maloai = @ma)
end
GO
/****** Object:  StoredProcedure [dbo].[xuatNguyenLieu_CanNhap_pro]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuatNguyenLieu_CanNhap_pro]
 as
	select * from dbo.xuatNguyenLieu_CanNhap()
GO
/****** Object:  StoredProcedure [dbo].[xuatNguyenLieu_HetHan_pro]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuatNguyenLieu_HetHan_pro]
 as
	select * from dbo.xuatNguyenLieu_HetHan()
GO
/****** Object:  StoredProcedure [dbo].[xuatNguyenLieu_NhanVien_pro]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[xuatNguyenLieu_NhanVien_pro] @Ma varchar(10)
 as
	select * from dbo.xuatNguyenLieu_NhanVien(@Ma)
GO
/****** Object:  StoredProcedure [dbo].[xuatSL_ItNhat]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuatSL_ItNhat] 
as
begin
	SELECT    ct.MaMon, m.TenMon, m.Gia, m.TrangThai, m.Maloai
FROM         CHITIETHOADON AS ct LEFT OUTER JOIN
                      MON AS m ON ct.MaMon = m.MaMon
GROUP BY ct.MaMon, m.TenMon, m.Gia, m.TrangThai, m.Maloai
HAVING     (COUNT(ct.MaMon) <= ALL
                          (SELECT    COUNT(*) AS Expr1
                            FROM         CHITIETHOADON AS CHITIETHOADON_1
                            GROUP BY MaMon))
end
GO
/****** Object:  StoredProcedure [dbo].[xuatSL_NhieuNhat]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuatSL_NhieuNhat] 
as
begin
	SELECT    ct.MaMon, m.TenMon, m.Gia, m.TrangThai, m.Maloai
	FROM         CHITIETHOADON AS ct LEFT OUTER JOIN
                      MON AS m ON ct.MaMon = m.MaMon
	GROUP BY ct.MaMon, m.TenMon, m.Gia, m.TrangThai, m.Maloai
	HAVING     (COUNT(ct.MaMon) >= ALL
                          (SELECT    COUNT(*) AS Expr1
                            FROM         CHITIETHOADON AS CHITIETHOADON_1
                            GROUP BY MaMon))
end
GO
/****** Object:  Trigger [dbo].[capnhap_ThanhTien_HoaDon]    Script Date: 12/25/2022 5:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[capnhap_ThanhTien_HoaDon] on [dbo].[CHITIETHOADON]
for insert , update
as
begin
	update CHITIETHOADON
	set ThanhTien = (select soluong * (select Gia from Mon where MaMon = (select MaMon from inserted)) from CHITIETHOADON 
										where MaMon = (select MaMon from inserted) and MaHD = (select MAHD from inserted) )
	where MaHD = (select MAHD from inserted) and MaMon = (select MaMon from inserted)
	update HOADON
	set ThanhTien = (select sum(ThanhTien) from CHITIETHOADON where MaHD = (select MAHD from inserted)) 
	where MaHD = (select MAHD from inserted)	
end
GO
ALTER TABLE [dbo].[CHITIETHOADON] ENABLE TRIGGER [capnhap_ThanhTien_HoaDon]
GO
/****** Object:  Trigger [dbo].[update_ThanhTien_GiamGia_HoaDon]    Script Date: 12/25/2022 5:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_ThanhTien_GiamGia_HoaDon] on [dbo].[HOADON]
for insert , update
as
begin
update HOADON
		set ThanhTien =  ThanhTien - GiamGia
		where MaHD = (select MAHD from inserted)
end
GO
ALTER TABLE [dbo].[HOADON] ENABLE TRIGGER [update_ThanhTien_GiamGia_HoaDon]
GO
