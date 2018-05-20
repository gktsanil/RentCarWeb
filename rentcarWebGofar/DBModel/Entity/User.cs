using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class User
    {
        [Key]
        public string UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserSurName { get; set; }
        public string UserPassword { get; set; }
        public Boolean UserType { get; set; }


        /*public virtual List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

        public CustomerDemographic()
        {
            this.CustomerCustomerDemos = new List<CustomerCustomerDemo>();
        }
        */
    }
}