using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using DataLayer;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class IncentiveMasters : Common
    {

        public string ProductName { get; set; }
        public string ModelCode { get; set; }
        public string ModelName { get; set; }
        public string ModelSize { get; set; }
        public string DurationPeriod { get; set; }
        public string Date { get; set; }


        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ProductName, "@ProductName", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ModelCode, "@ModelCode", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ModelName, "@ModelName", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ModelSize, "@ModelSize", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, DurationPeriod, "@DurationPeriod", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, Date, "@Date", ParameterDirection.Input));
                dbReader = ObjDbfactory.GetReader("PRO_UpdateIncentiveMaster", false, objLstdbParams);

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

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_DeleteIncentiveMaster", false, objLstdbParams);

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


    }

}