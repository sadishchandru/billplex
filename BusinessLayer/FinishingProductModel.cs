﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FinishingProductModel: Common
    {
        public Int64 ProductNameId { get; set; } 
        public string Productcode { get; set; } 
        public string Productmodel { get; set; } 
        public string Productsize { get; set; } 
        public string WagesforProduct { get; set; } 
        public string ItemDate { get; set; }

        public List<DropDownItemInfo> ProductModelList { get; set; }
        public List<DropDownItemInfo> SizeMasterList { get; set; }

        #region Update

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
                objLstDbParams.Add(new DbParams(DbType.String, 50, ProductNameId, "@ProductNameId", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Productcode, "@Productcode", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 200, Productmodel, "@Productmodel", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, Productsize, "@Productsize", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, WagesforProduct, "@WagesforProduct", ParameterDirection.Input));
                objLstDbParams.Add(new DbParams(DbType.String, 50, ItemDate, "@ItemDate", ParameterDirection.Input));
               
                dbReader = ObjDbfactory.GetReader("PRO_UpdateFinishingProductModel", false, objLstDbParams);

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

        public void Delete()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_DeleteFinishingProductModel", false, objLstdbParams);

                //while (dbReader.Read())
                //{
                //    Result.Message = ToString(dbReader["ResultMessage"]);
                //   Result.Status = (ResultStatus)ToInteger(dbReader["ResultNo"]);
                //}

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
    }
}
