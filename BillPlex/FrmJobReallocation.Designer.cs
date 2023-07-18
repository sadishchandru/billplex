
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJobReallocation));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnTransfer = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmployeeCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lblWeight = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
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
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.ddReceivingDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
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
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.txtEmployeeCode);
            this.panelControl1.Controls.Add(this.labelControl30);
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1797, 802);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.btnClear);
            this.panelControl6.Controls.Add(this.btnTransfer);
            this.panelControl6.Controls.Add(this.btnCancel);
            this.panelControl6.Location = new System.Drawing.Point(1523, 57);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(269, 347);
            this.panelControl6.TabIndex = 32;
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTransfer.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(90, 38);
            this.btnCancel.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnCancel.LookAndFeel.SkinName = "DevExpress Style";
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 75);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = " Cancel \r\n  This \r\n Giving";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.gridControl1);
            this.panelControl5.Controls.Add(this.labelControl31);
            this.panelControl5.Location = new System.Drawing.Point(5, 422);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1787, 375);
            this.panelControl5.TabIndex = 31;
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
            storedProcQuery1.Name = "PRO_GetJobGivingWithoutDC";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetJobGivingWithoutDC";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
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
            this.colOrderNo,
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
            this.colTotalQty,
            this.colTotalWt,
            this.colShortage,
            this.colorderQty,
            this.colorderWt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 1;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 2;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            // 
            // colClientCompany
            // 
            this.colClientCompany.FieldName = "ClientCompany";
            this.colClientCompany.Name = "colClientCompany";
            this.colClientCompany.Visible = true;
            this.colClientCompany.VisibleIndex = 4;
            // 
            // colSubClientCompany
            // 
            this.colSubClientCompany.FieldName = "SubClientCompany";
            this.colSubClientCompany.Name = "colSubClientCompany";
            this.colSubClientCompany.Visible = true;
            this.colSubClientCompany.VisibleIndex = 5;
            // 
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 6;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 7;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 8;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 9;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 10;
            // 
            // colModelName
            // 
            this.colModelName.FieldName = "ModelName";
            this.colModelName.Name = "colModelName";
            this.colModelName.Visible = true;
            this.colModelName.VisibleIndex = 11;
            // 
            // colModelCode
            // 
            this.colModelCode.FieldName = "ModelCode";
            this.colModelCode.Name = "colModelCode";
            this.colModelCode.Visible = true;
            this.colModelCode.VisibleIndex = 12;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 13;
            // 
            // colProductSize
            // 
            this.colProductSize.FieldName = "ProductSize";
            this.colProductSize.Name = "colProductSize";
            this.colProductSize.Visible = true;
            this.colProductSize.VisibleIndex = 14;
            // 
            // colRawMaterial
            // 
            this.colRawMaterial.FieldName = "RawMaterial";
            this.colRawMaterial.Name = "colRawMaterial";
            this.colRawMaterial.Visible = true;
            this.colRawMaterial.VisibleIndex = 15;
            // 
            // colQuantityPiece
            // 
            this.colQuantityPiece.FieldName = "QuantityPiece";
            this.colQuantityPiece.Name = "colQuantityPiece";
            this.colQuantityPiece.Visible = true;
            this.colQuantityPiece.VisibleIndex = 16;
            // 
            // colWeightKg
            // 
            this.colWeightKg.FieldName = "WeightKg";
            this.colWeightKg.Name = "colWeightKg";
            this.colWeightKg.Visible = true;
            this.colWeightKg.VisibleIndex = 17;
            // 
            // colExcess
            // 
            this.colExcess.FieldName = "Excess";
            this.colExcess.Name = "colExcess";
            this.colExcess.Visible = true;
            this.colExcess.VisibleIndex = 18;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 19;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 20;
            // 
            // colAvlQty
            // 
            this.colAvlQty.FieldName = "AvlQty";
            this.colAvlQty.Name = "colAvlQty";
            this.colAvlQty.Visible = true;
            this.colAvlQty.VisibleIndex = 21;
            // 
            // colTotalQty
            // 
            this.colTotalQty.FieldName = "TotalQty";
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 22;
            // 
            // colTotalWt
            // 
            this.colTotalWt.FieldName = "TotalWt";
            this.colTotalWt.Name = "colTotalWt";
            this.colTotalWt.Visible = true;
            this.colTotalWt.VisibleIndex = 23;
            // 
            // colShortage
            // 
            this.colShortage.FieldName = "Shortage";
            this.colShortage.Name = "colShortage";
            this.colShortage.Visible = true;
            this.colShortage.VisibleIndex = 24;
            // 
            // colorderQty
            // 
            this.colorderQty.FieldName = "orderQty";
            this.colorderQty.Name = "colorderQty";
            this.colorderQty.Visible = true;
            this.colorderQty.VisibleIndex = 25;
            // 
            // colorderWt
            // 
            this.colorderWt.FieldName = "orderWt";
            this.colorderWt.Name = "colorderWt";
            this.colorderWt.Visible = true;
            this.colorderWt.VisibleIndex = 26;
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl31.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl31.Appearance.Options.UseFont = true;
            this.labelControl31.Appearance.Options.UseForeColor = true;
            this.labelControl31.Location = new System.Drawing.Point(7, 5);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(91, 16);
            this.labelControl31.TabIndex = 28;
            this.labelControl31.Text = "Job Given Info";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(356, 386);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(128, 20);
            this.txtEmployeeCode.TabIndex = 27;
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Appearance.Options.UseForeColor = true;
            this.labelControl30.Location = new System.Drawing.Point(245, 388);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(97, 16);
            this.labelControl30.TabIndex = 27;
            this.labelControl30.Text = "Employee Code";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(17, 386);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "View Received Pending";
            this.checkEdit1.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.checkEdit1.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.checkEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.checkEdit1.Size = new System.Drawing.Size(173, 20);
            this.checkEdit1.TabIndex = 30;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lblWeight);
            this.panelControl4.Controls.Add(this.labelControl18);
            this.panelControl4.Controls.Add(this.labelControl16);
            this.panelControl4.Controls.Add(this.labelControl17);
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
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(879, 56);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(46, 16);
            this.labelControl16.TabIndex = 19;
            this.labelControl16.Text = "Weight";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(5, 5);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(116, 16);
            this.labelControl17.TabIndex = 1;
            this.labelControl17.Text = "Job Re-allocation:";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(12, 27);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(97, 16);
            this.labelControl19.TabIndex = 2;
            this.labelControl19.Text = "Employee Code";
            // 
            // txtShortage
            // 
            this.txtShortage.Location = new System.Drawing.Point(1043, 107);
            this.txtShortage.Name = "txtShortage";
            this.txtShortage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortage.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtShortage.Properties.Appearance.Options.UseFont = true;
            this.txtShortage.Properties.Appearance.Options.UseForeColor = true;
            this.txtShortage.Size = new System.Drawing.Size(187, 22);
            this.txtShortage.TabIndex = 25;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Appearance.Options.UseForeColor = true;
            this.labelControl20.Location = new System.Drawing.Point(12, 59);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(98, 16);
            this.labelControl20.TabIndex = 3;
            this.labelControl20.Text = "Company Name";
            // 
            // txtExcess
            // 
            this.txtExcess.Location = new System.Drawing.Point(1043, 81);
            this.txtExcess.Name = "txtExcess";
            this.txtExcess.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcess.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtExcess.Properties.Appearance.Options.UseFont = true;
            this.txtExcess.Properties.Appearance.Options.UseForeColor = true;
            this.txtExcess.Size = new System.Drawing.Size(187, 22);
            this.txtExcess.TabIndex = 24;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Appearance.Options.UseForeColor = true;
            this.labelControl21.Location = new System.Drawing.Point(12, 85);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(99, 16);
            this.labelControl21.TabIndex = 4;
            this.labelControl21.Text = "Client Company";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(1043, 55);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.BeepOnError = false;
            this.txtWeight.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtWeight.Properties.MaskSettings.Set("mask", "d");
            this.txtWeight.Properties.UseMaskAsDisplayFormat = true;
            this.txtWeight.Size = new System.Drawing.Size(82, 20);
            this.txtWeight.TabIndex = 23;
            this.txtWeight.EditValueChanged += new System.EventHandler(this.txtWeight_EditValueChanged);
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Appearance.Options.UseForeColor = true;
            this.labelControl22.Location = new System.Drawing.Point(12, 111);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(127, 16);
            this.labelControl22.TabIndex = 5;
            this.labelControl22.Text = "Sub Client Company";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(1043, 26);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(187, 20);
            this.txtQuantity.TabIndex = 22;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Appearance.Options.UseForeColor = true;
            this.labelControl23.Location = new System.Drawing.Point(879, 108);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(60, 16);
            this.labelControl23.TabIndex = 21;
            this.labelControl23.Text = "Shortage";
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(176, 56);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(187, 20);
            this.txtComName.TabIndex = 7;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Appearance.Options.UseForeColor = true;
            this.labelControl24.Location = new System.Drawing.Point(879, 84);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(43, 16);
            this.labelControl24.TabIndex = 20;
            this.labelControl24.Text = "Excess";
            // 
            // txtClientCompany
            // 
            this.txtClientCompany.Location = new System.Drawing.Point(176, 82);
            this.txtClientCompany.Name = "txtClientCompany";
            this.txtClientCompany.Size = new System.Drawing.Size(187, 20);
            this.txtClientCompany.TabIndex = 8;
            // 
            // txtSubClient
            // 
            this.txtSubClient.Location = new System.Drawing.Point(176, 108);
            this.txtSubClient.Name = "txtSubClient";
            this.txtSubClient.Size = new System.Drawing.Size(187, 20);
            this.txtSubClient.TabIndex = 9;
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl25.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl25.Appearance.Options.UseFont = true;
            this.labelControl25.Appearance.Options.UseForeColor = true;
            this.labelControl25.Location = new System.Drawing.Point(879, 27);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(56, 16);
            this.labelControl25.TabIndex = 18;
            this.labelControl25.Text = "Quantity";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Appearance.Options.UseForeColor = true;
            this.labelControl26.Location = new System.Drawing.Point(451, 27);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(100, 16);
            this.labelControl26.TabIndex = 10;
            this.labelControl26.Text = "Employee Name";
            // 
            // txtSubContractor
            // 
            this.txtSubContractor.Location = new System.Drawing.Point(615, 107);
            this.txtSubContractor.Name = "txtSubContractor";
            this.txtSubContractor.Size = new System.Drawing.Size(187, 20);
            this.txtSubContractor.TabIndex = 17;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Appearance.Options.UseForeColor = true;
            this.labelControl27.Location = new System.Drawing.Point(451, 56);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(53, 16);
            this.labelControl27.TabIndex = 11;
            this.labelControl27.Text = "Director";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(615, 81);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(187, 20);
            this.txtClientName.TabIndex = 16;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Appearance.Options.UseForeColor = true;
            this.labelControl28.Location = new System.Drawing.Point(451, 84);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(75, 16);
            this.labelControl28.TabIndex = 12;
            this.labelControl28.Text = "Client Name";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(615, 55);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(187, 20);
            this.txtDirector.TabIndex = 15;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Appearance.Options.UseForeColor = true;
            this.labelControl29.Location = new System.Drawing.Point(451, 109);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(99, 16);
            this.labelControl29.TabIndex = 13;
            this.labelControl29.Text = "Sub Contractor";
            // 
            // txtJEmpName
            // 
            this.txtJEmpName.Location = new System.Drawing.Point(615, 26);
            this.txtJEmpName.Name = "txtJEmpName";
            this.txtJEmpName.Size = new System.Drawing.Size(187, 20);
            this.txtJEmpName.TabIndex = 14;
            // 
            // drpEmpCode
            // 
            this.drpEmpCode.Location = new System.Drawing.Point(176, 26);
            this.drpEmpCode.Name = "drpEmpCode";
            this.drpEmpCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpEmpCode.Size = new System.Drawing.Size(187, 20);
            this.drpEmpCode.TabIndex = 6;
            this.drpEmpCode.SelectedIndexChanged += new System.EventHandler(this.drpEmpCode_SelectedIndexChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Location = new System.Drawing.Point(5, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1787, 45);
            this.panelControl3.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(800, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Job Reallocation";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.ddReceivingDate);
            this.panelControl2.Controls.Add(this.labelControl2);
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
            this.panelControl2.Size = new System.Drawing.Size(1511, 154);
            this.panelControl2.TabIndex = 28;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(879, 56);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(88, 16);
            this.labelControl13.TabIndex = 19;
            this.labelControl13.Text = "Product Color";
            // 
            // ddReceivingDate
            // 
            this.ddReceivingDate.EditValue = null;
            this.ddReceivingDate.Location = new System.Drawing.Point(1271, 36);
            this.ddReceivingDate.Name = "ddReceivingDate";
            this.ddReceivingDate.Properties.BeepOnError = false;
            this.ddReceivingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddReceivingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddReceivingDate.Properties.MaskSettings.Set("mask", "d");
            this.ddReceivingDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddReceivingDate.Size = new System.Drawing.Size(110, 20);
            this.ddReceivingDate.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(180, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Job Received Pending Data:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(1271, 14);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(102, 16);
            this.labelControl15.TabIndex = 26;
            this.labelControl15.Text = "Receiving Date:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Employee Code";
            // 
            // txtPendingQty
            // 
            this.txtPendingQty.Location = new System.Drawing.Point(1043, 107);
            this.txtPendingQty.Name = "txtPendingQty";
            this.txtPendingQty.Size = new System.Drawing.Size(187, 20);
            this.txtPendingQty.TabIndex = 25;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Customer Name";
            // 
            // txtReceivedQty
            // 
            this.txtReceivedQty.Location = new System.Drawing.Point(1043, 81);
            this.txtReceivedQty.Name = "txtReceivedQty";
            this.txtReceivedQty.Size = new System.Drawing.Size(187, 20);
            this.txtReceivedQty.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Raw Material";
            // 
            // txtProColor
            // 
            this.txtProColor.Location = new System.Drawing.Point(1043, 55);
            this.txtProColor.Name = "txtProColor";
            this.txtProColor.Size = new System.Drawing.Size(187, 20);
            this.txtProColor.TabIndex = 23;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 16);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Raw Type";
            // 
            // txtProSize
            // 
            this.txtProSize.Location = new System.Drawing.Point(1043, 26);
            this.txtProSize.Name = "txtProSize";
            this.txtProSize.Size = new System.Drawing.Size(187, 20);
            this.txtProSize.TabIndex = 22;
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Location = new System.Drawing.Point(176, 26);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new System.Drawing.Size(187, 20);
            this.txtEmpCode.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(879, 108);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(78, 16);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Pending Qty";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(176, 56);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(187, 20);
            this.txtCustName.TabIndex = 7;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(879, 84);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(86, 16);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "Received Qty";
            // 
            // txtRawMaterial
            // 
            this.txtRawMaterial.Location = new System.Drawing.Point(176, 82);
            this.txtRawMaterial.Name = "txtRawMaterial";
            this.txtRawMaterial.Size = new System.Drawing.Size(187, 20);
            this.txtRawMaterial.TabIndex = 8;
            // 
            // txtRawType
            // 
            this.txtRawType.Location = new System.Drawing.Point(176, 108);
            this.txtRawType.Name = "txtRawType";
            this.txtRawType.Size = new System.Drawing.Size(187, 20);
            this.txtRawType.TabIndex = 9;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(879, 27);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(81, 16);
            this.labelControl14.TabIndex = 18;
            this.labelControl14.Text = "Product Size";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(451, 27);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(100, 16);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Employee Name";
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(615, 107);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(187, 20);
            this.txtQuanity.TabIndex = 17;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(451, 56);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(87, 16);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Product Code";
            // 
            // txtProModel
            // 
            this.txtProModel.Location = new System.Drawing.Point(615, 81);
            this.txtProModel.Name = "txtProModel";
            this.txtProModel.Size = new System.Drawing.Size(187, 20);
            this.txtProModel.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(451, 84);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(93, 16);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Product Model";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(615, 55);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(187, 20);
            this.txtProductCode.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(451, 109);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 16);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Quantity";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(615, 26);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(187, 20);
            this.txtEmpName.TabIndex = 14;
            // 
            // FrmJobReallocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1821, 826);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmJobReallocation";
            this.Text = "FrmJobReallocation";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
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
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit txtEmployeeCode;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit drpEmpCode;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnTransfer;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
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
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWt;
        private DevExpress.XtraGrid.Columns.GridColumn colShortage;
        private DevExpress.XtraGrid.Columns.GridColumn colorderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colorderWt;
        private DevExpress.XtraEditors.LabelControl lblWeight;
    }
}