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
    public partial class FrmInDirectLabourBill : DevExpress.XtraEditors.XtraForm
    {
        private InDirectLabourBill InDirectLabourBillRequest;
        private LabourDirectBill LabourBill;
        public FrmInDirectLabourBill()
        {
            InitializeComponent();
            InDirectLabourBillRequest = new InDirectLabourBill();

            InDirectLabourBillRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            ddDate.DateTime = DateTime.Now;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "MasterCompanyRequired", true },
                    {"ClientCompanyRequired",true},
                    {"SubClientCompanyRequired",true}
                };

            var dropdwonList = InDirectLabourBillRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "MasterCompanyRequired")
                {
                    InDirectLabourBillRequest.MasterCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "ClientCompanyRequired")
                {
                    InDirectLabourBillRequest.ClientCompanyList = (List<DropDownItemInfo>)item.Value;
                }

                if (item.Key == "SubClientCompanyRequired")
                {
                    InDirectLabourBillRequest.SubClientList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (InDirectLabourBillRequest.MasterCompanyList != null)
            {
                if (InDirectLabourBillRequest.MasterCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in InDirectLabourBillRequest.MasterCompanyList)
                    {
                        drpMainCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            if (InDirectLabourBillRequest.ClientCompanyList != null)
            {
                if (InDirectLabourBillRequest.ClientCompanyList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in InDirectLabourBillRequest.ClientCompanyList)
                    {
                        drpClientCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
            if (InDirectLabourBillRequest.SubClientList != null)
            {
                if (InDirectLabourBillRequest.SubClientList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in InDirectLabourBillRequest.SubClientList)
                    {
                        drpSubClientCompany.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }
        }

        private void drpMainCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpMainCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtDirector.Text = InDirectLabourBillRequest.MasterCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpClientCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpClientCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtClientName.Text = InDirectLabourBillRequest.ClientCompanyList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void drpSubClientCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)drpSubClientCompany.SelectedItem;

            if (selectedItem != null)
            {
                txtSubClient.Text = InDirectLabourBillRequest.SubClientList.FirstOrDefault(item => item.Name == selectedItem.ToString())?.AuthorName ?? "";
            }
        }

        private void FrmInDirectLabourBill_Load(object sender, EventArgs e)
        {
            foreach (GridColumn column in gridView1.Columns)
            {
                drpSortBy.Properties.Items.Add(column.FieldName);
            }
        }

        private void radioProductionIncentive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textGrandToal.Text, out double inputValue))
            {
                double result = 0.0;

                if (radioProductionIncentive.Text == "1")
                {
                    textProctionIncentive.Enabled = true;
                    if (double.TryParse(textProctionIncentive.Text, out double percentageValue))
                    {
                        result = (percentageValue / 100) * inputValue;
                    }
                }
                else if (radioProductionIncentive.Text == "0" && !string.IsNullOrEmpty(textProctionIncentive.Text))
                {
                    result = Convert.ToDouble(textProctionIncentive.Text) + inputValue;
                }

                textProIncentiveTotal.Text = result.ToString("0.00");
            }
        }
        private void radioPf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textProIncentiveTotal.Text, out double inputValue))
            {
                double result = 0.0;

                if (radioPf.Text == "1")
                {
                    if (double.TryParse(textPf.Text, out double percentageValue))
                    {
                        result = (percentageValue / 100) * inputValue;
                    }
                }
                else if (radioPf.Text == "0" && !string.IsNullOrEmpty(textPf.Text))
                {
                    result = Convert.ToDouble(textPf.Text) + inputValue;
                }

                textPFTotal.Text = result.ToString("0.00");
            }
        }

        private void radioEsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textPFTotal.Text, out double inputValue))
            {
                double result = 0.0;

                if (radioEsi.Text == "1")
                {
                    if (double.TryParse(txtESI.Text, out double percentageValue))
                    {
                        result = (percentageValue / 100) * inputValue;
                    }
                }
                else if (radioEsi.Text == "0" && !string.IsNullOrEmpty(txtESI.Text))
                {
                    result = Convert.ToDouble(txtESI.Text) + inputValue;
                }

                txtESITotal.Text = result.ToString("0.00");
            }
        }

        private void radioBonus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtESITotal.Text, out double inputValue))
            {
                double result = 0.0;

                if (radioBonus.Text == "1")
                {
                    if (double.TryParse(textBonus.Text, out double percentageValue))
                    {
                        result = (percentageValue / 100) * inputValue;
                    }
                }
                else if (radioBonus.Text == "0" && !string.IsNullOrEmpty(textBonus.Text))
                {
                    result = Convert.ToDouble(textBonus.Text) + inputValue;
                }

                textBousTotal.Text = result.ToString("0.00");
            }
        }

        private void radCompanyWise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radCompanyWise.Text == "0")
            {
                drpClientCompany.Enabled = true;

                drpSubClientCompany.Enabled = false;
            }
            else if (radCompanyWise.Text == "1")
            {
                drpSubClientCompany.Enabled = true;
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (!gridControl1.IsPrintingAvailable)
            {
                MessageBox.Show("");
                return;
            }
            gridControl1.ShowPrintPreview();
            LabourDirectBill repot = new LabourDirectBill();
            repot.ShowPreview();
        }

        private void textSubTotal1_EditValueChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal deductionTotal = 0;

            if (textDeduction.Text != "" && textDeduction.Text != "0")
            {
                deductionTotal = Convert.ToDecimal(textDeduction.Text);
                total = deductionTotal;
            }

            if (textSubTotal1.Text != "" && textSubTotal1.Text != "0")
            {
                total += Convert.ToDecimal(textSubTotal1.Text);
            }

            if (textConveyance.Text != "" && textConveyance.Text != "0")
            {
                total += Convert.ToDecimal(textConveyance.Text);
            }

            if (textIncentives.Text != "" && textIncentives.Text != "0")
            {
                total += Convert.ToDecimal(textIncentives.Text);
            }

            if (textSubTotal2.Text != "" && textSubTotal2.Text != "0")
            {
                total += Convert.ToDecimal(textSubTotal2.Text);
            }

            if (textSuperVisorChargesLrg.Text != "" && textSuperVisorChargesLrg.Text != "0")
            {
                total += Convert.ToDecimal(textSuperVisorChargesLrg.Text);
            }

            if (textGrandToal.Text != "" && textGrandToal.Text != "0")
            {
                total += Convert.ToDecimal(textGrandToal.Text);
            }

            if (textPFTotal.Text != "" && textPFTotal.Text != "0")
            {
                total += Convert.ToDecimal(textPFTotal.Text);
            }

            if (txtESITotal.Text != "" && txtESITotal.Text != "0")
            {
                total += Convert.ToDecimal(txtESITotal.Text);
            }

            if (textBonus.Text != "" && textBonus.Text != "0")
            {
                total += Convert.ToDecimal(textBonus.Text);
            }
            if (textAdvance.Text != "" && textAdvance.Text != "0")
            {
                decimal advance = Convert.ToDecimal(textAdvance.Text);
                total -= advance; // Subtract the advance amount from the total
            }
            textFinalTotal.Text = total.ToString();
            textNetAmount.Text = total.ToString();
        }
    }
}