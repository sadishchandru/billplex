using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
//using DataLayer;

namespace BillPlex
{
    public partial class FrmSubClientCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        //private readonly SqlConnector _conn;
        public FrmSubClientCompanyInfo()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
           // _conn = new SqlConnector(connectionString);
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
            string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            //Calling the stored procedure for creating a new Company Profile




           SqlParameter[] parameters = new SqlParameter[]
           {
            new SqlParameter("@MasterCode", drpMainCompany.Text),
            new SqlParameter("@MasterCompanyId", txtCompanyName.Text),
            new SqlParameter("@ClientCompanyId", drpClientCompany.Text),
            new SqlParameter("@SubComCode", txtCompanyCode.Text),
            new SqlParameter("@SubComName", txtCompanyName.Text),
            new SqlParameter("@ComOffAddress", txtOffAddress.Text),
            new SqlParameter("@ComState", drpState.Text),
            new SqlParameter("@ComPin", txtPin.Text),
            new SqlParameter("@ComNature", selectedValue),
            new SqlParameter("@Director", txtEmail.Text),
            new SqlParameter("@ComStartDate", ddStartingDate.Text.ToString()),
            new SqlParameter("@ComStdCode", txtOffPin.Text),
            new SqlParameter("@ComPhone", txtOfficePhone.Text),
            new SqlParameter("@ComEmail", txtEmail.Text),
            new SqlParameter("@ComWebsite", txtWebsite.Text),
            new SqlParameter("@PFType", radPfType.Text),
            new SqlParameter("@ComPFNo", txtPFCode.Text),
            new SqlParameter("@ComPfDate", ddPFDate.Text.ToString()),
            new SqlParameter("@ComEsiNo", txtEsiCode.Text),
            new SqlParameter("@ComEsiDate", ddESIDate.Text),
            new SqlParameter("@ComFactoryNo", txtFactoryAct.Text),
            new SqlParameter("@ComCstNo", txtCst.Text),
            new SqlParameter("@ComSslNo", txtSsi.Text),
            new SqlParameter("@ComTinNo", txtTin.Text),
            new SqlParameter("@ComLicenseno", selectedValue),
            new SqlParameter("@ComPanNo", txtPanNo.Text),
            new SqlParameter("@ComTan_no", txttan.Text.ToString()),
            new SqlParameter("@AuthorName", txtName.Text),
            new SqlParameter("@AuthorFathername", txtFathers.Text),
            new SqlParameter("@AuthorGender", radGender.Text),
            new SqlParameter("@AuthorBlood", drpbloodGrop.Text),
            new SqlParameter("@AuthorDOB", ddDOB.Text.ToString()),
            new SqlParameter("@AuthorEmail", txtAuthEmailId.Text),
            new SqlParameter("@AuthorAddress", txtAuthAddress.Text),
            new SqlParameter("@AuthorState", drpAuthState.Text),
            new SqlParameter("@AuthorPin", txtAuthpin.Text),
            new SqlParameter("@AuthorMobile", txtAuthMobileNo.Text),
            new SqlParameter("@AuthorPan", txtAuthPanNo.Text),
            new SqlParameter("@AuthorPercent", txtAuthPercent.Text),
            new SqlParameter("@AuthorActive",radActiveStatus.Text),
            //new SqlParameter("@AuthorImage", AuthImg.Text),
           // new SqlParameter("@BankName", txtBankDetails.Text),
           // new SqlParameter("@BankAcNo", txtBankDetails.Text),
            //new SqlParameter("@BankAddress", txtBankDetails.Text)
           };

           // var i = _conn.ExecuteNonQuery("PRO_UpdateSubClientCompanyProfileInfo", parameters);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Id = 0;
            string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            // Calling the stored procedure for creating a new Company Profile
            SqlParameter[] parameters = new SqlParameter[]
           {
            new SqlParameter("@MasterCode", drpMainCompany.Text),
            new SqlParameter("@MasterCompanyId", txtCompanyName.Text),
            new SqlParameter("@ClientCompanyId", drpClientCompany.Text),
            new SqlParameter("@SubComCode", txtCompanyCode.Text),
            new SqlParameter("@SubComName", txtCompanyName.Text),
            new SqlParameter("@ComOffAddress", txtOffAddress.Text),
            new SqlParameter("@ComState", drpState.Text),
            new SqlParameter("@ComPin", txtPin.Text),
            new SqlParameter("@ComNature", selectedValue),
            new SqlParameter("@Director", txtEmail.Text),
            new SqlParameter("@ComStartDate", ddStartingDate.Text.ToString()),
            new SqlParameter("@ComStdCode", txtOffPin.Text),
            new SqlParameter("@ComPhone", txtOfficePhone.Text),
            new SqlParameter("@ComEmail", txtEmail.Text),
            new SqlParameter("@ComWebsite", txtWebsite.Text),
            new SqlParameter("@PFType", radPfType.Text),
            new SqlParameter("@ComPFNo", txtPFCode.Text),
            new SqlParameter("@ComPfDate", ddPFDate.Text.ToString()),
            new SqlParameter("@ComEsiNo", txtEsiCode.Text),
            new SqlParameter("@ComEsiDate", ddESIDate.Text),
            new SqlParameter("@ComFactoryNo", txtFactoryAct.Text),
            new SqlParameter("@ComCstNo", txtCst.Text),
            new SqlParameter("@ComSslNo", txtSsi.Text),
            new SqlParameter("@ComTinNo", txtTin.Text),
            new SqlParameter("@ComLicenseno", selectedValue),
            new SqlParameter("@ComPanNo", txtPanNo.Text),
            new SqlParameter("@ComTan_no", txttan.Text.ToString()),
            new SqlParameter("@AuthorName", txtName.Text),
            new SqlParameter("@AuthorFathername", txtFathers.Text),
            new SqlParameter("@AuthorGender", radGender.Text),
            new SqlParameter("@AuthorBlood", drpbloodGrop.Text),
            new SqlParameter("@AuthorDOB", ddDOB.Text.ToString()),
            new SqlParameter("@AuthorEmail", txtAuthEmailId.Text),
            new SqlParameter("@AuthorAddress", txtAuthAddress.Text),
            new SqlParameter("@AuthorState", drpAuthState.Text),
            new SqlParameter("@AuthorPin", txtAuthpin.Text),
            new SqlParameter("@AuthorMobile", txtAuthMobileNo.Text),
            new SqlParameter("@AuthorPan", txtAuthPanNo.Text),
            new SqlParameter("@AuthorPercent", txtAuthPercent.Text),
            new SqlParameter("@AuthorActive",radActiveStatus.Text),
            //new SqlParameter("@AuthorImage", AuthImg.Text),
           // new SqlParameter("@BankName", txtBankDetails.Text),
           // new SqlParameter("@BankAcNo", txtBankDetails.Text),
            //new SqlParameter("@BankAddress", txtBankDetails.Text)
           };

           // var i = _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        }
    }
}