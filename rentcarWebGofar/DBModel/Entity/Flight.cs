using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class Flight
    {
        [Key]
        public int FlightID { get; set; }
        public DateTime FlightTime { get; set; }
        public int LandingCity { get; set; }
        public int DepartureCity { get; set; }
        public int FlightNumber { get; set; }
        public int FlightCompanyID { get; set; }
    }
}