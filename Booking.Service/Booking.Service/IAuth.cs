using System.ServiceModel;

namespace Booking.Service
{
    [ServiceContract]
    public interface IAuth
    {
        [OperationContract]
        bool Login(string username, string password);
    }
}
