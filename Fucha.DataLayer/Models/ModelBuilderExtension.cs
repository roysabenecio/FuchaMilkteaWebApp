using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using Microsoft.EntityFrameworkCore;

namespace Fucha.DataLayer.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { Id = 31, MenuId = 41, MeasurementUnit = MeasurementUnit.Pieces, RequiredMeasure = 1   },
                new Recipe { Id = 32, MenuId = 42, MeasurementUnit = MeasurementUnit.Pieces, RequiredMeasure = 1 },

                new Recipe { Id = 33, MenuId = 43, MeasurementUnit = MeasurementUnit.Pieces, RequiredMeasure = 1 },

                new Recipe { Id = 34, MenuId = 44, MeasurementUnit = MeasurementUnit.Pieces, RequiredMeasure = 1 },
                new Recipe { Id = 35, MenuId = 45, MeasurementUnit = MeasurementUnit.Pieces, RequiredMeasure = 1 }

                );

            modelBuilder.Entity<Menu>().HasData(
                new Menu { Id = 1, MenuCategoryId = 1, Name = "Okinawa" },
                new Menu { Id = 2, MenuCategoryId = 1, Name = "Red Velvet"},
                new Menu { Id = 3, MenuCategoryId = 1, Name = "Wintermelon" },
                new Menu { Id = 4, MenuCategoryId = 1, Name = "Salted Caramel" },
                new Menu { Id = 5, MenuCategoryId = 1, Name = "Taro" },
                new Menu { Id = 6, MenuCategoryId = 2, Name = "Cookies & Cream" },
                new Menu { Id = 7, MenuCategoryId = 2, Name = "Dark Chocolate" },
                new Menu { Id = 8, MenuCategoryId = 2, Name = "Hokkaido" },
                new Menu { Id = 9, MenuCategoryId = 2, Name = "Black Wintermel" },
                new Menu { Id = 10, MenuCategoryId = 2, Name = "Avocado Cheescake" },
                new Menu { Id = 11, MenuCategoryId = 2, Name = "Choco Bunny" },
                new Menu { Id = 12, MenuCategoryId = 2, Name = "Choco Berry Meiji" },
                new Menu { Id = 13, MenuCategoryId = 2, Name = "Mango Graham Cabin" },
                new Menu { Id = 14, MenuCategoryId = 2, Name = "Salty Cream Okinawa" },
                new Menu { Id = 15, MenuCategoryId = 3, Name = "Japanese Sausage with Rice & Egg" },
                new Menu { Id = 16, MenuCategoryId = 3, Name = "Hungarian Sausage with Rice & Egg" },
                new Menu { Id = 17, MenuCategoryId = 3, Name = "Spam Bacon with Rice & Egg" },
                new Menu { Id = 18, MenuCategoryId = 3, Name = "Cheesedog with Rice & Hotdog" },
                new Menu { Id = 19, MenuCategoryId = 3, Name = "Hungarian Sausage" },
                new Menu { Id = 20, MenuCategoryId = 3, Name = "Spam & Japanese Sausage" },

                new Menu { Id = 21, MenuCategoryId = 6, Name = "Hungarian Solo" },
                new Menu { Id = 22, MenuCategoryId = 6, Name = "Assorted Balls" },
                new Menu { Id = 23, MenuCategoryId = 6, Name = "Gyoza" },
                new Menu { Id = 24, MenuCategoryId = 6, Name = "Fries" },
                new Menu { Id = 25, MenuCategoryId = 6, Name = "Siomai" },

                new Menu { Id = 41, MenuCategoryId = 4, Name = "Cheesy Garlic" },
                new Menu { Id = 42, MenuCategoryId = 4, Name = "Ham 'N Cheese" },
                new Menu { Id = 43, MenuCategoryId = 4, Name = "Peperoni" },
                new Menu { Id = 44, MenuCategoryId = 4, Name = "Hawaiian" },
                new Menu { Id = 45, MenuCategoryId = 4, Name = "Beef Mushroom" }
                );
            modelBuilder.Entity<MenuPrice>().HasData(
                new MenuPrice { Id = 1, Price = 50, SizeId = 1, MenuCategoryId = 1 },
                new MenuPrice { Id = 2, Price = 60, SizeId = 2, MenuCategoryId = 1 },
                new MenuPrice { Id = 3, Price = 70, SizeId = 3, MenuCategoryId = 1 },
                new MenuPrice { Id = 4, Price = 120, SizeId = 4, MenuCategoryId = 1 },
                new MenuPrice { Id = 5, Price = 70, SizeId = 2, MenuCategoryId = 2 },
                new MenuPrice { Id = 6, Price = 90, SizeId = 3, MenuCategoryId = 2 },
                new MenuPrice { Id = 7, Price = 130, SizeId = 4, MenuCategoryId = 2 },
                new MenuPrice { Id = 8, MenuId = 15, Price = 60, MenuCategoryId = 3 },
                new MenuPrice { Id = 9, MenuId = 16, Price = 75, MenuCategoryId = 3 },
                new MenuPrice { Id = 10, MenuId = 17, Price = 65, MenuCategoryId = 3 },
                new MenuPrice { Id = 11, MenuId = 18, Price = 65, MenuCategoryId = 3 },
                new MenuPrice { Id = 12, MenuId = 19, Price = 50, MenuCategoryId = 3 },
                new MenuPrice { Id = 13, MenuId = 20, Price = 65, MenuCategoryId = 3 },
                new MenuPrice { Id = 14, MenuId = 21, Price = 50, MenuCategoryId = 6 },
                new MenuPrice { Id = 15, MenuId = 22, Price = 25, MenuCategoryId = 6 },
                new MenuPrice { Id = 16, MenuId = 23, Price = 40, MenuCategoryId = 6 },
                new MenuPrice { Id = 17, MenuId = 24, Price = 30, MenuCategoryId = 6 },
                new MenuPrice { Id = 18, MenuId = 25, Price = 25, MenuCategoryId = 6 },

                new MenuPrice { Id = 19, MenuId = 41, Price = 115, MenuCategoryId = 4 },
                new MenuPrice { Id = 20, MenuId = 42, Price = 115, MenuCategoryId = 4 },
                new MenuPrice { Id = 21, MenuId = 43, Price = 115, MenuCategoryId = 4 },
                new MenuPrice { Id = 22, MenuId = 44, Price = 115, MenuCategoryId = 4 },
                new MenuPrice { Id = 23, MenuId = 45, Price = 115, MenuCategoryId = 4 }
                );

            modelBuilder.Entity<AddOn>().HasData(
                new AddOn { Id = 1, Name = "Pearl", AddOnPrice = 10 },
                new AddOn { Id = 2, Name = "Nata", AddOnPrice = 10 },
                new AddOn { Id = 3, Name = "Nutella", AddOnPrice = 10 },
                new AddOn { Id = 4, Name = "Cookies", AddOnPrice = 10 },
                new AddOn { Id = 5, Name = "Cream Cheese", AddOnPrice = 10 }
                );

            modelBuilder.Entity<Size>().HasData(
                //new Size { Id = 1, Name = "Small", Label = "S", MenuCategoryId = 1 },
                //new Size { Id = 2, Name = "Medium", Label = "M", MenuCategoryId = 1 },
                //new Size { Id = 3, Name = "Large", Label = "L", MenuCategoryId = 1 },
                //new Size { Id = 4, Name = "1 Liter", Label = "1L", MenuCategoryId = 1 },
                //new Size { Id = 5, Name = "Medium", Label = "M", MenuCategoryId = 2 },
                //new Size { Id = 6, Name = "Large", Label = "L", MenuCategoryId = 2 },
                //new Size { Id = 7, Name = "1 Liter", Label = "1L", MenuCategoryId = 2 }
                //new Size { Id = 1, Name = "Small", MenuCategoryId = 1 },
                //new Size { Id = 2, Name = "Medium", MenuCategoryId = 1 },
                //new Size { Id = 3, Name = "Large", MenuCategoryId = 1 },
                //new Size { Id = 4, Name = "1 Liter", MenuCategoryId = 1 },
                //new Size { Id = 5, Name = "Medium", MenuCategoryId = 2 },
                //new Size { Id = 6, Name = "Large", MenuCategoryId = 2 },
                //new Size { Id = 7, Name = "1 Liter", MenuCategoryId = 2 }
                new Size { Id = 1, Name = "Small" },
                new Size { Id = 2, Name = "Medium"},
                new Size { Id = 3, Name = "Large"},
                new Size { Id = 4, Name = "1 Liter"}
                );
            
            modelBuilder.Entity<MenuCategory>().HasData(
                new MenuCategory { Id = 1, Name = "Classic Milk Tea" },
                new MenuCategory { Id = 2, Name = "Premium Milk Tea" },
                new MenuCategory { Id = 3, Name = "All Day Meals" },
                new MenuCategory { Id = 4, Name = "Pizza Regular" },
                new MenuCategory { Id = 5, Name = "Pizza Premium" },
                new MenuCategory { Id = 6, Name = "Snacks" },
                new MenuCategory { Id = 7, Name = "Ala Carte" },
                new MenuCategory { Id = 8, Name = "Chicken Wings" }


                );
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Roy", LastName = "Sabenecio", UserName = "r", Password = "r", Role = "Admin", UserStatus = "Approved" }
                );
            modelBuilder.Entity<Stock>().HasData(
                new Stock { Id = 1, MenuId = 1, Category = StockCategory.MilkTeaFlavor, Measure = 5, MeasurementUnit = MeasurementUnit.Kilogram, SupplierId = 1 },
                new Stock { Id = 2, MenuId = 2, Category = StockCategory.MilkTeaFlavor, Measure = 5, MeasurementUnit = MeasurementUnit.Kilogram, SupplierId = 1 },
                new Stock { Id = 3, MenuId = 3, Category = StockCategory.MilkTeaFlavor, Measure = 5, MeasurementUnit = MeasurementUnit.Kilogram, SupplierId = 2 },
                new Stock { Id = 10, AddOnId = 3, Category = StockCategory.MilkTeaAddOn, Measure = 5, MeasurementUnit = MeasurementUnit.Gram, SupplierId = 3 },


                new Stock { Id = 41, MenuId = 41, Category = StockCategory.Pizza, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, SupplierId = 10 },
                new Stock { Id = 42, MenuId = 42, Category = StockCategory.Pizza, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, SupplierId = 10 },
                new Stock { Id = 43, MenuId = 43, Category = StockCategory.Pizza, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, SupplierId = 10 },
                new Stock { Id = 44, MenuId = 44, Category = StockCategory.Pizza, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, SupplierId = 10 },
                new Stock { Id = 45, MenuId = 45, Category = StockCategory.Pizza, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, SupplierId = 10 }
                //new Stock { Id = 2, StockCategory = "Utensil", Name= "Milk Tea Cup", Quantity = 10, MeasurementUnit = "Pieces"}
                );
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "In joy", Address = "157 Josefa Drive Brgy, Corazon De Jesus, San Juan City", ContactNumber = 9178077279, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 2, Name = "PHNI Bubble Tea Store", Address = "208A Banawe St., Brgy Tatalon, Quezon City", ContactNumber = 09175858100, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 3, Name = "MSCS PrimeGoods, Inc.", Address = "San Juan Manila", ContactNumber = 9171284151, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 10, Name = "Pizza Crust", Address = "#24 F Pasco Aveue Santolan, Pasig, Philippines", ContactNumber = 9955823086, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") }
                );
            modelBuilder.Entity<PurchaseRecord>().HasData(
                new PurchaseRecord() { Id = 1, SupplierId = 1, ItemQuantity = 2, TotalAmount = 100, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), UserId = 1 },
                new PurchaseRecord() { Id = 2, SupplierId = 3, ItemQuantity = 1, TotalAmount = 50, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), UserId = 1}
                );
            modelBuilder.Entity<PORecord>().HasData(
                new PORecord() { Id = 1, StockId = 1, Category = StockCategory.MilkTeaFlavor, Measure = 100, MeasurementUnit = MeasurementUnit.Kilogram, Price = 100, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), PurchaseRecordId = 1 },
                new PORecord() { Id = 2, StockId = 2, Category = StockCategory.MilkTeaFlavor, Measure = 50, MeasurementUnit = MeasurementUnit.Kilogram, Price = 50, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), PurchaseRecordId = 1 },
                new PORecord() { Id = 3, StockId = 4, Category = StockCategory.MilkTeaAddOn, Measure = 50, MeasurementUnit = MeasurementUnit.Kilogram, Price = 50, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), PurchaseRecordId = 2 }
                );
        }
    }
}
