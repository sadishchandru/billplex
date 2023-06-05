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
@MasterCode varchar(50) null = '',
--@MasterCompany varchar(100)null = '',
@MasterCompanyId BIGINT  ='',
@ComCcode varchar(50) null= '',
@ComCname varchar(100) null= '',
@ComCoffAddress varchar(250) null= '',
@ComCstate varchar(50) null= '',
@ComCPin varchar(50) null= '',
@ComCNature varchar(100) null= '',
@ComType varchar(100) null= '',
@ComCDatestart date null= '',
@ComStdCode varchar(20) null= '',
@ComCPhone varchar(20) null= '',
@ComCEmail varchar(50) null= '',
@ComCWebsite varchar(50) null= '',
@PfType varchar(100) null= '',
@ComCPFno varchar(100) null= '',
@ComCPFdate date null= '',
@ComCESino varchar(100) null= '',
@ComCESIdate date null= '',
@ComCFactoryNo varchar(100) null= '',
@ComCCSTno varchar(100) null= '',
@ComCSSLno varchar(100) null= '',
@ComCTINno varchar(100) null= '',
@ComCLicenseno varchar(100) null= '',
@ComCPanno varchar(100) null= '',
@ComCTanno varchar(100) null= '',
@ComCPname varchar(100) null= '',
@CCPFathername varchar(100) null= '',
@CCPGender varchar(100) null= '',
@CCPblood varchar(50) null= '',
@CCPDOB date null= '',
@CCPEmail varchar(100) null= '',
@CCPAddress varchar(250) null= '',
@CCPstate varchar(50) null= '',
@CCPpin varchar(50) null= '',
@CCPMobile varchar(100) null= '',
@CCPPan varchar(50) null= '',
@CCPpercent varchar(100) null = '',
@CCPactive varchar(100) null= '',
@CCPImage image null= '',
@CBankname varchar(100) null= '',
@CBankACNo varchar(100) null= '',
@CBankAddress varchar(250) null= ''
	
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO ClientMaster
		(
			[MasterCode],
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
			@MasterCode,
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
		SET	[MasterCode] = @MasterCode,
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
			[ComCESIdate]=@ComCEmail,
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
