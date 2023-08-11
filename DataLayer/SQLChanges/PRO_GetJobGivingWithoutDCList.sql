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
-- exec PRO_GetJobGivingWithoutDCList  
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetJobGivingWithoutDCList]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;

		WITH JobGiving AS (
				SELECT  OrderNo
						,Id
						,EmployeeCode
						,EmployeeName
						,CompanyName
						,Director
						,ClientCompany
						,ClientName
						,SubClientCompany
						,subContractor
						,Date
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
						,ROW_NUMBER() OVER (PARTITION BY OrderNo ORDER BY OrderNo ASC) AS RowNum
						,PendingQty
						,received
						,Wages
						,CurrentWt
						,ReceivingDate
						,BDays
						,ADays
						,BalanceWt
						,Deduction
						,conveyance
						,incentive
						,NetAmt
						,TotalAmt
						,isDelete
					FROM JobGivingWithoutDC	

			)
				SELECT 
						OM.OrderNo
						,JG.Id
						,EP.EmployeeCode
						,JG.EmployeeName
						,CompanyName
						,Director
						,ClientCompany
						,JG.ClientName
						,SubClientCompany
						,subContractor
						,Date
						,JG.OrderDate
						,CustomerCode
						,CustomerName
						,ModelName
						,ModelCode
						,ProductName
						,JG.ProductSize
						,Color
						,RawMaterial
						,Type
						,CAST(QuantityPiece AS INT) as QuantityPiece
						,WeightKg
						,JG.AvlQty
						,Excess
						,TotalQty
						,JG.TotalWt
						,Shortage
						,orderQty
						,orderWt
						,PendingQty
						,received
						,Wages
						,CurrentWt
						,ReceivingDate
						,BDays
						,ADays
						,BalanceWt
						,Deduction
						,conveyance
						,incentive
						,NetAmt
						,TotalAmt
			FROM JobGiving JG
			left join EmployeePersonal EP on EP.Id = JG.EmployeeCode
			left join OrderMaster OM on OM.Id = JG.OrderNo
			WHERE RowNum = 1
			AND ISNULL(isDelete, 0) = 0;

END
