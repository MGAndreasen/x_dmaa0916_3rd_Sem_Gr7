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
        public int DepartureReturn { get; set; }
           
        public int Customer { get; set; }

        public string ReturnDate { get; set; }
        public string OneWayDate { get; set; }

        public int numOfPassengers { get; set; }
        public List<numPassenger> numPassengersList { get; set; }
        public List<Passenger> Passengers { get; set; }
        public IEnumerable<Destination> Destinations { get; set; }
        public IEnumerable<Departure> Departures { get; set; }
        public IEnumerable<Departure> Returns { get; set; }

        public BookingViewModel()
        {
            Passengers = new List<Passenger>();
            Destinations = new List<Destination>();
            Departures = new List<Departure>();
            Returns = new List<Departure>();
            numPassengersList = new List<numPassenger>();
            numOfPassengers = 1;

            OneWayDate = "";
            ReturnDate = "";

            // Add default Passenger
            Passengers.Add(new Passenger());
            //Passengers.Add(new Passenger());
            //Passengers.Add(new Passenger());
            //Passengers[0].FirstName = "Tester";
            //Passengers[0].LastName = "Man";

            //Passengers[1].FirstName = "Tester2";
            //Passengers[1].LastName = "Man2";

            //Passengers[2].FirstName = "Tester3";
            //Passengers[2].LastName = "Man3";

            numPassengersList.Add(new numPassenger { num = 1, display = "1 Passenger" });
            numPassengersList.Add(new numPassenger { num = 2, display = "2 Passenger" });
            numPassengersList.Add(new numPassenger { num = 3, display = "3 Passenger" });
            numPassengersList.Add(new numPassenger { num = 4, display = "4 Passenger" });
            numPassengersList.Add(new numPassenger { num = 5, display = "5 Passenger" });
            numPassengersList.Add(new numPassenger { num = 6, display = "6 Passenger" });
            numPassengersList.Add(new numPassenger { num = 7, display = "7 Passenger" });
            numPassengersList.Add(new numPassenger { num = 8, display = "8 Passenger" });
            numPassengersList.Add(new numPassenger { num = 9, display = "9 Passenger" });


            OneWay = false;
        }
    }
}