using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking.Web.Models
{
    public class BookingViewModel
    {
        public int FromDestination { get; set; }
        public int ToDestination { get; set; }
        public int Departure { get; set; }
        public int Customer { get; set; }

        public IEnumerable<Destination> Destinations { get; set; }
        public IEnumerable<Departure> Departures { get; set; }

        public BookingViewModel()
        {
            Destinations = new List<Destination>();
            Departures = new List<Departure>();
        }
    }
}