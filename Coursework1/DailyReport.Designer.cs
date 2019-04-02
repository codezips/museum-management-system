namespace Coursework1
{
    partial class DailyReport
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
            this.dateToday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DailyDataGrid = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dateToday
            // 
            this.dateToday.AutoSize = true;
            this.dateToday.Location = new System.Drawing.Point(100, 89);
            this.dateToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateToday.Name = "dateToday";
            this.dateToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateToday.Size = new System.Drawing.Size(30, 13);
            this.dateToday.TabIndex = 11;
            this.dateToday.Text = "Date";
            this.dateToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date :";
            // 
            // DailyDataGrid
            // 
            this.DailyDataGrid.AllowUserToAddRows = false;
            this.DailyDataGrid.AllowUserToDeleteRows = false;
            this.DailyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.visitors,
            this.time});
            this.DailyDataGrid.Location = new System.Drawing.Point(24, 119);
            this.DailyDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DailyDataGrid.Name = "DailyDataGrid";
            this.DailyDataGrid.ReadOnly = true;
            this.DailyDataGrid.RowTemplate.Height = 24;
            this.DailyDataGrid.Size = new System.Drawing.Size(350, 122);
            this.DailyDataGrid.TabIndex = 14;
            this.DailyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DailyDataGrid_CellContentClick);
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // visitors
            // 
            this.visitors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.visitors.HeaderText = "Total No. of Visitors";
            this.visitors.Name = "visitors";
            this.visitors.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "Total Duration (Minutes)";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(396, 266);
            this.Controls.Add(this.DailyDataGrid);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DailyReport";
            this.Text = "DailyReport";
            this.Load += new System.EventHandler(this.DailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateToday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DailyDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitors;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}