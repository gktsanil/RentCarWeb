using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public int TownID { get; set; }
        public Decimal HotelRating { get; set; }
        public string MainCurrency { get; set; }
        public string HotelImage { get; set; }
        public string HotelPhoneNumber { get; set; }
        public string HotemEmail { get; set; }
        public int HotelStars { get; set; }
    }
}