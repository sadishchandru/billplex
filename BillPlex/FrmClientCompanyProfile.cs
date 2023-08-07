using BusinessLayer;using DevExpress.XtraEditors;using DevExpress.XtraEditors.Controls;using DevExpress.XtraGrid.Views.Grid;using System;using System.Collections;using System.Collections.Generic;using System.ComponentModel;using System.Configuration;using System.Data;using System.Data.SqlClient;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmClientCompanyProfile : DevExpress.XtraEditors.XtraForm
    {
        private ClientCompanyInfo ClientCompanyinfoRequest;
        private FrmClientCompanyInfo ClientCompanyRequest;
        private GridView gridView;
        public FrmClientCompanyProfile()

        {
            ClientCompanyinfoRequest = new ClientCompanyInfo();
            InitializeComponent();
            ClientCompanyinfoRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            ReloadSqlDataSource();
        }

        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            gridView2.RefreshData();

        }
        private void Newbtn_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            Form myForm = Application.OpenForms["FrmClientCompanyInfo"];
            if (myForm != null)
            {
                myForm.Close();
                myForm = new FrmClientCompanyInfo();
                myForm.MdiParent = this.MdiParent;
                myForm.Show();
                IsOpen = true;
            }

            if (IsOpen == false)
            {
                FrmClientCompanyInfo CompanyInfo = new FrmClientCompanyInfo();
                CompanyInfo.MdiParent = this.MdiParent;
                CompanyInfo.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView2.GetSelectedRows();
            if (selectedRows.Length > 0)
            {
                if (selectedRows.Length > 0)
                {
                    foreach (var rowHandle in selectedRows)
                    {
                        ClientCompanyinfoRequest.Id = (Int64)gridView2.GetRowCellValue(rowHandle, "Id");
                    }
                    ClientCompanyinfoRequest.Delete();
                    if (ClientCompanyinfoRequest.Result.Status == ResultStatus.Success)
                    {
                        XtraMessageBox.Show(ClientCompanyinfoRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadSqlDataSource();
                    }
                    else
                    {
                        if (ClientCompanyinfoRequest.Result.Message.Contains("FK__"))
                        {
                            XtraMessageBox.Show("This Iteam has RelationShip with Another Model", "RelationShip Issues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            XtraMessageBox.Show(ClientCompanyinfoRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("No Record Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Records not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView2.GetSelectedRows();
            if (selectedRow.Length > 0)
            {

                ClientCompanyRequest = new FrmClientCompanyInfo();

                ClientCompanyRequest.BindData(gridView2);

                ClientCompanyRequest.MdiParent = this.MdiParent;

                ClientCompanyRequest.Show();
            }
            else
            {
                XtraMessageBox.Show("Records not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void FrmClientCompanyProfile_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the form
            int centerX = (this.Width - panelControl1.Width) / 2;
            int centerY = (this.Height - panelControl1.Height) / 2;

            // Set the controls' positions to the calculated center position
            panelControl1.Location = new Point(centerX, centerY);
        }
    }
}