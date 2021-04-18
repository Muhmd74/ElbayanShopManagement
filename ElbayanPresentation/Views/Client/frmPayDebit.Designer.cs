
namespace ElbayaNPresentation.Views.Client
{
    partial class frmPayDebit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpPaymentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtRefNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtRefNumber);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpPaymentDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.guna2TextBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 358);
            this.panel1.TabIndex = 0;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPaymentDate.BorderRadius = 3;
            this.dtpPaymentDate.BorderThickness = 1;
            this.dtpPaymentDate.CheckedState.Parent = this.dtpPaymentDate;
            this.dtpPaymentDate.FillColor = System.Drawing.Color.White;
            this.dtpPaymentDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.HoverState.Parent = this.dtpPaymentDate;
            this.dtpPaymentDate.Location = new System.Drawing.Point(21, 31);
            this.dtpPaymentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPaymentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.ShadowDecoration.Parent = this.dtpPaymentDate;
            this.dtpPaymentDate.Size = new System.Drawing.Size(170, 31);
            this.dtpPaymentDate.TabIndex = 139;
            this.dtpPaymentDate.Value = new System.DateTime(2021, 4, 7, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(197, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 138;
            this.label7.Text = "تاريخ اليوم :";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(20, 288);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(67, 35);
            this.guna2Button1.TabIndex = 137;
            this.guna2Button1.Text = "رجوع";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnPay.Location = new System.Drawing.Point(116, 288);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(113, 35);
            this.btnPay.TabIndex = 136;
            this.btnPay.Text = "تسديد | F10";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox2.BackColor = System.Drawing.Color.White;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox2.BorderRadius = 5;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox2.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(19, 108);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(224, 84);
            this.guna2TextBox2.TabIndex = 121;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(129, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 132;
            this.label6.Text = "ملاحظات توضيحية";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "شيك",
            "حوالة ",
            "إيداع",
            "نقدا",
            "أخرى"});
            this.comboBox1.Location = new System.Drawing.Point(292, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 30);
            this.comboBox1.TabIndex = 152;
            // 
            // txtRefNumber
            // 
            this.txtRefNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtRefNumber.BackColor = System.Drawing.Color.White;
            this.txtRefNumber.BorderColor = System.Drawing.Color.Gray;
            this.txtRefNumber.BorderRadius = 1;
            this.txtRefNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRefNumber.DefaultText = "";
            this.txtRefNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRefNumber.DisabledState.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.txtRefNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRefNumber.DisabledState.Parent = this.txtRefNumber;
            this.txtRefNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefNumber.Enabled = false;
            this.txtRefNumber.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtRefNumber.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtRefNumber.FocusedState.Parent = this.txtRefNumber;
            this.txtRefNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNumber.ForeColor = System.Drawing.Color.Black;
            this.txtRefNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefNumber.HoverState.Parent = this.txtRefNumber;
            this.txtRefNumber.Location = new System.Drawing.Point(292, 27);
            this.txtRefNumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtRefNumber.Name = "txtRefNumber";
            this.txtRefNumber.PasswordChar = '\0';
            this.txtRefNumber.PlaceholderText = "";
            this.txtRefNumber.SelectedText = "";
            this.txtRefNumber.ShadowDecoration.Parent = this.txtRefNumber;
            this.txtRefNumber.Size = new System.Drawing.Size(214, 35);
            this.txtRefNumber.TabIndex = 140;
            this.txtRefNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox1.BackColor = System.Drawing.Color.White;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.BorderRadius = 1;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(292, 279);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(214, 37);
            this.guna2TextBox1.TabIndex = 143;
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMobile.BackColor = System.Drawing.Color.White;
            this.txtMobile.BorderColor = System.Drawing.Color.Gray;
            this.txtMobile.BorderRadius = 1;
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobile.DefaultText = "";
            this.txtMobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobile.DisabledState.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.txtMobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMobile.DisabledState.Parent = this.txtMobile;
            this.txtMobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobile.Enabled = false;
            this.txtMobile.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtMobile.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtMobile.FocusedState.Parent = this.txtMobile;
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtMobile.ForeColor = System.Drawing.Color.Black;
            this.txtMobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobile.HoverState.Parent = this.txtMobile;
            this.txtMobile.Location = new System.Drawing.Point(292, 180);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.PlaceholderText = "";
            this.txtMobile.SelectedText = "";
            this.txtMobile.ShadowDecoration.Parent = this.txtMobile;
            this.txtMobile.Size = new System.Drawing.Size(214, 37);
            this.txtMobile.TabIndex = 144;
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPayment.BackColor = System.Drawing.Color.White;
            this.txtPayment.BorderColor = System.Drawing.Color.Gray;
            this.txtPayment.BorderRadius = 1;
            this.txtPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayment.DefaultText = "0";
            this.txtPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayment.DisabledState.Parent = this.txtPayment;
            this.txtPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayment.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtPayment.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtPayment.FocusedState.Parent = this.txtPayment;
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtPayment.ForeColor = System.Drawing.Color.Black;
            this.txtPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayment.HoverState.Parent = this.txtPayment;
            this.txtPayment.Location = new System.Drawing.Point(292, 132);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PasswordChar = '\0';
            this.txtPayment.PlaceholderText = "";
            this.txtPayment.SelectedText = "";
            this.txtPayment.SelectionStart = 1;
            this.txtPayment.ShadowDecoration.Parent = this.txtPayment;
            this.txtPayment.Size = new System.Drawing.Size(214, 37);
            this.txtPayment.TabIndex = 142;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Gray;
            this.txtName.BorderRadius = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.Enabled = false;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtName.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(292, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(214, 37);
            this.txtName.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(75, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 148;
            this.label2.Text = "تنزيل مستحقات";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(524, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 149;
            this.label5.Text = "طرف مسدد ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(523, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 145;
            this.label4.Text = "رقم مرجعي #";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(520, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 146;
            this.label3.Text = "طريقة السداد";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(519, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 22);
            this.label12.TabIndex = 147;
            this.label12.Text = "الرصيد اللاحق";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(518, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 22);
            this.label11.TabIndex = 150;
            this.label11.Text = "المبلغ المسدد";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(517, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 151;
            this.label1.Text = "الرصيد السابق";
            // 
            // frmPayDebit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(669, 438);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Movable = false;
            this.Name = "frmPayDebit";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.Load += new System.EventHandler(this.frmPayDebit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtRefNumber;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtMobile;
        private Guna.UI2.WinForms.Guna2TextBox txtPayment;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}