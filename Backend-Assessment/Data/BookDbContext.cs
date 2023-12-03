using Backend_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Data;

public class BookDbContext : DbContext, IDbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {
        Database.Migrate();
        // Or Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
    
    public DbSet<Country> Countries { get; set; }
    public DbSet<Holiday> Holidays { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>()
            .HasMany<Holiday>(g => g.Holidays)
            .WithOne(s => s.Country)
            .HasForeignKey(s => s.CountryId);
        
        modelBuilder.Entity<Country>()
            .HasMany<Weekend>(g => g.Weekends)
            .WithOne(s => s.Country)
            .HasForeignKey(s => s.CountryId);
    }
}