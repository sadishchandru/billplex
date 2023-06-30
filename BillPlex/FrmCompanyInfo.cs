//using DataLayer;
using BusinessLayer;
using DevExpress.XtraEditors;
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
    public partial class FrmCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _conn;

        private CompanyMasterInfo CompanyRequest;

        private List<string> masterCodeList;
        //private readonly SqlConnector _conn;
        public FrmCompanyInfo()
        {
            InitializeComponent();
            CompanyRequest = new CompanyMasterInfo();
            CompanyRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            CompanyRequest.Result = new ResultDetail();

            masterCodeList = new List<string>();

            labelAvailable.Visible = false;
            labelCodeExist.Visible = false;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true },
                    { "MasterBankRequired", true }
                };

            var dropdwonList = CompanyRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    CompanyRequest.MasterCodeList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "MasterBankRequired")
                {
                    CompanyRequest.MasterBankList = (List<DropDownItemInfo>)item.Value;
                }
            }

            //if (CompanyRequest.MasterCodeList != null)
            //{

            //    if (CompanyRequest.MasterCodeList.Count() > 0)
            //    {
            //        foreach (DropDownItemInfo item in CompanyRequest.MasterCodeList)
            //        {
            //            drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
            //        }
            //    }
            //}

            //CompanyRequest.MasterBankList = CompanyRequest.GetDropdownValues(dropDownList);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmCompanyProfileBankInfo CP = new FrmCompanyProfileBankInfo();
            CP.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text != string.Empty && txtCompanyName.Text != string.Empty && txtName.Text != string.Empty)
                {
                    if (labelAvailable.Visible == true && labelCodeExist.Visible == false)
                    {

                        CompanyRequest.Code = txtCode.Text;
                        CompanyRequest.CompanyName = txtCompanyName.Text;
                        CompanyRequest.OffAddress = txtOfficeAddress.Text;
                        CompanyRequest.State = drpState.Text;
                        CompanyRequest.StatePin = txtPinNo.Text;
                        CompanyRequest.StdCode = txtStdCode.Text;
                        CompanyRequest.PhoneNo = txtPhoneNo.Text;
                        CompanyRequest.Startingdate = ddStartingdate.Text.ToString();
                        CompanyRequest.BusinessNature = radBusinessNature.Text;
                        CompanyRequest.EmailID = txtEmail.Text;
                        CompanyRequest.Website = txtWebsite.Text;
                        CompanyRequest.PFCode = txtPFCode.Text;
                        CompanyRequest.PfDate = ddPfDate.Text.ToString();
                        CompanyRequest.EsiCode = txtEsiCode.Text;
                        CompanyRequest.EsiDate = ddEsiDate.Text.ToString();
                        CompanyRequest.FactoryAct = txtFactoryAct.Text;
                        CompanyRequest.TinNo = txtTin.Text;
                        CompanyRequest.CSTNo = txtCSTNo.Text;
                        CompanyRequest.SSINo = txtSSINo.Text;
                        CompanyRequest.PanNo = txtPanNo.Text;
                        CompanyRequest.TanNo = txtTanNo.Text;
                        CompanyRequest.LicenseNo = txtLicense.Text;
                        CompanyRequest.Name = txtName.Text;
                        CompanyRequest.FathersName = txtFathersName.Text;
                        CompanyRequest.Gender = radGender.Text;
                        CompanyRequest.Address = txtAddress.Text;
                        CompanyRequest.AuthState = drpAuthState.Text;
                        CompanyRequest.AuthPin = txtAuthorPin.Text;
                        CompanyRequest.AuthStdCode = txtAuthorStdCode.Text;
                        CompanyRequest.AuthPhoneNo = txtAuthorPhoneNo.Text;
                        CompanyRequest.AuthorBloodGroup = drpAuthBlood.Text;
                        CompanyRequest.DOB = ddAuthDOB.Text.ToString();
                        CompanyRequest.AuthEmail = txtAuthorEmailId.Text;
                        CompanyRequest.AuthMobile = txtAuthorMobileNo.Text;
                        CompanyRequest.AuthorPanNo = txtAuthorPanNo.Text;
                        CompanyRequest.Update();

                        if (CompanyRequest.Result.Status == ResultStatus.Success)
                        {
                            XtraMessageBox.Show(CompanyRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                            FrmCompanyProfile form = Application.OpenForms.OfType<FrmCompanyProfile>().FirstOrDefault();

                            Form myForm = Application.OpenForms["FrmCompanyProfile"];
                            if (myForm != null)
                            {
                                form.ReloadSqlDataSource();
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show(CompanyRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    } else
                    {
                        XtraMessageBox.Show("Please check Code", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //  this.Close();
                }
                else
                {
                    XtraMessageBox.Show("please Enter the manditory field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BindData(dynamic selectedCompanyList)
        {
            var selectedRows = selectedCompanyList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                CompanyRequest.Id = selectedCompanyList.GetRowCellValue(rowHandle, "Id");
                txtCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComCcode");
                txtOfficeAddress.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComOffAdd");
                drpState.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Comstate");
                txtPinNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPin");
                var datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComDatestart").ToString();
                ddStartingdate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                if (radBusinessNature.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "ComNature") != "")
                {
                    radBusinessNature.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "ComNature"));
                }
                txtStdCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComStdCode");
                txtPhoneNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPhone");
                txtEmail.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComEmail");
                txtWebsite.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComWebsite");
                txtPFCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPFno");

                datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComPFdate").ToString();
                ddPfDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                txtEsiCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComESIno");
                datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComESIdate").ToString();
                ddEsiDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                txtFactoryAct.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComFactoryNo");
                txtCSTNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComCSTno");
                txtSSINo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComSSLno");
                txtTin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComTINno");
                txtLicense.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComLicenseno");
                txtPanNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPanno");
                txtTanNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComTanno");
                txtCompanyName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComName");
                txtName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAuthorName");
                txtFathersName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAFathername");
                if (radGender.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "CAGender") != "")
                {
                    radGender.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "CAGender"));
                }
                txtAddress.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAAddress");
                drpAuthState.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAstate");
                txtAuthorPin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CApin");
                txtAuthorStdCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAStdCode");
                txtAuthorPhoneNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAPhoneno");
                txtAuthorMobileNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAMobile");
                drpAuthBlood.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAblood");
                datete = selectedCompanyList.GetRowCellValue(rowHandle, "CADOB").ToString();
                ddAuthDOB.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                txtAuthorEmailId.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAEmail");
                txtAuthorPanNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAPan");
            }

            if (CompanyRequest.MasterBankList != null)
            {
                if (CompanyRequest.MasterBankList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in CompanyRequest.MasterBankList)
                    {
                        if (item.Code == CompanyRequest.Id.ToString())
                        {
                            txtBankDetails.Text = string.Join(Environment.NewLine, item.Name);
                        }
                    }
                    txtBankDetails.Enabled = false;
                }

            }
            txtCode.Enabled = false;
            txtCompanyName.Enabled = true;
            btnAdd.Enabled = false;
            BtnNew.Enabled = false;
            btnUpdate.Enabled = true;
            labelAvailable.Visible = false;
            labelCodeExist.Visible = false;
        }

        void dropdownvalidate()
        {
            drpState.SelectedIndex = 0;
            drpAuthBlood.SelectedIndex = 0;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //CompanyRequest.Id = 0;
            txtCode.ResetText();
            txtCompanyName.ResetText();
            txtOfficeAddress.ResetText();
            drpState.ResetText();
            txtPinNo.ResetText();
            txtCode.ResetText();
            txtPhoneNo.ResetText();
            ddStartingdate.ResetText();
            radBusinessNature.ResetText();
            txtEmail.ResetText();
            txtWebsite.ResetText();
            txtPFCode.ResetText();
            ddPfDate.ResetText();
            txtEsiCode.ResetText();
            ddEsiDate.ResetText();
            txtFactoryAct.ResetText();
            txtTin.ResetText();
            txtCSTNo.ResetText();
            txtSSINo.ResetText();
            txtPanNo.ResetText();
            txtTanNo.ResetText();
            txtLicense.ResetText();
            txtName.ResetText();
            txtFathersName.ResetText();
            radGender.ResetText();
            txtAddress.ResetText();
            drpAuthState.ResetText();
            txtAuthorPin.ResetText();
            txtAuthorStdCode.ResetText();
            txtAuthorPhoneNo.ResetText();
            drpAuthBlood.ResetText();
            ddAuthDOB.ResetText();
            txtAuthorEmailId.ResetText();
            txtAuthorMobileNo.ResetText();
            txtAuthorPanNo.ResetText();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClearBtn_Click(object sender, EventArgs e)
        {
            txtAddress.ResetText();
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string textToCopy = txtAddress.Text;
                Clipboard.SetText(textToCopy);
                MessageBox.Show("Text copied to clipboard.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while copying text: " + ex.Message);
            }
        }

        private void txtCode_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCode.Text != string.Empty)
            {
                if (CompanyRequest.MasterCodeList != null)
                {

                    //var IsCode = CompanyRequest.MasterCodeList.FirstOrDefault(item => item.Code == txtCode.Text.ToString())?.Id ?? 0;
                    var IsCode = CompanyRequest.MasterCodeList.FirstOrDefault(obj => obj.Code == txtCode.Text.ToString() && obj.Id != CompanyRequest.Id);

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