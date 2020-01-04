using ForumDomain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public DbSet<Thread> Threads { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostReplaies { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


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

            modelBuilder.Entity<Thread>()
               .HasMany(u => u.Posts)
               .WithOne(o => o.Thread)
               .HasForeignKey(o => o.ThreadId)
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
             PasswordHash = hasher.HashPassword(null, "Bob123456"),
             SecurityStamp = string.Empty,
             Joined = DateTime.Now
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
             PasswordHash = hasher.HashPassword(null, "Alek7891011"),
             SecurityStamp = string.Empty,
             Joined = DateTime.Now
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
            modelBuilder.Entity<Category>().HasData(
                  new Category
                  {
                      Id = 1,
                      Title = "Software",
                      ImageUrl = "https://www.cbronline.com/wp-content/uploads/2017/06/What-Your-Business-Needs-To-Resolve-Tech-And-Software-Problems.jpg"
                  },
                  new Category
                  {
                      Id = 2,
                      Title = "Games",
                      ImageUrl = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fblogs-images.forbes.com%2Fforbes-finds%2Ffiles%2F2019%2F04%2Fmariokart8-1200x675.jpg"
                  },
                  new Category
                  {
                      Id = 3,
                      Title = "News",
                      ImageUrl = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fblogs-images.forbes.com%2Fallbusiness%2Ffiles%2F2018%2F10%2Fmachine-learning-1200x808.jpg"
                  }
              );

            modelBuilder.Entity<Thread>()
              .HasData(
                new Thread()
                {
                    Id = 1,
                    Title = "Best Free AV",
                    Created = DateTime.Now,
                    ImageUrl = "https://ksassets.timeincuk.net/wp/uploads/sites/54/2019/06/best-free-antivirus-trusted-reviews-920x518.jpg",
                    CategoryId = 1
                },
                new Thread()
                {
                    Id = 2,
                    Title = "New version of FireFox is released",
                    Created = DateTime.Now,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Firefox_Logo%2C_2017.svg/1200px-Firefox_Logo%2C_2017.svg.png",
                    CategoryId = 3

                },
                 new Thread
                 {
                     Id = 3,
                     Title = "The best FPS game in 2019",
                     Created = DateTime.Now,
                     ImageUrl = "https://ksassets.timeincuk.net/wp/uploads/sites/54/2019/01/Best-FPS-Games-920x613.jpg",
                     CategoryId = 2
                 }
                );
            modelBuilder.Entity<Post>()
              .HasData(
                new Post
                {
                    Id =1,
                    Content = "The best free antivirus is Kespersky Cloud Free",
                    Created = DateTime.Now,
                    ThreadId = 1,
                    UserId = bobUserId
                }
                );
            modelBuilder.Entity<Post>()
              .HasData(
                new Post
                {
                    Id = 2,
                    Content = "Avast is another good free antivirus",
                    Created = DateTime.Now,
                    ThreadId = 1,
                    UserId = aleksUserId
                },
                new Post
                {
                    Id = 3,
                    ThreadId = 2,
                    Content = "I hope they've pathed some of the security holes",
                    Created = DateTime.Now,
                    UserId = bobUserId
                },
                    new Post
                    {
                        Id = 4,
                        ThreadId = 3,
                        Content = "Call of Duty: Modern Warfare is the best one so far.",
                        Created = DateTime.Now,
                        UserId = aleksUserId
                    }
                );
        }

    }

   
}
