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
    public partial class FrmCompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        public FrmCompanyProfile()
        {
            InitializeComponent();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            FrmCompanyInfo CP = new FrmCompanyInfo();
            CP.ShowDialog();
        }

        private void FrmCompanyProfile_Load(object sender, EventArgs e)
        {

        }
    }
}