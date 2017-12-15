using Booking.Web.Helpers;
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
            ViewBag.Message = "Book a flight";

            try
            {
                var client = ServiceHelper.GetServiceClient();
                ViewBag.proxy = client;
                ViewBag.proxyError = "";
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            return View();
        }


       // [HttpGet]
        public ActionResult SearchResult()
        {
            try
            {
                var client = ServiceHelper.GetServiceClient();
                ViewBag.Proxy = client;
                ViewBag.Error = "";

            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.ToString();
            }
            return View();
        }

    }
}