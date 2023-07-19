USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spSearchNVByIdNV]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*--------------TIM KIEM NHAN VIEN THEO IDNHANVIEN -----------*/
create procedure [dbo].[spSearchNVByIdNV]
(
	@IdNhanVien varchar (10)
)
as
Begin
	select *from NhanVien where IdNhanVien like  '%'+@IdNhanVien+'%'
End 
GO
