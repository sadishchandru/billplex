USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetSubClientCompanyProfileInfo]    Script Date: 6/20/2023 3:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
			,NetAmt