using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumDataAccess.Migrations
{
    public partial class seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 8, 3, 10, 3, 12, 557, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 8, 3, 10, 3, 12, 559, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 8, 3, 10, 3, 12, 560, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Created", "ForumId", "Title", "UserId" },
                values: new object[] { 2, "I’ve been working with javascript for a while now and I’m comfortable with it. I like all the libraries and flexibility that I have with it. I want to eventually start messing around with another language like Python or even Java but I’m not really seeing much of what something like python adds that I can’t really already do in javascript.Can someone explain to this noob why I should start learning Python (or Java)?", new DateTime(2019, 8, 3, 10, 3, 12, 560, DateTimeKind.Local), 1, "Is Python worth learning 2019?", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 8, 2, 9, 23, 37, 79, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 8, 2, 9, 23, 37, 81, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 8, 2, 9, 23, 37, 81, DateTimeKind.Local));
        }
    }
}
