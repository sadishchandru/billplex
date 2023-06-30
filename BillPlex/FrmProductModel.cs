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

namespace BillPlex
{
    public partial class FrmProductModel : DevExpress.XtraEditors.XtraForm
    {
        private ProductModel productModelRequest;
        public FrmProductModel()
        {
            InitializeComponent();

            productModelRequest = new ProductModel();
            productModelRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    {"RawMaterialRequired",true},
                    {"ProductModelRequired",true },
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

                        // var foundItem = drpRawType.Properties.Items.FindItem(item => item.ToString() == item.Name.ToString());

                        //ComboBoxItem foundItem = drpRawType.Properties.Items.FirstOrDefault(item => item.ToString() == searchValue);

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
                        drpProSize.Properties.Items.Add(new ImageComboBoxItem(item.Name));
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



                    //productModelRequest.RawMaterialType = drpRawType.Text;
                    //productModelRequest.RawMaterialName = drpRawName.Text;
                    //productModelRequest.ProductName = drpProName.Text;
                    productModelRequest.ModelCode = txtModelCode.Text;
                    productModelRequest.ModelName = txtModelName.Text;
                    productModelRequest.ProductSize = drpProSize.Text;
                    productModelRequest.RawMaterialStock = txtRawStock.Text;
                    productModelRequest.RequiredRawMaterialWeight = txtRawWeight.Text;
                    productModelRequest.WagesForProductModel = txtWages.Text;
                    productModelRequest.PMDate = ddDate.Text;
                    productModelRequest.Update();

                }
                else
                {
                    XtraMessageBox.Show(productModelRequest.Result.Message, "please give the manditory field", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (productModelRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(productModelRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click();
                    ReloadSqlDataSource();
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
            try
            {
                var selectedRows = grd_ProductModel.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    productModelRequest.Id = (Int64)grd_ProductModel.GetRowCellValue(rowHandle, "Id");


                    drpRawType.SelectedIndex = productModelRequest.RawMaterialList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "RawmaterialTypeId")));
                    drpRawName.SelectedIndex = productModelRequest.RawMaterialList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "RawMaterialId")));
                    //drpRawType.Text = grd_ProductModel.GetRowCellValue(rowHandle, "RawmaterialTypeId").ToString();
                    //drpRawName.Text = grd_ProductModel.GetRowCellValue(rowHandle, "RawMaterialId").ToString();

                    drpProName.SelectedIndex = productModelRequest.ProductModelList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "ProductId")));

                    //drpProName.Text = grd_ProductModel.GetRowCellValue(rowHandle, "ProductId").ToString();
                    txtModelCode.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductCode");
                    txtModelName.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductModel");

                    //drpProSize.SelectedIndex = productModelRequest.SizeMasterList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "ProductSize")));


                    drpProSize.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductSize");
                    txtRawStock.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "RawMaterialStock");
                    txtRawWeight.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ReqRawMaterial");
                    txtWages.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "WagesforItem");
                    //var datete = grd_ProductModel.GetRowCellValue(rowHandle, "Date").ToString();
                    //DateTime dat = DateTime.Parse(datete);
                    //ddDate.Text = dat.ToString();
                    var datete = grd_ProductModel.GetRowCellValue(rowHandle, "Date").ToString();
                    ddDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                }
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAdd.Enabled = true;

            }
            catch (Exception ex)
            {

            }
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

                foreach (var row in sqlDataSource1.Result[0])
                {
                    //var model = new YourModel
                    //{
                    //    // Map the columns from the data source to properties in your model
                    //    Property1 = Convert.ToString(row["ColumnName1"]),
                    //    Property2 = Convert.ToString(row["ColumnName2"]),
                    //    // Add more properties as needed
                    //};

                    //dataList.Add(model);
                }

                int count = 0;

                foreach (var item in productModelRequest.RawMaterialList)
                {
                    if (item.Code == selectedRawTypeItem.ToString() && item.Name == selectedRawItem.ToString())
                    {
                        count = int.Parse(item.AuthorName) + count;
                    }
                }

                txtRawStock.Text = count.ToString();
            }


            //if ((selectedRawItem != null && selectedRawItem != "") && (selectedRawTypeItem != null && selectedRawTypeItem != ""))
            //{
            //    int count = 0;

            //    foreach (var item in productModelRequest.RawMaterialList)
            //    {
            //        if (item.Code == selectedRawTypeItem.ToString() && item.Name == selectedRawItem.ToString())
            //        {
            //            count = int.Parse(item.AuthorName) - count;
            //        }
            //    }

            //    txtRawStock.Text = count.ToString();
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}