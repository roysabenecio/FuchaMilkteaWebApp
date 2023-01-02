using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 160, 11, 7, 157, 89, 107, 78, 86, 104, 247, 14, 72, 97, 40, 28, 246, 158, 103, 5, 188, 32, 170, 13, 104, 111, 255, 171, 66, 52, 223, 8 }, new byte[] { 164, 139, 46, 2, 152, 21, 241, 218, 96, 248, 62, 211, 88, 116, 213, 109, 151, 42, 165, 13, 156, 151, 194, 168, 93, 45, 253, 191, 136, 117, 99, 3, 118, 247, 188, 16, 102, 4, 68, 180, 62, 152, 19, 214, 93, 4, 6, 178, 61, 72, 0, 100, 191, 60, 14, 175, 114, 209, 130, 179, 194, 43, 34, 114 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 169, 211, 171, 84, 60, 6, 148, 201, 59, 38, 145, 150, 248, 166, 209, 73, 155, 94, 27, 86, 152, 37, 30, 56, 82, 68, 69, 47, 245, 212, 35 }, new byte[] { 20, 189, 214, 131, 139, 213, 176, 175, 52, 155, 176, 87, 109, 96, 139, 94, 42, 181, 101, 5, 46, 215, 90, 62, 208, 173, 199, 16, 23, 113, 252, 136, 223, 65, 247, 51, 128, 142, 174, 96, 162, 154, 184, 14, 238, 134, 161, 80, 248, 59, 65, 118, 215, 105, 99, 103, 29, 3, 235, 42, 19, 71, 157, 250 } });
        }
    }
}
