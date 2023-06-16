using BusinessLayer;
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

namespace BillPlex
{
    public partial class FrmFinishingProductModel : DevExpress.XtraEditors.XtraForm
    {
        private FinishingProductModel FinishingProductModelRequest;
        public FrmFinishingProductModel()
        {
            InitializeComponent();
            FinishingProductModelRequest = new FinishingProductModel();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FinishingProductModelRequest.ProductNameId = drpProductName.Text;
                FinishingProductModelRequest.Productcode = txtModelCode.Text;
                FinishingProductModelRequest.Productmodel = txtModelName.Text;
                FinishingProductModelRequest.Productsize = drpProductSize.Text;
                FinishingProductModelRequest.WagesforProduct = txtWages.Text;
                FinishingProductModelRequest.ItemDate = drpDate.Text;
                FinishingProductModelRequest.Update();

                if (FinishingProductModelRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(FinishingProductModelRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Display a warning alert
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }
    }
}