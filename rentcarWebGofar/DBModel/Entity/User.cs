using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rentcarWebGofar.DBModel.Entity
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserEmail { get; set; }
        public int UserNumber { get; set; }
        public string UserSurName { get; set; }
        public string UserPassword { get; set; }
        public Boolean UserType { get; set; }


        /*public virtual List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

        public CustomerDemographic()
        {
            this.CustomerCustomerDemos = new List<CustomerCustomerDemo>();
        }
        */

        public virtual List<Message> Messages { get; set; }
        public virtual List<Ticket> Tickets { get; set; }

        public User()
        {
            this.Messages = new List<Message>();
            this.Tickets = new List<Ticket>();
        }
    }
}