using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.DataAccess.Migrations
{
    public partial class NewEntityAlert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "60d64b5f-a274-4386-a2d1-a6d963f4897a", "4e74171b-2475-4bef-ae1c-9a7fed09870a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0a4d6d77-407d-421d-a956-5ba127c14643", "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "257ef1a3-c1f8-4dd4-9d65-f06c6ed24e62", "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c", "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "21e2ef9b-78ec-407f-9f19-916eef1eac03");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "63df52d1-93d4-4f05-863a-c22fbfffb0e9");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "c8d42ab6-ebe9-4696-ba3d-3740df43f971");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "e79b0c8a-6bc2-4922-a685-33716413ff70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7ab02ae6-4c75-450f-93a3-b1f7b29af87d", "e61821f6-845c-4bcc-9f13-cbc22247a101" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0a4d6d77-407d-421d-a956-5ba127c14643", "02816675-d81f-4bb7-876c-caf77b0d7b63" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "257ef1a3-c1f8-4dd4-9d65-f06c6ed24e62", "0fc94acc-559b-42bc-b243-756d44bdb788" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c", "9fa237e4-c4b7-4d60-950b-b12d1cda47c7" });

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "696ef4de-f064-4ee2-8931-4df85cde9159");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "6df7bbc4-6dac-4958-ba4a-8b774c3845c9");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "8337efbe-f35b-4a17-93ee-15fd0aa05dc3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4b9f9c10-5edc-4813-ba67-c495a5815ce1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "8c0e7dd3-b117-473f-95da-29a41883542d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c3e2f8f0-e693-4996-9025-1a54d517284d");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsItSuspended",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Alerts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PostId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alerts_AspNetUsers_UserId",
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
                    { "5e10bb0e-5c55-4f4f-8c52-5ab5c1751523", "c79d9a96-16e3-400a-931b-206ca843f6ad", "admin", "ADMIN" },
                    { "dab6d0ec-60e0-4d8b-bf81-62d9a7334b17", "a0c0b935-03b7-422b-a0e8-a3bba110e1f1", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsItOnline", "IsItSuspended", "Joined", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f6a3b03d-90b8-4dd4-ab61-1d93e22bc3ef", 0, "/avatars/no-image.jpg", "d7584e60-c278-4fbd-8c06-31e0e9c11132", "ga@forum.com", true, "Gjurgica Anastasovska", false, false, new DateTime(2019, 10, 7, 21, 47, 44, 351, DateTimeKind.Local), false, null, "GA@FORUM.COM", "GJURGICA", "AQAAAAEAACcQAAAAENuRpZXMlFhSQ6UXER0aAAr9yJ9kCkO7fBAXq+Ma7yChlY9po5goPAPMhOiNIc9CqQ==", null, false, "", false, "gjurgica" },
                    { "23d43032-30f1-4a0b-b553-4374d2352397", 0, "/avatars/no-image.jpg", "72e82a3a-5ebc-487f-8ff6-3510c0177a4f", "fm@forum.com", true, "Florent Memedi", false, false, new DateTime(2019, 10, 7, 21, 47, 44, 361, DateTimeKind.Local), false, null, "FM@FORUM.COM", "FLORENT", "AQAAAAEAACcQAAAAEJqeGFEWor19cs23dt8UQu7XHwlUdWPYuqYPH2nRrvYv0ZlozEgXVFz9baOCSozozQ==", null, false, "", false, "florent" },
                    { "7d61ae6a-c786-497e-9955-b144476f596f", 0, "/avatars/no-image.jpg", "3275c9a9-4b0d-4b3c-89f1-ea815f5457f9", "vp@forum.com", true, "Vladimir Prokopiev", false, false, new DateTime(2019, 10, 7, 21, 47, 44, 370, DateTimeKind.Local), false, null, "VP@FORUM.COM", "VLADIMIR", "AQAAAAEAACcQAAAAEEjKsx6D4rUXFqDl9vvHw/LmX13Cadog/Z2/u5qCb125e1h/tIaycTNIe+i47lNjQw==", null, false, "", false, "vladimir" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "6378176c-7cdc-4244-9b01-9b8393d40def", "Software" },
                    { "8418e314-2f90-4927-a8f1-75676a0044c8", "Games" },
                    { "2a8b43b5-306f-4561-b32e-69018b8e6a69", "News" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "7d61ae6a-c786-497e-9955-b144476f596f", "5e10bb0e-5c55-4f4f-8c52-5ab5c1751523" },
                    { "f6a3b03d-90b8-4dd4-ab61-1d93e22bc3ef", "5e10bb0e-5c55-4f4f-8c52-5ab5c1751523" },
                    { "23d43032-30f1-4a0b-b553-4374d2352397", "5e10bb0e-5c55-4f4f-8c52-5ab5c1751523" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Title" },
                values: new object[,]
                {
                    { "097b47f6-2ca9-482a-a5ea-49c15e5112ab", "6378176c-7cdc-4244-9b01-9b8393d40def", new DateTime(2019, 10, 7, 21, 47, 44, 370, DateTimeKind.Local), "Best Free AV" },
                    { "be00757b-8c5e-4717-af05-658a8c7f8039", "8418e314-2f90-4927-a8f1-75676a0044c8", new DateTime(2019, 10, 7, 21, 47, 44, 371, DateTimeKind.Local), "The best FPS game in 2019" },
                    { "fab5cc4d-3c42-419a-a547-dbd49d41d451", "2a8b43b5-306f-4561-b32e-69018b8e6a69", new DateTime(2019, 10, 7, 21, 47, 44, 371, DateTimeKind.Local), "New version of FireFox is released" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "DateCreated", "ThreadId", "UserId" },
                values: new object[,]
                {
                    { "9032b9b6-6da1-489b-87a5-1454f98ceaaa", "The best free antivirus is Kaspersky Cloud Free", new DateTime(2019, 10, 7, 19, 47, 44, 371, DateTimeKind.Utc), "097b47f6-2ca9-482a-a5ea-49c15e5112ab", "7d61ae6a-c786-497e-9955-b144476f596f" },
                    { "71edf604-f239-49f6-bd72-fd192f0f242b", "Avast is another good free antivirus", new DateTime(2019, 10, 7, 19, 47, 44, 371, DateTimeKind.Utc), "097b47f6-2ca9-482a-a5ea-49c15e5112ab", "f6a3b03d-90b8-4dd4-ab61-1d93e22bc3ef" },
                    { "b8426a2a-f293-4d42-a777-4676a3384237", "Call of Duty: Modern Warfare is the best one so far.", new DateTime(2019, 10, 7, 19, 47, 44, 371, DateTimeKind.Utc), "be00757b-8c5e-4717-af05-658a8c7f8039", "23d43032-30f1-4a0b-b553-4374d2352397" },
                    { "a5c9e54c-efbd-4740-84d8-ae59b57dd8bd", "I hope they've pathed some of the security holes", new DateTime(2019, 10, 7, 19, 47, 44, 371, DateTimeKind.Utc), "fab5cc4d-3c42-419a-a547-dbd49d41d451", "f6a3b03d-90b8-4dd4-ab61-1d93e22bc3ef" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_UserId",
                table: "Alerts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "dab6d0ec-60e0-4d8b-bf81-62d9a7334b17", "a0c0b935-03b7-422b-a0e8-a3bba110e1f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "23d43032-30f1-4a0b-b553-4374d2352397", "5e10bb0e-5c55-4f4f-8c52-5ab5c1751523" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7d61ae6a-c786-497e-9955-b144476f596f", "5e10bb0e-5c55-4f4f-8c52-5ab5c1751523" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f6a3b03d-90b8-4dd4-ab61-1d93e22bc3ef", "5e10bb0e-5c55-4f4f-8c52-5ab5c1751523" });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "71edf604-f239-49f6-bd72-fd192f0f242b");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "9032b9b6-6da1-489b-87a5-1454f98ceaaa");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "a5c9e54c-efbd-4740-84d8-ae59b57dd8bd");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "b8426a2a-f293-4d42-a777-4676a3384237");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5e10bb0e-5c55-4f4f-8c52-5ab5c1751523", "c79d9a96-16e3-400a-931b-206ca843f6ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "23d43032-30f1-4a0b-b553-4374d2352397", "72e82a3a-5ebc-487f-8ff6-3510c0177a4f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7d61ae6a-c786-497e-9955-b144476f596f", "3275c9a9-4b0d-4b3c-89f1-ea815f5457f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f6a3b03d-90b8-4dd4-ab61-1d93e22bc3ef", "d7584e60-c278-4fbd-8c06-31e0e9c11132" });

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "097b47f6-2ca9-482a-a5ea-49c15e5112ab");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "be00757b-8c5e-4717-af05-658a8c7f8039");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "fab5cc4d-3c42-419a-a547-dbd49d41d451");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2a8b43b5-306f-4561-b32e-69018b8e6a69");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6378176c-7cdc-4244-9b01-9b8393d40def");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "8418e314-2f90-4927-a8f1-75676a0044c8");

            migrationBuilder.DropColumn(
                name: "IsItSuspended",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ab02ae6-4c75-450f-93a3-b1f7b29af87d", "e61821f6-845c-4bcc-9f13-cbc22247a101", "admin", "ADMIN" },
                    { "60d64b5f-a274-4386-a2d1-a6d963f4897a", "4e74171b-2475-4bef-ae1c-9a7fed09870a", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsItOnline", "Joined", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c", 0, "/avatars/no-image.jpg", "9fa237e4-c4b7-4d60-950b-b12d1cda47c7", "ga@forum.com", true, "Gjurgica Anastasovska", false, new DateTime(2019, 10, 7, 13, 39, 1, 809, DateTimeKind.Local), false, null, "GA@FORUM.COM", "GJURGICA", "AQAAAAEAACcQAAAAEPZezX+bMq+i64twmirglGReg9aoEYzlZpWL3fDlsRiL8o0ym1J02NBY15ylEHWoHQ==", null, false, "", false, "gjurgica" },
                    { "0a4d6d77-407d-421d-a956-5ba127c14643", 0, "/avatars/no-image.jpg", "02816675-d81f-4bb7-876c-caf77b0d7b63", "fm@forum.com", true, "Florent Memedi", false, new DateTime(2019, 10, 7, 13, 39, 1, 820, DateTimeKind.Local), false, null, "FM@FORUM.COM", "FLORENT", "AQAAAAEAACcQAAAAEM3QQeaOVF82s09PyckCQUtcOh4DXQWXjFVPNSJAiCAzrGEApDeqhD8qocj0hPJp+A==", null, false, "", false, "florent" },
                    { "257ef1a3-c1f8-4dd4-9d65-f06c6ed24e62", 0, "/avatars/no-image.jpg", "0fc94acc-559b-42bc-b243-756d44bdb788", "vp@forum.com", true, "Vladimir Prokopiev", false, new DateTime(2019, 10, 7, 13, 39, 1, 828, DateTimeKind.Local), false, null, "VP@FORUM.COM", "VLADIMIR", "AQAAAAEAACcQAAAAECc6vakbw4D5gvrknqx26mQWcXnxPM0g1ErMlyVeeTO87gqhQic1QSARancBru0EBQ==", null, false, "", false, "vladimir" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "c3e2f8f0-e693-4996-9025-1a54d517284d", "Software" },
                    { "8c0e7dd3-b117-473f-95da-29a41883542d", "Games" },
                    { "4b9f9c10-5edc-4813-ba67-c495a5815ce1", "News" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "257ef1a3-c1f8-4dd4-9d65-f06c6ed24e62", "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" },
                    { "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c", "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" },
                    { "0a4d6d77-407d-421d-a956-5ba127c14643", "7ab02ae6-4c75-450f-93a3-b1f7b29af87d" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Title" },
                values: new object[,]
                {
                    { "696ef4de-f064-4ee2-8931-4df85cde9159", "c3e2f8f0-e693-4996-9025-1a54d517284d", new DateTime(2019, 10, 7, 13, 39, 1, 828, DateTimeKind.Local), "Best Free AV" },
                    { "6df7bbc4-6dac-4958-ba4a-8b774c3845c9", "8c0e7dd3-b117-473f-95da-29a41883542d", new DateTime(2019, 10, 7, 13, 39, 1, 828, DateTimeKind.Local), "The best FPS game in 2019" },
                    { "8337efbe-f35b-4a17-93ee-15fd0aa05dc3", "4b9f9c10-5edc-4813-ba67-c495a5815ce1", new DateTime(2019, 10, 7, 13, 39, 1, 828, DateTimeKind.Local), "New version of FireFox is released" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "DateCreated", "ThreadId", "UserId" },
                values: new object[,]
                {
                    { "c8d42ab6-ebe9-4696-ba3d-3740df43f971", "The best free antivirus is Kaspersky Cloud Free", new DateTime(2019, 10, 7, 11, 39, 1, 829, DateTimeKind.Utc), "696ef4de-f064-4ee2-8931-4df85cde9159", "257ef1a3-c1f8-4dd4-9d65-f06c6ed24e62" },
                    { "63df52d1-93d4-4f05-863a-c22fbfffb0e9", "Avast is another good free antivirus", new DateTime(2019, 10, 7, 11, 39, 1, 829, DateTimeKind.Utc), "696ef4de-f064-4ee2-8931-4df85cde9159", "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c" },
                    { "e79b0c8a-6bc2-4922-a685-33716413ff70", "Call of Duty: Modern Warfare is the best one so far.", new DateTime(2019, 10, 7, 11, 39, 1, 829, DateTimeKind.Utc), "6df7bbc4-6dac-4958-ba4a-8b774c3845c9", "0a4d6d77-407d-421d-a956-5ba127c14643" },
                    { "21e2ef9b-78ec-407f-9f19-916eef1eac03", "I hope they've pathed some of the security holes", new DateTime(2019, 10, 7, 11, 39, 1, 829, DateTimeKind.Utc), "8337efbe-f35b-4a17-93ee-15fd0aa05dc3", "cc3c9b6c-c2cd-4be2-98ed-2232c7b5348c" }
                });
        }
    }
}
