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
    public partial class VisitorRegistrationForm : Form
    {
        public VisitorRegistrationForm()
        {
            InitializeComponent();
        }

        private VisitRepository _visitRepository = new VisitRepository();
        private BindingSource _visitBindingSource = new BindingSource();

        private void RegisterVisitor_Load(object sender, EventArgs e)
        {
            GetVisitData(sender, e);
        }

        private void GetVisitData(object sender, EventArgs e)
        {
            //to display in grid
            //it get's visitor data from visitorRepository class.
            _visitBindingSource.DataSource = _visitRepository.GetVisits();

            //if set to true creates a new object if the list is empty.
            _visitBindingSource.AllowNew = false;

            //nameTextBox.DataSource = _visitBindingSource;
            //nameTextBox.DisplayMember = "VisitorName";
            //nameTextBox.ValueMember = "VisitorName";
        }

        //this property has only get accessor.
        //it is called when the user press OK button
        public Visitor Visitor
        {
            get
            {
                var visitor = new Visitor();
                visitor.VisitorName = Convert.ToString(nameTextBox.Text);
                visitor.Email = emailTextBox.Text;
                visitor.Address = addressTextBox.Text;
                visitor.Contact = contactTextBox.Text;
                visitor.Occupation = occupationTextBox.Text;
                return visitor;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (emailTextBox.Text.Length > 0 && emailTextBox.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(emailTextBox.Text.Trim()))
                {
                    MessageBox.Show("Email doesn't seem valid. Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTextBox.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void occupationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
