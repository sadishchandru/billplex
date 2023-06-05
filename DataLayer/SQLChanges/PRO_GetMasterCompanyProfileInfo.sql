SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE PRO_GetMasterCompanyProfileInfo
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	--DECLARE @StartRowIndex NVARCHAR(10) = CONVERT(NVARCHAR(10),((@PageNo - 1) * @PageSize) + 1) 
	--DECLARE @MaximumRows NVARCHAR(10) = CONVERT(NVARCHAR(10),@PageNo * @PageSize)	
    
	
	SET @Query = '
	;With MasterCompanyProfileInfo AS
		(
			SELECT	ComCcode
					ComName
					ComType
					ComOffAdd
					Comstate
					ComPin
					ComNature
					ComDatestart
					ComStdCode
					ComPhone
					ComEmail
					ComWebsite
					ComPFno
					ComPFdate
					ComESIno
					ComESIdate
					ComFactoryNo
					ComCSTno
					ComSSLno
					ComTINno
					ComLicenseno
					ComPanno
					ComTanno
					CAuthorName
					CAFathername
					CAGender
					CAAddress
					CAstate
					CApin
					CAStdCode
					CAPhoneno
					CAMobile
					CAblood
					CADOB
					CAEmail
					CAPan
					CBankname
					CBankACNo
					CBankAddress
					Id
					CreatedDate
			FROM	CompanyMasterInfo CMI
			'

	IF(@SearchKey != '')
		BEGIN
			SET	@Query = @Query + ' AND  CMI.ComName LIKE ''%'+@SearchKey+'%'''
		END

	SET	@Query = @Query + ' )
			SELECT	CASE WHEN ROW_NUMBER() OVER(ORDER BY row_no) = 1 then (select count(*) from MasterCompanyProfileInfo) else 0 end as total_count,
					*		
			FROM	MasterCompanyProfileInfo '

	PRINT (@Query)
	EXEC(@Query)

END
GO
