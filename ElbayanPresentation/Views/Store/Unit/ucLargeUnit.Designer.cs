
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLargeUnits));
            this.dgvTabContainer = new System.Windows.Forms.TabControl();
            this.tpActiveLargeUnits = new System.Windows.Forms.TabPage();
            this.dgvLargeUnit = new System.Windows.Forms.DataGridView();
            this.dgvLargeUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LargeUnitWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpArchieveLargeUnits = new System.Windows.Forms.TabPage();
            this.dgvDeletedLargeUnit = new System.Windows.Forms.DataGridView();
            this.dgvLargeUnitDeletedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDeletedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LargeUnitWeightDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvTabContainer.SuspendLayout();
            this.tpActiveLargeUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLargeUnit)).BeginInit();
            this.tpArchieveLargeUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedLargeUnit)).BeginInit();
            this.gbMainOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabContainer
            // 
            this.dgvTabContainer.Controls.Add(this.tpActiveLargeUnits);
            this.dgvTabContainer.Controls.Add(this.tpArchieveLargeUnits);
            this.dgvTabContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTabContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTabContainer.ItemSize = new System.Drawing.Size(132, 59);
            this.dgvTabContainer.Location = new System.Drawing.Point(0, 356);
            this.dgvTabContainer.Name = "dgvTabContainer";
            this.dgvTabContainer.Padding = new System.Drawing.Point(6, 5);
            this.dgvTabContainer.RightToLeftLayout = true;
            this.dgvTabContainer.SelectedIndex = 0;
            this.dgvTabContainer.Size = new System.Drawing.Size(1550, 406);
            this.dgvTabContainer.TabIndex = 7;
            this.dgvTabContainer.SelectedIndexChanged += new System.EventHandler(this.dgvTabContainer_SelectedIndexChanged);
            // 
            // tpActiveLargeUnits
            // 
            this.tpActiveLargeUnits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpActiveLargeUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpActiveLargeUnits.Controls.Add(this.dgvLargeUnit);
            this.tpActiveLargeUnits.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpActiveLargeUnits.ForeColor = System.Drawing.Color.White;
            this.tpActiveLargeUnits.Location = new System.Drawing.Point(4, 63);
            this.tpActiveLargeUnits.Name = "tpActiveLargeUnits";
            this.tpActiveLargeUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tpActiveLargeUnits.Size = new System.Drawing.Size(1542, 339);
            this.tpActiveLargeUnits.TabIndex = 0;
            this.tpActiveLargeUnits.Text = "الوحدات النشطة";
            // 
            // dgvLargeUnit
            // 
            this.dgvLargeUnit.AllowUserToAddRows = false;
            this.dgvLargeUnit.AllowUserToDeleteRows = false;
            this.dgvLargeUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLargeUnit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLargeUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLargeUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLargeUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLargeUnitID,
            this.dgvLargeUnitName,
            this.dgvLargeUnitDescription,
            this.IsDeleted,
            this.LargeUnitWeight});
            this.dgvLargeUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLargeUnit.Location = new System.Drawing.Point(3, 3);
            this.dgvLargeUnit.Name = "dgvLargeUnit";
            this.dgvLargeUnit.ReadOnly = true;
            this.dgvLargeUnit.RowHeadersWidth = 51;
            this.dgvLargeUnit.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvLargeUnit.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvLargeUnit.RowTemplate.Height = 35;
            this.dgvLargeUnit.Size = new System.Drawing.Size(1536, 333);
            this.dgvLargeUnit.TabIndex = 0;
            this.dgvLargeUnit.DoubleClick += new System.EventHandler(this.dgvLargeUnit_DoubleClick);
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
            // LargeUnitWeight
            // 
            this.LargeUnitWeight.DataPropertyName = "Weight";
            this.LargeUnitWeight.HeaderText = "وزن الوحدة الرئيسية";
            this.LargeUnitWeight.MinimumWidth = 6;
            this.LargeUnitWeight.Name = "LargeUnitWeight";
            this.LargeUnitWeight.ReadOnly = true;
            this.LargeUnitWeight.Visible = false;
            // 
            // tpArchieveLargeUnits
            // 
            this.tpArchieveLargeUnits.BackColor = System.Drawing.Color.White;
            this.tpArchieveLargeUnits.Controls.Add(this.dgvDeletedLargeUnit);
            this.tpArchieveLargeUnits.Location = new System.Drawing.Point(4, 63);
            this.tpArchieveLargeUnits.Name = "tpArchieveLargeUnits";
            this.tpArchieveLargeUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tpArchieveLargeUnits.Size = new System.Drawing.Size(1542, 339);
            this.tpArchieveLargeUnits.TabIndex = 1;
            this.tpArchieveLargeUnits.Text = "الوحدات المؤرشفة";
            // 
            // dgvDeletedLargeUnit
            // 
            this.dgvDeletedLargeUnit.AllowUserToAddRows = false;
            this.dgvDeletedLargeUnit.AllowUserToDeleteRows = false;
            this.dgvDeletedLargeUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedLargeUnit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedLargeUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeletedLargeUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedLargeUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLargeUnitDeletedID,
            this.dgvLargeUnitDeletedName,
            this.dgvLargeUnitDeletedDescription,
            this.LargeUnitWeightDeleted});
            this.dgvDeletedLargeUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedLargeUnit.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedLargeUnit.Name = "dgvDeletedLargeUnit";
            this.dgvDeletedLargeUnit.ReadOnly = true;
            this.dgvDeletedLargeUnit.RowHeadersWidth = 51;
            this.dgvDeletedLargeUnit.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedLargeUnit.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedLargeUnit.RowTemplate.Height = 35;
            this.dgvDeletedLargeUnit.Size = new System.Drawing.Size(1536, 333);
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
            // LargeUnitWeightDeleted
            // 
            this.LargeUnitWeightDeleted.DataPropertyName = "Weight";
            this.LargeUnitWeightDeleted.HeaderText = "وزن الوحدة";
            this.LargeUnitWeightDeleted.MinimumWidth = 6;
            this.LargeUnitWeightDeleted.Name = "LargeUnitWeightDeleted";
            this.LargeUnitWeightDeleted.ReadOnly = true;
            this.LargeUnitWeightDeleted.Visible = false;
            // 
            // gbMainOperations
            // 
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
            this.gbMainOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMainOperations.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMainOperations.ForeColor = System.Drawing.Color.White;
            this.gbMainOperations.Location = new System.Drawing.Point(0, 0);
            this.gbMainOperations.Name = "gbMainOperations";
            this.gbMainOperations.ShadowDecoration.Parent = this.gbMainOperations;
            this.gbMainOperations.Size = new System.Drawing.Size(1550, 350);
            this.gbMainOperations.TabIndex = 8;
            this.gbMainOperations.Text = "الوحدات الكبري";
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
            this.txtName.Location = new System.Drawing.Point(832, 81);
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
            this.txtDescription.Location = new System.Drawing.Point(832, 151);
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
            this.btnAdd.Location = new System.Drawing.Point(1189, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(190, 62);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "إضافة جديدة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(955, 269);
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
            this.btnDeleteByOne.Location = new System.Drawing.Point(711, 269);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.ShadowDecoration.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Size = new System.Drawing.Size(190, 62);
            this.btnDeleteByOne.TabIndex = 30;
            this.btnDeleteByOne.Text = "أرشفة";
            this.btnDeleteByOne.Click += new System.EventHandler(this.btnDeleteByOne_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(1393, 200);
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
            this.label1.Location = new System.Drawing.Point(1392, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "اسم الوحدة";
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
            this.txtSearch.Location = new System.Drawing.Point(44, 266);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(412, 63);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(465, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "بحث باسم أو وصف الوحدة";
            // 
            // ucLargeUnits
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.gbMainOperations);
            this.Controls.Add(this.dgvTabContainer);
            this.Name = "ucLargeUnits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1550, 762);
            this.dgvTabContainer.ResumeLayout(false);
            this.tpActiveLargeUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLargeUnit)).EndInit();
            this.tpArchieveLargeUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedLargeUnit)).EndInit();
            this.gbMainOperations.ResumeLayout(false);
            this.gbMainOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dgvTabContainer;
        private System.Windows.Forms.TabPage tpActiveLargeUnits;
        private System.Windows.Forms.DataGridView dgvLargeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn LargeUnitWeight;
        private System.Windows.Forms.TabPage tpArchieveLargeUnits;
        private System.Windows.Forms.DataGridView dgvDeletedLargeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDeletedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDeletedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDeletedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn LargeUnitWeightDeleted;
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
    }
}
