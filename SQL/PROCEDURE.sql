USE QLKTX
GO
-- FILE CREATE PROCEDURE 

-- CHỨC NĂNG ĐĂNG NHẬP
CREATE OR ALTER PROC PROC_LOGIN
	@TENDANGNHAP VARCHAR(16),
	@MATKHAU VARCHAR(32)
AS
BEGIN
	DECLARE @PASSWORD_GENERATE VARCHAR(32)
	SET @PASSWORD_GENERATE = dbo.UFN_GenerateMD5(@MATKHAU)
	SELECT * FROM NGUOIDUNG
	WHERE TENDANGNHAP = @TENDANGNHAP COLLATE SQL_Latin1_General_CP1_CS_AS
	AND MATKHAU = @PASSWORD_GENERATE COLLATE SQL_Latin1_General_CP1_CS_AS --PHÂN BIỆT CHỮ THƯỜNG CHỮ HOA
END
GO
--1. LẤY NGƯỜI DÙNG BẰNG TÊN ĐĂNG NHẬP
CREATE OR ALTER PROC USP_GetUserByUsername
@TENDANGNHAP varchar(16)
As 
Begin 
select *
from NGUOIDUNG
where TENDANGNHAP =@TENDANGNHAP;

END;
GO
--2. Dùng để lấy người dùng bằng id
CREATE OR ALTER PROC USP_GetUserById
	@ID_user BIGINT
AS
Begin 
select *
from NGUOIDUNG
where ID_NGUOIDUNG =@ID_user;
end
GO
--3. Dùng để lấy sinh viên bằng id
CREATE OR ALTER PROC USP_GetStudentById
@ID_sv BIGINT
As 
Begin 
select *
from SINHVIEN
where ID_NGUOIDUNG =@ID_sv;
END;
GO
--4. Dùng để lấy quản trị viên bằng id
CREATE OR ALTER PROC USP_GetAdminById
@ID_admin BIGINT
As 
Begin 
select *
from ADMIN
where ID_NGUOIDUNG =@ID_admin;
END;
GO
--5. Dùng để lấy nhân viên bằng id
CREATE OR ALTER PROC USP_GetEmployeeById
	@USER_ID BIGINT
AS
BEGIN
	SELECT * FROM dbo.NHANVIEN WHERE ID_NGUOIDUNG = @USER_ID
END
GO
--6. Dùng để lấy xã, phường bằng của huyện bằng tỉnh, huyện
CREATE OR ALTER PROC USP_GetListCommuneByProvinceAndDistrict
	@TENTINHTHANH NVARCHAR(20),
	@TENHUYEN NVARCHAR(40)
AS
BEGIN
	DECLARE @MATINHTHANH VARCHAR(2)
	DECLARE @MAHUYEN VARCHAR(3)
	SET @MATINHTHANH = dbo.UFN_LayMaTinhBangTenTinh(@TENTINHTHANH)
	SET @MAHUYEN = dbo.UFN_LayMaHuyen(@TENHUYEN,@MATINHTHANH)
	SELECT * FROM dbo.XA WHERE MAHUYEN = @MAHUYEN
END
GO

--7. Dùng để lấy danh sách quản trị viên



GO
--8. Dùng để thay đổi mật khẩu
CREATE OR ALTER PROC USP_ChangePassword
	@ID_NGUOIDUNG BIGINT,
	@OLDPASS VARCHAR(32),
	@NEWPASS VARCHAR(32)
AS
BEGIN
	DECLARE @newPassword VARCHAR(32), @username VARCHAR(16), @execQuery VARCHAR(100)
	SET @newPassword = dbo.UFN_GenerateMD5(@NEWPASS)
	UPDATE dbo.NGUOIDUNG SET MATKHAU = @newPassword WHERE ID_NGUOIDUNG = @ID_NGUOIDUNG
	SELECT @username = CONCAT('_', TENDANGNHAP) FROM dbo.NGUOIDUNG WHERE ID_NGUOIDUNG = @ID_NGUOIDUNG

	SET @execQuery = CONCAT('ALTER LOGIN ', @username, ' WITH PASSWORD = ''', @NEWPASS,''' OLD_PASSWORD = ''',@OLDPASS, '''')
	EXEC(@execQuery)
END
GO
--8.Lấy danh sách phòng
CREATE procedure ds_phong
As 
Begin 
select *
from PHONG
END;
go
exec ds_phong
go
--10.Lấy danh sách khu
CREATE procedure ds_khu
As 
Begin 
select *
from KHUVUC
END;
exec ds_khu
go
-- 11.Lấy danh sách user
CREATE procedure ds_user
As 
Begin 
select *
from NGUOIDUNG
END;
exec ds_user
go
-- 9.Lấy danh sách phòng bằng mã khu vực
CREATE procedure ds_p_mkv
@makhuvuc varchar
As 
Begin 
select *
from PHONG
where MAKHUVUC=@makhuvuc
END;
exec ds_p_mkv
@makhuvuc =A
go
-- 12.Lấy 1 nhân viên
Create procedure nv
@idnv int
As 
Begin 
select *
from NHANVIEN
where ID_NGUOIDUNG =@idnv;
END;
go
-- 