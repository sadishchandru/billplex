using DevExpress.XtraBars;
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

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void ClientCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmClientCompanyProfile ClientCompanyInfo = new FrmClientCompanyProfile();
            ClientCompanyInfo.MdiParent = this;
            ClientCompanyInfo.Show();
        }

        private void MasterCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCompanyProfile MasterCompanyInfo = new FrmCompanyProfile();
            MasterCompanyInfo.MdiParent = this;
            MasterCompanyInfo.Show();
        }

        private void SubClient_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSubClientCompanyProfile SubClientCompanyInfo = new FrmSubClientCompanyProfile();
            SubClientCompanyInfo.MdiParent = this;
            SubClientCompanyInfo.Show();
        }

        private void CustomerMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCustomerMaster CustomerMasterInfo = new FrmCustomerMaster();
            CustomerMasterInfo.MdiParent = this;
            CustomerMasterInfo.Show();
        }

        private void btn_Employee_Master(object sender, ItemClickEventArgs e)
        {
            FrmEmployeeMaster employeeMaster = new FrmEmployeeMaster();
            employeeMaster.MdiParent = this;
            employeeMaster.Show();
        }
    }
}