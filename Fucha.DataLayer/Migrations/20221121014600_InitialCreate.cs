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
                    AddOnPrice = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    MenuCategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    PurchaseRecordId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    StockId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    AddOnId = table.Column<int>(type: "int", nullable: true),
                    RequiredMeasure = table.Column<double>(type: "float", nullable: false),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    TotalSales = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    AddOnId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Measure = table.Column<double>(type: "float", nullable: false),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false),
                    StockCategory = table.Column<int>(type: "int", nullable: false),
                    StockStatus = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastRestocked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AddOns",
                columns: new[] { "Id", "AddOnPrice", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 10.0, false, "Pearl" },
                    { 2, 10.0, false, "Nata" },
                    { 3, 10.0, false, "Nutella" },
                    { 4, 10.0, false, "Cookies" },
                    { 5, 10.0, false, "Cream Cheese" }
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
                columns: new[] { "Id", "IsDeleted", "MenuCategoryId", "MenuId", "Price", "SizeId" },
                values: new object[,]
                {
                    { 1, false, 1, null, 50.0, 1 },
                    { 2, false, 1, null, 60.0, 2 },
                    { 3, false, 1, null, 70.0, 3 },
                    { 4, false, 1, null, 120.0, 4 },
                    { 5, false, 2, null, 70.0, 2 },
                    { 6, false, 2, null, 90.0, 3 },
                    { 7, false, 2, null, 130.0, 4 },
                    { 8, false, 3, 15, 60.0, null },
                    { 9, false, 3, 16, 75.0, null },
                    { 10, false, 3, 17, 65.0, null },
                    { 11, false, 3, 18, 65.0, null },
                    { 12, false, 3, 19, 50.0, null },
                    { 13, false, 3, 20, 65.0, null },
                    { 14, false, 6, 21, 50.0, null },
                    { 15, false, 6, 22, 25.0, null },
                    { 16, false, 6, 23, 40.0, null },
                    { 17, false, 6, 24, 30.0, null },
                    { 18, false, 6, 25, 25.0, null },
                    { 19, false, 4, 41, 115.0, null },
                    { 20, false, 4, 42, 115.0, null },
                    { 21, false, 4, 43, 115.0, null },
                    { 22, false, 4, 44, 115.0, null },
                    { 23, false, 4, 45, 115.0, null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "IsDeleted", "MenuCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, false, 1, "Okinawa" },
                    { 2, false, 1, "Red Velvet" },
                    { 3, false, 1, "Wintermelon" },
                    { 4, false, 1, "Salted Caramel" },
                    { 5, false, 1, "Taro" },
                    { 6, false, 2, "Cookies & Cream" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "IsDeleted", "MenuCategoryId", "Name" },
                values: new object[,]
                {
                    { 7, false, 2, "Dark Chocolate" },
                    { 8, false, 2, "Hokkaido" },
                    { 9, false, 2, "Black Wintermel" },
                    { 10, false, 2, "Avocado Cheescake" },
                    { 11, false, 2, "Choco Bunny" },
                    { 12, false, 2, "Choco Berry Meiji" },
                    { 13, false, 2, "Mango Graham Cabin" },
                    { 14, false, 2, "Salty Cream Okinawa" },
                    { 15, false, 3, "Japanese Sausage with Rice & Egg" },
                    { 16, false, 3, "Hungarian Sausage with Rice & Egg" },
                    { 17, false, 3, "Spam Bacon with Rice & Egg" },
                    { 18, false, 3, "Cheesedog with Rice & Hotdog" },
                    { 19, false, 3, "Hungarian Sausage" },
                    { 20, false, 3, "Spam & Japanese Sausage" },
                    { 21, false, 6, "Hungarian Solo" },
                    { 22, false, 6, "Assorted Balls" },
                    { 23, false, 6, "Gyoza" },
                    { 24, false, 6, "Fries" },
                    { 25, false, 6, "Siomai" },
                    { 41, false, 4, "Cheesy Garlic" },
                    { 42, false, 4, "Ham 'N Cheese" },
                    { 43, false, 4, "Peperoni" },
                    { 44, false, 4, "Hawaiian" },
                    { 45, false, 4, "Beef Mushroom" }
                });

            migrationBuilder.InsertData(
                table: "PORecords",
                columns: new[] { "Id", "Category", "DatePurchased", "IsDeleted", "MeasurementUnit", "Price", "PurchaseRecordId", "Quantity", "StockId" },
                values: new object[,]
                {
                    { 1, 0, "Monday, 21 November 2022", false, 1, 100.0, 1, 100.0, 1 },
                    { 2, 0, "Monday, 21 November 2022", false, 1, 50.0, 1, 50.0, 2 },
                    { 3, 1, "Monday, 21 November 2022", false, 1, 50.0, 2, 50.0, 4 }
                });

            migrationBuilder.InsertData(
                table: "PurchaseRecords",
                columns: new[] { "Id", "DatePurchased", "ItemQuantity", "SupplierId", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1, "Monday, 21 November 2022", 2, 1, 100.0, 0 },
                    { 2, "Monday, 21 November 2022", 1, 3, 50.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "AddOnId", "IsDeleted", "MeasurementUnit", "MenuId", "RequiredMeasure", "SizeId", "StockId" },
                values: new object[,]
                {
                    { 31, null, false, 3, 41, 1.0, null, 0 },
                    { 32, null, false, 3, 42, 1.0, null, 0 },
                    { 33, null, false, 3, 43, 1.0, null, 0 },
                    { 34, null, false, 3, 44, 1.0, null, 0 },
                    { 35, null, false, 3, 45, 1.0, null, 0 }
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
                columns: new[] { "Id", "AddOnId", "DateAdded", "IsDeleted", "LastRestocked", "Measure", "MeasurementUnit", "MenuId", "Name", "StockCategory", "StockStatus", "SupplierId" },
                values: new object[,]
                {
                    { 1, null, null, false, null, 5.0, 1, 1, "Okinawa", 0, 0, 1 },
                    { 2, null, null, false, null, 5.0, 1, 2, "Red Velvet", 0, 0, 1 },
                    { 3, null, null, false, null, 5.0, 1, 3, "Wintermelon", 0, 0, 2 },
                    { 4, 3, null, false, null, 5.0, 1, null, "Nutella", 1, 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "AddOnId", "DateAdded", "IsDeleted", "LastRestocked", "Measure", "MeasurementUnit", "MenuId", "Name", "StockCategory", "StockStatus", "SupplierId" },
                values: new object[,]
                {
                    { 41, null, null, false, null, 100.0, 3, null, "Cheesy Garlic", 2, 0, 10 },
                    { 42, null, null, false, null, 100.0, 3, null, "Ham 'N Cheese", 2, 0, 10 },
                    { 43, null, null, false, null, 100.0, 3, null, "Peperoni", 2, 0, 10 },
                    { 44, null, null, false, null, 100.0, 3, null, "Hawaiian", 2, 0, 10 },
                    { 45, null, null, false, null, 100.0, 3, null, "Beef Mushroom", 2, 0, 10 }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "ContactNumber", "DateAdded", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "157 Josefa Drive Brgy, Corazon De Jesus, San Juan City", 9178077279L, "Monday, 21 November 2022", false, "In joy" },
                    { 2, "208A Banawe St., Brgy Tatalon, Quezon City", 9175858100L, "Monday, 21 November 2022", false, "PHNI Bubble Tea Store" },
                    { 3, "San Juan Manila", 91712841510L, "Monday, 21 November 2022", false, "MSCS PrimeGoods, Inc." },
                    { 10, "#24 F Pasco Aveue Santolan, Pasig, Philippines", 9955823086L, "Monday, 21 November 2022", false, "Pizza Crust" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "FirstName", "IsDeleted", "LastName", "Password", "Role", "UserName", "UserStatus" },
                values: new object[] { 1, null, "Roy", false, "Sabenecio", "r", "Admin", "r", "Approved" });
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
