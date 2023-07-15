using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmDirectJobReceivedWithoutGivingInfo : DevExpress.XtraEditors.XtraForm
    {
        private DirectJobReceivedWithoutGiving DirectJobReceivedWithoutGivingRequest;
        public FrmDirectJobReceivedWithoutGivingInfo()
        {
            InitializeComponent();

            DirectJobReceivedWithoutGivingRequest = new DirectJobReceivedWithoutGiving();

            DirectJobReceivedWithoutGivingRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "ColorMasterRequired", true },
                    {"EmployeePersonalRequired",true},
                    {"FinishingProductRequired",true}
                };

            var dropdwonList = DirectJobReceivedWithoutGivingRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ColorMasterRequired")
                {
                    DirectJobReceivedWithoutGivingRequest.ColorMasterList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "EmployeePersonalRequired")
                {
                    DirectJobReceivedWithoutGivingRequest.EmployeePersonalList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "FinishingProductRequired")
                {
                    DirectJobReceivedWithoutGivingRequest.FinishingProductList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (DirectJobReceivedWithoutGivingRequest.ColorMasterList != null)
            {
                if (DirectJobReceivedWithoutGivingRequest.ColorMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in DirectJobReceivedWithoutGivingRequest.ColorMasterList)
                    {
                        drpColor.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }

            }
            if (DirectJobReceivedWithoutGivingRequest.EmployeePersonalList != null)
            {
                if (DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in DirectJobReceivedWithoutGivingRequest.EmployeePersonalList)
                    {
                        drpEmpCode.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                    }
                }
            }
            if (DirectJobReceivedWithoutGivingRequest.FinishingProductList != null)
            {
                if (DirectJobReceivedWithoutGivingRequest.FinishingProductList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in DirectJobReceivedWithoutGivingRequest.FinishingProductList)
                    {
                        drpProductModel.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedMasterItem = drpEmpCode.Text;

                if (selectedMasterItem != null)
                {
                    DirectJobReceivedWithoutGivingRequest.EmployeeCode = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedMasterItem.ToString())?.Id ?? -1;
                }
                DirectJobReceivedWithoutGivingRequest.EmployeeName = txtEmpName.Text;
                DirectJobReceivedWithoutGivingRequest.CompanyName = txtComName.Text;
                DirectJobReceivedWithoutGivingRequest.Director = txtDirector.Text;
                DirectJobReceivedWithoutGivingRequest.ClientComapny = txtClientCompany.Text;
                DirectJobReceivedWithoutGivingRequest.ClientName = txtClientName.Text;
                DirectJobReceivedWithoutGivingRequest.SubClientComapny = txtSubClient.Text;
                DirectJobReceivedWithoutGivingRequest.SubClientName = txtSubContractor.Text;
                DirectJobReceivedWithoutGivingRequest.ProductModel = drpProductModel.Text;
                DirectJobReceivedWithoutGivingRequest.ProductCode = drpProductCode.Text;
                DirectJobReceivedWithoutGivingRequest.ProductName = txtProductName.Text;
                DirectJobReceivedWithoutGivingRequest.Wages = txtWages.Text;
                DirectJobReceivedWithoutGivingRequest.ProSize = txtSize.Text;
                DirectJobReceivedWithoutGivingRequest.Color = drpColor.Text;
                DirectJobReceivedWithoutGivingRequest.Quantity = txtQuantity.Text;
                DirectJobReceivedWithoutGivingRequest.Weight = txtWeight.Text;
                DirectJobReceivedWithoutGivingRequest.IncentiveApplicable = drpIncentiveApp.Text;
                DirectJobReceivedWithoutGivingRequest.BDays = txtBeforeDays.Text;
                DirectJobReceivedWithoutGivingRequest.ADays = txtAfterDays.Text;
                DirectJobReceivedWithoutGivingRequest.Deduction = txtDeducation.Text;
                DirectJobReceivedWithoutGivingRequest.Total = txtTotal.Text;
                DirectJobReceivedWithoutGivingRequest.Conveyance = txtConveyance.Text;
                DirectJobReceivedWithoutGivingRequest.Incentive = txtIncentive.Text;
                DirectJobReceivedWithoutGivingRequest.NetAmt = txtNetAmt.Text;
                DirectJobReceivedWithoutGivingRequest.Update();

                if (DirectJobReceivedWithoutGivingRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(DirectJobReceivedWithoutGivingRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    FrmSubClientCompanyProfile form = Application.OpenForms.OfType<FrmSubClientCompanyProfile>().FirstOrDefault();

                    Form myForm = Application.OpenForms["FrmSubClientCompanyProfile"];
                    if (myForm != null)
                    {
                        form.ReloadSqlDataSource();
                    }
                }
                else
                {
                    XtraMessageBox.Show(DirectJobReceivedWithoutGivingRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {

            }
        }

        private void drpEmpCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpEmpCode.SelectedItem;
            if (selectedItem != null)
            {
                txtEmpName.Text = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.Name ?? "";
                txtComName.Text = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.proModel ?? "";
                txtDirector.Text = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.AuthorName ?? "";
                txtClientCompany.Text = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.productId ?? "";
                txtClientName.Text = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.RawMaterial ?? "";
                txtSubClient.Text = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.SubCom ?? "";
                txtSubContractor.Text = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.SubComName ?? "";
            }
        }

        private void drpProductModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = drpProductModel.Text;
            if (DirectJobReceivedWithoutGivingRequest.FinishingProductList != null && selectItem != "")
            {
                if (DirectJobReceivedWithoutGivingRequest.FinishingProductList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in DirectJobReceivedWithoutGivingRequest.FinishingProductList)
                    {
                        if (item.Name == selectItem)
                        {
                            drpProductCode.Properties.Items.Add(new ImageComboBoxItem(item.AuthorName));
                        }
                    }
                }
            }
        }
        private void drpProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = drpProductCode.Text;
            if (selectedItem != null)
            {
                txtProductName.Text = DirectJobReceivedWithoutGivingRequest.FinishingProductList.FirstOrDefault(item => item.AuthorName == selectedItem.ToString() && item.Name == drpProductModel.Text.ToString())?.Code ?? "";
                txtWages.Text = DirectJobReceivedWithoutGivingRequest.FinishingProductList.FirstOrDefault(item => item.AuthorName == selectedItem.ToString() && item.Name == drpProductModel.Text.ToString())?.productId ?? "";
                txtSize.Text = DirectJobReceivedWithoutGivingRequest.FinishingProductList.FirstOrDefault(item => item.AuthorName == selectedItem.ToString() && item.Name == drpProductModel.Text.ToString())?.proModel ?? "";
            }
        }

        public void BindData(dynamic selectedCompanyList)
        {
            var selectedRows = selectedCompanyList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                DirectJobReceivedWithoutGivingRequest.Id = selectedCompanyList.GetRowCellValue(rowHandle, "Id");
                drpEmpCode.SelectedIndex = DirectJobReceivedWithoutGivingRequest.EmployeePersonalList.FindIndex(x => x.Id == Convert.ToInt64(selectedCompanyList.GetRowCellValue(rowHandle, "EmpId").ToString()));
                txtEmpName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "EmployeeName");
                txtComName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CompanyName");
                txtDirector.Text = selectedCompanyList.GetRowCellValue(rowHandle, "DirectorName");
                txtClientCompany.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ClientCompany");
                txtClientName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ClientName");
                txtSubClient.Text = selectedCompanyList.GetRowCellValue(rowHandle, "SubClientCompany");
                txtSubContractor.Text = selectedCompanyList.GetRowCellValue(rowHandle, "SubClientName");
                drpProductModel.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ProductModel");
                drpProductCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ProductCode");
                txtProductName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ProductName");
                txtWages.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Wages");
                txtSize.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Prosize");
                drpColor.Text = selectedCompanyList.GetRowCellValue(rowHandle, "color");
                txtQuantity.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Quantity");
                txtWeight.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Weight");
                drpIncentiveApp.Text = selectedCompanyList.GetRowCellValue(rowHandle, "IncentiveApplicable");
                txtBeforeDays.Text = selectedCompanyList.GetRowCellValue(rowHandle, "BDays");
                txtAfterDays.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ADays");
                txtDeducation.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Deduction");
                txtTotal.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Total");
                txtConveyance.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Conveyance");
                txtIncentive.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Incentive");
                txtNetAmt.Text = selectedCompanyList.GetRowCellValue(rowHandle, "NetAmt");

                btnAdd.Enabled = false;
                btnNew.Enabled = false;
                btnUpdate.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpName.ResetText();
            txtComName.ResetText();
            txtDirector.ResetText();
            txtClientCompany.ResetText();
            txtClientName.ResetText();
            txtSubClient.ResetText();
            txtSubContractor.ResetText();
            drpProductModel.ResetText();
            drpProductCode.ResetText();
            txtProductName.ResetText();
            txtWages.ResetText();
            txtSize.ResetText();
            drpColor.ResetText();
            txtQuantity.ResetText();
            txtWeight.ResetText();
            drpIncentiveApp.ResetText();
            txtBeforeDays.ResetText();
            txtAfterDays.ResetText();
            txtDeducation.ResetText();
            txtTotal.ResetText();
            txtConveyance.ResetText();
            txtIncentive.ResetText();
            txtNetAmt.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDeducation_EditValueChanged(object sender, EventArgs e)
        {
            int a;
            int b;
            if(txtTotal.Text !="" && txtDeducation.Text != "")
            {
                if (int.TryParse(txtTotal.Text, out a) && int.TryParse(txtDeducation.Text, out b))
                {
                    int result = a - b;
                    txtTotal.Text = result.ToString();
                }
            }
            else if (string.IsNullOrEmpty(txtDeducation.Text))
            {
                txtTotal.Text = string.Empty; 
            }
        }

        private void txtConveyance_EditValueChanged(object sender, EventArgs e)
       {
            int a;
            int b;
            if (txtNetAmt.Text!="" && txtConveyance.Text != "")
            {
                if (int.TryParse(txtNetAmt.Text, out a))
                {
                    if (int.TryParse(txtConveyance.Text, out b))
                    {
                        txtNetAmt.Text = (a + b).ToString();
                    }
                    else
                    {
                        txtNetAmt.Text = a.ToString();
                    }
                }
                else if (string.IsNullOrEmpty(txtConveyance.Text))
                {
                    txtNetAmt.Text = string.Empty; // or "0" if you want to show zero
                }

            }
        }

        private void txtIncentive_EditValueChanged(object sender, EventArgs e)
        {
            int a;
            int b;
            if (txtNetAmt.Text != "" && txtIncentive.Text != "")
            {
                if (int.TryParse(txtNetAmt.Text, out a) && int.TryParse(txtIncentive.Text, out b))
                {
                    txtNetAmt.Text = (a + b).ToString();
                }
            }
        }

        private void txtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            int a;
            int b;
            if (txtWages.Text != "" && txtQuantity.Text != "")
            {
                if (int.TryParse(txtWages.Text, out a) && int.TryParse(txtQuantity.Text, out b))
                {
                    int total = a * b;
                    txtTotal.Text = total.ToString();
                    txtNetAmt.Text = total.ToString();
                }
            }
        }
    }
}