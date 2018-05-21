using rentcarWebGofar.DBModel.Context;
using rentcarWebGofar.DBModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rentcarWebGofar.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Dashboard()
        {
            ProjectContext cntx = new ProjectContext();
            Message msg = new Message();// make object of table
            msg.MessageText = "Merhaba Dünya";
            msg.MessageDate = DateTime.Now;
            msg.SenderID = 1;
            msg.ReceiverID = 2;
            msg.MessageStatus = true;

            cntx.Messages.Add(msg);
            cntx.SaveChanges();

            return View();
        }
    }
}