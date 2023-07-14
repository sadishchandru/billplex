using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class JobGivingWithoutDc : Common
    {
        public Int64 EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string CompanyName { get; set; }
        public string ClientCompany { get; set; }
        public string ClientName { get; set; }
        public string SubClientCompany { get; set; }
        public string Date { get; set; }
        public Int64 OrderNo { get; set; }
        public string OrderDate { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ModelName { get; set; }
        public string ModelCode { get; set; }
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public string Color { get; set; }
        public string RawMaterial { get; set; }
        public string RawType { get; set; }
        public string QuantityPiece { get; set; }
        public string WeightKg { get; set; }
        public string AvlQty { get; set; }
        public string TotalQty { get; set; }
        public string TotalWt { get; set; }
        #region JobReallocation
        public string Shortage { get; set; }
        public string Excess { get; set; }
        public string subContractor { get; set; }
        public string Director { get; set; }
        #endregion
        public List<DropDownItemInfo> EmployeePersonalList { get; set; }
        public List<DropDownItemInfo> OrderMasterList { get; set; }

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
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmployeeCode, "@EmployeeCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, EmployeeName, "@EmployeeName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CompanyName, "@CompanyName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ClientCompany, "@ClientCompany", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ClientName, "@ClientName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, SubClientCompany, "@SubClientCompany", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Date, "@Date", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, OrderNo, "@OrderNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, OrderDate, "@OrderDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerCode, "@CustomerCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerName, "@CustomerName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ModelName, "@ModelName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ModelCode, "@ModelCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductName, "@ProductName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductSize, "@ProductSize", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Color, "@Color", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, RawMaterial, "@RawMaterial", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, RawType, "@Type", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, QuantityPiece, "@QuantityPiece", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, WeightKg, "@WeightKg", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AvlQty, "@AvlQty", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TotalQty, "@TotalQty", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, TotalWt, "@TotalWt", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Shortage, "@Shortage", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, subContractor, "@subContractor", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Director, "@Director", ParameterDirection.Input));


                dbReader = ObjDbfactory.GetReader("PRO_UpdateJobGivingWithoutDC", false, objLstDbParams);

                Result.Message = "Job Giving Without DC Updated Successfully";
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
                dbReader = ObjDbfactory.GetReader("PRO_DeleteJobGivingWithoutDC", false, objLstDbParams);

                Result.Message = "Job Giving Without DC Deleted Successfully";
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
