USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spgetKhachHang]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop  procedure spSearchNVByTenNV

						/*-- BANG KHACH HANG -- */
						
/*--------- Hien thi thong tin KhachHang ----------------*/
CREATE procedure [dbo].[spgetKhachHang]
as
Begin
	select IdKhachHang, TenKhachHang,  DienThoai, Email, ChiTieu
	from Khachhang
End
GO
