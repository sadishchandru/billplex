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
    public partial class FrmDeliveryChallanInfo : DevExpress.XtraEditors.XtraForm
    {
        private DeliveryChallanInfro DeliveryChallanRequest;
        public FrmDeliveryChallanInfo()
        {
            InitializeComponent();
            DeliveryChallanRequest = new DeliveryChallanInfro();

            DeliveryChallanRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                    DeliveryChallanRequest.CompanyMasterId= drpCName.Text;
                    DeliveryChallanRequest.Director=drpDirector.Text;
                    DeliveryChallanRequest.ClientCompanyId = drpCCom.Text;
                    DeliveryChallanRequest.Contractor = drpContractor.Text;
                    DeliveryChallanRequest.SubclientCompanyId= drpSCCom.Text;
                    DeliveryChallanRequest.Subcontractor= drpSCon.Text;
                    DeliveryChallanRequest.CustomerCode = drpCCode.Text;
                    DeliveryChallanRequest.CustomerName = drpComName.Text.ToString();
                    DeliveryChallanRequest.OrderNo = drpOrderCode.Text;
                    DeliveryChallanRequest.ModelCode = drpMCode.Text;
                    DeliveryChallanRequest.ModelName =drpMName.Text;
                    DeliveryChallanRequest.ProductName= txtProductName.Text;
                    DeliveryChallanRequest.RawMaterial = txtRawMaterial.Text;
                    DeliveryChallanRequest.RawType= txtType.Text;
                    DeliveryChallanRequest.ProductSize = drpPSize.Text.ToString();
                    DeliveryChallanRequest.OrderDate = ddODate.Text;
                    DeliveryChallanRequest.ColourName = drpColor.Text.ToString();
                    DeliveryChallanRequest.Quantity = txtQuantity.Text;
                    DeliveryChallanRequest.Weight= txtWeight.Text;
                    DeliveryChallanRequest.Excess =txtExcess.Text;
                    DeliveryChallanRequest.AvlQty= txtAvlQty.Text;
                    DeliveryChallanRequest.Shortage = txtShortage.Text;
                    DeliveryChallanRequest.DcNo= txtDCNo.Text;
                    DeliveryChallanRequest.DcDate= ddDCDate.Text;
                    //DeliveryChallanRequest.OrderQty= txtOrderQty.Text;
                    DeliveryChallanRequest.OrderWeight= txtWeight.Text;
                    DeliveryChallanRequest.Update();
                    this.Close();

                    FrmClientCompanyProfile CompanyInfo = new FrmClientCompanyProfile();
                    //CompanyInfo.MdiParent = this;
                    CompanyInfo.FrmClientCompanyProfile_Load(sender, e);

                if (DeliveryChallanRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(DeliveryChallanRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Display a warning alert
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BindData(dynamic selectedChallanList)
        {
            var selectedRows = selectedChallanList.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                DeliveryChallanRequest.Id = selectedChallanList.GetRowCellValue(rowHandle, "Id");
                drpCName.Text = selectedChallanList.GetRowCellValue(rowHandle, "CompanyMasterId");
                drpCCom.Text = selectedChallanList.GetRowCellValue(rowHandle, "ClientCompanyId");
                drpSCCom.Text = selectedChallanList.GetRowCellValue(rowHandle, "SubclientCompanyId");
                drpDirector.Text = selectedChallanList.GetRowCellValue(rowHandle, "Director");
                drpContractor.Text = selectedChallanList.GetRowCellValue(rowHandle, "Contractor");
                drpSCon.Text = selectedChallanList.GetRowCellValue(rowHandle, "Subcontractor");
                drpCCode.Text = selectedChallanList.GetRowCellValue(rowHandle, "CustomerCode");
                drpCName.Text = selectedChallanList.GetRowCellValue(rowHandle, "CustomerName");
                drpOrderCode.Text = selectedChallanList.GetRowCellValue(rowHandle, "OrderNo");

                var datete = selectedChallanList.GetRowCellValue(rowHandle, "OrderDate").ToString();
                ddODate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";

                drpMCode.Text = selectedChallanList.GetRowCellValue(rowHandle, "ModelCode");
                drpMName.Text = selectedChallanList.GetRowCellValue(rowHandle, "ModelName");
                txtProductName.Text = selectedChallanList.GetRowCellValue(rowHandle, "ProductName");
                drpPSize.Text = selectedChallanList.GetRowCellValue(rowHandle, "ProductSize");
                txtRawMaterial.Text = selectedChallanList.GetRowCellValue(rowHandle, "RawMaterial");
                txtQuantity.Text = selectedChallanList.GetRowCellValue(rowHandle, "Quantity");
                txtWeight.Text = selectedChallanList.GetRowCellValue(rowHandle, "Weight");
                txtExcess.Text = selectedChallanList.GetRowCellValue(rowHandle, "Excess");
                drpColor.Text = selectedChallanList.GetRowCellValue(rowHandle, "ColourName");
                txtType.Text = selectedChallanList.GetRowCellValue(rowHandle, "RawType");
                txtAvlQty.Text = selectedChallanList.GetRowCellValue(rowHandle, "AvlQty");
                txtShortage.Text = selectedChallanList.GetRowCellValue(rowHandle, "Shortage");
                txtDCNo.Text = selectedChallanList.GetRowCellValue(rowHandle, "DcNo");

                datete = selectedChallanList.GetRowCellValue(rowHandle, "DcDate").ToString();
                ddDCDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
            }

            btnAdd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            drpCName.ResetText();
            drpCCom.ResetText();
            drpSCCom.ResetText();
            drpDirector.ResetText();
            drpContractor.ResetText();
            drpSCon.ResetText();
            drpCCode.ResetText();
            drpCName.ResetText();
            drpOrderCode.ResetText();
            ddODate.ResetText();
            drpMCode.ResetText();
            drpMName.ResetText();
            txtProductName.ResetText();
            drpPSize.ResetText();
            txtRawMaterial.ResetText();
            txtQuantity.ResetText();
            txtWeight.ResetText();
            txtExcess.ResetText();
            drpColor.ResetText();
            txtType.ResetText();
            txtAvlQty.ResetText();
            txtShortage.ResetText();
            txtDCNo.ResetText();
            ddDCDate.ResetText();
        }
    }
}