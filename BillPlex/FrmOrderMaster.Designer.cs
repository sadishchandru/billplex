
namespace BillPlex
{
    partial class FrmOrderMaster
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1777, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(878, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 40);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Order Master";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.simpleButton11);
            this.panelControl2.Controls.Add(this.simpleButton10);
            this.panelControl2.Controls.Add(this.simpleButton9);
            this.panelControl2.Controls.Add(this.simpleButton8);
            this.panelControl2.Controls.Add(this.simpleButton7);
            this.panelControl2.Controls.Add(this.simpleButton6);
            this.panelControl2.Controls.Add(this.simpleButton5);
            this.panelControl2.Controls.Add(this.simpleButton4);
            this.panelControl2.Controls.Add(this.radioGroup1);
            this.panelControl2.Location = new System.Drawing.Point(13, 134);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1777, 608);
            this.panelControl2.TabIndex = 1;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(891, 35);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Appearance.Options.UseForeColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.ColumnIndent = 5;
            this.radioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Open", true, ((short)(1)), "open"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cancel", true, ((short)(1)), "cancel"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Complete", true, ((short)(1)), "complete"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All", true, ((short)(1)), "all")});
            this.radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioGroup1.Size = new System.Drawing.Size(586, 96);
            this.radioGroup1.TabIndex = 0;
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton11.Appearance.Options.UseFont = true;
            this.simpleButton11.Location = new System.Drawing.Point(1617, 66);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(113, 101);
            this.simpleButton11.TabIndex = 58;
            this.simpleButton11.Text = "REFRESH";
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.Location = new System.Drawing.Point(1629, 207);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(91, 37);
            this.simpleButton10.TabIndex = 57;
            this.simpleButton10.Text = "NEW";
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Location = new System.Drawing.Point(1629, 533);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(91, 37);
            this.simpleButton9.TabIndex = 56;
            this.simpleButton9.Text = "EXIT";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Location = new System.Drawing.Point(1629, 372);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(91, 37);
            this.simpleButton8.TabIndex = 55;
            this.simpleButton8.Text = "UPDATE";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(1629, 425);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(91, 37);
            this.simpleButton7.TabIndex = 54;
            this.simpleButton7.Text = "DELETE";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Location = new System.Drawing.Point(1629, 480);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(91, 37);
            this.simpleButton6.TabIndex = 53;
            this.simpleButton6.Text = "CLEAR";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(1629, 264);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(91, 37);
            this.simpleButton5.TabIndex = 52;
            this.simpleButton5.Text = "ADD";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(1629, 320);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(91, 37);
            this.simpleButton4.TabIndex = 51;
            this.simpleButton4.Text = "EDIT";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 101);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1583, 502);
            this.gridControl1.TabIndex = 59;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FrmOrderMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 754);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmOrderMaster";
            this.Text = "FrmOrderMaster";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}