using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginHistory",
                table: "LoginHistory");

            migrationBuilder.RenameTable(
                name: "LoginHistory",
                newName: "LoginHistories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginHistories",
                table: "LoginHistories",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 252, 16, 219, 198, 117, 230, 185, 241, 73, 127, 114, 89, 229, 188, 80, 34, 73, 134, 130, 31, 186, 219, 78, 110, 237, 225, 181, 186, 100, 238, 129 }, new byte[] { 97, 247, 11, 192, 115, 144, 78, 172, 235, 76, 190, 202, 199, 91, 107, 179, 201, 225, 248, 246, 231, 114, 30, 130, 105, 250, 42, 253, 106, 248, 27, 56, 228, 160, 46, 203, 21, 241, 175, 85, 78, 60, 27, 254, 90, 132, 160, 138, 99, 16, 237, 246, 222, 213, 14, 221, 239, 76, 59, 193, 235, 193, 16, 180 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginHistories",
                table: "LoginHistories");

            migrationBuilder.RenameTable(
                name: "LoginHistories",
                newName: "LoginHistory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginHistory",
                table: "LoginHistory",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 26, 252, 183, 97, 55, 161, 63, 235, 64, 250, 167, 195, 45, 240, 207, 158, 221, 254, 40, 35, 26, 232, 158, 78, 215, 143, 84, 117, 180, 209, 28 }, new byte[] { 248, 54, 230, 51, 24, 34, 172, 156, 125, 133, 163, 87, 149, 28, 21, 235, 146, 83, 9, 240, 202, 197, 136, 94, 41, 72, 114, 22, 147, 197, 228, 84, 164, 215, 198, 228, 180, 197, 68, 130, 218, 29, 9, 112, 219, 215, 55, 241, 88, 162, 186, 87, 36, 81, 114, 90, 224, 180, 217, 190, 159, 18, 22, 124 } });
        }
    }
}
