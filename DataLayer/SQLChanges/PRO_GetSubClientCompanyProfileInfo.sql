USE [Billplex]
GO
/****** Object:  StoredProcedure [dbo].[PRO_GetSubClientCompanyProfileInfo]    Script Date: 6/20/2023 3:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================-- Author:		<Author,,Name>-- Create date: <Create Date,,>-- Description:	<Description,,>-- =============================================ALTER     PROCEDURE [dbo].[PRO_GetSubClientCompanyProfileInfo]ASBEGIN	-- SET NOCOUNT ON added to prevent extra result sets fromSET NOCOUNT ON;		SELECT	Id,			--MasterCode,			MasterCompanyId,			ClientCompanyId,			SubComCode,			SubComName,			ComOffAdd,			ComState,			ComPin,			ComNature,			Director,			ComDatestart,			ComStdCode,			ComPhone,			ComEmail,			ComWebsite,			PfType,			ComPfNo,			ComPfDate,			ComEsiNo,			ComEsiDate,			ComFactoryNo,			ComCstNo,			ComSslNo,			ComTinNo,			ComLicenseno,			ComPanNo,			ComTanNo,			AuthorName,			AuthorFathername,			AuthorGender,			AuthorBlood,			AuthorDOB,			AuthorEmail,			AuthorAddress,			AuthorState,			AuthorPin,			AuthorMobile,			AuthorPan,			AuthorPercent,			AuthorActive			FROM SubClientMaster SCMEND