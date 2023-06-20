﻿using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmOrderMasterInfo : DevExpress.XtraEditors.XtraForm
    {
        private OrderMasterInfo OrderMasterRequest;
        public FrmOrderMasterInfo()
        {
            InitializeComponent();
            OrderMasterRequest = new OrderMasterInfo();
            OrderMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    {"ProductModelRequest",true},
                    {"ProductMasterRequest",true},
                    {"SizeMasterRequest",true},
                    { "CustomerMasterRequired", true },
                    { "ColorMasterRequired", true }
                };

            var dropdwonList = OrderMasterRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ProductModelRequest")
                {
                    OrderMasterRequest.ProductMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }
            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ProductMasterRequest")
                {
                    OrderMasterRequest.ProductModelList = (List<DropDownItemInfo>)item.Value;
                }
            }

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "SizeMasterRequest")
                {
                    OrderMasterRequest.SizeMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "CustomerMasterRequired")
                {
                    OrderMasterRequest.CustomerMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ColorMasterRequired")
                {
                    OrderMasterRequest.ColourMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (OrderMasterRequest.ProductModelList != null)
            {
                if (OrderMasterRequest.ProductModelList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in OrderMasterRequest.ProductModelList)
                    {
                        drpModelName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                        drpModelCode.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                    }
                }
            }
            if (OrderMasterRequest.ProductMasterList != null)
            {
                if (OrderMasterRequest.ProductMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in OrderMasterRequest.ProductMasterList)
                    {
                        drpProductName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            if (OrderMasterRequest.SizeMasterList != null)
            {
                if (OrderMasterRequest.SizeMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in OrderMasterRequest.SizeMasterList)
                    {
                        drpProductSize.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            if (OrderMasterRequest.CustomerMasterList != null)
            {
                if (OrderMasterRequest.CustomerMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in OrderMasterRequest.CustomerMasterList)
                    {
                        drpCustCode.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                        drpCustName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            if (OrderMasterRequest.ColourMasterList != null)
            {
                if (OrderMasterRequest.ColourMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in OrderMasterRequest.ColourMasterList)
                    {
                        drpProColor.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
        }

        

        private void comboBoxEdit10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Delete      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var id = gridView1.GetRowCellValue(rowHandle, "Id");

                OrderMasterRequest.Id = (Int64)id;
            }

            OrderMasterRequest.Delete();

            if (OrderMasterRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(OrderMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Edit

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView1.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    txtOrderNo.Text = (string)gridView1.GetRowCellValue(rowHandle, "@OrderNo");
                    ddOrderDate.Text = (string)gridView1.GetRowCellValue(rowHandle, "Orderdate");
                    var datete = gridView1.GetRowCellValue(rowHandle, "Orderdate").ToString();
                    DateTime dat = DateTime.Parse(datete);
                    drpCustCode.Text = (string)gridView1.GetRowCellValue(rowHandle, "Customcode");
                    drpCustName.Text = (string)gridView1.GetRowCellValue(rowHandle, "CustomerId");
                    drpProductName.Text = (string)gridView1.GetRowCellValue(rowHandle, "ProductNameId");
                    drpModelCode.Text = (string)gridView1.GetRowCellValue(rowHandle, "productcode");
                    drpModelName.Text = (string)gridView1.GetRowCellValue(rowHandle, "productmodel");
                    drpProductSize.Text = (string)gridView1.GetRowCellValue(rowHandle, "productsize");
                    txtMaterialwt.Text = (string)gridView1.GetRowCellValue(rowHandle, "Quantity");
                    txtType.Text = (string)gridView1.GetRowCellValue(rowHandle, "RawType");
                    txtRawmatName.Text = (string)gridView1.GetRowCellValue(rowHandle, "RawmaterialId");
                    drpProColor.Text = (string)gridView1.GetRowCellValue(rowHandle, "ColorId");
                    txtQuantity.Text = (string)gridView1.GetRowCellValue(rowHandle, "RawQty");
                    ddProDate.Text = (string)gridView1.GetRowCellValue(rowHandle, "Delivarydate");
                    var datet = gridView1.GetRowCellValue(rowHandle, "Delivarydate").ToString();
                    DateTime date = DateTime.Parse(datete);
                    drpStatus.Text = (string)gridView1.GetRowCellValue(rowHandle, "Status");
                    txtTotRawmat.Text = (string)gridView1.GetRowCellValue(rowHandle, "TotalRaw");
                    txtWages.Text = (string)gridView1.GetRowCellValue(rowHandle, "WagesforEmp");
                    
                }
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Add

        private void btnAdd_click(object sender, EventArgs e)
        {
            try
            {
                var selectedItems = drpCustName.Text;

                string selectedMasterItem = (string)drpCustName.SelectedItem;

                if (selectedMasterItem != null)
                {
                    OrderMasterRequest.CustomerId = OrderMasterRequest.CustomerMasterList.FirstOrDefault(item => item.Name == selectedMasterItem.ToString())?.Id ?? -1;
                }
                var selectedPNameItems = drpProductName.Text;
                
                string selectedMastersItem = (string)drpProductName.SelectedItem;

                if (selectedMastersItem != null)
                {
                    OrderMasterRequest.ProductNameId = OrderMasterRequest.ProductMasterList.FirstOrDefault(item => item.Name == selectedMastersItem.ToString())?.Id ?? -1;
                }

                var selectedProColorItems = drpProColor.Text;

                string selectedCMasterItem = (string)drpProColor.SelectedItem;

                if (selectedCMasterItem != null)
                {
                    OrderMasterRequest.ColorId = OrderMasterRequest.ColourMasterList.FirstOrDefault(item => item.Name == selectedCMasterItem.ToString())?.Id ?? -1;
                }

                OrderMasterRequest.OrderNo = txtOrderNo.Text;
                OrderMasterRequest.OrderDate = ddOrderDate.Text;
                OrderMasterRequest.CustomerCodeId = drpCustCode.Text;
                //OrderMasterRequest.CustomerId = int.Parse(drpCustName.Text);
                //OrderMasterRequest.ProductNameId = int.Parse(drpProductName.Text);
                OrderMasterRequest.ProductModel = drpModelName.Text;
                OrderMasterRequest.ProductCode = drpModelCode.Text;
                OrderMasterRequest.ProductSize = drpProductSize.Text;
                OrderMasterRequest.Quantity = txtMaterialwt.Text;
                OrderMasterRequest.RawType = txtType.Text;
                OrderMasterRequest.RawQty = txtRawmatName.Text;
                //OrderMasterRequest.ColorId = int.Parse(drpProColor.Text);
                OrderMasterRequest.TotalRaw = txtQuantity.Text;
                OrderMasterRequest.Deliverydate = ddProDate.Text;
                OrderMasterRequest.status = drpStatus.Text;
                OrderMasterRequest.TotalRaw = txtTotRawmat.Text;
                OrderMasterRequest.WagesforEmp = txtWages.Text;
                OrderMasterRequest.Update();

                if (OrderMasterRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(OrderMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void drpCustCode_Click(object sender, EventArgs e)
        {
            
        }

        private void drpProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void BindData(dynamic SelectedOrderList)
        {
            var selectedRows = SelectedOrderList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                OrderMasterRequest.Id = SelectedOrderList.GetRowCellValue(rowHandle, "Id");
                txtOrderNo.Text = SelectedOrderList.GetRowCellValue(rowHandle, "OrderNo");
                var datete = SelectedOrderList.GetRowCellValue(rowHandle, "Orderdate");

                ddOrderDate.Text = datete.ToString();
                //ddOrderDate.Text = SelectedOrderList.GetRowCellValue(rowHandle, "Orderdate");
                drpCustCode.Text = SelectedOrderList.GetRowCellValue(rowHandle, "Customcode");
                drpCustName.Text = SelectedOrderList.GetRowCellValue(rowHandle, "CustomerId") == 0 ? string.Empty : SelectedOrderList.GetRowCellValue(rowHandle, "CustomerId").ToString();
                drpProductName.Text = SelectedOrderList.GetRowCellValue(rowHandle, "ProductNameId") == 0 ? string.Empty : SelectedOrderList.GetRowCellValue(rowHandle, "CustomerId").ToString();
                drpModelName.Text = SelectedOrderList.GetRowCellValue(rowHandle, "productmodel");
                drpModelCode.Text = SelectedOrderList.GetRowCellValue(rowHandle, "productcode");
                drpProductSize.Text = SelectedOrderList.GetRowCellValue(rowHandle, "productsize");
                txtMaterialwt.Text = SelectedOrderList.GetRowCellValue(rowHandle, "Quantity");
                txtType.Text = SelectedOrderList.GetRowCellValue(rowHandle, "RawType");
                drpProColor.Text = SelectedOrderList.GetRowCellValue(rowHandle, "ColorId") == 0 ? string.Empty : SelectedOrderList.GetRowCellValue(rowHandle, "CustomerId").ToString();
                txtQuantity.Text = SelectedOrderList.GetRowCellValue(rowHandle, "RawQty");
                //ddProDate.Text = SelectedOrderList.GetRowCellValue(rowHandle, "Delivarydate");
                var datet = SelectedOrderList.GetRowCellValue(rowHandle, "Delivarydate");

                ddProDate.Text = datet.ToString();
                drpStatus.Text = SelectedOrderList.GetRowCellValue(rowHandle, "Status");
                txtTotRawmat.Text = SelectedOrderList.GetRowCellValue(rowHandle, "TotalRaw");
                txtWages.Text = SelectedOrderList.GetRowCellValue(rowHandle, "WagesforEmp");
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = false;
            btnUpdate.Enabled = true;
        }

        #region Reset
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderNo.ResetText();
            ddOrderDate.ResetText();
            drpCustCode.ResetText();
            drpCustName.ResetText();
            drpProductName.ResetText();
            drpModelCode.ResetText();
            drpModelName.ResetText();
            drpProductSize.ResetText();
            txtMaterialwt.ResetText();
            txtType.ResetText();
            txtRawmatName.ResetText();
            drpProColor.ResetText();
            txtQuantity.ResetText();
            ddProDate.ResetText();
            drpStatus.ResetText();
            txtTotRawmat.ResetText();
            txtWages.ResetText();
        }
        #endregion
    }
}