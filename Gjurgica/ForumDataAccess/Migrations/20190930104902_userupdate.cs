using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumDataAccess.Migrations
{
    public partial class userupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e07f3d4e-f09e-4d5b-9dbd-1592fa2ba99b", "2e081021-14e0-40cf-94e0-7f50daa0f9b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f95f9f1f-0d02-42d4-9327-71b22a6618bf", "82676832-57dd-4c85-83fd-40597833ca9f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2e081021-14e0-40cf-94e0-7f50daa0f9b7", "982ac924-4e24-4d5e-a33c-81ac8e5a945e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "82676832-57dd-4c85-83fd-40597833ca9f", "5cb441ef-0ea6-4915-a258-3a52ed1698e0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e07f3d4e-f09e-4d5b-9dbd-1592fa2ba99b", "ce822b71-9b5a-4c1c-b312-9d64cd32ddb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f95f9f1f-0d02-42d4-9327-71b22a6618bf", "650287fd-78a4-4e88-bca0-2a70d285ddb9" });

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d918ee5-2cd5-44af-9b86-918775b704ba", "fb249502-efd6-4062-85df-9f978f512a35", "admin", "ADMIN" },
                    { "fbb36bab-d88e-4da9-b35b-74591fe480e7", "5783d00a-5039-4464-be73-854bdb27d8f6", "customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "IsItOnline", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "12f0fe8d-e3a3-440b-8b13-71bfd8adfd63", 0, "434539e3-e3dd-48ce-bff6-7503403f4ece", "bob@gmail.com", true, "Bob", null, false, new DateTime(2019, 9, 30, 12, 49, 0, 809, DateTimeKind.Local), "Bobsky", false, null, "BOB@GMAIL.COM", "BOBY", "AQAAAAEAACcQAAAAEEM96qhkyyqDzkX9z5K8klECCWZHKYJ3yX/imCTpYmODL4Y58Jmm6OzllpgI1n90Wg==", null, false, "", false, "Boby" },
                    { "cc79d607-6a40-45f6-83c7-b974a1fdb7cb", 0, "363852bb-966a-4d14-8578-20e9103509fb", "alek88@gmail.com", true, "Aleksandar", null, false, new DateTime(2019, 9, 30, 12, 49, 0, 823, DateTimeKind.Local), "Veljanovski", false, null, "ALEK88@GMAIL.COM", "ALEKS", "AQAAAAEAACcQAAAAECtyDoExvRD1PpuZ5sEcaXfUY7vL5TfbaK1BZBFIDz/nTb68HJL8kBNdYgFJeaHW8A==", null, false, "", false, "Aleks" }
                });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 9, 30, 12, 49, 0, 824, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 9, 30, 12, 49, 0, 824, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 9, 30, 12, 49, 0, 824, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "12f0fe8d-e3a3-440b-8b13-71bfd8adfd63", "7d918ee5-2cd5-44af-9b86-918775b704ba" },
                    { "cc79d607-6a40-45f6-83c7-b974a1fdb7cb", "fbb36bab-d88e-4da9-b35b-74591fe480e7" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 30, 12, 49, 0, 824, DateTimeKind.Local), "12f0fe8d-e3a3-440b-8b13-71bfd8adfd63" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 30, 12, 49, 0, 824, DateTimeKind.Local), "cc79d607-6a40-45f6-83c7-b974a1fdb7cb" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 30, 12, 49, 0, 824, DateTimeKind.Local), "12f0fe8d-e3a3-440b-8b13-71bfd8adfd63" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 30, 12, 49, 0, 824, DateTimeKind.Local), "cc79d607-6a40-45f6-83c7-b974a1fdb7cb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "12f0fe8d-e3a3-440b-8b13-71bfd8adfd63", "7d918ee5-2cd5-44af-9b86-918775b704ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cc79d607-6a40-45f6-83c7-b974a1fdb7cb", "fbb36bab-d88e-4da9-b35b-74591fe480e7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7d918ee5-2cd5-44af-9b86-918775b704ba", "fb249502-efd6-4062-85df-9f978f512a35" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "fbb36bab-d88e-4da9-b35b-74591fe480e7", "5783d00a-5039-4464-be73-854bdb27d8f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "12f0fe8d-e3a3-440b-8b13-71bfd8adfd63", "434539e3-e3dd-48ce-bff6-7503403f4ece" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cc79d607-6a40-45f6-83c7-b974a1fdb7cb", "363852bb-966a-4d14-8578-20e9103509fb" });

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "82676832-57dd-4c85-83fd-40597833ca9f", "5cb441ef-0ea6-4915-a258-3a52ed1698e0", "admin", "ADMIN" },
                    { "2e081021-14e0-40cf-94e0-7f50daa0f9b7", "982ac924-4e24-4d5e-a33c-81ac8e5a945e", "customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsItOnline", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f95f9f1f-0d02-42d4-9327-71b22a6618bf", 0, "650287fd-78a4-4e88-bca0-2a70d285ddb9", "bob@gmail.com", true, "Bob", false, new DateTime(2019, 9, 26, 15, 58, 8, 870, DateTimeKind.Local), "Bobsky", false, null, "BOB@GMAIL.COM", "BOBY", "AQAAAAEAACcQAAAAEODpFOdXqr5bnS75MdjqO/Xaj0BkCjbQS+cmTr9MmZokjXb/A5xE+1r9IWrQQfim3g==", null, false, "", false, "Boby" },
                    { "e07f3d4e-f09e-4d5b-9dbd-1592fa2ba99b", 0, "ce822b71-9b5a-4c1c-b312-9d64cd32ddb1", "alek88@gmail.com", true, "Aleksandar", false, new DateTime(2019, 9, 26, 15, 58, 8, 880, DateTimeKind.Local), "Veljanovski", false, null, "ALEK88@GMAIL.COM", "ALEKS", "AQAAAAEAACcQAAAAELxayfCUOdohhuBKcKAaRj/PgfYESg5D79wfWLfYom9qpmn6tAyrwqGEIDuFaubs/A==", null, false, "", false, "Aleks" }
                });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 9, 26, 15, 58, 8, 881, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 9, 26, 15, 58, 8, 881, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 9, 26, 15, 58, 8, 881, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "f95f9f1f-0d02-42d4-9327-71b22a6618bf", "82676832-57dd-4c85-83fd-40597833ca9f" },
                    { "e07f3d4e-f09e-4d5b-9dbd-1592fa2ba99b", "2e081021-14e0-40cf-94e0-7f50daa0f9b7" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 26, 15, 58, 8, 881, DateTimeKind.Local), "f95f9f1f-0d02-42d4-9327-71b22a6618bf" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 26, 15, 58, 8, 881, DateTimeKind.Local), "e07f3d4e-f09e-4d5b-9dbd-1592fa2ba99b" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 26, 15, 58, 8, 881, DateTimeKind.Local), "f95f9f1f-0d02-42d4-9327-71b22a6618bf" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 26, 15, 58, 8, 881, DateTimeKind.Local), "e07f3d4e-f09e-4d5b-9dbd-1592fa2ba99b" });
        }
    }
}
