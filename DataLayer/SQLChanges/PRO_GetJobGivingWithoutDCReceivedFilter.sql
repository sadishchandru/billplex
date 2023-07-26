USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetClientCompanyProfileInfo]    Script Date: 05/06/2023 14:36:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <07/26/2023>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].PRO_GetJobGivingWithoutDCReceivedFilter
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';

	SELECT  JGDC.Id
			,EP.EmployeeCode
			,JGDC.EmployeeName
			,CompanyName
			,ClientCompany
			,SubClientCompany
			,JGDC.OrderNo
			,Om.Orderno
			,Date
			,JGDC.Orderdate
			,CustomerCode
			,CustomerName
			,ModelName
			,ModelCode
			,ProductName
			,JGDC.ProductSize
			,RawMaterial
			,QuantityPiece
			,WeightKg
			,Excess
			,Color
			,Type
			,JGDC.AvlQty
			,Shortage
			,orderQty
			,orderWt
			,JGDC.ClientName
			,TotalQty
			,JGDC.TotalWt
			,subContractor
			,Director
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
			FROM JobGivingWithoutDC JGDC
			left join EmployeePersonal EP on EP.Id = JGDC.EmployeeCode
			left join OrderMaster OM on OM.Id = JGDC.OrderNo
			where ISNULL(TotalQty, 0) > 0 ;
END