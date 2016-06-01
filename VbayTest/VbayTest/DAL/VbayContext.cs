using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VbayTest.Models;


namespace VbayTest.DAL
{
    public class VbayContext : DbContext
    {
        public VbayContext() : base("VbayContext")
        {
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}