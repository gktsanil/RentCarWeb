using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public int CompanyID { get; set; }
        public int CustomerID { get; set; }
        public Decimal InvoiceAmount { get; set; }
        public Boolean InvoiceType { get; set; }
        public int PaymentType { get; set; }
    }
}