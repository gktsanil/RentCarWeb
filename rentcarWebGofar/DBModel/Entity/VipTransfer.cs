using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class VipTransfer
    {
        [Key]
        public int TransferID { get; set; }
        public string Type { get; set; }
        public Decimal PricePerKM { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public int CarPersonCount { get; set; }
        public Decimal DriverRate { get; set; }
        public string CarImage { get; set; }
    }
}