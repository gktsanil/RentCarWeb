using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using rentcarWebGofar.DBModel.Entity;

namespace rentcarWebGofar.DBModel.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<VipTransfer> VipTransfers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<CityTour> CityTours { get; set; }
        public DbSet<RentCar> RentCars { get; set; }
    }
}