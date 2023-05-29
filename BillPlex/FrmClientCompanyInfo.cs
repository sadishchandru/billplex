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
    public partial class FrmClientCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmClientCompanyInfo()
        {
            InitializeComponent();
        }

        private void InsertBankInfoBtn_Click(object sender, EventArgs e)
        {
            FrmClientCompanyBankInfo Cs = new FrmClientCompanyBankInfo();
            Cs.ShowDialog();
        }
    }
}