﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;

namespace BillPlex
{
    public partial class FrmDeliveryChallanProfile : DevExpress.XtraEditors.XtraForm
    {
       

        private DeliveryChallanProfile DeliveryChallanProfileRequest;
        public FrmDeliveryChallanProfile()
        {
            InitializeComponent();
            DeliveryChallanProfileRequest = new DeliveryChallanProfile();
            DeliveryChallanProfileRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            // gridControl1.FillAsync();
        }



        private void btnNew_Click(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //FrmDeliveryChallanProfile.DeliveryChallanProfile = cmbFind.Text;
                    
                    //DeliveryChallanProfile.Update();

                    //if (DeliveryChallanProfile.Result.Status == ResultStatus.Success)
                    //{
                    //    XtraMessageBox.Show(productMasterRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }

                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

     
        private void cmbFind_txt(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void grid_click(object sender, EventArgs e)
        {

        }
    }
}