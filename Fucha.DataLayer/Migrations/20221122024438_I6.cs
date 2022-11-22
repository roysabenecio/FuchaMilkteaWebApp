using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "PORecords",
                newName: "Measure");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PurchaseRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PurchaseRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PurchaseRecords");

            migrationBuilder.RenameColumn(
                name: "Measure",
                table: "PORecords",
                newName: "Quantity");
        }
    }
}
