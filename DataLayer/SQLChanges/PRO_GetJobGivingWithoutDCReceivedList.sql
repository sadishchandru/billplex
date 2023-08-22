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
    CompanyName,
    ClientCompany,
    SubClientCompany,
    Om.Orderno AS OrderNo,
    Date,
    JGDC.Orderdate,
    CustomerCode,
    CustomerName,
    ModelName,
    ModelCode,
    JGDC.ProductSize,
    RawMaterial,
    QuantityPiece,
    WeightKg,
    Excess,
    Color,
    Type,
    JGDC.AvlQty,
    Shortage,
    orderQty,
    orderWt,
    JGDC.ClientName,
    TotalQty,
    JGDC.TotalWt,
    JGDC.subContractor,
    JGDC.Director,
    PendingQty,
    received,
    Wages,
    CurrentWt,
    ReceivingDate,
    BDays,
    ADays,
    BalanceWt,
    Deduction,
    conveyance,
    incentive,
    NetAmt,
    TotalAmt
FROM JobGivingWithoutDC JGDC
LEFT JOIN EmployeePersonal EP ON EP.Id = JGDC.EmployeeCode
LEFT JOIN OrderMaster OM ON OM.Id = JGDC.OrderNo
WHERE CONVERT(INT, TotalQty) = (Select SUM(CONVERT(INT, received)) FROM JobGivingWithoutDC e where e.OrderNo = JGDC.OrderNo);
END