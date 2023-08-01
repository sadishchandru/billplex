
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeMasterList));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.EmployeeGridControl = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.EmployeeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colDeleteOption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colId_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpId_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFdistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPincode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeRelation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoB_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResiding = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNo_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpCode_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpId_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAddress_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFarea_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFdistrict_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPincode_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeRelation_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoB_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResiding_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorportion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaritalStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReligion_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFName_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGuardianName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGuardianAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGuardianRelation = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1594, 76);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(780, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(164, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Employee Master";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.panelControl7);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Location = new System.Drawing.Point(11, 84);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1594, 709);
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
            this.panelControl7.Location = new System.Drawing.Point(1439, 183);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(113, 254);
            this.panelControl7.TabIndex = 63;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelControl3.Controls.Add(this.btnClear);
            this.panelControl3.Controls.Add(this.btnFind);
            this.panelControl3.Controls.Add(this.comboBoxEdit1);
            this.panelControl3.Controls.Add(this.EmployeeGridControl);
            this.panelControl3.Location = new System.Drawing.Point(5, 17);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1384, 613);
            this.panelControl3.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(854, 11);
            this.btnClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(752, 10);
            this.btnFind.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnFind.LookAndFeel.SkinName = "DevExpress Style";
            this.btnFind.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(163, 12);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(567, 20);
            this.comboBoxEdit1.TabIndex = 1;
            // 
            // EmployeeGridControl
            // 
            this.EmployeeGridControl.DataMember = "PRO_GetEmployeeList";
            this.EmployeeGridControl.DataSource = this.sqlDataSource1;
            this.EmployeeGridControl.Location = new System.Drawing.Point(4, 41);
            this.EmployeeGridControl.MainView = this.EmployeeGridView;
            this.EmployeeGridControl.Name = "EmployeeGridControl";
            this.EmployeeGridControl.Size = new System.Drawing.Size(1371, 552);
            this.EmployeeGridControl.TabIndex = 0;
            this.EmployeeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EmployeeGridView});
            this.EmployeeGridControl.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetEmployeeList";
            storedProcQuery1.StoredProcName = "PRO_GetEmployeeList";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
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
            this.colESIDispensary,
            this.colDeleteOption,
            this.colId_1,
            this.colEmployeeCode,
            this.colMasterCompanyId,
            this.colContractorName,
            this.colClientCompanyId,
            this.colClientName,
            this.colSubCompanyId,
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
            this.colId_2,
            this.colEmpCode,
            this.colEmpId_1,
            this.colSNo,
            this.colName,
            this.colFAddress,
            this.colFarea,
            this.colFdistrict,
            this.colState,
            this.colPincode,
            this.colEmployeeRelation,
            this.colDoB_1,
            this.colAge,
            this.colResiding,
            this.colRemark,
            this.colId_3,
            this.colSNo_1,
            this.colEmpCode_1,
            this.colEmpId_2,
            this.colName_1,
            this.colFAddress_1,
            this.colFarea_1,
            this.colFdistrict_1,
            this.colPincode_1,
            this.colState_1,
            this.colEmployeeRelation_1,
            this.colDoB_2,
            this.colAge_1,
            this.colResiding_1,
            this.colPorportion,
            this.colMaritalStatus,
            this.colReligion_1,
            this.colFName_1,
            this.colGuardianName,
            this.colGuardianAddress,
            this.colGuardianRelation});
            this.EmployeeGridView.GridControl = this.EmployeeGridControl;
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.DoubleClick += new System.EventHandler(this.btn_EmployeeGridView_Click);
            // 
            // colId
            // 
            this.colId.FieldName = "EmployeeCode";
            this.colId.MinWidth = 69;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colEmpId
            // 
            this.colEmpId.FieldName = "EmpId";
            this.colEmpId.MinWidth = 69;
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.Visible = true;
            this.colEmpId.VisibleIndex = 43;
            // 
            // colBankName
            // 
            this.colBankName.FieldName = "BankName";
            this.colBankName.MinWidth = 69;
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 44;
            // 
            // colBankAddress
            // 
            this.colBankAddress.FieldName = "BankAddress";
            this.colBankAddress.MinWidth = 69;
            this.colBankAddress.Name = "colBankAddress";
            this.colBankAddress.Visible = true;
            this.colBankAddress.VisibleIndex = 45;
            // 
            // colSalaryNo
            // 
            this.colSalaryNo.FieldName = "SalaryNo";
            this.colSalaryNo.MinWidth = 69;
            this.colSalaryNo.Name = "colSalaryNo";
            this.colSalaryNo.Visible = true;
            this.colSalaryNo.VisibleIndex = 46;
            // 
            // colPaymentMode
            // 
            this.colPaymentMode.FieldName = "PaymentMode";
            this.colPaymentMode.MinWidth = 69;
            this.colPaymentMode.Name = "colPaymentMode";
            this.colPaymentMode.Visible = true;
            this.colPaymentMode.VisibleIndex = 47;
            // 
            // colAccountType
            // 
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.MinWidth = 69;
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.Visible = true;
            this.colAccountType.VisibleIndex = 48;
            // 
            // colBankRef
            // 
            this.colBankRef.FieldName = "BankRef";
            this.colBankRef.MinWidth = 69;
            this.colBankRef.Name = "colBankRef";
            this.colBankRef.Visible = true;
            this.colBankRef.VisibleIndex = 49;
            // 
            // colWard
            // 
            this.colWard.FieldName = "Ward";
            this.colWard.MinWidth = 69;
            this.colWard.Name = "colWard";
            this.colWard.Visible = true;
            this.colWard.VisibleIndex = 50;
            // 
            // colPolicyNo
            // 
            this.colPolicyNo.FieldName = "PolicyNo";
            this.colPolicyNo.MinWidth = 69;
            this.colPolicyNo.Name = "colPolicyNo";
            this.colPolicyNo.Visible = true;
            this.colPolicyNo.VisibleIndex = 51;
            // 
            // colPolicyTerm
            // 
            this.colPolicyTerm.FieldName = "PolicyTerm";
            this.colPolicyTerm.MinWidth = 69;
            this.colPolicyTerm.Name = "colPolicyTerm";
            this.colPolicyTerm.Visible = true;
            this.colPolicyTerm.VisibleIndex = 52;
            // 
            // colLicId
            // 
            this.colLicId.FieldName = "LicId";
            this.colLicId.MinWidth = 69;
            this.colLicId.Name = "colLicId";
            this.colLicId.Visible = true;
            this.colLicId.VisibleIndex = 53;
            // 
            // colAnnualDate
            // 
            this.colAnnualDate.FieldName = "AnnualDate";
            this.colAnnualDate.MinWidth = 69;
            this.colAnnualDate.Name = "colAnnualDate";
            this.colAnnualDate.Visible = true;
            this.colAnnualDate.VisibleIndex = 55;
            // 
            // colPFApplicable
            // 
            this.colPFApplicable.FieldName = "PFApplicable";
            this.colPFApplicable.MinWidth = 69;
            this.colPFApplicable.Name = "colPFApplicable";
            this.colPFApplicable.Visible = true;
            this.colPFApplicable.VisibleIndex = 54;
            // 
            // colPFJoiningDate
            // 
            this.colPFJoiningDate.FieldName = "PFJoiningDate";
            this.colPFJoiningDate.MinWidth = 69;
            this.colPFJoiningDate.Name = "colPFJoiningDate";
            this.colPFJoiningDate.Visible = true;
            this.colPFJoiningDate.VisibleIndex = 56;
            // 
            // colPFLastDate
            // 
            this.colPFLastDate.FieldName = "PFLastDate";
            this.colPFLastDate.MinWidth = 69;
            this.colPFLastDate.Name = "colPFLastDate";
            this.colPFLastDate.Visible = true;
            this.colPFLastDate.VisibleIndex = 57;
            // 
            // colPFNo
            // 
            this.colPFNo.FieldName = "PFNo";
            this.colPFNo.MinWidth = 69;
            this.colPFNo.Name = "colPFNo";
            this.colPFNo.Visible = true;
            this.colPFNo.VisibleIndex = 58;
            // 
            // colPensionApplicable
            // 
            this.colPensionApplicable.FieldName = "PensionApplicable";
            this.colPensionApplicable.MinWidth = 69;
            this.colPensionApplicable.Name = "colPensionApplicable";
            this.colPensionApplicable.Visible = true;
            this.colPensionApplicable.VisibleIndex = 59;
            // 
            // colPensionJoiningDate
            // 
            this.colPensionJoiningDate.FieldName = "PensionJoiningDate";
            this.colPensionJoiningDate.MinWidth = 69;
            this.colPensionJoiningDate.Name = "colPensionJoiningDate";
            this.colPensionJoiningDate.Visible = true;
            this.colPensionJoiningDate.VisibleIndex = 60;
            // 
            // colESIApplicable
            // 
            this.colESIApplicable.FieldName = "ESIApplicable";
            this.colESIApplicable.MinWidth = 69;
            this.colESIApplicable.Name = "colESIApplicable";
            this.colESIApplicable.Visible = true;
            this.colESIApplicable.VisibleIndex = 61;
            // 
            // colESIJoiningDate
            // 
            this.colESIJoiningDate.FieldName = "ESIJoiningDate";
            this.colESIJoiningDate.MinWidth = 69;
            this.colESIJoiningDate.Name = "colESIJoiningDate";
            this.colESIJoiningDate.Visible = true;
            this.colESIJoiningDate.VisibleIndex = 62;
            // 
            // colESINo
            // 
            this.colESINo.FieldName = "ESINo";
            this.colESINo.MinWidth = 69;
            this.colESINo.Name = "colESINo";
            this.colESINo.Visible = true;
            this.colESINo.VisibleIndex = 63;
            // 
            // colESILastDate
            // 
            this.colESILastDate.FieldName = "ESILastDate";
            this.colESILastDate.MinWidth = 69;
            this.colESILastDate.Name = "colESILastDate";
            this.colESILastDate.Visible = true;
            this.colESILastDate.VisibleIndex = 64;
            // 
            // colESIOffice
            // 
            this.colESIOffice.FieldName = "ESIOffice";
            this.colESIOffice.MinWidth = 69;
            this.colESIOffice.Name = "colESIOffice";
            this.colESIOffice.Visible = true;
            this.colESIOffice.VisibleIndex = 65;
            // 
            // colESIDispensary
            // 
            this.colESIDispensary.FieldName = "ESIDispensary";
            this.colESIDispensary.MinWidth = 69;
            this.colESIDispensary.Name = "colESIDispensary";
            this.colESIDispensary.Visible = true;
            this.colESIDispensary.VisibleIndex = 66;
            // 
            // colDeleteOption
            // 
            this.colDeleteOption.FieldName = "DeleteOption";
            this.colDeleteOption.MinWidth = 69;
            this.colDeleteOption.Name = "colDeleteOption";
            this.colDeleteOption.Visible = true;
            this.colDeleteOption.VisibleIndex = 67;
            // 
            // colId_1
            // 
            this.colId_1.FieldName = "Id_1";
            this.colId_1.MinWidth = 69;
            this.colId_1.Name = "colId_1";
            this.colId_1.Visible = true;
            this.colId_1.VisibleIndex = 1;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.MinWidth = 69;
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 2;
            // 
            // colMasterCompanyId
            // 
            this.colMasterCompanyId.FieldName = "MasterCompanyId";
            this.colMasterCompanyId.MinWidth = 69;
            this.colMasterCompanyId.Name = "colMasterCompanyId";
            this.colMasterCompanyId.Visible = true;
            this.colMasterCompanyId.VisibleIndex = 3;
            // 
            // colContractorName
            // 
            this.colContractorName.FieldName = "ContractorName";
            this.colContractorName.MinWidth = 69;
            this.colContractorName.Name = "colContractorName";
            this.colContractorName.Visible = true;
            this.colContractorName.VisibleIndex = 4;
            // 
            // colClientCompanyId
            // 
            this.colClientCompanyId.FieldName = "ClientCompanyId";
            this.colClientCompanyId.MinWidth = 69;
            this.colClientCompanyId.Name = "colClientCompanyId";
            this.colClientCompanyId.Visible = true;
            this.colClientCompanyId.VisibleIndex = 5;
            // 
            // colClientName
            // 
            this.colClientName.FieldName = "ClientName";
            this.colClientName.MinWidth = 69;
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 6;
            // 
            // colSubCompanyId
            // 
            this.colSubCompanyId.FieldName = "SubCompanyId";
            this.colSubCompanyId.MinWidth = 69;
            this.colSubCompanyId.Name = "colSubCompanyId";
            this.colSubCompanyId.Visible = true;
            this.colSubCompanyId.VisibleIndex = 7;
            // 
            // colSubCompanyName
            // 
            this.colSubCompanyName.FieldName = "SubCompanyName";
            this.colSubCompanyName.MinWidth = 69;
            this.colSubCompanyName.Name = "colSubCompanyName";
            this.colSubCompanyName.Visible = true;
            this.colSubCompanyName.VisibleIndex = 8;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.MinWidth = 69;
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 9;
            // 
            // colPAddress
            // 
            this.colPAddress.FieldName = "PAddress";
            this.colPAddress.MinWidth = 69;
            this.colPAddress.Name = "colPAddress";
            this.colPAddress.Visible = true;
            this.colPAddress.VisibleIndex = 10;
            // 
            // colPArea
            // 
            this.colPArea.FieldName = "PArea";
            this.colPArea.MinWidth = 69;
            this.colPArea.Name = "colPArea";
            this.colPArea.Visible = true;
            this.colPArea.VisibleIndex = 11;
            // 
            // colPDistrict
            // 
            this.colPDistrict.FieldName = "PDistrict";
            this.colPDistrict.MinWidth = 69;
            this.colPDistrict.Name = "colPDistrict";
            this.colPDistrict.Visible = true;
            this.colPDistrict.VisibleIndex = 12;
            // 
            // colPPincode
            // 
            this.colPPincode.FieldName = "PPincode";
            this.colPPincode.MinWidth = 69;
            this.colPPincode.Name = "colPPincode";
            this.colPPincode.Visible = true;
            this.colPPincode.VisibleIndex = 13;
            // 
            // colPState
            // 
            this.colPState.FieldName = "PState";
            this.colPState.MinWidth = 69;
            this.colPState.Name = "colPState";
            this.colPState.Visible = true;
            this.colPState.VisibleIndex = 14;
            // 
            // colCAddress
            // 
            this.colCAddress.FieldName = "CAddress";
            this.colCAddress.MinWidth = 69;
            this.colCAddress.Name = "colCAddress";
            this.colCAddress.Visible = true;
            this.colCAddress.VisibleIndex = 15;
            // 
            // colCArea
            // 
            this.colCArea.FieldName = "CArea";
            this.colCArea.MinWidth = 69;
            this.colCArea.Name = "colCArea";
            this.colCArea.Visible = true;
            this.colCArea.VisibleIndex = 16;
            // 
            // colCDistrict
            // 
            this.colCDistrict.FieldName = "CDistrict";
            this.colCDistrict.MinWidth = 69;
            this.colCDistrict.Name = "colCDistrict";
            this.colCDistrict.Visible = true;
            this.colCDistrict.VisibleIndex = 17;
            // 
            // colCPincode
            // 
            this.colCPincode.FieldName = "CPincode";
            this.colCPincode.MinWidth = 69;
            this.colCPincode.Name = "colCPincode";
            this.colCPincode.Visible = true;
            this.colCPincode.VisibleIndex = 18;
            // 
            // colCState
            // 
            this.colCState.FieldName = "CState";
            this.colCState.MinWidth = 69;
            this.colCState.Name = "colCState";
            this.colCState.Visible = true;
            this.colCState.VisibleIndex = 19;
            // 
            // colVoterId
            // 
            this.colVoterId.FieldName = "VoterId";
            this.colVoterId.MinWidth = 69;
            this.colVoterId.Name = "colVoterId";
            this.colVoterId.Visible = true;
            this.colVoterId.VisibleIndex = 20;
            // 
            // colDrivingNo
            // 
            this.colDrivingNo.FieldName = "DrivingNo";
            this.colDrivingNo.MinWidth = 69;
            this.colDrivingNo.Name = "colDrivingNo";
            this.colDrivingNo.Visible = true;
            this.colDrivingNo.VisibleIndex = 21;
            // 
            // colPan
            // 
            this.colPan.FieldName = "Pan";
            this.colPan.MinWidth = 69;
            this.colPan.Name = "colPan";
            this.colPan.Visible = true;
            this.colPan.VisibleIndex = 22;
            this.colPan.Width = 221;
            // 
            // colPassportNo
            // 
            this.colPassportNo.FieldName = "PassportNo";
            this.colPassportNo.MinWidth = 69;
            this.colPassportNo.Name = "colPassportNo";
            this.colPassportNo.Visible = true;
            this.colPassportNo.VisibleIndex = 23;
            // 
            // colIdentityMark
            // 
            this.colIdentityMark.FieldName = "IdentityMark";
            this.colIdentityMark.MinWidth = 69;
            this.colIdentityMark.Name = "colIdentityMark";
            this.colIdentityMark.Visible = true;
            this.colIdentityMark.VisibleIndex = 24;
            // 
            // colDoB
            // 
            this.colDoB.FieldName = "DoB";
            this.colDoB.MinWidth = 69;
            this.colDoB.Name = "colDoB";
            this.colDoB.Visible = true;
            this.colDoB.VisibleIndex = 25;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.MinWidth = 69;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 26;
            // 
            // colBloodGroup
            // 
            this.colBloodGroup.FieldName = "BloodGroup";
            this.colBloodGroup.MinWidth = 69;
            this.colBloodGroup.Name = "colBloodGroup";
            this.colBloodGroup.Visible = true;
            this.colBloodGroup.VisibleIndex = 27;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 69;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 28;
            // 
            // colFName
            // 
            this.colFName.FieldName = "FName";
            this.colFName.MinWidth = 69;
            this.colFName.Name = "colFName";
            this.colFName.Visible = true;
            this.colFName.VisibleIndex = 29;
            // 
            // colMName
            // 
            this.colMName.FieldName = "MName";
            this.colMName.MinWidth = 69;
            this.colMName.Name = "colMName";
            this.colMName.Visible = true;
            this.colMName.VisibleIndex = 30;
            // 
            // colMStatus
            // 
            this.colMStatus.FieldName = "MStatus";
            this.colMStatus.MinWidth = 69;
            this.colMStatus.Name = "colMStatus";
            this.colMStatus.Visible = true;
            this.colMStatus.VisibleIndex = 31;
            // 
            // colReligion
            // 
            this.colReligion.FieldName = "Religion";
            this.colReligion.MinWidth = 69;
            this.colReligion.Name = "colReligion";
            this.colReligion.Visible = true;
            this.colReligion.VisibleIndex = 32;
            // 
            // colCaste
            // 
            this.colCaste.FieldName = "Caste";
            this.colCaste.MinWidth = 69;
            this.colCaste.Name = "colCaste";
            this.colCaste.Visible = true;
            this.colCaste.VisibleIndex = 33;
            // 
            // colNationality
            // 
            this.colNationality.FieldName = "Nationality";
            this.colNationality.MinWidth = 69;
            this.colNationality.Name = "colNationality";
            this.colNationality.Visible = true;
            this.colNationality.VisibleIndex = 34;
            // 
            // colSCode
            // 
            this.colSCode.FieldName = "SCode";
            this.colSCode.MinWidth = 69;
            this.colSCode.Name = "colSCode";
            this.colSCode.Visible = true;
            this.colSCode.VisibleIndex = 35;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 69;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 36;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.MinWidth = 69;
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 37;
            // 
            // colEJoiningDate
            // 
            this.colEJoiningDate.FieldName = "EJoiningDate";
            this.colEJoiningDate.MinWidth = 69;
            this.colEJoiningDate.Name = "colEJoiningDate";
            this.colEJoiningDate.Visible = true;
            this.colEJoiningDate.VisibleIndex = 38;
            // 
            // colEProbationPeriod
            // 
            this.colEProbationPeriod.FieldName = "EProbationPeriod";
            this.colEProbationPeriod.MinWidth = 69;
            this.colEProbationPeriod.Name = "colEProbationPeriod";
            this.colEProbationPeriod.Visible = true;
            this.colEProbationPeriod.VisibleIndex = 39;
            // 
            // colEConfirmationDate
            // 
            this.colEConfirmationDate.FieldName = "EConfirmationDate";
            this.colEConfirmationDate.MinWidth = 69;
            this.colEConfirmationDate.Name = "colEConfirmationDate";
            this.colEConfirmationDate.Visible = true;
            this.colEConfirmationDate.VisibleIndex = 40;
            // 
            // colEResigningDate
            // 
            this.colEResigningDate.FieldName = "EResigningDate";
            this.colEResigningDate.MinWidth = 69;
            this.colEResigningDate.Name = "colEResigningDate";
            this.colEResigningDate.Visible = true;
            this.colEResigningDate.VisibleIndex = 41;
            // 
            // colReason
            // 
            this.colReason.FieldName = "Reason";
            this.colReason.MinWidth = 69;
            this.colReason.Name = "colReason";
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 42;
            // 
            // colEmpImage
            // 
            this.colEmpImage.FieldName = "EmpImage";
            this.colEmpImage.MinWidth = 69;
            this.colEmpImage.Name = "colEmpImage";
            this.colEmpImage.Visible = true;
            this.colEmpImage.VisibleIndex = 68;
            // 
            // colId_2
            // 
            this.colId_2.FieldName = "Id_2";
            this.colId_2.MinWidth = 69;
            this.colId_2.Name = "colId_2";
            this.colId_2.Visible = true;
            this.colId_2.VisibleIndex = 69;
            // 
            // colEmpCode
            // 
            this.colEmpCode.FieldName = "EmpCode";
            this.colEmpCode.MinWidth = 69;
            this.colEmpCode.Name = "colEmpCode";
            this.colEmpCode.Visible = true;
            this.colEmpCode.VisibleIndex = 70;
            // 
            // colEmpId_1
            // 
            this.colEmpId_1.FieldName = "EmpId_1";
            this.colEmpId_1.MinWidth = 69;
            this.colEmpId_1.Name = "colEmpId_1";
            this.colEmpId_1.Visible = true;
            this.colEmpId_1.VisibleIndex = 71;
            // 
            // colSNo
            // 
            this.colSNo.FieldName = "SNo";
            this.colSNo.MinWidth = 69;
            this.colSNo.Name = "colSNo";
            this.colSNo.Visible = true;
            this.colSNo.VisibleIndex = 72;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 69;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 73;
            // 
            // colFAddress
            // 
            this.colFAddress.FieldName = "FAddress";
            this.colFAddress.MinWidth = 69;
            this.colFAddress.Name = "colFAddress";
            this.colFAddress.Visible = true;
            this.colFAddress.VisibleIndex = 74;
            // 
            // colFarea
            // 
            this.colFarea.FieldName = "Farea";
            this.colFarea.MinWidth = 69;
            this.colFarea.Name = "colFarea";
            this.colFarea.Visible = true;
            this.colFarea.VisibleIndex = 75;
            // 
            // colFdistrict
            // 
            this.colFdistrict.FieldName = "Fdistrict";
            this.colFdistrict.MinWidth = 69;
            this.colFdistrict.Name = "colFdistrict";
            this.colFdistrict.Visible = true;
            this.colFdistrict.VisibleIndex = 76;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.MinWidth = 69;
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 77;
            // 
            // colPincode
            // 
            this.colPincode.FieldName = "Pincode";
            this.colPincode.MinWidth = 69;
            this.colPincode.Name = "colPincode";
            this.colPincode.Visible = true;
            this.colPincode.VisibleIndex = 78;
            // 
            // colEmployeeRelation
            // 
            this.colEmployeeRelation.FieldName = "EmployeeRelation";
            this.colEmployeeRelation.MinWidth = 69;
            this.colEmployeeRelation.Name = "colEmployeeRelation";
            this.colEmployeeRelation.Visible = true;
            this.colEmployeeRelation.VisibleIndex = 79;
            // 
            // colDoB_1
            // 
            this.colDoB_1.FieldName = "DoB_1";
            this.colDoB_1.MinWidth = 69;
            this.colDoB_1.Name = "colDoB_1";
            this.colDoB_1.Visible = true;
            this.colDoB_1.VisibleIndex = 80;
            // 
            // colAge
            // 
            this.colAge.FieldName = "Age";
            this.colAge.MinWidth = 69;
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 81;
            // 
            // colResiding
            // 
            this.colResiding.FieldName = "Residing";
            this.colResiding.MinWidth = 69;
            this.colResiding.Name = "colResiding";
            this.colResiding.Visible = true;
            this.colResiding.VisibleIndex = 82;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.MinWidth = 69;
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 83;
            // 
            // colId_3
            // 
            this.colId_3.FieldName = "Id_3";
            this.colId_3.MinWidth = 21;
            this.colId_3.Name = "colId_3";
            this.colId_3.Visible = true;
            this.colId_3.VisibleIndex = 84;
            // 
            // colSNo_1
            // 
            this.colSNo_1.FieldName = "SNo_1";
            this.colSNo_1.MinWidth = 69;
            this.colSNo_1.Name = "colSNo_1";
            this.colSNo_1.Visible = true;
            this.colSNo_1.VisibleIndex = 85;
            // 
            // colEmpCode_1
            // 
            this.colEmpCode_1.FieldName = "EmpCode_1";
            this.colEmpCode_1.MinWidth = 69;
            this.colEmpCode_1.Name = "colEmpCode_1";
            this.colEmpCode_1.Visible = true;
            this.colEmpCode_1.VisibleIndex = 86;
            // 
            // colEmpId_2
            // 
            this.colEmpId_2.FieldName = "EmpId_2";
            this.colEmpId_2.MinWidth = 69;
            this.colEmpId_2.Name = "colEmpId_2";
            this.colEmpId_2.Visible = true;
            this.colEmpId_2.VisibleIndex = 87;
            // 
            // colName_1
            // 
            this.colName_1.FieldName = "Name_1";
            this.colName_1.MinWidth = 69;
            this.colName_1.Name = "colName_1";
            this.colName_1.Visible = true;
            this.colName_1.VisibleIndex = 88;
            // 
            // colFAddress_1
            // 
            this.colFAddress_1.FieldName = "FAddress_1";
            this.colFAddress_1.MinWidth = 69;
            this.colFAddress_1.Name = "colFAddress_1";
            this.colFAddress_1.Visible = true;
            this.colFAddress_1.VisibleIndex = 89;
            // 
            // colFarea_1
            // 
            this.colFarea_1.FieldName = "Farea_1";
            this.colFarea_1.MinWidth = 69;
            this.colFarea_1.Name = "colFarea_1";
            this.colFarea_1.Visible = true;
            this.colFarea_1.VisibleIndex = 90;
            // 
            // colFdistrict_1
            // 
            this.colFdistrict_1.FieldName = "Fdistrict_1";
            this.colFdistrict_1.MinWidth = 69;
            this.colFdistrict_1.Name = "colFdistrict_1";
            this.colFdistrict_1.Visible = true;
            this.colFdistrict_1.VisibleIndex = 91;
            // 
            // colPincode_1
            // 
            this.colPincode_1.FieldName = "Pincode_1";
            this.colPincode_1.MinWidth = 69;
            this.colPincode_1.Name = "colPincode_1";
            this.colPincode_1.Visible = true;
            this.colPincode_1.VisibleIndex = 92;
            // 
            // colState_1
            // 
            this.colState_1.FieldName = "State_1";
            this.colState_1.MinWidth = 69;
            this.colState_1.Name = "colState_1";
            this.colState_1.Visible = true;
            this.colState_1.VisibleIndex = 93;
            // 
            // colEmployeeRelation_1
            // 
            this.colEmployeeRelation_1.FieldName = "EmployeeRelation_1";
            this.colEmployeeRelation_1.MinWidth = 69;
            this.colEmployeeRelation_1.Name = "colEmployeeRelation_1";
            this.colEmployeeRelation_1.Visible = true;
            this.colEmployeeRelation_1.VisibleIndex = 94;
            // 
            // colDoB_2
            // 
            this.colDoB_2.FieldName = "DoB_2";
            this.colDoB_2.MinWidth = 69;
            this.colDoB_2.Name = "colDoB_2";
            this.colDoB_2.Visible = true;
            this.colDoB_2.VisibleIndex = 95;
            // 
            // colAge_1
            // 
            this.colAge_1.FieldName = "Age_1";
            this.colAge_1.MinWidth = 69;
            this.colAge_1.Name = "colAge_1";
            this.colAge_1.Visible = true;
            this.colAge_1.VisibleIndex = 96;
            // 
            // colResiding_1
            // 
            this.colResiding_1.FieldName = "Residing_1";
            this.colResiding_1.MinWidth = 69;
            this.colResiding_1.Name = "colResiding_1";
            this.colResiding_1.Visible = true;
            this.colResiding_1.VisibleIndex = 97;
            // 
            // colPorportion
            // 
            this.colPorportion.FieldName = "Porportion";
            this.colPorportion.MinWidth = 69;
            this.colPorportion.Name = "colPorportion";
            this.colPorportion.Visible = true;
            this.colPorportion.VisibleIndex = 98;
            // 
            // colMaritalStatus
            // 
            this.colMaritalStatus.FieldName = "MaritalStatus";
            this.colMaritalStatus.MinWidth = 69;
            this.colMaritalStatus.Name = "colMaritalStatus";
            this.colMaritalStatus.Visible = true;
            this.colMaritalStatus.VisibleIndex = 99;
            // 
            // colReligion_1
            // 
            this.colReligion_1.FieldName = "Religion";
            this.colReligion_1.MinWidth = 69;
            this.colReligion_1.Name = "colReligion_1";
            this.colReligion_1.Visible = true;
            this.colReligion_1.VisibleIndex = 100;
            // 
            // colFName_1
            // 
            this.colFName_1.FieldName = "FName";
            this.colFName_1.MinWidth = 69;
            this.colFName_1.Name = "colFName_1";
            this.colFName_1.Visible = true;
            this.colFName_1.VisibleIndex = 101;
            // 
            // colGuardianName
            // 
            this.colGuardianName.FieldName = "GuardianName";
            this.colGuardianName.MinWidth = 69;
            this.colGuardianName.Name = "colGuardianName";
            this.colGuardianName.Visible = true;
            this.colGuardianName.VisibleIndex = 102;
            // 
            // colGuardianAddress
            // 
            this.colGuardianAddress.FieldName = "GuardianAddress";
            this.colGuardianAddress.MinWidth = 69;
            this.colGuardianAddress.Name = "colGuardianAddress";
            this.colGuardianAddress.Visible = true;
            this.colGuardianAddress.VisibleIndex = 103;
            // 
            // colGuardianRelation
            // 
            this.colGuardianRelation.FieldName = "GuardianRelation";
            this.colGuardianRelation.MinWidth = 69;
            this.colGuardianRelation.Name = "colGuardianRelation";
            this.colGuardianRelation.Visible = true;
            this.colGuardianRelation.VisibleIndex = 104;
            // 
            // FrmEmployeeMasterList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1618, 799);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl EmployeeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView EmployeeGridView;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteOption;
        private DevExpress.XtraGrid.Columns.GridColumn colId_1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colContractorName;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCompanyId;
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
        private DevExpress.XtraGrid.Columns.GridColumn colId_2;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpId_1;
        private DevExpress.XtraGrid.Columns.GridColumn colSNo;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colFarea;
        private DevExpress.XtraGrid.Columns.GridColumn colFdistrict;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colPincode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeRelation;
        private DevExpress.XtraGrid.Columns.GridColumn colDoB_1;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colResiding;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colId_3;
        private DevExpress.XtraGrid.Columns.GridColumn colSNo_1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpCode_1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpId_2;
        private DevExpress.XtraGrid.Columns.GridColumn colName_1;
        private DevExpress.XtraGrid.Columns.GridColumn colFAddress_1;
        private DevExpress.XtraGrid.Columns.GridColumn colFarea_1;
        private DevExpress.XtraGrid.Columns.GridColumn colFdistrict_1;
        private DevExpress.XtraGrid.Columns.GridColumn colPincode_1;
        private DevExpress.XtraGrid.Columns.GridColumn colState_1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeRelation_1;
        private DevExpress.XtraGrid.Columns.GridColumn colDoB_2;
        private DevExpress.XtraGrid.Columns.GridColumn colAge_1;
        private DevExpress.XtraGrid.Columns.GridColumn colResiding_1;
        private DevExpress.XtraGrid.Columns.GridColumn colPorportion;
        private DevExpress.XtraGrid.Columns.GridColumn colMaritalStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colReligion_1;
        private DevExpress.XtraGrid.Columns.GridColumn colFName_1;
        private DevExpress.XtraGrid.Columns.GridColumn colGuardianName;
        private DevExpress.XtraGrid.Columns.GridColumn colGuardianAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colGuardianRelation;
    }
}