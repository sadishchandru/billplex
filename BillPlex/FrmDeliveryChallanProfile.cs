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
    public partial class FrmDeliveryChallanProfile : DevExpress.XtraEditors.XtraForm
    {
        private DeliveryChallanInfro DeliveryChallanInfoRequest;
        private FrmDeliveryChallanInfo DeliveryChallanRequest;
        private GridView gridView;
        public FrmDeliveryChallanProfile()
        {
            DeliveryChallanInfoRequest = new DeliveryChallanInfro();
            InitializeComponent();
            DeliveryChallanInfoRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            // gridControl1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmDeliveryChallanInfo CI = new FrmDeliveryChallanInfo();
            CI.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                DeliveryChallanInfoRequest.Id = (Int64)gridView1.GetRowCellValue(rowHandle, "Id");
            }
            DeliveryChallanInfoRequest.Delete();

            if (DeliveryChallanInfoRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(DeliveryChallanInfoRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmDeliveryChallanProfile_Load(object sender, EventArgs e)
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