using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CriticalLevel",
                table: "Stocks",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LowLevel",
                table: "Stocks",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OverStockLevel",
                table: "Stocks",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Status" },
                values: new object[] { "Sunday, 11 December 2022", 3 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Sunday, 11 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 196, 122, 40, 239, 200, 150, 53, 211, 223, 19, 106, 98, 49, 1, 10, 45, 73, 164, 2, 47, 98, 178, 206, 94, 240, 236, 34, 3, 194, 15, 213, 10 }, new byte[] { 186, 238, 174, 180, 179, 150, 53, 212, 105, 169, 60, 25, 205, 132, 222, 206, 103, 151, 37, 126, 2, 117, 217, 181, 182, 173, 173, 67, 103, 22, 86, 63, 142, 76, 4, 72, 230, 229, 195, 90, 212, 89, 245, 180, 180, 120, 149, 6, 176, 217, 153, 87, 110, 111, 67, 254, 141, 160, 109, 37, 128, 12, 85, 45 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CriticalLevel",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "LowLevel",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "OverStockLevel",
                table: "Stocks");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Status" },
                values: new object[] { "Saturday, 10 December 2022", 2 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Saturday, 10 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 227, 236, 60, 235, 17, 155, 223, 22, 114, 43, 4, 154, 253, 62, 151, 167, 59, 201, 6, 206, 1, 199, 226, 88, 0, 17, 138, 169, 163, 24, 149, 160 }, new byte[] { 94, 193, 74, 102, 84, 219, 212, 220, 11, 228, 94, 68, 237, 47, 143, 23, 129, 166, 4, 127, 15, 87, 186, 185, 48, 2, 104, 101, 223, 113, 83, 123, 12, 234, 209, 109, 19, 84, 197, 74, 86, 126, 236, 184, 237, 8, 3, 77, 239, 118, 188, 132, 197, 196, 19, 195, 188, 34, 23, 185, 161, 167, 166, 105 } });
        }
    }
}
