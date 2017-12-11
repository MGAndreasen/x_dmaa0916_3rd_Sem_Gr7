using System.ServiceModel;
using Booking.Models;

namespace Booking.Service
{
    [ServiceContract]
    public interface IAuth
    {
        [OperationContract]
        User Login(string username, string password);
    }
}
