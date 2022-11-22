using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Tuesday, 22 November 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Tuesday, 22 November 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Tuesday, 22 November 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Tuesday, 22 November 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Tuesday, 22 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Tuesday, 22 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Tuesday, 22 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Tuesday, 22 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Tuesday, 22 November 2022");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Monday, 21 November 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Monday, 21 November 2022");

            migrationBuilder.UpdateData(
                table: "PORecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePurchased",
                value: "Monday, 21 November 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Monday, 21 November 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Monday, 21 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Monday, 21 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Monday, 21 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Monday, 21 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: "Monday, 21 November 2022");
        }
    }
}
