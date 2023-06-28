//using DataLayer;
using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class FrmSubClientCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        //private readonly SqlConnector _conn;
        private SubClientCompanyInfo SubClientRequest;



        public FrmSubClientCompanyInfo()
        {
            InitializeComponent();



            // _conn = new SqlConnector(connectionString);

            SubClientRequest = new SubClientCompanyInfo();

            SubClientRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true },
                    {"ClientCompanyRequired",true},
                { "SubClientBankRequired", true}
                };
            //ClientCompanyRequest.MasterCompanyList = ClientCompanyRequest.GetDropdownValues(dropDownList);

            var dropdwonList = SubClientRequest.GetDropdownCollections(dropDownList);


            //SubClientRequest.MasterCompanyList = (List<DropDownItemInfo>)dropdwonList.Cast<Hashtable>()
            //              .Where(entry => entry.Keys == "MasterCompanyRequired")
            //              .Select(entry => entry.Value);


            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    SubClientRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "ClientCompanyRequired")
                {
                    SubClientRequest.ClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (SubClientRequest.MasterCompanyList != null)
            {
                if (SubClientRequest.MasterCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in SubClientRequest.MasterCompanyList)
                    {
                        drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }

            }

            if (SubClientRequest.ClientCompanyList != null)
            {
                if (SubClientRequest.ClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in SubClientRequest.ClientCompanyList)
                    {
                        drpCCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsertBankInfo_Click(object sender, EventArgs e)
        {
            FrmSubClientCompanyBankInfo fbankInfo = new FrmSubClientCompanyBankInfo();
            fbankInfo.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                if (drpMainCompany.Text != string.Empty && drpCCompany.Text != string.Empty && txtCompanyCode.Text != "" && txtCompanyName.Text != "" && 
                    (drpMainCompany.Text != string.Empty && drpMainCompany.Text != "Select") && (drpCCompany.Text != string.Empty && drpCCompany.Text != "Select"))

                {
                    string selectedMasterItem = (string)drpMainCompany.SelectedItem;

                    if (selectedMasterItem != null)
                    {
                        SubClientRequest.MainCompany = SubClientRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedMasterItem.ToString())?.Id ?? -1;
                    }
                    string selectedClientItem = (string)drpCCompany.SelectedItem;

                    if (selectedClientItem != null)
                    {
                        SubClientRequest.ClientCompany = SubClientRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedClientItem.ToString())?.Id ?? -1;
                    }
                    //SubClientRequest.MainCompany = drpMainCompany.Text;
                    SubClientRequest.Director = txtDirector.Text;
                    //SubClientRequest.ClientCompany = drpCCompany.Text;
                    SubClientRequest.ContractorName = txtContName.Text;
                    SubClientRequest.SubCompanyCode = txtCompanyCode.Text;
                    SubClientRequest.SubCompanyName = txtCompanyName.Text;
                    SubClientRequest.OfficeAddress = txtOffAddress.Text;
                    SubClientRequest.State = drpState.Text;
                    SubClientRequest.Pin = txtPin.Text;
                    SubClientRequest.BusinessNature = radBusinessNature.Text;
                    SubClientRequest.StartingDate = ddStartingDate.Text;
                    SubClientRequest.STDCode = txtOffPin.Text;
                    SubClientRequest.PhoneNo = txtOfficePhone.Text;
                    SubClientRequest.EmailId = txtEmail.Text;
                    SubClientRequest.Website = txtWebsite.Text;
                    SubClientRequest.PfType = radPfType.Text;
                    SubClientRequest.PFCode = txtPFCode.Text;
                    SubClientRequest.PFDate = ddPFDate.Text;
                    SubClientRequest.EsiCode = txtEsiCode.Text;
                    SubClientRequest.ESIDate = ddESIDate.Text;
                    SubClientRequest.FactoryActNo = txtFactoryAct.Text;
                    SubClientRequest.TinNo = txtTin.Text;
                    SubClientRequest.CstNo = txtCst.Text;
                    SubClientRequest.SsiNo = txtSsi.Text;
                    SubClientRequest.PanNo = txtPanNo.Text;
                    SubClientRequest.TanNo = txttan.Text;
                    SubClientRequest.LicenseNo = txtLicense.Text;
                    SubClientRequest.Name = txtName.Text;
                    SubClientRequest.FathersName = txtFathers.Text;
                    SubClientRequest.Gender = radGender.Text;
                    SubClientRequest.BloodGroup = drpAuthBlood.Text;
                    SubClientRequest.DOB = ddDOB.Text;
                    SubClientRequest.AuthEmailId = txtAuthEmailId.Text;
                    SubClientRequest.AuthAddress = txtAuthAddress.Text;
                    SubClientRequest.AuthState = drpAuthState.Text;
                    SubClientRequest.Authpin = txtAuthpin.Text;
                    SubClientRequest.AuthMobileNo = txtAuthMobileNo.Text;
                    SubClientRequest.AuthPanNo = txtAuthPanNo.Text;
                    SubClientRequest.AuthPercent = txtAuthPercent.Text;
                    SubClientRequest.ActiveStatus = radActiveStatus.Text;
                    SubClientRequest.Update();
                    //this.Close();

                    if (SubClientRequest.Result.Status == ResultStatus.Success)
                    {
                        XtraMessageBox.Show(SubClientRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();

                        FrmSubClientCompanyProfile form = Application.OpenForms.OfType<FrmSubClientCompanyProfile>().FirstOrDefault();

                        Form myForm = Application.OpenForms["FrmSubClientCompanyProfile"];
                        if (myForm != null)
                        {
                            form.ReloadSqlDataSource();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(SubClientRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    XtraMessageBox.Show("Please Enter Manditory field", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void drpDirector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //drpMainCompany.SelectedIndexChanged += drpMainCompany_SelectedIndexChanged;
        private void drpMainCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpMainCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtDirector.Text = SubClientRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpCCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpCCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtContName.Text = SubClientRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        public void BindData(dynamic selectedCompanyList)
        {
            var selectedRows = selectedCompanyList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                SubClientRequest.Id = selectedCompanyList.GetRowCellValue(rowHandle, "Id");
                //txtCompanyCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "MasterCode").toString() == DBNull.Value ? string.Empty : selectedCompanyList.GetRowCellValue(rowHandle, "MasterCode").ToString();

                //drpMainCompany.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "MasterCompanyId").ToString());
                drpMainCompany.SelectedIndex = SubClientRequest.MasterCompanyList.FindIndex(x => x.Id == Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "MasterCompanyId").ToString()));                //drpCCompany.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "ClientCompanyId").ToString());

                drpCCompany.SelectedIndex = SubClientRequest.ClientCompanyList.FindIndex(x => x.Id == Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "ClientCompanyId").ToString()));
                txtCompanyCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "SubComCode");
                txtCompanyName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "SubComName");
                txtOffAddress.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComOffAdd");
                drpState.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComState");
                txtPin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPin");
                if (radBusinessNature.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "ComNature") != "")
                    radBusinessNature.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "ComNature"));

                txtDirector.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Director");
                var datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComDatestart").ToString();

                ddStartingDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";

                txtOffPin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComStdCode");
                txtOfficePhone.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPhone");
                txtEmail.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComEmail");
                txtWebsite.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComWebsite");

                if (radPfType.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "PfType") != "")
                    radPfType.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "PfType"));
                txtPFCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPfNo");

                datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComPfDate").ToString();
                ddPFDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";

                txtEsiCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComEsiNo");

                datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComEsiDate").ToString();
                ddESIDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";

                txtFactoryAct.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComFactoryNo");
                txtCst.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComCstNo");
                txtSsi.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComSslNo");
                txtTin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComTinNo");
                txtLicense.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComLicenseno");
                txtPanNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPanNo");
                txttan.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComTanNo");
                txtName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorName");
                txtFathers.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");

                if (radGender.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "AuthorGender") != "")
                    radGender.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "AuthorGender"));

                drpAuthBlood.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorBlood");

                datete = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorDOB").ToString();
                ddDOB.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";

                txtAuthEmailId.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorEmail");
                txtAuthAddress.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorAddress");
                drpAuthState.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorState");
                txtAuthpin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorPin");
                txtAuthMobileNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorMobile");
                txtAuthPanNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorPan");
                txtAuthPercent.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorPercent");

                if (radActiveStatus.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "AuthorActive") != "")
                    radActiveStatus.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "AuthorActive"));
            }

            if (SubClientRequest.SubClientBankList != null)
            {
                foreach (DropDownItemInfo item in SubClientRequest.SubClientBankList)
                {
                    if (item.Code == SubClientRequest.Id.ToString())
                    {
                        txtBankDetails.Text = string.Join(Environment.NewLine, item.Name);
                    }
                }
                txtBankDetails.Enabled = false;
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = false;
            btnUpdate.Enabled = true;
            btnEdit.Enabled = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            drpMainCompany.ResetText();
            txtDirector.ResetText();
            drpCCompany.ResetText();
            txtContName.ResetText();
            txtCompanyCode.ResetText();
            txtCompanyName.ResetText();
            txtOffAddress.ResetText();
            drpState.ResetText();
            txtPin.ResetText();
            radBusinessNature.ResetText();
            ddStartingDate.ResetText();
            txtOffPin.ResetText();
            txtOfficePhone.ResetText();
            txtEmail.ResetText();
            txtWebsite.ResetText();
            radPfType.ResetText();
            txtPFCode.ResetText();
            ddPFDate.ResetText();
            txtEsiCode.ResetText();
            ddESIDate.ResetText();
            txtFactoryAct.ResetText();
            txtTin.ResetText();
            txtCst.ResetText();
            txtSsi.ResetText();
            txtPanNo.ResetText();
            txttan.ResetText();
            txtLicense.ResetText();
            txtName.ResetText();
            txtFathers.ResetText();
            radGender.ResetText();
            drpAuthBlood.ResetText();
            ddDOB.ResetText();
            txtAuthEmailId.ResetText();
            txtAuthAddress.ResetText();
            drpAuthState.ResetText();
            txtAuthpin.ResetText();
            txtAuthMobileNo.ResetText();
            txtAuthPanNo.ResetText();
            txtAuthPercent.ResetText();
            radActiveStatus.ResetText();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}