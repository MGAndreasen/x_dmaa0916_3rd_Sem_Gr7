using System.ServiceModel;
using Booking.Models;

namespace Booking.Service
{
    [ServiceContract]
    public interface IAuth
    {
        [OperationContract]
        Customer Login(string username, string password);
    }
}
