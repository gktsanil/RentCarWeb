using rentcarWebGofar.DBModel.Context;
using rentcarWebGofar.DBModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rentcarWebGofar.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(string email, string password)
        {
            ProjectContext cntx = new ProjectContext();
            User user = new User();// make object of table
            user.UserEmail = email;
            user.UserPassword = password;
            user.UserType = false;
            user.UserID = 0;

            /*
            msg.MessageText = "Merhaba Dünya";
            msg.MessageDate = DateTime.Now;
            msg.SenderID = 1;
            msg.ReceiverID = 2;
            msg.MessageStatus = true;
            */
            cntx.Users.Add(user);
            cntx.SaveChanges();

            return View();
        }
    }
}