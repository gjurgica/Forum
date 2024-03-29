﻿// <auto-generated />
using System;
using Forum.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forum.DataAccess.Migrations
{
    [DbContext(typeof(ForumDbContext))]
    [Migration("20191007113902_InPrivateMessageModelChangedReceiverIdToFrom")]
    partial class InPrivateMessageModelChangedReceiverIdToFrom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Forum.DomainClasses.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = "c3e2f8f0-e693-4996-9025-1a54d517284d", Title = "Software" },
                        new { Id = "8c0e7dd3-b117-473f-95da-29a41883542d", Title = "Games" },
                        new { Id = "4b9f9c10-5edc-4813-ba67-c495a5815ce1", Title = "News" }
                    );
                });

            modelBuilder.Entity("Forum.DomainClasses.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("ThreadId")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ThreadId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = "c8d42ab6-ebe9-4696-ba3d-3740df43f971", Content = "The best free antivirus is Kaspersky Cloud Free", DateCreated = new DateTime(2019, 10, 7, 11, 39, 1, 829, DateTimeKind.Utc), ThreadId = "696ef4de-f064-4ee2-8931-4df85cde9159", UserId = "257ef1a3-c1f8-4dd4-9d65-f06c6ed24e62" },
                        new { Id = "63df52d1-93d4-4f05-863a-c22fbfffb0e9", Content = "Avast is another good free antivirus", DateCreated = new DateTime(2019, 10, 7, 11, 39, 1, 829, DateTimeKind.Utc), ThreadId = "696ef4de-f064-4ee2-8931-4df85cde9159", UserId = "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c" },
                        new { Id = "21e2ef9b-78ec-407f-9f19-916eef1eac03", Content = "I hope they've pathed some of the security holes", DateCreated = new DateTime(2019, 10, 7, 11, 39, 1, 829, DateTimeKind.Utc), ThreadId = "8337efbe-f35b-4a17-93ee-15fd0aa05dc3", UserId = "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c" },
                        new { Id = "e79b0c8a-6bc2-4922-a685-33716413ff70", Content = "Call of Duty: Modern Warfare is the best one so far.", DateCreated = new DateTime(2019, 10, 7, 11, 39, 1, 829, DateTimeKind.Utc), ThreadId = "6df7bbc4-6dac-4958-ba4a-8b774c3845c9", UserId = "0a4d6d77-407d-421d-a956-5ba127c14643" }
                    );
                });

            modelBuilder.Entity("Forum.DomainClasses.Models.PrivateMessage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<string>("From")
                        .IsRequired();

                    b.Property<string>("receiverId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("receiverId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Forum.DomainClasses.Models.Thread", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryId")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Threads");

                    b.HasData(
                        new { Id = "696ef4de-f064-4ee2-8931-4df85cde9159", CategoryId = "c3e2f8f0-e693-4996-9025-1a54d517284d", DateCreated = new DateTime(2019, 10, 7, 13, 39, 1, 828, DateTimeKind.Local), Title = "Best Free AV" },
                        new { Id = "8337efbe-f35b-4a17-93ee-15fd0aa05dc3", CategoryId = "4b9f9c10-5edc-4813-ba67-c495a5815ce1", DateCreated = new DateTime(2019, 10, 7, 13, 39, 1, 828, DateTimeKind.Local), Title = "New version of FireFox is released" },
                        new { Id = "6df7bbc4-6dac-4958-ba4a-8b774c3845c9", CategoryId = "8c0e7dd3-b117-473f-95da-29a41883542d", DateCreated = new DateTime(2019, 10, 7, 13, 39, 1, 828, DateTimeKind.Local), Title = "The best FPS game in 2019" }
                    );
                });

            modelBuilder.Entity("Forum.DomainClasses.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsItOnline");

                    b.Property<DateTime>("Joined");

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
                        new { Id = "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c", AccessFailedCount = 0, Avatar = "/avatars/no-image.jpg", ConcurrencyStamp = "9fa237e4-c4b7-4d60-950b-b12d1cda47c7", Email = "ga@forum.com", EmailConfirmed = true, FullName = "Gjurgica Anastasovska", IsItOnline = false, Joined = new DateTime(2019, 10, 7, 13, 39, 1, 809, DateTimeKind.Local), LockoutEnabled = false, NormalizedEmail = "GA@FORUM.COM", NormalizedUserName = "GJURGICA", PasswordHash = "AQAAAAEAACcQAAAAEPZezX+bMq+i64twmirglGReg9aoEYzlZpWL3fDlsRiL8o0ym1J02NBY15ylEHWoHQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "gjurgica" },
                        new { Id = "0a4d6d77-407d-421d-a956-5ba127c14643", AccessFailedCount = 0, Avatar = "/avatars/no-image.jpg", ConcurrencyStamp = "02816675-d81f-4bb7-876c-caf77b0d7b63", Email = "fm@forum.com", EmailConfirmed = true, FullName = "Florent Memedi", IsItOnline = false, Joined = new DateTime(2019, 10, 7, 13, 39, 1, 820, DateTimeKind.Local), LockoutEnabled = false, NormalizedEmail = "FM@FORUM.COM", NormalizedUserName = "FLORENT", PasswordHash = "AQAAAAEAACcQAAAAEM3QQeaOVF82s09PyckCQUtcOh4DXQWXjFVPNSJAiCAzrGEApDeqhD8qocj0hPJp+A==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "florent" },
                        new { Id = "257ef1a3-c1f8-4dd4-9d65-f06c6ed24e62", AccessFailedCount = 0, Avatar = "/avatars/no-image.jpg", ConcurrencyStamp = "0fc94acc-559b-42bc-b243-756d44bdb788", Email = "vp@forum.com", EmailConfirmed = true, FullName = "Vladimir Prokopiev", IsItOnline = false, Joined = new DateTime(2019, 10, 7, 13, 39, 1, 828, DateTimeKind.Local), LockoutEnabled = false, NormalizedEmail = "VP@FORUM.COM", NormalizedUserName = "VLADIMIR", PasswordHash = "AQAAAAEAACcQAAAAECc6vakbw4D5gvrknqx26mQWcXnxPM0g1ErMlyVeeTO87gqhQic1QSARancBru0EBQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "vladimir" }
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
                        new { Id = "7ab02ae6-4c75-450f-93a3-b1f7b29af87d", ConcurrencyStamp = "e61821f6-845c-4bcc-9f13-cbc22247a101", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "60d64b5f-a274-4386-a2d1-a6d963f4897a", ConcurrencyStamp = "4e74171b-2475-4bef-ae1c-9a7fed09870a", Name = "user", NormalizedName = "USER" }
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
                        new { UserId = "257ef1a3-c1f8-4dd4-9d65-f06c6ed24e62", RoleId = "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" },
                        new { UserId = "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c", RoleId = "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" },
                        new { UserId = "0a4d6d77-407d-421d-a956-5ba127c14643", RoleId = "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" }
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

            modelBuilder.Entity("Forum.DomainClasses.Models.Post", b =>
                {
                    b.HasOne("Forum.DomainClasses.Models.Thread", "Thread")
                        .WithMany("Posts")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Forum.DomainClasses.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Forum.DomainClasses.Models.PrivateMessage", b =>
                {
                    b.HasOne("Forum.DomainClasses.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("receiverId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Forum.DomainClasses.Models.Thread", b =>
                {
                    b.HasOne("Forum.DomainClasses.Models.Category", "Category")
                        .WithMany("Threads")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
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
                    b.HasOne("Forum.DomainClasses.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Forum.DomainClasses.Models.User")
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

                    b.HasOne("Forum.DomainClasses.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Forum.DomainClasses.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
