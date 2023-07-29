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
            ClientCompanyinfoRequest  = new ClientCompanyInfo();
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

            //FrmClientCompanyInfo CP = new FrmClientCompanyInfo();
            //CP.MdiParent = this.MdiParent;
            //CP.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView2.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                ClientCompanyinfoRequest.Id = (Int64)gridView2.GetRowCellValue(rowHandle, "Id");

                //CompanyMasterRequest.Id = (Int32)gridView2.GetRowCellValue(rowHandle, "Id");
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView2.GetSelectedRows();

            ClientCompanyRequest = new FrmClientCompanyInfo();

            ClientCompanyRequest.BindData(gridView2);

            ClientCompanyRequest.MdiParent = this.MdiParent;

            ClientCompanyRequest.Show();
           
        }

        public void FrmClientCompanyProfile_Load(object sender, EventArgs e)
        {
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = (float)ourScreenWidth / 1600f;
            float scaleFactorHeigth = (float)ourScreenHeight / 900f;
            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
            Scale(scaleFactor);

            // If you want to center the resized screen.
            CenterToScreen();
        }
    }
}