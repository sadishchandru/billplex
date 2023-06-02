USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetClientCompanyProfileInfo]    Script Date: 02/06/2023 15:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetSubClientBankInfo]
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	--DECLARE @StartRowIndex NVARCHAR(10) = CONVERT(NVARCHAR(10),((@PageNo - 1) * @PageSize) + 1) 
	--DECLARE @MaximumRows NVARCHAR(10) = CONVERT(NVARCHAR(10),@PageNo * @PageSize)	
    
	
	--SET @Query = '
	--;With SubClientBankInfo AS
	--	(
			--SELECT 
			--		Id,
					--ClientCompany,
					--SubClientCompany,
			--		BankName,
			--		BankAcNo,
			--		BranchCode,
			--		BranchName,
			--		IFSCode,
			--		Address
			--FROM SubClientBankInfo SCBI
	--		'

	--IF(@SearchKey != '')
	--	BEGIN
	--		SET	@Query = @Query + ' AND  CMI.ComName LIKE ''%'+@SearchKey+'%'''
	--	END

	--SET	@Query = @Query + ' )
	--		SELECT	CASE WHEN ROW_NUMBER() OVER(ORDER BY row_no) = 1 then (select count(*) from MasterCompanyProfileInfo) else 0 end as total_count,
	--				*		
	--		FROM	SubClientBankInfo '

	--PRINT (@Query)
	--EXEC(@Query)


			SELECT 
					SCBI.Id,
					CM.ComCname,
					SCM.SubComName,
					SCBI.ClientCompanyId,
					SCBI.SubClientCompanyId,
					SCBI.BankName,
					SCBI.BankAcNo,
					BranchCode,
					BranchName,
					IFSCode,
					Address
			FROM SubClientBankInfo SCBI
			inner join ClientMaster CM on CM.Id = SCBI.ClientCompanyId
			inner join SubClientMaster SCM On SCM.Id = SCBI.SubClientCompanyId
END