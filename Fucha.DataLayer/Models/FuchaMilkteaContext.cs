using Fucha.DomainClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.Models
{
    public class FuchaMilkteaContext : DbContext, IFuchaMilkteaContext
    {

        public FuchaMilkteaContext() { }
        public FuchaMilkteaContext(DbContextOptions<FuchaMilkteaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            
            //modelBuilder.Entity<Recipe>()
            //    .HasOne(r => r.Ingredient)
            //    .WithOne(i => i.Recipe)
            //    .HasForeignKey<Ingredient>(i => i.RecipeId);

            modelBuilder.Seed(); // Initialize Data
            //new DbInitializer(modelBuilder).Seed();

        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<AddOn> AddOns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SaleTransaction> SalesTransaction { get; set; }

        public DbSet<MenuCategory> MenuCategories { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        
        
        //public DbSet<Meal> Meals { get; set; } // double check

        public DbSet<Item> Items { get; set; }
        public DbSet<MenuPrice> MenuPrices { get; set; }

        public int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Azure Connection String
            //var connectionString = "Data Source = tcp:fuchaappdb.database.windows.net,1433; Initial Catalog = FuchaAppDB; User Id = dbAdmin@fuchaappdb; Password = @CapstoneDb;";
            var connectionString = "Data Source=DESKTOP-LMK627L\\SQLEXPRESS;Initial Catalog=fuchaappdb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    public interface IFuchaMilkteaContext : IDisposable
    {
        DbSet<Menu> Menus { get; set; }
        DbSet<AddOn> AddOns { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<SaleTransaction> SalesTransaction { get; set; }

        DbSet<MenuCategory> MenuCategories { get; set; }

        DbSet<Size> Sizes { get; set; }

        DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        //DbSet<Meal> Meals { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<MenuPrice> MenuPrices { get; set; }



        //DbSet<Sale> Sales { get; set; }

        int SaveChanges();
    }



    //public class DbInitializer
    //{
    //    private readonly ModelBuilder _modelBuilder;
    //    public DbInitializer(ModelBuilder modelBuilder)
    //    {
    //        _modelBuilder = modelBuilder;
    //    }

    //    public void Seed()
    //    {

    //        //_modelBuilder.Entity<Ingredient>().HasData(
    //        //    new Ingredient() { Id = 1, Name="Okinawa", Category="", Quantity="200",IngredientStatus}
    //        //    );


    //        //var ingredients = dbContext.Ingredients.ToDictionary(i => i.Name, i => i.Id);
    //        //_modelBuilder.Entity<Recipe>().HasData(
    //        //    new Recipe { Id=1, RecipeCategory="Milk Tea", Name="Okinawa", Size="Small",
    //        //        Ingredients = new[]
    //        //        {
    //        //            new Ingredient { Id= ingredients["Okinawa"], Name=}
    //        //        }
    //        //        , Materials, Price, }
    //        //    );
    //        //_modelBuilder.Entity<Recipe>().HasData(
    //        //    new Recipe
    //        //    {
    //        //        Id = 1,
    //        //        RecipeCategory = "Milk Tea",
    //        //        Name = "Okinawa",
    //        //        Size = "Small",
    //        //        Price = 60,
    //        //    });

    //        //dbContext.SaveChanges();

    //        //var r1 = dbContext.Recipes.Find(1);
    //        //var i1 = dbContext.Ingredients.Find(1);

    //        //r1.Ingredients.Add(i1);

    //        //        //var r1 = dbContext.Entry(r1).Collection(r => r.Ingredients).Load();

    //    }
    //}


}
