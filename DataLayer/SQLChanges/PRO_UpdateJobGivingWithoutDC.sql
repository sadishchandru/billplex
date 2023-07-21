USE [Billplex]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Company Profile Info
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateJobGivingWithoutDC]
@Id BIGINT = 0,
@EmployeeCode VARCHAR(100) ='',
@EmployeeName VARCHAR(100) ='',
@CompanyName VARCHAR(100) ='',
@ClientCompany VARCHAR(100) ='',
@ClientName VARCHAR(100) ='',
@SubClientCompany VARCHAR(100) ='',
@OrderNo BIGINT = 0,
@Date Date ='',
@OrderDate DATE ='',
@CustomerCode VARCHAR(100) ='',
@CustomerName VARCHAR(100) ='',
@ModelName VARCHAR(100) ='',
@ModelCode VARCHAR(100) ='',
@ProductName VARCHAR(100) ='',
@ProductSize VARCHAR(100) ='',
@RawMaterial VARCHAR(100) ='',
@QuantityPiece VARCHAR(100) ='',
@WeightKg VARCHAR(100) ='',
@Excess VARCHAR(100) ='',
@Color VARCHAR(100) ='',
@Type VARCHAR(100) ='',
@AvlQty INT =0,
@TotalQty varchar(50)='',
@TotalWt varchar(100)= '',
@Shortage VARCHAR(100) = '',
@Director varchar(100) = '',
@subContractor varchar(100)=''
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ResultNo BIT = 0
    DECLARE @ResultMessage VARCHAR(MAX) = ''

    IF (@Id = 0)
    BEGIN
        INSERT INTO [dbo].[JobGivingWithoutDC]
            (
				EmployeeCode
				,EmployeeName
				,CompanyName
				,ClientCompany
				,ClientName
				,SubClientCompany
				,OrderNo
				,Date
				,OrderDate
				,CustomerCode
				,CustomerName
				,ModelName
				,ModelCode
				,ProductName
				,ProductSize
				,RawMaterial
				,QuantityPiece
				,WeightKg
				,Excess
				,Color
				,Type
				,AvlQty
				,Shortage
				,TotalQty
				,TotalWt
				,Director
				,subContractor

            )
        VALUES
            (
               @EmployeeCode,
                @EmployeeName,
                @CompanyName,
                @ClientCompany,
				@ClientName,
                @SubClientCompany,
                @OrderNo,
                @Date,
                @OrderDate,
                @CustomerCode,
                @CustomerName,
                @ModelName,
                @ModelCode,
                @ProductName,
                @ProductSize,
                @RawMaterial,
                @QuantityPiece,
                @WeightKg,
                @Excess,
                @Color,
                @Type,
                @AvlQty,
                @Shortage,
				@TotalQty,
				@TotalWt,
				@Director,
				@subContractor
            )

        SET @ResultMessage = 'JobGivingWithoutDC Added Successfully';
        SET @ResultNo = 1

    END
    ELSE
    BEGIN
        UPDATE JobGivingWithoutDC
        SET
            [EmployeeCode] = @EmployeeCode,
            [EmployeeName] = @EmployeeName,
            [CompanyName] = @CompanyName,
            [ClientCompany] = @ClientCompany,
            [SubClientCompany] = @SubClientCompany,
            [OrderNo] = @OrderNo,
            [Date] = @Date,
            [OrderDate] = @OrderDate,
            [CustomerCode] = @CustomerCode,
            [CustomerName] = @CustomerName,
            [ModelName] = @ModelName,
            [ModelCode] = @ModelCode,
            [ProductName] = @ProductName,
            [ProductSize] = @ProductSize,
            [RawMaterial] = @RawMaterial,
            [QuantityPiece] = @QuantityPiece,
            [WeightKg] = @WeightKg,
            [Excess] = @Excess,
            [Color] = @Color,
            [Type] = @Type,
            [AvlQty] = @AvlQty,
            [Shortage] = @Shortage,
			[TotalQty]=@TotalQty,
			[TotalWt]=@TotalWt,
			[Director]=@Director,
			[subContractor]=@subContractor
        WHERE Id = @Id

        SET @ResultMessage = 'JobGivingWithoutDC Updated Successfully';
        SET @ResultNo = 1
    END

    SELECT @ResultMessage AS ResultMessage, @ResultNo AS ResultNo
	IF(@ResultNo = 1)
	BEGIN
		EXEC PRO_GetJobGivingWithoutDCFilter @Id = @OrderNo;
	END
END
