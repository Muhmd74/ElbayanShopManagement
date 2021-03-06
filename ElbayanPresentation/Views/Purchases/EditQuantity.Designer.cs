
namespace ElbayaNPresentation.Views.Purchases
{
    partial class frmEditQuantity
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
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblCurrencySubtotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubtotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblCurrencyPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbIncludeVAT = new System.Windows.Forms.CheckBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtDefaultPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscountValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVatValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtQuantity.BorderColor = System.Drawing.Color.Gray;
            this.txtQuantity.BorderRadius = 5;
            this.txtQuantity.BorderThickness = 2;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtQuantity.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(151, 54);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(7, 12, 7, 12);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(169, 39);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(62, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 21);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "الكمية";
            // 
            // lblCurrencySubtotal
            // 
            this.lblCurrencySubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurrencySubtotal.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencySubtotal.Appearance.Options.UseFont = true;
            this.lblCurrencySubtotal.Location = new System.Drawing.Point(62, 104);
            this.lblCurrencySubtotal.Name = "lblCurrencySubtotal";
            this.lblCurrencySubtotal.Size = new System.Drawing.Size(63, 21);
            this.lblCurrencySubtotal.TabIndex = 11;
            this.lblCurrencySubtotal.Text = "سعر الشراء";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(62, 200);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 21);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "نسبة خصم";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDiscount.BorderColor = System.Drawing.Color.Gray;
            this.txtDiscount.BorderRadius = 5;
            this.txtDiscount.BorderThickness = 2;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtDiscount.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(151, 198);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(169, 39);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSubtotal.BorderColor = System.Drawing.Color.Gray;
            this.txtSubtotal.BorderRadius = 5;
            this.txtSubtotal.BorderThickness = 2;
            this.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubtotal.DefaultText = "";
            this.txtSubtotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubtotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubtotal.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSubtotal.DisabledState.Parent = this.txtSubtotal;
            this.txtSubtotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtSubtotal.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtSubtotal.FocusedState.Parent = this.txtSubtotal;
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubtotal.HoverState.Parent = this.txtSubtotal;
            this.txtSubtotal.Location = new System.Drawing.Point(151, 148);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(10, 18, 10, 18);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.PlaceholderText = "";
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.ShadowDecoration.Parent = this.txtSubtotal;
            this.txtSubtotal.Size = new System.Drawing.Size(169, 39);
            this.txtSubtotal.TabIndex = 16;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(357, 149);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 21);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "ريال سعودي";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(62, 149);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 21);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "إجمالي الكمية";
            // 
            // lblCurrencyPrice
            // 
            this.lblCurrencyPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurrencyPrice.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyPrice.Appearance.Options.UseFont = true;
            this.lblCurrencyPrice.Location = new System.Drawing.Point(357, 106);
            this.lblCurrencyPrice.Name = "lblCurrencyPrice";
            this.lblCurrencyPrice.Size = new System.Drawing.Size(67, 21);
            this.lblCurrencyPrice.TabIndex = 11;
            this.lblCurrencyPrice.Text = "ريال سعودي";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(332, 204);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(13, 26);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "%";
            // 
            // txtTotalProductPrice
            // 
            this.txtTotalProductPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalProductPrice.BorderColor = System.Drawing.Color.Gray;
            this.txtTotalProductPrice.BorderRadius = 5;
            this.txtTotalProductPrice.BorderThickness = 2;
            this.txtTotalProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalProductPrice.DefaultText = "";
            this.txtTotalProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalProductPrice.DisabledState.Parent = this.txtTotalProductPrice;
            this.txtTotalProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalProductPrice.Enabled = false;
            this.txtTotalProductPrice.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTotalProductPrice.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtTotalProductPrice.FocusedState.Parent = this.txtTotalProductPrice;
            this.txtTotalProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalProductPrice.HoverState.Parent = this.txtTotalProductPrice;
            this.txtTotalProductPrice.Location = new System.Drawing.Point(168, 248);
            this.txtTotalProductPrice.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtTotalProductPrice.Name = "txtTotalProductPrice";
            this.txtTotalProductPrice.PasswordChar = '\0';
            this.txtTotalProductPrice.PlaceholderText = "";
            this.txtTotalProductPrice.SelectedText = "";
            this.txtTotalProductPrice.ShadowDecoration.Parent = this.txtTotalProductPrice;
            this.txtTotalProductPrice.Size = new System.Drawing.Size(152, 39);
            this.txtTotalProductPrice.TabIndex = 4;
            this.txtTotalProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(53, 256);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(109, 21);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "الإجمالي بعد الخصم";
            // 
            // cbIncludeVAT
            // 
            this.cbIncludeVAT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbIncludeVAT.AutoSize = true;
            this.cbIncludeVAT.Enabled = false;
            this.cbIncludeVAT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncludeVAT.Location = new System.Drawing.Point(39, 304);
            this.cbIncludeVAT.Name = "cbIncludeVAT";
            this.cbIncludeVAT.Size = new System.Drawing.Size(152, 19);
            this.cbIncludeVAT.TabIndex = 5;
            this.cbIncludeVAT.Text = "ضريبة القيم المضافة VAT";
            this.cbIncludeVAT.UseVisualStyleBackColor = true;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(35, 350);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(94, 22);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "الإجمالي  مع الضريبة";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalPrice.BorderColor = System.Drawing.Color.Gray;
            this.txtTotalPrice.BorderRadius = 5;
            this.txtTotalPrice.BorderThickness = 2;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTotalPrice.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(154, 342);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(169, 39);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(39, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "إدراج الكمية";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(276, 421);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(137, 26);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = " لإدراج الكمية  | Enter ";
            // 
            // txtDefaultPrice
            // 
            this.txtDefaultPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDefaultPrice.BorderColor = System.Drawing.Color.Gray;
            this.txtDefaultPrice.BorderRadius = 5;
            this.txtDefaultPrice.BorderThickness = 2;
            this.txtDefaultPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefaultPrice.DefaultText = "";
            this.txtDefaultPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefaultPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefaultPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultPrice.DisabledState.Parent = this.txtDefaultPrice;
            this.txtDefaultPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDefaultPrice.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtDefaultPrice.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtDefaultPrice.FocusedState.Parent = this.txtDefaultPrice;
            this.txtDefaultPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultPrice.HoverState.Parent = this.txtDefaultPrice;
            this.txtDefaultPrice.Location = new System.Drawing.Point(151, 100);
            this.txtDefaultPrice.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtDefaultPrice.Name = "txtDefaultPrice";
            this.txtDefaultPrice.PasswordChar = '\0';
            this.txtDefaultPrice.PlaceholderText = "";
            this.txtDefaultPrice.SelectedText = "";
            this.txtDefaultPrice.ShadowDecoration.Parent = this.txtDefaultPrice;
            this.txtDefaultPrice.Size = new System.Drawing.Size(169, 39);
            this.txtDefaultPrice.TabIndex = 2;
            this.txtDefaultPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDefaultPrice.Enter += new System.EventHandler(this.txtDefaultPrice_Enter);
            this.txtDefaultPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDefaultPrice_KeyPress);
            this.txtDefaultPrice.Leave += new System.EventHandler(this.txtDefaultPrice_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "التعديل على كمية صنف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(463, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "ريال سعودي";
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDiscountValue.BorderColor = System.Drawing.Color.Gray;
            this.txtDiscountValue.BorderRadius = 5;
            this.txtDiscountValue.BorderThickness = 2;
            this.txtDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountValue.DefaultText = "";
            this.txtDiscountValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscountValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscountValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscountValue.DisabledState.Parent = this.txtDiscountValue;
            this.txtDiscountValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiscountValue.Enabled = false;
            this.txtDiscountValue.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtDiscountValue.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtDiscountValue.FocusedState.Parent = this.txtDiscountValue;
            this.txtDiscountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.txtDiscountValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscountValue.HoverState.Parent = this.txtDiscountValue;
            this.txtDiscountValue.Location = new System.Drawing.Point(357, 198);
            this.txtDiscountValue.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.PasswordChar = '\0';
            this.txtDiscountValue.PlaceholderText = "";
            this.txtDiscountValue.SelectedText = "";
            this.txtDiscountValue.ShadowDecoration.Parent = this.txtDiscountValue;
            this.txtDiscountValue.Size = new System.Drawing.Size(94, 39);
            this.txtDiscountValue.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDiscountValue.TabIndex = 4;
            this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVatValue
            // 
            this.txtVatValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtVatValue.BorderColor = System.Drawing.Color.Gray;
            this.txtVatValue.BorderRadius = 5;
            this.txtVatValue.BorderThickness = 2;
            this.txtVatValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVatValue.DefaultText = "";
            this.txtVatValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVatValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVatValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVatValue.DisabledState.Parent = this.txtVatValue;
            this.txtVatValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtVatValue.Enabled = false;
            this.txtVatValue.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtVatValue.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.txtVatValue.FocusedState.Parent = this.txtVatValue;
            this.txtVatValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.txtVatValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVatValue.HoverState.Parent = this.txtVatValue;
            this.txtVatValue.Location = new System.Drawing.Point(203, 294);
            this.txtVatValue.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtVatValue.Name = "txtVatValue";
            this.txtVatValue.PasswordChar = '\0';
            this.txtVatValue.PlaceholderText = "";
            this.txtVatValue.SelectedText = "";
            this.txtVatValue.ShadowDecoration.Parent = this.txtVatValue;
            this.txtVatValue.Size = new System.Drawing.Size(120, 39);
            this.txtVatValue.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtVatValue.TabIndex = 18;
            this.txtVatValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEditQuantity
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(554, 462);
            this.ControlBox = false;
            this.Controls.Add(this.txtVatValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbIncludeVAT);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtDefaultPrice);
            this.Controls.Add(this.txtDiscountValue);
            this.Controls.Add(this.txtTotalProductPrice);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblCurrencyPrice);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblCurrencySubtotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.labelControl2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditQuantity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditQuantity_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditQuantity_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblCurrencySubtotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        internal Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        internal Guna.UI2.WinForms.Guna2TextBox txtSubtotal;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblCurrencyPrice;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        internal Guna.UI2.WinForms.Guna2TextBox txtTotalProductPrice;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.CheckBox cbIncludeVAT;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        internal Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        internal Guna.UI2.WinForms.Guna2TextBox txtDefaultPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal Guna.UI2.WinForms.Guna2TextBox txtDiscountValue;
        internal Guna.UI2.WinForms.Guna2TextBox txtVatValue;
    }
}