USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_DeleteClientMaster]    Script Date: 12/06/2023 4:45:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 31-05-2023
-- Description:	Insert & Update CustomerDetails
-- =============================================
 CREATE OR ALTER   PROCEDURE [dbo].[PRO_DeleteProductModel]
(
    @Id bigint
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete the record based on the @Id parameter
    DELETE FROM [dbo].[ProductModel]
    WHERE [Id] = @Id;
END
