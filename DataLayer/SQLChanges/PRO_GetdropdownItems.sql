SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan
-- Create date: 5th June
-- Description:	Get dropdown items
-- =============================================
-- EXEC PRO_GetdropdownItems @MasterCompanyRequired =1,@ClientCompanyRequired =1,@RawMaterialRequest = 1,@ProductModelRequest = 1,@ProductMasterRequest = 1
-- EXEC PRO_GetdropdownItems @ProductMasterRequest = 1
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetdropdownItems]
	@MasterCompanyRequired BIT = 0,
	@ClientCompanyRequired  BIT = 0,
	@SUbClientCompanyRequired BIT = 0,
	@ProductMasterRequest BIT =0,
	@ProductModelRequest BIT =0,
	@RawMaterialRequired BIT =0,
	@SizeMasterRequest BIT =0,
	@ColorMasterRequired Bit = 0,
	@CustomerMasterRequired Bit = 0
AS 
BEGIN
    SET NOCOUNT ON;

	IF(@MasterCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					ComCcode as code,
					ComName as name,
					CAuthorName as authorName
			FROM	[dbo].[CompanyMasterInfo]
		END

	IF(@ClientCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					ComCcode as code,
					ComCname as name,
					ComCPname as authorName
			FROM	ClientMaster
		END

	IF(@SubClientCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					SubComCode as code,
					SubComName as name,
					AuthorName as authorName
			FROM	SubClientMaster
		END
	IF(@RawMaterialRequired = 1) 
		BEGIN
			SELECT	Id,
					RawMaterialType as code,
					RawMaterials as name,
					RawMaterialStock as authorName
			FROM	RawMaterial
		END

	IF(@ProductModelRequest = 1) 
		BEGIN
			SELECT	Id,
					'' as code,
					Productmodel as name,
					'' as authorName
			FROM	Productmodeltemp
		END

	IF(@ProductMasterRequest = 1) 
		BEGIN
			SELECT	Id,
					productCode as code,
					ProductSize as name,
					[ProductModel] As ModelName,
					WagesforItem as authorName
			FROM	[dbo].[ProductModel]
		END
	IF(@SizeMasterRequest = 1) 
		BEGIN
			SELECT	Id,
					Sizename as name,
					'' as code,
					'' as authorName
			FROM SizeMaster
		END

	IF(@CustomerMasterRequired = 1) 
			BEGIN
				SELECT	Id,
						Code as code,
						Name as name,
						'' as authorName
				FROM	CustomerMaster
			END
	IF(@ColorMasterRequired = 1) 
		BEGIN
			SELECT	Id,
					'' as code,
					Colournname as name,
					'' as authorName
			FROM	ColourMaster
		END
END
GO
