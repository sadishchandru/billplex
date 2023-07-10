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
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateJobReceived]
    @Id BIGINT = 0,
    @EmployeeCode VARCHAR(100) = '',
    @EmployeeName VARCHAR(100) = '',
    @CustomerName VARCHAR(100) = '',
    @RawMaterialName VARCHAR(100) = '',
    @Quantity VARCHAR(100) = '',
    @Wages VARCHAR(100) = '',
    @PendingQty VARCHAR(100) = '',
    @ModelName VARCHAR(100) = '',
    @Type VARCHAR(100) = '',
    @Weight VARCHAR(100) = '',
    @CurrentWt VARCHAR(100) = '',
    @RcvdQty VARCHAR(100) = '',
    @ReceivingDate DATE = NULL,
    @ProductModel VARCHAR(100) = '',
    @ProductCode VARCHAR(100) = '',
    @ProductSize VARCHAR(100) = '',
    @ProductColor VARCHAR(100) = '',
    @IncentiveApplicable VARCHAR(100) = '',
    @BeforeDays VARCHAR(100) = '',
    @AfterDays VARCHAR(100) = '',
    @BalanceWeight VARCHAR(100) = '',
    @Conveyance VARCHAR(100) = '',
    @Deduction VARCHAR(100) = '',
    @Incentive VARCHAR(100) = '',
    @Total VARCHAR(100) = '',
    @NetAmt VARCHAR(100) = ''
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ResultNo BIT = 0
    DECLARE @ResultMessage VARCHAR(MAX) = ''

    IF (@Id = 0)
    BEGIN
        INSERT INTO [dbo].[JobReceived]
            (
                EmployeeCode,
                EmployeeName,
                CustomerName,
                RawMaterialName,
                Quantity,
                Wages,
                PendingQty,
                ModelName,
                Type,
                Weight,
                CurrentWt,
                RcvdQty,
                ReceivingDate,
                ProductModel,
                ProductCode,
                ProductSize,
                ProductColor,
                IncentiveApplicable,
                BeforeDays,
                AfterDays,
                BalanceWeight,
                Conveyance,
                Deduction,
                Incentive,
                Total,
                NetAmt
            )
        VALUES
            (
                @EmployeeCode,
                @EmployeeName,
                @CustomerName,
                @RawMaterialName,
                @Quantity,
                @Wages,
                @PendingQty,
                @ModelName,
                @Type,
                @Weight,
                @CurrentWt,
                @RcvdQty,
                @ReceivingDate,
                @ProductModel,
                @ProductCode,
                @ProductSize,
                @ProductColor,
                @IncentiveApplicable,
                @BeforeDays,
                @AfterDays,
                @BalanceWeight,
                @Conveyance,
                @Deduction,
                @Incentive,
                @Total,
                @NetAmt
            )

        SET @ResultMessage = 'JobReceived Added Successfully';
        SET @ResultNo = 1
    END
    ELSE
    BEGIN
        UPDATE JobReceived
        SET
            [EmployeeCode] = @EmployeeCode,
            [EmployeeName] = @EmployeeName,
            [CustomerName] = @CustomerName,
            [RawMaterialName] = @RawMaterialName,
            [Quantity] = @Quantity,
            [Wages] = @Wages,
            [PendingQty] = @PendingQty,
            [ModelName] = @ModelName,
            [Type] = @Type,
            [Weight] = @Weight,
            [CurrentWt] = @CurrentWt,
            [RcvdQty] = @RcvdQty,
            [ReceivingDate] = @ReceivingDate,
            [ProductModel] = @ProductModel,
            [ProductCode] = @ProductCode,
            [ProductSize] = @ProductSize,
            [ProductColor] = @ProductColor,
            [IncentiveApplicable] = @IncentiveApplicable,
            [BeforeDays] = @BeforeDays,
            [AfterDays] = @AfterDays,
            [BalanceWeight] = @BalanceWeight,
            [Conveyance] = @Conveyance,
            [Deduction] = @Deduction,
            [Incentive] = @Incentive,
            [Total] = @Total,
            [NetAmt] = @NetAmt
        WHERE Id = @Id

        SET @ResultMessage = 'JobReceived Updated Successfully';
        SET @ResultNo = 1
    END

    SELECT @ResultMessage AS ResultMessage, @ResultNo AS ResultNo
END
