﻿using BusinessLayer;using DevExpress.XtraEditors;using DevExpress.XtraEditors.Controls;using DevExpress.XtraGrid.Views.Grid;using System;using System.Collections;using System.Collections.Generic;using System.ComponentModel;using System.Configuration;using System.Data;using System.Data.SqlClient;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmClientCompanyProfile : DevExpress.XtraEditors.XtraForm
    {        
        private ClientCompanyInfo ClientCompanyinfoRequest;
        private FrmClientCompanyInfo ClientCompanyRequest;
        private GridView gridView;
        public FrmClientCompanyProfile()

        {
            ClientCompanyinfoRequest  = new ClientCompanyInfo();
            InitializeComponent();
            ClientCompanyinfoRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            loadgrid();
        }

        void loadgrid()
        {
            gridView = gridView2;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        private void Newbtn_Click(object sender, EventArgs e)
        {
            FrmClientCompanyInfo CP = new FrmClientCompanyInfo();
            CP.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView2.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                ClientCompanyinfoRequest.Id = (Int64)gridView2.GetRowCellValue(rowHandle, "Id");

                //CompanyMasterRequest.Id = (Int32)gridView2.GetRowCellValue(rowHandle, "Id");
            }
            ClientCompanyinfoRequest.Delete();

            if (ClientCompanyinfoRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(ClientCompanyinfoRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView2.GetSelectedRows();

            ClientCompanyRequest = new FrmClientCompanyInfo();

            ClientCompanyRequest.BindData(gridView2);


            ClientCompanyRequest.Show();
           
        }

        public void FrmClientCompanyProfile_Load(object sender, EventArgs e)
        {
           // loadgrid();
        }
    }
}