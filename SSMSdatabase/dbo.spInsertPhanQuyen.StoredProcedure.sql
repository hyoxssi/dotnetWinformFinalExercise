USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spInsertPhanQuyen]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --drop proc spgetPhanQuyenByIdTaiKhoan
/*---------------- Insert PHANQUYEN -------------------*/
create procedure [dbo].[spInsertPhanQuyen]
( 
		@IdTaiKhoan			varchar (10),
		@MatKhau				varchar(200),
		@IdNhanVien			varchar(10)
)
as
Begin
	insert into PhanQuyen
	values(@IdTaiKhoan,@MatKhau,@IdNhanVien )
End
GO
