using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class Town
    {
        [Key]
        public int TownID { get; set; }
        public int CityID { get; set; }
        public string TownName { get; set; }

        public virtual City City { get; set; }
    }
}