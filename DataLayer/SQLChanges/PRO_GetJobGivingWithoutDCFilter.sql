USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetClientCompanyProfileInfo]    Script Date: 27/06/2023 19:55:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
-- exec PRO_GetJobGivingWithoutDCFilter  @Id = '2019'
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetJobGivingWithoutDCFilter]
@Id varchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';

		IF(@Id = '')
			BEGIN 
				
				SELECT  Id
					,EmployeeCode
					,EmployeeName
					,CompanyName
					,Director
					,ClientCompany
					,ClientName
					,SubClientCompany
					,subContractor
					,Date
					,OrderNo
					,OrderDate
					,CustomerCode
					,CustomerName
					,ModelName
					,ModelCode
					,ProductName
					,ProductSize
					,Color
					,RawMaterial
					,Type
					,CAST(QuantityPiece AS INT) as QuantityPiece
					,WeightKg
					,AvlQty
					,Excess
					,TotalQty
					,TotalWt
					,Shortage
					,orderQty
					,orderWt
					FROM JobGivingWithoutDC
					Where ISNULL(isDelete, 0) = 0
			END
		ELSE
			BEGIN 
				SELECT  Id
					,EmployeeCode
					,EmployeeName
					,CompanyName
					,Director
					,ClientCompany
					,ClientName
					,SubClientCompany
					,subContractor
					,Date
					,OrderNo
					,OrderDate
					,CustomerCode
					,CustomerName
					,ModelName
					,ModelCode
					,ProductName
					,ProductSize
					,Color
					,RawMaterial
					,Type
					,CAST(QuantityPiece AS INT) as QuantityPiece
					,WeightKg
					,AvlQty
					,Excess
					,TotalQty
					,TotalWt
					,Shortage
					,orderQty
					,orderWt
					FROM JobGivingWithoutDC
					where OrderNo = @Id
					AND ISNULL(isDelete, 0) = 0
			END
			
END
