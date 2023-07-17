USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetSubClientCompanyProfileInfo]    Script Date: 6/20/2023 3:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================-- Author:		<Author,,Name>-- Create date: <Create Date,,>-- Description:	<Description,,>-- =============================================CREATE OR ALTER PROCEDURE [dbo].[PRO_GetDirectJobReceivedWithoutGivingByFilter]@Id varchar(100)=''ASBEGIN	-- SET NOCOUNT ON added to prevent extra result sets fromSET NOCOUNT ON;		SELECT	DJR.Id
			,EP.EmployeeCode
			,DJR.EmployeeName
			,CompanyName
			,DirectorName
			,ClientCompany
			,DJR.ClientName
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
			,NetAmt			,ReceivingDate			FROM DirectJobReceivedWithoutGiving DJR			LEFT JOIN EmployeePersonal EP ON EP.Id = DJR.EmpId			where DJR.Id = @IdEND