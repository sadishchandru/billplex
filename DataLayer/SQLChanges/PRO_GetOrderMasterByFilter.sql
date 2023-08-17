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
				OM.Id,
				OM.OrderNo,
				Orderdate,
				OM.Customcode,
				CM.Code,
				OM.CustomerId,
				CM.Name,
				ProductNameId,
				Pm.Productmodel,
				OM.productmodel,
				OM.productcode,
				OM.productsize,
				Quantity,
				OM.RawmaterialId,
				RawType,
				ColorId,
				CMM.Colournname AS Color,
				RawQty,
				TotalRaw,
				TotalWt,
				Delivarydate,
				WagesforEmp,
				Status,
				AdditionalReason
			FROM OrderMaster OM
			left join CustomerMaster CM on CM.Id = OM.CustomerId
			left join Productmodeltemp PM on PM.Id = OM.ProductNameId
			left join ColourMaster CMM on CMM.Id = OM.ColorId
        WHERE OrderNo = @OrderNo;
 
END