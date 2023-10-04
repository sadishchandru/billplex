﻿using BillPlex.Models;
using BusinessLayer;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmDirectLabourBill : DevExpress.XtraEditors.XtraForm
    {
        private DirectLabourBill DirectLabourBillRequest;
        private RpLabourBill LabourBill; // Declare the report variable at the class level
        public FrmDirectLabourBill()
        {
            InitializeComponent();
            InitializeDataSource();
            DirectLabourBillRequest = new DirectLabourBill();

            DirectLabourBillRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            ddDate.DateTime = DateTime.Now;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true },
                    {"ClientCompanyRequired",true},
                    {"SubClientCompanyRequired",true}
                };

            var dropdwonList = DirectLabourBillRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    DirectLabourBillRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "ClientCompanyRequired")
                {
                    DirectLabourBillRequest.ClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "SubClientCompanyRequired")
                {
                    DirectLabourBillRequest.SubClientList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (DirectLabourBillRequest.MasterCompanyList != null)
            {
                if (DirectLabourBillRequest.MasterCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in DirectLabourBillRequest.MasterCompanyList)
                    {
                        drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            if (DirectLabourBillRequest.ClientCompanyList != null)
            {
                if (DirectLabourBillRequest.ClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in DirectLabourBillRequest.ClientCompanyList)
                    {
                        drpCCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            if (DirectLabourBillRequest.SubClientList != null)
            {
                if (DirectLabourBillRequest.SubClientList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in DirectLabourBillRequest.SubClientList)
                    {
                        drpSubClient.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            string BillNo = txtBillNo.Text;
            string FromDate = ddFrom.Text;
            string ToDate = ddTo.Text;
            string Date = ddDate.Text;
            string LessDeducation = txtDeducation.Text;
            string SubTotal1 = txtSubTotal1.Text;
            string Conveyance = txtConveyance.Text;
            string Incentives = txtIncentives.Text;
            string SubTotal2 = txtSubTotal2.Text;
            string SupVisorTotal = txtSupVisorTotal.Text;
            string GrandTotal = txtGrandTotal.Text;
            string ProductIncentive = txtProductionIncentive.Text;
            string PFText = txtPFText.Text;
            string TotalESI = TxtTotalESI.Text;
            string TotalBouns = txtTotalBouns.Text;
            string FinalTotal = txtFinalTotal.Text;
            string Advance = txtAdvance.Text;
            string NetAmount = txtNetAmount.Text;

            if (DirectLabourBillRequest.DirectBillReportList != null && DirectLabourBillRequest.DirectBillReportList.Count > 0)
            {
                //Create an instance of your report
                RpLabourBill report = new RpLabourBill(GetLabourBillDataSource(BillNo, FromDate, Date, ToDate, LessDeducation, SubTotal1, Conveyance, Incentives, SubTotal2,
                    SupVisorTotal, GrandTotal, ProductIncentive, PFText, TotalESI, TotalBouns, FinalTotal, Advance, NetAmount, DirectLabourBillRequest.DirectBillReportList), DirectLabourBillRequest.DirectBillReportList);
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            } else
            {
                XtraMessageBox.Show("No Record to Genrate Report ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private List<LabourBillData> GetLabourBillDataSource(string billNo, string fromDate, string date, string todate, string lessdeducation, string subTotal1, string conveyance, string incentives,
            string grandTotal, string productIncentive, string Subtotal2, string SupVisortotal, string PFtext, string totalESI, string totalbouns, string finaltotal, string advance, string netamount, List<DirectLabourBill> DirectBillReportList)
        {
            // Convert the fromDate to a DateTime if needed
            string parsedFromDate = fromDate;
            string parsedToDate = todate;
            string parsedDate = date;

            List<LabourBillData> dataSource = new List<LabourBillData>
            {
                new LabourBillData
                {
                    BillNo = billNo,
                    FromDate = parsedFromDate,
                    ToDate = parsedToDate,
                    Date = parsedDate,
                    LessDeducation = lessdeducation,
                    SubTotal1 = subTotal1,
                    Conveyance = conveyance,
                    Incentives = incentives,
                    SubTotal2 = Subtotal2,
                    SupVisorTotal = SupVisortotal,
                    GrandTotal = grandTotal,
                    ProductIncentive = productIncentive,
                    PFText = PFtext,
                    TotalESI = totalESI,
                    TotalBouns = totalbouns,
                    FinalTotal = finaltotal,
                    Advance = advance,
                    NetAmount = netamount,
                    TotalQtys = long.Parse(txttotalQuantity.Text),
                    TotalAmounts = long.Parse(txtGrandTotal.Text),
                    DirectBillReportList = DirectBillReportList
                }
            };

            return dataSource;
        }
        private void drpMainCompany_EditValueChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpMainCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtDirector.Text = DirectLabourBillRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpCCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpCCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtClientName.Text = DirectLabourBillRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpSubClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpSubClient.SelectedItem;

            if (selectedItem != null)
            {
                txtSubClient.Text = DirectLabourBillRequest.SubClientList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void comboBoxEdit3_EditValueChanged(object sender, EventArgs e)
        {
            //DateTime fromDate = ddFrom.DateTime;
            //DateTime toDate = ddTo.DateTime;

            //// Get the GridView
            //GridView gridView = gridControl1.MainView as GridView;

            //// Clear any existing filters
            //gridView.ActiveFilter.Clear();

            //// Apply the date range filter
            //gridView.ActiveFilterString = $"[sqlDataSource1] >= #{fromDate.ToString("MM/dd/yyyy")}# AND [sqlDataSource1] <= #{toDate.ToString("MM/dd/yyyy")}#";
            //DisplayFooterTotal();
        }

        private void FrmDirectLabourBill_Load(object sender, EventArgs e)
        {
            foreach (GridColumn column in gridView1.Columns)
            {
                drpSortBy.Properties.Items.Add(column.FieldName);
            }
        }

        private void drpOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected sorting order from the ComboBox
            //string selectedSortingOrder = drpOrderBy.EditValue.ToString();

            //// Get the GridView
            //GridView gridView = gridView1;
            //GridView gridView = (GridView)gridControl1.MainView;

            //// Clear existing sorting settings
            //gridView.ClearSorting();

            // Determine the sort order
            //ColumnSortOrder sortOrder = drpOrderBy.EditValue.ToString() == "Ascending" ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending;

            // Apply sorting to the grid
            //gridView.Columns["YourColumnName"].SortOrder = sortOrder;
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtGrandTotal.Text, out double inputValue))
            {
                double result = 0.0;

                if (radProduction.Text == "1")
                {
                    txtIncentivePercent.Enabled = true;
                    if (double.TryParse(txtIncentivePercent.Text, out double percentageValue))
                    {
                        result = (percentageValue / 100) * inputValue;
                    }
                }
                else if (radProduction.Text == "0" && !string.IsNullOrEmpty(txtIncentivePercent.Text))
                {
                    result = Convert.ToDouble(txtIncentivePercent.Text) + inputValue;
                }

                txtProductionIncentive.Text = result.ToString("0.00");
            }
        }

        private void radPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtProductionIncentive.Text, out double inputValue))
            {
                double result = 0.0;

                if (radProduction.Text == "1")
                {
                    if (double.TryParse(txtpf.Text, out double percentageValue))
                    {
                        result = (percentageValue / 100) * inputValue;
                    }
                }
                else if (radProduction.Text == "0" && !string.IsNullOrEmpty(txtpf.Text))
                {
                    result = Convert.ToDouble(txtpf.Text) + inputValue;
                }

                txtPFText.Text = result.ToString("0.00");
            }
        }

        private void radESI_EditValueChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPFText.Text, out double inputValue))
            {
                double result = 0.0;

                if (radProduction.Text == "1")
                {
                    if (double.TryParse(txtESI.Text, out double percentageValue))
                    {
                        result = (percentageValue / 100) * inputValue;
                    }
                }
                else if (radProduction.Text == "0" && !string.IsNullOrEmpty(txtESI.Text))
                {
                    result = Convert.ToDouble(txtESI.Text) + inputValue;
                }

                TxtTotalESI.Text = result.ToString("0.00");
            }
        }

        private void radBonus_EditValueChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TxtTotalESI.Text, out double inputValue))
            {
                double result = 0.0;

                if (radProduction.Text == "1")
                {
                    if (double.TryParse(txtBonus.Text, out double percentageValue))
                    {
                        result = (percentageValue / 100) * inputValue;
                    }
                }
                else if (radProduction.Text == "0" && !string.IsNullOrEmpty(txtBonus.Text))
                {
                    result = Convert.ToDouble(txtBonus.Text) + inputValue;
                }

                txtTotalBouns.Text = result.ToString("0.00");
            }
        }

        private void drpSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumnName = drpSortBy.SelectedItem.ToString();
            GridColumn selectedColumn = gridView1.Columns[selectedColumnName];

            if (selectedColumn != null)
            {
                // Move the selected column to the first position in the column collection
                selectedColumn.VisibleIndex = 0;
            }
        }
        // to get the footer values 
        private void DisplayFooterTotal()
        {
            GridView view = gridView1;

            // Access the summary item for the desired column
            GridColumn column1 = view.Columns["TotalAmt"]; // Replace with your actual column name
            GridColumnSummaryItem summaryItem = column1.SummaryItem as GridColumnSummaryItem;

            if (summaryItem != null && summaryItem.SummaryValue != null)
            {
                double totalColumn1 = Convert.ToDouble(summaryItem.SummaryValue);
                txtTotal.Text = totalColumn1.ToString(); // Update TextBox with total value of Column1
                txtSubTotal1.Text = totalColumn1.ToString(); // Update TextBox with total value of Column1
            }
            else
            {
                txtTotal.Text = "0.00"; // Handle the case where the summary value is not available
            }
        }

        private void txtSubTotal1_EditValueChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal deductionTotal = 0;

            if (txtDeducation.Text != "" && txtDeducation.Text != "0")
            {
                deductionTotal = Convert.ToDecimal(txtDeducation.Text);
                total = deductionTotal;
            }

            if (txtSubTotal1.Text != "" && txtSubTotal1.Text != "0")
            {
                total += Convert.ToDecimal(txtSubTotal1.Text);
            }

            if (txtConveyance.Text != "" && txtConveyance.Text != "0")
            {
                total += Convert.ToDecimal(txtConveyance.Text);
            }

            if (txtIncentives.Text != "" && txtIncentives.Text != "0")
            {
                total += Convert.ToDecimal(txtIncentives.Text);
            }

            if (txtSubTotal2.Text != "" && txtSubTotal2.Text != "0")
            {
                total += Convert.ToDecimal(txtSubTotal2.Text);
            }

            if (txtSupVisorTotal.Text != "" && txtSupVisorTotal.Text != "0")
            {
                total += Convert.ToDecimal(txtSupVisorTotal.Text);
            }

            if (txtGrandTotal.Text != "" && txtGrandTotal.Text != "0")
            {
                total += Convert.ToDecimal(txtGrandTotal.Text);
            }

            if (txtPFText.Text != "" && txtPFText.Text != "0")
            {
                total += Convert.ToDecimal(txtPFText.Text);
            }

            if (TxtTotalESI.Text != "" && TxtTotalESI.Text != "0")
            {
                total += Convert.ToDecimal(TxtTotalESI.Text);
            }

            if (txtBonus.Text != "" && txtBonus.Text != "0")
            {
                total += Convert.ToDecimal(txtBonus.Text);
            }
            if (txtAdvance.Text != "" && txtAdvance.Text != "0")
            {
                decimal advance = Convert.ToDecimal(txtAdvance.Text);
                total -= advance; // Subtract the advance amount from the total
            }
            txtFinalTotal.Text = total.ToString();
            txtNetAmount.Text = total.ToString();
        }

        private void drpCCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DirectLabourBillRequest.FromDate = ddFrom.Text;
                DirectLabourBillRequest.ToDate = ddTo.Text;
                DirectLabourBillRequest.MainComapny = drpMainCompany.Text;
                DirectLabourBillRequest.ClientComapny = drpCCompany.Text;
                DirectLabourBillRequest.SubClientCompany = drpSubClient.Text;
                DirectLabourBillRequest.ClientWise = radCompanyWise.Text;
                DirectLabourBillRequest.DirectBillReport();
                if (DirectLabourBillRequest.DirectBillReportList.Count() > 0)
                {
                    InitializeDataSource();

                    foreach (var item in DirectLabourBillRequest.DirectBillReportList)
                    {
                        DataTable dataTable = (DataTable)gridControl1.DataSource;
                        DataRow newRow = dataTable.NewRow();
                        newRow["ModelName"] = item.ModelName;
                        newRow["ProductName"] = item.ProductName;
                        newRow["ProductSize"] = item.ProductSize;
                        newRow["QuantityPiece"] = item.QuantityPiece;
                        newRow["WagesforEmp"] = item.WagesforEmp;
                        newRow["TotalQty"] = item.TotalQty;
                        newRow["NetAmt"] = item.NetAmt;
                        newRow["TotalAmt"] = item.TotalAmt;
                        newRow["OrderNo"] = item.OrderNo;
                        dataTable.Rows.Add(newRow);
                        gridControl1.RefreshDataSource();
                    }
                    // Refresh the grid to display the new row
                    gridView1.RefreshData();
                    gridControl1.RefreshDataSource();
                }
                DisplayFooterTotal();
                DirectLabourBillRequest.DirectBillReportList.ToList();
                txtDeducation.Text = DirectLabourBillRequest.DirectBillReportList.Sum(item => Convert.ToDecimal(item.Deducation)).ToString();
                txtConveyance.Text = DirectLabourBillRequest.DirectBillReportList.Sum(item => Convert.ToDecimal(item.Conveyance)).ToString();
                txtIncentives.Text = DirectLabourBillRequest.DirectBillReportList.Sum(item => Convert.ToDecimal(item.Incentive)).ToString();
                txttotalQuantity.Text = DirectLabourBillRequest.DirectBillReportList.Sum(item => long.Parse(item.TotalQty == "" ? "0" : item.TotalQty)).ToString();
                txtGrandTotal.Text = DirectLabourBillRequest.DirectBillReportList.Sum(item => long.Parse(item.TotalAmt == "" ? "0" : item.TotalAmt)).ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeDataSource()
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
            dataTable.Columns.Add("OrderNo", typeof(string));

            gridControl1.DataSource = dataTable;
            gridView1.RefreshData();
            gridControl1.RefreshDataSource();
        }

        private void radCompanyWise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radCompanyWise.Text == "0")
            {
                drpCCompany.Enabled = true;

                drpSubClient.Enabled = false;
            }
            else if (radCompanyWise.Text == "1")
            {
                drpSubClient.Enabled = true;
            }
        }
    }
}