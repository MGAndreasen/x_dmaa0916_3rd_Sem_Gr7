using Booking.Web.Helpers;
using Booking.Web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Booking.Web.Controllers
{
    public class AfgangeController : Controller
    {
        // GET: Afgange
        public ActionResult Index()
        {
            return RedirectToAction("SelectDestination", "Afgange");
        }

        // Layout View
        [HttpGet]
        public ActionResult SelectDestination()
        {
            // Opret ny model, eller henter nuværende model fra session.
            BookingViewModel Bookingvm = GetBookingViewModel();

            List<Destination> Destinations = new List<Destination>();
            List<Departure> Departures = new List<Departure>();

            ViewBag.Message = "Book a flight";

            // Snup modellen fra Sessionen hvis vi har været igang allerede...
            if (Session["BookingModel"] == null)
            {
                Bookingvm = new BookingViewModel();
            }
            else
            {
                Bookingvm = (BookingViewModel)Session["BookingModel"];
            }


            try
            {
                var client = ServiceHelper.GetServiceClient();
                ViewBag.proxy = client;
                ViewBag.proxyError = "";

                var DestResult = client.GetAllDestinations();

                foreach (var d in DestResult)
                {
                    Destinations.Add(new Destination { Id = d.Id, Name = d.NameDestination });
                }

                // Set Aalborg defaults
                if (Bookingvm.FromDestination == 0)
                {
                    // Fra Aalborg
                    Bookingvm.FromDestination = Destinations.SingleOrDefault(x => x.Name == "Aalborg").Id;

                    // Til noget vi ved har lidt data på sig!
                    Bookingvm.ToDestination = Destinations.SingleOrDefault(x => x.Name == "Nuuk").Id;

                    // Hent evt. Departures
                    var DeptResult = client.GetAllDeparturesFromTo(Bookingvm.FromDestination, Bookingvm.ToDestination);

                    foreach (var d in DeptResult)
                    {
                        Departures.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                    }

                    Bookingvm.Departures = Departures;
                }

                Bookingvm.Destinations = Destinations;
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            return View(Bookingvm);
        }

        // POST View
        [HttpPost]
        public ActionResult SelectDestination(BookingViewModel Bookingvm)
        {
            List<Destination> Destinations = new List<Destination>();
            List<Departure> Departures = new List<Departure>();

            //ViewBag.Message = "Vælge afgang";

            try
            {
                var client = ServiceHelper.GetServiceClient();
                ViewBag.Proxy = client;
                ViewBag.Error = "";

                var DestResult = client.GetAllDestinations();

                foreach (var d in DestResult)
                {
                    Destinations.Add(new Destination { Id = d.Id, Name = d.NameDestination });
                }

                var DeptResult = client.GetAllDeparturesFromTo(Bookingvm.FromDestination, Bookingvm.ToDestination);
                foreach (var d in DeptResult)
                {
                    Departures.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                }

                Bookingvm.Destinations = Destinations;
                Bookingvm.Departures = Departures;


                // Valider Datoer
                DateTime OneWayDate;
                DateTime ReturnDate;

                if (!DateTime.TryParseExact(Bookingvm.OneWayDate, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out OneWayDate))
                {
                    Bookingvm.OneWayDate = "";
                }

                if (!DateTime.TryParseExact(Bookingvm.ReturnDate, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out ReturnDate))
                {
                    Bookingvm.ReturnDate = "";
                }

                if (Bookingvm.OneWay)
                {
                    Bookingvm.ReturnDate = "";
                }
                else
                {
                    if (Bookingvm.OneWayDate != "" && Bookingvm.ReturnDate != "")
                    {
                        if (OneWayDate > ReturnDate)
                        {
                            Bookingvm.ReturnDate = "";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
            }

            Session["BookingModel"] = Bookingvm;

            return RedirectToAction("SelectDestination", "Afgange");
        }

        // Partial Views
        public ActionResult SelectDeparture()
        {
            BookingViewModel Bookingvm = null;
            List<Destination> Destinations = new List<Destination>();
            ViewBag.Message = "Book a flight";


            // Snup modellen fra Sessionen hvis vi har været igang allerede...
            if (Session["BookingModel"] == null)
            {
                Bookingvm = new BookingViewModel();
            }
            else
            {
                Bookingvm = (BookingViewModel)Session["BookingModel"];
            }


            try
            {
                var client = ServiceHelper.GetServiceClient();
                ViewBag.proxy = client;
                ViewBag.proxyError = "";

                var DestResult = client.GetAllDestinations();

                foreach (var d in DestResult)
                {
                    Destinations.Add(new Destination { Id = d.Id, Name = d.NameDestination });
                }


                // Set Aalborg defaults
                if (Bookingvm.FromDestination == 0)
                {
                    // Fra Aalborg
                    Bookingvm.FromDestination = Destinations.SingleOrDefault(x => x.Name == "Aalborg").Id;

                    // Til noget vi ved har lidt data på sig!
                    Bookingvm.ToDestination = Destinations.SingleOrDefault(x => x.Name == "Nuuk").Id;
                }

                Bookingvm.Destinations = Destinations;
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            return View(Bookingvm);
        }


        // Helper funktioner
        private BookingViewModel GetBookingViewModel()
        {
            BookingViewModel Bookingvm = null;

            // Snup modellen fra Sessionen hvis vi har været igang allerede...
            if (Session["BookingModel"] == null)
            {
                Bookingvm = new BookingViewModel();
            }
            else
            {
                Bookingvm = (BookingViewModel)Session["BookingModel"];
            }

            return Bookingvm;
        }
    }
}