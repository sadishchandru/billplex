using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class FrmEmployeeMaster : DevExpress.XtraEditors.XtraForm
    {
        private EmployeePersonal EmployeePersonalRequest;
        
        private EmployeeFinance EmployeeFinanceRequest;

        private EmployeeFamily EmployeeFamilyRequest;

        private EmployeeNominee EmployeeNomineeReqest;
        public FrmEmployeeMaster()
        {
            InitializeComponent();

            EmployeePersonalRequest = new EmployeePersonal();
            EmployeeFinanceRequest = new EmployeeFinance();
            EmployeeFamilyRequest = new EmployeeFamily();
            EmployeeNomineeReqest = new EmployeeNominee();

            EmployeePersonalRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            EmployeeFinanceRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            EmployeeFamilyRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            EmployeeNomineeReqest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true },
                    {"ClientCompanyRequired",true},
                    {"SubClientCompanyRequired",true}
                };
            var dropdwonList = EmployeePersonalRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    EmployeePersonalRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "ClientCompanyRequired")
                {
                    EmployeePersonalRequest.ClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "SubClientCompanyRequired")
                {
                    EmployeePersonalRequest.SubClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }
            }
            if (EmployeePersonalRequest.MasterCompanyList.Count() > 0)
            {
                foreach (DropDownItemInfo item in EmployeePersonalRequest.MasterCompanyList)
                {
                    drpMCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                }
            }

            if (EmployeePersonalRequest.ClientCompanyList.Count() > 0)
            {
                foreach (DropDownItemInfo item in EmployeePersonalRequest.ClientCompanyList)
                {
                    drpCCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                }
            }
            if (EmployeePersonalRequest.SubClientCompanyList.Count() > 0)
            {
                foreach (DropDownItemInfo item in EmployeePersonalRequest.SubClientCompanyList)
                {
                    drpSCCom.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                }
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {

                var tabIndex = EmployeeMasterTab.SelectedTabPageIndex;
                #region Employee Personal Detail Update
                if (tabIndex == 0)
                {
                    // Employee Personal Detail Update
                    string selectedMasterItem = (string)drpMCompany.SelectedItem;

                    if (selectedMasterItem != null)
                    {
                        EmployeePersonalRequest.EMasterCompany = EmployeePersonalRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedMasterItem.ToString())?.Id ?? -1;
                    }

                    string selectedClientItem = (string)drpCCompany.SelectedItem;

                    if (selectedClientItem != null)
                    {
                        EmployeePersonalRequest.EClientCompany = EmployeePersonalRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedClientItem.ToString())?.Id ?? -1;
                    }

                    string selectedSubClientItem = (string)drpMCompany.SelectedItem;

                    if (selectedSubClientItem != null)
                    {
                        EmployeePersonalRequest.ESubClientCompany = EmployeePersonalRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedSubClientItem.ToString())?.Id ?? -1;
                    }

                    //EmployeePersonalRequest.EMasterCompany = drpMCompany.Text;
                    EmployeePersonalRequest.EProprietorName = txtPName.Text;
                    //EmployeePersonalRequest.EClientCompany = drpCCompany.Text;
                    EmployeePersonalRequest.EClientName = txtCName.Text;
                    //EmployeePersonalRequest.ESubClientCompany = drpSCCom.Text;
                    EmployeePersonalRequest.ESubClientName = txtSCName.Text;
                    EmployeePersonalRequest.EEmployeeCode = txtEmpCode.Text;
                    EmployeePersonalRequest.EEmployeeName = txtEmpName.Text;
                    EmployeePersonalRequest.EVoterIdNo = txtVoterID.Text;
                    EmployeePersonalRequest.EDrivingLicNo = txtDriving.Text;
                    EmployeePersonalRequest.EPanNo = txtPANCard.Text;
                    EmployeePersonalRequest.EPassportNo = txtPassport.Text;
                    EmployeePersonalRequest.EIdentityMark = txtIdentity.Text;
                    EmployeePersonalRequest.EPAddress = txtPerAddress.Text;
                    EmployeePersonalRequest.EPVillageArea = txtPerArea.Text;
                    EmployeePersonalRequest.EPState = drpPState.Text;
                    EmployeePersonalRequest.EPDistrict = drpDistrict.Text;
                    EmployeePersonalRequest.EPPincode = txtPinCode.Text;
                    EmployeePersonalRequest.ECAddress = txtCPAddress.Text;
                    EmployeePersonalRequest.ECDistrict = drpCDistrict.Text;
                    EmployeePersonalRequest.ECState = drpState.Text;
                    EmployeePersonalRequest.ECPincode = txtPPincode.Text;
                    EmployeePersonalRequest.EDOB = ddDOB.Text;
                    EmployeePersonalRequest.EGender = radGender.Text;
                    EmployeePersonalRequest.EBloodGroup = drpBlood.Text;
                    EmployeePersonalRequest.EEmailId = txtEmailId.Text;
                    EmployeePersonalRequest.EmobileNo = txtMobile.Text;
                    EmployeePersonalRequest.EFatherName = txtFathers.Text;
                    EmployeePersonalRequest.EMotherName = txtMotherName.Text;
                    EmployeePersonalRequest.EMaritalStatus = drpMarital.Text;
                    EmployeePersonalRequest.EStdCode = txtStdCode.Text;
                    EmployeePersonalRequest.EPhone = txtPhone.Text;
                    EmployeePersonalRequest.EReligion = drpReligion.Text;
                    EmployeePersonalRequest.ECast = drpCast.Text;
                    EmployeePersonalRequest.Enationality = drpNationlity.Text;
                    EmployeePersonalRequest.EJoiningDate = ddJDate.Text;
                    EmployeePersonalRequest.EProbPeriod = txtProb.Text;
                    EmployeePersonalRequest.EConfirmDate = ddCDate.Text;
                    EmployeePersonalRequest.EResigningDate = ddRDate.Text;
                    EmployeePersonalRequest.ESelectWithReason = drpReason.Text;
                    //EmployeePersonalRequest.EPhoto = svgPhoto.Text;
                    EmployeePersonalRequest.Update();
                }
                #endregion

                #region Employee Finance Detail Update
                else if (tabIndex == 1)
                {
                    // Employee Finance Detail Update
                    //EmployeeFinanceRequest.FEmpId = Id.Text;
                    EmployeeFinanceRequest.FBankName = drpBName.Text;
                    EmployeeFinanceRequest.FAddress = txtAddress.Text;
                    EmployeeFinanceRequest.FSalaryAcNo = txtSalaryAC.Text;
                    EmployeeFinanceRequest.FPaymentMode = drpPayMode.Text;
                    EmployeeFinanceRequest.FAcType = txtACTypes.Text;
                    EmployeeFinanceRequest.FBankRefNo = txtBankRef.Text;
                    EmployeeFinanceRequest.FWard = txtWard.Text;
                    EmployeeFinanceRequest.FPolicyNo = txtPolicyNo.Text;
                    EmployeeFinanceRequest.FPolicyTerm = txtPolicyName.Text;
                    EmployeeFinanceRequest.FLicId = txtLic.Text;
                    EmployeeFinanceRequest.FARenewableDate = ddRDate.Text;
                    EmployeeFinanceRequest.FPfApplication = chPF.Text;
                    EmployeeFinanceRequest.FPfJoiningDate = ddPFJDate.Text;
                    EmployeeFinanceRequest.FPfNo = txtPFNo.Text;
                    EmployeeFinanceRequest.FPfLastDate = ddPFlastDate.Text;
                    EmployeeFinanceRequest.FPensionApplication = chPension.Text;
                    EmployeeFinanceRequest.FJoiningDate = ddJDate.Text;
                    EmployeeFinanceRequest.FEsiApplication = chESI.Text;
                    EmployeeFinanceRequest.FEsiJoiningDate = ddESIDate.Text;
                    EmployeeFinanceRequest.FEsiNo = txtBIEsiNo.Text;
                    EmployeeFinanceRequest.FEsiLastDate = ddESILastDate.Text;
                    EmployeeFinanceRequest.FLocalOffice = drpLOffice.Text;
                    EmployeeFinanceRequest.FEsiDespensary = drpESIDispensary.Text;
                    EmployeeFinanceRequest.Update();
                }
                #endregion

                #region Employee Family Detail Update
                else if (tabIndex == 2)
                {
                    // Employee Family Detail Update
                    //EmployeeFamilyRequest.EFEmpId = txtId.Text;
                    //EmployeeFamilyRequest.EFEmpCode = txtemp.Text;
                    EmployeeFamilyRequest.SNo = txtFSno.Text;
                    EmployeeFamilyRequest.EFName = txtFName.Text;
                    EmployeeFamilyRequest.EFAddress = txtFAddress.Text;
                    EmployeeFamilyRequest.EFArea = txtFArea.Text;
                    EmployeeFamilyRequest.EFDistrict = drpFDistrict.Text;
                    EmployeeFamilyRequest.EFState = drpFState.Text;
                    EmployeeFamilyRequest.EFPin = txtFPin.Text;
                    EmployeeFamilyRequest.EFRelation = txtFEmp.Text;
                    EmployeeFamilyRequest.EFDOB = ddFDOB.Text;
                    EmployeeFamilyRequest.EFAge = txtFAge.Text;
                    EmployeeFamilyRequest.EFResiding = drpResiding.Text;
                    EmployeeFamilyRequest.EFRemark = txtRemarks.Text;
                    EmployeeFamilyRequest.Update();
                }
                #endregion

                #region Nominee Detail Update
                else if (tabIndex == 3)
                {
                    //Employee Nominee Detail Update
                    //EmployeeNomineeReqest.ENEmpCode = txtId.Text;
                    //EmployeeNomineeReqest.ENEmpId = txtEmpId.Text;
                    EmployeeNomineeReqest.ENSno = txtNSno.Text;
                    EmployeeNomineeReqest.ENName = txtNname.Text;
                    EmployeeNomineeReqest.ENAddress = txtNAddress.Text;
                    EmployeeNomineeReqest.ENArea = txtNArea.Text;
                    EmployeeNomineeReqest.ENDistrict = drpNDistrict.Text;
                    EmployeeNomineeReqest.ENState = drpNState.Text;
                    EmployeeNomineeReqest.ENPin = txtNPin.Text;
                    EmployeeNomineeReqest.ENRelation = txtNEmp.Text;
                    EmployeeNomineeReqest.ENDob = ddNDOB.Text;
                    EmployeeNomineeReqest.ENAge = txtNAge.Text;
                    EmployeeNomineeReqest.ENResidence = drpNResiding.Text;
                    EmployeeNomineeReqest.ENgratuity = txtNGratuity.Text;
                    EmployeeNomineeReqest.ENMStatus = drpNMarital.Text;
                    EmployeeNomineeReqest.ENReligion = drpNReligion.Text;
                    EmployeeNomineeReqest.ENFName = txtNFathers.Text;
                    EmployeeNomineeReqest.ENGAddress = txtFAddress.Text;
                    EmployeeNomineeReqest.ENGRelation = txtGREmp.Text;
                    EmployeeNomineeReqest.Update();
                }
                #endregion


                if (EmployeePersonalRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(EmployeePersonalRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {

        }

        private void drpMCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpMCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtPName.Text = EmployeePersonalRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpCCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpCCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtCName.Text = EmployeePersonalRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpSCCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpSCCom.SelectedItem;

            if (selectedItem != null)
            {
                txtSCName.Text = EmployeePersonalRequest.SubClientCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }
    }
}