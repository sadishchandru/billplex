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
using BusinessLayer;

namespace BillPlex
{
    public partial class NavBar : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private FrmCompanyProfile MasterCompanyInfo;
        public NavBar()
        {
            InitializeComponent();
            btn_JobGiving.Visibility = BarItemVisibility.Never;
            btn_DirectJobGiving.Visibility = BarItemVisibility.Never;
            btn_DirectJobReceived.Visibility = BarItemVisibility.Never;
            btn_DeliveryChallan.Visibility = BarItemVisibility.Never;
            MasterCompanyInfo = new FrmCompanyProfile();

            //Common commonClass = new Common();

            //commonClass.InitializeConfigure();
        }
        #region profile
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
            if (IsOpen == false)
            {
                FrmClientCompanyProfile ClientCompanyInfo = new FrmClientCompanyProfile();
                ClientCompanyInfo.MdiParent = this;
                ClientCompanyInfo.Show();
            }
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
            if (IsOpen == false)
            {
                MasterCompanyInfo = new FrmCompanyProfile();
                MasterCompanyInfo.MdiParent = this;
                MasterCompanyInfo.Show();
            }
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
            if (IsOpen == false)
            {
                FrmSubClientCompanyProfile SubClientCompanyInfo = new FrmSubClientCompanyProfile();
                SubClientCompanyInfo.MdiParent = this;
                SubClientCompanyInfo.Show();
            }
        }
        #endregion

        #region Master
        private void CustomerMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            Form myForm = Application.OpenForms["FrmCustomerMaster"];
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
        #region Bank Info
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
            Form myForm = Application.OpenForms["FrmClientCompanyBankInfo"];
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
        #endregion
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmFinishingProductModel")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmFinishingProductModel finishingProductItem = new FrmFinishingProductModel();
                finishingProductItem.MdiParent = this;
                finishingProductItem.Show();
            }

        }
        #endregion

        #region Job allocation
        private void btn_JobGiving_ItemClick(object sender, ItemClickEventArgs e)
        {

            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "FrmJobGivingProfile")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    FrmJobGivingProfile JobGivingItem = new FrmJobGivingProfile();
            //    JobGivingItem.MdiParent = this;
            //    JobGivingItem.Show();
            //}

        }

        private void btn_JobGivingWithoutDC_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;

            Form myForm = Application.OpenForms["FrmJobGivingWithoutDcProfile"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmJobGivingWithoutDcProfile();
                myForm.MdiParent = this;
                myForm.Show();
                IsOpen = true;
            }
            if (IsOpen == false)
            {
                FrmJobGivingWithoutDcProfile frmJobGivingWithoutDc = new FrmJobGivingWithoutDcProfile();
                frmJobGivingWithoutDc.MdiParent = this;
                frmJobGivingWithoutDc.Show();
            }

        }

        private void btn_JobReallocation_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmJobReallocation")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmJobReallocation JobReallocation = new FrmJobReallocation();
                JobReallocation.MdiParent = this;
                JobReallocation.Show();
            }
        }

        private void btn_DirectJobGiving_ItemClick(object sender, ItemClickEventArgs e)
        {
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            // if (f.Text == "FrmDirectJobGivingProfile")
            // {
            //   IsOpen = true;
            //   f.Focus();
            //   break;
            // }
            //}
            //if (IsOpen == false)
            //{
            //  FrmDirectJobGivingProfile DirectJobGiving = new FrmDirectJobGivingProfile();
            //  DirectJobGiving.MdiParent = this;
            //  DirectJobGiving.Show();
            //}
        }

        private void btn_DirectJobReceived_ItemClick(object sender, ItemClickEventArgs e)
        {
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "FrmDirectJobReceivedWithoutGivingProfile")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    FrmDirectJobReceivedWithoutGivingProfile DirectJobReceivedWithoutGiving = new FrmDirectJobReceivedWithoutGivingProfile();
            //    DirectJobReceivedWithoutGiving.MdiParent = this;
            //    DirectJobReceivedWithoutGiving.Show();
            //}
        }

        private void btn_DirectJobReceivedWithoutGiving_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmDirectJobReceivedWithoutGivingProfile")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmDirectJobReceivedWithoutGivingProfile DirectJobReceivedWithoutGiving = new FrmDirectJobReceivedWithoutGivingProfile();
                DirectJobReceivedWithoutGiving.MdiParent = this;
                DirectJobReceivedWithoutGiving.Show();
            }
        }

        private void btnJobReceived_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmJobReceivedProfile")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmJobReceivedProfile JobReceived = new FrmJobReceivedProfile();
                JobReceived.MdiParent = this;
                JobReceived.Show();
            }
        }
        #endregion
        private bool IsFormOpen(Form _form)
        {
            //bool isOpen = false;
            //foreach (Form item in MdiChildren)
            //{
            //    if (item.Name == _form.Name)
            //    {
            //        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
            //        isOpen = true;
            //        break; // No need to continue looping once the form is found.
            //    }
            //}
            //return isOpen;

            bool isOpen = false;
            foreach (Form item in MdiChildren)
            {
                if (item.GetType() == _form.GetType())
                {
                    xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                    isOpen = true;
                    break;
                }
            }
            return isOpen;

            if (isOpen)
            {
                _form.Activate();
                return true;
            }
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            // Activate a specific MDI child form based on the selected tab
            foreach (Form item in MdiChildren)
            {

                if (item is FrmOrderMasterInfo orderMasterForm)
                {
                    if (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == item.GetType())
                    {
                        // Focus the found form
                        orderMasterForm.Focus();

                        // Call the method on the form
                        orderMasterForm.DropDownGetList();

                        break; // Exit the loop after finding the form
                    }

                }
                if (item is FrmProductModel ProductModelForm)
                {
                    if (xtraTabbedMdiManager1.SelectedPage != null)
                    {
                        if (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == item.GetType())
                        {
                            // Focus the found form
                            ProductModelForm.Focus();

                            // Call the method on the form
                            ProductModelForm.DropDownGetList();

                            break; // Exit the loop after finding the form
                        }
                    }
                }
                if (xtraTabbedMdiManager1.SelectedPage != null)
                {
                    if (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == item.GetType())
                    {
                        item.Activate();
                        break;
                    }
                }
            }
        }
    }
}