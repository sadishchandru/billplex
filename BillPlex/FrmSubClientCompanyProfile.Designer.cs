
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.Exitbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Clearbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Deletebtn = new DevExpress.XtraEditors.SimpleButton();
            this.Updatebtn = new DevExpress.XtraEditors.SimpleButton();
            this.Editbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Addbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Newbtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.SubClientGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.Claerbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Findbtn = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubClientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1576, 72);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(634, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(248, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sub Client Company Profile";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Location = new System.Drawing.Point(3, 80);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1576, 658);
            this.panelControl2.TabIndex = 1;
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
            this.panelControl5.Location = new System.Drawing.Point(1456, 110);
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
            this.Editbtn.Click += new System.EventHandler(this.btn_EditClick);
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
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Location = new System.Drawing.Point(5, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1429, 648);
            this.panelControl3.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl4.Controls.Add(this.gridControl1);
            this.panelControl4.Controls.Add(this.Claerbtn);
            this.panelControl4.Controls.Add(this.Findbtn);
            this.panelControl4.Controls.Add(this.dropDownButton1);
            this.panelControl4.Location = new System.Drawing.Point(6, 6);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1423, 621);
            this.panelControl4.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetSubClientCompanyProfileInfo";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(23, 123);
            this.gridControl1.MainView = this.SubClientGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1395, 493);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubClientGrid});
            this.gridControl1.Click += new System.EventHandler(this.btn_EditClick);
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
            // SubClientGrid
            // 
            this.SubClientGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
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
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colMasterCompanyId
            // 
            this.colMasterCompanyId.FieldName = "MasterCompanyId";
            this.colMasterCompanyId.Name = "colMasterCompanyId";
            this.colMasterCompanyId.Visible = true;
            this.colMasterCompanyId.VisibleIndex = 1;
            // 
            // colClientCompanyId
            // 
            this.colClientCompanyId.FieldName = "ClientCompanyId";
            this.colClientCompanyId.Name = "colClientCompanyId";
            this.colClientCompanyId.Visible = true;
            this.colClientCompanyId.VisibleIndex = 2;
            // 
            // colSubComCode
            // 
            this.colSubComCode.FieldName = "SubComCode";
            this.colSubComCode.Name = "colSubComCode";
            this.colSubComCode.Visible = true;
            this.colSubComCode.VisibleIndex = 3;
            // 
            // colSubComName
            // 
            this.colSubComName.FieldName = "SubComName";
            this.colSubComName.Name = "colSubComName";
            this.colSubComName.Visible = true;
            this.colSubComName.VisibleIndex = 4;
            // 
            // colComOffAdd
            // 
            this.colComOffAdd.FieldName = "ComOffAdd";
            this.colComOffAdd.Name = "colComOffAdd";
            this.colComOffAdd.Visible = true;
            this.colComOffAdd.VisibleIndex = 5;
            // 
            // colComState
            // 
            this.colComState.FieldName = "ComState";
            this.colComState.Name = "colComState";
            this.colComState.Visible = true;
            this.colComState.VisibleIndex = 6;
            // 
            // colComPin
            // 
            this.colComPin.FieldName = "ComPin";
            this.colComPin.Name = "colComPin";
            this.colComPin.Visible = true;
            this.colComPin.VisibleIndex = 7;
            // 
            // colComNature
            // 
            this.colComNature.FieldName = "ComNature";
            this.colComNature.Name = "colComNature";
            this.colComNature.Visible = true;
            this.colComNature.VisibleIndex = 8;
            // 
            // colDirector
            // 
            this.colDirector.FieldName = "Director";
            this.colDirector.Name = "colDirector";
            this.colDirector.Visible = true;
            this.colDirector.VisibleIndex = 9;
            // 
            // colComDatestart
            // 
            this.colComDatestart.FieldName = "ComDatestart";
            this.colComDatestart.Name = "colComDatestart";
            this.colComDatestart.Visible = true;
            this.colComDatestart.VisibleIndex = 10;
            // 
            // colComStdCode
            // 
            this.colComStdCode.FieldName = "ComStdCode";
            this.colComStdCode.Name = "colComStdCode";
            this.colComStdCode.Visible = true;
            this.colComStdCode.VisibleIndex = 11;
            // 
            // colComPhone
            // 
            this.colComPhone.FieldName = "ComPhone";
            this.colComPhone.Name = "colComPhone";
            this.colComPhone.Visible = true;
            this.colComPhone.VisibleIndex = 12;
            // 
            // colComEmail
            // 
            this.colComEmail.FieldName = "ComEmail";
            this.colComEmail.Name = "colComEmail";
            this.colComEmail.Visible = true;
            this.colComEmail.VisibleIndex = 13;
            // 
            // colComWebsite
            // 
            this.colComWebsite.FieldName = "ComWebsite";
            this.colComWebsite.Name = "colComWebsite";
            this.colComWebsite.Visible = true;
            this.colComWebsite.VisibleIndex = 14;
            // 
            // colPfType
            // 
            this.colPfType.FieldName = "PfType";
            this.colPfType.Name = "colPfType";
            this.colPfType.Visible = true;
            this.colPfType.VisibleIndex = 15;
            // 
            // colComPfNo
            // 
            this.colComPfNo.FieldName = "ComPfNo";
            this.colComPfNo.Name = "colComPfNo";
            this.colComPfNo.Visible = true;
            this.colComPfNo.VisibleIndex = 16;
            // 
            // colComPfDate
            // 
            this.colComPfDate.FieldName = "ComPfDate";
            this.colComPfDate.Name = "colComPfDate";
            this.colComPfDate.Visible = true;
            this.colComPfDate.VisibleIndex = 17;
            // 
            // colComEsiNo
            // 
            this.colComEsiNo.FieldName = "ComEsiNo";
            this.colComEsiNo.Name = "colComEsiNo";
            this.colComEsiNo.Visible = true;
            this.colComEsiNo.VisibleIndex = 18;
            // 
            // colComEsiDate
            // 
            this.colComEsiDate.FieldName = "ComEsiDate";
            this.colComEsiDate.Name = "colComEsiDate";
            this.colComEsiDate.Visible = true;
            this.colComEsiDate.VisibleIndex = 19;
            // 
            // colComFactoryNo
            // 
            this.colComFactoryNo.FieldName = "ComFactoryNo";
            this.colComFactoryNo.Name = "colComFactoryNo";
            this.colComFactoryNo.Visible = true;
            this.colComFactoryNo.VisibleIndex = 20;
            // 
            // colComCstNo
            // 
            this.colComCstNo.FieldName = "ComCstNo";
            this.colComCstNo.Name = "colComCstNo";
            this.colComCstNo.Visible = true;
            this.colComCstNo.VisibleIndex = 21;
            // 
            // colComSslNo
            // 
            this.colComSslNo.FieldName = "ComSslNo";
            this.colComSslNo.Name = "colComSslNo";
            this.colComSslNo.Visible = true;
            this.colComSslNo.VisibleIndex = 22;
            // 
            // colComTinNo
            // 
            this.colComTinNo.FieldName = "ComTinNo";
            this.colComTinNo.Name = "colComTinNo";
            this.colComTinNo.Visible = true;
            this.colComTinNo.VisibleIndex = 23;
            // 
            // colComLicenseno
            // 
            this.colComLicenseno.FieldName = "ComLicenseno";
            this.colComLicenseno.Name = "colComLicenseno";
            this.colComLicenseno.Visible = true;
            this.colComLicenseno.VisibleIndex = 24;
            // 
            // colComPanNo
            // 
            this.colComPanNo.FieldName = "ComPanNo";
            this.colComPanNo.Name = "colComPanNo";
            this.colComPanNo.Visible = true;
            this.colComPanNo.VisibleIndex = 25;
            // 
            // colComTanNo
            // 
            this.colComTanNo.FieldName = "ComTanNo";
            this.colComTanNo.Name = "colComTanNo";
            this.colComTanNo.Visible = true;
            this.colComTanNo.VisibleIndex = 26;
            // 
            // colAuthorName
            // 
            this.colAuthorName.FieldName = "AuthorName";
            this.colAuthorName.Name = "colAuthorName";
            this.colAuthorName.Visible = true;
            this.colAuthorName.VisibleIndex = 27;
            // 
            // colAuthorFathername
            // 
            this.colAuthorFathername.FieldName = "AuthorFathername";
            this.colAuthorFathername.Name = "colAuthorFathername";
            this.colAuthorFathername.Visible = true;
            this.colAuthorFathername.VisibleIndex = 28;
            // 
            // colAuthorGender
            // 
            this.colAuthorGender.FieldName = "AuthorGender";
            this.colAuthorGender.Name = "colAuthorGender";
            this.colAuthorGender.Visible = true;
            this.colAuthorGender.VisibleIndex = 29;
            // 
            // colAuthorBlood
            // 
            this.colAuthorBlood.FieldName = "AuthorBlood";
            this.colAuthorBlood.Name = "colAuthorBlood";
            this.colAuthorBlood.Visible = true;
            this.colAuthorBlood.VisibleIndex = 30;
            // 
            // colAuthorDOB
            // 
            this.colAuthorDOB.FieldName = "AuthorDOB";
            this.colAuthorDOB.Name = "colAuthorDOB";
            this.colAuthorDOB.Visible = true;
            this.colAuthorDOB.VisibleIndex = 31;
            // 
            // colAuthorEmail
            // 
            this.colAuthorEmail.FieldName = "AuthorEmail";
            this.colAuthorEmail.Name = "colAuthorEmail";
            this.colAuthorEmail.Visible = true;
            this.colAuthorEmail.VisibleIndex = 32;
            // 
            // colAuthorAddress
            // 
            this.colAuthorAddress.FieldName = "AuthorAddress";
            this.colAuthorAddress.Name = "colAuthorAddress";
            this.colAuthorAddress.Visible = true;
            this.colAuthorAddress.VisibleIndex = 33;
            // 
            // colAuthorState
            // 
            this.colAuthorState.FieldName = "AuthorState";
            this.colAuthorState.Name = "colAuthorState";
            this.colAuthorState.Visible = true;
            this.colAuthorState.VisibleIndex = 34;
            // 
            // colAuthorPin
            // 
            this.colAuthorPin.FieldName = "AuthorPin";
            this.colAuthorPin.Name = "colAuthorPin";
            this.colAuthorPin.Visible = true;
            this.colAuthorPin.VisibleIndex = 35;
            // 
            // colAuthorMobile
            // 
            this.colAuthorMobile.FieldName = "AuthorMobile";
            this.colAuthorMobile.Name = "colAuthorMobile";
            this.colAuthorMobile.Visible = true;
            this.colAuthorMobile.VisibleIndex = 36;
            // 
            // colAuthorPan
            // 
            this.colAuthorPan.FieldName = "AuthorPan";
            this.colAuthorPan.Name = "colAuthorPan";
            this.colAuthorPan.Visible = true;
            this.colAuthorPan.VisibleIndex = 37;
            // 
            // colAuthorPercent
            // 
            this.colAuthorPercent.FieldName = "AuthorPercent";
            this.colAuthorPercent.Name = "colAuthorPercent";
            this.colAuthorPercent.Visible = true;
            this.colAuthorPercent.VisibleIndex = 38;
            // 
            // colAuthorActive
            // 
            this.colAuthorActive.FieldName = "AuthorActive";
            this.colAuthorActive.Name = "colAuthorActive";
            this.colAuthorActive.Visible = true;
            this.colAuthorActive.VisibleIndex = 39;
            // 
            // Claerbtn
            // 
            this.Claerbtn.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Claerbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Claerbtn.Appearance.Options.UseBackColor = true;
            this.Claerbtn.Appearance.Options.UseFont = true;
            this.Claerbtn.Location = new System.Drawing.Point(951, 23);
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
            this.Findbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findbtn.Appearance.Options.UseBackColor = true;
            this.Findbtn.Appearance.Options.UseFont = true;
            this.Findbtn.Location = new System.Drawing.Point(798, 23);
            this.Findbtn.LookAndFeel.SkinName = "DevExpress Style";
            this.Findbtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(75, 23);
            this.Findbtn.TabIndex = 3;
            this.Findbtn.Text = "Find";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(23, 23);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(721, 23);
            this.dropDownButton1.TabIndex = 2;
            // 
            // FrmSubClientCompanyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1567, 749);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSubClientCompanyProfile";
            this.Text = "FrmSubClientCompanyProfile";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubClientGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton Claerbtn;
        private DevExpress.XtraEditors.SimpleButton Findbtn;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton Exitbtn;
        private DevExpress.XtraEditors.SimpleButton Clearbtn;
        private DevExpress.XtraEditors.SimpleButton Deletebtn;
        private DevExpress.XtraEditors.SimpleButton Updatebtn;
        private DevExpress.XtraEditors.SimpleButton Editbtn;
        private DevExpress.XtraEditors.SimpleButton Addbtn;
        private DevExpress.XtraEditors.SimpleButton Newbtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView SubClientGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
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