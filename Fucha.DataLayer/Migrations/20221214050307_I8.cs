using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CriticalLevel", "LowLevel", "OverStockLevel" },
                values: new object[] { 0.14999999999999999, 0.29999999999999999, 3.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CriticalLevel", "LowLevel", "OverStockLevel" },
                values: new object[] { 0.14999999999999999, 0.29999999999999999, 3.0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CriticalLevel", "LowLevel", "OverStockLevel" },
                values: new object[] { 0.14999999999999999, 0.29999999999999999, 3.0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 143, 230, 2, 47, 212, 30, 131, 78, 106, 64, 22, 209, 153, 100, 172, 181, 135, 128, 0, 46, 159, 141, 226, 143, 204, 44, 250, 176, 163, 213, 124 }, new byte[] { 6, 17, 17, 53, 52, 20, 208, 65, 17, 242, 210, 234, 203, 108, 199, 66, 172, 5, 202, 18, 79, 181, 99, 2, 85, 33, 205, 155, 243, 163, 1, 80, 233, 123, 148, 71, 162, 49, 230, 36, 23, 136, 132, 254, 41, 214, 213, 30, 168, 227, 73, 4, 107, 163, 38, 16, 199, 147, 64, 96, 144, 195, 58, 103 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CriticalLevel", "LowLevel", "OverStockLevel" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CriticalLevel", "LowLevel", "OverStockLevel" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CriticalLevel", "LowLevel", "OverStockLevel" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 223, 162, 215, 140, 14, 134, 37, 252, 123, 77, 234, 152, 248, 124, 75, 58, 192, 109, 96, 58, 62, 106, 79, 110, 110, 166, 138, 55, 157, 26, 106, 46 }, new byte[] { 54, 33, 39, 39, 139, 234, 193, 89, 123, 243, 167, 234, 93, 207, 115, 40, 246, 81, 80, 142, 4, 5, 112, 169, 146, 224, 227, 207, 203, 171, 167, 245, 29, 130, 35, 48, 16, 217, 56, 148, 8, 210, 207, 158, 239, 72, 154, 8, 30, 91, 236, 222, 78, 74, 179, 158, 25, 212, 115, 79, 202, 180, 239, 26 } });
        }
    }
}
