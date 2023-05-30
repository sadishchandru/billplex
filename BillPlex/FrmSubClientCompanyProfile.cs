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
    public partial class FrmSubClientCompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        public FrmSubClientCompanyProfile()
        {
            InitializeComponent();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            FrmClientCompanyInfo CP = new FrmClientCompanyInfo();
            CP.ShowDialog();
        }
    }
}