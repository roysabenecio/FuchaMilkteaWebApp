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
            modelBuilder.Seed(); // Initialize Data
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<AddOn> AddOns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SaleTransaction> SalesTransaction { get; set; }

        public DbSet<MenuCategory> MenuCategories { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<PORecord> PORecords { get; set; }
        public DbSet<PurchaseRecord> PurchaseRecords { get; set; }

        public DbSet<Recipe> Recipes { get; set; }
        
        
        //public DbSet<Meal> Meals { get; set; } // double check
        public DbSet<MenuPrice> MenuPrices { get; set; }

        //Inventory Side
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockCategorys> StockCategories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public new int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Azure Connection String
            //var connectionString = "Data Source = tcp:fuchaappdb.database.windows.net,1433; Initial Catalog = FuchaAppDB; User Id = dbAdmin@fuchaappdb; Password = @CapstoneDb;";
            var connectionString = "Data Source=DESKTOP-LMK627L\\SQLEXPRESS;Initial Catalog=fuchaappdb;Integrated Security=True";
            //var connectionString = "Data Source=DESKTOP-8QM55PT;Initial Catalog=fuchaappdb;Integrated Security=True";
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

        DbSet<PORecord> PORecords { get; set; }
        DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        //DbSet<Meal> Meals { get; set; }
        DbSet<MenuPrice> MenuPrices { get; set; }

        //DbSet<Sale> Sales { get; set; }


        //Inventory Side
        DbSet<Stock> Stocks { get; set; }
        DbSet<StockCategorys> StockCategories { get; set; }
        DbSet<Supplier> Suppliers { get; set; }



        int SaveChanges();
    }

}
