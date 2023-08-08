using DataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Common
    {
        public Int64 Id { get; set; }
        public DbDataReader dbReader;
        public DbFactory ObjDbfactory;
        public ResultDetail Result { get; set; }

        public string ConnectionString { get; set; }

        // Initialize the SQL DB connection
        public void InitializeDb()
        {

            

            // Refresh the ConfigurationManager
            ConfigurationManager.RefreshSection("connectionStrings");
            string localServerName = Environment.MachineName;
            string connectionStringTemplate = "Data Source={0};Initial Catalog=BillPlex;Integrated Security=True;";

            // Retrieve the connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            // Modify the connection string (example: change the database name)
            connectionString = connectionString.Replace("Data Source=localhost", $"Data Source={localServerName}");

            // Update the connection string in app.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["BillPlex"].ConnectionString = connectionString;
            config.Save(ConfigurationSaveMode.Modified);


            string dynamicConnectionString = string.Format(connectionStringTemplate, localServerName);
            ObjDbfactory = new DbFactory(DataBaseType.SQLServer, dynamicConnectionString);
        }

        // Close the SQL DB connection
        public void CloseConnection()
        {
            if (dbReader != null)
                dbReader.Close();

            if (ObjDbfactory != null)
                ObjDbfactory.CloseConnection();
        }

        #region Convertion methods
        public string ToString(object Value)
        {
            if (Value == null || Value == DBNull.Value)
                return "";
            else
                return Value.ToString();
        }
        public int ToInteger(object Value)
        {
            if (Value == null || Value == DBNull.Value)
                return 0;
            else if (Value.ToString() == "")
                return 0;
            else
                return Convert.ToInt32(Value);
        }
        public bool ToBool(object Value)
        {
            if (Value == null || Value == DBNull.Value)
                return false;
            else
            {
                try
                {
                    return Convert.ToBoolean(Value);
                }
                catch
                {
                    return false;
                }
            }
        }

        public Int64 ToBigInt(object Value)
        {
            if (Value == null || Value == DBNull.Value)
                return 0;
            else if (Value.ToString() == "")
                return 0;
            else
                return Convert.ToInt64(Value);
        }

        public string ToDateTimeToString(object Value)
        {
            if (Value == null || Value == DBNull.Value)
                return "";
            else
            {
                try
                {
                    DateTime dtCurrent = Convert.ToDateTime(Value);

                    if (dtCurrent == new DateTime(1900, 1, 1))
                        return "";
                    else if (dtCurrent == new DateTime(2000, 1, 1))
                        return "";
                    else if (dtCurrent == new DateTime(2001, 1, 1))
                        return "";
                    else
                        return Convert.ToDateTime(Value).ToString("dd/MM/yyyy");
                }
                catch
                {
                    return "";
                }
            }
        }

        public string ToDateTimeToString(object Value, string sPattern)
        {
            if (Value == null || Value == DBNull.Value)
                return "";
            else
            {
                try
                {
                    DateTime dtCurrent = Convert.ToDateTime(Value);

                    if (dtCurrent == new DateTime(1900, 1, 1))
                        return "";
                    else if (dtCurrent == new DateTime(2000, 1, 1))
                        return "";
                    else if (dtCurrent == new DateTime(2001, 1, 1))
                        return "";
                    else
                        return Convert.ToDateTime(Value).ToString(sPattern);
                }
                catch
                {
                    return "";
                }
            }
        }
        #endregion

        #region Static conversion methods
        public static class Conversion
        {
            public static string ToString(object Value)
            {
                if (Value == null || Value == DBNull.Value)
                    return "";
                else
                    return Value.ToString();
            }
            public static int ToInteger(object Value)
            {
                if (Value == null || Value == DBNull.Value)
                    return 0;
                else if (Value.ToString() == "")
                    return 0;
                else
                    return Convert.ToInt32(Value);
            }
            public static bool ToBool(object Value)
            {
                if (Value == null || Value == DBNull.Value)
                    return false;
                else
                {
                    try
                    {
                        return Convert.ToBoolean(Value);
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
        #endregion


        #region GetDropDownList

        public List<DropDownItemInfo> GetDropdownValues(Dictionary<string, bool> RequiredDropdownFields)
        {

            dbReader = null;
            Result = new ResultDetail();

            List<DropDownItemInfo> DropdownItemLists = new List<DropDownItemInfo>();

            try
            {
                InitializeDb();

                List<DbParams> objLstDbParams = new List<DbParams>();
                foreach (var item in RequiredDropdownFields)
                {
                    objLstDbParams.Add(new DbParams(DbType.Boolean, 15, item.Value, "@" + item.Key, ParameterDirection.Input));
                }

                dbReader = ObjDbfactory.GetReader("PRO_GetdropdownItems", false, objLstDbParams);

                foreach (var item in RequiredDropdownFields)
                {
                    DropdownItemLists = DropDownItemInfo.PreparedItemList(ref dbReader, true);
                    dbReader.NextResult();
                }

               //esult.Status = ResultStatus.Success;
               //return  ;
            }
            catch (Exception ex)
            {
                Result.Status = ResultStatus.Error;
                Result.Message = ex.Message;
            }
            finally
            {
                CloseConnection();
            }

            return DropdownItemLists;
        }

        public Hashtable GetDropdownCollections(Dictionary<string, bool> RequiredDropdownFields)
        {

            dbReader = null;
            Result = new ResultDetail();

            Hashtable DropdownItemLists = new Hashtable();

            try
            {
                InitializeDb();

                List<DbParams> objLstDbParams = new List<DbParams>();
                foreach (var item in RequiredDropdownFields)
                {
                    objLstDbParams.Add(new DbParams(DbType.Boolean, 15, item.Value, "@" + item.Key, ParameterDirection.Input));
                }

                dbReader = ObjDbfactory.GetReader("PRO_GetdropdownItems", false, objLstDbParams);

                foreach (var item in RequiredDropdownFields)
                {
                    DropdownItemLists.Add( item.Key,DropDownItemInfo.PreparedItemByProModelList(ref dbReader));
                    dbReader.NextResult();
                }
            }
            catch (Exception ex)
            {
                Result.Status = ResultStatus.Error;
                Result.Message = ex.Message;
            }
            finally
            {
                CloseConnection();
            }

            return DropdownItemLists;
        }
        #endregion
    }
}
