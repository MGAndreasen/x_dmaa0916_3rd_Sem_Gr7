using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Booking.Web.BookingServiceRemote;

namespace Booking.Web.Models
{
    public class BookingViewModel
    {
        [Required(ErrorMessage = "Please select Origion.")]
        public int FromDestination { get; set; }

        [Required(ErrorMessage = "Please select Destination.")]
        public int ToDestination { get; set; }

        public bool OneWay { get; set; }

        //[Required(ErrorMessage = "Please select a departure.")]
        public int Departure { get; set; }

        public int Customer { get; set; }

        public string ReturnDate { get; set; }
        public string OneWayDate { get; set; }

        public List<Passenger> Passengers { get; set; }
        public IEnumerable<Destination> Destinations { get; set; }
        public IEnumerable<Departure> Departures { get; set; }

        public BookingViewModel()
        {
            Passengers = new List<Passenger>();
            Destinations = new List<Destination>();
            Departures = new List<Departure>();

            // Add default Passenger
            Passengers.Add(new Passenger());
            Passengers.Add(new Passenger());
            Passengers.Add(new Passenger());
            Passengers[0].FirstName = "Tester";
            Passengers[0].LastName = "Man";

            Passengers[1].FirstName = "Tester2";
            Passengers[1].LastName = "Man2";

            Passengers[2].FirstName = "Tester3";
            Passengers[2].LastName = "Man3";
        }
    }
}