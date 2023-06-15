using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPlex
{
    public partial class FrmOrderMaster : DevExpress.XtraEditors.XtraForm
    {
        private OrderMasterInfo OrderMasterRequest;
        public FrmOrderMaster()
        {
            InitializeComponent();
            OrderMasterRequest = new OrderMasterInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                var id = gridView1.GetRowCellValue(rowHandle, "Id");

                OrderMasterRequest.Id = (int)id;
            }

            OrderMasterRequest.Delete();
        }
    }
}