
namespace BillPlex
{
    partial class FrmClientCompanyReport
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
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelSearchIndex = new DevExpress.XtraEditors.LabelControl();
            this.labelMonthlyreportwages = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelOrderby = new DevExpress.XtraEditors.LabelControl();
            this.labelSortby = new DevExpress.XtraEditors.LabelControl();
            this.drpOrderby = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpSortby = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelFrom = new DevExpress.XtraEditors.LabelControl();
            this.labelDirector = new DevExpress.XtraEditors.LabelControl();
            this.labelMainCompany = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.txtClientName = new DevExpress.XtraEditors.TextEdit();
            this.drpClientCompany = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpFrom = new DevExpress.XtraEditors.DateEdit();
            this.drpTo = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpOrderby.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpSortby.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpClientCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.labelMonthlyreportwages);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1790, 818);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.labelSearchIndex);
            this.panelControl4.Location = new System.Drawing.Point(14, 167);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(217, 42);
            this.panelControl4.TabIndex = 4;
            // 
            // labelSearchIndex
            // 
            this.labelSearchIndex.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchIndex.Appearance.Options.UseFont = true;
            this.labelSearchIndex.Location = new System.Drawing.Point(13, 15);
            this.labelSearchIndex.Name = "labelSearchIndex";
            this.labelSearchIndex.Size = new System.Drawing.Size(106, 18);
            this.labelSearchIndex.TabIndex = 0;
            this.labelSearchIndex.Text = "Search Index";
            // 
            // labelMonthlyreportwages
            // 
            this.labelMonthlyreportwages.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthlyreportwages.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelMonthlyreportwages.Appearance.Options.UseFont = true;
            this.labelMonthlyreportwages.Appearance.Options.UseForeColor = true;
            this.labelMonthlyreportwages.Location = new System.Drawing.Point(861, 22);
            this.labelMonthlyreportwages.Name = "labelMonthlyreportwages";
            this.labelMonthlyreportwages.Size = new System.Drawing.Size(354, 29);
            this.labelMonthlyreportwages.TabIndex = 11;
            this.labelMonthlyreportwages.Text = "MONTHLY REPORT WAGES";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelOrderby);
            this.panelControl3.Controls.Add(this.labelSortby);
            this.panelControl3.Controls.Add(this.drpOrderby);
            this.panelControl3.Controls.Add(this.drpSortby);
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Location = new System.Drawing.Point(243, 73);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1533, 683);
            this.panelControl3.TabIndex = 1;
            // 
            // labelOrderby
            // 
            this.labelOrderby.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderby.Appearance.Options.UseFont = true;
            this.labelOrderby.Location = new System.Drawing.Point(1240, 45);
            this.labelOrderby.Name = "labelOrderby";
            this.labelOrderby.Size = new System.Drawing.Size(71, 18);
            this.labelOrderby.TabIndex = 12;
            this.labelOrderby.Text = "Order By";
            // 
            // labelSortby
            // 
            this.labelSortby.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortby.Appearance.Options.UseFont = true;
            this.labelSortby.Location = new System.Drawing.Point(924, 45);
            this.labelSortby.Name = "labelSortby";
            this.labelSortby.Size = new System.Drawing.Size(59, 18);
            this.labelSortby.TabIndex = 11;
            this.labelSortby.Text = "Sort By";
            // 
            // drpOrderby
            // 
            this.drpOrderby.Location = new System.Drawing.Point(1329, 43);
            this.drpOrderby.Name = "drpOrderby";
            this.drpOrderby.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpOrderby.Size = new System.Drawing.Size(185, 20);
            this.drpOrderby.TabIndex = 10;
            // 
            // drpSortby
            // 
            this.drpSortby.Location = new System.Drawing.Point(1021, 43);
            this.drpSortby.Name = "drpSortby";
            this.drpSortby.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpSortby.Size = new System.Drawing.Size(185, 20);
            this.drpSortby.TabIndex = 9;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.gridControl1);
            this.panelControl5.Location = new System.Drawing.Point(21, 94);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1498, 576);
            this.panelControl5.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(19, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1474, 533);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelFrom);
            this.panelControl2.Controls.Add(this.labelDirector);
            this.panelControl2.Controls.Add(this.labelMainCompany);
            this.panelControl2.Controls.Add(this.btnPrint);
            this.panelControl2.Controls.Add(this.txtClientName);
            this.panelControl2.Controls.Add(this.drpClientCompany);
            this.panelControl2.Controls.Add(this.drpFrom);
            this.panelControl2.Controls.Add(this.drpTo);
            this.panelControl2.Location = new System.Drawing.Point(14, 167);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(217, 383);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 266);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 18);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "To";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(-22, 283);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "To";
            // 
            // labelFrom
            // 
            this.labelFrom.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Appearance.Options.UseFont = true;
            this.labelFrom.Location = new System.Drawing.Point(13, 204);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(40, 18);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "From";
            // 
            // labelDirector
            // 
            this.labelDirector.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirector.Appearance.Options.UseFont = true;
            this.labelDirector.Location = new System.Drawing.Point(13, 133);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(101, 18);
            this.labelDirector.TabIndex = 11;
            this.labelDirector.Text = "Client Name";
            // 
            // labelMainCompany
            // 
            this.labelMainCompany.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCompany.Appearance.Options.UseFont = true;
            this.labelMainCompany.Location = new System.Drawing.Point(14, 64);
            this.labelMainCompany.Name = "labelMainCompany";
            this.labelMainCompany.Size = new System.Drawing.Size(123, 18);
            this.labelMainCompany.TabIndex = 10;
            this.labelMainCompany.Text = "ClientCompany";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(25, 340);
            this.btnPrint.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnPrint.LookAndFeel.SkinName = "DevExpress Style";
            this.btnPrint.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(162, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Location = new System.Drawing.Point(13, 157);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(184, 20);
            this.txtClientName.TabIndex = 6;
            // 
            // drpClientCompany
            // 
            this.drpClientCompany.Location = new System.Drawing.Point(13, 88);
            this.drpClientCompany.Name = "drpClientCompany";
            this.drpClientCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpClientCompany.Size = new System.Drawing.Size(183, 20);
            this.drpClientCompany.TabIndex = 5;
            this.drpClientCompany.SelectedIndexChanged += new System.EventHandler(this.drpClientCompany_SelectedIndexChanged);
            // 
            // drpFrom
            // 
            this.drpFrom.EditValue = null;
            this.drpFrom.Location = new System.Drawing.Point(11, 228);
            this.drpFrom.Name = "drpFrom";
            this.drpFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpFrom.Properties.DisplayFormat.FormatString = "";
            this.drpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.drpFrom.Properties.EditFormat.FormatString = "";
            this.drpFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.drpFrom.Properties.Mask.EditMask = "";
            this.drpFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.drpFrom.Size = new System.Drawing.Size(185, 20);
            this.drpFrom.TabIndex = 8;
            // 
            // drpTo
            // 
            this.drpTo.EditValue = null;
            this.drpTo.Location = new System.Drawing.Point(11, 290);
            this.drpTo.Name = "drpTo";
            this.drpTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpTo.Properties.DisplayFormat.FormatString = "";
            this.drpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.drpTo.Properties.EditFormat.FormatString = "";
            this.drpTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.drpTo.Properties.Mask.EditMask = "";
            this.drpTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.drpTo.Size = new System.Drawing.Size(185, 20);
            this.drpTo.TabIndex = 15;
            // 
            // FrmClientCompanyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 829);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmClientCompanyReport";
            this.Text = "FrmClientCompanyReport";
            this.Load += new System.EventHandler(this.FrmClientCompanyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpOrderby.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpSortby.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpClientCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpTo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelMonthlyreportwages;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelOrderby;
        private DevExpress.XtraEditors.LabelControl labelSortby;
        private DevExpress.XtraEditors.ComboBoxEdit drpOrderby;
        private DevExpress.XtraEditors.ComboBoxEdit drpSortby;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelFrom;
        private DevExpress.XtraEditors.LabelControl labelDirector;
        private DevExpress.XtraEditors.LabelControl labelMainCompany;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.TextEdit txtClientName;
        private DevExpress.XtraEditors.ComboBoxEdit drpClientCompany;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelSearchIndex;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit drpFrom;
        private DevExpress.XtraEditors.DateEdit drpTo;
    }
}