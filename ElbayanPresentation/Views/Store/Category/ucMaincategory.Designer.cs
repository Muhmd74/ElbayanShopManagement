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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gbMainOperations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteByOne = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ActiveMainCategory = new System.Windows.Forms.TabControl();
            this.tpActiveMainCategory = new System.Windows.Forms.TabPage();
            this.dgvMainCategory = new System.Windows.Forms.DataGridView();
            this.MainCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDeletedMainCategory = new System.Windows.Forms.TabPage();
            this.dgvDeletedMainCategory = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.gbMainOperations.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.ActiveMainCategory.SuspendLayout();
            this.tpActiveMainCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCategory)).BeginInit();
            this.tpDeletedMainCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedMainCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gbMainOperations);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1535, 354);
            this.panelControl1.TabIndex = 1;
            // 
            // gbMainOperations
            // 
            this.gbMainOperations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMainOperations.BackColor = System.Drawing.Color.White;
            this.gbMainOperations.BorderRadius = 10;
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
            this.gbMainOperations.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMainOperations.ForeColor = System.Drawing.Color.White;
            this.gbMainOperations.Location = new System.Drawing.Point(1, 3);
            this.gbMainOperations.Name = "gbMainOperations";
            this.gbMainOperations.ShadowDecoration.Parent = this.gbMainOperations;
            this.gbMainOperations.Size = new System.Drawing.Size(1531, 350);
            this.gbMainOperations.TabIndex = 7;
            this.gbMainOperations.Text = "التصنيفات الرئيسية";
            this.gbMainOperations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.White;
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
            this.txtName.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(813, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(542, 60);
            this.txtName.TabIndex = 32;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
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
            this.txtDescription.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(813, 151);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(542, 111);
            this.txtDescription.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 17;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(1170, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(190, 62);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "إضافة جديدة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 17;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.btnUpdate.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(936, 269);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(190, 62);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "حفظ التعديلات";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteByOne
            // 
            this.btnDeleteByOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteByOne.BackColor = System.Drawing.Color.White;
            this.btnDeleteByOne.BorderRadius = 17;
            this.btnDeleteByOne.CheckedState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.CustomImages.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteByOne.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOne.ForeColor = System.Drawing.Color.White;
            this.btnDeleteByOne.HoverState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Location = new System.Drawing.Point(692, 269);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.ShadowDecoration.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Size = new System.Drawing.Size(190, 62);
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
            this.label2.Location = new System.Drawing.Point(1374, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "وصف تعريفي";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(1373, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "اسم التصنيف";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.BorderRadius = 11;
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
            this.txtSearch.Location = new System.Drawing.Point(25, 266);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(412, 63);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(446, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "بحث باسم أو وصف التصنيف";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ActiveMainCategory);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 360);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1535, 437);
            this.guna2Panel1.TabIndex = 2;
            // 
            // ActiveMainCategory
            // 
            this.ActiveMainCategory.Controls.Add(this.tpActiveMainCategory);
            this.ActiveMainCategory.Controls.Add(this.tpDeletedMainCategory);
            this.ActiveMainCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActiveMainCategory.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveMainCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ActiveMainCategory.ItemSize = new System.Drawing.Size(132, 59);
            this.ActiveMainCategory.Location = new System.Drawing.Point(0, 3);
            this.ActiveMainCategory.Name = "ActiveMainCategory";
            this.ActiveMainCategory.RightToLeftLayout = true;
            this.ActiveMainCategory.SelectedIndex = 0;
            this.ActiveMainCategory.Size = new System.Drawing.Size(1535, 434);
            this.ActiveMainCategory.TabIndex = 4;
            this.ActiveMainCategory.SelectedIndexChanged += new System.EventHandler(this.ActiveMainCategory_SelectedIndexChanged);
            // 
            // tpActiveMainCategory
            // 
            this.tpActiveMainCategory.BackColor = System.Drawing.Color.White;
            this.tpActiveMainCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpActiveMainCategory.Controls.Add(this.dgvMainCategory);
            this.tpActiveMainCategory.ForeColor = System.Drawing.Color.White;
            this.tpActiveMainCategory.Location = new System.Drawing.Point(4, 63);
            this.tpActiveMainCategory.Name = "tpActiveMainCategory";
            this.tpActiveMainCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpActiveMainCategory.Size = new System.Drawing.Size(1527, 367);
            this.tpActiveMainCategory.TabIndex = 0;
            this.tpActiveMainCategory.Text = "التصنيفات النشطة";
            // 
            // dgvMainCategory
            // 
            this.dgvMainCategory.AllowUserToAddRows = false;
            this.dgvMainCategory.AllowUserToDeleteRows = false;
            this.dgvMainCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMainCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvMainCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMainCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMainCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMainCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MainCategoryID,
            this.AutoNumber,
            this.CategoryName,
            this.Description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMainCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMainCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMainCategory.Location = new System.Drawing.Point(3, 6);
            this.dgvMainCategory.Name = "dgvMainCategory";
            this.dgvMainCategory.ReadOnly = true;
            this.dgvMainCategory.RowHeadersWidth = 59;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.dgvMainCategory.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMainCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMainCategory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.dgvMainCategory.RowTemplate.Height = 35;
            this.dgvMainCategory.Size = new System.Drawing.Size(1521, 358);
            this.dgvMainCategory.TabIndex = 0;
            this.dgvMainCategory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMainCategory_RowPostPaint);
            this.dgvMainCategory.DoubleClick += new System.EventHandler(this.dgvMainCategory_DoubleClick_1);
            // 
            // MainCategoryID
            // 
            this.MainCategoryID.DataPropertyName = "Id";
            this.MainCategoryID.HeaderText = "الرقم المرجعي";
            this.MainCategoryID.MinimumWidth = 6;
            this.MainCategoryID.Name = "MainCategoryID";
            this.MainCategoryID.ReadOnly = true;
            this.MainCategoryID.Visible = false;
            // 
            // AutoNumber
            // 
            this.AutoNumber.FillWeight = 29F;
            this.AutoNumber.HeaderText = "الرقم المسلسل";
            this.AutoNumber.MaxInputLength = 5;
            this.AutoNumber.MinimumWidth = 6;
            this.AutoNumber.Name = "AutoNumber";
            this.AutoNumber.ReadOnly = true;
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
            this.Description.FillWeight = 129.9465F;
            this.Description.HeaderText = "وصف التصنيف";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // tpDeletedMainCategory
            // 
            this.tpDeletedMainCategory.Controls.Add(this.dgvDeletedMainCategory);
            this.tpDeletedMainCategory.Location = new System.Drawing.Point(4, 63);
            this.tpDeletedMainCategory.Name = "tpDeletedMainCategory";
            this.tpDeletedMainCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeletedMainCategory.Size = new System.Drawing.Size(1527, 367);
            this.tpDeletedMainCategory.TabIndex = 1;
            this.tpDeletedMainCategory.Text = "التصنفيات المؤرشفة";
            this.tpDeletedMainCategory.UseVisualStyleBackColor = true;
            // 
            // dgvDeletedMainCategory
            // 
            this.dgvDeletedMainCategory.AllowUserToAddRows = false;
            this.dgvDeletedMainCategory.AllowUserToDeleteRows = false;
            this.dgvDeletedMainCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedMainCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedMainCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeletedMainCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedMainCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.SerialNumber,
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
            this.dgvDeletedMainCategory.Size = new System.Drawing.Size(1521, 361);
            this.dgvDeletedMainCategory.TabIndex = 1;
            this.dgvDeletedMainCategory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDeletedMainCategory_RowPostPaint);
            this.dgvDeletedMainCategory.DoubleClick += new System.EventHandler(this.dgvDeletedMainCategory_DoubleClick_1);
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "Id";
            this.CategoryID.HeaderText = "الرقم المرجعي";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // SerialNumber
            // 
            this.SerialNumber.FillWeight = 29F;
            this.SerialNumber.HeaderText = "الرقم المسلسل";
            this.SerialNumber.MinimumWidth = 6;
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
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
            // ucMaincategory
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucMaincategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1535, 797);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.gbMainOperations.ResumeLayout(false);
            this.gbMainOperations.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ActiveMainCategory.ResumeLayout(false);
            this.tpActiveMainCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCategory)).EndInit();
            this.tpDeletedMainCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedMainCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Guna.UI2.WinForms.Guna2GroupBox gbMainOperations;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDeleteByOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TabControl ActiveMainCategory;
        private System.Windows.Forms.TabPage tpActiveMainCategory;
        public System.Windows.Forms.DataGridView dgvMainCategory;
        private System.Windows.Forms.TabPage tpDeletedMainCategory;
        private System.Windows.Forms.DataGridView dgvDeletedMainCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedDescription;
    }
}
