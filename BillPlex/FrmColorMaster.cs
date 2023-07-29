﻿using BusinessLayer;
using DevExpress.XtraEditors;
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
    public partial class FrmColorMaster : DevExpress.XtraEditors.XtraForm
    {
        private ColorMaster ColorMasterRequest;
        public FrmColorMaster()
        {
            InitializeComponent();
            ColorMasterRequest = new ColorMaster();
            ColorMasterRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            ColorMasterRequest.Result = new ResultDetail();

            labelAvailable.Visible = false;
            LabelExceed.Visible = false;

            Dictionary<string, bool> dropDownList = new Dictionary<string, bool>        {
                    { "ColorMasterRequired", true }
                };

            var dropdwonList = ColorMasterRequest.GetDropdownCollections(dropDownList);

            foreach (DictionaryEntry item in dropdwonList)
            {
                if (item.Key == "ColorMasterRequired")
                {
                    ColorMasterRequest.ColorList = (List<DropDownItemInfo>)item.Value;
                }
            }

            btnAdd.Enabled = true;
            btEdit.Enabled = false;
            btUpdate.Enabled = false;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();
        }
        public void ReloadSqlDataSource()
        {
            sqlDataSource2.FillAsync();
            ColormasterGrid.RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCName.Text != string.Empty)
                {
                    if ((ColorMasterRequest.Id != 0 || labelAvailable.Visible == true) && LabelExceed.Visible == false)
                    {
                        ColorMasterRequest.ColorName = txtCName.Text;
                        ColorMasterRequest.Update();
                        if (ColorMasterRequest.Result.Status == ResultStatus.Success)
                        {
                            btnAdd.Enabled = true;
                            btEdit.Enabled = false;
                            btUpdate.Enabled = false;
                            XtraMessageBox.Show(ColorMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadSqlDataSource();
                        }
                        else
                        {
                            XtraMessageBox.Show(ColorMasterRequest.Result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Please check Colour", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("please give the mandatory field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = ColormasterGrid.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    ColorMasterRequest.Id = (Int32)ColormasterGrid.GetRowCellValue(rowHandle, "Id");
                    txtCName.Text = ColormasterGrid.GetRowCellValue(rowHandle, "Colournname").ToString();

                }
                btnAdd.Enabled = false;
                btEdit.Enabled = false;
                btDelete.Enabled = true;
                btUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = ColormasterGrid.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var id = ColormasterGrid.GetRowCellValue(rowHandle, "Id");

                ColorMasterRequest.Id = (Int32)id;
            }

            ColorMasterRequest.Delete();

            if (ColorMasterRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(ColorMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadSqlDataSource();
            }

        }

        private void btClear_Click(object sender = null, EventArgs e = null)
        {
            ColorMasterRequest.Id = 0;
            txtCName.ResetText();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCName_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCName.Text != string.Empty)
            {
                if (ColorMasterRequest.ColorList != null)
                {

                    var Color = ColorMasterRequest.ColorList.FirstOrDefault(obj => obj.Name.ToUpper() == txtCName.Text.ToUpper().ToString() && obj.Id != ColorMasterRequest.Id);

                    if (Color != null)
                    {
                        labelAvailable.Visible = false;
                        LabelExceed.Visible = true;
                    }
                    else
                    {
                        labelAvailable.Visible = true;
                        LabelExceed.Visible = false;
                    }
                }
                else
                {
                    labelAvailable.Visible = true;
                    LabelExceed.Visible = false;
                }

            }
            else
            {
                labelAvailable.Visible = false;
                LabelExceed.Visible = false;
            }
        }

        private void FrmColorMaster_Load(object sender, EventArgs e)
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