USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_UpdateCompanyProfileInfo]    Script Date: 01/06/2023 14:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Company Profile Info
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateSubClientCompanyProfileInfo]
@ComId BIGINT = 0
,@ComCcode VARCHAR(50) = ''
,@ComName VARCHAR(100) = ''
,@ComType VARCHAR(50) = ''
,@ComOffAdd	VARCHAR(100) = ''
,@Comstate VARCHAR(50) = ''
,@ComPin VARCHAR(50) = ''
,@ComNature VARCHAR(100) = ''
,@ComDatestart DATE = NULL
,@ComStdCode VARCHAR(10) = ''
,@ComPhone VARCHAR(20) = ''
,@ComEmail VARCHAR(50) = ''
,@ComWebsite VARCHAR(50) = ''
,@ComPFno VARCHAR(100) = ''
,@ComPFdate DATE = NULL
,@ComESIno VARCHAR(100) = ''
,@ComESIdate DATE = NULL
,@ComFactoryNo VARCHAR(100) = ''
,@ComCSTno VARCHAR(100) = ''
,@ComSSLno VARCHAR(100) = ''
,@ComTINno VARCHAR(100) = ''
,@ComLicenseno VARCHAR(100) = ''
,@ComPanno VARCHAR(100) = ''
,@ComTanno VARCHAR(100) = ''
,@CAuthorName VARCHAR(100) = ''
,@CAFathername VARCHAR(100) = ''
,@CAGender VARCHAR(100) = ''
,@CAAddress VARCHAR(250) = ''
,@CAstate VARCHAR(50) = ''
,@CApin VARCHAR(50) = ''
,@CAStdCode VARCHAR(10) = ''
,@CAPhoneno VARCHAR(50) = ''
,@CAMobile VARCHAR(100) = ''
,@CAblood VARCHAR(50) = ''
,@CADOB VARCHAR(50) = ''
,@CAEmail VARCHAR(100) = ''
,@CAPan VARCHAR(50) = ''
,@CBankname VARCHAR(100) = ''
,@CBankACNo VARCHAR(100) = ''
,@CBankAddress  VARCHAR(250) = ''
	
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	--IF(@ComId = 0)
	--BEGIN
	--	INSERT INTO SubClientMaster
	--	(
			
	--		[MasterCode]
	--		,[MasterCompanyId]
	--		,[ClientCompanyId]
	--		,[SubComCode]
	--		,[SubComName]
	--		,[ComOffAdd]
	--		,[ComState]
	--		,[ComPin]
	--		,[ComNature]
	--		,[ComType]
	--		,[ComDatestart]
	--		,[ComStdCode]
	--		,[ComPhone]
	--		,[ComEmail]
	--		,[ComWebsite]
	--		,[PfType]
	--		,[ComPfNo]
	--		,[ComPfDate]
	--		,[ComEsiNo]
	--		,[ComEsiDate]
	--		,[ComFactoryNo]
	--		,[ComCstNo]
	--		,[ComSslNo]
	--		,[ComTinNo]
	--		,[ComLicenseno]
	--		,[ComPanNo]
	--		,[ComTanNo]
	--		,[AuthorName]
	--		,[AuthorFathername]
	--		,[AuthorGender]
	--		,[AuthorBlood]
	--		,[AuthorDOB]
	--		,[AuthorEmail]
	--		,[AuthorAddress]
	--		,[AuthorState]
	--		,[AuthorPin]
	--		,[AuthorMobile]
	--		,[AuthorPan]
	--		,[AuthorPercent]
	--		,[AuthorActive]
	--	) VALUES
	--	(
	--		@ComCcode
	--		,@ComName
	--		,@ComType
	--		,@ComOffAdd
	--		,@Comstate
	--		,@ComPin
	--		,@ComNature
	--		,@ComDatestart
	--		,@ComStdCode
	--		,@ComPhone
	--		,@ComEmail
	--		,@ComWebsite
	--		,@ComPFno
	--		,@ComPFdate
	--		,@ComESIno
	--		,@ComESIdate
	--		,@ComFactoryNo
	--		,@ComCSTno
	--		,@ComSSLno
	--		,@ComTINno
	--		,@ComLicenseno
	--		,@ComPanno
	--		,@ComTanno
	--		,@CAuthorName
	--		,@CAFathername
	--		,@CAGender
	--		,@CAAddress
	--		,@CAstate
	--		,@CApin
	--		,@CAStdCode
	--		,@CAPhoneno
	--		,@CAMobile
	--		,@CAblood
	--		,@CADOB
	--		,@CAEmail
	--		,@CAPan
	--		,@CBankname
	--		,@CBankACNo
	--		,@CBankAddress 
	--	)

	--	SET @ResultMessage = 'Sub Client Company Profile Added Successfully';
	--	SET @ResultNo = 1
	--END
	--ELSE
	--BEGIN
	--	UPDATE SubClientMaster 
	--	SET	[ComCcode] = @ComCcode
	--		,[ComName] = @ComName
	--		,[ComType] = @ComType
	--		,[ComOffAdd] = @ComOffAdd
	--		,[Comstate] = @Comstate
	--		,[ComPin] = @ComPin
	--		,[ComNature] = @ComNature
	--		,[ComDatestart] = @ComDatestart
	--		,[ComStdCode] = @ComStdCode
	--		,[ComPhone] = @ComPhone
	--		,[ComEmail] = @ComEmail
	--		,[ComWebsite] = @ComWebsite
	--		,[ComPFno] = @ComPFno
	--		,[ComPFdate] = @ComPFdate
	--		,[ComESIno] = @ComESIno
	--		,[ComESIdate] = @ComESIdate
	--		,[ComFactoryNo] = @ComFactoryNo
	--		,[ComCSTno] = @ComCSTno
	--		,[ComSSLno] = @ComSSLno
	--		,[ComTINno] = @ComTINno
	--		,[ComLicenseno] = @ComLicenseno
	--		,[ComPanno] = @ComPanno
	--		,[ComTanno] = @ComTanno
	--		,[CAuthorName] = @CAuthorName
	--		,[CAFathername] = @CAFathername
	--		,[CAGender] = @CAGender
	--		,[CAAddress] = @CAAddress
	--		,[CAstate] = @CAstate
	--		,[CApin] = @CApin
	--		,[CAStdCode] = @CAStdCode
	--		,[CAPhoneno] = @CAPhoneno
	--		,[CAMobile] = @CAMobile
	--		,[CAblood] = @CAblood
	--		,[CADOB] = @CADOB
	--		,[CAEmail] = @CAEmail
	--		,[CAPan] = @CAPan
	--		,[CBankname] = @CBankname
	--		,[CBankACNo] = @CBankACNo
	--		,[CBankAddress] = @CBankAddress
	--	WHERE Id = @ComId

		
	--	SET @ResultMessage = 'Sub Client Company Profile Updated Successfully';
	--	SET @ResultNo = 1
	--END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
