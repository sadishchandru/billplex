using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SubClientCompanyInfo : Common
    {
        public Int64 MainCompany { get; set; }
        public String Director { get; set; }
        public Int64 ClientCompany { get; set; }
        public String ContractorName { get; set; }
        public String SubCompanyCode { get; set; }
        public String SubCompanyName { get; set; }
        public String OfficeAddress { get; set; }
        public String State { get; set; }
        public String Pin { get; set; }
        public String BusinessNature { get; set; }
        public String StartingDate { get; set; }
        public String STDCode { get; set; }
        public String PhoneNo { get; set; }
        public String EmailId { get; set; }
        public String Website { get; set; }
        public String PfType { get; set; }
        public String PFCode { get; set; }
        public String PFDate { get; set; }
        public String EsiCode { get; set; }
        public String ESIDate { get; set; }
        public String FactoryActNo { get; set; }
        public String TinNo { get; set; }
        public String CstNo { get; set; }
        public String SsiNo { get; set; }
        
        public String PanNo { get; set; }
        public String TanNo { get; set; }
        public String LicenseNo { get; set; }
        public String Name { get; set; }
        public String FathersName { get; set; }
        public String Gender { get; set; }
        public String BloodGroup { get; set; }
        public String DOB { get; set; }
        public String AuthEmailId { get; set; }
        public String AuthAddress { get; set; }
        public String AuthState { get; set; }
        public String Authpin { get; set; }
        public String AuthMobileNo { get; set; }
        public String AuthPanNo { get; set; }
        public String AuthPercent { get; set; }
        public String ActiveStatus { get; set; }
        public List<DropDownItemInfo> MasterCompanyList { get; set; }
        public List<DropDownItemInfo> ClientCompanyList { get; set; }
        public List<DropDownItemInfo> SubClientBankList { get; set; }

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
                objLstDbParams.Add(new DbParams(DbType.String, 50, MainCompany, "@MasterCompanyld", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Director, "@Director", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, ClientCompany, "@ClientCompanyld", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ContractorName, "@ContractorName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SubCompanyCode, "@SubComCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SubCompanyName, "@SubComName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, OfficeAddress, "@ComOffAdd", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, State, "@ComState", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Pin, "@ComPin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, BusinessNature, "@ComNature", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, StartingDate == "" ? null : StartingDate, "@ComDatestart", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, STDCode, "@ComStdCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PhoneNo, "@ComPhone", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmailId, "@ComEmail", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Website, "@ComWebsite", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PfType, "@PfType", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PFCode, "@ComPfNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, PFDate == "" ? null : PFDate, "@ComPfDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EsiCode, "@ComEsiNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, ESIDate == "" ? null : ESIDate, "@ComEsiDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FactoryActNo, "@ComFactoryNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TinNo, "@ComTinNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CstNo, "@ComCstNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SsiNo, "@ComSsiNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PanNo, "@ComPanNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TanNo, "@ComTanNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, LicenseNo, "@ComLicenseno", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Name, "@AuthorName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, FathersName, "@AuthorFathername", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Gender, "@AuthorGender", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BloodGroup, "@AuthorBlood", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, DOB == "" ? null : DOB, "@AuthorDOB", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthEmailId, "@AuthorEmail", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthAddress, "@AuthorAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthState, "@AuthorState", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthMobileNo, "@AuthorMobile", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthPanNo, "@AuthorPan", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Authpin, "@AuthorPin", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AuthPercent, "@AuthorPercent", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ActiveStatus, "@AuthorActive", ParameterDirection.Input));


                dbReader = ObjDbfactory.GetReader("PRO_UpdateSubClientCompanyProfileInfo", false, objLstDbParams);

                Result.Message = "SubClient Company Updated Successfully";
                Result.Status = ResultStatus.Success;



                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }


            }
            catch (Exception ex)
            {
                Result.Message = ex.Message;
                Result.Status = ResultStatus.Success;

            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion


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
                dbReader = ObjDbfactory.GetReader("PRO_DeleteSubClientMaster", false, objLstDbParams);

                Result.Message = "Sub Client Master Deleted Successfully";
                Result.Status = ResultStatus.Success;

                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }


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

