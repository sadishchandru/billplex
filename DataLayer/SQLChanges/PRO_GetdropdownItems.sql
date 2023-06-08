SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan
-- Create date: 5th June
-- Description:	Get dropdown items
-- =============================================
-- EXEC PRO_GetdropdownItems @MasterCompanyRequired =1
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetdropdownItems]
	@MasterCompanyRequired BIT = 0,
	@ClientCompanyRequired  BIT = 0
AS 
BEGIN
    SET NOCOUNT ON;

	IF(@MasterCompanyRequired = 1) 
		BEGIN
			SELECT	id,
					ComCcode as code,
					ComName as name
			FROM	[dbo].[CompanyMasterInfo]
		END

	IF(@ClientCompanyRequired = 1) 
		BEGIN
			SELECT	id,
					ComCcode as code,
					ComName as name
			FROM	[dbo].[CompanyMasterInfo]
		END
END
GO
