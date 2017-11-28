using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    [DataContract]
    public class Role
    {

        //Ctors
        public Role()
        {
            User = new List<User>();
        }

        //Properties
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<User> User { get; set; }
    }
}
