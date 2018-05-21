using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace rentcarWebGofar.DBModel.Entity
{
    public class Ticket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicektID { get; set; }
        public Boolean TicketStatus { get; set; }
        public int SenderID { get; set; }
        public DateTime TicketDate { get; set; }
        public string TicketType { get; set; }


        public virtual User User { get; set; }
    }
}