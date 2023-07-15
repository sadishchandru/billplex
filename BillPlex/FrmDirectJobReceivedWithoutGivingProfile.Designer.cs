
namespace BillPlex
{
    partial class FrmDirectJobReceivedWithoutGivingProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectJobReceivedWithoutGivingProfile));
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
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colNetAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncentive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConveyance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirectorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProsize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncentiveApplicable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeduction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConveyance1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncentive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Location = new System.Drawing.Point(12, 75);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1791, 741);
            this.panelControl2.TabIndex = 3;
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
            this.panelControl5.Location = new System.Drawing.Point(1642, 157);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(98, 281);
            this.panelControl5.TabIndex = 2;
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
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.btnClear);
            this.panelControl3.Controls.Add(this.btnFind);
            this.panelControl3.Controls.Add(this.comboBoxEdit1);
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Location = new System.Drawing.Point(19, 25);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1564, 692);
            this.panelControl3.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(869, 26);
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            // 
            // btnFind
            // 
            this.btnFind.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnFind.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Appearance.Options.UseBackColor = true;
            this.btnFind.Appearance.Options.UseFont = true;
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(769, 26);
            this.btnFind.LookAndFeel.SkinName = "DevExpress Style";
            this.btnFind.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(106, 29);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(618, 20);
            this.comboBoxEdit1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetDirectJobReceivedWithoutGiving";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(10, 82);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1549, 605);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colEmpId,
            this.colEmployeeName,
            this.colCompanyName,
            this.colDirectorName,
            this.colClientCompany,
            this.colClientName,
            this.colSubClientCompany,
            this.colSubClientName,
            this.colProductModel,
            this.colProductCode,
            this.colProductName,
            this.colProsize,
            this.colWages,
            this.colcolor,
            this.colQuantity,
            this.colWeight,
            this.colIncentiveApplicable,
            this.colBDays,
            this.colADays,
            this.colDeduction,
            this.colTotal,
            this.colConveyance1,
            this.colIncentive1,
            this.colNetAmt1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1791, 55);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(685, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(421, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "DIRECT JOB RECEIVED Without GIVING";
            // 
            // colNetAmt
            // 
            this.colNetAmt.FieldName = "NetAmt";
            this.colNetAmt.Name = "colNetAmt";
            // 
            // colIncentive
            // 
            this.colIncentive.FieldName = "Incentive";
            this.colIncentive.Name = "colIncentive";
            // 
            // colConveyance
            // 
            this.colConveyance.FieldName = "Conveyance";
            this.colConveyance.Name = "colConveyance";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetDirectJobReceivedWithoutGiving";
            storedProcQuery1.StoredProcName = "PRO_GetDirectJobReceivedWithoutGiving";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colEmpId
            // 
            this.colEmpId.FieldName = "EmpId";
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.Visible = true;
            this.colEmpId.VisibleIndex = 1;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 2;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            // 
            // colDirectorName
            // 
            this.colDirectorName.FieldName = "DirectorName";
            this.colDirectorName.Name = "colDirectorName";
            this.colDirectorName.Visible = true;
            this.colDirectorName.VisibleIndex = 4;
            // 
            // colClientCompany
            // 
            this.colClientCompany.FieldName = "ClientCompany";
            this.colClientCompany.Name = "colClientCompany";
            this.colClientCompany.Visible = true;
            this.colClientCompany.VisibleIndex = 5;
            // 
            // colClientName
            // 
            this.colClientName.FieldName = "ClientName";
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 6;
            // 
            // colSubClientCompany
            // 
            this.colSubClientCompany.FieldName = "SubClientCompany";
            this.colSubClientCompany.Name = "colSubClientCompany";
            this.colSubClientCompany.Visible = true;
            this.colSubClientCompany.VisibleIndex = 7;
            // 
            // colSubClientName
            // 
            this.colSubClientName.FieldName = "SubClientName";
            this.colSubClientName.Name = "colSubClientName";
            this.colSubClientName.Visible = true;
            this.colSubClientName.VisibleIndex = 8;
            // 
            // colProductModel
            // 
            this.colProductModel.FieldName = "ProductModel";
            this.colProductModel.Name = "colProductModel";
            this.colProductModel.Visible = true;
            this.colProductModel.VisibleIndex = 9;
            // 
            // colProductCode
            // 
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 10;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 11;
            // 
            // colProsize
            // 
            this.colProsize.FieldName = "Prosize";
            this.colProsize.Name = "colProsize";
            this.colProsize.Visible = true;
            this.colProsize.VisibleIndex = 12;
            // 
            // colWages
            // 
            this.colWages.FieldName = "Wages";
            this.colWages.Name = "colWages";
            this.colWages.Visible = true;
            this.colWages.VisibleIndex = 13;
            // 
            // colcolor
            // 
            this.colcolor.FieldName = "color";
            this.colcolor.Name = "colcolor";
            this.colcolor.Visible = true;
            this.colcolor.VisibleIndex = 14;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 15;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 16;
            // 
            // colIncentiveApplicable
            // 
            this.colIncentiveApplicable.FieldName = "IncentiveApplicable";
            this.colIncentiveApplicable.Name = "colIncentiveApplicable";
            this.colIncentiveApplicable.Visible = true;
            this.colIncentiveApplicable.VisibleIndex = 17;
            // 
            // colBDays
            // 
            this.colBDays.FieldName = "BDays";
            this.colBDays.Name = "colBDays";
            this.colBDays.Visible = true;
            this.colBDays.VisibleIndex = 18;
            // 
            // colADays
            // 
            this.colADays.FieldName = "ADays";
            this.colADays.Name = "colADays";
            this.colADays.Visible = true;
            this.colADays.VisibleIndex = 19;
            // 
            // colDeduction
            // 
            this.colDeduction.FieldName = "Deduction";
            this.colDeduction.Name = "colDeduction";
            this.colDeduction.Visible = true;
            this.colDeduction.VisibleIndex = 20;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 21;
            // 
            // colConveyance1
            // 
            this.colConveyance1.FieldName = "Conveyance";
            this.colConveyance1.Name = "colConveyance1";
            this.colConveyance1.Visible = true;
            this.colConveyance1.VisibleIndex = 22;
            // 
            // colIncentive1
            // 
            this.colIncentive1.FieldName = "Incentive";
            this.colIncentive1.Name = "colIncentive1";
            this.colIncentive1.Visible = true;
            this.colIncentive1.VisibleIndex = 23;
            // 
            // colNetAmt1
            // 
            this.colNetAmt1.FieldName = "NetAmt";
            this.colNetAmt1.Name = "colNetAmt1";
            this.colNetAmt1.Visible = true;
            this.colNetAmt1.VisibleIndex = 24;
            // 
            // FrmDirectJobReceivedWithoutGivingProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 828);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmDirectJobReceivedWithoutGivingProfile";
            this.Text = "FrmDirectJobReceivedWithoutGivingProfile";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton Exitbtn;
        private DevExpress.XtraEditors.SimpleButton Clearbtn;
        private DevExpress.XtraEditors.SimpleButton Deletebtn;
        private DevExpress.XtraEditors.SimpleButton Updatebtn;
        private DevExpress.XtraEditors.SimpleButton Editbtn;
        private DevExpress.XtraEditors.SimpleButton Addbtn;
        private DevExpress.XtraEditors.SimpleButton Newbtn;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colDirectorName;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colSubClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductModel;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProsize;
        private DevExpress.XtraGrid.Columns.GridColumn colWages;
        private DevExpress.XtraGrid.Columns.GridColumn colcolor;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colIncentiveApplicable;
        private DevExpress.XtraGrid.Columns.GridColumn colBDays;
        private DevExpress.XtraGrid.Columns.GridColumn colADays;
        private DevExpress.XtraGrid.Columns.GridColumn colDeduction;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colConveyance1;
        private DevExpress.XtraGrid.Columns.GridColumn colIncentive1;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmt1;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colIncentive;
        private DevExpress.XtraGrid.Columns.GridColumn colConveyance;
    }
}