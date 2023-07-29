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
    public partial class FrmJobReceivedProfile : DevExpress.XtraEditors.XtraForm
    {

        private JobReceived JobReceivedInfoRequest;
        private FrmJobReceivedInfo JobReceivedRequest;
        private GridView gridView;
        public FrmJobReceivedProfile()
        {
            JobReceivedInfoRequest = new JobReceived();
            InitializeComponent();
            JobReceivedInfoRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            gridView1.RefreshData();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmJobReceivedInfo CP = new FrmJobReceivedInfo();
            CP.MdiParent = this.MdiParent;
            CP.Show();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                JobReceivedInfoRequest.Id = (Int64)gridView1.GetRowCellValue(rowHandle, "Id");
            }
            JobReceivedInfoRequest.Delete();

            if (JobReceivedInfoRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(JobReceivedInfoRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadSqlDataSource();
            }

        }

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetSelectedRows();

            JobReceivedRequest = new FrmJobReceivedInfo();

            JobReceivedRequest.BindData(gridView1);
            JobReceivedRequest.MdiParent = this.MdiParent;
            JobReceivedRequest.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmJobReceivedProfile_Load(object sender, EventArgs e)
        {
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = (float)ourScreenWidth / 1600f;
            float scaleFactorHeigth = (float)ourScreenHeight / 900f;
            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
            Scale(scaleFactor);

            // If you want to center the resized screen.
            CenterToScreen();
        }
    }
}