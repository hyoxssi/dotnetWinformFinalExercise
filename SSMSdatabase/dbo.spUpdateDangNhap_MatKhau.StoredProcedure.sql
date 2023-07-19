USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateDangNhap_MatKhau]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateDangNhap_MatKhau]
(
			@IdDangNhap	varchar(100),
			@MatKhau		    varchar(250)				
)
as
Begin
		   update DangNhap set MatKhau=@MatKhau
		   where IdDangNhap = @IdDangNhap
End

/*---------------- Xoa DangNhap -------------------------*/
GO
