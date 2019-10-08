using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Joined = table.Column<DateTime>(nullable: false),
                    IsItOnline = table.Column<bool>(nullable: false),
                    Avatar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    senderId = table.Column<string>(nullable: false),
                    receiverId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_receiverId",
                        column: x => x.receiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Threads",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    CategoryId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Threads_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    ThreadId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55203503-3618-4d3b-9574-4d3411e42465", "dbc90da9-bbb6-4144-bbde-30f356969d7f", "admin", "ADMIN" },
                    { "6f37b68b-6088-4dbf-8688-fbee8c5e1fdb", "a3157ef4-aa56-4a43-b3dc-81a307d3e22f", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsItOnline", "Joined", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5517938e-0e1b-451c-8808-714db25ebfd8", 0, "/avatars/no-image.jpg", "c910355c-da2a-44a6-98a5-bceb74b98b16", "ga@forum.com", true, "Gjurgica Anastasovska", false, new DateTime(2019, 10, 6, 0, 58, 10, 482, DateTimeKind.Local), false, null, "GA@FORUM.COM", "GJURGICA", "AQAAAAEAACcQAAAAENS5VAI1ezO8mABCVx7cL/PwTZYhROsGJBUtuxMLdpP3zTmcgMyeROP26/3RB6R5qg==", null, false, "", false, "gjurgica" },
                    { "9c50eeec-0068-44bd-8b60-ac6fface69c2", 0, "/avatars/no-image.jpg", "d7bf0ad1-391c-40ed-90c3-292894bdc339", "fm@forum.com", true, "Florent Memedi", false, new DateTime(2019, 10, 6, 0, 58, 10, 493, DateTimeKind.Local), false, null, "FM@FORUM.COM", "FLORENT", "AQAAAAEAACcQAAAAEHCsXRH9dtRskldO6lBFLwOjhmGdh7rQM/FUqcA1on4HWw19UCuRkadC/AkWOcpzxw==", null, false, "", false, "florent" },
                    { "9a7b3cd6-2fb4-4f44-b69b-ba6f8fd405ea", 0, "/avatars/no-image.jpg", "d2b09fa2-078a-4143-b8a5-08f8c0731d18", "vp@forum.com", true, "Vladimir Prokopiev", false, new DateTime(2019, 10, 6, 0, 58, 10, 501, DateTimeKind.Local), false, null, "VP@FORUM.COM", "VLADIMIR", "AQAAAAEAACcQAAAAEHLEpPAH7WXP4OP3CFWlbPZ01cpM/xG1cUGKW+29Vf7wv4apmdPlSQMmkz3yklqX5Q==", null, false, "", false, "vladimir" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "a56c3037-cf88-4376-87e2-d370633a459c", "Software" },
                    { "97024e2b-6640-4be6-b68f-3f95abe60fd7", "Games" },
                    { "402e1af8-5fb3-408b-9924-6d61abb0e462", "News" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "9a7b3cd6-2fb4-4f44-b69b-ba6f8fd405ea", "55203503-3618-4d3b-9574-4d3411e42465" },
                    { "5517938e-0e1b-451c-8808-714db25ebfd8", "55203503-3618-4d3b-9574-4d3411e42465" },
                    { "9c50eeec-0068-44bd-8b60-ac6fface69c2", "55203503-3618-4d3b-9574-4d3411e42465" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Title" },
                values: new object[,]
                {
                    { "b3c968d8-5283-407e-ad74-701c32baf227", "a56c3037-cf88-4376-87e2-d370633a459c", new DateTime(2019, 10, 6, 0, 58, 10, 502, DateTimeKind.Local), "Best Free AV" },
                    { "3bb74f8a-4741-4cc1-8f90-1e2c1139c7fc", "97024e2b-6640-4be6-b68f-3f95abe60fd7", new DateTime(2019, 10, 6, 0, 58, 10, 502, DateTimeKind.Local), "The best FPS game in 2019" },
                    { "398e04e8-d425-4199-bd0a-79a4a98eb582", "402e1af8-5fb3-408b-9924-6d61abb0e462", new DateTime(2019, 10, 6, 0, 58, 10, 502, DateTimeKind.Local), "New version of FireFox is released" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "DateCreated", "ThreadId", "UserId" },
                values: new object[,]
                {
                    { "59b79b59-9b42-4399-a449-acf7b92128d8", "The best free antivirus is Kaspersky Cloud Free", new DateTime(2019, 10, 5, 22, 58, 10, 502, DateTimeKind.Utc), "b3c968d8-5283-407e-ad74-701c32baf227", "9a7b3cd6-2fb4-4f44-b69b-ba6f8fd405ea" },
                    { "ac68cd63-b534-4524-b183-e2ab232a24f7", "Avast is another good free antivirus", new DateTime(2019, 10, 5, 22, 58, 10, 502, DateTimeKind.Utc), "b3c968d8-5283-407e-ad74-701c32baf227", "5517938e-0e1b-451c-8808-714db25ebfd8" },
                    { "e6c11ac6-92cc-425e-bcfd-d6a49169827e", "Call of Duty: Modern Warfare is the best one so far.", new DateTime(2019, 10, 5, 22, 58, 10, 502, DateTimeKind.Utc), "3bb74f8a-4741-4cc1-8f90-1e2c1139c7fc", "9c50eeec-0068-44bd-8b60-ac6fface69c2" },
                    { "d4b93b4c-62cb-49ef-9ef8-890368aea70e", "I hope they've pathed some of the security holes", new DateTime(2019, 10, 5, 22, 58, 10, 502, DateTimeKind.Utc), "398e04e8-d425-4199-bd0a-79a4a98eb582", "5517938e-0e1b-451c-8808-714db25ebfd8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_receiverId",
                table: "Messages",
                column: "receiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ThreadId",
                table: "Posts",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_CategoryId",
                table: "Threads",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Threads");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
