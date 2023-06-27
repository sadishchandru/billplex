//using DataLayer;
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
    public partial class FrmClientCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        //private readonly SqlConnector _conn;
        private ClientCompanyInfo ClientCompanyRequest;
        public FrmClientCompanyInfo()

        {
            InitializeComponent();
            // string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // _conn = new SqlConnector(connectionString);

            ClientCompanyRequest = new ClientCompanyInfo();

            ClientCompanyRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true },
                    { "ClientMasterBankRequired", true }
                };
            //ClientCompanyRequest.MasterCompanyList = ClientCompanyRequest.GetDropdownValues(dropDownList);

            var dropdwonList = ClientCompanyRequest.GetDropdownCollections(dropDownList);


            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    ClientCompanyRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "ClientMasterBankRequired")
                {
                    ClientCompanyRequest.ClientBankList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (ClientCompanyRequest.MasterCompanyList != null)
            {

                if (ClientCompanyRequest.MasterCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in ClientCompanyRequest.MasterCompanyList)
                    {
                        drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }

            //if (ClientCompanyRequest.ClientBankList != null)
            //{

            //    if (ClientCompanyRequest.ClientBankList.Count() > 0)
            //    {
            //        foreach (DropDownItemInfo item in ClientCompanyRequest.ClientBankList)
            //        {
            //            drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
            //        }
            //    }
            //}



            dropdownvalidate();
        }

        private void InsertBankInfoBtn_Click(object sender, EventArgs e)
        {
            FrmClientCompanyBankInfo Cs = new FrmClientCompanyBankInfo();
            Cs.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtCompanyCode.Text != string.Empty || txtCompanyCode.Text != "Select") && txtCompanyName.Text != string.Empty && txtName.Text != string.Empty)
                {

                    var selectedItem = drpMainCompany.EditValue;
                    var selectedItems = drpMainCompany.Text;

                    if (selectedItem != null)
                    {
                        ClientCompanyRequest.MainCompany = ClientCompanyRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.Id ?? -1;
                    }


                    ClientCompanyRequest.Director = txtDirector.Text;
                    ClientCompanyRequest.CompanyCode = txtCompanyCode.Text;
                    ClientCompanyRequest.CompanyName = txtCompanyName.Text;
                    ClientCompanyRequest.OffAddress = txtOffAddress.Text;
                    ClientCompanyRequest.State = drpState.Text;
                    ClientCompanyRequest.Pin = txtPin.Text;
                    ClientCompanyRequest.BusinessNature = radBusinessNature.Text;
                    ClientCompanyRequest.Startingdate = ddStartingDate.Text.ToString();
                    ClientCompanyRequest.stdCode = txtstdCode.Text;
                    ClientCompanyRequest.CompanyPhone = txtClientCompanyPhone.Text;
                    ClientCompanyRequest.Email = txtEmail.Text;
                    ClientCompanyRequest.Website = txtWebsite.Text;
                    ClientCompanyRequest.PfType = radPfType.Text;
                    ClientCompanyRequest.PFCode = txtPFCode.Text;
                    ClientCompanyRequest.PFdate = ddPfDate.Text.ToString();
                    ClientCompanyRequest.EsiCode = txtEsiCode.Text;
                    ClientCompanyRequest.ESIdate = ddEsiCode.Text.ToString();
                    ClientCompanyRequest.FactoryAct = txtFactoryAct.Text;
                    ClientCompanyRequest.Tin = txtTin.Text;
                    ClientCompanyRequest.CSTno = txtCst.Text;
                    ClientCompanyRequest.Ssi = txtSsi.Text;
                    ClientCompanyRequest.PanNo = txtPanNo.Text;
                    ClientCompanyRequest.Tan = txtTan.Text;
                    ClientCompanyRequest.License = LicenseTxt.Text;
                    ClientCompanyRequest.Name = txtName.Text;
                    ClientCompanyRequest.Fathername = txtFathers.Text;
                    ClientCompanyRequest.Gender = radGender.Text;
                    ClientCompanyRequest.AuthBloodGroup = drpAuthBloodGroup.Text;
                    ClientCompanyRequest.DOB = ddDOB.Text.ToString();
                    ClientCompanyRequest.AuthEmail = txtEmailID.Text;
                    ClientCompanyRequest.AuthAddress = TxtAuthAddress.Text;
                    ClientCompanyRequest.AuthState = drpAuthState.Text;
                    ClientCompanyRequest.Authpin = txtAuthpin.Text;
                    ClientCompanyRequest.mobile = txtmobile.Text;
                    ClientCompanyRequest.AuthPanNo = txtAuthPanNo.Text;
                    ClientCompanyRequest.Percent = txtPercent.Text;
                    ClientCompanyRequest.ActiveStatus = radActiveStatus.Text;
                    ClientCompanyRequest.Update();
                    //this.Close();

                    FrmClientCompanyProfile CompanyInfo = new FrmClientCompanyProfile();
                    //CompanyInfo.MdiParent = this;
                    CompanyInfo.FrmClientCompanyProfile_Load(sender, e);
                }
                else
                {
                    XtraMessageBox.Show(ClientCompanyRequest.Result.Message, "please give the manditory field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //if (ClientCompanyRequest.CompanyCode == string.Empty)
                //{
                //    XtraMessageBox.Show(ClientCompanyRequest.Result.Message, "please Select Main Company", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}

                if (ClientCompanyRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(ClientCompanyRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                // Display a warning alert
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };
        }

        private void MainCompanyDd_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
        }

        private void drpMainCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpMainCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtDirector.Text = ClientCompanyRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        public void BindData(dynamic selectedClientCompanyList)
        {
            var selectedRows = selectedClientCompanyList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                ClientCompanyRequest.Id = selectedClientCompanyList.GetRowCellValue(rowHandle, "Id");
                //txtDirector.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "");
                txtCompanyCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCcode");
                txtCompanyName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCname");
                txtOffAddress.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCoffAddress");
                drpState.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCstate");
                //drpMainCompany.SelectedIndex = Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "MasterCompanyId"));
                drpMainCompany.SelectedIndex = ClientCompanyRequest.MasterCompanyList.FindIndex(x => x.Id == Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "MasterCompanyId")));
                
                txtPin.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPin");
                if (radBusinessNature.SelectedIndex != null && selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCNature") != "")
                {
                    radBusinessNature.SelectedIndex = Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCNature"));
                }
                //radBusinessNature.DataBindings.Add("radBusinessNature", selectedClientCompanyList, "ComCNature", true, DataSourceUpdateMode.OnPropertyChanged);
                var datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCDatestart").ToString();
                ddStartingDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                txtstdCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComStdCode");
                txtClientCompanyPhone.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPhone");
                txtEmail.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCEmail");
                txtWebsite.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCWebsite");
                if (radPfType.SelectedIndex != null && selectedClientCompanyList.GetRowCellValue(rowHandle, "PfType") != "")
                {
                    radPfType.SelectedIndex = Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "PfType"));
                }
                txtPFCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPFno");
                datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPFdate").ToString();
                ddPfDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                txtEsiCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCESIno");
                datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCESIdate").ToString();
                ddEsiCode.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                txtFactoryAct.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCFactoryNo");
                txtTin.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCTINno");
                txtCst.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCCSTno");
                txtSsi.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCSSLno");
                txtPanNo.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPanno");
                txtTan.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCTanno");
                LicenseTxt.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCLicenseno");
                txtName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPname");
                txtFathers.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPFathername");
                if (radGender.SelectedIndex != null && selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPGender") != "")
                {
                    radGender.SelectedIndex = Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPGender"));
                }
                drpAuthBloodGroup.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPblood");
                datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPDOB").ToString();
                ddDOB.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                txtEmailID.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPEmail");
                TxtAuthAddress.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPAddress");
                drpAuthState.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPstate");
                txtAuthpin.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPpin");
                txtmobile.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPMobile");
                txtAuthPanNo.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPPan");
                txtPercent.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPpercent");
                if (radActiveStatus.SelectedIndex != null && selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPactive") != "")
                {
                    radActiveStatus.SelectedIndex = Convert.ToInt32(selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPactive"));
                }
            }

            if (ClientCompanyRequest.ClientBankList != null)
            {
                foreach (DropDownItemInfo item in ClientCompanyRequest.ClientBankList)
                {
                    if (item.Code == ClientCompanyRequest.Id.ToString())
                    {
                        txtBankDetails.Text = string.Join(Environment.NewLine, item.Name);
                    }
                }
                txtBankDetails.Enabled = false;
            }

            btnAdd.Enabled = false;
            EditBtn.Enabled = false;
            UpdateBtn.Enabled = true;
        }

        void dropdownvalidate()
        {
            drpMainCompany.SelectedIndex = 0;
            drpState.SelectedIndex = 0;
            drpAuthBloodGroup.SelectedIndex = 0;
            drpAuthState.SelectedIndex = 0;


        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtDirector.ResetText();
            txtCompanyCode.ResetText();
            txtCompanyName.ResetText();
            txtOffAddress.ResetText();
            drpState.ResetText();
            txtPin.ResetText();
            radBusinessNature.ResetText();
            ddStartingDate.ResetText();
            txtstdCode.ResetText();
            txtClientCompanyPhone.ResetText();
            txtEmail.ResetText();
            txtWebsite.ResetText();
            radPfType.ResetText();
            txtPFCode.ResetText();
            ddPfDate.ResetText();
            txtEsiCode.ResetText();
            ddEsiCode.ResetText();
            txtFactoryAct.ResetText();
            txtTin.ResetText();
            txtCst.ResetText();
            txtSsi.ResetText();
            txtPanNo.ResetText();
            txtTan.ResetText();
            LicenseTxt.ResetText();
            txtName.ResetText();
            txtFathers.ResetText();
            radGender.ResetText();
            drpAuthBloodGroup.ResetText();
            ddDOB.ResetText();
            txtEmailID.ResetText();
            TxtAuthAddress.ResetText();
            drpAuthState.ResetText();
            txtAuthpin.ResetText();
            txtmobile.ResetText();
            txtAuthPanNo.ResetText();
            txtPercent.ResetText();
            radActiveStatus.ResetText();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthCopyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string textToCopy = TxtAuthAddress.Text;
                Clipboard.SetText(textToCopy);
                MessageBox.Show("Text copied to clipboard.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while copying text: " + ex.Message);
            }
        }

        private void AuthAddClearBtn_Click(object sender, EventArgs e)
        {
            TxtAuthAddress.ResetText();
        }
    }
}