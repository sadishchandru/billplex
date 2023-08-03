
namespace BillPlex
{
    partial class FrmSizeMaster
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSizeMaster));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelAvailable = new DevExpress.XtraEditors.LabelControl();
            this.LabelExceed = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.SizeMasterGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.txtSName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeMasterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(5, 4);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1441, 49);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.labelAvailable);
            this.panelControl2.Controls.Add(this.LabelExceed);
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtSearch);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.svgImageBox1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.txtSName);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(5, 57);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1442, 546);
            this.panelControl2.TabIndex = 5;
            // 
            // labelAvailable
            // 
            this.labelAvailable.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailable.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelAvailable.Appearance.Options.UseFont = true;
            this.labelAvailable.Appearance.Options.UseForeColor = true;
            this.labelAvailable.Location = new System.Drawing.Point(300, 65);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(75, 18);
            this.labelAvailable.TabIndex = 35;
            this.labelAvailable.Text = "Available";
            // 
            // LabelExceed
            // 
            this.LabelExceed.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExceed.Appearance.ForeColor = System.Drawing.Color.Red;
            this.LabelExceed.Appearance.Options.UseFont = true;
            this.LabelExceed.Appearance.Options.UseForeColor = true;
            this.LabelExceed.Location = new System.Drawing.Point(616, 65);
            this.LabelExceed.Name = "LabelExceed";
            this.LabelExceed.Size = new System.Drawing.Size(116, 18);
            this.LabelExceed.TabIndex = 34;
            this.LabelExceed.Text = "Already Exists";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetSizeMaster";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(157, 237);
            this.gridControl1.MainView = this.SizeMasterGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(599, 298);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SizeMasterGrid});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery3.Name = "PRO_GetSizeMaster";
            queryParameter3.Name = "@SearchKey";
            queryParameter3.Type = typeof(string);
            storedProcQuery3.Parameters.Add(queryParameter3);
            storedProcQuery3.StoredProcName = "PRO_GetSizeMaster";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlBST19HZXRTaXplTWFzdGVyI" +
    "j48RmllbGQgTmFtZT0iSUQiIFR5cGU9IkludDMyIiAvPjxGaWVsZCBOYW1lPSJTaXplbmFtZSIgVHlwZ" +
    "T0iU3RyaW5nIiAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // SizeMasterGrid
            // 
            this.SizeMasterGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.colSizename});
            this.SizeMasterGrid.GridControl = this.gridControl1;
            this.SizeMasterGrid.Name = "SizeMasterGrid";
            // 
            // Id
            // 
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // colSizename
            // 
            this.colSizename.FieldName = "Sizename";
            this.colSizename.Name = "colSizename";
            this.colSizename.Visible = true;
            this.colSizename.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(215, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 22);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "*";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(324, 193);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(432, 20);
            this.txtSearch.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(88, 190);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(147, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Search Size Name";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(853, 31);
            this.svgImageBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(543, 177);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
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
            this.panelControl3.Location = new System.Drawing.Point(88, 112);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(632, 50);
            this.panelControl3.TabIndex = 9;
            // 
            // btClear
            // 
            this.btClear.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Appearance.Options.UseFont = true;
            this.btClear.Location = new System.Drawing.Point(421, 13);
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
            this.btExit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Appearance.Options.UseFont = true;
            this.btExit.Location = new System.Drawing.Point(518, 13);
            this.btExit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(81, 24);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "EXIT";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Appearance.Options.UseFont = true;
            this.btDelete.Location = new System.Drawing.Point(313, 13);
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
            this.btEdit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Appearance.Options.UseFont = true;
            this.btEdit.Location = new System.Drawing.Point(113, 13);
            this.btEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(81, 24);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "EDIT";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Appearance.Options.UseFont = true;
            this.btUpdate.Location = new System.Drawing.Point(212, 13);
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
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(13, 13);
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
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(300, 39);
            this.txtSName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(432, 20);
            this.txtSName.TabIndex = 6;
            this.txtSName.EditValueChanged += new System.EventHandler(this.txtSName_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(88, 46);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Size Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(627, 7);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(186, 35);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Size Master";
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl4.Controls.Add(this.panelControl2);
            this.panelControl4.Controls.Add(this.panelControl1);
            this.panelControl4.Location = new System.Drawing.Point(13, 13);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1454, 611);
            this.panelControl4.TabIndex = 6;
            // 
            // FrmSizeMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1481, 636);
            this.Controls.Add(this.panelControl4);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSizeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSizeMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSizeMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeMasterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
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
        private DevExpress.XtraEditors.TextEdit txtSName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView SizeMasterGrid;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn colSizename;
        private DevExpress.XtraEditors.LabelControl LabelExceed;
        private DevExpress.XtraEditors.LabelControl labelAvailable;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
    }
}