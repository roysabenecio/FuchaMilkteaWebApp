using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PORecord");

            migrationBuilder.RenameColumn(
                name: "PORecordId",
                table: "PurchaseRecords",
                newName: "PurchaseRecordId");

            migrationBuilder.CreateTable(
                name: "PurchaseRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    DatePurchased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseRecord", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PurchaseRecord",
                columns: new[] { "Id", "DatePurchased", "ItemQuantity", "SupplierId", "TotalAmount" },
                values: new object[] { 1, "Friday, 18 November 2022", 2, 1, 100.0 });

            migrationBuilder.InsertData(
                table: "PurchaseRecord",
                columns: new[] { "Id", "DatePurchased", "ItemQuantity", "SupplierId", "TotalAmount" },
                values: new object[] { 2, "Friday, 18 November 2022", 1, 3, 50.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Red Velvet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseRecord");

            migrationBuilder.RenameColumn(
                name: "PurchaseRecordId",
                table: "PurchaseRecords",
                newName: "PORecordId");

            migrationBuilder.CreateTable(
                name: "PORecord",
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
                    table.PrimaryKey("PK_PORecord", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PORecord",
                columns: new[] { "Id", "DatePurchased", "ItemQuantity", "SupplierId", "TotalAmount" },
                values: new object[] { 1, "Friday, 18 November 2022", 2, 1, 100.0 });

            migrationBuilder.InsertData(
                table: "PORecord",
                columns: new[] { "Id", "DatePurchased", "ItemQuantity", "SupplierId", "TotalAmount" },
                values: new object[] { 2, "Friday, 18 November 2022", 1, 3, 50.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Okinawa");
        }
    }
}
