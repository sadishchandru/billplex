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
@From DATE = NULL
,@To DATE = NULL
,@IsClientWise INT = 0
,@MainCompany VARCHAR(50) = ''
,@ClientCompany VARCHAR(50) = ''
,@SubClientCompany VARCHAR(50) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from

	DECLARE @Query NVARCHAR(MAX) = '';

	SET @Query = '				;With LabourDirectReportList AS 				(					SELECT  
						JGDC.Id,
						JGDC.ModelName,
						JGDC.ProductName,
						JGDC.ProductSize,
						JGDC.QuantityPiece,
						OM.WagesforEmp,
						JGDC.[TotalQty],
						JGDC.NetAmt,
						JGDC.TotalAmt,
						JGDC.Deduction,
						JGDC.conveyance As Conveyance,
						JGDC.incentive As Incentive,
						ROW_NUMBER() OVER(ORDER BY JGDC.OrderDate DESC) AS row_no
					FROM JobGivingWithoutDC JGDC
					LEFT JOIN EmployeePersonal EP on EP.Id = JGDC.EmployeeCode
					LEFT JOIN OrderMaster OM on OM.Id = JGDC.OrderNo
					WHERE received IS NOT NULL AND received <> '''' 
						  AND TotalQty IS NOT NULL AND TotalQty <> '''' 
						  AND received = TotalQty'			IF(IsNull(@From, '') != '' AND IsNull(@To, '') != '' )				BEGIN				--PRINT('Date')					--SET	@Query = @Query + ' AND (CONVERT(DATE,JGDC.OrderDate)) BETWEEN '''+@From+''' AND '''+@To+''''					SET @Query = @Query + ' AND (CONVERT(DATE,JGDC.OrderDate)) BETWEEN ''' + CONVERT(NVARCHAR, @From) + ''' AND ''' + CONVERT(NVARCHAR, @To) + ''''				END			IF(@IsClientWise = 1 AND @MainCompany != '' AND @ClientCompany != '')				BEGIN					SET	@Query = @Query + ' AND JGDC.CompanyName =  '''+@MainCompany+ ''' AND JGDC.ClientCompany =  '''+@ClientCompany+ ''''				END			ELSE IF (@IsClientWise = 2 AND @MainCompany != '' AND @ClientCompany != '' AND @SubClientCompany != '')				BEGIN					SET	@Query = @Query + ' AND JGDC.CompanyName =  '''+@MainCompany+ ''' AND JGDC.ClientCompany =  '''+@ClientCompany+ ''' AND JGDC.SubClientCompany =  '''+@SubClientCompany+ ''''				END				SET	@Query = @Query + ')					SELECT	CASE 					WHEN ROW_NUMBER() OVER(ORDER BY row_no) = 1 THEN (SELECT COUNT(*) FROM LabourDirectReportList)					ELSE 0 					END AS total_count,					* FROM	LabourDirectReportList '

				--PRINT(@QUERY);
		EXEC (@QUERY);
END

/*
EXEC [dbo].[PRO_GetDirectLabourBill]
    @From = '2023-08-14',
    @To = '2023-09-14',
    @IsClientWise = 2,
    @MainCompany = 'ACOMPANY',
    @ClientCompany = 'ClientCOmpany',
    @SubClientCompany = 'SUBCLIENTCOMPANY';
*/