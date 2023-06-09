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
    public partial class FrmSubClientCompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        private SubClientCompanyInfo SubClientRequest;
        public FrmSubClientCompanyProfile()
        {
            InitializeComponent();
            SubClientRequest = new SubClientCompanyInfo();

            SubClientRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            FrmSubClientCompanyInfo CP = new FrmSubClientCompanyInfo();
            CP.ShowDialog();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var Id = gridView1.GetRowCellValue(rowHandle, "Id");
                //SubClientRequest.Id = (int)Id;

            }

           // SubClientRequest.Id = Id;
            SubClientRequest.Delete();
        }

        
    }
}