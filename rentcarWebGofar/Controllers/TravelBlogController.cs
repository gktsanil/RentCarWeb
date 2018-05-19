using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rentcarWebGofar.Controllers
{
    public class TravelBlogController : Controller
    {
        // GET: TravelBlog
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: TravelBlog Detail
        public ActionResult BlogDetail()
        {
            return View();
        }
    }
}