using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DbFactory
    {
        private int _iCMDTimeout = 0;
        private DbConnection _Conn;
        private string _ConnString;
        private DataBaseType _DbaseType;
        private DbProviderFactory _DbProviderFactory;
        private string _ProviderString;

        public DbFactory(DataBaseType DbaseType, string ConnString)
        {
            try
            {
                this._ConnString = ConnString;
                this._DbaseType = DbaseType;
                this.GetConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AddParameter(List<DbParams> DbList, ref DbCommand MyCommand)
        {
            try
            {
                for (int index = 0; index < DbList.Count; ++index)
                {
                    DbParameter parameter = this._DbProviderFactory.CreateParameter();
                    parameter.Direction = DbList[index].Direction;
                    parameter.ParameterName = DbList[index].ParameterName;
                    parameter.DbType = DbList[index].dbType;
                    parameter.Size = DbList[index].DbLength;
                    parameter.Value = DbList[index].Value;
                    MyCommand.Parameters.Add((object)parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CloseConnection()
        {
            this._Conn.Close();
            this._Conn.Dispose();
            this._Conn = (DbConnection)null;
        }

        public void GetCommand(string QueryorProcName, bool IsQuery)
        {
            DbCommand dbCommand = (DbCommand)null;
            try
            {
                dbCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                dbCommand.CommandTimeout = this._iCMDTimeout;
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dbCommand?.Dispose();
            }
        }

        public void GetCommand(string QueryorProcName, bool IsQuery, List<DbParams> DbList)
        {
            DbCommand MyCommand = (DbCommand)null;
            try
            {
                MyCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                this.AddParameter(DbList, ref MyCommand);
                MyCommand.CommandTimeout = this._iCMDTimeout;
                MyCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                MyCommand?.Dispose();
            }
        }

        public void GetCommand(
          string QueryorProcName,
          bool IsQuery,
          List<DbParams> DbList,
          DbTransaction Tran)
        {
            DbCommand MyCommand = (DbCommand)null;
            try
            {
                MyCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                MyCommand.Transaction = Tran;
                MyCommand.CommandTimeout = this._iCMDTimeout;
                this.AddParameter(DbList, ref MyCommand);
                MyCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                MyCommand?.Dispose();
            }
        }

        private void GetConnection()
        {
            try
            {
                this.GetConnectionString();
                this.GetProvider();
                this._Conn = this._DbProviderFactory.CreateConnection();
                this._Conn.ConnectionString = this._ConnString;
                this._Conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void GetConnectionString()
        {
            try
            {
                switch (this._DbaseType)
                {
                    case DataBaseType.SQLServer:
                        this._ProviderString = "System.Data.SqlClient";
                        break;
                        //case DataBaseType.Access:
                        //  this._ConnString = ConfigurationManager.ConnectionStrings["MS ACESS"].ConnectionString;
                        //  this._ProviderString = ConfigurationManager.ConnectionStrings["MS ACESS"].ProviderName;
                        //  break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet GetData(string QueryorProcName, bool IsQuery)
        {
            DbCommand dbCommand = (DbCommand)null;
            try
            {
                dbCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                dbCommand.CommandTimeout = this._iCMDTimeout;
                DataSet dataSet = new DataSet();
                using (DbDataAdapter dataAdapter = this._DbProviderFactory.CreateDataAdapter())
                {
                    dataAdapter.SelectCommand = dbCommand;
                    dataAdapter.Fill(dataSet);
                }
                return dataSet;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dbCommand?.Dispose();
            }
        }

        public DataSet GetData(string QueryorProcName, bool IsQuery, List<DbParams> DbList)
        {
            DbCommand MyCommand = (DbCommand)null;
            try
            {
                MyCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                MyCommand.CommandTimeout = this._iCMDTimeout;
                this.AddParameter(DbList, ref MyCommand);
                DataSet dataSet = new DataSet();
                using (DbDataAdapter dataAdapter = this._DbProviderFactory.CreateDataAdapter())
                {
                    dataAdapter.SelectCommand = MyCommand;
                    dataAdapter.Fill(dataSet);
                }
                return dataSet;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                MyCommand?.Dispose();
            }
        }

        public DataSet GetData(
          string QueryorProcName,
          bool IsQuery,
          List<DbParams> DbList,
          DbTransaction Tran)
        {
            DbCommand MyCommand = (DbCommand)null;
            try
            {
                MyCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                MyCommand.CommandTimeout = this._iCMDTimeout;
                MyCommand.Transaction = Tran;
                this.AddParameter(DbList, ref MyCommand);
                DataSet dataSet = new DataSet();
                using (DbDataAdapter dataAdapter = this._DbProviderFactory.CreateDataAdapter())
                {
                    dataAdapter.SelectCommand = MyCommand;
                    dataAdapter.Fill(dataSet);
                }
                return dataSet;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                MyCommand?.Dispose();
            }
        }

        private void GetProvider()
        {
            try
            {
                //this._DbProviderFactory = DbProviderFactories.GetFactory(this._ProviderString);
                this._DbProviderFactory = DbProviderFactories.GetFactory(new SqlConnection(this._ConnString));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DbDataReader GetReader(string QueryorProcName, bool IsQuery)
        {
            DbDataReader dbDataReader = (DbDataReader)null;
            DbCommand dbCommand = (DbCommand)null;
            try
            {
                dbCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                dbCommand.CommandTimeout = this._iCMDTimeout;
                dbDataReader = dbCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dbCommand?.Dispose();
            }
            return dbDataReader;
        }

        public DbDataReader GetReader(
          string QueryorProcName,
          bool IsQuery,
          List<DbParams> DbList)
        {
            DbDataReader dbDataReader = (DbDataReader)null;
            DbCommand MyCommand = (DbCommand)null;
            try
            {
                MyCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                MyCommand.CommandTimeout = this._iCMDTimeout;
                this.AddParameter(DbList, ref MyCommand);
                MyCommand.CommandTimeout = 0;
                dbDataReader = MyCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                MyCommand?.Dispose();
            }
            return dbDataReader;
        }

        public object GetScalarValue(string QueryorProcName, bool IsQuery)
        {
            object obj = (object)null;
            DbCommand dbCommand = (DbCommand)null;
            try
            {
                dbCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                dbCommand.CommandTimeout = this._iCMDTimeout;
                obj = dbCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dbCommand?.Dispose();
            }
            return obj;
        }

        public object GetScalarValue(string QueryorProcName, bool IsQuery, List<DbParams> DbList)
        {
            object obj = (object)null;
            DbCommand MyCommand = (DbCommand)null;
            try
            {
                MyCommand = this.InitializeCommand(QueryorProcName, IsQuery);
                MyCommand.CommandTimeout = this._iCMDTimeout;
                this.AddParameter(DbList, ref MyCommand);
                obj = MyCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                MyCommand?.Dispose();
            }
            return obj;
        }

        private DbCommand InitializeCommand(string QueryorProcName, bool IsQuery)
        {
            using (DbCommand command = this._DbProviderFactory.CreateCommand())
            {
                try
                {
                    command.Connection = this._Conn;
                    command.CommandTimeout = this._iCMDTimeout;
                    command.CommandType = !IsQuery ? CommandType.StoredProcedure : CommandType.Text;
                    command.CommandText = QueryorProcName;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return command;
            }
        }

        public DbConnection Conn
        {
            get
            {
                return this._Conn;
            }
        }
    }
}
