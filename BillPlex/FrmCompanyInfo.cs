//using DataLayer;
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
    public partial class FrmCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        //private readonly SqlConnector _conn;
        public FrmCompanyInfo()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            //_conn = new SqlConnector(connectionString);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmCompanyProfileBankInfo CP = new FrmCompanyProfileBankInfo();
            CP.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            // Calling the stored procedure for creating a new Company Profile



            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ComCcode", txtCode.Text),
            new SqlParameter("@ComName", txtCompanyName.Text),
            new SqlParameter("@ComOffAdd", txtOfficeAddress.Text),
            new SqlParameter("@Comstate", drpState.Text),
            new SqlParameter("@ComPin", txtPinNo.Text),
            new SqlParameter("@ComStdCode", txtStdCode.Text),
            new SqlParameter("@ComPhone", txtPhoneNo.Text),
            new SqlParameter("@ComDatestart", ddStartingdate.Text.ToString()),
            new SqlParameter("@ComNature", selectedValue),
            new SqlParameter("@ComEmail", txtEmail.Text),
            new SqlParameter("@ComWebsite", txtWebsite.Text),
            new SqlParameter("@ComPFno", txtPFCode.Text),
            new SqlParameter("@ComPFdate", ddPfDate.Text.ToString()),
            new SqlParameter("@ComESIno", txtEsiCode.Text),
            new SqlParameter("@ComESIdate", ddEsiDate.Text.ToString()),
            new SqlParameter("@ComFactoryNo", txtFactoryAct.Text),
            new SqlParameter("@ComTINno", txtTin.Text),
            new SqlParameter("@ComCSTno", txtCSTNo.Text),
            new SqlParameter("@ComSSLno", txtSSINo.Text),
            new SqlParameter("@ComPanno", txtPanNo.Text),
            new SqlParameter("@ComTanno", txtTanNo.Text),
            new SqlParameter("@ComLicenseno", txtLicense.Text),
            new SqlParameter("@CAuthorName", txtName.Text),
            new SqlParameter("@CAFathername", txtFathersName.Text),
            new SqlParameter("@CAGender", selectedValue),
            new SqlParameter("@CAAddress", txtAddress.Text),
            new SqlParameter("@CAstate", ddAuthstartingdate.Text.ToString()),
            new SqlParameter("@CApin", txtAuthorPin.Text),
            new SqlParameter("@CAStdCode", txtAuthorStdCode.Text),
            new SqlParameter("@CAPhoneno", txtAuthorPhoneNo.Text),
            new SqlParameter("@CAblood", txtAuthorBloodGroup.Text),
            new SqlParameter("@CADOB", ddAuthDOB.Text.ToString()),
            new SqlParameter("@CAEmail", txtAuthorEmailId.Text),
            new SqlParameter("@CAMobile", txtAuthorMobileNo.Text),
            new SqlParameter("@CAPan", txtAuthorPanNo.Text)
            };

            //var i = _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var Id = 0;
            string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";
            // Calling the stored procedure for creating a new Company Profile
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", Id),
            new SqlParameter("@ComCcode", txtCode.Text),
            new SqlParameter("@ComName", txtCompanyName.Text),
            new SqlParameter("@ComOffAdd", txtOfficeAddress.Text),
            new SqlParameter("@Comstate", drpState.Text),
            new SqlParameter("@ComPin", txtPinNo.Text),
            new SqlParameter("@ComStdCode", txtStdCode.Text),
            new SqlParameter("@ComPhone", txtPhoneNo.Text),
            new SqlParameter("@ComDatestart", ddStartingdate.Text.ToString()),
            new SqlParameter("@ComNature", selectedValue),
            new SqlParameter("@ComEmail", txtEmail.Text),
            new SqlParameter("@ComWebsite", txtWebsite.Text),
            new SqlParameter("@ComPFno", txtPFCode.Text),
            new SqlParameter("@ComPFdate", ddPfDate.Text.ToString()),
            new SqlParameter("@ComESIno", txtEsiCode.Text),
            new SqlParameter("@ComESIdate", ddEsiDate.Text.ToString()),
            new SqlParameter("@ComFactoryNo", txtFactoryAct.Text),
            new SqlParameter("@ComTINno", txtTin.Text),
            new SqlParameter("@ComCSTno", txtCSTNo.Text),
            new SqlParameter("@ComSSLno", txtSSINo.Text),
            new SqlParameter("@ComPanno", txtPanNo.Text),
            new SqlParameter("@ComTanno", txtTanNo.Text),
            new SqlParameter("@ComLicenseno", txtLicense.Text),
            new SqlParameter("@CAuthorName", txtName.Text),
            new SqlParameter("@CAFathername", txtFathersName.Text),
            new SqlParameter("@CAGender", selectedValue),
            new SqlParameter("@CAAddress", txtAddress.Text),
            new SqlParameter("@CAstate", ddAuthstartingdate.Text.ToString()),
            new SqlParameter("@CApin", txtAuthorPin.Text),
            new SqlParameter("@CAStdCode", txtAuthorStdCode.Text),
            new SqlParameter("@CAPhoneno", txtAuthorPhoneNo.Text),
            new SqlParameter("@CAblood", txtAuthorBloodGroup.Text),
            new SqlParameter("@CADOB", ddAuthDOB.Text.ToString()),
            new SqlParameter("@CAEmail", txtAuthorEmailId.Text),
            new SqlParameter("@CAMobile", txtAuthorMobileNo.Text),
            new SqlParameter("@CAPan", txtAuthorPanNo.Text)
            };

            //var i = _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        }
    }
}