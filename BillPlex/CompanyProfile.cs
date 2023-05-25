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
    public partial class CompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        public CompanyProfile()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CompanyProfile_Load(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Button clicked");
        }
    }
}