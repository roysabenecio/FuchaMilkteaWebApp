using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseRecord");

            migrationBuilder.DeleteData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "PurchaseRecords");

            migrationBuilder.DropColumn(
                name: "MeasurementUnit",
                table: "PurchaseRecords");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "PurchaseRecords");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "PurchaseRecords",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "PurchaseRecords",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "PurchaseRecordId",
                table: "PurchaseRecords",
                newName: "ItemQuantity");

            migrationBuilder.CreateTable(
                name: "PORecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DatePurchased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseRecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PORecords", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PORecords",
                columns: new[] { "Id", "Category", "DatePurchased", "MeasurementUnit", "Price", "PurchaseRecordId", "Quantity", "StockId" },
                values: new object[,]
                {
                    { 1, 0, "Friday, 18 November 2022", 1, 100.0, 1, 100.0, 1 },
                    { 2, 0, "Friday, 18 November 2022", 1, 50.0, 1, 50.0, 2 },
                    { 3, 1, "Friday, 18 November 2022", 1, 50.0, 2, 50.0, 4 }
                });

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "ItemQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "SupplierId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PORecords");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "PurchaseRecords",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "PurchaseRecords",
                newName: "StockId");

            migrationBuilder.RenameColumn(
                name: "ItemQuantity",
                table: "PurchaseRecords",
                newName: "PurchaseRecordId");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "PurchaseRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnit",
                table: "PurchaseRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "PurchaseRecords",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "PurchaseRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePurchased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemQuantity = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseRecord", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PurchaseRecord",
                columns: new[] { "Id", "DatePurchased", "ItemQuantity", "SupplierId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Friday, 18 November 2022", 2, 1, 100.0 },
                    { 2, "Friday, 18 November 2022", 1, 3, 50.0 }
                });

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MeasurementUnit", "Price", "PurchaseRecordId" },
                values: new object[] { 1, 100.0, 1 });

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MeasurementUnit", "Price", "StockId" },
                values: new object[] { 1, 50.0, 2 });

            migrationBuilder.InsertData(
                table: "PurchaseRecords",
                columns: new[] { "Id", "Category", "DatePurchased", "MeasurementUnit", "Price", "PurchaseRecordId", "Quantity", "StockId" },
                values: new object[] { 3, 1, "Friday, 18 November 2022", 1, 50.0, 2, 50.0, 4 });
        }
    }
}
