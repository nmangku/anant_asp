using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace BookStore.Models
{
    public class StoreDbContext : DbContext
    {

        public StoreDbContext() : base("BookStore")
        {

        }

        public DbSet<Book> books { get; set; }

        public System.Data.Entity.DbSet<BookStore.Models.Location> Locations { get; set; }

    }
}