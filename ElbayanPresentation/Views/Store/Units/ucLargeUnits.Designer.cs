
namespace ElbayaNPresentation.Views.Store.Units
{
    partial class ucLargeUnits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMainCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteByOne = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActiveMainCategory = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvSubCategory = new System.Windows.Forms.DataGridView();
            this.dgvSubCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubcategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMainCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMainCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDeletedMainCategory = new System.Windows.Forms.DataGridView();
            this.dgvSubCategoryDeletedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedManiCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedMainCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.ActiveMainCategory.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedMainCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbxMainCategory);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDeleteByOne);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1550, 296);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cbxMainCategory
            // 
            this.cbxMainCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMainCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbxMainCategory.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxMainCategory.BorderRadius = 17;
            this.cbxMainCategory.BorderThickness = 2;
            this.cbxMainCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMainCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMainCategory.FocusedColor = System.Drawing.Color.Silver;
            this.cbxMainCategory.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.cbxMainCategory.FocusedState.Parent = this.cbxMainCategory;
            this.cbxMainCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMainCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxMainCategory.FormattingEnabled = true;
            this.cbxMainCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxMainCategory.HoverState.Parent = this.cbxMainCategory;
            this.cbxMainCategory.ItemHeight = 30;
            this.cbxMainCategory.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxMainCategory.ItemsAppearance.Parent = this.cbxMainCategory;
            this.cbxMainCategory.ItemsAppearance.SelectedForeColor = System.Drawing.SystemColors.Highlight;
            this.cbxMainCategory.Location = new System.Drawing.Point(198, 62);
            this.cbxMainCategory.Name = "cbxMainCategory";
            this.cbxMainCategory.ShadowDecoration.Parent = this.cbxMainCategory;
            this.cbxMainCategory.Size = new System.Drawing.Size(372, 36);
            this.cbxMainCategory.TabIndex = 3;
            this.cbxMainCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxMainCategory.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.BorderRadius = 17;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(854, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(542, 54);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.BorderRadius = 17;
            this.txtDescription.BorderThickness = 2;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(854, 95);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(542, 100);
            this.txtDescription.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderRadius = 17;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(1205, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(190, 56);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "إضافة جديدة";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BorderRadius = 17;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.btnUpdate.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(971, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(190, 56);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "حفظ التعديلات";
            // 
            // btnDeleteByOne
            // 
            this.btnDeleteByOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteByOne.BorderRadius = 17;
            this.btnDeleteByOne.CheckedState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.CustomImages.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnDeleteByOne.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOne.ForeColor = System.Drawing.Color.White;
            this.btnDeleteByOne.HoverState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Location = new System.Drawing.Point(727, 205);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.ShadowDecoration.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Size = new System.Drawing.Size(190, 56);
            this.btnDeleteByOne.TabIndex = 6;
            this.btnDeleteByOne.Text = "أرشفة";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderRadius = 17;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnSearch.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(198, 205);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(190, 56);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "إبحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(198, 134);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(372, 58);
            this.txtSearch.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "أختر التصنيف الرئيسي";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "بحث باسم التصنيف";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1415, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "وصف تعريفي";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1414, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم التصنيف";
            // 
            // ActiveMainCategory
            // 
            this.ActiveMainCategory.Controls.Add(this.tabPage3);
            this.ActiveMainCategory.Controls.Add(this.tabPage4);
            this.ActiveMainCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActiveMainCategory.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveMainCategory.Location = new System.Drawing.Point(0, 296);
            this.ActiveMainCategory.Name = "ActiveMainCategory";
            this.ActiveMainCategory.RightToLeftLayout = true;
            this.ActiveMainCategory.SelectedIndex = 0;
            this.ActiveMainCategory.Size = new System.Drawing.Size(1550, 491);
            this.ActiveMainCategory.TabIndex = 4;
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
            this.tabPage3.Size = new System.Drawing.Size(1542, 450);
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
            this.dgvMainCategoryID,
            this.dgvMainCategoryName});
            this.dgvSubCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.ReadOnly = true;
            this.dgvSubCategory.RowHeadersWidth = 51;
            this.dgvSubCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSubCategory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvSubCategory.RowTemplate.Height = 35;
            this.dgvSubCategory.Size = new System.Drawing.Size(1536, 444);
            this.dgvSubCategory.TabIndex = 0;
            // 
            // dgvSubCategoryID
            // 
            this.dgvSubCategoryID.DataPropertyName = "Id";
            this.dgvSubCategoryID.HeaderText = "رقم التصنيف المرجعي";
            this.dgvSubCategoryID.MinimumWidth = 6;
            this.dgvSubCategoryID.Name = "dgvSubCategoryID";
            this.dgvSubCategoryID.ReadOnly = true;
            this.dgvSubCategoryID.Visible = false;
            // 
            // dgvSubCategoryName
            // 
            this.dgvSubCategoryName.DataPropertyName = "Name";
            this.dgvSubCategoryName.HeaderText = "اسم التصنيف";
            this.dgvSubCategoryName.MinimumWidth = 6;
            this.dgvSubCategoryName.Name = "dgvSubCategoryName";
            this.dgvSubCategoryName.ReadOnly = true;
            // 
            // dgvSubcategoryDescription
            // 
            this.dgvSubcategoryDescription.DataPropertyName = "Description";
            this.dgvSubcategoryDescription.HeaderText = "وصف التصنيف";
            this.dgvSubcategoryDescription.MinimumWidth = 6;
            this.dgvSubcategoryDescription.Name = "dgvSubcategoryDescription";
            this.dgvSubcategoryDescription.ReadOnly = true;
            // 
            // dgvMainCategoryID
            // 
            this.dgvMainCategoryID.DataPropertyName = "CategoryId";
            this.dgvMainCategoryID.HeaderText = "رقم التصنيف الرئيسي المرجعي";
            this.dgvMainCategoryID.MinimumWidth = 6;
            this.dgvMainCategoryID.Name = "dgvMainCategoryID";
            this.dgvMainCategoryID.ReadOnly = true;
            this.dgvMainCategoryID.Visible = false;
            // 
            // dgvMainCategoryName
            // 
            this.dgvMainCategoryName.DataPropertyName = "CategoryName";
            this.dgvMainCategoryName.HeaderText = "اسم التصنيف الرئيسي";
            this.dgvMainCategoryName.MinimumWidth = 6;
            this.dgvMainCategoryName.Name = "dgvMainCategoryName";
            this.dgvMainCategoryName.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDeletedMainCategory);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1542, 407);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedMainCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeletedMainCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedMainCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubCategoryDeletedID,
            this.dgvSubCategoryDeletedName,
            this.dgvSubCategoryDeletedDescription,
            this.dgvSubCategoryDeletedManiCategoryID,
            this.dgvSubCategoryDeletedMainCategoryName});
            this.dgvDeletedMainCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedMainCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedMainCategory.Name = "dgvDeletedMainCategory";
            this.dgvDeletedMainCategory.ReadOnly = true;
            this.dgvDeletedMainCategory.RowHeadersWidth = 51;
            this.dgvDeletedMainCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedMainCategory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedMainCategory.RowTemplate.Height = 35;
            this.dgvDeletedMainCategory.Size = new System.Drawing.Size(1536, 401);
            this.dgvDeletedMainCategory.TabIndex = 1;
            // 
            // dgvSubCategoryDeletedID
            // 
            this.dgvSubCategoryDeletedID.DataPropertyName = "Id";
            this.dgvSubCategoryDeletedID.HeaderText = "الرقم المرجعي";
            this.dgvSubCategoryDeletedID.MinimumWidth = 6;
            this.dgvSubCategoryDeletedID.Name = "dgvSubCategoryDeletedID";
            this.dgvSubCategoryDeletedID.ReadOnly = true;
            this.dgvSubCategoryDeletedID.Visible = false;
            // 
            // dgvSubCategoryDeletedName
            // 
            this.dgvSubCategoryDeletedName.DataPropertyName = "Name";
            this.dgvSubCategoryDeletedName.HeaderText = "اسم التصنيف";
            this.dgvSubCategoryDeletedName.MinimumWidth = 6;
            this.dgvSubCategoryDeletedName.Name = "dgvSubCategoryDeletedName";
            this.dgvSubCategoryDeletedName.ReadOnly = true;
            // 
            // dgvSubCategoryDeletedDescription
            // 
            this.dgvSubCategoryDeletedDescription.DataPropertyName = "Description";
            this.dgvSubCategoryDeletedDescription.HeaderText = "وصف التصنيف";
            this.dgvSubCategoryDeletedDescription.MinimumWidth = 6;
            this.dgvSubCategoryDeletedDescription.Name = "dgvSubCategoryDeletedDescription";
            this.dgvSubCategoryDeletedDescription.ReadOnly = true;
            // 
            // dgvSubCategoryDeletedManiCategoryID
            // 
            this.dgvSubCategoryDeletedManiCategoryID.DataPropertyName = "CategoryId";
            this.dgvSubCategoryDeletedManiCategoryID.HeaderText = "الرقم المرجعي التصنيف الرئيسي";
            this.dgvSubCategoryDeletedManiCategoryID.MinimumWidth = 6;
            this.dgvSubCategoryDeletedManiCategoryID.Name = "dgvSubCategoryDeletedManiCategoryID";
            this.dgvSubCategoryDeletedManiCategoryID.ReadOnly = true;
            this.dgvSubCategoryDeletedManiCategoryID.Visible = false;
            // 
            // dgvSubCategoryDeletedMainCategoryName
            // 
            this.dgvSubCategoryDeletedMainCategoryName.DataPropertyName = "CategoryName";
            this.dgvSubCategoryDeletedMainCategoryName.HeaderText = "اسم التصنيف الرئيسي";
            this.dgvSubCategoryDeletedMainCategoryName.MinimumWidth = 6;
            this.dgvSubCategoryDeletedMainCategoryName.Name = "dgvSubCategoryDeletedMainCategoryName";
            this.dgvSubCategoryDeletedMainCategoryName.ReadOnly = true;
            // 
            // ucLargeUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActiveMainCategory);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucLargeUnits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1550, 818);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ActiveMainCategory.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedMainCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMainCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDeleteByOne;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl ActiveMainCategory;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubcategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMainCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMainCategoryName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDeletedMainCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedManiCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedMainCategoryName;
    }
}
