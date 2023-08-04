
namespace BillPlex
{
    partial class FrmSubClientCompanyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubClientCompanyProfile));
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SubClientGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubComCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubComName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComOffAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComNature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComDatestart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComStdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPfType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPfNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPfDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComEsiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComEsiDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComFactoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComCstNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComSslNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComTinNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComLicenseno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComPanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComTanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorFathername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorBlood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorDOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorPin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorPan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubClientGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetSubClientCompanyProfileInfo";
            storedProcQuery1.StoredProcName = "PRO_GetSubClientCompanyProfileInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1542, 724);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Location = new System.Drawing.Point(5, 83);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1532, 636);
            this.panelControl3.TabIndex = 3;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.Exitbtn);
            this.panelControl5.Controls.Add(this.Clearbtn);
            this.panelControl5.Controls.Add(this.Deletebtn);
            this.panelControl5.Controls.Add(this.Updatebtn);
            this.panelControl5.Controls.Add(this.Editbtn);
            this.panelControl5.Controls.Add(this.Addbtn);
            this.panelControl5.Controls.Add(this.Newbtn);
            this.panelControl5.Location = new System.Drawing.Point(1404, 143);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(98, 281);
            this.panelControl5.TabIndex = 2;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Exitbtn.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // Clearbtn
            // 
            this.Clearbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Clearbtn.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Deletebtn.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Appearance.Options.UseBackColor = true;
            this.Deletebtn.Appearance.Options.UseFont = true;
            this.Deletebtn.Location = new System.Drawing.Point(12, 168);
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
            this.Updatebtn.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Editbtn.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Addbtn.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Newbtn.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetSubClientCompanyProfileInfo";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.SubClientGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1383, 626);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubClientGrid});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btn_EditClick);
            // 
            // SubClientGrid
            // 
            this.SubClientGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMasterCompany,
            this.colClientCompany,
            this.colMasterCompanyId,
            this.colClientCompanyId,
            this.colSubComCode,
            this.colSubComName,
            this.colComOffAdd,
            this.colComState,
            this.colComPin,
            this.colComNature,
            this.colDirector,
            this.colComDatestart,
            this.colComStdCode,
            this.colComPhone,
            this.colComEmail,
            this.colComWebsite,
            this.colPfType,
            this.colComPfNo,
            this.colComPfDate,
            this.colComEsiNo,
            this.colComEsiDate,
            this.colComFactoryNo,
            this.colComCstNo,
            this.colComSslNo,
            this.colComTinNo,
            this.colComLicenseno,
            this.colComPanNo,
            this.colComTanNo,
            this.colAuthorName,
            this.colAuthorFathername,
            this.colAuthorGender,
            this.colAuthorBlood,
            this.colAuthorDOB,
            this.colAuthorEmail,
            this.colAuthorAddress,
            this.colAuthorState,
            this.colAuthorPin,
            this.colAuthorMobile,
            this.colAuthorPan,
            this.colAuthorPercent,
            this.colAuthorActive});
            this.SubClientGrid.GridControl = this.gridControl1;
            this.SubClientGrid.Name = "SubClientGrid";
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
            // colMasterCompany
            // 
            this.colMasterCompany.FieldName = "MasterCompany";
            this.colMasterCompany.MinWidth = 80;
            this.colMasterCompany.Name = "colMasterCompany";
            this.colMasterCompany.Visible = true;
            this.colMasterCompany.VisibleIndex = 1;
            this.colMasterCompany.Width = 80;
            // 
            // colClientCompany
            // 
            this.colClientCompany.FieldName = "ClientCompany";
            this.colClientCompany.MinWidth = 80;
            this.colClientCompany.Name = "colClientCompany";
            this.colClientCompany.Visible = true;
            this.colClientCompany.VisibleIndex = 2;
            this.colClientCompany.Width = 80;
            // 
            // colMasterCompanyId
            // 
            this.colMasterCompanyId.FieldName = "MasterCompanyId";
            this.colMasterCompanyId.MinWidth = 80;
            this.colMasterCompanyId.Name = "colMasterCompanyId";
            this.colMasterCompanyId.Width = 80;
            // 
            // colClientCompanyId
            // 
            this.colClientCompanyId.FieldName = "ClientCompanyId";
            this.colClientCompanyId.MinWidth = 80;
            this.colClientCompanyId.Name = "colClientCompanyId";
            this.colClientCompanyId.Width = 80;
            // 
            // colSubComCode
            // 
            this.colSubComCode.FieldName = "SubComCode";
            this.colSubComCode.MinWidth = 80;
            this.colSubComCode.Name = "colSubComCode";
            this.colSubComCode.Visible = true;
            this.colSubComCode.VisibleIndex = 3;
            this.colSubComCode.Width = 80;
            // 
            // colSubComName
            // 
            this.colSubComName.FieldName = "SubComName";
            this.colSubComName.MinWidth = 80;
            this.colSubComName.Name = "colSubComName";
            this.colSubComName.Visible = true;
            this.colSubComName.VisibleIndex = 4;
            this.colSubComName.Width = 80;
            // 
            // colComOffAdd
            // 
            this.colComOffAdd.FieldName = "ComOffAdd";
            this.colComOffAdd.MinWidth = 80;
            this.colComOffAdd.Name = "colComOffAdd";
            this.colComOffAdd.Visible = true;
            this.colComOffAdd.VisibleIndex = 5;
            this.colComOffAdd.Width = 80;
            // 
            // colComState
            // 
            this.colComState.FieldName = "ComState";
            this.colComState.MinWidth = 80;
            this.colComState.Name = "colComState";
            this.colComState.Visible = true;
            this.colComState.VisibleIndex = 6;
            this.colComState.Width = 80;
            // 
            // colComPin
            // 
            this.colComPin.FieldName = "ComPin";
            this.colComPin.MinWidth = 80;
            this.colComPin.Name = "colComPin";
            this.colComPin.Visible = true;
            this.colComPin.VisibleIndex = 7;
            this.colComPin.Width = 80;
            // 
            // colComNature
            // 
            this.colComNature.FieldName = "ComNature";
            this.colComNature.MinWidth = 80;
            this.colComNature.Name = "colComNature";
            this.colComNature.Visible = true;
            this.colComNature.VisibleIndex = 8;
            this.colComNature.Width = 80;
            // 
            // colDirector
            // 
            this.colDirector.FieldName = "Director";
            this.colDirector.MinWidth = 80;
            this.colDirector.Name = "colDirector";
            this.colDirector.Width = 80;
            // 
            // colComDatestart
            // 
            this.colComDatestart.FieldName = "ComDatestart";
            this.colComDatestart.MinWidth = 80;
            this.colComDatestart.Name = "colComDatestart";
            this.colComDatestart.Visible = true;
            this.colComDatestart.VisibleIndex = 9;
            this.colComDatestart.Width = 80;
            // 
            // colComStdCode
            // 
            this.colComStdCode.FieldName = "ComStdCode";
            this.colComStdCode.MinWidth = 80;
            this.colComStdCode.Name = "colComStdCode";
            this.colComStdCode.Visible = true;
            this.colComStdCode.VisibleIndex = 10;
            this.colComStdCode.Width = 80;
            // 
            // colComPhone
            // 
            this.colComPhone.FieldName = "ComPhone";
            this.colComPhone.MinWidth = 80;
            this.colComPhone.Name = "colComPhone";
            this.colComPhone.Visible = true;
            this.colComPhone.VisibleIndex = 11;
            this.colComPhone.Width = 1000;
            // 
            // colComEmail
            // 
            this.colComEmail.FieldName = "ComEmail";
            this.colComEmail.MinWidth = 80;
            this.colComEmail.Name = "colComEmail";
            this.colComEmail.Visible = true;
            this.colComEmail.VisibleIndex = 12;
            this.colComEmail.Width = 80;
            // 
            // colComWebsite
            // 
            this.colComWebsite.FieldName = "ComWebsite";
            this.colComWebsite.MinWidth = 80;
            this.colComWebsite.Name = "colComWebsite";
            this.colComWebsite.Visible = true;
            this.colComWebsite.VisibleIndex = 13;
            this.colComWebsite.Width = 80;
            // 
            // colPfType
            // 
            this.colPfType.FieldName = "PfType";
            this.colPfType.MinWidth = 80;
            this.colPfType.Name = "colPfType";
            this.colPfType.Visible = true;
            this.colPfType.VisibleIndex = 14;
            this.colPfType.Width = 80;
            // 
            // colComPfNo
            // 
            this.colComPfNo.FieldName = "ComPfNo";
            this.colComPfNo.MinWidth = 80;
            this.colComPfNo.Name = "colComPfNo";
            this.colComPfNo.Visible = true;
            this.colComPfNo.VisibleIndex = 15;
            this.colComPfNo.Width = 80;
            // 
            // colComPfDate
            // 
            this.colComPfDate.FieldName = "ComPfDate";
            this.colComPfDate.MinWidth = 80;
            this.colComPfDate.Name = "colComPfDate";
            this.colComPfDate.Visible = true;
            this.colComPfDate.VisibleIndex = 16;
            this.colComPfDate.Width = 80;
            // 
            // colComEsiNo
            // 
            this.colComEsiNo.FieldName = "ComEsiNo";
            this.colComEsiNo.MinWidth = 80;
            this.colComEsiNo.Name = "colComEsiNo";
            this.colComEsiNo.Visible = true;
            this.colComEsiNo.VisibleIndex = 17;
            this.colComEsiNo.Width = 80;
            // 
            // colComEsiDate
            // 
            this.colComEsiDate.FieldName = "ComEsiDate";
            this.colComEsiDate.MinWidth = 80;
            this.colComEsiDate.Name = "colComEsiDate";
            this.colComEsiDate.Visible = true;
            this.colComEsiDate.VisibleIndex = 18;
            this.colComEsiDate.Width = 80;
            // 
            // colComFactoryNo
            // 
            this.colComFactoryNo.FieldName = "ComFactoryNo";
            this.colComFactoryNo.MinWidth = 80;
            this.colComFactoryNo.Name = "colComFactoryNo";
            this.colComFactoryNo.Visible = true;
            this.colComFactoryNo.VisibleIndex = 19;
            this.colComFactoryNo.Width = 80;
            // 
            // colComCstNo
            // 
            this.colComCstNo.FieldName = "ComCstNo";
            this.colComCstNo.MinWidth = 80;
            this.colComCstNo.Name = "colComCstNo";
            this.colComCstNo.Visible = true;
            this.colComCstNo.VisibleIndex = 20;
            this.colComCstNo.Width = 80;
            // 
            // colComSslNo
            // 
            this.colComSslNo.FieldName = "ComSslNo";
            this.colComSslNo.MinWidth = 80;
            this.colComSslNo.Name = "colComSslNo";
            this.colComSslNo.Visible = true;
            this.colComSslNo.VisibleIndex = 21;
            this.colComSslNo.Width = 80;
            // 
            // colComTinNo
            // 
            this.colComTinNo.FieldName = "ComTinNo";
            this.colComTinNo.MinWidth = 80;
            this.colComTinNo.Name = "colComTinNo";
            this.colComTinNo.Visible = true;
            this.colComTinNo.VisibleIndex = 22;
            this.colComTinNo.Width = 80;
            // 
            // colComLicenseno
            // 
            this.colComLicenseno.FieldName = "ComLicenseno";
            this.colComLicenseno.MinWidth = 80;
            this.colComLicenseno.Name = "colComLicenseno";
            this.colComLicenseno.Visible = true;
            this.colComLicenseno.VisibleIndex = 23;
            this.colComLicenseno.Width = 80;
            // 
            // colComPanNo
            // 
            this.colComPanNo.FieldName = "ComPanNo";
            this.colComPanNo.MinWidth = 80;
            this.colComPanNo.Name = "colComPanNo";
            this.colComPanNo.Visible = true;
            this.colComPanNo.VisibleIndex = 24;
            this.colComPanNo.Width = 80;
            // 
            // colComTanNo
            // 
            this.colComTanNo.FieldName = "ComTanNo";
            this.colComTanNo.MinWidth = 80;
            this.colComTanNo.Name = "colComTanNo";
            this.colComTanNo.Visible = true;
            this.colComTanNo.VisibleIndex = 25;
            this.colComTanNo.Width = 80;
            // 
            // colAuthorName
            // 
            this.colAuthorName.FieldName = "AuthorName";
            this.colAuthorName.MinWidth = 80;
            this.colAuthorName.Name = "colAuthorName";
            this.colAuthorName.Visible = true;
            this.colAuthorName.VisibleIndex = 26;
            this.colAuthorName.Width = 80;
            // 
            // colAuthorFathername
            // 
            this.colAuthorFathername.FieldName = "AuthorFathername";
            this.colAuthorFathername.MinWidth = 80;
            this.colAuthorFathername.Name = "colAuthorFathername";
            this.colAuthorFathername.Visible = true;
            this.colAuthorFathername.VisibleIndex = 27;
            this.colAuthorFathername.Width = 80;
            // 
            // colAuthorGender
            // 
            this.colAuthorGender.FieldName = "AuthorGender";
            this.colAuthorGender.MinWidth = 80;
            this.colAuthorGender.Name = "colAuthorGender";
            this.colAuthorGender.Visible = true;
            this.colAuthorGender.VisibleIndex = 28;
            this.colAuthorGender.Width = 80;
            // 
            // colAuthorBlood
            // 
            this.colAuthorBlood.FieldName = "AuthorBlood";
            this.colAuthorBlood.MinWidth = 80;
            this.colAuthorBlood.Name = "colAuthorBlood";
            this.colAuthorBlood.Visible = true;
            this.colAuthorBlood.VisibleIndex = 29;
            this.colAuthorBlood.Width = 80;
            // 
            // colAuthorDOB
            // 
            this.colAuthorDOB.FieldName = "AuthorDOB";
            this.colAuthorDOB.MinWidth = 80;
            this.colAuthorDOB.Name = "colAuthorDOB";
            this.colAuthorDOB.Visible = true;
            this.colAuthorDOB.VisibleIndex = 30;
            this.colAuthorDOB.Width = 80;
            // 
            // colAuthorEmail
            // 
            this.colAuthorEmail.FieldName = "AuthorEmail";
            this.colAuthorEmail.MinWidth = 80;
            this.colAuthorEmail.Name = "colAuthorEmail";
            this.colAuthorEmail.Visible = true;
            this.colAuthorEmail.VisibleIndex = 31;
            this.colAuthorEmail.Width = 80;
            // 
            // colAuthorAddress
            // 
            this.colAuthorAddress.FieldName = "AuthorAddress";
            this.colAuthorAddress.MinWidth = 80;
            this.colAuthorAddress.Name = "colAuthorAddress";
            this.colAuthorAddress.Visible = true;
            this.colAuthorAddress.VisibleIndex = 32;
            this.colAuthorAddress.Width = 80;
            // 
            // colAuthorState
            // 
            this.colAuthorState.FieldName = "AuthorState";
            this.colAuthorState.MinWidth = 80;
            this.colAuthorState.Name = "colAuthorState";
            this.colAuthorState.Visible = true;
            this.colAuthorState.VisibleIndex = 33;
            this.colAuthorState.Width = 80;
            // 
            // colAuthorPin
            // 
            this.colAuthorPin.FieldName = "AuthorPin";
            this.colAuthorPin.MinWidth = 80;
            this.colAuthorPin.Name = "colAuthorPin";
            this.colAuthorPin.Visible = true;
            this.colAuthorPin.VisibleIndex = 34;
            this.colAuthorPin.Width = 80;
            // 
            // colAuthorMobile
            // 
            this.colAuthorMobile.FieldName = "AuthorMobile";
            this.colAuthorMobile.MinWidth = 80;
            this.colAuthorMobile.Name = "colAuthorMobile";
            this.colAuthorMobile.Visible = true;
            this.colAuthorMobile.VisibleIndex = 35;
            this.colAuthorMobile.Width = 80;
            // 
            // colAuthorPan
            // 
            this.colAuthorPan.FieldName = "AuthorPan";
            this.colAuthorPan.MinWidth = 80;
            this.colAuthorPan.Name = "colAuthorPan";
            this.colAuthorPan.Visible = true;
            this.colAuthorPan.VisibleIndex = 36;
            this.colAuthorPan.Width = 80;
            // 
            // colAuthorPercent
            // 
            this.colAuthorPercent.FieldName = "AuthorPercent";
            this.colAuthorPercent.MinWidth = 80;
            this.colAuthorPercent.Name = "colAuthorPercent";
            this.colAuthorPercent.Visible = true;
            this.colAuthorPercent.VisibleIndex = 37;
            this.colAuthorPercent.Width = 80;
            // 
            // colAuthorActive
            // 
            this.colAuthorActive.FieldName = "AuthorActive";
            this.colAuthorActive.MinWidth = 80;
            this.colAuthorActive.Name = "colAuthorActive";
            this.colAuthorActive.Visible = true;
            this.colAuthorActive.VisibleIndex = 38;
            this.colAuthorActive.Width = 80;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1532, 72);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(584, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(364, 29);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Sub Client Company Profile";
            // 
            // FrmSubClientCompanyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1567, 749);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSubClientCompanyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSubClientCompanyProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSubClientCompanyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubClientGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView SubClientGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubComCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubComName;
        private DevExpress.XtraGrid.Columns.GridColumn colComOffAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colComState;
        private DevExpress.XtraGrid.Columns.GridColumn colComPin;
        private DevExpress.XtraGrid.Columns.GridColumn colComNature;
        private DevExpress.XtraGrid.Columns.GridColumn colDirector;
        private DevExpress.XtraGrid.Columns.GridColumn colComDatestart;
        private DevExpress.XtraGrid.Columns.GridColumn colComStdCode;
        private DevExpress.XtraGrid.Columns.GridColumn colComPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colComEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colComWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colPfType;
        private DevExpress.XtraGrid.Columns.GridColumn colComPfNo;
        private DevExpress.XtraGrid.Columns.GridColumn colComPfDate;
        private DevExpress.XtraGrid.Columns.GridColumn colComEsiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colComEsiDate;
        private DevExpress.XtraGrid.Columns.GridColumn colComFactoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colComCstNo;
        private DevExpress.XtraGrid.Columns.GridColumn colComSslNo;
        private DevExpress.XtraGrid.Columns.GridColumn colComTinNo;
        private DevExpress.XtraGrid.Columns.GridColumn colComLicenseno;
        private DevExpress.XtraGrid.Columns.GridColumn colComPanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colComTanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorName;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorFathername;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorGender;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorBlood;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorDOB;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorState;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorPin;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorPan;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorActive;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton Exitbtn;
        private DevExpress.XtraEditors.SimpleButton Clearbtn;
        private DevExpress.XtraEditors.SimpleButton Deletebtn;
        private DevExpress.XtraEditors.SimpleButton Updatebtn;
        private DevExpress.XtraEditors.SimpleButton Editbtn;
        private DevExpress.XtraEditors.SimpleButton Addbtn;
        private DevExpress.XtraEditors.SimpleButton Newbtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}