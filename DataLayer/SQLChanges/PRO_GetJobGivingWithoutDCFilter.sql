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
-- EXEC PRO_GetJobGivingWithoutDCFilter  @Id = '2019'
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetJobGivingWithoutDCFilter]
@Id varchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';

		IF(@Id = '')
			BEGIN 
				
				SELECT  JG.Id
					,EmployeeCode
					,EmployeeName
					,CompanyName
					,Director
					,ClientCompany
					,ClientName
					,SubClientCompany
					,subContractor
					,Date
					,O.Orderno AS OrderNo
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
					FROM JobGivingWithoutDC JG
					LEFT JOIN OrderMaster O ON O.Id = JG.OrderNo
					Where ISNULL(isDelete, 0) = 0
			END
		ELSE
			BEGIN 
				SELECT  JG.Id
					,EmployeeCode
					,EmployeeName
					,CompanyName
					,Director
					,ClientCompany
					,ClientName
					,SubClientCompany
					,subContractor
					,Date
					,O.Orderno AS OrderNo
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
					FROM JobGivingWithoutDC JG
					LEFT JOIN OrderMaster O ON O.Id = JG.OrderNo
					where JG.OrderNo = @Id
					AND ISNULL(isDelete, 0) = 0
			END
			
END
