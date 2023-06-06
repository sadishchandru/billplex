// Decompiled with JetBrains decompiler
// Type: DataLayer.GetDbType
// Assembly: DataLayer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 935CBB44-3C86-411B-A6DB-1B9C8B2761A7
// Assembly location: C:\Users\Admin\Desktop\DataLayer.dll

using System.Data;

namespace DataLayer
{
    public class GetDbType
    {
        public static DbType SqlDbTypeToDbType(SQlDataBaseType sqlDbType)
        {
            DbType dbType = DbType.String;
            switch (sqlDbType)
            {
                case SQlDataBaseType.BigInt:
                    return DbType.Int64;
                case SQlDataBaseType.Binary:
                    return DbType.Binary;
                case SQlDataBaseType.Bit:
                    return DbType.Boolean;
                case SQlDataBaseType.Char:
                    return DbType.AnsiStringFixedLength;
                case SQlDataBaseType.DateTime:
                    return DbType.DateTime;
                case SQlDataBaseType.Decimal:
                    return DbType.Decimal;
                case SQlDataBaseType.Float:
                    return DbType.Double;
                case SQlDataBaseType.Image:
                    return DbType.Binary;
                case SQlDataBaseType.Int:
                    return DbType.Int32;
                case SQlDataBaseType.Money:
                    return DbType.Currency;
                case SQlDataBaseType.NChar:
                    return DbType.StringFixedLength;
                case SQlDataBaseType.NText:
                    return DbType.String;
                case SQlDataBaseType.NVarChar:
                    return DbType.String;
                case SQlDataBaseType.Real:
                    return DbType.Single;
                case SQlDataBaseType.UniqueIdentifier:
                    return DbType.Guid;
                case SQlDataBaseType.SmallDateTime:
                    return DbType.DateTime;
                case SQlDataBaseType.SmallInt:
                    return DbType.Int16;
                case SQlDataBaseType.SmallMoney:
                    return dbType;
                case SQlDataBaseType.Text:
                    return DbType.AnsiString;
                case SQlDataBaseType.Timestamp:
                    return DbType.Binary;
                case SQlDataBaseType.TinyInt:
                    return DbType.Byte;
                case SQlDataBaseType.VarBinary:
                    return DbType.Binary;
                case SQlDataBaseType.VarChar:
                    return DbType.AnsiString;
                case SQlDataBaseType.Variant:
                    return DbType.Object;
                default:
                    return dbType;
            }
        }
    }
}
