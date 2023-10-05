
namespace BillPlex
{
    partial class FrmOrderMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderMaster));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNameId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductmodel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductsize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rawmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRaw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelivarydate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWagesforEmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdditionalReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 4);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1523, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(662, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(198, 32);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Order Master";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Controls.Add(this.btnNew);
            this.panelControl2.Controls.Add(this.btnExit);
            this.panelControl2.Controls.Add(this.btnUpdate);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnClear);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.btnEdit);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Location = new System.Drawing.Point(5, 61);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1523, 555);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetOrderMaster";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(19, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1321, 486);
            this.gridControl1.TabIndex = 59;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetOrderMaster";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetOrderMaster";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOrderNo,
            this.colOrderdate,
            this.colCustomcode,
            this.ColProductName,
            this.colCode,
            this.colCustomerId,
            this.colName,
            this.colProductNameId,
            this.colproductmodel,
            this.colproductcode,
            this.colproductsize,
            this.colQuantity,
            this.Rawmaterial,
            this.colRawType,
            this.colColorId,
            this.colRawQty,
            this.colTotalRaw,
            this.colDelivarydate,
            this.colWagesforEmp,
            this.colStatus,
            this.colAdditionalReason});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 80;
            this.colId.Name = "colId";
            this.colId.Width = 80;
            // 
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.MinWidth = 80;
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 0;
            this.colOrderNo.Width = 80;
            // 
            // colOrderdate
            // 
            this.colOrderdate.FieldName = "Orderdate";
            this.colOrderdate.MinWidth = 80;
            this.colOrderdate.Name = "colOrderdate";
            this.colOrderdate.Visible = true;
            this.colOrderdate.VisibleIndex = 1;
            this.colOrderdate.Width = 80;
            // 
            // colCustomcode
            // 
            this.colCustomcode.FieldName = "Customcode";
            this.colCustomcode.MinWidth = 80;
            this.colCustomcode.Name = "colCustomcode";
            this.colCustomcode.Width = 80;
            // 
            // ColProductName
            // 
            this.ColProductName.FieldName = "ProductName";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.Visible = true;
            this.ColProductName.VisibleIndex = 4;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 80;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 2;
            this.colCode.Width = 80;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.MinWidth = 80;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Width = 80;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 80;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 80;
            // 
            // colProductNameId
            // 
            this.colProductNameId.FieldName = "ProductNameId";
            this.colProductNameId.MinWidth = 80;
            this.colProductNameId.Name = "colProductNameId";
            this.colProductNameId.Width = 80;
            // 
            // colproductmodel
            // 
            this.colproductmodel.FieldName = "productmodel";
            this.colproductmodel.MinWidth = 80;
            this.colproductmodel.Name = "colproductmodel";
            this.colproductmodel.Visible = true;
            this.colproductmodel.VisibleIndex = 5;
            this.colproductmodel.Width = 80;
            // 
            // colproductcode
            // 
            this.colproductcode.FieldName = "productcode";
            this.colproductcode.MinWidth = 80;
            this.colproductcode.Name = "colproductcode";
            this.colproductcode.Visible = true;
            this.colproductcode.VisibleIndex = 6;
            this.colproductcode.Width = 80;
            // 
            // colproductsize
            // 
            this.colproductsize.FieldName = "productsize";
            this.colproductsize.MinWidth = 80;
            this.colproductsize.Name = "colproductsize";
            this.colproductsize.Visible = true;
            this.colproductsize.VisibleIndex = 7;
            this.colproductsize.Width = 80;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 80;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 8;
            this.colQuantity.Width = 80;
            // 
            // Rawmaterial
            // 
            this.Rawmaterial.Caption = "Rawmaterial";
            this.Rawmaterial.FieldName = "RawmaterialId";
            this.Rawmaterial.MinWidth = 80;
            this.Rawmaterial.Name = "Rawmaterial";
            this.Rawmaterial.Visible = true;
            this.Rawmaterial.VisibleIndex = 9;
            this.Rawmaterial.Width = 80;
            // 
            // colRawType
            // 
            this.colRawType.FieldName = "RawType";
            this.colRawType.MinWidth = 80;
            this.colRawType.Name = "colRawType";
            this.colRawType.Visible = true;
            this.colRawType.VisibleIndex = 10;
            this.colRawType.Width = 80;
            // 
            // colColorId
            // 
            this.colColorId.Caption = "Colour";
            this.colColorId.FieldName = "ColorId";
            this.colColorId.MinWidth = 80;
            this.colColorId.Name = "colColorId";
            this.colColorId.Visible = true;
            this.colColorId.VisibleIndex = 11;
            this.colColorId.Width = 80;
            // 
            // colRawQty
            // 
            this.colRawQty.FieldName = "RawQty";
            this.colRawQty.MinWidth = 80;
            this.colRawQty.Name = "colRawQty";
            this.colRawQty.Visible = true;
            this.colRawQty.VisibleIndex = 12;
            this.colRawQty.Width = 80;
            // 
            // colTotalRaw
            // 
            this.colTotalRaw.FieldName = "TotalRaw";
            this.colTotalRaw.MinWidth = 80;
            this.colTotalRaw.Name = "colTotalRaw";
            this.colTotalRaw.Visible = true;
            this.colTotalRaw.VisibleIndex = 13;
            this.colTotalRaw.Width = 80;
            // 
            // colDelivarydate
            // 
            this.colDelivarydate.FieldName = "Delivarydate";
            this.colDelivarydate.MinWidth = 80;
            this.colDelivarydate.Name = "colDelivarydate";
            this.colDelivarydate.Visible = true;
            this.colDelivarydate.VisibleIndex = 14;
            this.colDelivarydate.Width = 80;
            // 
            // colWagesforEmp
            // 
            this.colWagesforEmp.FieldName = "WagesforEmp";
            this.colWagesforEmp.MinWidth = 80;
            this.colWagesforEmp.Name = "colWagesforEmp";
            this.colWagesforEmp.Visible = true;
            this.colWagesforEmp.VisibleIndex = 15;
            this.colWagesforEmp.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 80;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 16;
            this.colStatus.Width = 80;
            // 
            // colAdditionalReason
            // 
            this.colAdditionalReason.FieldName = "AdditionalReason";
            this.colAdditionalReason.MinWidth = 80;
            this.colAdditionalReason.Name = "colAdditionalReason";
            this.colAdditionalReason.Visible = true;
            this.colAdditionalReason.VisibleIndex = 17;
            this.colAdditionalReason.Width = 80;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(1373, 69);
            this.btnRefresh.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.LookAndFeel.SkinName = "DevExpress Style";
            this.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 82);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(1383, 183);
            this.btnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 30);
            this.btnNew.TabIndex = 57;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(1383, 448);
            this.btnExit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 30);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "EXIT";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(1383, 317);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "UPDATE";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(1383, 360);
            this.btnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 30);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(1383, 405);
            this.btnClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 30);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "CLEAR";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(1383, 229);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "ADD";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(1383, 275);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 30);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.Text = "EDIT";
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(1362, 58);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(124, 430);
            this.panelControl4.TabIndex = 60;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1533, 620);
            this.panelControl3.TabIndex = 2;
            // 
            // FrmOrderMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1557, 644);
            this.Controls.Add(this.panelControl3);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(500, 32);
            this.Name = "FrmOrderMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOrderMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderdate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomcode;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNameId;
        private DevExpress.XtraGrid.Columns.GridColumn colproductmodel;
        private DevExpress.XtraGrid.Columns.GridColumn colproductcode;
        private DevExpress.XtraGrid.Columns.GridColumn colproductsize;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn Rawmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colRawType;
        private DevExpress.XtraGrid.Columns.GridColumn colColorId;
        private DevExpress.XtraGrid.Columns.GridColumn colRawQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRaw;
        private DevExpress.XtraGrid.Columns.GridColumn colDelivarydate;
        private DevExpress.XtraGrid.Columns.GridColumn colWagesforEmp;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalReason;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn ColProductName;
    }
}