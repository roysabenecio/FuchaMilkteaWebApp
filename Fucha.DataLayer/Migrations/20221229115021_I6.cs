using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 92, 66, 87, 138, 79, 176, 204, 196, 40, 232, 15, 166, 66, 255, 43, 149, 210, 95, 65, 58, 116, 205, 16, 34, 0, 190, 46, 60, 75, 27, 181, 245 }, new byte[] { 31, 117, 119, 29, 64, 202, 27, 90, 33, 206, 63, 8, 161, 91, 157, 188, 75, 13, 18, 75, 255, 94, 25, 153, 223, 160, 227, 158, 84, 123, 180, 86, 157, 106, 51, 175, 77, 93, 85, 80, 225, 159, 54, 163, 14, 215, 133, 64, 210, 231, 4, 8, 239, 180, 205, 254, 238, 37, 173, 89, 74, 235, 121, 46 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 160, 11, 7, 157, 89, 107, 78, 86, 104, 247, 14, 72, 97, 40, 28, 246, 158, 103, 5, 188, 32, 170, 13, 104, 111, 255, 171, 66, 52, 223, 8 }, new byte[] { 164, 139, 46, 2, 152, 21, 241, 218, 96, 248, 62, 211, 88, 116, 213, 109, 151, 42, 165, 13, 156, 151, 194, 168, 93, 45, 253, 191, 136, 117, 99, 3, 118, 247, 188, 16, 102, 4, 68, 180, 62, 152, 19, 214, 93, 4, 6, 178, 61, 72, 0, 100, 191, 60, 14, 175, 114, 209, 130, 179, 194, 43, 34, 114 } });
        }
    }
}
