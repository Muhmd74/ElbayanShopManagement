
namespace ElbayaNPresentation.Views.Purchases.Procurement
{
    partial class frmProcurementOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcurementOrder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtProductBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblF2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtpOrderDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddNewProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeletedProductFromOrder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.rbDeferredOrder = new System.Windows.Forms.RadioButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.dtpDefrredDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rbCashOrder = new System.Windows.Forms.RadioButton();
            this.btnAddNewSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalProduOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.dgvOrderProduct = new System.Windows.Forms.DataGridView();
            this.PSNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qunatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceIncVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.cbxActiveProduct = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvOrderProduct, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 570);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.cbxActiveProduct);
            this.groupControl1.Controls.Add(this.cbxSupplier);
            this.groupControl1.Controls.Add(this.btnDeletedProductFromOrder);
            this.groupControl1.Controls.Add(this.btnAddNewSupplier);
            this.groupControl1.Controls.Add(this.btnAddNewProduct);
            this.groupControl1.Controls.Add(this.txtProductBarcode);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.lblF2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtOrderNumber);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1018, 94);
            this.groupControl1.TabIndex = 0;
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductBarcode.BorderColor = System.Drawing.Color.Gray;
            this.txtProductBarcode.BorderRadius = 9;
            this.txtProductBarcode.BorderThickness = 2;
            this.txtProductBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductBarcode.DefaultText = "";
            this.txtProductBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductBarcode.DisabledState.Parent = this.txtProductBarcode;
            this.txtProductBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductBarcode.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtProductBarcode.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtProductBarcode.FocusedState.Parent = this.txtProductBarcode;
            this.txtProductBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductBarcode.HoverState.Parent = this.txtProductBarcode;
            this.txtProductBarcode.Location = new System.Drawing.Point(750, 51);
            this.txtProductBarcode.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.PasswordChar = '\0';
            this.txtProductBarcode.PlaceholderText = "";
            this.txtProductBarcode.SelectedText = "";
            this.txtProductBarcode.ShadowDecoration.Parent = this.txtProductBarcode;
            this.txtProductBarcode.Size = new System.Drawing.Size(182, 39);
            this.txtProductBarcode.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(622, 58);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 22);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "أختر منتج";
            // 
            // lblF2
            // 
            this.lblF2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblF2.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF2.Appearance.Options.UseFont = true;
            this.lblF2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblF2.Location = new System.Drawing.Point(304, 56);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(17, 27);
            this.lblF2.TabIndex = 0;
            this.lblF2.Text = "F2";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(724, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 27);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "F1";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(622, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 22);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "أختر مورد";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(949, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 22);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "باركود المنتج";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderNumber.BorderColor = System.Drawing.Color.Gray;
            this.txtOrderNumber.BorderRadius = 9;
            this.txtOrderNumber.BorderThickness = 2;
            this.txtOrderNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderNumber.DefaultText = "";
            this.txtOrderNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrderNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrderNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderNumber.DisabledState.Parent = this.txtOrderNumber;
            this.txtOrderNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderNumber.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtOrderNumber.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtOrderNumber.FocusedState.Parent = this.txtOrderNumber;
            this.txtOrderNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderNumber.HoverState.Parent = this.txtOrderNumber;
            this.txtOrderNumber.Location = new System.Drawing.Point(777, 8);
            this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.PasswordChar = '\0';
            this.txtOrderNumber.PlaceholderText = "";
            this.txtOrderNumber.SelectedText = "";
            this.txtOrderNumber.ShadowDecoration.Parent = this.txtOrderNumber;
            this.txtOrderNumber.Size = new System.Drawing.Size(155, 39);
            this.txtOrderNumber.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(950, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "رقم الفاتورة";
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.rbCashOrder);
            this.groupControl2.Controls.Add(this.rbDeferredOrder);
            this.groupControl2.Controls.Add(this.dtpDefrredDate);
            this.groupControl2.Controls.Add(this.dtpOrderDate);
            this.groupControl2.Controls.Add(this.lblUserName);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txtTotalOrder);
            this.groupControl2.Controls.Add(this.txtTotalProduOrder);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 430);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1018, 137);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOrderDate.BorderColor = System.Drawing.Color.DimGray;
            this.dtpOrderDate.BorderRadius = 9;
            this.dtpOrderDate.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.dtpOrderDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.dtpOrderDate.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.dtpOrderDate.CheckedState.Parent = this.dtpOrderDate;
            this.dtpOrderDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.HoverState.Parent = this.dtpOrderDate;
            this.dtpOrderDate.Location = new System.Drawing.Point(788, 9);
            this.dtpOrderDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpOrderDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.ShadowDecoration.Parent = this.dtpOrderDate;
            this.dtpOrderDate.Size = new System.Drawing.Size(129, 32);
            this.dtpOrderDate.TabIndex = 21;
            this.dtpOrderDate.Value = new System.DateTime(2021, 3, 9, 21, 0, 10, 526);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(935, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 25);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "تاريخ الفاتورة";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnAddNewProduct.Location = new System.Drawing.Point(330, 51);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAddNewProduct.Size = new System.Drawing.Size(38, 36);
            this.btnAddNewProduct.TabIndex = 12;
            // 
            // btnDeletedProductFromOrder
            // 
            this.btnDeletedProductFromOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletedProductFromOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnDeletedProductFromOrder.Location = new System.Drawing.Point(260, 51);
            this.btnDeletedProductFromOrder.Name = "btnDeletedProductFromOrder";
            this.btnDeletedProductFromOrder.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDeletedProductFromOrder.Size = new System.Drawing.Size(38, 36);
            this.btnDeletedProductFromOrder.TabIndex = 12;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(212, 56);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 27);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Delete";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(51, 16);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(145, 27);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "لحفظ ودغع الفاتورة F12";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(60, 57);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(136, 27);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "لتعديل كمية صنف F11";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl11.Location = new System.Drawing.Point(927, 48);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(79, 25);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "اسم المستحدم";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblUserName.Location = new System.Drawing.Point(808, 48);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Employee.Name";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl13.Location = new System.Drawing.Point(260, 13);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(79, 25);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "عدد الأصناف ";
            // 
            // rbDeferredOrder
            // 
            this.rbDeferredOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDeferredOrder.AutoSize = true;
            this.rbDeferredOrder.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbDeferredOrder.Location = new System.Drawing.Point(632, 11);
            this.rbDeferredOrder.Name = "rbDeferredOrder";
            this.rbDeferredOrder.Size = new System.Drawing.Size(127, 29);
            this.rbDeferredOrder.TabIndex = 22;
            this.rbDeferredOrder.TabStop = true;
            this.rbDeferredOrder.Text = "دفع الفاتورة أجل";
            this.rbDeferredOrder.UseVisualStyleBackColor = true;
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl14.Location = new System.Drawing.Point(534, 13);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(91, 25);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "تاريخ الاستحقاق";
            this.labelControl14.Visible = false;
            // 
            // dtpDefrredDate
            // 
            this.dtpDefrredDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDefrredDate.BorderColor = System.Drawing.Color.DimGray;
            this.dtpDefrredDate.BorderRadius = 9;
            this.dtpDefrredDate.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.dtpDefrredDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.dtpDefrredDate.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.dtpDefrredDate.CheckedState.Parent = this.dtpDefrredDate;
            this.dtpDefrredDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtpDefrredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDefrredDate.HoverState.Parent = this.dtpDefrredDate;
            this.dtpDefrredDate.Location = new System.Drawing.Point(383, 9);
            this.dtpDefrredDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDefrredDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDefrredDate.Name = "dtpDefrredDate";
            this.dtpDefrredDate.ShadowDecoration.Parent = this.dtpDefrredDate;
            this.dtpDefrredDate.Size = new System.Drawing.Size(130, 32);
            this.dtpDefrredDate.TabIndex = 21;
            this.dtpDefrredDate.TabStop = false;
            this.dtpDefrredDate.Value = new System.DateTime(2021, 3, 9, 21, 0, 10, 526);
            this.dtpDefrredDate.Visible = false;
            // 
            // rbCashOrder
            // 
            this.rbCashOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCashOrder.AutoSize = true;
            this.rbCashOrder.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbCashOrder.Location = new System.Drawing.Point(632, 48);
            this.rbCashOrder.Name = "rbCashOrder";
            this.rbCashOrder.Size = new System.Drawing.Size(128, 29);
            this.rbCashOrder.TabIndex = 22;
            this.rbCashOrder.TabStop = true;
            this.rbCashOrder.Text = "دفع الفاتورة كاش";
            this.rbCashOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddNewSupplier
            // 
            this.btnAddNewSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnAddNewSupplier.Location = new System.Drawing.Point(330, 11);
            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
            this.btnAddNewSupplier.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAddNewSupplier.Size = new System.Drawing.Size(38, 36);
            this.btnAddNewSupplier.TabIndex = 12;
            this.btnAddNewSupplier.Click += new System.EventHandler(this.btnAddNewSupplier_Click);
            // 
            // txtTotalProduOrder
            // 
            this.txtTotalProduOrder.BorderColor = System.Drawing.Color.Gray;
            this.txtTotalProduOrder.BorderRadius = 9;
            this.txtTotalProduOrder.BorderThickness = 2;
            this.txtTotalProduOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalProduOrder.DefaultText = "";
            this.txtTotalProduOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalProduOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalProduOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalProduOrder.DisabledState.Parent = this.txtTotalProduOrder;
            this.txtTotalProduOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalProduOrder.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTotalProduOrder.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtTotalProduOrder.FocusedState.Parent = this.txtTotalProduOrder;
            this.txtTotalProduOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalProduOrder.HoverState.Parent = this.txtTotalProduOrder;
            this.txtTotalProduOrder.Location = new System.Drawing.Point(97, 8);
            this.txtTotalProduOrder.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.txtTotalProduOrder.Name = "txtTotalProduOrder";
            this.txtTotalProduOrder.PasswordChar = '\0';
            this.txtTotalProduOrder.PlaceholderText = "";
            this.txtTotalProduOrder.SelectedText = "";
            this.txtTotalProduOrder.ShadowDecoration.Parent = this.txtTotalProduOrder;
            this.txtTotalProduOrder.Size = new System.Drawing.Size(122, 35);
            this.txtTotalProduOrder.TabIndex = 10;
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.BorderColor = System.Drawing.Color.Gray;
            this.txtTotalOrder.BorderRadius = 9;
            this.txtTotalOrder.BorderThickness = 2;
            this.txtTotalOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalOrder.DefaultText = "0";
            this.txtTotalOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTotalOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalOrder.DisabledState.Parent = this.txtTotalOrder;
            this.txtTotalOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalOrder.Enabled = false;
            this.txtTotalOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTotalOrder.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTotalOrder.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtTotalOrder.FocusedState.Parent = this.txtTotalOrder;
            this.txtTotalOrder.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalOrder.HoverState.Parent = this.txtTotalOrder;
            this.txtTotalOrder.Location = new System.Drawing.Point(97, 48);
            this.txtTotalOrder.Margin = new System.Windows.Forms.Padding(7, 12, 7, 12);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.PasswordChar = '\0';
            this.txtTotalOrder.PlaceholderText = "";
            this.txtTotalOrder.SelectedText = "";
            this.txtTotalOrder.SelectionStart = 1;
            this.txtTotalOrder.ShadowDecoration.Parent = this.txtTotalOrder;
            this.txtTotalOrder.Size = new System.Drawing.Size(138, 42);
            this.txtTotalOrder.TabIndex = 10;
            this.txtTotalOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl15.Location = new System.Drawing.Point(260, 58);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(88, 25);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "مجموع الفاتورة";
            // 
            // dgvOrderProduct
            // 
            this.dgvOrderProduct.AllowUserToAddRows = false;
            this.dgvOrderProduct.AllowUserToDeleteRows = false;
            this.dgvOrderProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PSNumber,
            this.ProductName,
            this.Unit,
            this.Qunatity,
            this.PriceIncVat,
            this.Discount,
            this.Subtotal});
            this.dgvOrderProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderProduct.Location = new System.Drawing.Point(3, 103);
            this.dgvOrderProduct.Name = "dgvOrderProduct";
            this.dgvOrderProduct.ReadOnly = true;
            this.dgvOrderProduct.Size = new System.Drawing.Size(1018, 321);
            this.dgvOrderProduct.TabIndex = 2;
            // 
            // PSNumber
            // 
            this.PSNumber.HeaderText = "رقم المنتج";
            this.PSNumber.Name = "PSNumber";
            this.PSNumber.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "اسم المنتج";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "الوحدة";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Qunatity
            // 
            this.Qunatity.HeaderText = "الكمية";
            this.Qunatity.Name = "Qunatity";
            this.Qunatity.ReadOnly = true;
            // 
            // PriceIncVat
            // 
            this.PriceIncVat.HeaderText = "السعر شامل الضريبة";
            this.PriceIncVat.Name = "PriceIncVat";
            this.PriceIncVat.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "الخصم";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "الإجمالي";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxSupplier.DropDownHeight = 100;
            this.cbxSupplier.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSupplier.IntegralHeight = false;
            this.cbxSupplier.ItemHeight = 25;
            this.cbxSupplier.Location = new System.Drawing.Point(383, 10);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(222, 33);
            this.cbxSupplier.TabIndex = 13;
            // 
            // cbxActiveProduct
            // 
            this.cbxActiveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxActiveProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxActiveProduct.DropDownHeight = 100;
            this.cbxActiveProduct.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActiveProduct.IntegralHeight = false;
            this.cbxActiveProduct.ItemHeight = 25;
            this.cbxActiveProduct.Location = new System.Drawing.Point(383, 51);
            this.cbxActiveProduct.Name = "cbxActiveProduct";
            this.cbxActiveProduct.Size = new System.Drawing.Size(222, 33);
            this.cbxActiveProduct.TabIndex = 13;
            // 
            // frmProcurementOrder
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcurementOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة مشتريات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal Guna.UI2.WinForms.Guna2TextBox txtProductBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblF2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        internal Guna.UI2.WinForms.Guna2TextBox txtOrderNumber;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        internal Guna.UI2.WinForms.Guna2DateTimePicker dtpOrderDate;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnAddNewProduct;
        private DevExpress.XtraEditors.SimpleButton btnDeletedProductFromOrder;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.RadioButton rbCashOrder;
        private System.Windows.Forms.RadioButton rbDeferredOrder;
        internal Guna.UI2.WinForms.Guna2DateTimePicker dtpDefrredDate;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnAddNewSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        internal Guna.UI2.WinForms.Guna2TextBox txtTotalOrder;
        internal Guna.UI2.WinForms.Guna2TextBox txtTotalProduOrder;
        private System.Windows.Forms.DataGridView dgvOrderProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qunatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceIncVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        internal System.Windows.Forms.ComboBox cbxActiveProduct;
        internal System.Windows.Forms.ComboBox cbxSupplier;
    }
}