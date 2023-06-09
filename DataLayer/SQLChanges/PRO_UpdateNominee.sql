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
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateNominee]
	@Id Bigint = 0,
	@SNo varchar(50) = '',
	@EmpCode varchar(100) = '',
	@EmpId BIGINt= '',
	@Name varchar(250) = '',
	@FAddress varchar(300) = '',
	@Farea varchar(100) = '',
	@Fdistrict varchar(100) = '',
	@Pincode varchar(100) = '',
	@State varchar(100) = '',
	@EmployeeRelation varchar(100) = '',
	@DoB date = NULL,
	@Age int = '',
	@Residing varchar(100) = '',
	@Porportion varchar(300) = '',
	@MaritalStatus varchar(100) = '',
	@Religion varchar(100) = '',
	@FName varchar(100) = '',
	@GuardianName varchar(100) = '',
	@GuardianAddress varchar(300) = '',
	@GuardianRelation varchar(300)= ''
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO Nominee
		(
				
				[SNo],
				[EmpCode],
				[EmpId],
				[Name],
				[FAddress],
				[Farea],
				[Fdistrict],
				[Pincode],
				[State],
				[EmployeeRelation],
				[DoB],
				[Age],
				[Residing],
				[Porportion],
				[MaritalStatus],
				[Religion],
				[FName],
				[GuardianName],
				[GuardianAddress],
				[GuardianRelation]
		) VALUES
		(
				
				@SNo,
				@EmpCode,
				@EmpId,
				@Name,
				@FAddress,
				@Farea,
				@Fdistrict,
				@Pincode,
				@State,
				@EmployeeRelation,
				@DoB,
				@Age,
				@Residing,
				@Porportion,
				@MaritalStatus,
				@Religion,
				@FName,
				@GuardianName,
				@GuardianAddress,
				@GuardianRelation
		)

		SET @ResultMessage = 'Nominee Detial Added Successfully';
		SET @ResultNo = 1
	END
	--ELSE
	--BEGIN
	--	UPDATE Nominee 
	--	SET	
	--	        [Id]=@Id,
	--			[SNo]=@SNo,
	--			[EmpCode]=@EmpCode,
	--			[EmpId]=@EmpId,
	--			[Name]=@Name,
	--			[FAddress]=@FAddress,
	--			[Farea]=@Farea,
	--			[Fdistrict]=@Fdistrict,
	--			[Pincode]=@Pincode,
	--			[State]=@State,
	--			[EmployeeRelation]=@EmployeeRelation,
	--			[DoB]=@DoB,
	--			[Age]=@Age,
	--			[Residing]=@Residing,
	--			[Porportion]=@Porportion,
	--			[MaritalStatus]=@MaritalStatus,
	--			[Religion]=@Religion,
	--			[FName]=@FName,
	--			[GuardianName]=@GuardianName,
	--			[GuardianAddress]=@GuardianAddress,
	--			[GuardianRelation]=@GuardianRelation

	--	WHERE Id = @Id
		
	--	SET @ResultMessage = 'Nominee Detials Updated Successfully';
	--	SET @ResultNo = 1
	--END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
