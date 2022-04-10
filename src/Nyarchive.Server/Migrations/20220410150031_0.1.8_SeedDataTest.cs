using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nyarchive.Server.Migrations
{
    public partial class _018_SeedDataTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArticleTransactionAdds",
                columns: new[] { "Id", "ArticleId", "ExpirationDate", "Tag", "Timestamp" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 4, 10, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ArticleTransactionRemoves",
                columns: new[] { "Id", "ArticleTransactionAddId", "QuantityOfUnit", "Timestamp", "UnitId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 250m, new DateTime(2022, 4, 10, 17, 45, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000002") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleTransactionRemoves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ArticleTransactionAdds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));
        }
    }
}
