
namespace BillPlex
{
    partial class FrmOrderMasterInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderMasterInfo));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerCodeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RawType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RawMaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RawQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Deliverydate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalRaw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WagesforEmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.drpCustCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnProName = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustCode = new DevExpress.XtraEditors.SimpleButton();
            this.btnProColor = new DevExpress.XtraEditors.SimpleButton();
            this.drpProColor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpProductSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpModelCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpModelName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpCustName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.drpProductName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtsearch = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtTotRawmat = new DevExpress.XtraEditors.TextEdit();
            this.txtRawmatName = new DevExpress.XtraEditors.TextEdit();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.txtWages = new DevExpress.XtraEditors.TextEdit();
            this.txtMaterialwt = new DevExpress.XtraEditors.TextEdit();
            this.txtOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ddOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.ddProDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotRawmat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawmatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialwt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(10, 11);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1552, 81);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(597, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(170, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Order Master";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Controls.Add(this.btnNew);
            this.panelControl2.Controls.Add(this.btnExit);
            this.panelControl2.Controls.Add(this.btnUpdate);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnClear);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.btnEdit);
            this.panelControl2.Controls.Add(this.labelControl22);
            this.panelControl2.Controls.Add(this.labelControl21);
            this.panelControl2.Controls.Add(this.drpCustCode);
            this.panelControl2.Controls.Add(this.btnProName);
            this.panelControl2.Controls.Add(this.btnCustCode);
            this.panelControl2.Controls.Add(this.btnProColor);
            this.panelControl2.Controls.Add(this.drpProColor);
            this.panelControl2.Controls.Add(this.drpStatus);
            this.panelControl2.Controls.Add(this.drpProductSize);
            this.panelControl2.Controls.Add(this.drpModelCode);
            this.panelControl2.Controls.Add(this.drpModelName);
            this.panelControl2.Controls.Add(this.drpCustName);
            this.panelControl2.Controls.Add(this.drpProductName);
            this.panelControl2.Controls.Add(this.labelControl20);
            this.panelControl2.Controls.Add(this.txtsearch);
            this.panelControl2.Controls.Add(this.txtQuantity);
            this.panelControl2.Controls.Add(this.txtTotRawmat);
            this.panelControl2.Controls.Add(this.txtRawmatName);
            this.panelControl2.Controls.Add(this.txtType);
            this.panelControl2.Controls.Add(this.txtWages);
            this.panelControl2.Controls.Add(this.txtMaterialwt);
            this.panelControl2.Controls.Add(this.txtOrderNo);
            this.panelControl2.Controls.Add(this.labelControl19);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.labelControl14);
            this.panelControl2.Controls.Add(this.labelControl15);
            this.panelControl2.Controls.Add(this.labelControl16);
            this.panelControl2.Controls.Add(this.labelControl17);
            this.panelControl2.Controls.Add(this.labelControl18);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.ddOrderDate);
            this.panelControl2.Controls.Add(this.ddProDate);
            this.panelControl2.Location = new System.Drawing.Point(11, 106);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1551, 707);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PRO_GetOrderMasterByFilter";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(38, 487);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1433, 200);
            this.gridControl1.TabIndex = 51;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillPlex";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "PRO_GetOrderMasterByFilter";
            queryParameter1.Name = "@OrderNo";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "PRO_GetOrderMasterByFilter";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.OrderNo,
            this.OrderDate,
            this.CustomerCodeId,
            this.CustomerId,
            this.ProductId,
            this.ProductModel,
            this.ProductCode,
            this.ProductSize,
            this.Quantity,
            this.RawType,
            this.RawMaterialId,
            this.ColorId,
            this.RawQty,
            this.Deliverydate,
            this.status,
            this.TotalRaw,
            this.WagesforEmp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // OrderNo
            // 
            this.OrderNo.Caption = "OrderNo";
            this.OrderNo.FieldName = "OrderNo";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.Visible = true;
            this.OrderNo.VisibleIndex = 1;
            // 
            // OrderDate
            // 
            this.OrderDate.Caption = "OrderDate";
            this.OrderDate.FieldName = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Visible = true;
            this.OrderDate.VisibleIndex = 2;
            // 
            // CustomerCodeId
            // 
            this.CustomerCodeId.Caption = "CustomerCodeId";
            this.CustomerCodeId.FieldName = "CustomerCodeId";
            this.CustomerCodeId.Name = "CustomerCodeId";
            this.CustomerCodeId.Visible = true;
            this.CustomerCodeId.VisibleIndex = 3;
            // 
            // CustomerId
            // 
            this.CustomerId.Caption = "CustomerId";
            this.CustomerId.FieldName = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = true;
            this.CustomerId.VisibleIndex = 4;
            // 
            // ProductId
            // 
            this.ProductId.Caption = "ProductId";
            this.ProductId.FieldName = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = true;
            this.ProductId.VisibleIndex = 5;
            // 
            // ProductModel
            // 
            this.ProductModel.Caption = "ProductModel";
            this.ProductModel.FieldName = "ProductModel";
            this.ProductModel.Name = "ProductModel";
            this.ProductModel.Visible = true;
            this.ProductModel.VisibleIndex = 6;
            // 
            // ProductCode
            // 
            this.ProductCode.Caption = "ProductCode";
            this.ProductCode.FieldName = "ProductCode";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Visible = true;
            this.ProductCode.VisibleIndex = 7;
            // 
            // ProductSize
            // 
            this.ProductSize.Caption = "ProductSize";
            this.ProductSize.FieldName = "ProductSize";
            this.ProductSize.Name = "ProductSize";
            this.ProductSize.Visible = true;
            this.ProductSize.VisibleIndex = 8;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 9;
            // 
            // RawType
            // 
            this.RawType.Caption = "RawType";
            this.RawType.FieldName = "RawType";
            this.RawType.Name = "RawType";
            this.RawType.Visible = true;
            this.RawType.VisibleIndex = 11;
            // 
            // RawMaterialId
            // 
            this.RawMaterialId.Caption = "RawMaterialId";
            this.RawMaterialId.FieldName = "RawMaterialId";
            this.RawMaterialId.Name = "RawMaterialId";
            this.RawMaterialId.Visible = true;
            this.RawMaterialId.VisibleIndex = 10;
            // 
            // ColorId
            // 
            this.ColorId.Caption = "ColorId";
            this.ColorId.FieldName = "ColorId";
            this.ColorId.Name = "ColorId";
            this.ColorId.Visible = true;
            this.ColorId.VisibleIndex = 12;
            // 
            // RawQty
            // 
            this.RawQty.Caption = "RawQty";
            this.RawQty.FieldName = "RawQty";
            this.RawQty.Name = "RawQty";
            this.RawQty.Visible = true;
            this.RawQty.VisibleIndex = 13;
            // 
            // Deliverydate
            // 
            this.Deliverydate.Caption = "Deliverydate";
            this.Deliverydate.FieldName = "Deliverydate";
            this.Deliverydate.Name = "Deliverydate";
            this.Deliverydate.Visible = true;
            this.Deliverydate.VisibleIndex = 15;
            // 
            // status
            // 
            this.status.Caption = "status";
            this.status.FieldName = "status";
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 16;
            // 
            // TotalRaw
            // 
            this.TotalRaw.Caption = "TotalRaw";
            this.TotalRaw.FieldName = "TotalRaw";
            this.TotalRaw.Name = "TotalRaw";
            this.TotalRaw.Visible = true;
            this.TotalRaw.VisibleIndex = 14;
            // 
            // WagesforEmp
            // 
            this.WagesforEmp.Caption = "WagesforEmp";
            this.WagesforEmp.FieldName = "WagesforEmp";
            this.WagesforEmp.Name = "WagesforEmp";
            this.WagesforEmp.Visible = true;
            this.WagesforEmp.VisibleIndex = 17;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(1273, 34);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 60);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "REFRESH";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(1283, 140);
            this.btnNew.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 30);
            this.btnNew.TabIndex = 49;
            this.btnNew.Text = "NEW";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(1283, 405);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 30);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "EXIT";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(1283, 274);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(1283, 318);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 30);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(1283, 362);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 30);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(1283, 187);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LightBlue;
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(1283, 232);
            this.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.LightBlue;
            this.btnEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 30);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelControl22.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Appearance.Options.UseForeColor = true;
            this.labelControl22.Location = new System.Drawing.Point(118, 68);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(9, 17);
            this.labelControl22.TabIndex = 42;
            this.labelControl22.Text = "*";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl21.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Appearance.Options.UseForeColor = true;
            this.labelControl21.Location = new System.Drawing.Point(231, 142);
            this.labelControl21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(9, 17);
            this.labelControl21.TabIndex = 41;
            this.labelControl21.Text = "*";
            // 
            // drpCustCode
            // 
            this.drpCustCode.Location = new System.Drawing.Point(261, 145);
            this.drpCustCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpCustCode.Name = "drpCustCode";
            this.drpCustCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCustCode.Size = new System.Drawing.Size(141, 20);
            this.drpCustCode.TabIndex = 40;
            this.drpCustCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit10_SelectedIndexChanged);
            // 
            // btnProName
            // 
            this.btnProName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProName.Appearance.Options.UseFont = true;
            this.btnProName.Location = new System.Drawing.Point(551, 180);
            this.btnProName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProName.Name = "btnProName";
            this.btnProName.Size = new System.Drawing.Size(50, 24);
            this.btnProName.TabIndex = 39;
            this.btnProName.Text = "...";
            this.btnProName.Click += new System.EventHandler(this.btnProName_Click);
            // 
            // btnCustCode
            // 
            this.btnCustCode.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustCode.Appearance.Options.UseFont = true;
            this.btnCustCode.Location = new System.Drawing.Point(551, 142);
            this.btnCustCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustCode.Name = "btnCustCode";
            this.btnCustCode.Size = new System.Drawing.Size(50, 24);
            this.btnCustCode.TabIndex = 38;
            this.btnCustCode.Text = "...";
            this.btnCustCode.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnProColor
            // 
            this.btnProColor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProColor.Appearance.Options.UseFont = true;
            this.btnProColor.Location = new System.Drawing.Point(1101, 137);
            this.btnProColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProColor.Name = "btnProColor";
            this.btnProColor.Size = new System.Drawing.Size(50, 24);
            this.btnProColor.TabIndex = 37;
            this.btnProColor.Text = "...";
            this.btnProColor.Click += new System.EventHandler(this.btnProColor_Click);
            // 
            // drpProColor
            // 
            this.drpProColor.Location = new System.Drawing.Point(866, 140);
            this.drpProColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProColor.Name = "drpProColor";
            this.drpProColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProColor.Size = new System.Drawing.Size(219, 20);
            this.drpProColor.TabIndex = 36;
            // 
            // drpStatus
            // 
            this.drpStatus.Location = new System.Drawing.Point(866, 254);
            this.drpStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpStatus.Name = "drpStatus";
            this.drpStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpStatus.Properties.Items.AddRange(new object[] {
            "Open",
            "Cancel",
            "Complete"});
            this.drpStatus.Size = new System.Drawing.Size(285, 20);
            this.drpStatus.TabIndex = 35;
            // 
            // drpProductSize
            // 
            this.drpProductSize.Location = new System.Drawing.Point(261, 297);
            this.drpProductSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProductSize.Name = "drpProductSize";
            this.drpProductSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProductSize.Size = new System.Drawing.Size(285, 20);
            this.drpProductSize.TabIndex = 33;
            this.drpProductSize.SelectedIndexChanged += new System.EventHandler(this.drpProductSize_SelectedIndexChanged);
            // 
            // drpModelCode
            // 
            this.drpModelCode.Location = new System.Drawing.Point(261, 259);
            this.drpModelCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpModelCode.Name = "drpModelCode";
            this.drpModelCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpModelCode.Size = new System.Drawing.Size(285, 20);
            this.drpModelCode.TabIndex = 32;
            this.drpModelCode.SelectedIndexChanged += new System.EventHandler(this.drpModelCode_SelectedIndexChanged);
            // 
            // drpModelName
            // 
            this.drpModelName.Location = new System.Drawing.Point(261, 222);
            this.drpModelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpModelName.Name = "drpModelName";
            this.drpModelName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpModelName.Size = new System.Drawing.Size(285, 20);
            this.drpModelName.TabIndex = 31;
            this.drpModelName.SelectedIndexChanged += new System.EventHandler(this.drpModelName_SelectedIndexChanged);
            // 
            // drpCustName
            // 
            this.drpCustName.Location = new System.Drawing.Point(407, 145);
            this.drpCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpCustName.Name = "drpCustName";
            this.drpCustName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpCustName.Size = new System.Drawing.Size(139, 20);
            this.drpCustName.TabIndex = 30;
            this.drpCustName.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit10_SelectedIndexChanged);
            // 
            // drpProductName
            // 
            this.drpProductName.Location = new System.Drawing.Point(261, 184);
            this.drpProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpProductName.Name = "drpProductName";
            this.drpProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpProductName.Size = new System.Drawing.Size(285, 20);
            this.drpProductName.TabIndex = 29;
            this.drpProductName.SelectedIndexChanged += new System.EventHandler(this.drpProductName_SelectedIndexChanged);
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(38, 426);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(412, 17);
            this.labelControl20.TabIndex = 27;
            this.labelControl20.Text = "By OrderNo / CustomerName / Code /  Prod.Model / Code ";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(510, 424);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(585, 20);
            this.txtsearch.TabIndex = 26;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(866, 180);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(285, 20);
            this.txtQuantity.TabIndex = 25;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // txtTotRawmat
            // 
            this.txtTotRawmat.Location = new System.Drawing.Point(866, 292);
            this.txtTotRawmat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotRawmat.Name = "txtTotRawmat";
            this.txtTotRawmat.Size = new System.Drawing.Size(285, 20);
            this.txtTotRawmat.TabIndex = 24;
            // 
            // txtRawmatName
            // 
            this.txtRawmatName.Location = new System.Drawing.Point(866, 101);
            this.txtRawmatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawmatName.Name = "txtRawmatName";
            this.txtRawmatName.Size = new System.Drawing.Size(285, 20);
            this.txtRawmatName.TabIndex = 23;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(866, 62);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(285, 20);
            this.txtType.TabIndex = 22;
            // 
            // txtWages
            // 
            this.txtWages.Location = new System.Drawing.Point(866, 336);
            this.txtWages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWages.Name = "txtWages";
            this.txtWages.Size = new System.Drawing.Size(285, 20);
            this.txtWages.TabIndex = 21;
            // 
            // txtMaterialwt
            // 
            this.txtMaterialwt.Location = new System.Drawing.Point(261, 336);
            this.txtMaterialwt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterialwt.Name = "txtMaterialwt";
            this.txtMaterialwt.Size = new System.Drawing.Size(285, 20);
            this.txtMaterialwt.TabIndex = 20;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(261, 71);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(285, 20);
            this.txtOrderNo.TabIndex = 19;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(38, 391);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(92, 17);
            this.labelControl19.TabIndex = 18;
            this.labelControl19.Text = "Search Index";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(645, 338);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(141, 17);
            this.labelControl12.TabIndex = 17;
            this.labelControl12.Text = "Wages for Employee";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(645, 100);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(132, 17);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "Raw Material Name";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(645, 139);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(96, 17);
            this.labelControl13.TabIndex = 14;
            this.labelControl13.Text = "Product Color";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(645, 177);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(60, 17);
            this.labelControl14.TabIndex = 13;
            this.labelControl14.Text = "Quantity";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(645, 216);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(91, 17);
            this.labelControl15.TabIndex = 12;
            this.labelControl15.Text = "Product Date";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(645, 253);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(45, 17);
            this.labelControl16.TabIndex = 11;
            this.labelControl16.Text = "Status";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(645, 294);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(131, 17);
            this.labelControl17.TabIndex = 10;
            this.labelControl17.Text = "Total Raw Material ";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(645, 64);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(34, 17);
            this.labelControl18.TabIndex = 9;
            this.labelControl18.Text = "Type";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(38, 106);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(76, 17);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Order Date";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(38, 144);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(164, 17);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Customer Code / Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(38, 183);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(99, 17);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Product Name";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(38, 221);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(85, 17);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Model Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 260);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 17);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Model Code";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 297);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 17);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Product Size";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 338);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(149, 17);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Material Weight/Item";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 71);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Order No";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 19);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Order Details";
            // 
            // ddOrderDate
            // 
            this.ddOrderDate.EditValue = null;
            this.ddOrderDate.Location = new System.Drawing.Point(261, 106);
            this.ddOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddOrderDate.Name = "ddOrderDate";
            this.ddOrderDate.Properties.BeepOnError = false;
            this.ddOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddOrderDate.Properties.DisplayFormat.FormatString = "";
            this.ddOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddOrderDate.Properties.EditFormat.FormatString = "";
            this.ddOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddOrderDate.Properties.MaskSettings.Set("mask", "d");
            this.ddOrderDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddOrderDate.Size = new System.Drawing.Size(285, 20);
            this.ddOrderDate.TabIndex = 28;
            // 
            // ddProDate
            // 
            this.ddProDate.EditValue = null;
            this.ddProDate.Location = new System.Drawing.Point(866, 222);
            this.ddProDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddProDate.Name = "ddProDate";
            this.ddProDate.Properties.BeepOnError = false;
            this.ddProDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddProDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddProDate.Properties.DisplayFormat.FormatString = "";
            this.ddProDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddProDate.Properties.EditFormat.FormatString = "";
            this.ddProDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ddProDate.Properties.MaskSettings.Set("mask", "d");
            this.ddProDate.Properties.UseMaskAsDisplayFormat = true;
            this.ddProDate.Size = new System.Drawing.Size(285, 20);
            this.ddProDate.TabIndex = 34;
            // 
            // FrmOrderMasterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 822);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOrderMasterInfo";
            this.Text = "FrmOrderMasterInfo";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpModelName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpCustName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotRawmat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRawmatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialwt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit drpCustCode;
        private DevExpress.XtraEditors.SimpleButton btnProName;
        private DevExpress.XtraEditors.SimpleButton btnCustCode;
        private DevExpress.XtraEditors.SimpleButton btnProColor;
        private DevExpress.XtraEditors.ComboBoxEdit drpProColor;
        private DevExpress.XtraEditors.ComboBoxEdit drpStatus;
        private DevExpress.XtraEditors.ComboBoxEdit drpProductSize;
        private DevExpress.XtraEditors.ComboBoxEdit drpModelCode;
        private DevExpress.XtraEditors.ComboBoxEdit drpModelName;
        private DevExpress.XtraEditors.ComboBoxEdit drpCustName;
        private DevExpress.XtraEditors.ComboBoxEdit drpProductName;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtsearch;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtTotRawmat;
        private DevExpress.XtraEditors.TextEdit txtRawmatName;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.TextEdit txtWages;
        private DevExpress.XtraEditors.TextEdit txtMaterialwt;
        private DevExpress.XtraEditors.TextEdit txtOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.DateEdit ddOrderDate;
        private DevExpress.XtraEditors.DateEdit ddProDate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn OrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerCodeId;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private DevExpress.XtraGrid.Columns.GridColumn ProductModel;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn ProductSize;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn RawMaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn RawType;
        private DevExpress.XtraGrid.Columns.GridColumn ColorId;
        private DevExpress.XtraGrid.Columns.GridColumn RawQty;
        private DevExpress.XtraGrid.Columns.GridColumn TotalRaw;
        private DevExpress.XtraGrid.Columns.GridColumn Deliverydate;
        private DevExpress.XtraGrid.Columns.GridColumn WagesforEmp;
        private DevExpress.XtraGrid.Columns.GridColumn status;
    }
}