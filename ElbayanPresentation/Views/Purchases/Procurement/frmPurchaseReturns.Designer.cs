
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseReturns));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOrderReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSupplierDefered = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.OrderProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWithVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.guna2TextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox1.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(487, 20);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(210, 35);
            this.guna2TextBox1.TabIndex = 21;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(241, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = ".........................";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBox3.Location = new System.Drawing.Point(20, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(863, 64);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ملخص الفاتورة";
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
            this.guna2TextBox5.Location = new System.Drawing.Point(10, 27);
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
            this.guna2TextBox4.Location = new System.Drawing.Point(224, 27);
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
            this.label7.Location = new System.Drawing.Point(324, 30);
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
            this.guna2TextBox3.Location = new System.Drawing.Point(413, 27);
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
            this.label6.Location = new System.Drawing.Point(513, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "المبتقي : ";
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
            this.txtTotalSupplierDefered.Location = new System.Drawing.Point(609, 27);
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
            this.label2.Location = new System.Drawing.Point(732, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "إجمالي الفاتورة : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSearchResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 224);
            this.groupBox2.TabIndex = 27;
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
            this.StockDateTime,
            this.VATValue,
            this.PriceWithVAT,
            this.OrderDate,
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
            this.dgvSearchResult.Size = new System.Drawing.Size(857, 195);
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
            this.SupplierName.HeaderText = "اسم الصنف";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // ProcessType
            // 
            this.ProcessType.FillWeight = 95.68217F;
            this.ProcessType.HeaderText = "الكمية ";
            this.ProcessType.Name = "ProcessType";
            this.ProcessType.ReadOnly = true;
            // 
            // OrderNumber
            // 
            this.OrderNumber.FillWeight = 77.42466F;
            this.OrderNumber.HeaderText = "الوحدة";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
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
            // OrderDate
            // 
            this.OrderDate.HeaderText = "تاريخ الفاتورة";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "المستخدم";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.guna2Button3);
            this.groupBox4.Controls.Add(this.guna2Button2);
            this.groupBox4.Controls.Add(this.guna2Button1);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.guna2TextBox2);
            this.groupBox4.Controls.Add(this.guna2TextBox7);
            this.groupBox4.Controls.Add(this.guna2TextBox6);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(20, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 30);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.guna2Button3.Location = new System.Drawing.Point(133, 84);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(148, 35);
            this.guna2Button3.TabIndex = 16;
            this.guna2Button3.Text = "إرجاع الكمية المحددة";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(342, 84);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(148, 35);
            this.guna2Button2.TabIndex = 16;
            this.guna2Button2.Text = "إرجاع الصنف المحدد كاملا";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.HotTrack;
            this.guna2Button1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(342, 31);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(148, 35);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "كامل الفاتورة مرتجع";
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButton2.Location = new System.Drawing.Point(133, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(203, 29);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "إرجاع كمية محددة من صنف";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox2.BorderRadius = 3;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox2.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox2.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(513, 110);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(184, 28);
            this.guna2TextBox2.TabIndex = 17;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox7.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox7.BorderRadius = 3;
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox7.DefaultText = "";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.Parent = this.guna2TextBox7;
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox7.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox7.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox7.FocusedState.Parent = this.guna2TextBox7;
            this.guna2TextBox7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox7.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.HoverState.Parent = this.guna2TextBox7;
            this.guna2TextBox7.Location = new System.Drawing.Point(513, 73);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "";
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.ShadowDecoration.Parent = this.guna2TextBox7;
            this.guna2TextBox7.Size = new System.Drawing.Size(184, 28);
            this.guna2TextBox7.TabIndex = 17;
            this.guna2TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox6.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox6.BorderRadius = 3;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox6.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox6.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.FocusedState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox6.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.HoverState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Location = new System.Drawing.Point(513, 38);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.ShadowDecoration.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Size = new System.Drawing.Size(184, 28);
            this.guna2TextBox6.TabIndex = 17;
            this.guna2TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(659, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "اسم نقطة البيع";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(783, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "إسم المستخدم";
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Movable = false;
            this.Name = "frmPurchaseReturns";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalSupplierDefered;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceWithVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpOrderReturnDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}