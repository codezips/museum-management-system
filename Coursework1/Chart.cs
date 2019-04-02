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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private VisitRepository _visitRepository = new VisitRepository();
        private List<Visit> _visitList = new List<Visit>();

        private void Chart_Load(object sender, EventArgs e)
        {
            LoadVisit();
            FillChart();
        }

        private void LoadVisit()
        {
            _visitList = _visitRepository.GetWeeksData();
        }

        private void FillChart()
        {
            foreach (var visit in _visitList)
            {
                visitChart.Series["Visitation"].Points.AddXY(visit.Date.DayOfWeek.ToString(), visit.TotalDuration.ToString());
            }
            visitChart.Titles.Add("Total Visitation in Minutes");
        }

        private void visitChart_Click(object sender, EventArgs e)
        {

        }
    }
}
