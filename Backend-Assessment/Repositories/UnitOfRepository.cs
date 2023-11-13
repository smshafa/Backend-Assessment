using Backend_Assessment.Data;

namespace Backend_Assessment.Repositories;

public class UnitOfRepository : IUnitOfRepository
{
    private readonly IDbContext _context;
    public IProductRepository Products { get; set; }
    public ICategoryRepository Categories { get; set; }

    public UnitOfRepository(IDbContext dbContext, IProductRepository productRepository,
        ICategoryRepository categoryRepository)
    {
        _context = dbContext;
        Products = productRepository;
        Categories = categoryRepository;
    }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
    }
}