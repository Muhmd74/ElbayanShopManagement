
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLargeUnitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LargeUnitWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTabContainer = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvActiveObjects = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDeletedObjects = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.dgvTabContainer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).BeginInit();
            this.SuspendLayout();
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
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1024, 75);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnAdd.Location = new System.Drawing.Point(7, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(192, 51);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "إضافة مورد جديد";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sakkal Majalla", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(822, 30);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(176, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "بحث باسم أو  رقم التليفون أو رقم المورد";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtSearch.Font = new System.Drawing.Font("Sakkal Majalla", 9F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(35, 35);
            this.txtSearch.Location = new System.Drawing.Point(513, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(291, 46);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvTabContainer);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1024, 693);
            this.guna2Panel2.TabIndex = 2;
            // 
            // dgvTabContainer
            // 
            this.dgvTabContainer.Controls.Add(this.tabPage3);
            this.dgvTabContainer.Controls.Add(this.tabPage4);
            this.dgvTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTabContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvTabContainer.ItemSize = new System.Drawing.Size(132, 45);
            this.dgvTabContainer.Location = new System.Drawing.Point(0, 0);
            this.dgvTabContainer.Name = "dgvTabContainer";
            this.dgvTabContainer.RightToLeftLayout = true;
            this.dgvTabContainer.SelectedIndex = 0;
            this.dgvTabContainer.Size = new System.Drawing.Size(1024, 693);
            this.dgvTabContainer.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.dgvActiveObjects);
            this.tabPage3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 49);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1016, 640);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "التصنيفات النشطة";
            // 
            // dgvActiveObjects
            // 
            this.dgvActiveObjects.AllowUserToAddRows = false;
            this.dgvActiveObjects.AllowUserToDeleteRows = false;
            this.dgvActiveObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveObjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActiveObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvActiveObjects.Name = "dgvActiveObjects";
            this.dgvActiveObjects.ReadOnly = true;
            this.dgvActiveObjects.RowHeadersWidth = 51;
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvActiveObjects.RowTemplate.Height = 35;
            this.dgvActiveObjects.Size = new System.Drawing.Size(1010, 634);
            this.dgvActiveObjects.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage4.Controls.Add(this.dgvDeletedObjects);
            this.tabPage4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 49);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1016, 640);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "التصنفيات المؤرشفة";
            // 
            // dgvDeletedObjects
            // 
            this.dgvDeletedObjects.AllowUserToAddRows = false;
            this.dgvDeletedObjects.AllowUserToDeleteRows = false;
            this.dgvDeletedObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedObjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeletedObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedObjects.Name = "dgvDeletedObjects";
            this.dgvDeletedObjects.ReadOnly = true;
            this.dgvDeletedObjects.RowHeadersWidth = 51;
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedObjects.RowTemplate.Height = 35;
            this.dgvDeletedObjects.Size = new System.Drawing.Size(1010, 634);
            this.dgvDeletedObjects.TabIndex = 1;
            // 
            // ucSupplierData
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucSupplierData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 768);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.dgvTabContainer.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLargeUnitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn LargeUnitWeight;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.TabControl dgvTabContainer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvActiveObjects;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDeletedObjects;
    }
}
