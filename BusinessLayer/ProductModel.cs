using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductModel : Common
    {
        public Int64 RawMaterialType { get; set; }
        public Int64 RawMaterialId { get; set; }
        public Int64 ProductId { get; set; }
        public string ModelCode { get; set; }
        public string ModelName { get; set; }
        public string ProductSize { get; set; }
        public string RawMaterialStock { get; set; }
        public string RequiredRawMaterialWeight { get; set; }
        public string WagesForProductModel { get; set; }
        public string PMDate { get; set; }

        public List<DropDownItemInfo> RawMaterialList { get; set; }
        public List<DropDownItemInfo> ProductModelList { get; set; }
        public List<DropDownItemInfo> SizeMasterList { get; set; }
        public List<DropDownItemInfo> ProductMasterList { get; set; }

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.Int64, 50, Id, "Id", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawMaterialType, "RawmaterialTypeId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawMaterialId, "RawMaterialId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductId, "ProductId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ModelCode, "ProductCode", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ModelName, "ProductModel", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductSize, "ProductSize", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawMaterialStock, "RawMaterialStock", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RequiredRawMaterialWeight, "ReqRawMaterial", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, WagesForProductModel, "WagesforItem", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.DateTime, 50, PMDate == "" ? null : PMDate, "Date", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateProductModel", false, objLstdbParams);

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

                dbReader = ObjDbfactory.GetReader("PRO_DeleteProductModel", false, objLstdbParams);

                Result.Message = "Product Master Deleted Successfully";
                Result.Status = ResultStatus.Success;
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
