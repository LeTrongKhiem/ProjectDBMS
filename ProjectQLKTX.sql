﻿create database QLKTX
go
use QLKTX
go

--TẠO BẢNG TỈNH THÀNH
CREATE TABLE TINHTHANH (
	MATINH VARCHAR(2) NOT NULL,
	TENTINHTHANH NVARCHAR(20) NOT NULL,
	KIEUTINHTHANH VARCHAR(1) NOT NULL,		--NHAN 2 GT: C: thành phố trực thuôc trung ương, P: Tỉnh
	CONSTRAINT PK_TINH PRIMARY KEY(MATINH)
)
GO
--TẠO BẢNG HUYỆN/ QUẬN
CREATE TABLE HUYEN (
	MAHUYEN VARCHAR(3) NOT NULL,
	TENHUYEN NVARCHAR(40) NOT NULL,
	KIEUHUYEN VARCHAR(1) NOT NULL,		--C: thành phố trực thuộc tỉnh, D: quận, H: huyện, T: thị xã
	MATINH VARCHAR(2) NOT NULL,

	CONSTRAINT PK_HUYEN PRIMARY KEY(MAHUYEN),
	CONSTRAINT FK_HUYEN_TINH FOREIGN KEY (MATINH) REFERENCES TINHTHANH (MATINH)
)
GO
--TẠO BẢNG XÃ / PHƯỜNG
CREATE TABLE XA (
	MAXA VARCHAR(5) NOT NULL,
	TENXA NVARCHAR(40) NOT NULL,
	KIEUXA VARCHAR(1) NOT NULL,			-- W: Phường, V: xã, T: thị trấn
	UUTIEN VARCHAR(6) NOT NULL DEFAULT N'KV3',		--độ ưu tiên (KV1, KV2, KV2-NT, KV3)
	MAHUYEN VARCHAR(3) NOT NULL,

	CONSTRAINT MAXA PRIMARY KEY(MAXA),
	CONSTRAINT FK_XA_HUYEN FOREIGN KEY (MAHUYEN) REFERENCES HUYEN(MAHUYEN)
)
GO
--TẠO BẢNG ĐẠI CHỈ
CREATE TABLE DIACHI (
	MADIACHI BIGINT IDENTITY(1, 1),
	DUONG NVARCHAR(50) NULL,
	MAXA VARCHAR(5) NOT NULL,
	MAHUYEN VARCHAR(3) NOT NULL,
	MATINH VARCHAR(2) NOT NULL,

	CONSTRAINT [PK_DIACHI] PRIMARY KEY(MADIACHI),
	CONSTRAINT [FK_DIACHI_XA] FOREIGN KEY (MAXA) REFERENCES XA(MAXA),
	CONSTRAINT [FK_DIACHI_HUYEN] FOREIGN KEY (MAHUYEN) REFERENCES HUYEN(MAHUYEN),
	CONSTRAINT [FK_DIACHI_TINH] FOREIGN KEY (MATINH) REFERENCES TINHTHANH(MATINH),
)
GO
--TẠO BẢNG TRƯỜNG
CREATE TABLE TRUONG (
	ID_TRUONG INT IDENTITY(1, 1) NOT NULL,
	MATRUONG VARCHAR(5) NULL, 				-- MÃ TRƯỜNG NLU, BKU, SPK ...
	TENTRUONG NVARCHAR(100) NOT NULL,

	CONSTRAINT [PK_TRUONG] PRIMARY KEY (ID_TRUONG)
)
GO
--TẠO BẢNG NGƯỜI DÙNG
CREATE TABLE NGUOIDUNG (
	ID_NGUOIDUNG BIGINT IDENTITY(1, 1) NOT NULL,
	HO NVARCHAR(40) NOT NULL,
	TEN NVARCHAR(20) NOT NULL,
	NGAYSINH DATE NOT NULL,								-- NGÀY SINH
	GIOITINH NVARCHAR(5) NOT NULL,						-- GIỚI TÍNH
	CMND VARCHAR(12) NULL, 							-- CHỨNG MINH NHÂN DÂN

	MADIACHI BIGINT NOT NULL,
	SĐT1 VARCHAR(15) NULL,					-- SỐ ĐIỆN THOẠI
	EMAIL VARCHAR(40) NULL,
	LINK_HINHANH VARCHAR(300) NULL,

	TENDANGNHAP VARCHAR(16) NOT NULL,
	MATKHAU VARCHAR(32) NOT NULL,
	USERTYPE VARCHAR(10) NOT NULL DEFAULT 'SINHVIEN',	-- ADMIN: TK QUẢN TRỊ, EMPLOYEE: NHÂN VIÊN, STUDENT: SINH VIÊN, RELATIVE: NGƯỜI THÂN
	TRANGTHAI BIT DEFAULT 1 NOT NULL
)
GO
ALTER TABLE dbo.NGUOIDUNG ADD CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY(ID_NGUOIDUNG)
ALTER TABLE dbo.NGUOIDUNG ADD CONSTRAINT [FK_NGUOIDUNG_DIACHI] FOREIGN KEY (MADIACHI) REFERENCES DIACHI(MADIACHI)
ALTER TABLE dbo.NGUOIDUNG ADD CONSTRAINT [TENDANGNHAP_UNINE] UNIQUE(TENDANGNHAP)
ALTER TABLE dbo.NGUOIDUNG ADD CONSTRAINT [PK_UNIQUE] UNIQUE(CMND)
GO
CREATE UNIQUE NONCLUSTERED INDEX IDX_USER_MAIL_Unique_Nullable ON NGUOIDUNG(EMAIL) WHERE EMAIL IS NOT NULL
CREATE UNIQUE NONCLUSTERED INDEX IDX_USER_SĐT1_Unique_Nullable ON NGUOIDUNG(SĐT1) WHERE SĐT1 IS NOT NULL
GO
CREATE TABLE [ADMIN] (
	ID_NGUOIDUNG BIGINT NOT NULL,				-- ĐỊNH DANH, DÙNG ĐỂ REFERENCES

	CONSTRAINT [PK_ADMIN] PRIMARY KEY(ID_NGUOIDUNG),
	CONSTRAINT [FK_ADMIN_NGUOIDUNG] FOREIGN KEY (ID_NGUOIDUNG) REFERENCES NGUOIDUNG(ID_NGUOIDUNG)
)
GO
--TẠO BẢNG NHÂN VIÊN QUẢN LÍ
CREATE TABLE NHANVIEN (
	ID_NGUOIDUNG BIGINT NOT NULL,				-- ĐỊNH DANH, DÙNG ĐỂ REFERENCES
	NGAYBD DATE DEFAULT GETDATE(),
	LUONG DECIMAL(19, 4),

	CONSTRAINT [PK_NHANVIEN] PRIMARY KEY(ID_NGUOIDUNG),
	CONSTRAINT [FK_NHANVIEN_NGUOIDUNG] FOREIGN KEY (ID_NGUOIDUNG) REFERENCES NGUOIDUNG(ID_NGUOIDUNG)
)
GO
--TẠO BẢNG SINH VIEN
CREATE TABLE SINHVIEN (
	ID_NGUOIDUNG BIGINT NOT NULL,				-- ĐỊNH DANH, DÙNG ĐỂ REFERENCES
	MASINHVIEN VARCHAR(15) NOT NULL,		-- MÃ SỐ SINH VIÊN, KHÔNG DÙNG ĐỂ REFERENCES
	ID_TRUONG INT NOT NULl,				-- TRƯỜNG
	KHOA NVARCHAR(50),					-- KHOA
	NGANH NVARCHAR(50),					-- NGÀNH HỌC
	
	CONSTRAINT [PK_SINHVIEN] PRIMARY KEY(ID_NGUOIDUNG),
	CONSTRAINT [FK_SINHVIEN_NGUOIDUNG] FOREIGN KEY (ID_NGUOIDUNG) REFERENCES NGUOIDUNG(ID_NGUOIDUNG),
	CONSTRAINT [FK_SINHVIEN_TRUONG] FOREIGN KEY (ID_TRUONG) REFERENCES TRUONG(ID_TRUONG)
)
GO
ALTER TABLE dbo.SINHVIEN ADD [TRANGTHAIDK] BIT DEFAULT 0
GO
-- TẠO BẢNG NGƯỜI THÂN
CREATE TABLE QUANHE (
	ID_NGUOIDUNG BIGINT NOT NULL,						-- ĐỊNH DANH LẤY USER ĐỂ LƯU THÔNG TIN (ID CỦA NGƯỜI THÂN)
	QUANHE_ID_NGUOIDUNG BIGINT NOT NULL,				-- USER_ID CỦA SINH VIÊN/ NHÂN VIÊN/ ADMIN
	QUANHE NVARCHAR(20),					-- QUAN HỆ
	
	CONSTRAINT [PK_QUANHE] PRIMARY KEY(ID_NGUOIDUNG, QUANHE_ID_NGUOIDUNG),
	CONSTRAINT [FK_QUANHE_NGUOIDUNG] FOREIGN KEY (ID_NGUOIDUNG) REFERENCES NGUOIDUNG(ID_NGUOIDUNG),
	CONSTRAINT [FK_QUANHE_NGUOIDUNG_DESC] FOREIGN KEY (QUANHE_ID_NGUOIDUNG) REFERENCES NGUOIDUNG(ID_NGUOIDUNG)
)
GO
--TẠO BẢNG LOẠI PHONG
CREATE TABLE LOAIPHONG (
	MALOAIPHONG INT IDENTITY(1, 1),
	TENLOAIPHONG NVARCHAR(20),
	GIA DECIMAL(19, 4),
	DIENTICH DECIMAL(8, 2),				-- DIỆN TÍCH
	SUCCHUA INT,						-- SỨC CHỨA

	CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY (MALOAIPHONG),
)
GO
-- TẠO BẢNG KHU VỰC
CREATE TABLE KHUVUC (
	MAKHUVUC VARCHAR(10) NOT NULL,
	TENKHUVUC NVARCHAR(50),

	CONSTRAINT [PK_KHUVUC] PRIMARY KEY(MAKHUVUC), 
)
GO
--TẠO BẢNG PHÒNG
CREATE TABLE PHONG (
	MAPHONG NVARCHAR(10) NOT NULL,
	MAKHUVUC VARCHAR(10) NOT NULL,
	MALOAIPHONG INT NOT NULL,

	CONSTRAINT [PK_PHONG] PRIMARY KEY (MAPHONG),
	CONSTRAINT [FK_PHONG_KHUVUC] FOREIGN KEY (MAKHUVUC) REFERENCES KHUVUC(MAKHUVUC),
	CONSTRAINT [PK_PHONG_LOAIPHONG] FOREIGN KEY (MALOAIPHONG) REFERENCES LOAIPHONG(MALOAIPHONG),
)
GO
--TẠO BẢNG ĐƠN VỊ
CREATE TABLE DONVI (
	MADONVI INT IDENTITY(1, 1),
	TENDONVI NVARCHAR(50),

	CONSTRAINT [PK_DONVI] PRIMARY KEY(MADONVI),
)
GO
-- TẠO BẢNG DỊCH VỤ
CREATE TABLE DICHVU(
	MADICHVU INT IDENTITY(1, 1),		-- MÃ DV
	TENDICHVU NVARCHAR(50),			-- TÊN DV
	MADONVI INT NOT NULL,					-- 
	DONGIA DECIMAL(19, 4),		-- ĐƠN GIÁ
	TRANGTHAI BIT DEFAULT 1, 				-- TRẠNG THÁI 1: CÒN, 0: ẨN(XÓA)

	CONSTRAINT [PK_DICHVU] PRIMARY KEY (MADICHVU),
	CONSTRAINT [FK_DICHVU_DONVI] FOREIGN KEY (MADONVI) REFERENCES DONVI(MADONVI),
)
GO
-- TẠO BẢNG HÓA ĐƠN
CREATE TABLE HOADON(
	MAHOADON BIGINT IDENTITY(1, 1),
	MANHANVIEN BIGINT NOT NULL,
	MAPHONG NVARCHAR(10) NOT NULL,
	NGAYTAO DATETIME DEFAULT GETDATE(),
	TONG DECIMAL(19, 4),	

	MAKHUVUC VARCHAR(10),
	TRANGTHAI BIT  DEFAULT 0,
	THANG INT,
	NAM INT,

	CONSTRAINT [PK_HOADON] PRIMARY KEY (MAHOADON),
	CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN(ID_NGUOIDUNG),
	CONSTRAINT [FK_HOADON_PHONG] FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG),
)
GO
--TẠO BẢNG CHI TIẾT HÓA ĐƠN
CREATE TABLE CTHD(
	MACTHD BIGINT IDENTITY(1, 1),
	MAHOADON BIGINT NOT NULL,
	MADICHVU INT NOT NULL,
	SOCU INT NOT NULL,			-- SỐ CŨ
	SOMOI INT NOT NULL,			-- SỐ MỚI

	TENDONVI NVARCHAR(50),
	TONGIA DECIMAL(19,4),

	CONSTRAINT [PK_CTHD] PRIMARY KEY (MACTHD, MAHOADON),
	CONSTRAINT [FK_CTHD_HOADON] FOREIGN KEY (MAHOADON) REFERENCES HOADON(MAHOADON),
	CONSTRAINT [FK_CTHD_DICHVU] FOREIGN KEY (MADICHVU) REFERENCES DICHVU(MADICHVU),
)
GO
-- TẠO BẢNG THANH TOÁN
CREATE TABLE THANHTOAN(
	MATHANHTOAN BIGINT IDENTITY(1, 1),				
	MAHOADON BIGINT NOT NULL,					 	-- MẢ HÓA ĐƠN
	MANHANVIEN BIGINT NOT NULL,					-- MÃ NHÂN VIÊN NHẬN TIỀN
	NGAYTHANHTOAN DATETIME DEFAULT GETDATE() NULL,	-- NGÀY THANH TOÁN
	SOTIEN DECIMAL(19, 4) NOT NULL,				-- SỐ TIỀN

	CONSTRAINT [PK_THANHTOAN] PRIMARY KEY (MATHANHTOAN, MAHOADON),
	CONSTRAINT [FK_THANHTOAN_HOADON] FOREIGN KEY (MAHOADON) REFERENCES HOADON(MAHOADON),
	CONSTRAINT [FK_THANHTOAN_NHANVIEN] FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN(ID_NGUOIDUNG)
)
GO
--TẠO BẢNG ĐĂNG KÍ PHÒNG
CREATE TABLE DKPHONG(
	MADKPHONG BIGINT IDENTITY(1, 1),
	CMND VARCHAR(12) NOT NULL,
	MAPHONG NVARCHAR(10) NOT NULL,
	MANHANVIEN BIGINT NOT NULL,
	MAKHUVUC VARCHAR(10) NOT NULL,
	NGAYBD DATETIME DEFAULT GETDATE() NOT NULL,
	HOCKY INT NOT NULL,
	NAMHOC INT NOT NULL,
	THOIHAN NVARCHAR(20) NOT NULL,
	TRANGTHAI BIT DEFAULT 0
	
	CONSTRAINT [PK_MADKPHONG] PRIMARY KEY (MADKPHONG),
	CONSTRAINT [FK_MAPHONG] FOREIGN KEY (MAPHONG) REFERENCES [dbo].PHONG(MAPHONG),
	CONSTRAINT [FK_MANHANVIEN] FOREIGN KEY (MANHANVIEN) REFERENCES [dbo].NHANVIEN(ID_NGUOIDUNG),
	CONSTRAINT [FK_MAKHUVUC] FOREIGN KEY (MAKHUVUC) REFERENCES [dbo].KHUVUC(MAKHUVUC),
)
GO
