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

        private FrmCompanyProfile MasterCompanyInfo;
        public NavBar()
        {
            InitializeComponent();

            MasterCompanyInfo = new FrmCompanyProfile();
        }

        private void Master_Company_Click(object sender, ItemClickEventArgs e)
        {
            /*CompanyProfile CP = new CompanyProfile();
            CP.ShowDialog();*/
            MessageBox.Show("Master_Company button clicked!");
        }

        private void ClientCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;

            Form myForm = Application.OpenForms["FrmClientCompanyProfile"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmCompanyProfile();
                myForm.MdiParent = this;
                myForm.Show();
                IsOpen = true;
            }
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "FrmClientCompanyProfile")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            if (IsOpen == false)
            {
                FrmClientCompanyProfile ClientCompanyInfo = new FrmClientCompanyProfile();
                ClientCompanyInfo.MdiParent = this;
                ClientCompanyInfo.Show();
            }
            //FrmClientCompanyProfile ClientCompanyInfo = new FrmClientCompanyProfile();
            //ClientCompanyInfo.MdiParent = this;
            //ClientCompanyInfo.Show();
        }

        private void MasterCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            Form myForm = Application.OpenForms["FrmCompanyProfile"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmCompanyProfile();
                myForm.MdiParent = this;
                myForm.Show();
                IsOpen = true;
            }
            
            //foreach(Form f in Application.OpenForms)
            //{
            //    Form myForm = Application.OpenForms["FrmCompanyProfile"];
            //    myForm.Close();
            //    myForm = new FrmCompanyProfile();
            //    myForm.MdiParent = this;
            //    myForm.Show();

            //    //if (f.Text == "FrmCompanyProfile")
            //    //{
            //    //    IsOpen = true;
            //    //    f.Focus();
            //    //    break;
            //    //}
            //}
            if (IsOpen == false)
            {
                 MasterCompanyInfo = new FrmCompanyProfile();
                MasterCompanyInfo.MdiParent = this;
                MasterCompanyInfo.Show();
            }
            
            //MasterCompanyInfo.MdiParent = this;
            //FrmCompanyProfile MasterCompanyInfo = new FrmCompanyProfile();
            //MasterCompanyInfo.MdiParent = this;
            //MasterCompanyInfo.Show();
        }

        private void SubClient_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;

            Form myForm = Application.OpenForms["FrmSubClientCompanyProfile"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmCompanyProfile();
                myForm.MdiParent = this;
                myForm.Show();
                IsOpen = true;
            }

            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "FrmSubClientCompanyProfile")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}


            if (IsOpen == false)
            {
                FrmSubClientCompanyProfile SubClientCompanyInfo = new FrmSubClientCompanyProfile();
                SubClientCompanyInfo.MdiParent = this;
                SubClientCompanyInfo.Show();
            }
            //FrmSubClientCompanyProfile SubClientCompanyInfo = new FrmSubClientCompanyProfile();
            //SubClientCompanyInfo.MdiParent = this;
            //SubClientCompanyInfo.Show();
        }

        private void CustomerMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmCustomerMaster")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmCustomerMaster CustomerMasterInfo = new FrmCustomerMaster();
                CustomerMasterInfo.MdiParent = this;
                CustomerMasterInfo.Show();
            }
            //FrmCustomerMaster CustomerMasterInfo = new FrmCustomerMaster();
            //CustomerMasterInfo.MdiParent = this;
            //CustomerMasterInfo.Show();
        }

        private void btn_Employee_Master(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmEmployeeMasterList")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmEmployeeMasterList employeeMaster = new FrmEmployeeMasterList();
                employeeMaster.MdiParent = this;
                employeeMaster.Show();
            }
            //FrmEmployeeMasterList employeeMaster = new FrmEmployeeMasterList();
            //employeeMaster.MdiParent = this;
            //employeeMaster.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmOrderMaster")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmOrderMaster masterbanking = new FrmOrderMaster();
                masterbanking.MdiParent = this;
                masterbanking.Show();
            }
            //FrmOrderMaster masterbanking = new FrmOrderMaster();
            //masterbanking.MdiParent = this;
            //masterbanking.Show();
        }

        private void btn_RawMaterial_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmRawMaterial")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmRawMaterial pc = new FrmRawMaterial();
                pc.MdiParent = this;
                pc.Show();
            }
            //FrmRawMaterial pc = new FrmRawMaterial();
            //pc.MdiParent = this;
            //pc.Show();
        }

        private void btn_ProductMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmProductMaster")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmProductMaster pc = new FrmProductMaster();
                pc.MdiParent = this;
                pc.Show();
            }
            //FrmProductMaster pc = new FrmProductMaster();
            //pc.MdiParent = this;
            //pc.Show();
        }

        private void btn_SizeMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmSizeMaster")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmSizeMaster pc = new FrmSizeMaster();
                pc.MdiParent = this;
                pc.Show();
            }
            //FrmSizeMaster pc = new FrmSizeMaster();
            //pc.MdiParent = this;
            //pc.Show();
        }

        private void btn_ColorMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmColorMaster")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmColorMaster pc = new FrmColorMaster();
                pc.MdiParent = this;
                pc.Show();
            }
            //FrmColorMaster pc = new FrmColorMaster();
            //pc.MdiParent = this;
            //pc.Show();
        }

        private void btn_ProductModel_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmProductModel")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmProductModel pc = new FrmProductModel();
                pc.MdiParent = this;
                pc.Show();
            }
            //FrmProductModel pc = new FrmProductModel();
            //pc.MdiParent = this;
            //pc.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "IncentiveMaster")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                IncentiveMaster pc = new IncentiveMaster();
                pc.MdiParent = this;
                pc.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmDeliveryChallanProfile")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmDeliveryChallanProfile cp = new FrmDeliveryChallanProfile();
                cp.MdiParent = this;
                cp.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_MasterBankInfo(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmCompanyProfileBankInfo")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmCompanyProfileBankInfo FrmCompanyProfileBankInfo = new FrmCompanyProfileBankInfo();
                FrmCompanyProfileBankInfo.MdiParent = this;
                FrmCompanyProfileBankInfo.Show();
            }
        }

        private void btn_ClientBankInfo(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmClientCompanyBankInfo")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmClientCompanyBankInfo clientCompanyBankInfo = new FrmClientCompanyBankInfo();
                clientCompanyBankInfo.MdiParent = this;
                clientCompanyBankInfo.Show();
            }
        }

        private void Btn_SubClientBankInfo(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmSubClientCompanyBankInfo")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmSubClientCompanyBankInfo subClientCompanyBankInfo = new FrmSubClientCompanyBankInfo();
                subClientCompanyBankInfo.MdiParent = this;
                subClientCompanyBankInfo.Show();
            }
        }
    }
}