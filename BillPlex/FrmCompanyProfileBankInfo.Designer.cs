
namespace BillPlex
{
    partial class FrmCompanyProfileBankInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyProfileBankInfo));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.MainBankInfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIFSCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.drpBankName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpMainCompany = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchComapnyName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.imgbox = new DevExpress.XtraEditors.PictureEdit();
            this.btn = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBankInfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMainCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchComapnyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox.Properties)).BeginInit();
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
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.drpBankName);
            this.panelControl1.Controls.Add(this.drpMainCompany);
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.txtSearchComapnyName);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.imgbox);
            this.panelControl1.Controls.Add(this.btn);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnUpdate);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.simpleButton1);
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
            this.panelControl1.Location = new System.Drawing.Point(12, 1);
            this.panelControl1.LookAndFeel.SkinName = "DevExpress Style";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1576, 808);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetMainBankInfo";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(7, 450);
            this.gridControl1.MainView = this.MainBankInfoGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1563, 352);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainBankInfoGridView});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btn_GridView);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetMainBankInfo";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetMainBankInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // MainBankInfoGridView
            // 
            this.MainBankInfoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colComName,
            this.colMainCompanyId,
            this.colBankName,
            this.colBankAcNo,
            this.colBranchCode,
            this.colBranchName,
            this.colIFSCode,
            this.colAddress});
            this.MainBankInfoGridView.GridControl = this.gridControl1;
            this.MainBankInfoGridView.Name = "MainBankInfoGridView";
            this.MainBankInfoGridView.PaintStyleName = "Flat";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colComName
            // 
            this.colComName.FieldName = "ComName";
            this.colComName.Name = "colComName";
            this.colComName.Visible = true;
            this.colComName.VisibleIndex = 1;
            // 
            // colMainCompanyId
            // 
            this.colMainCompanyId.FieldName = "MainCompanyId";
            this.colMainCompanyId.Name = "colMainCompanyId";
            this.colMainCompanyId.Visible = true;
            this.colMainCompanyId.VisibleIndex = 2;
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
            // drpBankName
            // 
            this.drpBankName.Location = new System.Drawing.Point(149, 95);
            this.drpBankName.Name = "drpBankName";
            this.drpBankName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpBankName.Size = new System.Drawing.Size(180, 20);
            this.drpBankName.TabIndex = 29;
            // 
            // drpMainCompany
            // 
            this.drpMainCompany.Location = new System.Drawing.Point(149, 60);
            this.drpMainCompany.Name = "drpMainCompany";
            this.drpMainCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpMainCompany.Size = new System.Drawing.Size(209, 20);
            this.drpMainCompany.TabIndex = 28;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(7, 411);
            this.btnSelect.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnSelect.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnSelect.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSelect.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 27;
            this.btnSelect.Text = "SELECT";
            // 
            // txtSearchComapnyName
            // 
            this.txtSearchComapnyName.Location = new System.Drawing.Point(820, 408);
            this.txtSearchComapnyName.Name = "txtSearchComapnyName";
            this.txtSearchComapnyName.Size = new System.Drawing.Size(751, 20);
            this.txtSearchComapnyName.TabIndex = 25;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(667, 410);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(147, 16);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Search Company Name";
            // 
            // imgbox
            // 
            this.imgbox.EditValue = ((object)(resources.GetObject("imgbox.EditValue")));
            this.imgbox.Location = new System.Drawing.Point(524, 53);
            this.imgbox.Name = "imgbox";
            this.imgbox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgbox.Size = new System.Drawing.Size(1047, 338);
            this.imgbox.TabIndex = 23;
            // 
            // btn
            // 
            this.btn.Enabled = false;
            this.btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn.ImageOptions.Image")));
            this.btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn.Location = new System.Drawing.Point(368, 297);
            this.btn.LookAndFeel.SkinName = "DevExpress Style";
            this.btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(74, 73);
            this.btn.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnCancel.Location = new System.Drawing.Point(368, 218);
            this.btnCancel.LookAndFeel.SkinName = "DevExpress Style";
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 73);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(368, 135);
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 73);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.Location = new System.Drawing.Point(368, 53);
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 73);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(335, 92);
            this.simpleButton1.LookAndFeel.SkinName = "DevExpress Style";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(23, 23);
            this.simpleButton1.TabIndex = 18;
            // 
            // TxtIfsCode
            // 
            this.TxtIfsCode.Location = new System.Drawing.Point(149, 340);
            this.TxtIfsCode.Name = "TxtIfsCode";
            this.TxtIfsCode.Size = new System.Drawing.Size(209, 20);
            this.TxtIfsCode.TabIndex = 17;
            // 
            // TxtBranchName
            // 
            this.TxtBranchName.Location = new System.Drawing.Point(149, 294);
            this.TxtBranchName.Name = "TxtBranchName";
            this.TxtBranchName.Size = new System.Drawing.Size(209, 20);
            this.TxtBranchName.TabIndex = 16;
            // 
            // TxtBranchCode
            // 
            this.TxtBranchCode.Location = new System.Drawing.Point(149, 246);
            this.TxtBranchCode.Name = "TxtBranchCode";
            this.TxtBranchCode.Size = new System.Drawing.Size(209, 20);
            this.TxtBranchCode.TabIndex = 15;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(149, 164);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(209, 66);
            this.TxtAddress.TabIndex = 14;
            // 
            // TxtBankAccountNo
            // 
            this.TxtBankAccountNo.Location = new System.Drawing.Point(149, 129);
            this.TxtBankAccountNo.Name = "TxtBankAccountNo";
            this.TxtBankAccountNo.Properties.BeepOnError = false;
            this.TxtBankAccountNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtBankAccountNo.Properties.MaskSettings.Set("mask", "d");
            this.TxtBankAccountNo.Properties.MaskSettings.Set("valueType", typeof(long));
            this.TxtBankAccountNo.Properties.UseMaskAsDisplayFormat = true;
            this.TxtBankAccountNo.Size = new System.Drawing.Size(209, 20);
            this.TxtBankAccountNo.TabIndex = 13;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 344);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 16);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "IFS Code";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 298);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 16);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Branch Name";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 250);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 16);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Branch Code";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 164);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 16);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Address";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 16);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Bank A/C NO";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 16);
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
            this.panelControl2.Location = new System.Drawing.Point(2, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1569, 35);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Bank Info";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Main Company";
            // 
            // FrmCompanyProfileBankInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1594, 815);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCompanyProfileBankInfo";
            this.Text = "FrmCompanyProfileBankInfo";
            this.Load += new System.EventHandler(this.FrmCompanyProfileBankInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBankInfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMainCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchComapnyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtSearchComapnyName;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.PictureEdit imgbox;
        private DevExpress.XtraEditors.SimpleButton btn;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
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
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.ComboBoxEdit drpBankName;
        private DevExpress.XtraEditors.ComboBoxEdit drpMainCompany;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView MainBankInfoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colComName;
        private DevExpress.XtraGrid.Columns.GridColumn colMainCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAcNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colIFSCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
    }
}