using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    public partial class I1 : Migration
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
                    Module = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddOns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddOnPrice = table.Column<double>(type: "float", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddOns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHistories", x => x.Id);
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
                name: "MTGramSolds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grams = table.Column<double>(type: "float", nullable: true),
                    ResetDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousMeasure = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTGramSolds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    AddOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddOnPrice = table.Column<double>(type: "float", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    StockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Measure = table.Column<double>(type: "float", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DatePurchased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedOrders = table.Column<int>(type: "int", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
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
                    ItemQuantity = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: true),
                    DatePurchased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasAddOn = table.Column<bool>(type: "bit", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    MenuCategoryId = table.Column<int>(type: "int", nullable: true)
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
                    ItemQuantity = table.Column<int>(type: "int", nullable: false),
                    DateSold = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Measure = table.Column<double>(type: "float", nullable: true),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false),
                    Ceiling = table.Column<double>(type: "float", nullable: true),
                    LowLevel = table.Column<double>(type: "float", nullable: true),
                    CriticalLevel = table.Column<double>(type: "float", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LastRestocked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    StockServingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockServings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequiredPerServing = table.Column<double>(type: "float", nullable: true),
                    MeasurementUnit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockServings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
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
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeStocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeStocks_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeStocks_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AddOns",
                columns: new[] { "Id", "AddOnPrice", "Name", "StockId" },
                values: new object[,]
                {
                    { 1, 0.0, "No Add-On", 0 },
                    { 2, 10.0, "Pearl", 0 },
                    { 3, 10.0, "Nata", 0 },
                    { 4, 10.0, "Nutella", 0 },
                    { 5, 10.0, "Cookies", 0 },
                    { 6, 10.0, "Cream Cheese", 0 }
                });

            migrationBuilder.InsertData(
                table: "MTGramSolds",
                columns: new[] { "Id", "Grams", "Name", "PreviousMeasure", "ResetDate", "StockId" },
                values: new object[,]
                {
                    { 1, 0.0, "Okinawa", null, null, 1 },
                    { 2, 1700.0, "Red Velvet", null, null, 2 },
                    { 3, 1500.0, "Wintermelon", null, null, 3 },
                    { 4, 0.0, "Salted Caramel", null, null, 4 },
                    { 5, 0.0, "Taro", null, null, 5 },
                    { 6, 0.0, "Dark Chocolate", null, null, 6 },
                    { 7, 0.0, "Hokkaido", null, null, 7 },
                    { 8, 0.0, "Black Wintermelon", null, null, 8 },
                    { 9, 0.0, "Avocado Cheesecake", null, null, 9 },
                    { 10, 0.0, "Choco Bunny", null, null, 10 },
                    { 11, 0.0, "Choco Berry Meiji", null, null, 11 },
                    { 12, 0.0, "Mango Graham Cabin", null, null, 12 },
                    { 13, 0.0, "Salty Cream Okinawa", null, null, 13 },
                    { 70, 0.0, "Cookies & Cream", null, null, 70 }
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
                    { 8, "Barkada Wings" }
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
                    { 13, 3, 19, 65.0, null },
                    { 14, 4, 20, 115.0, null },
                    { 15, 4, 21, 115.0, null }
                });

            migrationBuilder.InsertData(
                table: "MenuPrices",
                columns: new[] { "Id", "MenuCategoryId", "MenuId", "Price", "SizeId" },
                values: new object[,]
                {
                    { 16, 4, 22, 115.0, null },
                    { 17, 4, 23, 115.0, null },
                    { 18, 4, 24, 115.0, null },
                    { 19, 5, 25, 135.0, null },
                    { 20, 5, 26, 135.0, null },
                    { 21, 5, 27, 135.0, null },
                    { 22, 5, 28, 135.0, null },
                    { 23, 6, 29, 50.0, null },
                    { 24, 6, 30, 25.0, null },
                    { 25, 6, 31, 40.0, null },
                    { 26, 6, 32, 30.0, null },
                    { 27, 6, 33, 25.0, null },
                    { 28, 7, 34, 88.0, null },
                    { 29, 7, 35, 149.0, null },
                    { 30, 8, 36, 249.0, null },
                    { 31, 8, 37, 380.0, null },
                    { 32, 8, 38, 649.0, null }
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
                    { 6, 2, "Cookies & Cream" },
                    { 7, 2, "Dark Chocolate" },
                    { 8, 2, "Hokkaido" },
                    { 9, 2, "Black Wintermelon" },
                    { 10, 2, "Avocado Cheesecake" },
                    { 11, 2, "Choco Bunny" },
                    { 12, 2, "Choco Berry Meiji" },
                    { 13, 2, "Mango Graham Cabin" },
                    { 14, 2, "Salty Cream Okinawa" },
                    { 15, 3, "Japanese Sausage with Rice & Egg" },
                    { 16, 3, "Hungarian Sausage with Rice & Egg" },
                    { 17, 3, "Spam Bacon with Rice & Egg" },
                    { 18, 3, "Cheesedog with Rice & Egg" },
                    { 19, 3, "Spam & Japanese Sausage" },
                    { 20, 4, "Cheesy Garlic" },
                    { 21, 4, "Ham 'N Cheese" },
                    { 22, 4, "Peperoni" },
                    { 23, 4, "Hawaiian" },
                    { 24, 4, "Beef Mushroom" },
                    { 25, 5, "All Meat" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "MenuCategoryId", "Name" },
                values: new object[,]
                {
                    { 26, 5, "Supreme" },
                    { 27, 5, "Chick N Cheese" },
                    { 28, 5, "Aloha Special" },
                    { 29, 6, "Hungarian Solo" },
                    { 30, 6, "Assorted Balls" },
                    { 31, 6, "Gyoza" },
                    { 32, 6, "Fries" },
                    { 33, 6, "Siomai" },
                    { 34, 7, "Wings 3 pcs with Rice" },
                    { 35, 7, "Wings 6 pcs with Rice" },
                    { 36, 8, "Wings 12 pcs" },
                    { 37, 8, "Wings 18 pcs" },
                    { 38, 8, "Wings 30 pcs" }
                });

            migrationBuilder.InsertData(
                table: "PORecords",
                columns: new[] { "Id", "Category", "DatePurchased", "Measure", "MeasurementUnit", "Price", "PurchaseRecordId", "ReceivedOrders", "Status", "StockName", "SupplierId" },
                values: new object[,]
                {
                    { 1, "MilkTeaFlavor", "Wednesday, 12 April 2023", 2.0, "Kilograms", 100.0, 1, 0, "Not Received", "Okinawa", 0 },
                    { 2, "MilkTeaFlavor", "Wednesday, 12 April 2023", 2.0, "Kilograms", 50.0, 1, 0, "Not Received", "Red Velvet", 0 },
                    { 3, "MilkTeaAddOn", "Wednesday, 12 April 2023", 2.0, "Kilograms", 50.0, 2, 0, "Not Received", "Salted Caramel", 0 }
                });

            migrationBuilder.InsertData(
                table: "PurchaseRecords",
                columns: new[] { "Id", "DatePurchased", "ItemQuantity", "SupplierId", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1, "Wednesday, 12 April 2023", 2, 1, 2000.0, 1 },
                    { 2, "Wednesday, 12 April 2023", 1, 1, 500.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "HasAddOn", "MenuCategoryId", "MenuId", "Name", "SizeId" },
                values: new object[,]
                {
                    { 1, true, 1, null, "Milk Tea Small", 1 },
                    { 2, true, 2, null, "Milk Tea Medium", 2 },
                    { 3, true, 2, null, "Milk Tea Large", 3 },
                    { 4, true, 2, null, "Milk Tea 1 Liter", 4 },
                    { 5, null, 3, 15, "Japanese Sausage with Rice & Egg", null },
                    { 6, null, 3, 16, "Hungarian Sausage with Rice & Egg", null },
                    { 7, null, 3, 17, "Spam Bacon with Rice & Egg", null },
                    { 8, null, 3, 18, "Cheesedog with Rice & Egg", null },
                    { 9, null, 3, 19, "Spam & Japanese Sausage", null },
                    { 10, null, 4, 20, "Cheesy Garlic", null },
                    { 11, null, 4, 21, "Ham 'N Cheese", null },
                    { 12, null, 4, 22, "Peperoni", null },
                    { 13, null, 4, 23, "Hawaiian", null },
                    { 14, null, 4, 24, "Beef Mushroom", null },
                    { 15, null, 5, 25, "All Meat", null },
                    { 16, null, 5, 26, "Supreme", null },
                    { 17, null, 5, 27, "Chick N Cheese", null },
                    { 18, null, 5, 28, "Aloha Special", null },
                    { 19, null, 6, 29, "Hungarian Solo", null },
                    { 20, null, 6, 30, "Assorted Balls", null },
                    { 21, null, 6, 31, "Gyoza", null },
                    { 22, null, 6, 32, "Fries", null },
                    { 23, null, 6, 33, "Siomai", null },
                    { 24, null, 7, 34, "Wings 3 pcs with Rice", null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "HasAddOn", "MenuCategoryId", "MenuId", "Name", "SizeId" },
                values: new object[,]
                {
                    { 25, null, 7, 35, "Wings 6 pcs with Rice", null },
                    { 26, null, 8, 36, "Wings 12 pcs", null },
                    { 27, null, 8, 37, "Wings 18 pcs", null },
                    { 28, null, 8, 38, "Wings 30 pcs", null }
                });

            migrationBuilder.InsertData(
                table: "SalesTransaction",
                columns: new[] { "Id", "DateSold", "ItemQuantity", "TotalSales", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 5500.0, 1 },
                    { 2, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4352.0, 1 },
                    { 3, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3670.0, 1 },
                    { 4, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 8710.0, 1 },
                    { 5, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4405.0, 1 },
                    { 6, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 5123.0, 1 },
                    { 7, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 6990.0, 1 },
                    { 8, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 8321.0, 1 },
                    { 9, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4327.0, 1 }
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
                table: "StockServings",
                columns: new[] { "Id", "MeasurementUnit", "RequiredPerServing" },
                values: new object[,]
                {
                    { 1, 3, 1.0 },
                    { 2, 3, 2.0 },
                    { 3, 3, 3.0 },
                    { 4, 3, 4.0 },
                    { 5, 3, 5.0 },
                    { 21, 0, 15.0 },
                    { 22, 0, 30.0 },
                    { 23, 0, 45.0 },
                    { 24, 0, 60.0 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Category", "Ceiling", "CriticalLevel", "IsRemoved", "LastRestocked", "LowLevel", "Measure", "MeasurementUnit", "Name", "Status", "StockServingId", "SupplierId" },
                values: new object[,]
                {
                    { 1, 0, 3.0, 0.14999999999999999, false, null, 0.29999999999999999, 2.0, 1, "Okinawa", 3, null, 1 },
                    { 2, 0, 3.0, 0.14999999999999999, false, null, 0.29999999999999999, 2.0, 1, "Red Velvet", null, null, 1 },
                    { 3, 0, 3.0, 0.14999999999999999, false, null, 0.29999999999999999, 0.0, 1, "Wintermelon", null, null, 2 },
                    { 4, 0, null, null, false, null, null, 2.0, 1, "Salted Caramel", null, null, 1 },
                    { 5, 0, null, null, false, null, null, 0.0, 1, "Taro", null, null, 2 },
                    { 6, 0, null, null, false, null, null, 0.0, 1, "Dark Chocolate", null, null, 1 },
                    { 7, 0, null, null, false, null, null, 2.0, 1, "Hokkaido", null, null, 1 },
                    { 8, 0, null, null, false, null, null, 0.0, 1, "Black Wintermelon", null, null, 1 },
                    { 9, 0, null, null, false, null, null, 0.0, 1, "Avocado Cheesecake", null, null, 1 },
                    { 10, 0, null, null, false, null, null, 0.0, 1, "Choco Bunny", null, null, 1 },
                    { 11, 0, null, null, false, null, null, 0.0, 1, "Choco Berry Meiji", null, null, 1 },
                    { 12, 0, null, null, false, null, null, 0.0, 1, "Mango Graham Cabin", null, null, 1 },
                    { 13, 0, null, null, false, null, null, 0.0, 1, "Salty Cream Okinawa", null, null, 1 },
                    { 14, 1, null, null, false, null, null, 5.0, 1, "Pearl", null, null, 2 },
                    { 15, 1, null, null, false, null, null, 5.0, 1, "Nata", null, null, 2 },
                    { 16, 1, null, null, false, null, null, 5.0, 1, "Nutella", null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Category", "Ceiling", "CriticalLevel", "IsRemoved", "LastRestocked", "LowLevel", "Measure", "MeasurementUnit", "Name", "Status", "StockServingId", "SupplierId" },
                values: new object[,]
                {
                    { 17, 1, null, null, false, null, null, 5.0, 1, "Cookies", null, null, 1 },
                    { 18, 1, null, null, false, null, null, 5.0, 1, "Cream Cheese", null, null, 1 },
                    { 19, 4, null, null, false, null, null, 100.0, 3, "Straw", null, 1, 2 },
                    { 20, 4, null, null, false, null, null, 100.0, 3, "Straw 1L", null, 1, 2 },
                    { 21, 4, null, null, false, null, null, 100.0, 3, "Cup 12 oz", null, 1, 2 },
                    { 22, 4, null, null, false, null, null, 100.0, 3, "Cup 16 oz", null, 1, 2 },
                    { 23, 4, null, null, false, null, null, 100.0, 3, "Cup 22 oz", null, 1, 2 },
                    { 24, 4, null, null, false, null, null, 100.0, 3, "Cup 1L", null, 1, 2 },
                    { 25, 5, null, null, false, null, null, 50.0, 3, "Japanese Sausage", null, 1, 4 },
                    { 26, 5, null, null, false, null, null, 50.0, 3, "Hungarian Sausage", null, 1, 5 },
                    { 27, 5, null, null, false, null, null, 50.0, 3, "Cheesedog", null, 1, null },
                    { 28, 5, null, null, false, null, null, 50.0, 4, "Spam Bacon", null, 2, 4 },
                    { 29, 5, null, null, false, null, null, 50.0, 3, "Egg", null, 1, 6 },
                    { 30, 4, null, null, false, null, null, 200.0, 3, "Styro Plate", null, 1, null },
                    { 31, 4, null, null, false, null, null, 200.0, 3, "Plastic Spoon", null, 1, null },
                    { 32, 4, null, null, false, null, null, 200.0, 3, "Plastic Fork", null, 1, null },
                    { 33, 2, null, null, false, null, null, 20.0, 3, "Cheesy Garlic", null, 1, 7 },
                    { 34, 2, null, null, false, null, null, 20.0, 3, "Ham 'N Cheese", null, 1, 7 },
                    { 35, 2, null, null, false, null, null, 20.0, 3, "Peperoni", null, 1, 8 },
                    { 36, 2, null, null, false, null, null, 20.0, 3, "Hawaiian", null, 1, 9 },
                    { 37, 2, null, null, false, null, null, 20.0, 3, "Beef Mushroom", null, 1, 7 },
                    { 38, 2, null, null, false, null, null, 20.0, 3, "All Meat", null, 1, 7 },
                    { 39, 2, null, null, false, null, null, 20.0, 3, "Supreme", null, 1, 7 },
                    { 40, 2, null, null, false, null, null, 20.0, 3, "Chick N Cheese", null, 1, 7 },
                    { 41, 2, null, null, false, null, null, 20.0, 3, "Aloha Special", null, 1, 7 },
                    { 42, 3, null, null, false, null, null, 100.0, 3, "Chicken balls", null, 2, 10 },
                    { 43, 3, null, null, false, null, null, 100.0, 3, "Squid balls", null, 2, 10 },
                    { 44, 3, null, null, false, null, null, 100.0, 3, "Shrimp balls", null, 2, 10 },
                    { 45, 3, null, null, false, null, null, 10.0, 1, "French Fries", null, null, 5 },
                    { 46, 3, null, null, false, null, null, 100.0, 3, "Gyoza", null, 5, 4 },
                    { 47, 3, null, null, false, null, null, 100.0, 3, "Siomai", null, 5, 11 },
                    { 48, 4, null, null, false, null, null, 100.0, 3, "Stick", null, 1, null },
                    { 49, 4, null, null, false, null, null, 100.0, 3, "Paper Tray", null, 5, null },
                    { 50, 5, null, null, false, null, null, 10.0, 5, "BBQ", null, null, null },
                    { 51, 5, null, null, false, null, null, 10.0, 5, "Cheese", null, null, null },
                    { 52, 5, null, null, false, null, null, 10.0, 5, "Sour Cream", null, null, null },
                    { 53, 6, null, null, false, null, null, 50.0, 1, "Chicken", null, null, null },
                    { 54, 4, null, null, false, null, null, 100.0, 3, "Paper Liner", null, 1, null },
                    { 55, 7, null, null, false, null, null, 5.0, 6, "Sweet Chili", null, null, 12 },
                    { 56, 7, null, null, false, null, null, 5.0, 6, "Terriyaki", null, null, 13 },
                    { 57, 7, null, null, false, null, null, 5.0, 6, "Mango Habanero", null, null, 8 },
                    { 58, 7, null, null, false, null, null, 5.0, 6, "Buffalo", null, null, 12 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Category", "Ceiling", "CriticalLevel", "IsRemoved", "LastRestocked", "LowLevel", "Measure", "MeasurementUnit", "Name", "Status", "StockServingId", "SupplierId" },
                values: new object[,]
                {
                    { 59, 7, null, null, false, null, null, 5.0, 6, "Soy Garlic", null, null, 13 },
                    { 60, 7, null, null, false, null, null, 5.0, 6, "Hickory BBQ", null, null, 12 },
                    { 61, 7, null, null, false, null, null, 5.0, 6, "Garlic Parmesan", null, null, 12 },
                    { 62, 7, null, null, false, null, null, 5.0, 6, "Sriracha", null, null, 12 },
                    { 63, 7, null, null, false, null, null, 5.0, 6, "Salted Egg", null, null, 8 },
                    { 64, 7, null, null, false, null, null, 5.0, 6, "Spiced Maple", null, null, 8 },
                    { 65, 7, null, null, false, null, null, 5.0, 6, "Lemon Glazed", null, null, 12 },
                    { 66, 7, null, null, false, null, null, 5.0, 6, "Korean Spicy", null, null, 12 },
                    { 70, 0, null, null, false, null, null, 0.0, 1, "Cookies & Cream", null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "ContactNumber", "ContactPerson", "DateAdded", "Email", "IsRemoved", "Name" },
                values: new object[,]
                {
                    { 1, "157 Josefa Drive Brgy, Corazon De Jesus, San Juan City", "09178077279", null, "Wednesday, 12 April 2023", null, false, "In joy" },
                    { 2, "208A Banawe St., Brgy Tatalon, Quezon City", "09175858100", null, "Wednesday, 12 April 2023", null, false, "PHNI Bubble Tea Store" },
                    { 3, "San Juan Manila", "09171284151", null, "Wednesday, 12 April 2023", null, false, "MSCS PrimeGoods, Inc." },
                    { 4, "1747 A. Mabini St, Malate, Manila, 1004 Metro Manila", "(02) 8523 1186", null, "Wednesday, 12 April 2023", null, false, "Fuji Mart Incorporated" },
                    { 5, "2329 Juan Luna St, Gagalangin, Manila, Metro Manila", "09985172380", null, "Wednesday, 12 April 2023", null, false, "Consistent Frozen Solutions" },
                    { 6, "40 Scout Oscar M. Alcaraz St, Santa Mesa Heights, Quezon City, 1114 Metro Manila", "09171735588", null, "Wednesday, 12 April 2023", null, false, "FST Egg Store" },
                    { 7, "#24 F Pasco Aveue Santolan, Pasig", "09955823086", null, "Wednesday, 12 April 2023", null, false, "Pizza Crust" },
                    { 8, "704 Rizal Ave. ext.Caloocan City, Metro Manil, 1403", "09955823086", null, "Wednesday, 12 April 2023", null, false, "Negosyo Now" },
                    { 9, "Metro Manila", "09955823086", null, "Wednesday, 12 April 2023", null, false, "Vostra Pizza" },
                    { 10, "837 Asuncion St, Binondo, Manila, 2006 Metro Manila", "09971220886", null, "Wednesday, 12 April 2023", null, false, "Golden Fishball Factory" },
                    { 11, "San Roque, Antipolo", "09610074035", null, "Wednesday, 12 April 2023", null, false, "Siomai Wholesale Supplier PH" },
                    { 12, "1005 Atlanta Centre Bldg., 31 Annapolis St., Greenhills, San Juan City", "721-339-47", null, "Wednesday, 12 April 2023", null, false, "JD FOODS Premium Sauces" },
                    { 13, "7F Steelworld Bldg. 713 N.S. Amoranto Sr. corner Biak na Bato Street, Quezon City", "09286418135", null, "Wednesday, 12 April 2023", null, false, "Easy Brand Ph" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "FirstName", "IsRemoved", "LastName", "PasswordHash", "PasswordSalt", "Role", "UserName", "UserStatus" },
                values: new object[] { 1, null, "Admin", false, "Admin", new byte[] { 219, 228, 154, 135, 45, 2, 84, 209, 134, 7, 203, 210, 173, 36, 111, 57, 93, 249, 2, 73, 95, 218, 233, 208, 222, 255, 106, 199, 253, 71, 42, 228 }, new byte[] { 20, 189, 200, 140, 98, 182, 10, 188, 238, 164, 99, 227, 4, 124, 43, 230, 232, 249, 35, 186, 237, 90, 17, 81, 129, 74, 217, 98, 61, 11, 97, 173, 127, 47, 75, 117, 97, 143, 212, 208, 69, 103, 233, 185, 203, 215, 142, 225, 235, 64, 47, 7, 35, 168, 219, 184, 231, 26, 237, 71, 106, 89, 243, 119 }, "Admin", "admin", "Approved" });

            migrationBuilder.InsertData(
                table: "RecipeStocks",
                columns: new[] { "Id", "RecipeId", "StockId" },
                values: new object[,]
                {
                    { 1, 1, 19 },
                    { 2, 1, 21 },
                    { 3, 2, 19 },
                    { 4, 2, 22 },
                    { 5, 3, 19 },
                    { 6, 3, 23 },
                    { 7, 4, 19 },
                    { 8, 4, 20 },
                    { 9, 5, 29 },
                    { 10, 5, 30 },
                    { 11, 5, 25 },
                    { 12, 6, 29 },
                    { 13, 6, 30 },
                    { 14, 6, 26 },
                    { 15, 7, 29 },
                    { 16, 7, 30 },
                    { 17, 7, 27 },
                    { 18, 8, 29 },
                    { 19, 8, 30 },
                    { 20, 8, 28 },
                    { 21, 9, 25 },
                    { 22, 9, 28 },
                    { 23, 9, 30 },
                    { 24, 10, 33 },
                    { 25, 11, 34 },
                    { 26, 12, 35 },
                    { 27, 13, 36 },
                    { 28, 14, 37 },
                    { 29, 15, 38 },
                    { 30, 16, 39 },
                    { 31, 17, 40 },
                    { 32, 18, 41 },
                    { 33, 19, 26 },
                    { 34, 19, 48 },
                    { 35, 20, 42 },
                    { 36, 20, 43 },
                    { 37, 20, 44 },
                    { 38, 20, 49 },
                    { 39, 21, 46 },
                    { 40, 21, 49 },
                    { 41, 22, 49 },
                    { 42, 23, 47 }
                });

            migrationBuilder.InsertData(
                table: "RecipeStocks",
                columns: new[] { "Id", "RecipeId", "StockId" },
                values: new object[,]
                {
                    { 43, 23, 49 },
                    { 44, 24, 54 },
                    { 45, 24, 31 },
                    { 46, 24, 32 },
                    { 47, 25, 54 },
                    { 48, 25, 31 },
                    { 49, 25, 32 },
                    { 50, 26, 54 },
                    { 51, 27, 54 },
                    { 52, 28, 54 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeStocks_RecipeId",
                table: "RecipeStocks",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeStocks_StockId",
                table: "RecipeStocks",
                column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityHistories");

            migrationBuilder.DropTable(
                name: "AddOns");

            migrationBuilder.DropTable(
                name: "LoginHistories");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "MenuPrices");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MTGramSolds");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PORecords");

            migrationBuilder.DropTable(
                name: "PurchaseRecords");

            migrationBuilder.DropTable(
                name: "RecipeStocks");

            migrationBuilder.DropTable(
                name: "SalesTransaction");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "StockServings");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
