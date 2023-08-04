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
	@EmployeePersonalRequired Bit = 0,
	@OrderMasterRequired Bit = 0,
	@FinishingProductRequired Bit = 0
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
			FROM	Productmodeltemp
			UNION SELECT top 1 0 Id,
					'' as code,
					'Select' as name,
					'' As proModel,
					'' as authorName,
					'' as productId,
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					Rm.RawMaterials as RawMaterial,
					'' As SubCom,
					'' As SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					'' As SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
						'' as RawMaterial,
						'' As SubCom,
						''as SubComName,
						'' As color,
						'' As RawName,
						'' As RawType,
						0 AS Qty,
						0 AS TotalQty,
						0 As TotalWt,
						'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
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
					'' as RawMaterial,
					'' As SubCom,
					''as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
			FROM	SubClientBankInfo

		END
		IF(@EmployeePersonalRequired = 1) 
		BEGIN
			SELECT	EP.Id,
					EP.EmployeeCode as code,
					EP.EmployeeName as name,
					CMI.ComName As proModel,
					EP.ContractorName as authorName,
					CM.ComCname as productId,
					EP.ClientName as RawMaterial,
					SCM.SubComName as SubCom,
					EP.SubCompanyName as SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
			FROM EmployeePersonal EP
			left join CompanyMasterInfo CMI on CMI.Id = EP.MasterCompanyId
			left join ClientMaster CM on CM.Id = EP.ClientCompanyId
			left join SubClientMaster SCM on SCM.Id = EP.SubCompanyId
		END
		IF(@OrderMasterRequired = 1) 
		BEGIN
			SELECT	OM.Id,
					OM.Orderno as code,
					OM.Orderdate as name,
					CMR.Code as authorName,
					CMR.Name As proModel,
					OM.Productmodel as productId,
					OM.Productcode as RawMaterial,
					PM.Productmodel As SubCom,
					Om.Productsize As SubComName,
					CCM.Colournname As color,
					OM.RawmaterialId As RawName,
					OM.RawType As RawType,
					OM.Quantity AS Qty,
					OM.TotalRaw AS TotalQty,
					OM.TotalWt As TotalWt,
					OM.WagesforEmp As WagesEmp
			FROM	OrderMaster OM
			left join CustomerMaster CMR on CMR.Id = OM.CustomerId
			left join Productmodeltemp PM on PM.Id = OM.ProductNameId
			left join ColourMaster CCM on CCM.Id = OM.ColorId
		END
		IF(@FinishingProductRequired = 1) 
		BEGIN
			SELECT	FPM.Id,
					PMT.Productmodel as code,
					FPM.Productmodel as name,
					FPM.Productcode as authorName,
					FPM.Productsize As proModel,
					FPM.WagesforProduct as productId,
					'' as RawMaterial,
					'' As SubCom,
					'' As SubComName,
					'' As color,
					'' As RawName,
					'' As RawType,
					0 AS Qty,
					0 AS TotalQty,
					0 As TotalWt,
					'' As WagesEmp
			FROM FinishingProductModel FPM
			left join Productmodeltemp PMT  on PMT.Id = FPM.ProductNameId
		END
END
