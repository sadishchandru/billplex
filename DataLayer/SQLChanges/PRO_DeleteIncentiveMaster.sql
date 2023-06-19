USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_DeleteIncentiveMaster]    Script Date: 6/20/2023 3:23:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 31-05-2023
-- Description:	Insert & Update CustomerDetails
-- =============================================
ALTER    PROCEDURE [dbo].[PRO_DeleteIncentiveMaster]
(
    @Id bigint
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete the record based on the @Id parameter
    DELETE FROM [dbo].IncentiveMaster
    WHERE [Id] = @Id;
END
