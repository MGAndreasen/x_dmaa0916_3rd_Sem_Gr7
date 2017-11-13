using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Booking.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        public string Post(string s)
        {
            return "Du postede " + s;
        }

        public List<string> GetRoute(string id)
        {
            List<string> lst = new List<string>();
            lst.Add("12");
            lst.Add("2");
            lst.Add("12");
            lst.Add("3");
            lst.Add("7");
            lst.Add("8");
            lst.Add("15");
            lst.Add("1");

            return lst;
        }

        public string GetDestination(string id)
        {
            return "Du postede " + id;
        }
    }
}
