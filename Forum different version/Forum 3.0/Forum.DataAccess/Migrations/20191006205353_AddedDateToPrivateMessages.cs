using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.DataAccess.Migrations
{
    public partial class AddedDateToPrivateMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6f37b68b-6088-4dbf-8688-fbee8c5e1fdb", "a3157ef4-aa56-4a43-b3dc-81a307d3e22f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5517938e-0e1b-451c-8808-714db25ebfd8", "55203503-3618-4d3b-9574-4d3411e42465" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9a7b3cd6-2fb4-4f44-b69b-ba6f8fd405ea", "55203503-3618-4d3b-9574-4d3411e42465" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9c50eeec-0068-44bd-8b60-ac6fface69c2", "55203503-3618-4d3b-9574-4d3411e42465" });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "59b79b59-9b42-4399-a449-acf7b92128d8");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "ac68cd63-b534-4524-b183-e2ab232a24f7");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "d4b93b4c-62cb-49ef-9ef8-890368aea70e");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "e6c11ac6-92cc-425e-bcfd-d6a49169827e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "55203503-3618-4d3b-9574-4d3411e42465", "dbc90da9-bbb6-4144-bbde-30f356969d7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5517938e-0e1b-451c-8808-714db25ebfd8", "c910355c-da2a-44a6-98a5-bceb74b98b16" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9a7b3cd6-2fb4-4f44-b69b-ba6f8fd405ea", "d2b09fa2-078a-4143-b8a5-08f8c0731d18" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9c50eeec-0068-44bd-8b60-ac6fface69c2", "d7bf0ad1-391c-40ed-90c3-292894bdc339" });

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "398e04e8-d425-4199-bd0a-79a4a98eb582");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "3bb74f8a-4741-4cc1-8f90-1e2c1139c7fc");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "b3c968d8-5283-407e-ad74-701c32baf227");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "402e1af8-5fb3-408b-9924-6d61abb0e462");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "97024e2b-6640-4be6-b68f-3f95abe60fd7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "a56c3037-cf88-4376-87e2-d370633a459c");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa819574-5229-4f14-9955-9373ca521076", "e973bd55-f81d-463b-a68e-3da6a88b4732", "admin", "ADMIN" },
                    { "a34e5c1e-f427-4fb5-87cf-22b2bbfd3ecc", "55a9cd71-11d8-4b87-91b2-9539d05471be", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsItOnline", "Joined", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b4b0ed97-3515-4409-91c5-a86a4c3aafe1", 0, "/avatars/no-image.jpg", "b963281b-9bb0-412c-81f9-a829120237e9", "ga@forum.com", true, "Gjurgica Anastasovska", false, new DateTime(2019, 10, 6, 22, 53, 53, 80, DateTimeKind.Local), false, null, "GA@FORUM.COM", "GJURGICA", "AQAAAAEAACcQAAAAEEflPKCXXeOGyrvWAeuzWvIJq21fwtb5mDou0/Y0RCtqpSjdb8xfJoUuaQLU0C5m/Q==", null, false, "", false, "gjurgica" },
                    { "f1435183-c8f7-4ad1-a92f-b9dff6bcf8f3", 0, "/avatars/no-image.jpg", "e6271cc1-8362-4032-998b-fab9c370f7c3", "fm@forum.com", true, "Florent Memedi", false, new DateTime(2019, 10, 6, 22, 53, 53, 91, DateTimeKind.Local), false, null, "FM@FORUM.COM", "FLORENT", "AQAAAAEAACcQAAAAEPh5/mN3O3/yV4HnYajMWV6wa+bzk6O4Xi+KvVb6J4a5b0WC6tGUmIbGqUy3ShTaDg==", null, false, "", false, "florent" },
                    { "4b4d0831-699d-42a0-a6dc-6a27ac862e30", 0, "/avatars/no-image.jpg", "98f56171-9831-4d85-a036-30a6883145ad", "vp@forum.com", true, "Vladimir Prokopiev", false, new DateTime(2019, 10, 6, 22, 53, 53, 99, DateTimeKind.Local), false, null, "VP@FORUM.COM", "VLADIMIR", "AQAAAAEAACcQAAAAEEKbQCCGTvEGYCZJxP0m6vZOtfJQy3f/XYs0TlVJfyImwM0zh97wndgSiMowgJDzTw==", null, false, "", false, "vladimir" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "2bc7b153-21be-4e94-8b9e-6400330d9e64", "Software" },
                    { "de909b2a-33b4-4c7a-899a-2525f31c4bf5", "Games" },
                    { "1d717556-280b-4c11-a03c-f436f2c7bc67", "News" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "4b4d0831-699d-42a0-a6dc-6a27ac862e30", "aa819574-5229-4f14-9955-9373ca521076" },
                    { "b4b0ed97-3515-4409-91c5-a86a4c3aafe1", "aa819574-5229-4f14-9955-9373ca521076" },
                    { "f1435183-c8f7-4ad1-a92f-b9dff6bcf8f3", "aa819574-5229-4f14-9955-9373ca521076" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Title" },
                values: new object[,]
                {
                    { "b0efc3f7-3b69-46fc-a936-47978e939166", "2bc7b153-21be-4e94-8b9e-6400330d9e64", new DateTime(2019, 10, 6, 22, 53, 53, 100, DateTimeKind.Local), "Best Free AV" },
                    { "746fa6f4-b378-4a09-971d-68933366069b", "de909b2a-33b4-4c7a-899a-2525f31c4bf5", new DateTime(2019, 10, 6, 22, 53, 53, 100, DateTimeKind.Local), "The best FPS game in 2019" },
                    { "9bfb52f8-5583-44e5-b834-a7592c9b2b81", "1d717556-280b-4c11-a03c-f436f2c7bc67", new DateTime(2019, 10, 6, 22, 53, 53, 100, DateTimeKind.Local), "New version of FireFox is released" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "DateCreated", "ThreadId", "UserId" },
                values: new object[,]
                {
                    { "bce0537d-05f3-4109-b17f-a32f18973987", "The best free antivirus is Kaspersky Cloud Free", new DateTime(2019, 10, 6, 20, 53, 53, 100, DateTimeKind.Utc), "b0efc3f7-3b69-46fc-a936-47978e939166", "4b4d0831-699d-42a0-a6dc-6a27ac862e30" },
                    { "bd55f9b9-d106-4516-8934-4ddbf7f776cc", "Avast is another good free antivirus", new DateTime(2019, 10, 6, 20, 53, 53, 101, DateTimeKind.Utc), "b0efc3f7-3b69-46fc-a936-47978e939166", "b4b0ed97-3515-4409-91c5-a86a4c3aafe1" },
                    { "dbf953ae-b6af-4a63-bc49-065a6dc13e97", "Call of Duty: Modern Warfare is the best one so far.", new DateTime(2019, 10, 6, 20, 53, 53, 101, DateTimeKind.Utc), "746fa6f4-b378-4a09-971d-68933366069b", "f1435183-c8f7-4ad1-a92f-b9dff6bcf8f3" },
                    { "bea9f187-8d8d-4508-b6fc-81ed6d2e9695", "I hope they've pathed some of the security holes", new DateTime(2019, 10, 6, 20, 53, 53, 101, DateTimeKind.Utc), "9bfb52f8-5583-44e5-b834-a7592c9b2b81", "b4b0ed97-3515-4409-91c5-a86a4c3aafe1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a34e5c1e-f427-4fb5-87cf-22b2bbfd3ecc", "55a9cd71-11d8-4b87-91b2-9539d05471be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4b4d0831-699d-42a0-a6dc-6a27ac862e30", "aa819574-5229-4f14-9955-9373ca521076" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b4b0ed97-3515-4409-91c5-a86a4c3aafe1", "aa819574-5229-4f14-9955-9373ca521076" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f1435183-c8f7-4ad1-a92f-b9dff6bcf8f3", "aa819574-5229-4f14-9955-9373ca521076" });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "bce0537d-05f3-4109-b17f-a32f18973987");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "bd55f9b9-d106-4516-8934-4ddbf7f776cc");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "bea9f187-8d8d-4508-b6fc-81ed6d2e9695");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "dbf953ae-b6af-4a63-bc49-065a6dc13e97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "aa819574-5229-4f14-9955-9373ca521076", "e973bd55-f81d-463b-a68e-3da6a88b4732" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4b4d0831-699d-42a0-a6dc-6a27ac862e30", "98f56171-9831-4d85-a036-30a6883145ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b4b0ed97-3515-4409-91c5-a86a4c3aafe1", "b963281b-9bb0-412c-81f9-a829120237e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f1435183-c8f7-4ad1-a92f-b9dff6bcf8f3", "e6271cc1-8362-4032-998b-fab9c370f7c3" });

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "746fa6f4-b378-4a09-971d-68933366069b");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "9bfb52f8-5583-44e5-b834-a7592c9b2b81");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "b0efc3f7-3b69-46fc-a936-47978e939166");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1d717556-280b-4c11-a03c-f436f2c7bc67");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2bc7b153-21be-4e94-8b9e-6400330d9e64");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "de909b2a-33b4-4c7a-899a-2525f31c4bf5");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Messages");

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
        }
    }
}
