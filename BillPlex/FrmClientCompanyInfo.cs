using DataLayer;
using DevExpress.XtraEditors;
using System;
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
        private readonly SqlConnector _conn;
        public FrmClientCompanyInfo()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            _conn = new SqlConnector(connectionString);
        }

        private void InsertBankInfoBtn_Click(object sender, EventArgs e)
        {
            FrmClientCompanyBankInfo Cs = new FrmClientCompanyBankInfo();
            Cs.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            // Calling the stored procedure for creating a new Company Profile
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MasterCompanyId", drpMainCompany.Text),
                new SqlParameter("@", drpDirector.Text),
                new SqlParameter("@ComCcode", txtCompanyCode.Text),
                new SqlParameter("@ComCname", txtCompanyName.Text),
                new SqlParameter("@ComCoffAddress", txtOffAddress.Text),
                new SqlParameter("@ComCstate", drpAuthState.Text),
                new SqlParameter("@ComCpin", txtPin.Text),
                new SqlParameter("@ComCNature",selectedValue),
                new SqlParameter("@ComCDatestart", ddStartingDate.Text.ToString()),
                new SqlParameter("@ComStdcode", stdCodeTxt.Text),
                new SqlParameter("@ComCPhone", txtClientCompanyPhone.Text),
                new SqlParameter("@ComCEmail", txtEmail.Text),
                new SqlParameter("@ComCWebsite", txtWebsite.Text),
                new SqlParameter("@PfType", radPfType.Text.ToString()),
                new SqlParameter("@ComCPFno", txtPFCode.Text),
                new SqlParameter("@ComCPFdate", ddPfDate.Text.ToString()),
                new SqlParameter("@ComCESIno", txtEsiCode.Text),
                new SqlParameter("@ComCESIdate", ddEsiCode.Text.ToString()),
                new SqlParameter("@ComCFactoryno", txtFactoryAct.Text),
                new SqlParameter("@ComCTINno", txtTin.Text),
                new SqlParameter("@ComCCSTno", txtCst.Text),
                new SqlParameter("@ComCSSLno", txtSsi.Text),
                new SqlParameter("@ComCPanno", txtPanNo.Text),
                new SqlParameter("@ComCTanno", txtTan.Text),
                new SqlParameter("@ComCLicenseno", LicenseTxt.Text),
                new SqlParameter("@ComCPname", txtName.Text),
                new SqlParameter("@CCPFathername", txtFathers.Text),
                new SqlParameter("@CCPGender", radGender.Text.ToString()),
                new SqlParameter("@CCPblood", drpAuthBloodGroup.Text),
                new SqlParameter("@CCPDOB", ddDOB.Text.ToString()),
                new SqlParameter("@CCPEmail", txtEmailID.Text),
                new SqlParameter("@CCPAddress", TxtAuthAddress.Text),
                new SqlParameter("@CCPstate", drpAuthState.Text),
                new SqlParameter("@CCPpin", txtAuthpin.Text),
                new SqlParameter("@CCPMobile", txtmobile.Text),
                new SqlParameter("@CCPPan", txtAuthPanNo.Text),
                new SqlParameter("@CCPpercent", txtPercent.Text),
                new SqlParameter("@CCPactive", radActiveStatus.Text.ToString()),
                new SqlParameter("@CCPFathername", txtBankDetails.Text),
                new SqlParameter("@CCPImage",AuthImg.SvgImage)
                // new SqlParameter("", drpAuthorStartingdate.Text),

            };

            var i = _conn.ExecuteNonQuery("PRO_UpdateClientCompanyProfileInfo", parameters);
        }

        private void MainCompanyDd_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var Id = 0;

            string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            // Calling the stored procedure for creating a new Company Profile
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MasterCompanyId", drpMainCompany.Text),
                new SqlParameter("@", drpDirector.Text),
                new SqlParameter("@ComCcode", txtCompanyCode.Text),
                new SqlParameter("@ComCname", txtCompanyName.Text),
                new SqlParameter("@ComCoffAddress", txtOffAddress.Text),
                new SqlParameter("@ComCstate", drpAuthState.Text),
                new SqlParameter("@ComCpin", txtPin.Text),
                new SqlParameter("@ComCNature",selectedValue),
                new SqlParameter("@ComCDatestart", ddStartingDate.Text.ToString()),
                new SqlParameter("@ComStdcode", stdCodeTxt.Text),
                new SqlParameter("@ComCPhone", txtClientCompanyPhone.Text),
                new SqlParameter("@ComCEmail", txtEmail.Text),
                new SqlParameter("@ComCWebsite", txtWebsite.Text),
                new SqlParameter("@PfType", radPfType.Text.ToString()),
                new SqlParameter("@ComCPFno", txtPFCode.Text),
                new SqlParameter("@ComCPFdate", ddPfDate.Text.ToString()),
                new SqlParameter("@ComCESIno", txtEsiCode.Text),
                new SqlParameter("@ComCESIdate", ddEsiCode.Text.ToString()),
                new SqlParameter("@ComCFactoryno", txtFactoryAct.Text),
                new SqlParameter("@ComCTINno", txtTin.Text),
                new SqlParameter("@ComCCSTno", txtCst.Text),
                new SqlParameter("@ComCSSLno", txtSsi.Text),
                new SqlParameter("@ComCPanno", txtPanNo.Text),
                new SqlParameter("@ComCTanno", txtTan.Text),
                new SqlParameter("@ComCLicenseno", LicenseTxt.Text),
                new SqlParameter("@ComCPname", txtName.Text),
                new SqlParameter("@CCPFathername", txtFathers.Text),
                new SqlParameter("@CCPGender", radGender.Text.ToString()),
                new SqlParameter("@CCPblood", drpAuthBloodGroup.Text),
                new SqlParameter("@CCPDOB", ddDOB.Text.ToString()),
                new SqlParameter("@CCPEmail", txtEmailID.Text),
                new SqlParameter("@CCPAddress", TxtAuthAddress.Text),
                new SqlParameter("@CCPstate", drpAuthState.Text),
                new SqlParameter("@CCPpin", txtAuthpin.Text),
                new SqlParameter("@CCPMobile", txtmobile.Text),
                new SqlParameter("@CCPPan", txtAuthPanNo.Text),
                new SqlParameter("@CCPpercent", txtPercent.Text),
                new SqlParameter("@CCPactive", radActiveStatus.Text.ToString()),
                new SqlParameter("@CCPFathername", txtBankDetails.Text),
                new SqlParameter("@CCPImage", AuthImg.SvgImage)
             };

            var i = _conn.ExecuteNonQuery("PRO_UpdateClientCompanyProfileInfo", parameters);
        }
    }
}