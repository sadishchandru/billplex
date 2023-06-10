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
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetSizeMaster]
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	--DECLARE @StartRowIndex NVARCHAR(10) = CONVERT(NVARCHAR(10),((@PageNo - 1) * @PageSize) + 1) 
	--DECLARE @MaximumRows NVARCHAR(10) = CONVERT(NVARCHAR(10),@PageNo * @PageSize)	
    
	
	--SET @Query = '
	--;With MainBankInfo AS
	--	(
			--SELECT 
			--		Id,
			--		MainCompany,
			--		BankName,
			--		BankAcNo,
			--		BranchCode,
			--		BranchName,
			--		IFSCode,
			--		Address
			--FROM MainBankInfo MBI
	--		'

	--IF(@SearchKey != '')
	--	BEGIN
	--		SET	@Query = @Query + ' AND  CMI.ComName LIKE ''%'+@SearchKey+'%'''
	--	END

	--SET	@Query = @Query + ' )
	--		SELECT	CASE WHEN ROW_NUMBER() OVER(ORDER BY row_no) = 1 then (select count(*) from MasterCompanyProfileInfo) else 0 end as total_count,
	--				*		
	--		FROM	MainBankInfo '

	--PRINT (@Query)
	--EXEC(@Query)


			SELECT 
					ID,
					Sizename
			FROM SizeMaster 
END