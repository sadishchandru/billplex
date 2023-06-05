USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_UpdateClientBankInfo]    Script Date: 02/06/2023 17:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Bank Info
-- =============================================
ALTER   PROCEDURE [dbo].[PRO_UpdateClientBankInfo]
@Id bigint='',
@MainCompany bigint='',
@ClientCompany bigint='',
@BankName varchar(250)='',
@BankAcNo varchar(250)='',
@BranchCode varchar(250)='',
@BranchName varchar(250)='',
@IFSCode varchar(250)='',
@Address varchar(250)=''

AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO ClientBankInfo
		( 
			MainCompanyId, 
			[BankName], 
			[BankAcNo], 
			[BranchCode], 
			[BranchName], 
			[IFSCode], 
			[Address]
		) VALUES
		(
			@MainCompany, 
			@BankName, 
			@BankAcNo, 
			@BranchCode, 
			@BranchName, 
			@IFSCode, 
			@Address
		)

		SET @ResultMessage = 'Client Bank Info Added Successfully';
		SET @ResultNo = 1
	END
	--ELSE
	--BEGIN
	--	UPDATE ClientBankInfo 
	--	SET	
			--[MainCompany] = @MainCompany,
   --         [ClientCompany] = @ClientCompany,
   --         [BankName] = @BankName,
   --         [BankAcNo] = @BankAcNo,
   --         [BranchCode] = @BranchCode,
   --         [BranchName] = @BranchName,
   --         [IFSCode] = @IFSCode,
   --         [Address] = @Address
	--	WHERE Id = @Id

		
	--	SET @ResultMessage = 'Client Bank Info Updated Successfully';
	--	SET @ResultNo = 1
	--END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
