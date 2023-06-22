SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
-- EXEC PRO_GetEmployeeList
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetEmployeeList]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	
	SELECT	 EP.Id
			,EmployeeCode
			,MasterCompanyId
			,ContractorName
			,ClientCompanyId
			,ClientName
			,SubCompanyId
			,SubCompanyName
			,EmployeeName
			,PAddress
			,PArea
			,PDistrict
			,PPincode
			,PState
			,CAddress
			,CArea
			,CDistrict
			,CPincode
			,CState
			,VoterId
			,DrivingNo
			,Pan
			,PassportNo
			,IdentityMark
			,DoB
			,Gender
			,BloodGroup
			,Email
			,FName
			,MName
			,MStatus
			,Religion
			,Caste
			,Nationality
			,SCode
			,Phone
			,Mobile
			,EJoiningDate
			,EProbationPeriod
			,EConfirmationDate
			,EResigningDate
			,Reason
			,EmpImage
			,EF.Id
			,EF.EmpId
			,EF.BankName
			,EF.BankAddress
			,EF.SalaryNo
			,EF.PaymentMode
			,EF.AccountType
			,EF.BankRef
			,EF.Ward
			,EF.PolicyNo
			,EF.PolicyTerm
			,EF.LicId
			,EF.AnnualDate
			,EF.PFApplicable
			,EF.PFJoiningDate
			,EF.PFLastDate
			,EF.PFNo
			,EF.PensionApplicable
			,EF.PensionJoiningDate
			,EF.ESIApplicable
			,EF.ESIJoiningDate
			,EF.ESINo
			,EF.ESILastDate
			,EF.ESIOffice
			,EF.ESIDispensary
			FROM EmployeePersonal EP
			LEFT JOIN EmployeeFinance EF ON EF.EmpId = EP.Id
				--LEFT JOIN Family ON EP.EmployeeCode = Family.EmpCode
				--LEFT JOIN Nominee ON Ep.EmployeeCode = Nominee.EmpCode;

END