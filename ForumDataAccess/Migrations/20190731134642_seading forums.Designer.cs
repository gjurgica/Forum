﻿// <auto-generated />
using System;
using ForumDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForumDataAccess.Migrations
{
    [DbContext(typeof(ForumDbContext))]
    [Migration("20190731134642_seading forums")]
    partial class seadingforums
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Forums");

                    b.HasData(
                        new { Id = 1, Created = new DateTime(2019, 7, 31, 15, 46, 42, 131, DateTimeKind.Local), Description = "Python is an interpreted, high-level, general-purpose programming language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/1200px-Python-logo-notext.svg.png", Title = "Pyton" },
                        new { Id = 2, Created = new DateTime(2019, 7, 31, 15, 46, 42, 134, DateTimeKind.Local), Description = "ReactJS is an open-source JavaScript library which is used for building user interfaces specifically for single page applications.", ImageUrl = "https://hackernoon.com/hn-images/1*y6C4nSvy2Woe0m7bWEn4BA.png", Title = "React.js" }
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

                    b.Property<int?>("ForumId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
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
                });

            modelBuilder.Entity("ForumDomain.Post", b =>
                {
                    b.HasOne("ForumDomain.Forum", "Forum")
                        .WithMany("Posts")
                        .HasForeignKey("ForumId");

                    b.HasOne("ForumDomain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
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