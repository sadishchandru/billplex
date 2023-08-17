﻿using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPlex
{
    public partial class IncentiveMaster : DevExpress.XtraEditors.XtraForm
    {
        private IncentiveMasters IncentiveMasterRequest;
        public IncentiveMaster()
        {
            InitializeComponent();
            IncentiveMasterRequest = new IncentiveMasters();
            IncentiveMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            sqlDataSource1.FillAsync();
            gridView1.BestFitColumns();

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    {"ProductModelRequired",true },
                    {"ProductMasterRequired",true }
                };

            var dropdwonList = IncentiveMasterRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ProductModelRequired")
                {
                    IncentiveMasterRequest.ProductModelList = (List<DropDownItemInfo>)item.Value;
                }                
                if (item.Key == "ProductMasterRequired")
                {
                    IncentiveMasterRequest.ProductMasterList = (List<DropDownItemInfo>)item.Value;
                }
            }

            if (IncentiveMasterRequest.ProductModelList != null)
            {
                if (IncentiveMasterRequest.ProductModelList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in IncentiveMasterRequest.ProductModelList)
                    {
                        DrpProductName.Properties.Items.Add(new ImageComboBoxItem(item.Name));
                    }
                }
            }

            if (IncentiveMasterRequest.ProductMasterList != null)
            {
                if (IncentiveMasterRequest.ProductMasterList.Count() > 0)
                {
                    foreach (DropDownItemInfo item in IncentiveMasterRequest.ProductMasterList)
                    {
                        DrpModelCode.Properties.Items.Add(new ImageComboBoxItem(item.proModel));
                    }
                }
            }
        }


        public void ReloadSqlDataSource()
        {
            sqlDataSource1.FillAsync();
            gridView1.RefreshData();

        }
        //private void dropDownButton1_Click(object sender, EventArgs e)
        //{

        //}

        private void btn_AddClick(object sender, EventArgs e)
        {
            try
            {
                if (DrpProductName.Text != string.Empty && DrpModelCode.Text != string.Empty)
                {
                    IncentiveMasterRequest.ProductName = DrpProductName.Text;
                    IncentiveMasterRequest.ModelCode = DrpModelCode.Text;
                    IncentiveMasterRequest.ModelName = DrpModelName.Text;
                    IncentiveMasterRequest.ModelSize = txtModelSize.Text;
                    IncentiveMasterRequest.DurationPeriod = txtDurationPeriod.Text;
                    IncentiveMasterRequest.Date = ddDate.Text;
                    IncentiveMasterRequest.Update();

                    if (IncentiveMasterRequest.Result.Status == ResultStatus.Success)
                    {
                        XtraMessageBox.Show(IncentiveMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_ClearClick();
                        btnAdd.Enabled = true;
                        btnUpdate.Enabled = false;
                        ReloadSqlDataSource();
                    }
                    else
                    {
                        XtraMessageBox.Show(IncentiveMasterRequest.Result.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("please give the manditory field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_DeleteClick(object sender, EventArgs e)
        {
            {
                var selectedRows = gridView1.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    var id = gridView1.GetRowCellValue(rowHandle, "Id");

                    IncentiveMasterRequest.Id = (Int64)id;
                }

                IncentiveMasterRequest.Delete();

                if (IncentiveMasterRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(IncentiveMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadSqlDataSource();
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            {
                var selectedRows = gridView1.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    var id = gridView1.GetRowCellValue(rowHandle, "Id");

                    IncentiveMasterRequest.Id = (Int64)id;
                }

                IncentiveMasterRequest.Delete();

                if (IncentiveMasterRequest.Result.Status == ResultStatus.Success)
                {
                    XtraMessageBox.Show(IncentiveMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        

        private void btn_ClearClick(object sender = null, EventArgs e= null)
        {
            IncentiveMasterRequest.Id = 0;
            DrpProductName.ResetText();
            DrpModelCode.ResetText();
            DrpModelName.ResetText();
            txtModelSize.ResetText();
            txtDurationPeriod.ResetText();
            ddDate.ResetText();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView1.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    IncentiveMasterRequest.Id = (Int64)gridView1.GetRowCellValue(rowHandle, "Id");
                    DrpProductName.Text = gridView1.GetRowCellValue(rowHandle, "ProductName").ToString();
                    DrpModelCode.Text = gridView1.GetRowCellValue(rowHandle, "ModelCode").ToString();
                    DrpModelName.Text = gridView1.GetRowCellValue(rowHandle, "ModelName").ToString();
                    txtModelSize.Text = gridView1.GetRowCellValue(rowHandle, "ModelSize").ToString();
                    txtDurationPeriod.Text = gridView1.GetRowCellValue(rowHandle, "DurationPeriod").ToString();
                    ddDate.Text = gridView1.GetRowCellValue(rowHandle, "Date").ToString();
                }
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnClear.Enabled = true;
                btnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnPNameTab_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FrmProductMaster")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FrmProductMaster productMaster = new FrmProductMaster();
                productMaster.MdiParent = this.MdiParent;
                productMaster.Show();
            }
        }

        private void IncentiveMaster_Load(object sender, EventArgs e)
        {
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = ourScreenWidth / 1600f;
            float scaleFactorHeigth = ourScreenHeight / 900f;
            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
            Scale(scaleFactor);

            // If you want to center the resized screen.
            CenterToScreen();
        }
    }
}