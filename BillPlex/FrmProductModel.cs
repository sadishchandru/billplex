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
    public partial class FrmProductModel : DevExpress.XtraEditors.XtraForm
    {
        private ProductModel productModelRequest;
        public FrmProductModel()
        {
            InitializeComponent();

            productModelRequest = new ProductModel();
            productModelRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                    productModelRequest.RawMaterialType = drpRawType.Text;
               // productModelRequest.Director = drpDirector.Text;
                //productModelRequest.ClientCompany = drpCCompany.Text;
                //productModelRequest.ContractorName = drpContractorName.Text;
                //productModelRequest.SubCompanyCode = txtCompanyCode.Text
            }
            catch
            {

            }
        }
    }
}