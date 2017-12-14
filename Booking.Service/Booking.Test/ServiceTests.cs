using Microsoft.VisualStudio.TestTools.UnitTesting;
using Booking.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Service.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        Service service = new Service();
        [TestMethod()]
        public void CreateDepartureTest()
        {
            //Models.Departure d = null;
            //service.CreateDeparture(d = new Models.Departure
            //{
            //    StartDestination = new Models.Destination { Id = 5 },
            //    EndDestination = new Models.Destination { Id = 10 },
            //    Plane = new Models.Plane { Id = 1 },
            //    DepartureTime = DateTime.Now
            //});
            //Assert.IsNotNull(service.GetDeparture(d.Id));
        }

        [TestMethod()]
        public void GetDepartureTest()
        {
            Assert.IsNotNull(service.GetDeparture(1));
        }

        [TestMethod()]
        public void UpdateDepartureTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteDepartureTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllDeparturesTest()
        {
            Assert.IsNotNull(service.GetAllDepartures());
        }

        [TestMethod()]
        public void GetAllTilbudTest()
        {
            Assert.IsNotNull(service.GetAllTilbud());
        }

        [TestMethod()]
        public void GetUserDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDataUsingDataContractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRouteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateCustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCustomerTest()
        {
            Assert.IsNotNull(service.GetCustomer(1));
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteCustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllCustomersTest()
        {
            Assert.IsNotNull(service.GetAllCustomers());
        }

        [TestMethod()]
        public void GetActivityCountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdActivityTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateBookingTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBookingTest()
        {
            Assert.IsNotNull(service.GetBooking(12));
        }

        [TestMethod()]
        public void UpdateBookingTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteBookingTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllBookingsTest()
        {
            Assert.IsNotNull(service.GetAllBookings());
        }

        [TestMethod()]
        public void CreateCityTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCityTest()
        {
            Assert.IsNotNull(service.GetCity(9000));
        }

        [TestMethod()]
        public void UpdateCityTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteCityTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateDestinationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDestinationTest()
        {
            Assert.IsNotNull(service.GetDestination(5));
        }

        [TestMethod()]
        public void UpdateDestinationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteDestinationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllDestinationsTest()
        {
            Assert.IsNotNull(service.GetAllDestinations());
        }

        [TestMethod()]
        public void CreatePassengerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPassengerTest()
        {
            Assert.IsNotNull(service.GetPassenger(1));
        }

        [TestMethod()]
        public void UpdatePassengerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeletePassengerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllPassengersTest()
        {
            Assert.IsNotNull(service.GetAllPassengers());
        }

        [TestMethod()]
        public void CreatePaymentTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPaymentTest()
        {
            Assert.IsNotNull(service.GetPayment(1));
        }

        [TestMethod()]
        public void UpdatePaymentTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeletePaymentTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreatePlaneTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPlaneTest()
        {
            Assert.IsNotNull(service.GetPlane(1));
        }

        [TestMethod()]
        public void UpdatePlaneTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeletePlaneTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllPlanesTest()
        {
            Assert.IsNotNull(service.GetAllPlanes());
        }

        [TestMethod()]
        public void CreateSeatTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSeatTest()
        {
            //ingen seats endnu
            Assert.IsNotNull(service.GetSeat(1));
        }

        [TestMethod()]
        public void UpdateSeatTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteSeatTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateTicketTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTicketTest()
        {
            Assert.IsNotNull(service.GetTicket(1));
        }

        [TestMethod()]
        public void UpdateTicketTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTicketTest()
        {
            Assert.Fail();
        }
    }
}