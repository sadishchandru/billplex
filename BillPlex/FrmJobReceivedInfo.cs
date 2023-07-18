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
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeCode = (string)txtEmpCode.Text;
                //JobReceivedRequest.EmployeeCode = txtEmpCode.Text;
                if (JobReceivedRequest != null)
                {
                    JobReceivedRequest.EmployeeName = txtEmpName.Text;
                }

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
                txtEmpCode.Text = (string)selectedCompanyList.GetRowCellValue(rowHandle, "EmployeeName");
                //txtEmpCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "EmployeeCode").ToString();
                txtEmpName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "EmployeeName");
                txtCName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CompanyName");
                txtRawMaterial.Text = selectedCompanyList.GetRowCellValue(rowHandle, "RawMaterial");
                txtQuantity.Text = selectedCompanyList.GetRowCellValue(rowHandle, "QuantityPiece");
                //txtWages.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComLicenseno");
                //txtPQty.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPanNo");
                //txtMName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ModelName");
                txtType.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Type");
                txtWeight.Text = selectedCompanyList.GetRowCellValue(rowHandle, "WeightKg");
                //txtCrntWt.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtRcvdQty.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //ddReceDate.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                txtPModel.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ModelName");
                txtPCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ModelCode");
                txtPSize.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ProductSize");
                txtColor.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Color");
                //drpIncentiveApp.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtBeforeDys.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtAfterdys.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtBalanceWeight.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtConveyance.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtDeduction.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtIncentive.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtTotal.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
                //txtNetAmt.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");

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
            int txtWeightValue;
            int lblWeightValue;

            if (int.TryParse(txtWeight.Text, out txtWeightValue) && int.TryParse(txtCrntWt.Text, out lblWeightValue))
            {
                int countDifferent = txtWeightValue - lblWeightValue;
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

        private void txtDeduction_EditValueChanged(object sender, EventArgs e)
        {
            int a = 0;
            int b;
            if (txtDeduction.Text != "")
            {
                if (int.TryParse(txtDeduction.Text, out b))
                {
                    int result = a - b;
                    txtTotal.Text = result.ToString();
                    txtNetAmt.Text = result.ToString();
                }
            }
        }

        private void txtIncentive_EditValueChanged(object sender, EventArgs e)
        {
            int a;
            int b;

            if (int.TryParse(txtNetAmt.Text, out a) && int.TryParse(txtIncentive.Text, out b))
            {
                int countDifferent = a + b;
                txtNetAmt.Text = countDifferent.ToString();
            }
        }

        private void txtConveyance_EditValueChanged(object sender, EventArgs e)
        {
            int a;
            int b;

            if (int.TryParse(txtConveyance.Text, out a) && int.TryParse(txtNetAmt.Text, out b))
            {
                int countDifferent = a + b;
                txtNetAmt.Text = countDifferent.ToString();
            }
        }
    }
}
