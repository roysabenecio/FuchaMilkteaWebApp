using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stocks");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Users",
                newName: "isRemoved");

            migrationBuilder.AlterColumn<int>(
                name: "StockStatus",
                table: "Stocks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Stocks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AddOnId",
                table: "Stocks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Stocks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "MenuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "MenuId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "MenuId",
                value: 3);

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "AddOnId", "DateAdded", "IsRemoved", "LastRestocked", "Measure", "MeasurementUnit", "MenuId", "StockCategory", "StockStatus", "SupplierId" },
                values: new object[] { 10, 3, null, false, null, 5.0, 0, null, 1, null, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "AddOnId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Stocks");

            migrationBuilder.RenameColumn(
                name: "isRemoved",
                table: "Users",
                newName: "isDeleted");

            migrationBuilder.AlterColumn<int>(
                name: "StockStatus",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MenuId", "Name" },
                values: new object[] { 0, "Okinawa" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MenuId", "Name" },
                values: new object[] { 0, "Red Velvet" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MenuId", "Name" },
                values: new object[] { 0, "Wintermelon" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "Cheesy Garlic");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "Ham 'N Cheese");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Peperoni");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "Hawaiian");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Beef Mushroom");

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "DateAdded", "LastRestocked", "Measure", "MeasurementUnit", "MenuId", "Name", "StockCategory", "StockStatus", "SupplierId" },
                values: new object[] { 4, null, null, 5.0, 1, 0, "Nutella", 1, 0, 3 });
        }
    }
}
