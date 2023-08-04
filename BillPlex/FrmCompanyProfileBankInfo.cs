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

namespace BillPlex
{
    public partial class FrmCompanyProfileBankInfo : DevExpress.XtraEditors.XtraForm
    {
        private CompanyBankInfo CompanyBankRequest;
        public FrmCompanyProfileBankInfo()
        {
            InitializeComponent();
            CompanyBankRequest = new CompanyBankInfo();
            CompanyBankRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true }
                };
            var dropdwonList = CompanyBankRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    CompanyBankRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }
            }


            if (CompanyBankRequest.MasterCompanyList != null)
            {
                if (CompanyBankRequest.MasterCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in CompanyBankRequest.MasterCompanyList)
                    {
                        drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }

            var list = new List<string> {
                "Bank A",
            "Puduvai Bharathiar Grama Bank",
            "State Bank"
            };

            drpBankName.Properties.Items.AddRange(list);
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            MainBankInfoGridView.RefreshData();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (drpMainCompany.Text != string.Empty && drpBankName.Text != string.Empty && TxtBankAccountNo.Text != string.Empty && TxtAddress.Text != string.Empty && TxtBranchCode.Text != string.Empty && TxtBranchName.Text != string.Empty && TxtIfsCode.Text != string.Empty)
                {
                    var selectedItem = drpMainCompany.EditValue;

                    if (selectedItem != null)
                    {
                        CompanyBankRequest.MainCompany = CompanyBankRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.Id ?? -1;
                    }
                    CompanyBankRequest.BankName = drpBankName.Text;
                    CompanyBankRequest.BankAcNo = TxtBankAccountNo.Text;
                    CompanyBankRequest.Address = TxtAddress.Text;
                    CompanyBankRequest.BranchCode = TxtBranchCode.Text;
                    CompanyBankRequest.BranchName = TxtBranchName.Text;
                    CompanyBankRequest.IFSCode = TxtIfsCode.Text;
                    CompanyBankRequest.Update();

                    if (CompanyBankRequest.Result.Status == ResultStatus.Success)
                    {
                        XtraMessageBox.Show(CompanyBankRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancel_Click();
                        btnCancel.Enabled = true;
                        ReloadSqlDataSource();
                    }
                }
                else
                {
                    XtraMessageBox.Show("please Enter the mandatory field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            btnCancel.Enabled = true;
        }
        private void btn_GridView(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = MainBankInfoGridView.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    CompanyBankRequest.Id = (Int64)MainBankInfoGridView.GetRowCellValue(rowHandle, "MainCompanyId");
                    drpMainCompany.SelectedIndex = CompanyBankRequest.MasterCompanyList.FindIndex(x => x.Id == Convert.ToInt32(MainBankInfoGridView.GetRowCellValue(rowHandle, "MainCompanyId")));
                    drpBankName.Text = MainBankInfoGridView.GetRowCellValue(rowHandle, "BankName").ToString();
                    TxtBankAccountNo.Text = MainBankInfoGridView.GetRowCellValue(rowHandle, "BankAcNo").ToString();
                    TxtAddress.Text = MainBankInfoGridView.GetRowCellValue(rowHandle, "Address").ToString();
                    TxtBranchCode.Text = MainBankInfoGridView.GetRowCellValue(rowHandle, "BranchCode").ToString();
                    TxtBranchName.Text = MainBankInfoGridView.GetRowCellValue(rowHandle, "BranchName").ToString();
                    TxtIfsCode.Text = MainBankInfoGridView.GetRowCellValue(rowHandle, "IFSCode").ToString();

                }
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnCancel_Click(object sender = null, EventArgs e = null)
        {
            CompanyBankRequest.Id = 0;
            drpMainCompany.ResetText();
            drpBankName.ResetText();
            TxtBankAccountNo.ResetText();
            TxtAddress.ResetText();
            TxtBranchCode.ResetText();
            TxtBranchName.ResetText();
            TxtIfsCode.ResetText();
        }

        private void FrmCompanyProfileBankInfo_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the form
            int centerX = (this.Width - panelControl1.Width) / 2;
            int centerY = (this.Height - panelControl1.Height) / 2;
            // Set the controls' positions to the calculated center position
            panelControl1.Location = new Point(centerX, centerY);
        }
    }
}