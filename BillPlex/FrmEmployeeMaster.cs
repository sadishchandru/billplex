﻿using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
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
    public partial class FrmEmployeeMaster : DevExpress.XtraEditors.XtraForm
    {
        private EmployeePersonal EmployeePersonalRequest;

        private EmployeeFinance EmployeeFinanceRequest;

        private EmployeeFamily EmployeeFamilyRequest;

        private EmployeeNominee EmployeeNomineeReqest;


        private List<dynamic> EmployeeFamilySource;

        private GridControl EmployeeGridControl;

        private DataTable dt;

        public FrmEmployeeMaster()
        {
            InitializeComponent();
            labelAvailable.Visible = false;
            labelCodeExist.Visible = false;
            InitializeGridControl();
            InitializeDataSource();

            EmployeePersonalRequest = new EmployeePersonal();
            EmployeeFinanceRequest = new EmployeeFinance();
            EmployeeFamilyRequest = new EmployeeFamily();
            EmployeeNomineeReqest = new EmployeeNominee();

            EmployeeFamilySource = new List<dynamic>();

            var connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            EmployeePersonalRequest.ConnectionString = connectionString;
            EmployeeFinanceRequest.ConnectionString = connectionString;
            EmployeeFamilyRequest.ConnectionString = connectionString;
            EmployeeNomineeReqest.ConnectionString = connectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true },
                    {"ClientCompanyRequired",true},
                    {"SubClientCompanyRequired",true},
                    {"EmployeePersonalRequired",true}
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
                if (item.Key == "EmployeePersonalRequired")
                {
                    EmployeePersonalRequest.EmployeeCodeList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (EmployeePersonalRequest.MasterCompanyList != null)
            {
                if (EmployeePersonalRequest.MasterCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in EmployeePersonalRequest.MasterCompanyList)
                    {
                        drpMCompany.Properties.Items.Add(item.Name);
                    }
                }
            }

            if (EmployeePersonalRequest.ClientCompanyList != null)
            {
                if (EmployeePersonalRequest.ClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in EmployeePersonalRequest.ClientCompanyList)
                    {
                        drpCCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }

            }
            if (EmployeePersonalRequest.SubClientCompanyList != null)
            {
                if (EmployeePersonalRequest.SubClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in EmployeePersonalRequest.SubClientCompanyList)
                    {
                        drpSCCom.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }

            }
        }

        private void InitializeGridControl()
        {
            FamilyGridControl = new GridControl();

            FamilyGridView = new GridView(FamilyGridControl);

            // Assign the GridView to the GridControl
            FamilyGridControl.MainView = FamilyGridView;
            //FamilyGridControl.ViewCollection.Add(FamilyGridView);


            // Add the GridControl to the form
            Controls.Add(FamilyGridControl);
        }

        private void InitializeDataSource()
        {
            FamilyGridView.Columns.Clear();

            // Create columns and bind them to the object properties
            FamilyGridView.Columns.AddVisible("SNo", "SNo");
            FamilyGridView.Columns.AddVisible("Name", "Name");
            FamilyGridView.Columns.AddVisible("Address", "Address");
            FamilyGridView.Columns.AddVisible("Area", "Area");
            FamilyGridView.Columns.AddVisible("District", "District");
            FamilyGridView.Columns.AddVisible("State", "State");
            FamilyGridView.Columns.AddVisible("Pin", "Pin");
            FamilyGridView.Columns.AddVisible("RelationEmployee", "RelationEmployee");
            FamilyGridView.Columns.AddVisible("DateOfBirth", "DateOfBirth");
            FamilyGridView.Columns.AddVisible("WhetherResiding", "WhetherResiding");
            FamilyGridView.Columns.AddVisible("Remarks", "Remarks");


            //// Create an empty DataTable with the desired column structure
            //dt = new DataTable();
            //dt.Columns.Add("SNo", typeof(string));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("Address", typeof(string));
            //dt.Columns.Add("Area", typeof(string));
            //dt.Columns.Add("District", typeof(string));
            //dt.Columns.Add("State", typeof(string));
            //dt.Columns.Add("Pin", typeof(string));
            //dt.Columns.Add("RelationEmployee", typeof(string));
            //dt.Columns.Add("DateOfBirth", typeof(string));
            //dt.Columns.Add("WhetherResiding", typeof(string));
            //dt.Columns.Add("Remarks", typeof(string));

            // Set the empty DataTaRemarksble as the data source for the GridView
            //FamilyGridControl.DataSource = dt;
            //FamilyGridView.DataSource = dataTable;

        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {

                var tabIndex = EmployeeMasterTab.SelectedTabPageIndex;
                #region Employee Personal Detail Update
                if (tabIndex == 0)
                {
                    if (txtEmpCode.Text != string.Empty && txtEmpName.Text != string.Empty)
                    {
                        if ((EmployeePersonalRequest.Id != 0 || labelAvailable.Visible == true) && labelCodeExist.Visible == false)
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

                            string selectedSubClientItem = (string)drpSCCom.SelectedItem;

                            if (selectedSubClientItem != null)
                            {
                                EmployeePersonalRequest.ESubClientCompany = EmployeePersonalRequest.SubClientCompanyList.FirstOrDefault(item => item.Name == selectedSubClientItem.ToString())?.Id ?? -1;
                            }

                            EmployeePersonalRequest.EProprietorName = txtPName.Text;
                            EmployeePersonalRequest.EClientName = txtCName.Text;
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
                            EmployeePersonalRequest.ECVillageArea = txtCArea.Text;
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

                            if (EmployeePersonalRequest.Result.Status == ResultStatus.Success)
                            {
                                this.Close();
                                XtraMessageBox.Show(EmployeePersonalRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FrmEmployeeMasterList form = Application.OpenForms.OfType<FrmEmployeeMasterList>().FirstOrDefault();

                                Form myForm = Application.OpenForms["FrmEmployeeMasterList"];
                                if (myForm != null)
                                {
                                    form.ReloadSqlDataSource();
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show(EmployeePersonalRequest.Result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Please check Code", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(EmployeePersonalRequest.Result.Message, "please give the manditory field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                #endregion

                #region Employee Finance Detail Update
                else if (tabIndex == 1)
                {
                    // Employee Finance Detail Update
                    EmployeeFinanceRequest.FEmpId = (int)EmployeePersonalRequest.Id;
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
                    EmployeeFinanceRequest.FPfApplication = chPF.Text == "" ? false : true;
                    EmployeeFinanceRequest.FPfJoiningDate = ddPFJDate.Text;
                    EmployeeFinanceRequest.FPfNo = txtPFNo.Text;
                    EmployeeFinanceRequest.FPfLastDate = ddPFlastDate.Text;
                    EmployeeFinanceRequest.FPensionApplication = chPension.Text == "" ? false : true;
                    EmployeeFinanceRequest.FJoiningDate = ddJDate.Text;
                    EmployeeFinanceRequest.FEsiApplication = chESI.Text == "" ? false : true;
                    EmployeeFinanceRequest.FEsiJoiningDate = ddESIDate.Text;
                    EmployeeFinanceRequest.FEsiNo = txtBIEsiNo.Text;
                    EmployeeFinanceRequest.FEsiLastDate = ddESILastDate.Text;
                    EmployeeFinanceRequest.FLocalOffice = drpLOffice.Text;
                    EmployeeFinanceRequest.FEsiDespensary = drpESIDispensary.Text;
                    EmployeeFinanceRequest.Update();

                    if (EmployeeFinanceRequest.Result.Status == ResultStatus.Success)
                    {
                        this.Close();
                        XtraMessageBox.Show(EmployeeFinanceRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmEmployeeMasterList form = Application.OpenForms.OfType<FrmEmployeeMasterList>().FirstOrDefault();
                        Form myForm = Application.OpenForms["FrmEmployeeMasterList"];
                        if (myForm != null)
                        {
                            form.ReloadSqlDataSource();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(EmployeeFinanceRequest.Result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

                    if (EmployeeFamilyRequest.Result.Status == ResultStatus.Success)
                    {
                        this.Close();
                        XtraMessageBox.Show(EmployeeFamilyRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmEmployeeMasterList form = Application.OpenForms.OfType<FrmEmployeeMasterList>().FirstOrDefault();
                        Form myForm = Application.OpenForms["FrmEmployeeMasterList"];
                        if (myForm != null)
                        {
                            form.ReloadSqlDataSource();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(EmployeeFamilyRequest.Result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

                    if (EmployeeNomineeReqest.Result.Status == ResultStatus.Success)
                    {
                        this.Close();
                        XtraMessageBox.Show(EmployeeNomineeReqest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmEmployeeMasterList form = Application.OpenForms.OfType<FrmEmployeeMasterList>().FirstOrDefault();
                        Form myForm = Application.OpenForms["FrmEmployeeMasterList"];
                        if (myForm != null)
                        {
                            form.ReloadSqlDataSource();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(EmployeeNomineeReqest.Result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion

            }
            catch (Exception ex)
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

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            drpMCompany.ResetText();
            drpCCompany.ResetText();
            drpSCCom.ResetText();
            txtPName.ResetText();
            txtCName.ResetText();
            txtSCName.ResetText();
            txtEmpCode.ResetText();
            txtEmpName.ResetText();
            txtVoterID.ResetText();
            txtDriving.ResetText();
            txtPANCard.ResetText();
            txtPassport.ResetText();
            txtIdentity.ResetText();
            txtPerAddress.ResetText();
            txtPerArea.ResetText();
            drpPState.ResetText();
            drpDistrict.ResetText();
            txtPinCode.ResetText();
            txtCPAddress.ResetText();
            txtCArea.ResetText();
            drpCDistrict.ResetText();
            drpState.ResetText();
            txtPPincode.ResetText();
            ddDOB.ResetText();
            radGender.ResetText();
            drpBlood.ResetText();
            txtEmailId.ResetText();
            txtMobile.ResetText();
            txtFathers.ResetText();
            txtMotherName.ResetText();
            drpMarital.ResetText();
            txtStdCode.ResetText();
            txtPhone.ResetText();
            drpReligion.ResetText();
            drpCast.ResetText();
            drpNationlity.ResetText();
            ddJDate.ResetText();
            txtProb.ResetText();
            ddCDate.ResetText();
            drpReason.ResetText();
            ddRDate.ResetText();
        }

        public void BindData(dynamic selectedClientCompanyList)
        {
            var selectedRows = selectedClientCompanyList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {

                // Employee Details
                EmployeePersonalRequest.Id = selectedClientCompanyList.GetRowCellValue(rowHandle, "Id");
                txtEmpCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "EmployeeCode");
                drpMCompany.SelectedIndex = EmployeePersonalRequest.MasterCompanyList.FindIndex(e => e.Id == Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "MasterCompanyId")));
                txtPName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ContractorName");

                //drpCCompany.SelectedIndex = Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "ClientCompanyId"));
                drpCCompany.SelectedIndex = EmployeePersonalRequest.ClientCompanyList.FindIndex(e => e.Id == Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "ClientCompanyId")));
                txtCName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ClientName");

                //drpSCCom.SelectedIndex = Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "SubCompanyId"));
                drpSCCom.SelectedIndex = EmployeePersonalRequest.SubClientCompanyList.FindIndex(e => e.Id == Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "SubCompanyId")));


                txtSCName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "SubCompanyName");
                txtEmpName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "EmployeeName");
                txtPerAddress.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PAddress");
                txtPerArea.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PArea");
                drpDistrict.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PDistrict");
                txtPinCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PPincode");
                drpPState.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PState");
                txtCPAddress.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CAddress");
                txtCArea.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CArea");
                drpCDistrict.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CDistrict");
                txtPPincode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CPincode");
                drpState.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CState");
                txtVoterID.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "VoterId");
                txtDriving.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "DrivingNo");
                txtPANCard.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Pan");
                txtPassport.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PassportNo");
                txtIdentity.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "IdentityMark");


                var datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "DoB").ToString();
                ddDOB.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";

                if (radGender.SelectedIndex != null && selectedClientCompanyList.GetRowCellValue(rowHandle, "Gender") != "")
                {
                    radGender.SelectedIndex = Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "Gender"));
                }

                drpBlood.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "BloodGroup");
                txtEmailId.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Email");
                txtFathers.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "FName");
                txtMotherName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "MName");
                drpMarital.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "MStatus");
                drpReligion.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Religion");
                drpCast.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Caste");
                drpNationlity.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Nationality");
                txtStdCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "SCode");
                txtPhone.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Phone");
                txtMobile.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Mobile");

                datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "EJoiningDate").ToString();
                ddJDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";


                txtProb.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "EProbationPeriod");

                datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "EConfirmationDate").ToString();
                ddCDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";

                datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "EResigningDate").ToString();
                ddRDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";

                drpReason.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Reason");

                int convertedValue = Convert.IsDBNull(selectedClientCompanyList.GetRowCellValue(rowHandle, "EmpId")) ? 0 : Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "EmpId"));
                // Finance Details 
                if (convertedValue != 0)
                {
                    EmployeeFinanceRequest.FEmpId = convertedValue;
                    //txtSCName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Id");
                    drpBName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "BankName");
                    txtAddress.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "BankAddress");
                    txtSalaryAC.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "SalaryNo");
                    drpPayMode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PaymentMode");
                    txtACTypes.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "AccountType");
                    txtBankRef.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "BankRef");
                    txtWard.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "Ward");
                    txtPolicyNo.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PolicyNo");
                    txtPolicyName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PolicyTerm");
                    txtLic.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "LicId");

                    var annualDate = selectedClientCompanyList.GetRowCellValue(rowHandle, "AnnualDate").ToString();
                    txtRDate.Text = annualDate != "" ? DateTime.Parse(annualDate).ToString("MM-dd-yyyy") : "";
                    chPF.Checked = selectedClientCompanyList.GetRowCellValue(rowHandle, "PFApplicable");
                    datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "PFJoiningDate").ToString();
                    ddPFJDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                    datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "PFLastDate").ToString();
                    ddPFlastDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                    txtPFNo.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PFNo");
                    chPension.Checked = selectedClientCompanyList.GetRowCellValue(rowHandle, "PensionApplicable");
                    datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "PensionJoiningDate").ToString();
                    ddPenDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                    chESI.Checked = selectedClientCompanyList.GetRowCellValue(rowHandle, "ESIApplicable");
                    datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "ESIJoiningDate").ToString();
                    ddESIDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                    txtBIEsiNo.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ESINo");
                    datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "ESILastDate").ToString();
                    ddESILastDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                    drpLOffice.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ESIOffice");
                    drpESIDispensary.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ESIDispensary");
                }               

            }

            if (EmployeePersonalRequest.Id > 0)
            {
                Addbtn.Enabled = false;
                Newbtn.Enabled = false;
                Updatebtn.Enabled = true;
                Deletebtn.Enabled = false;
                labelAvailable.Visible = false;
                labelCodeExist.Visible = false;
            }
            else if (EmployeeFinanceRequest.Id > 0)
            {
                Addbtn.Enabled = false;
                Newbtn.Enabled = false;
                Updatebtn.Enabled = true;
                Deletebtn.Enabled = false;
            }
            else
            {
                Addbtn.Enabled = true;
                Newbtn.Enabled = false;
                Updatebtn.Enabled = false;
                Deletebtn.Enabled = false;
            }

        }

        private void bntAddRow_Click(object sender, EventArgs e)
        {

            GridView gridView = FamilyGridView; // Replace gridView1 with the actual name of your GridView control

            // Retrieve textbox values
            string value1 = txtFSno.Text;
            string value2 = txtFName.Text;
            // Retrieve additional textbox values as needed

            // Add a new row to the GridView
            gridView.AddNewRow();

            // Set values for each column in the new row
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "Sno", value1);
            gridView.SetRowCellValue(gridView.FocusedRowHandle, "FName", value2);
            // Set values for additional columns as needed

            // End the row editing
            gridView.UpdateCurrentRow();

//          -----------------------------
            //// Retrieve textbox values
            //string value1 = txtFSno.Text;
            //string value2 = txtFName.Text;
            //// Retrieve additional textbox values as needed

            //// Create a new row object
            //EmployeeFamily newRow = new EmployeeFamily()
            //{
            //    SNo = value1,
            //    EFName = value2,
            //    // Set additional properties as needed
            //};

            //// Access the GridView's data source
            //List<EmployeeFamily> employeeFamilies = (List<EmployeeFamily>)FamilyGridControl.DataSource;

            //// Check if the data source is null or not assigned
            //if (employeeFamilies == null)
            //{
            //    // Create a new list and assign it as the data source
            //    employeeFamilies = new List<EmployeeFamily>();
            //    FamilyGridControl.DataSource = employeeFamilies;
            //}

            //// Add the new row object to the data source
            //employeeFamilies.Add(newRow);

            //// Refresh the GridView to reflect the changes
            //FamilyGridView.RefreshData();

            //// Clear the textboxes
            //txtFSno.Text = string.Empty;
            //txtFName.Text = string.Empty;
            //// Clear additional textboxes as needed

            //FamilyGridControl.DataSource = EmployeeFamilySource;
            //FamilyGridView.RefreshData();
        }

        private void txtEmpCode_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmpCode.Text != string.Empty)
            {
                if (EmployeePersonalRequest.EmployeeCodeList != null)
                {

                    //var IsCode = CompanyRequest.MasterCodeList.FirstOrDefault(item => item.Code == txtCode.Text.ToString())?.Id ?? 0;
                    var IsCode = EmployeePersonalRequest.EmployeeCodeList.FirstOrDefault(obj => obj.Code == txtEmpCode.Text.ToString() && obj.Id != EmployeePersonalRequest.Id);

                    if (IsCode != null)
                    {
                        labelAvailable.Visible = false;
                        labelCodeExist.Visible = true;
                    }
                    else
                    {
                        labelAvailable.Visible = true;
                        labelCodeExist.Visible = false;
                    }
                }
                else
                {
                    labelAvailable.Visible = true;
                    labelCodeExist.Visible = false;
                }

            }
            else
            {
                labelAvailable.Visible = false;
                labelCodeExist.Visible = false;
            }
        }
    }
}