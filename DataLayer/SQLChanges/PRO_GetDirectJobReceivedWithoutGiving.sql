USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetSubClientCompanyProfileInfo]    Script Date: 6/20/2023 3:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================-- Author:		<Author,,Name>-- Create date: <Create Date,,>-- Description:	<Description,,>-- =============================================CREATE OR ALTER PROCEDURE [dbo].[PRO_GetDirectJobReceivedWithoutGiving]ASBEGIN	-- SET NOCOUNT ON added to prevent extra result sets fromSET NOCOUNT ON;		SELECT	Id
			,EmpId
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
			,NetAmt			FROM DirectJobReceivedWithoutGivingEND