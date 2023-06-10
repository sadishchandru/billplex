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
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateRawMaterial]
	@Id int = 0,
	@RawMaterials varchar(100)='',
	@RawMaterialType varchar(100)='',
	@RawMaterialStock varchar(100)=''
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO[dbo].[RawMaterial]
		(
			RawMaterials,
			RawMaterialType,
			RawMaterialStock
		) VALUES
		(
			@RawMaterials,
			@RawMaterialType,
			@RawMaterialStock
		)

		SET @ResultMessage = 'RawMaterial Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE RawMaterial 
		SET	
		[Id] = @Id,
		[RawMaterials] = @RawMaterials,
		[RawMaterialType] = @RawMaterialType,
		[RawMaterialStock] = @RawMaterialStock
		WHERE Id = @Id
		SET @ResultMessage = 'RawMaterial Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
