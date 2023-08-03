
namespace BillPlex
{
    partial class FrmDirectJobReceivedWithoutGivingInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectJobReceivedWithoutGivingInfo));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirectorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProsize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncentiveApplicable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeduction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConveyance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Incentive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNetAmt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtIncentive = new DevExpress.XtraEditors.TextEdit();
            this.txtConveyance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtAfterDays = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtBeforeDays = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtDeducation = new DevExpress.XtraEditors.TextEdit();
            this.drpIncentiveApp = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpColor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtSize = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtWages = new DevExpress.XtraEditors.TextEdit();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.drpProductCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpProductModel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ddReceivingDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubContractor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.txtClientName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.txtDirector = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmpName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtComName = new DevExpress.XtraEditors.TextEdit();
            this.txtClientCompany = new DevExpress.XtraEditors.TextEdit();
            this.txtSubClient = new DevExpress.XtraEditors.TextEdit();
            this.drpEmpCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncentive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConveyance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeducation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpIncentiveApp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceivingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceivingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubContractor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1499, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Location = new System.Drawing.Point(5, 67);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1499, 711);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.btnExit);
            this.panelControl5.Controls.Add(this.btnClear);
            this.panelControl5.Controls.Add(this.btnDelete);
            this.panelControl5.Controls.Add(this.btnUpdate);
            this.panelControl5.Controls.Add(this.btnEdit);
            this.panelControl5.Controls.Add(this.btnAdd);
            this.panelControl5.Controls.Add(this.btnNew);
            this.panelControl5.Location = new System.Drawing.Point(1371, 195);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(98, 281);
            this.panelControl5.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(12, 246);
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(12, 207);
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(12, 168);
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(12, 126);
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(12, 86);
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "EDIT";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(12, 43);
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnNew.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseBackColor = true;
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(12, 5);
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "NEW";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl23);
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Controls.Add(this.txtNetAmt);
            this.panelControl3.Controls.Add(this.labelControl18);
            this.panelControl3.Controls.Add(this.txtIncentive);
            this.panelControl3.Controls.Add(this.txtConveyance);
            this.panelControl3.Controls.Add(this.labelControl17);
            this.panelControl3.Controls.Add(this.labelControl16);
            this.panelControl3.Controls.Add(this.txtAfterDays);
            this.panelControl3.Controls.Add(this.labelControl14);
            this.panelControl3.Controls.Add(this.txtBeforeDays);
            this.panelControl3.Controls.Add(this.labelControl13);
            this.panelControl3.Controls.Add(this.txtTotal);
            this.panelControl3.Controls.Add(this.txtDeducation);
            this.panelControl3.Controls.Add(this.drpIncentiveApp);
            this.panelControl3.Controls.Add(this.drpColor);
            this.panelControl3.Controls.Add(this.labelControl12);
            this.panelControl3.Controls.Add(this.labelControl11);
            this.panelControl3.Controls.Add(this.labelControl10);
            this.panelControl3.Controls.Add(this.txtWeight);
            this.panelControl3.Controls.Add(this.txtQuantity);
            this.panelControl3.Controls.Add(this.txtSize);
            this.panelControl3.Controls.Add(this.labelControl9);
            this.panelControl3.Controls.Add(this.labelControl8);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.txtWages);
            this.panelControl3.Controls.Add(this.txtProductName);
            this.panelControl3.Controls.Add(this.drpProductCode);
            this.panelControl3.Controls.Add(this.drpProductModel);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.ddReceivingDate);
            this.panelControl3.Controls.Add(this.labelControl15);
            this.panelControl3.Controls.Add(this.labelControl26);
            this.panelControl3.Controls.Add(this.txtSubContractor);
            this.panelControl3.Controls.Add(this.labelControl27);
            this.panelControl3.Controls.Add(this.txtClientName);
            this.panelControl3.Controls.Add(this.labelControl28);
            this.panelControl3.Controls.Add(this.txtDirector);
            this.panelControl3.Controls.Add(this.labelControl29);
            this.panelControl3.Controls.Add(this.txtEmpName);
            this.panelControl3.Controls.Add(this.labelControl19);
            this.panelControl3.Controls.Add(this.labelControl20);
            this.panelControl3.Controls.Add(this.labelControl21);
            this.panelControl3.Controls.Add(this.labelControl22);
            this.panelControl3.Controls.Add(this.txtComName);
            this.panelControl3.Controls.Add(this.txtClientCompany);
            this.panelControl3.Controls.Add(this.txtSubClient);
            this.panelControl3.Controls.Add(this.drpEmpCode);
            this.panelControl3.Location = new System.Drawing.Point(6, 20);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1317, 682);
            this.panelControl3.TabIndex = 0;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Appearance.Options.UseForeColor = true;
            this.labelControl23.Location = new System.Drawing.Point(1120, 5);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(10, 19);
            this.labelControl23.TabIndex = 64;
            this.labelControl23.Text = "*";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetDirectJobReceivedWithoutGivingByFilter";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(16, 363);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1288, 292);
            this.gridControl1.TabIndex = 63;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery3.Name = "PRO_GetDirectJobReceivedWithoutGivingByFilter";
            queryParameter3.Name = "@Id";
            queryParameter3.Type = typeof(string);
            storedProcQuery3.Parameters.Add(queryParameter3);
            storedProcQuery3.StoredProcName = "PRO_GetDirectJobReceivedWithoutGivingByFilter";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployeeCode,
            this.colEmployeeName,
            this.colCompanyName,
            this.colDirectorName,
            this.colClientCompany,
            this.colClientName,
            this.colSubClientCompany,
            this.colSubClientName,
            this.colProductModel,
            this.colProductCode,
            this.colProductName,
            this.colProsize,
            this.colWages,
            this.colcolor,
            this.colQuantity,
            this.colWeight,
            this.colIncentiveApplicable,
            this.colBDays,
            this.colADays,
            this.colDeduction,
            this.colTotal,
            this.colConveyance,
            this.Incentive,
            this.colNetAmt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.Caption = "EmployeeCode";
            this.EmployeeCode.FieldName = "EmployeeCode";
            this.EmployeeCode.MinWidth = 80;
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.Visible = true;
            this.EmployeeCode.VisibleIndex = 0;
            this.EmployeeCode.Width = 80;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.MinWidth = 80;
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 1;
            this.colEmployeeName.Width = 80;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.MinWidth = 80;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            this.colCompanyName.Width = 80;
            // 
            // colDirectorName
            // 
            this.colDirectorName.FieldName = "DirectorName";
            this.colDirectorName.MinWidth = 80;
            this.colDirectorName.Name = "colDirectorName";
            this.colDirectorName.Visible = true;
            this.colDirectorName.VisibleIndex = 3;
            this.colDirectorName.Width = 80;
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
            // colClientName
            // 
            this.colClientName.FieldName = "ClientName";
            this.colClientName.MinWidth = 80;
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 5;
            this.colClientName.Width = 80;
            // 
            // colSubClientCompany
            // 
            this.colSubClientCompany.FieldName = "SubClientCompany";
            this.colSubClientCompany.MinWidth = 80;
            this.colSubClientCompany.Name = "colSubClientCompany";
            this.colSubClientCompany.Visible = true;
            this.colSubClientCompany.VisibleIndex = 6;
            this.colSubClientCompany.Width = 80;
            // 
            // colSubClientName
            // 
            this.colSubClientName.FieldName = "SubClientName";
            this.colSubClientName.MinWidth = 80;
            this.colSubClientName.Name = "colSubClientName";
            this.colSubClientName.Visible = true;
            this.colSubClientName.VisibleIndex = 7;
            this.colSubClientName.Width = 80;
            // 
            // colProductModel
            // 
            this.colProductModel.FieldName = "ProductModel";
            this.colProductModel.MinWidth = 80;
            this.colProductModel.Name = "colProductModel";
            this.colProductModel.Visible = true;
            this.colProductModel.VisibleIndex = 8;
            this.colProductModel.Width = 80;
            // 
            // colProductCode
            // 
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.MinWidth = 80;
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 9;
            this.colProductCode.Width = 80;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 80;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 10;
            this.colProductName.Width = 80;
            // 
            // colProsize
            // 
            this.colProsize.FieldName = "Prosize";
            this.colProsize.MinWidth = 80;
            this.colProsize.Name = "colProsize";
            this.colProsize.Visible = true;
            this.colProsize.VisibleIndex = 11;
            this.colProsize.Width = 80;
            // 
            // colWages
            // 
            this.colWages.FieldName = "Wages";
            this.colWages.MinWidth = 80;
            this.colWages.Name = "colWages";
            this.colWages.Visible = true;
            this.colWages.VisibleIndex = 12;
            this.colWages.Width = 80;
            // 
            // colcolor
            // 
            this.colcolor.FieldName = "color";
            this.colcolor.MinWidth = 80;
            this.colcolor.Name = "colcolor";
            this.colcolor.Visible = true;
            this.colcolor.VisibleIndex = 13;
            this.colcolor.Width = 80;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 80;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 14;
            this.colQuantity.Width = 80;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.MinWidth = 80;
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 15;
            this.colWeight.Width = 80;
            // 
            // colIncentiveApplicable
            // 
            this.colIncentiveApplicable.FieldName = "IncentiveApplicable";
            this.colIncentiveApplicable.MinWidth = 80;
            this.colIncentiveApplicable.Name = "colIncentiveApplicable";
            this.colIncentiveApplicable.Visible = true;
            this.colIncentiveApplicable.VisibleIndex = 16;
            this.colIncentiveApplicable.Width = 80;
            // 
            // colBDays
            // 
            this.colBDays.FieldName = "BDays";
            this.colBDays.MinWidth = 80;
            this.colBDays.Name = "colBDays";
            this.colBDays.Visible = true;
            this.colBDays.VisibleIndex = 22;
            this.colBDays.Width = 80;
            // 
            // colADays
            // 
            this.colADays.FieldName = "ADays";
            this.colADays.MinWidth = 80;
            this.colADays.Name = "colADays";
            this.colADays.Visible = true;
            this.colADays.VisibleIndex = 23;
            this.colADays.Width = 80;
            // 
            // colDeduction
            // 
            this.colDeduction.FieldName = "Deduction";
            this.colDeduction.MinWidth = 80;
            this.colDeduction.Name = "colDeduction";
            this.colDeduction.Visible = true;
            this.colDeduction.VisibleIndex = 17;
            this.colDeduction.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 80;
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 18;
            this.colTotal.Width = 80;
            // 
            // colConveyance
            // 
            this.colConveyance.FieldName = "Conveyance";
            this.colConveyance.MinWidth = 80;
            this.colConveyance.Name = "colConveyance";
            this.colConveyance.Visible = true;
            this.colConveyance.VisibleIndex = 19;
            this.colConveyance.Width = 80;
            // 
            // Incentive
            // 
            this.Incentive.FieldName = "Incentive";
            this.Incentive.MinWidth = 80;
            this.Incentive.Name = "Incentive";
            this.Incentive.Visible = true;
            this.Incentive.VisibleIndex = 20;
            this.Incentive.Width = 80;
            // 
            // colNetAmt
            // 
            this.colNetAmt.FieldName = "NetAmt";
            this.colNetAmt.MinWidth = 80;
            this.colNetAmt.Name = "colNetAmt";
            this.colNetAmt.Visible = true;
            this.colNetAmt.VisibleIndex = 21;
            this.colNetAmt.Width = 80;
            // 
            // txtNetAmt
            // 
            this.txtNetAmt.Enabled = false;
            this.txtNetAmt.Location = new System.Drawing.Point(1082, 330);
            this.txtNetAmt.Name = "txtNetAmt";
            this.txtNetAmt.Size = new System.Drawing.Size(140, 20);
            this.txtNetAmt.TabIndex = 62;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(966, 330);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(68, 18);
            this.labelControl18.TabIndex = 61;
            this.labelControl18.Text = "Net Amt";
            // 
            // txtIncentive
            // 
            this.txtIncentive.Location = new System.Drawing.Point(1082, 290);
            this.txtIncentive.Name = "txtIncentive";
            this.txtIncentive.Properties.BeepOnError = false;
            this.txtIncentive.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIncentive.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtIncentive.Properties.MaskSettings.Set("mask", "d");
            this.txtIncentive.Properties.UseMaskAsDisplayFormat = true;
            this.txtIncentive.Size = new System.Drawing.Size(140, 20);
            this.txtIncentive.TabIndex = 60;
            this.txtIncentive.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // txtConveyance
            // 
            this.txtConveyance.Location = new System.Drawing.Point(1082, 254);
            this.txtConveyance.Name = "txtConveyance";
            this.txtConveyance.Properties.BeepOnError = false;
            this.txtConveyance.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtConveyance.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtConveyance.Properties.MaskSettings.Set("mask", "d");
            this.txtConveyance.Properties.UseMaskAsDisplayFormat = true;
            this.txtConveyance.Size = new System.Drawing.Size(140, 20);
            this.txtConveyance.TabIndex = 59;
            this.txtConveyance.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(962, 294);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(76, 18);
            this.labelControl17.TabIndex = 58;
            this.labelControl17.Text = "Incentive";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(962, 253);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(97, 18);
            this.labelControl16.TabIndex = 57;
            this.labelControl16.Text = "Conveyance";
            // 
            // txtAfterDays
            // 
            this.txtAfterDays.Enabled = false;
            this.txtAfterDays.Location = new System.Drawing.Point(1144, 195);
            this.txtAfterDays.Name = "txtAfterDays";
            this.txtAfterDays.Size = new System.Drawing.Size(78, 20);
            this.txtAfterDays.TabIndex = 56;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(1058, 189);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(72, 36);
            this.labelControl14.TabIndex = 55;
            this.labelControl14.Text = "After\r\n   (Days)";
            // 
            // txtBeforeDays
            // 
            this.txtBeforeDays.Enabled = false;
            this.txtBeforeDays.Location = new System.Drawing.Point(962, 193);
            this.txtBeforeDays.Name = "txtBeforeDays";
            this.txtBeforeDays.Size = new System.Drawing.Size(78, 20);
            this.txtBeforeDays.TabIndex = 54;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(884, 189);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(72, 36);
            this.labelControl13.TabIndex = 53;
            this.labelControl13.Text = "Before\r\n   (Days)";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(807, 295);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 20);
            this.txtTotal.TabIndex = 52;
            // 
            // txtDeducation
            // 
            this.txtDeducation.Location = new System.Drawing.Point(807, 253);
            this.txtDeducation.Name = "txtDeducation";
            this.txtDeducation.Properties.BeepOnError = false;
            this.txtDeducation.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDeducation.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtDeducation.Properties.MaskSettings.Set("mask", "d");
            this.txtDeducation.Properties.UseMaskAsDisplayFormat = true;
            this.txtDeducation.Size = new System.Drawing.Size(140, 20);
            this.txtDeducation.TabIndex = 51;
            this.txtDeducation.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // drpIncentiveApp
            // 
            this.drpIncentiveApp.Location = new System.Drawing.Point(807, 195);
            this.drpIncentiveApp.Name = "drpIncentiveApp";
            this.drpIncentiveApp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpIncentiveApp.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.drpIncentiveApp.Size = new System.Drawing.Size(53, 20);
            this.drpIncentiveApp.TabIndex = 50;
            // 
            // drpColor
            // 
            this.drpColor.Location = new System.Drawing.Point(508, 226);
            this.drpColor.Name = "drpColor";
            this.drpColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpColor.Size = new System.Drawing.Size(170, 20);
            this.drpColor.TabIndex = 49;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(697, 292);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(42, 18);
            this.labelControl12.TabIndex = 48;
            this.labelControl12.Text = "Total";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(697, 252);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(82, 18);
            this.labelControl11.TabIndex = 47;
            this.labelControl11.Text = "Deduction";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(697, 190);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(102, 36);
            this.labelControl10.TabIndex = 46;
            this.labelControl10.Text = "Incentive\r\n   Applicable";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(508, 290);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.BeepOnError = false;
            this.txtWeight.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtWeight.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtWeight.Properties.MaskSettings.Set("mask", "d");
            this.txtWeight.Properties.UseMaskAsDisplayFormat = true;
            this.txtWeight.Size = new System.Drawing.Size(170, 20);
            this.txtWeight.TabIndex = 45;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(508, 259);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.BeepOnError = false;
            this.txtQuantity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtQuantity.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtQuantity.Properties.MaskSettings.Set("mask", "d");
            this.txtQuantity.Properties.UseMaskAsDisplayFormat = true;
            this.txtQuantity.Size = new System.Drawing.Size(170, 20);
            this.txtQuantity.TabIndex = 44;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(508, 190);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(170, 20);
            this.txtSize.TabIndex = 42;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(415, 289);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 18);
            this.labelControl9.TabIndex = 41;
            this.labelControl9.Text = "Weight";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(415, 261);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 18);
            this.labelControl8.TabIndex = 40;
            this.labelControl8.Text = "Quantity";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(415, 224);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 18);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "Color";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(415, 192);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 18);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "Size";
            // 
            // txtWages
            // 
            this.txtWages.Enabled = false;
            this.txtWages.Location = new System.Drawing.Point(180, 290);
            this.txtWages.Name = "txtWages";
            this.txtWages.Size = new System.Drawing.Size(206, 20);
            this.txtWages.TabIndex = 37;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(180, 256);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(206, 20);
            this.txtProductName.TabIndex = 36;
            // 
            // drpProductCode
            // 
            this.drpProductCode.Location = new System.Drawing.Point(180, 223);
            this.drpProductCode.Name = "drpProductCode";
            this.drpProductCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProductCode.Size = new System.Drawing.Size(206, 20);
            this.drpProductCode.TabIndex = 35;
            this.drpProductCode.SelectedIndexChanged += new System.EventHandler(this.drpProductCode_SelectedIndexChanged);
            // 
            // drpProductModel
            // 
            this.drpProductModel.Location = new System.Drawing.Point(180, 191);
            this.drpProductModel.Name = "drpProductModel";
            this.drpProductModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProductModel.Size = new System.Drawing.Size(206, 20);
            this.drpProductModel.TabIndex = 34;
            this.drpProductModel.SelectedIndexChanged += new System.EventHandler(this.drpProductModel_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(16, 292);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 18);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Wages";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 253);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 18);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Product Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 225);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 18);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Product Code";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 194);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 18);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Product Model";
            // 
            // ddReceivingDate
            // 
            this.ddReceivingDate.EditValue = null;
            this.ddReceivingDate.Location = new System.Drawing.Point(1168, 7);
            this.ddReceivingDate.Name = "ddReceivingDate";
            this.ddReceivingDate.Properties.BeepOnError = false;
            this.ddReceivingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddReceivingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddReceivingDate.Properties.MaskSettings.Set("mask", "d");
            this.ddReceivingDate.Properties.TodayDate = new System.DateTime(2023, 7, 10, 16, 38, 7, 0);
            this.ddReceivingDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddReceivingDate.Size = new System.Drawing.Size(144, 20);
            this.ddReceivingDate.TabIndex = 29;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(950, 5);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(130, 18);
            this.labelControl15.TabIndex = 28;
            this.labelControl15.Text = "Receiving Date:";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Appearance.Options.UseForeColor = true;
            this.labelControl26.Location = new System.Drawing.Point(555, 38);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(132, 18);
            this.labelControl26.TabIndex = 18;
            this.labelControl26.Text = "Employee Name";
            // 
            // txtSubContractor
            // 
            this.txtSubContractor.Enabled = false;
            this.txtSubContractor.Location = new System.Drawing.Point(719, 118);
            this.txtSubContractor.Name = "txtSubContractor";
            this.txtSubContractor.Size = new System.Drawing.Size(255, 20);
            this.txtSubContractor.TabIndex = 25;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Appearance.Options.UseForeColor = true;
            this.labelControl27.Location = new System.Drawing.Point(555, 67);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(117, 18);
            this.labelControl27.TabIndex = 19;
            this.labelControl27.Text = "Director Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Location = new System.Drawing.Point(719, 92);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(255, 20);
            this.txtClientName.TabIndex = 24;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Appearance.Options.UseForeColor = true;
            this.labelControl28.Location = new System.Drawing.Point(555, 95);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(101, 18);
            this.labelControl28.TabIndex = 20;
            this.labelControl28.Text = "Client Name";
            // 
            // txtDirector
            // 
            this.txtDirector.Enabled = false;
            this.txtDirector.Location = new System.Drawing.Point(719, 66);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(255, 20);
            this.txtDirector.TabIndex = 23;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Appearance.Options.UseForeColor = true;
            this.labelControl29.Location = new System.Drawing.Point(555, 120);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(137, 18);
            this.labelControl29.TabIndex = 21;
            this.labelControl29.Text = "Sub Client Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(719, 37);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(255, 20);
            this.txtEmpName.TabIndex = 22;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(16, 37);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(126, 18);
            this.labelControl19.TabIndex = 10;
            this.labelControl19.Text = "Employee Code";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Appearance.Options.UseForeColor = true;
            this.labelControl20.Location = new System.Drawing.Point(16, 69);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(128, 18);
            this.labelControl20.TabIndex = 11;
            this.labelControl20.Text = "Company Name";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Appearance.Options.UseForeColor = true;
            this.labelControl21.Location = new System.Drawing.Point(16, 95);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(129, 18);
            this.labelControl21.TabIndex = 12;
            this.labelControl21.Text = "Client Company";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Appearance.Options.UseForeColor = true;
            this.labelControl22.Location = new System.Drawing.Point(16, 121);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(165, 18);
            this.labelControl22.TabIndex = 13;
            this.labelControl22.Text = "Sub Client Company";
            // 
            // txtComName
            // 
            this.txtComName.Enabled = false;
            this.txtComName.Location = new System.Drawing.Point(212, 69);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(274, 20);
            this.txtComName.TabIndex = 15;
            // 
            // txtClientCompany
            // 
            this.txtClientCompany.Enabled = false;
            this.txtClientCompany.Location = new System.Drawing.Point(212, 95);
            this.txtClientCompany.Name = "txtClientCompany";
            this.txtClientCompany.Size = new System.Drawing.Size(274, 20);
            this.txtClientCompany.TabIndex = 16;
            // 
            // txtSubClient
            // 
            this.txtSubClient.Enabled = false;
            this.txtSubClient.Location = new System.Drawing.Point(212, 121);
            this.txtSubClient.Name = "txtSubClient";
            this.txtSubClient.Size = new System.Drawing.Size(274, 20);
            this.txtSubClient.TabIndex = 17;
            // 
            // drpEmpCode
            // 
            this.drpEmpCode.Location = new System.Drawing.Point(212, 39);
            this.drpEmpCode.Name = "drpEmpCode";
            this.drpEmpCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpEmpCode.Size = new System.Drawing.Size(274, 20);
            this.drpEmpCode.TabIndex = 14;
            this.drpEmpCode.SelectedIndexChanged += new System.EventHandler(this.drpEmpCode_SelectedIndexChanged);
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl4.Controls.Add(this.panelControl2);
            this.panelControl4.Controls.Add(this.panelControl1);
            this.panelControl4.Location = new System.Drawing.Point(13, 13);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1509, 784);
            this.panelControl4.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(478, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(600, 32);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "DIRECT JOB RECEIVED Without GIVING";
            // 
            // FrmDirectJobReceivedWithoutGivingInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1562, 819);
            this.Controls.Add(this.panelControl4);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmDirectJobReceivedWithoutGivingInfo";
            this.Text = "FrmDirectJobReceivedWithoutGivingInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDirectJobReceivedWithoutGivingInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncentive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConveyance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeducation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpIncentiveApp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceivingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddReceivingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubContractor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.TextEdit txtComName;
        private DevExpress.XtraEditors.TextEdit txtClientCompany;
        private DevExpress.XtraEditors.TextEdit txtSubClient;
        private DevExpress.XtraEditors.ComboBoxEdit drpEmpCode;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit txtSubContractor;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit txtClientName;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.TextEdit txtDirector;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.TextEdit txtEmpName;
        private DevExpress.XtraEditors.DateEdit ddReceivingDate;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit drpProductCode;
        private DevExpress.XtraEditors.ComboBoxEdit drpProductModel;
        private DevExpress.XtraEditors.TextEdit txtWages;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSize;
        private DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit drpColor;
        private DevExpress.XtraEditors.ComboBoxEdit drpIncentiveApp;
        private DevExpress.XtraEditors.TextEdit txtDeducation;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtBeforeDays;
        private DevExpress.XtraEditors.TextEdit txtAfterDays;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtIncentive;
        private DevExpress.XtraEditors.TextEdit txtConveyance;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtNetAmt;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colDirectorName;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductModel;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProsize;
        private DevExpress.XtraGrid.Columns.GridColumn colWages;
        private DevExpress.XtraGrid.Columns.GridColumn colcolor;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colIncentiveApplicable;
        private DevExpress.XtraGrid.Columns.GridColumn colBDays;
        private DevExpress.XtraGrid.Columns.GridColumn colADays;
        private DevExpress.XtraGrid.Columns.GridColumn colDeduction;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colConveyance;
        private DevExpress.XtraGrid.Columns.GridColumn Incentive;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmt;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
    }
}