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
@From DATE = null
,@To DATE = null
,@IsClientWise int = 0
,@MainCompany VARCHAR(50) = ''
,@ClientCompany VARCHAR(50) = ''
,@SubClientCompany VARCHAR(50) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from

	DECLARE @Query NVARCHAR(MAX) = '';

	SET @Query = '
					JGDC.Id
					,ModelName
					,ProductName
					,JGDC.ProductSize
					,QuantityPiece
					,WagesforEmp
					,[TotalQty]
					,NetAmt
					,TotalAmt
					,ROW_NUMBER() OVER(ORDER BY JGDC.OrderDate DESC) AS row_no
					FROM JobGivingWithoutDC JGDC
					LEFT JOIN EmployeePersonal EP on EP.Id = JGDC.EmployeeCode
					LEFT JOIN OrderMaster OM on OM.Id = JGDC.OrderNo
					WHERE 1=1 '

				PRINT(@QUERY);
		EXEC (@QUERY);
END

/*
EXEC [dbo].[PRO_GetDirectLabourBill]
    --@From = '2023-08-14',
    --@To = '2023-08-14',
    @IsClientWise = 2,
    @MainCompany = 'ACOMPANY',
    @ClientCompany = 'ClientCOmpany',
    @SubClientCompany = 'SUBCLIENTCOMPANY';
*/