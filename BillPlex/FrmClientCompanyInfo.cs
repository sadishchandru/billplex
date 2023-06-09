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
            Hashtable dropdownlist =  ClientCompanyRequest.GetDropdownValues(dropDownList);

            foreach (DictionaryEntry item in dropdownlist)
            {
                drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Value.ToString(), item.Key));
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
                ClientCompanyRequest.MainCompany = drpMainCompany.Text;
                ClientCompanyRequest.Director = drpDirector.Text;
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
    }
}