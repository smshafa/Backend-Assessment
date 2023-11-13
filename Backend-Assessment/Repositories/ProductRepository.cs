using Backend_Assessment.Application.Features.Dto.Product;
using Backend_Assessment.Data;
using Backend_Assessment.Models;

namespace Backend_Assessment.Repositories;

public class ProductRepository : GenericRepository<Product, int>, IProductRepository
{
    public ProductRepository(OrderDbContext context) : base(context)
    {
    }

    public Product? GetOne(int id)
    {
        return _context.Products.SingleOrDefault(o => o.Id == id);
    }

    public IEnumerable<Product> GetProducts(string name)
    {
        return _context.Products.Where(x => x.Name == name);
    }
}