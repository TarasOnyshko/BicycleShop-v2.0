using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Bikes_MS_.Models
{
    public class Bike_context : DbContext
    {

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public static Bike_context Create()
        {
            return new Bike_context();
        }

        
        public Bike find(string id)
        {
            return this.Bikes.Single(p => p.Id.Equals(id));
        }
    }
}