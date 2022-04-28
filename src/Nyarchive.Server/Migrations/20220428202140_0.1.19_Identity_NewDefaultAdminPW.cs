using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nyarchive.Server.Migrations
{
    public partial class _0119_Identity_NewDefaultAdminPW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "ConcurrencyStamp",
                value: "105d752f-34f5-4be0-aa23-8efe8f213e55");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b503a64-fb35-4984-a8bf-f92b98a9d86d", "AQAAAAEAACcQAAAAEAC7P54UusoX1+eB1x+4bBKTQdkQuyjqIsW/Gm1+8BPmbO9j4/zUPoxh0ZH7saA/RQ==" });
        }
    }
}
