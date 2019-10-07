using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.mvc.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
    }

    public class RestaurantDbContext: DbContext  //making a table in our database to store this data
    {
        public DbSet<Restaurant> Restaurants { get; set; }  //this class is making a connection to the database. Entity is info stored in your database.
    }
}