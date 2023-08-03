
namespace BillPlex
{
    partial class FrmJobReceivedInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJobReceivedInfo));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSize1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPiece1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightKg1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExcess1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvlQty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortage1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPendingQty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreceived1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWages1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentWt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivingDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalanceWt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderno2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderdate = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPendingQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalanceWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWagesEmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmpCode2 = new DevExpress.XtraEditors.TextEdit();
            this.chckViewDailyRecievPending = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.drpIncentiveApp = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtConveyance = new DevExpress.XtraEditors.TextEdit();
            this.txtNetAmt = new DevExpress.XtraEditors.TextEdit();
            this.txtIncentive = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtDeduction = new DevExpress.XtraEditors.TextEdit();
            this.txtBalanceWeight = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtCName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.txtAfterdys = new DevExpress.XtraEditors.TextEdit();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.txtRcvdQty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.txtMName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.txtPQty = new DevExpress.XtraEditors.TextEdit();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.txtCrntWt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBeforeDys = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtPSize = new DevExpress.XtraEditors.TextEdit();
            this.txtColor = new DevExpress.XtraEditors.TextEdit();
            this.txtPCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.ddReceDate = new DevExpress.XtraEditors.DateEdit();
            this.txtEmpName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmpCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtWages = new DevExpress.XtraEditors.TextEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.txtRawMaterial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckViewDailyRecievPending.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpIncentiveApp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConveyance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncentive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeduction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterdys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRcvdQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCrntWt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeDys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Controls.Add(this.panelControl7);
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Location = new System.Drawing.Point(12, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1355, 816);
            this.panelControl1.TabIndex = 5;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.btnClear);
            this.panelControl7.Controls.Add(this.btnDelete);
            this.panelControl7.Controls.Add(this.btnUpdate);
            this.panelControl7.Controls.Add(this.btnEdit);
            this.panelControl7.Controls.Add(this.btnAdd);
            this.panelControl7.Controls.Add(this.btnExit);
            this.panelControl7.Controls.Add(this.btnNew);
            this.panelControl7.Location = new System.Drawing.Point(1224, 247);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(113, 307);
            this.panelControl7.TabIndex = 136;
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(18, 220);
            this.btnClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnClear.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 23);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(18, 173);
            this.btnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "DELETE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(18, 128);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(18, 87);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 23);
            this.btnEdit.TabIndex = 61;
            this.btnEdit.Text = "EDIT";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(18, 48);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(18, 265);
            this.btnExit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnExit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 23);
            this.btnExit.TabIndex = 59;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(18, 5);
            this.btnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 23);
            this.btnNew.TabIndex = 53;
            this.btnNew.Text = "NEW";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.panelControl4);
            this.panelControl5.Controls.Add(this.txtEmpCode2);
            this.panelControl5.Controls.Add(this.chckViewDailyRecievPending);
            this.panelControl5.Controls.Add(this.labelControl25);
            this.panelControl5.Location = new System.Drawing.Point(5, 381);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1203, 430);
            this.panelControl5.TabIndex = 135;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridControl2);
            this.panelControl4.Controls.Add(this.labelControl7);
            this.panelControl4.Controls.Add(this.gridControl1);
            this.panelControl4.Location = new System.Drawing.Point(5, 36);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1161, 380);
            this.panelControl4.TabIndex = 135;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "PRO_GetJobGivingWithoutDCReceivedFilter";
            this.gridControl2.DataSource = this.sqlDataSource2;
            this.gridControl2.Location = new System.Drawing.Point(16, 40);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1109, 311);
            this.gridControl2.TabIndex = 137;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "BillPlex";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery1.Name = "PRO_GetJobGivingWithoutDCReceivedFilter";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetJobGivingWithoutDCReceivedFilter";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colEmployeeCode1,
            this.colEmployeeName1,
            this.CompanyName,
            this.ClientCompany,
            this.SubClientCompany,
            this.colOrderNo,
            this.colOrderDate1,
            this.colCustomerCode1,
            this.colCustomerName1,
            this.colModelName1,
            this.colModelCode1,
            this.colProductSize1,
            this.colRawMaterial1,
            this.colQuantityPiece1,
            this.colWeightKg1,
            this.colExcess1,
            this.colColor1,
            this.colType1,
            this.colAvlQty1,
            this.colShortage1,
            this.colTotalQty1,
            this.colPendingQty1,
            this.colreceived1,
            this.colWages1,
            this.colCurrentWt1,
            this.colReceivingDate1,
            this.colBalanceWt1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
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
            // CompanyName
            // 
            this.CompanyName.Caption = "CompanyName";
            this.CompanyName.FieldName = "CompanyName";
            this.CompanyName.MinWidth = 80;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Visible = true;
            this.CompanyName.VisibleIndex = 3;
            this.CompanyName.Width = 80;
            // 
            // ClientCompany
            // 
            this.ClientCompany.Caption = "ClientCompany";
            this.ClientCompany.FieldName = "ClientCompany";
            this.ClientCompany.MinWidth = 80;
            this.ClientCompany.Name = "ClientCompany";
            this.ClientCompany.Visible = true;
            this.ClientCompany.VisibleIndex = 4;
            this.ClientCompany.Width = 80;
            // 
            // SubClientCompany
            // 
            this.SubClientCompany.Caption = "SubClientCompany";
            this.SubClientCompany.FieldName = "SubClientCompany";
            this.SubClientCompany.MinWidth = 80;
            this.SubClientCompany.Name = "SubClientCompany";
            this.SubClientCompany.Visible = true;
            this.SubClientCompany.VisibleIndex = 5;
            this.SubClientCompany.Width = 80;
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
            // colQuantityPiece1
            // 
            this.colQuantityPiece1.FieldName = "QuantityPiece";
            this.colQuantityPiece1.MinWidth = 80;
            this.colQuantityPiece1.Name = "colQuantityPiece1";
            this.colQuantityPiece1.Visible = true;
            this.colQuantityPiece1.VisibleIndex = 14;
            this.colQuantityPiece1.Width = 80;
            // 
            // colWeightKg1
            // 
            this.colWeightKg1.FieldName = "WeightKg";
            this.colWeightKg1.MinWidth = 80;
            this.colWeightKg1.Name = "colWeightKg1";
            this.colWeightKg1.Visible = true;
            this.colWeightKg1.VisibleIndex = 15;
            this.colWeightKg1.Width = 80;
            // 
            // colExcess1
            // 
            this.colExcess1.FieldName = "Excess";
            this.colExcess1.MinWidth = 80;
            this.colExcess1.Name = "colExcess1";
            this.colExcess1.Visible = true;
            this.colExcess1.VisibleIndex = 16;
            this.colExcess1.Width = 80;
            // 
            // colColor1
            // 
            this.colColor1.FieldName = "Color";
            this.colColor1.MinWidth = 80;
            this.colColor1.Name = "colColor1";
            this.colColor1.Visible = true;
            this.colColor1.VisibleIndex = 17;
            this.colColor1.Width = 80;
            // 
            // colType1
            // 
            this.colType1.FieldName = "Type";
            this.colType1.MinWidth = 80;
            this.colType1.Name = "colType1";
            this.colType1.Visible = true;
            this.colType1.VisibleIndex = 18;
            this.colType1.Width = 80;
            // 
            // colAvlQty1
            // 
            this.colAvlQty1.FieldName = "AvlQty";
            this.colAvlQty1.MinWidth = 80;
            this.colAvlQty1.Name = "colAvlQty1";
            this.colAvlQty1.Visible = true;
            this.colAvlQty1.VisibleIndex = 19;
            this.colAvlQty1.Width = 80;
            // 
            // colShortage1
            // 
            this.colShortage1.FieldName = "Shortage";
            this.colShortage1.MinWidth = 80;
            this.colShortage1.Name = "colShortage1";
            this.colShortage1.Visible = true;
            this.colShortage1.VisibleIndex = 20;
            this.colShortage1.Width = 80;
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
            // colPendingQty1
            // 
            this.colPendingQty1.FieldName = "PendingQty";
            this.colPendingQty1.MinWidth = 80;
            this.colPendingQty1.Name = "colPendingQty1";
            this.colPendingQty1.Visible = true;
            this.colPendingQty1.VisibleIndex = 22;
            this.colPendingQty1.Width = 80;
            // 
            // colreceived1
            // 
            this.colreceived1.FieldName = "received";
            this.colreceived1.MinWidth = 80;
            this.colreceived1.Name = "colreceived1";
            this.colreceived1.Visible = true;
            this.colreceived1.VisibleIndex = 23;
            this.colreceived1.Width = 80;
            // 
            // colWages1
            // 
            this.colWages1.FieldName = "Wages";
            this.colWages1.MinWidth = 80;
            this.colWages1.Name = "colWages1";
            this.colWages1.Visible = true;
            this.colWages1.VisibleIndex = 24;
            this.colWages1.Width = 80;
            // 
            // colCurrentWt1
            // 
            this.colCurrentWt1.FieldName = "CurrentWt";
            this.colCurrentWt1.MinWidth = 80;
            this.colCurrentWt1.Name = "colCurrentWt1";
            this.colCurrentWt1.Visible = true;
            this.colCurrentWt1.VisibleIndex = 25;
            this.colCurrentWt1.Width = 80;
            // 
            // colReceivingDate1
            // 
            this.colReceivingDate1.FieldName = "ReceivingDate";
            this.colReceivingDate1.MinWidth = 80;
            this.colReceivingDate1.Name = "colReceivingDate1";
            this.colReceivingDate1.Visible = true;
            this.colReceivingDate1.VisibleIndex = 26;
            this.colReceivingDate1.Width = 80;
            // 
            // colBalanceWt1
            // 
            this.colBalanceWt1.FieldName = "BalanceWt";
            this.colBalanceWt1.MinWidth = 80;
            this.colBalanceWt1.Name = "colBalanceWt1";
            this.colBalanceWt1.Visible = true;
            this.colBalanceWt1.VisibleIndex = 27;
            this.colBalanceWt1.Width = 80;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 15);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(123, 18);
            this.labelControl7.TabIndex = 136;
            this.labelControl7.Text = "Job Giving Info";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetJobGivingWithoutDC";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(6, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1150, 335);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "PRO_GetJobGivingWithoutDC";
            queryParameter2.Name = "@SearchKey";
            queryParameter2.Type = typeof(string);
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.StoredProcName = "PRO_GetJobGivingWithoutDC";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
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
            this.colOrderNo1,
            this.colOrderno2,
            this.colOrderdate,
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
            this.colTotalQty,
            this.colPendingQty,
            this.colreceived,
            this.colWages,
            this.colCurrentWt,
            this.colReceivingDate,
            this.colBalanceWt,
            this.colWagesEmp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 80;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 80;
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
            // colOrderNo1
            // 
            this.colOrderNo1.FieldName = "OrderNo";
            this.colOrderNo1.MinWidth = 80;
            this.colOrderNo1.Name = "colOrderNo1";
            this.colOrderNo1.Visible = true;
            this.colOrderNo1.VisibleIndex = 6;
            this.colOrderNo1.Width = 80;
            // 
            // colOrderno2
            // 
            this.colOrderno2.FieldName = "Orderno";
            this.colOrderno2.MinWidth = 80;
            this.colOrderno2.Name = "colOrderno2";
            this.colOrderno2.Visible = true;
            this.colOrderno2.VisibleIndex = 7;
            this.colOrderno2.Width = 80;
            // 
            // colOrderdate
            // 
            this.colOrderdate.FieldName = "CustomerCode";
            this.colOrderdate.MinWidth = 80;
            this.colOrderdate.Name = "colOrderdate";
            this.colOrderdate.Visible = true;
            this.colOrderdate.VisibleIndex = 8;
            this.colOrderdate.Width = 80;
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
            this.colorderQty.Width = 1000;
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
            // colTotalQty
            // 
            this.colTotalQty.FieldName = "TotalQty";
            this.colTotalQty.MinWidth = 80;
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 25;
            this.colTotalQty.Width = 80;
            // 
            // colPendingQty
            // 
            this.colPendingQty.FieldName = "PendingQty";
            this.colPendingQty.MinWidth = 80;
            this.colPendingQty.Name = "colPendingQty";
            this.colPendingQty.Visible = true;
            this.colPendingQty.VisibleIndex = 26;
            this.colPendingQty.Width = 80;
            // 
            // colreceived
            // 
            this.colreceived.FieldName = "received";
            this.colreceived.MinWidth = 80;
            this.colreceived.Name = "colreceived";
            this.colreceived.Visible = true;
            this.colreceived.VisibleIndex = 27;
            this.colreceived.Width = 80;
            // 
            // colWages
            // 
            this.colWages.FieldName = "Wages";
            this.colWages.MinWidth = 80;
            this.colWages.Name = "colWages";
            this.colWages.Visible = true;
            this.colWages.VisibleIndex = 28;
            this.colWages.Width = 80;
            // 
            // colCurrentWt
            // 
            this.colCurrentWt.FieldName = "CurrentWt";
            this.colCurrentWt.MinWidth = 80;
            this.colCurrentWt.Name = "colCurrentWt";
            this.colCurrentWt.Visible = true;
            this.colCurrentWt.VisibleIndex = 29;
            this.colCurrentWt.Width = 80;
            // 
            // colReceivingDate
            // 
            this.colReceivingDate.FieldName = "ReceivingDate";
            this.colReceivingDate.MinWidth = 80;
            this.colReceivingDate.Name = "colReceivingDate";
            this.colReceivingDate.Visible = true;
            this.colReceivingDate.VisibleIndex = 30;
            this.colReceivingDate.Width = 80;
            // 
            // colBalanceWt
            // 
            this.colBalanceWt.FieldName = "BalanceWt";
            this.colBalanceWt.MinWidth = 80;
            this.colBalanceWt.Name = "colBalanceWt";
            this.colBalanceWt.Visible = true;
            this.colBalanceWt.VisibleIndex = 31;
            this.colBalanceWt.Width = 80;
            // 
            // colWagesEmp
            // 
            this.colWagesEmp.FieldName = "WagesEmp";
            this.colWagesEmp.MinWidth = 80;
            this.colWagesEmp.Name = "colWagesEmp";
            this.colWagesEmp.Visible = true;
            this.colWagesEmp.VisibleIndex = 32;
            this.colWagesEmp.Width = 80;
            // 
            // txtEmpCode2
            // 
            this.txtEmpCode2.Location = new System.Drawing.Point(435, 9);
            this.txtEmpCode2.Name = "txtEmpCode2";
            this.txtEmpCode2.Size = new System.Drawing.Size(113, 20);
            this.txtEmpCode2.TabIndex = 135;
            this.txtEmpCode2.EditValueChanged += new System.EventHandler(this.txtEmpCode2_EditValueChanged);
            // 
            // chckViewDailyRecievPending
            // 
            this.chckViewDailyRecievPending.Location = new System.Drawing.Point(9, 5);
            this.chckViewDailyRecievPending.Name = "chckViewDailyRecievPending";
            this.chckViewDailyRecievPending.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckViewDailyRecievPending.Properties.Appearance.Options.UseFont = true;
            this.chckViewDailyRecievPending.Properties.Caption = "View DailyReceived Pending";
            this.chckViewDailyRecievPending.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.chckViewDailyRecievPending.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.chckViewDailyRecievPending.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chckViewDailyRecievPending.Size = new System.Drawing.Size(265, 22);
            this.chckViewDailyRecievPending.TabIndex = 93;
            this.chckViewDailyRecievPending.CheckedChanged += new System.EventHandler(this.chckViewDailyRecievPending_CheckedChanged);
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl25.Appearance.Options.UseFont = true;
            this.labelControl25.Location = new System.Drawing.Point(294, 9);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(126, 18);
            this.labelControl25.TabIndex = 135;
            this.labelControl25.Text = "Employee Code";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl20);
            this.panelControl2.Location = new System.Drawing.Point(16, 61);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(241, 32);
            this.panelControl2.TabIndex = 4;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Appearance.Options.UseForeColor = true;
            this.labelControl20.Location = new System.Drawing.Point(3, 4);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(226, 18);
            this.labelControl20.TabIndex = 92;
            this.labelControl20.Text = "Assign a Job To Employee";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl9);
            this.panelControl3.Controls.Add(this.drpIncentiveApp);
            this.panelControl3.Controls.Add(this.txtConveyance);
            this.panelControl3.Controls.Add(this.txtNetAmt);
            this.panelControl3.Controls.Add(this.txtIncentive);
            this.panelControl3.Controls.Add(this.labelControl23);
            this.panelControl3.Controls.Add(this.labelControl22);
            this.panelControl3.Controls.Add(this.labelControl21);
            this.panelControl3.Controls.Add(this.labelControl18);
            this.panelControl3.Controls.Add(this.labelControl17);
            this.panelControl3.Controls.Add(this.txtTotal);
            this.panelControl3.Controls.Add(this.txtDeduction);
            this.panelControl3.Controls.Add(this.txtBalanceWeight);
            this.panelControl3.Controls.Add(this.labelControl14);
            this.panelControl3.Controls.Add(this.txtCName);
            this.panelControl3.Controls.Add(this.labelControl11);
            this.panelControl3.Controls.Add(this.labelControl44);
            this.panelControl3.Controls.Add(this.labelControl43);
            this.panelControl3.Controls.Add(this.txtAfterdys);
            this.panelControl3.Controls.Add(this.labelControl42);
            this.panelControl3.Controls.Add(this.labelControl41);
            this.panelControl3.Controls.Add(this.txtRcvdQty);
            this.panelControl3.Controls.Add(this.labelControl31);
            this.panelControl3.Controls.Add(this.txtMName);
            this.panelControl3.Controls.Add(this.labelControl30);
            this.panelControl3.Controls.Add(this.txtPQty);
            this.panelControl3.Controls.Add(this.txtWeight);
            this.panelControl3.Controls.Add(this.txtCrntWt);
            this.panelControl3.Controls.Add(this.labelControl19);
            this.panelControl3.Controls.Add(this.txtType);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.txtBeforeDys);
            this.panelControl3.Controls.Add(this.labelControl15);
            this.panelControl3.Controls.Add(this.labelControl16);
            this.panelControl3.Controls.Add(this.txtPSize);
            this.panelControl3.Controls.Add(this.txtColor);
            this.panelControl3.Controls.Add(this.txtPCode);
            this.panelControl3.Controls.Add(this.labelControl10);
            this.panelControl3.Controls.Add(this.ddReceDate);
            this.panelControl3.Controls.Add(this.txtEmpName);
            this.panelControl3.Controls.Add(this.txtEmpCode);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.txtPModel);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.txtQuantity);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.txtWages);
            this.panelControl3.Controls.Add(this.labelControl32);
            this.panelControl3.Controls.Add(this.txtRawMaterial);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl24);
            this.panelControl3.Controls.Add(this.labelControl38);
            this.panelControl3.Controls.Add(this.labelControl39);
            this.panelControl3.Controls.Add(this.labelControl35);
            this.panelControl3.Controls.Add(this.labelControl33);
            this.panelControl3.Location = new System.Drawing.Point(5, 74);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1203, 301);
            this.panelControl3.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(743, 46);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(10, 18);
            this.labelControl9.TabIndex = 138;
            this.labelControl9.Text = "*";
            // 
            // drpIncentiveApp
            // 
            this.drpIncentiveApp.Location = new System.Drawing.Point(764, 160);
            this.drpIncentiveApp.Name = "drpIncentiveApp";
            this.drpIncentiveApp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpIncentiveApp.Size = new System.Drawing.Size(100, 20);
            this.drpIncentiveApp.TabIndex = 135;
            // 
            // txtConveyance
            // 
            this.txtConveyance.Location = new System.Drawing.Point(1015, 198);
            this.txtConveyance.Name = "txtConveyance";
            this.txtConveyance.Properties.BeepOnError = false;
            this.txtConveyance.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtConveyance.Properties.MaskSettings.Set("mask", "d");
            this.txtConveyance.Properties.UseMaskAsDisplayFormat = true;
            this.txtConveyance.Size = new System.Drawing.Size(115, 20);
            this.txtConveyance.TabIndex = 134;
            this.txtConveyance.EditValueChanged += new System.EventHandler(this.txtRcvdQty_EditValueChanged);
            // 
            // txtNetAmt
            // 
            this.txtNetAmt.Enabled = false;
            this.txtNetAmt.Location = new System.Drawing.Point(1015, 253);
            this.txtNetAmt.Name = "txtNetAmt";
            this.txtNetAmt.Properties.BeepOnError = false;
            this.txtNetAmt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtNetAmt.Properties.MaskSettings.Set("mask", "d");
            this.txtNetAmt.Properties.UseMaskAsDisplayFormat = true;
            this.txtNetAmt.Size = new System.Drawing.Size(115, 20);
            this.txtNetAmt.TabIndex = 133;
            // 
            // txtIncentive
            // 
            this.txtIncentive.Location = new System.Drawing.Point(1015, 224);
            this.txtIncentive.Name = "txtIncentive";
            this.txtIncentive.Properties.BeepOnError = false;
            this.txtIncentive.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIncentive.Properties.MaskSettings.Set("mask", "d");
            this.txtIncentive.Properties.UseMaskAsDisplayFormat = true;
            this.txtIncentive.Size = new System.Drawing.Size(115, 20);
            this.txtIncentive.TabIndex = 132;
            this.txtIncentive.EditValueChanged += new System.EventHandler(this.txtRcvdQty_EditValueChanged);
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(924, 253);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(68, 18);
            this.labelControl23.TabIndex = 131;
            this.labelControl23.Text = "Net Amt";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(895, 196);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(97, 18);
            this.labelControl22.TabIndex = 130;
            this.labelControl22.Text = "Conveyance";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(916, 225);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(76, 18);
            this.labelControl21.TabIndex = 129;
            this.labelControl21.Text = "Incentive";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(614, 250);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(42, 18);
            this.labelControl18.TabIndex = 128;
            this.labelControl18.Text = "Total";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(614, 225);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(82, 18);
            this.labelControl17.TabIndex = 127;
            this.labelControl17.Text = "Deduction";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(764, 252);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.BeepOnError = false;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("mask", "d");
            this.txtTotal.Properties.UseMaskAsDisplayFormat = true;
            this.txtTotal.Size = new System.Drawing.Size(113, 20);
            this.txtTotal.TabIndex = 126;
            // 
            // txtDeduction
            // 
            this.txtDeduction.Location = new System.Drawing.Point(764, 222);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Properties.BeepOnError = false;
            this.txtDeduction.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDeduction.Properties.MaskSettings.Set("mask", "d");
            this.txtDeduction.Properties.UseMaskAsDisplayFormat = true;
            this.txtDeduction.Size = new System.Drawing.Size(113, 20);
            this.txtDeduction.TabIndex = 125;
            this.txtDeduction.EditValueChanged += new System.EventHandler(this.txtRcvdQty_EditValueChanged);
            // 
            // txtBalanceWeight
            // 
            this.txtBalanceWeight.Enabled = false;
            this.txtBalanceWeight.Location = new System.Drawing.Point(764, 188);
            this.txtBalanceWeight.Name = "txtBalanceWeight";
            this.txtBalanceWeight.Size = new System.Drawing.Size(113, 20);
            this.txtBalanceWeight.TabIndex = 124;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(614, 189);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(129, 18);
            this.labelControl14.TabIndex = 123;
            this.labelControl14.Text = "Balance Weight";
            // 
            // txtCName
            // 
            this.txtCName.Enabled = false;
            this.txtCName.Location = new System.Drawing.Point(186, 90);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(403, 20);
            this.txtCName.TabIndex = 122;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(10, 88);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(131, 18);
            this.labelControl11.TabIndex = 121;
            this.labelControl11.Text = "Customer Name";
            // 
            // labelControl44
            // 
            this.labelControl44.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl44.Appearance.Options.UseFont = true;
            this.labelControl44.Location = new System.Drawing.Point(1003, 165);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(54, 18);
            this.labelControl44.TabIndex = 120;
            this.labelControl44.Text = "(Days)";
            // 
            // labelControl43
            // 
            this.labelControl43.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl43.Appearance.Options.UseFont = true;
            this.labelControl43.Location = new System.Drawing.Point(869, 165);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(54, 18);
            this.labelControl43.TabIndex = 94;
            this.labelControl43.Text = "(Days)";
            // 
            // txtAfterdys
            // 
            this.txtAfterdys.Location = new System.Drawing.Point(1062, 162);
            this.txtAfterdys.Name = "txtAfterdys";
            this.txtAfterdys.Size = new System.Drawing.Size(68, 20);
            this.txtAfterdys.TabIndex = 119;
            // 
            // labelControl42
            // 
            this.labelControl42.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl42.Appearance.Options.UseFont = true;
            this.labelControl42.Location = new System.Drawing.Point(1007, 146);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(40, 18);
            this.labelControl42.TabIndex = 118;
            this.labelControl42.Text = "After";
            // 
            // labelControl41
            // 
            this.labelControl41.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl41.Appearance.Options.UseFont = true;
            this.labelControl41.Location = new System.Drawing.Point(868, 146);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(53, 18);
            this.labelControl41.TabIndex = 117;
            this.labelControl41.Text = "Before";
            // 
            // txtRcvdQty
            // 
            this.txtRcvdQty.Location = new System.Drawing.Point(482, 219);
            this.txtRcvdQty.Name = "txtRcvdQty";
            this.txtRcvdQty.Properties.BeepOnError = false;
            this.txtRcvdQty.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtRcvdQty.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtRcvdQty.Properties.MaskSettings.Set("mask", "d");
            this.txtRcvdQty.Properties.UseMaskAsDisplayFormat = true;
            this.txtRcvdQty.Size = new System.Drawing.Size(107, 20);
            this.txtRcvdQty.TabIndex = 116;
            this.txtRcvdQty.EditValueChanged += new System.EventHandler(this.txtRcvdQty_EditValueChanged);
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl31.Appearance.Options.UseFont = true;
            this.labelControl31.Location = new System.Drawing.Point(368, 218);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(73, 18);
            this.labelControl31.TabIndex = 115;
            this.labelControl31.Text = "Rcvd Qty";
            // 
            // txtMName
            // 
            this.txtMName.Enabled = false;
            this.txtMName.Location = new System.Drawing.Point(186, 249);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(403, 20);
            this.txtMName.TabIndex = 114;
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Location = new System.Drawing.Point(11, 250);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(101, 18);
            this.labelControl30.TabIndex = 98;
            this.labelControl30.Text = "Model Name";
            // 
            // txtPQty
            // 
            this.txtPQty.Enabled = false;
            this.txtPQty.Location = new System.Drawing.Point(186, 217);
            this.txtPQty.Name = "txtPQty";
            this.txtPQty.Size = new System.Drawing.Size(158, 20);
            this.txtPQty.TabIndex = 113;
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(482, 160);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(107, 20);
            this.txtWeight.TabIndex = 112;
            // 
            // txtCrntWt
            // 
            this.txtCrntWt.Location = new System.Drawing.Point(482, 186);
            this.txtCrntWt.Name = "txtCrntWt";
            this.txtCrntWt.Properties.BeepOnError = false;
            this.txtCrntWt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCrntWt.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCrntWt.Properties.MaskSettings.Set("mask", "n3");
            this.txtCrntWt.Properties.UseMaskAsDisplayFormat = true;
            this.txtCrntWt.Size = new System.Drawing.Size(107, 20);
            this.txtCrntWt.TabIndex = 111;
            this.txtCrntWt.EditValueChanged += new System.EventHandler(this.txtCrntWt_EditValueChanged);
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(368, 189);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(90, 18);
            this.labelControl19.TabIndex = 110;
            this.labelControl19.Text = "Current Wt";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(482, 132);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(107, 20);
            this.txtType.TabIndex = 109;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(368, 130);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 18);
            this.labelControl6.TabIndex = 108;
            this.labelControl6.Text = "Type";
            // 
            // txtBeforeDys
            // 
            this.txtBeforeDys.Location = new System.Drawing.Point(934, 162);
            this.txtBeforeDys.Name = "txtBeforeDys";
            this.txtBeforeDys.Size = new System.Drawing.Size(58, 20);
            this.txtBeforeDys.TabIndex = 107;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(614, 146);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(76, 18);
            this.labelControl15.TabIndex = 105;
            this.labelControl15.Text = "Incentive";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(614, 164);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(84, 18);
            this.labelControl16.TabIndex = 106;
            this.labelControl16.Text = "Applicable";
            // 
            // txtPSize
            // 
            this.txtPSize.Enabled = false;
            this.txtPSize.Location = new System.Drawing.Point(764, 113);
            this.txtPSize.Name = "txtPSize";
            this.txtPSize.Size = new System.Drawing.Size(113, 20);
            this.txtPSize.TabIndex = 104;
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(978, 113);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(152, 20);
            this.txtColor.TabIndex = 103;
            // 
            // txtPCode
            // 
            this.txtPCode.Enabled = false;
            this.txtPCode.Location = new System.Drawing.Point(978, 76);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(152, 20);
            this.txtPCode.TabIndex = 102;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(924, 77);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 18);
            this.labelControl10.TabIndex = 101;
            this.labelControl10.Text = "Code";
            // 
            // ddReceDate
            // 
            this.ddReceDate.EditValue = null;
            this.ddReceDate.Location = new System.Drawing.Point(764, 43);
            this.ddReceDate.Name = "ddReceDate";
            this.ddReceDate.Properties.BeepOnError = false;
            this.ddReceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddReceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddReceDate.Properties.DisplayFormat.FormatString = "";
            this.ddReceDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddReceDate.Properties.EditFormat.FormatString = "";
            this.ddReceDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddReceDate.Properties.MaskSettings.Set("mask", "d");
            this.ddReceDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddReceDate.Size = new System.Drawing.Size(366, 20);
            this.ddReceDate.TabIndex = 98;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(309, 51);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(280, 20);
            this.txtEmpName.TabIndex = 100;
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.EditValue = "";
            this.txtEmpCode.Enabled = false;
            this.txtEmpCode.Location = new System.Drawing.Point(186, 51);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new System.Drawing.Size(117, 20);
            this.txtEmpCode.TabIndex = 99;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(83, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "/ Name";
            // 
            // txtPModel
            // 
            this.txtPModel.Enabled = false;
            this.txtPModel.Location = new System.Drawing.Point(764, 79);
            this.txtPModel.Name = "txtPModel";
            this.txtPModel.Size = new System.Drawing.Size(128, 20);
            this.txtPModel.TabIndex = 87;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(614, 74);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 18);
            this.labelControl5.TabIndex = 86;
            this.labelControl5.Text = "Product Model";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(614, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 18);
            this.labelControl4.TabIndex = 85;
            this.labelControl4.Text = "Receiving Date";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(186, 162);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(158, 20);
            this.txtQuantity.TabIndex = 84;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 165);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 18);
            this.labelControl3.TabIndex = 83;
            this.labelControl3.Text = "Quantity";
            // 
            // txtWages
            // 
            this.txtWages.Enabled = false;
            this.txtWages.Location = new System.Drawing.Point(186, 191);
            this.txtWages.Name = "txtWages";
            this.txtWages.Size = new System.Drawing.Size(158, 20);
            this.txtWages.TabIndex = 82;
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Appearance.Options.UseFont = true;
            this.labelControl32.Location = new System.Drawing.Point(11, 195);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(56, 18);
            this.labelControl32.TabIndex = 62;
            this.labelControl32.Text = "Wages";
            // 
            // txtRawMaterial
            // 
            this.txtRawMaterial.Enabled = false;
            this.txtRawMaterial.Location = new System.Drawing.Point(186, 132);
            this.txtRawMaterial.Name = "txtRawMaterial";
            this.txtRawMaterial.Size = new System.Drawing.Size(158, 20);
            this.txtRawMaterial.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Employee Code";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Location = new System.Drawing.Point(924, 116);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(42, 18);
            this.labelControl24.TabIndex = 39;
            this.labelControl24.Text = "Color";
            // 
            // labelControl38
            // 
            this.labelControl38.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl38.Appearance.Options.UseFont = true;
            this.labelControl38.Location = new System.Drawing.Point(614, 111);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(101, 18);
            this.labelControl38.TabIndex = 6;
            this.labelControl38.Text = "Product Size";
            // 
            // labelControl39
            // 
            this.labelControl39.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl39.Appearance.Options.UseFont = true;
            this.labelControl39.Location = new System.Drawing.Point(10, 220);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(100, 18);
            this.labelControl39.TabIndex = 9;
            this.labelControl39.Text = "Pending Qty";
            // 
            // labelControl35
            // 
            this.labelControl35.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl35.Appearance.Options.UseFont = true;
            this.labelControl35.Location = new System.Drawing.Point(11, 135);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(159, 18);
            this.labelControl35.TabIndex = 10;
            this.labelControl35.Text = "Raw Material Name";
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl33.Appearance.Options.UseFont = true;
            this.labelControl33.Location = new System.Drawing.Point(368, 163);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(59, 18);
            this.labelControl33.TabIndex = 12;
            this.labelControl33.Text = "Weight";
            // 
            // panelControl6
            // 
            this.panelControl6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl6.Appearance.Options.UseBackColor = true;
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl6.Controls.Add(this.labelControl8);
            this.panelControl6.Location = new System.Drawing.Point(5, 4);
            this.panelControl6.LookAndFeel.SkinName = "DevExpress Style";
            this.panelControl6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(1345, 41);
            this.panelControl6.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(568, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(208, 32);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Job Received ";
            // 
            // FrmJobReceivedInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1374, 846);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmJobReceivedInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmJobReceivedInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmJobReceivedInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckViewDailyRecievPending.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpIncentiveApp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConveyance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncentive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeduction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterdys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRcvdQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCrntWt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeDys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txtPModel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtWages;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.TextEdit txtRawMaterial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtCrntWt;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBeforeDys;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtPSize;
        private DevExpress.XtraEditors.TextEdit txtColor;
        private DevExpress.XtraEditors.TextEdit txtPCode;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit ddReceDate;
        private DevExpress.XtraEditors.TextEdit txtEmpName;
        private DevExpress.XtraEditors.TextEdit txtEmpCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private DevExpress.XtraEditors.TextEdit txtRcvdQty;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.TextEdit txtMName;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit txtPQty;
        private DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraEditors.LabelControl labelControl44;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraEditors.TextEdit txtAfterdys;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraEditors.TextEdit txtConveyance;
        private DevExpress.XtraEditors.TextEdit txtNetAmt;
        private DevExpress.XtraEditors.TextEdit txtIncentive;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtDeduction;
        private DevExpress.XtraEditors.TextEdit txtBalanceWeight;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtCName;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtEmpCode2;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.CheckEdit chckViewDailyRecievPending;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit drpIncentiveApp;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName1;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn ClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn SubClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName1;
        private DevExpress.XtraGrid.Columns.GridColumn colModelName1;
        private DevExpress.XtraGrid.Columns.GridColumn colModelCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSize1;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterial1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPiece1;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightKg1;
        private DevExpress.XtraGrid.Columns.GridColumn colExcess1;
        private DevExpress.XtraGrid.Columns.GridColumn colColor1;
        private DevExpress.XtraGrid.Columns.GridColumn colType1;
        private DevExpress.XtraGrid.Columns.GridColumn colAvlQty1;
        private DevExpress.XtraGrid.Columns.GridColumn colShortage1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty1;
        private DevExpress.XtraGrid.Columns.GridColumn colPendingQty1;
        private DevExpress.XtraGrid.Columns.GridColumn colreceived1;
        private DevExpress.XtraGrid.Columns.GridColumn colWages1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentWt1;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivingDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceWt1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderno2;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderdate;
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
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colPendingQty;
        private DevExpress.XtraGrid.Columns.GridColumn colreceived;
        private DevExpress.XtraGrid.Columns.GridColumn colWages;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentWt;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceWt;
        private DevExpress.XtraGrid.Columns.GridColumn colWagesEmp;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}