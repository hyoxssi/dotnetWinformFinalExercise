USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteDangNhapByIdDangNhap]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteDangNhapByIdDangNhap]
(
		 @IdDangNhap	varchar(100)							
)
as
Begin
		 delete from DangNhap 
		 where IdDangNhap =@IdDangNhap
End
/*----------- Tim kiem thong tin theo IdDangNhap ----------*/
GO
