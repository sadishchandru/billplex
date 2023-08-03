
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery15 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter15 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyProfile));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery16 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter16 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComCcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.ExitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ClearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "BillPlex";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery15.Name = "PRO_GetMasterCompanyProfileInfo";
            queryParameter15.Name = "@SearchKey";
            queryParameter15.Type = typeof(string);
            storedProcQuery15.Parameters.Add(queryParameter15);
            storedProcQuery15.StoredProcName = "PRO_GetMasterCompanyProfileInfo";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery15});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery16.Name = "PRO_GetMasterCompanyProfileInfo";
            queryParameter16.Name = "@SearchKey";
            queryParameter16.Type = typeof(string);
            storedProcQuery16.Parameters.Add(queryParameter16);
            storedProcQuery16.StoredProcName = "PRO_GetMasterCompanyProfileInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery16});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1794, 712);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.panelControl7);
            this.panelControl3.Location = new System.Drawing.Point(5, 83);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1784, 624);
            this.panelControl3.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridControl1);
            this.panelControl4.Location = new System.Drawing.Point(6, 6);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1614, 613);
            this.panelControl4.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetMasterCompanyProfileInfo";
            this.gridControl1.DataSource = this.sqlDataSource2;
            this.gridControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(5, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1604, 571);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colComCcode,
            this.colComName,
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
            // colComOffAdd
            // 
            this.colComOffAdd.FieldName = "ComOffAdd";
            this.colComOffAdd.MinWidth = 80;
            this.colComOffAdd.Name = "colComOffAdd";
            this.colComOffAdd.Visible = true;
            this.colComOffAdd.VisibleIndex = 3;
            this.colComOffAdd.Width = 80;
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
            this.colComDatestart.Width = 80;
            // 
            // colComStdCode
            // 
            this.colComStdCode.FieldName = "ComStdCode";
            this.colComStdCode.MinWidth = 80;
            this.colComStdCode.Name = "colComStdCode";
            this.colComStdCode.Visible = true;
            this.colComStdCode.VisibleIndex = 8;
            this.colComStdCode.Width = 80;
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
            this.colComWebsite.Width = 80;
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
            this.colComPFdate.Width = 80;
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
            this.colComESIdate.Width = 80;
            // 
            // colComFactoryNo
            // 
            this.colComFactoryNo.FieldName = "ComFactoryNo";
            this.colComFactoryNo.MinWidth = 80;
            this.colComFactoryNo.Name = "colComFactoryNo";
            this.colComFactoryNo.Visible = true;
            this.colComFactoryNo.VisibleIndex = 16;
            this.colComFactoryNo.Width = 80;
            // 
            // colComCSTno
            // 
            this.colComCSTno.FieldName = "ComCSTno";
            this.colComCSTno.MinWidth = 80;
            this.colComCSTno.Name = "colComCSTno";
            this.colComCSTno.Visible = true;
            this.colComCSTno.VisibleIndex = 17;
            this.colComCSTno.Width = 80;
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
            this.colComLicenseno.Width = 80;
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
            this.colCAuthorName.Width = 80;
            // 
            // colCAFathername
            // 
            this.colCAFathername.FieldName = "CAFathername";
            this.colCAFathername.MinWidth = 80;
            this.colCAFathername.Name = "colCAFathername";
            this.colCAFathername.Visible = true;
            this.colCAFathername.VisibleIndex = 24;
            this.colCAFathername.Width = 80;
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
            this.colCAStdCode.Width = 80;
            // 
            // colCAPhoneno
            // 
            this.colCAPhoneno.FieldName = "CAPhoneno";
            this.colCAPhoneno.MinWidth = 80;
            this.colCAPhoneno.Name = "colCAPhoneno";
            this.colCAPhoneno.Visible = true;
            this.colCAPhoneno.VisibleIndex = 30;
            this.colCAPhoneno.Width = 80;
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
            this.colCBankACNo.Width = 80;
            // 
            // colCBankAddress
            // 
            this.colCBankAddress.FieldName = "CBankAddress";
            this.colCBankAddress.MinWidth = 80;
            this.colCBankAddress.Name = "colCBankAddress";
            this.colCBankAddress.Visible = true;
            this.colCBankAddress.VisibleIndex = 38;
            this.colCBankAddress.Width = 80;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.MinWidth = 80;
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 39;
            this.colCreatedDate.Width = 80;
            // 
            // colCAStartDate
            // 
            this.colCAStartDate.FieldName = "CAStartDate";
            this.colCAStartDate.MinWidth = 80;
            this.colCAStartDate.Name = "colCAStartDate";
            this.colCAStartDate.Visible = true;
            this.colCAStartDate.VisibleIndex = 40;
            this.colCAStartDate.Width = 80;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.ExitBtn);
            this.panelControl7.Controls.Add(this.ClearBtn);
            this.panelControl7.Controls.Add(this.btnDelete);
            this.panelControl7.Controls.Add(this.btnUpdate);
            this.panelControl7.Controls.Add(this.btnEdit);
            this.panelControl7.Controls.Add(this.btnAdd);
            this.panelControl7.Controls.Add(this.BtnNew);
            this.panelControl7.Location = new System.Drawing.Point(1645, 120);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(113, 307);
            this.panelControl7.TabIndex = 4;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Appearance.Options.UseFont = true;
            this.ExitBtn.Location = new System.Drawing.Point(18, 265);
            this.ExitBtn.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.ExitBtn.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.ExitBtn.LookAndFeel.SkinName = "DevExpress Style";
            this.ExitBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(81, 23);
            this.ExitBtn.TabIndex = 59;
            this.ExitBtn.Text = "EXIT";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Appearance.Options.UseFont = true;
            this.ClearBtn.Enabled = false;
            this.ClearBtn.Location = new System.Drawing.Point(18, 217);
            this.ClearBtn.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.ClearBtn.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.ClearBtn.LookAndFeel.SkinName = "DevExpress Style";
            this.ClearBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(81, 23);
            this.ClearBtn.TabIndex = 58;
            this.ClearBtn.Text = "CLEAR";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(18, 176);
            this.btnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(18, 135);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "UPDATE";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(18, 89);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 23);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "EDIT";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(18, 44);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "ADD";
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNew.AppearanceDisabled.BackColor2 = System.Drawing.Color.LightBlue;
            this.BtnNew.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnNew.Location = new System.Drawing.Point(18, 5);
            this.BtnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.BtnNew.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.BtnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.BtnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(81, 23);
            this.BtnNew.TabIndex = 53;
            this.BtnNew.Text = "NEW";
            this.BtnNew.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1784, 72);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(782, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 29);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Company Profile";
            // 
            // FrmCompanyProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1818, 736);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCompanyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompanyProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCompanyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.SimpleButton ExitBtn;
        private DevExpress.XtraEditors.SimpleButton ClearBtn;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colComCcode;
        private DevExpress.XtraGrid.Columns.GridColumn colComName;
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}