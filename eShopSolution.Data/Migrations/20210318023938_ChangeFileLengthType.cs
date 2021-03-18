using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 9, 39, 36, 674, DateTimeKind.Local).AddTicks(6537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 9, 12, 59, 710, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ca5ab7c5-6a78-4080-866e-bd41f9c07fd1"),
                column: "ConcurrencyStamp",
                value: "824103b4-ff29-4abc-8410-42430e2cf3a3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6e1e441-93c5-4046-85ff-a3e009f3cf91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfdd0c38-3f57-45a3-9808-4d3196858e73", "AQAAAAEAACcQAAAAEOiKwWxB1jy5daH22KmBuTwsXlUi1DgWhBGUfL7KksCf8lF8cL0YwnsBZOcnikfo2w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 18, 9, 39, 36, 696, DateTimeKind.Local).AddTicks(2496));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 9, 12, 59, 710, DateTimeKind.Local).AddTicks(2756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 9, 39, 36, 674, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ca5ab7c5-6a78-4080-866e-bd41f9c07fd1"),
                column: "ConcurrencyStamp",
                value: "38d75ed5-15c9-40d6-8dd3-cb643be3644f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6e1e441-93c5-4046-85ff-a3e009f3cf91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6a31142-a8cd-4011-b7c5-a79ca3152e1d", "AQAAAAEAACcQAAAAEKp9n34plpnEWTiBUJkYHiQch6HLjcuHro1VeKTi23C+yRmcDHUVdGHxmJEGNr8FpQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 18, 9, 12, 59, 749, DateTimeKind.Local).AddTicks(6250));
        }
    }
}
