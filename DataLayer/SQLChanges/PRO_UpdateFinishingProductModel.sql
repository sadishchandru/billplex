USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_UpdateColourMaster]    Script Date: 16/06/2023 10:28:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Company Profile Info
-- =============================================
CREATE OR ALTER   PROCEDURE [dbo].[PRO_UpdateFinishingProductModel]
	@Id int = 0 ,
	@ProductNameId iNT = 0,
	@Productcode varchar(100) = '',
	@Productmodel varchar(100) = '',
	@Productsize varchar(100) = '',
	@WagesforProduct varchar(100) = '',
	@ItemDate date = null
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF(@Id = 0)
	BEGIN
		INSERT INTO[dbo].[FinishingProductModel]
		(		
			ProductNameId,
			Productcode,
			Productmodel,
			Productsize,
			WagesforProduct,
			ItemDate
		) VALUES
		(			
			@ProductNameId,
			@Productcode,
			@Productmodel,
			@Productsize,
			@WagesforProduct,
			@ItemDate
		)
		SET @ResultMessage = 'FinishingProductModel Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE [FinishingProductModel] 
		SET	
	    --[Id] = @Id,
			[ProductNameId]= @ProductNameId,
			[Productcode]= @Productcode,
			[Productmodel]=@Productmodel,
			[Productsize] = @Productsize,
			[WagesforProduct] = @WagesforProduct,
			[ItemDate]=@ItemDate
		WHERE Id = @Id
		SET @ResultMessage = 'FinishingProductModel Updated Successfully';
		SET @ResultNo = 1
	END

	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
		

END
