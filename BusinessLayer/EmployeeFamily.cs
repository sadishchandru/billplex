using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeFamily : Common
    {
        public Int32 EFEmpId { get; set; }
        public string EFEmpCode { get; set; }
        public string SNo { get; set; }
        public string EFName { get; set; }
        public string EFAddress { get; set; }
        public string EFArea { get; set; }
        public string EFDistrict { get; set; }
        public string EFState { get; set; }
        public string EFPin { get; set; }
        public string EFRelation { get; set; }
        public string EFDOB { get; set; }
        public string EFAge { get; set; }
        public string EFResiding { get; set; }
        public string EFRemark { get; set; }

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
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFEmpId, "@EmpId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFEmpCode, "@EmpCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SNo, "@SNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, EFName, "@Name", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFAddress, "@FAddress", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFArea, "@Farea", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFDistrict, "@Fdistrict", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFState, "@State", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFPin, "@Pincode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFRelation, "@EmployeeRelation", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, EFDOB, "@DoB", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFAge, "@Age", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFResiding, "@Residing", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EFRemark, "@Remark", ParameterDirection.Input));


                dbReader = ObjDbfactory.GetReader("PRO_UpdateFamily", false, objLstDbParams);

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
    }
}
