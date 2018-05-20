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
    }
}