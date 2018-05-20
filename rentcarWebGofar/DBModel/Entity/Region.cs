using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class Region
    {
        [Key]
        public int RegionID { get; set; }
        public int CityID { get; set; }
        public string RegionName { get; set; }
    }
}