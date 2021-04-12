
namespace ElbayaNPresentation.Views.Client.Customers
{
    partial class ucAllCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAllCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pActions = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.tabDGVContainer = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvActiveObjects = new System.Windows.Forms.DataGridView();
            this.ActiveObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectNationalIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectFirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectCommercialREgistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectRefNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectTaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectFaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectIsSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveObjectIsCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDeletedObjects = new System.Windows.Forms.DataGridView();
            this.NotActiveObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.pActions.SuspendLayout();
            this.tabDGVContainer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pActions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabDGVContainer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.16667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.83334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pActions
            // 
            this.pActions.Controls.Add(this.txtSearch);
            this.pActions.Controls.Add(this.label9);
            this.pActions.Controls.Add(this.btnAdd);
            this.pActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pActions.Location = new System.Drawing.Point(2, 2);
            this.pActions.Margin = new System.Windows.Forms.Padding(2);
            this.pActions.Name = "pActions";
            this.pActions.Size = new System.Drawing.Size(1020, 48);
            this.pActions.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.BorderRadius = 5;
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
            this.txtSearch.Location = new System.Drawing.Point(540, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(284, 31);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.Font = new System.Drawing.Font("Sakkal Majalla", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(860, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 26);
            this.label9.TabIndex = 25;
            this.label9.Text = "بحث باسم أو رقم مورد أو جوال";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.ImageSize = new System.Drawing.Size(31, 31);
            this.btnAdd.Location = new System.Drawing.Point(10, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(123, 31);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "إضافة جديدة";
            this.btnAdd.TextOffset = new System.Drawing.Point(-15, 0);
            // 
            // tabDGVContainer
            // 
            this.tabDGVContainer.Controls.Add(this.tabPage3);
            this.tabDGVContainer.Controls.Add(this.tabPage4);
            this.tabDGVContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabDGVContainer.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabDGVContainer.ItemSize = new System.Drawing.Size(132, 39);
            this.tabDGVContainer.Location = new System.Drawing.Point(2, 54);
            this.tabDGVContainer.Margin = new System.Windows.Forms.Padding(2);
            this.tabDGVContainer.MinimumSize = new System.Drawing.Size(375, 214);
            this.tabDGVContainer.Name = "tabDGVContainer";
            this.tabDGVContainer.RightToLeftLayout = true;
            this.tabDGVContainer.SelectedIndex = 0;
            this.tabDGVContainer.Size = new System.Drawing.Size(1020, 458);
            this.tabDGVContainer.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.dgvActiveObjects);
            this.tabPage3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1012, 411);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "العملاء النشطون";
            // 
            // dgvActiveObjects
            // 
            this.dgvActiveObjects.AllowUserToAddRows = false;
            this.dgvActiveObjects.AllowUserToDeleteRows = false;
            this.dgvActiveObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActiveObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveObjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvActiveObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActiveObjectId,
            this.ActiveObjectName,
            this.ActiveObjectNationalIdentity,
            this.ActiveObjectIsActive,
            this.ActiveObjectFirmName,
            this.ActiveObjectAddress,
            this.ActiveObjectCommercialREgistration,
            this.ActiveObjectMobile,
            this.ActiveObjectEmail,
            this.ActiveObjectRefNumber,
            this.ActiveObjectTaxNumber,
            this.ActiveObjectDescription,
            this.ActiveObjectOpeningBalance,
            this.ActiveObjectFaxNumber,
            this.ActiveObjectPhoneNumber,
            this.ActiveObjectIsSupplier,
            this.ActiveObjectIsCustomer});
            this.dgvActiveObjects.Location = new System.Drawing.Point(2, 2);
            this.dgvActiveObjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvActiveObjects.Name = "dgvActiveObjects";
            this.dgvActiveObjects.ReadOnly = true;
            this.dgvActiveObjects.RowHeadersWidth = 51;
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvActiveObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvActiveObjects.RowTemplate.Height = 35;
            this.dgvActiveObjects.Size = new System.Drawing.Size(1010, 405);
            this.dgvActiveObjects.TabIndex = 0;
            // 
            // ActiveObjectId
            // 
            this.ActiveObjectId.DataPropertyName = "Id";
            this.ActiveObjectId.HeaderText = "الرقم المرجعي";
            this.ActiveObjectId.MinimumWidth = 8;
            this.ActiveObjectId.Name = "ActiveObjectId";
            this.ActiveObjectId.ReadOnly = true;
            this.ActiveObjectId.Visible = false;
            // 
            // ActiveObjectName
            // 
            this.ActiveObjectName.DataPropertyName = "Name";
            this.ActiveObjectName.HeaderText = "اسم العميل";
            this.ActiveObjectName.MinimumWidth = 8;
            this.ActiveObjectName.Name = "ActiveObjectName";
            this.ActiveObjectName.ReadOnly = true;
            // 
            // ActiveObjectNationalIdentity
            // 
            this.ActiveObjectNationalIdentity.DataPropertyName = "NationalIdentity";
            this.ActiveObjectNationalIdentity.HeaderText = "رقم الهوية";
            this.ActiveObjectNationalIdentity.MinimumWidth = 8;
            this.ActiveObjectNationalIdentity.Name = "ActiveObjectNationalIdentity";
            this.ActiveObjectNationalIdentity.ReadOnly = true;
            this.ActiveObjectNationalIdentity.Visible = false;
            // 
            // ActiveObjectIsActive
            // 
            this.ActiveObjectIsActive.DataPropertyName = "IsActive";
            this.ActiveObjectIsActive.HeaderText = "حالة المورد";
            this.ActiveObjectIsActive.MinimumWidth = 8;
            this.ActiveObjectIsActive.Name = "ActiveObjectIsActive";
            this.ActiveObjectIsActive.ReadOnly = true;
            this.ActiveObjectIsActive.Visible = false;
            // 
            // ActiveObjectFirmName
            // 
            this.ActiveObjectFirmName.DataPropertyName = "FirmName";
            this.ActiveObjectFirmName.HeaderText = "اسم الشركة";
            this.ActiveObjectFirmName.MinimumWidth = 8;
            this.ActiveObjectFirmName.Name = "ActiveObjectFirmName";
            this.ActiveObjectFirmName.ReadOnly = true;
            this.ActiveObjectFirmName.Visible = false;
            // 
            // ActiveObjectAddress
            // 
            this.ActiveObjectAddress.DataPropertyName = "Address";
            this.ActiveObjectAddress.HeaderText = "عنوان المورد";
            this.ActiveObjectAddress.MinimumWidth = 8;
            this.ActiveObjectAddress.Name = "ActiveObjectAddress";
            this.ActiveObjectAddress.ReadOnly = true;
            this.ActiveObjectAddress.Visible = false;
            // 
            // ActiveObjectCommercialREgistration
            // 
            this.ActiveObjectCommercialREgistration.DataPropertyName = "CommercialRegister";
            this.ActiveObjectCommercialREgistration.HeaderText = "الترخيص التجاري";
            this.ActiveObjectCommercialREgistration.MinimumWidth = 8;
            this.ActiveObjectCommercialREgistration.Name = "ActiveObjectCommercialREgistration";
            this.ActiveObjectCommercialREgistration.ReadOnly = true;
            this.ActiveObjectCommercialREgistration.Visible = false;
            // 
            // ActiveObjectMobile
            // 
            this.ActiveObjectMobile.DataPropertyName = "Mobile";
            this.ActiveObjectMobile.HeaderText = "رقم الجوال";
            this.ActiveObjectMobile.MinimumWidth = 8;
            this.ActiveObjectMobile.Name = "ActiveObjectMobile";
            this.ActiveObjectMobile.ReadOnly = true;
            // 
            // ActiveObjectEmail
            // 
            this.ActiveObjectEmail.HeaderText = "البريد الالكتروني";
            this.ActiveObjectEmail.MinimumWidth = 8;
            this.ActiveObjectEmail.Name = "ActiveObjectEmail";
            this.ActiveObjectEmail.ReadOnly = true;
            // 
            // ActiveObjectRefNumber
            // 
            this.ActiveObjectRefNumber.DataPropertyName = "ReferenceNumber";
            this.ActiveObjectRefNumber.HeaderText = "رقم المورد";
            this.ActiveObjectRefNumber.MinimumWidth = 8;
            this.ActiveObjectRefNumber.Name = "ActiveObjectRefNumber";
            this.ActiveObjectRefNumber.ReadOnly = true;
            // 
            // ActiveObjectTaxNumber
            // 
            this.ActiveObjectTaxNumber.DataPropertyName = "TaxNumber";
            this.ActiveObjectTaxNumber.HeaderText = "الرقم الضريبي";
            this.ActiveObjectTaxNumber.MinimumWidth = 8;
            this.ActiveObjectTaxNumber.Name = "ActiveObjectTaxNumber";
            this.ActiveObjectTaxNumber.ReadOnly = true;
            this.ActiveObjectTaxNumber.Visible = false;
            // 
            // ActiveObjectDescription
            // 
            this.ActiveObjectDescription.DataPropertyName = "Description";
            this.ActiveObjectDescription.HeaderText = "ملاحظات";
            this.ActiveObjectDescription.MinimumWidth = 8;
            this.ActiveObjectDescription.Name = "ActiveObjectDescription";
            this.ActiveObjectDescription.ReadOnly = true;
            // 
            // ActiveObjectOpeningBalance
            // 
            this.ActiveObjectOpeningBalance.DataPropertyName = "OpeningBalance";
            this.ActiveObjectOpeningBalance.HeaderText = "الرصيد الافتتاحي";
            this.ActiveObjectOpeningBalance.MinimumWidth = 8;
            this.ActiveObjectOpeningBalance.Name = "ActiveObjectOpeningBalance";
            this.ActiveObjectOpeningBalance.ReadOnly = true;
            // 
            // ActiveObjectFaxNumber
            // 
            this.ActiveObjectFaxNumber.DataPropertyName = "FaxNumber";
            this.ActiveObjectFaxNumber.HeaderText = "رقم الفاكس";
            this.ActiveObjectFaxNumber.MinimumWidth = 8;
            this.ActiveObjectFaxNumber.Name = "ActiveObjectFaxNumber";
            this.ActiveObjectFaxNumber.ReadOnly = true;
            this.ActiveObjectFaxNumber.Visible = false;
            // 
            // ActiveObjectPhoneNumber
            // 
            this.ActiveObjectPhoneNumber.DataPropertyName = "Phone";
            this.ActiveObjectPhoneNumber.HeaderText = "رقم الهاتف";
            this.ActiveObjectPhoneNumber.MinimumWidth = 8;
            this.ActiveObjectPhoneNumber.Name = "ActiveObjectPhoneNumber";
            this.ActiveObjectPhoneNumber.ReadOnly = true;
            this.ActiveObjectPhoneNumber.Visible = false;
            // 
            // ActiveObjectIsSupplier
            // 
            this.ActiveObjectIsSupplier.DataPropertyName = "IsSupplier";
            this.ActiveObjectIsSupplier.HeaderText = "إنه مورد";
            this.ActiveObjectIsSupplier.MinimumWidth = 8;
            this.ActiveObjectIsSupplier.Name = "ActiveObjectIsSupplier";
            this.ActiveObjectIsSupplier.ReadOnly = true;
            this.ActiveObjectIsSupplier.Visible = false;
            // 
            // ActiveObjectIsCustomer
            // 
            this.ActiveObjectIsCustomer.DataPropertyName = "IsCustomer";
            this.ActiveObjectIsCustomer.HeaderText = "إنه عميل";
            this.ActiveObjectIsCustomer.MinimumWidth = 8;
            this.ActiveObjectIsCustomer.Name = "ActiveObjectIsCustomer";
            this.ActiveObjectIsCustomer.ReadOnly = true;
            this.ActiveObjectIsCustomer.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage4.Controls.Add(this.dgvDeletedObjects);
            this.tabPage4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 43);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1012, 411);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "العملاء غير النشطوين";
            // 
            // dgvDeletedObjects
            // 
            this.dgvDeletedObjects.AllowUserToAddRows = false;
            this.dgvDeletedObjects.AllowUserToDeleteRows = false;
            this.dgvDeletedObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeletedObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedObjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeletedObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeletedObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NotActiveObjectId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dgvDeletedObjects.Location = new System.Drawing.Point(2, 2);
            this.dgvDeletedObjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeletedObjects.Name = "dgvDeletedObjects";
            this.dgvDeletedObjects.ReadOnly = true;
            this.dgvDeletedObjects.RowHeadersWidth = 51;
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDeletedObjects.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvDeletedObjects.RowTemplate.Height = 35;
            this.dgvDeletedObjects.Size = new System.Drawing.Size(1009, 407);
            this.dgvDeletedObjects.TabIndex = 1;
            // 
            // NotActiveObjectId
            // 
            this.NotActiveObjectId.DataPropertyName = "Id";
            this.NotActiveObjectId.HeaderText = "الرقم المرجعي";
            this.NotActiveObjectId.MinimumWidth = 8;
            this.NotActiveObjectId.Name = "NotActiveObjectId";
            this.NotActiveObjectId.ReadOnly = true;
            this.NotActiveObjectId.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم العميل";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NationalIdentity";
            this.dataGridViewTextBoxColumn3.HeaderText = "رقم الهوية";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IsActive";
            this.dataGridViewTextBoxColumn4.HeaderText = "حالة المورد";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FirmName";
            this.dataGridViewTextBoxColumn5.HeaderText = "اسم الشركة";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "عنوان المورد";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CommercialRegister";
            this.dataGridViewTextBoxColumn7.HeaderText = "الترخيص التجاري";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Mobile";
            this.dataGridViewTextBoxColumn8.HeaderText = "رقم الجوال";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "البريد الالكتروني";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ReferenceNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "رقم المورد";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TaxNumber";
            this.dataGridViewTextBoxColumn11.HeaderText = "الرقم الضريبي";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn12.HeaderText = "ملاحظات";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "OpeningBalance";
            this.dataGridViewTextBoxColumn13.HeaderText = "الرصيد الافتتاحي";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FaxNumber";
            this.dataGridViewTextBoxColumn14.HeaderText = "رقم الفاكس";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn15.HeaderText = "رقم الهاتف";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "IsSupplier";
            this.dataGridViewTextBoxColumn16.HeaderText = "إنه مورد";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "IsCustomer";
            this.dataGridViewTextBoxColumn17.HeaderText = "إنه عميل";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // ucAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucAllCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 514);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pActions.ResumeLayout(false);
            this.tabDGVContainer.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveObjects)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedObjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pActions;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvActiveObjects;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvDeletedObjects;
        internal System.Windows.Forms.TabControl tabDGVContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectNationalIdentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectFirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectCommercialREgistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectRefNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectTaxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectOpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectFaxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectIsSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveObjectIsCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotActiveObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}
