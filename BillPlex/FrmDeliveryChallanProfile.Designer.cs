
namespace BillPlex
{
    partial class FrmDeliveryChallanProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryChallanProfile));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbFind = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelDeliveryChallan = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnclr = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyMasterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubclientCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubcontractor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColourName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvlQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDeliveryChallan)).BeginInit();
            this.panelDeliveryChallan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(42, 14);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1244, 50);
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
            this.labelControl1.Size = new System.Drawing.Size(257, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Delivery challan";
            // 
            // cmbFind
            // 
            this.cmbFind.Location = new System.Drawing.Point(37, 34);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFind.Size = new System.Drawing.Size(433, 20);
            this.cmbFind.TabIndex = 2;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.panelDeliveryChallan);
            this.panelControl4.Location = new System.Drawing.Point(42, 70);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1153, 699);
            this.panelControl4.TabIndex = 6;
            // 
            // panelDeliveryChallan
            // 
            this.panelDeliveryChallan.Controls.Add(this.gridControl1);
            this.panelDeliveryChallan.Controls.Add(this.cmbFind);
            this.panelDeliveryChallan.Controls.Add(this.btnclr);
            this.panelDeliveryChallan.Controls.Add(this.btnFind);
            this.panelDeliveryChallan.Location = new System.Drawing.Point(5, 20);
            this.panelDeliveryChallan.Name = "panelDeliveryChallan";
            this.panelDeliveryChallan.Size = new System.Drawing.Size(1123, 660);
            this.panelDeliveryChallan.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetDeliveryChallanInfo";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(37, 116);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1069, 539);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCompanyMasterId,
            this.colDirector,
            this.colClientCompanyId,
            this.colContractor,
            this.colSubclientCompanyId,
            this.colSubcontractor,
            this.colCustomerCode,
            this.colCustomerName,
            this.colOrderNo,
            this.colModelCode,
            this.colModelName,
            this.colProductName,
            this.colRawMaterial,
            this.colRawType,
            this.colProductSize,
            this.colOrderDate,
            this.colColourName,
            this.colQuantity,
            this.colWeight,
            this.colExcess,
            this.colAvlQty,
            this.colShortage,
            this.colDcNo,
            this.colDcDate,
            this.colOrderQty,
            this.colOrderWeight});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(574, 31);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 23);
            this.btnclr.TabIndex = 2;
            this.btnclr.Text = "Clear";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(477, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1384, 774);
            this.panelControl3.TabIndex = 1;
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
            this.panelControl2.Location = new System.Drawing.Point(1233, 251);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(117, 240);
            this.panelControl2.TabIndex = 32;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(25, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(25, 103);
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
            this.btnNew.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnNew.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetDeliveryChallanInfo";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetDeliveryChallanInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colCompanyMasterId
            // 
            this.colCompanyMasterId.FieldName = "CompanyMasterId";
            this.colCompanyMasterId.Name = "colCompanyMasterId";
            this.colCompanyMasterId.Visible = true;
            this.colCompanyMasterId.VisibleIndex = 1;
            // 
            // colDirector
            // 
            this.colDirector.FieldName = "Director";
            this.colDirector.Name = "colDirector";
            this.colDirector.Visible = true;
            this.colDirector.VisibleIndex = 2;
            // 
            // colClientCompanyId
            // 
            this.colClientCompanyId.FieldName = "ClientCompanyId";
            this.colClientCompanyId.Name = "colClientCompanyId";
            this.colClientCompanyId.Visible = true;
            this.colClientCompanyId.VisibleIndex = 3;
            // 
            // colContractor
            // 
            this.colContractor.FieldName = "Contractor";
            this.colContractor.Name = "colContractor";
            this.colContractor.Visible = true;
            this.colContractor.VisibleIndex = 4;
            // 
            // colSubclientCompanyId
            // 
            this.colSubclientCompanyId.FieldName = "SubclientCompanyId";
            this.colSubclientCompanyId.Name = "colSubclientCompanyId";
            this.colSubclientCompanyId.Visible = true;
            this.colSubclientCompanyId.VisibleIndex = 5;
            // 
            // colSubcontractor
            // 
            this.colSubcontractor.FieldName = "Subcontractor";
            this.colSubcontractor.Name = "colSubcontractor";
            this.colSubcontractor.Visible = true;
            this.colSubcontractor.VisibleIndex = 6;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 7;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 8;
            // 
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 9;
            // 
            // colModelCode
            // 
            this.colModelCode.FieldName = "ModelCode";
            this.colModelCode.Name = "colModelCode";
            this.colModelCode.Visible = true;
            this.colModelCode.VisibleIndex = 10;
            // 
            // colModelName
            // 
            this.colModelName.FieldName = "ModelName";
            this.colModelName.Name = "colModelName";
            this.colModelName.Visible = true;
            this.colModelName.VisibleIndex = 11;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 12;
            // 
            // colRawMaterial
            // 
            this.colRawMaterial.FieldName = "RawMaterial";
            this.colRawMaterial.Name = "colRawMaterial";
            this.colRawMaterial.Visible = true;
            this.colRawMaterial.VisibleIndex = 13;
            // 
            // colRawType
            // 
            this.colRawType.FieldName = "RawType";
            this.colRawType.Name = "colRawType";
            this.colRawType.Visible = true;
            this.colRawType.VisibleIndex = 14;
            // 
            // colProductSize
            // 
            this.colProductSize.FieldName = "ProductSize";
            this.colProductSize.Name = "colProductSize";
            this.colProductSize.Visible = true;
            this.colProductSize.VisibleIndex = 15;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 16;
            // 
            // colColourName
            // 
            this.colColourName.FieldName = "ColourName";
            this.colColourName.Name = "colColourName";
            this.colColourName.Visible = true;
            this.colColourName.VisibleIndex = 17;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 18;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 19;
            // 
            // colExcess
            // 
            this.colExcess.FieldName = "Excess";
            this.colExcess.Name = "colExcess";
            this.colExcess.Visible = true;
            this.colExcess.VisibleIndex = 20;
            // 
            // colAvlQty
            // 
            this.colAvlQty.FieldName = "AvlQty";
            this.colAvlQty.Name = "colAvlQty";
            this.colAvlQty.Visible = true;
            this.colAvlQty.VisibleIndex = 21;
            // 
            // colShortage
            // 
            this.colShortage.FieldName = "Shortage";
            this.colShortage.Name = "colShortage";
            this.colShortage.Visible = true;
            this.colShortage.VisibleIndex = 22;
            // 
            // colDcNo
            // 
            this.colDcNo.FieldName = "DcNo";
            this.colDcNo.Name = "colDcNo";
            this.colDcNo.Visible = true;
            this.colDcNo.VisibleIndex = 23;
            // 
            // colDcDate
            // 
            this.colDcDate.FieldName = "DcDate";
            this.colDcDate.Name = "colDcDate";
            this.colDcDate.Visible = true;
            this.colDcDate.VisibleIndex = 24;
            // 
            // colOrderQty
            // 
            this.colOrderQty.FieldName = "OrderQty";
            this.colOrderQty.Name = "colOrderQty";
            this.colOrderQty.Visible = true;
            this.colOrderQty.VisibleIndex = 25;
            // 
            // colOrderWeight
            // 
            this.colOrderWeight.FieldName = "OrderWeight";
            this.colOrderWeight.Name = "colOrderWeight";
            this.colOrderWeight.Visible = true;
            this.colOrderWeight.VisibleIndex = 26;
            // 
            // FrmDeliveryChallanProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 814);
            this.Controls.Add(this.panelControl3);
            this.Name = "FrmDeliveryChallanProfile";
            this.Text = "FrmDeliveryChallanProfile";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDeliveryChallan)).EndInit();
            this.panelDeliveryChallan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbFind;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelDeliveryChallan;
        private DevExpress.XtraEditors.SimpleButton btnclr;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyMasterId;
        private DevExpress.XtraGrid.Columns.GridColumn colDirector;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colContractor;
        private DevExpress.XtraGrid.Columns.GridColumn colSubclientCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubcontractor;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colModelCode;
        private DevExpress.XtraGrid.Columns.GridColumn colModelName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colRawType;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSize;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colColourName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colExcess;
        private DevExpress.XtraGrid.Columns.GridColumn colAvlQty;
        private DevExpress.XtraGrid.Columns.GridColumn colShortage;
        private DevExpress.XtraGrid.Columns.GridColumn colDcNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDcDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderWeight;
    }
}