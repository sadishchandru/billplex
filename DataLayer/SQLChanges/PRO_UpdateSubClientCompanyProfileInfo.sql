USE [BillPlex]
GO
--****** Object:  StoredProcedure [dbo].[PRO_UpdateCompanyProfileInfo]    Script Date: 01-06-2023 14:27:01 ******-
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
@Id bigint = 0 ,
@MasterCompanyld bigint= 0,
@ClientCompanyld  bigint = 0,
@ContractorName varchar(100)= '',
@SubComCode varchar(50)='',
@SubComName varchar(100)='',
@ComOffAdd varchar(250)='',
@ComState varchar(50)='',
@ComPin varchar(50)='',
@ComNature varchar(100)='',
@Director varchar(100)='',
@ComDatestart date=Null,
@ComStdCode varchar(20)='',
@ComPhone varchar(20)='',
@ComEmail varchar(50)='',
@ComWebsite varchar(50)='',
@PfType varchar(100)='',
@ComPfNo varchar(100)='',
@ComPfDate date=Null,
@ComEsiNo varchar(100)='',
@ComEsiDate date=Null,
@ComFactoryNo varchar(100)='',
@ComCstNo varchar(100)='',
@ComSsINo varchar(100)='',
@ComTinNo varchar(100)='',
@ComLicenseno varchar(100)='',
@ComPanNo varchar(100)='',
@ComTanNo varchar(100)='',
@AuthorName varchar(100)='',
@AuthorFathername varchar(100)='',
@AuthorGender varchar(100)='',
@AuthorBlood varchar(50)='',
@AuthorDOB date=Null,
@AuthorEmail varchar(100)='',
@AuthorAddress varchar(250)='',
@AuthorState varchar(50)='', 
@AuthorPin varchar(50)='',
@AuthorMobile varchar(100)='',
@AuthorPan varchar(50)='',
@AuthorPercent varchar(100)='',
@AuthorActive varchar(100)=''
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO SubClientMaster
		(
			 [MasterCompanyId]
			,[ClientCompanyId]
			,[ContractorName]
			,[SubComCode]
			,[SubComName]
			,[ComOffAdd]
			,[ComState]
			,[ComPin]
			,[ComNature]
			,[Director]
			,[ComDatestart]
			,[ComStdCode]
			,[ComPhone]
			,[ComEmail]
			,[ComWebsite]
			,[PfType]
			,[ComPfNo]
			,[ComPfDate]
			,[ComEsiNo]
			,[ComEsiDate]
			,[ComFactoryNo]
			,[ComCstNo]
			,[ComSslNo]
			,[ComTinNo]
			,[ComLicenseno]
			,[ComPanNo]
			,[ComTanNo]
			,[AuthorName]
			,[AuthorFathername]
			,[AuthorGender]
			,[AuthorBlood]
			,[AuthorDOB]
			,[AuthorEmail]
			,[AuthorAddress]
			,[AuthorState]
			,[AuthorPin]
			,[AuthorMobile]
			,[AuthorPan]
			,[AuthorPercent]
			,[AuthorActive]
		) VALUES
		(
			@MasterCompanyld,
			@ClientCompanyld,
			@ContractorName,
			@SubComCode,
			@SubComName,
			@ComOffAdd,
			@ComState,
			@ComPin,
			@ComNature,
			@Director,
			@ComDatestart,
			@ComStdCode,
			@ComPhone,
			@ComEmail,
			@ComWebsite,
			@PfType,
			@ComPfNo,
			@ComPfDate,
			@ComEsiNo,
			@ComEsiDate,
			@ComFactoryNo,
			@ComCstNo,
			@ComSsINo,
			@ComTinNo,
			@ComLicenseno,
			@ComPanNo,
			@ComTanNo,
			@AuthorName,
			@AuthorFathername,
			@AuthorGender,
			@AuthorBlood,
			@AuthorDOB,
			@AuthorEmail,
			@AuthorAddress,
			@AuthorState,
			@AuthorPin,
			@AuthorMobile,
			@AuthorPan,
			@AuthorPercent,
			@AuthorActive
		)

		SET @ResultMessage = 'Sub Client Company Profile Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE SubClientMaster 
		SET	
			[MasterCompanyId]=@MasterCompanyld,
			[ClientCompanyId]=@ClientCompanyld,
			[ContractorName]=@ContractorName,
			[SubComCode]=@SubComCode,
			[SubComName]=@SubComName,
			[ComOffAdd]=@ComOffAdd,
			[ComState]=@ComState,
			[ComPin]=@ComPin,
			[ComNature]=@ComNature,
			[Director]=@Director,
			[ComDatestart]=@ComDatestart,
			[ComStdCode]=@ComStdCode,
			[ComPhone]=@ComPhone,
			[ComEmail]=@ComEmail,
			[ComWebsite]=@ComWebsite,
			[PfType]=@PfType,
			[ComPfNo]=@ComPfNo,
			[ComPfDate]=@ComPfDate,
			[ComEsiNo]=@ComEsiNo,
			[ComEsiDate]=@ComEsiDate,
			[ComFactoryNo]=@ComFactoryNo,
			[ComCstNo]=@ComCstNo,
			[ComSslNo]=@ComSsINo,
			[ComTinNo]=@ComTinNo,
			[ComLicenseno]=@ComLicenseno,
			[ComPanNo]=@ComPanNo,
			[ComTanNo]=@ComTanNo,
			[AuthorName]=@AuthorName,
			[AuthorFathername]=@AuthorFathername,
			[AuthorGender]=@AuthorGender,
			[AuthorBlood]=@AuthorBlood,
			[AuthorDOB]=@AuthorDOB,
			[AuthorEmail]=@AuthorEmail,
			[AuthorAddress]=@AuthorAddress,
			[AuthorState]=@AuthorState,
			[AuthorPin]=@AuthorPin,
			[AuthorMobile]=@AuthorMobile,
			[AuthorPan]=@AuthorPan,
			[AuthorPercent]=@AuthorPercent,
			[AuthorActive]=@AuthorActive
		WHERE Id = @Id

		
		SET @ResultMessage = 'Sub Client Company Profile Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
