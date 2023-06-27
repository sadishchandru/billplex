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
ALTER     PROCEDURE [dbo].[PRO_GetClientCompanyProfileInfo]
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	--DECLARE @StartRowIndex NVARCHAR(10) = CONVERT(NVARCHAR(10),((@PageNo - 1) * @PageSize) + 1) 
	--DECLARE @MaximumRows NVARCHAR(10) = CONVERT(NVARCHAR(10),@PageNo * @PageSize)	
    
	
	--SET @Query = '
	--;With MasterCompanyProfileInfo AS
	--	(
			--SELECT  MasterCode,
			--		MasterCompanyId,
			--		ComCcode,
			--		ComCname,
			--		ComCoffAddress,
			--		ComCstate,
			--		ComCPin,
			--		ComCNature,
			--		ComType,
			--		ComCDatestart,
			--		ComStdCode,
			--		ComCPhone,
			--		ComCEmail,
			--		ComCWebsite,
			--		PfType,
			--		ComCPFno,
			--		ComCPFdate,
			--		ComCESIno,
			--		ComCESIdate,
			--		ComCFactoryNo,
			--		ComCCSTno,
			--		ComCSSLno,
			--		ComCTINno,
			--		ComCLicenseno,
			--		ComCPanno,
			--		ComCTanno,
			--		ComCPname,
			--		CCPFathername,
			--		CCPGender,
			--		CCPblood,
			--		CCPDOB,
			--		CCPEmail,
			--		CCPAddress,
			--		CCPstate,
			--		CCPpin,
			--		CCPMobile,
			--		CCPPan,
			--		CCPpercent,
			--		CCPactive,
			--		CCPImage,
			--		CBankname,
			--		CBankACNo,
			--		CBankAddress
			--		FROM ClientMaster CM
	--		'

	--IF(@SearchKey != '')
	--	BEGIN
	--		SET	@Query = @Query + ' AND  CMI.ComName LIKE ''%'+@SearchKey+'%'''
	--	END

	--SET	@Query = @Query + ' )
	--		SELECT	CASE WHEN ROW_NUMBER() OVER(ORDER BY row_no) = 1 then (select count(*) from MasterCompanyProfileInfo) else 0 end as total_count,
	--				*		
	--		FROM	MasterCompanyProfileInfo '

	--PRINT (@Query)
	--EXEC(@Query)


			SELECT  Id,
					MasterCode,
					MasterCompanyId,
					ComCcode,
					ComCname,
					ComCoffAddress,
					ComCstate,
					ComCPin,
					ComCNature,
					ComType,
					ComCDatestart,
					ComStdCode,
					ComCPhone,
					ComCEmail,
					ComCWebsite,
					PfType,
					ComCPFno,
					ComCPFdate,
					ComCESIno,
					ComCESIdate,
					ComCFactoryNo,
					ComCCSTno,
					ComCSSLno,
					ComCTINno,
					ComCLicenseno,
					ComCPanno,
					ComCTanno,
					ComCPname,
					CCPFathername,
					CCPGender,
					CCPblood,
					CCPDOB,
					CCPEmail,
					CCPAddress,
					CCPstate,
					CCPpin,
					CCPMobile,
					CCPPan,
					CCPpercent,
					CCPactive,
					CCPImage,
					CBankname,
					CBankACNo,
					CBankAddress
					FROM ClientMaster CM
END
