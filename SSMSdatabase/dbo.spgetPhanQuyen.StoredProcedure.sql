USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spgetPhanQuyen]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


						/*----- BANG PHANQUYEN-----*/

/*--------- Hien thi thong tin PHANQUYEN ----------------*/
create procedure [dbo].[spgetPhanQuyen]
as
Begin
	select pq.IdTaiKhoan as 'Id Tài Khoản',MatKhau as 'Mật Khẩu',nv.IdNhanVien as 'Id Nhân Viên',Ten as 'Họ Tên'
	from PhanQuyen pq,NhanVien nv
	where pq.IdNhanVien = nv.IdNhanVien
End
GO
