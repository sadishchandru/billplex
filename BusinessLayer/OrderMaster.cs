using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderMaster : Common
    {
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string ModelName { get; set; }
        public string ProductSize { get; set; }
        public string MaterialWeight { get; set; }
        public string Type { get; set; }
        public string RawMaterialName { get; set; }
        public string ProductColor { get; set; }
        public string Quantity { get; set; }
        public string DeliveryDate { get; set; }
        public string status { get; set; }
        public string TotalRawMaterial { get; set; }
        public string WagesForEmployee { get; set; }

        #region Update
        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.String, 50, OrderNo, "@OrderNo", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, OrderDate, "@OrderDate", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, CustomerCode, "@CustomerCode", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, CustomerName, "@CustomerName", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductName, "@ProductName", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ModelName, "@ModelName", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductSize, "@ProductSize", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, MaterialWeight, "@MaterialWeight", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, Type, "@Type", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, RawMaterialName, "@RawMaterialName", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductColor, "@ProductColor", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, Quantity, "@Quantity", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, DeliveryDate, "@DeliveryDate", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, status, "@status", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, TotalRawMaterial, "@TotalRawMaterial", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, WagesForEmployee, "@WagesForEmployee", ParameterDirection.Input));


                dbReader = ObjDbfactory.GetReader("PRO_UpdateOrderMaster", false, objLstdbParams);

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
