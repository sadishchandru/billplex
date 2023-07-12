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

			SELECT  Id
					,EmployeeCode
					,EmployeeName
					,CompanyName
					,ClientCompany
					,SubClientCompany
					,OrderNo
					,Date
					,OrderDate
					,CustomerCode
					,CustomerName
					,ModelName
					,ModelCode
					,ProductName
					,ProductSize
					,RawMaterial
					,QuantityPiece
					,WeightKg
					,Excess
					,Color
					,Type
					,AvlQty
					,TotalQty
					,TotalWt
					,Shortage
					,orderQty
					,orderWt
					FROM JobGivingWithoutDC
END
