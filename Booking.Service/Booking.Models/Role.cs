using System.Collections.Generic;
using System.Runtime.Serialization;

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
