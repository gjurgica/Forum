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
    [Migration("20190926132016_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForumDomain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Title = "Software" },
                        new { Id = 2, Title = "Games" },
                        new { Id = 3, Title = "News" }
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

                    b.Property<int?>("ThreadId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ThreadId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, Content = "The best free antivirus is Kespersky Cloud Free", Created = new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), ThreadId = 1, UserId = "4d920455-f1e6-4315-a60c-d39de7bfb1a7" },
                        new { Id = 2, Content = "Avast is another good free antivirus", Created = new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), ThreadId = 1, UserId = "af0a7884-8162-4849-8c78-37b9018af963" },
                        new { Id = 3, Content = "I hope they've pathed some of the security holes", Created = new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), ThreadId = 2, UserId = "4d920455-f1e6-4315-a60c-d39de7bfb1a7" },
                        new { Id = 4, Content = "Call of Duty: Modern Warfare is the best one so far.", Created = new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), ThreadId = 3, UserId = "af0a7884-8162-4849-8c78-37b9018af963" }
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

            modelBuilder.Entity("ForumDomain.Thread", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Threads");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Created = new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), ImageUrl = "https://ksassets.timeincuk.net/wp/uploads/sites/54/2019/06/best-free-antivirus-trusted-reviews-920x518.jpg", Title = "Best Free AV" },
                        new { Id = 2, CategoryId = 3, Created = new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Firefox_Logo%2C_2017.svg/1200px-Firefox_Logo%2C_2017.svg.png", Title = "New version of FireFox is released" },
                        new { Id = 3, CategoryId = 2, Created = new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), ImageUrl = "https://ksassets.timeincuk.net/wp/uploads/sites/54/2019/01/Best-FPS-Games-920x613.jpg", Title = "The best FPS game in 2019" }
                    );
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

                    b.Property<bool>("IsItOnline");

                    b.Property<DateTime>("Joined");

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
                        new { Id = "4d920455-f1e6-4315-a60c-d39de7bfb1a7", AccessFailedCount = 0, ConcurrencyStamp = "30f52c07-ee7b-4154-a771-b42c6a89ccea", Email = "bob@gmail.com", EmailConfirmed = true, FirstName = "Bob", IsItOnline = false, Joined = new DateTime(2019, 9, 26, 15, 20, 15, 285, DateTimeKind.Local), LastName = "Bobsky", LockoutEnabled = false, NormalizedEmail = "BOB@GMAIL.COM", NormalizedUserName = "BOBY", PasswordHash = "AQAAAAEAACcQAAAAEBwb4mO9FzyUk2c92+U6AjqLpAiVoD9/K/9/xeQydzKUQkW0XACQKBauI4Yq9asN+Q==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "Boby" },
                        new { Id = "af0a7884-8162-4849-8c78-37b9018af963", AccessFailedCount = 0, ConcurrencyStamp = "cbd9a843-15f8-4e4e-b03d-9df9923a1fe9", Email = "alek88@gmail.com", EmailConfirmed = true, FirstName = "Aleksandar", IsItOnline = false, Joined = new DateTime(2019, 9, 26, 15, 20, 15, 295, DateTimeKind.Local), LastName = "Veljanovski", LockoutEnabled = false, NormalizedEmail = "ALEK88@GMAIL.COM", NormalizedUserName = "ALEKS", PasswordHash = "AQAAAAEAACcQAAAAEJnbxD3N5viIEMRU8RvRXqGn/8m3QhwdYY/hPSeNLCH7eRft4h8sOkhWVTK/SFixlw==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "Aleks" }
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
                        new { Id = "2fca2757-ee22-4593-bfb3-774340ec04ff", ConcurrencyStamp = "61437219-e2e8-497a-be08-224fac6345b0", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "b0d72c84-45bb-43f2-84b6-1fcc73363aa4", ConcurrencyStamp = "8478f539-2429-49cd-9342-41ccbfd2ec2f", Name = "customer", NormalizedName = "CUSTOMER" }
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
                        new { UserId = "4d920455-f1e6-4315-a60c-d39de7bfb1a7", RoleId = "2fca2757-ee22-4593-bfb3-774340ec04ff" },
                        new { UserId = "af0a7884-8162-4849-8c78-37b9018af963", RoleId = "b0d72c84-45bb-43f2-84b6-1fcc73363aa4" }
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

            modelBuilder.Entity("ForumDomain.Post", b =>
                {
                    b.HasOne("ForumDomain.Thread", "Thread")
                        .WithMany("Posts")
                        .HasForeignKey("ThreadId")
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

            modelBuilder.Entity("ForumDomain.Thread", b =>
                {
                    b.HasOne("ForumDomain.Category", "Category")
                        .WithMany("Threads")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ForumDomain.User")
                        .WithMany("Threads")
                        .HasForeignKey("UserId");
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
