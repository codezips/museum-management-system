using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

       
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if the form is already open
            Form openForm = Application.OpenForms["VisitDetail"];
            //doesnot open a new instance if the form is already open.
            if (openForm == null)
            {
                VisitDetailForm visitDetail = new VisitDetailForm();
                visitDetail.MdiParent = this;
                visitDetail.Show();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void visitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if the form is already open
            Form openForm = Application.OpenForms["VisitorDetail"];
            //doesnot open a new instance if the form is already open.
            if (openForm == null)
            {
                VisitorDetailForm visitorDetail = new VisitorDetailForm();
                visitorDetail.MdiParent = this;
                visitorDetail.Show();
            }
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if the form is already open
            Form openForm = Application.OpenForms["Chart"];
            //doesnot open a new instance if the form is already open.
            if (openForm == null)
            {
                Chart chart = new Chart();
                chart.MdiParent = this;
                chart.Show();
            }
        }

        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form openForm = Application.OpenForms["Reports"];
            //doesnot open a new instance if the form is already open.
            if (openForm == null)
            {
                Reports reports = new Reports();
                reports.MdiParent = this;
                reports.Show();
            }
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form openForm = Application.OpenForms["DailyReport"];
            //doesnot open a new instance if the form is already open.
            if (openForm == null)
            {
                DailyReport report = new DailyReport();
                report.MdiParent = this;
                report.Show();
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Successfully Signed out.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
