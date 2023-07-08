using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DeliveryChallanInfro : Common
    {
        public Int64 CompanyMasterId { get; set; }
        public string Director { get; set; }
        public Int64 ClientCompanyId { get; set; }
        public string Contractor { get; set; }
        public Int64 SubclientCompanyId { get; set; }
        public string Subcontractor { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public Int64 OrderNo { get; set; }
        public string ModelCode { get; set; }
        public string ModelName { get; set; }
        public string ProductName { get; set; }
        public string RawMaterial { get; set; }
        public string RawType { get; set; }
        public string ProductSize { get; set; }
        public string OrderDate { get; set; }
        public Int64 ColourName { get; set; }
        public Int32 Quantity { get; set; }
        public Int64 Weight { get; set; }
        public Int64 Excess { get; set; }
        public string AvlQty { get; set; }
        public Int64 Shortage { get; set; }
        public Int64 DcNo { get; set; }
        public string DcDate { get; set; }
        public Int64 OrderQty { get; set; }
        public Int64 OrderWeight { get; set; }
        public List<DropDownItemInfo> MasterCompanyList { get; set; }
        public List<DropDownItemInfo> ClientCompanyList { get; set; }
        public List<DropDownItemInfo> SUbClientCompanyList { get; set; }
        public List<DropDownItemInfo> ProductMasterList { get; set; }
        public List<DropDownItemInfo> CustomerMasterList { get; set; }
        public List<DropDownItemInfo> ColorMasterList { get; set; }
        public List<DropDownItemInfo> OrderMasterList { get; set; }
        public List<DropDownItemInfo> IncentiveMasterList { get; set; }





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
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, CompanyMasterId, "@CompanyMasterId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, Director, "@Director", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, ClientCompanyId, "@ClientCompanyId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Contractor, "@Contractor", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, SubclientCompanyId, "@SubclientCompanyId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Subcontractor, "@Subcontractor", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerCode, "@CustomerCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, CustomerName, "@CustomerName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 200, OrderNo, "@OrderNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ModelCode, "@ModelCode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ModelName, "@ModelName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductName, "@ProductName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, RawMaterial, "@RawMaterial", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, RawType, "@RawType", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductSize, "@ProductSize", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime,50, OrderDate == "" ? null : OrderDate, "@OrderDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, ColourName, "@ColourName", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int32, 50, Quantity, "@Quantity", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, Weight, "@Weight", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, Excess, "@Excess", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, AvlQty, "@AvlQty", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, Shortage, "@Shortage", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, DcNo, "@DcNo", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.DateTime, 50, DcDate == "" ? null : DcDate, "@DcDate", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, OrderQty, "@OrderQty", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.Int64, 50, OrderWeight, "@OrderWeight", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateDeliveryChallanInfo", false, objLstDbParams);

                Result.Message = "Delivery Challan Updated Successfully";
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

                dbReader = ObjDbfactory.GetReader("PRO_DeleteDeliveryChallanInfo", false, objLstDbParams);


                Result.Message = "Challan Deleted Successfully";
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
