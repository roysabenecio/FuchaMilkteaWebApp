using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using Microsoft.EntityFrameworkCore;

namespace Fucha.DataLayer.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
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
                new Menu { Id = 20, MenuCategoryId = 3, Name = "Spam & Japanese Sausage" }

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
                new MenuPrice { Id = 13, MenuId = 20, Price = 65, MenuCategoryId = 3 }
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
                new MenuCategory { Id = 3, Name = "All Day Meals" }
                );
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Roy", LastName = "Sabenecio", UserName = "r", Password = "r", Role = "Admin", UserStatus = "Approved" }
                );
            modelBuilder.Entity<Stock>().HasData(
                new Stock{ Id = 1, StockCategory = StockCategory.MilkTeaFlavor, Name = "Okinawa", Measure = 5, MeasurementUnit = MeasurementUnit.Kilogram }
                //new Stock { Id = 2, StockCategory = "Utensil", Name= "Milk Tea Cup", Quantity = 10, MeasurementUnit = "Pieces"}
                );


        }
    }
}
