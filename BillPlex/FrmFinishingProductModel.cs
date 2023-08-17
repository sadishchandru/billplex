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
            gridView1.BestFitColumns();
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
            sqlDataSource1.FillAsync();
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
                if ((drpProductName.Text != string.Empty || drpProductName.Text != "Select") && txtModelCode.Text != string.Empty)
                {
                    string selectedProductItem = (string)drpProductName.SelectedItem;

                    if (selectedProductItem != null)
                    {
                        FinishingProductModelRequest.ProductNameId = FinishingProductModelRequest.ProductModelList.FirstOrDefault(item => item.Name == selectedProductItem.ToString())?.Id ?? -1;
                    }
                    FinishingProductModelRequest.Productcode = txtModelCode.Text;
                    FinishingProductModelRequest.Productmodel = txtModelName.Text;
                    FinishingProductModelRequest.Productsize = drpProductSize.Text;
                    FinishingProductModelRequest.WagesforProduct = txtWages.Text;
                    FinishingProductModelRequest.ItemDate = ddDate.Text;
                    FinishingProductModelRequest.Update();

                    if (FinishingProductModelRequest.Result.Status == ResultStatus.Success)
                    {
                        XtraMessageBox.Show(FinishingProductModelRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadSqlDataSource();
                        btnAdd.Enabled = true;
                        btnUpdate.Enabled = false;
                        txtModelCode.Enabled = true;
                        Reset_Text();
                    }
                }
                else
                {
                    XtraMessageBox.Show("please give the mandatory field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var Id = gridView1.GetRowCellValue(rowHandle, "Id");

                FinishingProductModelRequest.Id = (Int32)Id;
            }
            FinishingProductModelRequest.Delete();
            if (FinishingProductModelRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(FinishingProductModelRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadSqlDataSource();
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                var selectedRows = gridView1.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    FinishingProductModelRequest.Id = (int)gridView1.GetRowCellValue(rowHandle, "Id");
                    drpProductName.SelectedIndex = FinishingProductModelRequest.ProductModelList.FindIndex(x => x.Id == Convert.ToInt64(gridView1.GetRowCellValue(rowHandle, "ProductNameId")));
                    txtModelCode.Text = (string)gridView1.GetRowCellValue(rowHandle, "Productcode");
                    txtModelName.Text = (string)gridView1.GetRowCellValue(rowHandle, "Productmodel");
                    drpProductSize.Text = (string)gridView1.GetRowCellValue(rowHandle, "Productsize");
                    txtWages.Text = (string)gridView1.GetRowCellValue(rowHandle, "WagesforProduct");
                    var datete = gridView1.GetRowCellValue(rowHandle, "ItemDate").ToString();
                    ddDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                }
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAdd.Enabled = true;
                txtModelCode.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Reset_Text()
        {
            drpProductName.ResetText();
            txtModelCode.ResetText();
            txtModelName.ResetText();
            txtWages.ResetText();
            drpProductSize.ResetText();
            ddDate.ResetText();
        }

        private void FrmFinishingProductModel_Load(object sender, EventArgs e)
        {
            int centerX = (this.Width - panelControl4.Width) / 2;
            int centerY = (this.Height - panelControl4.Height) / 2;

            // Set the controls' positions to the calculated center position
            panelControl4.Location = new Point(centerX, centerY);
        }
    }
}