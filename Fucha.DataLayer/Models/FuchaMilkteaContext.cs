using Fucha.DomainClasses;
using Microsoft.EntityFrameworkCore;

namespace Fucha.DataLayer.Models
{
    public class FuchaMilkteaContext : DbContext, IFuchaMilkteaContext
    {
        public FuchaMilkteaContext(DbContextOptions<FuchaMilkteaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed(); // Initialize Data
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost\\SQLEXPRESS;Initial Catalog=fuchaappdb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeStock> RecipeStocks { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockServing> StockServings { get; set; }
        public DbSet<AddOn> AddOns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SaleTransaction> SalesTransaction { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<PORecord> PORecords { get; set; }
        public DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        public DbSet<MenuPrice> MenuPrices { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<LoginHistory> LoginHistories { get; set; }

        public DbSet<MTGramSold> MTGramSolds { get; set; }

        public DbSet<ActivityHistory> ActivityHistories { get; set; }


        public new int SaveChanges()
        {
            return base.SaveChanges();
        }
    }

    public interface IFuchaMilkteaContext : IDisposable
    {
        DbSet<Menu> Menus { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<RecipeStock> RecipeStocks { get; set; }
        DbSet<Stock> Stocks { get; set; }
        DbSet<StockServing> StockServings { get; set; }
        DbSet<AddOn> AddOns { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<SaleTransaction> SalesTransaction { get; set; }
        DbSet<MenuCategory> MenuCategories { get; set; }
        DbSet<Size> Sizes { get; set; }
        DbSet<PORecord> PORecords { get; set; }
        DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        DbSet<MenuPrice> MenuPrices { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<LoginHistory> LoginHistories { get; set; }

        DbSet<MTGramSold> MTGramSolds { get; set; }

        DbSet<ActivityHistory> ActivityHistories { get; set; }

        int SaveChanges();
    }
}