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
CREATE or alter PROCEDURE [dbo].[PRO_GetDirectLabourBill]
    @From DATE = NULL,
    @To DATE = NULL,
	@IsClientWise INT = 0,
    @MainCompany VARCHAR(50) = '',
    @ClientCompany VARCHAR(50) = '',
    @SubClientCompany VARCHAR(50) = ''
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets

    DECLARE @Query NVARCHAR(MAX) = '';

    SET @Query = '
        ;WITH LabourDirectReportList AS 
        (
            SELECT  
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
                JGDC.conveyance AS Conveyance,
                JGDC.incentive AS Incentive,
                JGDC.OrderDate,
				OM.Orderno AS OrderNo,
                ROW_NUMBER() OVER (ORDER BY JGDC.OrderDate DESC) AS row_no
            FROM JobGivingWithoutDC JGDC
            LEFT JOIN EmployeePersonal EP ON EP.Id = JGDC.EmployeeCode
            LEFT JOIN OrderMaster OM ON OM.Id = JGDC.OrderNo
            WHERE received IS NOT NULL AND received <> '''' 
                AND TotalQty IS NOT NULL AND TotalQty <> '''' 
    ';

    IF (ISNULL(@From, '') <> '' AND ISNULL(@To, '') <> '')
    BEGIN
        SET @Query = @Query + ' AND (CONVERT(DATE, JGDC.OrderDate)) BETWEEN ''' + CONVERT(NVARCHAR, @From) + ''' AND ''' + CONVERT(NVARCHAR, @To) + '''';
    END

    IF (@MainCompany <> '' AND @ClientCompany <> '' AND @IsClientWise = 0)
    BEGIN
        SET @Query = @Query + ' AND JGDC.CompanyName = ''' + @MainCompany + ''' AND JGDC.ClientCompany = ''' + @ClientCompany + '''';
    END

    IF (@MainCompany <> '' AND @ClientCompany <> '' AND @SubClientCompany <> '' AND @IsClientWise = 1)
    BEGIN
        SET @Query = @Query + ' AND JGDC.SubClientCompany = ''' + @SubClientCompany + '''';
    END

    SET @Query = @Query + '
        )
        SELECT
            CASE 
                WHEN ROW_NUMBER() OVER (ORDER BY row_no) = 1 THEN (SELECT COUNT(*) FROM LabourDirectReportList)
                ELSE 0 
            END AS total_count,
            *
        FROM LabourDirectReportList';

    EXEC sp_executesql @Query;
END

-- EXEC [dbo].[PRO_GetDirectLabourBill] @From = '2023-09-01', @To = '2023-10-31' , @MainCompany = 'AUROMICS TRUST' , @ClientCompany = 'EZHUMALAI .R';

