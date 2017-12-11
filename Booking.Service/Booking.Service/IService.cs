using Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Booking.Service
{
    [ServiceContract]
    public interface IService
    {
        #region Michael's sjeit.
        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // Token play
        //[OperationContract]
        //[WebInvoke(Method = "GET",  ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/login/")]
        //string Login(string s);



        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "{s}")]
        string Post(string s);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/route/{id}")]
        List<string> GetRoute(string id);

        //[OperationContract]
        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/destination/{id}")]
        //string GetDestination(string id);

        #endregion

        #region Departure

        [OperationContract]
        void CreateDeparture(Departure obj);

        [OperationContract]
        Departure GetDeparture(int id);

        [OperationContract]
        void UpdateDeparture(Departure obj);

        [OperationContract]
        void DeleteDeparture(int id);

        [OperationContract]
        IEnumerable<Departure> GetAllDepartures();

        #endregion

        #region CustomerCtrl

        [OperationContract]
        void CreateCustomer(Customer obj);

        [OperationContract]
        Customer GetCustomer(int id);

        [OperationContract]
        void UpdateCustomer(Customer obj);

        [OperationContract]
        void DeleteCustomer(int id);
        [OperationContract]
        IEnumerable<Customer> GetAllCustomers();

        #endregion 

        #region BookingCtrl

        [OperationContract]
        void CreateBooking(Bookings obj);
        [OperationContract]
        Bookings GetBooking(int id);
        [OperationContract]
        void UpdateBooking(Bookings obj);
        [OperationContract]
        void DeleteBooking(int id);
        [OperationContract]
        IEnumerable<Bookings> GetAllBookings();
        #endregion 

        #region CityCtrl

        [OperationContract]
        void CreateCity(City obj);
        [OperationContract]
        City GetCity(int id);
        [OperationContract]
        void UpdateCity(City obj);
        [OperationContract]
        void DeleteCity(int id);

        #endregion 

        #region DestinationCtrl

        [OperationContract]
        void CreateDestination(Destination obj);
        [OperationContract]
        Destination GetDestination(int id);
        [OperationContract]
        void UpdateDestination(Destination obj);
        [OperationContract]
        void DeleteDestination(int id);

        [OperationContract]
        [FaultContract(typeof(System.Security.SecurityException))]
        IEnumerable<Destination> GetAllDestinations();

        #endregion 

        #region PassengerCtrl

        [OperationContract]
        void CreatePassenger(Passenger obj);
        [OperationContract]
        Passenger GetPassenger(int id);
        [OperationContract]
        void UpdatePassenger(Passenger obj);
        [OperationContract]
        void DeletePassenger(int id);
        [OperationContract]
        IEnumerable<Passenger> GetAllPassengers();

        #endregion 

        #region PaymentCtrl

        [OperationContract]
        void CreatePayment(Payment obj);
        [OperationContract]
        Payment GetPayment(int id);
        [OperationContract]
        void UpdatePayment(Payment obj);
        [OperationContract]
        void DeletePayment(int id);

        #endregion 

        #region PlaneCtrl

        [OperationContract]
        void CreatePlane(Plane obj);
        [OperationContract]
        Plane GetPlane(int id);
        [OperationContract]
        void UpdatePlane(Plane obj);
        [OperationContract]
        void DeletePlane(int id);
        [OperationContract]
        IEnumerable<Plane> GetAllPlanes();

        #endregion 

        #region RowCtrl

        [OperationContract]
        void CreateRow(Row obj);
        [OperationContract]
        Row GetRow(int id);
        [OperationContract]
        void UpdateRow(Row obj);
        [OperationContract]
        void DeleteRow(int id);

        #endregion 

        #region SeatCtrl

        [OperationContract]
        void CreateSeat(Seat obj);
        [OperationContract]
        Seat GetSeat(int id);
        [OperationContract]
        void UpdateSeat(Seat obj);
        [OperationContract]
        void DeleteSeat(int id);

        #endregion 

        //#region SeatSchemaCtrl

        //[OperationContract]
        //void CreateSeatSchema(SeatSchema obj);
        //[OperationContract]
        //SeatSchema GetSetSchema(int id);
        //[OperationContract]
        //void UpdateSeatSchema(SeatSchema obj);
        //[OperationContract]
        //void DeleteSeatSchema(int id);

        //#endregion 

        #region TicketCtrl

        [OperationContract]
        void CreateTicket(Ticket obj);
        [OperationContract]
        Ticket GetTicket(int id);
        [OperationContract]
        void UpdateTicket(Ticket obj);
        [OperationContract]
        void DeleteTicket(int id);

        #endregion 

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Booking.Service.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
