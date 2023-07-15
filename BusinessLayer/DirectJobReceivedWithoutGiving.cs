using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class DirectJobReceivedWithoutGiving : Common
    {
        public Int64 EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string CompanyName { get; set; }
        public string Director { get; set; }
        public string ClientComapny { get; set; }
        public string ClientName { get; set; }
        public string SubClientComapny { get; set; }
        public string SubClientName { get; set; }
        public string ProductModel { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Wages { get; set; }
        public string ProSize { get; set; }
        public string Color { get; set; }
        public string Quantity { get; set; }
        public string Weight { get; set; }
        public string IncentiveApplicable { get; set; }
        public string BDays { get; set; }
        public string ADays { get; set; }
        public string Deduction { get; set; }
        public string Total { get; set; }
        public string Conveyance { get; set; }
        public string Incentive { get; set; }
        public string NetAmt { get; set; }
        public List<DropDownItemInfo> EmployeePersonalList { get; set; }
        public List<DropDownItemInfo> ColorMasterList { get; set; }
        public List<DropDownItemInfo> FinishingProductList { get; set; }

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
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmployeeCode, "@EmpId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmployeeName, "@EmployeeName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, CompanyName, "@CompanyName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Director, "@DirectorName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ClientComapny, "@ClientCompany", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ClientName, "@ClientName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SubClientComapny, "@SubClientCompany", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SubClientName, "@SubClientName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductModel, "@ProductModel", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200,ProductCode, "@ProductCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductName, "@ProductName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Wages, "@Wages", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProSize, "@Prosize", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Color, "@color", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Quantity, "@Quantity", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Weight, "@Weight", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, IncentiveApplicable, "@IncentiveApplicable", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BDays, "@BDays", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ADays, "@ADays", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Deduction, "@Deduction", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Total, "@Total", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Conveyance, "@Conveyance", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Incentive, "@Incentive", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, NetAmt, "@NetAmt", ParameterDirection.Input));


                dbReader = ObjDbfactory.GetReader("PRO_UpdateDirectJobReceivedWithoutGiving", false, objLstDbParams);

                Result.Message = "Direct Job Received Without Giving Updated Successfully";
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
                dbReader = ObjDbfactory.GetReader("PRO_DeleteDirectJobReceivedWithoutGiving", false, objLstDbParams);

                Result.Message = "Direct Job Received Without Giving Deleted Successfully";
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
                Result.Status = ResultStatus.Error;

            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
