using ForumDomain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumDataAccess
{
    public class ForumDbContext : IdentityDbContext<User>
    {
        public ForumDbContext(DbContextOptions options)
           : base(options) { }

        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostReplaies { get; set; }


        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
               .HasMany(u => u.Forums)
               .WithOne(o => o.User)
               .HasForeignKey(o => o.UserId)
               .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
               .HasMany(u => u.Posts)
               .WithOne(o => o.User)
               .HasForeignKey(o => o.UserId)
               .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
               .HasMany(u => u.PostReplays)
               .WithOne(o => o.User)
               .HasForeignKey(o => o.UserId)
               .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Forum>()
               .HasMany(u => u.Posts)
               .WithOne(o => o.Forum)
               .HasForeignKey(o => o.ForumId)
               .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Post>()
               .HasMany(u => u.Replies)
               .WithOne(o => o.Post)
               .HasForeignKey(o => o.PostId)
               .OnDelete(DeleteBehavior.SetNull);


            //Generate Ids for each Role
            string adminRoleId = Guid.NewGuid().ToString();
            string customerRoleId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Id = adminRoleId,
                   Name = "admin",
                   NormalizedName = "ADMIN"
               },
               new IdentityRole
               {
                   Id = customerRoleId,
                   Name = "customer",
                   NormalizedName = "CUSTOMER"
               }
           );

            //Generate Ids for each User
            string bobUserId = Guid.NewGuid().ToString();
            string aleksUserId = Guid.NewGuid().ToString();

            //Generate a hasher, we need this hasher to hash our password in the database
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>()
           .HasData(
         new User()
         {
             Id = bobUserId,
             FirstName = "Bob",
             LastName = "Bobsky",
             UserName = "Boby",
             NormalizedUserName = "BOBY",
             Email = "bob@gmail.com",
             NormalizedEmail = "BOB@GMAIL.COM",
             EmailConfirmed = true,
             PasswordHash = hasher.HashPassword(null, "ananas"),
             SecurityStamp = string.Empty
         },
         new User()
         {
             Id = aleksUserId,
             FirstName = "Aleksandar",
             LastName = "Veljanovski",
             UserName = "Aleks",
             NormalizedUserName = "ALEKS",
             Email = "alek88@gmail.com",
             NormalizedEmail = "ALEK88@GMAIL.COM",
             EmailConfirmed = true,
             PasswordHash = hasher.HashPassword(null, "alek789"),
             SecurityStamp = string.Empty
         }
         );


            //Seeding UserRoles, assigning a Role for each User
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>
               {
                   RoleId = adminRoleId,
                   UserId = bobUserId
               },
               new IdentityUserRole<string>
               {
                   RoleId = customerRoleId,
                   UserId = aleksUserId
               }
           );

            modelBuilder.Entity<Forum>()
              .HasData(
                new Forum()
                {
                    Id = 1,
                    Title = "Pyton",
                    Description = "Python is an interpreted, high-level, general-purpose programming language.",
                    Created = DateTime.Now,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/1200px-Python-logo-notext.svg.png",
                    UserId = bobUserId
                },
                new Forum()
                {
                    Id = 2,
                    Title = "React.js",
                    Description = "ReactJS is an open-source JavaScript library which is used for building user interfaces specifically for single page applications.",
                    Created = DateTime.Now,
                    ImageUrl = "https://cdn.worldvectorlogo.com/logos/react.svg",
                    UserId = bobUserId

                }
                );
            modelBuilder.Entity<Post>()
              .HasData(
                new Post
                {
                    Id =1,
                    Title = "Is it easy to learn Python?",
                    Content = "What is the best way to learn Python by myself? Are there any recommended websites/forums and textbooks?",
                    Created = DateTime.Now,
                    ForumId = 1,
                    UserId = bobUserId
                }
                );
            modelBuilder.Entity<Post>()
              .HasData(
                new Post
                {
                    Id = 2,
                    Title = "Is Python worth learning 2019?",
                    Content = "I’ve been working with javascript for a while now and I’m comfortable with it. I like all the libraries and flexibility that I have with it. I want to eventually start messing around with another language like Python or even Java but I’m not really seeing much of what something like python adds that I can’t really already do in javascript.Can someone explain to this noob why I should start learning Python (or Java)?",
                    Created = DateTime.Now,
                    ForumId = 1,
                    UserId = aleksUserId
                }
                );
        }

    }

   
}
