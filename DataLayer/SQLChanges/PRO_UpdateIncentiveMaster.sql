USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_UpdateIncentiveMaster]    Script Date: 6/20/2023 3:24:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Company Profile Info
-- =============================================
ALTER   PROCEDURE [dbo].[PRO_UpdateIncentiveMaster]
	@Id bigint = 0,
	@ProductName varchar(100)='',
	@ModelCode varchar(100)='',
	@ModelName varchar(100)='',
	@ModelSize varchar(100)='',
	@DurationPeriod varchar(100)='',
	@Date date = Null
	
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO[dbo].[IncentiveMaster]
		(
			ProductName,
			ModelCode,
			ModelName,
			ModelSize,
			DurationPeriod,
			Date
		) VALUES
		(
			@ProductName,
			@ModelCode,
			@ModelName,
			@ModelSize,
			@DurationPeriod,
			@Date
		)

		SET @ResultMessage = 'IncentiveMaster Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE IncentiveMaster 
		SET	
		
		ProductName = @ProductName,
		ModelCode = @ModelCode,
		ModelName = @ModelName,
		ModelSize = @ModelSize,
		DurationPeriod = @DurationPeriod,
		Date = @Date
		
		WHERE Id = @Id
		SET @ResultMessage = 'IncentiveMaster Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
