using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BillPlex
{
    public partial class LabourBill : DevExpress.XtraReports.UI.XtraReport
    {
        public LabourBill()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //float top = 100; // Adjust the top position as needed

            //for (int rowHandle = 0; rowHandle < gridView1.RowCount; rowHandle++)
            //{
            //    var cellValue1 = gridView1.GetRowCellValue(rowHandle, "Column1").ToString();
            //    var cellValue2 = gridView1.GetRowCellValue(rowHandle, "Column2").ToString();

            //    XRLabel label = new XRLabel();
            //    label.Text = $"{cellValue1}, {cellValue2}";
            //    label.SizeF = new SizeF(200, 20); // Adjust the size as needed
            //    label.LocationF = new PointF(100, top);
            //    containerControl.Controls.Add(label);

            //    top += 20; // Adjust the vertical position for the next label
            //}
        }
    }
}
