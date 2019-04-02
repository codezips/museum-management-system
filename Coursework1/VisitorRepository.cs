using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coursework1
{
    class VisitorRepository
    {
        private List<Visitor> _visitorList = new List<Visitor>();
        //file location to save object state. It is path of {project location}\bin\Debug
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath);

        //start: private methods of this class

        //gets object data from file location and converts to c# list.
        private void DeSerializeVisitorData()
        {
            try
            {
                //step 1: check if file exists
                if (File.Exists(filePath + @"\visitorDetails.dat"))
                {
                    //step 2 : opens a stream to open the file
                    Stream stream = File.Open(filePath + @"\visitorDetails.dat", FileMode.Open);

                    //step 3: check if file is null or emtpy.
                    if (stream != null && stream.Length > 0)
                    {
                        //BinaryFormatter class has method to convert .dat file to a c# list. i.e. deserialization.
                        BinaryFormatter binaryFormatter = new BinaryFormatter();

                        //Step 4: Convert object state to c# list.
                        _visitorList = (List<Visitor>)binaryFormatter.Deserialize(stream);

                        MessageBox.Show("Successfully Retrieved Visitor Details from file!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //step 5: close the stream. after opening a stream it should always be closed.
                    stream.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to get visitor data. Please try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //saves c# list object, converts to object data and saves in the file location.
        private void SerializeVisitorData(List<Visitor> visitors)
        {
            //step 1: create a new file/ opens the file if it already exisits.
            Stream str = File.Open(filePath + @"\visitorDetails.dat", FileMode.Create);
            //BinaryFormatter class has method to convert  c# list to .dat file. i.e. serialization.
            BinaryFormatter bF = new BinaryFormatter();
            //step 2: convert c# list to .dat file.
            bF.Serialize(str, visitors);
            //step 3: writes to the file.
            str.Flush();
            //step 4: close the stream.
            str.Close();
            MessageBox.Show("Succesfully saved Visitor Details to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //end: private methods of this class


        //start: public methods of this class. only these methods can be accessed by other classes

        //read from a csv file and conver it to c# object.
        public List<Visitor> ReadFromCSV(string csvString)
        {
            var visitorList = new List<Visitor>();
            try
            {
                //1st row contains property name so skipping the first row.
                var lines = csvString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Skip(1);

                foreach (var item in lines)
                {
                    var values = item.Split(',');
                    var visitor = new Visitor();
                    visitor.VisitorID = Convert.ToInt32(values[0]);
                    visitor.VisitorName = values[1];
                    visitor.Email = values[2];
                    visitor.Address = values[3];
                    visitor.Contact = values[4];
                    visitor.Occupation = values[5];

                    visitorList.Add(visitor);
                }
                MessageBox.Show("Records Imported Successfullly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _visitorList = visitorList;

            }
            catch (Exception)
            {
                MessageBox.Show("Not able to get visitor data. Please try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return visitorList;

        }

        //export the list to csv
        public void ExportToCSV(List<Visitor> visitors, string filePath)
        {
            try
            {
                if (visitors.Count > 0)
                {
                    var propList = visitors[0].GetType().GetProperties().Select(prop => prop.Name).ToList();
                    //TextWriter is used to create outputand streamWriter is used to read file location

                    using (TextWriter TW = new StreamWriter(filePath, append: true))
                    {
                        //writes header
                        foreach (var prop in propList)
                        {
                            TW.Write(prop.ToString() + ",");
                        }
                        TW.WriteLine();
                        //writes values
                        foreach (var val in visitors)
                        {
                            foreach (PropertyInfo prop in val.GetType().GetProperties())
                            {
                                TW.Write(prop.GetValue(val, null).ToString() + ",");
                            }
                            TW.WriteLine();

                        }
                    }
                    MessageBox.Show("Records Exported Successfullly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(filePath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while saving records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        //reads visitor data from object source and returns a list
        public List<Visitor> GetVisitors()
        {
            //step 1: get data from the file.
            DeSerializeVisitorData();
            //check if it is null or empty.
            if (_visitorList != null && _visitorList.Count > 0)
            {
                return _visitorList;
            }
            else
            {
                _visitorList = new List<Visitor>();
                return _visitorList;
            }

        }

        //accepts list of visitor and serializes the data to save as a object state.
        public void SaveVisitors(List<Visitor> visitors)
        {
            //call this method to save the file.
            SerializeVisitorData(visitors);
        }

        //gets the latest identity id.
        public int GenerateId()
        {
            int id = 0;
            //checks if list is null or empty
            if (_visitorList != null && _visitorList.Count > 0)
            {
                id = _visitorList.Max(a => a.VisitorID);
            }

            return id + 1;
        }

        

    }
}
