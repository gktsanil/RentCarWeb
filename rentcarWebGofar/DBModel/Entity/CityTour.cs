using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class CityTour
    {
        [Key]
        public int TourID { get; set; }
        public string TourImage { get; set; }
        public string TourDescriptions { get; set; }
        public Decimal TourPrice { get; set; }
        public int TourType { get; set; }
    }
}