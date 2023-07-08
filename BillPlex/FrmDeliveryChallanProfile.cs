﻿using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmDeliveryChallanProfile : DevExpress.XtraEditors.XtraForm
    {
        private DeliveryChallanInfro DeliveryChallanInfoRequest;
        private FrmDeliveryChallanInfo DeliveryChallanRequest;
        private GridView gridView;
        public FrmDeliveryChallanProfile()
        {
            DeliveryChallanInfoRequest = new DeliveryChallanInfro();
            InitializeComponent();
            DeliveryChallanInfoRequest.ConnectionString = ConfigurationManager.ConnectionStrings["BillPlex"].ConnectionString;
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            // gridControl1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmDeliveryChallanInfo CI = new FrmDeliveryChallanInfo();
            CI.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                DeliveryChallanInfoRequest.Id = (Int64)gridView1.GetRowCellValue(rowHandle, "Id");
            }
            DeliveryChallanInfoRequest.Delete();

            if (DeliveryChallanInfoRequest.Result.Status == ResultStatus.Success)
            {
                XtraMessageBox.Show(DeliveryChallanInfoRequest.Result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          //  try
          //  {
          //      var selectedRows = gridView1.GetSelectedRows();
          //
          //      foreach (var rowHandle in selectedRows)
          //      {
          //


      //             drpCName.Text = gridView1.GetRowCellValue(rowHandle, "CompanyMasterId").ToString();
      //             drpCCom.Text = gridView1.GetRowCellValue(rowHandle, "ClientCompanyId").ToString();
      //             drpSCCom.Text = gridView1.GetRowCellValue(rowHandle, "SubclientCompanyId").ToString();
      //             txtDirector.Text = gridView1.GetRowCellValue(rowHandle, "Director").ToString();
      //             txtContractor.Text = gridView1.GetRowCellValue(rowHandle, "Contractor").ToString();
      //             txtSCont.Text = gridView1.GetRowCellValue(rowHandle, "Subcontractor").ToString();
      //             drpCCode.Text = gridView1.GetRowCellValue(rowHandle, "CustomerCode").ToString();
      //             drpCName.Text = gridView1.GetRowCellValue(rowHandle, "CustomerName").ToString();
      //             drpOrderCode.Text = gridView1.GetRowCellValue(rowHandle, "OrderNo").ToString();
      //             drpOrderCode.SelectedIndex = DeliveryChallanRequest.OrderMasterList.FindIndex(x => x.Id == Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "OrderNo").ToString()));
      //             var datete = gridView1.GetRowCellValue(rowHandle, "OrderDate").ToString();
      //             ddODate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
      //
      //             drpMCode.Text = gridView1.GetRowCellValue(rowHandle, "ModelCode").ToString();
      //             drpMName.Text = gridView1.GetRowCellValue(rowHandle, "ModelName").ToString();
      //             txtProductName.Text = gridView1.GetRowCellValue(rowHandle, "ProductName").ToString();
      //             drpPSize.Text = gridView1.GetRowCellValue(rowHandle, "ProductSize").ToString();
      //             txtRawMaterial.Text = gridView1.GetRowCellValue(rowHandle, "RawMaterial").ToString();
      //             txtQuantity.Text = gridView1.GetRowCellValue(rowHandle, "Quantity").ToString();
      //             txtWeight.Text = gridView1.GetRowCellValue(rowHandle, "Weight").ToString();
      //             txtExcess.Text = gridView1.GetRowCellValue(rowHandle, "Excess").ToString();
      //             drpColor.SelectedIndex = DeliveryChallanRequest.ColorMasterList.FindIndex(x => x.Id == Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "ColourName").ToString()));
      //             txtType.Text = gridView1.GetRowCellValue(rowHandle, "RawType").ToString();
      //             txtAvlQty.Text = gridView1.GetRowCellValue(rowHandle, "AvlQty").ToString();
      //             txtShortage.Text = gridView1.GetRowCellValue(rowHandle, "Shortage").ToString();
      //             txtDCNo.Text = gridView1.GetRowCellValue(rowHandle, "DcNo").ToString();
      //
      //             datete = gridView1.GetRowCellValue(rowHandle, "DcDate").ToString();
      //             ddDCDate.Text = datete != "" ? DateTime.Parse(datete).ToString("MM-dd-yyyy") : "";
      //
      //
      //         }
      //         btnAdd.Enabled = false;
      //         btnEdit.Enabled = false;
      //         btnDelete.Enabled = true;
      //         btnUpdate.Enabled = true;
      //     }
   //      catch (Exception ex)
   //      {
   //          throw ex;
   //      }
   //
   //  }
   //
     //
     //
     //      var selectedRow = gridView1.GetSelectedRows();
     //
     //      DeliveryChallanRequest = new FrmDeliveryChallanInfo();
     //
     //      DeliveryChallanRequest.BindData(gridView1);
     //
     //      //CompanyInfo.MdiParent = this;
       //     DeliveryChallanRequest.Show();
        }
    }
}