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
using DataLayer;

namespace BillPlex
{
    public partial class FrmSubClientCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmSubClientCompanyInfo()
        {
            InitializeComponent();
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

            // Calling the stored procedure for creating a new Company Profile



            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //new SqlParameter("@MasterCode", drpMainCompany.Text),
            //new SqlParameter("@MasterCompanyId", txtCompanyName.Text),
            //new SqlParameter("@ClientCompanyId", txtOfficeAddress.Text),
            //new SqlParameter("@SubComCode", drpState.Text),
            //new SqlParameter("@SubComName", txtPinNo.Text),
            //new SqlParameter("@ComOffAddress", txtStdCode.Text),
            //new SqlParameter("@ComState", txtPhoneNo.Text),
            //new SqlParameter("@ComPin", ddStartingdate.Text.ToString()),
            //new SqlParameter("@ComNature", selectedValue),
            //new SqlParameter("@ComType", txtEmail.Text),
            //new SqlParameter("@ComStartDate", txtWebsite.Text),
            //new SqlParameter("@ComDtdCode", txtPFCode.Text),
            //new SqlParameter("@ComPhone", ddPfDate.Text.ToString()),
            //new SqlParameter("@ComEmail", txtEsiCode.Text),
            //new SqlParameter("@ComWebsite", ddEsiDate.Text.ToString()),
            //new SqlParameter("@PFType", txtFactoryAct.Text),
            //new SqlParameter("@ComPFNo", txtTin.Text),
            //new SqlParameter("@ComPfDate", txtCSTNo.Text),
            //new SqlParameter("@ComEsiNo", txtSSINo.Text),
            //new SqlParameter("@ComEsiDate", txtPanNo.Text),
            //new SqlParameter("@ComFactoryNo", txtTanNo.Text),
            //new SqlParameter("@ComCstNo", txtLicense.Text),
            //new SqlParameter("@ComSslNo", txtName.Text),
            //new SqlParameter("@ComTinNo", txtFathersName.Text),
            //new SqlParameter("@ComLicenseno", selectedValue),
            //new SqlParameter("@ComPanNo", txtAddress.Text),
            //new SqlParameter("@ComTan_no", ddAuthstartingdate.Text.ToString()),
            //new SqlParameter("@ComName", txtAuthorPin.Text),
            //new SqlParameter("@AuthorFathername", txtAuthorStdCode.Text),
            //new SqlParameter("@AuthorGender", txtAuthorPhoneNo.Text),
            //new SqlParameter("@AuthorBlood", txtAuthorBloodGroup.Text),
            //new SqlParameter("@AuthorDOB", ddAuthDOB.Text.ToString()),
            //new SqlParameter("@AuthorEmail", txtAuthorEmailId.Text),
            //new SqlParameter("@AuthorAddress", txtAuthorMobileNo.Text),
            //new SqlParameter("@AuthorState", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorPin", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorMobile", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorPan", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorPercent", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorActive", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorImage", txtAuthorPanNo.Text),
            //new SqlParameter("@BankName", txtAuthorPanNo.Text),
            //new SqlParameter("@BankAcNo", txtAuthorPanNo.Text),
            //new SqlParameter("@BankAddress", txtAuthorPanNo.Text)
            //};

            //var i = _conn.ExecuteNonQuery("PRO_UpdateSubClientCompanyProfileInfo", parameters);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var Id = 0;
            //string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

            //// Calling the stored procedure for creating a new Company Profile
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //new SqlParameter("@Id", Id),
            //new SqlParameter("@MasterCode", drpMainCompany.Text),
            //new SqlParameter("@MasterCompanyId", txtCompanyName.Text),
            //new SqlParameter("@ClientCompanyId", txtOfficeAddress.Text),
            //new SqlParameter("@ComCode", drpState.Text),
            //new SqlParameter("@ComName", txtPinNo.Text),
            //new SqlParameter("@ComOffAddress", txtStdCode.Text),
            //new SqlParameter("@ComState", txtPhoneNo.Text),
            //new SqlParameter("@ComPin", ddStartingdate.Text.ToString()),
            //new SqlParameter("@ComNature", selectedValue),
            //new SqlParameter("@ComType", txtEmail.Text),
            //new SqlParameter("@ComStartDate", txtWebsite.Text),
            //new SqlParameter("@ComDtdCode", txtPFCode.Text),
            //new SqlParameter("@ComPhone", ddPfDate.Text.ToString()),
            //new SqlParameter("@ComEmail", txtEsiCode.Text),
            //new SqlParameter("@ComWebsite", ddEsiDate.Text.ToString()),
            //new SqlParameter("@PFType", txtFactoryAct.Text),
            //new SqlParameter("@ComPFNo", txtTin.Text),
            //new SqlParameter("@ComPfDate", txtCSTNo.Text),
            //new SqlParameter("@ComEsiNo", txtSSINo.Text),
            //new SqlParameter("@ComEsiDate", txtPanNo.Text),
            //new SqlParameter("@ComFactoryNo", txtTanNo.Text),
            //new SqlParameter("@ComCstNo", txtLicense.Text),
            //new SqlParameter("@ComSslNo", txtName.Text),
            //new SqlParameter("@ComTinNo", txtFathersName.Text),
            //new SqlParameter("@ComLicenseno", selectedValue),
            //new SqlParameter("@ComPanNo", txtAddress.Text),
            //new SqlParameter("@ComTan_no", ddAuthstartingdate.Text.ToString()),
            //new SqlParameter("@ComName", txtAuthorPin.Text),
            //new SqlParameter("@AuthorFathername", txtAuthorStdCode.Text),
            //new SqlParameter("@AuthorGender", txtAuthorPhoneNo.Text),
            //new SqlParameter("@AuthorBlood", txtAuthorBloodGroup.Text),
            //new SqlParameter("@AuthorDOB", ddAuthDOB.Text.ToString()),
            //new SqlParameter("@AuthorEmail", txtAuthorEmailId.Text),
            //new SqlParameter("@AuthorAddress", txtAuthorMobileNo.Text),
            //new SqlParameter("@AuthorState", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorPin", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorMobile", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorPan", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorPercent", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorActive", txtAuthorPanNo.Text),
            //new SqlParameter("@AuthorImage", txtAuthorPanNo.Text),
            //new SqlParameter("@BankName", txtAuthorPanNo.Text),
            //new SqlParameter("@BankAcNo", txtAuthorPanNo.Text),
            //new SqlParameter("@BankAddress", txtAuthorPanNo.Text)
            //};

            //var i = _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        }
    }
}