USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spgetNhanVienByIdNhanVien]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spgetNhanVien
/*----------- Hien thi thong tin NhanVien bang IdNhanVien --------------*/
create procedure [dbo].[spgetNhanVienByIdNhanVien]
(
	@IdNhanVien varchar(10)
)
as
Begin
	select * from NhanVien where IdNhanVien =@IdNhanVien
End

GO
