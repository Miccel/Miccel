using Miccel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Miccel.Context
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("DbTutorial") { }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<MemberShipType> MembershipType { get; set; }
    }
}