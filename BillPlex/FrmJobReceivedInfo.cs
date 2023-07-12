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
    public partial class FrmJobReceivedInfo : DevExpress.XtraEditors.XtraForm
    {
        private JobReceivedInfo JobReceivedRequest;
        public FrmJobReceivedInfo()
        {
            InitializeComponent();
            sqlDataSource1.FillAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeCode = (string)txtEmpCode.Text;
                //JobReceivedRequest.EmployeeCode = txtEmpCode.Text;
                JobReceivedRequest.EmployeeName = txtEmpName.Text;
                JobReceivedRequest.CustomerName = txtCName.Text;
                JobReceivedRequest.RawMaterialName = txtRawMaterial.Text;
                JobReceivedRequest.Quantity = txtQuantity.Text;
                JobReceivedRequest.Wages = txtWages.Text;
                JobReceivedRequest.PendingQty = txtPQty.Text;
                JobReceivedRequest.ModelName = txtMName.Text;
                JobReceivedRequest.Type = txtType.Text;
                JobReceivedRequest.Weight = txtWeight.Text;
                JobReceivedRequest.CurrentWt = txtCrntWt.Text;
                JobReceivedRequest.RcvdQty = txtRcvdQty.Text;
                JobReceivedRequest.ReceivingDate = ddReceDate.Text;
                JobReceivedRequest.ProductModel = txtPModel.Text;
                JobReceivedRequest.ProductCode = txtPCode.Text;
                JobReceivedRequest.ProductSize = txtPSize.Text;
                JobReceivedRequest.ProductColor = txtColor.Text;
                JobReceivedRequest.IncentiveApplicable = drpIncentiveApp.Text;
                JobReceivedRequest.BeforeDays = txtBeforeDys.Text;
                JobReceivedRequest.AfterDays = txtAfterdys.Text;
                JobReceivedRequest.BalanceWeight = txtBalanceWeight.Text;
                JobReceivedRequest.Conveyance = txtConveyance.Text;
                JobReceivedRequest.Deduction = txtDeduction.Text;
                JobReceivedRequest.Incentive = txtIncentive.Text;
                JobReceivedRequest.Total = txtTotal.Text;
                JobReceivedRequest.NetAmt = txtNetAmt.Text;
                JobReceivedRequest.Update();

                if (JobReceivedRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(JobReceivedRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    FrmSubClientCompanyProfile form = Application.OpenForms.OfType<FrmSubClientCompanyProfile>().FirstOrDefault();

                    Form myForm = Application.OpenForms["FrmJobReceivedRequestProfile"];
                    if (myForm != null)
                    {
                        form.ReloadSqlDataSource();
                    }
                }
                else
                {
                    XtraMessageBox.Show(JobReceivedRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
      //  public void BindData(dynamic selectedCompanyList)
      //  {
      //      var selectedRows = selectedCompanyList.GetSelectedRows();
      //
      //      foreach (var rowHandle in selectedRows)
      //      {
                // SubClientRequest.Id = selectedCompanyList.GetRowCellValue(rowHandle, "Id");
                // drpMainCompany.SelectedIndex = SubClientRequest.MasterCompanyList.FindIndex(x => x.Id == Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "MasterCompanyId").ToString()));
                // drpCCompany.SelectedIndex = SubClientRequest.ClientCompanyList.FindIndex(x => x.Id == Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "ClientCompanyId").ToString()));
                // txtCompanyCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "SubComCode");
                // txtCompanyName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "SubComName");
                // txtOffAddress.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComOffAdd");
                // drpState.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComState");
                // txtPin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPin");
                // if (radBusinessNature.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "ComNature") != "")
                //     radBusinessNature.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "ComNature"));
                //
                // txtDirector.Text = selectedCompanyList.GetRowCellValue(rowHandle, "Director");
                // var datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComDatestart").ToString();
                //
                // ddStartingDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                //
                // txtOffPin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComStdCode");
                // txtOfficePhone.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPhone");
                // txtEmail.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComEmail");
                // txtWebsite.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComWebsite");
                //
                // if (radPfType.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "PfType") != "")
                //     radPfType.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "PfType"));
                // txtPFCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPfNo");
                //
                // datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComPfDate").ToString();
                // ddPFDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                //
                // txtEsiCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComEsiNo");
                //
                // datete = selectedCompanyList.GetRowCellValue(rowHandle, "ComEsiDate").ToString();
                // ddESIDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                //
              //  txtEmpName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComFactoryNo");
              //  txtCName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComCstNo");
              //  txtRawMaterial.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComSslNo");
              //  txtQuantity.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComTinNo");
              //  txtWages.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComLicenseno");
              //  txtPQty.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComPanNo");
              //  txtMName.Text = selectedCompanyList.GetRowCellValue(rowHandle, "ComTanNo");
              //  txtType.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorName");
              //  txtWeight.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  txtCrntWt.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  txtRcvdQty.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  ddReceDate.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  txtPModel.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  txtPCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  txtPSize.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  txtEmpCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  txtPModel.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
              //  txtPCode.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
               // txtFathers.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
               // txtFathers.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
               // txtFathers.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
               // txtFathers.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");
               // txtFathers.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorFathername");

                //  if (radGender.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "AuthorGender") != "")
                //      radGender.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "AuthorGender"));
                //
                //  drpAuthBlood.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorBlood");
                //
                //  datete = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorDOB").ToString();
                //  ddDOB.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
                //
                //  txtAuthEmailId.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorEmail");
                //  txtAuthAddress.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorAddress");
                //  drpAuthState.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorState");
                //  txtAuthpin.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorPin");
                //  txtAuthMobileNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorMobile");
                //  txtAuthPanNo.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorPan");
                //  txtAuthPercent.Text = selectedCompanyList.GetRowCellValue(rowHandle, "AuthorPercent");
                //
                //  if (radActiveStatus.SelectedIndex != null && selectedCompanyList.GetRowCellValue(rowHandle, "AuthorActive") != "")
                //      radActiveStatus.SelectedIndex = Convert.ToInt32(selectedCompanyList.GetRowCellValue(rowHandle, "AuthorActive"));
           // }


       // }

    }
}
