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
            // Calling the stored procedure for creating a new Company Profile
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ComCcode", drpMainCompany.Text),
            new SqlParameter("@ComName", drpDirector.Text),
            new SqlParameter("@ComOffAdd", txtCompanyCode.Text),
            new SqlParameter("@Comstate", txtCompanyName.Text),
            new SqlParameter("@ComPin", txtOffAddress.Text),
            new SqlParameter("@ComNature", drpState.Text),
            new SqlParameter("@ComDatestart", txtPin.Text),
            new SqlParameter("@ComStdCode", radBusinessNature.Text),
            new SqlParameter("", ddStartingDate.Text),
            new SqlParameter("", txtClientCompanyPhone.Text),
            new SqlParameter("", txtEmail.Text),
            new SqlParameter("", txtWebsite.Text),
            new SqlParameter("", radPfType.Text),
            new SqlParameter("", txtPFCode.Text),
            new SqlParameter("", ddPfDate.Text),
            new SqlParameter("", txtEsiCode.Text),
            new SqlParameter("", ddEsiCode.Text),
            new SqlParameter("", txtFactoryAct.Text),
            new SqlParameter("", txtTin.Text),
            new SqlParameter("", txtCst.Text),
            new SqlParameter("", txtSsi.Text),
            new SqlParameter("", txtPanNo.Text),
            new SqlParameter("", txtTan.Text),
            new SqlParameter("", LicenseTxt.Text),
            new SqlParameter("", txtName.Text),
            new SqlParameter("", txtFathers.Text),
            new SqlParameter("", radGender.Text),
            new SqlParameter("", DrpBloodGroup.Text),
            new SqlParameter("", ddDOB.Text),
            new SqlParameter("", txtEmailID.Text),
            new SqlParameter("", TxtAuthAddress.Text),
            new SqlParameter("", drpAuthState.Text),
            new SqlParameter("", txtAuthpin.Text),
            new SqlParameter("", txtmobile.Text),
            new SqlParameter("", txtAuthPanNo.Text),
            new SqlParameter("", txtPercent.Text),
            new SqlParameter("", radActiveStatus.Text),
            new SqlParameter("", txtBankDetails.Text)
           // new SqlParameter("", drpAuthorStartingdate.Text),

            };

            var i = _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        }

        private void MainCompanyDd_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //    string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //    SqlConnector con = new SqlConnector(connectionString);
            // Calling the stored procedure for creating a new Company Profile
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //new SqlParameter("@ComCcode", drpMainCompany.Text),
            //new SqlParameter("@ComName", drpDirector.Text),
            //new SqlParameter("@ComOffAdd", txtCompanyCode.Text),
            //new SqlParameter("@Comstate", txtCompanyName.Text),
            //new SqlParameter("@ComPin", txtOffAddress.Text),
            //new SqlParameter("@ComNature", drpState.Text),
            //new SqlParameter("@ComDatestart", txtPin.Text),
            //new SqlParameter("@ComStdCode", radBusinessNature.Text),
            //new SqlParameter("", drpStartingDate.Text),
            //new SqlParameter("", txtClientCompanyPhone.Text),
            //new SqlParameter("", txtEmail.Text),
            //new SqlParameter("", txtWebsite.Text),
            //new SqlParameter("", radPfType.Text),
            //new SqlParameter("", txtPFCode.Text),
            //new SqlParameter("", drpPfDate.Text),
            //new SqlParameter("", txtEsiCode.Text),
            //new SqlParameter("", drpEsiDate.Text),
            //new SqlParameter("", txtFactoryAct.Text),
            //new SqlParameter("", txtTin.Text),
            //new SqlParameter("", txtCst.Text),
            //new SqlParameter("", txtSsi.Text),
            //new SqlParameter("", txtPanNo.Text),
            //new SqlParameter("", txtTan.Text),
            //new SqlParameter("", LicenseTxt.Text)
             //};

        //    con.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        }
    }
}