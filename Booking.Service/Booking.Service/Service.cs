using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Booking.Models;
using Booking.Controller;
using System.Security.Permissions;

namespace Booking.Service
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Service : IService
    {
        // Nix pille
        public UserCtrl uCtrl { get; set; }

        private CustomerCtrl customerCtrl = new CustomerCtrl();
        private BookingCtrl bookingCtrl = new BookingCtrl();
        private CityCtrl cityCtrl = new CityCtrl();
        private DestinationCtrl destinationCtrl = new DestinationCtrl();
        private PassengerCtrl passengerCtrl = new PassengerCtrl();
        private PaymentCtrl paymentCtrl = new PaymentCtrl();
        private PlaneCtrl planeCtrl = new PlaneCtrl();
        private RowCtrl rowCtrl = new RowCtrl();
        private SeatCtrl seatCtrl = new SeatCtrl();
        private SeatSchemaCtrl seatSchemaCtrl = new SeatSchemaCtrl();
        private TicketCtrl ticketCtrl = new TicketCtrl();

        public Service()
        {
            uCtrl = new UserCtrl();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public string GetUserData(int value)
        {
            var found = uCtrl.GetUser(1);
            return string.Format("Pssst, the data you requested back was: {0}, hi {1}, you are allowed to know!", value, OperationContext.Current.ServiceSecurityContext.PrimaryIdentity.Name);
        }

        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string Login(string s)
        {
            string[] sa = s.Split('&');
            sa[0].TrimStart('?');
            sa[1].TrimStart('&');
            sa[0].Replace("username=", "");
            sa[1].Replace("password=", "");

            if (sa[0].ToLower() == "tester" && sa[1] == "1234Qwer!")
            {
                return "MINHASHKODE....";
            }
            else
            {
                return "NOT VALID";
            }
        }

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

        //public string GetDestination(string id)
        //{
        //    return "Du postede " + id;
        //}

        #region Customer
        public void CreateCustomer(Customer obj)
        {
            customerCtrl.Create(obj);
        }

        public Customer GetCustomer(int id)
        {
           return customerCtrl.Get(id);
        }

        public void UpdateCustomer(Customer obj)
        {
            customerCtrl.Update(obj); 
        }

        public void DeleteCustomer(int id)
        {
            customerCtrl.Delete(id);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerCtrl.GetAllCustomers();
        }

        #endregion

        #region Booking
        public void CreateBooking(Bookings obj)
        {
            bookingCtrl.Create(obj);
        }

        public Bookings GetBooking(int id)
        {
            return bookingCtrl.Get(id);
        }

        public void UpdateBooking(Bookings obj)
        {
            bookingCtrl.Update(obj);
        }

        public void DeleteBooking(int id)
        {
            bookingCtrl.Delete(id);
        }

        #endregion

        #region City
        public void CreateCity(City obj)
        {
            cityCtrl.Create(obj);
        }

        public City GetCity(int id)
        {
            return cityCtrl.Get(id);
        }

        public void UpdateCity(City obj)
        {
            cityCtrl.Update(obj);
        }

        public void DeleteCity(int id)
        {
            cityCtrl.Delete(id);
        }

        #endregion

        #region Destination
        public void CreateDestination(Destination obj)
        {
            destinationCtrl.Create(obj);
        }

        public Destination GetDestination(int id)
        {
            return destinationCtrl.Get(id);
        }

        public void UpdateDestination(Destination obj)
        {
            destinationCtrl.Update(obj);
        }

        public void DeleteDestination(int id)
        {
            destinationCtrl.Delete(id);
        }

        public IEnumerable<Destination> GetAllDestinations()
        {
            return destinationCtrl.GetAllDestinations();
        }

        #endregion

        #region Passenger
        public void CreatePassenger(Passenger obj)
        {
            passengerCtrl.Create(obj);
        }

        public Passenger GetPassenger(int id)
        {
            return passengerCtrl.Get(id);
        }

        public void UpdatePassenger(Passenger obj)
        {
            passengerCtrl.Update(obj);
        }

        public void DeletePassenger(int id)
        {
            passengerCtrl.Delete(id);
        }

        public IEnumerable<Passenger> GetAllPassengers()
        {
            return passengerCtrl.GetAllPassengers();
        }

        #endregion

        #region Payment
        public void CreatePayment(Payment obj)
        {
            paymentCtrl.Create(obj);
        }

        public Payment GetPayment(int id)
        {
            return paymentCtrl.Get(id);
        }

        public void UpdatePayment(Payment obj)
        {
            paymentCtrl.Update(obj);
        }

        public void DeletePayment(int id)
        {
            paymentCtrl.Delete(id);
        }
        #endregion

        #region Plane
        public void CreatePlane(Plane obj)
        {
            planeCtrl.Create(obj);
        }

        public Plane GetPlane(int id)
        {
            return planeCtrl.Get(id);
        }

        public void UpdatePlane(Plane obj)
        {
            planeCtrl.Update(obj);
        }

        public void DeletePlane(int id)
        {
            planeCtrl.Delete(id);
        }

        public IEnumerable<Plane> GetAllPlanes()
        {
            return planeCtrl.GetAllPlanes();
        }
        #endregion

        #region Row
        public void CreateRow(Row obj)
        {
            rowCtrl.Create(obj);
        }

        public Row GetRow(int id)
        {
            return rowCtrl.Get(id);
        }

        public void UpdateRow(Row obj)
        {
            rowCtrl.Update(obj);
        }

        public void DeleteRow(int id)
        {
            rowCtrl.Delete(id);
        }
        #endregion

        #region Seat
        public void CreateSeat(Seat obj)
        {
            seatCtrl.Create(obj);
        }

        public Seat GetSeat(int id)
        {
            return seatCtrl.Get(id);
        }

        public void UpdateSeat(Seat obj)
        {
            seatCtrl.Update(obj);
        }

        public void DeleteSeat(int id)
        {
            seatCtrl.Delete(id);
        }
        #endregion

        #region SeatSchema
        public void CreateSeatSchema(SeatSchema obj)
        {
            seatSchemaCtrl.Create(obj);
        }

        public SeatSchema GetSetSchema(int id)
        {
            return seatSchemaCtrl.Get(id);
        }

        public void UpdateSeatSchema(SeatSchema obj)
        {
            seatSchemaCtrl.Update(obj);
        }

        public void DeleteSeatSchema(int id)
        {
            seatSchemaCtrl.Delete(id);
        }
        #endregion

        #region Ticket
        public void CreateTicket(Ticket obj)
        {
            ticketCtrl.Create(obj);
        }

        public Ticket GetTicket(int id)
        {
           return ticketCtrl.Get(id);
        }

        public void UpdateTicket(Ticket obj)
        {
            ticketCtrl.Update(obj);
        }

        public void DeleteTicket(int id)
        {
            ticketCtrl.Delete(id);
        }

        #endregion

        public string GetDestinationWeb(string id)
        {
            throw new NotImplementedException();
        }
    }
}
