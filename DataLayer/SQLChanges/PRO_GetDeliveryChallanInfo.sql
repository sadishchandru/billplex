SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--EXEC PRO_GetMasterCompanyProfileInfo
CREATE OR ALTER PROCEDURE PRO_GetDeliveryChallanInfo
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	--DECLARE @StartRowIndex NVARCHAR(10) = CONVERT(NVARCHAR(10),((@PageNo - 1) * @PageSize) + 1) 
	--DECLARE @MaximumRows NVARCHAR(10) = CONVERT(NVARCHAR(10),@PageNo * @PageSize)	
    
	
	
			SELECT	Id
					,CompanyMasterId
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
			FROM	DeliveryChallanProfileInfo DCPI
			

END
GO
