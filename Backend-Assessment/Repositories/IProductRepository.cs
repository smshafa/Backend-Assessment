using Backend_Assessment.Application.Features.Dto.Product;
using Backend_Assessment.Models;

namespace Backend_Assessment.Repositories;

public interface IProductRepository : IGenericRepository<Product, int>
{
    IEnumerable<Product> GetProducts(string name);
    Product? GetOne(int id);
}