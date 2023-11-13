using Backend_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Data;

public class OrderDbContext : DbContext, IDbContext
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
    {
        Database.Migrate();
        // Or Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany<Product>(g => g.Products)
            .WithOne(s => s.Category)
            .HasForeignKey(s => s.CategoryId);
    }
}