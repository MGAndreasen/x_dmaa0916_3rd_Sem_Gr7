using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class User
    {
        // Constructors
        public User()
        {
            Roles = new List<Role>();
        }

        // Properties

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public List<Role> Roles { get; set; }
    }
}
