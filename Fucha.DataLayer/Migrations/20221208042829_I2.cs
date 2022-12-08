using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHistory", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Thursday, 08 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 26, 252, 183, 97, 55, 161, 63, 235, 64, 250, 167, 195, 45, 240, 207, 158, 221, 254, 40, 35, 26, 232, 158, 78, 215, 143, 84, 117, 180, 209, 28 }, new byte[] { 248, 54, 230, 51, 24, 34, 172, 156, 125, 133, 163, 87, 149, 28, 21, 235, 146, 83, 9, 240, 202, 197, 136, 94, 41, 72, 114, 22, 147, 197, 228, 84, 164, 215, 198, 228, 180, 197, 68, 130, 218, 29, 9, 112, 219, 215, 55, 241, 88, 162, 186, 87, 36, 81, 114, 90, 224, 180, 217, 190, 159, 18, 22, 124 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginHistory");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Wednesday, 07 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 26, 113, 42, 160, 195, 166, 254, 169, 133, 34, 6, 23, 185, 60, 103, 61, 128, 229, 87, 206, 122, 111, 255, 65, 218, 3, 52, 123, 26, 124, 224, 89 }, new byte[] { 37, 74, 133, 52, 46, 195, 254, 179, 97, 6, 84, 103, 104, 143, 194, 207, 2, 1, 92, 123, 190, 44, 2, 66, 252, 193, 171, 21, 115, 87, 177, 78, 110, 200, 19, 170, 88, 167, 211, 148, 173, 119, 12, 0, 48, 3, 94, 178, 90, 214, 120, 91, 245, 118, 231, 39, 9, 152, 194, 15, 71, 125, 113, 237 } });
        }
    }
}
