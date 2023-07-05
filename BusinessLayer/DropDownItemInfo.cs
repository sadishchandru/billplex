using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLayer.Common;

namespace BusinessLayer
{
    public class DropDownItemInfo
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string AuthorName { get; set; }
        public string proModel { get; set; }
        public string productId { get; set; }
        public string RawMaterial { get; set; }
        public static List<DropDownItemInfo> PreparedItemList(ref DbDataReader dbReader)
        {
            List<DropDownItemInfo> itemList = new List<DropDownItemInfo>();
            while (dbReader.Read())
            {
                DropDownItemInfo itemInfo = new DropDownItemInfo();
                itemInfo.Id = Conversion.ToInteger(dbReader["id"]);
                itemInfo.Name = Conversion.ToString(dbReader["name"]);
                itemList.Add(itemInfo);
            }

            return itemList;
        }
        public static List<DropDownItemInfo> PreparedItemList(ref DbDataReader dbReader, bool isMoreValue)
            {
            List<DropDownItemInfo> itemList = new List<DropDownItemInfo>();
            while (dbReader.Read())
            {
                DropDownItemInfo itemInfo = new DropDownItemInfo();
                itemInfo.Id = Conversion.ToInteger(dbReader["id"]);
                itemInfo.Name = Conversion.ToString(dbReader["name"]);
                itemInfo.Code = Conversion.ToString(dbReader["code"]);
                itemList.Add(itemInfo);
            }

            return itemList;
        }

        public static List<DropDownItemInfo> PreparedItemByAuthorList(ref DbDataReader dbReader)
        {
            List<DropDownItemInfo> itemList = new List<DropDownItemInfo>();
            while (dbReader.Read())
            {
                DropDownItemInfo itemInfo = new DropDownItemInfo();
                itemInfo.Id = Conversion.ToInteger(dbReader["id"]);
                itemInfo.Name = Conversion.ToString(dbReader["name"]);
                itemInfo.Code = Conversion.ToString(dbReader["code"]);
                itemInfo.AuthorName = Conversion.ToString(dbReader["authorName"]);
                itemList.Add(itemInfo);
            }

            return itemList;
        }
        public static List<DropDownItemInfo> PreparedItemByProModelList(ref DbDataReader dbReader)
        {
            List<DropDownItemInfo> itemList = new List<DropDownItemInfo>();
            while (dbReader.Read())
            {
                DropDownItemInfo itemInfo = new DropDownItemInfo();
                itemInfo.Id = Conversion.ToInteger(dbReader["id"]);
                itemInfo.Name = Conversion.ToString(dbReader["name"]);
                itemInfo.Code = Conversion.ToString(dbReader["code"]);
                itemInfo.AuthorName = Conversion.ToString(dbReader["authorName"]);
                itemInfo.proModel = Conversion.ToString(dbReader["proModel"]);
                itemInfo.productId = Conversion.ToString(dbReader["productId"]);
                itemInfo.RawMaterial = Conversion.ToString(dbReader["RawMaterial"]);
                itemList.Add(itemInfo);
            }

            return itemList;
        }
    }
}
