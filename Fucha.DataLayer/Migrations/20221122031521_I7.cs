using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockStatus",
                table: "Stocks",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "StockCategory",
                table: "Stocks",
                newName: "Category");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContactNumber",
                value: 9171284151L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Stocks",
                newName: "StockStatus");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Stocks",
                newName: "StockCategory");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContactNumber",
                value: 91712841510L);
        }
    }
}
