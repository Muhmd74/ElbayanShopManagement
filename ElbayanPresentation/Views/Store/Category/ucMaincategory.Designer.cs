namespace ElbayaNPresentation.Views.Store.Category
{
    partial class ucMaincategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMaincategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteByOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActiveMainCategory = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvMainCategory = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDeletedMainCategory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.ActiveMainCategory.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCategory)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedMainCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.guna2TextBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDeleteByOne);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1282, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "بحث باسم التصنيف";
            // 
            // btnDeleteByOne
            // 
            this.btnDeleteByOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteByOne.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOne.Appearance.Options.UseFont = true;
            this.btnDeleteByOne.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOne.AppearanceHovered.Options.UseFont = true;
            this.btnDeleteByOne.AppearanceHovered.Options.UseTextOptions = true;
            this.btnDeleteByOne.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDeleteByOne.AppearancePressed.Options.UseTextOptions = true;
            this.btnDeleteByOne.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDeleteByOne.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDeleteByOne.ImageOptions.ImageToTextIndent = 23;
            this.btnDeleteByOne.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteByOne.ImageOptions.SvgImage")));
            this.btnDeleteByOne.Location = new System.Drawing.Point(565, 214);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.Size = new System.Drawing.Size(212, 48);
            this.btnDeleteByOne.TabIndex = 5;
            this.btnDeleteByOne.Text = "أرشفة ";
            this.btnDeleteByOne.Click += new System.EventHandler(this.btnDeleteByOne_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.AppearanceHovered.Options.UseTextOptions = true;
            this.btnUpdate.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.AppearancePressed.Options.UseTextOptions = true;
            this.btnUpdate.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnUpdate.ImageOptions.ImageToTextIndent = 23;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(810, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 48);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "حفظ التعديلات";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseTextOptions = true;
            this.btnAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.AppearanceHovered.Options.UseTextOptions = true;
            this.btnAdd.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.AppearancePressed.Options.UseTextOptions = true;
            this.btnAdd.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.ImageOptions.ImageToTextIndent = 11;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(1063, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "إضافة ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(566, 40);
            this.txtName.MaxLength = 250;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(573, 36);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(566, 82);
            this.txtDescription.MaxLength = 1000;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(573, 104);
            this.txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1148, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "وصف تعريفي";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1147, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم التصنيف";
            // 
            // ActiveMainCategory
            // 
            this.ActiveMainCategory.Controls.Add(this.tabPage3);
            this.ActiveMainCategory.Controls.Add(this.tabPage4);
            this.ActiveMainCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActiveMainCategory.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveMainCategory.Location = new System.Drawing.Point(0, 269);
            this.ActiveMainCategory.Name = "ActiveMainCategory";
            this.ActiveMainCategory.RightToLeftLayout = true;
            this.ActiveMainCategory.SelectedIndex = 0;
            this.ActiveMainCategory.Size = new System.Drawing.Size(1282, 448);
            this.ActiveMainCategory.TabIndex = 0;
            this.ActiveMainCategory.Selected += new System.Windows.Forms.TabControlEventHandler(this.ActiveMainCategory_Selected);
            this.ActiveMainCategory.Click += new System.EventHandler(this.ActiveMainCategory_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.dgvMainCategory);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1274, 407);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "التصنيفات النشطة";
            // 
            // dgvMainCategory
            // 
            this.dgvMainCategory.AllowUserToAddRows = false;
            this.dgvMainCategory.AllowUserToDeleteRows = false;
            this.dgvMainCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMainCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMainCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMainCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName,
            this.Description});
            this.dgvMainCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvMainCategory.Name = "dgvMainCategory";
            this.dgvMainCategory.ReadOnly = true;
            this.dgvMainCategory.RowHeadersWidth = 51;
            this.dgvMainCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMainCategory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvMainCategory.RowTemplate.Height = 35;
            this.dgvMainCategory.Size = new System.Drawing.Size(1268, 401);
            this.dgvMainCategory.TabIndex = 0;
            this.dgvMainCategory.DoubleClick += new System.EventHandler(this.dgvMainCategory_DoubleClick);
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.HeaderText = "اسم التصنيف";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "وصف التصنيف";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDeletedMainCategory);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1274, 407);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "التصنفيات المؤرشفة";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDeletedMainCategory
            // 
            this.dgvDeletedMainCategory.AllowUserToAddRows = false;
            this.dgvDeletedMainCategory.AllowUserToDeleteRows = false;
            this.dgvDeletedMainCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedMainCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedMainCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeletedMainCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedMainCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DeletedName,
            this.DeletedDescription});
            this.dgvDeletedMainCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedMainCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedMainCategory.Name = "dgvDeletedMainCategory";
            this.dgvDeletedMainCategory.ReadOnly = true;
            this.dgvDeletedMainCategory.RowHeadersWidth = 51;
            this.dgvDeletedMainCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedMainCategory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedMainCategory.RowTemplate.Height = 35;
            this.dgvDeletedMainCategory.Size = new System.Drawing.Size(1268, 401);
            this.dgvDeletedMainCategory.TabIndex = 1;
            this.dgvDeletedMainCategory.DoubleClick += new System.EventHandler(this.dgvDeletedMainCategory_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DeletedName
            // 
            this.DeletedName.DataPropertyName = "Name";
            this.DeletedName.HeaderText = "اسم التصنيف";
            this.DeletedName.MinimumWidth = 6;
            this.DeletedName.Name = "DeletedName";
            this.DeletedName.ReadOnly = true;
            // 
            // DeletedDescription
            // 
            this.DeletedDescription.DataPropertyName = "Description";
            this.DeletedDescription.HeaderText = "وصف التصنيف";
            this.DeletedDescription.MinimumWidth = 6;
            this.DeletedDescription.Name = "DeletedDescription";
            this.DeletedDescription.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(82, 32);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(297, 57);
            this.guna2TextBox1.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 17;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnSearch.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(331, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(190, 56);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "إبحث";
            // 
            // ucMaincategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActiveMainCategory);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucMaincategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1282, 717);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ActiveMainCategory.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCategory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedMainCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl ActiveMainCategory;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDeleteByOne;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.DataGridView dgvMainCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDeletedMainCategory;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedDescription;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
    }
}
