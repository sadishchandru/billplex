
namespace BillPlex
{
    partial class FrmEmployeeMasterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeMasterList));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.EmployeeGridControl = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.EmployeeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPPincode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPincode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDrivingNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassportNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentityMark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBloodGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReligion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNationality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEJoiningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEProbationPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEConfirmationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEResigningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinanceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPolicyNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPolicyTerm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnnualDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFApplicable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFJoiningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFLastDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPensionApplicable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPensionJoiningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESIApplicable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESIJoiningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESINo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESILastDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESIOffice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESIDispensary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(6, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1560, 76);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.panelControl7);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Location = new System.Drawing.Point(6, 87);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1560, 677);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.btnDelete);
            this.panelControl7.Controls.Add(this.btnUpdate);
            this.panelControl7.Controls.Add(this.btnEdit);
            this.panelControl7.Controls.Add(this.btnAdd);
            this.panelControl7.Controls.Add(this.btnExit);
            this.panelControl7.Controls.Add(this.btnNew);
            this.panelControl7.Location = new System.Drawing.Point(1376, 149);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(113, 254);
            this.panelControl7.TabIndex = 63;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(18, 173);
            this.btnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnDelete.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 23);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "DELETE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(18, 128);
            this.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 23);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "UPDATE";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(18, 88);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 23);
            this.btnEdit.TabIndex = 61;
            this.btnEdit.Text = "EDIT";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(18, 46);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 23);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "ADD";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(18, 212);
            this.btnExit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnExit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 23);
            this.btnExit.TabIndex = 59;
            this.btnExit.Text = "EXIT";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(18, 5);
            this.btnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(71, 23);
            this.btnNew.TabIndex = 53;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.EmployeeGridControl);
            this.panelControl3.Location = new System.Drawing.Point(5, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1313, 667);
            this.panelControl3.TabIndex = 0;
            // 
            // EmployeeGridControl
            // 
            this.EmployeeGridControl.DataMember = "PRO_GetEmployeeList";
            this.EmployeeGridControl.DataSource = this.sqlDataSource1;
            this.EmployeeGridControl.Location = new System.Drawing.Point(4, 5);
            this.EmployeeGridControl.MainView = this.EmployeeGridView;
            this.EmployeeGridControl.Name = "EmployeeGridControl";
            this.EmployeeGridControl.Size = new System.Drawing.Size(1304, 657);
            this.EmployeeGridControl.TabIndex = 0;
            this.EmployeeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EmployeeGridView});
            this.EmployeeGridControl.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "PRO_GetEmployeeList";
            storedProcQuery2.StoredProcName = "PRO_GetEmployeeList";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colEmployeeCode,
            this.colMasterCompanyId,
            this.colCompanyName,
            this.colContractorName,
            this.colClientCompanyId,
            this.colClientCompany,
            this.colClientName,
            this.colSubCompanyId,
            this.colSubCompany,
            this.colSubCompanyName,
            this.colEmployeeName,
            this.colPAddress,
            this.colPArea,
            this.colPDistrict,
            this.colPPincode,
            this.colPState,
            this.colCAddress,
            this.colCArea,
            this.colCDistrict,
            this.colCPincode,
            this.colCState,
            this.colVoterId,
            this.colDrivingNo,
            this.colPan,
            this.colPassportNo,
            this.colIdentityMark,
            this.colDoB,
            this.colGender,
            this.colBloodGroup,
            this.colEmail,
            this.colFName,
            this.colMName,
            this.colMStatus,
            this.colReligion,
            this.colCaste,
            this.colNationality,
            this.colSCode,
            this.colPhone,
            this.colMobile,
            this.colEJoiningDate,
            this.colEProbationPeriod,
            this.colEConfirmationDate,
            this.colEResigningDate,
            this.colReason,
            this.colEmpImage,
            this.colfinanceId,
            this.colEmpId,
            this.colBankName,
            this.colBankAddress,
            this.colSalaryNo,
            this.colPaymentMode,
            this.colAccountType,
            this.colBankRef,
            this.colWard,
            this.colPolicyNo,
            this.colPolicyTerm,
            this.colLicId,
            this.colAnnualDate,
            this.colPFApplicable,
            this.colPFJoiningDate,
            this.colPFLastDate,
            this.colPFNo,
            this.colPensionApplicable,
            this.colPensionJoiningDate,
            this.colESIApplicable,
            this.colESIJoiningDate,
            this.colESINo,
            this.colESILastDate,
            this.colESIOffice,
            this.colESIDispensary});
            this.EmployeeGridView.GridControl = this.EmployeeGridControl;
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.DoubleClick += new System.EventHandler(this.btn_EmployeeGridView_Click);
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
            // colEmployeeCode
            // 
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.MinWidth = 80;
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 1;
            this.colEmployeeCode.Width = 80;
            // 
            // colMasterCompanyId
            // 
            this.colMasterCompanyId.FieldName = "MasterCompanyId";
            this.colMasterCompanyId.MinWidth = 80;
            this.colMasterCompanyId.Name = "colMasterCompanyId";
            this.colMasterCompanyId.Width = 80;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.MinWidth = 80;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            this.colCompanyName.Width = 80;
            // 
            // colContractorName
            // 
            this.colContractorName.FieldName = "ContractorName";
            this.colContractorName.MinWidth = 80;
            this.colContractorName.Name = "colContractorName";
            this.colContractorName.Visible = true;
            this.colContractorName.VisibleIndex = 3;
            this.colContractorName.Width = 80;
            // 
            // colClientCompanyId
            // 
            this.colClientCompanyId.FieldName = "ClientCompanyId";
            this.colClientCompanyId.MinWidth = 80;
            this.colClientCompanyId.Name = "colClientCompanyId";
            this.colClientCompanyId.Width = 80;
            // 
            // colClientCompany
            // 
            this.colClientCompany.FieldName = "ClientCompany";
            this.colClientCompany.MinWidth = 80;
            this.colClientCompany.Name = "colClientCompany";
            this.colClientCompany.Visible = true;
            this.colClientCompany.VisibleIndex = 4;
            this.colClientCompany.Width = 80;
            // 
            // colClientName
            // 
            this.colClientName.FieldName = "ClientName";
            this.colClientName.MinWidth = 80;
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 5;
            this.colClientName.Width = 80;
            // 
            // colSubCompanyId
            // 
            this.colSubCompanyId.FieldName = "SubCompanyId";
            this.colSubCompanyId.MinWidth = 80;
            this.colSubCompanyId.Name = "colSubCompanyId";
            this.colSubCompanyId.Width = 80;
            // 
            // colSubCompany
            // 
            this.colSubCompany.FieldName = "SubCompany";
            this.colSubCompany.MinWidth = 80;
            this.colSubCompany.Name = "colSubCompany";
            this.colSubCompany.Visible = true;
            this.colSubCompany.VisibleIndex = 6;
            this.colSubCompany.Width = 80;
            // 
            // colSubCompanyName
            // 
            this.colSubCompanyName.FieldName = "SubCompanyName";
            this.colSubCompanyName.MinWidth = 80;
            this.colSubCompanyName.Name = "colSubCompanyName";
            this.colSubCompanyName.Visible = true;
            this.colSubCompanyName.VisibleIndex = 7;
            this.colSubCompanyName.Width = 80;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.MinWidth = 80;
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 8;
            this.colEmployeeName.Width = 80;
            // 
            // colPAddress
            // 
            this.colPAddress.FieldName = "PAddress";
            this.colPAddress.MinWidth = 80;
            this.colPAddress.Name = "colPAddress";
            this.colPAddress.Visible = true;
            this.colPAddress.VisibleIndex = 9;
            this.colPAddress.Width = 80;
            // 
            // colPArea
            // 
            this.colPArea.FieldName = "PArea";
            this.colPArea.MinWidth = 80;
            this.colPArea.Name = "colPArea";
            this.colPArea.Visible = true;
            this.colPArea.VisibleIndex = 10;
            this.colPArea.Width = 80;
            // 
            // colPDistrict
            // 
            this.colPDistrict.FieldName = "PDistrict";
            this.colPDistrict.MinWidth = 80;
            this.colPDistrict.Name = "colPDistrict";
            this.colPDistrict.Visible = true;
            this.colPDistrict.VisibleIndex = 11;
            this.colPDistrict.Width = 80;
            // 
            // colPPincode
            // 
            this.colPPincode.FieldName = "PPincode";
            this.colPPincode.MinWidth = 80;
            this.colPPincode.Name = "colPPincode";
            this.colPPincode.Visible = true;
            this.colPPincode.VisibleIndex = 12;
            this.colPPincode.Width = 80;
            // 
            // colPState
            // 
            this.colPState.FieldName = "PState";
            this.colPState.MinWidth = 80;
            this.colPState.Name = "colPState";
            this.colPState.Visible = true;
            this.colPState.VisibleIndex = 13;
            this.colPState.Width = 80;
            // 
            // colCAddress
            // 
            this.colCAddress.FieldName = "CAddress";
            this.colCAddress.MinWidth = 80;
            this.colCAddress.Name = "colCAddress";
            this.colCAddress.Visible = true;
            this.colCAddress.VisibleIndex = 14;
            this.colCAddress.Width = 80;
            // 
            // colCArea
            // 
            this.colCArea.FieldName = "CArea";
            this.colCArea.MinWidth = 80;
            this.colCArea.Name = "colCArea";
            this.colCArea.Visible = true;
            this.colCArea.VisibleIndex = 15;
            this.colCArea.Width = 80;
            // 
            // colCDistrict
            // 
            this.colCDistrict.FieldName = "CDistrict";
            this.colCDistrict.MinWidth = 80;
            this.colCDistrict.Name = "colCDistrict";
            this.colCDistrict.Visible = true;
            this.colCDistrict.VisibleIndex = 16;
            this.colCDistrict.Width = 80;
            // 
            // colCPincode
            // 
            this.colCPincode.FieldName = "CPincode";
            this.colCPincode.MinWidth = 80;
            this.colCPincode.Name = "colCPincode";
            this.colCPincode.Visible = true;
            this.colCPincode.VisibleIndex = 17;
            this.colCPincode.Width = 80;
            // 
            // colCState
            // 
            this.colCState.FieldName = "CState";
            this.colCState.MinWidth = 80;
            this.colCState.Name = "colCState";
            this.colCState.Visible = true;
            this.colCState.VisibleIndex = 18;
            this.colCState.Width = 80;
            // 
            // colVoterId
            // 
            this.colVoterId.FieldName = "VoterId";
            this.colVoterId.MinWidth = 80;
            this.colVoterId.Name = "colVoterId";
            this.colVoterId.Visible = true;
            this.colVoterId.VisibleIndex = 19;
            this.colVoterId.Width = 80;
            // 
            // colDrivingNo
            // 
            this.colDrivingNo.FieldName = "DrivingNo";
            this.colDrivingNo.MinWidth = 80;
            this.colDrivingNo.Name = "colDrivingNo";
            this.colDrivingNo.Visible = true;
            this.colDrivingNo.VisibleIndex = 20;
            this.colDrivingNo.Width = 80;
            // 
            // colPan
            // 
            this.colPan.FieldName = "Pan";
            this.colPan.MinWidth = 80;
            this.colPan.Name = "colPan";
            this.colPan.Visible = true;
            this.colPan.VisibleIndex = 21;
            this.colPan.Width = 80;
            // 
            // colPassportNo
            // 
            this.colPassportNo.FieldName = "PassportNo";
            this.colPassportNo.MinWidth = 80;
            this.colPassportNo.Name = "colPassportNo";
            this.colPassportNo.Visible = true;
            this.colPassportNo.VisibleIndex = 22;
            this.colPassportNo.Width = 80;
            // 
            // colIdentityMark
            // 
            this.colIdentityMark.FieldName = "IdentityMark";
            this.colIdentityMark.MinWidth = 80;
            this.colIdentityMark.Name = "colIdentityMark";
            this.colIdentityMark.Visible = true;
            this.colIdentityMark.VisibleIndex = 23;
            this.colIdentityMark.Width = 80;
            // 
            // colDoB
            // 
            this.colDoB.FieldName = "DoB";
            this.colDoB.MinWidth = 80;
            this.colDoB.Name = "colDoB";
            this.colDoB.Visible = true;
            this.colDoB.VisibleIndex = 24;
            this.colDoB.Width = 80;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.MinWidth = 80;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 25;
            this.colGender.Width = 80;
            // 
            // colBloodGroup
            // 
            this.colBloodGroup.FieldName = "BloodGroup";
            this.colBloodGroup.MinWidth = 80;
            this.colBloodGroup.Name = "colBloodGroup";
            this.colBloodGroup.Visible = true;
            this.colBloodGroup.VisibleIndex = 26;
            this.colBloodGroup.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 80;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 27;
            this.colEmail.Width = 80;
            // 
            // colFName
            // 
            this.colFName.FieldName = "FName";
            this.colFName.MinWidth = 80;
            this.colFName.Name = "colFName";
            this.colFName.Visible = true;
            this.colFName.VisibleIndex = 28;
            this.colFName.Width = 80;
            // 
            // colMName
            // 
            this.colMName.FieldName = "MName";
            this.colMName.MinWidth = 80;
            this.colMName.Name = "colMName";
            this.colMName.Visible = true;
            this.colMName.VisibleIndex = 29;
            this.colMName.Width = 80;
            // 
            // colMStatus
            // 
            this.colMStatus.FieldName = "MStatus";
            this.colMStatus.MinWidth = 80;
            this.colMStatus.Name = "colMStatus";
            this.colMStatus.Visible = true;
            this.colMStatus.VisibleIndex = 30;
            this.colMStatus.Width = 80;
            // 
            // colReligion
            // 
            this.colReligion.FieldName = "Religion";
            this.colReligion.MinWidth = 80;
            this.colReligion.Name = "colReligion";
            this.colReligion.Visible = true;
            this.colReligion.VisibleIndex = 31;
            this.colReligion.Width = 80;
            // 
            // colCaste
            // 
            this.colCaste.FieldName = "Caste";
            this.colCaste.MinWidth = 80;
            this.colCaste.Name = "colCaste";
            this.colCaste.Visible = true;
            this.colCaste.VisibleIndex = 32;
            this.colCaste.Width = 80;
            // 
            // colNationality
            // 
            this.colNationality.FieldName = "Nationality";
            this.colNationality.MinWidth = 80;
            this.colNationality.Name = "colNationality";
            this.colNationality.Visible = true;
            this.colNationality.VisibleIndex = 33;
            this.colNationality.Width = 80;
            // 
            // colSCode
            // 
            this.colSCode.FieldName = "SCode";
            this.colSCode.MinWidth = 80;
            this.colSCode.Name = "colSCode";
            this.colSCode.Visible = true;
            this.colSCode.VisibleIndex = 34;
            this.colSCode.Width = 80;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 80;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 35;
            this.colPhone.Width = 80;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.MinWidth = 80;
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 36;
            this.colMobile.Width = 80;
            // 
            // colEJoiningDate
            // 
            this.colEJoiningDate.FieldName = "EJoiningDate";
            this.colEJoiningDate.MinWidth = 80;
            this.colEJoiningDate.Name = "colEJoiningDate";
            this.colEJoiningDate.Visible = true;
            this.colEJoiningDate.VisibleIndex = 37;
            this.colEJoiningDate.Width = 80;
            // 
            // colEProbationPeriod
            // 
            this.colEProbationPeriod.FieldName = "EProbationPeriod";
            this.colEProbationPeriod.MinWidth = 80;
            this.colEProbationPeriod.Name = "colEProbationPeriod";
            this.colEProbationPeriod.Visible = true;
            this.colEProbationPeriod.VisibleIndex = 38;
            this.colEProbationPeriod.Width = 80;
            // 
            // colEConfirmationDate
            // 
            this.colEConfirmationDate.FieldName = "EConfirmationDate";
            this.colEConfirmationDate.MinWidth = 80;
            this.colEConfirmationDate.Name = "colEConfirmationDate";
            this.colEConfirmationDate.Visible = true;
            this.colEConfirmationDate.VisibleIndex = 39;
            this.colEConfirmationDate.Width = 80;
            // 
            // colEResigningDate
            // 
            this.colEResigningDate.FieldName = "EResigningDate";
            this.colEResigningDate.MinWidth = 80;
            this.colEResigningDate.Name = "colEResigningDate";
            this.colEResigningDate.Visible = true;
            this.colEResigningDate.VisibleIndex = 40;
            this.colEResigningDate.Width = 80;
            // 
            // colReason
            // 
            this.colReason.FieldName = "Reason";
            this.colReason.MinWidth = 80;
            this.colReason.Name = "colReason";
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 41;
            this.colReason.Width = 80;
            // 
            // colEmpImage
            // 
            this.colEmpImage.FieldName = "EmpImage";
            this.colEmpImage.MinWidth = 80;
            this.colEmpImage.Name = "colEmpImage";
            this.colEmpImage.Visible = true;
            this.colEmpImage.VisibleIndex = 42;
            this.colEmpImage.Width = 80;
            // 
            // colfinanceId
            // 
            this.colfinanceId.FieldName = "financeId";
            this.colfinanceId.MinWidth = 80;
            this.colfinanceId.Name = "colfinanceId";
            this.colfinanceId.Visible = true;
            this.colfinanceId.VisibleIndex = 43;
            this.colfinanceId.Width = 80;
            // 
            // colEmpId
            // 
            this.colEmpId.FieldName = "EmpId";
            this.colEmpId.MinWidth = 80;
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.Visible = true;
            this.colEmpId.VisibleIndex = 44;
            this.colEmpId.Width = 80;
            // 
            // colBankName
            // 
            this.colBankName.FieldName = "BankName";
            this.colBankName.MinWidth = 80;
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 45;
            this.colBankName.Width = 80;
            // 
            // colBankAddress
            // 
            this.colBankAddress.FieldName = "BankAddress";
            this.colBankAddress.MinWidth = 80;
            this.colBankAddress.Name = "colBankAddress";
            this.colBankAddress.Visible = true;
            this.colBankAddress.VisibleIndex = 46;
            this.colBankAddress.Width = 80;
            // 
            // colSalaryNo
            // 
            this.colSalaryNo.FieldName = "SalaryNo";
            this.colSalaryNo.MinWidth = 80;
            this.colSalaryNo.Name = "colSalaryNo";
            this.colSalaryNo.Visible = true;
            this.colSalaryNo.VisibleIndex = 47;
            this.colSalaryNo.Width = 80;
            // 
            // colPaymentMode
            // 
            this.colPaymentMode.FieldName = "PaymentMode";
            this.colPaymentMode.MinWidth = 80;
            this.colPaymentMode.Name = "colPaymentMode";
            this.colPaymentMode.Visible = true;
            this.colPaymentMode.VisibleIndex = 48;
            this.colPaymentMode.Width = 80;
            // 
            // colAccountType
            // 
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.MinWidth = 80;
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.Visible = true;
            this.colAccountType.VisibleIndex = 49;
            this.colAccountType.Width = 80;
            // 
            // colBankRef
            // 
            this.colBankRef.FieldName = "BankRef";
            this.colBankRef.MinWidth = 80;
            this.colBankRef.Name = "colBankRef";
            this.colBankRef.Visible = true;
            this.colBankRef.VisibleIndex = 50;
            this.colBankRef.Width = 80;
            // 
            // colWard
            // 
            this.colWard.FieldName = "Ward";
            this.colWard.MinWidth = 80;
            this.colWard.Name = "colWard";
            this.colWard.Visible = true;
            this.colWard.VisibleIndex = 51;
            this.colWard.Width = 80;
            // 
            // colPolicyNo
            // 
            this.colPolicyNo.FieldName = "PolicyNo";
            this.colPolicyNo.MinWidth = 80;
            this.colPolicyNo.Name = "colPolicyNo";
            this.colPolicyNo.Visible = true;
            this.colPolicyNo.VisibleIndex = 52;
            this.colPolicyNo.Width = 80;
            // 
            // colPolicyTerm
            // 
            this.colPolicyTerm.FieldName = "PolicyTerm";
            this.colPolicyTerm.MinWidth = 80;
            this.colPolicyTerm.Name = "colPolicyTerm";
            this.colPolicyTerm.Visible = true;
            this.colPolicyTerm.VisibleIndex = 53;
            this.colPolicyTerm.Width = 80;
            // 
            // colLicId
            // 
            this.colLicId.FieldName = "LicId";
            this.colLicId.MinWidth = 80;
            this.colLicId.Name = "colLicId";
            this.colLicId.Visible = true;
            this.colLicId.VisibleIndex = 54;
            this.colLicId.Width = 80;
            // 
            // colAnnualDate
            // 
            this.colAnnualDate.FieldName = "AnnualDate";
            this.colAnnualDate.MinWidth = 80;
            this.colAnnualDate.Name = "colAnnualDate";
            this.colAnnualDate.Visible = true;
            this.colAnnualDate.VisibleIndex = 55;
            this.colAnnualDate.Width = 80;
            // 
            // colPFApplicable
            // 
            this.colPFApplicable.FieldName = "PFApplicable";
            this.colPFApplicable.MinWidth = 80;
            this.colPFApplicable.Name = "colPFApplicable";
            this.colPFApplicable.Visible = true;
            this.colPFApplicable.VisibleIndex = 56;
            this.colPFApplicable.Width = 80;
            // 
            // colPFJoiningDate
            // 
            this.colPFJoiningDate.FieldName = "PFJoiningDate";
            this.colPFJoiningDate.MinWidth = 80;
            this.colPFJoiningDate.Name = "colPFJoiningDate";
            this.colPFJoiningDate.Visible = true;
            this.colPFJoiningDate.VisibleIndex = 57;
            this.colPFJoiningDate.Width = 80;
            // 
            // colPFLastDate
            // 
            this.colPFLastDate.FieldName = "PFLastDate";
            this.colPFLastDate.MinWidth = 80;
            this.colPFLastDate.Name = "colPFLastDate";
            this.colPFLastDate.Visible = true;
            this.colPFLastDate.VisibleIndex = 58;
            this.colPFLastDate.Width = 80;
            // 
            // colPFNo
            // 
            this.colPFNo.FieldName = "PFNo";
            this.colPFNo.MinWidth = 80;
            this.colPFNo.Name = "colPFNo";
            this.colPFNo.Visible = true;
            this.colPFNo.VisibleIndex = 59;
            this.colPFNo.Width = 80;
            // 
            // colPensionApplicable
            // 
            this.colPensionApplicable.FieldName = "PensionApplicable";
            this.colPensionApplicable.MinWidth = 80;
            this.colPensionApplicable.Name = "colPensionApplicable";
            this.colPensionApplicable.Visible = true;
            this.colPensionApplicable.VisibleIndex = 60;
            this.colPensionApplicable.Width = 80;
            // 
            // colPensionJoiningDate
            // 
            this.colPensionJoiningDate.FieldName = "PensionJoiningDate";
            this.colPensionJoiningDate.MinWidth = 80;
            this.colPensionJoiningDate.Name = "colPensionJoiningDate";
            this.colPensionJoiningDate.Visible = true;
            this.colPensionJoiningDate.VisibleIndex = 61;
            this.colPensionJoiningDate.Width = 80;
            // 
            // colESIApplicable
            // 
            this.colESIApplicable.FieldName = "ESIApplicable";
            this.colESIApplicable.MinWidth = 80;
            this.colESIApplicable.Name = "colESIApplicable";
            this.colESIApplicable.Visible = true;
            this.colESIApplicable.VisibleIndex = 62;
            this.colESIApplicable.Width = 80;
            // 
            // colESIJoiningDate
            // 
            this.colESIJoiningDate.FieldName = "ESIJoiningDate";
            this.colESIJoiningDate.MinWidth = 80;
            this.colESIJoiningDate.Name = "colESIJoiningDate";
            this.colESIJoiningDate.Visible = true;
            this.colESIJoiningDate.VisibleIndex = 63;
            this.colESIJoiningDate.Width = 80;
            // 
            // colESINo
            // 
            this.colESINo.FieldName = "ESINo";
            this.colESINo.MinWidth = 80;
            this.colESINo.Name = "colESINo";
            this.colESINo.Visible = true;
            this.colESINo.VisibleIndex = 64;
            this.colESINo.Width = 80;
            // 
            // colESILastDate
            // 
            this.colESILastDate.FieldName = "ESILastDate";
            this.colESILastDate.MinWidth = 80;
            this.colESILastDate.Name = "colESILastDate";
            this.colESILastDate.Visible = true;
            this.colESILastDate.VisibleIndex = 65;
            this.colESILastDate.Width = 80;
            // 
            // colESIOffice
            // 
            this.colESIOffice.FieldName = "ESIOffice";
            this.colESIOffice.MinWidth = 80;
            this.colESIOffice.Name = "colESIOffice";
            this.colESIOffice.Visible = true;
            this.colESIOffice.VisibleIndex = 66;
            this.colESIOffice.Width = 80;
            // 
            // colESIDispensary
            // 
            this.colESIDispensary.FieldName = "ESIDispensary";
            this.colESIDispensary.MinWidth = 80;
            this.colESIDispensary.Name = "colESIDispensary";
            this.colESIDispensary.Visible = true;
            this.colESIDispensary.VisibleIndex = 67;
            this.colESIDispensary.Width = 80;
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl4.Controls.Add(this.panelControl1);
            this.panelControl4.Controls.Add(this.panelControl2);
            this.panelControl4.Location = new System.Drawing.Point(13, 13);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1571, 769);
            this.panelControl4.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(650, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(260, 32);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Employee Master";
            // 
            // FrmEmployeeMasterList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1618, 799);
            this.Controls.Add(this.panelControl4);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEmployeeMasterList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmployeeMasterList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEmployeeMasterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl EmployeeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView EmployeeGridView;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colContractorName;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colPAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPArea;
        private DevExpress.XtraGrid.Columns.GridColumn colPDistrict;
        private DevExpress.XtraGrid.Columns.GridColumn colPPincode;
        private DevExpress.XtraGrid.Columns.GridColumn colPState;
        private DevExpress.XtraGrid.Columns.GridColumn colCAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCArea;
        private DevExpress.XtraGrid.Columns.GridColumn colCDistrict;
        private DevExpress.XtraGrid.Columns.GridColumn colCPincode;
        private DevExpress.XtraGrid.Columns.GridColumn colCState;
        private DevExpress.XtraGrid.Columns.GridColumn colVoterId;
        private DevExpress.XtraGrid.Columns.GridColumn colDrivingNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPan;
        private DevExpress.XtraGrid.Columns.GridColumn colPassportNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentityMark;
        private DevExpress.XtraGrid.Columns.GridColumn colDoB;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colBloodGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colFName;
        private DevExpress.XtraGrid.Columns.GridColumn colMName;
        private DevExpress.XtraGrid.Columns.GridColumn colMStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colReligion;
        private DevExpress.XtraGrid.Columns.GridColumn colCaste;
        private DevExpress.XtraGrid.Columns.GridColumn colNationality;
        private DevExpress.XtraGrid.Columns.GridColumn colSCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colEJoiningDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEProbationPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colEConfirmationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEResigningDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReason;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpImage;
        private DevExpress.XtraGrid.Columns.GridColumn colfinanceId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpId;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMode;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colBankRef;
        private DevExpress.XtraGrid.Columns.GridColumn colWard;
        private DevExpress.XtraGrid.Columns.GridColumn colPolicyNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPolicyTerm;
        private DevExpress.XtraGrid.Columns.GridColumn colLicId;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnualDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPFApplicable;
        private DevExpress.XtraGrid.Columns.GridColumn colPFJoiningDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPFLastDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPFNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPensionApplicable;
        private DevExpress.XtraGrid.Columns.GridColumn colPensionJoiningDate;
        private DevExpress.XtraGrid.Columns.GridColumn colESIApplicable;
        private DevExpress.XtraGrid.Columns.GridColumn colESIJoiningDate;
        private DevExpress.XtraGrid.Columns.GridColumn colESINo;
        private DevExpress.XtraGrid.Columns.GridColumn colESILastDate;
        private DevExpress.XtraGrid.Columns.GridColumn colESIOffice;
        private DevExpress.XtraGrid.Columns.GridColumn colESIDispensary;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}