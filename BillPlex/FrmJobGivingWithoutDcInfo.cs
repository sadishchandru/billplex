using BusinessLayer;
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
    public partial class FrmJobGivingWithoutDcInfo : DevExpress.XtraEditors.XtraForm
    {
        private JobGivingWithoutDc JobGivingWithoutDcRequest;
        public FrmJobGivingWithoutDcInfo()
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
                //if (JobGivingWithoutDcRequest.OrderMasterList.Count() > 0)
                //{
                //    foreach (DropDownItemInfo item in JobGivingWithoutDcRequest.OrderMasterList)
                //    {
                //        drpOrderNo.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                //    }
                //}
            }
            if (JobGivingWithoutDcRequest.OrderMasterList != null)
            {

                if (JobGivingWithoutDcRequest.OrderMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in JobGivingWithoutDcRequest.OrderMasterList)
                    {
                        var foundItem = "";

                        foreach (string items in drpOrderNo.Properties.Items)
                        {
                            if (items.ToString() == item.Code.ToString())
                            {
                                foundItem = items;
                                break;
                            }
                        }
                        if (foundItem == "")
                        {
                            drpOrderNo.Properties.Items.Add(new ImageComboBoxItem(item.Code));
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = (string)drpEmpCode.SelectedItem;

                if (selectedItem != null)
                {
                    JobGivingWithoutDcRequest.EmployeeCode = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.Id ?? -1;
                }
                JobGivingWithoutDcRequest.EmployeeName = txtEmpName.Text;
                JobGivingWithoutDcRequest.CompanyName = txtComName.Text;
                JobGivingWithoutDcRequest.ClientCompany = txtCCom.Text;
                JobGivingWithoutDcRequest.ClientName = txtClientName.Text;
                JobGivingWithoutDcRequest.SubClientCompany = txtSCCom.Text;
                JobGivingWithoutDcRequest.Date = ddDate.Text;
                string selectedItems = (string)drpOrderNo.SelectedItem;
                if (selectedItems != null)
                {
                    JobGivingWithoutDcRequest.OrderNo = JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.Name == selectedItems.ToString())?.Id ?? -1;
                }
                JobGivingWithoutDcRequest.OrderDate = ddODate.Text;
                JobGivingWithoutDcRequest.CustomerCode = txtCCode.Text;
                JobGivingWithoutDcRequest.CustomerName = txtCCName.Text;
                JobGivingWithoutDcRequest.ModelName = drpMName.Text;
                JobGivingWithoutDcRequest.ModelCode = drpMCode.Text;
                JobGivingWithoutDcRequest.ProductName = txtPName.Text;
                JobGivingWithoutDcRequest.ProductSize = txtPSize.Text;
                JobGivingWithoutDcRequest.Color = drpColor.Text;
                JobGivingWithoutDcRequest.RawMaterial = txtRawMaterial.Text;
                JobGivingWithoutDcRequest.RawType = txtType.Text;
                JobGivingWithoutDcRequest.QuantityPiece = txtQuantity.Text;
                JobGivingWithoutDcRequest.WeightKg = txtWeight.Text;
                JobGivingWithoutDcRequest.AvlQty =txtAvlQty.Text;
                JobGivingWithoutDcRequest.TotalQty = txtTQty.Text;
                JobGivingWithoutDcRequest.TotalWt = txtTotalWT.Text;
                JobGivingWithoutDcRequest.Shortage = txtShortage.Text;
                JobGivingWithoutDcRequest.Update();

                if (JobGivingWithoutDcRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(JobGivingWithoutDcRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click();
                    this.Close();

                    FrmJobGivingWithoutDcProfile form = Application.OpenForms.OfType<FrmJobGivingWithoutDcProfile>().FirstOrDefault();

                    Form myForm = Application.OpenForms["FrmJobGivingWithoutDcProfile"];
                    if (myForm != null)
                    {
                        form.ReloadSqlDataSource();
                    }
                }
                else
                {
                    XtraMessageBox.Show(JobGivingWithoutDcRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drpEmpCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpEmpCode.SelectedItem;
            if (selectedItem != null)
            {
                txtComName.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.proModel ?? "";
                txtCCom.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.productId ?? "";
                txtSCCom.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.SubCom ?? "";
                txtClientName.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.RawMaterial ?? "";
                txtEmpName.Text = JobGivingWithoutDcRequest.EmployeePersonalList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.Name ?? "";
            }
        }

        private void drpOrderNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpOrderNo.SelectedItem;
            if (selectedItem != null)
            {
                txtCCode.Text = JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.AuthorName ?? "";
                txtCCName.Text = JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.proModel ?? "";
                ddDate.Text = JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.Code == selectedItem.ToString())?.Name ?? "";
            }
            var selectItem = drpOrderNo.Text;

            if (JobGivingWithoutDcRequest.OrderMasterList != null && selectItem != "")
            {
                if (JobGivingWithoutDcRequest.OrderMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in JobGivingWithoutDcRequest.OrderMasterList)
                    {
                        if (item.Code == selectItem)
                        {
                            drpMName.Properties.Items.Add(new ImageComboBoxItem(item.productId));
                        }
                    }
                }
            }
        }

        private void drpMName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = drpMName.Text;
            if (JobGivingWithoutDcRequest.OrderMasterList != null && selectItem != "")
            {
                if (JobGivingWithoutDcRequest.OrderMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in JobGivingWithoutDcRequest.OrderMasterList)
                    {
                        if (item.productId == selectItem)
                        {
                            drpMCode.Properties.Items.Add(new ImageComboBoxItem(item.RawMaterial));
                        }
                    }
                }
            }
        }

        private void drpMCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpMCode.SelectedItem;
            if (selectedItem != null)
            {
                txtPName.Text = JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.RawMaterial == selectedItem.ToString())?.SubCom ?? "";
                txtPSize.Text = JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.RawMaterial == selectedItem.ToString())?.SubComName ?? "";
            }
            var selectItem = drpMCode.Text;
            if (JobGivingWithoutDcRequest.OrderMasterList != null && selectItem != "")
            {
                if (JobGivingWithoutDcRequest.OrderMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in JobGivingWithoutDcRequest.OrderMasterList)
                    {
                        if (item.RawMaterial == selectItem)
                        {
                            drpColor.Properties.Items.Add(new ImageComboBoxItem(item.color));
                        }
                    }
                }
            }
        }

        private void drpColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpColor.SelectedItem;
            if (selectedItem != null)
            {
                txtRawMaterial.Text = JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.color == selectedItem.ToString())?.RawName ?? "";
                txtType.Text = JobGivingWithoutDcRequest.OrderMasterList.FirstOrDefault(item => item.color == selectedItem.ToString())?.RawType ?? "";
            }
        }

        public void BindData(dynamic selectedCompanyList)
        {
            var selectedRows = selectedCompanyList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                JobGivingWithoutDcRequest.Id = selectedCompanyList.GetRowCellValue(rowHandle, "Id");
                drpEmpCode.SelectedIndex = JobGivingWithoutDcRequest.EmployeePersonalList.FindIndex(x => x.Id == Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "EmployeeCode").ToString()));
                txtEmpName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "EmployeeName");
                txtComName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CompanyName");
                txtCCom.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ClientCompany");
                txtClientName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ClientName");
                txtSCCom.Text = selectedCompanyList.GetRowCellValue(rowHandle, "SubClientCompany");
                var datete = selectedCompanyList.GetRowCellValue(rowHandle, "Date").ToString();
                ddDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                drpOrderNo.SelectedIndex = JobGivingWithoutDcRequest.OrderMasterList.FindIndex(x => x.Id == Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "OrderNo").ToString()));
                datete = selectedCompanyList.GetRowCellValue(rowHandle, "OrderDate").ToString();
                ddODate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                txtCCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CustomerCode");
                txtCCName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CustomerName");
                drpMName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ModelName");
                drpMCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ModelCode");
                txtPName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ProductName");
                txtPSize.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ProductSize");
                drpColor.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Color");
                txtRawMaterial.Text = selectedCompanyList.GetRowCellValue(rowHandle, "RawMaterial");
                txtType.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Type");
                txtQuantity.Text = selectedCompanyList.GetRowCellValue(rowHandle, "QuantityPiece");
                txtWeight.Text = selectedCompanyList.GetRowCellValue(rowHandle, "WeightKg");
                txtAvlQty.Text =selectedCompanyList.GetRowCellValue(rowHandle, "AvlQty");
                txtTQty.Text = selectedCompanyList.GetRowCellValue(rowHandle, "TotalQty");
                txtTotalWT.Text = selectedCompanyList.GetRowCellValue(rowHandle, "TotalWt");
                txtShortage.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");

                btnAdd.Enabled = false;
                btnNew.Enabled = false;
                btnUpdate.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnClear_Click(object sender = null, EventArgs e = null)
        {
            drpEmpCode.ResetText();
            txtEmpName.ResetText();
            txtComName.ResetText();
            txtCCom.ResetText();
            txtClientName.ResetText();
            txtSCCom.ResetText();
            ddDate.ResetText();
            drpOrderNo.ResetText();
            ddODate.ResetText();
            txtCCode.ResetText();
            txtCCName.ResetText();
            drpMName.ResetText();
            drpMCode.ResetText();
            txtPName.ResetText();
            txtPSize.ResetText();
            drpColor.ResetText();
            txtRawMaterial.ResetText();
            txtType.ResetText();
            txtQuantity.ResetText();
            txtWeight.ResetText();
            txtAvlQty.ResetText();
            txtTQty.ResetText();
            txtTotalWT.ResetText();
            txtShortage.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
