USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spgetSanPhamByIdSanPham]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spgetSanPhamByIdSanPham]
(
	@IdSanPham varchar(10)
)
as
Begin
	select * from SanPham where IdSanPham =@IdSanPham
End
GO
