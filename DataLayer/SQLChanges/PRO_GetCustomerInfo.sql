USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetClientCompanyProfileInfo]    Script Date: 05/06/2023 14:36:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetCustomerInfo]
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	--DECLARE @StartRowIndex NVARCHAR(10) = CONVERT(NVARCHAR(10),((@PageNo - 1) * @PageSize) + 1) 
	--DECLARE @MaximumRows NVARCHAR(10) = CONVERT(NVARCHAR(10),@PageNo * @PageSize)	
    
	
	--SET @Query = '
	--;With CustomerMaster AS
	--	(
			--SELECT  [Code],
				--[Name],
				--[OffAddress],
				--[State],
				--[Pin],
				--[Country],
				--[PhonePin],
				--[OffPhone],
				--[Email],
				--[ResAddress],
				--[ResState],
				--[ResPin],
				--[ResCountry],
				--[Mobile],
				--[TinNo],
				--[TinDate],
				--[CstNo],
				--[CstDate],
				--[licenseNo],
				--[Website]
			--		FROM CustomerMaster CM
	--		'

	--IF(@SearchKey != '')
	--	BEGIN
	--		SET	@Query = @Query + ' AND  CMI.ComName LIKE ''%'+@SearchKey+'%'''
	--	END

	--SET	@Query = @Query + ' )
	--		SELECT	CASE WHEN ROW_NUMBER() OVER(ORDER BY row_no) = 1 then (select count(*) from MasterCompanyProfileInfo) else 0 end as total_count,
	--				*		
	--		FROM	CustomerMaster '

	--PRINT (@Query)
	--EXEC(@Query)


			SELECT Id,
				[Code],
				[Name],
				[OffAddress],
				[State],
				[Pin],
				[Country],
				[PhonePin],
				[OffPhone],
				[Email],
				[ResAddress],
				[ResState],
				[ResPin],
				[ResCountry],
				[Mobile],
				[TinNo],
				[TinDate],
				[CstNo],
				[CstDate],
				[licenseNo],
				[Website]
			FROM CustomerMaster CM
END