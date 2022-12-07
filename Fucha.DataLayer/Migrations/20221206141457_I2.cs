using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Tuesday, 06 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 41, 66, 54, 232, 85, 230, 21, 50, 30, 198, 111, 10, 71, 215, 113, 170, 145, 39, 75, 69, 14, 145, 191, 197, 224, 139, 147, 136, 134, 52, 218 }, new byte[] { 102, 82, 102, 208, 115, 80, 155, 182, 252, 78, 23, 136, 63, 57, 53, 239, 53, 197, 74, 197, 148, 95, 69, 240, 243, 188, 33, 250, 93, 251, 193, 79, 47, 119, 106, 167, 69, 71, 0, 140, 138, 187, 50, 117, 158, 251, 143, 162, 127, 30, 246, 73, 73, 58, 40, 132, 100, 100, 103, 246, 137, 180, 85, 98 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: "Monday, 05 December 2022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "r");
        }
    }
}
