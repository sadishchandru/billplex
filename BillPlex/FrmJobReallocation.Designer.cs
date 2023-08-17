
namespace BillPlex
{
    partial class FrmJobReallocation
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJobReallocation));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnTransfer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_JobCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientCompany1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSize1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightKg1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExcess1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvlQty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortage1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subContractor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirector1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPendingQty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreceived1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWages1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentWt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceivingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalanceWt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeduction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconveyance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colincentive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Orderno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvlQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubContractor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPendingQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.received = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalanceWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmployeeCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.chkViewReceivedPending = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.lblWeight = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtShortage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtExcess = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtComName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.txtClientCompany = new DevExpress.XtraEditors.TextEdit();
            this.txtSubClient = new DevExpress.XtraEditors.TextEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubContractor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.txtClientName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.txtDirector = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.txtJEmpName = new DevExpress.XtraEditors.TextEdit();
            this.drpEmpCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.ddReceivingDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPendingQty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtReceivedQty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProColor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtProSize = new DevExpress.XtraEditors.TextEdit();
            this.txtEmpCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtRawMaterial = new DevExpress.XtraEditors.TextEdit();
            this.txtRawType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuanity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtProModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmpName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewReceivedPending.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubContractor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceivingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceivingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPendingQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceivedQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuanity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.panelControl7);
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.txtEmployeeCode);
            this.panelControl1.Controls.Add(this.labelControl30);
            this.panelControl1.Controls.Add(this.chkViewReceivedPending);
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1797, 802);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl7
            // 
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.labelControl2);
            this.panelControl7.Location = new System.Drawing.Point(17, 51);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(239, 21);
            this.panelControl7.TabIndex = 29;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(227, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Job Received Pending Data:";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.btnClear);
            this.panelControl6.Controls.Add(this.btnTransfer);
            this.panelControl6.Controls.Add(this.btn_JobCancel);
            this.panelControl6.Location = new System.Drawing.Point(1523, 57);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(269, 347);
            this.panelControl6.TabIndex = 32;
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(90, 267);
            this.btnClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Appearance.Options.UseFont = true;
            this.btnTransfer.Location = new System.Drawing.Point(90, 156);
            this.btnTransfer.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnTransfer.LookAndFeel.SkinName = "DevExpress Style";
            this.btnTransfer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(121, 75);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer\r\n   To\r\n   This\r\nEmployee";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btn_JobCancel
            // 
            this.btn_JobCancel.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JobCancel.Appearance.Options.UseFont = true;
            this.btn_JobCancel.Location = new System.Drawing.Point(90, 38);
            this.btn_JobCancel.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btn_JobCancel.LookAndFeel.SkinName = "DevExpress Style";
            this.btn_JobCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_JobCancel.Name = "btn_JobCancel";
            this.btn_JobCancel.Size = new System.Drawing.Size(121, 75);
            this.btn_JobCancel.TabIndex = 0;
            this.btn_JobCancel.Text = " Cancel \r\n  This \r\n Giving";
            this.btn_JobCancel.Click += new System.EventHandler(this.btnJobCancel_Click);
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.gridControl2);
            this.panelControl5.Controls.Add(this.gridControl1);
            this.panelControl5.Controls.Add(this.labelControl31);
            this.panelControl5.Location = new System.Drawing.Point(5, 422);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1787, 375);
            this.panelControl5.TabIndex = 31;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "PRO_GetJobGivingWithoutDCReceivedFilter";
            this.gridControl2.DataSource = this.sqlDataSource2;
            this.gridControl2.Location = new System.Drawing.Point(7, 28);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1746, 333);
            this.gridControl2.TabIndex = 30;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "BillPlex";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery3.Name = "PRO_GetJobGivingWithoutDCReceivedFilter";
            queryParameter3.Name = "@SearchKey";
            queryParameter3.Type = typeof(string);
            storedProcQuery3.Parameters.Add(queryParameter3);
            storedProcQuery3.StoredProcName = "PRO_GetJobGivingWithoutDCReceivedFilter";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colEmployeeCode1,
            this.colEmployeeName1,
            this.colCompanyName1,
            this.colClientCompany1,
            this.colSubClientCompany1,
            this.colOrderNo,
            this.colOrderDate1,
            this.colCustomerCode1,
            this.colCustomerName1,
            this.colModelName1,
            this.colModelCode1,
            this.colProductSize1,
            this.colRawMaterial1,
            this.colWeightKg1,
            this.colExcess1,
            this.colColor1,
            this.colType1,
            this.colAvlQty1,
            this.colShortage1,
            this.colClientName1,
            this.colTotalQty1,
            this.colTotalWt1,
            this.subContractor,
            this.colDirector1,
            this.colPendingQty1,
            this.colreceived1,
            this.colWages1,
            this.colCurrentWt1,
            this.ReceivingDate,
            this.colBalanceWt1,
            this.colDeduction,
            this.colconveyance,
            this.colincentive,
            this.colNetAmt,
            this.colTotalAmt});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.MinWidth = 80;
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 80;
            // 
            // colEmployeeCode1
            // 
            this.colEmployeeCode1.FieldName = "EmployeeCode";
            this.colEmployeeCode1.MinWidth = 80;
            this.colEmployeeCode1.Name = "colEmployeeCode1";
            this.colEmployeeCode1.Visible = true;
            this.colEmployeeCode1.VisibleIndex = 1;
            this.colEmployeeCode1.Width = 80;
            // 
            // colEmployeeName1
            // 
            this.colEmployeeName1.FieldName = "EmployeeName";
            this.colEmployeeName1.MinWidth = 80;
            this.colEmployeeName1.Name = "colEmployeeName1";
            this.colEmployeeName1.Visible = true;
            this.colEmployeeName1.VisibleIndex = 2;
            this.colEmployeeName1.Width = 80;
            // 
            // colCompanyName1
            // 
            this.colCompanyName1.FieldName = "CompanyName";
            this.colCompanyName1.MinWidth = 80;
            this.colCompanyName1.Name = "colCompanyName1";
            this.colCompanyName1.Visible = true;
            this.colCompanyName1.VisibleIndex = 3;
            this.colCompanyName1.Width = 80;
            // 
            // colClientCompany1
            // 
            this.colClientCompany1.FieldName = "ClientCompany";
            this.colClientCompany1.MinWidth = 80;
            this.colClientCompany1.Name = "colClientCompany1";
            this.colClientCompany1.Visible = true;
            this.colClientCompany1.VisibleIndex = 4;
            this.colClientCompany1.Width = 80;
            // 
            // colSubClientCompany1
            // 
            this.colSubClientCompany1.FieldName = "SubClientCompany";
            this.colSubClientCompany1.MinWidth = 80;
            this.colSubClientCompany1.Name = "colSubClientCompany1";
            this.colSubClientCompany1.Visible = true;
            this.colSubClientCompany1.VisibleIndex = 5;
            this.colSubClientCompany1.Width = 80;
            // 
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.MinWidth = 80;
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 6;
            this.colOrderNo.Width = 80;
            // 
            // colOrderDate1
            // 
            this.colOrderDate1.FieldName = "Orderdate";
            this.colOrderDate1.MinWidth = 80;
            this.colOrderDate1.Name = "colOrderDate1";
            this.colOrderDate1.Visible = true;
            this.colOrderDate1.VisibleIndex = 7;
            this.colOrderDate1.Width = 80;
            // 
            // colCustomerCode1
            // 
            this.colCustomerCode1.FieldName = "CustomerCode";
            this.colCustomerCode1.MinWidth = 80;
            this.colCustomerCode1.Name = "colCustomerCode1";
            this.colCustomerCode1.Visible = true;
            this.colCustomerCode1.VisibleIndex = 8;
            this.colCustomerCode1.Width = 80;
            // 
            // colCustomerName1
            // 
            this.colCustomerName1.FieldName = "CustomerName";
            this.colCustomerName1.MinWidth = 80;
            this.colCustomerName1.Name = "colCustomerName1";
            this.colCustomerName1.Visible = true;
            this.colCustomerName1.VisibleIndex = 9;
            this.colCustomerName1.Width = 80;
            // 
            // colModelName1
            // 
            this.colModelName1.FieldName = "ModelName";
            this.colModelName1.MinWidth = 80;
            this.colModelName1.Name = "colModelName1";
            this.colModelName1.Visible = true;
            this.colModelName1.VisibleIndex = 10;
            this.colModelName1.Width = 80;
            // 
            // colModelCode1
            // 
            this.colModelCode1.FieldName = "ModelCode";
            this.colModelCode1.MinWidth = 80;
            this.colModelCode1.Name = "colModelCode1";
            this.colModelCode1.Visible = true;
            this.colModelCode1.VisibleIndex = 11;
            this.colModelCode1.Width = 80;
            // 
            // colProductSize1
            // 
            this.colProductSize1.FieldName = "ProductSize";
            this.colProductSize1.MinWidth = 80;
            this.colProductSize1.Name = "colProductSize1";
            this.colProductSize1.Visible = true;
            this.colProductSize1.VisibleIndex = 12;
            this.colProductSize1.Width = 80;
            // 
            // colRawMaterial1
            // 
            this.colRawMaterial1.FieldName = "RawMaterial";
            this.colRawMaterial1.MinWidth = 80;
            this.colRawMaterial1.Name = "colRawMaterial1";
            this.colRawMaterial1.Visible = true;
            this.colRawMaterial1.VisibleIndex = 13;
            this.colRawMaterial1.Width = 80;
            // 
            // colWeightKg1
            // 
            this.colWeightKg1.FieldName = "WeightKg";
            this.colWeightKg1.MinWidth = 80;
            this.colWeightKg1.Name = "colWeightKg1";
            this.colWeightKg1.Visible = true;
            this.colWeightKg1.VisibleIndex = 14;
            this.colWeightKg1.Width = 80;
            // 
            // colExcess1
            // 
            this.colExcess1.FieldName = "Excess";
            this.colExcess1.MinWidth = 80;
            this.colExcess1.Name = "colExcess1";
            this.colExcess1.Visible = true;
            this.colExcess1.VisibleIndex = 15;
            this.colExcess1.Width = 80;
            // 
            // colColor1
            // 
            this.colColor1.FieldName = "Color";
            this.colColor1.MinWidth = 80;
            this.colColor1.Name = "colColor1";
            this.colColor1.Visible = true;
            this.colColor1.VisibleIndex = 16;
            this.colColor1.Width = 80;
            // 
            // colType1
            // 
            this.colType1.FieldName = "Type";
            this.colType1.MinWidth = 80;
            this.colType1.Name = "colType1";
            this.colType1.Visible = true;
            this.colType1.VisibleIndex = 17;
            this.colType1.Width = 80;
            // 
            // colAvlQty1
            // 
            this.colAvlQty1.FieldName = "AvlQty";
            this.colAvlQty1.MinWidth = 80;
            this.colAvlQty1.Name = "colAvlQty1";
            this.colAvlQty1.Visible = true;
            this.colAvlQty1.VisibleIndex = 18;
            this.colAvlQty1.Width = 80;
            // 
            // colShortage1
            // 
            this.colShortage1.FieldName = "Shortage";
            this.colShortage1.MinWidth = 80;
            this.colShortage1.Name = "colShortage1";
            this.colShortage1.Visible = true;
            this.colShortage1.VisibleIndex = 19;
            this.colShortage1.Width = 80;
            // 
            // colClientName1
            // 
            this.colClientName1.FieldName = "ClientName";
            this.colClientName1.MinWidth = 80;
            this.colClientName1.Name = "colClientName1";
            this.colClientName1.Visible = true;
            this.colClientName1.VisibleIndex = 20;
            this.colClientName1.Width = 80;
            // 
            // colTotalQty1
            // 
            this.colTotalQty1.FieldName = "TotalQty";
            this.colTotalQty1.MinWidth = 80;
            this.colTotalQty1.Name = "colTotalQty1";
            this.colTotalQty1.Visible = true;
            this.colTotalQty1.VisibleIndex = 21;
            this.colTotalQty1.Width = 80;
            // 
            // colTotalWt1
            // 
            this.colTotalWt1.FieldName = "TotalWt";
            this.colTotalWt1.MinWidth = 80;
            this.colTotalWt1.Name = "colTotalWt1";
            this.colTotalWt1.Visible = true;
            this.colTotalWt1.VisibleIndex = 22;
            this.colTotalWt1.Width = 80;
            // 
            // subContractor
            // 
            this.subContractor.Caption = "subContractor";
            this.subContractor.FieldName = "subContractor";
            this.subContractor.MinWidth = 80;
            this.subContractor.Name = "subContractor";
            this.subContractor.Visible = true;
            this.subContractor.VisibleIndex = 23;
            this.subContractor.Width = 80;
            // 
            // colDirector1
            // 
            this.colDirector1.FieldName = "Director";
            this.colDirector1.MinWidth = 80;
            this.colDirector1.Name = "colDirector1";
            this.colDirector1.Visible = true;
            this.colDirector1.VisibleIndex = 24;
            this.colDirector1.Width = 80;
            // 
            // colPendingQty1
            // 
            this.colPendingQty1.FieldName = "PendingQty";
            this.colPendingQty1.MinWidth = 80;
            this.colPendingQty1.Name = "colPendingQty1";
            this.colPendingQty1.Visible = true;
            this.colPendingQty1.VisibleIndex = 25;
            this.colPendingQty1.Width = 80;
            // 
            // colreceived1
            // 
            this.colreceived1.FieldName = "received";
            this.colreceived1.MinWidth = 80;
            this.colreceived1.Name = "colreceived1";
            this.colreceived1.Visible = true;
            this.colreceived1.VisibleIndex = 26;
            this.colreceived1.Width = 80;
            // 
            // colWages1
            // 
            this.colWages1.FieldName = "Wages";
            this.colWages1.MinWidth = 80;
            this.colWages1.Name = "colWages1";
            this.colWages1.Visible = true;
            this.colWages1.VisibleIndex = 27;
            this.colWages1.Width = 80;
            // 
            // colCurrentWt1
            // 
            this.colCurrentWt1.FieldName = "CurrentWt";
            this.colCurrentWt1.MinWidth = 80;
            this.colCurrentWt1.Name = "colCurrentWt1";
            this.colCurrentWt1.Visible = true;
            this.colCurrentWt1.VisibleIndex = 28;
            this.colCurrentWt1.Width = 80;
            // 
            // ReceivingDate
            // 
            this.ReceivingDate.Caption = "ReceivingDate";
            this.ReceivingDate.FieldName = "ReceivingDate";
            this.ReceivingDate.MinWidth = 80;
            this.ReceivingDate.Name = "ReceivingDate";
            this.ReceivingDate.Visible = true;
            this.ReceivingDate.VisibleIndex = 29;
            this.ReceivingDate.Width = 80;
            // 
            // colBalanceWt1
            // 
            this.colBalanceWt1.FieldName = "BalanceWt";
            this.colBalanceWt1.MinWidth = 80;
            this.colBalanceWt1.Name = "colBalanceWt1";
            this.colBalanceWt1.Visible = true;
            this.colBalanceWt1.VisibleIndex = 30;
            this.colBalanceWt1.Width = 80;
            // 
            // colDeduction
            // 
            this.colDeduction.FieldName = "Deduction";
            this.colDeduction.MinWidth = 80;
            this.colDeduction.Name = "colDeduction";
            this.colDeduction.Visible = true;
            this.colDeduction.VisibleIndex = 31;
            this.colDeduction.Width = 80;
            // 
            // colconveyance
            // 
            this.colconveyance.FieldName = "conveyance";
            this.colconveyance.MinWidth = 80;
            this.colconveyance.Name = "colconveyance";
            this.colconveyance.Visible = true;
            this.colconveyance.VisibleIndex = 32;
            this.colconveyance.Width = 80;
            // 
            // colincentive
            // 
            this.colincentive.FieldName = "incentive";
            this.colincentive.MinWidth = 80;
            this.colincentive.Name = "colincentive";
            this.colincentive.Visible = true;
            this.colincentive.VisibleIndex = 33;
            this.colincentive.Width = 80;
            // 
            // colNetAmt
            // 
            this.colNetAmt.FieldName = "NetAmt";
            this.colNetAmt.MinWidth = 80;
            this.colNetAmt.Name = "colNetAmt";
            this.colNetAmt.Visible = true;
            this.colNetAmt.VisibleIndex = 34;
            this.colNetAmt.Width = 80;
            // 
            // colTotalAmt
            // 
            this.colTotalAmt.FieldName = "TotalAmt";
            this.colTotalAmt.MinWidth = 80;
            this.colTotalAmt.Name = "colTotalAmt";
            this.colTotalAmt.Visible = true;
            this.colTotalAmt.VisibleIndex = 35;
            this.colTotalAmt.Width = 80;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetJobGivingWithoutDC";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(7, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1775, 333);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery4.Name = "PRO_GetJobGivingWithoutDC";
            queryParameter4.Name = "@SearchKey";
            queryParameter4.Type = typeof(string);
            storedProcQuery4.Parameters.Add(queryParameter4);
            storedProcQuery4.StoredProcName = "PRO_GetJobGivingWithoutDC";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colEmployeeCode,
            this.colEmployeeName,
            this.colCompanyName,
            this.colClientCompany,
            this.colSubClientCompany,
            this.Orderno,
            this.colDate,
            this.colOrderDate,
            this.colCustomerCode,
            this.colCustomerName,
            this.colModelName,
            this.colModelCode,
            this.colProductName,
            this.colProductSize,
            this.colRawMaterial,
            this.colQuantityPiece,
            this.colWeightKg,
            this.colExcess,
            this.colColor,
            this.colType,
            this.colAvlQty,
            this.colShortage,
            this.colorderQty,
            this.colorderWt,
            this.colClientName,
            this.colTotalQty,
            this.colTotalWt,
            this.colsubContractor,
            this.colDirector,
            this.colPendingQty,
            this.received,
            this.colWages,
            this.colCurrentWt,
            this.colReceivingDate,
            this.colBDays,
            this.colADays,
            this.colBalanceWt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 50;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.MinWidth = 80;
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 1;
            this.colEmployeeCode.Width = 80;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.MinWidth = 80;
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 2;
            this.colEmployeeName.Width = 80;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.MinWidth = 80;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            this.colCompanyName.Width = 80;
            // 
            // colClientCompany
            // 
            this.colClientCompany.FieldName = "ClientCompany";
            this.colClientCompany.MinWidth = 80;
            this.colClientCompany.Name = "colClientCompany";
            this.colClientCompany.Visible = true;
            this.colClientCompany.VisibleIndex = 4;
            this.colClientCompany.Width = 80;
            // 
            // colSubClientCompany
            // 
            this.colSubClientCompany.FieldName = "SubClientCompany";
            this.colSubClientCompany.MinWidth = 80;
            this.colSubClientCompany.Name = "colSubClientCompany";
            this.colSubClientCompany.Visible = true;
            this.colSubClientCompany.VisibleIndex = 5;
            this.colSubClientCompany.Width = 80;
            // 
            // Orderno
            // 
            this.Orderno.Caption = "Orderno";
            this.Orderno.FieldName = "Orderno";
            this.Orderno.MinWidth = 80;
            this.Orderno.Name = "Orderno";
            this.Orderno.Visible = true;
            this.Orderno.VisibleIndex = 6;
            this.Orderno.Width = 80;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 80;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 7;
            this.colDate.Width = 80;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "Orderdate";
            this.colOrderDate.MinWidth = 80;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 8;
            this.colOrderDate.Width = 80;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.MinWidth = 80;
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 9;
            this.colCustomerCode.Width = 80;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.MinWidth = 80;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 10;
            this.colCustomerName.Width = 80;
            // 
            // colModelName
            // 
            this.colModelName.FieldName = "ModelName";
            this.colModelName.MinWidth = 80;
            this.colModelName.Name = "colModelName";
            this.colModelName.Visible = true;
            this.colModelName.VisibleIndex = 11;
            this.colModelName.Width = 80;
            // 
            // colModelCode
            // 
            this.colModelCode.FieldName = "ModelCode";
            this.colModelCode.MinWidth = 80;
            this.colModelCode.Name = "colModelCode";
            this.colModelCode.Visible = true;
            this.colModelCode.VisibleIndex = 12;
            this.colModelCode.Width = 80;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 80;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 13;
            this.colProductName.Width = 80;
            // 
            // colProductSize
            // 
            this.colProductSize.FieldName = "ProductSize";
            this.colProductSize.MinWidth = 80;
            this.colProductSize.Name = "colProductSize";
            this.colProductSize.Visible = true;
            this.colProductSize.VisibleIndex = 14;
            this.colProductSize.Width = 80;
            // 
            // colRawMaterial
            // 
            this.colRawMaterial.FieldName = "RawMaterial";
            this.colRawMaterial.MinWidth = 80;
            this.colRawMaterial.Name = "colRawMaterial";
            this.colRawMaterial.Visible = true;
            this.colRawMaterial.VisibleIndex = 15;
            this.colRawMaterial.Width = 80;
            // 
            // colQuantityPiece
            // 
            this.colQuantityPiece.FieldName = "QuantityPiece";
            this.colQuantityPiece.MinWidth = 80;
            this.colQuantityPiece.Name = "colQuantityPiece";
            this.colQuantityPiece.Visible = true;
            this.colQuantityPiece.VisibleIndex = 16;
            this.colQuantityPiece.Width = 80;
            // 
            // colWeightKg
            // 
            this.colWeightKg.FieldName = "WeightKg";
            this.colWeightKg.MinWidth = 80;
            this.colWeightKg.Name = "colWeightKg";
            this.colWeightKg.Visible = true;
            this.colWeightKg.VisibleIndex = 17;
            this.colWeightKg.Width = 80;
            // 
            // colExcess
            // 
            this.colExcess.FieldName = "Excess";
            this.colExcess.MinWidth = 80;
            this.colExcess.Name = "colExcess";
            this.colExcess.Visible = true;
            this.colExcess.VisibleIndex = 18;
            this.colExcess.Width = 80;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.MinWidth = 80;
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 19;
            this.colColor.Width = 80;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.MinWidth = 80;
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 20;
            this.colType.Width = 80;
            // 
            // colAvlQty
            // 
            this.colAvlQty.FieldName = "AvlQty";
            this.colAvlQty.MinWidth = 80;
            this.colAvlQty.Name = "colAvlQty";
            this.colAvlQty.Visible = true;
            this.colAvlQty.VisibleIndex = 21;
            this.colAvlQty.Width = 80;
            // 
            // colShortage
            // 
            this.colShortage.FieldName = "Shortage";
            this.colShortage.MinWidth = 80;
            this.colShortage.Name = "colShortage";
            this.colShortage.Visible = true;
            this.colShortage.VisibleIndex = 22;
            this.colShortage.Width = 80;
            // 
            // colorderQty
            // 
            this.colorderQty.FieldName = "orderQty";
            this.colorderQty.MinWidth = 80;
            this.colorderQty.Name = "colorderQty";
            this.colorderQty.Visible = true;
            this.colorderQty.VisibleIndex = 23;
            this.colorderQty.Width = 80;
            // 
            // colorderWt
            // 
            this.colorderWt.FieldName = "orderWt";
            this.colorderWt.MinWidth = 80;
            this.colorderWt.Name = "colorderWt";
            this.colorderWt.Visible = true;
            this.colorderWt.VisibleIndex = 24;
            this.colorderWt.Width = 80;
            // 
            // colClientName
            // 
            this.colClientName.FieldName = "ClientName";
            this.colClientName.MinWidth = 80;
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 25;
            this.colClientName.Width = 80;
            // 
            // colTotalQty
            // 
            this.colTotalQty.FieldName = "TotalQty";
            this.colTotalQty.MinWidth = 80;
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 26;
            this.colTotalQty.Width = 80;
            // 
            // colTotalWt
            // 
            this.colTotalWt.FieldName = "TotalWt";
            this.colTotalWt.MinWidth = 80;
            this.colTotalWt.Name = "colTotalWt";
            this.colTotalWt.Visible = true;
            this.colTotalWt.VisibleIndex = 27;
            this.colTotalWt.Width = 80;
            // 
            // colsubContractor
            // 
            this.colsubContractor.FieldName = "subContractor";
            this.colsubContractor.MinWidth = 80;
            this.colsubContractor.Name = "colsubContractor";
            this.colsubContractor.Visible = true;
            this.colsubContractor.VisibleIndex = 28;
            this.colsubContractor.Width = 80;
            // 
            // colDirector
            // 
            this.colDirector.FieldName = "Director";
            this.colDirector.MinWidth = 80;
            this.colDirector.Name = "colDirector";
            this.colDirector.Visible = true;
            this.colDirector.VisibleIndex = 29;
            this.colDirector.Width = 80;
            // 
            // colPendingQty
            // 
            this.colPendingQty.FieldName = "PendingQty";
            this.colPendingQty.MinWidth = 80;
            this.colPendingQty.Name = "colPendingQty";
            this.colPendingQty.Visible = true;
            this.colPendingQty.VisibleIndex = 30;
            this.colPendingQty.Width = 80;
            // 
            // received
            // 
            this.received.Caption = "received";
            this.received.FieldName = "received";
            this.received.MinWidth = 80;
            this.received.Name = "received";
            this.received.Visible = true;
            this.received.VisibleIndex = 31;
            this.received.Width = 80;
            // 
            // colWages
            // 
            this.colWages.FieldName = "Wages";
            this.colWages.MinWidth = 80;
            this.colWages.Name = "colWages";
            this.colWages.Visible = true;
            this.colWages.VisibleIndex = 32;
            this.colWages.Width = 80;
            // 
            // colCurrentWt
            // 
            this.colCurrentWt.FieldName = "CurrentWt";
            this.colCurrentWt.MinWidth = 80;
            this.colCurrentWt.Name = "colCurrentWt";
            this.colCurrentWt.Visible = true;
            this.colCurrentWt.VisibleIndex = 33;
            this.colCurrentWt.Width = 80;
            // 
            // colReceivingDate
            // 
            this.colReceivingDate.FieldName = "ReceivingDate";
            this.colReceivingDate.MinWidth = 80;
            this.colReceivingDate.Name = "colReceivingDate";
            this.colReceivingDate.Visible = true;
            this.colReceivingDate.VisibleIndex = 34;
            this.colReceivingDate.Width = 80;
            // 
            // colBDays
            // 
            this.colBDays.FieldName = "BDays";
            this.colBDays.MinWidth = 80;
            this.colBDays.Name = "colBDays";
            this.colBDays.Visible = true;
            this.colBDays.VisibleIndex = 35;
            this.colBDays.Width = 80;
            // 
            // colADays
            // 
            this.colADays.FieldName = "ADays";
            this.colADays.MinWidth = 80;
            this.colADays.Name = "colADays";
            this.colADays.Visible = true;
            this.colADays.VisibleIndex = 36;
            this.colADays.Width = 80;
            // 
            // colBalanceWt
            // 
            this.colBalanceWt.FieldName = "BalanceWt";
            this.colBalanceWt.MinWidth = 80;
            this.colBalanceWt.Name = "colBalanceWt";
            this.colBalanceWt.Visible = true;
            this.colBalanceWt.VisibleIndex = 37;
            this.colBalanceWt.Width = 80;
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl31.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl31.Appearance.Options.UseFont = true;
            this.labelControl31.Appearance.Options.UseForeColor = true;
            this.labelControl31.Location = new System.Drawing.Point(7, 5);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(118, 18);
            this.labelControl31.TabIndex = 28;
            this.labelControl31.Text = "Job Given Info";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.EnterMoveNextControl = true;
            this.txtEmployeeCode.Location = new System.Drawing.Point(474, 389);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(191, 20);
            this.txtEmployeeCode.TabIndex = 26;
            this.txtEmployeeCode.EditValueChanged += new System.EventHandler(this.txtEmployeeCode_EditValueChanged);
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Appearance.Options.UseForeColor = true;
            this.labelControl30.Location = new System.Drawing.Point(297, 389);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(126, 18);
            this.labelControl30.TabIndex = 27;
            this.labelControl30.Text = "Employee Code";
            // 
            // chkViewReceivedPending
            // 
            this.chkViewReceivedPending.EnterMoveNextControl = true;
            this.chkViewReceivedPending.Location = new System.Drawing.Point(17, 386);
            this.chkViewReceivedPending.Name = "chkViewReceivedPending";
            this.chkViewReceivedPending.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkViewReceivedPending.Properties.Appearance.Options.UseFont = true;
            this.chkViewReceivedPending.Properties.Caption = "View Received Pending";
            this.chkViewReceivedPending.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.chkViewReceivedPending.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.chkViewReceivedPending.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkViewReceivedPending.Size = new System.Drawing.Size(222, 22);
            this.chkViewReceivedPending.TabIndex = 27;
            this.chkViewReceivedPending.CheckedChanged += new System.EventHandler(this.chkViewReceivedPending_CheckedChanged);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.panelControl8);
            this.panelControl4.Controls.Add(this.lblWeight);
            this.panelControl4.Controls.Add(this.labelControl18);
            this.panelControl4.Controls.Add(this.labelControl16);
            this.panelControl4.Controls.Add(this.labelControl19);
            this.panelControl4.Controls.Add(this.txtShortage);
            this.panelControl4.Controls.Add(this.labelControl20);
            this.panelControl4.Controls.Add(this.txtExcess);
            this.panelControl4.Controls.Add(this.labelControl21);
            this.panelControl4.Controls.Add(this.txtWeight);
            this.panelControl4.Controls.Add(this.labelControl22);
            this.panelControl4.Controls.Add(this.txtQuantity);
            this.panelControl4.Controls.Add(this.labelControl23);
            this.panelControl4.Controls.Add(this.txtComName);
            this.panelControl4.Controls.Add(this.labelControl24);
            this.panelControl4.Controls.Add(this.txtClientCompany);
            this.panelControl4.Controls.Add(this.txtSubClient);
            this.panelControl4.Controls.Add(this.labelControl25);
            this.panelControl4.Controls.Add(this.labelControl26);
            this.panelControl4.Controls.Add(this.txtSubContractor);
            this.panelControl4.Controls.Add(this.labelControl27);
            this.panelControl4.Controls.Add(this.txtClientName);
            this.panelControl4.Controls.Add(this.labelControl28);
            this.panelControl4.Controls.Add(this.txtDirector);
            this.panelControl4.Controls.Add(this.labelControl29);
            this.panelControl4.Controls.Add(this.txtJEmpName);
            this.panelControl4.Controls.Add(this.drpEmpCode);
            this.panelControl4.Location = new System.Drawing.Point(5, 216);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1511, 154);
            this.panelControl4.TabIndex = 29;
            // 
            // panelControl8
            // 
            this.panelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl8.Controls.Add(this.labelControl17);
            this.panelControl8.Location = new System.Drawing.Point(15, -6);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(162, 23);
            this.panelControl8.TabIndex = 28;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(3, 2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(145, 18);
            this.labelControl17.TabIndex = 1;
            this.labelControl17.Text = "Job Re-allocation:";
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(1145, 58);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(0, 13);
            this.lblWeight.TabIndex = 27;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(1131, 56);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(8, 16);
            this.labelControl18.TabIndex = 26;
            this.labelControl18.Text = "/";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(879, 56);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(59, 18);
            this.labelControl16.TabIndex = 19;
            this.labelControl16.Text = "Weight";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(12, 27);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(126, 18);
            this.labelControl19.TabIndex = 2;
            this.labelControl19.Text = "Employee Code";
            // 
            // txtShortage
            // 
            this.txtShortage.Enabled = false;
            this.txtShortage.EnterMoveNextControl = true;
            this.txtShortage.Location = new System.Drawing.Point(1043, 107);
            this.txtShortage.Name = "txtShortage";
            this.txtShortage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortage.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtShortage.Properties.Appearance.Options.UseFont = true;
            this.txtShortage.Properties.Appearance.Options.UseForeColor = true;
            this.txtShortage.Properties.BeepOnError = false;
            this.txtShortage.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtShortage.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtShortage.Properties.MaskSettings.Set("mask", "f3");
            this.txtShortage.Properties.UseMaskAsDisplayFormat = true;
            this.txtShortage.Size = new System.Drawing.Size(187, 22);
            this.txtShortage.TabIndex = 25;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Appearance.Options.UseForeColor = true;
            this.labelControl20.Location = new System.Drawing.Point(12, 59);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(128, 18);
            this.labelControl20.TabIndex = 3;
            this.labelControl20.Text = "Company Name";
            // 
            // txtExcess
            // 
            this.txtExcess.Enabled = false;
            this.txtExcess.EnterMoveNextControl = true;
            this.txtExcess.Location = new System.Drawing.Point(1043, 81);
            this.txtExcess.Name = "txtExcess";
            this.txtExcess.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcess.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtExcess.Properties.Appearance.Options.UseFont = true;
            this.txtExcess.Properties.Appearance.Options.UseForeColor = true;
            this.txtExcess.Properties.BeepOnError = false;
            this.txtExcess.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtExcess.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtExcess.Properties.MaskSettings.Set("mask", "f3");
            this.txtExcess.Properties.UseMaskAsDisplayFormat = true;
            this.txtExcess.Size = new System.Drawing.Size(187, 22);
            this.txtExcess.TabIndex = 24;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Appearance.Options.UseForeColor = true;
            this.labelControl21.Location = new System.Drawing.Point(12, 85);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(129, 18);
            this.labelControl21.TabIndex = 4;
            this.labelControl21.Text = "Client Company";
            // 
            // txtWeight
            // 
            this.txtWeight.EnterMoveNextControl = true;
            this.txtWeight.Location = new System.Drawing.Point(1043, 55);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Properties.Appearance.Options.UseFont = true;
            this.txtWeight.Properties.BeepOnError = false;
            this.txtWeight.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtWeight.Properties.MaskSettings.Set("mask", "f3");
            this.txtWeight.Properties.UseMaskAsDisplayFormat = true;
            this.txtWeight.Size = new System.Drawing.Size(82, 20);
            this.txtWeight.TabIndex = 23;
            this.txtWeight.EditValueChanged += new System.EventHandler(this.txtWeight_EditValueChanged);
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Appearance.Options.UseForeColor = true;
            this.labelControl22.Location = new System.Drawing.Point(12, 111);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(165, 18);
            this.labelControl22.TabIndex = 5;
            this.labelControl22.Text = "Sub Client Company";
            // 
            // txtQuantity
            // 
            this.txtQuantity.EnterMoveNextControl = true;
            this.txtQuantity.Location = new System.Drawing.Point(1043, 26);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Properties.BeepOnError = false;
            this.txtQuantity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtQuantity.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtQuantity.Properties.MaskSettings.Set("mask", "d");
            this.txtQuantity.Properties.UseMaskAsDisplayFormat = true;
            this.txtQuantity.Size = new System.Drawing.Size(187, 20);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Appearance.Options.UseForeColor = true;
            this.labelControl23.Location = new System.Drawing.Point(879, 108);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(73, 18);
            this.labelControl23.TabIndex = 21;
            this.labelControl23.Text = "Shortage";
            // 
            // txtComName
            // 
            this.txtComName.Enabled = false;
            this.txtComName.EnterMoveNextControl = true;
            this.txtComName.Location = new System.Drawing.Point(176, 56);
            this.txtComName.Name = "txtComName";
            this.txtComName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComName.Properties.Appearance.Options.UseFont = true;
            this.txtComName.Size = new System.Drawing.Size(187, 20);
            this.txtComName.TabIndex = 15;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Appearance.Options.UseForeColor = true;
            this.labelControl24.Location = new System.Drawing.Point(879, 84);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(55, 18);
            this.labelControl24.TabIndex = 20;
            this.labelControl24.Text = "Excess";
            // 
            // txtClientCompany
            // 
            this.txtClientCompany.Enabled = false;
            this.txtClientCompany.EnterMoveNextControl = true;
            this.txtClientCompany.Location = new System.Drawing.Point(176, 82);
            this.txtClientCompany.Name = "txtClientCompany";
            this.txtClientCompany.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCompany.Properties.Appearance.Options.UseFont = true;
            this.txtClientCompany.Size = new System.Drawing.Size(187, 20);
            this.txtClientCompany.TabIndex = 16;
            // 
            // txtSubClient
            // 
            this.txtSubClient.Enabled = false;
            this.txtSubClient.EnterMoveNextControl = true;
            this.txtSubClient.Location = new System.Drawing.Point(176, 108);
            this.txtSubClient.Name = "txtSubClient";
            this.txtSubClient.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubClient.Properties.Appearance.Options.UseFont = true;
            this.txtSubClient.Size = new System.Drawing.Size(187, 20);
            this.txtSubClient.TabIndex = 17;
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl25.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl25.Appearance.Options.UseFont = true;
            this.labelControl25.Appearance.Options.UseForeColor = true;
            this.labelControl25.Location = new System.Drawing.Point(879, 27);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(71, 18);
            this.labelControl25.TabIndex = 18;
            this.labelControl25.Text = "Quantity";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Appearance.Options.UseForeColor = true;
            this.labelControl26.Location = new System.Drawing.Point(451, 27);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(132, 18);
            this.labelControl26.TabIndex = 10;
            this.labelControl26.Text = "Employee Name";
            // 
            // txtSubContractor
            // 
            this.txtSubContractor.Enabled = false;
            this.txtSubContractor.EnterMoveNextControl = true;
            this.txtSubContractor.Location = new System.Drawing.Point(615, 107);
            this.txtSubContractor.Name = "txtSubContractor";
            this.txtSubContractor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubContractor.Properties.Appearance.Options.UseFont = true;
            this.txtSubContractor.Size = new System.Drawing.Size(187, 20);
            this.txtSubContractor.TabIndex = 21;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Appearance.Options.UseForeColor = true;
            this.labelControl27.Location = new System.Drawing.Point(451, 56);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(64, 18);
            this.labelControl27.TabIndex = 11;
            this.labelControl27.Text = "Director";
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.EnterMoveNextControl = true;
            this.txtClientName.Location = new System.Drawing.Point(615, 81);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Properties.Appearance.Options.UseFont = true;
            this.txtClientName.Size = new System.Drawing.Size(187, 20);
            this.txtClientName.TabIndex = 20;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Appearance.Options.UseForeColor = true;
            this.labelControl28.Location = new System.Drawing.Point(451, 84);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(101, 18);
            this.labelControl28.TabIndex = 12;
            this.labelControl28.Text = "Client Name";
            // 
            // txtDirector
            // 
            this.txtDirector.Enabled = false;
            this.txtDirector.EnterMoveNextControl = true;
            this.txtDirector.Location = new System.Drawing.Point(615, 55);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Properties.Appearance.Options.UseFont = true;
            this.txtDirector.Size = new System.Drawing.Size(187, 20);
            this.txtDirector.TabIndex = 19;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Appearance.Options.UseForeColor = true;
            this.labelControl29.Location = new System.Drawing.Point(451, 109);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(121, 18);
            this.labelControl29.TabIndex = 13;
            this.labelControl29.Text = "Sub Contractor";
            // 
            // txtJEmpName
            // 
            this.txtJEmpName.Enabled = false;
            this.txtJEmpName.EnterMoveNextControl = true;
            this.txtJEmpName.Location = new System.Drawing.Point(615, 26);
            this.txtJEmpName.Name = "txtJEmpName";
            this.txtJEmpName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJEmpName.Properties.Appearance.Options.UseFont = true;
            this.txtJEmpName.Size = new System.Drawing.Size(187, 20);
            this.txtJEmpName.TabIndex = 18;
            // 
            // drpEmpCode
            // 
            this.drpEmpCode.EnterMoveNextControl = true;
            this.drpEmpCode.Location = new System.Drawing.Point(176, 26);
            this.drpEmpCode.Name = "drpEmpCode";
            this.drpEmpCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpEmpCode.Properties.Appearance.Options.UseFont = true;
            this.drpEmpCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpEmpCode.Size = new System.Drawing.Size(187, 20);
            this.drpEmpCode.TabIndex = 14;
            this.drpEmpCode.SelectedIndexChanged += new System.EventHandler(this.drpEmpCode_SelectedIndexChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Location = new System.Drawing.Point(5, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1787, 45);
            this.panelControl3.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(769, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(249, 32);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Job Reallocation";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl32);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.ddReceivingDate);
            this.panelControl2.Controls.Add(this.labelControl15);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txtPendingQty);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txtReceivedQty);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtProColor);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.txtProSize);
            this.panelControl2.Controls.Add(this.txtEmpCode);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.txtCustName);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.txtRawMaterial);
            this.panelControl2.Controls.Add(this.txtRawType);
            this.panelControl2.Controls.Add(this.labelControl14);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.txtQuanity);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.txtProModel);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.txtProductCode);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.txtEmpName);
            this.panelControl2.Location = new System.Drawing.Point(5, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1511, 151);
            this.panelControl2.TabIndex = 28;
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl32.Appearance.Options.UseFont = true;
            this.labelControl32.Appearance.Options.UseForeColor = true;
            this.labelControl32.Location = new System.Drawing.Point(1423, 14);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(10, 18);
            this.labelControl32.TabIndex = 28;
            this.labelControl32.Text = "*";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(879, 56);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(109, 18);
            this.labelControl13.TabIndex = 19;
            this.labelControl13.Text = "Product Color";
            // 
            // ddReceivingDate
            // 
            this.ddReceivingDate.EditValue = null;
            this.ddReceivingDate.EnterMoveNextControl = true;
            this.ddReceivingDate.Location = new System.Drawing.Point(1271, 36);
            this.ddReceivingDate.Name = "ddReceivingDate";
            this.ddReceivingDate.Properties.BeepOnError = false;
            this.ddReceivingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddReceivingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddReceivingDate.Properties.MaskSettings.Set("mask", "d");
            this.ddReceivingDate.Properties.TodayDate = new System.DateTime(2023, 7, 27, 19, 14, 25, 0);
            this.ddReceivingDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddReceivingDate.Size = new System.Drawing.Size(110, 20);
            this.ddReceivingDate.TabIndex = 13;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(1271, 14);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(130, 18);
            this.labelControl15.TabIndex = 26;
            this.labelControl15.Text = "Receiving Date:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Employee Code";
            // 
            // txtPendingQty
            // 
            this.txtPendingQty.Enabled = false;
            this.txtPendingQty.EnterMoveNextControl = true;
            this.txtPendingQty.Location = new System.Drawing.Point(1043, 107);
            this.txtPendingQty.Name = "txtPendingQty";
            this.txtPendingQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendingQty.Properties.Appearance.Options.UseFont = true;
            this.txtPendingQty.Size = new System.Drawing.Size(187, 20);
            this.txtPendingQty.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(131, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Customer Name";
            // 
            // txtReceivedQty
            // 
            this.txtReceivedQty.Enabled = false;
            this.txtReceivedQty.EnterMoveNextControl = true;
            this.txtReceivedQty.Location = new System.Drawing.Point(1043, 81);
            this.txtReceivedQty.Name = "txtReceivedQty";
            this.txtReceivedQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedQty.Properties.Appearance.Options.UseFont = true;
            this.txtReceivedQty.Size = new System.Drawing.Size(187, 20);
            this.txtReceivedQty.TabIndex = 11;
            this.txtReceivedQty.EditValueChanged += new System.EventHandler(this.txtReceivedQty_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 18);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Raw Material";
            // 
            // txtProColor
            // 
            this.txtProColor.Enabled = false;
            this.txtProColor.EnterMoveNextControl = true;
            this.txtProColor.Location = new System.Drawing.Point(1043, 55);
            this.txtProColor.Name = "txtProColor";
            this.txtProColor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProColor.Properties.Appearance.Options.UseFont = true;
            this.txtProColor.Size = new System.Drawing.Size(187, 20);
            this.txtProColor.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Raw Type";
            // 
            // txtProSize
            // 
            this.txtProSize.Enabled = false;
            this.txtProSize.EnterMoveNextControl = true;
            this.txtProSize.Location = new System.Drawing.Point(1043, 26);
            this.txtProSize.Name = "txtProSize";
            this.txtProSize.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProSize.Properties.Appearance.Options.UseFont = true;
            this.txtProSize.Size = new System.Drawing.Size(187, 20);
            this.txtProSize.TabIndex = 9;
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Enabled = false;
            this.txtEmpCode.EnterMoveNextControl = true;
            this.txtEmpCode.Location = new System.Drawing.Point(176, 26);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCode.Properties.Appearance.Options.UseFont = true;
            this.txtEmpCode.Size = new System.Drawing.Size(187, 20);
            this.txtEmpCode.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(879, 108);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(100, 18);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Pending Qty";
            // 
            // txtCustName
            // 
            this.txtCustName.Enabled = false;
            this.txtCustName.EnterMoveNextControl = true;
            this.txtCustName.Location = new System.Drawing.Point(176, 56);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Properties.Appearance.Options.UseFont = true;
            this.txtCustName.Size = new System.Drawing.Size(187, 20);
            this.txtCustName.TabIndex = 2;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(879, 84);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(108, 18);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "Received Qty";
            // 
            // txtRawMaterial
            // 
            this.txtRawMaterial.Enabled = false;
            this.txtRawMaterial.EnterMoveNextControl = true;
            this.txtRawMaterial.Location = new System.Drawing.Point(176, 82);
            this.txtRawMaterial.Name = "txtRawMaterial";
            this.txtRawMaterial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawMaterial.Properties.Appearance.Options.UseFont = true;
            this.txtRawMaterial.Size = new System.Drawing.Size(187, 20);
            this.txtRawMaterial.TabIndex = 3;
            // 
            // txtRawType
            // 
            this.txtRawType.Enabled = false;
            this.txtRawType.EnterMoveNextControl = true;
            this.txtRawType.Location = new System.Drawing.Point(176, 108);
            this.txtRawType.Name = "txtRawType";
            this.txtRawType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawType.Properties.Appearance.Options.UseFont = true;
            this.txtRawType.Size = new System.Drawing.Size(187, 20);
            this.txtRawType.TabIndex = 4;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(879, 27);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(101, 18);
            this.labelControl14.TabIndex = 18;
            this.labelControl14.Text = "Product Size";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(451, 27);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(132, 18);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Employee Name";
            // 
            // txtQuanity
            // 
            this.txtQuanity.Enabled = false;
            this.txtQuanity.EnterMoveNextControl = true;
            this.txtQuanity.Location = new System.Drawing.Point(615, 107);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuanity.Properties.Appearance.Options.UseFont = true;
            this.txtQuanity.Size = new System.Drawing.Size(187, 20);
            this.txtQuanity.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(451, 56);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(108, 18);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Product Code";
            // 
            // txtProModel
            // 
            this.txtProModel.Enabled = false;
            this.txtProModel.EnterMoveNextControl = true;
            this.txtProModel.Location = new System.Drawing.Point(615, 81);
            this.txtProModel.Name = "txtProModel";
            this.txtProModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProModel.Properties.Appearance.Options.UseFont = true;
            this.txtProModel.Size = new System.Drawing.Size(187, 20);
            this.txtProModel.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(451, 84);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(115, 18);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Product Model";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Enabled = false;
            this.txtProductCode.EnterMoveNextControl = true;
            this.txtProductCode.Location = new System.Drawing.Point(615, 55);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Properties.Appearance.Options.UseFont = true;
            this.txtProductCode.Size = new System.Drawing.Size(187, 20);
            this.txtProductCode.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(451, 109);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(71, 18);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Quantity";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.EnterMoveNextControl = true;
            this.txtEmpName.Location = new System.Drawing.Point(615, 26);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Properties.Appearance.Options.UseFont = true;
            this.txtEmpName.Size = new System.Drawing.Size(187, 20);
            this.txtEmpName.TabIndex = 5;
            // 
            // FrmJobReallocation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1821, 826);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmJobReallocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmJobReallocation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmJobReallocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewReceivedPending.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.panelControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubContractor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceivingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceivingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPendingQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceivedQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuanity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtRawType;
        private DevExpress.XtraEditors.TextEdit txtRawMaterial;
        private DevExpress.XtraEditors.TextEdit txtCustName;
        private DevExpress.XtraEditors.TextEdit txtEmpCode;
        private DevExpress.XtraEditors.TextEdit txtPendingQty;
        private DevExpress.XtraEditors.TextEdit txtReceivedQty;
        private DevExpress.XtraEditors.TextEdit txtProColor;
        private DevExpress.XtraEditors.TextEdit txtProSize;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtQuanity;
        private DevExpress.XtraEditors.TextEdit txtProModel;
        private DevExpress.XtraEditors.TextEdit txtProductCode;
        private DevExpress.XtraEditors.TextEdit txtEmpName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.DateEdit ddReceivingDate;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtShortage;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtExcess;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.TextEdit txtComName;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.TextEdit txtClientCompany;
        private DevExpress.XtraEditors.TextEdit txtSubClient;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit txtSubContractor;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit txtClientName;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.TextEdit txtDirector;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.TextEdit txtJEmpName;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.CheckEdit chkViewReceivedPending;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit txtEmployeeCode;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit drpEmpCode;
        private DevExpress.XtraEditors.SimpleButton btn_JobCancel;
        private DevExpress.XtraEditors.SimpleButton btnTransfer;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl lblWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn Orderno;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colModelName;
        private DevExpress.XtraGrid.Columns.GridColumn colModelCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSize;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPiece;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightKg;
        private DevExpress.XtraGrid.Columns.GridColumn colExcess;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colAvlQty;
        private DevExpress.XtraGrid.Columns.GridColumn colShortage;
        private DevExpress.XtraGrid.Columns.GridColumn colorderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colorderWt;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWt;
        private DevExpress.XtraGrid.Columns.GridColumn colsubContractor;
        private DevExpress.XtraGrid.Columns.GridColumn colDirector;
        private DevExpress.XtraGrid.Columns.GridColumn colPendingQty;
        private DevExpress.XtraGrid.Columns.GridColumn received;
        private DevExpress.XtraGrid.Columns.GridColumn colWages;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentWt;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBDays;
        private DevExpress.XtraGrid.Columns.GridColumn colADays;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceWt;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName1;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientCompany1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName1;
        private DevExpress.XtraGrid.Columns.GridColumn colModelName1;
        private DevExpress.XtraGrid.Columns.GridColumn colModelCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSize1;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterial1;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightKg1;
        private DevExpress.XtraGrid.Columns.GridColumn colExcess1;
        private DevExpress.XtraGrid.Columns.GridColumn colColor1;
        private DevExpress.XtraGrid.Columns.GridColumn colType1;
        private DevExpress.XtraGrid.Columns.GridColumn colAvlQty1;
        private DevExpress.XtraGrid.Columns.GridColumn colShortage1;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWt1;
        private DevExpress.XtraGrid.Columns.GridColumn subContractor;
        private DevExpress.XtraGrid.Columns.GridColumn colDirector1;
        private DevExpress.XtraGrid.Columns.GridColumn colPendingQty1;
        private DevExpress.XtraGrid.Columns.GridColumn colreceived1;
        private DevExpress.XtraGrid.Columns.GridColumn colWages1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentWt1;
        private DevExpress.XtraGrid.Columns.GridColumn ReceivingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceWt1;
        private DevExpress.XtraGrid.Columns.GridColumn colDeduction;
        private DevExpress.XtraGrid.Columns.GridColumn colconveyance;
        private DevExpress.XtraGrid.Columns.GridColumn colincentive;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmt;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl8;
    }
}