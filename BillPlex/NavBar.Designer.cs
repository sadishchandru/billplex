
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
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_RawMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ProductMaster = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SizeMaster = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ColorMaster = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ProductModel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Master_Group_btn_Click = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
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
            this.barButtonItem4,
            this.barButtonItem5,
            this.btn_RawMaterial,
            this.btn_ProductMaster,
            this.btn_SizeMaster,
            this.btn_ColorMaster,
            this.btn_ProductModel,
            this.barButtonItem11,
            this.barButtonItem12});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 27;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1752, 178);
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
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Master";
            this.barButtonItem4.Id = 18;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "OrderMaster";
            this.barButtonItem5.Id = 19;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // btn_RawMaterial
            // 
            this.btn_RawMaterial.Caption = "Raw Material";
            this.btn_RawMaterial.Id = 20;
            this.btn_RawMaterial.Name = "btn_RawMaterial";
            this.btn_RawMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_RawMaterial_ItemClick);
            // 
            // btn_ProductMaster
            // 
            this.btn_ProductMaster.Caption = "Product Master";
            this.btn_ProductMaster.Id = 21;
            this.btn_ProductMaster.Name = "btn_ProductMaster";
            this.btn_ProductMaster.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ProductMaster_ItemClick);
            // 
            // btn_SizeMaster
            // 
            this.btn_SizeMaster.Caption = "Size Master";
            this.btn_SizeMaster.Id = 22;
            this.btn_SizeMaster.Name = "btn_SizeMaster";
            this.btn_SizeMaster.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SizeMaster_ItemClick);
            // 
            // btn_ColorMaster
            // 
            this.btn_ColorMaster.Caption = "Color Master";
            this.btn_ColorMaster.Id = 23;
            this.btn_ColorMaster.Name = "btn_ColorMaster";
            this.btn_ColorMaster.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ColorMaster_ItemClick);
            // 
            // btn_ProductModel
            // 
            this.btn_ProductModel.Caption = "Product Model";
            this.btn_ProductModel.Id = 24;
            this.btn_ProductModel.Name = "btn_ProductModel";
            this.btn_ProductModel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ProductModel_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Finishing Product Model";
            this.barButtonItem11.Id = 25;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Incentive Master";
            this.barButtonItem12.Id = 26;
            this.barButtonItem12.Name = "barButtonItem12";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_RawMaterial, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ProductMaster, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_SizeMaster, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ColorMaster, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ProductModel, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem11, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem12, true);
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
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup2.ImageOptions.SvgImage")));
            this.ribbonPageGroup2.ItemLinks.Add(this.barSubItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 657);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1752, 28);
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 685);
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btn_RawMaterial;
        private DevExpress.XtraBars.BarButtonItem btn_ProductMaster;
        private DevExpress.XtraBars.BarButtonItem btn_SizeMaster;
        private DevExpress.XtraBars.BarButtonItem btn_ColorMaster;
        private DevExpress.XtraBars.BarButtonItem btn_ProductModel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
    }
}