USE [dotnetPetShopDB]
GO
/****** Object:  StoredProcedure [dbo].[spDeletePhanQuyen]    Script Date: 7/19/2023 12:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spUpdatePhanQuyen
/*-------------------- Delete PHANQUYEN -------------------*/
create procedure [dbo].[spDeletePhanQuyen]
(
	@IdTaiKhoan			varchar (10)
)
as
begin
	Delete PhanQuyen where IdTaiKhoan = @IdTaiKhoan	 
end
GO
