using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class JobReceivedInfo : Common
    {
        public Int64 EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerName { get; set; }
        public string RawMaterialName { get; set; }
        public string Quantity { get; set; }
        public string Wages { get; set; }
        public string PendingQty { get; set; }
        public string ModelName { get; set; }
        public string Type { get; set; }
        public string Weight { get; set; }
        public string CurrentWt { get; set; }
        public string RcvdQty { get; set; }
        public string ReceivingDate { get; set; }
        public string ProductModel { get; set; }
        public string ProductCode { get; set; }
        public string ProductSize { get; set; }
        public string ProductColor { get; set; }
        public string IncentiveApplicable { get; set; }
        public string BeforeDays { get; set; }
        public string AfterDays { get; set; }
        public string BalanceWeight { get; set; }
        public string Conveyance { get; set; }
        public string Deduction { get; set; }
        public string Incentive { get; set; }
        public string Total { get; set; }
        public string NetAmt { get; set; }

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
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, EmployeeCode, "@EmployeeCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmployeeName, "@EmployeeName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerName, "@CustomerName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, RawMaterialName, "@RawMaterialName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Quantity, "@Quantity", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Wages, "@Wages", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, PendingQty, "@PendingQty", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ModelName, "@ModelName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Type, "@Type", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Weight, "@Weight", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerName, "@CustomerName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ModelName, "@ModelName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CurrentWt, "@CurrentWt", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, RcvdQty, "@RcvdQty", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ReceivingDate, "@ReceivingDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductModel, "@ProductModel", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductCode, "@ProductCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductSize, "@ProductSize", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductColor, "@ProductColor", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, IncentiveApplicable, "@IncentiveApplicable", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BeforeDays, "@BeforeDays", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AfterDays, "@AfterDays", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, BalanceWeight, "@BalanceWeight", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Conveyance, "@Conveyance", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Deduction, "@Deduction", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Incentive, "@Incentive", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Total, "@Total", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, NetAmt, "@NetAmt", ParameterDirection.Input));


                dbReader = ObjDbfactory.GetReader("PRO_UpdateJobReceived", false, objLstDbParams);

                Result.Message = "Job Received Updated Successfully";
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
                dbReader = ObjDbfactory.GetReader("PRO_DeleteJobReceived", false, objLstDbParams);

                Result.Message = "Job Received Deleted Successfully";
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
