using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.DataAccess.Migrations
{
    public partial class InPrivateMessageModelChangedReceiverIdToFrom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "senderId",
                table: "Messages",
                newName: "From");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "From",
                table: "Messages",
                newName: "senderId");

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
    }
}
