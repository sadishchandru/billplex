using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class FrmFinishingProductModel : DevExpress.XtraEditors.XtraForm
    {
        private FinishingProductModel FinishingProductModelRequest;
        public FrmFinishingProductModel()
        {
            InitializeComponent();
            FinishingProductModelRequest = new FinishingProductModel();
            FinishingProductModelRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    {"ProductModelRequired",true },
                    {"SizeMasterRequired",true}
                };

            var dropdwonList = FinishingProductModelRequest.GetDropdownCollections(dropDownList);


            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ProductModelRequired")
                {
                    FinishingProductModelRequest.ProductModelList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "SizeMasterRequired")
                {
                    FinishingProductModelRequest.SizeMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (FinishingProductModelRequest.ProductModelList != null)
            {
                if (FinishingProductModelRequest.ProductModelList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in FinishingProductModelRequest.ProductModelList)
                    {
                        drpProductName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            if (FinishingProductModelRequest.SizeMasterList != null)
            {
                if (FinishingProductModelRequest.SizeMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in FinishingProductModelRequest.SizeMasterList)
                    {
                        var foundItem = "";

                        foreach (string items in drpProductSize.Properties.Items)
                        {
                            if (items.ToLower().ToString() == item.Name.ToLower().ToString())
                            {
                                foundItem = items;
                                break;
                            }
                        }

                        if (foundItem == "")
                        {
                            drpProductSize.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                        }
                    }
                }
            }
        }

        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            gridView1.RefreshData();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FinishingProductModelRequest.ProductNameId = drpProductName.Text;
                FinishingProductModelRequest.Productcode = txtModelCode.Text;
                FinishingProductModelRequest.Productmodel = txtModelName.Text;
                FinishingProductModelRequest.Productsize = drpProductSize.Text;
                FinishingProductModelRequest.WagesforProduct = txtWages.Text;
                FinishingProductModelRequest.ItemDate = drpDate.Text;
                FinishingProductModelRequest.Update();

                if (FinishingProductModelRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(FinishingProductModelRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadSqlDataSource();
                }

            }
            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }
    }
}