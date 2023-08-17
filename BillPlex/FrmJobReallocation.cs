﻿using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmJobReallocation : DevExpress.XtraEditors.XtraForm
    {
        private JobGivingWithoutDc JobGivingWithoutDcRequest;
        public FrmJobReallocation()
        {
            InitializeComponent();

            JobGivingWithoutDcRequest = new JobGivingWithoutDc();

            JobGivingWithoutDcRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>
            {
                    { "EmployeePersonalRequired", true },
                    { "OrderMasterRequired", true }
            };

            var dropdwonList = JobGivingWithoutDcRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "EmployeePersonalRequired")
                {
                    JobGivingWithoutDcRequest.EmployeePersonalList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "OrderMasterRequired")
                {
                    JobGivingWithoutDcRequest.OrderMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }
            if (JobGivingWithoutDcRequest.EmployeePersonalList != null)
            {
                if (JobGivingWithoutDcRequest.EmployeePersonalList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in JobGivingWithoutDcRequest.EmployeePersonalList)
                    {
                        drpEmpCode.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                    }
                }
            }

            gridView1.GridControl.DataSource = sqlDataSource1;
            gridView2.GridControl.DataSource = sqlDataSource2;

            gridView2.GridControl.Visible = false;

            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView2.OptionsBehavior.AutoPopulateColumns = false;

            ddReceivingDate.DateTime = DateTime.Now;

            gridView1.BestFitColumns();
            gridView2.BestFitColumns();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView1.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    JobGivingWithoutDcRequest.Id = (Int64)gridView1.GetRowCellValue(rowHandle, "Id");
                    txtEmpCode.Text = gridView1.GetRowCellValue(rowHandle, "EmployeeCode").ToString();
                    txtEmpName.Text = (string)gridView1.GetRowCellValue(rowHandle, "EmployeeName");
                    txtCustName.Text = (string)gridView1.GetRowCellValue(rowHandle, "CustomerName");
                    txtRawMaterial.Text = (string)gridView1.GetRowCellValue(rowHandle, "RawMaterial");
                    txtRawType.Text = (string)gridView1.GetRowCellValue(rowHandle, "Type");
                    txtProductCode.Text = (string)gridView1.GetRowCellValue(rowHandle, "ModelCode");
                    txtProModel.Text = (string)gridView1.GetRowCellValue(rowHandle, "ModelName");
                    txtQuanity.Text = (string)gridView1.GetRowCellValue(rowHandle, "QuantityPiece");
                    txtProSize.Text = (string)gridView1.GetRowCellValue(rowHandle, "ProductSize");
                    txtProColor.Text = (string)gridView1.GetRowCellValue(rowHandle, "Color");
                    lblWeight.Text = (string)gridView1.GetRowCellValue(rowHandle, "WeightKg");
                    txtReceivedQty.Text = (string)gridView1.GetRowCellValue(rowHandle, "received");
                    JobGivingWithoutDcRequest.OrderNo = gridView1.GetRowCellValue(rowHandle, "OrderNo").ToString();
                    JobGivingWithoutDcRequest.CompanyName = gridView1.GetRowCellValue(rowHandle, "CompanyName").ToString();
                    JobGivingWithoutDcRequest.Director = gridView1.GetRowCellValue(rowHandle, "Director").ToString();
                    JobGivingWithoutDcRequest.CustomerCode = gridView1.GetRowCellValue(rowHandle, "CustomerCode").ToString();
                    JobGivingWithoutDcRequest.CustomerName = gridView1.GetRowCellValue(rowHandle, "CustomerName").ToString();
                    JobGivingWithoutDcRequest.ProductName = gridView1.GetRowCellValue(rowHandle, "ModelName").ToString();
                    JobGivingWithoutDcRequest.Color = gridView1.GetRowCellValue(rowHandle, "Color").ToString();
                    JobGivingWithoutDcRequest.WagesEmp = gridView1.GetRowCellValue(rowHandle, "WagesEmp").ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drpEmpCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)drpEmpCode.SelectedItem;
            if (selected != null)
            {
                txtComName.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selected.ToString())?.proModel ?? "";
                txtClientCompany.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selected.ToString())?.productId ?? "";
                txtSubClient.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selected.ToString())?.SubCom ?? "";
                txtJEmpName.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selected.ToString())?.Name ?? "";
                txtDirector.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selected.ToString())?.AuthorName ?? "";
                txtClientName.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selected.ToString())?.RawMaterial ?? "";
                txtSubContractor.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selected.ToString())?.SubComName ?? "";
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddReceivingDate.Text != null && ddReceivingDate.Text != null && ddReceivingDate.Text != string.Empty)
                {

                    string selectedItem = (string)drpEmpCode.SelectedItem;

                    if (selectedItem != null)
                    {
                        JobGivingWithoutDcRequest.EmployeeCode = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.Id ?? -1;
                    }
                    JobGivingWithoutDcRequest.CompanyName = txtComName.Text;
                    JobGivingWithoutDcRequest.ClientCompany = txtClientCompany.Text;
                    JobGivingWithoutDcRequest.SubClientCompany = txtSubClient.Text;
                    JobGivingWithoutDcRequest.EmployeeName = txtJEmpName.Text;
                    JobGivingWithoutDcRequest.Director = txtDirector.Text;
                    JobGivingWithoutDcRequest.ClientName = txtClientName.Text;
                    JobGivingWithoutDcRequest.subContractor = txtSubContractor.Text;
                    JobGivingWithoutDcRequest.QuantityPiece = txtQuantity.Text;
                    JobGivingWithoutDcRequest.WeightKg = txtWeight.Text;
                    JobGivingWithoutDcRequest.Excess = txtExcess.Text;
                    JobGivingWithoutDcRequest.Shortage = txtShortage.Text;
                    JobGivingWithoutDcRequest.RawMaterial = txtRawMaterial.Text;
                    JobGivingWithoutDcRequest.RawType = txtRawType.Text;
                    JobGivingWithoutDcRequest.ModelName = txtProModel.Text;
                    JobGivingWithoutDcRequest.ProductSize = txtProSize.Text;
                    JobGivingWithoutDcRequest.ModelCode = txtProductCode.Text;
                    JobGivingWithoutDcRequest.Color = txtProColor.Text;
                    JobGivingWithoutDcRequest.Update();

                    if (JobGivingWithoutDcRequest.Result.Status == ResultStatus.Success)
                    {
                        XtraMessageBox.Show("Giving is Transfer to the another Employee", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show(JobGivingWithoutDcRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("please Enter the mandatory field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtWeight_EditValueChanged(object sender, EventArgs e)
        {
            decimal txtWeightValue;
            decimal lblWeightValue;

            if (decimal.TryParse(txtWeight.Text, out txtWeightValue) && decimal.TryParse(lblWeight.Text, out lblWeightValue))
            {
                decimal countDifferent = txtWeightValue - lblWeightValue;
                if (countDifferent >= 0)
                {
                    txtExcess.Text = countDifferent.ToString();
                    txtShortage.Text = string.Empty;
                }
                else
                {
                    txtExcess.Text = string.Empty;
                    txtShortage.Text = (countDifferent).ToString();
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            drpEmpCode.ResetText();
            txtEmployeeCode.ResetText();
            txtJEmpName.ResetText();
            txtExcess.ResetText();
            txtPendingQty.ResetText();
            txtProColor.ResetText();
            txtQuantity.ResetText();
            txtEmpCode.ResetText();
            txtEmpName.ResetText();
            txtCustName.ResetText();
            txtRawMaterial.ResetText();
            txtRawType.ResetText();
            txtProductCode.ResetText();
            txtProModel.ResetText();
            txtQuanity.ResetText();
            txtQuantity.ResetText();
            txtProSize.ResetText();
            txtProColor.ResetText();
            txtWeight.ResetText();
            lblWeight.ResetText();
            txtReceivedQty.ResetText();
            txtPendingQty.ResetText();
            txtShortage.ResetText();
        }

        private void btnJobCancel_Click(object sender, EventArgs e)
        {
            if (JobGivingWithoutDcRequest.Id != 0)
            {
                JobGivingWithoutDcRequest.Delete();

                if (JobGivingWithoutDcRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show("Job is cannceled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlDataSource1.FillAsync();
                    gridView1.RefreshData();
                }
                else
                {
                    XtraMessageBox.Show(JobGivingWithoutDcRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtReceivedQty_EditValueChanged(object sender, EventArgs e)
        {
            int txtWeightValue;
            int lblWeightValue;

            if (int.TryParse(txtQuanity.Text, out txtWeightValue) && int.TryParse(txtReceivedQty.Text, out lblWeightValue))
            {
                int countDifferent = txtWeightValue - lblWeightValue;
                txtPendingQty.Text = countDifferent.ToString();
                txtQuantity.Text = countDifferent.ToString();
            }
            else
            {
                txtQuantity.Text = txtWeightValue.ToString();
                txtPendingQty.Text = txtWeightValue.ToString();
            }
        }

        private void txtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            var selectedItem = txtQuantity.Text;
            if (selectedItem != null && selectedItem != "")
            {
                var enteredQty = Convert.ToDecimal(txtQuantity.Text);
                var totalWt = Convert.ToDecimal(JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.RawName == txtRawMaterial.Text && item.RawType == txtRawType.Text && item.color == txtProColor.Text && item.SubComName == txtProSize.Text)?.TotalWt);
                var total = enteredQty * totalWt;
                lblWeight.Text = total.ToString();
            }
        }

        private void txtEmployeeCode_EditValueChanged(object sender, EventArgs e)
        {
            // Get the entered text from the TextBox
            string filterText = txtEmployeeCode.Text.Trim();

            // Clear any existing filter
            gridView1.ClearColumnsFilter();
            gridView2.ClearColumnsFilter();

            // If the filter text is empty, return
            if (string.IsNullOrEmpty(filterText))
                return;

            // Apply the filter to the GridView
            gridView1.ActiveFilterString = $"[EmployeeCode] LIKE '%{filterText}%'";
            gridView2.ActiveFilterString = $"[EmployeeCode] LIKE '%{filterText}%'";
        }

        private void chkViewReceivedPending_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewReceivedPending.Checked)
            {
                // If the CheckBox is checked, show sqlDataSource2 GridView and hide sqlDataSource1 GridView
                gridView1.GridControl.Visible = false;
                gridView2.GridControl.Visible = true;
            }
            else
            {
                // If the CheckBox is unchecked, show sqlDataSource1 GridView and hide sqlDataSource2 GridView
                gridView2.GridControl.Visible = false;
                gridView1.GridControl.Visible = true;
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView2.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    JobGivingWithoutDcRequest.Id = (Int64)gridView2.GetRowCellValue(rowHandle, "Id");
                    txtEmpCode.Text = gridView2.GetRowCellValue(rowHandle, "EmployeeCode").ToString();
                    txtEmpName.Text = (string)gridView2.GetRowCellValue(rowHandle, "EmployeeName");
                    txtCustName.Text = (string)gridView2.GetRowCellValue(rowHandle, "CustomerName");
                    txtRawMaterial.Text = (string)gridView2.GetRowCellValue(rowHandle, "RawMaterial");
                    txtRawType.Text = (string)gridView2.GetRowCellValue(rowHandle, "Type");
                    txtProductCode.Text = (string)gridView2.GetRowCellValue(rowHandle, "ModelCode");
                    txtProModel.Text = (string)gridView2.GetRowCellValue(rowHandle, "ModelName");
                    txtQuanity.Text = (string)gridView2.GetRowCellValue(rowHandle, "TotalQty");
                    txtProSize.Text = (string)gridView2.GetRowCellValue(rowHandle, "ProductSize");
                    txtProColor.Text = (string)gridView2.GetRowCellValue(rowHandle, "Color");
                    txtPendingQty.Text = (string)gridView2.GetRowCellValue(rowHandle, "PendingQty");
                    lblWeight.Text = (string)gridView2.GetRowCellValue(rowHandle, "BalanceWt");
                    txtReceivedQty.Text = (string)gridView2.GetRowCellValue(rowHandle, "received");
                    JobGivingWithoutDcRequest.OrderNo = gridView2.GetRowCellValue(rowHandle, "OrderNo").ToString();
                    JobGivingWithoutDcRequest.CompanyName = gridView2.GetRowCellValue(rowHandle, "CompanyName").ToString();
                    JobGivingWithoutDcRequest.CustomerCode = gridView2.GetRowCellValue(rowHandle, "CustomerCode").ToString();
                    JobGivingWithoutDcRequest.CustomerName = gridView2.GetRowCellValue(rowHandle, "CustomerName").ToString();
                    JobGivingWithoutDcRequest.ProductName = gridView2.GetRowCellValue(rowHandle, "ModelName").ToString();
                    JobGivingWithoutDcRequest.Color = gridView2.GetRowCellValue(rowHandle, "Color").ToString();
                    JobGivingWithoutDcRequest.WagesEmp = gridView2.GetRowCellValue(rowHandle, "Wages").ToString();
                }
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmJobReallocation_Load(object sender, EventArgs e)
        {
            int centerX = (this.Width - panelControl1.Width) / 2;
            int centerY = (this.Height - panelControl1.Height) / 2;

            // Set the controls' positions to the calculated center position
            panelControl1.Location = new Point(centerX, centerY);
        }
    }
}