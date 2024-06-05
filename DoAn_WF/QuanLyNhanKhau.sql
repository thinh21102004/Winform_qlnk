
set dateformat dmy
Go
drop database QuanLyNhanKhau

drop table quan
drop table phuong
drop table khupho
drop table hogiadinh
drop table thanhvien
GO
CREATE DATABASE 
QuanLyNhanKhau

GO
USE 
QuanLyNhanKhau

--tao bang
GO
CREATE TABLE Quan
(
 MaQuanID VARCHAR(5)not null
,TenQuan CHAR(20) not null
,CONSTRAINT PK_Quan PRIMARY KEY (MaQuanID)
)
GO
CREATE TABLE Phuong
(
 MaPhuongID VARCHAR(10)not null
,TenPhuong CHAR(20)
,MaQuanID VARCHAR(5)null
,CONSTRAINT PK_Phuong PRIMARY KEY (MaPhuongID)
)
GO
CREATE TABLE KhuPho 
(
 MaKhuPhoID VARCHAR(10)not null
,TenKhuPho CHAR(20)
,MaPhuongID VARCHAR(10)null 
,CONSTRAINT PK_KhuPho PRIMARY KEY (MaKhuPhoID)	
)
GO
CREATE TABLE HoGiaDinh(
 MaHoID VARCHAR (10) not null
,MaKhuPhoID VARCHAR(10) null
,CONSTRAINT PK_HoGiaDinh PRIMARY KEY (MaHoID)
)
GO 
CREATE TABLE ThanhVien
(
 CCCDID VARCHAR(12) not null
,MaHoID VARCHAR(10) null
,HoTen CHAR(50)
,GioiTinh CHAR(10)
,NamSinh Date
,CONSTRAINT PK_ThanhVien PRIMARY KEY (CCCDID)
)


--them khoa ngoai
GO
ALTER TABLE ThanhVien
	ADD CONSTRAINT FK_HoGiaDinh_ThanhVien FOREIGN KEY (MaHoID) REFERENCES HoGiaDinh (MaHoID)
GO
ALTER TABLE HoGiaDinh
ADD CONSTRAINT FK_KhuPho_HoGiaDinh FOREIGN KEY (MaKhuPhoID) REFERENCES KhuPho (MaKhuPhoID)
GO
ALTER TABLE KhuPho
ADD CONSTRAINT FK_Phuong_KhuPho FOREIGN KEY (MaPhuongID) REFERENCES Phuong (MaPhuongID)
GO
ALTER TABLE Phuong
ADD CONSTRAINT FK_Quan_Phuong FOREIGN KEY (MaQuanID)REFERENCES Quan (MaQuanID)
GO

---Lấy ds nhân khẩu
	GO
	CREATE PROC Select_NhanKhau
	As
	BEGIN
		select * from ThanhVien
	END;
	GO
	-- Tim CCCD
CREATE PROC TimCCCD
@CCCDID VARCHAR(12)
AS
BEGIN
SELECT * FROM ThanhVien 
WHERE CCCDID = @CCCDID
END;
-- Tim theo ten
CREATE PROC TimTen
@hoten char(50)
AS
BEGIN
SELECT * FROM ThanhVien 
WHERE ThanhVien.HoTen = @hoten
END;

CREATE PROC Them_NhanKhau
	@CCCDID VARCHAR(12),
	@MaHoID VARCHAR(10),
	@HoTen CHAR(50),
	@GioiTinh CHAR(10),
	@NamSinh Date
	As
	BEGIN
		insert ThanhVien (CCCDID,MaHoID,HoTen,GioiTinh,NamSinh) values(@CCCDID,@MaHoID,@HoTen,@GioiTinh,@NamSinh)
	END;
go
CREATE PROC Sua_NhanKhau
	@CCCDID VARCHAR(12),
	@MaHoID VARCHAR(10),
	@HoTen CHAR(50),
	@GioiTinh CHAR(10),
	@NamSinh Date
	As
	BEGIN

		update ThanhVien set MaHoID=@MaHoID,HoTen=@HoTen,GioiTinh=@GioiTinh,NamSinh=@NamSinh where CCCDID=@CCCDID
	END;
	GO
	CREATE PROC Xoa_NhanKhau
	@CCCDID VARCHAR(12)
	As
	BEGIN

		delete from ThanhVien  where CCCDID=@CCCDID
	END;
	GO
	
create proc sp_inhogiadinh
as
begin
select * from HoGiaDinh
end;
go

create proc sp_timhgd_maho
@maho varchar(10)
as
begin
select * from HoGiaDinh where MaHoID = @maho
end;
go

create proc sp_timhgd_makp
@makp varchar (10)
as 
begin
select * from HoGiaDinh where @makp = MaKhuPhoID
end;
go

create proc so_themhgd
@maho varchar(10), @makhupho varchar(10)
as
begin
insert into HoGiaDinh(MaHoID, MaKhuPhoID)
values (@maho, @makhupho)
end;
go
create proc sp_suahgd
@maho varchar(10), @makp varchar(10)
as
begin
update HoGiaDinh set MaKhuPhoID = @makp where MaHoID = @maho
end;
go
create proc sp_xoahgd
@maho varchar(10)
as
begin
delete from HoGiaDinh where MaHoID = @maho
end;
go
--- Lấy danh sách khu phố
CREATE PROCEDURE sp_LayDSKhuPho
AS 
BEGIN 
SELECT * FROM KhuPho
END;
go
---Sửa khu phố
CREATE PROCEDURE sp_SuaKhuPho
		@MaKhuPhoID VARCHAR(10),
		@TenKhuPho CHAR(20),
		@MaPhuongID VARCHAR(10)
AS
BEGIN
    UPDATE KhuPho
    SET TenKhuPho = @TenKhuPho,
		MaPhuongID = @MaPhuongID    WHERE MaKhuPhoID = @MaKhuPhoID;
END;
go
---Xóa khu phố
CREATE PROCEDURE sp_XoaKhuPho
		@MaKhuPhoID VARCHAR(10)
AS
BEGIN
    DELETE FROM KhuPho
    WHERE MaKhuPhoID = @MaKhuPhoID;
END;
go
---Thêm danh sách khu phố
CREATE PROCEDURE sp_ThemKhuPho
		@MaKhuPhoID VARCHAR(10),
		@TenKhuPho CHAR(20),
		@MaPhuongID VARCHAR(10)
AS
BEGIN	
	INSERT INTO KhuPho(MaKhuPhoID,TenKhuPho,MaPhuongID) 
	VALUES (@MaKhuPhoID,@TenKhuPho,@MaPhuongID);
END;
go
create proc sp_timkhupho_theoma
@makp varchar (10)
as
begin
select * from KhuPho where MaKhuPhoID=@makp
end;
go
create proc sp_timkhupho_theoten
@tenkp char(20)
as
begin
select * from KhuPho where TenKhuPho=@tenkp
end;
go
create proc sp_LayDSPhuong
as
begin
select * from Phuong
end;
go
create proc sp_timphuong_ma
@maphuong varchar (10)
as
begin
select * from Phuong where MaPhuongID=@maphuong
end;
go
create proc sp_timphuong_ten
@tenphuong char (20)
as
begin
select * from Phuong where TenPhuong=@tenphuong
end;
go
CREATE proc sp_ThemPhuong
@MaPhuong varchar(10),
@TenPhuong char(20),
@maquan varchar(5)
as
begin
insert into Phuong(MaPhuongID,TenPhuong, MaQuanID)
values(@MaPhuong, @TenPhuong, @maquan);
end;
go
create proc sp_XoaPhuong
@maphuong varchar(10)
as
begin
delete from Phuong where MaPhuongID=@maphuong
end;
go
create proc sp_SuaPhuong
@maphuong varchar(10),
@tenphuong char (20),
@maquan varchar(5)
as
begin
update Phuong set TenPhuong=@tenphuong, MaQuanID = @maquan where MaPhuongID=@maphuong
end;
go
create proc sp_LayDSQuan
as
begin
select * from Quan
end;
go
create proc sp_timquan_ten
@ten char (20)
as
begin
select * from Quan where TenQuan=@ten
end;
go
create proc sp_timquan_ma
@ma varchar(5)
as
begin
select * from Quan where MaQuanID=@ma
end;
go
create proc sp_themquan
@ten char(20),
@ma varchar (5)
as
begin
insert into Quan(MaQuanID,TenQuan) values(@ma,@ten)
end;
go
CREATE PROC sp_TimMaQuan
@MaQuanID VARCHAR(5)
AS
BEGIN
SELECT * FROM Quan 
WHERE MaQuanID = @MaQuanID
END;
go
CREATE PROC sp_TimTenQuan
@TenQuan CHAR(20)
AS
BEGIN
SELECT * FROM Quan 
WHERE TenQuan = @TenQuan
END;
go
CREATE PROCEDURE sp_XoaQuan
    @MaQuanID VARCHAR(5),
    @TenQuan CHAR(20)
AS
BEGIN
    DELETE FROM Quan
    WHERE MaQuanID = @MaQuanID;
END;
go
CREATE PROCEDURE sp_SuaQuan
    @MaQuanID VARCHAR(5),
    @TenQuan CHAR(20)
AS
BEGIN
    UPDATE Quan
    SET TenQuan = @TenQuan
    WHERE MaQuanID = @MaQuanID;
END;
go

--TranThanhPhong Lam RP--
	--Rp--
	create proc nk_hgd(@cccd varchar(12))
as
begin
SELECT ThanhVien.CCCDID, ThanhVien.HoTen, ThanhVien.GioiTinh, ThanhVien.NamSinh, HoGiaDinh.MaHoID, KhuPho.TenKhuPho, KhuPho.MaKhuPhoID, Phuong.TenPhuong, Phuong.MaPhuongID, Quan.TenQuan, Quan.MaQuanID
From ThanhVien

JOIN HoGiaDinh ON ThanhVien.MaHoID = HoGiaDinh.MaHoID
JOIN KhuPho ON KhuPho.MaKhuPhoID = HoGiaDinh.MaKhuPhoID
JOIN Phuong ON Phuong.MaPhuongID = KhuPho.MaPhuongID
JOIN Quan ON Phuong.MaQuanID = Quan.MaQuanID
where ThanhVien.CCCDID=@cccd
end;
GO
exec nk_hgd '100000000002'
GO
--PROC ĐKKH--
create proc nk_nguoinam(@cccdnam varchar(12))
as
begin
SELECT ThanhVien.CCCDID, ThanhVien.HoTen, ThanhVien.GioiTinh, ThanhVien.NamSinh, HoGiaDinh.MaHoID, KhuPho.TenKhuPho, KhuPho.MaKhuPhoID, Phuong.TenPhuong, Phuong.MaPhuongID, Quan.TenQuan, Quan.MaQuanID
From ThanhVien

JOIN HoGiaDinh ON ThanhVien.MaHoID = HoGiaDinh.MaHoID
JOIN KhuPho ON KhuPho.MaKhuPhoID = HoGiaDinh.MaKhuPhoID
JOIN Phuong ON Phuong.MaPhuongID = KhuPho.MaPhuongID
JOIN Quan ON Phuong.MaQuanID = Quan.MaQuanID
where ThanhVien.CCCDID=@cccdnam and ThanhVien.GioiTinh Like N'Nam%' and DATEDIFF(YEAR,ThanhVien.NamSinh,GETDATE()) >= 20;
end;
GO
create proc nk_nguoinu(@cccdnu varchar(12))
as
begin
SELECT ThanhVien.CCCDID, ThanhVien.HoTen, ThanhVien.GioiTinh, ThanhVien.NamSinh, HoGiaDinh.MaHoID, KhuPho.TenKhuPho, KhuPho.MaKhuPhoID, Phuong.TenPhuong, Phuong.MaPhuongID, Quan.TenQuan, Quan.MaQuanID
From ThanhVien

JOIN HoGiaDinh ON ThanhVien.MaHoID = HoGiaDinh.MaHoID
JOIN KhuPho ON KhuPho.MaKhuPhoID = HoGiaDinh.MaKhuPhoID
JOIN Phuong ON Phuong.MaPhuongID = KhuPho.MaPhuongID
JOIN Quan ON Phuong.MaQuanID = Quan.MaQuanID
where ThanhVien.CCCDID=@cccdnu and ThanhVien.GioiTinh like N'Nu%' and DATEDIFF(YEAR,ThanhVien.NamSinh,GETDATE()) >= 18;
end;
----------------

---Stored Thông Tin Thành Phố
Go
create proc tt_thanhpho
as
begin 
SELECT 
    q.TenQuan AS Quan,
    COUNT(DISTINCT p.MaPhuongID) AS SoLuongPhuong,
    COUNT(DISTINCT kp.MaKhuPhoID) AS SoLuongKhuPho,
    COUNT(DISTINCT hg.MaHoID) AS SoLuongHoGiaDinh,
    COUNT(tv.CCCDID) AS SoLuongThanhVien
FROM 
    Quan q
 JOIN Phuong p ON q.MaQuanID = p.MaQuanID
 JOIN KhuPho kp ON p.MaPhuongID = kp.MaPhuongID
 JOIN HoGiaDinh hg ON kp.MaKhuPhoID = hg.MaKhuPhoID
 JOIN ThanhVien tv ON hg.MaHoID = tv.MaHoID
GROUP BY 
    q.TenQuan;
end;
--- thông kê độ tuổi 
create proc tk_DoTuoi
As
begin
SELECT 
    q.TenQuan AS Quan,
    CASE 
        WHEN YEAR(GETDATE()) - YEAR(tv.NamSinh) BETWEEN 0 AND 18 THEN N'Dưới 18'
        WHEN YEAR(GETDATE()) - YEAR(tv.NamSinh) BETWEEN 19 AND 30 THEN '19-30'
        WHEN YEAR(GETDATE()) - YEAR(tv.NamSinh) BETWEEN 31 AND 50 THEN '31-50'
        ELSE N'Trên 50' 
    END AS DoTuoi,
    COUNT(tv.CCCDID) AS SoLuongThanhVien
FROM 
    Quan q
 JOIN Phuong p ON q.MaQuanID = p.MaQuanID
 JOIN KhuPho kp ON p.MaPhuongID = kp.MaPhuongID
 JOIN HoGiaDinh hg ON kp.MaKhuPhoID = hg.MaKhuPhoID
 JOIN ThanhVien tv ON hg.MaHoID = tv.MaHoID
GROUP BY 
    q.TenQuan, 
    CASE 
        WHEN YEAR(GETDATE()) - YEAR(tv.NamSinh) BETWEEN 0 AND 18 THEN N'Dưới 18'
        WHEN YEAR(GETDATE()) - YEAR(tv.NamSinh) BETWEEN 19 AND 30 THEN '19-30'
        WHEN YEAR(GETDATE()) - YEAR(tv.NamSinh) BETWEEN 31 AND 50 THEN '31-50'
        ELSE N'Trên 50' 
    END;
	end;
	-- thông kê giới tính
	create proc tk_GioiTinh
	as
	begin
	SELECT 
    q.TenQuan AS Quan,
    tv.GioiTinh,
    COUNT(tv.CCCDID) AS SoLuongThanhVien
FROM 
    Quan q
 JOIN Phuong p ON q.MaQuanID = p.MaQuanID
 JOIN KhuPho kp ON p.MaPhuongID = kp.MaPhuongID
 JOIN HoGiaDinh hg ON kp.MaKhuPhoID = hg.MaKhuPhoID
 JOIN ThanhVien tv ON hg.MaHoID = tv.MaHoID
GROUP BY 
    q.TenQuan,
    tv.GioiTinh
	end;
	-- rp người trong độ tuổi nhập ngũ
	CREATE PROC TK_NguoiNhapNgu
	AS
	BEGIN
SELECT 
    tv.HoTen AS HoVaTen,
    tv.NamSinh AS NgaySinh,
    tv.MaHoID AS MaHoID,
    q.TenQuan AS Quan,
    p.TenPhuong AS Phuong,
	tv.GioiTinh As GioiTinh
FROM 
    ThanhVien tv
 JOIN HoGiaDinh hg ON tv.MaHoID = hg.MaHoID
 JOIN KhuPho kp ON hg.MaKhuPhoID = kp.MaKhuPhoID
 JOIN Phuong p ON kp.MaPhuongID = p.MaPhuongID
 JOIN Quan q ON p.MaQuanID = q.MaQuanID
WHERE 
    YEAR(GETDATE()) - YEAR(tv.NamSinh) BETWEEN 18 AND 27 AND tv.GioiTinh Like  'Nam%'
	END;