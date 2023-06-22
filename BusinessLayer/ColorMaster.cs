using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ColorMaster: Common
    {
        public string ColorName { get; set; }

        public void Update()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.String, 50, Id, "@ID", ParameterDirection.Input));
                objLstdbParams.Add(new DbParams(DbType.String, 50, ColorName, "@Colournname", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_UpdateColourMaster", false, objLstdbParams);

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

        #region

        public void Delete()
        {
            dbReader = null;
            Result = new ResultDetail();

            try
            {
                InitializeDb();

                List<DbParams> objLstdbParams = new List<DbParams>();
                objLstdbParams.Add(new DbParams(DbType.String, 50, Id, "@Id", ParameterDirection.Input));

                dbReader = ObjDbfactory.GetReader("PRO_DeleteColorMaster", false, objLstdbParams);

                Result.Message = "Color Master Deleted Successfully";
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
            }
            finally
            {
                CloseConnection();
            }
        }

        #endregion
    }


}
