using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Snacks" },
                    { 7, "Ala Carte" },
                    { 8, "Chicken Wings" }
                });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 6, 21, 50.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 6, 22, 25.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 6, 23, 40.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 6, 24, 30.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 6, 25, 25.0 });

            migrationBuilder.InsertData(
                table: "MenuPrices",
                columns: new[] { "Id", "MenuCategoryId", "MenuId", "Price", "SizeId" },
                values: new object[,]
                {
                    { 19, 4, 41, 115.0, null },
                    { 20, 4, 42, 115.0, null },
                    { 21, 4, 43, 115.0, null },
                    { 22, 4, 44, 115.0, null },
                    { 23, 4, 45, 115.0, null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "MenuCategoryId", "Name" },
                values: new object[,]
                {
                    { 21, 6, "Hungarian Solo" },
                    { 22, 6, "Assorted Balls" },
                    { 23, 6, "Gyoza" },
                    { 24, 6, "Fries" },
                    { 25, 6, "Siomai" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 4, 41, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 4, 42, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 4, 43, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 4, 44, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MenuCategoryId", "MenuId", "Price" },
                values: new object[] { 4, 45, 115.0 });
        }
    }
}
