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
    public partial class VisitorDetailForm : Form
    {
        public VisitorDetailForm()
        {
            InitializeComponent();
        }

        //repository class has all the logic to save and retrieve data.
        //making a object of VisitorRepository class.
        private VisitorRepository _visitorRepository = new VisitorRepository();
        //making object of BindingSource clss to store Visitor data.
        private BindingSource _visitorBindingSource = new BindingSource();

        //this function is called when the form loads.

        private void VisitorDetail_Load(object sender, EventArgs e)
        {
            //calls this method to get the visitor list.
            toolStripMenuItem5_Click(sender, e);
        }

        

        private void ExpVisitor_Click(object sender, EventArgs e)
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
                _visitorRepository.ExportToCSV((List<Visitor>)_visitorBindingSource.DataSource, dialog.FileName);
            }
        }

        //this function calls SaveVisitor class and pass the data list the class.
        private void SaveVisitor_Click(object sender, EventArgs e)
        {
            _visitorRepository.SaveVisitors((List<Visitor>)_visitorBindingSource.DataSource);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //step 1: create object of VisitorRegisterForm
            VisitorRegistrationForm registervisitor = new VisitorRegistrationForm();
            registervisitor.MaximizeBox = false;
            //step 2: open the form in dialog box and store the result.
            var result = registervisitor.ShowDialog(this);
            //step 3: check if user has pressed OK button
            if (result == DialogResult.OK)
            {
                //store the data from dialog box to a variable.
                var newVisitor = registervisitor.Visitor;
                //generate unique id and store.
                newVisitor.VisitorID = _visitorRepository.GenerateId();
                //add to the grid
                _visitorBindingSource.Add(newVisitor);
                //save to the object state file.
                _visitorRepository.SaveVisitors((List<Visitor>)_visitorBindingSource.DataSource);

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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
                //Step 2: Pass the csvString to ReadFromCSV method from _visitorRepository class
                //Step 3: Save the value to the binding source. (Binding Source is used by our grid).
                _visitorBindingSource.DataSource = _visitorRepository.ReadFromCSV(csvString);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
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
                _visitorRepository.ExportToCSV((List<Visitor>)_visitorBindingSource.DataSource, dialog.FileName);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _visitorRepository.SaveVisitors((List<Visitor>)_visitorBindingSource.DataSource);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

            //Step 1: Get Visitor Data from GetVisitor method of _visitorRepository class.
            //Step 2: Store it in the _vehicleBindingSource.DataSource
            _visitorBindingSource.DataSource = _visitorRepository.GetVisitors();

            //if set to true creates a new object if the list is empty.
            _visitorBindingSource.AllowNew = false;

            //display data in the binding source in the grid.
            //assign the list to the grid.
            VisitorDataGridView.DataSource = _visitorBindingSource;
            //making the grid readonly.
            VisitorDataGridView.ReadOnly = true;
        }

       

        private void VisitorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void visitorMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
