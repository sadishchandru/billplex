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
    public partial class FrmSubClientCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmSubClientCompanyInfo()
        {
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsertBankInfo_Click(object sender, EventArgs e)
        {
            FrmSubClientCompanyBankInfo fbankInfo = new FrmSubClientCompanyBankInfo();
            fbankInfo.Show();
        }
    }
}