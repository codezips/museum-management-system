namespace Coursework1
{
    partial class VisitRegistrationForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameTBox = new System.Windows.Forms.ComboBox();
            this.btnCancelVisit = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.outTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddVisit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(180, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Add New Visit Entry";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameTBox);
            this.panel2.Controls.Add(this.btnCancelVisit);
            this.panel2.Controls.Add(this.datePicker);
            this.panel2.Controls.Add(this.outTimePicker);
            this.panel2.Controls.Add(this.inTimePicker);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnAddVisit);
            this.panel2.Location = new System.Drawing.Point(84, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 269);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nameTBox
            // 
            this.nameTBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.nameTBox.FormattingEnabled = true;
            this.nameTBox.Location = new System.Drawing.Point(147, 26);
            this.nameTBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(174, 23);
            this.nameTBox.TabIndex = 11;
            // 
            // btnCancelVisit
            // 
            this.btnCancelVisit.BackColor = System.Drawing.Color.Black;
            this.btnCancelVisit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelVisit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelVisit.ForeColor = System.Drawing.Color.White;
            this.btnCancelVisit.Location = new System.Drawing.Point(222, 192);
            this.btnCancelVisit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelVisit.Name = "btnCancelVisit";
            this.btnCancelVisit.Size = new System.Drawing.Size(98, 40);
            this.btnCancelVisit.TabIndex = 10;
            this.btnCancelVisit.Text = "Cancel";
            this.btnCancelVisit.UseVisualStyleBackColor = false;
            this.btnCancelVisit.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.datePicker.Location = new System.Drawing.Point(147, 63);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(174, 24);
            this.datePicker.TabIndex = 9;
            this.datePicker.Value = new System.DateTime(2018, 12, 31, 7, 28, 42, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // outTimePicker
            // 
            this.outTimePicker.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.outTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.outTimePicker.Location = new System.Drawing.Point(147, 145);
            this.outTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.outTimePicker.Name = "outTimePicker";
            this.outTimePicker.Size = new System.Drawing.Size(174, 24);
            this.outTimePicker.TabIndex = 8;
            this.outTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // inTimePicker
            // 
            this.inTimePicker.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.inTimePicker.Location = new System.Drawing.Point(147, 106);
            this.inTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.inTimePicker.Name = "inTimePicker";
            this.inTimePicker.Size = new System.Drawing.Size(174, 24);
            this.inTimePicker.TabIndex = 7;
            this.inTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(56, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Out Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(56, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "In Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(56, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(56, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // btnAddVisit
            // 
            this.btnAddVisit.BackColor = System.Drawing.Color.Black;
            this.btnAddVisit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddVisit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddVisit.ForeColor = System.Drawing.Color.White;
            this.btnAddVisit.Location = new System.Drawing.Point(58, 192);
            this.btnAddVisit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.Size = new System.Drawing.Size(98, 40);
            this.btnAddVisit.TabIndex = 0;
            this.btnAddVisit.Text = "Add";
            this.btnAddVisit.UseVisualStyleBackColor = false;
            // 
            // VisitRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisitRegistrationForm";
            this.Text = "Visit Registration Form";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox nameTBox;
        private System.Windows.Forms.Button btnCancelVisit;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker outTimePicker;
        private System.Windows.Forms.DateTimePicker inTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddVisit;
    }
}