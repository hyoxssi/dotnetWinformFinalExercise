USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spgetKhachHangByIdKhachHang]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*----------- Hien thi thong tin KhachHang bang IdKhachHang --------------*/
create procedure [dbo].[spgetKhachHangByIdKhachHang]
(
	@IdKhachHang		varchar (10)
)
as
begin
	select * from Khachhang where IdKhachHang = @IdKhachHang
end
GO
