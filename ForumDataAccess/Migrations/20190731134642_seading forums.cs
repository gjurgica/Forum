using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumDataAccess.Migrations
{
    public partial class seadingforums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Created", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, new DateTime(2019, 7, 31, 15, 46, 42, 131, DateTimeKind.Local), "Python is an interpreted, high-level, general-purpose programming language.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/1200px-Python-logo-notext.svg.png", "Pyton" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Created", "Description", "ImageUrl", "Title" },
                values: new object[] { 2, new DateTime(2019, 7, 31, 15, 46, 42, 134, DateTimeKind.Local), "ReactJS is an open-source JavaScript library which is used for building user interfaces specifically for single page applications.", "https://hackernoon.com/hn-images/1*y6C4nSvy2Woe0m7bWEn4BA.png", "React.js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "Url", "UserName" },
                values: new object[] { 1, "bob@gmail.com", "Bob", "Bobsky", "ananas", null, "Boby" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "Url", "UserName" },
                values: new object[] { 2, "alek88@gmail.com", "Aleksandar", "Veljanovski", "alek789", null, "Aleks" });
        }
    }
}
