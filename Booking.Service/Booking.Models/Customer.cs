using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Customer
    {
        //Constructors

        public Customer()
        {
        }


        //Properties
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public City City { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public long CPR { get; set; }
        [DataMember]
        public long PhoneNumber { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool Confirmed { get; set; }
    }
}
