
namespace BillPlex
{
    partial class NavBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBar));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.ClientCompany_Click = new DevExpress.XtraBars.BarButtonItem();
            this.SubClient_Btn_Click = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerDetails = new DevExpress.XtraBars.BarButtonItem();
            this.MasterCompany_Btn_Click = new DevExpress.XtraBars.BarButtonItem();
            this.btn_EmployeeMaster = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Master_Group_btn_Click = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barSubItem1,
            this.ClientCompany_Click,
            this.SubClient_Btn_Click,
            this.btnCustomerDetails,
            this.MasterCompany_Btn_Click,
            this.btn_EmployeeMaster,
            this.barSubItem2,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1031, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Master_Company_Click);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 5;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // ClientCompany_Click
            // 
            this.ClientCompany_Click.Caption = "Client Company";
            this.ClientCompany_Click.Id = 7;
            this.ClientCompany_Click.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ClientCompany_Click.ImageOptions.SvgImage")));
            this.ClientCompany_Click.Name = "ClientCompany_Click";
            this.ClientCompany_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClientCompany_ItemClick);
            // 
            // SubClient_Btn_Click
            // 
            this.SubClient_Btn_Click.Caption = "Sub-Client Company";
            this.SubClient_Btn_Click.Id = 8;
            this.SubClient_Btn_Click.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SubClient_Btn_Click.ImageOptions.SvgImage")));
            this.SubClient_Btn_Click.Name = "SubClient_Btn_Click";
            this.SubClient_Btn_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SubClient_ItemClick);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.Caption = "Customer Master";
            this.btnCustomerDetails.Id = 9;
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CustomerMaster_ItemClick);
            // 
            // MasterCompany_Btn_Click
            // 
            this.MasterCompany_Btn_Click.Caption = "Master Company";
            this.MasterCompany_Btn_Click.Id = 10;
            this.MasterCompany_Btn_Click.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MasterCompany_Btn_Click.ImageOptions.SvgImage")));
            this.MasterCompany_Btn_Click.Name = "MasterCompany_Btn_Click";
            this.MasterCompany_Btn_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MasterCompany_ItemClick);
            // 
            // btn_EmployeeMaster
            // 
            this.btn_EmployeeMaster.Caption = "Employee Master";
            this.btn_EmployeeMaster.Id = 11;
            this.btn_EmployeeMaster.Name = "btn_EmployeeMaster";
            this.btn_EmployeeMaster.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Employee_Master);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonPageCategory1.Text = "BillPlex";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Masters";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomerDetails, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_EmployeeMaster, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Masters";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Master_Group_btn_Click,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Profile";
            // 
            // Master_Group_btn_Click
            // 
            this.Master_Group_btn_Click.ItemLinks.Add(this.MasterCompany_Btn_Click);
            this.Master_Group_btn_Click.ItemLinks.Add(this.ClientCompany_Click, true);
            this.Master_Group_btn_Click.ItemLinks.Add(this.SubClient_Btn_Click, true);
            this.Master_Group_btn_Click.Name = "Master_Group_btn_Click";
            this.Master_Group_btn_Click.Text = "Profile";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 661);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1031, 24);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup2.ImageOptions.SvgImage")));
            this.ribbonPageGroup2.ItemLinks.Add(this.barSubItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Banking Details";
            this.barSubItem2.Id = 14;
            this.barSubItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem2.ImageOptions.SvgImage")));
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Client";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sub Clinet";
            this.barButtonItem3.Id = 17;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Master";
            this.barButtonItem4.Id = 18;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 685);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("NavBar.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "NavBar";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Master_Group_btn_Click;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem ClientCompany_Click;
        private DevExpress.XtraBars.BarButtonItem SubClient_Btn_Click;
        private DevExpress.XtraBars.BarButtonItem btnCustomerDetails;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem MasterCompany_Btn_Click;
        private DevExpress.XtraBars.BarButtonItem btn_EmployeeMaster;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}