
namespace BillPlex
{
    partial class FrmJobReceivedProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJobReceivedProfile));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.panelDeliveryChallan = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbFind = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnclr = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDeliveryChallan)).BeginInit();
            this.panelDeliveryChallan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Location = new System.Drawing.Point(12, 3);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1574, 825);
            this.panelControl3.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnEdit);
            this.panelControl2.Controls.Add(this.btnExit);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.btnClear);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnUpdate);
            this.panelControl2.Controls.Add(this.btnNew);
            this.panelControl2.Location = new System.Drawing.Point(1393, 309);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(117, 240);
            this.panelControl2.TabIndex = 32;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(25, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "EDIT";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnExit.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnExit.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btnExit.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btnExit.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.btnExit.AppearanceDisabled.Options.UseBackColor = true;
            this.btnExit.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnExit.AppearanceDisabled.Options.UseForeColor = true;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnExit.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnExit.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.Options.UseBorderColor = true;
            this.btnExit.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnExit.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.btnExit.AppearancePressed.BorderColor = System.Drawing.Color.Aqua;
            this.btnExit.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnExit.AppearancePressed.Options.UseBackColor = true;
            this.btnExit.AppearancePressed.Options.UseBorderColor = true;
            this.btnExit.AppearancePressed.Options.UseForeColor = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Location = new System.Drawing.Point(25, 192);
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "EXIT";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btnAdd.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdd.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnAdd.AppearanceDisabled.Options.UseForeColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseBorderColor = true;
            this.btnAdd.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.btnAdd.AppearancePressed.BorderColor = System.Drawing.Color.Aqua;
            this.btnAdd.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.AppearancePressed.Options.UseBackColor = true;
            this.btnAdd.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdd.AppearancePressed.Options.UseForeColor = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Location = new System.Drawing.Point(25, 46);
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "ADD";
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnClear.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseBorderColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseForeColor = true;
            this.btnClear.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnClear.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btnClear.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btnClear.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.btnClear.AppearanceDisabled.Options.UseBackColor = true;
            this.btnClear.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnClear.AppearanceDisabled.Options.UseForeColor = true;
            this.btnClear.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnClear.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnClear.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnClear.AppearanceHovered.Options.UseBackColor = true;
            this.btnClear.AppearanceHovered.Options.UseBorderColor = true;
            this.btnClear.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnClear.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.btnClear.AppearancePressed.BorderColor = System.Drawing.Color.Aqua;
            this.btnClear.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnClear.AppearancePressed.Options.UseBackColor = true;
            this.btnClear.AppearancePressed.Options.UseBorderColor = true;
            this.btnClear.AppearancePressed.Options.UseForeColor = true;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Location = new System.Drawing.Point(25, 161);
            this.btnClear.LookAndFeel.SkinName = "DevExpress Style";
            this.btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "CLEAR";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(25, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(25, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(25, 16);
            this.btnNew.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnNew.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.checkEdit1);
            this.panelControl4.Controls.Add(this.panelDeliveryChallan);
            this.panelControl4.Location = new System.Drawing.Point(42, 70);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1345, 722);
            this.panelControl4.TabIndex = 6;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(1053, 33);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "View DailyReceived";
            this.checkEdit1.Size = new System.Drawing.Size(217, 23);
            this.checkEdit1.TabIndex = 87;
            // 
            // panelDeliveryChallan
            // 
            this.panelDeliveryChallan.Controls.Add(this.gridControl1);
            this.panelDeliveryChallan.Controls.Add(this.cmbFind);
            this.panelDeliveryChallan.Controls.Add(this.btnclr);
            this.panelDeliveryChallan.Controls.Add(this.btnFind);
            this.panelDeliveryChallan.Location = new System.Drawing.Point(16, 79);
            this.panelDeliveryChallan.Name = "panelDeliveryChallan";
            this.panelDeliveryChallan.Size = new System.Drawing.Size(1324, 610);
            this.panelDeliveryChallan.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(10, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1303, 540);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // cmbFind
            // 
            this.cmbFind.Location = new System.Drawing.Point(21, 22);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFind.Size = new System.Drawing.Size(433, 20);
            this.cmbFind.TabIndex = 2;
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(562, 25);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 23);
            this.btnclr.TabIndex = 2;
            this.btnclr.Text = "Clear";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(481, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(42, 14);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1244, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(486, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Job Received ";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetJobReceived";
            queryParameter1.Name = "@SearchKey";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetJobReceived";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // FrmJobReceivedProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 866);
            this.Controls.Add(this.panelControl3);
            this.Name = "FrmJobReceivedProfile";
            this.Text = "FrmJobReceivedProfile";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDeliveryChallan)).EndInit();
            this.panelDeliveryChallan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.PanelControl panelDeliveryChallan;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbFind;
        private DevExpress.XtraEditors.SimpleButton btnclr;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}