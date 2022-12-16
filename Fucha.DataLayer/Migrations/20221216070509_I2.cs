using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Module",
                table: "ActivityHistories",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 28, 169, 69, 117, 153, 124, 132, 227, 32, 237, 94, 10, 78, 85, 204, 79, 69, 111, 138, 160, 186, 246, 36, 123, 92, 208, 178, 22, 59, 93, 207, 252 }, new byte[] { 117, 209, 251, 143, 65, 138, 194, 129, 137, 198, 170, 82, 46, 48, 196, 27, 85, 81, 155, 245, 246, 72, 2, 234, 141, 80, 224, 103, 232, 155, 114, 231, 175, 19, 200, 140, 175, 15, 151, 159, 12, 196, 238, 93, 205, 206, 230, 129, 239, 245, 86, 30, 53, 197, 131, 24, 125, 179, 238, 188, 35, 235, 85, 213 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Module",
                table: "ActivityHistories");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Thursday, 15 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 190, 222, 103, 76, 63, 92, 203, 107, 161, 47, 238, 105, 150, 220, 186, 207, 57, 169, 173, 194, 0, 66, 153, 29, 218, 15, 64, 193, 190, 152, 73, 205 }, new byte[] { 38, 3, 97, 56, 228, 166, 74, 78, 208, 51, 53, 113, 12, 227, 60, 233, 91, 49, 244, 97, 150, 138, 224, 206, 54, 20, 106, 21, 192, 224, 109, 205, 79, 190, 86, 153, 137, 166, 58, 189, 175, 127, 245, 250, 51, 29, 41, 101, 30, 0, 141, 101, 152, 45, 183, 172, 216, 184, 8, 177, 194, 119, 230, 208 } });
        }
    }
}
