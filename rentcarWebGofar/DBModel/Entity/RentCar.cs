using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rentcarWebGofar.DBModel.Entity
{
    public class RentCar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarID { get; set; }
        public int CompanyID { get; set; }
        public string CompanyDescriptions { get; set; }
    }
}