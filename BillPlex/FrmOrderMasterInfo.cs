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
        private OrderMaster OrderMasterRequest;
        public FrmOrderMasterInfo()
        {
            InitializeComponent();
            OrderMasterRequest = new OrderMaster();
            OrderMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }

        private void comboBoxEdit10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            txtOrderNo.ResetText();
            DdOrderDate.ResetText();
            DdCustCode.ResetText();
            DdCustName.ResetText();
            DdProductName.ResetText();
            DdModelName.ResetText();
            DdProductSize.ResetText();
            txtMaterialwt.ResetText();
            txtType.ResetText();
            txtTotRawmat.ResetText();
            drpProColor.ResetText();
            txtQuantity.ResetText();
            ddProDate.ResetText();
            drpStatus.ResetText();
            txtTotRawmat.ResetText();
            txtWages.ResetText();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                OrderMasterRequest.OrderNo = txtOrderNo.Text;
                OrderMasterRequest.OrderDate = DdOrderDate.Text;
                OrderMasterRequest.CustomerCode = DdCustCode.Text;
                OrderMasterRequest.CustomerName = DdCustName.Text;
                OrderMasterRequest.ProductName = DdProductName.Text;
                OrderMasterRequest.ModelName = DdModelName.Text;
                OrderMasterRequest.ProductSize = DdProductSize.Text;
                OrderMasterRequest.MaterialWeight = txtMaterialwt.Text;
                OrderMasterRequest.Type = txtType.Text;
                OrderMasterRequest.RawMaterialName = txtTotRawmat.Text;
                OrderMasterRequest.ProductColor = drpProColor.Text;
                OrderMasterRequest.Quantity = txtQuantity.Text;
                OrderMasterRequest.DeliveryDate = ddProDate.Text;
                OrderMasterRequest.status = drpStatus.Text;
                OrderMasterRequest.TotalRawMaterial = txtTotRawmat.Text;
                OrderMasterRequest.WagesForEmployee = txtWages.Text;

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
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var id = gridView1.GetRowCellValue(rowHandle, "Id");

                OrderMasterRequest.Id = (int)id;
            }

            OrderMasterRequest.Delete();
        }
    }
}