using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VBay2.Models;

namespace VBay2.DAL
{
    public class VBayInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<VBayContext>
    {
        protected override void Seed(VBayContext context)
        {
            var ads = new List<Ad>
            {
                new Ad {Headline = "Books", Description = "Books For Sale", Price = 10, DatePosted = DateTime.Today },
                new Ad {Headline = "Tv", Description = "Tv For Sale", Price = 20, DatePosted = DateTime.Today },
                new Ad {Headline = "Movies", Description = "Movies For Sale", Price = 50, DatePosted = DateTime.Today },
                new Ad {Headline = "Furniture", Description = "Furniture For Sale", Price = 100, DatePosted = DateTime.Today },
                new Ad {Headline = "Cat", Description = "Free Cat", Price = 0, DatePosted = DateTime.Today },
                new Ad {Headline = "Dog", Description = "Free Dog", Price = 0, DatePosted = DateTime.Today },
                new Ad {Headline = "Clothes", Description = "Clothes For Donation", Price = 0, DatePosted = DateTime.Today },
                new Ad {Headline = "DVDs", Description = "Dvds For Sale", Price = 30, DatePosted = DateTime.Today }
            };
            ads.ForEach(a => context.Ads.Add(a));
            context.SaveChanges();

            var users = new List<User>
            {
                new User {FirstName = "Greg", LastName = "Flynn", Department = "IT", Email = "gflynn@volusia.org", Phone = "3867778866" },
                new User {FirstName = "Jim", LastName = "Reynolds", Department = "HR", Email = "jreynolds@volusia.org", Phone = "3867778860" },
                new User {FirstName = "Alyssa", LastName = "Reynolds", Department = "HR", Email = "areynolds@volusia.org", Phone = "3867778869" },
                new User {FirstName = "Scot", LastName = "Roundfield", Department = "CT", Email = "sroundfield@volusia.org", Phone = "3867778865" },
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}