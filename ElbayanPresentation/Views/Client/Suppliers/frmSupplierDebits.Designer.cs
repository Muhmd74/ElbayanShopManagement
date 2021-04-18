
namespace ElbayaNPresentation.Views.Purchases.Suppliers
{
    partial class frmSupplierDebits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierDebits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.cbxSuppliers = new System.Windows.Forms.ComboBox();
            this.rbOneSupplier = new System.Windows.Forms.RadioButton();
            this.rbAllSuppliers = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.OrderProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalSupplierDefered = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.lblCurency = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPayPartOfDefered = new System.Windows.Forms.RadioButton();
            this.rbPayAllDefereds = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbxSuppliers);
            this.groupBox1.Controls.Add(this.rbOneSupplier);
            this.groupBox1.Controls.Add(this.rbAllSuppliers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.CustomImages.Image")));
            this.btnPrint.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.Gray;
            this.btnPrint.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(46, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(169, 35);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "طباعة الكشف";
            this.btnPrint.TextOffset = new System.Drawing.Point(-11, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.btnSearch.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(284, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(105, 35);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "بحث | F3";
            // 
            // cbxSuppliers
            // 
            this.cbxSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSuppliers.DropDownHeight = 150;
            this.cbxSuppliers.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSuppliers.FormattingEnabled = true;
            this.cbxSuppliers.IntegralHeight = false;
            this.cbxSuppliers.ItemHeight = 25;
            this.cbxSuppliers.Location = new System.Drawing.Point(435, 18);
            this.cbxSuppliers.Name = "cbxSuppliers";
            this.cbxSuppliers.Size = new System.Drawing.Size(205, 33);
            this.cbxSuppliers.TabIndex = 11;
            // 
            // rbOneSupplier
            // 
            this.rbOneSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOneSupplier.AutoSize = true;
            this.rbOneSupplier.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbOneSupplier.Location = new System.Drawing.Point(646, 20);
            this.rbOneSupplier.Name = "rbOneSupplier";
            this.rbOneSupplier.Size = new System.Drawing.Size(101, 29);
            this.rbOneSupplier.TabIndex = 1;
            this.rbOneSupplier.Text = "مورد  محدد";
            this.rbOneSupplier.UseVisualStyleBackColor = true;
            // 
            // rbAllSuppliers
            // 
            this.rbAllSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAllSuppliers.AutoSize = true;
            this.rbAllSuppliers.Checked = true;
            this.rbAllSuppliers.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbAllSuppliers.Location = new System.Drawing.Point(753, 20);
            this.rbAllSuppliers.Name = "rbAllSuppliers";
            this.rbAllSuppliers.Size = new System.Drawing.Size(124, 29);
            this.rbAllSuppliers.TabIndex = 0;
            this.rbAllSuppliers.TabStop = true;
            this.rbAllSuppliers.Text = "جميع الموردين";
            this.rbAllSuppliers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSearchResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 313);
            this.groupBox2.TabIndex = 18;
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
            this.SupplierName,
            this.ProcessType,
            this.OrderNumber,
            this.Debit,
            this.StockDateTime});
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
            this.dgvSearchResult.Size = new System.Drawing.Size(878, 284);
            this.dgvSearchResult.TabIndex = 13;
            // 
            // OrderProductId
            // 
            this.OrderProductId.DataPropertyName = "Id";
            this.OrderProductId.HeaderText = "رقم مرجعي المنتج";
            this.OrderProductId.Name = "OrderProductId";
            this.OrderProductId.ReadOnly = true;
            this.OrderProductId.Visible = false;
            // 
            // SupplierName
            // 
            this.SupplierName.FillWeight = 147.4798F;
            this.SupplierName.HeaderText = "اسم المورد";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // ProcessType
            // 
            this.ProcessType.FillWeight = 95.68217F;
            this.ProcessType.HeaderText = "البيان";
            this.ProcessType.Name = "ProcessType";
            this.ProcessType.ReadOnly = true;
            // 
            // OrderNumber
            // 
            this.OrderNumber.FillWeight = 77.42466F;
            this.OrderNumber.HeaderText = "رقم الفاتورة";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // Debit
            // 
            this.Debit.FillWeight = 112.1535F;
            this.Debit.HeaderText = "مدين (مستحق للمورد)";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // StockDateTime
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.StockDateTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.StockDateTime.FillWeight = 74.69918F;
            this.StockDateTime.HeaderText = "اليوم والتاريخ";
            this.StockDateTime.Name = "StockDateTime";
            this.StockDateTime.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "مستحقات الموردين";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalSupplierDefered);
            this.groupBox3.Controls.Add(this.btnPay);
            this.groupBox3.Controls.Add(this.lblCurency);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rbPayPartOfDefered);
            this.groupBox3.Controls.Add(this.rbPayAllDefereds);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.groupBox3.Location = new System.Drawing.Point(20, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(884, 71);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملية سداد";
            // 
            // txtTotalSupplierDefered
            // 
            this.txtTotalSupplierDefered.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalSupplierDefered.BorderColor = System.Drawing.Color.Black;
            this.txtTotalSupplierDefered.BorderRadius = 5;
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
            this.txtTotalSupplierDefered.Location = new System.Drawing.Point(90, 21);
            this.txtTotalSupplierDefered.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.txtTotalSupplierDefered.Name = "txtTotalSupplierDefered";
            this.txtTotalSupplierDefered.PasswordChar = '\0';
            this.txtTotalSupplierDefered.PlaceholderText = "";
            this.txtTotalSupplierDefered.SelectedText = "";
            this.txtTotalSupplierDefered.ShadowDecoration.Parent = this.txtTotalSupplierDefered;
            this.txtTotalSupplierDefered.Size = new System.Drawing.Size(125, 35);
            this.txtTotalSupplierDefered.TabIndex = 17;
            this.txtTotalSupplierDefered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPay.BorderRadius = 5;
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnPay.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Location = new System.Drawing.Point(427, 20);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(113, 35);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "تسديد | F10";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblCurency
            // 
            this.lblCurency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurency.AutoSize = true;
            this.lblCurency.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.lblCurency.Location = new System.Drawing.Point(32, 27);
            this.lblCurency.Name = "lblCurency";
            this.lblCurency.Size = new System.Drawing.Size(48, 22);
            this.lblCurency.TabIndex = 20;
            this.lblCurency.Text = "العملة";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(223, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "إجمالي المستحقات : ";
            // 
            // rbPayPartOfDefered
            // 
            this.rbPayPartOfDefered.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbPayPartOfDefered.AutoSize = true;
            this.rbPayPartOfDefered.Checked = true;
            this.rbPayPartOfDefered.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbPayPartOfDefered.ForeColor = System.Drawing.Color.Black;
            this.rbPayPartOfDefered.Location = new System.Drawing.Point(560, 23);
            this.rbPayPartOfDefered.Name = "rbPayPartOfDefered";
            this.rbPayPartOfDefered.Size = new System.Drawing.Size(111, 29);
            this.rbPayPartOfDefered.TabIndex = 1;
            this.rbPayPartOfDefered.TabStop = true;
            this.rbPayPartOfDefered.Text = "تسديد جزئي";
            this.rbPayPartOfDefered.UseVisualStyleBackColor = true;
            // 
            // rbPayAllDefereds
            // 
            this.rbPayAllDefereds.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbPayAllDefereds.AutoSize = true;
            this.rbPayAllDefereds.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbPayAllDefereds.ForeColor = System.Drawing.Color.Black;
            this.rbPayAllDefereds.Location = new System.Drawing.Point(691, 23);
            this.rbPayAllDefereds.Name = "rbPayAllDefereds";
            this.rbPayAllDefereds.Size = new System.Drawing.Size(183, 29);
            this.rbPayAllDefereds.TabIndex = 0;
            this.rbPayAllDefereds.Text = "تسديد كامل المستحقات";
            this.rbPayAllDefereds.UseVisualStyleBackColor = true;
            // 
            // frmSupplierDebits
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 541);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Movable = false;
            this.Name = "frmSupplierDebits";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOneSupplier;
        private System.Windows.Forms.RadioButton rbAllSuppliers;
        private System.Windows.Forms.ComboBox cbxSuppliers;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDateTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.Windows.Forms.RadioButton rbPayPartOfDefered;
        private System.Windows.Forms.RadioButton rbPayAllDefereds;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalSupplierDefered;
        private System.Windows.Forms.Label lblCurency;
        private System.Windows.Forms.Label label2;
    }
}