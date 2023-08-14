﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;
using System.Collections;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Office.Utils;
using DevExpress.XtraGrid.Columns;

namespace BillPlex
{
    public partial class FrmProductModel : DevExpress.XtraEditors.XtraForm
    {
        private ProductModel productModelRequest;
        public FrmProductModel()
        {
            InitializeComponent();

            labelAvailable.Visible = false;
            labelCodeExist.Visible = false;

            ddDate.DateTime = DateTime.Now;
            productModelRequest = new ProductModel();
            productModelRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();

            LabelExceed.Visible = false;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    {"RawMaterialRequired",true},
                    {"ProductModelRequired",true },
                    {"ProductMasterRequired",true },
                    {"SizeMasterRequired",true}
                };

            var dropdwonList = productModelRequest.GetDropdownCollections(dropDownList);


            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "RawMaterialRequired")
                {
                    productModelRequest.RawMaterialList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "ProductModelRequired")
                {
                    productModelRequest.ProductModelList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "ProductMasterRequired")
                {
                    productModelRequest.ProductMasterList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "SizeMasterRequired")
                {
                    productModelRequest.SizeMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (productModelRequest.RawMaterialList != null)
            {

                if (productModelRequest.RawMaterialList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in productModelRequest.RawMaterialList)
                    {
                        var foundItem = "";

                        foreach (string items in drpRawType.Properties.Items)
                        {
                            if (items.ToString() == item.Code.ToString())
                            {
                                foundItem = items;
                                break;
                            }
                        }

                        if (foundItem == "")
                        {
                            drpRawType.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                        }


                        foundItem = "";

                        foreach (string items in drpRawName.Properties.Items)
                        {
                            if (items.ToString() == item.Name.ToString())
                            {
                                foundItem = items;
                                break;
                            }
                        }

                        if (foundItem == "")
                        {
                            drpRawName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                        }
                    }
                }
            }

            if (productModelRequest.ProductModelList != null)
            {
                if (productModelRequest.ProductModelList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in productModelRequest.ProductModelList)
                    {
                        drpProName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }

            if (productModelRequest.SizeMasterList != null)
            {
                if (productModelRequest.SizeMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in productModelRequest.SizeMasterList)
                    {
                        var foundItem = "";

                        foreach (string items in drpProSize.Properties.Items)
                        {
                            if (items.ToLower().ToString() == item.Name.ToLower().ToString())
                            {
                                foundItem = items;
                                break;
                            }
                        }

                        if (foundItem == "")
                        {
                            drpProSize.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                        }
                    }
                }
            }
        }

        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            grd_ProductModel.RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((drpProName.Text != string.Empty || drpProName.Text != "Select") && txtModelCode.Text != string.Empty && txtModelName.Text != string.Empty)
                {

                    if ((productModelRequest.Id != 0 || labelAvailable.Visible == true) && labelCodeExist.Visible == false)
                    {
                        string selectedMasterItem = (string)drpRawType.SelectedItem;

                        if (selectedMasterItem != null)
                        {
                            productModelRequest.RawMaterialType = productModelRequest.RawMaterialList.FirstOrDefault(item => item.Code == selectedMasterItem.ToString())?.Id ?? -1;
                        }

                        string selectedMaterialItem = (string)drpRawName.SelectedItem;

                        if (selectedMasterItem != null)
                        {
                            productModelRequest.RawMaterialId = productModelRequest.RawMaterialList.FirstOrDefault(item => item.Name == selectedMaterialItem.ToString())?.Id ?? -1;
                        }

                        string selectedProductItem = (string)drpProName.SelectedItem;

                        if (selectedProductItem != null)
                        {
                            productModelRequest.ProductId = productModelRequest.ProductModelList.FirstOrDefault(item => item.Name == selectedProductItem.ToString())?.Id ?? -1;
                        }
                        productModelRequest.ModelCode = txtModelCode.Text;
                        productModelRequest.ModelName = txtModelName.Text;
                        productModelRequest.ProductSize = drpProSize.Text;
                        productModelRequest.RawMaterialStock = txtRawStock.Text;
                        productModelRequest.RequiredRawMaterialWeight = txtRawWeight.Text;
                        productModelRequest.WagesForProductModel = txtWages.Text;
                        productModelRequest.PMDate = ddDate.Text;
                        if (LabelExceed.Visible == false)
                        {
                            productModelRequest.Update();
                        }
                        else
                        {
                            XtraMessageBox.Show("Please check Required Raw weight has exceed ", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Please check Code", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    XtraMessageBox.Show("please give the manditory field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (productModelRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(productModelRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click();
                    ReloadSqlDataSource();
                    btnUpdate.Enabled = false;
                    btnAdd.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected rows from the GridView control
            var selectedRows = grd_ProductModel.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var id = grd_ProductModel.GetRowCellValue(rowHandle, "Id");

                productModelRequest.Id = (Int64)id;
            }

            productModelRequest.Delete();

            if (productModelRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(productModelRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadSqlDataSource();
            }
        }

        private void btnClear_Click(object sender = null, EventArgs e = null)
        {
            productModelRequest.Id = 0;
            drpRawType.ResetText();
            drpRawName.ResetText();
            drpProName.ResetText();
            txtModelCode.ResetText();
            txtModelName.ResetText();
            drpProSize.ResetText();
            txtRawStock.ResetText();
            txtRawWeight.ResetText();
            txtWages.ResetText();
            ddDate.ResetText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void drpRawType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpRawType.SelectedItem;
        }

        private void drpProName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpProName.SelectedItem;

            if (selectedItem != null)
            {
                Text = productModelRequest.ProductModelList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpRawName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRawItem = (string)drpRawName.SelectedItem;

            string selectedRawTypeItem = (string)drpRawType.SelectedItem;

            if ((selectedRawItem != null && selectedRawItem != "") && (selectedRawTypeItem != null && selectedRawTypeItem != ""))
            {

                GridView gridView = grd_ProductModel;

                List<Dictionary<string, object>> allData = new List<Dictionary<string, object>>();
                decimal actualCount = 0;
                // Iterate over each row in the grid
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    if (selectedRawTypeItem == grd_ProductModel.GetRowCellValue(i, "RawMaterialType").ToString() && selectedRawItem == grd_ProductModel.GetRowCellValue(i, "RawMaterials").ToString())
                    {
                        decimal reqMateialcount = decimal.Parse(grd_ProductModel.GetRowCellValue(i, "ReqRawMaterial").ToString());
                        actualCount = actualCount + reqMateialcount;
                    }
                }
                decimal count = 0;

                foreach (var item in productModelRequest.RawMaterialList)
                {
                    if (item.Code == selectedRawTypeItem.ToString() && item.Name == selectedRawItem.ToString())
                    {
                        count = decimal.Parse(item.AuthorName) + count;
                    }
                }

                txtRawStock.Text = Math.Abs(count - actualCount).ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRawWeight_EditValueChanged(object sender, EventArgs e)
        {
            if (txtRawWeight.Text != "" && txtRawStock.Text != "")
            {
                if (decimal.Parse(txtRawStock.Text) < decimal.Parse(txtRawWeight.Text))
                {
                    LabelExceed.Visible = true;
                }
                else
                {
                    LabelExceed.Visible = false;
                }
            }
        }

        private void grd_ProductModel_RowClick(object sender, RowClickEventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = grd_ProductModel.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    productModelRequest.Id = (Int64)grd_ProductModel.GetRowCellValue(rowHandle, "Id");
                    drpRawType.SelectedIndex = productModelRequest.RawMaterialList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "RawmaterialTypeId")));
                    drpRawName.SelectedIndex = productModelRequest.RawMaterialList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "RawMaterialId")));
                    drpProName.SelectedIndex = productModelRequest.ProductModelList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "ProductId")));
                    txtModelCode.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductCode");
                    txtModelName.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductModel");
                    drpProSize.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductSize");
                    txtRawStock.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "RawMaterialStock");
                    txtRawWeight.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ReqRawMaterial");
                    txtWages.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "WagesforItem");
                    var datete = grd_ProductModel.GetRowCellValue(rowHandle, "Date").ToString();
                    ddDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                }
                txtModelCode.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                labelAvailable.Visible = false;
                labelCodeExist.Visible = false;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtModelCode.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            Form myForm = Application.OpenForms["FrmRawMaterial"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmRawMaterial();
                myForm.MdiParent = this.MdiParent;
                myForm.Show();
                IsOpen = true;
            }
            if (IsOpen == false)
            {
                FrmRawMaterial rawMaterial = new FrmRawMaterial();
                rawMaterial.MdiParent = this.MdiParent;
                rawMaterial.Show();
            }
        }

        private void btnDot1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            Form myForm = Application.OpenForms["FrmProductMaster"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmProductMaster();
                myForm.MdiParent = this.MdiParent;
                myForm.Show();
                IsOpen = true;
            }
            if (IsOpen == false)
            {
                FrmProductMaster rawMaterial = new FrmProductMaster();
                rawMaterial.MdiParent = this.MdiParent;
                rawMaterial.Show();
            }
        }

        private void btnDot2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            Form myForm = Application.OpenForms["FrmSizeMaster"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmSizeMaster();
                myForm.MdiParent = this.MdiParent;
                myForm.Show();
                IsOpen = true;
            }
            if (IsOpen == false)
            {
                FrmSizeMaster rawMaterial = new FrmSizeMaster();
                rawMaterial.MdiParent = this.MdiParent;
                rawMaterial.Show();
            }
        }

        private void txtCode_EditValueChanged(object sender, EventArgs e)
        {
            if (txtModelCode.Text != string.Empty)
            {
                if (productModelRequest.ProductMasterList != null)
                {

                    //var IsCode = CompanyRequest.MasterCodeList.FirstOrDefault(item => item.Code == txtCode.Text.ToString())?.Id ?? 0;
                    var IsCode = productModelRequest.ProductMasterList.FirstOrDefault(obj => obj.Code.ToLower() == txtModelCode.Text.ToLower() && obj.Id != productModelRequest.Id);

                    if (IsCode != null)
                    {
                        labelAvailable.Visible = false;
                        labelCodeExist.Visible = true;
                    }
                    else
                    {
                        labelAvailable.Visible = true;
                        labelCodeExist.Visible = false;
                    }
                }
                else
                {
                    labelAvailable.Visible = true;
                    labelCodeExist.Visible = false;
                }

            }
            else
            {
                labelAvailable.Visible = false;
                labelCodeExist.Visible = false;
            }
        }

        private void drpRawType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectItem = drpRawType.Text;

            if (productModelRequest.RawMaterialList != null && selectItem != "")
            {
                if (productModelRequest.RawMaterialList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in productModelRequest.RawMaterialList)
                    {

                        if (item.Code == selectItem && drpRawName.Properties.Items.OfType<object>().Any(prop => prop.ToString() == selectItem))
                        {
                            //drpRawName.Properties.Items.Clear();
                            drpRawName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                            break;
                        }
                    }
                }
            }
        }

        private void FrmProductModel_Load(object sender, EventArgs e)
        {
            int centerX = (this.Width - panelControl4.Width) / 2;
            int centerY = (this.Height - panelControl4.Height) / 2;

            // Set the controls' positions to the calculated center position
            panelControl4.Location = new Point(centerX, centerY);
        }
    }
}