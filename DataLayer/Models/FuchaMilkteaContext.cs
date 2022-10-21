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

        public DbSet<Ingredient> Ingredients { get; set; }
        //public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<User> Users { get; set; }

        public int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost; port=5432; database=fuchaappdb; username=postgres; password=adminPass ;Persist Security Info=False;";
            optionsBuilder.UseNpgsql(connectionString);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
        //public class UserDetailMappings : IEntityTypeConfiguration<User>
        //{
        //    public void Configure(EntityTypeBuilder<User> builder)
        //    {
        //        //throw new NotImplementedException();
        //        builder.HasKey(u => u.Id);
        //    }
        //}
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

        int SaveChanges();
    }
}
