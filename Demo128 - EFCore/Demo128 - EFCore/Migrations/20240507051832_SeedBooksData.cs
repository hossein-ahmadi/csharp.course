using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo128___EFCore.Migrations
{
    /// <inheritdoc />
    public partial class SeedBooksData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "ISBN", "Title" },
                values: new object[,]
                {
                    { 1, 1, "B12345_1", "کتاب شماره 1" },
                    { 2, 1, "B12345_2", "کتاب شماره 2" },
                    { 3, 1, "B12345_3", "کتاب شماره 3" },
                    { 4, 1, "B12345_4", "کتاب شماره 4" },
                    { 5, 1, "B12345_5", "کتاب شماره 5" },
                    { 6, 1, "B12345_6", "کتاب شماره 6" },
                    { 7, 1, "B12345_7", "کتاب شماره 7" },
                    { 8, 1, "B12345_8", "کتاب شماره 8" },
                    { 9, 1, "B12345_9", "کتاب شماره 9" },
                    { 10, 1, "B12345_10", "کتاب شماره 10" },
                    { 11, 1, "B12345_11", "کتاب شماره 11" },
                    { 12, 1, "B12345_12", "کتاب شماره 12" },
                    { 13, 1, "B12345_13", "کتاب شماره 13" },
                    { 14, 1, "B12345_14", "کتاب شماره 14" },
                    { 15, 1, "B12345_15", "کتاب شماره 15" },
                    { 16, 1, "B12345_16", "کتاب شماره 16" },
                    { 17, 1, "B12345_17", "کتاب شماره 17" },
                    { 18, 1, "B12345_18", "کتاب شماره 18" },
                    { 19, 1, "B12345_19", "کتاب شماره 19" },
                    { 20, 1, "B12345_20", "کتاب شماره 20" },
                    { 21, 1, "B12345_21", "کتاب شماره 21" },
                    { 22, 1, "B12345_22", "کتاب شماره 22" },
                    { 23, 1, "B12345_23", "کتاب شماره 23" },
                    { 24, 1, "B12345_24", "کتاب شماره 24" },
                    { 25, 1, "B12345_25", "کتاب شماره 25" },
                    { 26, 1, "B12345_26", "کتاب شماره 26" },
                    { 27, 1, "B12345_27", "کتاب شماره 27" },
                    { 28, 1, "B12345_28", "کتاب شماره 28" },
                    { 29, 1, "B12345_29", "کتاب شماره 29" },
                    { 30, 1, "B12345_30", "کتاب شماره 30" },
                    { 31, 1, "B12345_31", "کتاب شماره 31" },
                    { 32, 1, "B12345_32", "کتاب شماره 32" },
                    { 33, 1, "B12345_33", "کتاب شماره 33" },
                    { 34, 1, "B12345_34", "کتاب شماره 34" },
                    { 35, 1, "B12345_35", "کتاب شماره 35" },
                    { 36, 1, "B12345_36", "کتاب شماره 36" },
                    { 37, 1, "B12345_37", "کتاب شماره 37" },
                    { 38, 1, "B12345_38", "کتاب شماره 38" },
                    { 39, 1, "B12345_39", "کتاب شماره 39" },
                    { 40, 1, "B12345_40", "کتاب شماره 40" },
                    { 41, 1, "B12345_41", "کتاب شماره 41" },
                    { 42, 1, "B12345_42", "کتاب شماره 42" },
                    { 43, 1, "B12345_43", "کتاب شماره 43" },
                    { 44, 1, "B12345_44", "کتاب شماره 44" },
                    { 45, 1, "B12345_45", "کتاب شماره 45" },
                    { 46, 1, "B12345_46", "کتاب شماره 46" },
                    { 47, 1, "B12345_47", "کتاب شماره 47" },
                    { 48, 1, "B12345_48", "کتاب شماره 48" },
                    { 49, 1, "B12345_49", "کتاب شماره 49" },
                    { 50, 1, "B12345_50", "کتاب شماره 50" },
                    { 51, 1, "B12345_51", "کتاب شماره 51" },
                    { 52, 1, "B12345_52", "کتاب شماره 52" },
                    { 53, 1, "B12345_53", "کتاب شماره 53" },
                    { 54, 1, "B12345_54", "کتاب شماره 54" },
                    { 55, 1, "B12345_55", "کتاب شماره 55" },
                    { 56, 1, "B12345_56", "کتاب شماره 56" },
                    { 57, 1, "B12345_57", "کتاب شماره 57" },
                    { 58, 1, "B12345_58", "کتاب شماره 58" },
                    { 59, 1, "B12345_59", "کتاب شماره 59" },
                    { 60, 1, "B12345_60", "کتاب شماره 60" },
                    { 61, 1, "B12345_61", "کتاب شماره 61" },
                    { 62, 1, "B12345_62", "کتاب شماره 62" },
                    { 63, 1, "B12345_63", "کتاب شماره 63" },
                    { 64, 1, "B12345_64", "کتاب شماره 64" },
                    { 65, 1, "B12345_65", "کتاب شماره 65" },
                    { 66, 1, "B12345_66", "کتاب شماره 66" },
                    { 67, 1, "B12345_67", "کتاب شماره 67" },
                    { 68, 1, "B12345_68", "کتاب شماره 68" },
                    { 69, 1, "B12345_69", "کتاب شماره 69" },
                    { 70, 1, "B12345_70", "کتاب شماره 70" },
                    { 71, 1, "B12345_71", "کتاب شماره 71" },
                    { 72, 1, "B12345_72", "کتاب شماره 72" },
                    { 73, 1, "B12345_73", "کتاب شماره 73" },
                    { 74, 1, "B12345_74", "کتاب شماره 74" },
                    { 75, 1, "B12345_75", "کتاب شماره 75" },
                    { 76, 1, "B12345_76", "کتاب شماره 76" },
                    { 77, 1, "B12345_77", "کتاب شماره 77" },
                    { 78, 1, "B12345_78", "کتاب شماره 78" },
                    { 79, 1, "B12345_79", "کتاب شماره 79" },
                    { 80, 1, "B12345_80", "کتاب شماره 80" },
                    { 81, 1, "B12345_81", "کتاب شماره 81" },
                    { 82, 1, "B12345_82", "کتاب شماره 82" },
                    { 83, 1, "B12345_83", "کتاب شماره 83" },
                    { 84, 1, "B12345_84", "کتاب شماره 84" },
                    { 85, 1, "B12345_85", "کتاب شماره 85" },
                    { 86, 1, "B12345_86", "کتاب شماره 86" },
                    { 87, 1, "B12345_87", "کتاب شماره 87" },
                    { 88, 1, "B12345_88", "کتاب شماره 88" },
                    { 89, 1, "B12345_89", "کتاب شماره 89" },
                    { 90, 1, "B12345_90", "کتاب شماره 90" },
                    { 91, 1, "B12345_91", "کتاب شماره 91" },
                    { 92, 1, "B12345_92", "کتاب شماره 92" },
                    { 93, 1, "B12345_93", "کتاب شماره 93" },
                    { 94, 1, "B12345_94", "کتاب شماره 94" },
                    { 95, 1, "B12345_95", "کتاب شماره 95" },
                    { 96, 1, "B12345_96", "کتاب شماره 96" },
                    { 97, 1, "B12345_97", "کتاب شماره 97" },
                    { 98, 1, "B12345_98", "کتاب شماره 98" },
                    { 99, 1, "B12345_99", "کتاب شماره 99" },
                    { 100, 1, "B12345_100", "کتاب شماره 100" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 7, 8, 48, 32, 678, DateTimeKind.Local).AddTicks(9085));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2024, 5, 7, 8, 46, 8, 319, DateTimeKind.Local).AddTicks(3804));
        }
    }
}
