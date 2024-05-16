using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo128___EFCore.Migrations
{
    /// <inheritdoc />
    public partial class RenameMemberAddressTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberAddress_Members_MemberId",
                table: "MemberAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberAddress",
                table: "MemberAddress");

            migrationBuilder.RenameTable(
                name: "MemberAddress",
                newName: "MembersAddresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembersAddresses",
                table: "MembersAddresses",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_MembersAddresses_Members_MemberId",
                table: "MembersAddresses",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembersAddresses_Members_MemberId",
                table: "MembersAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembersAddresses",
                table: "MembersAddresses");

            migrationBuilder.RenameTable(
                name: "MembersAddresses",
                newName: "MemberAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberAddress",
                table: "MemberAddress",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberAddress_Members_MemberId",
                table: "MemberAddress",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
