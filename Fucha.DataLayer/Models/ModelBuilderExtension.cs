using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.Models
{
    public static class ModelBuilderExtension
    {
        private static readonly FuchaMilkteaContext _dbContext;
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Ingredient i1 = new Ingredient { Id = 1, IngredientCategory = "Milk Tea Powder", Name = "Okinawa Powder", Quantity = 5, MeasurementType = "Kilograms" };
            //Recipe r1 =
            //new Recipe
            //{
            //    Id = 1,
            //    RecipeCategory = "Milk Tea",
            //    Name = "Okinawa",
            //    Size = "Small",
            //    Price = 60,
            //    Ingredient = i1
            //};
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Roy", LastName = "Sabenecio", UserName = "roy", Password = "r", Role = "Admin", UserStatus = "Approved" }
                );
            //modelBuilder.Entity<Ingredient>().HasData(
            //    new Ingredient { Id = 1, IngredientCategory = "Milk Tea Powder", Name = "Okinawa Powder", Quantity = 5, MeasurementType = "Kilograms" }
            //    );
            modelBuilder.Entity<Item>().HasData(
                new Item{ Id = 1, ItemCategory = "Milk Tea Powder", Name = "Okinawa Powder", Quantity = 5, MeasurementUnit = "Kilograms" },
                new Item { Id = 2, ItemCategory = "Utensil", Name= "Milk Tea Cup", Quantity = 10, MeasurementUnit = "Pieces"}
                );
            modelBuilder.Entity<Menu>().HasData(
                //new Menu { Id = 1, MenuCategory = MenuCategory.ClassicMilkTea, Name = "Okinawa", Specification = MilkTeaSpecification.Regular },
                //new Menu { Id = 2, MenuCategory = MenuCategory.ClassicMilkTea, Name = "Red Velvet", Specification = MilkTeaSpecification.Regular },
                //new Menu { Id = 3, MenuCategory = MenuCategory.ClassicMilkTea, Name = "Wintermelon", Specification = MilkTeaSpecification.Regular },
                //new Menu { Id = 6, MenuCategory = MenuCategory.ClassicMilkTea, Name = "Cookies & Cream", Specification = MilkTeaSpecification.Premium },
                //new Menu { Id = 7, MenuCategory = MenuCategory.ClassicMilkTea, Name = "Dark Chocolate", Specification = MilkTeaSpecification.Premium }
                new Menu { Id = 1, MenuCategory = MenuCategory.ClassicMilkTea, Name = "Okinawa"},
                new Menu { Id = 2, MenuCategory = MenuCategory.ClassicMilkTea, Name = "Red Velvet"},
                new Menu { Id = 3, MenuCategory = MenuCategory.ClassicMilkTea, Name = "Wintermelon"},
                new Menu { Id = 6, MenuCategory = MenuCategory.PremiumMilkTea, Name = "Cookies & Cream"},
                new Menu { Id = 7, MenuCategory = MenuCategory.PremiumMilkTea, Name = "Dark Chocolate"}
                );
            //modelBuilder.Entity<Recipe>().HasData(
            //    new Recipe 
            //    {
            //        Id = 1,
            //        RecipeCategory = "Milk Tea",
            //        Name = "Okinawa",
            //        Size = "Small",
            //        Price = 60,
            //        //Ingredient = () => modelBuilder.Entity<Ingredient>().HasData()
            //    });
            //modelBuilder.Entity<Ingredient>().HasData(i1);
            //modelBuilder.Entity<Recipe>().HasData(r1);

            //_dbContext.SaveChanges();

        }
    }
}
