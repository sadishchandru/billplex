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
            FrmEmployeeMasterList employeeMaster = new FrmEmployeeMasterList();
            employeeMaster.MdiParent = this;
            employeeMaster.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOrderMaster masterbanking = new FrmOrderMaster();
            masterbanking.MdiParent = this;
            masterbanking.Show();
        }

        private void btn_RawMaterial_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmRawMaterial pc = new FrmRawMaterial();
            pc.MdiParent = this;
            pc.Show();
        }

        private void btn_ProductMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmProductMaster pc = new FrmProductMaster();
            pc.MdiParent = this;
            pc.Show();
        }

        private void btn_SizeMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSizeMaster pc = new FrmSizeMaster();
            pc.MdiParent = this;
            pc.Show();
        }

        private void btn_ColorMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmColorMaster pc = new FrmColorMaster();
            pc.MdiParent = this;
            pc.Show();
        }

        private void btn_ProductModel_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmProductModel pc = new FrmProductModel();
            pc.MdiParent = this;
            pc.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            IncentiveMaster pc = new IncentiveMaster();
            pc.MdiParent = this;
            pc.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDeliveryChallanProfile cp = new FrmDeliveryChallanProfile();
            cp.MdiParent = this;
            cp.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_MasterBankInfo(object sender, ItemClickEventArgs e)
        {
            FrmCompanyProfileBankInfo FrmCompanyProfileBankInfo = new FrmCompanyProfileBankInfo();
            FrmCompanyProfileBankInfo.MdiParent = this;
            FrmCompanyProfileBankInfo.Show();
        }

        private void btn_ClientBankInfo(object sender, ItemClickEventArgs e)
        {
            FrmClientCompanyBankInfo clientCompanyBankInfo = new FrmClientCompanyBankInfo();
            clientCompanyBankInfo.MdiParent = this;
            clientCompanyBankInfo.Show();
        }

        private void Btn_SubClientBankInfo(object sender, ItemClickEventArgs e)
        {
            FrmSubClientCompanyBankInfo subClientCompanyBankInfo = new FrmSubClientCompanyBankInfo();
            subClientCompanyBankInfo.MdiParent = this;
            subClientCompanyBankInfo.Show();
        }
    }
}