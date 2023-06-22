using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClientCompanyInfo : Common
    {
        public Int64 MainCompany { get; set; }
        public string Director { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string OffAddress { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public string BusinessNature { get; set; }
        public string Startingdate { get; set; }
        public string stdCode { get; set; }
        public string CompanyPhone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PfType { get; set; }
        public string PFCode { get; set; }
        public string PFdate { get; set; }
        public string EsiCode { get; set; }
        public string ESIdate { get; set; }
        public string FactoryAct { get; set; }
        public string Tin { get; set; }
        public string CSTno { get; set; }
        public string Ssi { get; set; }
        public string PanNo { get; set; }
        public string Tan { get; set; }
        public string License { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }
        public string Gender { get; set; }
        public string AuthBloodGroup { get; set; }
        public string DOB { get; set; }
        public string AuthEmail { get; set; }
        public string AuthAddress { get; set; }
        public string AuthState { get; set; }
        public string Authpin { get; set; }
        public string mobile { get; set; }
        public string AuthPanNo { get; set; }
        public string Percent { get; set; }
        public string ActiveStatus { get; set; }
        public List<DropDownItemInfo> MasterCompanyList { get; set; }
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
                objLstDbParams.Add(new DbParams(DbType.String, 50, MainCompany, "@MasterCompanyId", ParameterDirection.Input));
                // objLstDbParams.Add(new DbParams(DbType.String, 50, Director, "@ComName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, CompanyCode, "@ComCcode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CompanyName, "@ComCname", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, OffAddress, "@ComCoffAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, State, "@ComCstate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Pin, "@ComCPin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BusinessNature, "@ComCNature", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, Startingdate == "" ? null : Startingdate, "@ComCDatestart", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, stdCode, "@ComStdCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, CompanyPhone, "@ComCPhone", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Email, "@ComCEmail", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Website, "@ComCWebsite", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PfType, "@PfType", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PFCode, "@ComCPFno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, PFdate == ""? null : PFdate, "@ComCPFdate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EsiCode, "@ComCESino", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, ESIdate == "" ? null : ESIdate, "@ComCESIdate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FactoryAct, "@ComCFactoryNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Tin, "@ComCTINno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CSTno, "@ComCCSTno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Ssi, "@ComCSSLno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PanNo, "@ComCPanno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Tan, "@ComCTanno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, License, "@ComCLicenseno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Name, "@ComCPname", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Fathername, "@CCPFathername", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Gender, "@CCPGender", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthBloodGroup, "@CCPblood", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, DOB == "" ? null : DOB, "@CCPDOB", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthEmail, "@CCPEmail", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthAddress, "@CCPAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthState, "@CCPstate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Authpin, "@CCPpin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthPanNo, "@CCPPan", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Percent, "@CCPpercent", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ActiveStatus, "@CCPactive", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateClientCompanyProfileInfo", false, objLstDbParams);

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

        #region Delete

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

                dbReader = ObjDbfactory.GetReader("PRO_DeleteClientMaster", false, objLstDbParams);


                Result.Message = "Client Company Master Deleted Successfully";
                Result.Status = ResultStatus.Success;

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
    }
}
