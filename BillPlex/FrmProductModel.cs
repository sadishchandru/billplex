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

            productModelRequest = new ProductModel();
            productModelRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();

            LabelExceed.Visible = false;

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
            //try
            //{
            //    var selectedRows = grd_ProductModel.GetSelectedRows();

            //    foreach (var rowHandle in selectedRows)
            //    {
            //        productModelRequest.Id = (Int64)grd_ProductModel.GetRowCellValue(rowHandle, "Id");


            //        drpRawType.SelectedIndex = productModelRequest.RawMaterialList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "RawmaterialTypeId")));
            //        drpRawName.SelectedIndex = productModelRequest.RawMaterialList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "RawMaterialId")));
            //        //drpRawType.Text = grd_ProductModel.GetRowCellValue(rowHandle, "RawmaterialTypeId").ToString();
            //        //drpRawName.Text = grd_ProductModel.GetRowCellValue(rowHandle, "RawMaterialId").ToString();

            //        drpProName.SelectedIndex = productModelRequest.ProductModelList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "ProductId")));

            //        //drpProName.Text = grd_ProductModel.GetRowCellValue(rowHandle, "ProductId").ToString();
            //        txtModelCode.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductCode");
            //        txtModelName.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductModel");

            //        //drpProSize.SelectedIndex = productModelRequest.SizeMasterList.FindIndex(x => x.Id == Convert.ToInt32(grd_ProductModel.GetRowCellValue(rowHandle, "ProductSize")));


            //        drpProSize.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ProductSize");
            //        txtRawStock.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "RawMaterialStock");
            //        txtRawWeight.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "ReqRawMaterial");
            //        txtWages.Text = (string)grd_ProductModel.GetRowCellValue(rowHandle, "WagesforItem");
            //        //var datete = grd_ProductModel.GetRowCellValue(rowHandle, "Date").ToString();
            //        //DateTime dat = DateTime.Parse(datete);
            //        //ddDate.Text = dat.ToString();
            //        var datete = grd_ProductModel.GetRowCellValue(rowHandle, "Date").ToString();
            //        ddDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
            //    }
            //    btnAdd.Enabled = false;
            //    btnEdit.Enabled = false;
            //    btnDelete.Enabled = true;
            //    btnUpdate.Enabled = true;
            //    btnAdd.Enabled = true;

            //}
            //catch (Exception ex)
            //{

            //}
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
                int actualCount = 0;
                // Iterate over each row in the grid
                for (int i = 0; i < gridView.RowCount; i++)
                {

                    //var RawMaterialType = grd_ProductModel.GetRowCellValue(i, "RawMaterialType").ToString();
                    //var RawMaterial = grd_ProductModel.GetRowCellValue(i, "RawMaterials").ToString();

                    if (selectedRawTypeItem == grd_ProductModel.GetRowCellValue(i, "RawMaterialType").ToString() && selectedRawItem == grd_ProductModel.GetRowCellValue(i, "RawMaterials").ToString())
                    {
                        int reqMateialcount = int.Parse(grd_ProductModel.GetRowCellValue(i, "ReqRawMaterial").ToString());
                        actualCount = actualCount + reqMateialcount;
                    }
                    //productModelRequest.Id = (Int64)grd_ProductModel.GetRowCellValue(i, "Id");

                    // Dictionary<string, object> rowData = new Dictionary<string, object>();

                    // Iterate over each column in the row
                    //foreach (var rowHandle in selectedRows)
                    //{ 

                    //}
                    //for (int j = 0; j < gridView.Columns.Count; j++)
                    //{
                    //    GridColumn column = gridView.Columns[j];

                    //    if (column.FieldName == "ReqRawMaterial" && (column.FieldName == "RawMaterialType" && column.FieldName == "RawMaterials"))
                    //    {

                    //        string columnName = column.FieldName;
                    //        //object cellValue = gridView.GetRowCellValue(i, column);
                    //        object cellValue = grd_ProductModel.GetRowCellValue(0, "Id");
                    //        rowData.Add(columnName, cellValue);

                    //    }
                    //}

                    // allData.Add(rowData);
                }


                //object dataSource = gridControl1.DataSource;

                //// Check if the DataSource is a DataTable
                //if (dataSource is DataTable dataTable)
                //{
                //    // Get all the values from the DataTable
                //    List<List<object>> allValues = dataTable.AsEnumerable()
                //        .Select(row => row.ItemArray.ToList())
                //        .ToList();

                //    // Use the resulting list of values as needed
                //    // ...
                //}
                //else if (dataSource is IEnumerable enumerable)
                //{
                //    // Get all the values from the IEnumerable
                //    List<List<object>> allValues = enumerable.Cast<object>()
                //        .Select(item => item.GetType().GetProperties().Select(prop => prop.GetValue(item)).ToList())
                //        .ToList();

                //    // Use the resulting list of values as needed
                //    // ...
                //}
                //else
                //{
                //    // Handle other data source types accordingly
                //}
                //DataTable dataTable = ((DataTable)gridControl1.DataSource);

                //// Get all the values from the DataTable
                //List<List<object>> allValues = dataTable.AsEnumerable()
                //    .Select(row => row.ItemArray.ToList())
                //    .ToList();


                //List<object[]> allValues = new List<object[]>();

                //// Iterate through the rows of the GridView
                //for (int rowHandle = 0; rowHandle < grd_ProductModel.DataRowCount; rowHandle++)
                //{
                //    List<object> rowValues = new List<object>();

                //    // Iterate through the columns of the current row
                //    for (int colIndex = 0; colIndex < grd_ProductModel.Columns.Count; colIndex++)
                //    {
                //        object cellValue = grd_ProductModel.GetRowCellValue(rowHandle, grd_ProductModel.Columns[colIndex]);
                //        rowValues.Add(cellValue);
                //    }

                //    allValues.Add(rowValues.ToArray());
                //}
                //var dataView = sqlDataSource1.data;
                //var dataTable = sqlDataSource1.ToTable();

                // Assuming you have a GridControl named "gridControl1" bound to a data source

                // Get the data source from the GridControl
                //var dataSource = (DataView)gridControl1.DataSource;

                // Check if the data source is a DataTable
                //if (dataSource is DataView dataView)
                //{
                //  var val = dataSource.ToTable();
                //}

                //if (dataSource is DataTable dataTable)
                //{
                //    // Iterate through the rows of the DataTable
                //    foreach (DataRow row in dataTable.Rows)
                //    {
                //        // Access the values of each column in the row
                //        var column1Value = row["Column1"].ToString();
                //        var column2Value = row["Column2"].ToString();

                //        // Do something with the values
                //        Console.WriteLine($"Column 1: {column1Value}, Column 2: {column2Value}");
                //    }
                //}


                // Assuming you have an ASPxGridView control named "gridView1" and a SqlDataSource control named "sqlDataSource1"

                // Get the data source from the SqlDataSource control
                // var dataSource = (SqlDataSource)sqlDataSource1;

                // Retrieve the data from the data source
                //  var dataView = (DataView)dataSource.Select(DataSourceSelectArguments.Empty);
                // var dataTable = dataView.ToTable();

                //var dataViewGrid = gridControl1.DefaultView;

                //foreach (DataRowView rowView in gridControl1.DefaultView)
                //{
                //    // Access the values of each column in the row
                //    var column1Value = rowView["Column1"].ToString();
                //    var column2Value = rowView["Column2"].ToString();

                //    // Do something with the values
                //    Console.WriteLine($"Column 1: {column1Value}, Column 2: {column2Value}");
                //}


                // Iterate through the rows of the data table
                //foreach (DataRow row in dataTable.Rows)
                //{
                //    // Access the values of each column in the row
                //    var column1Value = row["Column1"].ToString();
                //    var column2Value = row["Column2"].ToString();

                //    // Do something with the values
                //    Console.WriteLine($"Column 1: {column1Value}, Column 2: {column2Value}");
                //}

                //foreach (var row in sqlDataSource1.Result[0]. )
                //{
                //var model = new YourModel
                //{
                //    // Map the columns from the data source to properties in your model
                //    Property1 = Convert.ToString(row["ColumnName1"]),
                //    Property2 = Convert.ToString(row["ColumnName2"]),
                //    // Add more properties as needed
                //};

                //dataList.Add(model);
                //}

                int count = 0;

                foreach (var item in productModelRequest.RawMaterialList)
                {
                    if (item.Code == selectedRawTypeItem.ToString() && item.Name == selectedRawItem.ToString())
                    {
                        count = int.Parse(item.AuthorName) + count;
                    }
                }

                txtRawStock.Text = Math.Abs(count - actualCount).ToString();
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

        private void txtRawWeight_EditValueChanged(object sender, EventArgs e)
        {
            if (txtRawWeight.Text != "" && txtRawStock.Text != "")
            {
                if (int.Parse(txtRawStock.Text) < int.Parse(txtRawWeight.Text))
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
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}