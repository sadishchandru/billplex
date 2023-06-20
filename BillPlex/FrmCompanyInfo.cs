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
                        this.Close();
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
                //txtty = selectedCompanyList.GetRowCellValue(rowHandle, "ComType");
                txtOfficeAddress.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComOffAdd");
                drpState.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Comstate");
                txtPinNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPin");
                var datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComDatestart").ToString();
                DateTime dat = DateTime.Parse(datete);
                ddStartingdate.Text = dat.ToString();
                txtStdCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComStdCode");
                txtPhoneNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPhone");
                txtEmail.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComEmail");
                txtWebsite.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComWebsite");
                txtPFCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPFno");

                datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComPFdate");
                ddPfDate.Text = datete.ToString();

                txtEsiCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComESIno");
                datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComESIdate");
                ddEsiDate.Text = datete.ToString();
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
                radGender.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAGender");
                txtAddress.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAAddress");
                //drpState.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAstate");
                txtAuthorPin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CApin");
                txtAuthorStdCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAStdCode");
                txtAuthorPhoneNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAPhoneno");
                txtAuthorMobileNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAMobile");
                txtAuthorBloodGroup.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAblood");
                datete = selectedCompanyList.GetRowCellValue(rowHandle, "CADOB");
                ddAuthDOB.Text = datete.ToString();
                txtAuthorEmailId.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAEmail");
                txtAuthorPanNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "CAPan");
                datete = selectedCompanyList.GetRowCellValue(rowHandle, "CAStartDate");
                ddAuthstartingdate.Text = datete.ToString();
            }

            btnAdd.Enabled = false;
            BtnNew.Enabled = false;
            btnUpdate.Enabled = true;
        }
    }
}