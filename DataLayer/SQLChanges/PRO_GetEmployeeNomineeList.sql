SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
-- EXEC PRO_GetEmployeeNomineeList
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetEmployeeNomineeList]
@EmpId BIGINT = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	
	
	SELECT	Id
			,SNo
			,EmpId
			,Name
			,FAddress
			,Farea
			,Fdistrict
			,Pincode
			,State
			,EmployeeRelation
			,DoB
			,Age
			,Residing
			,Porportion
			,MaritalStatus
			,Religion
			,FName
			,GuardianName
			,GuardianAddress
			,GuardianRelation
			FROM Nominee
			WHERE EmpId = @EmpId
END