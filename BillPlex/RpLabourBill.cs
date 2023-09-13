using BillPlex.Models;
using BusinessLayer;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Data;

namespace BillPlex
{
    public partial class RpLabourBill : DevExpress.XtraReports.UI.XtraReport
    {
        LabourBillData labourBillData = new LabourBillData();
        List<LabourBillData> dataSourceReport = new List<LabourBillData>();

        public RpLabourBill(List<LabourBillData> dataSource, List<DirectLabourBill> DirectLabourBillRequest)
        {
            InitializeComponent();

            // Create DetailReportBand and DetailBand
            DetailReportBand detailReportBand = new DetailReportBand();
            Bands.Add(detailReportBand);

            DetailBand detailBand = new DetailBand();
            detailReportBand.Bands.Add(detailBand);

            XRPanel panel = new XRPanel();
            panel.WidthF = 500; // Set the width of the panel as needed
            panel.HeightF = 300; // Set the height of the panel as needed
            panel.Borders = DevExpress.XtraPrinting.BorderSide.All; // Set panel borders
            panel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter; // Center-align the content

            // Create a table
            XRTable table = new XRTable();
            table.WidthF = 830; // Set the table width as needed
            table.Borders = DevExpress.XtraPrinting.BorderSide.All;
            table.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table

            // Create table header row
            XRTableRow headerRow = new XRTableRow();
            XRTableCell headerCell1 = new XRTableCell();
            headerCell1.Text = "Quantity";
            headerCell1.Borders = DevExpress.XtraPrinting.BorderSide.All;
            headerCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table

            XRTableCell headerCell2 = new XRTableCell();
            headerCell2.Text = "Product Name";
            headerCell2.Borders = DevExpress.XtraPrinting.BorderSide.All;

            XRTableCell headerCell3 = new XRTableCell();
            headerCell3.Text = "Net Amount";
            headerCell3.Borders = DevExpress.XtraPrinting.BorderSide.All;

            XRTableCell headerCell4 = new XRTableCell();
            headerCell4.Text = "Total Amount";
            headerCell4.Borders = DevExpress.XtraPrinting.BorderSide.All;

            headerRow.Cells.AddRange(new XRTableCell[] { headerCell1, headerCell2, headerCell3, headerCell4 });
            table.Rows.Add(headerRow);

            // Populate the table with data
            foreach (var dataItem in DirectLabourBillRequest)
            {
                XRTableRow dataRow = new XRTableRow();
                dataRow.Borders = DevExpress.XtraPrinting.BorderSide.All;

                XRTableCell dataCell1 = new XRTableCell();
                dataCell1.DataBindings.Add("Text", dataItem, "TotalQty");
                dataCell1.Borders = DevExpress.XtraPrinting.BorderSide.All;

                XRTableCell dataCell2 = new XRTableCell();
                dataCell2.DataBindings.Add("Text", dataItem, "ProductName");
                dataCell2.Borders = DevExpress.XtraPrinting.BorderSide.All;

                XRTableCell dataCell3 = new XRTableCell();
                dataCell3.DataBindings.Add("Text", dataItem, "NetAmt");
                dataCell3.Borders = DevExpress.XtraPrinting.BorderSide.All;

                XRTableCell dataCell4 = new XRTableCell();
                dataCell4.DataBindings.Add("Text", dataItem, "TotalAmt");
                dataCell4.Borders = DevExpress.XtraPrinting.BorderSide.All;

                dataRow.Cells.AddRange(new XRTableCell[] { dataCell1, dataCell2, dataCell3, dataCell4 });
                table.Rows.Add(dataRow);
            }

            // Add the table to the DetailBand
            detailBand.Controls.Add(table);

            // Bind the controls to data source fields
            DataSource = dataSource;
            //Bind the controls to data source fields
            BillNo.DataBindings.Add("Text", DataSource, "BillNo");
            FromDate.DataBindings.Add("Text", DataSource, "FromDate", "{0:MM/dd/yyyy}");
            ToDate.DataBindings.Add("Text", DataSource, "ToDate", "{0:MM/dd/yyyy}");
            Date.DataBindings.Add("Text", DataSource, "Date", "{0:MM/dd/yyyy}");
            LessDeducation.DataBindings.Add("Text", DataSource, "LessDeducation");
            SubTotal1.DataBindings.Add("Text", DataSource, "SubTotal1");
            Conveyance.DataBindings.Add("Text", DataSource, "Conveyance");
            Incentive.DataBindings.Add("Text", DataSource, "Incentives");
            Subtotal2.DataBindings.Add("Text", DataSource, "Subtotal2");
            SupervisorCharge.DataBindings.Add("Text", DataSource, "SupVisorTotal");
            GrandTotal.DataBindings.Add("Text", DataSource, "GrandTotal");
            ProductionIncentive.DataBindings.Add("Text", DataSource, "ProductIncentive");
            PF.DataBindings.Add("Text", DataSource, "PFText");
            ESI.DataBindings.Add("Text", DataSource, "TotalESI");
            Bonus.DataBindings.Add("Text", DataSource, "TotalBouns");
            FinalTotal.DataBindings.Add("Text", DataSource, "FinalTotal");
            Advance.DataBindings.Add("Text", DataSource, "Advance");
            NetAmount.DataBindings.Add("Text", DataSource, "NetAmount");
            objectDataSource1.DataSource = dataSource;

            // Report Data Binding (if needed)
            // ... (data source configuration)
        }
    }
}
