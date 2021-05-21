
namespace ElbayaNPresentation.Views.Purchases
{
    partial class frmPurchaseReturns
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseReturns));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOrderReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalOrderVAT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOrderPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrderProducts = new System.Windows.Forms.DataGridView();
            this.OrderProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWithVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudReturnAmountOfProduct = new System.Windows.Forms.NumericUpDown();
            this.btnReturnSpicifiedQuantity = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturnAllOrderProduct = new Guna.UI2.WinForms.Guna2Button();
            this.rbIsOnlyOneProduct = new System.Windows.Forms.RadioButton();
            this.txtCollectedPersonJob = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCollectedPersonMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcollectedPersonName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPOSName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtOrderDeferred = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducts)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnAmountOfProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(75, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "مرتجع مشتريات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpOrderReturnDate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSupplierName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtpOrderReturnDate
            // 
            this.dtpOrderReturnDate.BorderRadius = 5;
            this.dtpOrderReturnDate.BorderThickness = 1;
            this.dtpOrderReturnDate.CheckedState.Parent = this.dtpOrderReturnDate;
            this.dtpOrderReturnDate.FillColor = System.Drawing.Color.White;
            this.dtpOrderReturnDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpOrderReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderReturnDate.HoverState.Parent = this.dtpOrderReturnDate;
            this.dtpOrderReturnDate.Location = new System.Drawing.Point(6, 19);
            this.dtpOrderReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpOrderReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpOrderReturnDate.Name = "dtpOrderReturnDate";
            this.dtpOrderReturnDate.ShadowDecoration.Parent = this.dtpOrderReturnDate;
            this.dtpOrderReturnDate.Size = new System.Drawing.Size(133, 36);
            this.dtpOrderReturnDate.TabIndex = 25;
            this.dtpOrderReturnDate.Value = new System.DateTime(2021, 3, 21, 0, 19, 36, 36);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(153, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "تاريخ المرتجع";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtSearch.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(487, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(210, 35);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(705, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "إبحث برقم الفاتورة : ";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSupplierName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierName.Location = new System.Drawing.Point(241, 26);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(135, 22);
            this.lblSupplierName.TabIndex = 20;
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(382, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "إسم المورد : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOrderDeferred);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTotalOrderVAT);
            this.groupBox3.Controls.Add(this.txtOrderPayment);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTotalOrder);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.groupBox3.Location = new System.Drawing.Point(20, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(863, 64);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ملخص الفاتورة";
            // 
            // txtTotalOrderVAT
            // 
            this.txtTotalOrderVAT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalOrderVAT.BorderColor = System.Drawing.Color.Black;
            this.txtTotalOrderVAT.BorderRadius = 3;
            this.txtTotalOrderVAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalOrderVAT.DefaultText = "";
            this.txtTotalOrderVAT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalOrderVAT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalOrderVAT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalOrderVAT.DisabledState.Parent = this.txtTotalOrderVAT;
            this.txtTotalOrderVAT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalOrderVAT.Enabled = false;
            this.txtTotalOrderVAT.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTotalOrderVAT.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtTotalOrderVAT.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTotalOrderVAT.FocusedState.Parent = this.txtTotalOrderVAT;
            this.txtTotalOrderVAT.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrderVAT.ForeColor = System.Drawing.Color.Black;
            this.txtTotalOrderVAT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalOrderVAT.HoverState.Parent = this.txtTotalOrderVAT;
            this.txtTotalOrderVAT.Location = new System.Drawing.Point(10, 27);
            this.txtTotalOrderVAT.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtTotalOrderVAT.Name = "txtTotalOrderVAT";
            this.txtTotalOrderVAT.PasswordChar = '\0';
            this.txtTotalOrderVAT.PlaceholderText = "";
            this.txtTotalOrderVAT.SelectedText = "";
            this.txtTotalOrderVAT.ShadowDecoration.Parent = this.txtTotalOrderVAT;
            this.txtTotalOrderVAT.Size = new System.Drawing.Size(100, 28);
            this.txtTotalOrderVAT.TabIndex = 17;
            this.txtTotalOrderVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderPayment
            // 
            this.txtOrderPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtOrderPayment.BorderColor = System.Drawing.Color.Black;
            this.txtOrderPayment.BorderRadius = 3;
            this.txtOrderPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderPayment.DefaultText = "";
            this.txtOrderPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrderPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrderPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderPayment.DisabledState.Parent = this.txtOrderPayment;
            this.txtOrderPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderPayment.Enabled = false;
            this.txtOrderPayment.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtOrderPayment.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtOrderPayment.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtOrderPayment.FocusedState.Parent = this.txtOrderPayment;
            this.txtOrderPayment.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderPayment.ForeColor = System.Drawing.Color.Black;
            this.txtOrderPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderPayment.HoverState.Parent = this.txtOrderPayment;
            this.txtOrderPayment.Location = new System.Drawing.Point(424, 27);
            this.txtOrderPayment.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtOrderPayment.Name = "txtOrderPayment";
            this.txtOrderPayment.PasswordChar = '\0';
            this.txtOrderPayment.PlaceholderText = "";
            this.txtOrderPayment.SelectedText = "";
            this.txtOrderPayment.ShadowDecoration.Parent = this.txtOrderPayment;
            this.txtOrderPayment.Size = new System.Drawing.Size(100, 28);
            this.txtOrderPayment.TabIndex = 17;
            this.txtOrderPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(110, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "قيمة الضريبة : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(524, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "المدفوع : ";
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalOrder.BorderColor = System.Drawing.Color.Black;
            this.txtTotalOrder.BorderRadius = 3;
            this.txtTotalOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalOrder.DefaultText = "";
            this.txtTotalOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalOrder.DisabledState.Parent = this.txtTotalOrder;
            this.txtTotalOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalOrder.Enabled = false;
            this.txtTotalOrder.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTotalOrder.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtTotalOrder.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTotalOrder.FocusedState.Parent = this.txtTotalOrder;
            this.txtTotalOrder.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrder.ForeColor = System.Drawing.Color.Black;
            this.txtTotalOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalOrder.HoverState.Parent = this.txtTotalOrder;
            this.txtTotalOrder.Location = new System.Drawing.Point(609, 27);
            this.txtTotalOrder.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.PasswordChar = '\0';
            this.txtTotalOrder.PlaceholderText = "";
            this.txtTotalOrder.SelectedText = "";
            this.txtTotalOrder.ShadowDecoration.Parent = this.txtTotalOrder;
            this.txtTotalOrder.Size = new System.Drawing.Size(100, 28);
            this.txtTotalOrder.TabIndex = 17;
            this.txtTotalOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(732, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "إجمالي الفاتورة : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOrderProducts);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 224);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // dgvOrderProducts
            // 
            this.dgvOrderProducts.AllowUserToAddRows = false;
            this.dgvOrderProducts.AllowUserToDeleteRows = false;
            this.dgvOrderProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderProductId,
            this.ProductName,
            this.Quantity,
            this.Debit,
            this.StockDateTime,
            this.VATValue,
            this.PriceWithVAT});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderProducts.Location = new System.Drawing.Point(3, 26);
            this.dgvOrderProducts.Name = "dgvOrderProducts";
            this.dgvOrderProducts.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderProducts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            this.dgvOrderProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.dgvOrderProducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvOrderProducts.RowTemplate.Height = 29;
            this.dgvOrderProducts.Size = new System.Drawing.Size(857, 195);
            this.dgvOrderProducts.TabIndex = 13;
            // 
            // OrderProductId
            // 
            this.OrderProductId.DataPropertyName = "Id";
            this.OrderProductId.HeaderText = "رقم مرجعي المنتج";
            this.OrderProductId.Name = "OrderProductId";
            this.OrderProductId.ReadOnly = true;
            this.OrderProductId.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 147.4798F;
            this.ProductName.HeaderText = "اسم الصنف";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 95.68217F;
            this.Quantity.HeaderText = "الكمية ";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Debit
            // 
            this.Debit.DataPropertyName = "PriceSale";
            this.Debit.FillWeight = 112.1535F;
            this.Debit.HeaderText = "سعر الشراء";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // StockDateTime
            // 
            this.StockDateTime.DataPropertyName = "Discount";
            this.StockDateTime.FillWeight = 74.69918F;
            this.StockDateTime.HeaderText = "قيمة خصم";
            this.StockDateTime.Name = "StockDateTime";
            this.StockDateTime.ReadOnly = true;
            // 
            // VATValue
            // 
            this.VATValue.DataPropertyName = "Vat";
            this.VATValue.HeaderText = "قيمة الضريبة";
            this.VATValue.Name = "VATValue";
            this.VATValue.ReadOnly = true;
            // 
            // PriceWithVAT
            // 
            this.PriceWithVAT.DataPropertyName = "TotalPrice";
            this.PriceWithVAT.HeaderText = "اجمالي الصنف";
            this.PriceWithVAT.Name = "PriceWithVAT";
            this.PriceWithVAT.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudReturnAmountOfProduct);
            this.groupBox4.Controls.Add(this.btnReturnSpicifiedQuantity);
            this.groupBox4.Controls.Add(this.btnReturnProduct);
            this.groupBox4.Controls.Add(this.btnReturnAllOrderProduct);
            this.groupBox4.Controls.Add(this.rbIsOnlyOneProduct);
            this.groupBox4.Controls.Add(this.txtCollectedPersonJob);
            this.groupBox4.Controls.Add(this.txtCollectedPersonMobile);
            this.groupBox4.Controls.Add(this.txtcollectedPersonName);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.groupBox4.Location = new System.Drawing.Point(20, 414);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(863, 156);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "عملية المرتجع ";
            // 
            // nudReturnAmountOfProduct
            // 
            this.nudReturnAmountOfProduct.Location = new System.Drawing.Point(20, 31);
            this.nudReturnAmountOfProduct.Name = "nudReturnAmountOfProduct";
            this.nudReturnAmountOfProduct.Size = new System.Drawing.Size(107, 30);
            this.nudReturnAmountOfProduct.TabIndex = 21;
            this.nudReturnAmountOfProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReturnSpicifiedQuantity
            // 
            this.btnReturnSpicifiedQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReturnSpicifiedQuantity.BorderRadius = 5;
            this.btnReturnSpicifiedQuantity.CheckedState.Parent = this.btnReturnSpicifiedQuantity;
            this.btnReturnSpicifiedQuantity.CustomImages.Parent = this.btnReturnSpicifiedQuantity;
            this.btnReturnSpicifiedQuantity.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnReturnSpicifiedQuantity.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnSpicifiedQuantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturnSpicifiedQuantity.HoverState.Parent = this.btnReturnSpicifiedQuantity;
            this.btnReturnSpicifiedQuantity.Location = new System.Drawing.Point(133, 84);
            this.btnReturnSpicifiedQuantity.Name = "btnReturnSpicifiedQuantity";
            this.btnReturnSpicifiedQuantity.ShadowDecoration.Parent = this.btnReturnSpicifiedQuantity;
            this.btnReturnSpicifiedQuantity.Size = new System.Drawing.Size(148, 35);
            this.btnReturnSpicifiedQuantity.TabIndex = 16;
            this.btnReturnSpicifiedQuantity.Text = "إرجاع الكمية المحددة";
            // 
            // btnReturnProduct
            // 
            this.btnReturnProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReturnProduct.BorderRadius = 5;
            this.btnReturnProduct.CheckedState.Parent = this.btnReturnProduct;
            this.btnReturnProduct.CustomImages.Parent = this.btnReturnProduct;
            this.btnReturnProduct.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnReturnProduct.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturnProduct.HoverState.Parent = this.btnReturnProduct;
            this.btnReturnProduct.Location = new System.Drawing.Point(342, 84);
            this.btnReturnProduct.Name = "btnReturnProduct";
            this.btnReturnProduct.ShadowDecoration.Parent = this.btnReturnProduct;
            this.btnReturnProduct.Size = new System.Drawing.Size(148, 35);
            this.btnReturnProduct.TabIndex = 16;
            this.btnReturnProduct.Text = "إرجاع الصنف المحدد كاملا";
            // 
            // btnReturnAllOrderProduct
            // 
            this.btnReturnAllOrderProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReturnAllOrderProduct.BorderRadius = 5;
            this.btnReturnAllOrderProduct.CheckedState.Parent = this.btnReturnAllOrderProduct;
            this.btnReturnAllOrderProduct.CustomImages.Parent = this.btnReturnAllOrderProduct;
            this.btnReturnAllOrderProduct.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnReturnAllOrderProduct.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReturnAllOrderProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturnAllOrderProduct.HoverState.Parent = this.btnReturnAllOrderProduct;
            this.btnReturnAllOrderProduct.Location = new System.Drawing.Point(342, 31);
            this.btnReturnAllOrderProduct.Name = "btnReturnAllOrderProduct";
            this.btnReturnAllOrderProduct.ShadowDecoration.Parent = this.btnReturnAllOrderProduct;
            this.btnReturnAllOrderProduct.Size = new System.Drawing.Size(148, 35);
            this.btnReturnAllOrderProduct.TabIndex = 16;
            this.btnReturnAllOrderProduct.Text = "كامل الفاتورة مرتجع";
            // 
            // rbIsOnlyOneProduct
            // 
            this.rbIsOnlyOneProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbIsOnlyOneProduct.AutoSize = true;
            this.rbIsOnlyOneProduct.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbIsOnlyOneProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbIsOnlyOneProduct.Location = new System.Drawing.Point(133, 29);
            this.rbIsOnlyOneProduct.Name = "rbIsOnlyOneProduct";
            this.rbIsOnlyOneProduct.Size = new System.Drawing.Size(203, 29);
            this.rbIsOnlyOneProduct.TabIndex = 0;
            this.rbIsOnlyOneProduct.Text = "إرجاع كمية محددة من صنف";
            this.rbIsOnlyOneProduct.UseVisualStyleBackColor = true;
            // 
            // txtCollectedPersonJob
            // 
            this.txtCollectedPersonJob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCollectedPersonJob.BorderColor = System.Drawing.Color.Black;
            this.txtCollectedPersonJob.BorderRadius = 3;
            this.txtCollectedPersonJob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCollectedPersonJob.DefaultText = "";
            this.txtCollectedPersonJob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCollectedPersonJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCollectedPersonJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCollectedPersonJob.DisabledState.Parent = this.txtCollectedPersonJob;
            this.txtCollectedPersonJob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCollectedPersonJob.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtCollectedPersonJob.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtCollectedPersonJob.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtCollectedPersonJob.FocusedState.Parent = this.txtCollectedPersonJob;
            this.txtCollectedPersonJob.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollectedPersonJob.ForeColor = System.Drawing.Color.Black;
            this.txtCollectedPersonJob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCollectedPersonJob.HoverState.Parent = this.txtCollectedPersonJob;
            this.txtCollectedPersonJob.Location = new System.Drawing.Point(513, 110);
            this.txtCollectedPersonJob.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtCollectedPersonJob.Name = "txtCollectedPersonJob";
            this.txtCollectedPersonJob.PasswordChar = '\0';
            this.txtCollectedPersonJob.PlaceholderText = "";
            this.txtCollectedPersonJob.SelectedText = "";
            this.txtCollectedPersonJob.ShadowDecoration.Parent = this.txtCollectedPersonJob;
            this.txtCollectedPersonJob.Size = new System.Drawing.Size(184, 28);
            this.txtCollectedPersonJob.TabIndex = 17;
            this.txtCollectedPersonJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCollectedPersonMobile
            // 
            this.txtCollectedPersonMobile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCollectedPersonMobile.BorderColor = System.Drawing.Color.Black;
            this.txtCollectedPersonMobile.BorderRadius = 3;
            this.txtCollectedPersonMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCollectedPersonMobile.DefaultText = "";
            this.txtCollectedPersonMobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCollectedPersonMobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCollectedPersonMobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCollectedPersonMobile.DisabledState.Parent = this.txtCollectedPersonMobile;
            this.txtCollectedPersonMobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCollectedPersonMobile.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtCollectedPersonMobile.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtCollectedPersonMobile.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtCollectedPersonMobile.FocusedState.Parent = this.txtCollectedPersonMobile;
            this.txtCollectedPersonMobile.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollectedPersonMobile.ForeColor = System.Drawing.Color.Black;
            this.txtCollectedPersonMobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCollectedPersonMobile.HoverState.Parent = this.txtCollectedPersonMobile;
            this.txtCollectedPersonMobile.Location = new System.Drawing.Point(513, 73);
            this.txtCollectedPersonMobile.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtCollectedPersonMobile.Name = "txtCollectedPersonMobile";
            this.txtCollectedPersonMobile.PasswordChar = '\0';
            this.txtCollectedPersonMobile.PlaceholderText = "";
            this.txtCollectedPersonMobile.SelectedText = "";
            this.txtCollectedPersonMobile.ShadowDecoration.Parent = this.txtCollectedPersonMobile;
            this.txtCollectedPersonMobile.Size = new System.Drawing.Size(184, 28);
            this.txtCollectedPersonMobile.TabIndex = 17;
            this.txtCollectedPersonMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcollectedPersonName
            // 
            this.txtcollectedPersonName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtcollectedPersonName.BorderColor = System.Drawing.Color.Black;
            this.txtcollectedPersonName.BorderRadius = 3;
            this.txtcollectedPersonName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcollectedPersonName.DefaultText = "";
            this.txtcollectedPersonName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcollectedPersonName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcollectedPersonName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcollectedPersonName.DisabledState.Parent = this.txtcollectedPersonName;
            this.txtcollectedPersonName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcollectedPersonName.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtcollectedPersonName.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtcollectedPersonName.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtcollectedPersonName.FocusedState.Parent = this.txtcollectedPersonName;
            this.txtcollectedPersonName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcollectedPersonName.ForeColor = System.Drawing.Color.Black;
            this.txtcollectedPersonName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcollectedPersonName.HoverState.Parent = this.txtcollectedPersonName;
            this.txtcollectedPersonName.Location = new System.Drawing.Point(513, 38);
            this.txtcollectedPersonName.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtcollectedPersonName.Name = "txtcollectedPersonName";
            this.txtcollectedPersonName.PasswordChar = '\0';
            this.txtcollectedPersonName.PlaceholderText = "";
            this.txtcollectedPersonName.SelectedText = "";
            this.txtcollectedPersonName.ShadowDecoration.Parent = this.txtcollectedPersonName;
            this.txtcollectedPersonName.Size = new System.Drawing.Size(184, 28);
            this.txtcollectedPersonName.TabIndex = 17;
            this.txtcollectedPersonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(693, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "وظيفة مستلم المرتجع : ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(748, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "رقم التليفون : ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(713, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "اسم مستلم المرتجع :";
            // 
            // lblPOSName
            // 
            this.lblPOSName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPOSName.AutoSize = true;
            this.lblPOSName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSName.ForeColor = System.Drawing.Color.Black;
            this.lblPOSName.Location = new System.Drawing.Point(575, 28);
            this.lblPOSName.Name = "lblPOSName";
            this.lblPOSName.Size = new System.Drawing.Size(105, 22);
            this.lblPOSName.TabIndex = 20;
            this.lblPOSName.Text = "اسم نقطة البيع";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(699, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 22);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "إسم المستخدم";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(853, 19);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 31);
            this.lblClose.TabIndex = 20;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtOrderDeferred
            // 
            this.txtOrderDeferred.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtOrderDeferred.BorderColor = System.Drawing.Color.Black;
            this.txtOrderDeferred.BorderRadius = 3;
            this.txtOrderDeferred.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderDeferred.DefaultText = "";
            this.txtOrderDeferred.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrderDeferred.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrderDeferred.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderDeferred.DisabledState.Parent = this.txtOrderDeferred;
            this.txtOrderDeferred.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderDeferred.Enabled = false;
            this.txtOrderDeferred.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtOrderDeferred.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtOrderDeferred.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtOrderDeferred.FocusedState.Parent = this.txtOrderDeferred;
            this.txtOrderDeferred.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDeferred.ForeColor = System.Drawing.Color.Black;
            this.txtOrderDeferred.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderDeferred.HoverState.Parent = this.txtOrderDeferred;
            this.txtOrderDeferred.Location = new System.Drawing.Point(236, 27);
            this.txtOrderDeferred.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtOrderDeferred.Name = "txtOrderDeferred";
            this.txtOrderDeferred.PasswordChar = '\0';
            this.txtOrderDeferred.PlaceholderText = "";
            this.txtOrderDeferred.SelectedText = "";
            this.txtOrderDeferred.ShadowDecoration.Parent = this.txtOrderDeferred;
            this.txtOrderDeferred.Size = new System.Drawing.Size(100, 28);
            this.txtOrderDeferred.TabIndex = 21;
            this.txtOrderDeferred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(336, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "المتبقي : ";
            // 
            // frmPurchaseReturns
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(903, 603);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPOSName);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblUserName);
            this.Movable = false;
            this.Name = "frmPurchaseReturns";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Load += new System.EventHandler(this.frmPurchaseReturns_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducts)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReturnAmountOfProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvOrderProducts;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button btnReturnAllOrderProduct;
        private System.Windows.Forms.RadioButton rbIsOnlyOneProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalOrderVAT;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudReturnAmountOfProduct;
        private Guna.UI2.WinForms.Guna2Button btnReturnSpicifiedQuantity;
        private Guna.UI2.WinForms.Guna2Button btnReturnProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtCollectedPersonJob;
        private Guna.UI2.WinForms.Guna2TextBox txtCollectedPersonMobile;
        private Guna.UI2.WinForms.Guna2TextBox txtcollectedPersonName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPOSName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpOrderReturnDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceWithVAT;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderDeferred;
        private System.Windows.Forms.Label label6;
    }
}