USE [BillPlex]
GO
--****** Object:  StoredProcedure [dbo].[PRO_UpdateCompanyProfileInfo]    Script Date: 01-06-2023 14:27:01 ******-
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Company Profile Info
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateProductModel]
@Id  BIGINT = 0,
@RawmaterialTypeId int= 0, 
@RawMaterialId  int= 0,
@ProductId int= 0,	
@ProductCode  varchar(100)= '',
@ProductModel  varchar(100)= '',
@ProductSize  varchar(100)= '',
@RawMaterialStock  varchar(200)= '',
@ReqRawMaterial  varchar(100)= '',
@WagesforItem  varchar(100)= '',
@Date  date  = Null 
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO dbo.ProductModel
		(
			RawmaterialTypeId,
			RawMaterialId,
			ProductId,
			ProductCode,
			ProductModel,
			ProductSize,
			RawMaterialStock,
			ReqRawMaterial,
			WagesforItem,
			Date
		) VALUES
		(
			@RawmaterialTypeId,
			@RawMaterialId,
			@ProductId,
			@ProductCode,
			@ProductModel,
			@ProductSize,
			@RawMaterialStock,
			@ReqRawMaterial,
			@WagesforItem,
			@Date
		)

		SET @ResultMessage = 'Product Model Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE dbo.ProductModel 
		SET	
			[RawmaterialTypeId]= @RawmaterialTypeId,
			[RawMaterialId]=@RawMaterialId,
			[ProductId]=@ProductId,
			[ProductCode]=@ProductCode,
			[ProductModel]=@ProductModel,
			[ProductSize]=@ProductSize,
			[RawMaterialStock]=@RawMaterialStock,
			[ReqRawMaterial]=@ReqRawMaterial,
			[WagesforItem]=@WagesforItem,
			[Date]=@Date
		WHERE Id = @Id

		
		SET @ResultMessage = 'Product Model Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END