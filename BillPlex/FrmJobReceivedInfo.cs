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
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            //chckViewDailyRecievPending.CheckedChanged += chckViewDailyRecievPending_CheckedChanged;

            gridControl1.DataSource = sqlDataSource1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedMasterItem = txtEmpCode.Text;

                if (selectedMasterItem != null)
                {
                    JobReceivedRequest.EmployeeCode = JobReceivedRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedMasterItem.ToString())?.Id ?? -1;
                }
                //JobReceivedRequest.EmployeeCode = txtEmpCode.Text;
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
            int total = 0;

            if (txtDeduction.Text != "" && txtDeduction.Text != "0")
            {
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

            txtTotal.Text = total.ToString();
            txtNetAmt.Text = total.ToString();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView1.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    //txtEmpCode.Text = gridView1.(x => x.Id == Convert.ToInt64(selectedCompanyList.GetRowCellValue(rowHandle, "EmpId").ToString()));
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
                    JobReceivedRequest.OrderNo = gridView1.GetRowCellValue(rowHandle, "OrderNo").ToString();
                    //JobReceivedRequest.OrderNo = (string)gridView1.GetRowCellValue(rowHandle, "OrderNo");
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

    }
}
