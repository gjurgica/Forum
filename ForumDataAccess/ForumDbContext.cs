﻿using ForumDomain;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumDataAccess
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions options)
           : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> Replies { get; set; }


        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
              .HasData(
            new User()
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Bobsky",
                UserName = "Boby",
                Email = "bob@gmail.com",
                Password = "ananas"
            },
            new User()
            {
                Id = 2,
                FirstName = "Aleksandar",
                LastName = "Veljanovski",
                UserName = "Aleks",
                Email = "alek88@gmail.com",
                Password = "alek789"
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
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/1200px-Python-logo-notext.svg.png"
                },
                new Forum()
                {
                    Id = 2,
                    Title = "React.js",
                    Description = "ReactJS is an open-source JavaScript library which is used for building user interfaces specifically for single page applications.",
                    Created = DateTime.Now,
                    ImageUrl = "https://cdn.worldvectorlogo.com/logos/react.svg"

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
                    UserId = 3
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
                    UserId = 1
                }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-I98ASMM\SQLEXPRESS;Database=ForumDB1;Trusted_Connection=True;");

        }
    }

   
}
