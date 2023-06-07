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
