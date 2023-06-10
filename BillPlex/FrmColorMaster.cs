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
    public partial class FrmColorMaster : DevExpress.XtraEditors.XtraForm
    {
        private ColorMaster  ColorMasterRequest;
        public FrmColorMaster()
        {
            InitializeComponent();
            ColorMasterRequest = new ColorMaster();
            ColorMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ColorMasterRequest.ColorName = txtCName.Text;
                ColorMasterRequest.Update();

                if (ColorMasterRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(ColorMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}