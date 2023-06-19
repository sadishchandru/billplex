using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CompanyBankInfo : Common
    {
        public String MainCompany { get; set; }
        public String BankName { get; set; }
        public String BankAcNo { get; set; }
        public String Address { get; set; }
        public String BranchCode { get; set; }
        public String BranchName { get; set; }
        public String IFSCode { get; set; }

        public List<DropDownItemInfo> MasterCompanyList { get; set; }

        

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                // Calling the stored procedure for creating a new Company Profile
                List<DbParams> objLstDbParams = new List<DbParams>();
                objLstDbParams.Add(new DbParams(DbType.String, 50, MainCompany, "@MainCompanyId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BankName, "@BankName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BankAcNo, "@BankAcNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Address, "@Address", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BranchCode, "@BranchCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BranchName, "@BranchName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, IFSCode, "@IFSCode", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateMainBankInfo", false, objLstDbParams);

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
