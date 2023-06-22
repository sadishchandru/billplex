﻿using BusinessLayer;
using DevExpress.XtraEditors;
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
    public partial class FrmEmployeeMasterList : DevExpress.XtraEditors.XtraForm
    {

        private EmployeePersonal EmployeePersonalRequest;
        public FrmEmployeeMasterList()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously

            EmployeePersonalRequest = new EmployeePersonal();
            EmployeePersonalRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            //EmployeePersonalRequest.GetList();
            sqlDataSource1.FillAsync();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmEmployeeMaster CP = new FrmEmployeeMaster();
            CP.ShowDialog();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //var selectedRows = gridView1.GetSelectedRows();

            //foreach (var rowHandle in selectedRows)
            //{
            //    var id = gridView1.GetRowCellValue(rowHandle, "Id").ToString(); // Retrieve the value of the "Id" column

            //    // Extract the desired values from the selected row
            //    string value1 = gridView1.GetRowCellValue(rowHandle, "Column1")?.ToString(); // Replace "Column1" with the actual column name
            //    string value2 = gridView1.GetRowCellValue(rowHandle, "Column2")?.ToString(); // Replace "Column2" with the actual column name

            //    // Populate the TextBox controls with the retrieved values
            //    colMasterCompanyId.SearchText = value1;
            //    colEmpCode.SearchText = value2;
            //}
        }
    }
}