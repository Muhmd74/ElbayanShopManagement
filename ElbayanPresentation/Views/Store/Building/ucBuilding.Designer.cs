
namespace ElbayaNPresentation.Views.Store.Building
{
    partial class ucBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBuilding));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTabContainer = new System.Windows.Forms.TabControl();
            this.tpActiveLargeUnits = new System.Windows.Forms.TabPage();
            this.dgvActiveObjects = new System.Windows.Forms.DataGridView();
            this.ActiveBuildingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveBuilingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveBuildingDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveBuildingAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveBuildingPhoneNUmber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpArchieveLargeUnits = new System.Windows.Forms.TabPage();
            this.dgvDeletedObjects = new System.Windows.Forms.DataGridView();
            this.DeletedBuildingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMainOperations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteByOne = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LargeUnitWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTabContainer
            // 
            this.dgvTabContainer.Controls.Add(this.tpActiveLargeUnits);
            this.dgvTabContainer.Controls.Add(this.tpArchieveLargeUnits);
            this.dgvTabContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTabContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTabContainer.ItemSize = new System.Drawing.Size(132, 39);
            this.dgvTabContainer.Location = new System.Drawing.Point(3, 286);
            this.dgvTabContainer.Name = "dgvTabContainer";
            this.dgvTabContainer.Padding = new System.Drawing.Point(6, 5);
            this.dgvTabContainer.RightToLeftLayout = true;
            this.dgvTabContainer.SelectedIndex = 0;
            this.dgvTabContainer.Size = new System.Drawing.Size(1018, 311);
            this.dgvTabContainer.TabIndex = 11;
            this.dgvTabContainer.SelectedIndexChanged += new System.EventHandler(this.dgvTabContainer_SelectedIndexChanged);
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
            this.tpActiveLargeUnits.Size = new System.Drawing.Size(1010, 264);
            this.tpActiveLargeUnits.TabIndex = 0;
            this.tpActiveLargeUnits.Text = "المخازن والفروع النشطة";
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
            this.ActiveBuildingId,
            this.ActiveBuilingName,
            this.ActiveBuildingDescription,
            this.ActiveBuildingAddress,
            this.ActiveBuildingPhoneNUmber});
            this.dgvActiveObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvActiveObjects.Name = "dgvActiveObjects";
            this.dgvActiveObjects.ReadOnly = true;
            this.dgvActiveObjects.RowHeadersWidth = 51;
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvActiveObjects.RowTemplate.Height = 35;
            this.dgvActiveObjects.Size = new System.Drawing.Size(1004, 258);
            this.dgvActiveObjects.TabIndex = 0;
            this.dgvActiveObjects.DoubleClick += new System.EventHandler(this.dgvActiveObjects_DoubleClick);
            // 
            // ActiveBuildingId
            // 
            this.ActiveBuildingId.DataPropertyName = "Id";
            this.ActiveBuildingId.HeaderText = "الرقم المرجعي";
            this.ActiveBuildingId.MinimumWidth = 6;
            this.ActiveBuildingId.Name = "ActiveBuildingId";
            this.ActiveBuildingId.ReadOnly = true;
            this.ActiveBuildingId.Visible = false;
            // 
            // ActiveBuilingName
            // 
            this.ActiveBuilingName.DataPropertyName = "Name";
            this.ActiveBuilingName.HeaderText = "اسم المخزن أو الفرع";
            this.ActiveBuilingName.MinimumWidth = 6;
            this.ActiveBuilingName.Name = "ActiveBuilingName";
            this.ActiveBuilingName.ReadOnly = true;
            // 
            // ActiveBuildingDescription
            // 
            this.ActiveBuildingDescription.DataPropertyName = "Description";
            this.ActiveBuildingDescription.HeaderText = "وصف المكان";
            this.ActiveBuildingDescription.MinimumWidth = 6;
            this.ActiveBuildingDescription.Name = "ActiveBuildingDescription";
            this.ActiveBuildingDescription.ReadOnly = true;
            // 
            // ActiveBuildingAddress
            // 
            this.ActiveBuildingAddress.DataPropertyName = "Address";
            this.ActiveBuildingAddress.HeaderText = "عنوان المخزن أو الفرع";
            this.ActiveBuildingAddress.MinimumWidth = 6;
            this.ActiveBuildingAddress.Name = "ActiveBuildingAddress";
            this.ActiveBuildingAddress.ReadOnly = true;
            // 
            // ActiveBuildingPhoneNUmber
            // 
            this.ActiveBuildingPhoneNUmber.DataPropertyName = "PhoneNumber";
            this.ActiveBuildingPhoneNUmber.HeaderText = "رقم الهاتف للمخزن أو الفرع";
            this.ActiveBuildingPhoneNUmber.MinimumWidth = 6;
            this.ActiveBuildingPhoneNUmber.Name = "ActiveBuildingPhoneNUmber";
            this.ActiveBuildingPhoneNUmber.ReadOnly = true;
            // 
            // tpArchieveLargeUnits
            // 
            this.tpArchieveLargeUnits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpArchieveLargeUnits.Controls.Add(this.dgvDeletedObjects);
            this.tpArchieveLargeUnits.Location = new System.Drawing.Point(4, 43);
            this.tpArchieveLargeUnits.Name = "tpArchieveLargeUnits";
            this.tpArchieveLargeUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tpArchieveLargeUnits.Size = new System.Drawing.Size(1010, 264);
            this.tpArchieveLargeUnits.TabIndex = 1;
            this.tpArchieveLargeUnits.Text = "المخازن والفروع المؤرشفة";
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
            this.dgvDeletedObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeletedBuildingId,
            this.DeletedObjectName,
            this.DeletedObjectDescription,
            this.DeletedObjectAddress,
            this.DeletedObjectPhoneNumber});
            this.dgvDeletedObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedObjects.Name = "dgvDeletedObjects";
            this.dgvDeletedObjects.ReadOnly = true;
            this.dgvDeletedObjects.RowHeadersWidth = 51;
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedObjects.RowTemplate.Height = 35;
            this.dgvDeletedObjects.Size = new System.Drawing.Size(1004, 258);
            this.dgvDeletedObjects.TabIndex = 1;
            this.dgvDeletedObjects.DoubleClick += new System.EventHandler(this.dgvDeletedObjects_DoubleClick);
            // 
            // DeletedBuildingId
            // 
            this.DeletedBuildingId.DataPropertyName = "Id";
            this.DeletedBuildingId.HeaderText = "الرقم المرجعي";
            this.DeletedBuildingId.MinimumWidth = 6;
            this.DeletedBuildingId.Name = "DeletedBuildingId";
            this.DeletedBuildingId.ReadOnly = true;
            this.DeletedBuildingId.Visible = false;
            // 
            // DeletedObjectName
            // 
            this.DeletedObjectName.DataPropertyName = "Name";
            this.DeletedObjectName.HeaderText = "اسم المخزن أو الفرع";
            this.DeletedObjectName.MinimumWidth = 6;
            this.DeletedObjectName.Name = "DeletedObjectName";
            this.DeletedObjectName.ReadOnly = true;
            // 
            // DeletedObjectDescription
            // 
            this.DeletedObjectDescription.DataPropertyName = "Description";
            this.DeletedObjectDescription.HeaderText = "وصف المكان أو المخزن";
            this.DeletedObjectDescription.MinimumWidth = 6;
            this.DeletedObjectDescription.Name = "DeletedObjectDescription";
            this.DeletedObjectDescription.ReadOnly = true;
            // 
            // DeletedObjectAddress
            // 
            this.DeletedObjectAddress.DataPropertyName = "Address";
            this.DeletedObjectAddress.HeaderText = "عنوان المكان أو المخزن";
            this.DeletedObjectAddress.MinimumWidth = 6;
            this.DeletedObjectAddress.Name = "DeletedObjectAddress";
            this.DeletedObjectAddress.ReadOnly = true;
            // 
            // DeletedObjectPhoneNumber
            // 
            this.DeletedObjectPhoneNumber.DataPropertyName = "PhoneNumber";
            this.DeletedObjectPhoneNumber.HeaderText = "رقم الهاتف للمخزن";
            this.DeletedObjectPhoneNumber.MinimumWidth = 6;
            this.DeletedObjectPhoneNumber.Name = "DeletedObjectPhoneNumber";
            this.DeletedObjectPhoneNumber.ReadOnly = true;
            // 
            // gbMainOperations
            // 
            this.gbMainOperations.BackColor = System.Drawing.Color.White;
            this.gbMainOperations.BorderRadius = 10;
            this.gbMainOperations.Controls.Add(this.txtPhoneNumber);
            this.gbMainOperations.Controls.Add(this.txtAddress);
            this.gbMainOperations.Controls.Add(this.txtName);
            this.gbMainOperations.Controls.Add(this.txtDescription);
            this.gbMainOperations.Controls.Add(this.btnAdd);
            this.gbMainOperations.Controls.Add(this.label5);
            this.gbMainOperations.Controls.Add(this.btnUpdate);
            this.gbMainOperations.Controls.Add(this.btnDeleteByOne);
            this.gbMainOperations.Controls.Add(this.label3);
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
            this.gbMainOperations.Size = new System.Drawing.Size(1018, 276);
            this.gbMainOperations.TabIndex = 12;
            this.gbMainOperations.Text = "المخازن والفروع";
            this.gbMainOperations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPhoneNumber.BorderRadius = 9;
            this.txtPhoneNumber.BorderThickness = 2;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.FocusedState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.HoverState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Location = new System.Drawing.Point(143, 130);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.ShadowDecoration.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Size = new System.Drawing.Size(286, 39);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress.BorderRadius = 9;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(141, 67);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(286, 39);
            this.txtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.txtName.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(600, 67);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(286, 39);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.txtDescription.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(600, 122);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(286, 59);
            this.txtDescription.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 9;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(875, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(115, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "إضافة جديدة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(451, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "رقم التليفون";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 9;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.btnUpdate.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(721, 208);
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
            this.btnDeleteByOne.BorderRadius = 9;
            this.btnDeleteByOne.CheckedState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.CustomImages.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteByOne.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOne.ForeColor = System.Drawing.Color.White;
            this.btnDeleteByOne.HoverState.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Location = new System.Drawing.Point(563, 208);
            this.btnDeleteByOne.Name = "btnDeleteByOne";
            this.btnDeleteByOne.ShadowDecoration.Parent = this.btnDeleteByOne;
            this.btnDeleteByOne.Size = new System.Drawing.Size(115, 39);
            this.btnDeleteByOne.TabIndex = 7;
            this.btnDeleteByOne.Text = "أرشفة";
            this.btnDeleteByOne.Click += new System.EventHandler(this.btnDeleteByOne_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(437, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "عنوان المبني أو المخزن";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(922, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "وصف تعريفي";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(895, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "اسم المخزن أو الفرع";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.txtSearch.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(35, 35);
            this.txtSearch.Location = new System.Drawing.Point(118, 208);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(272, 39);
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
            this.label9.Location = new System.Drawing.Point(410, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "بحث باسم أو  رقم التليفون";
            // 
            // LargeUnitWeight
            // 
            this.LargeUnitWeight.DataPropertyName = "Weight";
            this.LargeUnitWeight.HeaderText = "وزن الوحدة الرئيسية";
            this.LargeUnitWeight.MinimumWidth = 6;
            this.LargeUnitWeight.Name = "LargeUnitWeight";
            this.LargeUnitWeight.ReadOnly = true;
            this.LargeUnitWeight.Visible = false;
            this.LargeUnitWeight.Width = 125;
            // 
            // dgvLargeUnitDescription
            // 
            this.dgvLargeUnitDescription.DataPropertyName = "Description";
            this.dgvLargeUnitDescription.HeaderText = "وصف الوحدة";
            this.dgvLargeUnitDescription.MaxInputLength = 1000;
            this.dgvLargeUnitDescription.MinimumWidth = 6;
            this.dgvLargeUnitDescription.Name = "dgvLargeUnitDescription";
            this.dgvLargeUnitDescription.ReadOnly = true;
            this.dgvLargeUnitDescription.Width = 125;
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
            // ucBuilding
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ucBuilding";
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

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl dgvTabContainer;
        private System.Windows.Forms.TabPage tpActiveLargeUnits;
        private System.Windows.Forms.DataGridView dgvActiveObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBuildingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBuilingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBuildingDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBuildingAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBuildingPhoneNUmber;
        private System.Windows.Forms.TabPage tpArchieveLargeUnits;
        private System.Windows.Forms.DataGridView dgvDeletedObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedBuildingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectPhoneNumber;
        private Guna.UI2.WinForms.Guna2GroupBox gbMainOperations;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDeleteByOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn LargeUnitWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
    }
}
