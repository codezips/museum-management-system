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
    public partial class VisitRegistrationForm : Form
    {
        private VisitorRepository _visitorRepository = new VisitorRepository();
        private BindingSource _visitorBindingSource = new BindingSource();

        public VisitRegistrationForm()
        {
            InitializeComponent();
        }

        
        private void Register_Load(object sender, EventArgs e)
        {
           
        } 

        

        public Visit Visit
        {
            get
            {
                var visit = new Visit();
                visit.VisitorName = nameTBox.Text;
                visit.Date = datePicker.Value.Date;
                visit.InTime = inTimePicker.Value.TimeOfDay;
                visit.OutTime = outTimePicker.Value.TimeOfDay;
                visit.TotalDuration = visit.CalculateTotalDuration();
                visit.Day = visit.GetDay();
                return visit;
            }
        }



        private void NameTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            System.DayOfWeek i = datePicker.Value.DayOfWeek;
            if ((i == System.DayOfWeek.Sunday) || (i == System.DayOfWeek.Saturday))
            {
                MessageBox.Show("Sorry, can't select a weekend day. Please choose another day.");

                if (DateTime.Now.DayOfWeek == System.DayOfWeek.Sunday)
                {
                    this.datePicker.Value = DateTime.Now.AddDays(1);
                }
                else if (DateTime.Now.DayOfWeek == System.DayOfWeek.Saturday)
                {
                    this.datePicker.Value = DateTime.Now.AddDays(-1);
                }
                else
                {
                    this.datePicker.Value = DateTime.Now;
                }
                return;
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            var i = inTimePicker.Value.Hour;
            if ((i < 10) || (i > 16))
            {
                MessageBox.Show("Sorry, can't select the time when musuem is closed..");

                if (i < 10)
                {
                    this.inTimePicker.Value = DateTime.Parse("10:00:00");
                }
                else if (i > 16)
                {
                    this.inTimePicker.Value = DateTime.Parse("16:59:00");
                }
                else
                {
                    this.inTimePicker.Value = DateTime.Now;
                }
                return;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var i = outTimePicker.Value.Hour;
            if ((i < 10) || (i > 16))
            {
                MessageBox.Show("Sorry, can't select the time when musuem is closed.");

                if (i < 10)
                {
                    this.outTimePicker.Value = DateTime.Parse("10:00:00");
                }
                else if (i > 16)
                {
                    this.outTimePicker.Value = DateTime.Parse("16:59:00");
                }
                else
                {
                    this.outTimePicker.Value = DateTime.Now;
                }
                return;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
