using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rentcarWebGofar.Controllers
{
    public class RentCarController : Controller
    {
        // GET: RentCar
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: RentCar Detail
        public ActionResult RentCarDetail()
        {
            return View();
        }
    }
}