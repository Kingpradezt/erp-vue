// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using ERP.Inventory.API.Models;  // your Models namespace

namespace ERP.Inventory.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().ToTable("app_users");
            modelBuilder.Entity<Product>().ToTable("products");
            base.OnModelCreating(modelBuilder);
        }
    }
}
