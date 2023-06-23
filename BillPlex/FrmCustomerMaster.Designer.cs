
namespace BillPlex
{
    partial class FrmCustomerMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerMaster));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.CustomerGridView = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.CustomerMaster_GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchCustomer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.drpCDCountry = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpState2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpCountry = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.txtLicenseNo = new DevExpress.XtraEditors.TextEdit();
            this.txtCSTno = new DevExpress.XtraEditors.TextEdit();
            this.txtTINno = new DevExpress.XtraEditors.TextEdit();
            this.txtMobileNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtPin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtCDAddress = new DevExpress.XtraEditors.MemoEdit();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnEmailClear = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmailID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneNo = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatePin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtOffAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ddTINDate = new DevExpress.XtraEditors.DateEdit();
            this.ddCSTDate = new DevExpress.XtraEditors.DateEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMaster_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpCDCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpState2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCSTno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTINno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCDAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatePin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTINDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTINDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCSTDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCSTDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1524, 67);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(705, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(232, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Customer Master";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.CustomerGridView);
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.btnEdit);
            this.panelControl2.Controls.Add(this.btnUpdate);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.txtSearchCustomer);
            this.panelControl2.Controls.Add(this.labelControl24);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Location = new System.Drawing.Point(12, 73);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1524, 736);
            this.panelControl2.TabIndex = 1;
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.DataMember = "PRO_GetCustomerInfo";
            this.CustomerGridView.DataSource = this.sqlDataSource1;
            this.CustomerGridView.Location = new System.Drawing.Point(96, 378);
            this.CustomerGridView.MainView = this.CustomerMaster_GridView;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(1343, 341);
            this.CustomerGridView.TabIndex = 53;
            this.CustomerGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CustomerMaster_GridView});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetCustomerInfo";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetCustomerInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // CustomerMaster_GridView
            // 
            this.CustomerMaster_GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.CustomerMaster_GridView.GridControl = this.CustomerGridView;
            this.CustomerMaster_GridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.CustomerMaster_GridView.Name = "CustomerMaster_GridView";
            this.CustomerMaster_GridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.CustomerMaster_GridView.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colOffAddress
            // 
            this.colOffAddress.FieldName = "OffAddress";
            this.colOffAddress.Name = "colOffAddress";
            this.colOffAddress.Visible = true;
            this.colOffAddress.VisibleIndex = 2;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 3;
            // 
            // colPin
            // 
            this.colPin.FieldName = "Pin";
            this.colPin.Name = "colPin";
            this.colPin.Visible = true;
            this.colPin.VisibleIndex = 4;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 5;
            // 
            // colPhonePin
            // 
            this.colPhonePin.FieldName = "PhonePin";
            this.colPhonePin.Name = "colPhonePin";
            this.colPhonePin.Visible = true;
            this.colPhonePin.VisibleIndex = 6;
            // 
            // colOffPhone
            // 
            this.colOffPhone.FieldName = "OffPhone";
            this.colOffPhone.Name = "colOffPhone";
            this.colOffPhone.Visible = true;
            this.colOffPhone.VisibleIndex = 7;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            // 
            // colResAddress
            // 
            this.colResAddress.FieldName = "ResAddress";
            this.colResAddress.Name = "colResAddress";
            this.colResAddress.Visible = true;
            this.colResAddress.VisibleIndex = 9;
            // 
            // colResState
            // 
            this.colResState.FieldName = "ResState";
            this.colResState.Name = "colResState";
            this.colResState.Visible = true;
            this.colResState.VisibleIndex = 10;
            // 
            // colResPin
            // 
            this.colResPin.FieldName = "ResPin";
            this.colResPin.Name = "colResPin";
            this.colResPin.Visible = true;
            this.colResPin.VisibleIndex = 11;
            // 
            // colResCountry
            // 
            this.colResCountry.FieldName = "ResCountry";
            this.colResCountry.Name = "colResCountry";
            this.colResCountry.Visible = true;
            this.colResCountry.VisibleIndex = 12;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 13;
            // 
            // colTinNo
            // 
            this.colTinNo.FieldName = "TinNo";
            this.colTinNo.Name = "colTinNo";
            this.colTinNo.Visible = true;
            this.colTinNo.VisibleIndex = 14;
            // 
            // colTinDate
            // 
            this.colTinDate.FieldName = "TinDate";
            this.colTinDate.Name = "colTinDate";
            this.colTinDate.Visible = true;
            this.colTinDate.VisibleIndex = 15;
            // 
            // colCstNo
            // 
            this.colCstNo.FieldName = "CstNo";
            this.colCstNo.Name = "colCstNo";
            this.colCstNo.Visible = true;
            this.colCstNo.VisibleIndex = 16;
            // 
            // colCstDate
            // 
            this.colCstDate.FieldName = "CstDate";
            this.colCstDate.Name = "colCstDate";
            this.colCstDate.Visible = true;
            this.colCstDate.VisibleIndex = 17;
            // 
            // collicenseNo
            // 
            this.collicenseNo.FieldName = "licenseNo";
            this.collicenseNo.Name = "collicenseNo";
            this.collicenseNo.Visible = true;
            this.collicenseNo.VisibleIndex = 18;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 19;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.btnClear);
            this.panelControl5.Controls.Add(this.btnAdd);
            this.panelControl5.Location = new System.Drawing.Point(1036, 312);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(136, 51);
            this.panelControl5.TabIndex = 52;
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(74, 11);
            this.btnClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnClear.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 23);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(6, 11);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(1187, 323);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 23);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(1260, 323);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 23);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(1333, 323);
            this.btnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 23);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(333, 326);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(349, 20);
            this.txtSearchCustomer.TabIndex = 44;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Appearance.Options.UseForeColor = true;
            this.labelControl24.Location = new System.Drawing.Point(96, 325);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(220, 18);
            this.labelControl24.TabIndex = 43;
            this.labelControl24.Text = "Search Customer Code/Name";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.drpCDCountry);
            this.panelControl3.Controls.Add(this.drpState2);
            this.panelControl3.Controls.Add(this.drpState);
            this.panelControl3.Controls.Add(this.drpCountry);
            this.panelControl3.Controls.Add(this.labelControl23);
            this.panelControl3.Controls.Add(this.labelControl22);
            this.panelControl3.Controls.Add(this.txtWebsite);
            this.panelControl3.Controls.Add(this.txtLicenseNo);
            this.panelControl3.Controls.Add(this.txtCSTno);
            this.panelControl3.Controls.Add(this.txtTINno);
            this.panelControl3.Controls.Add(this.txtMobileNo);
            this.panelControl3.Controls.Add(this.labelControl21);
            this.panelControl3.Controls.Add(this.labelControl20);
            this.panelControl3.Controls.Add(this.labelControl19);
            this.panelControl3.Controls.Add(this.labelControl18);
            this.panelControl3.Controls.Add(this.labelControl17);
            this.panelControl3.Controls.Add(this.txtPin);
            this.panelControl3.Controls.Add(this.labelControl14);
            this.panelControl3.Controls.Add(this.labelControl15);
            this.panelControl3.Controls.Add(this.labelControl16);
            this.panelControl3.Controls.Add(this.labelControl13);
            this.panelControl3.Controls.Add(this.txtCDAddress);
            this.panelControl3.Controls.Add(this.btnCopy);
            this.panelControl3.Controls.Add(this.btnEmailClear);
            this.panelControl3.Controls.Add(this.txtEmailID);
            this.panelControl3.Controls.Add(this.labelControl12);
            this.panelControl3.Controls.Add(this.txtPhoneNo);
            this.panelControl3.Controls.Add(this.txtCode);
            this.panelControl3.Controls.Add(this.labelControl11);
            this.panelControl3.Controls.Add(this.txtStatePin);
            this.panelControl3.Controls.Add(this.labelControl10);
            this.panelControl3.Controls.Add(this.txtOffAddress);
            this.panelControl3.Controls.Add(this.txtCustomerName);
            this.panelControl3.Controls.Add(this.txtCustomerCode);
            this.panelControl3.Controls.Add(this.labelControl9);
            this.panelControl3.Controls.Add(this.labelControl8);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.ddTINDate);
            this.panelControl3.Controls.Add(this.ddCSTDate);
            this.panelControl3.Location = new System.Drawing.Point(96, 18);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1343, 275);
            this.panelControl3.TabIndex = 0;
            // 
            // drpCDCountry
            // 
            this.drpCDCountry.Location = new System.Drawing.Point(550, 233);
            this.drpCDCountry.Name = "drpCDCountry";
            this.drpCDCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCDCountry.Properties.Items.AddRange(new object[] {
            "India"});
            this.drpCDCountry.Properties.Sorted = true;
            this.drpCDCountry.Size = new System.Drawing.Size(237, 20);
            this.drpCDCountry.TabIndex = 46;
            // 
            // drpState2
            // 
            this.drpState2.Location = new System.Drawing.Point(550, 181);
            this.drpState2.Name = "drpState2";
            this.drpState2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpState2.Properties.Items.AddRange(new object[] {
            "Andaman and Nicobar Islands",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chhattisgarh",
            "Dadra and Nagar Haveli and Daman and Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Ladakh",
            "Lakshadweep",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Puducherry",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.drpState2.Properties.Sorted = true;
            this.drpState2.Size = new System.Drawing.Size(127, 20);
            this.drpState2.TabIndex = 45;
            // 
            // drpState
            // 
            this.drpState.Location = new System.Drawing.Point(153, 173);
            this.drpState.Name = "drpState";
            this.drpState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpState.Properties.Items.AddRange(new object[] {
            "Andaman and Nicobar Islands",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chhattisgarh",
            "Dadra and Nagar Haveli and Daman and Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Ladakh",
            "Lakshadweep",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Puducherry",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.drpState.Properties.Sorted = true;
            this.drpState.Size = new System.Drawing.Size(127, 20);
            this.drpState.TabIndex = 44;
            // 
            // drpCountry
            // 
            this.drpCountry.Location = new System.Drawing.Point(153, 232);
            this.drpCountry.Name = "drpCountry";
            this.drpCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCountry.Properties.Items.AddRange(new object[] {
            "India"});
            this.drpCountry.Properties.Sorted = true;
            this.drpCountry.Size = new System.Drawing.Size(237, 20);
            this.drpCountry.TabIndex = 43;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(1129, 118);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(29, 14);
            this.labelControl23.TabIndex = 40;
            this.labelControl23.Text = "Date";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(1129, 73);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(29, 14);
            this.labelControl22.TabIndex = 39;
            this.labelControl22.Text = "Date";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(1010, 212);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(254, 20);
            this.txtWebsite.TabIndex = 38;
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Location = new System.Drawing.Point(1010, 166);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(254, 20);
            this.txtLicenseNo.TabIndex = 37;
            // 
            // txtCSTno
            // 
            this.txtCSTno.Location = new System.Drawing.Point(1010, 115);
            this.txtCSTno.Name = "txtCSTno";
            this.txtCSTno.Size = new System.Drawing.Size(107, 20);
            this.txtCSTno.TabIndex = 36;
            // 
            // txtTINno
            // 
            this.txtTINno.Location = new System.Drawing.Point(1010, 70);
            this.txtTINno.Name = "txtTINno";
            this.txtTINno.Size = new System.Drawing.Size(107, 20);
            this.txtTINno.TabIndex = 35;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(1010, 30);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Properties.BeepOnError = false;
            this.txtMobileNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMobileNo.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMobileNo.Properties.MaskSettings.Set("mask", "d");
            this.txtMobileNo.Size = new System.Drawing.Size(254, 20);
            this.txtMobileNo.TabIndex = 34;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(901, 218);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(49, 14);
            this.labelControl21.TabIndex = 33;
            this.labelControl21.Text = "Website";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(901, 121);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(43, 14);
            this.labelControl20.TabIndex = 32;
            this.labelControl20.Text = "CST No";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(901, 76);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(40, 14);
            this.labelControl19.TabIndex = 31;
            this.labelControl19.Text = "TIN No";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(901, 172);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(64, 14);
            this.labelControl18.TabIndex = 31;
            this.labelControl18.Text = "License No";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(901, 36);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(60, 14);
            this.labelControl17.TabIndex = 30;
            this.labelControl17.Text = "Mobile No";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(722, 180);
            this.txtPin.Name = "txtPin";
            this.txtPin.Properties.BeepOnError = false;
            this.txtPin.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPin.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPin.Properties.MaskSettings.Set("mask", "d");
            this.txtPin.Size = new System.Drawing.Size(65, 20);
            this.txtPin.TabIndex = 28;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(695, 181);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(21, 14);
            this.labelControl14.TabIndex = 27;
            this.labelControl14.Text = "PIN";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(474, 239);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(50, 14);
            this.labelControl15.TabIndex = 25;
            this.labelControl15.Text = "Country";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(474, 183);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(34, 14);
            this.labelControl16.TabIndex = 24;
            this.labelControl16.Text = "State";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(474, 133);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(49, 14);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = "Address";
            // 
            // txtCDAddress
            // 
            this.txtCDAddress.Location = new System.Drawing.Point(550, 120);
            this.txtCDAddress.Name = "txtCDAddress";
            this.txtCDAddress.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCDAddress.Size = new System.Drawing.Size(237, 51);
            this.txtCDAddress.TabIndex = 22;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(692, 91);
            this.btnCopy.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnCopy.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnCopy.LookAndFeel.SkinName = "DevExpress Style";
            this.btnCopy.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(44, 23);
            this.btnCopy.TabIndex = 21;
            this.btnCopy.Text = "Copy";
            // 
            // btnEmailClear
            // 
            this.btnEmailClear.Location = new System.Drawing.Point(743, 91);
            this.btnEmailClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEmailClear.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnEmailClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEmailClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEmailClear.Name = "btnEmailClear";
            this.btnEmailClear.Size = new System.Drawing.Size(44, 23);
            this.btnEmailClear.TabIndex = 20;
            this.btnEmailClear.Text = "Clear";
            // 
            // txtEmailID
            // 
            this.txtEmailID.Location = new System.Drawing.Point(550, 65);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(237, 20);
            this.txtEmailID.TabIndex = 19;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(474, 67);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(49, 14);
            this.labelControl12.TabIndex = 18;
            this.labelControl12.Text = "Email ID";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(604, 30);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Properties.BeepOnError = false;
            this.txtPhoneNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPhoneNo.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPhoneNo.Properties.MaskSettings.Set("mask", "d");
            this.txtPhoneNo.Size = new System.Drawing.Size(183, 20);
            this.txtPhoneNo.TabIndex = 17;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(550, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(48, 20);
            this.txtCode.TabIndex = 16;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(474, 34);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(59, 14);
            this.labelControl11.TabIndex = 15;
            this.labelControl11.Text = "Phone No";
            // 
            // txtStatePin
            // 
            this.txtStatePin.Location = new System.Drawing.Point(325, 175);
            this.txtStatePin.Name = "txtStatePin";
            this.txtStatePin.Properties.BeepOnError = false;
            this.txtStatePin.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtStatePin.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtStatePin.Properties.MaskSettings.Set("mask", "d");
            this.txtStatePin.Size = new System.Drawing.Size(65, 20);
            this.txtStatePin.TabIndex = 13;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(298, 176);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(21, 14);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "PIN";
            // 
            // txtOffAddress
            // 
            this.txtOffAddress.Location = new System.Drawing.Point(153, 106);
            this.txtOffAddress.Name = "txtOffAddress";
            this.txtOffAddress.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOffAddress.Size = new System.Drawing.Size(237, 51);
            this.txtOffAddress.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(153, 70);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(237, 20);
            this.txtCustomerName.TabIndex = 9;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(153, 31);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(237, 20);
            this.txtCustomerCode.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(111, 73);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(10, 18);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "*";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(109, 32);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(10, 18);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(15, 234);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 14);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Country";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 178);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 14);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "State";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 121);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 14);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Office Address";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Customer Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Customer Code";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(3, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Customer Details";
            // 
            // ddTINDate
            // 
            this.ddTINDate.EditValue = null;
            this.ddTINDate.Location = new System.Drawing.Point(1173, 71);
            this.ddTINDate.Name = "ddTINDate";
            this.ddTINDate.Properties.BeepOnError = false;
            this.ddTINDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddTINDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddTINDate.Properties.DisplayFormat.FormatString = "";
            this.ddTINDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddTINDate.Properties.EditFormat.FormatString = "";
            this.ddTINDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddTINDate.Properties.MaskSettings.Set("mask", "d");
            this.ddTINDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddTINDate.Size = new System.Drawing.Size(91, 20);
            this.ddTINDate.TabIndex = 41;
            // 
            // ddCSTDate
            // 
            this.ddCSTDate.EditValue = null;
            this.ddCSTDate.Location = new System.Drawing.Point(1173, 112);
            this.ddCSTDate.Name = "ddCSTDate";
            this.ddCSTDate.Properties.BeepOnError = false;
            this.ddCSTDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddCSTDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddCSTDate.Properties.DisplayFormat.FormatString = "";
            this.ddCSTDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddCSTDate.Properties.EditFormat.FormatString = "";
            this.ddCSTDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddCSTDate.Properties.MaskSettings.Set("mask", "d");
            this.ddCSTDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddCSTDate.Size = new System.Drawing.Size(91, 20);
            this.ddCSTDate.TabIndex = 42;
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(1181, 312);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(230, 51);
            this.panelControl4.TabIndex = 48;
            // 
            // FrmCustomerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 818);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCustomerMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomerMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMaster_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpCDCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpState2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCSTno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTINno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCDAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatePin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTINDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTINDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCSTDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCSTDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtOffAddress;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtCustomerCode;
        private DevExpress.XtraEditors.TextEdit txtStatePin;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.SimpleButton btnEmailClear;
        private DevExpress.XtraEditors.TextEdit txtEmailID;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtPhoneNo;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit txtCDAddress;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtPin;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.TextEdit txtWebsite;
        private DevExpress.XtraEditors.TextEdit txtLicenseNo;
        private DevExpress.XtraEditors.TextEdit txtCSTno;
        private DevExpress.XtraEditors.TextEdit txtTINno;
        private DevExpress.XtraEditors.TextEdit txtMobileNo;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit txtSearchCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl CustomerGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView CustomerMaster_GridView;
        private DevExpress.XtraEditors.DateEdit ddTINDate;
        private DevExpress.XtraEditors.DateEdit ddCSTDate;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
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
        private DevExpress.XtraEditors.ComboBoxEdit drpCountry;
        private DevExpress.XtraEditors.ComboBoxEdit drpState;
        private DevExpress.XtraEditors.ComboBoxEdit drpCDCountry;
        private DevExpress.XtraEditors.ComboBoxEdit drpState2;
    }
}