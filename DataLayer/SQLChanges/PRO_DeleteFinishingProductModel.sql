USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_DeleteProductModel]    Script Date: 16/06/2023 10:44:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 31-05-2023
-- Description:	Insert & Update CustomerDetails
-- =============================================
CREATE OR ALTER     PROCEDURE [dbo].[PRO_DeleteFinishingProductModel]
(
    @Id int
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete the record based on the @Id parameter
    DELETE FROM [dbo].[FinishingProductModel]
    WHERE [Id] = @Id;
END
