USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spgetDangNhap]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetDangNhap]
as
Begin
		 select IdDangNhap, MatKhau, TrangThai
		 from DangNhap		 
End
GO
