
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLargeUnits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gbMainOperations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteByOne = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTabContainer = new System.Windows.Forms.TabControl();
            this.tpActiveLargeUnits = new System.Windows.Forms.TabPage();
            this.dgvLargeUnit = new System.Windows.Forms.DataGridView();
            this.dgvLargeUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpArchieveLargeUnits = new System.Windows.Forms.TabPage();
            this.dgvDeletedLargeUnit = new System.Windows.Forms.DataGridView();
            this.dgvLargeUnitDeletedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDeletedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.gbMainOperations.SuspendLayout();
            this.dgvTabContainer.SuspendLayout();
            this.tpActiveLargeUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLargeUnit)).BeginInit();
            this.tpArchieveLargeUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedLargeUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gbMainOperations);
            this.panelControl1.Controls.Add(this.dgvTabContainer);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1550, 952);
            this.panelControl1.TabIndex = 0;
            // 
            // gbMainOperations
            // 
            this.gbMainOperations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMainOperations.BorderRadius = 29;
            this.gbMainOperations.Controls.Add(this.txtSearch);
            this.gbMainOperations.Controls.Add(this.txtName);
            this.gbMainOperations.Controls.Add(this.txtDescription);
            this.gbMainOperations.Controls.Add(this.btnAdd);
            this.gbMainOperations.Controls.Add(this.btnUpdate);
            this.gbMainOperations.Controls.Add(this.btnDeleteByOne);
            this.gbMainOperations.Controls.Add(this.label9);
            this.gbMainOperations.Controls.Add(this.label2);
            this.gbMainOperations.Controls.Add(this.label1);
            this.gbMainOperations.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.gbMainOperations.CustomBorderThickness = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.gbMainOperations.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMainOperations.ForeColor = System.Drawing.Color.White;
            this.gbMainOperations.Location = new System.Drawing.Point(0, 0);
            this.gbMainOperations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMainOperations.Name = "gbMainOperations";
            this.gbMainOperations.ShadowDecoration.Parent = this.gbMainOperations;
            this.gbMainOperations.Size = new System.Drawing.Size(1550, 356);
            this.gbMainOperations.TabIndex = 7;
            this.gbMainOperations.Text = "وحدات المنتجات الكبرى";
            this.gbMainOperations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightSize = new System.Drawing.Size(45, 45);
            this.txtSearch.Location = new System.Drawing.Point(48, 280);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(412, 65);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextOffset = new System.Drawing.Point(15, 0);
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
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(849, 83);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(542, 56);
            this.txtName.TabIndex = 17;
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
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(849, 159);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(542, 115);
            this.txtDescription.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderRadius = 11;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(1040, 280);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(160, 52);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "إضافة جديدة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BorderRadius = 17;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.btnUpdate.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(1231, 280);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(160, 52);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "حفظ التعديلات";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteByOne
            // 
            this.btnDeleteByOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteByOne.BorderRadius = 17;
            this.btnDeleteByOne.CheckedState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.CustomImages.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteByOne.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOne.ForeColor = System.Drawing.Color.White;
            this.btnDeleteByOne.HoverState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Location = new System.Drawing.Point(849, 280);
            this.btnDeleteByOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.ShadowDecoration.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Size = new System.Drawing.Size(160, 52);
            this.btnDeleteByOne.TabIndex = 21;
            this.btnDeleteByOne.Text = "أرشفة";
            this.btnDeleteByOne.Click += new System.EventHandler(this.btnDeleteByOne_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(469, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "بحث باسم أو وصف الوحدة";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(1410, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "وصف تعريفي";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(1409, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "اسم الوحدة ";
            // 
            // dgvTabContainer
            // 
            this.dgvTabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabContainer.Controls.Add(this.tpActiveLargeUnits);
            this.dgvTabContainer.Controls.Add(this.tpArchieveLargeUnits);
            this.dgvTabContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTabContainer.ItemSize = new System.Drawing.Size(132, 59);
            this.dgvTabContainer.Location = new System.Drawing.Point(0, 459);
            this.dgvTabContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTabContainer.Name = "dgvTabContainer";
            this.dgvTabContainer.Padding = new System.Drawing.Point(6, 5);
            this.dgvTabContainer.RightToLeftLayout = true;
            this.dgvTabContainer.SelectedIndex = 0;
            this.dgvTabContainer.Size = new System.Drawing.Size(1550, 491);
            this.dgvTabContainer.TabIndex = 6;
            this.dgvTabContainer.SelectedIndexChanged += new System.EventHandler(this.dgvTabContainer_SelectedIndexChanged_1);
            // 
            // tpActiveLargeUnits
            // 
            this.tpActiveLargeUnits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpActiveLargeUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpActiveLargeUnits.Controls.Add(this.dgvLargeUnit);
            this.tpActiveLargeUnits.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpActiveLargeUnits.ForeColor = System.Drawing.Color.White;
            this.tpActiveLargeUnits.Location = new System.Drawing.Point(4, 63);
            this.tpActiveLargeUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpActiveLargeUnits.Name = "tpActiveLargeUnits";
            this.tpActiveLargeUnits.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpActiveLargeUnits.Size = new System.Drawing.Size(1542, 424);
            this.tpActiveLargeUnits.TabIndex = 0;
            this.tpActiveLargeUnits.Text = "الوحدات النشطة";
            // 
            // dgvLargeUnit
            // 
            this.dgvLargeUnit.AllowUserToAddRows = false;
            this.dgvLargeUnit.AllowUserToDeleteRows = false;
            this.dgvLargeUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLargeUnit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLargeUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLargeUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLargeUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLargeUnitID,
            this.dgvLargeUnitName,
            this.dgvLargeUnitDescription,
            this.IsDeleted});
            this.dgvLargeUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLargeUnit.Location = new System.Drawing.Point(3, 4);
            this.dgvLargeUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLargeUnit.Name = "dgvLargeUnit";
            this.dgvLargeUnit.ReadOnly = true;
            this.dgvLargeUnit.RowHeadersWidth = 51;
            this.dgvLargeUnit.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvLargeUnit.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvLargeUnit.RowTemplate.Height = 35;
            this.dgvLargeUnit.Size = new System.Drawing.Size(1536, 416);
            this.dgvLargeUnit.TabIndex = 0;
            this.dgvLargeUnit.DoubleClick += new System.EventHandler(this.dgvLargeUnit_DoubleClick_1);
            // 
            // dgvLargeUnitID
            // 
            this.dgvLargeUnitID.DataPropertyName = "Id";
            this.dgvLargeUnitID.HeaderText = "رقم الوحدة المرجعي";
            this.dgvLargeUnitID.MaxInputLength = 50;
            this.dgvLargeUnitID.MinimumWidth = 6;
            this.dgvLargeUnitID.Name = "dgvLargeUnitID";
            this.dgvLargeUnitID.ReadOnly = true;
            this.dgvLargeUnitID.Visible = false;
            // 
            // dgvLargeUnitName
            // 
            this.dgvLargeUnitName.DataPropertyName = "Name";
            this.dgvLargeUnitName.HeaderText = "اسم الوحدة";
            this.dgvLargeUnitName.MaxInputLength = 250;
            this.dgvLargeUnitName.MinimumWidth = 6;
            this.dgvLargeUnitName.Name = "dgvLargeUnitName";
            this.dgvLargeUnitName.ReadOnly = true;
            // 
            // dgvLargeUnitDescription
            // 
            this.dgvLargeUnitDescription.DataPropertyName = "Description";
            this.dgvLargeUnitDescription.HeaderText = "وصف الوحدة";
            this.dgvLargeUnitDescription.MaxInputLength = 1000;
            this.dgvLargeUnitDescription.MinimumWidth = 6;
            this.dgvLargeUnitDescription.Name = "dgvLargeUnitDescription";
            this.dgvLargeUnitDescription.ReadOnly = true;
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "حالة الحذف";
            this.IsDeleted.MinimumWidth = 6;
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.ReadOnly = true;
            this.IsDeleted.Visible = false;
            // 
            // tpArchieveLargeUnits
            // 
            this.tpArchieveLargeUnits.Controls.Add(this.dgvDeletedLargeUnit);
            this.tpArchieveLargeUnits.Location = new System.Drawing.Point(4, 63);
            this.tpArchieveLargeUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpArchieveLargeUnits.Name = "tpArchieveLargeUnits";
            this.tpArchieveLargeUnits.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpArchieveLargeUnits.Size = new System.Drawing.Size(1542, 424);
            this.tpArchieveLargeUnits.TabIndex = 1;
            this.tpArchieveLargeUnits.Text = "الوحدات المؤرشفة";
            this.tpArchieveLargeUnits.UseVisualStyleBackColor = true;
            // 
            // dgvDeletedLargeUnit
            // 
            this.dgvDeletedLargeUnit.AllowUserToAddRows = false;
            this.dgvDeletedLargeUnit.AllowUserToDeleteRows = false;
            this.dgvDeletedLargeUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedLargeUnit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedLargeUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeletedLargeUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedLargeUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLargeUnitDeletedID,
            this.dgvLargeUnitDeletedName,
            this.dgvLargeUnitDeletedDescription});
            this.dgvDeletedLargeUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedLargeUnit.Location = new System.Drawing.Point(3, 4);
            this.dgvDeletedLargeUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDeletedLargeUnit.Name = "dgvDeletedLargeUnit";
            this.dgvDeletedLargeUnit.ReadOnly = true;
            this.dgvDeletedLargeUnit.RowHeadersWidth = 51;
            this.dgvDeletedLargeUnit.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedLargeUnit.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedLargeUnit.RowTemplate.Height = 35;
            this.dgvDeletedLargeUnit.Size = new System.Drawing.Size(1536, 416);
            this.dgvDeletedLargeUnit.TabIndex = 1;
            this.dgvDeletedLargeUnit.DoubleClick += new System.EventHandler(this.dgvDeletedLargeUnit_DoubleClick);
            // 
            // dgvLargeUnitDeletedID
            // 
            this.dgvLargeUnitDeletedID.DataPropertyName = "Id";
            this.dgvLargeUnitDeletedID.HeaderText = "الرقم المرجعي";
            this.dgvLargeUnitDeletedID.MinimumWidth = 6;
            this.dgvLargeUnitDeletedID.Name = "dgvLargeUnitDeletedID";
            this.dgvLargeUnitDeletedID.ReadOnly = true;
            this.dgvLargeUnitDeletedID.Visible = false;
            // 
            // dgvLargeUnitDeletedName
            // 
            this.dgvLargeUnitDeletedName.DataPropertyName = "Name";
            this.dgvLargeUnitDeletedName.HeaderText = "اسم الوحدة";
            this.dgvLargeUnitDeletedName.MinimumWidth = 6;
            this.dgvLargeUnitDeletedName.Name = "dgvLargeUnitDeletedName";
            this.dgvLargeUnitDeletedName.ReadOnly = true;
            // 
            // dgvLargeUnitDeletedDescription
            // 
            this.dgvLargeUnitDeletedDescription.DataPropertyName = "Description";
            this.dgvLargeUnitDeletedDescription.HeaderText = "وصف الوحدة";
            this.dgvLargeUnitDeletedDescription.MinimumWidth = 6;
            this.dgvLargeUnitDeletedDescription.Name = "dgvLargeUnitDeletedDescription";
            this.dgvLargeUnitDeletedDescription.ReadOnly = true;
            // 
            // ucLargeUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucLargeUnits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1550, 952);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.gbMainOperations.ResumeLayout(false);
            this.gbMainOperations.PerformLayout();
            this.dgvTabContainer.ResumeLayout(false);
            this.tpActiveLargeUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLargeUnit)).EndInit();
            this.tpArchieveLargeUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedLargeUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Guna.UI2.WinForms.Guna2GroupBox gbMainOperations;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDeleteByOne;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl dgvTabContainer;
        private System.Windows.Forms.TabPage tpActiveLargeUnits;
        private System.Windows.Forms.DataGridView dgvLargeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.TabPage tpArchieveLargeUnits;
        private System.Windows.Forms.DataGridView dgvDeletedLargeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDeletedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDeletedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDeletedDescription;
    }
}
