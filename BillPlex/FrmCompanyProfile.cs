﻿using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmCompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        private CompanyMasterInfo CompanyMasterRequest;

        private FrmCompanyInfo CompanyInfoRequest;
        private GridView gridView;

        public FrmCompanyProfile()
        {
            InitializeComponent();
            CompanyMasterRequest = new CompanyMasterInfo();
            CompanyMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();
            gridView1.BestFitColumns();
        }

        public void ReloadSqlDataSource()
        {
            sqlDataSource2.FillAsync();
            gridView1.RefreshData();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();
            if (selectedRows.Length > 0)
            {
                foreach (var rowHandle in selectedRows)
                {
                    CompanyMasterRequest.Id = (Int64)gridView1.GetRowCellValue(rowHandle, "Id");
                }
                CompanyMasterRequest.Delete();

                if (CompanyMasterRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(CompanyMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView1.RefreshData();
                    ReloadSqlDataSource();
                }
                else
                {
                    if (CompanyMasterRequest.Result.Message.Contains("FK__"))
                    {
                        XtraMessageBox.Show("This Item has RelationShip with Another Model", "RelationShip Issues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        XtraMessageBox.Show(CompanyMasterRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Records not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetSelectedRows();
            if (selectedRow.Length > 0)
            {

                CompanyInfoRequest = new FrmCompanyInfo();

                CompanyInfoRequest.MdiParent = this.MdiParent;

                CompanyInfoRequest.BindData(gridView1);

                CompanyInfoRequest.Show();
            }
            else
            {
                XtraMessageBox.Show("Records not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void FrmCompanyProfile_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the form
            int centerX = (this.Width - panelControl1.Width) / 2;
            int centerY = (this.Height - panelControl1.Height) / 2;

            // Set the controls' positions to the calculated center position
            panelControl1.Location = new Point(centerX, centerY);
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            Form myForm = Application.OpenForms["FrmCompanyInfo"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmCompanyInfo();
                myForm.MdiParent = this.MdiParent;
                myForm.Show();
                IsOpen = true;
            }

            if (IsOpen == false)
            {
                FrmCompanyInfo CompanyInfo = new FrmCompanyInfo();
                CompanyInfo.MdiParent = this.MdiParent;
                CompanyInfo.Show();
            }
        }
    }
}