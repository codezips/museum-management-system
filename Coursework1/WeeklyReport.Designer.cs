namespace Coursework1
{
    partial class Reports
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
            this.WeeklyDataGridView = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WeeklyDataGridView
            // 
            this.WeeklyDataGridView.AllowUserToAddRows = false;
            this.WeeklyDataGridView.AllowUserToDeleteRows = false;
            this.WeeklyDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.WeeklyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeeklyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Visitors,
            this.minutes});
            this.WeeklyDataGridView.Location = new System.Drawing.Point(31, 91);
            this.WeeklyDataGridView.Name = "WeeklyDataGridView";
            this.WeeklyDataGridView.ReadOnly = true;
            this.WeeklyDataGridView.RowTemplate.Height = 24;
            this.WeeklyDataGridView.Size = new System.Drawing.Size(498, 312);
            this.WeeklyDataGridView.TabIndex = 0;
            this.WeeklyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Visitors
            // 
            this.Visitors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Visitors.HeaderText = "No. of Visitors";
            this.Visitors.Name = "Visitors";
            this.Visitors.ReadOnly = true;
            this.Visitors.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // minutes
            // 
            this.minutes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.minutes.HeaderText = "Total Minutes";
            this.minutes.Name = "minutes";
            this.minutes.ReadOnly = true;
            this.minutes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(31, 431);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(498, 52);
            this.SortBtn.TabIndex = 1;
            this.SortBtn.Text = "Sort Data Using No. of Visitors";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(564, 510);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.WeeklyDataGridView);
            this.Name = "Reports";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView WeeklyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitors;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutes;
        private System.Windows.Forms.Button SortBtn;
    }
}