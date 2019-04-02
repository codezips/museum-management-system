using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    [Serializable()]
    public class Visitor : ISerializable
    {
        public int VisitorID { get; set; }
        public string VisitorName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Occupation { get; set; }

        //needed for serialization
        //making key value pairs.
        public static string KEY = "VisitorID";
        public static string KEY1 = "VisitorName";
        public static string KEY2 = "Email";
        public static string KEY3 = "Address";
        public static string KEY4 = "Contact";
        public static string KEY5 = "Occupation";

        //default constructor
        public Visitor() { }


        //Deserialization constructor.
        //gets value from object data and converts to c# property.
        public Visitor(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties
            VisitorID = (int)serial.GetValue(KEY, typeof(int));
            VisitorName = (string)serial.GetValue(KEY1, typeof(string));
            Email = (string)serial.GetValue(KEY2, typeof(string));
            Address = (string)serial.GetValue(KEY3, typeof(string));
            Contact = (string)serial.GetValue(KEY4, typeof(string));
            Occupation = (string)serial.GetValue(KEY5, typeof(string));

        }

        //Serialize Method.
        //this method converts the properties to object data using Key value mentioned above
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue(KEY, VisitorID);
            info.AddValue(KEY1, VisitorName);
            info.AddValue(KEY2, Email);
            info.AddValue(KEY3, Address);
            info.AddValue(KEY4, Contact);
            info.AddValue(KEY5, Occupation);
        }

    }
}
