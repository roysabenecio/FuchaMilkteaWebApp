using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SalesTransaction",
                columns: new[] { "Id", "DateSold", "ItemQuantity", "TotalSales", "UserId" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 2950.0, 1 },
                    { 11, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 6254.0, 1 },
                    { 12, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 8513.0, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 83, 29, 67, 198, 59, 183, 243, 65, 20, 122, 133, 193, 63, 144, 176, 79, 145, 188, 100, 167, 139, 190, 154, 156, 162, 179, 127, 207, 126, 33, 114 }, new byte[] { 176, 242, 95, 155, 226, 133, 195, 31, 173, 93, 94, 253, 60, 114, 240, 140, 93, 255, 87, 108, 251, 3, 110, 230, 83, 192, 228, 141, 119, 16, 236, 227, 129, 119, 146, 237, 109, 75, 126, 122, 206, 12, 53, 14, 239, 246, 210, 193, 235, 119, 60, 65, 92, 208, 81, 42, 58, 38, 117, 88, 174, 208, 139, 41 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesTransaction",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalesTransaction",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SalesTransaction",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 228, 154, 135, 45, 2, 84, 209, 134, 7, 203, 210, 173, 36, 111, 57, 93, 249, 2, 73, 95, 218, 233, 208, 222, 255, 106, 199, 253, 71, 42, 228 }, new byte[] { 20, 189, 200, 140, 98, 182, 10, 188, 238, 164, 99, 227, 4, 124, 43, 230, 232, 249, 35, 186, 237, 90, 17, 81, 129, 74, 217, 98, 61, 11, 97, 173, 127, 47, 75, 117, 97, 143, 212, 208, 69, 103, 233, 185, 203, 215, 142, 225, 235, 64, 47, 7, 35, 168, 219, 184, 231, 26, 237, 71, 106, 89, 243, 119 } });
        }
    }
}
