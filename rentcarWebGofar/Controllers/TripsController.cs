using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rentcarWebGofar.Controllers
{
    public class TripsController : Controller
    {
        // GET: Trips
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: TripDetail
        public ActionResult TripDetail()
        {
            return View();
        }
    }
}