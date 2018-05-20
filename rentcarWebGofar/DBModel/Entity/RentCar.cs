using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class RentCar
    {
        [Key]
        public int CarID { get; set; }
        public int CompanyID { get; set; }
        public string CompanyDescriptions { get; set; }
    }
}