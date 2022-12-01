using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.Models.sampleSeeder
{
    public class sampleStocks
    {
        public sampleStocks()
        {
            var milkteaIngredientStocks = new[]
            {
                new Stock { Id = 1, Name = "Okinawa", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 2, Name = "Red Velvet", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 3, Name = "Wintermelon", SupplierId = 2, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 4, Name = "Salted Caramel", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 5, Name = "Taro", SupplierId = 2, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 6, Name = "Dark Chocolate", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 7, Name = "Hokkaido", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 8, Name = "Black Wintermelon", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 9, Name = "Avocado Cheesecake", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 10, Name = "Choco Bunny", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 11, Name = "Choco Berry Meiji", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 12, Name = "Mango Graham Cabin", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 13, Name = "Salty Cream Okinawa", SupplierId = 1, Measure = 15, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaFlavor, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },

                new Stock { Id = 14, Name = "Pearl", SupplierId = 2, Measure = 5, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaAddOn, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 15, Name = "Nata", SupplierId = 2, Measure = 5, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaAddOn, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 16, Name = "Nutella", SupplierId = 3, Measure = 5, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaAddOn, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 17, Name = "Cookies", SupplierId = 1, Measure = 5, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaAddOn, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 18, Name = "Cream Cheese", SupplierId = 1, Measure = 5, MeasurementUnit = MeasurementUnit.Kilograms, Category = StockCategory.MilkTeaAddOn, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
            };

            var milkteaMaterialStocks = new[]
            {
                new Stock { Id = 19, Name = "Straw", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 20, Name = "Straw 1L", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 21, Name = "Cup 12 oz", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 22, Name = "Cup 16 oz", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 23, Name = "Cup 22 oz", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 24, Name = "Cup 1L", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") }
            };

            var allDayStocks = new[]
            {
                new Stock { Id = 25, Name = "Japanese Sausage", SupplierId = 4, StockServingId = 1, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 26, Name = "Hungarian Sausage", SupplierId = 5, StockServingId = 1, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 27, Name = "Cheesedog", SupplierId = null, StockServingId = 1, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 28, Name = "Spam Bacon", SupplierId = 4, StockServingId = 2, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Can, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 29, Name = "Egg", SupplierId = 6, StockServingId = 1, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                
                new Stock { Id = 30, Name = "Styro Plate", SupplierId = null, StockServingId = 1, Category = StockCategory.Material, Measure = 200, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 31, Name = "Plastic Spoon", SupplierId = null, StockServingId = 1, Category = StockCategory.Material, Measure = 200, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 32, Name = "Plastic Fork", SupplierId = null, StockServingId = 1, Category = StockCategory.Material, Measure = 200, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
            };

            var pizzaStocks = new[]
            {
                new Stock { Id = 33, Name = "Cheesy Garlic", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 34, Name = "Ham 'N Cheese", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 35, Name = "Peperoni", SupplierId = 8, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 36, Name = "Hawaiian", SupplierId = 9, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 37, Name = "Beef Mushroom", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 38, Name = "All Meat", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 39, Name = "Supreme", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 40, Name = "Chick N Cheese", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 41, Name = "Aloha Special", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
            };

            var snackStocks = new[]
            {
                new Stock { Id = 42, Name = "Chicken balls", SupplierId = 10, StockServingId = 2, Category = StockCategory.Snack, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 43, Name = "Squad balls", SupplierId = 10, StockServingId = 2, Category = StockCategory.Snack, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 44, Name = "Shrimp balls", SupplierId = 10, StockServingId = 2, Category = StockCategory.Snack, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                
                new Stock { Id = 45, Name = "French Fries", SupplierId = 5, StockServingId = null, Category = StockCategory.Snack, Measure = 10, MeasurementUnit = MeasurementUnit.Kilograms, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 46, Name = "Gyoza", SupplierId = 4, StockServingId = 5, Category = StockCategory.Snack, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 47, Name = "Siomai", SupplierId = 11, StockServingId = 5, Category = StockCategory.Snack, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },

                new Stock { Id = 48, Name = "Stick", SupplierId = null, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 49, Name = "Paper Tray", SupplierId = null, StockServingId = 5, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                
                new Stock { Id = 50, Name = "BBQ", SupplierId = null, Category = StockCategory.Ingredient, Measure = 10, MeasurementUnit = MeasurementUnit.Pack, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 51, Name = "Cheese", SupplierId = null, Category = StockCategory.Ingredient, Measure = 10, MeasurementUnit = MeasurementUnit.Pack, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 52, Name = "Sour Cream", SupplierId = null, Category = StockCategory.Ingredient, Measure = 10, MeasurementUnit = MeasurementUnit.Pack, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
            };

            var wings = new[]
            {
                new Stock { Id = 53, Name = "Chicken", SupplierId = null, Category = StockCategory.Wing, Measure = 50, MeasurementUnit = MeasurementUnit.Kilograms, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 54, Name = "Paper Liner", SupplierId = null, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },

                new Stock { Id = 55, Name = "Sweet Chili", SupplierId = 12, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 56, Name = "Terriyaki", SupplierId = 13, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 57, Name = "Mango Habanero", SupplierId = 8, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 58, Name = "Buffalo", SupplierId = 12, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 59, Name = "Soy Garlic", SupplierId = 13, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 60, Name = "Hickory BBQ", SupplierId = 12, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 61, Name = "Garlic Parmesan", SupplierId = 12, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 62, Name = "Sriracha", SupplierId = 12, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 63, Name = "Salted Egg", SupplierId = 8, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 64, Name = "Spiced Maple", SupplierId = 8, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 65, Name = "Lemon Glazed", SupplierId = 12, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 66, Name = "Korean Spicy", SupplierId = 12, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
            };

            var stockServings = new[]
            {
                new StockServing { Id = 1, RequiredPerServing = 1, MeasurementUnit = MeasurementUnit.Pieces },
                new StockServing { Id = 2, RequiredPerServing = 2, MeasurementUnit = MeasurementUnit.Pieces },
                new StockServing { Id = 3, RequiredPerServing = 3, MeasurementUnit = MeasurementUnit.Pieces },
                new StockServing { Id = 4, RequiredPerServing = 4, MeasurementUnit = MeasurementUnit.Pieces },
                new StockServing { Id = 5, RequiredPerServing = 5, MeasurementUnit = MeasurementUnit.Pieces }
            };
        }
    }
}
