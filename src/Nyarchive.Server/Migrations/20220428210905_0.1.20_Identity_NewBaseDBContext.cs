using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nyarchive.Server.Migrations
{
    public partial class _0120_Identity_NewBaseDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "ConcurrencyStamp",
                value: "4bab333d-6b7c-4df4-b3d0-f63d166961e2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fae5db5-da2d-40cc-b043-201f4612e5ee", "AQAAAAEAACcQAAAAEF62lrNuqSKL2Ud+BTwjLq7VlwBIYQfTlDqTvbcxsigADWPMuy1helRDe+Ap0e2c1A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "ConcurrencyStamp",
                value: "86fb19d8-9fa9-4a18-b8e9-53bb49e6827f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8470cf2-5fff-4e7c-8204-0135b0f5353c", "AQAAAAEAACcQAAAAEFWbAu1jdg0NUefip9i2VYQCmn0BM5psUxrkWmUKVLX31cYS9eZlord6fTIH9eskRg==" });
        }
    }
}
