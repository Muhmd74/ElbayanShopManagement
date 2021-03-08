
namespace ElbayaNPresentation.Views.Client.Suppliers
{
    partial class ucAllSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAllSupplier));
            this.pActions = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabDGVContainer = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvActiveObjects = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDeletedObjects = new System.Windows.Forms.DataGridView();
            this.dgvSubCategoryDeletedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedManiCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoryDeletedMainCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabDGVContainer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // pActions
            // 
            this.pActions.Controls.Add(this.txtSearch);
            this.pActions.Controls.Add(this.label9);
            this.pActions.Controls.Add(this.btnAdd);
            this.pActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pActions.Location = new System.Drawing.Point(0, 0);
            this.pActions.Name = "pActions";
            this.pActions.Size = new System.Drawing.Size(1298, 73);
            this.pActions.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 11;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.ImageSize = new System.Drawing.Size(31, 31);
            this.btnAdd.Location = new System.Drawing.Point(19, 8);
            this.btnAdd.MinimumSize = new System.Drawing.Size(151, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(192, 53);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "إضافة جديدة";
            this.btnAdd.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabDGVContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 541);
            this.panel1.TabIndex = 1;
            // 
            // tabDGVContainer
            // 
            this.tabDGVContainer.Controls.Add(this.tabPage3);
            this.tabDGVContainer.Controls.Add(this.tabPage4);
            this.tabDGVContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDGVContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabDGVContainer.ItemSize = new System.Drawing.Size(132, 59);
            this.tabDGVContainer.Location = new System.Drawing.Point(0, 0);
            this.tabDGVContainer.Name = "tabDGVContainer";
            this.tabDGVContainer.RightToLeftLayout = true;
            this.tabDGVContainer.SelectedIndex = 0;
            this.tabDGVContainer.Size = new System.Drawing.Size(1298, 525);
            this.tabDGVContainer.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.dgvActiveObjects);
            this.tabPage3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 63);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1290, 458);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "الموردون النشطون";
            // 
            // dgvActiveObjects
            // 
            this.dgvActiveObjects.AllowUserToAddRows = false;
            this.dgvActiveObjects.AllowUserToDeleteRows = false;
            this.dgvActiveObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveObjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActiveObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvActiveObjects.Name = "dgvActiveObjects";
            this.dgvActiveObjects.ReadOnly = true;
            this.dgvActiveObjects.RowHeadersWidth = 51;
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvActiveObjects.RowTemplate.Height = 35;
            this.dgvActiveObjects.Size = new System.Drawing.Size(1284, 452);
            this.dgvActiveObjects.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage4.Controls.Add(this.dgvDeletedObjects);
            this.tabPage4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 63);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1290, 458);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "الموردون غير النشطوين";
            // 
            // dgvDeletedObjects
            // 
            this.dgvDeletedObjects.AllowUserToAddRows = false;
            this.dgvDeletedObjects.AllowUserToDeleteRows = false;
            this.dgvDeletedObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedObjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDeletedObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubCategoryDeletedID,
            this.dgvSubCategoryDeletedName,
            this.dgvSubCategoryDeletedDescription,
            this.dgvSubCategoryDeletedManiCategoryID,
            this.dgvSubCategoryDeletedMainCategoryName});
            this.dgvDeletedObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedObjects.Location = new System.Drawing.Point(3, 3);
            this.dgvDeletedObjects.Name = "dgvDeletedObjects";
            this.dgvDeletedObjects.ReadOnly = true;
            this.dgvDeletedObjects.RowHeadersWidth = 51;
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedObjects.RowTemplate.Height = 35;
            this.dgvDeletedObjects.Size = new System.Drawing.Size(1284, 452);
            this.dgvDeletedObjects.TabIndex = 1;
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
            this.txtSearch.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(35, 35);
            this.txtSearch.Location = new System.Drawing.Point(756, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(340, 55);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sakkal Majalla", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1103, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "بحث باسم أو رقم مورد أو جوال";
            // 
            // ucAllSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pActions);
            this.Name = "ucAllSupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1298, 613);
            this.pActions.ResumeLayout(false);
            this.pActions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabDGVContainer.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pActions;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabDGVContainer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvActiveObjects;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDeletedObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedManiCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoryDeletedMainCategoryName;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
    }
}
