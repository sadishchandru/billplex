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
        public string RawMaterialType { get; set; }
        public string RawMaterialName { get; set; }
        public string ProductName { get; set; }
        public string ModelCode { get; set; }
        public string ModelName { get; set; }
        public string ProductSize { get; set; }
        public string RawMaterialStock { get; set; }
        public string RequiredRawMaterialWeight { get; set; }
        public string WagesForProductModel { get; set; }
        public string PMDate { get; set; }

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawMaterialType, "@RawmaterialTypeId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawMaterialName, "@RawMaterialId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductName, "@ProductId", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ModelCode, "@ProductCode", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ModelName, "@ProductModel", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductSize, "@ProductSize", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawMaterialStock, "@RawMaterialStock", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RequiredRawMaterialWeight, "@ReqRawMaterial", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, WagesForProductModel, "@WagesforItem", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, PMDate, "@Date", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateProductModel", false, objLstdbParams);

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
