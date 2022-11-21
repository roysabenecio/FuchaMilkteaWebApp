using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddOns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddOnPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddOns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    MenuCategoryId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuPrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    MenuCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    AddOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddOnPrice = table.Column<double>(type: "float", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    SaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PORecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DatePurchased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseRecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PORecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseRecords",
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
                    table.PrimaryKey("PK_PurchaseRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    AddOnId = table.Column<int>(type: "int", nullable: true),
                    RequiredMeasure = table.Column<double>(type: "float", nullable: false),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSold = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalSales = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTransaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Measure = table.Column<double>(type: "float", nullable: false),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false),
                    StockCategory = table.Column<int>(type: "int", nullable: false),
                    StockStatus = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastRestocked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<long>(type: "bigint", nullable: false),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AddOns",
                columns: new[] { "Id", "AddOnPrice", "Name" },
                values: new object[,]
                {
                    { 1, 10.0, "Pearl" },
                    { 2, 10.0, "Nata" },
                    { 3, 10.0, "Nutella" },
                    { 4, 10.0, "Cookies" },
                    { 5, 10.0, "Cream Cheese" }
                });

            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Classic Milk Tea" },
                    { 2, "Premium Milk Tea" },
                    { 3, "All Day Meals" },
                    { 4, "Pizza Regular" },
                    { 5, "Pizza Premium" },
                    { 6, "Snacks" },
                    { 7, "Ala Carte" },
                    { 8, "Chicken Wings" }
                });

            migrationBuilder.InsertData(
                table: "MenuPrices",
                columns: new[] { "Id", "MenuCategoryId", "MenuId", "Price", "SizeId" },
                values: new object[,]
                {
                    { 1, 1, null, 50.0, 1 },
                    { 2, 1, null, 60.0, 2 },
                    { 3, 1, null, 70.0, 3 },
                    { 4, 1, null, 120.0, 4 },
                    { 5, 2, null, 70.0, 2 },
                    { 6, 2, null, 90.0, 3 },
                    { 7, 2, null, 130.0, 4 },
                    { 8, 3, 15, 60.0, null },
                    { 9, 3, 16, 75.0, null },
                    { 10, 3, 17, 65.0, null },
                    { 11, 3, 18, 65.0, null },
                    { 12, 3, 19, 50.0, null },
                    { 13, 3, 20, 65.0, null },
                    { 14, 6, 21, 50.0, null },
                    { 15, 6, 22, 25.0, null },
                    { 16, 6, 23, 40.0, null },
                    { 17, 6, 24, 30.0, null },
                    { 18, 6, 25, 25.0, null },
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
                    { 1, 1, "Okinawa" },
                    { 2, 1, "Red Velvet" },
                    { 3, 1, "Wintermelon" },
                    { 4, 1, "Salted Caramel" },
                    { 5, 1, "Taro" },
                    { 6, 2, "Cookies & Cream" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "MenuCategoryId", "Name" },
                values: new object[,]
                {
                    { 7, 2, "Dark Chocolate" },
                    { 8, 2, "Hokkaido" },
                    { 9, 2, "Black Wintermel" },
                    { 10, 2, "Avocado Cheescake" },
                    { 11, 2, "Choco Bunny" },
                    { 12, 2, "Choco Berry Meiji" },
                    { 13, 2, "Mango Graham Cabin" },
                    { 14, 2, "Salty Cream Okinawa" },
                    { 15, 3, "Japanese Sausage with Rice & Egg" },
                    { 16, 3, "Hungarian Sausage with Rice & Egg" },
                    { 17, 3, "Spam Bacon with Rice & Egg" },
                    { 18, 3, "Cheesedog with Rice & Hotdog" },
                    { 19, 3, "Hungarian Sausage" },
                    { 20, 3, "Spam & Japanese Sausage" },
                    { 21, 6, "Hungarian Solo" },
                    { 22, 6, "Assorted Balls" },
                    { 23, 6, "Gyoza" },
                    { 24, 6, "Fries" },
                    { 25, 6, "Siomai" },
                    { 41, 4, "Cheesy Garlic" },
                    { 42, 4, "Ham 'N Cheese" },
                    { 43, 4, "Peperoni" },
                    { 44, 4, "Hawaiian" },
                    { 45, 4, "Beef Mushroom" }
                });

            migrationBuilder.InsertData(
                table: "PORecords",
                columns: new[] { "Id", "Category", "DatePurchased", "MeasurementUnit", "Price", "PurchaseRecordId", "Quantity", "StockId" },
                values: new object[,]
                {
                    { 1, 0, "Monday, 21 November 2022", 1, 100.0, 1, 100.0, 1 },
                    { 2, 0, "Monday, 21 November 2022", 1, 50.0, 1, 50.0, 2 },
                    { 3, 1, "Monday, 21 November 2022", 1, 50.0, 2, 50.0, 4 }
                });

            migrationBuilder.InsertData(
                table: "PurchaseRecords",
                columns: new[] { "Id", "DatePurchased", "ItemQuantity", "SupplierId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Monday, 21 November 2022", 2, 1, 100.0 },
                    { 2, "Monday, 21 November 2022", 1, 3, 50.0 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "AddOnId", "MeasurementUnit", "MenuId", "RequiredMeasure", "SizeId" },
                values: new object[,]
                {
                    { 31, null, 3, 41, 1.0, null },
                    { 32, null, 3, 42, 1.0, null },
                    { 33, null, 3, 43, 1.0, null },
                    { 34, null, 3, 44, 1.0, null },
                    { 35, null, 3, 45, 1.0, null }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Small" },
                    { 2, "Medium" },
                    { 3, "Large" },
                    { 4, "1 Liter" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "DateAdded", "LastRestocked", "Measure", "MeasurementUnit", "MenuId", "Name", "StockCategory", "StockStatus", "SupplierId" },
                values: new object[,]
                {
                    { 1, null, null, 5.0, 1, 0, "Okinawa", 0, 0, 1 },
                    { 2, null, null, 5.0, 1, 0, "Red Velvet", 0, 0, 1 },
                    { 3, null, null, 5.0, 1, 0, "Wintermelon", 0, 0, 2 },
                    { 4, null, null, 5.0, 1, 0, "Nutella", 1, 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "DateAdded", "LastRestocked", "Measure", "MeasurementUnit", "MenuId", "Name", "StockCategory", "StockStatus", "SupplierId" },
                values: new object[,]
                {
                    { 41, null, null, 100.0, 3, 0, "Cheesy Garlic", 2, 0, 10 },
                    { 42, null, null, 100.0, 3, 0, "Ham 'N Cheese", 2, 0, 10 },
                    { 43, null, null, 100.0, 3, 0, "Peperoni", 2, 0, 10 },
                    { 44, null, null, 100.0, 3, 0, "Hawaiian", 2, 0, 10 },
                    { 45, null, null, 100.0, 3, 0, "Beef Mushroom", 2, 0, 10 }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "ContactNumber", "DateAdded", "Name" },
                values: new object[,]
                {
                    { 1, "157 Josefa Drive Brgy, Corazon De Jesus, San Juan City", 9178077279L, "Monday, 21 November 2022", "In joy" },
                    { 2, "208A Banawe St., Brgy Tatalon, Quezon City", 9175858100L, "Monday, 21 November 2022", "PHNI Bubble Tea Store" },
                    { 3, "San Juan Manila", 91712841510L, "Monday, 21 November 2022", "MSCS PrimeGoods, Inc." },
                    { 10, "#24 F Pasco Aveue Santolan, Pasig, Philippines", 9955823086L, "Monday, 21 November 2022", "Pizza Crust" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "FirstName", "LastName", "Password", "Role", "UserName", "UserStatus" },
                values: new object[] { 1, null, "Roy", "Sabenecio", "r", "Admin", "r", "Approved" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddOns");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "MenuPrices");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PORecords");

            migrationBuilder.DropTable(
                name: "PurchaseRecords");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "SalesTransaction");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "StockCategories");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
