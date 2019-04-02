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
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            _visitList = _visitRepository.GetReportData();
            FillChart();
            dateToday.Text = DateTime.Now.ToLongDateString();
        }
        private VisitRepository _visitRepository = new VisitRepository();
        private List<Visit> _visitList = new List<Visit>();

        private void FillChart()
        {
            foreach (var visit in _visitList)
            {
                var a = visit.Date.DayOfWeek.ToString();
                var b = visit.TotalDuration.ToString();
                var c = visit.Count.ToString();
                this.DailyDataGrid.Rows.Add(a, c, b);
            }
        }

        private void DailyDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
