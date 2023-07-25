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
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetJobGivingWithoutDC]
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
					--,TotalQty
					--,TotalWt
					,Shortage
					,orderQty
					,orderWt
					,JGDC.[ClientName]
					,[TotalQty]
					,JGDC.[TotalWt]
					,[subContractor]
					,[Director]
					,[PendingQty]
					,[received]
					,[Wages]
					,[CurrentWt]
					,[ReceivingDate]
					,[BDays]
					,[ADays]
					,[BalanceWt]
					FROM JobGivingWithoutDC JGDC
					left join EmployeePersonal EP on EP.Id = JGDC.EmployeeCode
					left join OrderMaster OM on OM.Id = JGDC.OrderNo
					WHERE ISNULL(isDelete, 0) = 0;
END
