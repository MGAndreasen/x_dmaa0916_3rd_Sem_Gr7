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
            List<Departure> Returns = new List<Departure>();

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
                    Bookingvm.ToDestination = Destinations.SingleOrDefault(x => x.Name == "Oslo").Id;
                }
                // Hent evt. Departures
                // Departures (from -> to)
                //if (Bookingvm.OneWayDate == "")
                //{
                    var DeptResult = client.GetAllDeparturesFromTo(Bookingvm.FromDestination, Bookingvm.ToDestination, DateTime.Now, DateTime.Now.AddDays(60));
                    foreach (var d in DeptResult)
                    {
                        Departures.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                    }
                //}
                //else
                //{
                //    DateTime dt = DateTime.ParseExact(Bookingvm.OneWayDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                //    var DeptResult = client.GetAllDeparturesFromTo(Bookingvm.FromDestination, Bookingvm.ToDestination, dt, dt.AddDays(60));
                //    foreach (var d in DeptResult)
                //    {
                //        Departures.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                //    }
                //}

                // Departures Retur (to -> from)
                //if (!Bookingvm.OneWay)
                //{
                    //if (Bookingvm.ReturnDate == "")
                    //{
                        var ReturnResult = client.GetAllDeparturesFromTo(Bookingvm.ToDestination, Bookingvm.FromDestination, DateTime.Now, DateTime.Now.AddDays(60));
                        foreach (var d in ReturnResult)
                        {
                            Returns.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                        }
                    //}
                    //else
                    //{
                    //    DateTime dt = DateTime.ParseExact(Bookingvm.ReturnDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    //    var ReturnResult = client.GetAllDeparturesFromTo(Bookingvm.ToDestination, Bookingvm.FromDestination, dt, dt.AddDays(60));
                    //    foreach (var d in ReturnResult)
                    //    {
                    //        Returns.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                    //    }
                    //}
                //}

                Bookingvm.Departures = Departures;
                Bookingvm.Returns = Returns;
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
            List<Departure> Returns = new List<Departure>();

            //ViewBag.Message = "Vælge afgang";

            try
            {
                var client = ServiceHelper.GetServiceClient();
                ViewBag.Proxy = client;
                ViewBag.Error = "";

                // Destinationer
                var DestResult = client.GetAllDestinations();
                foreach (var d in DestResult)
                {
                    Destinations.Add(new Destination { Id = d.Id, Name = d.NameDestination });
                }
                Bookingvm.Destinations = Destinations;

                // Valider Datoer
                DateTime OneWayDate;
                DateTime ReturnDate;

                if (!DateTime.TryParseExact(Bookingvm.OneWayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out OneWayDate))
                {
                    Bookingvm.OneWayDate = "";
                }

                if (!DateTime.TryParseExact(Bookingvm.ReturnDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out ReturnDate))
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


                // Departures (from -> to)
                if (Bookingvm.OneWayDate == "")
                {
                    var DeptResult = client.GetAllDeparturesFromTo(Bookingvm.FromDestination, Bookingvm.ToDestination, DateTime.Now, DateTime.Now.AddDays(60));
                    foreach (var d in DeptResult)
                    {
                        Departures.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                    }
                }
                else
                {
                    DateTime dt = DateTime.ParseExact(Bookingvm.OneWayDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    var DeptResult = client.GetAllDeparturesFromTo(Bookingvm.FromDestination, Bookingvm.ToDestination, dt, dt.AddDays(60));
                    foreach (var d in DeptResult)
                    {
                        Departures.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                    }
                }
                Bookingvm.Departures = Departures;


                // Departures Retur (to -> from)
                if (!Bookingvm.OneWay)
                {
                    if (Bookingvm.ReturnDate == "")
                    {
                        var ReturnResult = client.GetAllDeparturesFromTo(Bookingvm.ToDestination, Bookingvm.FromDestination, DateTime.Now, DateTime.Now.AddDays(60));
                        foreach (var d in ReturnResult)
                        {
                            Returns.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                        }
                    }
                    else
                    {
                        DateTime dt = DateTime.ParseExact(Bookingvm.ReturnDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        var ReturnResult = client.GetAllDeparturesFromTo(Bookingvm.ToDestination, Bookingvm.FromDestination, dt, dt.AddDays(60));
                        foreach (var d in ReturnResult)
                        {
                            Returns.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                        }
                    }
                }
                Bookingvm.Returns = Returns;

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