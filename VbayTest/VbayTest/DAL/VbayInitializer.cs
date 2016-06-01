using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VbayTest.Models;

namespace VbayTest.DAL
{
    public class VbayInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<VbayContext>
    {
        protected override void Seed(VbayContext context)
        {
            var ads = new List<Ad>
            {
                new Ad {Headline = "Books", Description = "Books for sale", Price = 10, DatePosted = DateTime.Today, UserID = 1 },
                new Ad {Headline = "Tv", Description = "Tv for sale", Price = 100, DatePosted = DateTime.Today, UserID = 2 },
                new Ad {Headline = "Furniture", Description = "furniture for sale", Price = 200, DatePosted = DateTime.Today, UserID = 3 },
                new Ad {Headline = "Clothes", Description = "Clothes for free", Price = 0, DatePosted = DateTime.Today, UserID = 1 },
                new Ad {Headline = "Bike", Description = "bicycle for sale", Price = 50, DatePosted = DateTime.Today, UserID = 2 }
            };
            ads.ForEach(a => context.Ads.Add(a));
            context.SaveChanges();

            var users = new List<User>{
                new User { FirstName = "Greg", LastName = "Flynn", Department = "IT", Email = "gflynn@volusia.org", Phone = "3864141602" },
                new User { FirstName = "Alyssa", LastName = "Reynolds", Department = "HR", Email = "areynolds@volusia.org", Phone = "3864141603" },
                new User { FirstName = "Jim", LastName = "Reynolds", Department = "HR", Email = "jreynolds@volusia.org", Phone = "3864141604" }
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}
