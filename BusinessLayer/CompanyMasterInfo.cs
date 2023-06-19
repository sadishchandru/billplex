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
        public string LicenseNo{ get; set; }
        public string Name { get; set; }
        public string FathersName { get; set; }
        public string Gender{ get; set; }
        public string Address{ get; set; }
        public string AuthStartingDate{ get; set; }
        public string AuthPin{ get; set; }
        public string AuthStdCode{ get; set; }
        public string AuthPhoneNo{ get; set; }
        public string AuthorBloodGroup { get; set; }
        public string DOB { get; set; }
        public string AuthEmail { get; set; }
        public string AuthMobile { get; set; }
        public string AuthorPanNo { get; set; }
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
                objLstDbParams.Add(new DbParams(DbType.String, 50, Code, "@ComCcode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CompanyName, "@ComName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, OffAddress, "@ComOffAdd", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, State, "@Comstate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, StatePin, "@ComPin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, StdCode, "@ComStdCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PhoneNo, "@ComPhone", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, Startingdate, "@ComDatestart", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BusinessNature, "@ComNature", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmailID, "@ComEmail", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, Website, "@ComWebsite", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PFCode, "@ComPFno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, PfDate, "@ComPFdate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EsiCode, "@ComESIno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, EsiDate, "@ComESIdate", ParameterDirection.Input));
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
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthStartingDate, "@CAstate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthPin, "@CApin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthStdCode, "@CAStdCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthPhoneNo, "@CAPhoneno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthorBloodGroup, "@CAblood", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, DOB, "@CADOB", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthEmail, "@CAEmail", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthMobile, "@CAMobile", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthorPanNo, "@CAPan", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateCompanyProfileInfo", false, objLstDbParams);

                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }


            }
            catch (Exception ex)
            {
                // Display a warning alert
                // XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion

        public void Delete() {

            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a new Company Profile
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_DeleteCompanyMasterInfo", false, objLstDbParams);

                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }


            }
            catch (Exception ex)
            {
                // Display a warning alert
                // XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
