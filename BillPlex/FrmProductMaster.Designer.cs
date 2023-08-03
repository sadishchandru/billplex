
namespace BillPlex
{
    partial class FrmProductMaster
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductMaster));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.grd_productmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductmodel = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.txtPName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_productmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.txtSearch);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.svgImageBox1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.txtPName);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(5, 60);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1583, 652);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(273, 60);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 22);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "*";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetProductmodeltemp";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(5, 283);
            this.gridControl1.MainView = this.grd_productmaster;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1573, 365);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_productmaster});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery4.Name = "PRO_GetProductmodeltemp";
            queryParameter4.Name = "@SearchKey";
            queryParameter4.Type = typeof(string);
            storedProcQuery4.Parameters.Add(queryParameter4);
            storedProcQuery4.StoredProcName = "PRO_GetProductmodeltemp";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // grd_productmaster
            // 
            this.grd_productmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colProductmodel});
            this.grd_productmaster.DetailHeight = 284;
            this.grd_productmaster.GridControl = this.gridControl1;
            this.grd_productmaster.Name = "grd_productmaster";
            this.grd_productmaster.DoubleClick += new System.EventHandler(this.btEdit_Click);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 23;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 86;
            // 
            // colProductmodel
            // 
            this.colProductmodel.FieldName = "Productmodel";
            this.colProductmodel.MinWidth = 23;
            this.colProductmodel.Name = "colProductmodel";
            this.colProductmodel.Visible = true;
            this.colProductmodel.VisibleIndex = 1;
            this.colProductmodel.Width = 86;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(290, 243);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(432, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(54, 240);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(182, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Search Raw Material";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(885, 17);
            this.svgImageBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(382, 242);
            this.svgImageBox1.SvgImage = global::BillPlex.Properties.Resources.Product_Master;
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
            this.panelControl3.Location = new System.Drawing.Point(194, 132);
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
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(514, 27);
            this.btExit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(81, 24);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "EXIT";
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
            this.btEdit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
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
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(357, 64);
            this.txtPName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(432, 20);
            this.txtPName.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(121, 61);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Product Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(5, 4);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1583, 49);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(733, 9);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(205, 29);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Product Master";
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl4.Controls.Add(this.panelControl1);
            this.panelControl4.Controls.Add(this.panelControl2);
            this.panelControl4.Location = new System.Drawing.Point(13, 13);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1593, 716);
            this.panelControl4.TabIndex = 4;
            // 
            // FrmProductMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1618, 743);
            this.Controls.Add(this.panelControl4);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProductMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_productmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_productmaster;
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
        private DevExpress.XtraEditors.TextEdit txtPName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductmodel;
        private DevExpress.XtraEditors.PanelControl panelControl4;
    }
}