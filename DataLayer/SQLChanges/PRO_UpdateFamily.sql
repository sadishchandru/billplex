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
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateFamily]
@Id bigint=0,
@EmpCode Bigint=0,
@EmpId Bigint = 0,
@SNo varchar(50)='',
@Name varchar(250)='',
@FAddress varchar(300)='',
@Farea varchar(100)='',
@Fdistrict varchar(100)='',
@State varchar(250)='',
@Pincode varchar(250)='',
@EmployeeRelation varchar(100)='',
@DoB DATE=NULL,
@Age INT= NULL,
@Residing varchar(100)='',
@Remark varchar(300) =''
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO Family
		(
			EmpCode
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
		) VALUES
		(
			@EmpCode,
			@EmpId,
			@SNo,
			@Name,
			@FAddress,
			@Farea,
			@Fdistrict,
			@State,
			@Pincode,
			@EmployeeRelation,
			@DoB,
			@Age,
			@Residing,
			@Remark
		)

		SET @ResultMessage = 'Family Added Successfully';
		SET @ResultNo = 1
	END
	--ELSE
	--BEGIN
	--	UPDATE Family 
	--	SET	
	--	[EmpCode]=@EmpCode,
	--	[EmpId]=@EmpId,
	--	[SNo]=@SNo,
	--	[Name]=@Name,
	--	[FAddress]=@FAddress,
	--	[Farea]=@Farea,
	--	[Fdistrict]=@Fdistrict,
	--	[State]=@State,
	--	[Pincode]=@Pincode,
	--	[EmployeeRelation]=@EmployeeRelation,
	--	[DoB]=@DoB,
	--	[Age]=@Age,
	--	[Residing]=@Residing,
	--	[Remark]=@Remark
	--	WHERE Id = @Id

		
	--	SET @ResultMessage = 'Family Updated Successfully';
	--	SET @ResultNo = 1
	--END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END