using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VBay2.Models;

namespace VBay2.DAL
{
    public class VBayContext : DbContext
    {
        public VBayContext() : base("VBayContext")
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