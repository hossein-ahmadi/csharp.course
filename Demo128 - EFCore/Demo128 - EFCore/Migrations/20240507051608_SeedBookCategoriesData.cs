using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo128___EFCore.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookCategoriesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "کتاب های داستانی" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 7, 8, 46, 8, 319, DateTimeKind.Local).AddTicks(3804));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 7, 8, 44, 5, 495, DateTimeKind.Local).AddTicks(4660));
        }
    }
}
