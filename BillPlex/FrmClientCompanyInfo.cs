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
                    { "MasterCompanyRequired", true }
                };
            //ClientCompanyRequest.MasterCompanyList = ClientCompanyRequest.GetDropdownValues(dropDownList);

            var dropdwonList = ClientCompanyRequest.GetDropdownCollections(dropDownList);


            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    ClientCompanyRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (ClientCompanyRequest.MasterCompanyList.Count() > 0)
            {
                foreach (DropDownItemInfo item in ClientCompanyRequest.MasterCompanyList)
                {
                    drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                }
            }
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
                ClientCompanyRequest.Startingdate = ddStartingDate.Text;
                ClientCompanyRequest.stdCode = txtstdCode.Text;
                ClientCompanyRequest.CompanyPhone = txtClientCompanyPhone.Text;
                ClientCompanyRequest.Email = txtEmail.Text;
                ClientCompanyRequest.Website = txtWebsite.Text;
                ClientCompanyRequest.PfType = radPfType.Text;
                ClientCompanyRequest.PFCode = txtPFCode.Text;
                ClientCompanyRequest.PFdate = ddPfDate.Text;
                ClientCompanyRequest.EsiCode = txtEsiCode.Text;
                ClientCompanyRequest.ESIdate = ddEsiCode.Text;
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
                ClientCompanyRequest.DOB = ddDOB.Text;
                ClientCompanyRequest.AuthEmail = txtEmailID.Text;
                ClientCompanyRequest.AuthAddress = TxtAuthAddress.Text;
                ClientCompanyRequest.AuthState = drpAuthState.Text;
                ClientCompanyRequest.Authpin = txtAuthpin.Text;
                ClientCompanyRequest.mobile = txtmobile.Text;
                ClientCompanyRequest.AuthPanNo = txtAuthPanNo.Text;
                ClientCompanyRequest.Percent = txtPercent.Text;
                ClientCompanyRequest.ActiveStatus = radActiveStatus.Text;
                ClientCompanyRequest.Update();

                if (ClientCompanyRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(ClientCompanyRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if(ClientCompanyRequest.CompanyCode == string.Empty)
                {
                    XtraMessageBox.Show(ClientCompanyRequest.Result.Message, "please Select Main Company", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Display a warning alert
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            // Calling the stored procedure for creating a new Company Profile
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@MasterCompanyId", drpMainCompany.Text),
            //    new SqlParameter("@", drpDirector.Text),
            //    new SqlParameter("@ComCcode", txtCompanyCode.Text),
            //    new SqlParameter("@ComCname", txtCompanyName.Text),
            //    new SqlParameter("@ComCoffAddress", txtOffAddress.Text),
            //    new SqlParameter("@ComCstate", drpAuthState.Text),
            //    new SqlParameter("@ComCpin", txtPin.Text),
            //    new SqlParameter("@ComCNature",selectedValue),
            //    new SqlParameter("@ComCDatestart", ddStartingDate.Text.ToString()),
            //    new SqlParameter("@ComStdcode", stdCodeTxt.Text),
            //    new SqlParameter("@ComCPhone", txtClientCompanyPhone.Text),
            //    new SqlParameter("@ComCEmail", txtEmail.Text),
            //    new SqlParameter("@ComCWebsite", txtWebsite.Text),
            //    new SqlParameter("@PfType", radPfType.Text.ToString()),
            //    new SqlParameter("@ComCPFno", txtPFCode.Text),
            //    new SqlParameter("@ComCPFdate", ddPfDate.Text.ToString()),
            //    new SqlParameter("@ComCESIno", txtEsiCode.Text),
            //    new SqlParameter("@ComCESIdate", ddEsiCode.Text.ToString()),
            //    new SqlParameter("@ComCFactoryno", txtFactoryAct.Text),
            //    new SqlParameter("@ComCTINno", txtTin.Text),
            //    new SqlParameter("@ComCCSTno", txtCst.Text),
            //    new SqlParameter("@ComCSSLno", txtSsi.Text),
            //    new SqlParameter("@ComCPanno", txtPanNo.Text),
            //    new SqlParameter("@ComCTanno", txtTan.Text),
            //    new SqlParameter("@ComCLicenseno", LicenseTxt.Text),
            //    new SqlParameter("@ComCPname", txtName.Text),
            //    new SqlParameter("@CCPFathername", txtFathers.Text),
            //    new SqlParameter("@CCPGender", radGender.Text.ToString()),
            //    new SqlParameter("@CCPblood", drpAuthBloodGroup.Text),
            //    new SqlParameter("@CCPDOB", ddDOB.Text.ToString()),
            //    new SqlParameter("@CCPEmail", txtEmailID.Text),
            //    new SqlParameter("@CCPAddress", TxtAuthAddress.Text),
            //    new SqlParameter("@CCPstate", drpAuthState.Text),
            //    new SqlParameter("@CCPpin", txtAuthpin.Text),
            //    new SqlParameter("@CCPMobile", txtmobile.Text),
            //    new SqlParameter("@CCPPan", txtAuthPanNo.Text),
            //    new SqlParameter("@CCPpercent", txtPercent.Text),
            //    new SqlParameter("@CCPactive", radActiveStatus.Text.ToString()),
            //    new SqlParameter("@CCPFathername", txtBankDetails.Text),
            //    new SqlParameter("@CCPImage",AuthImg.SvgImage)
                // new SqlParameter("", drpAuthorStartingdate.Text),

            //};

            // var i = _conn.ExecuteNonQuery("PRO_UpdateClientCompanyProfileInfo", parameters);
        }

        private void MainCompanyDd_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //var Id = 0;

            //string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            // Calling the stored procedure for creating a new Company Profile
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@MasterCompanyId", drpMainCompany.Text),
            //    new SqlParameter("@", drpDirector.Text),
            //    new SqlParameter("@ComCcode", txtCompanyCode.Text),
            //    new SqlParameter("@ComCname", txtCompanyName.Text),
            //    new SqlParameter("@ComCoffAddress", txtOffAddress.Text),
            //    new SqlParameter("@ComCstate", drpAuthState.Text),
            //    new SqlParameter("@ComCpin", txtPin.Text),
            //    new SqlParameter("@ComCNature",selectedValue),
            //    new SqlParameter("@ComCDatestart", ddStartingDate.Text.ToString()),
            //    new SqlParameter("@ComStdcode", stdCodeTxt.Text),
            //    new SqlParameter("@ComCPhone", txtClientCompanyPhone.Text),
            //    new SqlParameter("@ComCEmail", txtEmail.Text),
            //    new SqlParameter("@ComCWebsite", txtWebsite.Text),
            //    new SqlParameter("@PfType", radPfType.Text.ToString()),
            //    new SqlParameter("@ComCPFno", txtPFCode.Text),
            //    new SqlParameter("@ComCPFdate", ddPfDate.Text.ToString()),
            //    new SqlParameter("@ComCESIno", txtEsiCode.Text),
            //    new SqlParameter("@ComCESIdate", ddEsiCode.Text.ToString()),
            //    new SqlParameter("@ComCFactoryno", txtFactoryAct.Text),
            //    new SqlParameter("@ComCTINno", txtTin.Text),
            //    new SqlParameter("@ComCCSTno", txtCst.Text),
            //    new SqlParameter("@ComCSSLno", txtSsi.Text),
            //    new SqlParameter("@ComCPanno", txtPanNo.Text),
            //    new SqlParameter("@ComCTanno", txtTan.Text),
            //    new SqlParameter("@ComCLicenseno", LicenseTxt.Text),
            //    new SqlParameter("@ComCPname", txtName.Text),
            //    new SqlParameter("@CCPFathername", txtFathers.Text),
            //    new SqlParameter("@CCPGender", radGender.Text.ToString()),
            //    new SqlParameter("@CCPblood", drpAuthBloodGroup.Text),
            //    new SqlParameter("@CCPDOB", ddDOB.Text.ToString()),
            //    new SqlParameter("@CCPEmail", txtEmailID.Text),
            //    new SqlParameter("@CCPAddress", TxtAuthAddress.Text),
            //    new SqlParameter("@CCPstate", drpAuthState.Text),
            //    new SqlParameter("@CCPpin", txtAuthpin.Text),
            //    new SqlParameter("@CCPMobile", txtmobile.Text),
            //    new SqlParameter("@CCPPan", txtAuthPanNo.Text),
            //    new SqlParameter("@CCPpercent", txtPercent.Text),
            //    new SqlParameter("@CCPactive", radActiveStatus.Text.ToString()),
            //    new SqlParameter("@CCPFathername", txtBankDetails.Text),
            //    new SqlParameter("@CCPImage", AuthImg.SvgImage)
            // };

            // var i = _conn.ExecuteNonQuery("PRO_UpdateClientCompanyProfileInfo", parameters);
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
                txtPin.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCpin");
                radBusinessNature.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCNature");
                var datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCDatestart");
                ddStartingDate.Text = datete.ToString();
                txtstdCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComStdcode");
                txtClientCompanyPhone.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPhone");
                txtEmail.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCEmail");
                txtWebsite.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCWebsite");
                radPfType.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "PfType");
                txtPFCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPFno");
                var datetes = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPFdate");
                ddPfDate.Text = datetes.ToString();
                txtEsiCode.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCESIno");
                datete = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCESIdate");
                ddEsiCode.Text = datete.ToString();
                txtFactoryAct.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCFactoryno");
                txtTin.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCTINno");
                txtCst.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCCSTno");
                txtSsi.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCSSLno");
                txtPanNo.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPanno");
                txtTan.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCTanno");
                LicenseTxt.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCLicenseno");
                txtName.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "ComCPname");
                txtFathers.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPFathername");
                radGender.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPGender");
                drpAuthBloodGroup.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPblood");
                var dateted = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPDOB");
                ddDOB.Text = dateted.ToString();
                txtEmailID.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPEmail");
                TxtAuthAddress.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPAddress");
                drpAuthState.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPstate");
                txtAuthpin.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPpin");
                txtmobile.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPMobile");
                txtAuthPanNo.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPPan");
                txtPercent.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPpercent");
                radActiveStatus.Text = selectedClientCompanyList.GetRowCellValue(rowHandle, "CCPactive");
            }

            btnAdd.Enabled = false;
            EditBtn.Enabled = false;
            UpdateBtn.Enabled = true;
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
    }
}