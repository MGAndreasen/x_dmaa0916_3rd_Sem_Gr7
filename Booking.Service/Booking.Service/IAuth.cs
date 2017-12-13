using System.ServiceModel;
using Booking.Models;

namespace Booking.Service
{
    [ServiceContract]
    public interface IAuth
    {
        [OperationContract]
        User Login(string username, string password);

        [OperationContract]
        bool CreateLogin(string email, string password, string firstname, string lastname, string address, int zipcode, long phonenumber);
    }
}
