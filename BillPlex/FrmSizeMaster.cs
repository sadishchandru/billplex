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
    public partial class FrmSizeMaster : DevExpress.XtraEditors.XtraForm
    {
        private SizeMaster sizeMasterRequest;
        public FrmSizeMaster()
        {
            InitializeComponent();
            sizeMasterRequest = new SizeMaster();
            sizeMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sizeMasterRequest.SizeName = txtSName.Text;
                sizeMasterRequest.Update();

                if (sizeMasterRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(sizeMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}