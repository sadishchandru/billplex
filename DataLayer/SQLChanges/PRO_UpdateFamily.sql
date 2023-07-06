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
@EmpId VARCHAR(20) = '' ,
@family_items XML = NULL 
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	BEGIN TRY 
		BEGIN TRAN

		DELETE FROM Family WHERE EmpId = @EmpId

		INSERT INTO Family
			(
				EmpId
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
			)
			SELECT @EmpId as  EmpId,
				--xmlobj.value('EmpId[1]','BIGINT') as EmpId,
				xmlobj.value('SNo[1]','VARCHAR(200)') as SNo,
				xmlobj.value('Name[1]','VARCHAR(200)') as [Name],
				xmlobj.value('FAddress[1]','VARCHAR(200)') as FAddress,
				xmlobj.value('Farea[1]','VARCHAR(200)') as Farea,
				xmlobj.value('Fdistrict[1]','VARCHAR(200)') as Fdistrict,
				xmlobj.value('State[1]','VARCHAR(200)') as [State],
				xmlobj.value('Pincode[1]','VARCHAR(200)') as Pincode,
				xmlobj.value('EmployeeRelation[1]','VARCHAR(200)') as EmployeeRelation,
				xmlobj.value('DoB[1]','date') as DoB,
				xmlobj.value('Age[1]','int') as Age,
				xmlobj.value('Residing[1]','VARCHAR(200)') as Residing,
				xmlobj.value('Remark[1]','VARCHAR(200)') as Remark		
			FROM @family_items.nodes('//FamilyItems') as R (xmlobj)
				
			SET	@ResultNo = 1
			SET	@ResultMessage = 'Family updated successfully'

		COMMIT;
	END TRY

	BEGIN CATCH

	ROLLBACK;
	
	SET	@ResultNo = 0
	SET	@ResultMessage = ERROR_MESSAGE();
	END CATCH


	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END