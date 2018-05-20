using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rentcarWebGofar.Controllers.Panel
{
    public class InvoiceController : Controller
    {
        // GET: Invoice Incoming
        public ActionResult Incoming()
        {
            return View();
        }
        
        // GET: Invoice Outgoing
        public ActionResult Outgoing()
        {
            return View();
        }
        
        // GET: Invoice Canceled
        public ActionResult Canceled()
        {
            return View();
        }
        
        // GET: Invoice Page
        public ActionResult ShowInvoice()
        {
            return View();
        }
    }
}