using BusinessLayer;
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
                    { "CustomerMasterRequired", true }
                    
                };

            var dropdwonList = OrderMasterRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "CustomerMasterRequired")
                {
                    OrderMasterRequest.OrderMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (OrderMasterRequest.OrderMasterList.Count() > 0)
            {
                foreach (DropDownItemInfo item in OrderMasterRequest.OrderMasterList)
                {
                    drpCustCode.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                    drpCustName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
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
                var selectedItem = drpCustCode.EditValue;
                var selectedItems = drpCustName.Text;

                if (selectedItem != null)
                {
                    OrderMasterRequest.CustomerCodeId = OrderMasterRequest.OrderMasterList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.Id ?? -1;
                }

                string selectedMasterItem = (string)drpCustName.SelectedItem;

                if (selectedMasterItem != null)
                {
                    OrderMasterRequest.CustomerId = OrderMasterRequest.OrderMasterList.FirstOrDefault(item => item.Name == selectedMasterItem.ToString())?.Id ?? -1;
                }

                OrderMasterRequest.OrderNo = txtOrderNo.Text;
                OrderMasterRequest.OrderDate = ddOrderDate.Text;
                //OrderMasterRequest.CustomerCodeId = drpCustCode.Text;
                //OrderMasterRequest.CustomerId = int.Parse(drpCustName.Text);
                OrderMasterRequest.ProductNameId = int.Parse(drpProductName.Text);
                OrderMasterRequest.ProductModel = int.Parse(drpModelName.Text);
                OrderMasterRequest.ProductCode = int.Parse(drpModelCode.Text);
                OrderMasterRequest.ProductSize = int.Parse(drpProductSize.Text);
                OrderMasterRequest.Quantity = txtMaterialwt.Text;
                OrderMasterRequest.RawType = txtType.Text;
                OrderMasterRequest.RawQty = txtRawmatName.Text;
                OrderMasterRequest.ColorId = int.Parse(drpProColor.Text);
                OrderMasterRequest.TotalRaw = txtQuantity.Text;
                OrderMasterRequest.Deliverydate = ddProDate.Text;
                OrderMasterRequest.status = int.Parse(drpStatus.Text);
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

        #region Reset
        private void Reset_Click(object sender, EventArgs e)
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

        private void drpCustCode_Click(object sender, EventArgs e)
        {
            string selectedItem = (string)drpCustCode.SelectedItem;

            if (selectedItem != null)
            {
                Text = OrderMasterRequest.CustomerMasterList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }
    }
}