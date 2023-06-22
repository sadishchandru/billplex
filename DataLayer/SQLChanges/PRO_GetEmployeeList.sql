USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetClientCompanyProfileInfo]    Script Date: 02/06/2023 15:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetEmployeeList]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	DECLARE @Query NVARCHAR(MAX) ='';
	
	
	SELECT Id
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
FROM EmployeePersonal EP
	--LEFT JOIN EmployeeFinance EF ON EF.EmpId = EP.Id
	--LEFT JOIN Family ON EP.EmployeeCode = Family.EmpCode
	--LEFT JOIN Nominee ON Ep.EmployeeCode = Nominee.EmpCode;

END