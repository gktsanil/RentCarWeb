using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public int CountryID { get; set; }
        public string CityName { get; set; }
    }
}