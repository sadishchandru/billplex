USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_UpdateClientCompanyProfileInfo]    Script Date: 05/06/2023 13:08:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 31-05-2023
-- Description:	Insert & Update CustomerDetails
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_DeleteDirectJobReceivedWithoutGiving]
(
    @Id bigint
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete the record based on the @Id parameter
    DELETE FROM [dbo].[DirectJobReceivedWithoutGiving]
    WHERE [Id] = @Id;
END