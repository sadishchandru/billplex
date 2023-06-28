USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_DeleteRawMaterials]    Script Date: 6/20/2023 3:37:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 31-05-2023
-- Description:	Insert & Update CustomerDetails
-- =============================================
 CREATE OR ALTER PROCEDURE [dbo].[PRO_DeleteRawMaterials]
(
    @Id bigint
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete the record based on the @Id parameter
    DELETE FROM [dbo].RawMaterial
    WHERE [Id] = @Id;
END
