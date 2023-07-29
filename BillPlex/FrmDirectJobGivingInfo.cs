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
    public partial class FrmDirectJobGivingInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmDirectJobGivingInfo()
        {
            InitializeComponent();
        }

        private void FrmDirectJobGivingInfo_Load(object sender, EventArgs e)
        {
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = (float)ourScreenWidth / 1600f;
            float scaleFactorHeigth = (float)ourScreenHeight / 900f;
            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
            Scale(scaleFactor);

            // If you want to center the resized screen.
            CenterToScreen();
        }
    }
}