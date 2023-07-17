USE [BillPlex]
GO
--****** Object:  StoredProcedure [dbo].[PRO_UpdateCompanyProfileInfo]    Script Date: 01-06-2023 14:27:01 ******-
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 29-05-2023
-- Description:	Insert & Update Company Profile Info
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateDirectJobReceivedWithoutGiving]
@Id BIGINT =0,
@EmpId BIGINT = 0,
@EmployeeName varchar(50)='',
@CompanyName varchar(50)='',
@DirectorName varchar(50)='',
@ClientCompany varchar(50)='',
@ClientName varchar(50)='',
@SubClientCompany varchar(50)='',
@SubClientName varchar(50)='',
@ProductModel varchar(50)='',
@ProductCode varchar(50)='',
@ProductName varchar(50)='',
@Prosize varchar(50)='',
@Wages varchar(20)='',
@color varchar(50)='',
@Quantity varchar(10)='',
@Weight varchar(10)='',
@IncentiveApplicable varchar(10)='',
@BDays varchar(10)='',
@ADays varchar(10)='',
@Deduction varchar(10)='',
@Total varchar(10)='',
@Conveyance varchar(10)='',
@Incentive varchar(10)='',
@NetAmt varchar(10)='',
@ReceivingDate Date = null
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''
IF (@Id = 0)
    BEGIN
        INSERT INTO DirectJobReceivedWithoutGiving
            (
				EmpId
				,EmployeeName
				,CompanyName
				,DirectorName
				,ClientCompany
				,ClientName
				,SubClientCompany
				,SubClientName
				,ProductModel
				,ProductCode
				,ProductName
				,Prosize
				,Wages
				,color
				,Quantity
				,Weight
				,IncentiveApplicable
				,BDays
				,ADays
				,Deduction
				,Total
				,Conveyance
				,Incentive
				,NetAmt
				,ReceivingDate
            )
        VALUES
            (
				@EmpId
				,@EmployeeName
				,@CompanyName
				,@DirectorName
				,@ClientCompany
				,@ClientName
				,@SubClientCompany
				,@SubClientName
				,@ProductModel
				,@ProductCode
				,@ProductName
				,@Prosize
				,@Wages
				,@color
				,@Quantity
				,@Weight
				,@IncentiveApplicable
				,@BDays
				,@ADays
				,@Deduction
				,@Total
				,@Conveyance
				,@Incentive
				,@NetAmt
				,@ReceivingDate
            )

        SET @ResultMessage = ' Direct Job Received Without Giving Added Successfully';
        SET @ResultNo = 1
    END
    ELSE
    BEGIN
        UPDATE DirectJobReceivedWithoutGiving
        SET
			EmpId=@EmpId,
			EmployeeName=@EmployeeName,
			CompanyName=@CompanyName,
			DirectorName=@DirectorName,
			ClientCompany=@ClientCompany,
			ClientName=@ClientName,
			SubClientCompany=@SubClientCompany,
			SubClientName=@SubClientName,
			ProductModel=@ProductModel,
			ProductCode=@ProductCode,
			ProductName=@ProductName,
			Prosize=@Prosize,
			Wages=@Wages,
			color=@color,
			Quantity=@Quantity,
			Weight=@Weight,
			IncentiveApplicable=@IncentiveApplicable,
			BDays=@BDays,
			ADays=@ADays,
			Deduction=@Deduction,
			Total=@Total,
			Conveyance=@Conveyance,
			Incentive=@Incentive,
			NetAmt=@NetAmt,
			ReceivingDate = @ReceivingDate
        WHERE Id = @Id

        SET @ResultMessage = 'Direct Job Received Without Giving Updated Successfully';
        SET @ResultNo = 1
    END
	SELECT @ResultMessage AS ResultMessage, @ResultNo AS ResultNo

	SET @Id = @@IDENTITY

	IF(@ResultNo = 1)
	BEGIN
		EXEC PRO_GetDirectJobReceivedWithoutGivingByFilter @Id = @Id;
	END
END
