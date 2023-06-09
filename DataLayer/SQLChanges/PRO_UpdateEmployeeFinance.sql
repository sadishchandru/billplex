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
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateEmployeeFinance]
	@Id bigint = 0,
	@EmpId  BIGINT=0,
	@BankName varchar(250)='',
	@BankAddress varchar(1000)='',
	@SalaryNo varchar(250)='',
	@PaymentMode varchar(100)='',
	@AccountType varchar(100) = '',
	@BankRef varchar(250) = '',
	@Ward varchar(200) ='',
	@PolicyNo varchar(250) ='',
	@PolicyTerm varchar(200) = '',
	@LicId varchar(250) ='',
	@AnnualDate date = NULL,
	@PFApplicable BIT = '',
	@PFJoiningDate  date = NULL,
	@PFLastDate date =NULL,
	@PFNo varchar(100) = '',
	@PensionApplicable bit = '',
	@PensionJoiningDate date= NULL,
	@ESIApplicable BIT = '',
	@ESIJoiningDate date= NULL,
	@ESINo varchar(100) = '',
	@ESILastDate date =NULL,
	@ESIOffice varchar(100) = '',
	@ESIDispensary varchar(100) = '',	
	@DeleteOption char(1) = ''
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO EmployeeFinance
		(
			
				[EmpId],
				[BankName],
				[BankAddress],
				[SalaryNo],
				[PaymentMode],
				[AccountType],
				[BankRef],
				[Ward],
				[PolicyNo],
				[PolicyTerm],
				[LicId],
				[AnnualDate],
				[PFApplicable],
				[PFJoiningDate],
				[PFLastDate],
				[PFNo],
				[PensionApplicable],
				[PensionJoiningDate],
				[ESIApplicable],
				[ESIJoiningDate],
				[ESINo],
				[ESILastDate],
				[ESIOffice],
				[ESIDispensary],
				[DeleteOption]
		) VALUES
		(
				
				@EmpId,
				@BankName,
				@BankAddress,
				@SalaryNo,
				@PaymentMode,
				@AccountType,
				@BankRef,
				@Ward,
				@PolicyNo,
				@PolicyTerm,
				@LicId,
				@AnnualDate,
				@PFApplicable,
				@PFJoiningDate,
				@PFLastDate,
				@PFNo,
				@PensionApplicable,
				@PensionJoiningDate,
				@ESIApplicable,
				@ESIJoiningDate,
				@ESINo,
				@ESILastDate,
				@ESIOffice,
				@ESIDispensary,
				@DeleteOption
		)

		SET @ResultMessage = 'Employee Finance Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE EmployeeFinance 
		SET	
		        
				[EmpId]=@EmpId,
				[BankName]=@BankName,
				[BankAddress]=@BankAddress,
				[SalaryNo]=@SalaryNo,
				[PaymentMode]=@PaymentMode,
				[AccountType]=@AccountType,
				[BankRef]=@BankRef,
				[Ward]=@Ward,
				[PolicyNo]=@PolicyNo,
				[PolicyTerm]=@PolicyTerm,
				[LicId]=@LicId,
				[AnnualDate]=@AnnualDate,
				[PFApplicable]=@PFApplicable,
				[PFJoiningDate]=@PFJoiningDate,
				[PFLastDate]=@PFLastDate,
				[PFNo]=@PFNo,
				[PensionApplicable]=@PensionApplicable,
				[PensionJoiningDate]=@PensionJoiningDate,
				[ESIApplicable]=@ESIApplicable,
				[ESIJoiningDate]=@ESIJoiningDate,
				[ESINo]=@ESINo,
				[ESILastDate]=@ESILastDate,
				[ESIOffice]=@ESIOffice,
				[ESIDispensary]=@ESIDispensary,
				[DeleteOption]=@DeleteOption

		WHERE Id = @Id
		
		SET @ResultMessage = 'Employee Finance Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
