using Fucha.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.Models.sampleSeeder
{
    internal class sampleMenu
    {
        public sampleMenu()
        {
            var menus = new[]
            {
                new Menu { Id = 1, MenuCategoryId = 1, Name = "Okinawa" },
                new Menu { Id = 2, MenuCategoryId = 1, Name = "Red Velvet" },
                new Menu { Id = 3, MenuCategoryId = 1, Name = "Wintermelon" },
                new Menu { Id = 4, MenuCategoryId = 1, Name = "Salted Caramel" },
                new Menu { Id = 5, MenuCategoryId = 1, Name = "Taro" },

                new Menu { Id = 6, MenuCategoryId = 2, Name = "Cookies & Cream" },
                new Menu { Id = 7, MenuCategoryId = 2, Name = "Dark Chocolate" },
                new Menu { Id = 8, MenuCategoryId = 2, Name = "Hokkaido" },
                new Menu { Id = 9, MenuCategoryId = 2, Name = "Black Wintermelon" },
                new Menu { Id = 10, MenuCategoryId = 2, Name = "Avocado Cheescake" },
                new Menu { Id = 11, MenuCategoryId = 2, Name = "Choco Bunny" },
                new Menu { Id = 12, MenuCategoryId = 2, Name = "Choco Berry Meiji" },
                new Menu { Id = 13, MenuCategoryId = 2, Name = "Mango Graham Cabin" },
                new Menu { Id = 14, MenuCategoryId = 2, Name = "Salty Cream Okinawa" },

                new Menu { Id = 15, MenuCategoryId = 3, Name = "Japanese Sausage with Rice & Egg" },
                new Menu { Id = 16, MenuCategoryId = 3, Name = "Hungarian Sausage with Rice & Egg" },
                new Menu { Id = 17, MenuCategoryId = 3, Name = "Spam Bacon with Rice & Egg" },
                new Menu { Id = 18, MenuCategoryId = 3, Name = "Cheesedog with Rice & Egg" },
                new Menu { Id = 19, MenuCategoryId = 3, Name = "Spam & Japanese Sausage" },

                new Menu { Id = 20, MenuCategoryId = 4, Name = "Cheesy Garlic" },
                new Menu { Id = 21, MenuCategoryId = 4, Name = "Ham 'N Cheese" },
                new Menu { Id = 22, MenuCategoryId = 4, Name = "Peperoni" },
                new Menu { Id = 23, MenuCategoryId = 4, Name = "Hawaiian" },
                new Menu { Id = 24, MenuCategoryId = 4, Name = "Beef Mushroom" },

                new Menu { Id = 25, MenuCategoryId = 5, Name = "All Meat" },
                new Menu { Id = 26, MenuCategoryId = 5, Name = "Supreme" },
                new Menu { Id = 27, MenuCategoryId = 5, Name = "Chick N Cheese" },
                new Menu { Id = 28, MenuCategoryId = 5, Name = "Aloha Special" },

                new Menu { Id = 29, MenuCategoryId = 6, Name = "Hungarian Solo" },
                new Menu { Id = 30, MenuCategoryId = 6, Name = "Assorted Balls" },
                new Menu { Id = 31, MenuCategoryId = 6, Name = "Gyoza" },
                new Menu { Id = 32, MenuCategoryId = 6, Name = "Fries" },
                new Menu { Id = 33, MenuCategoryId = 6, Name = "Siomai" },

                new Menu { Id = 34, MenuCategoryId = 7, Name = "3 pcs with Rice" },
                new Menu { Id = 35, MenuCategoryId = 7, Name = "6 pcs with Rice" },
                new Menu { Id = 36, MenuCategoryId = 8, Name = "12 pcs" },
                new Menu { Id = 37, MenuCategoryId = 8, Name = "18 pcs" },
                new Menu { Id = 38, MenuCategoryId = 8, Name = "30 pcs" },
            };

            var menuPrice = new[]
            {
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
                new MenuPrice { Id = 13, MenuId = 19, Price = 65, MenuCategoryId = 3 },

                new MenuPrice { Id = 14, MenuId = 20, Price = 115, MenuCategoryId = 4 },
                new MenuPrice { Id = 15, MenuId = 21, Price = 115, MenuCategoryId = 4 },
                new MenuPrice { Id = 16, MenuId = 22, Price = 115, MenuCategoryId = 4 },
                new MenuPrice { Id = 17, MenuId = 23, Price = 115, MenuCategoryId = 4 },
                new MenuPrice { Id = 18, MenuId = 24, Price = 115, MenuCategoryId = 4 },

                new MenuPrice { Id = 19, MenuId = 25, Price = 135, MenuCategoryId = 5 },
                new MenuPrice { Id = 20, MenuId = 26, Price = 135, MenuCategoryId = 5 },
                new MenuPrice { Id = 21, MenuId = 27, Price = 135, MenuCategoryId = 5 },
                new MenuPrice { Id = 22, MenuId = 28, Price = 135, MenuCategoryId = 5 },

                new MenuPrice { Id = 23, MenuId = 29, Price = 50, MenuCategoryId = 6 },
                new MenuPrice { Id = 24, MenuId = 30, Price = 25, MenuCategoryId = 6 },
                new MenuPrice { Id = 25, MenuId = 31, Price = 40, MenuCategoryId = 6 },
                new MenuPrice { Id = 26, MenuId = 32, Price = 30, MenuCategoryId = 6 },
                new MenuPrice { Id = 27, MenuId = 33, Price = 25, MenuCategoryId = 6 },

                new MenuPrice { Id = 28, MenuId = 34, Price = 88, MenuCategoryId = 7 },
                new MenuPrice { Id = 29, MenuId = 35, Price = 149, MenuCategoryId = 7 },
                new MenuPrice { Id = 30, MenuId = 36, Price = 249, MenuCategoryId = 8 },
                new MenuPrice { Id = 31, MenuId = 37, Price = 380, MenuCategoryId = 8 },
                new MenuPrice { Id = 32, MenuId = 38, Price = 649, MenuCategoryId = 8 },
            };

            var menuCategory = new[]
            {
                new MenuCategory { Id = 1, Name = "Classic Milk Tea" },
                new MenuCategory { Id = 2, Name = "Premium Milk Tea" },
                new MenuCategory { Id = 3, Name = "All Day Meals" },
                new MenuCategory { Id = 4, Name = "Pizza Regular" },
                new MenuCategory { Id = 5, Name = "Pizza Premium" },
                new MenuCategory { Id = 6, Name = "Snacks" },
                new MenuCategory { Id = 7, Name = "Ala Carte" },
                new MenuCategory { Id = 8, Name = "Barkada Wings" }
            };
        }
    }
}
