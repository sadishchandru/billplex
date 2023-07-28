USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetRawMaterial]    Script Date: 14/06/2023 11:55:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
 -- EXEC PRO_GetOrderMasterByFilter @OrderNo = '001';
CREATE OR ALTER   PROCEDURE [dbo].[PRO_GetOrderMasterByFilter]
@OrderNo VARCHAR(200) = ''

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
	


        SELECT 
            Id,
            OrderNo,
            Orderdate,
            Customcode,
            CustomerId,
            ProductNameId,
            productmodel,
            productcode,
            productsize,
            Quantity,
            RawmaterialId,
            RawType,
            ColorId,
            RawQty,
            TotalRaw,
            Delivarydate,
            WagesforEmp,
            Status,
			totalWt,
			AdditionalReason
        FROM OrderMaster
        WHERE OrderNo = @OrderNo;
 
END