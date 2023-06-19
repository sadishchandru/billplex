SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan
-- Create date: 5th June
-- Description:	Get dropdown items
-- =============================================
-- EXEC PRO_GetdropdownItems @MasterCompanyRequired =1,@CustomerMasterRequired =1
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetdropdownItems]
	@MasterCompanyRequired BIT = 0,
	@ClientCompanyRequired  BIT = 0,
	@SUbClientCompanyRequired BIT = 0,
	@CustomerMasterRequired BIT = 0
AS 
BEGIN
    SET NOCOUNT ON;

	IF(@MasterCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					ComCcode as code,
					ComName as name,
					CAuthorName as authorName
			FROM	[dbo].[CompanyMasterInfo]
		END

	IF(@ClientCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					ComCcode as code,
					ComCname as name,
					ComCPname as authorName
			FROM	ClientMaster
		END

	IF(@SubClientCompanyRequired = 1) 
		BEGIN
			SELECT	Id,
					SubComCode as code,
					SubComName as name,
					AuthorName as authorName
			FROM	SubClientMaster
		END

	IF(@CustomerMasterRequired = 1) 
		BEGIN
			SELECT	Id,
					Code as code,
					Name as name,
					'' as authorName
			FROM	CustomerMaster
		END
END
GO
