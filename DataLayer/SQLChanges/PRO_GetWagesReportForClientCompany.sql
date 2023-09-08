USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetClientCompanyProfileInfo]    Script Date: 27/06/2023 19:55:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Purushothaman K>
-- Create date: <09/04/2023>
-- Description:	<Wages Report For client Company>
-- =============================================
-- Exec [PRO_GetWagesReportForClientCompany]
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetWagesReportForClientCompany]
@From DATE = NULL,
@To DATE = NULL,
@ClientCompany VARCHAR(50) = ''
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets

    DECLARE @Query NVARCHAR(MAX) = '';

    SET @Query = '
    ;WITH LabourDirectReportList AS 
    (
        SELECT
            EP.EmployeeCode,
            JGDC.EmployeeName,
            EP.EJoiningDate,
			EF.PFNo,
			EF.ESINo,
            ClientCompany AS CompanyName,
			JGDC.ClientName,
            OM.Orderno AS OrderNo,
            ModelName,
			ReceivingDate,
            QuantityPiece,
            Wages,
            Deduction,
            conveyance As Conveyance,
            incentive As Incentive,
            NetAmt AS NetAmount,
            ROW_NUMBER() OVER (ORDER BY JGDC.OrderDate DESC) AS row_no
        FROM JobGivingWithoutDC JGDC
        LEFT JOIN EmployeePersonal EP ON EP.Id = JGDC.EmployeeCode
        LEFT JOIN OrderMaster OM ON OM.Id = JGDC.OrderNo
        LEFT JOIN EmployeeFinance EF ON EF.Id = JGDC.EmployeeCode';
	--PRINT(@QUERY);
    IF (ISNULL(@From, '') <> '' AND ISNULL(@To, '') <> '')
    BEGIN
        SET @Query = @Query + '
            WHERE (CONVERT(DATE, JGDC.OrderDate)) BETWEEN ''' + CONVERT(NVARCHAR, @From) + ''' AND ''' + CONVERT(NVARCHAR, @To) + '''';
    END
    ELSE
    BEGIN
        SET @Query = @Query + ' WHERE 1=1'; -- Adding a placeholder condition when dates are not specified.
    END

    IF (@ClientCompany <> '')
    BEGIN
        SET @Query = @Query + ' AND JGDC.CompanyName =  ''' + @ClientCompany + '''';
    END

    SET @Query = @Query + '
    )
    SELECT
        CASE 
            WHEN ROW_NUMBER() OVER(ORDER BY row_no) = 1 THEN (SELECT COUNT(*) FROM LabourDirectReportList)
            ELSE 0 
        END AS total_count,
        *
    FROM LabourDirectReportList ';

    --PRINT(@QUERY);
    EXEC (@QUERY);
END

/*
EXEC [dbo].[[PRO_GetWagesReportForClientCompany]]
    @From = '2023-08-01',
    @To = '2023-08-25',
    @ClientCompany = 'ClientCOmpany';
*/