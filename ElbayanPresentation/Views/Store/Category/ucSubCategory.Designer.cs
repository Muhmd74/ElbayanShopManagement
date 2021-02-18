
namespace ElbayaNPresentation.Views.Store.Category
{
    partial class ucSubCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSubCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteByOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDeletedSubCategory = new System.Windows.Forms.DataGridView();
            this.DeletedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvSubCategory = new System.Windows.Forms.DataGridView();
            this.ActiveMainCategory = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMainCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSubCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubcategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMainCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMainCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedSubCategory)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.ActiveMainCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeletedDescription
            // 
            this.DeletedDescription.DataPropertyName = "Description";
            this.DeletedDescription.HeaderText = "وصف التصنيف";
            this.DeletedDescription.MinimumWidth = 6;
            this.DeletedDescription.Name = "DeletedDescription";
            this.DeletedDescription.ReadOnly = true;
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
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "بحث باسم التصنيف";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.AppearanceHovered.Options.UseFont = true;
            this.btnSearch.AppearanceHovered.Options.UseTextOptions = true;
            this.btnSearch.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.AppearancePressed.Options.UseTextOptions = true;
            this.btnSearch.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.ImageOptions.ImageToTextIndent = 23;
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearch.ImageOptions.SvgImage")));
            this.btnSearch.Location = new System.Drawing.Point(423, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 55);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "ابحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(107, 122);
            this.txtSearch.MaxLength = 250;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(459, 36);
            this.txtSearch.TabIndex = 6;
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
            this.btnDeleteByOne.Location = new System.Drawing.Point(788, 214);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.Size = new System.Drawing.Size(212, 48);
            this.btnDeleteByOne.TabIndex = 5;
            this.btnDeleteByOne.Text = "أرشفة ";
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
            this.btnUpdate.Location = new System.Drawing.Point(1033, 213);
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
            this.btnAdd.Location = new System.Drawing.Point(1286, 213);
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
            this.txtName.Location = new System.Drawing.Point(789, 40);
            this.txtName.MaxLength = 250;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(573, 36);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(789, 82);
            this.txtDescription.MaxLength = 1000;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(573, 104);
            this.txtDescription.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDeletedSubCategory);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1497, 458);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "التصنفيات المؤرشفة";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDeletedSubCategory
            // 
            this.dgvDeletedSubCategory.AllowUserToAddRows = false;
            this.dgvDeletedSubCategory.AllowUserToDeleteRows = false;
            this.dgvDeletedSubCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedSubCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedSubCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeletedSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DeletedName,
            this.DeletedDescription});
            this.dgvDeletedSubCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedSubCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedSubCategory.Name = "dgvDeletedSubCategory";
            this.dgvDeletedSubCategory.ReadOnly = true;
            this.dgvDeletedSubCategory.RowHeadersWidth = 51;
            this.dgvDeletedSubCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedSubCategory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedSubCategory.RowTemplate.Height = 35;
            this.dgvDeletedSubCategory.Size = new System.Drawing.Size(1491, 452);
            this.dgvDeletedSubCategory.TabIndex = 1;
            // 
            // DeletedName
            // 
            this.DeletedName.DataPropertyName = "Name";
            this.DeletedName.HeaderText = "اسم التصنيف";
            this.DeletedName.MinimumWidth = 6;
            this.DeletedName.Name = "DeletedName";
            this.DeletedName.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1371, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "وصف تعريفي";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.dgvSubCategory);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1497, 458);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "التصنيفات النشطة";
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.AllowUserToAddRows = false;
            this.dgvSubCategory.AllowUserToDeleteRows = false;
            this.dgvSubCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubCategoryID,
            this.dgvSubCategoryName,
            this.dgvSubcategoryDescription,
            this.dgvMainCategoryId,
            this.dgvMainCategoryName});
            this.dgvSubCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.ReadOnly = true;
            this.dgvSubCategory.RowHeadersWidth = 51;
            this.dgvSubCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSubCategory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvSubCategory.RowTemplate.Height = 35;
            this.dgvSubCategory.Size = new System.Drawing.Size(1491, 452);
            this.dgvSubCategory.TabIndex = 0;
            this.dgvSubCategory.DoubleClick += new System.EventHandler(this.dgvSubCategory_DoubleClick);
            // 
            // ActiveMainCategory
            // 
            this.ActiveMainCategory.Controls.Add(this.tabPage3);
            this.ActiveMainCategory.Controls.Add(this.tabPage4);
            this.ActiveMainCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActiveMainCategory.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveMainCategory.Location = new System.Drawing.Point(0, 303);
            this.ActiveMainCategory.Name = "ActiveMainCategory";
            this.ActiveMainCategory.RightToLeftLayout = true;
            this.ActiveMainCategory.SelectedIndex = 0;
            this.ActiveMainCategory.Size = new System.Drawing.Size(1505, 499);
            this.ActiveMainCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1370, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم التصنيف";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbxMainCategory);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnDeleteByOne);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1505, 297);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbxMainCategory
            // 
            this.cbxMainCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMainCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxMainCategory.FormattingEnabled = true;
            this.cbxMainCategory.Location = new System.Drawing.Point(107, 40);
            this.cbxMainCategory.Name = "cbxMainCategory";
            this.cbxMainCategory.Size = new System.Drawing.Size(459, 36);
            this.cbxMainCategory.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "اختر التصنيف الرئيسي";
            // 
            // dgvSubCategoryID
            // 
            this.dgvSubCategoryID.DataPropertyName = "Id";
            this.dgvSubCategoryID.HeaderText = "الرقم المرجعي";
            this.dgvSubCategoryID.MinimumWidth = 6;
            this.dgvSubCategoryID.Name = "dgvSubCategoryID";
            this.dgvSubCategoryID.ReadOnly = true;
            this.dgvSubCategoryID.Visible = false;
            // 
            // dgvSubCategoryName
            // 
            this.dgvSubCategoryName.DataPropertyName = "Name";
            this.dgvSubCategoryName.HeaderText = "اسم التصنيف الفرعي";
            this.dgvSubCategoryName.MinimumWidth = 6;
            this.dgvSubCategoryName.Name = "dgvSubCategoryName";
            this.dgvSubCategoryName.ReadOnly = true;
            // 
            // dgvSubcategoryDescription
            // 
            this.dgvSubcategoryDescription.DataPropertyName = "Description";
            this.dgvSubcategoryDescription.HeaderText = "وصف التصنيف الفرعي";
            this.dgvSubcategoryDescription.MinimumWidth = 6;
            this.dgvSubcategoryDescription.Name = "dgvSubcategoryDescription";
            this.dgvSubcategoryDescription.ReadOnly = true;
            // 
            // dgvMainCategoryId
            // 
            this.dgvMainCategoryId.DataPropertyName = "CategoryId";
            this.dgvMainCategoryId.HeaderText = "الرقم المرجعي للتصنيف الرئيسي";
            this.dgvMainCategoryId.MinimumWidth = 6;
            this.dgvMainCategoryId.Name = "dgvMainCategoryId";
            this.dgvMainCategoryId.ReadOnly = true;
            this.dgvMainCategoryId.Visible = false;
            // 
            // dgvMainCategoryName
            // 
            this.dgvMainCategoryName.DataPropertyName = "CategoryName";
            this.dgvMainCategoryName.HeaderText = "اسم التصنيف الرئيسي";
            this.dgvMainCategoryName.MinimumWidth = 6;
            this.dgvMainCategoryName.Name = "dgvMainCategoryName";
            this.dgvMainCategoryName.ReadOnly = true;
            // 
            // ucSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActiveMainCategory);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucSubCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1505, 802);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedSubCategory)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.ActiveMainCategory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnDeleteByOne;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl ActiveMainCategory;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvSubCategory;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDeletedSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMainCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubcategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMainCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMainCategoryName;
    }
}
