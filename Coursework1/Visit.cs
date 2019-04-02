using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    [Serializable()]
    public class Visit : ISerializable
    {
        public int VisitID { get; set; }
        public string VisitorName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan InTime { get; set; }
        public TimeSpan OutTime { get; set; }
        public double TotalDuration { get; set; }
        public string Day { get; set; }
        [NonSerialized] public double Count;

        //needed for serialization
        public static string KEY = "VisitID";
        public static string KEY1 = "VisitorName";
        public static string KEY2 = "Date";
        public static string KEY3 = "InTime";
        public static string KEY4 = "OutTime";
        public static string KEY5 = "TotalDuration";
        public static string KEY6 = "Day";


        //Deserialization constructor.
        public Visit(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties

            VisitID = (int)serial.GetValue(KEY, typeof(int));
            VisitorName = (string)serial.GetValue(KEY1, typeof(string));
            Date = (DateTime)serial.GetValue(KEY2, typeof(DateTime));
            Day = (string)serial.GetValue(KEY6, typeof(string));
            InTime = (TimeSpan)serial.GetValue(KEY3, typeof(TimeSpan));
            OutTime = (TimeSpan)serial.GetValue(KEY4, typeof(TimeSpan));
            TotalDuration = (double)serial.GetValue(KEY5, typeof(double));
        }

        //default constructor
        public Visit() { }

        //needed for serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
           
            info.AddValue(KEY, VisitID);
            info.AddValue(KEY1, VisitorName);
            info.AddValue(KEY2, Date);
            info.AddValue(KEY3, InTime);
            info.AddValue(KEY4, OutTime);
            info.AddValue(KEY5, TotalDuration);
            info.AddValue(KEY6, Day);
        }

        public double CalculateTotalDuration()
        {
            return (int)OutTime.Subtract(InTime).TotalMinutes;
        }

        public string GetDay()
        {
            string i = Date.ToString("dddd");
            return i;
        }
    }
}
