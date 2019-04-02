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
    class VisitRepository
    {
        private List<Visit> _visitList = new List<Visit>();
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath);

        private void DeSerializeVisitData()
        {
            try
            {
                //check whether file exist
                if (File.Exists(filePath + @"\visit.dat"))
                {
                    Stream stream = File.Open(filePath + @"\visit.dat", FileMode.Open);
                    if (stream != null && stream.Length > 0)
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();

                        //Reading Visit List Information
                        _visitList = (List<Visit>)binaryFormatter.Deserialize(stream);
                        MessageBox.Show("Successfully Retrieved Visit Details from file!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    stream.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Not able to get visit data. Please try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }

        private void SerializeVisitData(List<Visit> visits)
        {
            //seriialize the visit data
            Stream str = File.Open(filePath + @"\visit.dat", FileMode.Create);
            BinaryFormatter bF = new BinaryFormatter();
            bF.Serialize(str, visits);
            str.Flush();
            str.Close();
            MessageBox.Show("Succesfully saved Visit Details to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public List<Visit> ReadFromCSV(string csvString)
        {
            var visitList = new List<Visit>();
            try
            {
                var lines = csvString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Skip(1);

                foreach (var item in lines)
                {
                    var values = item.Split(',');
                    var visit = new Visit();
                    visit.VisitID = Convert.ToInt32(values[0]);
                    visit.VisitorName = Convert.ToString(values[1]);
                    visit.Date = Convert.ToDateTime(values[2]);
                    visit.InTime = Convert.ToDateTime(values[3]).TimeOfDay;
                    visit.OutTime = Convert.ToDateTime(values[4]).TimeOfDay;

                    visitList.Add(visit);
                }
                MessageBox.Show("Records Imported Successfullly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _visitList = visitList;
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to get visit data. Please try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            return visitList;
        }

        public void ExportToCSV(List<Visit> visits, string filePath)
        {
            try
            {
                if (visits.Count > 0)
                {
                    var propList = visits[0].GetType().GetProperties().Select(prop => prop.Name).ToList();
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
                        foreach (var val in visits)
                        {
                            foreach (PropertyInfo prop in val.GetType().GetProperties())
                            {
                                TW.Write(prop.GetValue(val, null).ToString() + ",");
                            }
                            TW.WriteLine();

                        }
                    }
                    MessageBox.Show("Records Exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(filePath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while exporting records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }


        public List<Visit> GetVisits()
        {
            DeSerializeVisitData();
            if (_visitList != null && _visitList.Count > 0)
            {
                return _visitList;
            }
            else
            {
                _visitList = new List<Visit>();
                return _visitList;
            }

        }


        public void SaveVisits(List<Visit> visits)
        {
            SerializeVisitData(visits);
        }

        public int GenerateId()
        {
            //generate id for data
            int id = 0;
            if (_visitList != null && _visitList.Count > 0)
            {
                id = _visitList.Max(a => a.VisitID);
            }

            return id + 1;
        }

        public List<Visit> SortUsingTotalDuration()
        {
            for (int i = 0; i < _visitList.Count; i++)
            {
                for (int j = 0; j < _visitList.Count - 1; j++)
                {
                    var val1 = Convert.ToInt32(_visitList[j].TotalDuration);
                    var val2 = Convert.ToInt32(_visitList[j + 1].TotalDuration);
                    if (val1 > val2)
                    {
                        var temp = _visitList[j + 1];
                        _visitList[j + 1] = _visitList[j];
                        _visitList[j] = temp;
                    }
                }
            }
            return _visitList;
        }

        public List<Visit> GetWeeksData()
        {
            DeSerializeVisitData();
            if (_visitList != null && _visitList.Count > 0)
            {
                //set to start of week i.e Monday of current week.
                var startOfWeek = DateTime.Now.AddDays(((int)DateTime.Now.DayOfWeek * -1) + 1);
                //set time as 10:00:00
                startOfWeek = new DateTime(startOfWeek.Year, startOfWeek.Month, startOfWeek.Day, 00, 0, 0);

                //set end of week i,e Friday of current we
                var endOfWeek = startOfWeek.AddDays(4);
                //set time as 17:00:00
                endOfWeek = new DateTime(endOfWeek.Year, endOfWeek.Month, endOfWeek.Day, 18, 0, 0);
                //where visitDetail.Date >= startOfWeek
                //                  && visitDetail.Date <= endOfWeek
                //get only this weeks data

                var weeklyData = (from visit in _visitList
                                  where visit.Date >= startOfWeek
                                  && visit.Date <= endOfWeek
                                  group visit by visit.Date into grp //groups data by date.
                                  select new Visit
                                  {
                                      Date = grp.Max(a => a.Date), //gets maximum value of date selected.
                                      Count = grp.Count(),
                                      TotalDuration = grp.Sum(a => a.TotalDuration) //get sum of total hours on that day.
                                  }).OrderByDescending(a => a.Count).ToList(); //orders the data in descending order and returns a list.
                return weeklyData;
            }
            else
            {
                _visitList = new List<Visit>();
                return _visitList;
            }
        }

        public List<Visit> GetReportData()
        {
            DeSerializeVisitData();
            if (_visitList != null && _visitList.Count > 0)
            {
                //set to start of week i.e Monday of current week.
                var currentDate = DateTime.Now;
                currentDate = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 00, 0, 0);
                

                var dailyData = (from visit in _visitList
                                  where visit.Date == currentDate
                                 group visit by visit.Date into grp //groups data by date.
                                 select new Visit
                                  {
                                      Date = grp.Max(a => a.Date),
                                      Count = grp.Count(),
                                      TotalDuration = grp.Sum(a => a.TotalDuration) //get sum of total hours on that day.
                                  }).OrderByDescending(a => a.Count).ToList(); //orders the data in descending order and returns a list.
                return dailyData;
            }
            else
            {
                _visitList = new List<Visit>();
                return _visitList;
            }
        }
    }
}
