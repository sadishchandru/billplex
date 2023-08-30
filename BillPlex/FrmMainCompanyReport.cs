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
    public partial class FrmMainCompanyReport : DevExpress.XtraEditors.XtraForm
    {
        private MainCompanyReport MainCompanyReportRequest;
        public FrmMainCompanyReport()
        {
            InitializeComponent();
            MainCompanyReportRequest = new MainCompanyReport();

            MainCompanyReportRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true }
                };

            var dropdwonList = MainCompanyReportRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    MainCompanyReportRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (MainCompanyReportRequest.MasterCompanyList != null)
            {
                if (MainCompanyReportRequest.MasterCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in MainCompanyReportRequest.MasterCompanyList)
                    {
                        drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
        }

        private void drpMainCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpMainCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtDirector.Text = MainCompanyReportRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void FrmMainCompanyReport_Load(object sender, EventArgs e)
        {
            foreach (GridColumn column in gridView1.Columns)
            {
                drpSortby.Properties.Items.Add(column.FieldName);
            }
        }
    }
}