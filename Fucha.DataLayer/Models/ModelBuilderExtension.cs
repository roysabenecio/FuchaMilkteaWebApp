﻿using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using Microsoft.EntityFrameworkCore;

namespace Fucha.DataLayer.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
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

            modelBuilder.Entity<Stock>().HasData(
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

                new Stock { Id = 19, Name = "Straw", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 20, Name = "Straw 1L", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 21, Name = "Cup 12 oz", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 22, Name = "Cup 16 oz", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 23, Name = "Cup 22 oz", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 24, Name = "Cup 1L", SupplierId = 2, StockServingId = 1, Category = StockCategory.Material, Measure = 100, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },

                new Stock { Id = 25, Name = "Japanese Sausage", SupplierId = 4, StockServingId = 1, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 26, Name = "Hungarian Sausage", SupplierId = 5, StockServingId = 1, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 27, Name = "Cheesedog", SupplierId = null, StockServingId = 1, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 28, Name = "Spam Bacon", SupplierId = 4, StockServingId = 2, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Can, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 29, Name = "Egg", SupplierId = 6, StockServingId = 1, Category = StockCategory.Ingredient, Measure = 50, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },

                new Stock { Id = 30, Name = "Styro Plate", SupplierId = null, StockServingId = 1, Category = StockCategory.Material, Measure = 200, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 31, Name = "Plastic Spoon", SupplierId = null, StockServingId = 1, Category = StockCategory.Material, Measure = 200, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 32, Name = "Plastic Fork", SupplierId = null, StockServingId = 1, Category = StockCategory.Material, Measure = 200, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },

                new Stock { Id = 33, Name = "Cheesy Garlic", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 34, Name = "Ham 'N Cheese", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 35, Name = "Peperoni", SupplierId = 8, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 36, Name = "Hawaiian", SupplierId = 9, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 37, Name = "Beef Mushroom", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 38, Name = "All Meat", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 39, Name = "Supreme", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 40, Name = "Chick N Cheese", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Stock { Id = 41, Name = "Aloha Special", SupplierId = 7, StockServingId = 1, Category = StockCategory.Pizza, Measure = 20, MeasurementUnit = MeasurementUnit.Pieces, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },

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
                new Stock { Id = 66, Name = "Korean Spicy", SupplierId = 12, Category = StockCategory.Ingredient, Measure = 5, MeasurementUnit = MeasurementUnit.Bottle, DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") }
                );

            modelBuilder.Entity<StockServing>().HasData(
                new StockServing { Id = 1, RequiredPerServing = 1, MeasurementUnit = MeasurementUnit.Pieces },
                new StockServing { Id = 2, RequiredPerServing = 2, MeasurementUnit = MeasurementUnit.Pieces },
                new StockServing { Id = 3, RequiredPerServing = 3, MeasurementUnit = MeasurementUnit.Pieces },
                new StockServing { Id = 4, RequiredPerServing = 4, MeasurementUnit = MeasurementUnit.Pieces },
                new StockServing { Id = 5, RequiredPerServing = 5, MeasurementUnit = MeasurementUnit.Pieces }
                );

            modelBuilder.Entity<RecipeStock>().HasData(
                new RecipeStock { Id = 1, StockId = 19, RecipeId = 1 },
                new RecipeStock { Id = 2, StockId = 21, RecipeId = 1 },
                new RecipeStock { Id = 3, StockId = 19, RecipeId = 2 },
                new RecipeStock { Id = 4, StockId = 22, RecipeId = 2 },
                new RecipeStock { Id = 5, StockId = 19, RecipeId = 3 },
                new RecipeStock { Id = 6, StockId = 23, RecipeId = 3 },
                new RecipeStock { Id = 7, StockId = 19, RecipeId = 4 },
                new RecipeStock { Id = 8, StockId = 20, RecipeId = 4 },

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

                new RecipeStock { Id = 24, StockId = 33, RecipeId = 10 },
                new RecipeStock { Id = 25, StockId = 34, RecipeId = 11 },
                new RecipeStock { Id = 26, StockId = 35, RecipeId = 12 },
                new RecipeStock { Id = 27, StockId = 36, RecipeId = 13 },
                new RecipeStock { Id = 28, StockId = 37, RecipeId = 14 },
                new RecipeStock { Id = 29, StockId = 38, RecipeId = 15 },
                new RecipeStock { Id = 30, StockId = 39, RecipeId = 16 },
                new RecipeStock { Id = 31, StockId = 40, RecipeId = 17 },
                new RecipeStock { Id = 32, StockId = 41, RecipeId = 18 },

                new RecipeStock { Id = 33, StockId = 26, RecipeId = 19 },
                new RecipeStock { Id = 34, StockId = 48, RecipeId = 19 },

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

                new RecipeStock { Id = 52, StockId = 54, RecipeId = 28 }
                );

            foreach (var r in recipes)
            {
                modelBuilder.Entity<Recipe>().HasData(r);
            }

            modelBuilder.Entity<Menu>().HasData(
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
                new Menu { Id = 38, MenuCategoryId = 8, Name = "30 pcs" }
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
                new MenuPrice { Id = 32, MenuId = 38, Price = 649, MenuCategoryId = 8 }
                );

            modelBuilder.Entity<MenuCategory>().HasData(
                new MenuCategory { Id = 1, Name = "Classic Milk Tea" },
                new MenuCategory { Id = 2, Name = "Premium Milk Tea" },
                new MenuCategory { Id = 3, Name = "All Day Meals" },
                new MenuCategory { Id = 4, Name = "Pizza Regular" },
                new MenuCategory { Id = 5, Name = "Pizza Premium" },
                new MenuCategory { Id = 6, Name = "Snacks" },
                new MenuCategory { Id = 7, Name = "Ala Carte" },
                new MenuCategory { Id = 8, Name = "Barkada Wings" }
                );

            modelBuilder.Entity<AddOn>().HasData(
                new AddOn { Id = 1, Name = "No Add-On", AddOnPrice = 0 },
                new AddOn { Id = 2, Name = "Pearl", AddOnPrice = 10 },
                new AddOn { Id = 3, Name = "Nata", AddOnPrice = 10 },
                new AddOn { Id = 4, Name = "Nutella", AddOnPrice = 10 },
                new AddOn { Id = 5, Name = "Cookies", AddOnPrice = 10 },
                new AddOn { Id = 6, Name = "Cream Cheese", AddOnPrice = 10 }
                );

            modelBuilder.Entity<Size>().HasData(
                new Size { Id = 1, Name = "Small" },
                new Size { Id = 2, Name = "Medium" },
                new Size { Id = 3, Name = "Large" },
                new Size { Id = 4, Name = "1 Liter" }
                );

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Roy", LastName = "Sabenecio", UserName = "r", Password = "r", Role = "Admin", UserStatus = "Approved" }
                );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "In joy", Address = "157 Josefa Drive Brgy, Corazon De Jesus, San Juan City", ContactNumber = "09178077279", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 2, Name = "PHNI Bubble Tea Store", Address = "208A Banawe St., Brgy Tatalon, Quezon City", ContactNumber = "09175858100", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 3, Name = "MSCS PrimeGoods, Inc.", Address = "San Juan Manila", ContactNumber = "09171284151", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 4, Name = "Fuji Mart Incorporated", Address = "1747 A. Mabini St, Malate, Manila, 1004 Metro Manila", ContactNumber = "(02) 8523 1186", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 5, Name = "Consistent Frozen Solutions", Address = "2329 Juan Luna St, Gagalangin, Manila, Metro Manila", ContactNumber = "09985172380", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 6, Name = "FST Egg Store", Address = "40 Scout Oscar M. Alcaraz St, Santa Mesa Heights, Quezon City, 1114 Metro Manila", ContactNumber = "09171735588", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 7, Name = "Pizza Crust", Address = "#24 F Pasco Aveue Santolan, Pasig", ContactNumber = "09955823086", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 8, Name = "Negosyo Now", Address = "704 Rizal Ave. ext.Caloocan City, Metro Manil, 1403", ContactNumber = "09955823086", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 9, Name = "Vostra Pizza", Address = "Metro Manila", ContactNumber = "09955823086", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 10, Name = "Golden Fishball Factory", Address = "837 Asuncion St, Binondo, Manila, 2006 Metro Manila", ContactNumber = "09971220886", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 11, Name = "Siomai Wholesale Supplier PH", Address = "San Roque, Antipolo", ContactNumber = "09610074035", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 12, Name = "JD FOODS Premium Sauces", Address = "1005 Atlanta Centre Bldg., 31 Annapolis St., Greenhills, San Juan City", ContactNumber = "721-339-47", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 13, Name = "Easy Brand Ph", Address = "7F Steelworld Bldg. 713 N.S. Amoranto Sr. corner Biak na Bato Street, Quezon City", ContactNumber = "09286418135", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") }
                );

            modelBuilder.Entity<PurchaseRecord>().HasData(
                new PurchaseRecord() { Id = 1, SupplierId = 1, ItemQuantity = 2, TotalAmount = 100, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), UserId = 1 },
                new PurchaseRecord() { Id = 2, SupplierId = 3, ItemQuantity = 1, TotalAmount = 50, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), UserId = 1 }
                );

            modelBuilder.Entity<PORecord>().HasData(
                new PORecord() { Id = 1, StockId = 1, Category = StockCategory.MilkTeaFlavor, Measure = 100, MeasurementUnit = MeasurementUnit.Kilograms, Price = 100, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), PurchaseRecordId = 1 },
                new PORecord() { Id = 2, StockId = 2, Category = StockCategory.MilkTeaFlavor, Measure = 50, MeasurementUnit = MeasurementUnit.Kilograms, Price = 50, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), PurchaseRecordId = 1 },
                new PORecord() { Id = 3, StockId = 4, Category = StockCategory.MilkTeaAddOn, Measure = 50, MeasurementUnit = MeasurementUnit.Kilograms, Price = 50, DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"), PurchaseRecordId = 2 }
                );
            
        }
    }
}