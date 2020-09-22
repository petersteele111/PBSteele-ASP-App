using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PBsteele.Migrations
{
    public partial class FixedDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2020, 6, 5, 5, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 8, 15, 32, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2020, 7, 4, 12, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 21, 17, 25, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2020, 9, 1, 16, 10, 12, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2020, 9, 21, 14, 35, 56, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 21, 14, 58, 12, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990) });
        }
    }
}
