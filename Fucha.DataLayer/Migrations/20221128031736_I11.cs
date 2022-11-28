using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RId",
                table: "Stocks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    AddOnId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_RId",
                table: "Stocks",
                column: "RId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Rs_RId",
                table: "Stocks",
                column: "RId",
                principalTable: "Rs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Rs_RId",
                table: "Stocks");

            migrationBuilder.DropTable(
                name: "Rs");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_RId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "RId",
                table: "Stocks");
        }
    }
}
