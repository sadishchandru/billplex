using System;
using System.Collections.Generic;
using DataLayer;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeNominee: Common
    {
        public string ENEmpCode { get; set; }
        public Int32 ENEmpId { get; set; }
        public string ENSno { get; set; }
        public string ENName { get; set; }
        public string ENAddress { get; set; }
        public string ENArea { get; set; }
        public string ENDistrict { get; set; }
        public string ENState { get; set; }
        public string ENPin { get; set; }
        public string ENRelation { get; set; }
        public string ENDob { get; set; }
        public string ENAge { get; set; }
        public string ENResidence { get; set; }
        public string ENgratuity { get; set; }
        public string ENMStatus { get; set; }
        public string ENReligion { get; set; }
        public string ENFName { get; set; }
        public string ENGName { get; set; }
        public string ENGAddress { get; set; }
        public string ENGRelation { get; set; }

        #region Update

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a Employee Finance
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENEmpId, "@EmpId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENEmpCode, "@EmpCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENSno, "@SNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENName, "@Name", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENAddress, "@FAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, ENArea, "@Farea", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENDistrict, "@Fdistrict", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENState, "@State", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENPin, "@Pincode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENRelation, "@EmployeeRelation", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENDob, "@DoB", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENAge, "@Age", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, ENResidence, "@Residing", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENgratuity, "@Porportion", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENMStatus, "@MaritalStatus", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENReligion, "@Religion", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENFName, "@FName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENGName, "@GuardianName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENGAddress, "@GuardianAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ENGRelation, "@GuardianRelation", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateNominee", false, objLstDbParams);

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
