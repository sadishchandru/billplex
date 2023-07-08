
namespace BillPlex
{
    partial class FrmRawMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRawMaterial));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterials = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterialType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawMaterialStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btClear = new DevExpress.XtraEditors.SimpleButton();
            this.btExit = new DevExpress.XtraEditors.SimpleButton();
            this.btDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtRawMaterial = new DevExpress.XtraEditors.TextEdit();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(10, 10);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1516, 104);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(658, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Raw Material";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.txtSearch);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.svgImageBox1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.txtRawMaterial);
            this.panelControl2.Controls.Add(this.txtStock);
            this.panelControl2.Controls.Add(this.txtType);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(11, 119);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1515, 734);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetRawMaterial";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(48, 396);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1343, 333);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetRawMaterial";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetRawMaterial";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colRawMaterials,
            this.colRawMaterialType,
            this.colRawMaterialStock});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colRawMaterials
            // 
            this.colRawMaterials.FieldName = "RawMaterials";
            this.colRawMaterials.Name = "colRawMaterials";
            this.colRawMaterials.Visible = true;
            this.colRawMaterials.VisibleIndex = 1;
            // 
            // colRawMaterialType
            // 
            this.colRawMaterialType.FieldName = "RawMaterialType";
            this.colRawMaterialType.Name = "colRawMaterialType";
            this.colRawMaterialType.Visible = true;
            this.colRawMaterialType.VisibleIndex = 2;
            // 
            // colRawMaterialStock
            // 
            this.colRawMaterialStock.FieldName = "RawMaterialStock";
            this.colRawMaterialStock.Name = "colRawMaterialStock";
            this.colRawMaterialStock.Visible = true;
            this.colRawMaterialStock.VisibleIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(289, 358);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(432, 20);
            this.txtSearch.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(53, 354);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(169, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Search Raw Material";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(781, 55);
            this.svgImageBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(610, 318);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 10;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btClear);
            this.panelControl3.Controls.Add(this.btExit);
            this.panelControl3.Controls.Add(this.btDelete);
            this.panelControl3.Controls.Add(this.btEdit);
            this.panelControl3.Controls.Add(this.btUpdate);
            this.panelControl3.Controls.Add(this.btnAdd);
            this.panelControl3.Location = new System.Drawing.Point(89, 230);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(632, 81);
            this.panelControl3.TabIndex = 9;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(417, 27);
            this.btClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(81, 24);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "CLEAR";
            this.btClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(516, 27);
            this.btExit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(81, 24);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "EXIT";
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(309, 27);
            this.btDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(81, 24);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "DELETE";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(109, 27);
            this.btEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(81, 24);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "EDIT";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(208, 27);
            this.btUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btUpdate.LookAndFeel.SkinName = "DevExpress Style";
            this.btUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(81, 24);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 27);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 24);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRawMaterial
            // 
            this.txtRawMaterial.Location = new System.Drawing.Point(284, 102);
            this.txtRawMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawMaterial.Name = "txtRawMaterial";
            this.txtRawMaterial.Size = new System.Drawing.Size(432, 20);
            this.txtRawMaterial.TabIndex = 8;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(284, 174);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(432, 20);
            this.txtStock.TabIndex = 7;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(284, 43);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(432, 20);
            this.txtType.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(232, 165);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 27);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(219, 96);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 27);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "*";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(48, 100);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(158, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Enter Raw Material";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 167);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(167, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Enter Stock Qty (Kg)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 40);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Enter The Type";
            // 
            // FrmRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 916);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRawMaterial";
            this.Text = "FrmRawMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRawMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btClear;
        private DevExpress.XtraEditors.SimpleButton btExit;
        private DevExpress.XtraEditors.SimpleButton btDelete;
        private DevExpress.XtraEditors.SimpleButton btEdit;
        private DevExpress.XtraEditors.SimpleButton btUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtRawMaterial;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterials;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterialType;
        private DevExpress.XtraGrid.Columns.GridColumn colRawMaterialStock;
    }
}