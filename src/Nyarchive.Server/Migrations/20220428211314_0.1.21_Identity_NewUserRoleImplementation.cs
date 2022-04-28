using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nyarchive.Server.Migrations
{
    public partial class _0121_Identity_NewUserRoleImplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "ConcurrencyStamp",
                value: "027ca360-1171-40f9-ab75-53d5bafc35f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df8ce448-d47f-4d74-9347-fdc947cc1d4a", "AQAAAAEAACcQAAAAEEMStjZaYESuH+TlbFHCIO2MOcYzFQpd7jIOksfArgBez7O4+Vmr/t71JsQrOTSYvA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
