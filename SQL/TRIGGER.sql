use QLKTX
go

--trigger
--Câu 1: Kiểm tra số điện thoại người dùng không được nhỏ hơn 10 hoặc lớn hơn 11 số
create trigger check_soDT
on NGUOIDUNG
for insert, update
as
	declare @tmp int
begin
	select @tmp = LEN(SĐT1) from NGUOIDUNG

		IF(@tmp > 11 or @tmp < 10)
			begin
				print N' Số điện thoại không được nhỏ hơn 10 và lớn hơn 11 số'
				
				rollback transaction
			end
end
go
--Câu 2: Kiểm tra tên đăng nhập khồng được quá 30 kí tự
create trigger check_tenDangNhap
on NGUOIDUNG
for insert, update
as
declare @Number int
begin
		
	select @Number =  LEN(TENDANGNHAP)from inserted
		if(@Number > 30)
			begin
				print N'Tên đăng nhập không được dài quá 30 kí tự'
				
				rollback transaction
			end
--rollback
end 
--drop trigger INSERT_UPDATE_NGUOIDUNG

GO
--Câu 3 Mật khẩu người dùng không được để trống và nhỏ hơn 4 ký tự
create trigger mat_khau
on NGUOIDUNG
for insert, update
as
declare @Count int
begin
select @Count = DATALENGTH(MATKHAU) from NGUOIDUNG
if(@Count < 4)
			begin
				print N'Mật khẩu không được nhỏ hơn 4 kí tự'
				rollback transaction
			end
end
go
--Câu 4: Nhân viên phải từ 20 tuổi trở lên 
CREATE TRIGGER check_nhanvien
ON NHANVIEN
FOR insert, update
AS
BEGIN
	declare @age int  
	select @age = DATEDIFF(year, NGAYSINH, GETDATE()) from NGUOIDUNG 
	if(@age < 20)
	begin
	print N'Nhân viên phải từ 20 tuổi trở lên'
	rollback tran
	end
	
	
	
END
go


--Câu 5: Kiểm tra loại phòng chỉ có thể là phòng đôi, phòng 4, phòng 6 hoặc phòng 8 
create trigger loai_phong
on LOAIPHONG
for insert, update
as
begin
declare	@num int
select @num = SUCCHUA from LOAIPHONG
	if(@num > 8)
		begin
			print N'Không tồn tại loại phòng này chỉ có thể là 2 4 6 8 người/phòng'
			rollback tran
		end
	if(@num%2 != 0)
		begin
			print N'Không tồn tại loại phòng này chỉ có thể là 2 4 6 8 người/phòng'
			rollback tran
		end
end
go
drop trigger loai_phong
go
--Câu 6: Cập nhật trạng thái của hóa đơn khi đã thanh toán
create trigger update_thanhtoan_hoadon
on THANHTOAN
for update
as
begin
	begin try
	if exists(select t.SOTIEN from THANHTOAN t, deleted dl where t.MAHOADON = dl.MAHOADON and t.SOTIEN > 0)
	update h set h.TRANGTHAI = 1
	from HOADON h, THANHTOAN t
	where h.MAHOADON = t.MAHOADON; 
	print N'Cập nhật thành công'
	end try
	
	begin catch
	print N'Cập nhật không thành công'
	rollback
	end catch
end
go

--Câu 7 :Hủy đăng kí phòng
create trigger huy_dk_phong
on DKPHONG
for delete
as
begin
	declare @value int
	if(@@ROWCOUNT = 0)
	begin
		print N'Không có dữ liệu đăng ký phòng'
		return
	end
	select * from DKPHONG 
	where @value = MADKPHONG
	
end

go

--Câu 8: Kiểm tra chỉ số sử dụng dịch vụ (điện, nước,..) số cũ không được lớn hơn số mới
create trigger check_cthd
on CTHD
for insert, update
as
begin
	if exists(select * from CTHD where SOCU > SOMOI)
	begin
		print N'Số cũ không thể lớn hơn số mới'
		rollback tran
	end
end
go

--Câu 9:  Cập nhật tổng tiền của hóa đơn khi thay đổi chi tiết hóa đơn
create trigger capNhat_ThanhTien
on CTHD
after insert, update, delete
as
begin
	declare @MaHD int ;
	declare @SumMoney float;
	with tmp as
	 ( 
		select MAHOADON from inserted
		union
		select MAHOADON from deleted
		)	
	select @MaHD = MAHOADON from tmp
	
	select @SumMoney = SUM((ct.SOMOI - ct.SOCU)* dv.DONGIA) 
	from CTHD ct,DICHVU dv
	where MAHOADON = @MaHD and ct.MADICHVU=dv.MADICHVU
	
	update CTHD 
	set TONGIA = @SumMoney
	
	
	update HOADON 
	set TONG = @SumMoney
	where MAHOADON = @MaHD
	
end 
go

-- Câu 10: Kiểm tra trạng thái người dùng chỉ có thể là 0(false) hoặc 1(true)
create trigger check_trangThaiUser
on NGUOIDUNG
for insert, update
as
begin
	if exists (select * from NGUOIDUNG where TRANGTHAI < 0 or TRANGTHAI > 1)
		begin
			print N'Trạng thái chỉ có thể là 0 hoặc 1'
			rollback tran
		end
end
go 

--Câu 11: Kiểm tra tuổi sinh viên phải từ 18 tuổi trở lên và Usertype phải là 'SINHVIEN'
create trigger check_tuoiSV
on SINHVIEN
for insert, update
as
begin
	declare @age int  
	select @age = DATEDIFF(year, NGAYSINH, GETDATE()) from NGUOIDUNG 
	if(@age < 18)
	begin
	print N'Sinh viên phải từ 18 tuổi trở lên'
	rollback tran
	end
	if not exists(select * from NGUOIDUNG n, inserted i where n.ID_NGUOIDUNG = i.ID_NGUOIDUNG and n.USERTYPE = 'SINHVIEN')
	begin
		print N'Người dùng không phải sinh viên'
		rollback tran
	end
end
