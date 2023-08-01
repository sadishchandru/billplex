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
    public partial class FrmJobReceivedInfo : DevExpress.XtraEditors.XtraForm
    {
        private JobReceived JobReceivedRequest;

        public FrmJobReceivedInfo()
        {
            InitializeComponent();

            JobReceivedRequest = new JobReceived();

            JobReceivedRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    {"EmployeePersonalRequired",true}
                };

            var dropdwonList = JobReceivedRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "EmployeePersonalRequired")
                {
                    JobReceivedRequest.EmployeePersonalList = (List<DropDownItemInfo>)item.Value;
                }
            }

            gridView1.GridControl.DataSource = sqlDataSource1;
            gridView2.GridControl.DataSource = sqlDataSource2;

            gridView2.GridControl.Visible = false;

            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView2.OptionsBehavior.AutoPopulateColumns = false;

            ddReceDate.DateTime = DateTime.Now;

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddReceDate.Text != null && ddReceDate.Text != null && ddReceDate.Text != string.Empty)
                {

                    string selectedMasterItem = txtEmpCode.Text;

                    if (selectedMasterItem != null)
                    {
                        JobReceivedRequest.EmployeeCode = JobReceivedRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedMasterItem.ToString())?.Id ?? -1;
                    }
                    JobReceivedRequest.EmployeeName = txtEmpName.Text;
                    JobReceivedRequest.CustomerName = txtCName.Text;
                    JobReceivedRequest.RawMaterialName = txtRawMaterial.Text;
                    JobReceivedRequest.Quantity = txtQuantity.Text;
                    JobReceivedRequest.Wages = txtWages.Text;
                    JobReceivedRequest.PendingQty = txtPQty.Text;
                    JobReceivedRequest.ModelName = txtMName.Text;
                    JobReceivedRequest.Type = txtType.Text;
                    JobReceivedRequest.Weight = txtWeight.Text;
                    JobReceivedRequest.CurrentWt = txtCrntWt.Text;
                    JobReceivedRequest.RcvdQty = txtRcvdQty.Text;
                    JobReceivedRequest.ReceivingDate = ddReceDate.Text;
                    JobReceivedRequest.ProductModel = txtPModel.Text;
                    JobReceivedRequest.ProductCode = txtPCode.Text;
                    JobReceivedRequest.ProductSize = txtPSize.Text;
                    JobReceivedRequest.ProductColor = txtColor.Text;
                    JobReceivedRequest.IncentiveApplicable = drpIncentiveApp.Text;
                    JobReceivedRequest.BeforeDays = txtBeforeDys.Text;
                    JobReceivedRequest.AfterDays = txtAfterdys.Text;
                    JobReceivedRequest.BalanceWeight = txtBalanceWeight.Text;
                    JobReceivedRequest.Conveyance = txtConveyance.Text;
                    JobReceivedRequest.Deduction = txtDeduction.Text;
                    JobReceivedRequest.Incentive = txtIncentive.Text;
                    JobReceivedRequest.Total = txtTotal.Text;
                    JobReceivedRequest.NetAmt = txtNetAmt.Text;
                    JobReceivedRequest.Update();

                    if (JobReceivedRequest.Result.Status == ResultStatus.Success)
                    {
                        XtraMessageBox.Show(JobReceivedRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();

                        FrmSubClientCompanyProfile form = Application.OpenForms.OfType<FrmSubClientCompanyProfile>().FirstOrDefault();

                        Form myForm = Application.OpenForms["FrmJobReceivedRequestProfile"];
                        if (myForm != null)
                        {
                            form.ReloadSqlDataSource();
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(JobReceivedRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void BindData(dynamic selectedCompanyList)
        {
            var selectedRows = selectedCompanyList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                txtEmpCode.Text = (string)selectedCompanyList.GetRowCellValue(rowHandle, "EmployeeCode");
                txtEmpName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "EmployeeName");
                txtCName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CompanyName");
                txtRawMaterial.Text = selectedCompanyList.GetRowCellValue(rowHandle, "RawMaterial");
                txtQuantity.Text = selectedCompanyList.GetRowCellValue(rowHandle, "QuantityPiece");
                txtType.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Type");
                txtWeight.Text = selectedCompanyList.GetRowCellValue(rowHandle, "WeightKg");
                txtPModel.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ModelName");
                txtPCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ModelCode");
                txtPSize.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ProductSize");
                txtColor.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Color");

                btnAdd.Enabled = false;
                btnNew.Enabled = false;
                btnUpdate.Enabled = true;
                btnEdit.Enabled = true;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpCode.ResetText();
            txtEmpCode.ResetText();
            txtEmpName.ResetText();
            txtCName.ResetText();
            txtRawMaterial.ResetText();
            txtQuantity.ResetText();
            txtWages.ResetText();
            txtPQty.ResetText();
            txtMName.ResetText();
            txtType.ResetText();
            txtWeight.ResetText();
            txtCrntWt.ResetText();
            txtRcvdQty.ResetText();
            ddReceDate.ResetText();
            txtPModel.ResetText();
            txtPCode.ResetText();
            txtPSize.ResetText();
            txtColor.ResetText();
            drpIncentiveApp.ResetText();
            txtBeforeDys.ResetText();
            txtAfterdys.ResetText();
            txtConveyance.ResetText();
            txtDeduction.ResetText();
            txtIncentive.ResetText();
            txtTotal.ResetText();
            txtNetAmt.ResetText();
        }

        private void txtCrntWt_EditValueChanged(object sender, EventArgs e)
        {
            decimal txtWeightValue;
            decimal lblWeightValue;

            if (decimal.TryParse(txtWeight.Text, out txtWeightValue) && decimal.TryParse(txtCrntWt.Text, out lblWeightValue))
            {
                decimal countDifferent = txtWeightValue - lblWeightValue;
                if (countDifferent >= 0)
                {
                    txtBalanceWeight.Text = countDifferent.ToString();
                }
                else
                {
                    txtBalanceWeight.Text = string.Empty;
                }
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView1.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    txtEmpCode.Text = gridView1.GetRowCellValue(rowHandle, "EmployeeCode").ToString();
                    txtEmpName.Text = (string)gridView1.GetRowCellValue(rowHandle, "EmployeeName");
                    txtCName.Text = (string)gridView1.GetRowCellValue(rowHandle, "CompanyName");
                    txtRawMaterial.Text = (string)gridView1.GetRowCellValue(rowHandle, "RawMaterial");
                    txtQuantity.Text = (string)gridView1.GetRowCellValue(rowHandle, "QuantityPiece");
                    txtType.Text = (string)gridView1.GetRowCellValue(rowHandle, "Type");
                    txtWeight.Text = (string)gridView1.GetRowCellValue(rowHandle, "WeightKg");
                    txtPModel.Text = (string)gridView1.GetRowCellValue(rowHandle, "ModelName");
                    txtPCode.Text = (string)gridView1.GetRowCellValue(rowHandle, "ModelCode");
                    txtPSize.Text = (string)gridView1.GetRowCellValue(rowHandle, "ProductSize");
                    txtColor.Text = (string)gridView1.GetRowCellValue(rowHandle, "Color");
                    txtWages.Text = (string)gridView1.GetRowCellValue(rowHandle, "WagesEmp");
                    JobReceivedRequest.OrderNo = gridView1.GetRowCellValue(rowHandle, "OrderNo").ToString();
                    JobReceivedRequest.OrderDate = (string)gridView1.GetRowCellValue(rowHandle, "OrderDate");
                    JobReceivedRequest.CompanyName = (string)gridView1.GetRowCellValue(rowHandle, "CompanyName");
                    JobReceivedRequest.CompanyCName = (string)gridView1.GetRowCellValue(rowHandle, "Director");
                    JobReceivedRequest.ClientCompany = (string)gridView1.GetRowCellValue(rowHandle, "ClientCompany");
                    JobReceivedRequest.ClientCompanyName = (string)gridView1.GetRowCellValue(rowHandle, "ClientName");
                    JobReceivedRequest.SubClientCompany = (string)gridView1.GetRowCellValue(rowHandle, "SubClientCompany");
                    JobReceivedRequest.SubClientCompanyName = (string)gridView1.GetRowCellValue(rowHandle, "subContractor");
                    JobReceivedRequest.CustomerCode = (string)gridView1.GetRowCellValue(rowHandle, "CustomerCode");
                    JobReceivedRequest.Id = (Int64)gridView1.GetRowCellValue(rowHandle, "Id");
                }
                btnAdd.Enabled = false;
                btnNew.Enabled = false;
                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void chckViewDailyRecievPending_CheckedChanged(object sender, EventArgs e)
        {
            if (chckViewDailyRecievPending.Checked)
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

        private void txtEmpCode2_EditValueChanged(object sender, EventArgs e)
        {
            // Get the entered text from the TextBox
            string filterText = txtEmpCode2.Text.Trim();

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

        private void txtRcvdQty_EditValueChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal deductionTotal = 0;
            decimal txtPQt = 0;

            if (txtWages.Text != "" && txtWages.Text != "0")
            {
                total = Convert.ToDecimal(txtWages.Text) * Convert.ToDecimal(txtRcvdQty.Text);
                deductionTotal = Convert.ToDecimal(txtWages.Text) * Convert.ToDecimal(txtRcvdQty.Text);
            }

            if (txtDeduction.Text != "" && txtDeduction.Text != "0")
            {
                deductionTotal = deductionTotal - Convert.ToInt32(txtDeduction.Text);
                total = total - Convert.ToInt32(txtDeduction.Text);
            }

            if (txtConveyance.Text != "" && txtConveyance.Text != "0")
            {
                total = total + Convert.ToInt32(txtConveyance.Text);
            }

            if (txtIncentive.Text != "" && txtIncentive.Text != "0")
            {
                total = total + Convert.ToInt32(txtIncentive.Text);
            }

            txtTotal.Text = deductionTotal.ToString();
            txtNetAmt.Text = total.ToString();


        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ddReceDate.Text != null)
                {

                    var selectedRows = gridView2.GetSelectedRows();

                    foreach (var rowHandle in selectedRows)
                    {
                        txtEmpCode.Text = gridView2.GetRowCellValue(rowHandle, "EmployeeCode").ToString();
                        txtEmpName.Text = (string)gridView2.GetRowCellValue(rowHandle, "EmployeeName");
                        txtCName.Text = (string)gridView2.GetRowCellValue(rowHandle, "CompanyName");
                        txtRawMaterial.Text = (string)gridView2.GetRowCellValue(rowHandle, "RawMaterial");
                        txtQuantity.Text = (string)gridView2.GetRowCellValue(rowHandle, "TotalQty");
                        txtType.Text = (string)gridView2.GetRowCellValue(rowHandle, "Type");
                        txtWeight.Text = (string)gridView2.GetRowCellValue(rowHandle, "BalanceWt");
                        txtPModel.Text = (string)gridView2.GetRowCellValue(rowHandle, "ModelName");
                        txtPCode.Text = (string)gridView2.GetRowCellValue(rowHandle, "ModelCode");
                        txtPSize.Text = (string)gridView2.GetRowCellValue(rowHandle, "ProductSize");
                        txtColor.Text = (string)gridView2.GetRowCellValue(rowHandle, "Color");
                        txtWages.Text = (string)gridView2.GetRowCellValue(rowHandle, "Wages");
                        var recicivedQty = (string)gridView2.GetRowCellValue(rowHandle, "received");
                        JobReceivedRequest.OrderNo = gridView2.GetRowCellValue(rowHandle, "OrderNo").ToString();
                        JobReceivedRequest.OrderDate = (string)gridView1.GetRowCellValue(rowHandle, "OrderDate");
                        JobReceivedRequest.CompanyName = (string)gridView1.GetRowCellValue(rowHandle, "CompanyName");
                        JobReceivedRequest.CompanyName = (string)gridView1.GetRowCellValue(rowHandle, "CompanyName");
                        JobReceivedRequest.ClientCompany = (string)gridView1.GetRowCellValue(rowHandle, "ClientCompany");
                        JobReceivedRequest.ClientCompany = (string)gridView1.GetRowCellValue(rowHandle, "ClientCompany");
                        JobReceivedRequest.SubClientCompany = (string)gridView1.GetRowCellValue(rowHandle, "SubClientCompany");
                        JobReceivedRequest.SubClientCompany = (string)gridView1.GetRowCellValue(rowHandle, "SubClientCompany");
                        JobReceivedRequest.Id = (Int64)gridView2.GetRowCellValue(rowHandle, "Id");

                        if (recicivedQty != "" && recicivedQty != "0")
                        {

                            txtPQty.Text = (Convert.ToDecimal(txtQuantity.Text) - Convert.ToDecimal(recicivedQty)).ToString();
                        }
                    }
                    btnAdd.Enabled = false;
                    btnNew.Enabled = false;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmJobReceivedInfo_Load(object sender, EventArgs e)
        {
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = ourScreenWidth / 1600f;
            float scaleFactorHeigth = ourScreenHeight / 900f;
            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
            Scale(scaleFactor);

            // If you want to center the resized screen.
            CenterToScreen();
        }
    }
}