using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PORecord_Users_UserId",
                table: "PORecord");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRecords_Users_UserId",
                table: "PurchaseRecords");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseRecords_UserId",
                table: "PurchaseRecords");

            migrationBuilder.DropIndex(
                name: "IX_PORecord_UserId",
                table: "PORecord");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PurchaseRecords");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "PORecord");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PORecord");

            migrationBuilder.UpdateData(
                table: "PORecord",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePurchased", "ItemQuantity" },
                values: new object[] { "Friday, 18 November 2022", 2 });

            migrationBuilder.UpdateData(
                table: "PORecord",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Friday, 18 November 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Friday, 18 November 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "DatePurchased", "PORecordId", "StockId" },
                values: new object[] { 0, "Friday, 18 November 2022", 1, 2 });

            migrationBuilder.InsertData(
                table: "PurchaseRecords",
                columns: new[] { "Id", "Category", "DatePurchased", "MeasurementUnit", "PORecordId", "Price", "Quantity", "StockId" },
                values: new object[] { 3, 1, "Friday, 18 November 2022", 1, 2, 50.0, 50.0, 4 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SupplierId" },
                values: new object[] { "Okinawa", 1 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "StockCategory", "SupplierId" },
                values: new object[] { "Wintermelon", 0, 2 });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "DateAdded", "LastRestocked", "Measure", "MeasurementUnit", "Name", "StockCategory", "StockStatus", "SupplierId" },
                values: new object[] { 4, null, null, 5.0, 1, "Nutella", 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Friday, 18 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Friday, 18 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Friday, 18 November 2022");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PurchaseRecords",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "PORecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PORecord",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PORecord",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePurchased", "ItemQuantity" },
                values: new object[] { "Thursday, 17 November 2022", 1 });

            migrationBuilder.UpdateData(
                table: "PORecord",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePurchased",
                value: "Thursday, 17 November 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePurchased",
                value: "Thursday, 17 November 2022");

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "DatePurchased", "PORecordId", "StockId" },
                values: new object[] { 1, "Thursday, 17 November 2022", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SupplierId" },
                values: new object[] { "Wintermelon", 2 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "StockCategory", "SupplierId" },
                values: new object[] { "Nutella", 1, 3 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: "Thursday, 17 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: "Thursday, 17 November 2022");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: "Thursday, 17 November 2022");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRecords_UserId",
                table: "PurchaseRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PORecord_UserId",
                table: "PORecord",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PORecord_Users_UserId",
                table: "PORecord",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseRecords_Users_UserId",
                table: "PurchaseRecords",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
