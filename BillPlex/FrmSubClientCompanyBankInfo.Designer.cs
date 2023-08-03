﻿
namespace BillPlex
{
    partial class FrmSubClientCompanyBankInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubClientCompanyBankInfo));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.drpBankName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpClientCompany = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpSubCompany = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.SubClientBankGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComCname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubComName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIFSCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SearchComapnyNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.imgImage = new DevExpress.XtraEditors.PictureEdit();
            this.btn = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TxtIfsCode = new DevExpress.XtraEditors.TextEdit();
            this.TxtBranchName = new DevExpress.XtraEditors.TextEdit();
            this.TxtBranchCode = new DevExpress.XtraEditors.TextEdit();
            this.TxtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.TxtBankAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpClientCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpSubCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubClientBankGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchComapnyNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIfsCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBranchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBranchCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl17);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.labelControl15);
            this.panelControl1.Controls.Add(this.btnUpdate);
            this.panelControl1.Controls.Add(this.drpBankName);
            this.panelControl1.Controls.Add(this.drpClientCompany);
            this.panelControl1.Controls.Add(this.drpSubCompany);
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.SearchComapnyNameTxt);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.imgImage);
            this.panelControl1.Controls.Add(this.btn);
            this.panelControl1.Controls.Add(this.btnClear);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.TxtIfsCode);
            this.panelControl1.Controls.Add(this.TxtBranchName);
            this.panelControl1.Controls.Add(this.TxtBranchCode);
            this.panelControl1.Controls.Add(this.TxtAddress);
            this.panelControl1.Controls.Add(this.TxtBankAccountNo);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.LookAndFeel.SkinName = "DevExpress Style";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1576, 808);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(150, 163);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(10, 19);
            this.labelControl17.TabIndex = 44;
            this.labelControl17.Text = "*";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(150, 280);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(10, 19);
            this.labelControl16.TabIndex = 42;
            this.labelControl16.Text = "*";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(150, 374);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(10, 19);
            this.labelControl14.TabIndex = 41;
            this.labelControl14.Text = "*";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(192, 105);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(10, 19);
            this.labelControl13.TabIndex = 40;
            this.labelControl13.Text = "*";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(150, 134);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(10, 19);
            this.labelControl12.TabIndex = 39;
            this.labelControl12.Text = "*";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(150, 196);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(10, 19);
            this.labelControl11.TabIndex = 38;
            this.labelControl11.Text = "*";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(192, 63);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(10, 19);
            this.labelControl15.TabIndex = 37;
            this.labelControl15.Text = "*";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(548, 142);
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 73);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // drpBankName
            // 
            this.drpBankName.Location = new System.Drawing.Point(238, 132);
            this.drpBankName.Name = "drpBankName";
            this.drpBankName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpBankName.Size = new System.Drawing.Size(192, 20);
            this.drpBankName.TabIndex = 32;
            // 
            // drpClientCompany
            // 
            this.drpClientCompany.Location = new System.Drawing.Point(238, 65);
            this.drpClientCompany.Name = "drpClientCompany";
            this.drpClientCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpClientCompany.Size = new System.Drawing.Size(225, 20);
            this.drpClientCompany.TabIndex = 31;
            // 
            // drpSubCompany
            // 
            this.drpSubCompany.Location = new System.Drawing.Point(238, 103);
            this.drpSubCompany.Name = "drpSubCompany";
            this.drpSubCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpSubCompany.Size = new System.Drawing.Size(225, 20);
            this.drpSubCompany.TabIndex = 30;
            // 
            // btnSelect
            // 
            this.btnSelect.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.Location = new System.Drawing.Point(7, 411);
            this.btnSelect.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnSelect.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnSelect.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSelect.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 29;
            this.btnSelect.Text = "Select";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(165, 18);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Sub Client Company";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetSubClientBankInfo";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(7, 448);
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.SubClientBankGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1566, 354);
            this.gridControl1.TabIndex = 26;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubClientBankGrid});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetSubClientBankInfo";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetSubClientBankInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // SubClientBankGrid
            // 
            this.SubClientBankGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colComCname,
            this.colSubComName,
            this.colClientCompanyId,
            this.colSubClientCompanyId,
            this.colBankName,
            this.colBankAcNo,
            this.colBranchCode,
            this.colBranchName,
            this.colIFSCode,
            this.colAddress});
            this.SubClientBankGrid.GridControl = this.gridControl1;
            this.SubClientBankGrid.Name = "SubClientBankGrid";
            this.SubClientBankGrid.DoubleClick += new System.EventHandler(this.btn_GridView);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colComCname
            // 
            this.colComCname.FieldName = "ComCname";
            this.colComCname.Name = "colComCname";
            this.colComCname.Visible = true;
            this.colComCname.VisibleIndex = 1;
            // 
            // colSubComName
            // 
            this.colSubComName.FieldName = "SubComName";
            this.colSubComName.Name = "colSubComName";
            this.colSubComName.Visible = true;
            this.colSubComName.VisibleIndex = 2;
            // 
            // colClientCompanyId
            // 
            this.colClientCompanyId.FieldName = "ClientCompanyId";
            this.colClientCompanyId.Name = "colClientCompanyId";
            // 
            // colSubClientCompanyId
            // 
            this.colSubClientCompanyId.FieldName = "SubClientCompanyId";
            this.colSubClientCompanyId.Name = "colSubClientCompanyId";
            // 
            // colBankName
            // 
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 3;
            // 
            // colBankAcNo
            // 
            this.colBankAcNo.FieldName = "BankAcNo";
            this.colBankAcNo.Name = "colBankAcNo";
            this.colBankAcNo.Visible = true;
            this.colBankAcNo.VisibleIndex = 4;
            // 
            // colBranchCode
            // 
            this.colBranchCode.FieldName = "BranchCode";
            this.colBranchCode.Name = "colBranchCode";
            this.colBranchCode.Visible = true;
            this.colBranchCode.VisibleIndex = 5;
            // 
            // colBranchName
            // 
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 6;
            // 
            // colIFSCode
            // 
            this.colIFSCode.FieldName = "IFSCode";
            this.colIFSCode.Name = "colIFSCode";
            this.colIFSCode.Visible = true;
            this.colIFSCode.VisibleIndex = 7;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 8;
            // 
            // SearchComapnyNameTxt
            // 
            this.SearchComapnyNameTxt.Location = new System.Drawing.Point(820, 408);
            this.SearchComapnyNameTxt.Name = "SearchComapnyNameTxt";
            this.SearchComapnyNameTxt.Size = new System.Drawing.Size(751, 20);
            this.SearchComapnyNameTxt.TabIndex = 25;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(580, 412);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(188, 18);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Search Company Name";
            // 
            // imgImage
            // 
            this.imgImage.EditValue = ((object)(resources.GetObject("imgImage.EditValue")));
            this.imgImage.Location = new System.Drawing.Point(686, 53);
            this.imgImage.Name = "imgImage";
            this.imgImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgImage.Size = new System.Drawing.Size(848, 338);
            this.imgImage.TabIndex = 23;
            // 
            // btn
            // 
            this.btn.Enabled = false;
            this.btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn.ImageOptions.Image")));
            this.btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn.Location = new System.Drawing.Point(548, 307);
            this.btn.LookAndFeel.SkinName = "DevExpress Style";
            this.btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(74, 73);
            this.btn.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnClear.Location = new System.Drawing.Point(548, 228);
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 73);
            this.btnClear.TabIndex = 21;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.Location = new System.Drawing.Point(548, 63);
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 73);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(436, 132);
            this.btnSearch.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSearch.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 23);
            this.btnSearch.TabIndex = 18;
            // 
            // TxtIfsCode
            // 
            this.TxtIfsCode.Location = new System.Drawing.Point(238, 377);
            this.TxtIfsCode.Name = "TxtIfsCode";
            this.TxtIfsCode.Size = new System.Drawing.Size(225, 20);
            this.TxtIfsCode.TabIndex = 17;
            // 
            // TxtBranchName
            // 
            this.TxtBranchName.Location = new System.Drawing.Point(238, 331);
            this.TxtBranchName.Name = "TxtBranchName";
            this.TxtBranchName.Size = new System.Drawing.Size(225, 20);
            this.TxtBranchName.TabIndex = 16;
            // 
            // TxtBranchCode
            // 
            this.TxtBranchCode.Location = new System.Drawing.Point(238, 283);
            this.TxtBranchCode.Name = "TxtBranchCode";
            this.TxtBranchCode.Size = new System.Drawing.Size(225, 20);
            this.TxtBranchCode.TabIndex = 15;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(238, 201);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(225, 66);
            this.TxtAddress.TabIndex = 14;
            // 
            // TxtBankAccountNo
            // 
            this.TxtBankAccountNo.Location = new System.Drawing.Point(238, 166);
            this.TxtBankAccountNo.Name = "TxtBankAccountNo";
            this.TxtBankAccountNo.Size = new System.Drawing.Size(225, 20);
            this.TxtBankAccountNo.TabIndex = 13;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(7, 379);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 18);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "IFS Code";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(7, 333);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(108, 18);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Branch Name";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(7, 285);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(102, 18);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Branch Code";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(7, 199);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 18);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Address";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 168);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 18);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Bank A/C NO";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 18);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Bank Name";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.AutoSize = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Location = new System.Drawing.Point(4, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1569, 35);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 25);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Bank Info";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(7, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Client Company";
            // 
            // FrmSubClientCompanyBankInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 828);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSubClientCompanyBankInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSubClientCompanyBankInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSubClientCompanyBankInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpClientCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpSubCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubClientBankGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchComapnyNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIfsCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBranchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBranchCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView SubClientBankGrid;
        private DevExpress.XtraEditors.TextEdit SearchComapnyNameTxt;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.PictureEdit imgImage;
        private DevExpress.XtraEditors.SimpleButton btn;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit TxtIfsCode;
        private DevExpress.XtraEditors.TextEdit TxtBranchName;
        private DevExpress.XtraEditors.TextEdit TxtBranchCode;
        private DevExpress.XtraEditors.MemoEdit TxtAddress;
        private DevExpress.XtraEditors.TextEdit TxtBankAccountNo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.ComboBoxEdit drpBankName;
        private DevExpress.XtraEditors.ComboBoxEdit drpClientCompany;
        private DevExpress.XtraEditors.ComboBoxEdit drpSubCompany;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colComCname;
        private DevExpress.XtraGrid.Columns.GridColumn colSubComName;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAcNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colIFSCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
    }
}