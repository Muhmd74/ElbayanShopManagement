
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSupplierData));
            this.LargeUnitWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedBuildingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeletedObjects = new System.Windows.Forms.DataGridView();
            this.tabDeletedObjects = new System.Windows.Forms.TabPage();
            this.dgvTabContainer = new System.Windows.Forms.TabControl();
            this.tabActiveObjects = new System.Windows.Forms.TabPage();
            this.dgvActiveObjects = new System.Windows.Forms.DataGridView();
            this.ActiveSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveSupplierDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveSupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveBuildingPhoneNUmber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).BeginInit();
            this.tabDeletedObjects.SuspendLayout();
            this.dgvTabContainer.SuspendLayout();
            this.tabActiveObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).BeginInit();
            this.SuspendLayout();
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
            // dgvDeletedObjects
            // 
            this.dgvDeletedObjects.AllowUserToAddRows = false;
            this.dgvDeletedObjects.AllowUserToDeleteRows = false;
            this.dgvDeletedObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDeletedObjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvDeletedObjects.Size = new System.Drawing.Size(1536, 272);
            this.dgvDeletedObjects.TabIndex = 1;
            // 
            // tabDeletedObjects
            // 
            this.tabDeletedObjects.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabDeletedObjects.Controls.Add(this.dgvDeletedObjects);
            this.tabDeletedObjects.Location = new System.Drawing.Point(4, 63);
            this.tabDeletedObjects.Name = "tabDeletedObjects";
            this.tabDeletedObjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeletedObjects.Size = new System.Drawing.Size(1542, 278);
            this.tabDeletedObjects.TabIndex = 1;
            this.tabDeletedObjects.Text = "قائمة الموردون المؤرشفة";
            // 
            // dgvTabContainer
            // 
            this.dgvTabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabContainer.Controls.Add(this.tabActiveObjects);
            this.dgvTabContainer.Controls.Add(this.tabDeletedObjects);
            this.dgvTabContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTabContainer.ItemSize = new System.Drawing.Size(132, 59);
            this.dgvTabContainer.Location = new System.Drawing.Point(0, 85);
            this.dgvTabContainer.Name = "dgvTabContainer";
            this.dgvTabContainer.Padding = new System.Drawing.Point(6, 5);
            this.dgvTabContainer.RightToLeftLayout = true;
            this.dgvTabContainer.SelectedIndex = 0;
            this.dgvTabContainer.Size = new System.Drawing.Size(1550, 677);
            this.dgvTabContainer.TabIndex = 11;
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
            this.tabActiveObjects.Size = new System.Drawing.Size(1542, 610);
            this.tabActiveObjects.TabIndex = 0;
            this.tabActiveObjects.Text = "قائمة الموردون النشطة";
            // 
            // dgvActiveObjects
            // 
            this.dgvActiveObjects.AllowUserToAddRows = false;
            this.dgvActiveObjects.AllowUserToDeleteRows = false;
            this.dgvActiveObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActiveObjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvActiveObjects.Size = new System.Drawing.Size(1536, 604);
            this.dgvActiveObjects.TabIndex = 0;
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
            // ActiveSupplierName
            // 
            this.ActiveSupplierName.DataPropertyName = "Name";
            this.ActiveSupplierName.HeaderText = "اسم المورد";
            this.ActiveSupplierName.MinimumWidth = 6;
            this.ActiveSupplierName.Name = "ActiveSupplierName";
            this.ActiveSupplierName.ReadOnly = true;
            this.ActiveSupplierName.Width = 115;
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
            // ActiveSupplierAddress
            // 
            this.ActiveSupplierAddress.DataPropertyName = "Address";
            this.ActiveSupplierAddress.HeaderText = "عنوان الشركة";
            this.ActiveSupplierAddress.MinimumWidth = 6;
            this.ActiveSupplierAddress.Name = "ActiveSupplierAddress";
            this.ActiveSupplierAddress.ReadOnly = true;
            this.ActiveSupplierAddress.Width = 145;
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
            this.txtSearch.Location = new System.Drawing.Point(880, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(480, 51);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1379, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "بحث باسم أو  رقم التليفون";
            // 
            // ucSupplierData
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvTabContainer);
            this.Name = "ucSupplierData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1550, 762);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).EndInit();
            this.tabDeletedObjects.ResumeLayout(false);
            this.dgvTabContainer.ResumeLayout(false);
            this.tabActiveObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn LargeUnitWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedBuildingId;
        private System.Windows.Forms.DataGridView dgvDeletedObjects;
        private System.Windows.Forms.TabPage tabDeletedObjects;
        private System.Windows.Forms.TabControl dgvTabContainer;
        private System.Windows.Forms.TabPage tabActiveObjects;
        private System.Windows.Forms.DataGridView dgvActiveObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSupplierDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBuildingPhoneNUmber;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
    }
}
