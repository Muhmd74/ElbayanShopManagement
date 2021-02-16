
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
            this.gcMainCategory = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gcMainCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMainCategory
            // 
            this.gcMainCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcMainCategory.Location = new System.Drawing.Point(0, 223);
            this.gcMainCategory.MainView = this.gridView1;
            this.gcMainCategory.Name = "gcMainCategory";
            this.gcMainCategory.Size = new System.Drawing.Size(1282, 494);
            this.gcMainCategory.TabIndex = 0;
            this.gcMainCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcMainCategory;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(91, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 128);
            this.panel1.TabIndex = 1;
            // 
            // ucMaincategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gcMainCategory);
            this.Name = "ucMaincategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1282, 717);
            ((System.ComponentModel.ISupportInitialize)(this.gcMainCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMainCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
    }
}
