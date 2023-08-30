
namespace BillPlex
{
    partial class FrmDirectLabourBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectLabourBill));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup6 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.radBonus = new DevExpress.XtraEditors.RadioGroup();
            this.radESI = new DevExpress.XtraEditors.RadioGroup();
            this.radProduction = new DevExpress.XtraEditors.RadioGroup();
            this.radPF = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtBonus = new DevExpress.XtraEditors.TextEdit();
            this.txtESI = new DevExpress.XtraEditors.TextEdit();
            this.txtpf = new DevExpress.XtraEditors.TextEdit();
            this.txtIncentivePercent = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtSuperVisor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtAdvance = new DevExpress.XtraEditors.TextEdit();
            this.txtFinalTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalBouns = new DevExpress.XtraEditors.TextEdit();
            this.TxtTotalESI = new DevExpress.XtraEditors.TextEdit();
            this.txtPFText = new DevExpress.XtraEditors.TextEdit();
            this.txtProductionIncentive = new DevExpress.XtraEditors.TextEdit();
            this.txtGrandTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtSupVisorTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtSubTotal2 = new DevExpress.XtraEditors.TextEdit();
            this.txtIncentives = new DevExpress.XtraEditors.TextEdit();
            this.txtConveyance = new DevExpress.XtraEditors.TextEdit();
            this.txtSubTotal1 = new DevExpress.XtraEditors.TextEdit();
            this.txtDeducation = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.drpOrderBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.drpSortBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubClient = new DevExpress.XtraEditors.TextEdit();
            this.txtClientName = new DevExpress.XtraEditors.TextEdit();
            this.txtDirector = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.drpSubClient = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpCCompany = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpMainCompany = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.radCompanyWise = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtBillNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ddFrom = new DevExpress.XtraEditors.DateEdit();
            this.ddTo = new DevExpress.XtraEditors.DateEdit();
            this.ddDate = new DevExpress.XtraEditors.DateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWagesforEmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBonus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radESI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProduction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtESI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncentivePercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuperVisor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdvance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalBouns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalESI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPFText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductionIncentive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrandTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupVisorTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncentives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConveyance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeducation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpOrderBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpSortBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpSubClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMainCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCompanyWise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.panelControl8);
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Controls.Add(this.labelControl31);
            this.panelControl1.Controls.Add(this.labelControl30);
            this.panelControl1.Controls.Add(this.labelControl29);
            this.panelControl1.Controls.Add(this.labelControl28);
            this.panelControl1.Controls.Add(this.radBonus);
            this.panelControl1.Controls.Add(this.radESI);
            this.panelControl1.Controls.Add(this.radProduction);
            this.panelControl1.Controls.Add(this.radPF);
            this.panelControl1.Controls.Add(this.labelControl27);
            this.panelControl1.Controls.Add(this.labelControl26);
            this.panelControl1.Controls.Add(this.labelControl25);
            this.panelControl1.Controls.Add(this.labelControl24);
            this.panelControl1.Controls.Add(this.labelControl23);
            this.panelControl1.Controls.Add(this.labelControl22);
            this.panelControl1.Controls.Add(this.labelControl21);
            this.panelControl1.Controls.Add(this.txtBonus);
            this.panelControl1.Controls.Add(this.txtESI);
            this.panelControl1.Controls.Add(this.txtpf);
            this.panelControl1.Controls.Add(this.txtIncentivePercent);
            this.panelControl1.Controls.Add(this.labelControl20);
            this.panelControl1.Controls.Add(this.txtSuperVisor);
            this.panelControl1.Controls.Add(this.labelControl19);
            this.panelControl1.Controls.Add(this.labelControl18);
            this.panelControl1.Controls.Add(this.labelControl17);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.labelControl15);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.txtNetAmount);
            this.panelControl1.Controls.Add(this.txtAdvance);
            this.panelControl1.Controls.Add(this.txtFinalTotal);
            this.panelControl1.Controls.Add(this.txtTotalBouns);
            this.panelControl1.Controls.Add(this.TxtTotalESI);
            this.panelControl1.Controls.Add(this.txtPFText);
            this.panelControl1.Controls.Add(this.txtProductionIncentive);
            this.panelControl1.Controls.Add(this.txtGrandTotal);
            this.panelControl1.Controls.Add(this.txtSupVisorTotal);
            this.panelControl1.Controls.Add(this.txtSubTotal2);
            this.panelControl1.Controls.Add(this.txtIncentives);
            this.panelControl1.Controls.Add(this.txtConveyance);
            this.panelControl1.Controls.Add(this.txtSubTotal1);
            this.panelControl1.Controls.Add(this.txtDeducation);
            this.panelControl1.Controls.Add(this.txtTotal);
            this.panelControl1.Controls.Add(this.btn_Print);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.drpOrderBy);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.drpSortBy);
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1800, 826);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetDirectLabourBill";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1385, 341);
            this.gridControl1.TabIndex = 123;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetDirectLabourBill";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetDirectLabourBill";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colModelName,
            this.colProductName,
            this.colProductSize,
            this.colQuantityPiece,
            this.colWagesforEmp,
            this.colTotalQty,
            this.colNetAmt,
            this.colTotalAmt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // panelControl8
            // 
            this.panelControl8.Controls.Add(this.calcEdit1);
            this.panelControl8.Controls.Add(this.labelControl34);
            this.panelControl8.Location = new System.Drawing.Point(21, 556);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(357, 236);
            this.panelControl8.TabIndex = 122;
            // 
            // calcEdit1
            // 
            this.calcEdit1.Location = new System.Drawing.Point(5, 29);
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcEdit1.Properties.Appearance.Options.UseFont = true;
            this.calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit1.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.calcEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.calcEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.calcEdit1.Size = new System.Drawing.Size(333, 26);
            this.calcEdit1.TabIndex = 126;
            // 
            // labelControl34
            // 
            this.labelControl34.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl34.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl34.Appearance.Options.UseFont = true;
            this.labelControl34.Appearance.Options.UseForeColor = true;
            this.labelControl34.Location = new System.Drawing.Point(5, 5);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(82, 18);
            this.labelControl34.TabIndex = 125;
            this.labelControl34.Text = "Calculator";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.panelControl7);
            this.panelControl6.Controls.Add(this.radioGroup6);
            this.panelControl6.Location = new System.Drawing.Point(424, 632);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(298, 114);
            this.panelControl6.TabIndex = 121;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.labelControl33);
            this.panelControl7.Location = new System.Drawing.Point(0, 0);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(298, 29);
            this.panelControl7.TabIndex = 2;
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl33.Appearance.Options.UseFont = true;
            this.labelControl33.Location = new System.Drawing.Point(6, 6);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(149, 18);
            this.labelControl33.TabIndex = 95;
            this.labelControl33.Text = "PF and ESI Option";
            // 
            // radioGroup6
            // 
            this.radioGroup6.Location = new System.Drawing.Point(5, 41);
            this.radioGroup6.Name = "radioGroup6";
            this.radioGroup6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioGroup6.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup6.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup6.Properties.Appearance.Options.UseFont = true;
            this.radioGroup6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup6.Properties.Columns = 1;
            this.radioGroup6.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Calculate With Sub Total 1 Both", true, null, "Calculate With Sub Total 1 Both"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Calculate With Sub Total 2 Both", true, null, "Calculate With Sub Total 2 Both")});
            this.radioGroup6.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.radioGroup6.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.radioGroup6.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radioGroup6.Size = new System.Drawing.Size(277, 68);
            this.radioGroup6.TabIndex = 1;
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl31.Appearance.Options.UseFont = true;
            this.labelControl31.Location = new System.Drawing.Point(853, 691);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(177, 18);
            this.labelControl31.TabIndex = 120;
            this.labelControl31.Text = "Bonus : % or Amount";
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Location = new System.Drawing.Point(876, 658);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(154, 18);
            this.labelControl30.TabIndex = 119;
            this.labelControl30.Text = "ESI : % or Amount";
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Location = new System.Drawing.Point(887, 625);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(146, 18);
            this.labelControl29.TabIndex = 118;
            this.labelControl29.Text = "PF : % or Amount";
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Location = new System.Drawing.Point(739, 595);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(295, 18);
            this.labelControl28.TabIndex = 117;
            this.labelControl28.Text = "Production Incentive : % or Amount";
            // 
            // radBonus
            // 
            this.radBonus.Location = new System.Drawing.Point(1040, 688);
            this.radBonus.Name = "radBonus";
            this.radBonus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radBonus.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBonus.Properties.Appearance.Options.UseBackColor = true;
            this.radBonus.Properties.Appearance.Options.UseFont = true;
            this.radBonus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radBonus.Properties.Columns = 2;
            this.radBonus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "%", true, null, "%"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Amount", true, null, "Amount")});
            this.radBonus.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.radBonus.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.radBonus.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radBonus.Size = new System.Drawing.Size(172, 27);
            this.radBonus.TabIndex = 116;
            this.radBonus.EditValueChanged += new System.EventHandler(this.radBonus_EditValueChanged);
            // 
            // radESI
            // 
            this.radESI.Location = new System.Drawing.Point(1040, 655);
            this.radESI.Name = "radESI";
            this.radESI.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radESI.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radESI.Properties.Appearance.Options.UseBackColor = true;
            this.radESI.Properties.Appearance.Options.UseFont = true;
            this.radESI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radESI.Properties.Columns = 2;
            this.radESI.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(0)), "%", true, null, "%"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), "Amount", true, null, "Amount")});
            this.radESI.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.radESI.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.radESI.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radESI.Size = new System.Drawing.Size(172, 27);
            this.radESI.TabIndex = 115;
            this.radESI.EditValueChanged += new System.EventHandler(this.radESI_EditValueChanged);
            // 
            // radProduction
            // 
            this.radProduction.Location = new System.Drawing.Point(1040, 581);
            this.radProduction.Name = "radProduction";
            this.radProduction.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radProduction.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProduction.Properties.Appearance.Options.UseBackColor = true;
            this.radProduction.Properties.Appearance.Options.UseFont = true;
            this.radProduction.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radProduction.Properties.Columns = 2;
            this.radProduction.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "%", true, null, "%"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Amount", true, null, "Amount")});
            this.radProduction.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.radProduction.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.radProduction.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radProduction.Size = new System.Drawing.Size(172, 42);
            this.radProduction.TabIndex = 113;
            this.radProduction.SelectedIndexChanged += new System.EventHandler(this.radioGroup2_SelectedIndexChanged);
            // 
            // radPF
            // 
            this.radPF.Location = new System.Drawing.Point(1040, 622);
            this.radPF.Name = "radPF";
            this.radPF.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radPF.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPF.Properties.Appearance.Options.UseBackColor = true;
            this.radPF.Properties.Appearance.Options.UseFont = true;
            this.radPF.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radPF.Properties.Columns = 2;
            this.radPF.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "%", true, null, "%"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Amount", true, null, "Amount")});
            this.radPF.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.radPF.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.radPF.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radPF.Size = new System.Drawing.Size(172, 27);
            this.radPF.TabIndex = 114;
            this.radPF.SelectedIndexChanged += new System.EventHandler(this.radPF_SelectedIndexChanged);
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Location = new System.Drawing.Point(1465, 803);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(98, 18);
            this.labelControl27.TabIndex = 112;
            this.labelControl27.Text = "Net Amount";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Location = new System.Drawing.Point(1465, 774);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(68, 18);
            this.labelControl26.TabIndex = 111;
            this.labelControl26.Text = "Advance";
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl25.Appearance.Options.UseFont = true;
            this.labelControl25.Location = new System.Drawing.Point(1465, 739);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(87, 18);
            this.labelControl25.TabIndex = 110;
            this.labelControl25.Text = "Final Total";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Location = new System.Drawing.Point(1386, 703);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(50, 18);
            this.labelControl24.TabIndex = 109;
            this.labelControl24.Text = "Bonus";
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(1409, 666);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(27, 18);
            this.labelControl23.TabIndex = 108;
            this.labelControl23.Text = "ESI";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(1409, 628);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(19, 18);
            this.labelControl22.TabIndex = 107;
            this.labelControl22.Text = "PF";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(1279, 595);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(168, 18);
            this.labelControl21.TabIndex = 106;
            this.labelControl21.Text = "Production Incentive";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(1453, 701);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(67, 20);
            this.txtBonus.TabIndex = 102;
            this.txtBonus.EditValueChanged += new System.EventHandler(this.radBonus_EditValueChanged);
            // 
            // txtESI
            // 
            this.txtESI.Location = new System.Drawing.Point(1453, 664);
            this.txtESI.Name = "txtESI";
            this.txtESI.Size = new System.Drawing.Size(67, 20);
            this.txtESI.TabIndex = 101;
            this.txtESI.EditValueChanged += new System.EventHandler(this.radESI_EditValueChanged);
            // 
            // txtpf
            // 
            this.txtpf.EditValue = "";
            this.txtpf.Location = new System.Drawing.Point(1453, 629);
            this.txtpf.Name = "txtpf";
            this.txtpf.Properties.BeepOnError = false;
            this.txtpf.Properties.UseMaskAsDisplayFormat = true;
            this.txtpf.Size = new System.Drawing.Size(67, 20);
            this.txtpf.TabIndex = 100;
            this.txtpf.EditValueChanged += new System.EventHandler(this.radPF_SelectedIndexChanged);
            // 
            // txtIncentivePercent
            // 
            this.txtIncentivePercent.Location = new System.Drawing.Point(1453, 593);
            this.txtIncentivePercent.Name = "txtIncentivePercent";
            this.txtIncentivePercent.Properties.BeepOnError = false;
            this.txtIncentivePercent.Size = new System.Drawing.Size(67, 20);
            this.txtIncentivePercent.TabIndex = 99;
            this.txtIncentivePercent.EditValueChanged += new System.EventHandler(this.radioGroup2_SelectedIndexChanged);
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(1426, 556);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(93, 18);
            this.labelControl20.TabIndex = 98;
            this.labelControl20.Text = "Grant Total";
            // 
            // txtSuperVisor
            // 
            this.txtSuperVisor.Location = new System.Drawing.Point(1453, 519);
            this.txtSuperVisor.Name = "txtSuperVisor";
            this.txtSuperVisor.Size = new System.Drawing.Size(67, 20);
            this.txtSuperVisor.TabIndex = 97;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(1288, 521);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(159, 18);
            this.labelControl19.TabIndex = 96;
            this.labelControl19.Text = "SuperVisor Charges";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(1426, 478);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(94, 18);
            this.labelControl18.TabIndex = 95;
            this.labelControl18.Text = "Sub Total 2";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(1426, 442);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(85, 18);
            this.labelControl17.TabIndex = 94;
            this.labelControl17.Text = "Incentives";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(1426, 406);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(97, 18);
            this.labelControl16.TabIndex = 93;
            this.labelControl16.Text = "Conveyance";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(1426, 374);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(94, 18);
            this.labelControl15.TabIndex = 92;
            this.labelControl15.Text = "Sub Total 1";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(1426, 340);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(92, 18);
            this.labelControl14.TabIndex = 91;
            this.labelControl14.Text = "Deducation";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(1426, 303);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(42, 18);
            this.labelControl13.TabIndex = 90;
            this.labelControl13.Text = "Total";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(1590, 801);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(200, 20);
            this.txtNetAmount.TabIndex = 89;
            this.txtNetAmount.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(1590, 772);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(200, 20);
            this.txtAdvance.TabIndex = 88;
            this.txtAdvance.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtFinalTotal
            // 
            this.txtFinalTotal.Location = new System.Drawing.Point(1590, 737);
            this.txtFinalTotal.Name = "txtFinalTotal";
            this.txtFinalTotal.Size = new System.Drawing.Size(200, 20);
            this.txtFinalTotal.TabIndex = 87;
            this.txtFinalTotal.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtTotalBouns
            // 
            this.txtTotalBouns.Location = new System.Drawing.Point(1590, 701);
            this.txtTotalBouns.Name = "txtTotalBouns";
            this.txtTotalBouns.Size = new System.Drawing.Size(200, 20);
            this.txtTotalBouns.TabIndex = 86;
            this.txtTotalBouns.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // TxtTotalESI
            // 
            this.TxtTotalESI.Location = new System.Drawing.Point(1590, 664);
            this.TxtTotalESI.Name = "TxtTotalESI";
            this.TxtTotalESI.Size = new System.Drawing.Size(200, 20);
            this.TxtTotalESI.TabIndex = 85;
            this.TxtTotalESI.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtPFText
            // 
            this.txtPFText.Location = new System.Drawing.Point(1590, 629);
            this.txtPFText.Name = "txtPFText";
            this.txtPFText.Size = new System.Drawing.Size(200, 20);
            this.txtPFText.TabIndex = 84;
            this.txtPFText.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtProductionIncentive
            // 
            this.txtProductionIncentive.Location = new System.Drawing.Point(1590, 593);
            this.txtProductionIncentive.Name = "txtProductionIncentive";
            this.txtProductionIncentive.Size = new System.Drawing.Size(200, 20);
            this.txtProductionIncentive.TabIndex = 83;
            this.txtProductionIncentive.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(1590, 554);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(200, 20);
            this.txtGrandTotal.TabIndex = 82;
            this.txtGrandTotal.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtSupVisorTotal
            // 
            this.txtSupVisorTotal.Location = new System.Drawing.Point(1590, 519);
            this.txtSupVisorTotal.Name = "txtSupVisorTotal";
            this.txtSupVisorTotal.Size = new System.Drawing.Size(200, 20);
            this.txtSupVisorTotal.TabIndex = 81;
            this.txtSupVisorTotal.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtSubTotal2
            // 
            this.txtSubTotal2.Location = new System.Drawing.Point(1590, 479);
            this.txtSubTotal2.Name = "txtSubTotal2";
            this.txtSubTotal2.Size = new System.Drawing.Size(200, 20);
            this.txtSubTotal2.TabIndex = 80;
            this.txtSubTotal2.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtIncentives
            // 
            this.txtIncentives.Location = new System.Drawing.Point(1590, 443);
            this.txtIncentives.Name = "txtIncentives";
            this.txtIncentives.Size = new System.Drawing.Size(200, 20);
            this.txtIncentives.TabIndex = 79;
            this.txtIncentives.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtConveyance
            // 
            this.txtConveyance.Location = new System.Drawing.Point(1590, 407);
            this.txtConveyance.Name = "txtConveyance";
            this.txtConveyance.Size = new System.Drawing.Size(200, 20);
            this.txtConveyance.TabIndex = 78;
            this.txtConveyance.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtSubTotal1
            // 
            this.txtSubTotal1.Location = new System.Drawing.Point(1590, 372);
            this.txtSubTotal1.Name = "txtSubTotal1";
            this.txtSubTotal1.Size = new System.Drawing.Size(200, 20);
            this.txtSubTotal1.TabIndex = 77;
            this.txtSubTotal1.EditValueChanged += new System.EventHandler(this.txtSubTotal1_EditValueChanged);
            // 
            // txtDeducation
            // 
            this.txtDeducation.Location = new System.Drawing.Point(1590, 337);
            this.txtDeducation.Name = "txtDeducation";
            this.txtDeducation.Size = new System.Drawing.Size(200, 20);
            this.txtDeducation.TabIndex = 76;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1590, 301);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 75;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(1655, 263);
            this.btn_Print.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btn_Print.LookAndFeel.SkinName = "DevExpress Style";
            this.btn_Print.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(135, 23);
            this.btn_Print.TabIndex = 74;
            this.btn_Print.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(1426, 229);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 18);
            this.labelControl12.TabIndex = 73;
            this.labelControl12.Text = "Order By";
            // 
            // drpOrderBy
            // 
            this.drpOrderBy.EnterMoveNextControl = true;
            this.drpOrderBy.Location = new System.Drawing.Point(1590, 227);
            this.drpOrderBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpOrderBy.Name = "drpOrderBy";
            this.drpOrderBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpOrderBy.Properties.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.drpOrderBy.Size = new System.Drawing.Size(200, 20);
            this.drpOrderBy.TabIndex = 72;
            this.drpOrderBy.SelectedIndexChanged += new System.EventHandler(this.drpOrderBy_SelectedIndexChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(1426, 191);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(59, 18);
            this.labelControl11.TabIndex = 71;
            this.labelControl11.Text = "Sort By";
            // 
            // drpSortBy
            // 
            this.drpSortBy.EnterMoveNextControl = true;
            this.drpSortBy.Location = new System.Drawing.Point(1590, 189);
            this.drpSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpSortBy.Name = "drpSortBy";
            this.drpSortBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpSortBy.Size = new System.Drawing.Size(200, 20);
            this.drpSortBy.TabIndex = 7;
            this.drpSortBy.SelectedIndexChanged += new System.EventHandler(this.drpSortBy_SelectedIndexChanged);
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.labelControl10);
            this.panelControl5.Controls.Add(this.labelControl9);
            this.panelControl5.Controls.Add(this.txtSubClient);
            this.panelControl5.Controls.Add(this.txtClientName);
            this.panelControl5.Controls.Add(this.txtDirector);
            this.panelControl5.Controls.Add(this.labelControl8);
            this.panelControl5.Controls.Add(this.drpSubClient);
            this.panelControl5.Controls.Add(this.drpCCompany);
            this.panelControl5.Controls.Add(this.drpMainCompany);
            this.panelControl5.Controls.Add(this.labelControl32);
            this.panelControl5.Controls.Add(this.labelControl7);
            this.panelControl5.Controls.Add(this.labelControl6);
            this.panelControl5.Location = new System.Drawing.Point(896, 68);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(899, 104);
            this.panelControl5.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(530, 78);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(137, 18);
            this.labelControl10.TabIndex = 70;
            this.labelControl10.Text = "Sub Client Name";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(530, 42);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(101, 18);
            this.labelControl9.TabIndex = 69;
            this.labelControl9.Text = "Client Name";
            // 
            // txtSubClient
            // 
            this.txtSubClient.Location = new System.Drawing.Point(694, 75);
            this.txtSubClient.Name = "txtSubClient";
            this.txtSubClient.Size = new System.Drawing.Size(200, 20);
            this.txtSubClient.TabIndex = 68;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(694, 38);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(200, 20);
            this.txtClientName.TabIndex = 67;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(694, 5);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(200, 20);
            this.txtDirector.TabIndex = 66;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(530, 8);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 18);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Director";
            // 
            // drpSubClient
            // 
            this.drpSubClient.EnterMoveNextControl = true;
            this.drpSubClient.Location = new System.Drawing.Point(241, 80);
            this.drpSubClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpSubClient.Name = "drpSubClient";
            this.drpSubClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpSubClient.Size = new System.Drawing.Size(234, 20);
            this.drpSubClient.TabIndex = 65;
            this.drpSubClient.SelectedIndexChanged += new System.EventHandler(this.drpSubClient_SelectedIndexChanged);
            // 
            // drpCCompany
            // 
            this.drpCCompany.EnterMoveNextControl = true;
            this.drpCCompany.Location = new System.Drawing.Point(241, 38);
            this.drpCCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpCCompany.Name = "drpCCompany";
            this.drpCCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCCompany.Size = new System.Drawing.Size(234, 20);
            this.drpCCompany.TabIndex = 64;
            this.drpCCompany.SelectedIndexChanged += new System.EventHandler(this.drpCCompany_SelectedIndexChanged);
            // 
            // drpMainCompany
            // 
            this.drpMainCompany.EnterMoveNextControl = true;
            this.drpMainCompany.Location = new System.Drawing.Point(241, 4);
            this.drpMainCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpMainCompany.Name = "drpMainCompany";
            this.drpMainCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpMainCompany.Size = new System.Drawing.Size(234, 20);
            this.drpMainCompany.TabIndex = 6;
            this.drpMainCompany.EditValueChanged += new System.EventHandler(this.drpMainCompany_EditValueChanged);
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Appearance.Options.UseFont = true;
            this.labelControl32.Location = new System.Drawing.Point(5, 79);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(158, 18);
            this.labelControl32.TabIndex = 63;
            this.labelControl32.Text = "Sub Company Code";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(129, 18);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Client Company";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(119, 18);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Main Company";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.radCompanyWise);
            this.panelControl4.Location = new System.Drawing.Point(538, 68);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(316, 82);
            this.panelControl4.TabIndex = 4;
            // 
            // radCompanyWise
            // 
            this.radCompanyWise.Location = new System.Drawing.Point(5, 7);
            this.radCompanyWise.Name = "radCompanyWise";
            this.radCompanyWise.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radCompanyWise.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompanyWise.Properties.Appearance.Options.UseBackColor = true;
            this.radCompanyWise.Properties.Appearance.Options.UseFont = true;
            this.radCompanyWise.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radCompanyWise.Properties.Columns = 1;
            this.radCompanyWise.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Client Company Wise", true, null, "Client Company Wise"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Sub Client Company Wise", true, null, "Sub Client Company Wise")});
            this.radCompanyWise.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.radCompanyWise.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.radCompanyWise.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radCompanyWise.Size = new System.Drawing.Size(277, 68);
            this.radCompanyWise.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtBillNo);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.ddFrom);
            this.panelControl3.Controls.Add(this.ddTo);
            this.panelControl3.Controls.Add(this.ddDate);
            this.panelControl3.Location = new System.Drawing.Point(5, 68);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(527, 82);
            this.panelControl3.TabIndex = 3;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(79, 6);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(167, 20);
            this.txtBillNo.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(277, 50);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 18);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "To";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(277, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "From";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Bill No";
            // 
            // ddFrom
            // 
            this.ddFrom.EditValue = null;
            this.ddFrom.Location = new System.Drawing.Point(377, 6);
            this.ddFrom.Name = "ddFrom";
            this.ddFrom.Properties.BeepOnError = false;
            this.ddFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddFrom.Properties.DisplayFormat.FormatString = "";
            this.ddFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddFrom.Properties.EditFormat.FormatString = "";
            this.ddFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddFrom.Properties.MaskSettings.Set("mask", "d");
            this.ddFrom.Properties.UseMaskAsDisplayFormat = true;
            this.ddFrom.Size = new System.Drawing.Size(133, 20);
            this.ddFrom.TabIndex = 9;
            // 
            // ddTo
            // 
            this.ddTo.EditValue = null;
            this.ddTo.Location = new System.Drawing.Point(377, 48);
            this.ddTo.Name = "ddTo";
            this.ddTo.Properties.BeepOnError = false;
            this.ddTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddTo.Properties.DisplayFormat.FormatString = "";
            this.ddTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddTo.Properties.EditFormat.FormatString = "";
            this.ddTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddTo.Properties.MaskSettings.Set("mask", "d");
            this.ddTo.Properties.UseMaskAsDisplayFormat = true;
            this.ddTo.Size = new System.Drawing.Size(133, 20);
            this.ddTo.TabIndex = 10;
            this.ddTo.EditValueChanged += new System.EventHandler(this.comboBoxEdit3_EditValueChanged);
            // 
            // ddDate
            // 
            this.ddDate.EditValue = null;
            this.ddDate.Location = new System.Drawing.Point(79, 51);
            this.ddDate.Name = "ddDate";
            this.ddDate.Properties.BeepOnError = false;
            this.ddDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddDate.Properties.DisplayFormat.FormatString = "";
            this.ddDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddDate.Properties.EditFormat.FormatString = "";
            this.ddDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddDate.Properties.MaskSettings.Set("mask", "d");
            this.ddDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddDate.Size = new System.Drawing.Size(167, 20);
            this.ddDate.TabIndex = 8;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1790, 56);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 29);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Labour Bill";
            // 
            // colModelName
            // 
            this.colModelName.FieldName = "ModelName";
            this.colModelName.Name = "colModelName";
            this.colModelName.Visible = true;
            this.colModelName.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // colProductSize
            // 
            this.colProductSize.FieldName = "ProductSize";
            this.colProductSize.Name = "colProductSize";
            this.colProductSize.Visible = true;
            this.colProductSize.VisibleIndex = 2;
            // 
            // colQuantityPiece
            // 
            this.colQuantityPiece.FieldName = "QuantityPiece";
            this.colQuantityPiece.Name = "colQuantityPiece";
            this.colQuantityPiece.Visible = true;
            this.colQuantityPiece.VisibleIndex = 3;
            // 
            // colWagesforEmp
            // 
            this.colWagesforEmp.FieldName = "WagesforEmp";
            this.colWagesforEmp.Name = "colWagesforEmp";
            this.colWagesforEmp.Visible = true;
            this.colWagesforEmp.VisibleIndex = 4;
            // 
            // colTotalQty
            // 
            this.colTotalQty.FieldName = "TotalQty";
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 5;
            // 
            // colNetAmt
            // 
            this.colNetAmt.FieldName = "NetAmt";
            this.colNetAmt.Name = "colNetAmt";
            this.colNetAmt.Visible = true;
            this.colNetAmt.VisibleIndex = 6;
            // 
            // colTotalAmt
            // 
            this.colTotalAmt.FieldName = "TotalAmt";
            this.colTotalAmt.Name = "colTotalAmt";
            this.colTotalAmt.Visible = true;
            this.colTotalAmt.VisibleIndex = 7;
            // 
            // FrmDirectLabourBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1838, 857);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "FrmDirectLabourBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDirectLabourBill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDirectLabourBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.panelControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBonus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radESI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProduction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtESI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncentivePercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuperVisor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdvance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalBouns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalESI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPFText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductionIncentive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrandTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupVisorTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncentives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConveyance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeducation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpOrderBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpSortBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpSubClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMainCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCompanyWise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBillNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit ddFrom;
        private DevExpress.XtraEditors.DateEdit ddTo;
        private DevExpress.XtraEditors.DateEdit ddDate;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.RadioGroup radCompanyWise;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.ComboBoxEdit drpSubClient;
        private DevExpress.XtraEditors.ComboBoxEdit drpCCompany;
        private DevExpress.XtraEditors.ComboBoxEdit drpMainCompany;
        private DevExpress.XtraEditors.TextEdit txtSubClient;
        private DevExpress.XtraEditors.TextEdit txtClientName;
        private DevExpress.XtraEditors.TextEdit txtDirector;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit drpOrderBy;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit drpSortBy;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.TextEdit txtTotalBouns;
        private DevExpress.XtraEditors.TextEdit TxtTotalESI;
        private DevExpress.XtraEditors.TextEdit txtPFText;
        private DevExpress.XtraEditors.TextEdit txtProductionIncentive;
        private DevExpress.XtraEditors.TextEdit txtGrandTotal;
        private DevExpress.XtraEditors.TextEdit txtSupVisorTotal;
        private DevExpress.XtraEditors.TextEdit txtSubTotal2;
        private DevExpress.XtraEditors.TextEdit txtIncentives;
        private DevExpress.XtraEditors.TextEdit txtConveyance;
        private DevExpress.XtraEditors.TextEdit txtSubTotal1;
        private DevExpress.XtraEditors.TextEdit txtDeducation;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtNetAmount;
        private DevExpress.XtraEditors.TextEdit txtAdvance;
        private DevExpress.XtraEditors.TextEdit txtFinalTotal;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtSuperVisor;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtBonus;
        private DevExpress.XtraEditors.TextEdit txtESI;
        private DevExpress.XtraEditors.TextEdit txtpf;
        private DevExpress.XtraEditors.TextEdit txtIncentivePercent;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.RadioGroup radBonus;
        private DevExpress.XtraEditors.RadioGroup radESI;
        private DevExpress.XtraEditors.RadioGroup radProduction;
        private DevExpress.XtraEditors.RadioGroup radPF;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.RadioGroup radioGroup6;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.CalcEdit calcEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colModelName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSize;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPiece;
        private DevExpress.XtraGrid.Columns.GridColumn colWagesforEmp;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmt;
    }
}