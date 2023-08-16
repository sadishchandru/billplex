using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
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

        private List<dynamic> OrderMasterSource;

        private GridControl gridControl;

        private DataTable dt;
        public FrmOrderMasterInfo()
        {
            InitializeComponent();
            InitializeDataSource();
            ddOrderDate.DateTime = DateTime.Now;
            lblReason.Visible = false;
            txtReasonbox.Visible = false;
            OrderMasterRequest = new OrderMasterInfo();
            OrderMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            OrderMasterRequest.OrderMasterList = new List<OrderMasterInfo>();

            OrderMasterSource = new List<dynamic>();
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
            var dropdwonList = OrderMasterRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ProductModelRequired")
                {
                    OrderMasterRequest.ProductModelList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "ProductMasterRequired")
                {
                    OrderMasterRequest.ProductMasterList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "CustomerMasterRequired")
                {
                    OrderMasterRequest.CustomerMasterList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "ColorMasterRequired")
                {
                    OrderMasterRequest.ColourMasterList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "OrderMasterRequired")
                {
                    OrderMasterRequest.OrderList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (OrderMasterRequest.ProductMasterList != null)
            {
                //if (OrderMasterRequest.ProductMasterList.Count() > 0)
                //{
                //    foreach (DropDownItemInfo item in OrderMasterRequest.ProductMasterList)
                //    {
                //        drpProductName.Properties.Items.Add(new ImageComboBoxItem(item.productId));
                //    }
                //}
                if (OrderMasterRequest.ProductMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in OrderMasterRequest.ProductMasterList)
                    {
                        var foundItem = "";

                        foreach (string items in drpProductName.Properties.Items)
                        {
                            if (items.ToString().ToLower() == item.productId.ToLower().ToString())
                            {
                                foundItem = items.ToString();
                                break;
                            }
                        }
                        if (foundItem == "")
                        {
                            drpProductName.Properties.Items.Add(new ImageComboBoxItem(item.productId));
                        }
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
            #endregion
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            gridView1.RefreshData();

        }
        private void comboBoxEdit10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCode = (string)drpCustCode.SelectedItem;

            string selectedName = (string)drpCustName.SelectedItem;

            if (selectedCode != null)
            {
                drpCustName.Text = OrderMasterRequest.CustomerMasterList.FirstOrDefault(item => item.Code == selectedCode.ToString())?.Name ?? "";
            }
            else if (selectedName != null)
            {
                drpCustCode.Text = OrderMasterRequest.CustomerMasterList.FirstOrDefault(item => item.Name == selectedName.ToString())?.Code ?? "";
            }
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
                ReloadSqlDataSource();
            }

        }
        #endregion

        #region Edit

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var selectedRows = gridView1.GetSelectedRows();

            //    foreach (var rowHandle in selectedRows)
            //    {
            //        OrderMasterRequest.Id = (int)gridView1.GetRowCellValue(rowHandle, "Id");
            //        txtOrderNo.Text = (string)gridView1.GetRowCellValue(rowHandle, "OrderNo");
            //        var datete = gridView1.GetRowCellValue(rowHandle, "Orderdate").ToString();
            //        ddOrderDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
            //        drpCustCode.Text = (string)gridView1.GetRowCellValue(rowHandle, "Customcode");
            //        drpCustName.Text = gridView1.GetRowCellValue(rowHandle, "CustomerId").ToString();
            //        drpProductName.Text = gridView1.GetRowCellValue(rowHandle, "ProductNameId").ToString();
            //        drpModelName.Text = (string)gridView1.GetRowCellValue(rowHandle, "productcode");
            //        drpModelCode.Text = (string)gridView1.GetRowCellValue(rowHandle, "productmodel");
            //        drpProductSize.Text = (string)gridView1.GetRowCellValue(rowHandle, "productsize");
            //        txtMaterialwt.Text = (string)gridView1.GetRowCellValue(rowHandle, "totalWt");
            //        txtType.Text = (string)gridView1.GetRowCellValue(rowHandle, "RawType");
            //        txtRawmatName.Text = (string)gridView1.GetRowCellValue(rowHandle, "RawmaterialId");
            //        drpProColor.SelectedIndex = OrderMasterRequest.ColourMasterList.FindIndex(x => x.Id == Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "ColorId").ToString()));
            //        var datet = gridView1.GetRowCellValue(rowHandle, "").ToString();
            //        ddDDate.Text = datet != "Delivarydate" ? DateTime.Parse(datet).ToString("MM-dd-yyyy") : "";
            //        drpStatus.Text = (string)gridView1.GetRowCellValue(rowHandle, "Status");
            //        txtTotRawmat.Text = (string)gridView1.GetRowCellValue(rowHandle, "TotalRaw");
            //        txtWages.Text = (string)gridView1.GetRowCellValue(rowHandle, "WagesforEmp");
            //    }
            //    btnAdd.Enabled = true;
            //    btnEdit.Enabled = false;
            //    btnDelete.Enabled = true;
            //    btnUpdate.Enabled = true;

            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        #endregion

        #region Add

        private void btnAdd_click(object sender, EventArgs e)
        {
            try
            {
                if (drpCustCode.Text != string.Empty && drpCustName.Text != string.Empty && txtOrderNo.Text != string.Empty && ddDDate.Text != string.Empty && ddDDate.Text != "")
                {
                    if ((OrderMasterRequest.Id == 0 && txtReasonbox.Visible == true && lblReason.Visible == true) || txtReasonbox.Visible == false && lblReason.Visible == false)
                    {

                        var selectedItems = drpCustName.Text;
                        string selectedMasterItem = (string)drpCustName.SelectedItem;
                        if (selectedMasterItem != null)
                        {
                            OrderMasterRequest.CustomerId = OrderMasterRequest.CustomerMasterList.FirstOrDefault(item => item.Name == selectedMasterItem.ToString())?.Id ?? -1;
                            OrderMasterRequest.CustomerCode = OrderMasterRequest.CustomerMasterList.FirstOrDefault(item => item.Name == selectedMasterItem.ToString())?.Id ?? -1;
                        }
                        var selectedPNameItems = drpProductName.Text;
                        string selectedPNameItem = (string)drpProductName.SelectedItem;
                        if (selectedPNameItems != null)
                        {
                            OrderMasterRequest.ProductNameId = OrderMasterRequest.ProductModelList.FirstOrDefault(item => item.Name == selectedPNameItem.ToString())?.Id ?? -1;
                        }
                        var selectedProColorItems = drpProColor.Text;
                        string selectedProColorItem = (string)drpProColor.SelectedItem;
                        if (selectedProColorItems != null)
                        {
                            OrderMasterRequest.ColorId = OrderMasterRequest.ColourMasterList.FirstOrDefault(item => item.Name == selectedProColorItem.ToString())?.Id ?? -1;
                        }
                        OrderMasterRequest.OrderNo = txtOrderNo.Text;
                        OrderMasterRequest.OrderDate = ddOrderDate.Text;
                        OrderMasterRequest.ProductModel = drpModelName.Text;
                        OrderMasterRequest.ProductCode = drpModelCode.Text;
                        OrderMasterRequest.ProductSize = drpProductSize.Text;
                        OrderMasterRequest.RawMaterialId = txtRawmatName.Text;
                        OrderMasterRequest.Quantity = txtQuantity.Text;
                        OrderMasterRequest.RawType = txtType.Text;
                        OrderMasterRequest.RawQty = txtRawmatName.Text;
                        OrderMasterRequest.MaterialWghtNo = txtMaterialwt.Text;
                        OrderMasterRequest.Deliverydate = ddDDate.Text;
                        OrderMasterRequest.status = drpStatus.Text;
                        OrderMasterRequest.TotalRaw = txtTotRawmat.Text;
                        OrderMasterRequest.WagesforEmp = txtWages.Text;
                        OrderMasterRequest.AdditionalReason = txtReasonbox.Text;
                        OrderMasterRequest.Update();
                        if (OrderMasterRequest.Result.Status == ResultStatus.Success)
                        {
                            XtraMessageBox.Show(OrderMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (OrderMasterRequest.OrderMasterList.Count() > 0)
                            {
                                foreach (var item in OrderMasterRequest.OrderMasterList)
                                {
                                    DataTable dataTable = gridControl1.DataSource as DataTable;
                                    DataRow newRow = dataTable.NewRow();
                                    newRow["OrderNo"] = item.OrderNo;
                                    newRow["Orderdate"] = item.OrderDate;
                                    newRow["Customcode"] = item.CustomerCode;
                                    newRow["Code"] = item.Code;
                                    newRow["CustomerId"] = item.CustomerId;
                                    newRow["Name"] = item.CustomerName;
                                    newRow["ProductNameId"] = item.ProductNameId;
                                    newRow["Productmodel"] = item.Productmodel;
                                    newRow["productmodel"] = item.ProductModel;
                                    newRow["productcode"] = item.ProductCode;
                                    newRow["productsize"] = item.ProductSize;
                                    newRow["Quantity"] = item.Quantity;
                                    newRow["RawType"] = item.RawType;
                                    newRow["RawmaterialId"] = item.RawMaterialId;
                                    newRow["ColorId"] = item.ColorId;
                                    newRow["RawQty"] = item.RawQty;
                                    newRow["Delivarydate"] = item.Deliverydate;
                                    newRow["Status"] = item.status;
                                    newRow["TotalRaw"] = item.TotalRaw;
                                    newRow["WagesforEmp"] = item.WagesforEmp;
                                    newRow["totalWt"] = item.MaterialWghtNo;
                                    newRow["AdditionalReason"] = item.AdditionalReason;
                                    // Add the new DataRow to the DataTable
                                    dataTable.Rows.Add(newRow);
                                }
                                // Refresh the grid to display the new row
                                gridView1.RefreshData();
                                gridControl1.RefreshDataSource();
                            }
                            btnClear_Click();
                            ReloadSqlDataSource();
                            btnClear_Click();
                        }
                        else
                        {
                            XtraMessageBox.Show(OrderMasterRequest.Result.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(OrderMasterRequest.Result.Message, "please give the manditory field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void drpProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpProductSize.SelectedItem;
            string ProductName = (string)drpProductName.SelectedItem;
            string ModelName = (string)drpModelName.SelectedItem;
            string ModelCode = (string)drpModelCode.SelectedItem;

            if (selectedItem != null)
            {
                txtMaterialwt.Text = OrderMasterRequest.ProductMasterList.FirstOrDefault(item => item.productId == ProductName.ToString() && item.proModel == ModelName.ToString() && item.Code == ModelCode.ToString() && item.Name == selectedItem.ToString())?.AuthorName ?? "";
                txtType.Text = OrderMasterRequest.ProductMasterList.FirstOrDefault(item => item.productId == ProductName.ToString() && item.proModel == ModelName.ToString() && item.Code == ModelCode.ToString() && item.Name == selectedItem.ToString())?.Code ?? "";
                txtRawmatName.Text = OrderMasterRequest.ProductMasterList.FirstOrDefault(item => item.productId == ProductName.ToString() && item.proModel == ModelName.ToString() && item.Code == ModelCode.ToString() && item.Name == selectedItem.ToString())?.RawMaterial ?? "";
                txtWages.Text = OrderMasterRequest.ProductMasterList.FirstOrDefault(item => item.productId == ProductName.ToString() && item.proModel == ModelName.ToString() && item.Code == ModelCode.ToString() && item.Name == selectedItem.ToString())?.SubCom ?? "";
            }
        }
        public void BindData(dynamic SelectedOrderList)
        {
            var selectedRows = SelectedOrderList.GetSelectedRows();
            foreach (var rowHandle in selectedRows)
            {
                OrderMasterRequest.Id = (int)SelectedOrderList.GetRowCellValue(rowHandle, "Id");
                txtOrderNo.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "OrderNo");
                var datete = SelectedOrderList.GetRowCellValue(rowHandle, "Orderdate").ToString();
                ddOrderDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                drpCustCode.SelectedIndex = OrderMasterRequest.CustomerMasterList.FindIndex(x => x.Id == Convert.ToInt32(SelectedOrderList.GetRowCellValue(rowHandle, "Customcode").ToString()));
                drpCustName.SelectedIndex = OrderMasterRequest.CustomerMasterList.FindIndex(x => x.Id == Convert.ToInt32(SelectedOrderList.GetRowCellValue(rowHandle, "CustomerId").ToString()));
                drpProductName.SelectedIndex = OrderMasterRequest.ProductMasterList.FindIndex(x => x.Id == Convert.ToInt32(SelectedOrderList.GetRowCellValue(rowHandle, "ProductNameId").ToString()));
                drpModelName.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "productcode");
                drpModelCode.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "productmodel");
                drpProductSize.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "productsize");
                txtMaterialwt.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "TotalWt");
                txtType.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "RawType");
                txtRawmatName.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "RawmaterialId");
                drpProColor.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "ColorId");
                txtQuantity.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "Quantity");
                datete = SelectedOrderList.GetRowCellValue(rowHandle, "Delivarydate").ToString();
                ddDDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                drpStatus.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "Status");
                txtTotRawmat.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "TotalRaw");
                txtWages.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "WagesforEmp");
                txtReasonbox.Text = (string)SelectedOrderList.GetRowCellValue(rowHandle, "AdditionalReason");
            }
            btnAdd.Enabled = false;
            btnNew.Enabled = false;
            btnUpdate.Enabled = true;
            lblReason.Visible = false;
            txtReasonbox.Visible = false;
        }
        #region Reset
        private void btnClear_Click(object sender = null, EventArgs e = null)
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
            ddDDate.ResetText();
            drpStatus.ResetText();
            txtTotRawmat.ResetText();
            txtWages.ResetText();
        }
        #endregion
        private void txtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            var count = 0;
            if (txtMaterialwt.Text != "" && txtQuantity.Text != "")
            {
                decimal a = Convert.ToDecimal(txtMaterialwt.Text);
                decimal b = Convert.ToDecimal(txtQuantity.Text);
                count = (int)(a * b);
                txtTotRawmat.Text = count.ToString();
            }
        }
        private void drpProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = drpProductName.Text;
            if (OrderMasterRequest.ProductMasterList != null && selectItem != "")
            {
                drpModelName.Properties.Items.Clear();
                if (OrderMasterRequest.ProductMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in OrderMasterRequest.ProductMasterList)
                    {
                        if (item.productId.ToLower() == selectItem.ToLower())
                        {
                            if (!drpModelName.Properties.Items.OfType<object>().Any(prop => prop.ToString().ToLower() == item.proModel.ToLower()))
                            {
                                drpModelName.Properties.Items.Add(new ImageComboBoxItem(item.proModel));
                            }
                        }
                    }
                }
            }
        }
        private void drpModelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = drpModelName.Text;
            if (OrderMasterRequest.ProductMasterList != null && selectItem != "")
            {
                if (OrderMasterRequest.ProductMasterList.Count() > 0)
                {
                    drpModelCode.Properties.Items.Clear();
                    foreach (DropDownItemInfo item in OrderMasterRequest.ProductMasterList)
                    {
                        if (item.proModel == selectItem)
                        {
                            drpModelCode.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                        }
                    }
                }
            }
        }
        private void drpModelCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = drpModelCode.Text;

            if (OrderMasterRequest.ProductMasterList != null && selectItem != "")
            {
                drpProductSize.Properties.Items.Clear();

                if (OrderMasterRequest.ProductMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in OrderMasterRequest.ProductMasterList)
                    {
                        if (item.Code == selectItem)
                        {
                            drpProductSize.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                        }
                    }
                }
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            Form myForm = Application.OpenForms["FrmCustomerMaster"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmCustomerMaster();
                myForm.MdiParent = this.MdiParent;
                myForm.Show();
                IsOpen = true;
            }
            if (IsOpen == false)
            {
                FrmCustomerMaster rawMaterial = new FrmCustomerMaster();
                rawMaterial.MdiParent = this.MdiParent;
                rawMaterial.Show();
            }
        }
        private void btnProName_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            Form myForm = Application.OpenForms["FrmProductModel"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmProductModel();
                myForm.MdiParent = this.MdiParent;
                myForm.Show();
                IsOpen = true;
            }
            if (IsOpen == false)
            {
                FrmProductModel productModel = new FrmProductModel();
                productModel.MdiParent = this.MdiParent;
                productModel.Show();
            }
        }
        private void btnProColor_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            Form myForm = Application.OpenForms["FrmColorMaster"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmColorMaster();
                myForm.MdiParent = this.MdiParent;
                myForm.Show();
                IsOpen = true;
            }
            if (IsOpen == false)
            {
                FrmColorMaster colorMaster = new FrmColorMaster();
                colorMaster.MdiParent = this.MdiParent;
                colorMaster.Show();
            }
        }
        private void InitializeDataSource()
        {
            //FamilyGridView.Columns.Clear();
            DataTable dataTable = new DataTable();
            // Create columns and bind them to the object properties
            dataTable.Columns.Add("OrderNo", typeof(string));
            dataTable.Columns.Add("Orderdate", typeof(string));
            dataTable.Columns.Add("Customcode", typeof(string));
            dataTable.Columns.Add("Code", typeof(string));
            dataTable.Columns.Add("CustomerId", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("ProductNameId", typeof(string));
            dataTable.Columns.Add("Productmodel", typeof(string));
            dataTable.Columns.Add("productmodel", typeof(string));
            dataTable.Columns.Add("productcode", typeof(string));
            dataTable.Columns.Add("productsize", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));
            dataTable.Columns.Add("RawType", typeof(string));
            dataTable.Columns.Add("RawmaterialId", typeof(string));
            dataTable.Columns.Add("ColorId", typeof(string));
            dataTable.Columns.Add("RawQty", typeof(string));
            dataTable.Columns.Add("Delivarydate", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("TotalRaw", typeof(string));
            dataTable.Columns.Add("WagesforEmp", typeof(string));
            dataTable.Columns.Add("totalWt", typeof(string));
            dataTable.Columns.Add("AdditionalReason", typeof(string));
            gridControl1.DataSource = dataTable;
            gridView1.RefreshData();
            gridControl1.RefreshDataSource();
        }
        private void txtOrderNo_EditValueChanged(object sender, EventArgs e)
        {
            if (txtOrderNo.Text != string.Empty)
            {
                if (OrderMasterRequest.OrderList != null)
                {
                    var IsCode = OrderMasterRequest.OrderList.FirstOrDefault(obj => obj.Code.ToLower() == txtOrderNo.Text.ToLower() && obj.Id != OrderMasterRequest.Id);
                    if (IsCode != null)
                    {
                        lblReason.Visible = false;
                        txtReasonbox.Visible = false;
                        lblReason.Visible = true;
                        txtReasonbox.Visible = true;
                    }
                    else
                    {
                        lblReason.Visible = true;
                        txtReasonbox.Visible = true;
                        lblReason.Visible = false;
                        txtReasonbox.Visible = false;
                    }
                }
                else
                {
                    lblReason.Visible = true;
                    txtReasonbox.Visible = true;
                    lblReason.Visible = false;
                    txtReasonbox.Visible = false;
                }
            }
            else
            {
                lblReason.Visible = false;
                txtReasonbox.Visible = false;
                lblReason.Visible = false;
                txtReasonbox.Visible = false;
            }
        }

        private void FrmOrderMasterInfo_Load(object sender, EventArgs e)
        {
            int centerX = (this.Width - panelControl3.Width) / 2;
            int centerY = (this.Height - panelControl3.Height) / 2;

            // Set the controls' positions to the calculated center position
            panelControl3.Location = new Point(centerX, centerY);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}