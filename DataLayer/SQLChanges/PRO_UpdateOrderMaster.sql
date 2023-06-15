USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_UpdateNominee]    Script Date: 14/06/2023 11:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Company Profile Info
-- =============================================
CREATE or ALTER   PROCEDURE [dbo].[PRO_UpdateOrderMaster]
	@Id  BIGINT= 0,
	@OrderNo  varchar(100)='',
	@Orderdate  date = NULL, 
	@CustomcodeId  varchar(100)='',
	@CustomerId  INT = '',
	@ProductNameId  INT='',
	@Quantity  varchar(100)='',
	@RawmaterialId  INT='',
	@RawType  varchar(100)='',
	@ColorId  INT='',
	@RawQty  varchar(100)='',
	@TotalRaw  varchar(100) ='',
	@Delivarydate  date=NULL, 
	@WagesforEmp  varchar(100)='',
	@Status  INT='', 
	@AvlQty  varchar(250)='',
	@Avlweight  varchar(100) ='' 
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO OrderMaster
		(		
			
				[OrderNo],
				[Orderdate],
				[CustomcodeId],
				[CustomerId],
				[ProductNameId],
				[Quantity],
				[RawmaterialId],
				[RawType],
				[ColorId],
				[RawQty],
				[TotalRaw],
				[Delivarydate],
				[WagesforEmp],
				[Status],
				[AvlQty],
				[Avlweight]
		) VALUES
		(
				
				
				@OrderNo,
				@Orderdate,
				@CustomcodeId,
				@CustomerId,
				@ProductNameId,
				@Quantity,
				@RawmaterialId,
				@RawType,
				@ColorId,
				@RawQty,
				@TotalRaw,
				@Delivarydate,
				@WagesforEmp,
				@Status,
				@AvlQty,
				@Avlweight
		)

		SET @ResultMessage = 'Order Master Added Successfully';
		SET @ResultNo = 1
	END
	--ELSE
	--BEGIN
	--	UPDATE OrderMaster 
	--	SET	
	--	        
				--[OrderNo]=@OrderNo,
				--[Orderdate]=@Orderdate,
				--[CustomcodeId]=@CustomcodeId,
				--[CustomerId]=@CustomerId,
				--[ProductNameId]=@ProductNameId,
				--[Quantity]=@Quantity,
				--[RawmaterialId]=@RawmaterialId,
				--[RawType]=@RawType,
				--[ColorId]=@ColorId,
				--[RawQty]=@RawQty,
				--[TotalRaw]=@TotalRaw,
				--[Delivarydate]=@Delivarydate,
				--[WagesforEmp]=@WagesforEmp,
				--[Status]=@Status,
				--[AvlQty]=@AvlQty,
				--[Avlweight]=@Avlweight

	--	WHERE Id = @Id
		
	--	SET @ResultMessage = 'OrderMaster Updated Successfully';
	--	SET @ResultNo = 1
	--END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
