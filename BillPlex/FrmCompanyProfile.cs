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

namespace BillPlex
{
    public partial class FrmCompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        public FrmCompanyProfile()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            FrmCompanyInfo CompanyInfo = new FrmCompanyInfo();
            CompanyInfo.MdiParent = this;
            CompanyInfo.Show();
        }
    }
}