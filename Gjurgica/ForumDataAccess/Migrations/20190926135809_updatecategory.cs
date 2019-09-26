using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumDataAccess.Migrations
{
    public partial class updatecategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4d920455-f1e6-4315-a60c-d39de7bfb1a7", "2fca2757-ee22-4593-bfb3-774340ec04ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "af0a7884-8162-4849-8c78-37b9018af963", "b0d72c84-45bb-43f2-84b6-1fcc73363aa4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2fca2757-ee22-4593-bfb3-774340ec04ff", "61437219-e2e8-497a-be08-224fac6345b0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b0d72c84-45bb-43f2-84b6-1fcc73363aa4", "8478f539-2429-49cd-9342-41ccbfd2ec2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4d920455-f1e6-4315-a60c-d39de7bfb1a7", "30f52c07-ee7b-4154-a771-b42c6a89ccea" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "af0a7884-8162-4849-8c78-37b9018af963", "cbd9a843-15f8-4e4e-b03d-9df9923a1fe9" });

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                nullable: true);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.cbronline.com/wp-content/uploads/2017/06/What-Your-Business-Needs-To-Resolve-Tech-And-Software-Problems.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fblogs-images.forbes.com%2Fforbes-finds%2Ffiles%2F2019%2F04%2Fmariokart8-1200x675.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fblogs-images.forbes.com%2Fallbusiness%2Ffiles%2F2018%2F10%2Fmachine-learning-1200x808.jpg");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fca2757-ee22-4593-bfb3-774340ec04ff", "61437219-e2e8-497a-be08-224fac6345b0", "admin", "ADMIN" },
                    { "b0d72c84-45bb-43f2-84b6-1fcc73363aa4", "8478f539-2429-49cd-9342-41ccbfd2ec2f", "customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsItOnline", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4d920455-f1e6-4315-a60c-d39de7bfb1a7", 0, "30f52c07-ee7b-4154-a771-b42c6a89ccea", "bob@gmail.com", true, "Bob", false, new DateTime(2019, 9, 26, 15, 20, 15, 285, DateTimeKind.Local), "Bobsky", false, null, "BOB@GMAIL.COM", "BOBY", "AQAAAAEAACcQAAAAEBwb4mO9FzyUk2c92+U6AjqLpAiVoD9/K/9/xeQydzKUQkW0XACQKBauI4Yq9asN+Q==", null, false, "", false, "Boby" },
                    { "af0a7884-8162-4849-8c78-37b9018af963", 0, "cbd9a843-15f8-4e4e-b03d-9df9923a1fe9", "alek88@gmail.com", true, "Aleksandar", false, new DateTime(2019, 9, 26, 15, 20, 15, 295, DateTimeKind.Local), "Veljanovski", false, null, "ALEK88@GMAIL.COM", "ALEKS", "AQAAAAEAACcQAAAAEJnbxD3N5viIEMRU8RvRXqGn/8m3QhwdYY/hPSeNLCH7eRft4h8sOkhWVTK/SFixlw==", null, false, "", false, "Aleks" }
                });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "4d920455-f1e6-4315-a60c-d39de7bfb1a7", "2fca2757-ee22-4593-bfb3-774340ec04ff" },
                    { "af0a7884-8162-4849-8c78-37b9018af963", "b0d72c84-45bb-43f2-84b6-1fcc73363aa4" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), "4d920455-f1e6-4315-a60c-d39de7bfb1a7" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), "af0a7884-8162-4849-8c78-37b9018af963" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), "4d920455-f1e6-4315-a60c-d39de7bfb1a7" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "UserId" },
                values: new object[] { new DateTime(2019, 9, 26, 15, 20, 15, 296, DateTimeKind.Local), "af0a7884-8162-4849-8c78-37b9018af963" });
        }
    }
}
