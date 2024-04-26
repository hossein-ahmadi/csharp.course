using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo128___EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddIsSysAdminForUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSysAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSysAdmin",
                table: "Users");
        }
    }
}
