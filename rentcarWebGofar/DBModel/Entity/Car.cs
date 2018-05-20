using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace rentcarWebGofar.DBModel.Entity
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public string CarSegment { get; set; }
        public string CarGearType { get; set; }
    }
}