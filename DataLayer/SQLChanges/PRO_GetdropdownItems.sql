USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetdropdownItems]    Script Date: 6/22/2023 5:26:53 PM ******/
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
-- EXEC PRO_GetdropdownItems @MasterCompanyRequired = 1, @ClientMasterBankRequired= 1
ALTER   PROCEDURE [dbo].[PRO_GetdropdownItems]
	@MasterCompanyRequired BIT = 0,
	@ClientCompanyRequired  BIT = 0,
	@SUbClientCompanyRequired BIT = 0,
	@RawMaterialRequired BIT =0,
	@ProductModelRequired BIT =0,
	@ProductMasterRequired BIT =0,
	@SizeMasterRequired BIT =0,
	@CustomerMasterRequired Bit = 0,
	@ColorMasterRequired Bit = 0,
	@MasterBankRequired Bit = 0,
	@ClientMasterBankRequired Bit = 0,
	@SubClientBankRequired Bit = 0,
	@EmployeePersonalRequired Bit = 0
AS 
BEGIN
    SET NOCOUNT ON;

	IF(@MasterCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					ComCcode as code,
					ComName as name,
					CAuthorName as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	[dbo].[CompanyMasterInfo]
            UNION
			SELECT	top 1 0 Id,
					'' as code,
					'Select' as name,
					'' as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	[dbo].[CompanyMasterInfo]
			
		END

	IF(@ClientCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					ComCcode as code,
					ComCname as name,
					ComCPname as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	ClientMaster
			UNION
			SELECT top 1 0 Id,
					'' as code,
					'Select' as name,
					'Select' as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	ClientMaster
		END

	IF(@SubClientCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					SubComCode as code,
					SubComName as name,
					AuthorName as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	SubClientMaster
		END
	IF(@RawMaterialRequired = 1) 
		BEGIN
			SELECT	Id,
					RawMaterialType as code,
					RawMaterials as name,
					RawMaterialStock as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	RawMaterial
		END

	IF(@ProductModelRequired = 1) 
		BEGIN
			SELECT	Id,
					'' as code,
					Productmodel as name,
					'' As proModel,
					'' as authorName,
					'' as productId,
					'' as RawMaterial
			FROM	Productmodeltemp
			UNION SELECT top 1 0 Id,
					'' as code,
					'Select' as name,
					'' As proModel,
					'' as authorName,
					'' as productId,
					'' as RawMaterial
			FROM	Productmodeltemp
		END

	IF(@ProductMasterRequired = 1) 
		BEGIN
			SELECT	pm.Id,
					pm.productCode as code,
					pm.ProductSize as name,
					pm.ProductModel As proModel,
					pm.WagesforItem as authorName,
					pmt.Productmodel as productId,
					Rm.RawMaterials as RawMaterial
			FROM	[dbo].[ProductModel] pm
			left join Productmodeltemp pmt on pmt.Id = pm.ProductId
			left join RawMaterial Rm on Rm.Id = pm.RawMaterialId
		END
	IF(@SizeMasterRequired = 1) 
		BEGIN
			SELECT	Id,
					Sizename as name,
					'' as code,
					'' as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM SizeMaster
		END

	IF(@CustomerMasterRequired = 1) 
			BEGIN
				SELECT	Id,
						Code as code,
						Name as name,
						'' As proModel,
						'' as authorName,
						'' As productId,
						'' as RawMaterial
				FROM CustomerMaster
			END
	IF(@ColorMasterRequired = 1) 
		BEGIN
			SELECT	Id,
					'' as code,
					Colournname as name,
					'' As proModel,
					'' as authorName,
					'' As productId,
					'' as RawMaterial
			FROM	ColourMaster
		END

	IF(@MasterBankRequired = 1) 
		BEGIN
			SELECT	Id,
					MainCompanyId as code,
					BankName as name,
					'' as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	MainBankInfo
		END

	IF(@ClientMasterBankRequired = 1) 
		BEGIN
			SELECT	Id,
					ClientCompanyId as code,
					BankName as name,
					'' as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	ClientBankInfo
		END

		IF(@SubClientBankRequired = 1) 
		BEGIN
			SELECT	Id,
					ClientCompanyId as code,
					BankName as name,
					'' as authorName,
					'' As proModel,
					'' as productId,
					'' as RawMaterial
			FROM	SubClientBankInfo

		END
		IF(@EmployeePersonalRequired = 1) 
		BEGIN
			SELECT	Id,
					EmployeeCode as code,
					EmployeeName as name,
					'' As proModel,
					'' as authorName,
					'' as productId,
					'' as RawMaterial
			FROM EmployeePersonal
		END

END
