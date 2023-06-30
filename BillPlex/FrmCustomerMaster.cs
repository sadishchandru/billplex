﻿using BusinessLayer;
using DevExpress.XtraEditors;
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
    public partial class FrmCustomerMaster : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _conn;

        private CustomerMasterInfo CustomerRequest;
        public FrmCustomerMaster()
        {
            InitializeComponent();

            labelAvailable.Visible = false;
            labelCodeExist.Visible = false;
            // _conn = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            //_conn = new SqlConnector(connectionString);
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            CustomerRequest = new CustomerMasterInfo();
            CustomerRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            CustomerRequest.Result = new ResultDetail();

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "CustomerMasterRequired", true }
                };

            var dropdwonList = CustomerRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "CustomerMasterRequired")
                {
                    CustomerRequest.CustomerMasterCodeList = (List<DropDownItemInfo>)item.Value;
                }
            }
        }
        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            CustomerMaster_GridView.RefreshData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerCode.Text != string.Empty && txtCustomerName.Text != string.Empty)
                {
                    if (labelAvailable.Visible == true && labelCodeExist.Visible == false)
                    {
                        CustomerRequest.CustomerCode = txtCustomerCode.Text;
                        CustomerRequest.CustomerName = txtCustomerName.Text;
                        CustomerRequest.OffAddress = txtOffAddress.Text;
                        CustomerRequest.State = drpState.Text;
                        CustomerRequest.StatePin = txtStatePin.Text;
                        CustomerRequest.Code = txtCode.Text;
                        CustomerRequest.Country = drpCountry.Text;
                        CustomerRequest.PhoneNo = txtPhoneNo.Text;
                        CustomerRequest.EmailID = txtEmailID.Text;
                        CustomerRequest.CDAddress = txtCDAddress.Text;
                        CustomerRequest.CState = drpCState.Text;
                        CustomerRequest.Pin = txtPin.Text;
                        CustomerRequest.CDCountry = drpCDCountry.Text;
                        CustomerRequest.MobileNo = txtMobileNo.Text;
                        CustomerRequest.TINno = txtTINno.Text;
                        CustomerRequest.TINDate = ddTINDate.Text;
                        CustomerRequest.CSTno = txtCSTno.Text;
                        CustomerRequest.CSTDate = ddCSTDate.Text;
                        CustomerRequest.LicenseNo = txtLicenseNo.Text;
                        CustomerRequest.Website = txtWebsite.Text;
                        CustomerRequest.Update();

                        if (CustomerRequest.Result.Status == ResultStatus.Success)
                        {
                            XtraMessageBox.Show(CustomerRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadSqlDataSource();
                        }
                        else
                        {
                            XtraMessageBox.Show(CustomerRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(CustomerRequest.Result.Message, "please give the manditory field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the values in textboxes
            CustomerRequest.Id = 0;
            txtCustomerCode.ResetText();
            txtCustomerName.ResetText();
            txtOffAddress.ResetText();
            drpState.ResetText();
            txtStatePin.ResetText();
            drpCountry.ResetText();
            txtCode.ResetText();
            txtPhoneNo.ResetText();
            txtEmailID.ResetText();
            txtCDAddress.ResetText();
            drpCState.ResetText();
            txtPin.ResetText();
            drpCDCountry.ResetText();
            txtMobileNo.ResetText();
            txtTINno.ResetText();
            ddTINDate.ResetText();
            txtCSTno.ResetText();
            ddCSTDate.ResetText();
            txtLicenseNo.ResetText();
            txtWebsite.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = CustomerMaster_GridView.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                CustomerRequest.Id = (Int64)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Id");

                //CompanyMasterRequest.Id = (Int32)gridView2.GetRowCellValue(rowHandle, "Id");
            }
            CustomerRequest.Delete();

            if (CustomerRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(CustomerRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //// Get the selected rows from the GridView control
            //var selectedRows = CustomerMaster_GridView.GetSelectedRows();

            //foreach (var rowHandle in selectedRows)
            //{
            //    CustomerRequest.Id = (int)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Id");
            //}
            //CustomerRequest.Delete();

        }

        private void drpCountry_Click(object sender, EventArgs e)
        {
            //List<string> countryNames = GetCountryNames(); // Retrieve the country names dynamically
            //comboBoxEdit1.Properties.DataSource = countryNames;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = CustomerMaster_GridView.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    CustomerRequest.Id = (Int64)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Id");
                    txtCustomerCode.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Code");
                    txtCustomerName.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Name");
                    txtOffAddress.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "OffAddress");
                    drpState.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "State");
                    txtStatePin.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Pin");
                    drpCountry.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Country");
                    txtCode.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "PhonePin");
                    txtPhoneNo.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "OffPhone");
                    txtEmailID.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Email");
                    txtCDAddress.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "ResAddress");
                    drpCState.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "ResState");
                    txtPin.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "ResPin");
                    drpCDCountry.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "ResCountry");
                    txtMobileNo.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Mobile");
                    txtTINno.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "TinNo");
                    var datete = CustomerMaster_GridView.GetRowCellValue(rowHandle, "CstDate").ToString();
                    DateTime dat = DateTime.Parse(datete);
                    ddTINDate.Text = dat.ToString();
                    txtCSTno.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "CstNo");
                    var datet = CustomerMaster_GridView.GetRowCellValue(rowHandle, "CstDate").ToString();
                    DateTime date = DateTime.Parse(datet);
                    ddCSTDate.Text = date.ToString();
                    txtLicenseNo.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "licenseNo");
                    txtWebsite.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "Website");
                }
                txtCustomerCode.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = true;

                labelAvailable.Visible = false;
                labelCodeExist.Visible = false;
            }
            catch(Exception ex) 
            {
               
            
            }
        }

        private void txtCompanyCode_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCustomerCode.Text != string.Empty)
            {
                if (CustomerRequest.CustomerMasterCodeList != null)
                {

                    //var IsCode = CompanyRequest.MasterCodeList.FirstOrDefault(item => item.Code == txtCode.Text.ToString())?.Id ?? 0;
                    var IsCode = CustomerRequest.CustomerMasterCodeList.FirstOrDefault(obj => obj.Code == txtCustomerCode.Text.ToString() && obj.Id != CustomerRequest.Id);

                    if (IsCode != null)
                    {
                        labelAvailable.Visible = false;
                        labelCodeExist.Visible = true;
                    }
                    else
                    {
                        labelAvailable.Visible = true;
                        labelCodeExist.Visible = false;
                    }
                }
                else
                {
                    labelAvailable.Visible = true;
                    labelCodeExist.Visible = false;
                }

            }
            else
            {
                labelAvailable.Visible = false;
                labelCodeExist.Visible = false;
            }
        }
    }
}
