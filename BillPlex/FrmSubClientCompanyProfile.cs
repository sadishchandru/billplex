﻿using BusinessLayer;
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
    public partial class FrmSubClientCompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        private SubClientCompanyInfo SubClientRequest;

        private FrmSubClientCompanyInfo SubCompanyInfoRequest;
        private GridView gridView;
        public FrmSubClientCompanyProfile()
        {
            InitializeComponent();

            gridView = SubClientGrid;
            SubClientRequest = new SubClientCompanyInfo();

            SubClientRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            SubClientGrid.BestFitColumns();
        }


        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            SubClientGrid.RefreshData();

        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            FrmSubClientCompanyInfo CP = new FrmSubClientCompanyInfo();
            CP.MdiParent = this.MdiParent;
            CP.Show();

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var selectedRows = SubClientGrid.GetSelectedRows();
            if (selectedRows.Length > 0)
            {
                if (selectedRows.Length > 0)
                {
                    foreach (var rowHandle in selectedRows)
                    {
                        SubClientRequest.Id = (Int64)SubClientGrid.GetRowCellValue(rowHandle, "Id");
                    }
                    SubClientRequest.Delete();
                    if (SubClientRequest.Result.Status == ResultStatus.Success)
                    {
                        XtraMessageBox.Show(SubClientRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadSqlDataSource();
                    }
                    else
                    {
                        if (SubClientRequest.Result.Message.Contains("FK__"))
                        {
                            XtraMessageBox.Show("This Item has Relationship with Another Model", "Relationship Issues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            XtraMessageBox.Show(SubClientRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("No Record Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Records not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_EditClick(object sender, EventArgs e)
        {
            var selectedRow = SubClientGrid.GetSelectedRows();
            if (selectedRow.Length > 0)
            {
                SubCompanyInfoRequest = new FrmSubClientCompanyInfo();
                SubCompanyInfoRequest.BindData(SubClientGrid);
                SubCompanyInfoRequest.MdiParent = this.MdiParent;
                SubCompanyInfoRequest.Show();
            }
            else
            {
                XtraMessageBox.Show("Records not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmSubClientCompanyProfile_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the form
            int centerX = (this.Width - panelControl1.Width) / 2;
            int centerY = (this.Height - panelControl1.Height) / 2;

            // Set the controls' positions to the calculated center position
            panelControl1.Location = new Point(centerX, centerY);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}