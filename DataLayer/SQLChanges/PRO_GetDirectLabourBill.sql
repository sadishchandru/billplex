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
-- Exec [PRO_GetDirectLabourBill]
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetDirectLabourBill]
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
			SELECT  JGDC.Id
					,ModelName
					,ProductName
					,JGDC.ProductSize
					,QuantityPiece
					,WagesforEmp
					,[TotalQty]
					,NetAmt
					,TotalAmt
					FROM JobGivingWithoutDC JGDC
					LEFT JOIN EmployeePersonal EP on EP.Id = JGDC.EmployeeCode
					LEFT JOIN OrderMaster OM on OM.Id = JGDC.OrderNo
END
