namespace Coursework1
{
    partial class VisitDetailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.visitMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByTotalDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitDataGridView = new System.Windows.Forms.DataGridView();
            this.visitMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitMenuStrip
            // 
            this.visitMenuStrip.AllowMerge = false;
            this.visitMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.visitMenuStrip.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.visitMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVisitToolStripMenuItem,
            this.importFromCSVToolStripMenuItem,
            this.exportToCSVToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.retrieveToolStripMenuItem,
            this.sortByTotalDurationToolStripMenuItem});
            this.visitMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.visitMenuStrip.Name = "visitMenuStrip";
            this.visitMenuStrip.Size = new System.Drawing.Size(173, 384);
            this.visitMenuStrip.TabIndex = 21;
            this.visitMenuStrip.Text = "menuStrip1";
            // 
            // addVisitToolStripMenuItem
            // 
            this.addVisitToolStripMenuItem.Name = "addVisitToolStripMenuItem";
            this.addVisitToolStripMenuItem.Size = new System.Drawing.Size(160, 21);
            this.addVisitToolStripMenuItem.Text = "Add Visit";
            this.addVisitToolStripMenuItem.Click += new System.EventHandler(this.addVisitToolStripMenuItem_Click);
            // 
            // importFromCSVToolStripMenuItem
            // 
            this.importFromCSVToolStripMenuItem.Name = "importFromCSVToolStripMenuItem";
            this.importFromCSVToolStripMenuItem.Size = new System.Drawing.Size(160, 21);
            this.importFromCSVToolStripMenuItem.Text = "Import from CSV";
            this.importFromCSVToolStripMenuItem.Click += new System.EventHandler(this.importFromCSVToolStripMenuItem_Click);
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(160, 21);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(160, 21);
            this.saveToolStripMenuItem.Text = "Save (Serialization)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // retrieveToolStripMenuItem
            // 
            this.retrieveToolStripMenuItem.Name = "retrieveToolStripMenuItem";
            this.retrieveToolStripMenuItem.Size = new System.Drawing.Size(160, 21);
            this.retrieveToolStripMenuItem.Text = "Retrieve (Deserialization)";
            this.retrieveToolStripMenuItem.Click += new System.EventHandler(this.retrieveToolStripMenuItem_Click);
            // 
            // sortByTotalDurationToolStripMenuItem
            // 
            this.sortByTotalDurationToolStripMenuItem.Name = "sortByTotalDurationToolStripMenuItem";
            this.sortByTotalDurationToolStripMenuItem.Size = new System.Drawing.Size(160, 21);
            this.sortByTotalDurationToolStripMenuItem.Text = "Sort By Total Duration";
            this.sortByTotalDurationToolStripMenuItem.Click += new System.EventHandler(this.sortByTotalDurationToolStripMenuItem_Click);
            // 
            // visitDataGridView
            // 
            this.visitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitDataGridView.Location = new System.Drawing.Point(175, 0);
            this.visitDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.visitDataGridView.Name = "visitDataGridView";
            this.visitDataGridView.RowTemplate.Height = 24;
            this.visitDataGridView.Size = new System.Drawing.Size(769, 367);
            this.visitDataGridView.TabIndex = 22;
            this.visitDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitDataGridView_CellContentClick);
            // 
            // VisitDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(955, 384);
            this.Controls.Add(this.visitDataGridView);
            this.Controls.Add(this.visitMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisitDetailForm";
            this.Text = "Visit Details";
            this.Load += new System.EventHandler(this.VisitDetailForm_Load);
            this.visitMenuStrip.ResumeLayout(false);
            this.visitMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip visitMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addVisitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByTotalDurationToolStripMenuItem;
        private System.Windows.Forms.DataGridView visitDataGridView;
    }
}