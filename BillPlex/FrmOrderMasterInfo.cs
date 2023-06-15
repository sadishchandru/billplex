using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmOrderMasterInfo : DevExpress.XtraEditors.XtraForm
    {
        private OrderMasterInfo OrderMasterRequest;
        public FrmOrderMasterInfo()
        {
            InitializeComponent();
            OrderMasterRequest = new OrderMasterInfo();
            OrderMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }

        private void comboBoxEdit10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            txtOrderNo.ResetText();
            drpOrderDate.ResetText();
            drpCustCode.ResetText();
            drpCustName.ResetText();
            drpProductName.ResetText();
            txtQuantity.ResetText();
            txtTotRawmat.ResetText();
            txtType.ResetText();
            drpProColor.ResetText();
            txtTotRawmat.ResetText();
            ddProDate.ResetText();
            txtWages.ResetText();
            drpStatus.ResetText();
            txtMaterialwt.ResetText();
            //DdModelName.ResetText();
            //DdProductSize.ResetText();
           
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                OrderMasterRequest.OrderNo = txtOrderNo.Text;
                OrderMasterRequest.OrderDate = drpOrderDate.Text;
                OrderMasterRequest.CustomerCodeId = drpCustCode.Text;
                OrderMasterRequest.CustomerId = int.Parse(drpCustName.Text);
                OrderMasterRequest.ProductNameId = int.Parse(drpProductName.Text);
                OrderMasterRequest.Quantity = txtMaterialwt.Text;   
                OrderMasterRequest.RawMaterialId = int.Parse(txtTotRawmat.Text);   
                OrderMasterRequest.RawType = txtType.Text;
                OrderMasterRequest.ColorId = int.Parse(drpProColor.Text);
                OrderMasterRequest.RawQty = txtQuantity.Text;
                OrderMasterRequest.TotalRaw = txtTotRawmat.Text;
                OrderMasterRequest.Deliverydate = ddProDate.Text;
                OrderMasterRequest.WagesforEmp = txtWages.Text;
                OrderMasterRequest.status = int.Parse(drpStatus.Text);
                OrderMasterRequest.Avlweight = txtMaterialwt.Text;

                //OrderMasterRequest.ModelName = DdModelName.Text;
                //model code
                //product size
                //product date
                //OrderMasterRequest.ProductSize = DdProductSize.Text;

                OrderMasterRequest.Update();

                if (OrderMasterRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(OrderMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}