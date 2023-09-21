using BillPlex.Models;
using BusinessLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

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

            //XRPanel panel = new XRPanel();
            //panel.WidthF = 50; // Set the width of the panel as needed
            //panel.HeightF = 300; // Set the height of the panel as needed
            //panel.Borders = DevExpress.XtraPrinting.BorderSide.All; // Set panel borders
            //panel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter; // Center-align the content

            // Create a table
            XRTable table = new XRTable();
            table.WidthF = 830; // Set the table width as needed
            table.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            table.LocationF = new PointF(detailBand.WidthF - table.WidthF, table.LocationF.Y);
            detailBand.Controls.Add(table);
            float leftPadding = 10;
            float rightPadding = 10;
            table.LocationF = new PointF(leftPadding, table.LocationF.Y);
            table.WidthF -= (leftPadding + rightPadding); // Adjust the width to account for right padding
            table.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table
            table.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.None;

            // Create table header row
            XRTableRow headerRow = new XRTableRow();

            headerRow.BackColor = System.Drawing.Color.Gray;
            headerRow.Borders = DevExpress.XtraPrinting.BorderSide.None;

            headerRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 0F);
            //this.Margins = new System.Drawing.Printing.Margins(5, 6, 7, 75);

            XRTableCell headerCell1 = new XRTableCell();
            headerCell1.Text = "Product";
            headerCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            headerCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table
            headerCell1.ForeColor = Color.Brown;
            headerCell1.BackColor = System.Drawing.Color.LightGray;
            headerCell1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            XRTableCell headerCell2 = new XRTableCell();
            headerCell2.Text = "Model";
            headerCell2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            headerCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table
            headerCell2.ForeColor = Color.Brown;
            headerCell2.BackColor = System.Drawing.Color.LightGray;
            headerCell2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            XRTableCell headerCell3 = new XRTableCell();
            headerCell3.Text = "Size";
            headerCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            headerCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table
            headerCell3.ForeColor = Color.Brown;
            headerCell3.BackColor = System.Drawing.Color.LightGray;
            headerCell3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            XRTableCell headerCell4 = new XRTableCell();
            headerCell4.Text = "Quantity";
            headerCell4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            headerCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table
            headerCell4.ForeColor = Color.Brown;
            headerCell4.BackColor = System.Drawing.Color.LightGray;
            headerCell4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            XRTableCell headerCell5 = new XRTableCell();
            headerCell5.Text = "Rate";
            headerCell5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            headerCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table
            headerCell5.ForeColor = Color.Brown;
            headerCell5.BackColor = System.Drawing.Color.LightGray;
            headerCell5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            XRTableCell headerCell6 = new XRTableCell();
            headerCell6.Text = "Amount";
            headerCell6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            headerCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify; // Center-align the table
            headerCell6.ForeColor = Color.Brown;
            headerCell6.BackColor = System.Drawing.Color.LightGray;
            headerCell6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            //XRTableCell headerCell2 = new XRTableCell();
            //headerCell2.Text = "Product Name";
            //headerCell2.Borders = DevExpress.XtraPrinting.BorderSide.None;

            //XRTableCell headerCell3 = new XRTableCell();
            //headerCell3.Text = "Net Amount";
            //headerCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;

            //XRTableCell headerCell4 = new XRTableCell();
            //headerCell4.Text = "Total Amount";
            //headerCell4.Borders = DevExpress.XtraPrinting.BorderSide.None;

            headerRow.Cells.AddRange(new XRTableCell[] { headerCell1, headerCell2, headerCell3, headerCell4, headerCell5, headerCell6 });
            table.Rows.Add(headerRow);

            // Populate the table with data
            XRTableRow dataRow = new XRTableRow();
            XRTableCell dataCell1 = new XRTableCell();
            XRTableCell dataCell2 = new XRTableCell();
            XRTableCell dataCell3 = new XRTableCell();
            XRTableCell dataCell4 = new XRTableCell();
            XRTableCell dataCell5 = new XRTableCell();
            XRTableCell dataCell6 = new XRTableCell();
            foreach (var dataItem in DirectLabourBillRequest)
            {
                dataRow = new XRTableRow();
                dataRow.Borders = DevExpress.XtraPrinting.BorderSide.All;

                //dataRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 10F);

                dataCell1 = new XRTableCell();
                dataCell1.DataBindings.Add("Text", dataItem, "ProductName");
                dataCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;

                dataCell2 = new XRTableCell();
                dataCell2.DataBindings.Add("Text", dataItem, "ModelName");
                dataCell2.Borders = DevExpress.XtraPrinting.BorderSide.None;
                
                dataCell3 = new XRTableCell();
                dataCell3.DataBindings.Add("Text", dataItem, "ProductSize");
                dataCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
                
                dataCell4 = new XRTableCell();
                dataCell4.DataBindings.Add("Text", dataItem, "TotalQty");
                dataCell4.Borders = DevExpress.XtraPrinting.BorderSide.None;

                dataCell5 = new XRTableCell();
                dataCell5.DataBindings.Add("Text", dataItem, "WagesforEmp");
                dataCell5.Borders = DevExpress.XtraPrinting.BorderSide.None;

                dataCell6 = new XRTableCell();
                dataCell6.DataBindings.Add("Text", dataItem, "TotalAmt");
                dataCell6.Borders = DevExpress.XtraPrinting.BorderSide.None;

                dataRow.Cells.AddRange(new XRTableCell[] { dataCell1, dataCell2, dataCell3, dataCell4, dataCell5, dataCell6 });
                table.Rows.Add(dataRow);
            }

            
                dataRow = new XRTableRow();
                dataRow.Borders = DevExpress.XtraPrinting.BorderSide.All;

                //dataRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 0);

                dataCell1 = new XRTableCell();
                dataCell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;

                dataCell2 = new XRTableCell();
                dataCell2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;

                dataCell3 = new XRTableCell();
                dataCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;

                dataCell4 = new XRTableCell();
                dataCell4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;


                dataCell5 = new XRTableCell();
                dataCell5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;

                dataCell6 = new XRTableCell();
                dataCell6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;

                dataRow.Cells.AddRange(new XRTableCell[] { dataCell1, dataCell2, dataCell3, dataCell4, dataCell5, dataCell6 });
                table.Rows.Add(dataRow);
            


            //dataRow = new XRTableRow();
            //dataRow.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;

            //table.Rows.Add(dataRow);


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

            int TotalQty = 3000;
            foreach (var dataItem in DirectLabourBillRequest)
            {
                int itemQty;
                if (int.TryParse(dataItem.TotalQty, out itemQty))
                {
                    TotalQty += itemQty;
                }
            }
            txtTotalQty.Text = TotalQty.ToString();
            txtTotalQty.DataBindings.Add("Text", txtTotalQty.Text, txtTotalQty.Text);
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number < 10)
                return units[number];
            else if (number < 20)
                return teens[number - 10];
            else if (number < 100)
                return tens[number / 10] + " " + units[number % 10];
            else if (number < 1000)
                return units[number / 100] + " Hundred " + NumberToWords(number % 100);
            else if (number < 1000000)
                return NumberToWords(number / 1000) + " Thousand " + NumberToWords(number % 1000);

            return "Number too large to convert";
        }

    }
}
