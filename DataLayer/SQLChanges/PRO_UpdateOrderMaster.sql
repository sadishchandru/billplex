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
	@Customcode  varchar(100)='',
	@CustomerId  INT = 0,
	@ProductNameId  INT=0,
	@productmodel varchar(100) = '',
	@productcode varchar(100) = '',
	@productsize varchar(100) = '',
	@Quantity  varchar(100)='',
	@RawType  varchar(100)='',
	@RawmaterialId  varchar(50)='',	
	@ColorId  INT=0,
	@RawQty  varchar(100)='',
	@Delivarydate  date=NULL, 
	@Status  Varchar(50)='', 
	@TotalRaw  varchar(100) ='',
	@WagesforEmp  varchar(100)='',
	@totalWt varchar(100) = '',
	--@AvlQty  varchar(250)='',
	--@Avlweight  varchar(100) ='',
	@AdditionalReason varchar(250) = '',
	@updateOn datetime = null
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO OrderMaster
		(		
			
			OrderNo
			,Orderdate
			,Customcode
			,CustomerId
			,ProductNameId
			,productmodel
			,productcode
			,productsize
			,Quantity
			,RawmaterialId
			,RawType
			,ColorId
			,RawQty
			,TotalRaw
			,totalWt
			,Delivarydate
			,WagesforEmp
			,Status
			,AdditionalReason
			--,AvlQty
			--,Avlweight
		) VALUES
		(
				@OrderNo,
				@Orderdate,
				@Customcode,
				@CustomerId,
				@ProductNameId,
				@productmodel,
				@productcode,
				@productsize,
				@Quantity,
				@RawmaterialId,
				@RawType,
				@ColorId,
				@RawQty,
				@TotalRaw,
				@totalWt,
				@Delivarydate,
				@WagesforEmp,
				@Status,
				@AdditionalReason
				--@AvlQty,
				--@Avlweight
				
		)

		SET @ResultMessage = 'Order Master Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE OrderMaster 
		SET	
		        
				[OrderNo]=@OrderNo,
				[Orderdate]=@Orderdate,
				[Customcode]=@Customcode,
				[CustomerId]=@CustomerId,
				[ProductNameId]=@ProductNameId,
				[Quantity]=@Quantity,
				[RawmaterialId]=@RawmaterialId,
				[RawType]=@RawType,
				[ColorId]=@ColorId,
				[RawQty]=@RawQty,
				[TotalRaw]=@TotalRaw,
				[Delivarydate]=@Delivarydate,
				[WagesforEmp]=@WagesforEmp,
				[TotalWt]=@totalWt,
				[Status]=@Status,
				[AdditionalReason] = @AdditionalReason
				--[AvlQty]=@AvlQty,
				--[Avlweight]=@Avlweight
		WHERE Id = @Id
		
		SET @ResultMessage = 'OrderMaster Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo

	IF(@ResultNo = 1)
	BEGIN
		EXEC PRO_GetOrderMasterByFilter @OrderNo = @OrderNo;
	END
		

END
