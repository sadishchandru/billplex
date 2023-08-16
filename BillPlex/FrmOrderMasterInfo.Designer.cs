
namespace BillPlex
{
    partial class FrmOrderMasterInfo
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderMasterInfo));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.txtReasonbox = new DevExpress.XtraEditors.MemoEdit();
            this.lblReason = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNameId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductmodel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductsize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawmaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRaw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelivarydate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWagesforEmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdditionalReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.drpCustCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnProName = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustCode = new DevExpress.XtraEditors.SimpleButton();
            this.btnProColor = new DevExpress.XtraEditors.SimpleButton();
            this.drpProColor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpProductSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpModelCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpModelName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpCustName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpProductName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtTotRawmat = new DevExpress.XtraEditors.TextEdit();
            this.txtRawmatName = new DevExpress.XtraEditors.TextEdit();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.txtWages = new DevExpress.XtraEditors.TextEdit();
            this.txtMaterialwt = new DevExpress.XtraEditors.TextEdit();
            this.txtOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ddOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.ddDDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReasonbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotRawmat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawmatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialwt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 4);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1552, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(691, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(198, 32);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Order Master";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.txtReasonbox);
            this.panelControl2.Controls.Add(this.lblReason);
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Controls.Add(this.labelControl22);
            this.panelControl2.Controls.Add(this.labelControl21);
            this.panelControl2.Controls.Add(this.drpCustCode);
            this.panelControl2.Controls.Add(this.btnProName);
            this.panelControl2.Controls.Add(this.btnCustCode);
            this.panelControl2.Controls.Add(this.btnProColor);
            this.panelControl2.Controls.Add(this.drpProColor);
            this.panelControl2.Controls.Add(this.drpStatus);
            this.panelControl2.Controls.Add(this.drpProductSize);
            this.panelControl2.Controls.Add(this.drpModelCode);
            this.panelControl2.Controls.Add(this.drpModelName);
            this.panelControl2.Controls.Add(this.drpCustName);
            this.panelControl2.Controls.Add(this.drpProductName);
            this.panelControl2.Controls.Add(this.txtQuantity);
            this.panelControl2.Controls.Add(this.txtTotRawmat);
            this.panelControl2.Controls.Add(this.txtRawmatName);
            this.panelControl2.Controls.Add(this.txtType);
            this.panelControl2.Controls.Add(this.txtWages);
            this.panelControl2.Controls.Add(this.txtMaterialwt);
            this.panelControl2.Controls.Add(this.txtOrderNo);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.labelControl14);
            this.panelControl2.Controls.Add(this.labelControl15);
            this.panelControl2.Controls.Add(this.labelControl16);
            this.panelControl2.Controls.Add(this.labelControl17);
            this.panelControl2.Controls.Add(this.labelControl18);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.ddOrderDate);
            this.panelControl2.Controls.Add(this.ddDDate);
            this.panelControl2.Location = new System.Drawing.Point(5, 75);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1551, 703);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.btnUpdate);
            this.panelControl5.Controls.Add(this.btnEdit);
            this.panelControl5.Controls.Add(this.btnAdd);
            this.panelControl5.Controls.Add(this.btnClear);
            this.panelControl5.Controls.Add(this.btnDelete);
            this.panelControl5.Controls.Add(this.btnNew);
            this.panelControl5.Controls.Add(this.btnExit);
            this.panelControl5.Location = new System.Drawing.Point(1400, 90);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(122, 312);
            this.panelControl5.TabIndex = 54;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(21, 146);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(21, 104);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 30);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(21, 59);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(21, 234);
            this.btnClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 30);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(21, 190);
            this.btnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 30);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(21, 12);
            this.btnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 30);
            this.btnNew.TabIndex = 49;
            this.btnNew.Text = "NEW";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(21, 277);
            this.btnExit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 30);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtReasonbox
            // 
            this.txtReasonbox.EnterMoveNextControl = true;
            this.txtReasonbox.Location = new System.Drawing.Point(1031, 351);
            this.txtReasonbox.Name = "txtReasonbox";
            this.txtReasonbox.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReasonbox.Size = new System.Drawing.Size(285, 46);
            this.txtReasonbox.TabIndex = 18;
            // 
            // lblReason
            // 
            this.lblReason.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Appearance.Options.UseFont = true;
            this.lblReason.Location = new System.Drawing.Point(745, 359);
            this.lblReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(237, 18);
            this.lblReason.TabIndex = 52;
            this.lblReason.Text = "Reason for Additional Orders";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetOrderMasterByFilter";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(38, 448);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1484, 250);
            this.gridControl1.TabIndex = 51;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "PRO_GetOrderMasterByFilter";
            queryParameter2.Name = "@OrderNo";
            queryParameter2.Type = typeof(string);
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.StoredProcName = "PRO_GetOrderMasterByFilter";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOrderNo,
            this.colOrderdate,
            this.colCustomcode,
            this.colCode,
            this.colCustomerId,
            this.colName,
            this.colProductNameId,
            this.colproductmodel,
            this.colproductcode,
            this.colproductsize,
            this.colQuantity,
            this.colRawmaterialId,
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
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 80;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.FixedWidth = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 80;
            // 
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.MinWidth = 80;
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 1;
            this.colOrderNo.Width = 80;
            // 
            // colOrderdate
            // 
            this.colOrderdate.FieldName = "Orderdate";
            this.colOrderdate.MinWidth = 80;
            this.colOrderdate.Name = "colOrderdate";
            this.colOrderdate.Visible = true;
            this.colOrderdate.VisibleIndex = 2;
            this.colOrderdate.Width = 80;
            // 
            // colCustomcode
            // 
            this.colCustomcode.FieldName = "Customcode";
            this.colCustomcode.MinWidth = 80;
            this.colCustomcode.Name = "colCustomcode";
            this.colCustomcode.Visible = true;
            this.colCustomcode.VisibleIndex = 3;
            this.colCustomcode.Width = 80;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 80;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 4;
            this.colCode.Width = 80;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.MinWidth = 80;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 5;
            this.colCustomerId.Width = 80;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 80;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 6;
            this.colName.Width = 80;
            // 
            // colProductNameId
            // 
            this.colProductNameId.FieldName = "ProductNameId";
            this.colProductNameId.MinWidth = 80;
            this.colProductNameId.Name = "colProductNameId";
            this.colProductNameId.Visible = true;
            this.colProductNameId.VisibleIndex = 7;
            this.colProductNameId.Width = 80;
            // 
            // colproductmodel
            // 
            this.colproductmodel.FieldName = "productmodel";
            this.colproductmodel.MinWidth = 80;
            this.colproductmodel.Name = "colproductmodel";
            this.colproductmodel.Visible = true;
            this.colproductmodel.VisibleIndex = 8;
            this.colproductmodel.Width = 80;
            // 
            // colproductcode
            // 
            this.colproductcode.FieldName = "productcode";
            this.colproductcode.MinWidth = 80;
            this.colproductcode.Name = "colproductcode";
            this.colproductcode.Visible = true;
            this.colproductcode.VisibleIndex = 9;
            this.colproductcode.Width = 80;
            // 
            // colproductsize
            // 
            this.colproductsize.FieldName = "productsize";
            this.colproductsize.MinWidth = 80;
            this.colproductsize.Name = "colproductsize";
            this.colproductsize.Visible = true;
            this.colproductsize.VisibleIndex = 10;
            this.colproductsize.Width = 80;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 80;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 11;
            this.colQuantity.Width = 80;
            // 
            // colRawmaterialId
            // 
            this.colRawmaterialId.FieldName = "RawmaterialId";
            this.colRawmaterialId.MinWidth = 80;
            this.colRawmaterialId.Name = "colRawmaterialId";
            this.colRawmaterialId.Visible = true;
            this.colRawmaterialId.VisibleIndex = 12;
            this.colRawmaterialId.Width = 80;
            // 
            // colRawType
            // 
            this.colRawType.FieldName = "RawType";
            this.colRawType.MinWidth = 80;
            this.colRawType.Name = "colRawType";
            this.colRawType.Visible = true;
            this.colRawType.VisibleIndex = 13;
            this.colRawType.Width = 80;
            // 
            // colColorId
            // 
            this.colColorId.FieldName = "ColorId";
            this.colColorId.MinWidth = 80;
            this.colColorId.Name = "colColorId";
            this.colColorId.Visible = true;
            this.colColorId.VisibleIndex = 14;
            this.colColorId.Width = 80;
            // 
            // colRawQty
            // 
            this.colRawQty.FieldName = "RawQty";
            this.colRawQty.MinWidth = 80;
            this.colRawQty.Name = "colRawQty";
            this.colRawQty.Visible = true;
            this.colRawQty.VisibleIndex = 15;
            this.colRawQty.Width = 80;
            // 
            // colTotalRaw
            // 
            this.colTotalRaw.FieldName = "TotalRaw";
            this.colTotalRaw.MinWidth = 80;
            this.colTotalRaw.Name = "colTotalRaw";
            this.colTotalRaw.Visible = true;
            this.colTotalRaw.VisibleIndex = 16;
            this.colTotalRaw.Width = 80;
            // 
            // colDelivarydate
            // 
            this.colDelivarydate.FieldName = "Delivarydate";
            this.colDelivarydate.MinWidth = 80;
            this.colDelivarydate.Name = "colDelivarydate";
            this.colDelivarydate.Visible = true;
            this.colDelivarydate.VisibleIndex = 17;
            this.colDelivarydate.Width = 80;
            // 
            // colWagesforEmp
            // 
            this.colWagesforEmp.FieldName = "WagesforEmp";
            this.colWagesforEmp.MinWidth = 80;
            this.colWagesforEmp.Name = "colWagesforEmp";
            this.colWagesforEmp.Visible = true;
            this.colWagesforEmp.VisibleIndex = 18;
            this.colWagesforEmp.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 80;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 19;
            this.colStatus.Width = 80;
            // 
            // colAdditionalReason
            // 
            this.colAdditionalReason.FieldName = "AdditionalReason";
            this.colAdditionalReason.MinWidth = 80;
            this.colAdditionalReason.Name = "colAdditionalReason";
            this.colAdditionalReason.Visible = true;
            this.colAdditionalReason.VisibleIndex = 20;
            this.colAdditionalReason.Width = 80;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(1421, 25);
            this.btnRefresh.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.LookAndFeel.SkinName = "DevExpress Style";
            this.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 60);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Appearance.Options.UseForeColor = true;
            this.labelControl22.Location = new System.Drawing.Point(252, 74);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(10, 18);
            this.labelControl22.TabIndex = 42;
            this.labelControl22.Text = "*";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Appearance.Options.UseForeColor = true;
            this.labelControl21.Location = new System.Drawing.Point(252, 143);
            this.labelControl21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(10, 18);
            this.labelControl21.TabIndex = 41;
            this.labelControl21.Text = "*";
            // 
            // drpCustCode
            // 
            this.drpCustCode.EnterMoveNextControl = true;
            this.drpCustCode.Location = new System.Drawing.Point(334, 146);
            this.drpCustCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpCustCode.Name = "drpCustCode";
            this.drpCustCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCustCode.Size = new System.Drawing.Size(141, 20);
            this.drpCustCode.TabIndex = 3;
            this.drpCustCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit10_SelectedIndexChanged);
            // 
            // btnProName
            // 
            this.btnProName.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProName.Appearance.Options.UseFont = true;
            this.btnProName.Location = new System.Drawing.Point(624, 183);
            this.btnProName.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnProName.LookAndFeel.SkinName = "DevExpress Style";
            this.btnProName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnProName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProName.Name = "btnProName";
            this.btnProName.Size = new System.Drawing.Size(50, 24);
            this.btnProName.TabIndex = 39;
            this.btnProName.Text = "...";
            this.btnProName.Click += new System.EventHandler(this.btnProName_Click);
            // 
            // btnCustCode
            // 
            this.btnCustCode.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustCode.Appearance.Options.UseFont = true;
            this.btnCustCode.Location = new System.Drawing.Point(624, 143);
            this.btnCustCode.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnCustCode.LookAndFeel.SkinName = "DevExpress Style";
            this.btnCustCode.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCustCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustCode.Name = "btnCustCode";
            this.btnCustCode.Size = new System.Drawing.Size(50, 24);
            this.btnCustCode.TabIndex = 38;
            this.btnCustCode.Text = "...";
            this.btnCustCode.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnProColor
            // 
            this.btnProColor.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProColor.Appearance.Options.UseFont = true;
            this.btnProColor.Location = new System.Drawing.Point(1266, 123);
            this.btnProColor.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnProColor.LookAndFeel.SkinName = "DevExpress Style";
            this.btnProColor.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnProColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProColor.Name = "btnProColor";
            this.btnProColor.Size = new System.Drawing.Size(50, 24);
            this.btnProColor.TabIndex = 37;
            this.btnProColor.Text = "...";
            this.btnProColor.Click += new System.EventHandler(this.btnProColor_Click);
            // 
            // drpProColor
            // 
            this.drpProColor.EnterMoveNextControl = true;
            this.drpProColor.Location = new System.Drawing.Point(1031, 126);
            this.drpProColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProColor.Name = "drpProColor";
            this.drpProColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProColor.Size = new System.Drawing.Size(219, 20);
            this.drpProColor.TabIndex = 12;
            // 
            // drpStatus
            // 
            this.drpStatus.EnterMoveNextControl = true;
            this.drpStatus.Location = new System.Drawing.Point(1031, 240);
            this.drpStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpStatus.Name = "drpStatus";
            this.drpStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpStatus.Properties.Items.AddRange(new object[] {
            "Open",
            "Cancel",
            "Complete"});
            this.drpStatus.Size = new System.Drawing.Size(285, 20);
            this.drpStatus.TabIndex = 15;
            // 
            // drpProductSize
            // 
            this.drpProductSize.EnterMoveNextControl = true;
            this.drpProductSize.Location = new System.Drawing.Point(334, 300);
            this.drpProductSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProductSize.Name = "drpProductSize";
            this.drpProductSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProductSize.Size = new System.Drawing.Size(285, 20);
            this.drpProductSize.TabIndex = 8;
            this.drpProductSize.SelectedIndexChanged += new System.EventHandler(this.drpProductSize_SelectedIndexChanged);
            // 
            // drpModelCode
            // 
            this.drpModelCode.EnterMoveNextControl = true;
            this.drpModelCode.Location = new System.Drawing.Point(334, 262);
            this.drpModelCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpModelCode.Name = "drpModelCode";
            this.drpModelCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpModelCode.Size = new System.Drawing.Size(285, 20);
            this.drpModelCode.TabIndex = 7;
            this.drpModelCode.SelectedIndexChanged += new System.EventHandler(this.drpModelCode_SelectedIndexChanged);
            // 
            // drpModelName
            // 
            this.drpModelName.EnterMoveNextControl = true;
            this.drpModelName.Location = new System.Drawing.Point(334, 225);
            this.drpModelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpModelName.Name = "drpModelName";
            this.drpModelName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpModelName.Size = new System.Drawing.Size(285, 20);
            this.drpModelName.TabIndex = 6;
            this.drpModelName.SelectedIndexChanged += new System.EventHandler(this.drpModelName_SelectedIndexChanged);
            // 
            // drpCustName
            // 
            this.drpCustName.Enabled = false;
            this.drpCustName.EnterMoveNextControl = true;
            this.drpCustName.Location = new System.Drawing.Point(480, 146);
            this.drpCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpCustName.Name = "drpCustName";
            this.drpCustName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCustName.Size = new System.Drawing.Size(139, 20);
            this.drpCustName.TabIndex = 4;
            this.drpCustName.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit10_SelectedIndexChanged);
            // 
            // drpProductName
            // 
            this.drpProductName.EnterMoveNextControl = true;
            this.drpProductName.Location = new System.Drawing.Point(334, 187);
            this.drpProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProductName.Name = "drpProductName";
            this.drpProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProductName.Size = new System.Drawing.Size(285, 20);
            this.drpProductName.TabIndex = 5;
            this.drpProductName.SelectedIndexChanged += new System.EventHandler(this.drpProductName_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.EnterMoveNextControl = true;
            this.txtQuantity.Location = new System.Drawing.Point(1031, 166);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(285, 20);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // txtTotRawmat
            // 
            this.txtTotRawmat.Enabled = false;
            this.txtTotRawmat.EnterMoveNextControl = true;
            this.txtTotRawmat.Location = new System.Drawing.Point(1031, 278);
            this.txtTotRawmat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotRawmat.Name = "txtTotRawmat";
            this.txtTotRawmat.Size = new System.Drawing.Size(285, 20);
            this.txtTotRawmat.TabIndex = 16;
            // 
            // txtRawmatName
            // 
            this.txtRawmatName.Enabled = false;
            this.txtRawmatName.EnterMoveNextControl = true;
            this.txtRawmatName.Location = new System.Drawing.Point(1031, 87);
            this.txtRawmatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawmatName.Name = "txtRawmatName";
            this.txtRawmatName.Size = new System.Drawing.Size(285, 20);
            this.txtRawmatName.TabIndex = 11;
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.EnterMoveNextControl = true;
            this.txtType.Location = new System.Drawing.Point(1031, 48);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(285, 20);
            this.txtType.TabIndex = 10;
            // 
            // txtWages
            // 
            this.txtWages.Enabled = false;
            this.txtWages.EnterMoveNextControl = true;
            this.txtWages.Location = new System.Drawing.Point(1031, 321);
            this.txtWages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWages.Name = "txtWages";
            this.txtWages.Size = new System.Drawing.Size(285, 20);
            this.txtWages.TabIndex = 17;
            // 
            // txtMaterialwt
            // 
            this.txtMaterialwt.Enabled = false;
            this.txtMaterialwt.EnterMoveNextControl = true;
            this.txtMaterialwt.Location = new System.Drawing.Point(334, 339);
            this.txtMaterialwt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterialwt.Name = "txtMaterialwt";
            this.txtMaterialwt.Size = new System.Drawing.Size(285, 20);
            this.txtMaterialwt.TabIndex = 9;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.EnterMoveNextControl = true;
            this.txtOrderNo.Location = new System.Drawing.Point(334, 74);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(285, 20);
            this.txtOrderNo.TabIndex = 1;
            this.txtOrderNo.EditValueChanged += new System.EventHandler(this.txtOrderNo_EditValueChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(745, 323);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(169, 18);
            this.labelControl12.TabIndex = 17;
            this.labelControl12.Text = "Wages for Employee";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(745, 99);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(159, 18);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "Raw Material Name";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(745, 138);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(109, 18);
            this.labelControl13.TabIndex = 14;
            this.labelControl13.Text = "Product Color";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(745, 176);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(71, 18);
            this.labelControl14.TabIndex = 13;
            this.labelControl14.Text = "Quantity";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(745, 215);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(111, 18);
            this.labelControl15.TabIndex = 12;
            this.labelControl15.Text = "Delivery Date";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(745, 252);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(53, 18);
            this.labelControl16.TabIndex = 11;
            this.labelControl16.Text = "Status";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(745, 280);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(160, 18);
            this.labelControl17.TabIndex = 10;
            this.labelControl17.Text = "Total Raw Material ";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(745, 63);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(39, 18);
            this.labelControl18.TabIndex = 9;
            this.labelControl18.Text = "Type";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(38, 106);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(90, 18);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Order Date";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(38, 144);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(191, 18);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Customer Code / Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(38, 183);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(114, 18);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Product Name";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(38, 221);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 18);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Model Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 260);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(95, 18);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Model Code";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 297);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 18);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Product Size";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 338);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(177, 18);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Material Weight/Item";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 71);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 18);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Order No";
            // 
            // ddOrderDate
            // 
            this.ddOrderDate.EditValue = null;
            this.ddOrderDate.EnterMoveNextControl = true;
            this.ddOrderDate.Location = new System.Drawing.Point(334, 109);
            this.ddOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddOrderDate.Name = "ddOrderDate";
            this.ddOrderDate.Properties.BeepOnError = false;
            this.ddOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddOrderDate.Properties.DisplayFormat.FormatString = "";
            this.ddOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddOrderDate.Properties.EditFormat.FormatString = "";
            this.ddOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddOrderDate.Properties.MaskSettings.Set("mask", "d");
            this.ddOrderDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddOrderDate.Size = new System.Drawing.Size(285, 20);
            this.ddOrderDate.TabIndex = 2;
            // 
            // ddDDate
            // 
            this.ddDDate.EditValue = null;
            this.ddDDate.EnterMoveNextControl = true;
            this.ddDDate.Location = new System.Drawing.Point(1031, 208);
            this.ddDDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddDDate.Name = "ddDDate";
            this.ddDDate.Properties.BeepOnError = false;
            this.ddDDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddDDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddDDate.Properties.DisplayFormat.FormatString = "";
            this.ddDDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddDDate.Properties.EditFormat.FormatString = "";
            this.ddDDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddDDate.Properties.MaskSettings.Set("mask", "d");
            this.ddDDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddDDate.Size = new System.Drawing.Size(285, 20);
            this.ddDDate.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Order Details";
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1564, 785);
            this.panelControl3.TabIndex = 2;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Location = new System.Drawing.Point(10, 67);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(125, 25);
            this.panelControl4.TabIndex = 54;
            // 
            // FrmOrderMasterInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 804);
            this.Controls.Add(this.panelControl3);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOrderMasterInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderMasterInfo";
            this.Load += new System.EventHandler(this.FrmOrderMasterInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReasonbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotRawmat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawmatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialwt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit drpCustCode;
        private DevExpress.XtraEditors.SimpleButton btnProName;
        private DevExpress.XtraEditors.SimpleButton btnCustCode;
        private DevExpress.XtraEditors.SimpleButton btnProColor;
        private DevExpress.XtraEditors.ComboBoxEdit drpProColor;
        private DevExpress.XtraEditors.ComboBoxEdit drpStatus;
        private DevExpress.XtraEditors.ComboBoxEdit drpProductSize;
        private DevExpress.XtraEditors.ComboBoxEdit drpModelCode;
        private DevExpress.XtraEditors.ComboBoxEdit drpModelName;
        private DevExpress.XtraEditors.ComboBoxEdit drpCustName;
        private DevExpress.XtraEditors.ComboBoxEdit drpProductName;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtTotRawmat;
        private DevExpress.XtraEditors.TextEdit txtRawmatName;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.TextEdit txtWages;
        private DevExpress.XtraEditors.TextEdit txtMaterialwt;
        private DevExpress.XtraEditors.TextEdit txtOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.DateEdit ddOrderDate;
        private DevExpress.XtraEditors.DateEdit ddDDate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblReason;
        private DevExpress.XtraEditors.MemoEdit txtReasonbox;
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
        private DevExpress.XtraGrid.Columns.GridColumn colRawmaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn colRawType;
        private DevExpress.XtraGrid.Columns.GridColumn colColorId;
        private DevExpress.XtraGrid.Columns.GridColumn colRawQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRaw;
        private DevExpress.XtraGrid.Columns.GridColumn colDelivarydate;
        private DevExpress.XtraGrid.Columns.GridColumn colWagesforEmp;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalReason;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
    }
}