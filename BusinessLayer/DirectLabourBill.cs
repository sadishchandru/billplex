using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DirectLabourBill : Common
    {
        public List<DropDownItemInfo> RawMaterialList { get; set; }
        public List<DropDownItemInfo> ProductModelList { get; set; }
        public List<DropDownItemInfo> CustomerMasterList { get; set; }
        public List<DropDownItemInfo> ProductMasterList { get; set; }
        public List<DropDownItemInfo> ColourMasterList { get; set; }
    }
}
