using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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

        public IEnumerable<Destination> Destinations { get; set; }
        public IEnumerable<Departure> Departures { get; set; }

        public BookingViewModel()
        {
            Destinations = new List<Destination>();
            Departures = new List<Departure>();
        }
    }
}