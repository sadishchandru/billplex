﻿
namespace BillPlex
{
    partial class FrmCompanyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyProfile));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.Exitbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Clearbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Deletebtn = new DevExpress.XtraEditors.SimpleButton();
            this.Updatebtn = new DevExpress.XtraEditors.SimpleButton();
            this.Editbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Addbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Newbtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComCcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComOffAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComNature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComDatestart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComStdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPFno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPFdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComESIno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComESIdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComFactoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComCSTno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComSSLno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComTINno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComLicenseno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPanno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComTanno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAFathername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCApin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAStdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAPhoneno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAblood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCADOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAPan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBankname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBankACNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBankAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.drpClientProfile = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Printbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Claerbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Findbtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpClientProfile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "BillPlex";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery1.Name = "PRO_GetMasterCompanyProfileInfo";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetMasterCompanyProfileInfo";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "PRO_GetMasterCompanyProfileInfo";
            queryParameter2.Name = "@SearchKey";
            queryParameter2.Type = typeof(string);
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.StoredProcName = "PRO_GetMasterCompanyProfileInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(8, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1559, 728);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Location = new System.Drawing.Point(5, 83);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1549, 640);
            this.panelControl3.TabIndex = 5;
            // 
            // panelControl5
            // 
            this.panelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl5.Controls.Add(this.Exitbtn);
            this.panelControl5.Controls.Add(this.Clearbtn);
            this.panelControl5.Controls.Add(this.Deletebtn);
            this.panelControl5.Controls.Add(this.Updatebtn);
            this.panelControl5.Controls.Add(this.Editbtn);
            this.panelControl5.Controls.Add(this.Addbtn);
            this.panelControl5.Controls.Add(this.Newbtn);
            this.panelControl5.Location = new System.Drawing.Point(1442, 101);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(98, 281);
            this.panelControl5.TabIndex = 1;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Exitbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Appearance.Options.UseBackColor = true;
            this.Exitbtn.Appearance.Options.UseFont = true;
            this.Exitbtn.Enabled = false;
            this.Exitbtn.Location = new System.Drawing.Point(12, 246);
            this.Exitbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Exitbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 11;
            this.Exitbtn.Text = "EXIT";
            this.Exitbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Clearbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.Appearance.Options.UseBackColor = true;
            this.Clearbtn.Appearance.Options.UseFont = true;
            this.Clearbtn.Enabled = false;
            this.Clearbtn.Location = new System.Drawing.Point(12, 207);
            this.Clearbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Clearbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 10;
            this.Clearbtn.Text = "CLEAR";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Deletebtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Appearance.Options.UseBackColor = true;
            this.Deletebtn.Appearance.Options.UseFont = true;
            this.Deletebtn.Location = new System.Drawing.Point(12, 168);
            this.Deletebtn.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.Deletebtn.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.Deletebtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Deletebtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 9;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Updatebtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Appearance.Options.UseBackColor = true;
            this.Updatebtn.Appearance.Options.UseFont = true;
            this.Updatebtn.Enabled = false;
            this.Updatebtn.Location = new System.Drawing.Point(12, 126);
            this.Updatebtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Updatebtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 8;
            this.Updatebtn.Text = "UPDATE";
            // 
            // Editbtn
            // 
            this.Editbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Editbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.Appearance.Options.UseBackColor = true;
            this.Editbtn.Appearance.Options.UseFont = true;
            this.Editbtn.Enabled = false;
            this.Editbtn.Location = new System.Drawing.Point(12, 86);
            this.Editbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Editbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(75, 23);
            this.Editbtn.TabIndex = 7;
            this.Editbtn.Text = "EDIT";
            // 
            // Addbtn
            // 
            this.Addbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Addbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Appearance.Options.UseBackColor = true;
            this.Addbtn.Appearance.Options.UseFont = true;
            this.Addbtn.Enabled = false;
            this.Addbtn.Location = new System.Drawing.Point(12, 43);
            this.Addbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Addbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "ADD";
            // 
            // Newbtn
            // 
            this.Newbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Newbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newbtn.Appearance.Options.UseBackColor = true;
            this.Newbtn.Appearance.Options.UseFont = true;
            this.Newbtn.Location = new System.Drawing.Point(12, 5);
            this.Newbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Newbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(75, 23);
            this.Newbtn.TabIndex = 5;
            this.Newbtn.Text = "NEW";
            this.Newbtn.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl4.Controls.Add(this.panelControl6);
            this.panelControl4.Location = new System.Drawing.Point(-9, -4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1429, 648);
            this.panelControl4.TabIndex = 0;
            // 
            // panelControl6
            // 
            this.panelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl6.Controls.Add(this.gridControl1);
            this.panelControl6.Controls.Add(this.drpClientProfile);
            this.panelControl6.Controls.Add(this.Printbtn);
            this.panelControl6.Controls.Add(this.Claerbtn);
            this.panelControl6.Controls.Add(this.Findbtn);
            this.panelControl6.Location = new System.Drawing.Point(9, 5);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(1403, 622);
            this.panelControl6.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridControl1.DataMember = "PRO_GetMasterCompanyProfileInfo";
            this.gridControl1.DataSource = this.sqlDataSource2;
            this.gridControl1.Location = new System.Drawing.Point(5, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1393, 527);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.Editbtn_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colComCcode,
            this.colComName,
            this.colComType,
            this.colComOffAdd,
            this.colComstate,
            this.colComPin,
            this.colComNature,
            this.colComDatestart,
            this.colComStdCode,
            this.colComPhone,
            this.colComEmail,
            this.colComWebsite,
            this.colComPFno,
            this.colComPFdate,
            this.colComESIno,
            this.colComESIdate,
            this.colComFactoryNo,
            this.colComCSTno,
            this.colComSSLno,
            this.colComTINno,
            this.colComLicenseno,
            this.colComPanno,
            this.colComTanno,
            this.colCAuthorName,
            this.colCAFathername,
            this.colCAGender,
            this.colCAAddress,
            this.colCAstate,
            this.colCApin,
            this.colCAStdCode,
            this.colCAPhoneno,
            this.colCAMobile,
            this.colCAblood,
            this.colCADOB,
            this.colCAEmail,
            this.colCAPan,
            this.colCBankname,
            this.colCBankACNo,
            this.colCBankAddress,
            this.colCreatedDate,
            this.colCAStartDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsScrollAnnotations.ShowCustomAnnotations = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsScrollAnnotations.ShowErrors = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
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
            // colComCcode
            // 
            this.colComCcode.FieldName = "ComCcode";
            this.colComCcode.MinWidth = 80;
            this.colComCcode.Name = "colComCcode";
            this.colComCcode.Visible = true;
            this.colComCcode.VisibleIndex = 1;
            this.colComCcode.Width = 80;
            // 
            // colComName
            // 
            this.colComName.FieldName = "ComName";
            this.colComName.MinWidth = 80;
            this.colComName.Name = "colComName";
            this.colComName.Visible = true;
            this.colComName.VisibleIndex = 2;
            this.colComName.Width = 80;
            // 
            // colComType
            // 
            this.colComType.FieldName = "ComType";
            this.colComType.MinWidth = 80;
            this.colComType.Name = "colComType";
            this.colComType.Width = 80;
            // 
            // colComOffAdd
            // 
            this.colComOffAdd.FieldName = "ComOffAdd";
            this.colComOffAdd.MinWidth = 80;
            this.colComOffAdd.Name = "colComOffAdd";
            this.colComOffAdd.Visible = true;
            this.colComOffAdd.VisibleIndex = 3;
            this.colComOffAdd.Width = 85;
            // 
            // colComstate
            // 
            this.colComstate.FieldName = "Comstate";
            this.colComstate.MinWidth = 80;
            this.colComstate.Name = "colComstate";
            this.colComstate.Visible = true;
            this.colComstate.VisibleIndex = 4;
            this.colComstate.Width = 80;
            // 
            // colComPin
            // 
            this.colComPin.FieldName = "ComPin";
            this.colComPin.MinWidth = 80;
            this.colComPin.Name = "colComPin";
            this.colComPin.Visible = true;
            this.colComPin.VisibleIndex = 5;
            this.colComPin.Width = 80;
            // 
            // colComNature
            // 
            this.colComNature.FieldName = "ComNature";
            this.colComNature.MinWidth = 80;
            this.colComNature.Name = "colComNature";
            this.colComNature.Visible = true;
            this.colComNature.VisibleIndex = 6;
            this.colComNature.Width = 80;
            // 
            // colComDatestart
            // 
            this.colComDatestart.FieldName = "ComDatestart";
            this.colComDatestart.MinWidth = 80;
            this.colComDatestart.Name = "colComDatestart";
            this.colComDatestart.Visible = true;
            this.colComDatestart.VisibleIndex = 7;
            this.colComDatestart.Width = 93;
            // 
            // colComStdCode
            // 
            this.colComStdCode.FieldName = "ComStdCode";
            this.colComStdCode.MinWidth = 80;
            this.colComStdCode.Name = "colComStdCode";
            this.colComStdCode.Visible = true;
            this.colComStdCode.VisibleIndex = 8;
            this.colComStdCode.Width = 91;
            // 
            // colComPhone
            // 
            this.colComPhone.FieldName = "ComPhone";
            this.colComPhone.MinWidth = 80;
            this.colComPhone.Name = "colComPhone";
            this.colComPhone.Visible = true;
            this.colComPhone.VisibleIndex = 9;
            this.colComPhone.Width = 80;
            // 
            // colComEmail
            // 
            this.colComEmail.FieldName = "ComEmail";
            this.colComEmail.MinWidth = 80;
            this.colComEmail.Name = "colComEmail";
            this.colComEmail.Visible = true;
            this.colComEmail.VisibleIndex = 10;
            this.colComEmail.Width = 80;
            // 
            // colComWebsite
            // 
            this.colComWebsite.FieldName = "ComWebsite";
            this.colComWebsite.MinWidth = 80;
            this.colComWebsite.Name = "colComWebsite";
            this.colComWebsite.Visible = true;
            this.colComWebsite.VisibleIndex = 11;
            this.colComWebsite.Width = 86;
            // 
            // colComPFno
            // 
            this.colComPFno.FieldName = "ComPFno";
            this.colComPFno.MinWidth = 80;
            this.colComPFno.Name = "colComPFno";
            this.colComPFno.Visible = true;
            this.colComPFno.VisibleIndex = 12;
            this.colComPFno.Width = 80;
            // 
            // colComPFdate
            // 
            this.colComPFdate.FieldName = "ComPFdate";
            this.colComPFdate.MinWidth = 80;
            this.colComPFdate.Name = "colComPFdate";
            this.colComPFdate.Visible = true;
            this.colComPFdate.VisibleIndex = 13;
            this.colComPFdate.Width = 81;
            // 
            // colComESIno
            // 
            this.colComESIno.FieldName = "ComESIno";
            this.colComESIno.MinWidth = 80;
            this.colComESIno.Name = "colComESIno";
            this.colComESIno.Visible = true;
            this.colComESIno.VisibleIndex = 14;
            this.colComESIno.Width = 80;
            // 
            // colComESIdate
            // 
            this.colComESIdate.FieldName = "ComESIdate";
            this.colComESIdate.MinWidth = 80;
            this.colComESIdate.Name = "colComESIdate";
            this.colComESIdate.Visible = true;
            this.colComESIdate.VisibleIndex = 15;
            this.colComESIdate.Width = 88;
            // 
            // colComFactoryNo
            // 
            this.colComFactoryNo.FieldName = "ComFactoryNo";
            this.colComFactoryNo.MinWidth = 80;
            this.colComFactoryNo.Name = "colComFactoryNo";
            this.colComFactoryNo.Visible = true;
            this.colComFactoryNo.VisibleIndex = 16;
            this.colComFactoryNo.Width = 100;
            // 
            // colComCSTno
            // 
            this.colComCSTno.FieldName = "ComCSTno";
            this.colComCSTno.MinWidth = 80;
            this.colComCSTno.Name = "colComCSTno";
            this.colComCSTno.Visible = true;
            this.colComCSTno.VisibleIndex = 17;
            this.colComCSTno.Width = 81;
            // 
            // colComSSLno
            // 
            this.colComSSLno.FieldName = "ComSSLno";
            this.colComSSLno.MinWidth = 80;
            this.colComSSLno.Name = "colComSSLno";
            this.colComSSLno.Visible = true;
            this.colComSSLno.VisibleIndex = 18;
            this.colComSSLno.Width = 80;
            // 
            // colComTINno
            // 
            this.colComTINno.FieldName = "ComTINno";
            this.colComTINno.MinWidth = 80;
            this.colComTINno.Name = "colComTINno";
            this.colComTINno.Visible = true;
            this.colComTINno.VisibleIndex = 19;
            this.colComTINno.Width = 80;
            // 
            // colComLicenseno
            // 
            this.colComLicenseno.FieldName = "ComLicenseno";
            this.colComLicenseno.MinWidth = 80;
            this.colComLicenseno.Name = "colComLicenseno";
            this.colComLicenseno.Visible = true;
            this.colComLicenseno.VisibleIndex = 20;
            this.colComLicenseno.Width = 94;
            // 
            // colComPanno
            // 
            this.colComPanno.FieldName = "ComPanno";
            this.colComPanno.MinWidth = 80;
            this.colComPanno.Name = "colComPanno";
            this.colComPanno.Visible = true;
            this.colComPanno.VisibleIndex = 21;
            this.colComPanno.Width = 80;
            // 
            // colComTanno
            // 
            this.colComTanno.FieldName = "ComTanno";
            this.colComTanno.MinWidth = 80;
            this.colComTanno.Name = "colComTanno";
            this.colComTanno.Visible = true;
            this.colComTanno.VisibleIndex = 22;
            this.colComTanno.Width = 80;
            // 
            // colCAuthorName
            // 
            this.colCAuthorName.FieldName = "CAuthorName";
            this.colCAuthorName.MinWidth = 80;
            this.colCAuthorName.Name = "colCAuthorName";
            this.colCAuthorName.Visible = true;
            this.colCAuthorName.VisibleIndex = 23;
            this.colCAuthorName.Width = 93;
            // 
            // colCAFathername
            // 
            this.colCAFathername.FieldName = "CAFathername";
            this.colCAFathername.MinWidth = 80;
            this.colCAFathername.Name = "colCAFathername";
            this.colCAFathername.Visible = true;
            this.colCAFathername.VisibleIndex = 24;
            this.colCAFathername.Width = 98;
            // 
            // colCAGender
            // 
            this.colCAGender.FieldName = "CAGender";
            this.colCAGender.MinWidth = 80;
            this.colCAGender.Name = "colCAGender";
            this.colCAGender.Visible = true;
            this.colCAGender.VisibleIndex = 25;
            this.colCAGender.Width = 80;
            // 
            // colCAAddress
            // 
            this.colCAAddress.FieldName = "CAAddress";
            this.colCAAddress.MinWidth = 80;
            this.colCAAddress.Name = "colCAAddress";
            this.colCAAddress.Visible = true;
            this.colCAAddress.VisibleIndex = 26;
            this.colCAAddress.Width = 80;
            // 
            // colCAstate
            // 
            this.colCAstate.FieldName = "CAstate";
            this.colCAstate.MinWidth = 80;
            this.colCAstate.Name = "colCAstate";
            this.colCAstate.Visible = true;
            this.colCAstate.VisibleIndex = 27;
            this.colCAstate.Width = 80;
            // 
            // colCApin
            // 
            this.colCApin.FieldName = "CApin";
            this.colCApin.MinWidth = 80;
            this.colCApin.Name = "colCApin";
            this.colCApin.Visible = true;
            this.colCApin.VisibleIndex = 28;
            this.colCApin.Width = 80;
            // 
            // colCAStdCode
            // 
            this.colCAStdCode.FieldName = "CAStdCode";
            this.colCAStdCode.MinWidth = 80;
            this.colCAStdCode.Name = "colCAStdCode";
            this.colCAStdCode.Visible = true;
            this.colCAStdCode.VisibleIndex = 29;
            this.colCAStdCode.Width = 84;
            // 
            // colCAPhoneno
            // 
            this.colCAPhoneno.FieldName = "CAPhoneno";
            this.colCAPhoneno.MinWidth = 80;
            this.colCAPhoneno.Name = "colCAPhoneno";
            this.colCAPhoneno.Visible = true;
            this.colCAPhoneno.VisibleIndex = 30;
            this.colCAPhoneno.Width = 82;
            // 
            // colCAMobile
            // 
            this.colCAMobile.FieldName = "CAMobile";
            this.colCAMobile.MinWidth = 80;
            this.colCAMobile.Name = "colCAMobile";
            this.colCAMobile.Visible = true;
            this.colCAMobile.VisibleIndex = 31;
            this.colCAMobile.Width = 80;
            // 
            // colCAblood
            // 
            this.colCAblood.FieldName = "CAblood";
            this.colCAblood.MinWidth = 80;
            this.colCAblood.Name = "colCAblood";
            this.colCAblood.Visible = true;
            this.colCAblood.VisibleIndex = 32;
            this.colCAblood.Width = 80;
            // 
            // colCADOB
            // 
            this.colCADOB.FieldName = "CADOB";
            this.colCADOB.MinWidth = 80;
            this.colCADOB.Name = "colCADOB";
            this.colCADOB.Visible = true;
            this.colCADOB.VisibleIndex = 33;
            this.colCADOB.Width = 80;
            // 
            // colCAEmail
            // 
            this.colCAEmail.FieldName = "CAEmail";
            this.colCAEmail.MinWidth = 80;
            this.colCAEmail.Name = "colCAEmail";
            this.colCAEmail.Visible = true;
            this.colCAEmail.VisibleIndex = 34;
            this.colCAEmail.Width = 80;
            // 
            // colCAPan
            // 
            this.colCAPan.FieldName = "CAPan";
            this.colCAPan.MinWidth = 80;
            this.colCAPan.Name = "colCAPan";
            this.colCAPan.Visible = true;
            this.colCAPan.VisibleIndex = 35;
            this.colCAPan.Width = 80;
            // 
            // colCBankname
            // 
            this.colCBankname.FieldName = "CBankname";
            this.colCBankname.MinWidth = 80;
            this.colCBankname.Name = "colCBankname";
            this.colCBankname.Visible = true;
            this.colCBankname.VisibleIndex = 36;
            this.colCBankname.Width = 80;
            // 
            // colCBankACNo
            // 
            this.colCBankACNo.FieldName = "CBankACNo";
            this.colCBankACNo.MinWidth = 80;
            this.colCBankACNo.Name = "colCBankACNo";
            this.colCBankACNo.Visible = true;
            this.colCBankACNo.VisibleIndex = 37;
            this.colCBankACNo.Width = 83;
            // 
            // colCBankAddress
            // 
            this.colCBankAddress.FieldName = "CBankAddress";
            this.colCBankAddress.MinWidth = 80;
            this.colCBankAddress.Name = "colCBankAddress";
            this.colCBankAddress.Visible = true;
            this.colCBankAddress.VisibleIndex = 38;
            this.colCBankAddress.Width = 95;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.MinWidth = 80;
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 39;
            this.colCreatedDate.Width = 88;
            // 
            // colCAStartDate
            // 
            this.colCAStartDate.FieldName = "CAStartDate";
            this.colCAStartDate.MinWidth = 80;
            this.colCAStartDate.Name = "colCAStartDate";
            this.colCAStartDate.Visible = true;
            this.colCAStartDate.VisibleIndex = 40;
            this.colCAStartDate.Width = 119;
            // 
            // drpClientProfile
            // 
            this.drpClientProfile.Location = new System.Drawing.Point(89, 26);
            this.drpClientProfile.Name = "drpClientProfile";
            this.drpClientProfile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpClientProfile.Size = new System.Drawing.Size(364, 20);
            this.drpClientProfile.TabIndex = 9;
            // 
            // Printbtn
            // 
            this.Printbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Printbtn.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Printbtn.Appearance.BorderColor = System.Drawing.Color.White;
            this.Printbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.Appearance.Options.UseBackColor = true;
            this.Printbtn.Appearance.Options.UseBorderColor = true;
            this.Printbtn.Appearance.Options.UseFont = true;
            this.Printbtn.Location = new System.Drawing.Point(776, 23);
            this.Printbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Printbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(75, 23);
            this.Printbtn.TabIndex = 7;
            this.Printbtn.Text = "Print";
            // 
            // Claerbtn
            // 
            this.Claerbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Claerbtn.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.Claerbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Claerbtn.Appearance.Options.UseBackColor = true;
            this.Claerbtn.Appearance.Options.UseFont = true;
            this.Claerbtn.Location = new System.Drawing.Point(590, 23);
            this.Claerbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Claerbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Claerbtn.Name = "Claerbtn";
            this.Claerbtn.Size = new System.Drawing.Size(75, 23);
            this.Claerbtn.TabIndex = 4;
            this.Claerbtn.Text = "Clear";
            // 
            // Findbtn
            // 
            this.Findbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Findbtn.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.Findbtn.Appearance.BorderColor = System.Drawing.Color.White;
            this.Findbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findbtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Findbtn.Appearance.Options.UseBackColor = true;
            this.Findbtn.Appearance.Options.UseBorderColor = true;
            this.Findbtn.Appearance.Options.UseFont = true;
            this.Findbtn.Appearance.Options.UseForeColor = true;
            this.Findbtn.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.Findbtn.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.Findbtn.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.Findbtn.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.Findbtn.AppearanceDisabled.Options.UseBackColor = true;
            this.Findbtn.AppearanceDisabled.Options.UseBorderColor = true;
            this.Findbtn.AppearanceDisabled.Options.UseForeColor = true;
            this.Findbtn.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.Findbtn.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.Findbtn.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.Findbtn.AppearanceHovered.Options.UseBackColor = true;
            this.Findbtn.AppearanceHovered.Options.UseBorderColor = true;
            this.Findbtn.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.Findbtn.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.Findbtn.AppearancePressed.BorderColor = System.Drawing.Color.Aqua;
            this.Findbtn.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.Findbtn.AppearancePressed.Options.UseBackColor = true;
            this.Findbtn.AppearancePressed.Options.UseBorderColor = true;
            this.Findbtn.AppearancePressed.Options.UseForeColor = true;
            this.Findbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Findbtn.Location = new System.Drawing.Point(487, 23);
            this.Findbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Findbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(75, 23);
            this.Findbtn.TabIndex = 3;
            this.Findbtn.Text = "Find";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1549, 72);
            this.panelControl2.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(601, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Company Profile";
            // 
            // FrmCompanyProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1572, 736);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompanyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompanyProfile";
            this.Load += new System.EventHandler(this.FrmCompanyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpClientProfile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton Exitbtn;
        private DevExpress.XtraEditors.SimpleButton Clearbtn;
        private DevExpress.XtraEditors.SimpleButton Deletebtn;
        private DevExpress.XtraEditors.SimpleButton Updatebtn;
        private DevExpress.XtraEditors.SimpleButton Editbtn;
        private DevExpress.XtraEditors.SimpleButton Addbtn;
        private DevExpress.XtraEditors.SimpleButton Newbtn;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colComCcode;
        private DevExpress.XtraGrid.Columns.GridColumn colComName;
        private DevExpress.XtraGrid.Columns.GridColumn colComType;
        private DevExpress.XtraGrid.Columns.GridColumn colComOffAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colComstate;
        private DevExpress.XtraGrid.Columns.GridColumn colComPin;
        private DevExpress.XtraGrid.Columns.GridColumn colComNature;
        private DevExpress.XtraGrid.Columns.GridColumn colComDatestart;
        private DevExpress.XtraGrid.Columns.GridColumn colComStdCode;
        private DevExpress.XtraGrid.Columns.GridColumn colComPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colComEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colComWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colComPFno;
        private DevExpress.XtraGrid.Columns.GridColumn colComPFdate;
        private DevExpress.XtraGrid.Columns.GridColumn colComESIno;
        private DevExpress.XtraGrid.Columns.GridColumn colComESIdate;
        private DevExpress.XtraGrid.Columns.GridColumn colComFactoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colComCSTno;
        private DevExpress.XtraGrid.Columns.GridColumn colComSSLno;
        private DevExpress.XtraGrid.Columns.GridColumn colComTINno;
        private DevExpress.XtraGrid.Columns.GridColumn colComLicenseno;
        private DevExpress.XtraGrid.Columns.GridColumn colComPanno;
        private DevExpress.XtraGrid.Columns.GridColumn colComTanno;
        private DevExpress.XtraGrid.Columns.GridColumn colCAuthorName;
        private DevExpress.XtraGrid.Columns.GridColumn colCAFathername;
        private DevExpress.XtraGrid.Columns.GridColumn colCAGender;
        private DevExpress.XtraGrid.Columns.GridColumn colCAAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCAstate;
        private DevExpress.XtraGrid.Columns.GridColumn colCApin;
        private DevExpress.XtraGrid.Columns.GridColumn colCAStdCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCAPhoneno;
        private DevExpress.XtraGrid.Columns.GridColumn colCAMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colCAblood;
        private DevExpress.XtraGrid.Columns.GridColumn colCADOB;
        private DevExpress.XtraGrid.Columns.GridColumn colCAEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCAPan;
        private DevExpress.XtraGrid.Columns.GridColumn colCBankname;
        private DevExpress.XtraGrid.Columns.GridColumn colCBankACNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCBankAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCAStartDate;
        private DevExpress.XtraEditors.ComboBoxEdit drpClientProfile;
        private DevExpress.XtraEditors.SimpleButton Printbtn;
        private DevExpress.XtraEditors.SimpleButton Claerbtn;
        private DevExpress.XtraEditors.SimpleButton Findbtn;
    }
}