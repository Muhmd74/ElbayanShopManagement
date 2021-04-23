
namespace ElbayaNPresentation.Views.Purchases.Procurement
{
    partial class frmPurchasesDailyMovements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchasesDailyMovements));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.OrderProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWithVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpOrderReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSupplierDefered = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSearchResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 316);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AllowUserToAddRows = false;
            this.dgvSearchResult.AllowUserToDeleteRows = false;
            this.dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResult.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderProductId,
            this.OrderNumber,
            this.ProductName,
            this.Quantity,
            this.Unit,
            this.Debit,
            this.StockDateTime,
            this.VATValue,
            this.PriceWithVAT,
            this.SupplierName,
            this.UserName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchResult.Location = new System.Drawing.Point(3, 26);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchResult.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            this.dgvSearchResult.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.dgvSearchResult.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSearchResult.RowTemplate.Height = 29;
            this.dgvSearchResult.Size = new System.Drawing.Size(888, 287);
            this.dgvSearchResult.TabIndex = 13;
            // 
            // OrderProductId
            // 
            this.OrderProductId.DataPropertyName = "Id";
            this.OrderProductId.HeaderText = "رقم مرجعي الطلب";
            this.OrderProductId.Name = "OrderProductId";
            this.OrderProductId.ReadOnly = true;
            this.OrderProductId.Visible = false;
            // 
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "رقم الطلب";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.FillWeight = 147.4798F;
            this.ProductName.HeaderText = "اسم الصنف";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 95.68217F;
            this.Quantity.HeaderText = "الكمية ";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.FillWeight = 77.42466F;
            this.Unit.HeaderText = "الوحدة";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Debit
            // 
            this.Debit.FillWeight = 112.1535F;
            this.Debit.HeaderText = "سعر الشراء";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // StockDateTime
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.StockDateTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.StockDateTime.FillWeight = 74.69918F;
            this.StockDateTime.HeaderText = "قيمة خصم";
            this.StockDateTime.Name = "StockDateTime";
            this.StockDateTime.ReadOnly = true;
            // 
            // VATValue
            // 
            this.VATValue.HeaderText = "قيمة الضريبة";
            this.VATValue.Name = "VATValue";
            this.VATValue.ReadOnly = true;
            // 
            // PriceWithVAT
            // 
            this.PriceWithVAT.HeaderText = "السعر مع الضريبة";
            this.PriceWithVAT.Name = "PriceWithVAT";
            this.PriceWithVAT.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "اسم المورد";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "المستخدم";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2Button3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dtpOrderReturnDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 59);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(25, 18);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(94, 31);
            this.guna2Button3.TabIndex = 27;
            this.guna2Button3.Text = "بحث ";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 29);
            this.comboBox1.TabIndex = 26;
            // 
            // dtpOrderReturnDate
            // 
            this.dtpOrderReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOrderReturnDate.BorderRadius = 5;
            this.dtpOrderReturnDate.BorderThickness = 1;
            this.dtpOrderReturnDate.CheckedState.Parent = this.dtpOrderReturnDate;
            this.dtpOrderReturnDate.Enabled = false;
            this.dtpOrderReturnDate.FillColor = System.Drawing.Color.White;
            this.dtpOrderReturnDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpOrderReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderReturnDate.HoverState.Parent = this.dtpOrderReturnDate;
            this.dtpOrderReturnDate.Location = new System.Drawing.Point(589, 19);
            this.dtpOrderReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpOrderReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpOrderReturnDate.Name = "dtpOrderReturnDate";
            this.dtpOrderReturnDate.ShadowDecoration.Parent = this.dtpOrderReturnDate;
            this.dtpOrderReturnDate.Size = new System.Drawing.Size(143, 28);
            this.dtpOrderReturnDate.TabIndex = 25;
            this.dtpOrderReturnDate.Value = new System.DateTime(2021, 3, 21, 0, 19, 36, 36);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(317, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "أختر مخزن محدد : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(738, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "حركة مشتريات عن يوم : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "يومية المشتريات";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(678, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "اسم نقطة البيع";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(802, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "إسم المستخدم";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.guna2TextBox5);
            this.groupBox3.Controls.Add(this.guna2TextBox4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.guna2TextBox3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTotalSupplierDefered);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.groupBox3.Location = new System.Drawing.Point(20, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 90);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ملخص اليوم";
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox5.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox5.BorderRadius = 3;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.Enabled = false;
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox5.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox5.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox5.FocusedState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox5.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.HoverState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Location = new System.Drawing.Point(13, 40);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.ShadowDecoration.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Size = new System.Drawing.Size(100, 28);
            this.guna2TextBox5.TabIndex = 17;
            this.guna2TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox4.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox4.BorderRadius = 3;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.Enabled = false;
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox4.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox4.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Location = new System.Drawing.Point(231, 40);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(100, 28);
            this.guna2TextBox4.TabIndex = 17;
            this.guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(125, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "المتبقي مدين";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(343, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "المدفوع : ";
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox3.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox3.BorderRadius = 3;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.Enabled = false;
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox3.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox3.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(428, 40);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(100, 28);
            this.guna2TextBox3.TabIndex = 17;
            this.guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(540, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "إجمالي المشتريات";
            // 
            // txtTotalSupplierDefered
            // 
            this.txtTotalSupplierDefered.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalSupplierDefered.BorderColor = System.Drawing.Color.Black;
            this.txtTotalSupplierDefered.BorderRadius = 3;
            this.txtTotalSupplierDefered.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalSupplierDefered.DefaultText = "";
            this.txtTotalSupplierDefered.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalSupplierDefered.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalSupplierDefered.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalSupplierDefered.DisabledState.Parent = this.txtTotalSupplierDefered;
            this.txtTotalSupplierDefered.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalSupplierDefered.Enabled = false;
            this.txtTotalSupplierDefered.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTotalSupplierDefered.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtTotalSupplierDefered.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTotalSupplierDefered.FocusedState.Parent = this.txtTotalSupplierDefered;
            this.txtTotalSupplierDefered.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSupplierDefered.ForeColor = System.Drawing.Color.Black;
            this.txtTotalSupplierDefered.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalSupplierDefered.HoverState.Parent = this.txtTotalSupplierDefered;
            this.txtTotalSupplierDefered.Location = new System.Drawing.Point(681, 40);
            this.txtTotalSupplierDefered.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtTotalSupplierDefered.Name = "txtTotalSupplierDefered";
            this.txtTotalSupplierDefered.PasswordChar = '\0';
            this.txtTotalSupplierDefered.PlaceholderText = "";
            this.txtTotalSupplierDefered.SelectedText = "";
            this.txtTotalSupplierDefered.ShadowDecoration.Parent = this.txtTotalSupplierDefered;
            this.txtTotalSupplierDefered.Size = new System.Drawing.Size(100, 28);
            this.txtTotalSupplierDefered.TabIndex = 17;
            this.txtTotalSupplierDefered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(804, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "عدد الفواتير";
            // 
            // frmPurchasesDailyMovements
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 548);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmPurchasesDailyMovements";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpOrderReturnDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalSupplierDefered;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceWithVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label3;
    }
}