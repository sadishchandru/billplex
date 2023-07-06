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
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetEmployeeFamilyList]
@EmpId BIGINT = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	
	
	SELECT	 Id
			,EmpId
			,SNo
			,Name
			,FAddress
			,Farea
			,Fdistrict
			,State
			,Pincode
			,EmployeeRelation
			,DoB
			,Age
			,Residing
			,Remark
			FROM Family
			WHERE EmpId = @EmpId
END