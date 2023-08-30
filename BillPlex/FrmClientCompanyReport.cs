﻿using BusinessLayer;
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
    public partial class FrmClientCompanyReport : DevExpress.XtraEditors.XtraForm
    {
        private ClientCompanyReport ClientCompanyReportRequest;
        public FrmClientCompanyReport()
        {
            InitializeComponent();
            ClientCompanyReportRequest = new ClientCompanyReport();

            ClientCompanyReportRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    {"ClientCompanyRequired",true}
                };

            var dropdwonList = ClientCompanyReportRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ClientCompanyRequired")
                {
                    ClientCompanyReportRequest.ClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (ClientCompanyReportRequest.ClientCompanyList != null)
            {
                if (ClientCompanyReportRequest.ClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in ClientCompanyReportRequest.ClientCompanyList)
                    {
                        drpClientCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
        }

        private void drpClientCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpClientCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtClientName.Text = ClientCompanyReportRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void FrmClientCompanyReport_Load(object sender, EventArgs e)
        {
            foreach (GridColumn column in gridView1.Columns)
            {
                drpSortby.Properties.Items.Add(column.FieldName);
            }
        }
    }
}