//using DataLayer;
using BusinessLayer;
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
        private readonly string _conn;

        private CompanyMasterInfo CompanyRequest;
        //private readonly SqlConnector _conn;
        public FrmCompanyInfo()
        {
            InitializeComponent();
            //string connectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            //_conn = new SqlConnector(connectionString);
            CompanyRequest = new CompanyMasterInfo();
            CompanyRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
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
                CompanyRequest.Code = txtCode.Text;
                CompanyRequest.CompanyName = txtCompanyName.Text;
                CompanyRequest.OffAddress = txtAddress.Text;
                CompanyRequest.State = drpState.Text;
                CompanyRequest.StatePin = txtPinNo.Text;
                CompanyRequest.StdCode = txtCode.Text;
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
                CompanyRequest.AuthStartingDate = ddAuthstartingdate.Text.ToString();
                CompanyRequest.AuthPin = txtAuthorPin.Text;
                CompanyRequest.AuthStdCode = txtAuthorStdCode.Text;
                CompanyRequest.AuthPhoneNo = txtAuthorPhoneNo.Text;
                CompanyRequest.AuthorBloodGroup = txtAuthorBloodGroup.Text;
                CompanyRequest.DOB = ddAuthDOB.Text.ToString();
                CompanyRequest.AuthEmail = txtAuthorEmailId.Text;
                CompanyRequest.AuthMobile = txtAuthorMobileNo.Text;
                CompanyRequest.AuthorPanNo = txtAuthorPanNo.Text;
                CompanyRequest.Update();

                if (CompanyRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(CompanyRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            // Calling the stored procedure for creating a new Company Profile



            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //new SqlParameter("@ComCcode", txtCode.Text),
            //new SqlParameter("@ComName", txtCompanyName.Text),
            //new SqlParameter("@ComOffAdd", txtOfficeAddress.Text),
            //new SqlParameter("@Comstate", drpState.Text),
            //new SqlParameter("@ComPin", txtPinNo.Text),
            //new SqlParameter("@ComStdCode", txtStdCode.Text),
            //new SqlParameter("@ComPhone", txtPhoneNo.Text),
            //new SqlParameter("@ComDatestart", ddStartingdate.Text.ToString()),
            //new SqlParameter("@ComNature", selectedValue),
            //new SqlParameter("@ComEmail", txtEmail.Text),
            //new SqlParameter("@ComWebsite", txtWebsite.Text),
            //new SqlParameter("@ComPFno", txtPFCode.Text),
            //new SqlParameter("@ComPFdate", ddPfDate.Text.ToString()),
            //new SqlParameter("@ComESIno", txtEsiCode.Text),
            //new SqlParameter("@ComESIdate", ddEsiDate.Text.ToString()),
            //new SqlParameter("@ComFactoryNo", txtFactoryAct.Text),
            //new SqlParameter("@ComTINno", txtTin.Text),
            //new SqlParameter("@ComCSTno", txtCSTNo.Text),
            //new SqlParameter("@ComSSLno", txtSSINo.Text),
            //new SqlParameter("@ComPanno", txtPanNo.Text),
            //new SqlParameter("@ComTanno", txtTanNo.Text),
            //new SqlParameter("@ComLicenseno", txtLicense.Text),
            //new SqlParameter("@CAuthorName", txtName.Text),
            //new SqlParameter("@CAFathername", txtFathersName.Text),
            //new SqlParameter("@CAGender", selectedValue),
            //new SqlParameter("@CAAddress", txtAddress.Text),
            //new SqlParameter("@CAstate", ddAuthstartingdate.Text.ToString()),
            //new SqlParameter("@CApin", txtAuthorPin.Text),
            //new SqlParameter("@CAStdCode", txtAuthorStdCode.Text),
            //new SqlParameter("@CAPhoneno", txtAuthorPhoneNo.Text),
            //new SqlParameter("@CAblood", txtAuthorBloodGroup.Text),
            //new SqlParameter("@CADOB", ddAuthDOB.Text.ToString()),
            //new SqlParameter("@CAEmail", txtAuthorEmailId.Text),
            //new SqlParameter("@CAMobile", txtAuthorMobileNo.Text),
            //new SqlParameter("@CAPan", txtAuthorPanNo.Text)
            //};

            //var i = _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        }

        //private void UpdateBtn_Click(object sender, EventArgs e)
        //{
        //    var Id = 0;
        //    string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";
        //    // Calling the stored procedure for creating a new Company Profile
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //    new SqlParameter("@Id", Id),
        //    new SqlParameter("@ComCcode", txtCode.Text),
        //    new SqlParameter("@ComName", txtCompanyName.Text),
        //    new SqlParameter("@ComOffAdd", txtOfficeAddress.Text),
        //    new SqlParameter("@Comstate", drpState.Text),
        //    new SqlParameter("@ComPin", txtPinNo.Text),
        //    new SqlParameter("@ComStdCode", txtStdCode.Text),
        //    new SqlParameter("@ComPhone", txtPhoneNo.Text),
        //    new SqlParameter("@ComDatestart", ddStartingdate.Text.ToString()),
        //    new SqlParameter("@ComNature", selectedValue),
        //    new SqlParameter("@ComEmail", txtEmail.Text),
        //    new SqlParameter("@ComWebsite", txtWebsite.Text),
        //    new SqlParameter("@ComPFno", txtPFCode.Text),
        //    new SqlParameter("@ComPFdate", ddPfDate.Text.ToString()),
        //    new SqlParameter("@ComESIno", txtEsiCode.Text),
        //    new SqlParameter("@ComESIdate", ddEsiDate.Text.ToString()),
        //    new SqlParameter("@ComFactoryNo", txtFactoryAct.Text),
        //    new SqlParameter("@ComTINno", txtTin.Text),
        //    new SqlParameter("@ComCSTno", txtCSTNo.Text),
        //    new SqlParameter("@ComSSLno", txtSSINo.Text),
        //    new SqlParameter("@ComPanno", txtPanNo.Text),
        //    new SqlParameter("@ComTanno", txtTanNo.Text),
        //    new SqlParameter("@ComLicenseno", txtLicense.Text),
        //    new SqlParameter("@CAuthorName", txtName.Text),
        //    new SqlParameter("@CAFathername", txtFathersName.Text),
        //    new SqlParameter("@CAGender", selectedValue),
        //    new SqlParameter("@CAAddress", txtAddress.Text),
        //    new SqlParameter("@CAstate", ddAuthstartingdate.Text.ToString()),
        //    new SqlParameter("@CApin", txtAuthorPin.Text),
        //    new SqlParameter("@CAStdCode", txtAuthorStdCode.Text),
        //    new SqlParameter("@CAPhoneno", txtAuthorPhoneNo.Text),
        //    new SqlParameter("@CAblood", txtAuthorBloodGroup.Text),
        //    new SqlParameter("@CADOB", ddAuthDOB.Text.ToString()),
        //    new SqlParameter("@CAEmail", txtAuthorEmailId.Text),
        //    new SqlParameter("@CAMobile", txtAuthorMobileNo.Text),
        //    new SqlParameter("@CAPan", txtAuthorPanNo.Text)
        //    };

        //    //var i = _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        //}
    }
}