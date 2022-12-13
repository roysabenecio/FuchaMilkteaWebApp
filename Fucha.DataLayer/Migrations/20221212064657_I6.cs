using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockId",
                table: "PORecords");

            migrationBuilder.AlterColumn<string>(
                name: "MeasurementUnit",
                table: "PORecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "PORecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "StockName",
                table: "PORecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "DatePurchased", "Measure", "MeasurementUnit", "StockName" },
                values: new object[] { "MilkTeaFlavor", "Monday, 12 December 2022", 2.0, "Kilograms", "Okinawa" });

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "DatePurchased", "Measure", "MeasurementUnit", "StockName" },
                values: new object[] { "MilkTeaFlavor", "Monday, 12 December 2022", 2.0, "Kilograms", "Red Velvet" });

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "DatePurchased", "Measure", "MeasurementUnit", "StockName" },
                values: new object[] { "MilkTeaAddOn", "Monday, 12 December 2022", 2.0, "Kilograms", "Salted Caramel" });

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePurchased", "TotalAmount" },
                values: new object[] { "Monday, 12 December 2022", 2000.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePurchased", "SupplierId", "TotalAmount" },
                values: new object[] { "Monday, 12 December 2022", 1, 500.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "StockServingId" },
                values: new object[] { "Monday, 12 December 2022", null });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Monday, 12 December 2022", 0.0 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Monday, 12 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 106, 202, 200, 205, 161, 105, 124, 106, 207, 189, 187, 42, 237, 191, 115, 110, 33, 95, 157, 229, 64, 197, 64, 160, 123, 107, 62, 10, 73, 241, 239, 123 }, new byte[] { 29, 75, 251, 146, 201, 178, 154, 7, 217, 146, 66, 245, 250, 83, 129, 183, 44, 161, 166, 192, 72, 206, 135, 241, 149, 245, 90, 191, 86, 226, 234, 158, 149, 157, 111, 157, 51, 103, 53, 163, 1, 206, 50, 103, 36, 248, 206, 193, 219, 84, 9, 168, 218, 194, 180, 109, 206, 102, 7, 16, 179, 127, 44, 35 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockName",
                table: "PORecords");

            migrationBuilder.AlterColumn<int>(
                name: "MeasurementUnit",
                table: "PORecords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "PORecords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "PORecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "DatePurchased", "Measure", "MeasurementUnit", "StockId" },
                values: new object[] { 0, "Sunday, 11 December 2022", 100.0, 1, 1 });

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "DatePurchased", "Measure", "MeasurementUnit", "StockId" },
                values: new object[] { 0, "Sunday, 11 December 2022", 50.0, 1, 2 });

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "DatePurchased", "Measure", "MeasurementUnit", "StockId" },
                values: new object[] { 1, "Sunday, 11 December 2022", 50.0, 1, 4 });

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePurchased", "TotalAmount" },
                values: new object[] { "Sunday, 11 December 2022", 100.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePurchased", "SupplierId", "TotalAmount" },
                values: new object[] { "Sunday, 11 December 2022", 3, 50.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "StockServingId" },
                values: new object[] { "Sunday, 11 December 2022", 1 });

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
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

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
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

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
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

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
                columns: new[] { "DateAdded", "Measure" },
                values: new object[] { "Sunday, 11 December 2022", 2.0 });

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
    }
}
