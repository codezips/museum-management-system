namespace Coursework1
{
    partial class VisitorDetailForm
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
            this.VisitorDataGridView = new System.Windows.Forms.DataGridView();
            this.visitorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorDataGridView)).BeginInit();
            this.visitorMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisitorDataGridView
            // 
            this.VisitorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorDataGridView.Location = new System.Drawing.Point(209, 40);
            this.VisitorDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.VisitorDataGridView.Name = "VisitorDataGridView";
            this.VisitorDataGridView.RowTemplate.Height = 24;
            this.VisitorDataGridView.Size = new System.Drawing.Size(600, 273);
            this.VisitorDataGridView.TabIndex = 6;
            this.VisitorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisitorDataGridView_CellContentClick);
            // 
            // visitorMenuStrip
            // 
            this.visitorMenuStrip.AllowMerge = false;
            this.visitorMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.visitorMenuStrip.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.visitorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.visitorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.visitorMenuStrip.Name = "visitorMenuStrip";
            this.visitorMenuStrip.Size = new System.Drawing.Size(173, 366);
            this.visitorMenuStrip.TabIndex = 15;
            this.visitorMenuStrip.Text = "menuStrip2";
            this.visitorMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.visitorMenuStrip_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 21);
            this.toolStripMenuItem1.Text = "Add Visitor";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 21);
            this.toolStripMenuItem2.Text = "Import from CSV";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 21);
            this.toolStripMenuItem3.Text = "Export to CSV";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 21);
            this.toolStripMenuItem4.Text = "Save (Serialization)";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 21);
            this.toolStripMenuItem5.Text = "Retrieve (Deserialization)";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // VisitorDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 366);
            this.Controls.Add(this.visitorMenuStrip);
            this.Controls.Add(this.VisitorDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisitorDetailForm";
            this.Text = "Visitor Details";
            this.Load += new System.EventHandler(this.VisitorDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorDataGridView)).EndInit();
            this.visitorMenuStrip.ResumeLayout(false);
            this.visitorMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView VisitorDataGridView;
        private System.Windows.Forms.MenuStrip visitorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}