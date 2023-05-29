﻿using DevExpress.XtraBars;
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
    public partial class NavBar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public NavBar()
        {
            InitializeComponent();
        }

        private void Master_Company_Click(object sender, ItemClickEventArgs e)
        {
            /*CompanyProfile CP = new CompanyProfile();
            CP.ShowDialog();*/
            MessageBox.Show("Master_Company button clicked!");
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void MasterButtonClicked(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            FrmCompanyInfo CP = new FrmCompanyInfo();
            CP.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmClientCompanyInfo CP = new FrmClientCompanyInfo();
            CP.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSubClientCompanyInfo CP = new FrmSubClientCompanyInfo();
            CP.ShowDialog();
        }
    }
}