
namespace ElbayaNPresentation.Views.Store.POSs
{
    partial class ucPOSs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPOSs));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTabContainer = new System.Windows.Forms.TabControl();
            this.tpActiveLargeUnits = new System.Windows.Forms.TabPage();
            this.dgvActiveObjects = new System.Windows.Forms.DataGridView();
            this.ActivePOSsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivePOSsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivePOSBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveBuilingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpArchieveLargeUnits = new System.Windows.Forms.TabPage();
            this.dgvDeletedObjects = new System.Windows.Forms.DataGridView();
            this.gbMainOperations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbxBuilding = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPionShortCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteByOne = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.dgvTabContainer.SuspendLayout();
            this.tpActiveLargeUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).BeginInit();
            this.tpArchieveLargeUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).BeginInit();
            this.gbMainOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTabContainer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbMainOperations, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTabContainer
            // 
            this.dgvTabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabContainer.Controls.Add(this.tpActiveLargeUnits);
            this.dgvTabContainer.Controls.Add(this.tpArchieveLargeUnits);
            this.dgvTabContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTabContainer.ItemSize = new System.Drawing.Size(132, 39);
            this.dgvTabContainer.Location = new System.Drawing.Point(3, 303);
            this.dgvTabContainer.Name = "dgvTabContainer";
            this.dgvTabContainer.Padding = new System.Drawing.Point(6, 5);
            this.dgvTabContainer.RightToLeftLayout = true;
            this.dgvTabContainer.SelectedIndex = 0;
            this.dgvTabContainer.Size = new System.Drawing.Size(1018, 294);
            this.dgvTabContainer.TabIndex = 17;
            // 
            // tpActiveLargeUnits
            // 
            this.tpActiveLargeUnits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpActiveLargeUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpActiveLargeUnits.Controls.Add(this.dgvActiveObjects);
            this.tpActiveLargeUnits.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpActiveLargeUnits.ForeColor = System.Drawing.Color.White;
            this.tpActiveLargeUnits.Location = new System.Drawing.Point(4, 43);
            this.tpActiveLargeUnits.Name = "tpActiveLargeUnits";
            this.tpActiveLargeUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tpActiveLargeUnits.Size = new System.Drawing.Size(1010, 247);
            this.tpActiveLargeUnits.TabIndex = 0;
            this.tpActiveLargeUnits.Text = " نقاط ومنافذ بيع نشطة";
            // 
            // dgvActiveObjects
            // 
            this.dgvActiveObjects.AllowUserToAddRows = false;
            this.dgvActiveObjects.AllowUserToDeleteRows = false;
            this.dgvActiveObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveObjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivePOSsId,
            this.ActivePOSsName,
            this.ActivePOSBuilding,
            this.ActiveBuilingId});
            this.dgvActiveObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvActiveObjects.Name = "dgvActiveObjects";
            this.dgvActiveObjects.ReadOnly = true;
            this.dgvActiveObjects.RowHeadersWidth = 51;
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvActiveObjects.RowTemplate.Height = 35;
            this.dgvActiveObjects.Size = new System.Drawing.Size(1004, 241);
            this.dgvActiveObjects.TabIndex = 0;
            this.dgvActiveObjects.DoubleClick += new System.EventHandler(this.dgvActiveObjects_DoubleClick);
            // 
            // ActivePOSsId
            // 
            this.ActivePOSsId.DataPropertyName = "Id";
            this.ActivePOSsId.HeaderText = "الرقم المرجعي";
            this.ActivePOSsId.MinimumWidth = 6;
            this.ActivePOSsId.Name = "ActivePOSsId";
            this.ActivePOSsId.ReadOnly = true;
            this.ActivePOSsId.Visible = false;
            // 
            // ActivePOSsName
            // 
            this.ActivePOSsName.DataPropertyName = "Name";
            this.ActivePOSsName.HeaderText = "اسم نقطة | منفذ بيع";
            this.ActivePOSsName.MinimumWidth = 6;
            this.ActivePOSsName.Name = "ActivePOSsName";
            this.ActivePOSsName.ReadOnly = true;
            // 
            // ActivePOSBuilding
            // 
            this.ActivePOSBuilding.DataPropertyName = "BuildingName";
            this.ActivePOSBuilding.HeaderText = "المبني التابع له نقطة البيع";
            this.ActivePOSBuilding.MinimumWidth = 6;
            this.ActivePOSBuilding.Name = "ActivePOSBuilding";
            this.ActivePOSBuilding.ReadOnly = true;
            // 
            // ActiveBuilingId
            // 
            this.ActiveBuilingId.DataPropertyName = "BuildingId";
            this.ActiveBuilingId.HeaderText = "الرقم المرجعي للمخزن التابع له نقطة البيع";
            this.ActiveBuilingId.MinimumWidth = 6;
            this.ActiveBuilingId.Name = "ActiveBuilingId";
            this.ActiveBuilingId.ReadOnly = true;
            this.ActiveBuilingId.Visible = false;
            // 
            // tpArchieveLargeUnits
            // 
            this.tpArchieveLargeUnits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpArchieveLargeUnits.Controls.Add(this.dgvDeletedObjects);
            this.tpArchieveLargeUnits.Location = new System.Drawing.Point(4, 43);
            this.tpArchieveLargeUnits.Name = "tpArchieveLargeUnits";
            this.tpArchieveLargeUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tpArchieveLargeUnits.Size = new System.Drawing.Size(1010, 247);
            this.tpArchieveLargeUnits.TabIndex = 1;
            this.tpArchieveLargeUnits.Text = " نقاط ومنافذ بيع مؤرشفة";
            // 
            // dgvDeletedObjects
            // 
            this.dgvDeletedObjects.AllowUserToAddRows = false;
            this.dgvDeletedObjects.AllowUserToDeleteRows = false;
            this.dgvDeletedObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedObjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeletedObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedObjects.Name = "dgvDeletedObjects";
            this.dgvDeletedObjects.ReadOnly = true;
            this.dgvDeletedObjects.RowHeadersWidth = 51;
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedObjects.RowTemplate.Height = 35;
            this.dgvDeletedObjects.Size = new System.Drawing.Size(1004, 241);
            this.dgvDeletedObjects.TabIndex = 1;
            // 
            // gbMainOperations
            // 
            this.gbMainOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMainOperations.BackColor = System.Drawing.Color.White;
            this.gbMainOperations.BorderRadius = 10;
            this.gbMainOperations.Controls.Add(this.cbxBuilding);
            this.gbMainOperations.Controls.Add(this.txtPionShortCode);
            this.gbMainOperations.Controls.Add(this.txtName);
            this.gbMainOperations.Controls.Add(this.btnAdd);
            this.gbMainOperations.Controls.Add(this.btnUpdate);
            this.gbMainOperations.Controls.Add(this.btnDeleteByOne);
            this.gbMainOperations.Controls.Add(this.label2);
            this.gbMainOperations.Controls.Add(this.label3);
            this.gbMainOperations.Controls.Add(this.label1);
            this.gbMainOperations.Controls.Add(this.txtSearch);
            this.gbMainOperations.Controls.Add(this.label9);
            this.gbMainOperations.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.gbMainOperations.CustomBorderThickness = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.gbMainOperations.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMainOperations.ForeColor = System.Drawing.Color.White;
            this.gbMainOperations.Location = new System.Drawing.Point(3, 6);
            this.gbMainOperations.Name = "gbMainOperations";
            this.gbMainOperations.ShadowDecoration.Parent = this.gbMainOperations;
            this.gbMainOperations.Size = new System.Drawing.Size(1018, 288);
            this.gbMainOperations.TabIndex = 16;
            this.gbMainOperations.Text = "نقاط ومنافذ البيع";
            this.gbMainOperations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxBuilding
            // 
            this.cbxBuilding.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbxBuilding.BackColor = System.Drawing.Color.Transparent;
            this.cbxBuilding.BorderColor = System.Drawing.Color.Gray;
            this.cbxBuilding.BorderRadius = 17;
            this.cbxBuilding.BorderThickness = 2;
            this.cbxBuilding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuilding.FocusedColor = System.Drawing.Color.Empty;
            this.cbxBuilding.FocusedState.Parent = this.cbxBuilding;
            this.cbxBuilding.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxBuilding.FormattingEnabled = true;
            this.cbxBuilding.HoverState.Parent = this.cbxBuilding;
            this.cbxBuilding.ItemHeight = 39;
            this.cbxBuilding.ItemsAppearance.Parent = this.cbxBuilding;
            this.cbxBuilding.Location = new System.Drawing.Point(162, 80);
            this.cbxBuilding.Name = "cbxBuilding";
            this.cbxBuilding.ShadowDecoration.Parent = this.cbxBuilding;
            this.cbxBuilding.Size = new System.Drawing.Size(290, 45);
            this.cbxBuilding.TabIndex = 28;
            this.cbxBuilding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbxBuilding.Click += new System.EventHandler(this.cbxBuilding_Click);
            // 
            // txtPionShortCode
            // 
            this.txtPionShortCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPionShortCode.BackColor = System.Drawing.Color.White;
            this.txtPionShortCode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPionShortCode.BorderRadius = 17;
            this.txtPionShortCode.BorderThickness = 2;
            this.txtPionShortCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPionShortCode.DefaultText = "";
            this.txtPionShortCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPionShortCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPionShortCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPionShortCode.DisabledState.Parent = this.txtPionShortCode;
            this.txtPionShortCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPionShortCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPionShortCode.FocusedState.Parent = this.txtPionShortCode;
            this.txtPionShortCode.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPionShortCode.ForeColor = System.Drawing.Color.Gray;
            this.txtPionShortCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPionShortCode.HoverState.Parent = this.txtPionShortCode;
            this.txtPionShortCode.Location = new System.Drawing.Point(625, 145);
            this.txtPionShortCode.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPionShortCode.Name = "txtPionShortCode";
            this.txtPionShortCode.PasswordChar = '\0';
            this.txtPionShortCode.PlaceholderText = "";
            this.txtPionShortCode.SelectedText = "";
            this.txtPionShortCode.ShadowDecoration.Parent = this.txtPionShortCode;
            this.txtPionShortCode.Size = new System.Drawing.Size(286, 39);
            this.txtPionShortCode.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.txtName.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(625, 86);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(286, 39);
            this.txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 17;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(817, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(115, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "إضافة جديدة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 17;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.btnUpdate.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(680, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(115, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "حفظ التعديلات";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteByOne
            // 
            this.btnDeleteByOne.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteByOne.BackColor = System.Drawing.Color.White;
            this.btnDeleteByOne.BorderRadius = 17;
            this.btnDeleteByOne.CheckedState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.CustomImages.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteByOne.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOne.ForeColor = System.Drawing.Color.White;
            this.btnDeleteByOne.HoverState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Location = new System.Drawing.Point(544, 212);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.ShadowDecoration.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Size = new System.Drawing.Size(115, 39);
            this.btnDeleteByOne.TabIndex = 7;
            this.btnDeleteByOne.Text = "أرشفة";
            this.btnDeleteByOne.Click += new System.EventHandler(this.btnDeleteByOne_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(920, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "الكود المختصر";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(470, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "المبنى التابع له نقطة البيع";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(934, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "اسم النقطة";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.txtSearch.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(35, 35);
            this.txtSearch.Location = new System.Drawing.Point(82, 212);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(286, 39);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(377, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "بحث باسم أو  رقم التليفون";
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "حالة الحذف";
            this.IsDeleted.MinimumWidth = 6;
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.ReadOnly = true;
            this.IsDeleted.Visible = false;
            this.IsDeleted.Width = 125;
            // 
            // ucPOSs
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucPOSs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.dgvTabContainer.ResumeLayout(false);
            this.tpActiveLargeUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).EndInit();
            this.tpArchieveLargeUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).EndInit();
            this.gbMainOperations.ResumeLayout(false);
            this.gbMainOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveShortCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl dgvTabContainer;
        private System.Windows.Forms.TabPage tpActiveLargeUnits;
        private System.Windows.Forms.DataGridView dgvActiveObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivePOSsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivePOSsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivePOSBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBuilingId;
        private System.Windows.Forms.TabPage tpArchieveLargeUnits;
        private System.Windows.Forms.DataGridView dgvDeletedObjects;
        private Guna.UI2.WinForms.Guna2GroupBox gbMainOperations;
        private Guna.UI2.WinForms.Guna2ComboBox cbxBuilding;
        private Guna.UI2.WinForms.Guna2TextBox txtPionShortCode;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDeleteByOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
    }
}
