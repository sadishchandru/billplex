using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderMasterInfo : Common
    {
        public Int64 Id { get; set; }
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }
        public Int64 CustomerCodeId { get; set; }
        public Int64 CustomerId { get; set; }
        public string ProductId { get; set; }
        public Int64 ProductNameId { get; set; }
        public string ProductModel { get; set; }
        public string ProductCode { get; set; }
        public string ProductSize { get; set; }
        public string Quantity { get; set; }
        public string RawMaterialId { get; set; }
        public string RawType { get; set; }
        public Int64 ColorId { get; set; }
        public string RawQty { get; set; }
        public string TotalRaw { get; set; }
        public string Deliverydate { get; set; }
        public string WagesforEmp { get; set; }
        public string status { get; set; }

        public List<DropDownItemInfo> ProductModelList { get; set; }
        public List<DropDownItemInfo> CustomerMasterList { get; set; }
        public List<DropDownItemInfo> ProductMasterList { get; set; }
        public List<DropDownItemInfo> ColourMasterList { get; set; }
        public List<OrderMasterInfo> OrderMasterList { get; set; }

        #region Update
        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.Int64, 50, Id, "@Id", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, OrderNo, "@OrderNo", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.Date, 50, OrderDate, "@OrderDate", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, CustomerCodeId, "@Customcode", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, CustomerId, "@CustomerId", ParameterDirection.Input));
                //objLstdbParams.Add(new DbParams(DbType.String, 50, ProductId, "@ProductId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductNameId, "@ProductNameId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductModel, "@productmodel", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductCode, "@productcode", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductSize, "@productsize", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, Quantity, "@Quantity", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawMaterialId, "@RawMaterialId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawType, "@RawType", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ColorId, "@ColorId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawQty, "@RawQty", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, TotalRaw, "@TotalRaw", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.Date, 50, Deliverydate, "@Delivarydate", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, WagesforEmp, "@WagesforEmp", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, status, "@status", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateOrderMaster", false, objLstdbParams);

                while (dbReader.Read())
                {
                    Result.Message = ToString(dbReader["ResultMessage"]);
                    Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                }

                if (Result.Status == ResultStatus.Success)
                {
                    OrderMasterList = AssignResult();
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

        public List<OrderMasterInfo> AssignResult()
        {
            List<OrderMasterInfo> FamilyList = new List<OrderMasterInfo>();
            dbReader.NextResult();

            while (dbReader.Read())
            {
                OrderMasterInfo OrderDetail = new OrderMasterInfo();
                OrderDetail.Id = ToInteger(dbReader["Id"]);
                OrderDetail.OrderNo = ToString(dbReader["OrderNo"]);
                OrderDetail.OrderDate = ToDateTimeToString(dbReader["Orderdate"]);
                OrderDetail.CustomerCodeId = ToInteger(dbReader["Customcode"]);
                OrderDetail.CustomerId = ToInteger(dbReader["CustomerId"]);
                OrderDetail.ProductId = ToString(dbReader["ProductNameId"]);
                OrderDetail.ProductModel = ToString(dbReader["productmodel"]);
                OrderDetail.ProductCode = ToString(dbReader["productcode"]);
                OrderDetail.ProductSize = ToString(dbReader["productsize"]);
                OrderDetail.Quantity = ToString(dbReader["Quantity"]);
                OrderDetail.RawType = ToString(dbReader["RawmaterialId"]);
                OrderDetail.RawMaterialId = ToString(dbReader["RawType"]);
                OrderDetail.ColorId = ToInteger(dbReader["ColorId"]);
                OrderDetail.RawQty = ToString(dbReader["RawQty"]);
                OrderDetail.Deliverydate = ToDateTimeToString(dbReader["Delivarydate"]);
                OrderDetail.status = ToString(dbReader["Status"]);
                OrderDetail.TotalRaw = ToString(dbReader["TotalRaw"]);
                OrderDetail.WagesforEmp = ToString(dbReader["WagesforEmp"]);

                FamilyList.Add(OrderDetail);
            }

            return FamilyList;
        }
        #endregion

        #region Delete

        public void Delete()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_DeleteOrderMaster", false, objLstdbParams);

                Result.Message = "Order Master Deleted Successfully";
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


    }
}
