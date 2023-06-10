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
using BusinessLayer;

namespace BillPlex
{
    public partial class FrmProductMaster : DevExpress.XtraEditors.XtraForm
    {
        private ProductMaster productMasterRequest;
        public FrmProductMaster()
        {
            InitializeComponent();
            productMasterRequest = new ProductMaster();
            productMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                productMasterRequest.ProductName = txtPName.Text;
                productMasterRequest.Update();

                if (productMasterRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(productMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}