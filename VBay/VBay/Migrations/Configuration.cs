namespace VBay.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VBay.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VBay.DAL.VBayContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VBay.DAL.VBayContext context)
        {
            var users = new List<User>
            {
                new User {FirstName = "Greg", LastName = "Flynn", Email = "gflynn@volusia.org", Department = "IT", Phone = "3867778899" },
                new User {FirstName = "Alyssa", LastName = "Reynolds", Email = "areynolds@volusia.org", Department = "HR", Phone = "3869994433" },
                new User {FirstName = "Joe", LastName = "Shmit", Email = "jshmit@volusia.org", Department = "DOT", Phone = "4075559966" }
            };
            users.ForEach(u => context.Users.AddOrUpdate(p => p.Email, u));
            context.SaveChanges();

            var ads = new List<Ad>
            {
                new Ad {Headline = "Books", Description = "I Have Books For Sale", Price = 9M, Date = DateTime.Today },
                new Ad {Headline = "Television", Description = "Tv For Sale", Price = 100M, Date = DateTime.Today },
                new Ad {Headline= "Clothes", Description ="Free clothes", Price = 0M, Date = DateTime.Today },
                new Ad {Headline = "Shoes", Description = "Shoes for sale", Price = 50M, Date = DateTime.Today }
            };
            ads.ForEach(u => context.Ads.AddOrUpdate(a => a.Headline, u));
            context.SaveChanges();

            var posts = new List<Post>
            {
                new Post {
                    UserId = users.Single(u => u.Email == "gflynn@volusia.org").UserId,
                    AdId = ads.Single(a => a.Headline == "Books").AdId
                },
                new Post
                {
                    UserId = users.Single(u => u.Email == "gflynn@volusia.org").UserId,
                    AdId = ads.Single(a => a.Headline == "Television").AdId
                },
                new Post
                {
                    UserId = users.Single (u => u.Email == "areynolds@volusia.org").UserId,
                    AdId = ads.Single(a => a.Headline == "Clothes").AdId
                },
                new Post
                {
                    UserId = users.Single(u => u.Email == "jshmit@volusia.org").UserId,
                    AdId = ads.Single(a => a.Headline == "Shoes").AdId
                }
            };
            //seed methods runs after every migration. so we dont want to duplicated data
            //We check if it is in the DB before adding
            foreach(Post p in posts)
            {
                var postInDatabase = context.Posts.Where(
                    s =>
                        s.User.UserId == p.UserId &&
                        s.Ad.AdId == p.AdId).SingleOrDefault();
                if(postInDatabase == null)
                {
                    context.Posts.Add(p);
                }
            }
            context.SaveChanges();
        }
    }
}
