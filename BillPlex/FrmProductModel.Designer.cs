
namespace BillPlex
{
    partial class FrmProductModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductModel));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.grd_ProductModel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawmaterialTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterialStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqRawMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWagesforItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.ddDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnDot2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtWages = new DevExpress.XtraEditors.TextEdit();
            this.txtRawWeight = new DevExpress.XtraEditors.TextEdit();
            this.txtRawStock = new DevExpress.XtraEditors.TextEdit();
            this.drpProSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnDot1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDot = new DevExpress.XtraEditors.SimpleButton();
            this.txtModelName = new DevExpress.XtraEditors.TextEdit();
            this.txtModelCode = new DevExpress.XtraEditors.TextEdit();
            this.drpProName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpRawName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpRawType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProductModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpRawName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpRawType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1594, 77);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(758, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(196, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Product Model";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.txtSearchModel);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.ddDate);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.btnDot2);
            this.panelControl2.Controls.Add(this.txtWages);
            this.panelControl2.Controls.Add(this.txtRawWeight);
            this.panelControl2.Controls.Add(this.txtRawStock);
            this.panelControl2.Controls.Add(this.drpProSize);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.btnDot1);
            this.panelControl2.Controls.Add(this.btnDot);
            this.panelControl2.Controls.Add(this.txtModelName);
            this.panelControl2.Controls.Add(this.txtModelCode);
            this.panelControl2.Controls.Add(this.drpProName);
            this.panelControl2.Controls.Add(this.drpRawName);
            this.panelControl2.Controls.Add(this.drpRawType);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(12, 96);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1594, 780);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetProductModel";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(29, 377);
            this.gridControl1.MainView = this.grd_ProductModel;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1550, 376);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ProductModel});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetProductModel";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetProductModel";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // grd_ProductModel
            // 
            this.grd_ProductModel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colRawmaterialTypeId,
            this.colRawMaterialId,
            this.colProductId,
            this.colProductCode,
            this.colProductModel,
            this.colProductSize,
            this.colRawMaterialStock,
            this.colReqRawMaterial,
            this.colWagesforItem,
            this.colDate});
            this.grd_ProductModel.GridControl = this.gridControl1;
            this.grd_ProductModel.Name = "grd_ProductModel";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 21;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colRawmaterialTypeId
            // 
            this.colRawmaterialTypeId.FieldName = "RawmaterialTypeId";
            this.colRawmaterialTypeId.MinWidth = 21;
            this.colRawmaterialTypeId.Name = "colRawmaterialTypeId";
            this.colRawmaterialTypeId.Visible = true;
            this.colRawmaterialTypeId.VisibleIndex = 1;
            // 
            // colRawMaterialId
            // 
            this.colRawMaterialId.FieldName = "RawMaterialId";
            this.colRawMaterialId.MinWidth = 21;
            this.colRawMaterialId.Name = "colRawMaterialId";
            this.colRawMaterialId.Visible = true;
            this.colRawMaterialId.VisibleIndex = 2;
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.MinWidth = 21;
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 3;
            // 
            // colProductCode
            // 
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.MinWidth = 21;
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 4;
            // 
            // colProductModel
            // 
            this.colProductModel.FieldName = "ProductModel";
            this.colProductModel.MinWidth = 21;
            this.colProductModel.Name = "colProductModel";
            this.colProductModel.Visible = true;
            this.colProductModel.VisibleIndex = 5;
            // 
            // colProductSize
            // 
            this.colProductSize.FieldName = "ProductSize";
            this.colProductSize.MinWidth = 21;
            this.colProductSize.Name = "colProductSize";
            this.colProductSize.Visible = true;
            this.colProductSize.VisibleIndex = 6;
            // 
            // colRawMaterialStock
            // 
            this.colRawMaterialStock.FieldName = "RawMaterialStock";
            this.colRawMaterialStock.MinWidth = 21;
            this.colRawMaterialStock.Name = "colRawMaterialStock";
            this.colRawMaterialStock.Visible = true;
            this.colRawMaterialStock.VisibleIndex = 7;
            // 
            // colReqRawMaterial
            // 
            this.colReqRawMaterial.FieldName = "ReqRawMaterial";
            this.colReqRawMaterial.MinWidth = 21;
            this.colReqRawMaterial.Name = "colReqRawMaterial";
            this.colReqRawMaterial.Visible = true;
            this.colReqRawMaterial.VisibleIndex = 8;
            // 
            // colWagesforItem
            // 
            this.colWagesforItem.FieldName = "WagesforItem";
            this.colWagesforItem.MinWidth = 21;
            this.colWagesforItem.Name = "colWagesforItem";
            this.colWagesforItem.Visible = true;
            this.colWagesforItem.VisibleIndex = 9;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 21;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 10;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.btnClear);
            this.panelControl3.Controls.Add(this.btnAdd);
            this.panelControl3.Controls.Add(this.btnEdit);
            this.panelControl3.Controls.Add(this.btnUpdate);
            this.panelControl3.Controls.Add(this.btnDelete);
            this.panelControl3.Location = new System.Drawing.Point(698, 191);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(405, 46);
            this.panelControl3.TabIndex = 31;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(324, 14);
            this.btnClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 19);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 14);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 19);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(94, 14);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 19);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(172, 14);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 19);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 14);
            this.btnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 19);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearchModel
            // 
            this.txtSearchModel.Location = new System.Drawing.Point(244, 281);
            this.txtSearchModel.Name = "txtSearchModel";
            this.txtSearchModel.Size = new System.Drawing.Size(377, 20);
            this.txtSearchModel.TabIndex = 30;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(63, 284);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(187, 21);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "Search Product Model";
            // 
            // ddDate
            // 
            this.ddDate.EditValue = null;
            this.ddDate.Location = new System.Drawing.Point(966, 6);
            this.ddDate.Name = "ddDate";
            this.ddDate.Properties.BeepOnError = false;
            this.ddDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddDate.Properties.MaskSettings.Set("mask", "d");
            this.ddDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddDate.Size = new System.Drawing.Size(111, 20);
            this.ddDate.TabIndex = 23;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(925, 5);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(40, 21);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Date";
            // 
            // btnDot2
            // 
            this.btnDot2.Location = new System.Drawing.Point(1054, 37);
            this.btnDot2.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDot2.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDot2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDot2.Name = "btnDot2";
            this.btnDot2.Size = new System.Drawing.Size(23, 19);
            this.btnDot2.TabIndex = 21;
            this.btnDot2.Text = "...";
            // 
            // txtWages
            // 
            this.txtWages.Location = new System.Drawing.Point(824, 155);
            this.txtWages.Name = "txtWages";
            this.txtWages.Size = new System.Drawing.Size(224, 20);
            this.txtWages.TabIndex = 20;
            // 
            // txtRawWeight
            // 
            this.txtRawWeight.Location = new System.Drawing.Point(824, 117);
            this.txtRawWeight.Name = "txtRawWeight";
            this.txtRawWeight.Size = new System.Drawing.Size(224, 20);
            this.txtRawWeight.TabIndex = 19;
            // 
            // txtRawStock
            // 
            this.txtRawStock.Location = new System.Drawing.Point(824, 77);
            this.txtRawStock.Name = "txtRawStock";
            this.txtRawStock.Size = new System.Drawing.Size(224, 20);
            this.txtRawStock.TabIndex = 18;
            // 
            // drpProSize
            // 
            this.drpProSize.Location = new System.Drawing.Point(824, 35);
            this.drpProSize.Name = "drpProSize";
            this.drpProSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProSize.Size = new System.Drawing.Size(224, 20);
            this.drpProSize.TabIndex = 17;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(487, 153);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(253, 21);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Wages for one product Model";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(487, 113);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(320, 21);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Required Raw Material Weight/Iteam";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(487, 80);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(165, 21);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Raw Material Stock";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(487, 39);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(107, 21);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Product Size";
            // 
            // btnDot1
            // 
            this.btnDot1.Location = new System.Drawing.Point(426, 117);
            this.btnDot1.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDot1.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDot1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDot1.Name = "btnDot1";
            this.btnDot1.Size = new System.Drawing.Size(23, 19);
            this.btnDot1.TabIndex = 12;
            this.btnDot1.Text = "...";
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(426, 39);
            this.btnDot.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDot.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDot.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(23, 19);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = "...";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(196, 188);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(224, 20);
            this.txtModelName.TabIndex = 10;
            // 
            // txtModelCode
            // 
            this.txtModelCode.Location = new System.Drawing.Point(196, 154);
            this.txtModelCode.Name = "txtModelCode";
            this.txtModelCode.Size = new System.Drawing.Size(224, 20);
            this.txtModelCode.TabIndex = 9;
            // 
            // drpProName
            // 
            this.drpProName.Location = new System.Drawing.Point(196, 114);
            this.drpProName.Name = "drpProName";
            this.drpProName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProName.Size = new System.Drawing.Size(224, 20);
            this.drpProName.TabIndex = 8;
            // 
            // drpRawName
            // 
            this.drpRawName.Location = new System.Drawing.Point(196, 77);
            this.drpRawName.Name = "drpRawName";
            this.drpRawName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpRawName.Size = new System.Drawing.Size(224, 20);
            this.drpRawName.TabIndex = 7;
            // 
            // drpRawType
            // 
            this.drpRawType.Location = new System.Drawing.Point(196, 39);
            this.drpRawType.Name = "drpRawType";
            this.drpRawType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpRawType.Size = new System.Drawing.Size(224, 20);
            this.drpRawType.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(29, 187);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(106, 21);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Model Name";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 154);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(100, 21);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Model Code";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(29, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Product Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(165, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Raw Material Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(157, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Raw Material Type";
            // 
            // FrmProductModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 863);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmProductModel";
            this.Text = "FrmProductModel";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProductModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpRawName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpRawType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit drpRawType;
        private DevExpress.XtraEditors.ComboBoxEdit drpProName;
        private DevExpress.XtraEditors.ComboBoxEdit drpRawName;
        private DevExpress.XtraEditors.TextEdit txtModelCode;
        private DevExpress.XtraEditors.TextEdit txtModelName;
        private DevExpress.XtraEditors.SimpleButton btnDot1;
        private DevExpress.XtraEditors.SimpleButton btnDot;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit drpProSize;
        private DevExpress.XtraEditors.TextEdit txtWages;
        private DevExpress.XtraEditors.TextEdit txtRawWeight;
        private DevExpress.XtraEditors.TextEdit txtRawStock;
        private DevExpress.XtraEditors.SimpleButton btnDot2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit ddDate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtSearchModel;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ProductModel;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRawmaterialTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductModel;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSize;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterialStock;
        private DevExpress.XtraGrid.Columns.GridColumn colReqRawMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colWagesforItem;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
    }
}