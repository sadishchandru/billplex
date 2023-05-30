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
    public partial class FrmCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        private readonly SqlConnector _conn;
        public FrmCompanyInfo()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            _conn = new SqlConnector(connectionString);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmCompanyProfileBankInfo CP = new FrmCompanyProfileBankInfo();
            CP.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {


            // Calling the stored procedure for creating a new Company Profile
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ComCcode", txtCode.Text),
            new SqlParameter("@ComName", txtCompanyName.Text),
            new SqlParameter("@ComOffAdd", txtOfficeAddress.Text),
            new SqlParameter("@Comstate", drpState.Text),
            new SqlParameter("@ComPin", txtPinNo.Text),
            new SqlParameter("@ComNature", txtOffice.Text),
            new SqlParameter("@ComDatestart", ddStartingdate.Text),
            new SqlParameter("@ComStdCode", radBusinessNature.Text),
            new SqlParameter("", txtEmail.Text),
            new SqlParameter("", txtWebsite.Text),
            new SqlParameter("", txtPFCode.Text),
            new SqlParameter("", ddPfDate.Text),
            new SqlParameter("", txtEsiCode.Text),
            new SqlParameter("", ddEsiDate.Text),
            new SqlParameter("", txtFactoryAct.Text),
            new SqlParameter("", txtTin.Text),
            new SqlParameter("", txtCSTNo.Text),
            new SqlParameter("", txtSSINo.Text),
            new SqlParameter("", txtPanNo.Text),
            new SqlParameter("", txtTanNo.Text),
            new SqlParameter("", txtLicense.Text),
            new SqlParameter("", txtName.Text),
            new SqlParameter("", txtFathersName.Text),
            new SqlParameter("", radGender.Text),
            new SqlParameter("", txtAddress.Text),
            new SqlParameter("", ddAuthstartingdate.Text),
            new SqlParameter("", txtAuthorPin.Text),
            new SqlParameter("", txtAuthorPhoneNo.Text),
            new SqlParameter("", txtAuthorBloodGroup.Text),
            new SqlParameter("", ddAuthDOB.Text),
            new SqlParameter("", txtAuthorEmailId.Text),
            new SqlParameter("", txtAuthorMobileNo.Text),
            new SqlParameter("", txtAuthorPanNo.Text)
           // new SqlParameter("", drpAuthorStartingdate.Text),

            };

           var i =  _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
        //    string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        //    SqlConnector con = new SqlConnector(connectionString);

        //    // Example of calling the stored procedure for creating a new user
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //    new SqlParameter("@ComCcode", txtCodeEdit.Text),
        //    new SqlParameter("@ComName", txtCompanyNameEdit.Text),
        //    new SqlParameter("@ComOffAdd", txtOfficeAddress.Text),
        //    new SqlParameter("@Comstate", drpState.Text),
        //    new SqlParameter("@ComPin", txtPinNo.Text),
        //    new SqlParameter("@ComNature", txtOffice.Text),
        //    new SqlParameter("@ComDatestart", drpStartingDate.Text),
        //    new SqlParameter("@ComStdCode", radBusinessNature.Text),
        //    new SqlParameter("", txtEmail.Text),
        //    new SqlParameter("", txtWebsite.Text),
        //    new SqlParameter("", txtPFCode.Text),
        //    new SqlParameter("", drpPFDate.Text),
        //    new SqlParameter("", txtEsiCode.Text),
        //    new SqlParameter("", drpESIDate.Text),
        //    new SqlParameter("", txtFactoryAct.Text),
        //    new SqlParameter("", txtTin.Text),
        //    new SqlParameter("", txtCSTNo.Text),
        //    new SqlParameter("", txtSSINo.Text),
        //    new SqlParameter("", txtPanNo.Text),
        //    new SqlParameter("", txtTanNo.Text),
        //    new SqlParameter("", txtLicense.Text),

        //    };

        //    con.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
       }
    }
}