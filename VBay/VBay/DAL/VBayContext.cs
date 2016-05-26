using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VBay.Models;

namespace VBay.DAL
{
    public class VBayContext : DbContext
    {
        //typically Entity set (DbSet) corresponds to a DB Table
        public DbSet<User> Users { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Post> Posts { get; set; }

        //Keeps from naming Tables "Users" rather than "User"
        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }


}