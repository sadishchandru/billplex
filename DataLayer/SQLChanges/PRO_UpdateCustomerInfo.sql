USE [BillPlex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_UpdateClientCompanyProfileInfo]    Script Date: 05/06/2023 13:08:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Srinivasan V
-- Create date: 31-05-2023
-- Description:	Insert & Update CustomerDetails
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[PRO_UpdateCustomerInfo]
@Id bigint =0,
@Code varchar(100)= '',
@Name varchar(100)= '',
@OffAddress varchar(250)= '',
@State varchar(100)= '',
@Pin varchar(100)= '',
@Country varchar(100)= '',
@PhonePin varchar(100)= '',
@OffPhone varchar(100)= '',
@Email varchar(100)= '',
@ResAddress varchar(250)= '',
@ResState varchar(100)= '',
@ResPin varchar(100)= '',
@ResCountry varchar(100)= '',
@Mobile varchar(100)= '',
@TinNo varchar(100)= '',
@TinDate date= '',
@CstNo varchar(100)= '',
@CstDate date= '',
@LicenseNo varchar(100)= '',
@Website varchar(100)= ''
	
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @ResultNo BIT = 0
	DECLARE @ResultMessage VARCHAR(MAX) = ''

	IF EXISTS (SELECT NULL FROM CustomerMaster WHERE Code = @Code AND Id != @Id)
	BEGIN
	SET @ResultMessage = 'Customer Code already exists';
    SET @ResultNo = 1;
	END
	ELSE
	BEGIN
	IF(@Id = 0)
	BEGIN
		INSERT INTO CustomerMaster
		(
			[Code],
            [Name],
            [OffAddress],
            [State],
            [Pin],
            [Country],
            [PhonePin],
            [OffPhone],
            [Email],
            [ResAddress],
            [ResState],
            [ResPin],
            [ResCountry],
            [Mobile],
            [TinNo],
            [TinDate],
            [CstNo],
            [CstDate],
            [licenseNo],
            [Website]
		) VALUES
		(
            @Code,
            @Name,
            @OffAddress,
            @State,
            @Pin,
            @Country,
            @PhonePin,
            @OffPhone,
            @Email,
            @ResAddress,
            @ResState,
            @ResPin,
            @ResCountry,
            @Mobile,
            @TinNo,
            @TinDate,
            @CstNo,
            @CstDate,
            @LicenseNo,
            @Website
		)

		SET @ResultMessage = 'Customer Master Profile Added Successfully';
		SET @ResultNo = 1
	END
	ELSE
	BEGIN
		UPDATE CustomerMaster 
		SET	[Code] = @Code,
            [Name] = @Name,
            [OffAddress] = @OffAddress,
            [State] = @State,
            [Pin] = @Pin,
            [Country] = @Country,
            [PhonePin]= @PhonePin,
            [OffPhone] = @OffPhone,
            [Email] = @Email,
            [ResAddress] = @ResAddress,
            [ResState] = @ResState,
            [ResPin] = @ResPin,
            [ResCountry] = @ResCountry,
            [Mobile] = @Mobile,
            [TinNo] = @TinNo,
            [TinDate] = @TinDate,
            [CstNo] = @CstNo,
            [CstDate] = @CstDate,
            [licenseNo] = @LicenseNo,
            [Website] = @Website
		WHERE Id = @Id

		
		SET @ResultMessage = 'Customer Master Profile Updated Successfully';
		SET @ResultNo = 1
	END

	
END
	SELECT  @ResultMessage AS ResultMessage,
			@ResultNo AS ResultNo
END