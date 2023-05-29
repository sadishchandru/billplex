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
    public partial class FrmCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmCompanyInfo()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmCompanyProfileBankInfo CP = new FrmCompanyProfileBankInfo();
            CP.ShowDialog();
        }
    }
}