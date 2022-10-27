using Fucha.DomainClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        //public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Meal> Meals { get; set; }

        public int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = "server=localhost; port=5432; database=fuchaappdb; username=postgres; password=adminPass ;Persist Security Info=False;";
            //var connectionString = "Data Source = tcp:fuchaappdb.database.windows.net,1433; Initial Catalog = FuchaAppDB; User Id = dbAdmin@fuchaappdb; Password = @CapstoneDb;";
            var connectionString = "Data Source=DESKTOP-LMK627L\\SQLEXPRESS;Initial Catalog=fuchaappdb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            _modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Roy", LastName = "Sabenecio", UserName = "roy", Password = "r", Role = "Admin", UserStatus = "Approved" }
                );
            //_modelBuilder.Entity<Ingredient>().HasData(
            //    new Ingredient() { Id = 1, Name="Okinawa", Category="", Quantity="200",IngredientStatus}
            //    );
        }
    }

    public interface IFuchaMilkteaContext : IDisposable
    {
        DbSet<Ingredient> Ingredients { get; set; }
        //public DbSet<Inventory> Inventories { get; set; }
        DbSet<Material> Materials { get; set; }
        DbSet<Menu> Menu { get; set; }
        DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<Sale> Sale { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Meal> Meals { get; set; }

        int SaveChanges();
    }
}
