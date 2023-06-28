using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SubClientCompanyBank: Common
    {
        public Int64 SubClientCompanyId { get; set; }
        public Int64 ClientCompanyId { get; set; }  
        public string BankName { get; set; }
        public string BankAcNo { get; set; }
        public string Address { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string IFSCode { get; set; }
        public List<DropDownItemInfo> ClientCompanyList { get; set; }
        public List<DropDownItemInfo> SubClientCompanyList { get; set; }

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a new Company Profile
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, Id, "@Id", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SubClientCompanyId, "@SubClientCompanyId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ClientCompanyId, "@ClientCompanyId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BankName, "@BankName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BankAcNo, "@BankAcNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Address, "@Address", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BranchCode, "@BranchCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BranchName, "@BranchName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, IFSCode, "@IFSCode", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateSubClientBankInfo", false, objLstDbParams);

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
    }
}
