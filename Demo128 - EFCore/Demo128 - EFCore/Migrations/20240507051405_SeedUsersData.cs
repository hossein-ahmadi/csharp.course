using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo128___EFCore.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Disabled", "Password", "RegisterDate", "Role", "Username" },
                values: new object[] { 1, false, "123456", new DateTime(2024, 5, 7, 8, 44, 5, 495, DateTimeKind.Local).AddTicks(4660), "sysadmin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
