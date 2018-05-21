using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace rentcarWebGofar.DBModel.Entity
{
    public class Message
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID { get; set; }
        public int SessionID { get; set; }
        public DateTime MessageDate { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public Boolean MessageStatus { get; set; }
        public string MessageText { get; set; }

        public virtual User User { get; set; }
    }
}