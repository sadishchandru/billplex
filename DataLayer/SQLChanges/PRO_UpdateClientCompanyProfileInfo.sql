USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_UpdateClientCompanyProfileInfo]    Script Date: 31/05/2023 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 31-05-2023
-- Description:	Insert & Update Client Company Profile Info
-- =============================================
ALTER   PROCEDURE [dbo].[PRO_UpdateClientCompanyProfileInfo]
@Id BIGINT  = 0,
@MasterCompanyId BIGINT  = 0,
@ComCcode varchar(50) = '',
@ComCname varchar(100) = '',
@ComCoffAddress varchar(250) = '',
@ComCstate varchar(50) = '',
@ComCPin varchar(50) = '',
@ComCNature varchar(100) = '',
@ComType varchar(100) = '',
@ComCDatestart date = NULL,
@ComStdCode varchar(20) = '',
@ComCPhone varchar(20) = '',
@ComCEmail varchar(50) = '',
@ComCWebsite varchar(50) = '',
@PfType varchar(100) = '',
@ComCPFno varchar(100) = '',
@ComCPFdate date = NULL,
@ComCESino varchar(100) = '',
@ComCESIdate date = NULL,
@ComCFactoryNo varchar(100) = '',
@ComCCSTno varchar(100) = '',
@ComCSSLno varchar(100) = '',
@ComCTINno varchar(100) = '',
@ComCLicenseno varchar(100) = '',
@ComCPanno varchar(100) = '',
@ComCTanno varchar(100) = '',
@ComCPname varchar(100) = '',
@CCPFathername varchar(100) = '',
@CCPGender varchar(100) = '',
@CCPblood varchar(50) = '',
@CCPDOB date = NULL,
@CCPEmail varchar(100) = '',
@CCPAddress varchar(250) = '',
@CCPstate varchar(50) = '',
@CCPpin varchar(50) = '',
@CCPMobile varchar(100) = '',
@CCPPan varchar(50) = '',
@CCPpercent varchar(100)  = '',
@CCPactive varchar(100) = '',
@CCPImage image = '',
@CBankname varchar(100) = '',
@CBankACNo varchar(100) = '',
@CBankAddress varchar(250) = ''
	
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO ClientMaster
		(
			[MasterCompanyId],
			[ComCcode],
			[ComCname],
			[ComCoffAddress],
			[ComCstate],
			[ComCPin],
			[ComCNature],
			[ComType],
			[ComCDatestart],
			[ComStdCode],
			[ComCPhone],
			[ComCEmail],
			[ComCWebsite],
			[PfType],
			[ComCPFno],
			[ComCPFdate],
			[ComCESIno],
			[ComCESIdate],
			[ComCFactoryNo],
			[ComCCSTno],
			[ComCSSLno],
			[ComCTINno],
			[ComCLicenseno],
			[ComCPanno],
			[ComCTanno],
			[ComCPname],
			[CCPFathername],
			[CCPGender],
			[CCPblood],
			[CCPDOB],
			[CCPEmail],
			[CCPAddress],
			[CCPstate],
			[CCPpin],
			[CCPMobile],
			[CCPPan],
			[CCPpercent],
			[CCPactive],
			[CCPImage],
			[CBankname],
			[CBankACNo],
			[CBankAddress]

		) VALUES
		(
			@MasterCompanyId,
			@ComCcode,
			@ComCname,
			@ComCoffAddress,
			@ComCstate,
			@ComCPin,
			@ComCNature,
			@ComType,
			@ComCDatestart,
			@ComStdCode,
			@ComCPhone,
			@ComCEmail,
			@ComCWebsite,
			@PfType,
			@ComCPFno,
			@ComCPFdate,
			@ComCESIno,
			@ComCESIdate,
			@ComCFactoryNo,
			@ComCCSTno,
			@ComCSSLno,
			@ComCTINno,
			@ComCLicenseno,
			@ComCPanno,
			@ComCTanno,
			@ComCPname,
			@CCPFathername,
			@CCPGender,
			@CCPblood,
			@CCPDOB,
			@CCPEmail,
			@CCPAddress,
			@CCPstate,
			@CCPpin,
			@CCPMobile,
			@CCPPan,
			@CCPpercent,
			@CCPactive,
			@CCPImage,
			@CBankname,
			@CBankACNo,
			@CBankAddress
		)

		SET @ResultMessage = 'Client Company Profile Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE ClientMaster 
		SET	
			[MasterCompanyId]= @MasterCompanyId,
			[ComCcode]=@ComCcode,
			[ComCname]=@ComCname,
			[ComCoffAddress]=@ComCoffAddress,
			[ComCstate]=@ComCstate,
			[ComCPin]=@ComCPin,
			[ComCNature]=@ComCNature,
			[ComType]=@ComType,
			[ComCDatestart]=@ComCDatestart,
			[ComStdCode]=@ComStdCode,
			[ComCPhone]=@ComCPhone,
			[ComCEmail]=@ComCEmail,
			[ComCWebsite]=@ComCWebsite,
			[PfType]=@PfType,
			[ComCPFno]=@ComCPFno,
			[ComCPFdate]=@ComCPFdate,
			[ComCESIno]=@ComCESino,
			[ComCESIdate]=@ComCESIdate,
			[ComCFactoryNo]=@ComCFactoryNo,
			[ComCCSTno]=@ComCCSTno,
			[ComCSSLno]=@ComCSSLno,
			[ComCTINno]=@ComCTINno,
			[ComCLicenseno]=@ComCLicenseno,
			[ComCPanno]=@ComCPanno,
			[ComCTanno]=@ComCTanno,
			[ComCPname]=@ComCPname,
			[CCPFathername]=@CCPFathername,
			[CCPGender]=@CCPGender,
			[CCPblood]=@CCPblood,
			[CCPDOB]=@CCPDOB,
			[CCPEmail]=@CCPEmail,
			[CCPAddress]=@CCPAddress,
			[CCPstate]=@CCPstate,
			[CCPpin]=@CCPpin,
			[CCPMobile]=@CCPMobile,
			[CCPPan]=@CCPPan,
			[CCPpercent]=@CCPpercent,
			[CCPactive]=@CCPactive,
			[CCPImage]=@CCPImage,
			[CBankname]=@CBankname,
			[CBankACNo]=@CBankACNo,
			[CBankAddress]=@CBankAddress
		WHERE Id = @Id

		
		SET @ResultMessage = 'Client Company Profile Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
