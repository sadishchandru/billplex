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
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetJobReceived]
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';

			SELECT  Id
					,EmployeeCode
					,EmployeeName
					,CustomerName
					,RawMaterialName
					,Quantity
					,Wages
					,PendingQty
					,ModelName
					,Type
					,Weight
					,CurrentWt
					,RcvdQty
					,ReceivingDate
					,ProductModel
					,ProductCode
					,ProductSize
					,ProductColor
					,IncentiveApplicable
					,BeforeDays
					,AfterDays
					,BalanceWeight
					,Conveyance
					,Deduction
					,Incentive
					,Total
					,NetAmt
					FROM JobReceived
END
