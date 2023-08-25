
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
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
            storedProcQuery2.Name = "PRO_GetSubClientCompanyProfileInfo";
            storedProcQuery2.StoredProcName = "PRO_GetSubClientCompanyProfileInfo";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
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
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.SubClientGrid.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.SubClientGrid.Name = "SubClientGrid";
            this.SubClientGrid.OptionsView.ColumnAutoWidth = false;
            this.SubClientGrid.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colMasterCompany
            // 
            this.colMasterCompany.FieldName = "MasterCompany";
            this.colMasterCompany.Name = "colMasterCompany";
            this.colMasterCompany.Visible = true;
            this.colMasterCompany.VisibleIndex = 0;
            // 
            // colClientCompany
            // 
            this.colClientCompany.FieldName = "ClientCompany";
            this.colClientCompany.Name = "colClientCompany";
            this.colClientCompany.Visible = true;
            this.colClientCompany.VisibleIndex = 1;
            // 
            // colMasterCompanyId
            // 
            this.colMasterCompanyId.FieldName = "MasterCompanyId";
            this.colMasterCompanyId.Name = "colMasterCompanyId";
            // 
            // colClientCompanyId
            // 
            this.colClientCompanyId.FieldName = "ClientCompanyId";
            this.colClientCompanyId.Name = "colClientCompanyId";
            // 
            // colSubComCode
            // 
            this.colSubComCode.FieldName = "SubComCode";
            this.colSubComCode.Name = "colSubComCode";
            this.colSubComCode.Visible = true;
            this.colSubComCode.VisibleIndex = 2;
            // 
            // colSubComName
            // 
            this.colSubComName.FieldName = "SubComName";
            this.colSubComName.Name = "colSubComName";
            this.colSubComName.Visible = true;
            this.colSubComName.VisibleIndex = 3;
            // 
            // colComOffAdd
            // 
            this.colComOffAdd.FieldName = "ComOffAdd";
            this.colComOffAdd.Name = "colComOffAdd";
            this.colComOffAdd.Visible = true;
            this.colComOffAdd.VisibleIndex = 4;
            // 
            // colComState
            // 
            this.colComState.FieldName = "ComState";
            this.colComState.Name = "colComState";
            this.colComState.Visible = true;
            this.colComState.VisibleIndex = 5;
            // 
            // colComPin
            // 
            this.colComPin.FieldName = "ComPin";
            this.colComPin.Name = "colComPin";
            this.colComPin.Visible = true;
            this.colComPin.VisibleIndex = 6;
            // 
            // colComNature
            // 
            this.colComNature.FieldName = "ComNature";
            this.colComNature.Name = "colComNature";
            this.colComNature.Visible = true;
            this.colComNature.VisibleIndex = 7;
            // 
            // colDirector
            // 
            this.colDirector.FieldName = "Director";
            this.colDirector.Name = "colDirector";
            this.colDirector.Visible = true;
            this.colDirector.VisibleIndex = 8;
            // 
            // colComDatestart
            // 
            this.colComDatestart.FieldName = "ComDatestart";
            this.colComDatestart.Name = "colComDatestart";
            this.colComDatestart.Visible = true;
            this.colComDatestart.VisibleIndex = 9;
            // 
            // colComStdCode
            // 
            this.colComStdCode.FieldName = "ComStdCode";
            this.colComStdCode.Name = "colComStdCode";
            this.colComStdCode.Visible = true;
            this.colComStdCode.VisibleIndex = 10;
            // 
            // colComPhone
            // 
            this.colComPhone.FieldName = "ComPhone";
            this.colComPhone.Name = "colComPhone";
            this.colComPhone.Visible = true;
            this.colComPhone.VisibleIndex = 11;
            // 
            // colComEmail
            // 
            this.colComEmail.FieldName = "ComEmail";
            this.colComEmail.Name = "colComEmail";
            this.colComEmail.Visible = true;
            this.colComEmail.VisibleIndex = 12;
            // 
            // colComWebsite
            // 
            this.colComWebsite.FieldName = "ComWebsite";
            this.colComWebsite.Name = "colComWebsite";
            this.colComWebsite.Visible = true;
            this.colComWebsite.VisibleIndex = 13;
            // 
            // colPfType
            // 
            this.colPfType.FieldName = "PfType";
            this.colPfType.Name = "colPfType";
            this.colPfType.Visible = true;
            this.colPfType.VisibleIndex = 14;
            // 
            // colComPfNo
            // 
            this.colComPfNo.FieldName = "ComPfNo";
            this.colComPfNo.Name = "colComPfNo";
            this.colComPfNo.Visible = true;
            this.colComPfNo.VisibleIndex = 15;
            // 
            // colComPfDate
            // 
            this.colComPfDate.FieldName = "ComPfDate";
            this.colComPfDate.Name = "colComPfDate";
            this.colComPfDate.Visible = true;
            this.colComPfDate.VisibleIndex = 16;
            // 
            // colComEsiNo
            // 
            this.colComEsiNo.FieldName = "ComEsiNo";
            this.colComEsiNo.Name = "colComEsiNo";
            this.colComEsiNo.Visible = true;
            this.colComEsiNo.VisibleIndex = 17;
            // 
            // colComEsiDate
            // 
            this.colComEsiDate.FieldName = "ComEsiDate";
            this.colComEsiDate.Name = "colComEsiDate";
            this.colComEsiDate.Visible = true;
            this.colComEsiDate.VisibleIndex = 18;
            // 
            // colComFactoryNo
            // 
            this.colComFactoryNo.FieldName = "ComFactoryNo";
            this.colComFactoryNo.Name = "colComFactoryNo";
            this.colComFactoryNo.Visible = true;
            this.colComFactoryNo.VisibleIndex = 19;
            // 
            // colComCstNo
            // 
            this.colComCstNo.FieldName = "ComCstNo";
            this.colComCstNo.Name = "colComCstNo";
            this.colComCstNo.Visible = true;
            this.colComCstNo.VisibleIndex = 20;
            // 
            // colComSslNo
            // 
            this.colComSslNo.FieldName = "ComSslNo";
            this.colComSslNo.Name = "colComSslNo";
            this.colComSslNo.Visible = true;
            this.colComSslNo.VisibleIndex = 21;
            // 
            // colComTinNo
            // 
            this.colComTinNo.FieldName = "ComTinNo";
            this.colComTinNo.Name = "colComTinNo";
            this.colComTinNo.Visible = true;
            this.colComTinNo.VisibleIndex = 22;
            // 
            // colComLicenseno
            // 
            this.colComLicenseno.FieldName = "ComLicenseno";
            this.colComLicenseno.Name = "colComLicenseno";
            this.colComLicenseno.Visible = true;
            this.colComLicenseno.VisibleIndex = 23;
            // 
            // colComPanNo
            // 
            this.colComPanNo.FieldName = "ComPanNo";
            this.colComPanNo.Name = "colComPanNo";
            this.colComPanNo.Visible = true;
            this.colComPanNo.VisibleIndex = 24;
            // 
            // colComTanNo
            // 
            this.colComTanNo.FieldName = "ComTanNo";
            this.colComTanNo.Name = "colComTanNo";
            this.colComTanNo.Visible = true;
            this.colComTanNo.VisibleIndex = 25;
            // 
            // colAuthorName
            // 
            this.colAuthorName.FieldName = "AuthorName";
            this.colAuthorName.Name = "colAuthorName";
            this.colAuthorName.Visible = true;
            this.colAuthorName.VisibleIndex = 26;
            // 
            // colAuthorFathername
            // 
            this.colAuthorFathername.FieldName = "AuthorFathername";
            this.colAuthorFathername.Name = "colAuthorFathername";
            this.colAuthorFathername.Visible = true;
            this.colAuthorFathername.VisibleIndex = 27;
            // 
            // colAuthorGender
            // 
            this.colAuthorGender.FieldName = "AuthorGender";
            this.colAuthorGender.Name = "colAuthorGender";
            this.colAuthorGender.Visible = true;
            this.colAuthorGender.VisibleIndex = 28;
            // 
            // colAuthorBlood
            // 
            this.colAuthorBlood.FieldName = "AuthorBlood";
            this.colAuthorBlood.Name = "colAuthorBlood";
            this.colAuthorBlood.Visible = true;
            this.colAuthorBlood.VisibleIndex = 29;
            // 
            // colAuthorDOB
            // 
            this.colAuthorDOB.FieldName = "AuthorDOB";
            this.colAuthorDOB.Name = "colAuthorDOB";
            this.colAuthorDOB.Visible = true;
            this.colAuthorDOB.VisibleIndex = 30;
            // 
            // colAuthorEmail
            // 
            this.colAuthorEmail.FieldName = "AuthorEmail";
            this.colAuthorEmail.Name = "colAuthorEmail";
            this.colAuthorEmail.Visible = true;
            this.colAuthorEmail.VisibleIndex = 31;
            // 
            // colAuthorAddress
            // 
            this.colAuthorAddress.FieldName = "AuthorAddress";
            this.colAuthorAddress.Name = "colAuthorAddress";
            this.colAuthorAddress.Visible = true;
            this.colAuthorAddress.VisibleIndex = 32;
            // 
            // colAuthorState
            // 
            this.colAuthorState.FieldName = "AuthorState";
            this.colAuthorState.Name = "colAuthorState";
            this.colAuthorState.Visible = true;
            this.colAuthorState.VisibleIndex = 33;
            // 
            // colAuthorPin
            // 
            this.colAuthorPin.FieldName = "AuthorPin";
            this.colAuthorPin.Name = "colAuthorPin";
            this.colAuthorPin.Visible = true;
            this.colAuthorPin.VisibleIndex = 34;
            // 
            // colAuthorMobile
            // 
            this.colAuthorMobile.FieldName = "AuthorMobile";
            this.colAuthorMobile.Name = "colAuthorMobile";
            this.colAuthorMobile.Visible = true;
            this.colAuthorMobile.VisibleIndex = 35;
            // 
            // colAuthorPan
            // 
            this.colAuthorPan.FieldName = "AuthorPan";
            this.colAuthorPan.Name = "colAuthorPan";
            this.colAuthorPan.Visible = true;
            this.colAuthorPan.VisibleIndex = 36;
            // 
            // colAuthorPercent
            // 
            this.colAuthorPercent.FieldName = "AuthorPercent";
            this.colAuthorPercent.Name = "colAuthorPercent";
            this.colAuthorPercent.Visible = true;
            this.colAuthorPercent.VisibleIndex = 37;
            // 
            // colAuthorActive
            // 
            this.colAuthorActive.FieldName = "AuthorActive";
            this.colAuthorActive.Name = "colAuthorActive";
            this.colAuthorActive.Visible = true;
            this.colAuthorActive.VisibleIndex = 38;
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
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton Exitbtn;
        private DevExpress.XtraEditors.SimpleButton Clearbtn;
        private DevExpress.XtraEditors.SimpleButton Deletebtn;
        private DevExpress.XtraEditors.SimpleButton Updatebtn;
        private DevExpress.XtraEditors.SimpleButton Editbtn;
        private DevExpress.XtraEditors.SimpleButton Addbtn;
        private DevExpress.XtraEditors.SimpleButton Newbtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
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
    }
}