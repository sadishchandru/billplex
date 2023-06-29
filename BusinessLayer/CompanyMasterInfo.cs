using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CompanyMasterInfo : Common
    {
        public string Code { get; set; }
        public string CompanyName { get; set; }
        public string OffAddress { get; set; }
        public string State { get; set; }
        public string StatePin { get; set; }
        public string StdCode { get; set; }
        public string PhoneNo { get; set; }
        public string Startingdate { get; set; }
        public string BusinessNature { get; set; }
        public string EmailID { get; set; }
        public string Website { get; set; }
        public string PFCode { get; set; }
        public string PfDate { get; set; }
        public string EsiCode { get; set; }
        public string EsiDate { get; set; }
        public string FactoryAct { get; set; }
        public string TinNo { get; set; }
        public string CSTNo { get; set; }
        public string SSINo { get; set; }
        public string PanNo { get; set; }
        public string TanNo { get; set; }
        public string LicenseNo { get; set; }
        public string Name { get; set; }
        public string FathersName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string AuthState { get; set; }
        public string AuthPin { get; set; }
        public string AuthStdCode { get; set; }
        public string AuthPhoneNo { get; set; }
        public string AuthorBloodGroup { get; set; }
        public string DOB { get; set; }
        public string AuthEmail { get; set; }
        public string AuthMobile { get; set; }
        public string AuthorPanNo { get; set; }

        public List<DropDownItemInfo> MasterBankList { get; set; }

        public List<DropDownItemInfo> MasterCodeList { get; set; }
        public List<CompanyMasterInfo> MasterList { get; set; }

        public string AuthorStartDate { get; set; }
        #region Update

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a new Company Profile
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Code, "@ComCcode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CompanyName, "@ComName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, OffAddress, "ComOffAdd", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, State, "@Comstate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, StatePin, "@ComPin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, StdCode, "@ComStdCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PhoneNo, "@ComPhone", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, Startingdate == "" ? null : Startingdate, "@ComDatestart", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BusinessNature, "@ComNature", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmailID, "@ComEmail", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, Website, "@ComWebsite", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PFCode, "@ComPFno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, PfDate == "" ? null : PfDate, "@ComPFdate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EsiCode, "@ComESIno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, EsiDate == "" ? null : EsiDate, "@ComESIdate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FactoryAct, "@ComFactoryNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TinNo, "@ComTINno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CSTNo, "@ComCSTno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SSINo, "@ComSSLno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PanNo, "@ComPanno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TanNo, "@ComTanno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, LicenseNo, "@ComLicenseno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Name, "@CAuthorName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FathersName, "@CAFathername", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Gender, "@CAGender", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Address, "@CAAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthState, "@CAstate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthPin, "@CApin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthStdCode, "@CAStdCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthPhoneNo, "@CAPhoneno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthorBloodGroup, "@CAblood", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, DOB == "" ? null : DOB, "@CADOB", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthEmail, "@CAEmail", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthMobile, "@CAMobile", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthorPanNo, "@CAPan", ParameterDirection.Input));
                //objLstDbParams.Add(new DbParams(DbType.DateTime, 50, AuthStartingDate == "" ? null : AuthStartingDate, "@CAStartDate", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateCompanyProfileInfo", false, objLstDbParams);
                //MasterList = MasterResult();

                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }


            }
            catch (Exception ex)
            {
                Result.Message = ex.Message;
                Result.Status = ResultStatus.Error;

            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion
        public List<CompanyMasterInfo> MasterResult()
        {
            List<CompanyMasterInfo> MasterEntryList = new List<CompanyMasterInfo>();

            while (dbReader.Read())
            {
                CompanyMasterInfo companyDetails = new CompanyMasterInfo();
                companyDetails.Id = Convert.ToInt32(dbReader["Id"]);
                companyDetails.CompanyName = ToString(dbReader["ComName"]);
                companyDetails.Code = ToString(dbReader["ComCcode"]);
                companyDetails.OffAddress = ToString(dbReader["ComOffAdd"]);
                companyDetails.State = ToString(dbReader["Comstate"]);
                companyDetails.StatePin = ToString(dbReader["ComPin"]);
                companyDetails.StdCode = ToString(dbReader["ComStdCode"]);
                companyDetails.PhoneNo = ToString(dbReader["ComPhone"]);
                companyDetails.Startingdate = ToString(dbReader["ComDatestart"]);
                companyDetails.BusinessNature = ToString(dbReader["ComNature"]);
                companyDetails.EmailID = ToString(dbReader["ComEmail"]);
                companyDetails.Website = ToString(dbReader["ComWebsite"]);
                companyDetails.PFCode = ToString(dbReader["ComPFno"]);
                companyDetails.PfDate = ToString(dbReader["ComPFdate"]);
                companyDetails.EsiCode = ToString(dbReader["ComESIno"]);
                companyDetails.EsiDate = ToString(dbReader["ComESIdate"]);
                companyDetails.FactoryAct = ToString(dbReader["ComFactoryNo"]);
                companyDetails.TinNo = ToString(dbReader["ComTINno"]);
                companyDetails.CSTNo = ToString(dbReader["ComCSTno"]);
                companyDetails.SSINo = ToString(dbReader["ComSSLno"]);
                companyDetails.PanNo = ToString(dbReader["ComPanno"]);
                companyDetails.TanNo = ToString(dbReader["ComTanno"]);
                companyDetails.LicenseNo = ToString(dbReader["ComLicenseno"]);
                companyDetails.Name = ToString(dbReader["CAuthorName"]);
                companyDetails.FathersName = ToString(dbReader["CAFathername"]);
                companyDetails.Gender = ToString(dbReader["CAGender"]);
                companyDetails.Address = ToString(dbReader["CAAddress"]);
                companyDetails.AuthState = ToString(dbReader["CAstate"]);
                companyDetails.AuthPin = ToString(dbReader["CApin"]);
                companyDetails.AuthStdCode = ToString(dbReader["CAStdCode"]);
                companyDetails.AuthPhoneNo = ToString(dbReader["CAPhoneno"]);
                companyDetails.AuthorBloodGroup = ToString(dbReader["CAblood"]);
                companyDetails.DOB = ToString(dbReader["CADOB"]);
                companyDetails.AuthEmail = ToString(dbReader["CAEmail"]);
                companyDetails.AuthMobile = ToString(dbReader["CAMobile"]);
                companyDetails.AuthorPanNo = ToString(dbReader["CAPan"]);

                MasterEntryList.Add(companyDetails);
            }
            return MasterEntryList;
        }

        public void Delete()
        {

            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a new Company Profile
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_DeleteCompanyMasterInfo", false, objLstDbParams);


                Result.Message = "Company Master Deleted Successfully";
                Result.Status = ResultStatus.Success;


            }
            catch (Exception ex)
            {
                Result.Message = ex.Message;                Result.Status = ResultStatus.Error;

            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
