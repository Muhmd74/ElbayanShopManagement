
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSubCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbMainOperations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbxMainCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteByOne = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ActiveMainCategory = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvActiveObject = new System.Windows.Forms.DataGridView();
            this.dgvSubCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubcategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMainCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMainCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDeletedObject = new System.Windows.Forms.DataGridView();
            this.dgvSubCategoryDeletedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedManiCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedMainCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbMainOperations.SuspendLayout();
            this.ActiveMainCategory.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObject)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObject)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbMainOperations, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ActiveMainCategory, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.16667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.83333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbMainOperations
            // 
            this.gbMainOperations.BackColor = System.Drawing.Color.White;
            this.gbMainOperations.BorderRadius = 10;
            this.gbMainOperations.Controls.Add(this.cbxMainCategory);
            this.gbMainOperations.Controls.Add(this.label5);
            this.gbMainOperations.Controls.Add(this.txtName);
            this.gbMainOperations.Controls.Add(this.txtDescription);
            this.gbMainOperations.Controls.Add(this.btnAdd);
            this.gbMainOperations.Controls.Add(this.btnUpdate);
            this.gbMainOperations.Controls.Add(this.btnDeleteByOne);
            this.gbMainOperations.Controls.Add(this.label2);
            this.gbMainOperations.Controls.Add(this.label1);
            this.gbMainOperations.Controls.Add(this.txtSearch);
            this.gbMainOperations.Controls.Add(this.label9);
            this.gbMainOperations.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.gbMainOperations.CustomBorderThickness = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.gbMainOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMainOperations.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMainOperations.ForeColor = System.Drawing.Color.White;
            this.gbMainOperations.Location = new System.Drawing.Point(3, 3);
            this.gbMainOperations.Name = "gbMainOperations";
            this.gbMainOperations.ShadowDecoration.Parent = this.gbMainOperations;
            this.gbMainOperations.Size = new System.Drawing.Size(1018, 291);
            this.gbMainOperations.TabIndex = 10;
            this.gbMainOperations.Text = "التصنيفات الفرعية";
            this.gbMainOperations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxMainCategory
            // 
            this.cbxMainCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMainCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbxMainCategory.BorderColor = System.Drawing.Color.Gray;
            this.cbxMainCategory.BorderRadius = 9;
            this.cbxMainCategory.BorderThickness = 2;
            this.cbxMainCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMainCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbxMainCategory.FocusedState.Parent = this.cbxMainCategory;
            this.cbxMainCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMainCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxMainCategory.FormattingEnabled = true;
            this.cbxMainCategory.HoverState.Parent = this.cbxMainCategory;
            this.cbxMainCategory.ItemHeight = 39;
            this.cbxMainCategory.ItemsAppearance.Parent = this.cbxMainCategory;
            this.cbxMainCategory.Location = new System.Drawing.Point(53, 55);
            this.cbxMainCategory.Name = "cbxMainCategory";
            this.cbxMainCategory.ShadowDecoration.Parent = this.cbxMainCategory;
            this.cbxMainCategory.Size = new System.Drawing.Size(286, 45);
            this.cbxMainCategory.TabIndex = 33;
            this.cbxMainCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbxMainCategory.Click += new System.EventHandler(this.cbxMainCategory_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(362, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "إختر التصنيف الرئيسي";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.BorderRadius = 9;
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
            this.txtName.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(565, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(286, 39);
            this.txtName.TabIndex = 32;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.BorderRadius = 9;
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
            this.txtDescription.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(565, 113);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(286, 79);
            this.txtDescription.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 9;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(802, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(115, 39);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "إضافة جديدة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 9;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.btnUpdate.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(672, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(115, 39);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "حفظ التعديلات";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDeleteByOne
            // 
            this.btnDeleteByOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteByOne.BackColor = System.Drawing.Color.White;
            this.btnDeleteByOne.BorderRadius = 9;
            this.btnDeleteByOne.CheckedState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.CustomImages.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteByOne.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOne.ForeColor = System.Drawing.Color.White;
            this.btnDeleteByOne.HoverState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Location = new System.Drawing.Point(541, 201);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.ShadowDecoration.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Size = new System.Drawing.Size(115, 39);
            this.btnDeleteByOne.TabIndex = 30;
            this.btnDeleteByOne.Text = "أرشفة";
            this.btnDeleteByOne.Click += new System.EventHandler(this.btnDeleteByOne_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(860, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "وصف تعريفي";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(860, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "اسم التصنيف";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.BorderRadius = 9;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.PapayaWhip;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(35, 35);
            this.txtSearch.Location = new System.Drawing.Point(28, 201);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(286, 39);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(323, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "بحث باسم التصنيف";
            // 
            // ActiveMainCategory
            // 
            this.ActiveMainCategory.Controls.Add(this.tabPage3);
            this.ActiveMainCategory.Controls.Add(this.tabPage4);
            this.ActiveMainCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActiveMainCategory.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.ActiveMainCategory.ItemSize = new System.Drawing.Size(132, 39);
            this.ActiveMainCategory.Location = new System.Drawing.Point(3, 310);
            this.ActiveMainCategory.Name = "ActiveMainCategory";
            this.ActiveMainCategory.RightToLeftLayout = true;
            this.ActiveMainCategory.SelectedIndex = 0;
            this.ActiveMainCategory.Size = new System.Drawing.Size(1018, 287);
            this.ActiveMainCategory.TabIndex = 9;
            this.ActiveMainCategory.SelectedIndexChanged += new System.EventHandler(this.ActiveMainCategory_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.dgvActiveObject);
            this.tabPage3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1010, 240);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "التصنيفات النشطة";
            // 
            // dgvActiveObject
            // 
            this.dgvActiveObject.AllowUserToAddRows = false;
            this.dgvActiveObject.AllowUserToDeleteRows = false;
            this.dgvActiveObject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveObject.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveObject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActiveObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveObject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubCategoryID,
            this.dgvSubCategoryName,
            this.dgvSubcategoryDescription,
            this.dgvMainCategoryID,
            this.dgvMainCategoryName});
            this.dgvActiveObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveObject.Location = new System.Drawing.Point(3, 3);
            this.dgvActiveObject.Name = "dgvActiveObject";
            this.dgvActiveObject.ReadOnly = true;
            this.dgvActiveObject.RowHeadersWidth = 51;
            this.dgvActiveObject.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvActiveObject.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvActiveObject.RowTemplate.Height = 35;
            this.dgvActiveObject.Size = new System.Drawing.Size(1004, 234);
            this.dgvActiveObject.TabIndex = 0;
            this.dgvActiveObject.DoubleClick += new System.EventHandler(this.dgvActiveObject_DoubleClick);
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
            this.tabPage4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage4.Controls.Add(this.dgvDeletedObject);
            this.tabPage4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 43);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1010, 240);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "التصنفيات المؤرشفة";
            // 
            // dgvDeletedObject
            // 
            this.dgvDeletedObject.AllowUserToAddRows = false;
            this.dgvDeletedObject.AllowUserToDeleteRows = false;
            this.dgvDeletedObject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedObject.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedObject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeletedObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedObject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubCategoryDeletedID,
            this.dgvSubCategoryDeletedName,
            this.dgvSubCategoryDeletedDescription,
            this.dgvSubCategoryDeletedManiCategoryID,
            this.dgvSubCategoryDeletedMainCategoryName});
            this.dgvDeletedObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedObject.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedObject.Name = "dgvDeletedObject";
            this.dgvDeletedObject.ReadOnly = true;
            this.dgvDeletedObject.RowHeadersWidth = 51;
            this.dgvDeletedObject.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedObject.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedObject.RowTemplate.Height = 35;
            this.dgvDeletedObject.Size = new System.Drawing.Size(1004, 234);
            this.dgvDeletedObject.TabIndex = 1;
            this.dgvDeletedObject.DoubleClick += new System.EventHandler(this.dgvDeletedObject_DoubleClick);
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
            // DeletedDescription
            // 
            this.DeletedDescription.DataPropertyName = "Description";
            this.DeletedDescription.HeaderText = "وصف التصنيف";
            this.DeletedDescription.MinimumWidth = 6;
            this.DeletedDescription.Name = "DeletedDescription";
            this.DeletedDescription.ReadOnly = true;
            this.DeletedDescription.Width = 125;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "Id";
            this.CategoryID.HeaderText = "الرقم المرجعي";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            this.CategoryID.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "وصف التصنيف";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // ucSubCategory
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSubCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbMainOperations.ResumeLayout(false);
            this.gbMainOperations.PerformLayout();
            this.ActiveMainCategory.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObject)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbMainOperations;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMainCategory;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDeleteByOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl ActiveMainCategory;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvActiveObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubcategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMainCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMainCategoryName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDeletedObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedManiCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedMainCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
