using Booking.Web.Helpers;
using Booking.Web.Models;
using System;
using System.Collections.Generic;
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

        public ActionResult SelectDestination()
        {
            BookingViewModel Bookingvm = null;

            if (Session["BookingModel"] == null)
            {
                Bookingvm = new BookingViewModel();
            }
            else
            {
                Bookingvm = (BookingViewModel)Session["BookingModel"];
            }

            List<Destination> Destinations = new List<Destination>();

            ViewBag.Message = "Book a flight";

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

                Bookingvm.Destinations = Destinations;
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            return View(Bookingvm);
        }


        [HttpPost]
        public ActionResult SelectDestination(BookingViewModel Bookingvm)
        {
            List<Destination> Destinations = new List<Destination>();
            List<Departure> Departures = new List<Departure>();

            ViewBag.Message = "Vælge afgang";

            try
            {
                var client = ServiceHelper.GetServiceClient();
                ViewBag.Proxy = client;
                ViewBag.Error = "";

                var DestResult = client.GetAllDestinations();
                var DeptResult = client.GetAllDeparturesFromTo(Bookingvm.FromDestination, Bookingvm.ToDestination);

                foreach (var d in DestResult)
                {
                    Destinations.Add(new Destination { Id = d.Id, Name = d.NameDestination });
                }

                foreach (var d in DeptResult)
                {
                    Departures.Add(new Departure { Id = d.Id, When = d.DepartureTime });
                }

                Bookingvm.Destinations = Destinations;
                Bookingvm.Departures = Departures;
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
            }

            Session["BookingModel"] = Bookingvm;

            return RedirectToAction("SelectDestination", "Afgange");
        }

    }
}