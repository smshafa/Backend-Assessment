using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Data;

public interface IDbContext
{
    DbSet<T> Set<T>() where T : class;
    int SaveChanges();
    void Dispose();
}