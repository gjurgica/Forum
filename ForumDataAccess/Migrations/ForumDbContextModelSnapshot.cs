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
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
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

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Forums");

                    b.HasData(
                        new { Id = 1, Created = new DateTime(2019, 9, 19, 15, 38, 10, 111, DateTimeKind.Local), Description = "Python is an interpreted, high-level, general-purpose programming language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/1200px-Python-logo-notext.svg.png", Title = "Pyton", UserId = "20d7a124-1067-4b8b-95a6-b732827aec80" },
                        new { Id = 2, Created = new DateTime(2019, 9, 19, 15, 38, 10, 113, DateTimeKind.Local), Description = "ReactJS is an open-source JavaScript library which is used for building user interfaces specifically for single page applications.", ImageUrl = "https://cdn.worldvectorlogo.com/logos/react.svg", Title = "React.js", UserId = "20d7a124-1067-4b8b-95a6-b732827aec80" }
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

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, Content = "What is the best way to learn Python by myself? Are there any recommended websites/forums and textbooks?", Created = new DateTime(2019, 9, 19, 15, 38, 10, 113, DateTimeKind.Local), ForumId = 1, Title = "Is it easy to learn Python?", UserId = "20d7a124-1067-4b8b-95a6-b732827aec80" },
                        new { Id = 2, Content = "I’ve been working with javascript for a while now and I’m comfortable with it. I like all the libraries and flexibility that I have with it. I want to eventually start messing around with another language like Python or even Java but I’m not really seeing much of what something like python adds that I can’t really already do in javascript.Can someone explain to this noob why I should start learning Python (or Java)?", Created = new DateTime(2019, 9, 19, 15, 38, 10, 113, DateTimeKind.Local), ForumId = 1, Title = "Is Python worth learning 2019?", UserId = "f8c1fc71-5bae-41c7-99a1-68e7723ba2de" }
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

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostReplaies");
                });

            modelBuilder.Entity("ForumDomain.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("Url");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "20d7a124-1067-4b8b-95a6-b732827aec80", AccessFailedCount = 0, ConcurrencyStamp = "28daf194-c8ce-4a68-8b63-3f5fb5375a36", Email = "bob@gmail.com", EmailConfirmed = true, FirstName = "Bob", LastName = "Bobsky", LockoutEnabled = false, NormalizedEmail = "BOB@GMAIL.COM", NormalizedUserName = "BOBY", PasswordHash = "AQAAAAEAACcQAAAAEIhU1TH+AEjs+Dc3a4ZKkHO7reFGd6De2Rclh1tSj3q8Qx5MJLXN587CXnvRV7wZ2Q==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "Boby" },
                        new { Id = "f8c1fc71-5bae-41c7-99a1-68e7723ba2de", AccessFailedCount = 0, ConcurrencyStamp = "186ecc41-f806-45b7-b799-bb32cdddeb28", Email = "alek88@gmail.com", EmailConfirmed = true, FirstName = "Aleksandar", LastName = "Veljanovski", LockoutEnabled = false, NormalizedEmail = "ALEK88@GMAIL.COM", NormalizedUserName = "ALEKS", PasswordHash = "AQAAAAEAACcQAAAAEDa7B74IURk/ztQ25H63EbN8FYHbQq9B6/A7KKStY27/xcg+4+PMGdO5f1NULCgS2A==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "Aleks" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "619dcb8c-a1cd-4671-80ed-fd772652f140", ConcurrencyStamp = "0a6ba74b-36e6-430c-92d8-79a2e23e841a", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "ebf1eed4-87dc-43ab-b54c-206bfa1d24a9", ConcurrencyStamp = "2550fb97-d5e3-4e73-a2b0-36f82232314c", Name = "customer", NormalizedName = "CUSTOMER" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "20d7a124-1067-4b8b-95a6-b732827aec80", RoleId = "619dcb8c-a1cd-4671-80ed-fd772652f140" },
                        new { UserId = "f8c1fc71-5bae-41c7-99a1-68e7723ba2de", RoleId = "ebf1eed4-87dc-43ab-b54c-206bfa1d24a9" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ForumDomain.Forum", b =>
                {
                    b.HasOne("ForumDomain.User", "User")
                        .WithMany("Forums")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("ForumDomain.Post", b =>
                {
                    b.HasOne("ForumDomain.Forum", "Forum")
                        .WithMany("Posts")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("ForumDomain.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("ForumDomain.PostReply", b =>
                {
                    b.HasOne("ForumDomain.Post", "Post")
                        .WithMany("Replies")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("ForumDomain.User", "User")
                        .WithMany("PostReplays")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ForumDomain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ForumDomain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ForumDomain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ForumDomain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
