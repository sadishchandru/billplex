SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Company Profile Info
-- =============================================
CREATE OR ALTER PROCEDURE PRO_UpdateDeliveryChallanInfo
@Id BIGINT =0,
@CompanyMasterId BIGINT = 0,
@Director Varchar(100) = 0,
@ClientCompanyId BIGINT =0,
@Contractor Varchar(100) = 0,
@SubclientCompanyId BIGINT =0,
@Subcontractor Varchar(100) =0,
@CustomerCode Varchar(100) =0,
@CustomerName Varchar(100) = 0,
@OrderNo INT = 0,
@ModelCode Varchar(100) = '',
@ModelName Varchar(100) = '',
@ProductName Varchar(100) = '',
@RawMaterial Varchar(100) = '',
@RawType Varchar(100) = '',
@ProductSize Varchar(100) = '',
@OrderDate Date = NULL,
@ColourName Int = 0,
@Quantity Int = 0,
@Weight Int = 0,
@Excess Int = 0,
@AvlQty Varchar(100) = '',
@Shortage Int = 0,
@DcNo Int = 0,
@DcDate Date = NULL,
@OrderQty Int = 0,
@OrderWeight Int = 0     
	
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage Varchar(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO DeliveryChallanProfileInfo
		(
			CompanyMasterId
			,Director
			,ClientCompanyId
			,Contractor
			,SubclientCompanyId
			,Subcontractor
			,CustomerCode
			,CustomerName
			,OrderNo
			,ModelCode
			,ModelName
			,ProductName
			,RawMaterial
			,RawType
			,ProductSize
			,OrderDate
			,ColourName
			,Quantity
			,Weight
			,Excess
			,AvlQty
			,Shortage
			,DcNo
			,DcDate
			,OrderQty
			,OrderWeight
		) VALUES
		(
			@CompanyMasterId,
			@Director,
			@ClientCompanyId,
			@Contractor,
			@SubclientCompanyId,
			@Subcontractor,
			@CustomerCode,
			@CustomerName,
			@OrderNo,
			@ModelCode,
			@ModelName,
			@ProductName,
			@RawMaterial,
			@RawType,
			@ProductSize,
			@OrderDate,
			@ColourName,
			@Quantity,
			@Weight,
			@Excess,
			@AvlQty,
			@Shortage,
			@DcNo,
			@DcDate,
			@OrderQty,
			@OrderWeight
		)

		SET @ResultMessage = 'Challan Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE DeliveryChallanProfileInfo 
		SET
			CompanyMasterId = @CompanyMasterId,
			Director = @Director,
			ClientCompanyId = @ClientCompanyId,
			Contractor = @Contractor,
			SubclientCompanyId = @SubclientCompanyId,
			Subcontractor = @Subcontractor,
			CustomerCode = @CustomerCode,
			CustomerName = @CustomerName,
			OrderNo = @OrderNo,
			ModelCode = @ModelCode,
			ModelName = @ModelName,
			ProductName = @ProductName,
			RawMaterial = @RawMaterial,
			RawType = @RawType,
			ProductSize = @ProductSize,
			OrderDate = @OrderDate,
			ColourName = @ColourName,
			Quantity = @Quantity,
			Weight = @Weight,
			Excess = @Excess,
			AvlQty = @AvlQty,
			Shortage = @Shortage,
			DcNo = @DcNo,
			DcDate = @DcDate,
			OrderQty = @OrderQty,
			OrderWeight = @OrderWeight
		WHERE Id = @Id

		
		SET @ResultMessage = 'Challan Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo

END
GO
