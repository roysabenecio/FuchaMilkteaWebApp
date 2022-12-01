using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 5, 135.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 5, 135.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 5, 135.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 5, 135.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 50.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 25.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 40.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 30.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 25.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 7, 88.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 7, 149.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 8, 249.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 8, 380.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 8, 649.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 50.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 25.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 40.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 30.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 6, 25.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 7, 88.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 7, 149.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 8, 249.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 8, 380.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 8, 649.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 4, 115.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 5, 135.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 5, 135.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 5, 135.0 });

            migrationBuilder.UpdateData(
                table: "MenuPrices",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MenuCategoryId", "Price" },
                values: new object[] { 5, 135.0 });
        }
    }
}
