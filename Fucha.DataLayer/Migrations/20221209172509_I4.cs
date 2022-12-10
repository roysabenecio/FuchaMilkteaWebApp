using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 70,
                column: "Measure",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 247, 11, 65, 240, 245, 124, 228, 89, 177, 79, 92, 113, 177, 68, 245, 206, 207, 150, 233, 160, 130, 129, 206, 98, 80, 69, 200, 215, 206, 77, 153, 22 }, new byte[] { 29, 87, 93, 136, 16, 72, 78, 31, 76, 141, 237, 94, 16, 196, 232, 90, 51, 86, 160, 18, 118, 37, 201, 4, 32, 191, 60, 4, 32, 193, 13, 101, 176, 18, 171, 10, 101, 194, 18, 230, 204, 131, 197, 98, 207, 95, 33, 177, 121, 195, 193, 41, 50, 189, 21, 54, 88, 1, 187, 134, 189, 125, 56, 103 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 70,
                column: "Measure",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 85, 170, 210, 41, 27, 13, 220, 149, 145, 131, 245, 109, 183, 176, 94, 191, 194, 241, 96, 229, 245, 188, 200, 28, 89, 191, 51, 239, 23, 172, 188 }, new byte[] { 176, 68, 242, 223, 148, 70, 159, 240, 244, 9, 222, 147, 131, 22, 209, 8, 194, 99, 123, 165, 206, 244, 196, 58, 156, 220, 250, 38, 110, 164, 150, 94, 166, 139, 184, 83, 95, 58, 105, 65, 47, 247, 184, 75, 206, 254, 138, 17, 161, 36, 105, 72, 250, 113, 109, 193, 110, 142, 38, 144, 153, 23, 99, 181 } });
        }
    }
}
