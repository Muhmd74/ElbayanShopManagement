
namespace ElbayaNPresentation.Views.Purchases.Suppliers.SupplierData
{
    partial class ucSupplierData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSupplierData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvLargeUnitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LargeUnitWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabDeletedObjects = new System.Windows.Forms.TabPage();
            this.dgvDeletedObjects = new System.Windows.Forms.DataGridView();
            this.DeletedObjectPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedBuildingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabActiveObjects = new System.Windows.Forms.TabPage();
            this.dgvActiveObjects = new System.Windows.Forms.DataGridView();
            this.ActiveBuildingPhoneNUmber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveSupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveSupplierDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTabContainer = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabDeletedObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).BeginInit();
            this.tabActiveObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).BeginInit();
            this.dgvTabContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTabContainer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.84252F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.15748F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1550, 762);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 9;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAdd.Location = new System.Drawing.Point(15, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(192, 51);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "إضافة مورد جديد";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSearch
            // 
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
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.txtSearch.Location = new System.Drawing.Point(793, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(480, 53);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
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
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1282, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "بحث باسم أو  رقم التليفون أو رقم المورد";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.04539F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.95461F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1544, 69);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // tabDeletedObjects
            // 
            this.tabDeletedObjects.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabDeletedObjects.Controls.Add(this.dgvDeletedObjects);
            this.tabDeletedObjects.Location = new System.Drawing.Point(4, 63);
            this.tabDeletedObjects.Name = "tabDeletedObjects";
            this.tabDeletedObjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeletedObjects.Size = new System.Drawing.Size(1536, 318);
            this.tabDeletedObjects.TabIndex = 1;
            this.tabDeletedObjects.Text = "قائمة الموردون المؤرشفة";
            // 
            // dgvDeletedObjects
            // 
            this.dgvDeletedObjects.AllowUserToAddRows = false;
            this.dgvDeletedObjects.AllowUserToDeleteRows = false;
            this.dgvDeletedObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dgvDeletedObjects.Size = new System.Drawing.Size(1530, 312);
            this.dgvDeletedObjects.TabIndex = 1;
            // 
            // DeletedObjectPhoneNumber
            // 
            this.DeletedObjectPhoneNumber.DataPropertyName = "PhoneNumber";
            this.DeletedObjectPhoneNumber.HeaderText = "رقم الهاتف للمخزن";
            this.DeletedObjectPhoneNumber.MinimumWidth = 6;
            this.DeletedObjectPhoneNumber.Name = "DeletedObjectPhoneNumber";
            this.DeletedObjectPhoneNumber.ReadOnly = true;
            this.DeletedObjectPhoneNumber.Width = 180;
            // 
            // DeletedObjectAddress
            // 
            this.DeletedObjectAddress.DataPropertyName = "Address";
            this.DeletedObjectAddress.HeaderText = "عنوان المكان أو المخزن";
            this.DeletedObjectAddress.MinimumWidth = 6;
            this.DeletedObjectAddress.Name = "DeletedObjectAddress";
            this.DeletedObjectAddress.ReadOnly = true;
            this.DeletedObjectAddress.Width = 199;
            // 
            // DeletedObjectDescription
            // 
            this.DeletedObjectDescription.DataPropertyName = "Description";
            this.DeletedObjectDescription.HeaderText = "وصف المكان أو المخزن";
            this.DeletedObjectDescription.MinimumWidth = 6;
            this.DeletedObjectDescription.Name = "DeletedObjectDescription";
            this.DeletedObjectDescription.ReadOnly = true;
            this.DeletedObjectDescription.Width = 197;
            // 
            // DeletedObjectName
            // 
            this.DeletedObjectName.DataPropertyName = "Name";
            this.DeletedObjectName.HeaderText = "اسم المخزن أو الفرع";
            this.DeletedObjectName.MinimumWidth = 6;
            this.DeletedObjectName.Name = "DeletedObjectName";
            this.DeletedObjectName.ReadOnly = true;
            this.DeletedObjectName.Width = 183;
            // 
            // DeletedBuildingId
            // 
            this.DeletedBuildingId.DataPropertyName = "Id";
            this.DeletedBuildingId.HeaderText = "الرقم المرجعي";
            this.DeletedBuildingId.MinimumWidth = 6;
            this.DeletedBuildingId.Name = "DeletedBuildingId";
            this.DeletedBuildingId.ReadOnly = true;
            this.DeletedBuildingId.Visible = false;
            this.DeletedBuildingId.Width = 125;
            // 
            // tabActiveObjects
            // 
            this.tabActiveObjects.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabActiveObjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabActiveObjects.Controls.Add(this.dgvActiveObjects);
            this.tabActiveObjects.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabActiveObjects.ForeColor = System.Drawing.Color.White;
            this.tabActiveObjects.Location = new System.Drawing.Point(4, 63);
            this.tabActiveObjects.Name = "tabActiveObjects";
            this.tabActiveObjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabActiveObjects.Size = new System.Drawing.Size(1536, 614);
            this.tabActiveObjects.TabIndex = 0;
            this.tabActiveObjects.Text = "قائمة الموردون النشطة";
            // 
            // dgvActiveObjects
            // 
            this.dgvActiveObjects.AllowUserToAddRows = false;
            this.dgvActiveObjects.AllowUserToDeleteRows = false;
            this.dgvActiveObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.ActiveSupplierId,
            this.ActiveSupplierName,
            this.ActiveSupplierDescription,
            this.ActiveSupplierAddress,
            this.ActiveBuildingPhoneNUmber});
            this.dgvActiveObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvActiveObjects.Name = "dgvActiveObjects";
            this.dgvActiveObjects.ReadOnly = true;
            this.dgvActiveObjects.RowHeadersWidth = 51;
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvActiveObjects.RowTemplate.Height = 35;
            this.dgvActiveObjects.Size = new System.Drawing.Size(1530, 608);
            this.dgvActiveObjects.TabIndex = 0;
            // 
            // ActiveBuildingPhoneNUmber
            // 
            this.ActiveBuildingPhoneNUmber.DataPropertyName = "Mobile";
            this.ActiveBuildingPhoneNUmber.HeaderText = "رقم الهاتف ";
            this.ActiveBuildingPhoneNUmber.MinimumWidth = 6;
            this.ActiveBuildingPhoneNUmber.Name = "ActiveBuildingPhoneNUmber";
            this.ActiveBuildingPhoneNUmber.ReadOnly = true;
            this.ActiveBuildingPhoneNUmber.Width = 126;
            // 
            // ActiveSupplierAddress
            // 
            this.ActiveSupplierAddress.DataPropertyName = "Address";
            this.ActiveSupplierAddress.HeaderText = "عنوان الشركة";
            this.ActiveSupplierAddress.MinimumWidth = 6;
            this.ActiveSupplierAddress.Name = "ActiveSupplierAddress";
            this.ActiveSupplierAddress.ReadOnly = true;
            this.ActiveSupplierAddress.Width = 145;
            // 
            // ActiveSupplierDescription
            // 
            this.ActiveSupplierDescription.DataPropertyName = "Description";
            this.ActiveSupplierDescription.HeaderText = "وصف المورد";
            this.ActiveSupplierDescription.MinimumWidth = 6;
            this.ActiveSupplierDescription.Name = "ActiveSupplierDescription";
            this.ActiveSupplierDescription.ReadOnly = true;
            this.ActiveSupplierDescription.Width = 128;
            // 
            // ActiveSupplierName
            // 
            this.ActiveSupplierName.DataPropertyName = "Name";
            this.ActiveSupplierName.HeaderText = "اسم المورد";
            this.ActiveSupplierName.MinimumWidth = 6;
            this.ActiveSupplierName.Name = "ActiveSupplierName";
            this.ActiveSupplierName.ReadOnly = true;
            this.ActiveSupplierName.Width = 115;
            // 
            // ActiveSupplierId
            // 
            this.ActiveSupplierId.DataPropertyName = "Id";
            this.ActiveSupplierId.HeaderText = "الرقم المرجعي";
            this.ActiveSupplierId.MinimumWidth = 6;
            this.ActiveSupplierId.Name = "ActiveSupplierId";
            this.ActiveSupplierId.ReadOnly = true;
            this.ActiveSupplierId.Visible = false;
            this.ActiveSupplierId.Width = 125;
            // 
            // dgvTabContainer
            // 
            this.dgvTabContainer.Controls.Add(this.tabActiveObjects);
            this.dgvTabContainer.Controls.Add(this.tabDeletedObjects);
            this.dgvTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTabContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTabContainer.ItemSize = new System.Drawing.Size(132, 59);
            this.dgvTabContainer.Location = new System.Drawing.Point(3, 78);
            this.dgvTabContainer.Name = "dgvTabContainer";
            this.dgvTabContainer.Padding = new System.Drawing.Point(6, 5);
            this.dgvTabContainer.RightToLeftLayout = true;
            this.dgvTabContainer.SelectedIndex = 0;
            this.dgvTabContainer.Size = new System.Drawing.Size(1544, 681);
            this.dgvTabContainer.TabIndex = 29;
            // 
            // ucSupplierData
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSupplierData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1550, 762);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabDeletedObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).EndInit();
            this.tabActiveObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).EndInit();
            this.dgvTabContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.TabControl dgvTabContainer;
        private System.Windows.Forms.TabPage tabActiveObjects;
        private System.Windows.Forms.DataGridView dgvActiveObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSupplierDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBuildingPhoneNUmber;
        private System.Windows.Forms.TabPage tabDeletedObjects;
        private System.Windows.Forms.DataGridView dgvDeletedObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedBuildingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn LargeUnitWeight;
    }
}
