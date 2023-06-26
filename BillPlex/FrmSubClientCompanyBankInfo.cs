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
//using DataLayer;

namespace BillPlex
{
    public partial class FrmSubClientCompanyBankInfo : DevExpress.XtraEditors.XtraForm
    {
        private SubClientCompanyBank SubClientCompanyBankRequest;
        //private readonly SqlConnector _conn;
        public FrmSubClientCompanyBankInfo()
        {
            InitializeComponent();
            sqlDataSource1.FillAsync();
            string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            SubClientCompanyBankRequest = new SubClientCompanyBank();
            SubClientCompanyBankRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "ClientCompanyRequired", true },
                    { "SubClientCompanyRequired", true }
                };
            var dropdwonList = SubClientCompanyBankRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ClientCompanyRequired")
                {
                    SubClientCompanyBankRequest.ClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }
                if (item.Key == "SubClientCompanyRequired")
                {
                    SubClientCompanyBankRequest.SubClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }
            }
            sqlDataSource1.FillAsync();

            if (SubClientCompanyBankRequest.ClientCompanyList != null)
            {
                if (SubClientCompanyBankRequest.ClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in SubClientCompanyBankRequest.ClientCompanyList)
                    {
                        drpClientCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }

            if (SubClientCompanyBankRequest.SubClientCompanyList != null)
            {
                if (SubClientCompanyBankRequest.SubClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in SubClientCompanyBankRequest.SubClientCompanyList)
                    {
                        drpSubCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (drpSubCompany.Text != string.Empty && drpClientCompany.Text != string.Empty && drpBankName.Text != string.Empty && TxtBankAccountNo.Text != string.Empty && TxtAddress.Text != string.Empty && TxtBranchCode.Text != string.Empty && TxtBranchName.Text != string.Empty && TxtIfsCode.Text != string.Empty)
                {
                    var selectedSubClientItem = drpSubCompany.EditValue;

                    if (selectedSubClientItem != null)
                    {
                        SubClientCompanyBankRequest.SubClientCompanyId = SubClientCompanyBankRequest.SubClientCompanyList.FirstOrDefault(item => item.Name == selectedSubClientItem.ToString())?.Id ?? -1;
                    }

                    var selectedClientItem = drpClientCompany.EditValue;
                    if (selectedClientItem != null)
                    {
                        SubClientCompanyBankRequest.ClientCompanyId = SubClientCompanyBankRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedClientItem.ToString())?.Id ?? -1;
                    }
                    // Calling the stored procedure for creating a new Company Profile
                    {

                        //ClientCompanyBankInfoRequest.ClientCompanyId = drpClientCompany.Text;
                        SubClientCompanyBankRequest.BankName = drpBankName.Text;
                        SubClientCompanyBankRequest.BankAcNo = TxtBankAccountNo.Text;
                        SubClientCompanyBankRequest.BranchCode = TxtBranchCode.Text;
                        SubClientCompanyBankRequest.BranchName = TxtBranchName.Text;
                        SubClientCompanyBankRequest.IFSCode = TxtIfsCode.Text;
                        SubClientCompanyBankRequest.Address = TxtAddress.Text;
                        SubClientCompanyBankRequest.Update();
                    };
                    if (SubClientCompanyBankRequest.Result.Status == ResultStatus.Success)
                    {
                        //ClientCompanyBankInfoRequest.RefreshData();

                        XtraMessageBox.Show(SubClientCompanyBankRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear_Click();
                    }
                }
                else
                {
                    XtraMessageBox.Show(SubClientCompanyBankRequest.Result.Message, "please give the manditory field", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
            }
        }

        private void btn_GridView(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = SubClientBankGrid.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    SubClientCompanyBankRequest.Id = (Int64)SubClientBankGrid.GetRowCellValue(rowHandle, "Id");
                    drpClientCompany.SelectedIndex = SubClientCompanyBankRequest.ClientCompanyList.FindIndex(x => x.Id == Convert.ToInt32(SubClientBankGrid.GetRowCellValue(rowHandle, "ClientCompanyId")));
                    //drpClientCompany.SelectedIndex = Convert.ToInt32(SubClientBankGrid.GetRowCellValue(rowHandle, "ClientCompanyId").ToString());
                    drpSubCompany.SelectedIndex = SubClientCompanyBankRequest.ClientCompanyList.FindIndex(x => x.Id == Convert.ToInt32(SubClientBankGrid.GetRowCellValue(rowHandle, "SubClientCompanyId")));
                    //drpSubCompany.SelectedIndex = Convert.ToInt32(SubClientBankGrid.GetRowCellValue(rowHandle, "SubClientCompanyId").ToString());
                    drpBankName.Text = SubClientBankGrid.GetRowCellValue(rowHandle, "BankName").ToString();
                    TxtBankAccountNo.Text = SubClientBankGrid.GetRowCellValue(rowHandle, "BankAcNo").ToString();
                    TxtAddress.Text = SubClientBankGrid.GetRowCellValue(rowHandle, "Address").ToString();
                    TxtBranchCode.Text = SubClientBankGrid.GetRowCellValue(rowHandle, "BranchCode").ToString();
                    TxtBranchName.Text = SubClientBankGrid.GetRowCellValue(rowHandle, "BranchName").ToString();
                    TxtIfsCode.Text = SubClientBankGrid.GetRowCellValue(rowHandle, "IFSCode").ToString();

                }
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnClear_Click(object sender = null, EventArgs e = null)
        {
            SubClientCompanyBankRequest.Id = 0;
            drpClientCompany.ResetText();
            drpSubCompany.ResetText();
            drpBankName.ResetText();
            TxtBankAccountNo.ResetText();
            TxtAddress.ResetText();
            TxtBranchCode.ResetText();
            TxtBranchName.ResetText();
            TxtIfsCode.ResetText();
        }
    }

   

        //var i = _conn.ExecuteNonQuery("PRO_UpdateClientBankInfo", parameters);
    
 
}