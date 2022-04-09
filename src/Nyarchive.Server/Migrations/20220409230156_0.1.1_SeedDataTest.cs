using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nyarchive.Server.Migrations
{
    public partial class _011_SeedDataTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0250677d-c42f-4426-960e-f06e434e0614"), "Deutsch" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f52dc481-def9-4574-abcb-451bfb0f18c6"), "English" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("0250677d-c42f-4426-960e-f06e434e0614"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("f52dc481-def9-4574-abcb-451bfb0f18c6"));
        }
    }
}
