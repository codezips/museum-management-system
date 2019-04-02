using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class VisitDetailForm : Form
    {
        public VisitDetailForm()
        {
            InitializeComponent();
        }

        private BindingSource _visitBindingSource = new BindingSource();
        private VisitRepository _visitRepository = new VisitRepository();

        private void VisitDetailForm_Load(object sender, EventArgs e)
        {
            retrieveToolStripMenuItem_Click(sender, e);
        }



        private void addVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitRegistrationForm visitForm = new VisitRegistrationForm();
            visitForm.MaximizeBox = false;
            var result = visitForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var newVisit = visitForm.Visit;
                newVisit.VisitID = _visitRepository.GenerateId();
                _visitBindingSource.Add(newVisit);
                _visitRepository.SaveVisits((List<Visit>)_visitBindingSource.DataSource);
            }
        }

        private void importFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //step 1: create an instance of windows default open dialog box.
            var dialog = new OpenFileDialog();
            //step 2: set filter so that it shows only csv files.
            dialog.Filter = "CSV files|*.csv";

            //step 3: open the dialog box
            var result = dialog.ShowDialog();

            //check if  user has clicked OK.
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //Step 1: read all the lines in the csv file
                var csvString = File.ReadAllText(dialog.FileName);
                //Step 2: Pass the csvString to ReadFromCSV method from _vehicleRepository class
                //Step 3: Save the value to the binding source. (Binding Source is used by our grid).
                _visitBindingSource.DataSource = _visitRepository.ReadFromCSV(csvString);
            }
        }

        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //step 1: create an instance of windows default save dialog box.
            var dialog = new SaveFileDialog();
            //step 2: set filter so that the file can be saved with extenstion .csv.
            dialog.Filter = "CSV File|*.csv";
            dialog.AddExtension = true;
            //step 3: open the save dialog box
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //export filename and our data list to the ExportToCSV class.
                _visitRepository.ExportToCSV((List<Visit>)_visitBindingSource.DataSource, dialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _visitRepository.SaveVisits((List<Visit>)_visitBindingSource.DataSource);
        }

        private void retrieveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to display in grid
            _visitBindingSource.DataSource = _visitRepository.GetVisits();

            //if set to true creates a new object if the list is empty.
            _visitBindingSource.AllowNew = false;

            visitDataGridView.DataSource = _visitBindingSource;
            visitDataGridView.ReadOnly = true;
        }

        private void sortByTotalDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _visitBindingSource.DataSource = _visitRepository.SortUsingTotalDuration();

            //refresh the grid to view the output.
            visitDataGridView.Refresh();
        }

        private void visitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
