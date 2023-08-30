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
        public RpLabourBill()
        {
            InitializeComponent();
            //sqlDataSource3.Fill();
        }

        public void getSqldataSource(List<DirectLabourBill> DirectBillReportList)
        {
            if (DirectBillReportList != null)
            {

                if (DirectBillReportList.Count <= 0)
                {
                    return;
                }
                InitializeDataSource();
                foreach (var item in DirectBillReportList)
                {
                    DataTable dataTable = InitializeDataSource();
                    DataRow newRow = dataTable.NewRow();
                    newRow["ModelName"] = item.ModelName;
                    newRow["ProductName"] = item.ProductName;
                    newRow["ProductSize"] = item.ProductSize;
                    newRow["QuantityPiece"] = item.QuantityPiece;
                    newRow["WagesforEmp"] = item.WagesforEmp;
                    newRow["TotalQty"] = item.TotalQty;
                    newRow["NetAmt"] = item.NetAmt;
                    newRow["TotalAmt"] = item.TotalAmt == "" ? 0 : decimal.Parse(item.TotalAmt);
                    // Add the new DataRow to the DataTable
                    newRow["VendorName"] = "Srini";
                    dataTable.Rows.Add(newRow);
                    dataSet14.Tables.Add(dataTable);
                }
            }



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
            dataTable.Columns.Add("VendorName", typeof(string));

            return dataTable;
        }

    }
}
