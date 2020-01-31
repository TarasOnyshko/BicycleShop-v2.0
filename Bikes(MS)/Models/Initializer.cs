using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Bikes_MS_.Models
{
    public class Initializer : DropCreateDatabaseAlways<Bike_context>
    {
        protected override void Seed(Bike_context db)
        {
            db.Bikes.Add(new Bike { Name = "Aventon", Price = 8000, Speed = 60, Weight = 8.6 });
            db.Bikes.Add(new Bike { Name = "Peugeot", Price = 3500, Speed = 65, Weight = 12 });
            db.Bikes.Add(new Bike { Name = "Bianchi", Price = 1200, Speed = 68, Weight = 7.8 });
            db.Bikes.Add(new Bike { Name = "Look", Price = 9000, Speed = 70, Weight = 10 });
            db.Bikes.Add(new Bike { Name = "Scott", Price = 15000, Speed = 64, Weight = 9 });
            db.Bikes.Add(new Bike { Name = "Azimut", Price = 9700, Speed = 55, Weight = 14 });
            base.Seed(db);
        }
    }
}