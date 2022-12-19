using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Squid balls");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Monday, 19 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "Admin", "Admin", new byte[] { 243, 46, 238, 214, 161, 15, 152, 192, 9, 61, 165, 187, 243, 121, 204, 75, 124, 145, 131, 227, 180, 190, 236, 24, 81, 79, 116, 144, 127, 226, 219, 119 }, new byte[] { 156, 242, 136, 32, 21, 166, 202, 216, 113, 193, 89, 101, 227, 87, 65, 183, 119, 72, 189, 246, 189, 126, 153, 50, 239, 242, 39, 196, 181, 198, 190, 136, 99, 220, 115, 44, 208, 76, 29, 122, 51, 30, 210, 41, 211, 78, 67, 47, 168, 38, 254, 169, 105, 131, 199, 237, 84, 84, 5, 35, 186, 180, 245, 79 }, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Squad balls");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Friday, 16 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "Roy", "Sabenecio", new byte[] { 28, 169, 69, 117, 153, 124, 132, 227, 32, 237, 94, 10, 78, 85, 204, 79, 69, 111, 138, 160, 186, 246, 36, 123, 92, 208, 178, 22, 59, 93, 207, 252 }, new byte[] { 117, 209, 251, 143, 65, 138, 194, 129, 137, 198, 170, 82, 46, 48, 196, 27, 85, 81, 155, 245, 246, 72, 2, 234, 141, 80, 224, 103, 232, 155, 114, 231, 175, 19, 200, 140, 175, 15, 151, 159, 12, 196, 238, 93, 205, 206, 230, 129, 239, 245, 86, 30, 53, 197, 131, 24, 125, 179, 238, 188, 35, 235, 85, 213 }, "r" });
        }
    }
}
