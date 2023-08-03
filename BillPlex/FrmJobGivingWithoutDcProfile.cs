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
    public partial class FrmJobGivingWithoutDcProfile : DevExpress.XtraEditors.XtraForm
    {
        private JobGivingWithoutDc JobGivingWithoutDcRequest;

        private FrmJobGivingWithoutDcInfo JobGivingWithoutDcInfoRequest;
        private GridView gridView;
        public FrmJobGivingWithoutDcProfile()
        {
            InitializeComponent();
            gridView1 = gridView1;
            JobGivingWithoutDcRequest = new JobGivingWithoutDc();

            JobGivingWithoutDcRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            gridView1.RefreshData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                JobGivingWithoutDcRequest.Id = (Int64)gridView1.GetRowCellValue(rowHandle, "Id");
            }
            JobGivingWithoutDcRequest.Delete();

            if (JobGivingWithoutDcRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(JobGivingWithoutDcRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadSqlDataSource();
            }
            else
            {
                if (JobGivingWithoutDcRequest.Result.Message.Contains("FK__"))
                {
                    XtraMessageBox.Show("This Iteam has RelationShip with Another Model", "RelationShip Issues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show(JobGivingWithoutDcRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmJobGivingWithoutDcInfo CP = new FrmJobGivingWithoutDcInfo();
            CP.MdiParent = this.MdiParent;
            CP.Show();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetSelectedRows();

            JobGivingWithoutDcInfoRequest = new FrmJobGivingWithoutDcInfo();

            JobGivingWithoutDcInfoRequest.BindData(gridView1);
            JobGivingWithoutDcInfoRequest.MdiParent = this.MdiParent;
            JobGivingWithoutDcInfoRequest.Show();
        }

        private void FrmJobGivingWithoutDcProfile_Load(object sender, EventArgs e)
        {
            int centerX = (this.Width - panelControl2.Width) / 2;
            int centerY = (this.Height - panelControl2.Height) / 2;

            // Set the controls' positions to the calculated center position
            panelControl2.Location = new Point(centerX, centerY);
        }
    }
}