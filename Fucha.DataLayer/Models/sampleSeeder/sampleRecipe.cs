using Fucha.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.Models.sampleSeeder
{
    internal class sampleRecipe
    {
        public sampleRecipe()
        {
            var recipes = new[]
            {
                new Recipe { Id = 1, Name = "Milk Tea Small", HasAddOn = true, MenuCategoryId = 1, SizeId = 1 },
                new Recipe { Id = 2, Name = "Milk Tea Medium", HasAddOn = true, MenuCategoryId = 2, SizeId = 2 },
                new Recipe { Id = 3, Name = "Milk Tea Large", HasAddOn = true, MenuCategoryId = 2, SizeId = 3 },
                new Recipe { Id = 4, Name = "Milk Tea 1 Liter", HasAddOn = true, MenuCategoryId = 2, SizeId = 4 },

                new Recipe { Id = 5, Name = "Japanese Sausage with Rice & Egg", MenuId = 15, MenuCategoryId = 3},
                new Recipe { Id = 6, Name = "Hungarian Sausage with Rice & Egg", MenuId = 16, MenuCategoryId = 3},
                new Recipe { Id = 7, Name = "Spam Bacon with Rice & Egg", MenuId = 17, MenuCategoryId = 3},
                new Recipe { Id = 8, Name = "Cheesedog with Rice & Egg", MenuId = 18, MenuCategoryId = 3},
                new Recipe { Id = 9, Name = "Spam & Japanese Sausage", MenuId = 19, MenuCategoryId = 3},

                new Recipe { Id = 10, Name = "Cheesy Garlic", MenuId = 20, MenuCategoryId = 4},
                new Recipe { Id = 11, Name = "Ham 'N Cheese", MenuId = 21, MenuCategoryId = 4},
                new Recipe { Id = 12, Name = "Peperoni", MenuId = 22, MenuCategoryId = 4},
                new Recipe { Id = 13, Name = "Hawaiian", MenuId = 23, MenuCategoryId = 4},
                new Recipe { Id = 14, Name = "Beef Mushroom", MenuId = 24, MenuCategoryId = 4},
                new Recipe { Id = 15, Name = "All Meat", MenuId = 25, MenuCategoryId = 5},
                new Recipe { Id = 16, Name = "Supreme", MenuId = 26, MenuCategoryId = 5},
                new Recipe { Id = 17, Name = "Chick N Cheese", MenuId = 27, MenuCategoryId = 5},
                new Recipe { Id = 18, Name = "Aloha Special", MenuId = 28, MenuCategoryId = 5},

                new Recipe { Id = 19, Name = "Hungarian Solo", MenuId = 29, MenuCategoryId = 6},
                new Recipe { Id = 20, Name = "Assorted Balls", MenuId = 30, MenuCategoryId = 6},
                new Recipe { Id = 21, Name = "Gyoza", MenuId = 31, MenuCategoryId = 6},
                new Recipe { Id = 22, Name = "Fries", MenuId = 32, MenuCategoryId = 6},
                new Recipe { Id = 23, Name = "Siomai", MenuId = 33, MenuCategoryId = 6},

                new Recipe { Id = 24, Name = "3 pcs with Rice", MenuId = 34, MenuCategoryId = 7},
                new Recipe { Id = 25, Name = "6 pcs with Rice", MenuId = 35, MenuCategoryId = 7},
                new Recipe { Id = 26, Name = "12 pcs", MenuId = 36, MenuCategoryId = 8},
                new Recipe { Id = 27, Name = "18 pcs", MenuId = 37, MenuCategoryId = 8},
                new Recipe { Id = 28, Name = "30 pcs", MenuId = 38, MenuCategoryId = 8},
            };

            var milktea = new[]
            {
                new RecipeStock { Id = 1, StockId = 19, RecipeId = 1 },
                new RecipeStock { Id = 2, StockId = 21, RecipeId = 1 },
                new RecipeStock { Id = 3, StockId = 19, RecipeId = 2 },
                new RecipeStock { Id = 4, StockId = 22, RecipeId = 2 },
                new RecipeStock { Id = 5, StockId = 19, RecipeId = 3 },
                new RecipeStock { Id = 6, StockId = 23, RecipeId = 3 },
                new RecipeStock { Id = 7, StockId = 19, RecipeId = 4 },
                new RecipeStock { Id = 8, StockId = 20, RecipeId = 4 },
            };
            var allDay = new[]
            {
                new RecipeStock { Id = 9, StockId = 29, RecipeId = 5 },
                new RecipeStock { Id = 10, StockId = 30, RecipeId = 5 },
                new RecipeStock { Id = 11, StockId = 25, RecipeId = 5 },
                new RecipeStock { Id = 12, StockId = 29, RecipeId = 6 },
                new RecipeStock { Id = 13, StockId = 30, RecipeId = 6 },
                new RecipeStock { Id = 14, StockId = 26, RecipeId = 6 },
                new RecipeStock { Id = 15, StockId = 29, RecipeId = 7 },
                new RecipeStock { Id = 16, StockId = 30, RecipeId = 7 },
                new RecipeStock { Id = 17, StockId = 27, RecipeId = 7 },
                new RecipeStock { Id = 18, StockId = 29, RecipeId = 8 },
                new RecipeStock { Id = 19, StockId = 30, RecipeId = 8 },
                new RecipeStock { Id = 20, StockId = 28, RecipeId = 8 },
                new RecipeStock { Id = 21, StockId = 25, RecipeId = 9 },
                new RecipeStock { Id = 22, StockId = 28, RecipeId = 9 },
                new RecipeStock { Id = 23, StockId = 30, RecipeId = 9 },
            };

            var pizza = new[]
            {
                new RecipeStock { Id = 24, StockId = 33, RecipeId = 10 },
                new RecipeStock { Id = 25, StockId = 34, RecipeId = 11 },
                new RecipeStock { Id = 26, StockId = 35, RecipeId = 12 },
                new RecipeStock { Id = 27, StockId = 36, RecipeId = 13 },
                new RecipeStock { Id = 28, StockId = 37, RecipeId = 14 },
                new RecipeStock { Id = 29, StockId = 38, RecipeId = 15 },
                new RecipeStock { Id = 30, StockId = 39, RecipeId = 16 },
                new RecipeStock { Id = 31, StockId = 40, RecipeId = 17 },
                new RecipeStock { Id = 32, StockId = 41, RecipeId = 18 },
            };

            var snacks = new[]
            {
                new RecipeStock { Id = 33, StockId = 26, RecipeId = 19 },
                new RecipeStock { Id = 33, StockId = 48, RecipeId = 19 },

                new RecipeStock { Id = 35, StockId = 42, RecipeId = 20 },
                new RecipeStock { Id = 36, StockId = 43, RecipeId = 20 },
                new RecipeStock { Id = 37, StockId = 44, RecipeId = 20 },
                new RecipeStock { Id = 38, StockId = 49, RecipeId = 20 },

                new RecipeStock { Id = 39, StockId = 46, RecipeId = 21 },
                new RecipeStock { Id = 40, StockId = 49, RecipeId = 21 },

                new RecipeStock { Id = 41, StockId = 49, RecipeId = 22 },

                new RecipeStock { Id = 42, StockId = 47, RecipeId = 23 },
                new RecipeStock { Id = 43, StockId = 49, RecipeId = 23 },

                new RecipeStock { Id = 44, StockId = 54, RecipeId = 24 },
                new RecipeStock { Id = 45, StockId = 31, RecipeId = 24 },
                new RecipeStock { Id = 46, StockId = 32, RecipeId = 24 },

                new RecipeStock { Id = 47, StockId = 54, RecipeId = 25 },
                new RecipeStock { Id = 48, StockId = 31, RecipeId = 25 },
                new RecipeStock { Id = 49, StockId = 32, RecipeId = 25 },

                new RecipeStock { Id = 50, StockId = 54, RecipeId = 26 },

                new RecipeStock { Id = 51, StockId = 54, RecipeId = 27 },

                new RecipeStock { Id = 52, StockId = 54, RecipeId = 28 },

            };
        }
    }
}
