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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private VisitRepository _visitRepository = new VisitRepository();
        private List<Visit> _visitList = new List<Visit>();

        private void DailyTab_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyTab_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //load the report
            _visitList = _visitRepository.GetWeeksData();
            //fill the chart here
            FillChart();
        }

       

        private void FillChart()
        {
            //get all data, loop and add them in the grid view
            foreach (var visit in _visitList)
            {
                var a = visit.Date.DayOfWeek.ToString();
                var b = visit.TotalDuration.ToString();
                var c = visit.Count.ToString();
                this.WeeklyDataGridView.Rows.Add(a,c,b);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TotalVisitor_Click(object sender, EventArgs e)
        {

        }

        private void dateToday_Click(object sender, EventArgs e)
        {

        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            //sort the data
            this.WeeklyDataGridView.Sort(this.WeeklyDataGridView.Columns["Visitors"], ListSortDirection.Ascending);
        }
    }
}
