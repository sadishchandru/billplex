// Decompiled with JetBrains decompiler
// Type: DataLayer.DbParams
// Assembly: DataLayer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 935CBB44-3C86-411B-A6DB-1B9C8B2761A7
// Assembly location: C:\Users\Admin\Desktop\DataLayer.dll

using System.Data;

namespace DataLayer
{
    public class DbParams
    {
        private int _DbLength;
        private DbType _dbType;
        private ParameterDirection _Direction;
        private string _ParameterName;
        private object _Value;

        public DbParams()
        {
            this._dbType = DbType.String;
            this._DbLength = 50;
            this._Value = (object)0;
        }

        public DbParams(
          DbType FdbType,
          int FDbLength,
          object FValue,
          string FParameterName,
          ParameterDirection FParameterDirection)
        {
            this._dbType = DbType.String;
            this._DbLength = 50;
            this._Value = (object)0;
            this._dbType = FdbType;
            this._DbLength = FDbLength;
            this._Value = FValue;
            this._ParameterName = FParameterName;
            this._Direction = FParameterDirection;
        }

        public int DbLength
        {
            get
            {
                return this._DbLength;
            }
            set
            {
                this._DbLength = value;
            }
        }

        public DbType dbType
        {
            get
            {
                return this._dbType;
            }
            set
            {
                this._dbType = value;
            }
        }

        public ParameterDirection Direction
        {
            get
            {
                return this._Direction;
            }
            set
            {
                this._Direction = value;
            }
        }

        public string ParameterName
        {
            get
            {
                return this._ParameterName;
            }
            set
            {
                this._ParameterName = value;
            }
        }

        public object Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this._Value = value;
            }
        }
    }
}
