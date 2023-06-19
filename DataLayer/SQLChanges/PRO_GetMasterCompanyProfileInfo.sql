SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--EXEC PRO_GetMasterCompanyProfileInfo
ALTER PROCEDURE PRO_GetMasterCompanyProfileInfo
@SearchKey VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	--DECLARE @StartRowIndex NVARCHAR(10) = CONVERT(NVARCHAR(10),((@PageNo - 1) * @PageSize) + 1) 
	--DECLARE @MaximumRows NVARCHAR(10) = CONVERT(NVARCHAR(10),@PageNo * @PageSize)	
    
	
	
			SELECT	Id
					,ComCcode
					,ComName
					,ComType
					,ComOffAdd
					,Comstate
					,ComPin
					,ComNature
					,ComDatestart
					,ComStdCode
					,ComPhone
					,ComEmail
					,ComWebsite
					,ComPFno
					,ComPFdate
					,ComESIno
					,ComESIdate
					,ComFactoryNo
					,ComCSTno
					,ComSSLno
					,ComTINno
					,ComLicenseno
					,ComPanno
					,ComTanno
					,CAuthorName
					,CAFathername
					,CAGender
					,CAAddress
					,CAstate
					,CApin
					,CAStdCode
					,CAPhoneno
					,CAMobile
					,CAblood
					,CADOB
					,CAEmail
					,CAPan
					,CBankname
					,CBankACNo
					,CBankAddress
					,CreatedDate
					,CAStartDate
			FROM	CompanyMasterInfo CMI
			

END
GO
