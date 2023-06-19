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
    public partial class FrmRawMaterial : DevExpress.XtraEditors.XtraForm
    {
        private RawMaterial RawMaterialRequest;
        public FrmRawMaterial()
        {
            InitializeComponent();
            RawMaterialRequest = new RawMaterial();
            RawMaterialRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                RawMaterialRequest.RawMaterials = txtType.Text;
                RawMaterialRequest.RawMaterialType = txtRawMaterial.Text;
                RawMaterialRequest.RawMaterialStock = txtStock.Text;
                RawMaterialRequest.Update();

                if (RawMaterialRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(RawMaterialRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}