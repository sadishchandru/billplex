﻿using BusinessLayer;
using DevExpress.XtraEditors;
using System;
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
            _conn = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            //_conn = new SqlConnector(connectionString);
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            CustomerRequest = new CustomerMasterInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerRequest.CustomerCode = txtCustomerCode.Text;
                CustomerRequest.CustomerName = txtCustomerName.Text;
                CustomerRequest.OffAddress = txtOffAddress.Text;
                CustomerRequest.State = drpState.Text;
                CustomerRequest.StatePin =txtStatePin.Text;
                CustomerRequest.Code =txtCode.Text;
                CustomerRequest.Country =drpCountry.Text;
                CustomerRequest.PhoneNo =txtPhoneNo.Text;
                CustomerRequest.EmailID = txtEmailID.Text;
                CustomerRequest.CDAddress = txtCDAddress.Text;
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
                } else
                {
                    XtraMessageBox.Show(CustomerRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            drpState2.ResetText();
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
            // Get the selected rows from the GridView control
            var selectedRows = CustomerMaster_GridView.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var id = CustomerMaster_GridView.GetRowCellValue(rowHandle, "Id");
            }
        }

        private void drpCountry_Click(object sender, EventArgs e)
        {
            //List<string> countryNames = GetCountryNames(); // Retrieve the country names dynamically
            //comboBoxEdit1.Properties.DataSource = countryNames;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var selectedRows = CustomerMaster_GridView.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var id = CustomerMaster_GridView.GetRowCellValue(rowHandle, "Id");
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
                drpState2.Text = (string)CustomerMaster_GridView.GetRowCellValue(rowHandle, "ResState");
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
        }
    }
}