using Backend_Assessment.Application.Features.Dto.Product;
using Backend_Assessment.Data;
using Backend_Assessment.Models;

namespace Backend_Assessment.Repositories;

public class ProductRepository : GenericRepository<Product, int>, IProductRepository
{
    public ProductRepository(OrderDbContext context) : base(context)
    {
    }

    public IQueryable<ProductDto> GetOne(int id)
    {
        var q = _context.Products.Where(o => o.Id == id).Select(e => new ProductDto {Id = e.Id});
        return q;
    }

    public IEnumerable<Product> GetProducts(string name)
    {
        return _context.Products.Where(x => x.Name == name);
    }
}