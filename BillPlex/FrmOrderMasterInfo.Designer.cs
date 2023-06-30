
namespace BillPlex
{
    partial class FrmOrderMasterInfo
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery5 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderMasterInfo));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOffAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhonePin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOffPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResPin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCstNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCstDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collicenseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.drpCustCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.drpProColor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpProductSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpModelCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpModelName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpCustName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpProductName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtsearch = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtTotRawmat = new DevExpress.XtraEditors.TextEdit();
            this.txtRawmatName = new DevExpress.XtraEditors.TextEdit();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.txtWages = new DevExpress.XtraEditors.TextEdit();
            this.txtMaterialwt = new DevExpress.XtraEditors.TextEdit();
            this.txtOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ddOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.ddProDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotRawmat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawmatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialwt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(10, 11);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1552, 81);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(597, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(170, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Order Master";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Controls.Add(this.btnNew);
            this.panelControl2.Controls.Add(this.btnExit);
            this.panelControl2.Controls.Add(this.btnUpdate);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnClear);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.btnEdit);
            this.panelControl2.Controls.Add(this.labelControl22);
            this.panelControl2.Controls.Add(this.labelControl21);
            this.panelControl2.Controls.Add(this.drpCustCode);
            this.panelControl2.Controls.Add(this.simpleButton3);
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.drpProColor);
            this.panelControl2.Controls.Add(this.drpStatus);
            this.panelControl2.Controls.Add(this.drpProductSize);
            this.panelControl2.Controls.Add(this.drpModelCode);
            this.panelControl2.Controls.Add(this.drpModelName);
            this.panelControl2.Controls.Add(this.drpCustName);
            this.panelControl2.Controls.Add(this.drpProductName);
            this.panelControl2.Controls.Add(this.labelControl20);
            this.panelControl2.Controls.Add(this.txtsearch);
            this.panelControl2.Controls.Add(this.txtQuantity);
            this.panelControl2.Controls.Add(this.txtTotRawmat);
            this.panelControl2.Controls.Add(this.txtRawmatName);
            this.panelControl2.Controls.Add(this.txtType);
            this.panelControl2.Controls.Add(this.txtWages);
            this.panelControl2.Controls.Add(this.txtMaterialwt);
            this.panelControl2.Controls.Add(this.txtOrderNo);
            this.panelControl2.Controls.Add(this.labelControl19);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.labelControl14);
            this.panelControl2.Controls.Add(this.labelControl15);
            this.panelControl2.Controls.Add(this.labelControl16);
            this.panelControl2.Controls.Add(this.labelControl17);
            this.panelControl2.Controls.Add(this.labelControl18);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.ddOrderDate);
            this.panelControl2.Controls.Add(this.ddProDate);
            this.panelControl2.Location = new System.Drawing.Point(11, 106);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1551, 707);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetCustomerInfo";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(38, 448);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1132, 234);
            this.gridControl1.TabIndex = 51;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery5.Name = "PRO_GetCustomerInfo";
            queryParameter5.Name = "@SearchKey";
            queryParameter5.Type = typeof(string);
            storedProcQuery5.Parameters.Add(queryParameter5);
            storedProcQuery5.StoredProcName = "PRO_GetCustomerInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery5});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colName,
            this.colOffAddress,
            this.colState,
            this.colPin,
            this.colCountry,
            this.colPhonePin,
            this.colOffPhone,
            this.colEmail,
            this.colResAddress,
            this.colResState,
            this.colResPin,
            this.colResCountry,
            this.colMobile,
            this.colTinNo,
            this.colTinDate,
            this.colCstNo,
            this.colCstDate,
            this.collicenseNo,
            this.colWebsite});
            this.gridView1.DetailHeight = 284;
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
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colOffAddress
            // 
            this.colOffAddress.FieldName = "OffAddress";
            this.colOffAddress.Name = "colOffAddress";
            this.colOffAddress.Visible = true;
            this.colOffAddress.VisibleIndex = 3;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 4;
            // 
            // colPin
            // 
            this.colPin.FieldName = "Pin";
            this.colPin.Name = "colPin";
            this.colPin.Visible = true;
            this.colPin.VisibleIndex = 5;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 6;
            // 
            // colPhonePin
            // 
            this.colPhonePin.FieldName = "PhonePin";
            this.colPhonePin.Name = "colPhonePin";
            this.colPhonePin.Visible = true;
            this.colPhonePin.VisibleIndex = 7;
            // 
            // colOffPhone
            // 
            this.colOffPhone.FieldName = "OffPhone";
            this.colOffPhone.Name = "colOffPhone";
            this.colOffPhone.Visible = true;
            this.colOffPhone.VisibleIndex = 8;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            // 
            // colResAddress
            // 
            this.colResAddress.FieldName = "ResAddress";
            this.colResAddress.Name = "colResAddress";
            this.colResAddress.Visible = true;
            this.colResAddress.VisibleIndex = 10;
            // 
            // colResState
            // 
            this.colResState.FieldName = "ResState";
            this.colResState.Name = "colResState";
            this.colResState.Visible = true;
            this.colResState.VisibleIndex = 11;
            // 
            // colResPin
            // 
            this.colResPin.FieldName = "ResPin";
            this.colResPin.Name = "colResPin";
            this.colResPin.Visible = true;
            this.colResPin.VisibleIndex = 12;
            // 
            // colResCountry
            // 
            this.colResCountry.FieldName = "ResCountry";
            this.colResCountry.Name = "colResCountry";
            this.colResCountry.Visible = true;
            this.colResCountry.VisibleIndex = 13;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 14;
            // 
            // colTinNo
            // 
            this.colTinNo.FieldName = "TinNo";
            this.colTinNo.Name = "colTinNo";
            this.colTinNo.Visible = true;
            this.colTinNo.VisibleIndex = 15;
            // 
            // colTinDate
            // 
            this.colTinDate.FieldName = "TinDate";
            this.colTinDate.Name = "colTinDate";
            this.colTinDate.Visible = true;
            this.colTinDate.VisibleIndex = 16;
            // 
            // colCstNo
            // 
            this.colCstNo.FieldName = "CstNo";
            this.colCstNo.Name = "colCstNo";
            this.colCstNo.Visible = true;
            this.colCstNo.VisibleIndex = 17;
            // 
            // colCstDate
            // 
            this.colCstDate.FieldName = "CstDate";
            this.colCstDate.Name = "colCstDate";
            this.colCstDate.Visible = true;
            this.colCstDate.VisibleIndex = 18;
            // 
            // collicenseNo
            // 
            this.collicenseNo.FieldName = "licenseNo";
            this.collicenseNo.Name = "collicenseNo";
            this.collicenseNo.Visible = true;
            this.collicenseNo.VisibleIndex = 19;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(1273, 74);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 60);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "REFRESH";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(1283, 180);
            this.btnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 30);
            this.btnNew.TabIndex = 49;
            this.btnNew.Text = "NEW";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(1283, 445);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 30);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "EXIT";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(1283, 314);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(1283, 358);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 30);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(1283, 402);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 30);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(1283, 227);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(1283, 272);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 30);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelControl22.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Appearance.Options.UseForeColor = true;
            this.labelControl22.Location = new System.Drawing.Point(118, 68);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(9, 17);
            this.labelControl22.TabIndex = 42;
            this.labelControl22.Text = "*";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl21.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Appearance.Options.UseForeColor = true;
            this.labelControl21.Location = new System.Drawing.Point(231, 142);
            this.labelControl21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(9, 17);
            this.labelControl21.TabIndex = 41;
            this.labelControl21.Text = "*";
            // 
            // drpCustCode
            // 
            this.drpCustCode.Location = new System.Drawing.Point(261, 145);
            this.drpCustCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpCustCode.Name = "drpCustCode";
            this.drpCustCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCustCode.Size = new System.Drawing.Size(141, 20);
            this.drpCustCode.TabIndex = 40;
            this.drpCustCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit10_SelectedIndexChanged);
            this.drpCustCode.Click += new System.EventHandler(this.drpCustCode_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(551, 180);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(50, 24);
            this.simpleButton3.TabIndex = 39;
            this.simpleButton3.Text = "...";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(551, 142);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 24);
            this.simpleButton2.TabIndex = 38;
            this.simpleButton2.Text = "...";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(1101, 137);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(50, 24);
            this.simpleButton1.TabIndex = 37;
            this.simpleButton1.Text = "...";
            // 
            // drpProColor
            // 
            this.drpProColor.Location = new System.Drawing.Point(866, 140);
            this.drpProColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProColor.Name = "drpProColor";
            this.drpProColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProColor.Size = new System.Drawing.Size(219, 20);
            this.drpProColor.TabIndex = 36;
            // 
            // drpStatus
            // 
            this.drpStatus.Location = new System.Drawing.Point(866, 254);
            this.drpStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpStatus.Name = "drpStatus";
            this.drpStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpStatus.Properties.Items.AddRange(new object[] {
            "Open",
            "Cancel",
            "Complete"});
            this.drpStatus.Size = new System.Drawing.Size(285, 20);
            this.drpStatus.TabIndex = 35;
            // 
            // drpProductSize
            // 
            this.drpProductSize.Location = new System.Drawing.Point(261, 297);
            this.drpProductSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProductSize.Name = "drpProductSize";
            this.drpProductSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProductSize.Size = new System.Drawing.Size(285, 20);
            this.drpProductSize.TabIndex = 33;
            this.drpProductSize.SelectedIndexChanged += new System.EventHandler(this.drpProductSize_SelectedIndexChanged);
            // 
            // drpModelCode
            // 
            this.drpModelCode.Location = new System.Drawing.Point(261, 259);
            this.drpModelCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpModelCode.Name = "drpModelCode";
            this.drpModelCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpModelCode.Size = new System.Drawing.Size(285, 20);
            this.drpModelCode.TabIndex = 32;
            // 
            // drpModelName
            // 
            this.drpModelName.Location = new System.Drawing.Point(261, 222);
            this.drpModelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpModelName.Name = "drpModelName";
            this.drpModelName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpModelName.Size = new System.Drawing.Size(285, 20);
            this.drpModelName.TabIndex = 31;
            // 
            // drpCustName
            // 
            this.drpCustName.Location = new System.Drawing.Point(407, 145);
            this.drpCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpCustName.Name = "drpCustName";
            this.drpCustName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCustName.Size = new System.Drawing.Size(139, 20);
            this.drpCustName.TabIndex = 30;
            // 
            // drpProductName
            // 
            this.drpProductName.Location = new System.Drawing.Point(261, 184);
            this.drpProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProductName.Name = "drpProductName";
            this.drpProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProductName.Size = new System.Drawing.Size(285, 20);
            this.drpProductName.TabIndex = 29;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(38, 426);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(412, 17);
            this.labelControl20.TabIndex = 27;
            this.labelControl20.Text = "By OrderNo / CustomerName / Code /  Prod.Model / Code ";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(510, 424);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(585, 20);
            this.txtsearch.TabIndex = 26;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(866, 180);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(285, 20);
            this.txtQuantity.TabIndex = 25;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // txtTotRawmat
            // 
            this.txtTotRawmat.Location = new System.Drawing.Point(866, 292);
            this.txtTotRawmat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotRawmat.Name = "txtTotRawmat";
            this.txtTotRawmat.Size = new System.Drawing.Size(285, 20);
            this.txtTotRawmat.TabIndex = 24;
            // 
            // txtRawmatName
            // 
            this.txtRawmatName.Location = new System.Drawing.Point(866, 101);
            this.txtRawmatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawmatName.Name = "txtRawmatName";
            this.txtRawmatName.Size = new System.Drawing.Size(285, 20);
            this.txtRawmatName.TabIndex = 23;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(866, 62);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(285, 20);
            this.txtType.TabIndex = 22;
            // 
            // txtWages
            // 
            this.txtWages.Location = new System.Drawing.Point(866, 336);
            this.txtWages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWages.Name = "txtWages";
            this.txtWages.Size = new System.Drawing.Size(285, 20);
            this.txtWages.TabIndex = 21;
            // 
            // txtMaterialwt
            // 
            this.txtMaterialwt.Location = new System.Drawing.Point(261, 336);
            this.txtMaterialwt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterialwt.Name = "txtMaterialwt";
            this.txtMaterialwt.Size = new System.Drawing.Size(285, 20);
            this.txtMaterialwt.TabIndex = 20;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(261, 71);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(285, 20);
            this.txtOrderNo.TabIndex = 19;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(38, 391);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(92, 17);
            this.labelControl19.TabIndex = 18;
            this.labelControl19.Text = "Search Index";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(645, 338);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(141, 17);
            this.labelControl12.TabIndex = 17;
            this.labelControl12.Text = "Wages for Employee";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(645, 100);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(132, 17);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "Raw Material Name";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(645, 139);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(96, 17);
            this.labelControl13.TabIndex = 14;
            this.labelControl13.Text = "Product Color";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(645, 177);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(60, 17);
            this.labelControl14.TabIndex = 13;
            this.labelControl14.Text = "Quantity";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(645, 216);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(91, 17);
            this.labelControl15.TabIndex = 12;
            this.labelControl15.Text = "Product Date";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(645, 253);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(45, 17);
            this.labelControl16.TabIndex = 11;
            this.labelControl16.Text = "Status";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(645, 294);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(131, 17);
            this.labelControl17.TabIndex = 10;
            this.labelControl17.Text = "Total Raw Material ";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(645, 64);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(34, 17);
            this.labelControl18.TabIndex = 9;
            this.labelControl18.Text = "Type";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(38, 106);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(76, 17);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Order Date";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(38, 144);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(164, 17);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Customer Code / Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(38, 183);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(99, 17);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Product Name";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(38, 221);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(85, 17);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Model Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 260);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 17);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Model Code";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 297);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 17);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Product Size";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 338);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(149, 17);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Material Weight/Item";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 71);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Order No";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 19);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Order Details";
            // 
            // ddOrderDate
            // 
            this.ddOrderDate.EditValue = null;
            this.ddOrderDate.Location = new System.Drawing.Point(261, 106);
            this.ddOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddOrderDate.Name = "ddOrderDate";
            this.ddOrderDate.Properties.BeepOnError = false;
            this.ddOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddOrderDate.Properties.DisplayFormat.FormatString = "";
            this.ddOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddOrderDate.Properties.EditFormat.FormatString = "";
            this.ddOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddOrderDate.Properties.MaskSettings.Set("mask", "d");
            this.ddOrderDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddOrderDate.Size = new System.Drawing.Size(285, 20);
            this.ddOrderDate.TabIndex = 28;
            // 
            // ddProDate
            // 
            this.ddProDate.EditValue = null;
            this.ddProDate.Location = new System.Drawing.Point(866, 222);
            this.ddProDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddProDate.Name = "ddProDate";
            this.ddProDate.Properties.BeepOnError = false;
            this.ddProDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddProDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddProDate.Properties.DisplayFormat.FormatString = "";
            this.ddProDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddProDate.Properties.EditFormat.FormatString = "";
            this.ddProDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddProDate.Properties.MaskSettings.Set("mask", "d");
            this.ddProDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddProDate.Size = new System.Drawing.Size(285, 20);
            this.ddProDate.TabIndex = 34;
            // 
            // FrmOrderMasterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 822);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOrderMasterInfo";
            this.Text = "FrmOrderMasterInfo";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotRawmat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawmatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialwt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit drpCustCode;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit drpProColor;
        private DevExpress.XtraEditors.ComboBoxEdit drpStatus;
        private DevExpress.XtraEditors.ComboBoxEdit drpProductSize;
        private DevExpress.XtraEditors.ComboBoxEdit drpModelCode;
        private DevExpress.XtraEditors.ComboBoxEdit drpModelName;
        private DevExpress.XtraEditors.ComboBoxEdit drpCustName;
        private DevExpress.XtraEditors.ComboBoxEdit drpProductName;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtsearch;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtTotRawmat;
        private DevExpress.XtraEditors.TextEdit txtRawmatName;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.TextEdit txtWages;
        private DevExpress.XtraEditors.TextEdit txtMaterialwt;
        private DevExpress.XtraEditors.TextEdit txtOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.DateEdit ddOrderDate;
        private DevExpress.XtraEditors.DateEdit ddProDate;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colOffAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colPin;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colPhonePin;
        private DevExpress.XtraGrid.Columns.GridColumn colOffPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colResAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colResState;
        private DevExpress.XtraGrid.Columns.GridColumn colResPin;
        private DevExpress.XtraGrid.Columns.GridColumn colResCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colTinNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTinDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCstNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCstDate;
        private DevExpress.XtraGrid.Columns.GridColumn collicenseNo;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
    }
}