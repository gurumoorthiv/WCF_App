using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Task1ServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string SayHello(string name)
        {
            int hour = DateTime.Now.Hour;
            if (hour > 17) return "Good Evening " + name;
            if (hour > 12) return "Good Afternoon " + name;
            return "Good Morning" + name;
        }

        public string TodayProgram(string name)
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                return "Happy Weekend " + name;
            }
            return string.Format("{0} {1}", "Enjoy Working Day", name);
        }
    }
}
