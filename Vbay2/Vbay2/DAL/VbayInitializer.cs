using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vbay2.Models;

namespace Vbay2.DAL
{
    public class VbayInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<VbayContext>
    {
        protected override void Seed(VbayContext context)
        {
            var users = new List<User>
            {
                new User {FirstName = "Greg", LastName = "Flynn", Department  = "IT" , Email = "gflynn@volusia.org" },
                new User {FirstName = "Alyssa", LastName = "Reynolds", Department  = "HR" , Email = "areynolds@volusia.org" },
                new User {FirstName = "Charles", LastName = "Jenkins", Department  = "PR" , Email = "cjenkins@volusia.org" }
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var ads = new List<Ad>
            {
                new Ad {Headline = "Cat", Description ="Cats for free", Price = 0, DatePosted = DateTime.Today },
                new Ad {Headline = "Dog", Description ="Giving away Puppies", Price = 0, DatePosted = DateTime.Today },
                new Ad {Headline = "Books", Description ="Selling My boook Collection", Price = 25, DatePosted = DateTime.Today },
                new Ad {Headline = "Tv", Description ="plasma screen tv for sale", Price = 150, DatePosted = DateTime.Today },
                new Ad {Headline = "Radio", Description ="Radio for sale with records", Price = 50, DatePosted = DateTime.Today },
                new Ad {Headline = "Car", Description ="Car for parts", Price = 600, DatePosted = DateTime.Today }
            };
            ads.ForEach(a => context.Ads.Add(a));
            context.SaveChanges();

            var posts = new List<Post>
            {
                new Post {UserID = 1, AdID = 3, Approved = true },
                new Post {UserID = 1, AdID = 1, Approved = true },
                new Post {UserID = 2, AdID = 4, Approved = false },
                new Post {UserID = 2, AdID = 6, Approved = false },
                new Post { UserID = 3, AdID = 2},
                new Post {UserID = 3, AdID = 5 }
            };
            posts.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();
        }
    }
}