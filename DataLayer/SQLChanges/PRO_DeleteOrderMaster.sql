USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_DeleteSubClientMaster]    Script Date: 14/06/2023 11:58:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 31-05-2023
-- Description:	Insert & Update CustomerDetails
-- =============================================
CREATE OR ALTER   PROCEDURE [dbo].[PRO_DeleteOrderMaster]
(
    @Id bigint
)
AS
BEGIN
    SET NOCOUNT ON;
	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

    -- Delete the record based on the @Id parameter
    DELETE FROM [dbo].[OrderMaster]
    WHERE [Id] = @Id;

	SET @ResultMessage = 'OrderMaster Deleted Successfully';
	SET @ResultNo = 1
END
