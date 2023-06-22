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
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateEmployeePersonal]
@Id bigint=0,
@EmployeeCode varchar(100) = '',
@MasterCompanyld bigint = 0, 
@ContractorName varchar(250)= '',
@ClientCompanyld bigint = 0,
@ClientName varchar(100)= '',
@SubCompanyld  bigint = 0,
@SubCompanyName varchar(100)= '', 
@EmployeeName varchar(250)= '',
@PAddress varchar(250)= '',
@PArea varchar(100)= '',
@PDistrict varchar(100)= '',
@PPincode varchar(250)= '',
@PState varchar(250)= '',
@CAddress varchar(250)= '',
@CArea varchar(100)= '',
@CDistrict varchar(100)= '',
@CPincode varchar(250)= '',
@CState varchar(250)= '',
@Voterld varchar(250)= '',
@DrivingNo varchar(250)= '',
@Pan varchar(250)= '',
@PassportNo varchar(250)= '',
@IdentityMark varchar(250),
@DoB date =NULL,
@Gender varchar(100)= '',
@BloodGroup varchar(100)= '',
@Email varchar(100)= '',
@FName varchar(100)= '',
@MName varchar(100)= '',
@MStatus varchar(100)= '',
@Religion varchar(100)= '',
@Caste varchar(100)= '',
@Nationality varchar(100)= '',
@SCode varchar(100)= '', 
@Phone varchar(100)= '', 
@Mobile varchar(100)= '',
@EJoiningDate DATE = NULL,
@EProbationPeriod VARCHAR(100) = '',
@EConfirmationDate DATE = NULL,
@EResigningDate DATE = NULL,
@Reason VARCHAR(100) = '',
@EmpImage IMAGE =NULL
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO EmployeePersonal
		(
			[EmployeeCode]
			,[MasterCompanyId]
			,[ContractorName]
			,[ClientCompanyId]
			,[ClientName]
			,[SubCompanyId]
			,[SubCompanyName]
			,[EmployeeName]
			,[PAddress]
			,[PArea]
			,[PDistrict]
			,[PPincode]
			,[PState]
			,[CAddress]
			,[CArea]
			,[CDistrict]
			,[CPincode]
			,[CState]
			,[VoterId]
			,[DrivingNo]
			,[Pan]
			,[PassportNo]
			,[IdentityMark]
			,[DoB]
			,[Gender]
			,[BloodGroup]
			,[Email]
			,[FName]
			,[MName]
			,[MStatus]
			,[Religion]
			,[Caste]
			,[Nationality]
			,[SCode]
			,[Phone]
			,[Mobile]
			,[EJoiningDate]
			,[EProbationPeriod]
			,[EConfirmationDate]
			,[EResigningDate]
			,[Reason]
			,[EmpImage]
		) VALUES
		(
			@EmployeeCode
			,@MasterCompanyld
			,@ContractorName
			,@ClientCompanyld
			,@ClientName
			,@SubCompanyld
			,@SubCompanyName
			,@EmployeeName
			,@PAddress
			,@PArea
			,@PDistrict
			,@PPincode
			,@PState
			,@CAddress
			,@CArea
			,@CDistrict
			,@CPincode
			,@CState
			,@Voterld
			,@DrivingNo
			,@Pan
			,@PassportNo
			,@IdentityMark
			,@DoB
			,@Gender
			,@BloodGroup
			,@Email
			,@FName
			,@MName
			,@MStatus
			,@Religion
			,@Caste
			,@Nationality
			,@SCode
			,@Phone
			,@Mobile
			,@EJoiningDate
			,@EProbationPeriod 
			,@EConfirmationDate
			,@EResigningDate
			,@Reason
			,@EmpImage
		)

		SET @ResultMessage = 'Employee Personal Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE EmployeePersonal 
		SET	
		[EmployeeCode]=@EmployeeCode,
		[MasterCompanyId]=@MasterCompanyld,
		[ContractorName]=@ContractorName,
		[ClientCompanyId]=@ClientCompanyld,
		[ClientName]=@ClientName,
		[SubCompanyId]=@SubCompanyld,
		[SubCompanyName]=@SubCompanyName,
		[EmployeeName]=@EmployeeName,
		[PAddress]=@PAddress,
		[PArea]=@PArea,
		[PDistrict]=@PDistrict,
		[PPincode]=@PPincode,
		[PState]=@PState,
		[CAddress]=@CAddress,
		[CArea]=CArea,
		[CDistrict]=@CDistrict,
		[CPincode]=@CPincode,
		[CState]=@CState,
		[VoterId]=@Voterld,
		[DrivingNo]=@DrivingNo,
		[Pan]=@Pan,
		[PassportNo]=@PassportNo,
		[IdentityMark]=@IdentityMark,
		[DoB]=@DoB,
		[Gender]=@Gender,
		[BloodGroup]=@BloodGroup,
		[Email]=@Email,
		[FName]=@FName,
		[MName]=@MName,
		[MStatus]=@MStatus,
		[Religion]=@Religion,
		[Caste]=@Caste,
		[Nationality]=@Nationality,
		[SCode]=@SCode,
		[Phone]=@Phone,
		[Mobile]=@Mobile,
		[EJoiningDate]=@EJoiningDate,
		[EProbationPeriod]=@EProbationPeriod,
		[EConfirmationDate]=@EConfirmationDate,
		[EResigningDate]=@EResigningDate,
		[Reason]=@Reason,
		[EmpImage]=@EmpImage
		WHERE Id = @Id

		
		SET @ResultMessage = 'Employee Personal Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END