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

	SET @Query = '				;With LabourDirectReportList AS 				(					SELECT  
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
					WHERE 1=1 '			IF(IsNull(@From, '') != '' AND IsNull(@To, '') != '' )				BEGIN				print('Date')					--SET	@Query = @Query + ' AND (CONVERT(DATE,JGDC.OrderDate)) BETWEEN '''+@From+''' AND '''+@To+''''					SET @Query = @Query + ' AND (CONVERT(DATE,JGDC.OrderDate)) BETWEEN ''' + CONVERT(NVARCHAR, @From) + ''' AND ''' + CONVERT(NVARCHAR, @To) + ''''				END			IF(@IsClientWise = 1 AND @MainCompany != '' AND @ClientCompany != '')				BEGIN					SET	@Query = @Query + ' AND JGDC.CompanyName =  '''+@MainCompany+ ''' AND JGDC.ClientCompany =  '''+@ClientCompany+ ''''				END			ELSE IF (@IsClientWise = 2 AND @MainCompany != '' AND @ClientCompany != '' AND @SubClientCompany != '')				BEGIN					SET	@Query = @Query + ' AND JGDC.CompanyName =  '''+@MainCompany+ ''' AND JGDC.ClientCompany =  '''+@ClientCompany+ ''' AND JGDC.SubClientCompany =  '''+@SubClientCompany+ ''''				END				SET	@Query = @Query + ')					SELECT	CASE 					WHEN ROW_NUMBER() OVER(ORDER BY row_no) = 1 THEN (SELECT COUNT(*) FROM LabourDirectReportList)					ELSE 0 					END AS total_count,					* FROM	LabourDirectReportList '

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