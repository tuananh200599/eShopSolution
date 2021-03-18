using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 9, 12, 59, 710, DateTimeKind.Local).AddTicks(2756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 10, 34, 12, 173, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 10, 34, 12, 173, DateTimeKind.Local).AddTicks(6726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 9, 12, 59, 710, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ca5ab7c5-6a78-4080-866e-bd41f9c07fd1"),
                column: "ConcurrencyStamp",
                value: "1b3ff728-0a86-4d38-a0f5-bef5151b093c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6e1e441-93c5-4046-85ff-a3e009f3cf91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9db108e-63c6-4efa-881c-9c0ef69c0bdc", "AQAAAAEAACcQAAAAEKz6SsQZNkePeRYVk1ASEhdzb0MT5b3B6bzEFNOXk3H2/U028TLIckDcV8fpOCKlEA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 17, 10, 34, 12, 194, DateTimeKind.Local).AddTicks(7891));
        }
    }
}
