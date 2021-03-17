using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 10, 34, 12, 173, DateTimeKind.Local).AddTicks(6726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 27, 14, 819, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ca5ab7c5-6a78-4080-866e-bd41f9c07fd1"), "1b3ff728-0a86-4d38-a0f5-bef5151b093c", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ca5ab7c5-6a78-4080-866e-bd41f9c07fd1"), new Guid("a6e1e441-93c5-4046-85ff-a3e009f3cf91") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a6e1e441-93c5-4046-85ff-a3e009f3cf91"), 0, "d9db108e-63c6-4efa-881c-9c0ef69c0bdc", new DateTime(1999, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "anh453138@gmail.com", true, "Anh", "Nguyen", false, null, "anh453138@gmail.com", "admin", "AQAAAAEAACcQAAAAEKz6SsQZNkePeRYVk1ASEhdzb0MT5b3B6bzEFNOXk3H2/U028TLIckDcV8fpOCKlEA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 17, 10, 34, 12, 194, DateTimeKind.Local).AddTicks(7891));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ca5ab7c5-6a78-4080-866e-bd41f9c07fd1"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ca5ab7c5-6a78-4080-866e-bd41f9c07fd1"), new Guid("a6e1e441-93c5-4046-85ff-a3e009f3cf91") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6e1e441-93c5-4046-85ff-a3e009f3cf91"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 27, 14, 819, DateTimeKind.Local).AddTicks(3263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 10, 34, 12, 173, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 17, 9, 27, 14, 840, DateTimeKind.Local).AddTicks(5682));
        }
    }
}
