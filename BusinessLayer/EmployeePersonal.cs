using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer

{
    public class EmployeePersonal: Common
    {
        public string EmployeeCode { get; set; }
        public Int64 EMasterCompany { get; set; }
        public string EProprietorName { get; set; }
        public Int64 EClientCompany { get; set; }
        public string EClientName { get; set; }
        public Int64 ESubClientCompany { get; set; }
        public string ESubClientName { get; set; }
        public string EEmployeeCode { get; set; }
        public string EEmployeeName { get; set; }
        public string EVoterIdNo { get; set; }
        public string EDrivingLicNo { get; set; }
        public string EPanNo { get; set; }
        public string EPassportNo { get; set; }
        public string EIdentityMark { get; set; }
        public string EPAddress { get; set; }
        public string EPVillageArea { get; set; }
        public string EPState { get; set; }
        public string EPDistrict { get; set; }
        public string EPPincode { get; set; }
        public string ECAddress { get; set; }
        public string ECVillageArea { get; set; }
        public string ECDistrict { get; set; }
        public string ECState { get; set; }
        public string ECPincode { get; set; }
        public string EDOB { get; set; }
        public string EGender { get; set; }
        public string EBloodGroup { get; set; }
        public string EEmailId { get; set; }
        public string EmobileNo { get; set; }
        public string EFatherName { get; set; }
        public string EMotherName { get; set; }
        public string EMaritalStatus { get; set; }
        public string EStdCode { get; set; }
        public string EPhone { get; set; }
        public string EReligion { get; set; }
        public string ECast { get; set; }
        public string Enationality { get; set; }
        public string EJoiningDate { get; set; }
        public string EProbPeriod { get; set; }
        public string EConfirmDate { get; set; }
        public string EResigningDate { get; set; }
        public string ESelectWithReason { get; set; }
        public string EPhoto { get; set; }
        public List<DropDownItemInfo> MasterCompanyList { get; set; }
        public List<DropDownItemInfo> ClientCompanyList { get; set; }
        public List<DropDownItemInfo> SubClientCompanyList { get; set; }
        public List<DropDownItemInfo> EmployeeCodeList { get; set; }


        #region Update

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a Employee Personal
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, Id, "@Id", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EEmployeeCode, "@EmployeeCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, EMasterCompany, "@MasterCompanyld", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EProprietorName, "@ContractorName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 200, EClientCompany, "@ClientCompanyld", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EClientName, "@ClientName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, ESubClientCompany, "@SubCompanyld", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ESubClientName, "@SubCompanyName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EEmployeeName, "@EmployeeName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EVoterIdNo, "@Voterld", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, EDrivingLicNo, "@DrivingNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EPanNo, "@Pan", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EPassportNo, "@PassportNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EIdentityMark, "@IdentityMark", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EPAddress, "@PAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EPVillageArea, "@PArea", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EPState, "@PState", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EPDistrict, "@PDistrict", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EPPincode, "@PPincode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ECAddress, "@CAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ECVillageArea, "@CArea", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ECDistrict, "@CDistrict", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ECState, "@CState", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ECPincode, "@CPincode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, EDOB == "" ? null : EDOB, "@DoB", ParameterDirection.Input));
                //objLstDbParams.Add(new DbParams(DbType.Date, 50, EDOB, "@DoB", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EGender, "@Gender", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EBloodGroup, "@BloodGroup", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, EEmailId, "@Email", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmobileNo, "@Mobile", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFatherName, "@FName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EMotherName, "@MName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EMaritalStatus, "@MStatus", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EStdCode, "@SCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EPhone, "@Phone", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, EReligion, "@Religion", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ECast, "@Caste", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Enationality, "@Nationality", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, EJoiningDate == "" ? null : EJoiningDate, "@EJoiningDate", ParameterDirection.Input));
                //objLstDbParams.Add(new DbParams(DbType.String, 50, EJoiningDate, "@EJoiningDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EProbPeriod, "@EProbationPeriod", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, EConfirmDate == "" ? null : EConfirmDate, "@EConfirmationDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Date, 50, EResigningDate == "" ? null : EResigningDate, "@EResigningDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ESelectWithReason, "@Reason", ParameterDirection.Input));
                //objLstDbParams.Add(new DbParams(DbType.String, 50, EPhoto, "@EmpImage", ParameterDirection.Input));




                dbReader = ObjDbfactory.GetReader("PRO_UpdateEmployeePersonal", false, objLstDbParams);

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
    }
}
