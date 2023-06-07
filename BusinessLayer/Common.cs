using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Common
    {
        public DbDataReader dbReader;
        public DbFactory ObjDbfactory;
        public ResultDetail Result { get; set; }

        public string ConnectionString { get; set; }

        // Initialize the SQL DB connection
        public void InitializeDb()
        {
            ObjDbfactory = new DbFactory(DataBaseType.SQLServer, ConnectionString);
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
    }
}
