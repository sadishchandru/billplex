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
    public partial class FrmSubClientCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        //private readonly SqlConnector _conn;
        private SubClientCompanyInfo SubClientRequest;
        public FrmSubClientCompanyInfo()
        {
            InitializeComponent();

            // _conn = new SqlConnector(connectionString);

            SubClientRequest = new SubClientCompanyInfo();

            SubClientRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true },
                    {"ClientCompanyRequired",true}
                };
            //ClientCompanyRequest.MasterCompanyList = ClientCompanyRequest.GetDropdownValues(dropDownList);

            var dropdwonList = SubClientRequest.GetDropdownCollections(dropDownList);


            //SubClientRequest.MasterCompanyList = (List<DropDownItemInfo>)dropdwonList.Cast<Hashtable>()
            //              .Where(entry => entry.Keys == "MasterCompanyRequired")
            //              .Select(entry => entry.Value);


            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    SubClientRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "ClientCompanyRequired")
                {
                    SubClientRequest.ClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }
                // SubClientRequest.MasterCompanyList = item;

                //        drpMainCompany.Properties.Items.AddRange(new ImageComboBoxItem[] {
                //new ImageComboBoxItem(item.Name)});
                //                var keyValue = item.Key.ToString();
                //if (item == "MasterCompanyRequired")
                //{
                // var itemList = item.Value as List<DropDownItemInfo>;

                //var itemsList = (DropDownItemInfo)item.Value;
                //drpMainCompany.Properties.Items.Add();
                //SubClientRequest.MasterCompanyList = dropdwonList;
                //SubClientRequest.ClientCompanyList = dropdwonList;
                //int index = 0;

                //drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                //drpCCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                //}
            }

            if (SubClientRequest.MasterCompanyList.Count() > 0)
            {
                foreach (DropDownItemInfo item in SubClientRequest.MasterCompanyList)
                {
                    drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                }
            }
            
            if (SubClientRequest.ClientCompanyList.Count() > 0)
            {
                foreach (DropDownItemInfo item in SubClientRequest.ClientCompanyList)
                {
                    drpCCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                }
            }

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
            string selectedMasterItem = (string)drpMainCompany.SelectedItem;

            if (selectedMasterItem != null)
            {
                SubClientRequest.MainCompany = SubClientRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedMasterItem.ToString())?.Id ?? -1;
            }

            string selectedClientItem = (string)drpCCompany.SelectedItem;

            if (selectedClientItem != null)
            {
                SubClientRequest.ClientCompany = SubClientRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedClientItem.ToString())?.Id ?? -1;
            }
            try
            {
                //SubClientRequest.MainCompany = drpMainCompany.Text;
                SubClientRequest.Director = txtDirector.Text;
                //SubClientRequest.ClientCompany = drpCCompany.Text;
                SubClientRequest.ContractorName = txtContName.Text;
                SubClientRequest.SubCompanyCode = txtCompanyCode.Text;
                SubClientRequest.SubCompanyName = txtCompanyName.Text;
                SubClientRequest.OfficeAddress = txtOffAddress.Text;
                SubClientRequest.State = drpState.Text;
                SubClientRequest.Pin = txtPin.Text;
                SubClientRequest.BusinessNature = radBusinessNature.Text;
                SubClientRequest.StartingDate = ddStartingDate.Text;
                SubClientRequest.STDCode = txtOffPin.Text;
                SubClientRequest.PhoneNo = txtOfficePhone.Text;
                SubClientRequest.EmailId = txtEmail.Text;
                SubClientRequest.Website = txtWebsite.Text;
                SubClientRequest.PfType = radPfType.Text;
                SubClientRequest.PFCode = txtPFCode.Text;
                SubClientRequest.PFDate = ddPFDate.Text;
                SubClientRequest.EsiCode = txtEsiCode.Text;
                SubClientRequest.ESIDate = ddESIDate.Text;
                SubClientRequest.FactoryActNo = txtFactoryAct.Text;
                SubClientRequest.TinNo = txtTin.Text;
                SubClientRequest.CstNo = txtCst.Text;
                SubClientRequest.SsiNo = txtSsi.Text;
                SubClientRequest.PanNo = txtPanNo.Text;
                SubClientRequest.TanNo = txttan.Text;
                SubClientRequest.LicenseNo = txtLicense.Text;
                SubClientRequest.Name = txtName.Text;
                SubClientRequest.FathersName = txtFathers.Text;
                SubClientRequest.Gender = radGender.Text;
                SubClientRequest.BloodGroup = txtBlood.Text;
                SubClientRequest.DOB = ddDOB.Text;
                SubClientRequest.AuthEmailId = txtAuthEmailId.Text;
                SubClientRequest.AuthAddress = txtAuthAddress.Text;
                SubClientRequest.AuthState = drpAuthState.Text;
                SubClientRequest.Authpin = txtAuthpin.Text;
                SubClientRequest.AuthMobileNo = txtAuthMobileNo.Text;
                SubClientRequest.AuthPanNo = txtAuthPanNo.Text;
                SubClientRequest.AuthPercent = txtAuthPercent.Text;
                SubClientRequest.ActiveStatus = radActiveStatus.Text;
                SubClientRequest.Update();

                if (SubClientRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(SubClientRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void drpDirector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //drpMainCompany.SelectedIndexChanged += drpMainCompany_SelectedIndexChanged;
        private void drpMainCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpMainCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtDirector.Text = SubClientRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpCCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpCCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtContName.Text = SubClientRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        //    private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    var Id = 0;
        //    string selectedValue = radBusinessNature.EditValue?.ToString() ?? "Default Value";

        //    // Calling the stored procedure for creating a new Company Profile
        //    SqlParameter[] parameters = new SqlParameter[]
        //   {
        //    new SqlParameter("@MasterCode", drpMainCompany.Text),
        //    new SqlParameter("@MasterCompanyId", txtCompanyName.Text),
        //    new SqlParameter("@ClientCompanyId", drpClientCompany.Text),
        //    new SqlParameter("@SubComCode", txtCompanyCode.Text),
        //    new SqlParameter("@SubComName", txtCompanyName.Text),
        //    new SqlParameter("@ComOffAddress", txtOffAddress.Text),
        //    new SqlParameter("@ComState", drpState.Text),
        //    new SqlParameter("@ComPin", txtPin.Text),
        //    new SqlParameter("@ComNature", selectedValue),
        //    new SqlParameter("@Director", txtEmail.Text),
        //    new SqlParameter("@ComStartDate", ddStartingDate.Text.ToString()),
        //    new SqlParameter("@ComStdCode", txtOffPin.Text),
        //    new SqlParameter("@ComPhone", txtOfficePhone.Text),
        //    new SqlParameter("@ComEmail", txtEmail.Text),
        //    new SqlParameter("@ComWebsite", txtWebsite.Text),
        //    new SqlParameter("@PFType", radPfType.Text),
        //    new SqlParameter("@ComPFNo", txtPFCode.Text),
        //    new SqlParameter("@ComPfDate", ddPFDate.Text.ToString()),
        //    new SqlParameter("@ComEsiNo", txtEsiCode.Text),
        //    new SqlParameter("@ComEsiDate", ddESIDate.Text),
        //    new SqlParameter("@ComFactoryNo", txtFactoryAct.Text),
        //    new SqlParameter("@ComCstNo", txtCst.Text),
        //    new SqlParameter("@ComSslNo", txtSsi.Text),
        //    new SqlParameter("@ComTinNo", txtTin.Text),
        //    new SqlParameter("@ComLicenseno", selectedValue),
        //    new SqlParameter("@ComPanNo", txtPanNo.Text),
        //    new SqlParameter("@ComTan_no", txttan.Text.ToString()),
        //    new SqlParameter("@AuthorName", txtName.Text),
        //    new SqlParameter("@AuthorFathername", txtFathers.Text),
        //    new SqlParameter("@AuthorGender", radGender.Text),
        //    new SqlParameter("@AuthorBlood", drpbloodGrop.Text),
        //    new SqlParameter("@AuthorDOB", ddDOB.Text.ToString()),
        //    new SqlParameter("@AuthorEmail", txtAuthEmailId.Text),
        //    new SqlParameter("@AuthorAddress", txtAuthAddress.Text),
        //    new SqlParameter("@AuthorState", drpAuthState.Text),
        //    new SqlParameter("@AuthorPin", txtAuthpin.Text),
        //    new SqlParameter("@AuthorMobile", txtAuthMobileNo.Text),
        //    new SqlParameter("@AuthorPan", txtAuthPanNo.Text),
        //    new SqlParameter("@AuthorPercent", txtAuthPercent.Text),
        //    new SqlParameter("@AuthorActive",radActiveStatus.Text),
        //    //new SqlParameter("@AuthorImage", AuthImg.Text),
        //   // new SqlParameter("@BankName", txtBankDetails.Text),
        //   // new SqlParameter("@BankAcNo", txtBankDetails.Text),
        //    //new SqlParameter("@BankAddress", txtBankDetails.Text)
        //   };

        //   // var i = _conn.ExecuteNonQuery("PRO_UpdateCompanyProfileInfo", parameters);
        //}
    }
}