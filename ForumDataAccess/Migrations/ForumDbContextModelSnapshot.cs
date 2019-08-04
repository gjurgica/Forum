﻿// <auto-generated />
using System;
using ForumDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForumDataAccess.Migrations
{
    [DbContext(typeof(ForumDbContext))]
    partial class ForumDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForumDomain.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<int>("PostId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Forums");

                    b.HasData(
                        new { Id = 1, Created = new DateTime(2019, 8, 3, 19, 24, 7, 0, DateTimeKind.Local), Description = "Python is an interpreted, high-level, general-purpose programming language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/1200px-Python-logo-notext.svg.png", PostId = 0, Title = "Pyton" },
                        new { Id = 2, Created = new DateTime(2019, 8, 3, 19, 24, 7, 2, DateTimeKind.Local), Description = "ReactJS is an open-source JavaScript library which is used for building user interfaces specifically for single page applications.", ImageUrl = "https://hackernoon.com/hn-images/1*y6C4nSvy2Woe0m7bWEn4BA.png", PostId = 0, Title = "React.js" }
                    );
                });

            modelBuilder.Entity("ForumDomain.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<int>("ForumId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, Content = "What is the best way to learn Python by myself? Are there any recommended websites/forums and textbooks?", Created = new DateTime(2019, 8, 3, 19, 24, 7, 2, DateTimeKind.Local), ForumId = 1, Title = "Is it easy to learn Python?", UserId = 3 },
                        new { Id = 2, Content = "I’ve been working with javascript for a while now and I’m comfortable with it. I like all the libraries and flexibility that I have with it. I want to eventually start messing around with another language like Python or even Java but I’m not really seeing much of what something like python adds that I can’t really already do in javascript.Can someone explain to this noob why I should start learning Python (or Java)?", Created = new DateTime(2019, 8, 3, 19, 24, 7, 2, DateTimeKind.Local), ForumId = 1, Title = "Is Python worth learning 2019?", UserId = 1 }
                    );
                });

            modelBuilder.Entity("ForumDomain.PostReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<int?>("PostId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("ForumDomain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Url");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Email = "bob@gmail.com", FirstName = "Bob", LastName = "Bobsky", Password = "ananas", UserName = "Boby" },
                        new { Id = 2, Email = "alek88@gmail.com", FirstName = "Aleksandar", LastName = "Veljanovski", Password = "alek789", UserName = "Aleks" }
                    );
                });

            modelBuilder.Entity("ForumDomain.Forum", b =>
                {
                    b.HasOne("ForumDomain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ForumDomain.Post", b =>
                {
                    b.HasOne("ForumDomain.Forum", "Forum")
                        .WithMany("Posts")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ForumDomain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ForumDomain.PostReply", b =>
                {
                    b.HasOne("ForumDomain.Post", "Post")
                        .WithMany("Replies")
                        .HasForeignKey("PostId");

                    b.HasOne("ForumDomain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
