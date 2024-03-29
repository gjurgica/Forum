﻿using Forum.DomainClasses.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DataAccess
{
    public class ForumDbContext : IdentityDbContext<User>
    {
        public ForumDbContext(DbContextOptions options) : base(options){}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Category>()
                .HasMany(c => c.Threads)
                .WithOne(t => t.Category)
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Thread>()
                .HasMany(t => t.Posts)
                .WithOne(p => p.Thread)
                .HasForeignKey(p => p.ThreadId)
                .OnDelete(DeleteBehavior.Cascade);

            //Id's for roles
            string adminRole = Guid.NewGuid().ToString();
            string userRole = Guid.NewGuid().ToString();

            //Roles
            builder.Entity<IdentityRole>().HasData(
                    new IdentityRole
                    {
                        Id = adminRole,
                        Name = "ADMIN",
                        NormalizedName = "admin"
                    },
                    new IdentityRole
                    {
                        Id = userRole,
                        Name = "USER",
                        NormalizedName = "user"
                    }
                );

            //User id's
            string gaUserId = Guid.NewGuid().ToString();
            string fmUserId = Guid.NewGuid().ToString();
            string vpUserId = Guid.NewGuid().ToString();

            //Hasher
            var hasher = new PasswordHasher<User>();

            builder.Entity<User>().HasData(
                    new User
                    {
                        Id = gaUserId,
                        FullName = "Gjurgica Anastasovska",
                        UserName = "gjurgica",
                        NormalizedUserName = "GA",
                        Email = "ga@forum.com",
                        NormalizedEmail = "GA@FORUM.COM",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "*Admin123"),
                        SecurityStamp = string.Empty
                    },
                    new User
                    {
                        Id = fmUserId,
                        FullName = "Florent Memedi",
                        UserName = "florent",
                        NormalizedUserName = "FM",
                        Email = "fm@forum.com",
                        NormalizedEmail = "FM@FORUM.COM",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "*Florent123"),
                        SecurityStamp = string.Empty
                    },
                    new User
                    {
                        Id = vpUserId,
                        FullName = "Vladimir Prokopiev",
                        UserName = "vladimir",
                        NormalizedUserName = "VP",
                        Email = "vp@forum.com",
                        NormalizedEmail = "VP@FORUM.COM",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "*Vladimir123"),
                        SecurityStamp = string.Empty
                    }
                );

            //Category id's
            string softwareId = Guid.NewGuid().ToString();
            string gamesId = Guid.NewGuid().ToString();
            string newsId = Guid.NewGuid().ToString();

            builder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = softwareId,
                        Title = "Software"
                    },
                    new Category
                    {
                        Id = gamesId,
                        Title = "Games"
                    },
                    new Category
                    {
                        Id = newsId,
                        Title = "News"
                    }
                );

            string threadOneId = Guid.NewGuid().ToString();
            string threadTwoId = Guid.NewGuid().ToString();
            string threadThreeId = Guid.NewGuid().ToString();

            builder.Entity<Thread>().HasData(
                    new Thread
                    {
                        Id = threadOneId,
                        Title = "Best Free AV",
                        CategoryId = softwareId,
                        DateCreated = DateTime.UtcNow
                    },
                    new Thread
                    {
                        Id = threadTwoId,
                        Title = "New version of FireFox is released",
                        CategoryId = newsId,
                        DateCreated = DateTime.UtcNow
                    },
                    new Thread
                    {
                        Id = threadThreeId,
                        Title = "The best FPS game in 2019",
                        CategoryId = gamesId,
                        DateCreated = DateTime.UtcNow
                    }
                );

            //Posts Id's

            string postOne = Guid.NewGuid().ToString();
            string postTwo = Guid.NewGuid().ToString();
            string postThree = Guid.NewGuid().ToString();
            string postFour = Guid.NewGuid().ToString();

            builder.Entity<Post>().HasData(
                    new Post
                    {
                        Id = postOne,
                        ThreadId = threadOneId,
                        Content = "The best free antivirus is Kespersky Cloud Free",
                        DateCreated = DateTime.UtcNow,
                        UserId = vpUserId
                    },
                    new Post
                    {
                        Id = postTwo,
                        ThreadId = threadOneId,
                        Content = "Avast is another good free antivirus",
                        DateCreated = DateTime.UtcNow,
                        UserId = gaUserId
                    },
                    new Post
                    {
                        Id = postThree,
                        ThreadId = threadTwoId,
                        Content = "I hope they've pathed some of the security holes",
                        DateCreated = DateTime.UtcNow,
                        UserId = gaUserId
                    },
                    new Post
                    {
                        Id = postFour,
                        ThreadId = threadThreeId,
                        Content = "Call of Duty: Modern Warfare is the best one so far.",
                        DateCreated = DateTime.UtcNow,
                        UserId = fmUserId
                    }
                );
        }
    }
}
