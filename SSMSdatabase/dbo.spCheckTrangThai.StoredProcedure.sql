USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spCheckTrangThai]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------------ Kiem tra DangNhap -----------------------*/
create procedure [dbo].[spCheckTrangThai]
(
		@IdDangNhap		varchar(100)
)
	as
	Begin
            select	TrangThai from DangNhap
            where		IdDangNhap= @IdDangNhap			
	End
GO
