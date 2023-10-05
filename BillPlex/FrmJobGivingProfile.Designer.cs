
namespace BillPlex
{
    partial class FrmJobGivingProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJobGivingProfile));
            this.gridSplitContainer1Grid = new DevExpress.XtraGrid.GridControl();
            this.gridSplitContainer1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl13 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl15 = new DevExpress.XtraEditors.PanelControl();
            this.btnClr = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl16 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubContractor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvlQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderWt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl13)).BeginInit();
            this.panelControl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl15)).BeginInit();
            this.panelControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl16)).BeginInit();
            this.panelControl16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSplitContainer1Grid
            // 
            this.gridSplitContainer1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1Grid.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1Grid.MainView = this.gridSplitContainer1View;
            this.gridSplitContainer1Grid.Name = "gridSplitContainer1Grid";
            this.gridSplitContainer1Grid.Size = new System.Drawing.Size(747, 237);
            this.gridSplitContainer1Grid.TabIndex = 0;
            this.gridSplitContainer1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSplitContainer1View});
            // 
            // gridSplitContainer1View
            // 
            this.gridSplitContainer1View.GridControl = this.gridSplitContainer1Grid;
            this.gridSplitContainer1View.Name = "gridSplitContainer1View";
            // 
            // panelControl13
            // 
            this.panelControl13.Controls.Add(this.labelControl16);
            this.panelControl13.Controls.Add(this.panelControl15);
            this.panelControl13.Controls.Add(this.panelControl16);
            this.panelControl13.Location = new System.Drawing.Point(12, 2);
            this.panelControl13.Name = "panelControl13";
            this.panelControl13.Size = new System.Drawing.Size(1634, 824);
            this.panelControl13.TabIndex = 6;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(665, 4);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(148, 29);
            this.labelControl16.TabIndex = 66;
            this.labelControl16.Text = "JOB GIVING";
            // 
            // panelControl15
            // 
            this.panelControl15.Controls.Add(this.btnClr);
            this.panelControl15.Controls.Add(this.btnDelete);
            this.panelControl15.Controls.Add(this.btnUpdate);
            this.panelControl15.Controls.Add(this.btnEdit);
            this.panelControl15.Controls.Add(this.btnAdd);
            this.panelControl15.Controls.Add(this.btnExit);
            this.panelControl15.Controls.Add(this.btnNew);
            this.panelControl15.Location = new System.Drawing.Point(1470, 208);
            this.panelControl15.Name = "panelControl15";
            this.panelControl15.Size = new System.Drawing.Size(91, 307);
            this.panelControl15.TabIndex = 63;
            // 
            // btnClr
            // 
            this.btnClr.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Appearance.Options.UseFont = true;
            this.btnClr.Location = new System.Drawing.Point(5, 219);
            this.btnClr.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnClr.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnClr.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClr.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(81, 23);
            this.btnClr.TabIndex = 64;
            this.btnClr.Text = "CLEAR";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(5, 172);
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
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(5, 131);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "UPDATE";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(5, 93);
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
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(5, 48);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "ADD";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(5, 269);
            this.btnExit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnExit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 23);
            this.btnExit.TabIndex = 59;
            this.btnExit.Text = "EXIT";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 23);
            this.btnNew.TabIndex = 53;
            this.btnNew.Text = "NEW";
            // 
            // panelControl16
            // 
            this.panelControl16.Controls.Add(this.gridControl2);
            this.panelControl16.Controls.Add(this.radioGroup2);
            this.panelControl16.Location = new System.Drawing.Point(15, 38);
            this.panelControl16.Name = "panelControl16";
            this.panelControl16.Size = new System.Drawing.Size(1449, 768);
            this.panelControl16.TabIndex = 2;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "PRO_GetJobGivingWithoutDCList";
            this.gridControl2.DataSource = this.sqlDataSource1;
            this.gridControl2.Location = new System.Drawing.Point(14, 40);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1430, 710);
            this.gridControl2.TabIndex = 66;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetJobGivingWithoutDCList";
            storedProcQuery1.StoredProcName = "PRO_GetJobGivingWithoutDCList";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderNo,
            this.colId,
            this.colEmployeeCode,
            this.colEmployeeName,
            this.colCompanyName,
            this.colDirector,
            this.colClientCompany,
            this.colClientName,
            this.colSubClientCompany,
            this.colsubContractor,
            this.colDate,
            this.colOrderDate,
            this.colCustomerCode,
            this.colCustomerName,
            this.colModelName,
            this.colModelCode,
            this.colProductName,
            this.colProductSize,
            this.colColor,
            this.colRawMaterial,
            this.colType,
            this.colQuantityPiece,
            this.colWeightKg,
            this.colAvlQty,
            this.colExcess,
            this.colTotalQty,
            this.colTotalWt,
            this.colShortage,
            this.colorderQty,
            this.colorderWt});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            // 
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 0;
            this.colOrderNo.Width = 37;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 20;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 2;
            this.colEmployeeCode.Width = 47;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 3;
            this.colEmployeeName.Width = 47;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 4;
            this.colCompanyName.Width = 47;
            // 
            // colDirector
            // 
            this.colDirector.FieldName = "Director";
            this.colDirector.Name = "colDirector";
            this.colDirector.Visible = true;
            this.colDirector.VisibleIndex = 5;
            this.colDirector.Width = 30;
            // 
            // colClientCompany
            // 
            this.colClientCompany.FieldName = "ClientCompany";
            this.colClientCompany.Name = "colClientCompany";
            this.colClientCompany.Visible = true;
            this.colClientCompany.VisibleIndex = 6;
            this.colClientCompany.Width = 47;
            // 
            // colClientName
            // 
            this.colClientName.FieldName = "ClientName";
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 7;
            this.colClientName.Width = 37;
            // 
            // colSubClientCompany
            // 
            this.colSubClientCompany.FieldName = "SubClientCompany";
            this.colSubClientCompany.Name = "colSubClientCompany";
            this.colSubClientCompany.Visible = true;
            this.colSubClientCompany.VisibleIndex = 8;
            this.colSubClientCompany.Width = 61;
            // 
            // colsubContractor
            // 
            this.colsubContractor.FieldName = "subContractor";
            this.colsubContractor.Name = "colsubContractor";
            this.colsubContractor.Visible = true;
            this.colsubContractor.VisibleIndex = 9;
            this.colsubContractor.Width = 46;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 10;
            this.colDate.Width = 20;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 11;
            this.colOrderDate.Width = 37;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 12;
            this.colCustomerCode.Width = 47;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 13;
            this.colCustomerName.Width = 44;
            // 
            // colModelName
            // 
            this.colModelName.FieldName = "ModelName";
            this.colModelName.Name = "colModelName";
            this.colModelName.Visible = true;
            this.colModelName.VisibleIndex = 14;
            this.colModelName.Width = 38;
            // 
            // colModelCode
            // 
            this.colModelCode.FieldName = "ModelCode";
            this.colModelCode.Name = "colModelCode";
            this.colModelCode.Visible = true;
            this.colModelCode.VisibleIndex = 15;
            this.colModelCode.Width = 41;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 16;
            this.colProductName.Width = 47;
            // 
            // colProductSize
            // 
            this.colProductSize.FieldName = "ProductSize";
            this.colProductSize.Name = "colProductSize";
            this.colProductSize.Visible = true;
            this.colProductSize.VisibleIndex = 17;
            this.colProductSize.Width = 49;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 18;
            this.colColor.Width = 33;
            // 
            // colRawMaterial
            // 
            this.colRawMaterial.FieldName = "RawMaterial";
            this.colRawMaterial.Name = "colRawMaterial";
            this.colRawMaterial.Visible = true;
            this.colRawMaterial.VisibleIndex = 19;
            this.colRawMaterial.Width = 85;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 20;
            this.colType.Width = 31;
            // 
            // colQuantityPiece
            // 
            this.colQuantityPiece.FieldName = "QuantityPiece";
            this.colQuantityPiece.Name = "colQuantityPiece";
            this.colQuantityPiece.Visible = true;
            this.colQuantityPiece.VisibleIndex = 21;
            this.colQuantityPiece.Width = 66;
            // 
            // colWeightKg
            // 
            this.colWeightKg.FieldName = "WeightKg";
            this.colWeightKg.Name = "colWeightKg";
            this.colWeightKg.Visible = true;
            this.colWeightKg.VisibleIndex = 22;
            this.colWeightKg.Width = 52;
            // 
            // colAvlQty
            // 
            this.colAvlQty.FieldName = "AvlQty";
            this.colAvlQty.Name = "colAvlQty";
            this.colAvlQty.Visible = true;
            this.colAvlQty.VisibleIndex = 23;
            this.colAvlQty.Width = 43;
            // 
            // colExcess
            // 
            this.colExcess.FieldName = "Excess";
            this.colExcess.Name = "colExcess";
            this.colExcess.Visible = true;
            this.colExcess.VisibleIndex = 24;
            this.colExcess.Width = 43;
            // 
            // colTotalQty
            // 
            this.colTotalQty.FieldName = "TotalQty";
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 25;
            this.colTotalQty.Width = 55;
            // 
            // colTotalWt
            // 
            this.colTotalWt.FieldName = "TotalWt";
            this.colTotalWt.Name = "colTotalWt";
            this.colTotalWt.Visible = true;
            this.colTotalWt.VisibleIndex = 26;
            this.colTotalWt.Width = 53;
            // 
            // colShortage
            // 
            this.colShortage.FieldName = "Shortage";
            this.colShortage.Name = "colShortage";
            this.colShortage.Visible = true;
            this.colShortage.VisibleIndex = 27;
            this.colShortage.Width = 58;
            // 
            // colorderQty
            // 
            this.colorderQty.FieldName = "orderQty";
            this.colorderQty.Name = "colorderQty";
            this.colorderQty.Visible = true;
            this.colorderQty.VisibleIndex = 28;
            this.colorderQty.Width = 62;
            // 
            // colorderWt
            // 
            this.colorderWt.FieldName = "orderWt";
            this.colorderWt.Name = "colorderWt";
            this.colorderWt.Visible = true;
            this.colorderWt.VisibleIndex = 29;
            this.colorderWt.Width = 82;
            // 
            // radioGroup2
            // 
            this.radioGroup2.Location = new System.Drawing.Point(865, 4);
            this.radioGroup2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.radioGroup2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.radioGroup2.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup2.Properties.Appearance.Options.UseFont = true;
            this.radioGroup2.Properties.Appearance.Options.UseForeColor = true;
            this.radioGroup2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup2.Properties.ColumnIndent = 5;
            this.radioGroup2.Properties.Columns = 4;
            this.radioGroup2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "InComplete", true, ((short)(1)), "InComplete"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Pending", true, ((short)(1)), "Pending"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Complete", true, ((short)(1)), "complete"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All", true, ((short)(1)), "all")});
            this.radioGroup2.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioGroup2.Size = new System.Drawing.Size(493, 37);
            this.radioGroup2.TabIndex = 65;
            // 
            // FrmJobGivingProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1618, 905);
            this.Controls.Add(this.panelControl13);
            this.Name = "FrmJobGivingProfile";
            this.Text = "FrmJobGivingProfile";
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl13)).EndInit();
            this.panelControl13.ResumeLayout(false);
            this.panelControl13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl15)).EndInit();
            this.panelControl15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl16)).EndInit();
            this.panelControl16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridSplitContainer1Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSplitContainer1View;
        private DevExpress.XtraEditors.PanelControl panelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.PanelControl panelControl15;
        private DevExpress.XtraEditors.SimpleButton btnClr;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl panelControl16;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colDirector;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colsubContractor;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colModelName;
        private DevExpress.XtraGrid.Columns.GridColumn colModelCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSize;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPiece;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightKg;
        private DevExpress.XtraGrid.Columns.GridColumn colAvlQty;
        private DevExpress.XtraGrid.Columns.GridColumn colExcess;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWt;
        private DevExpress.XtraGrid.Columns.GridColumn colShortage;
        private DevExpress.XtraGrid.Columns.GridColumn colorderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colorderWt;
    }
}