USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetClientCompanyProfileInfo]    Script Date: 02/06/2023 15:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Panneerselvam K,,Name>
-- Create date: <20-06-2023 Date,,>
-- Description:	<Getting List of the Incentive Master Record>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_GetIncentiveMaster]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
SELECT 
					Id,
					ProductName,
					ModelCode,
					ModelName,
					ModelSize,
					DurationPeriod,
					Date
					
		FROM IncentiveMaster
END