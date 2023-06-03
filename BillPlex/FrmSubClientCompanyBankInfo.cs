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
using DataLayer;

namespace BillPlex
{
    public partial class FrmSubClientCompanyBankInfo : DevExpress.XtraEditors.XtraForm
    {
        private readonly SqlConnector _conn;
        public FrmSubClientCompanyBankInfo()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            _conn = new SqlConnector(connectionString);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ClientCompanyId", drpClientCompany.Text),
                new SqlParameter("@SubClientCompanyId", drpSubClient.Text),
                new SqlParameter("@BankName", drpBankName.Text),
                new SqlParameter("@BankAcNo", TxtBankAccountNo.Text),
                new SqlParameter("@BranchCode",TxtBranchCode.Text),
                new SqlParameter("@BranchName", TxtBranchName.Text),
                new SqlParameter("@IFSCode", TxtIfsCode.Text),
                new SqlParameter("@Address", TxtAddress.Text),
            };

            var i = _conn.ExecuteNonQuery("PRO_UpdateClientBankInfo", parameters);
        }
    }
}