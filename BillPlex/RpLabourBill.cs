using BusinessLayer;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace BillPlex
{
    public partial class RpLabourBill : DevExpress.XtraReports.UI.XtraReport
    {
        public class LabourBillData
        {
            public string BillNo { get; set; }
            public string FromDate { get; set; }
            public string ToDate { get; set; }
            public string Date { get; set; }
            public string LessDeducation { get; set; }
            public string SubTotal1 { get; set; }
            public string Conveyance { get; set; }
            public string Incentives { get; set; }
            public string SubTotal2 { get; set; }
            public string SupVisorTotal { get; set; }
            public string GrandTotal { get; set; }
            public string ProductIncentive { get; set; }
            public string PFText { get; set; }
            public string TotalESI { get; set; }
            public string TotalBouns { get; set; }
            public string FinalTotal { get; set; }
            public string Advance { get; set; }
            public string NetAmount { get; set; }
        }
        public RpLabourBill(List<LabourBillData> dataSource, List<DirectLabourBill> DirectBillReportList)
        {
            InitializeComponent(); // Initialize the report components

            DataSource = dataSource;

            // Bind the controls to data source fields
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


            //detailTable.BeginInit();

            foreach (var item in DirectBillReportList)
            {
                detailTableRow = new XRTableRow();

                quantity.DataBindings.Add("Text", item, "QuantityPiece");
                detailTableRow.Cells.Add(quantity);

                productName.DataBindings.Add("Text", item, "ProductName");
                detailTableRow.Cells.Add(productName);

                unitPrice.DataBindings.Add("Text", item, "WagesforEmp");
                detailTableRow.Cells.Add(unitPrice);

                lineTotal.DataBindings.Add("Text", item, "TotalAmt");
                detailTableRow.Cells.Add(lineTotal);

                // Add the row to the table
                detailTable.Rows.Add(detailTableRow);
            }

            //detailTable.EndInit();

            // Add the table to the DetailBand
            this.Detail.Controls.Add(detailTable);

            //if (DirectBillReportList != null)
            //{

            //    if (DirectBillReportList.Count <= 0)
            //    {
            //        return;
            //    }
            //    foreach (var item in DirectBillReportList)
            //    {
            //        DataTable dataTable = InitializeDataSource();
            //        DataRow newRow = dataTable.NewRow();
            //        newRow["ModelName"] = item.ModelName;
            //        newRow["ProductName"] = item.ProductName;
            //        newRow["ProductSize"] = item.ProductSize;
            //        newRow["QuantityPiece"] = item.QuantityPiece;
            //        newRow["WagesforEmp"] = item.WagesforEmp;
            //        newRow["TotalQty"] = item.TotalQty;
            //        newRow["NetAmt"] = item.NetAmt;
            //        newRow["TotalAmt"] = item.TotalAmt == "" ? 0 : decimal.Parse(item.TotalAmt);

            //        dataTable.Rows.Add(newRow);
            //        dataSet14.Tables.Add(dataTable);
            //    }
            //}
        }

        private DataTable InitializeDataSource()
        {
            DataTable dataTable = new DataTable();
            // Create columns and bind them to the object properties
            dataTable.Columns.Add("ModelName", typeof(string));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("ProductSize", typeof(string));
            dataTable.Columns.Add("QuantityPiece", typeof(string));
            dataTable.Columns.Add("WagesforEmp", typeof(string));
            dataTable.Columns.Add("TotalQty", typeof(string));
            dataTable.Columns.Add("NetAmt", typeof(string));
            dataTable.Columns.Add("TotalAmt", typeof(string));
            //dataTable.Columns.Add("VendorName", typeof(string));
            //dataSet15.Tables.Add(dataTable);


            return dataTable;
        }

    }
}
