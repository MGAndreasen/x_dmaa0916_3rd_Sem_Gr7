using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Booking.Models;
using Booking.Controller;

namespace Booking.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Service : IService
    {
        private CustomerCtrl customerCtrl;
        private BookingCtrl bookingCtrl;
        private DestinationCtrl destinationCtrl;
        private PassengerCtrl passengerCtrl;
        private PaymentCtrl paymentCtrl;
        private PlaneCtrl planeCtrl;
        private RowCtrl rowCtrl;
        private SeatCtrl seatCtrl;
        private SeatSchemaCtrl seatSchemaCtrl;
        private TicketCtrl ticketCtrl; 
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

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

        #endregion

        #region Booking
        public void CreateBooking(Bookings obj)
        {
            throw new NotImplementedException();
        }

        public Bookings GetBooking(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBooking(Bookings obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteBooking(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region City
        public void CreateCity(City obj)
        {
            throw new NotImplementedException();
        }

        public City GetCity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCity(City obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteCity(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Destination
        public void CreateDestination(Destination obj)
        {
            throw new NotImplementedException();
        }

        public Destination GetDestination(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDestination(Destination obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteDestination(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Passenger
        public void CreatePassenger(Passenger obj)
        {
            throw new NotImplementedException();
        }

        public Passenger GetPassenger(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassenger(Passenger obj)
        {
            throw new NotImplementedException();
        }

        public void DeletePassenger(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Payment
        public void CreatePayment(Payment obj)
        {
            throw new NotImplementedException();
        }

        public Payment GetPayment(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePayment(Payment obj)
        {
            throw new NotImplementedException();
        }

        public void DeletePayment(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Plane
        public void CreatePlane(Plane obj)
        {
            throw new NotImplementedException();
        }

        public Plane GetPlane(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePlane(Plane obj)
        {
            throw new NotImplementedException();
        }

        public void DeletePlane(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Row
        public void CreateRow(Row obj)
        {
            throw new NotImplementedException();
        }

        public Row GetRow(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRow(Row obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteRow(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Seat
        public void CreateSeat(Seat obj)
        {
            throw new NotImplementedException();
        }

        public Seat GetSeat(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSeat(Seat obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteSeat(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region SeatSchema
        public void CreateSeatSchema(SeatSchema obj)
        {
            throw new NotImplementedException();
        }

        public SeatSchema GetSetSchema(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSeatSchema(SeatSchema obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteSeatSchema(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Ticket
        public void CreateTicket(Ticket obj)
        {
            throw new NotImplementedException();
        }

        public Ticket GetTicket(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicket(Ticket obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }
#endregion
    }
}
