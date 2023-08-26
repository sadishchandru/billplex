using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmDirectLabourBill : DevExpress.XtraEditors.XtraForm
    {
        private DirectLabourBill DirectLabourBillRequest;
        public FrmDirectLabourBill()
        {
            InitializeComponent();
            DirectLabourBillRequest = new DirectLabourBill();
            DirectLabourBillRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }
        public void DropDownGetList()
        {
            #region DropDown Get List
            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>
            {
                {"RawMaterialRequired",true},
                {"ProductModelRequired",true},
                {"ProductMasterRequired",true},
                {"CustomerMasterRequired",true},
                {"ColorMasterRequired",true},
                {"OrderMasterRequired",true}
            };

            var dropdwonList = DirectLabourBillRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ProductModelRequired")
                {
                    DirectLabourBillRequest.ProductModelList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "ProductMasterRequired")
                {
                    DirectLabourBillRequest.ProductMasterList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "CustomerMasterRequired")
                {
                    DirectLabourBillRequest.CustomerMasterList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "ColorMasterRequired")
                {
                    DirectLabourBillRequest.ColourMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }
            #endregion
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            report rep = new report();
            rep.RequestParameters = false;
            rep.ExportToPdf("Report.pdf");
            System.Diagnostics.Process.Start("Report.pdf");
        }
    }
}