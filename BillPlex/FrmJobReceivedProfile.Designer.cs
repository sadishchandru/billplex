
namespace BillPlex
{
    partial class FrmJobReceivedProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJobReceivedProfile));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.panelDeliveryChallan = new DevExpress.XtraEditors.PanelControl();
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
            this.cmbFind = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnclr = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDeliveryChallan)).BeginInit();
            this.panelDeliveryChallan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Location = new System.Drawing.Point(12, 3);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1574, 825);
            this.panelControl3.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnEdit);
            this.panelControl2.Controls.Add(this.btnExit);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.btnClear);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnUpdate);
            this.panelControl2.Controls.Add(this.btnNew);
            this.panelControl2.Location = new System.Drawing.Point(1393, 309);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(117, 240);
            this.panelControl2.TabIndex = 32;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(25, 75);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "EDIT";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnExit.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnExit.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btnExit.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btnExit.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.btnExit.AppearanceDisabled.Options.UseBackColor = true;
            this.btnExit.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnExit.AppearanceDisabled.Options.UseForeColor = true;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnExit.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnExit.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.Options.UseBorderColor = true;
            this.btnExit.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnExit.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.btnExit.AppearancePressed.BorderColor = System.Drawing.Color.Aqua;
            this.btnExit.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnExit.AppearancePressed.Options.UseBackColor = true;
            this.btnExit.AppearancePressed.Options.UseBorderColor = true;
            this.btnExit.AppearancePressed.Options.UseForeColor = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Location = new System.Drawing.Point(25, 192);
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btnAdd.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdd.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnAdd.AppearanceDisabled.Options.UseForeColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseBorderColor = true;
            this.btnAdd.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.btnAdd.AppearancePressed.BorderColor = System.Drawing.Color.Aqua;
            this.btnAdd.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.AppearancePressed.Options.UseBackColor = true;
            this.btnAdd.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdd.AppearancePressed.Options.UseForeColor = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(25, 46);
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "ADD";
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnClear.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseBorderColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseForeColor = true;
            this.btnClear.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnClear.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btnClear.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btnClear.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.btnClear.AppearanceDisabled.Options.UseBackColor = true;
            this.btnClear.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnClear.AppearanceDisabled.Options.UseForeColor = true;
            this.btnClear.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnClear.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnClear.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnClear.AppearanceHovered.Options.UseBackColor = true;
            this.btnClear.AppearanceHovered.Options.UseBorderColor = true;
            this.btnClear.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnClear.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.btnClear.AppearancePressed.BorderColor = System.Drawing.Color.Aqua;
            this.btnClear.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnClear.AppearancePressed.Options.UseBackColor = true;
            this.btnClear.AppearancePressed.Options.UseBorderColor = true;
            this.btnClear.AppearancePressed.Options.UseForeColor = true;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(25, 161);
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "CLEAR";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(25, 132);
            this.btnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(25, 103);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(25, 16);
            this.btnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.checkEdit1);
            this.panelControl4.Controls.Add(this.panelDeliveryChallan);
            this.panelControl4.Location = new System.Drawing.Point(42, 70);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1345, 722);
            this.panelControl4.TabIndex = 6;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(1053, 33);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "View DailyReceived";
            this.checkEdit1.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.checkEdit1.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.checkEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.checkEdit1.Size = new System.Drawing.Size(217, 23);
            this.checkEdit1.TabIndex = 87;
            // 
            // panelDeliveryChallan
            // 
            this.panelDeliveryChallan.Controls.Add(this.gridControl1);
            this.panelDeliveryChallan.Controls.Add(this.cmbFind);
            this.panelDeliveryChallan.Controls.Add(this.btnclr);
            this.panelDeliveryChallan.Controls.Add(this.btnFind);
            this.panelDeliveryChallan.Location = new System.Drawing.Point(16, 79);
            this.panelDeliveryChallan.Name = "panelDeliveryChallan";
            this.panelDeliveryChallan.Size = new System.Drawing.Size(1324, 610);
            this.panelDeliveryChallan.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetJobGivingWithoutDC";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(5, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1314, 531);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick_1);
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
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.MinWidth = 80;
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 6;
            this.colOrderNo.Width = 80;
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
            this.colOrderDate.FieldName = "OrderDate";
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
            this.colColor.Width = 208;
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
            // colTotalQty
            // 
            this.colTotalQty.FieldName = "TotalQty";
            this.colTotalQty.MinWidth = 80;
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 22;
            this.colTotalQty.Width = 80;
            // 
            // colTotalWt
            // 
            this.colTotalWt.FieldName = "TotalWt";
            this.colTotalWt.MinWidth = 80;
            this.colTotalWt.Name = "colTotalWt";
            this.colTotalWt.Visible = true;
            this.colTotalWt.VisibleIndex = 23;
            this.colTotalWt.Width = 80;
            // 
            // colShortage
            // 
            this.colShortage.FieldName = "Shortage";
            this.colShortage.MinWidth = 80;
            this.colShortage.Name = "colShortage";
            this.colShortage.Visible = true;
            this.colShortage.VisibleIndex = 24;
            this.colShortage.Width = 80;
            // 
            // colorderQty
            // 
            this.colorderQty.FieldName = "orderQty";
            this.colorderQty.MinWidth = 80;
            this.colorderQty.Name = "colorderQty";
            this.colorderQty.Visible = true;
            this.colorderQty.VisibleIndex = 25;
            this.colorderQty.Width = 80;
            // 
            // colorderWt
            // 
            this.colorderWt.FieldName = "orderWt";
            this.colorderWt.MinWidth = 80;
            this.colorderWt.Name = "colorderWt";
            this.colorderWt.Visible = true;
            this.colorderWt.VisibleIndex = 26;
            this.colorderWt.Width = 80;
            // 
            // cmbFind
            // 
            this.cmbFind.Location = new System.Drawing.Point(21, 22);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFind.Size = new System.Drawing.Size(433, 20);
            this.cmbFind.TabIndex = 2;
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(562, 25);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 23);
            this.btnclr.TabIndex = 2;
            this.btnclr.Text = "Clear";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(481, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(42, 14);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1345, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(486, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Job Received ";
            // 
            // FrmJobReceivedProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 866);
            this.Controls.Add(this.panelControl3);
            this.Name = "FrmJobReceivedProfile";
            this.Text = "FrmJobReceivedProfile";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDeliveryChallan)).EndInit();
            this.panelDeliveryChallan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.PanelControl panelDeliveryChallan;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbFind;
        private DevExpress.XtraEditors.SimpleButton btnclr;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
    }
}