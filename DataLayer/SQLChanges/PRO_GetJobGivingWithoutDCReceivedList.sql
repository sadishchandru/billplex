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
-- EXEC [dbo].PRO_GetJobGivingWithoutDCReceivedList
CREATE OR ALTER PROCEDURE [dbo].PRO_GetJobGivingWithoutDCReceivedList
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';

	SELECT
		JGDC.Id,
		EP.EmployeeCode,
		JGDC.EmployeeName,
		JGDC.CompanyName,
		JGDC.ClientCompany,
		JGDC.SubClientCompany,
		OM.Orderno AS OrderNo,
		JGDC.[Date],
		JGDC.Orderdate,
		JGDC.CustomerCode,
		JGDC.CustomerName,
		JGDC.ModelName,
		JGDC.ModelCode,
		JGDC.ProductSize,
		JGDC.RawMaterial,
		JGDC.QuantityPiece,
		JGDC.WeightKg,
		JGDC.Excess,
		JGDC.Color,
		JGDC.[Type],
		JGDC.AvlQty,
		JGDC.Shortage,
		JGDC.orderQty,
		JGDC.orderWt,
		JGDC.ClientName,
		JGDC.TotalQty,
		JGDC.TotalWt,
		JGDC.subContractor,
		JGDC.Director,
		JGDC.PendingQty,
		JGDC.received,
		JGDC.Wages,
		JGDC.CurrentWt,
		JGDC.ReceivingDate,
		JGDC.BDays,
		JGDC.ADays,
		JGDC.BalanceWt,
		JGDC.Deduction,
		JGDC.conveyance,
		JGDC.incentive,
		JGDC.NetAmt,
		JGDC.TotalAmt
	FROM JobGivingWithoutDC JGDC
	LEFT JOIN EmployeePersonal EP ON EP.Id = JGDC.EmployeeCode
	LEFT JOIN OrderMaster OM ON OM.Id = JGDC.OrderNo
	WHERE CONVERT(INT, TotalQty) = (Select SUM(CONVERT(INT, received)) FROM JobGivingWithoutDC e where e.OrderNo = JGDC.OrderNo);
END