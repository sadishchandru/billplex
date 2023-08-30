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
    public partial class FrmSubClientCompanyReport : DevExpress.XtraEditors.XtraForm
    {
        private SubClientReport SubClientReportRequest;
        public FrmSubClientCompanyReport()
        {
            InitializeComponent();
            SubClientReportRequest = new SubClientReport();

            SubClientReportRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    {"SubClientCompanyRequired",true}
                };

            var dropdwonList = SubClientReportRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "SubClientCompanyRequired")
                {
                    SubClientReportRequest.SubClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (SubClientReportRequest.SubClientCompanyList != null)
            {
                if (SubClientReportRequest.SubClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in SubClientReportRequest.SubClientCompanyList)
                    {
                        drpSubClientCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
        }

        private void drpSubClientCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpSubClientCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtSubClientName.Text = SubClientReportRequest.SubClientCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void FrmSubClientCompanyReport_Load(object sender, EventArgs e)
        {
            foreach (GridColumn column in gridView1.Columns)
            {
                drpSortby.Properties.Items.Add(column.FieldName);
            }
        }
    }
}