using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityHistories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 227, 236, 60, 235, 17, 155, 223, 22, 114, 43, 4, 154, 253, 62, 151, 167, 59, 201, 6, 206, 1, 199, 226, 88, 0, 17, 138, 169, 163, 24, 149, 160 }, new byte[] { 94, 193, 74, 102, 84, 219, 212, 220, 11, 228, 94, 68, 237, 47, 143, 23, 129, 166, 4, 127, 15, 87, 186, 185, 48, 2, 104, 101, 223, 113, 83, 123, 12, 234, 209, 109, 19, 84, 197, 74, 86, 126, 236, 184, 237, 8, 3, 77, 239, 118, 188, 132, 197, 196, 19, 195, 188, 34, 23, 185, 161, 167, 166, 105 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityHistories");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 247, 11, 65, 240, 245, 124, 228, 89, 177, 79, 92, 113, 177, 68, 245, 206, 207, 150, 233, 160, 130, 129, 206, 98, 80, 69, 200, 215, 206, 77, 153, 22 }, new byte[] { 29, 87, 93, 136, 16, 72, 78, 31, 76, 141, 237, 94, 16, 196, 232, 90, 51, 86, 160, 18, 118, 37, 201, 4, 32, 191, 60, 4, 32, 193, 13, 101, 176, 18, 171, 10, 101, 194, 18, 230, 204, 131, 197, 98, 207, 95, 33, 177, 121, 195, 193, 41, 50, 189, 21, 54, 88, 1, 187, 134, 189, 125, 56, 103 } });
        }
    }
}
