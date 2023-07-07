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
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateSizeMaster]
	@Id int = 0,
	@Sizename varchar(100)=''

AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''
	IF EXISTS (SELECT NULL FROM SizeMaster WHERE Sizename = @Sizename AND Id != @Id)
	BEGIN
		SET @ResultMessage = 'Size already exists';
		SET @ResultNo = 0;
	END
	ELSE
	BEGIN
		IF(@Id = 0)
		BEGIN
			INSERT INTO[dbo].[SizeMaster]
			(
				Sizename
			) VALUES
			(
				@Sizename
			)

			SET @ResultMessage = 'SizeMaster Added Successfully';
			SET @ResultNo = 1
		END
		ELSE
		BEGIN
			UPDATE SizeMaster 
			SET	
			[Sizename] = @Sizename
			WHERE Id = @Id
			SET @ResultMessage = 'SizeMaster Updated Successfully';
			SET @ResultNo = 1
		END

		SELECT  @ResultMessage AS ResultMessage,
				@ResultNo AS ResultNo
	END
END
