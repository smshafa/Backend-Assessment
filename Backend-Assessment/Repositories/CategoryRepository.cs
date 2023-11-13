using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Data;
using Backend_Assessment.Models;

namespace Backend_Assessment.Repositories;

public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
{
    public CategoryRepository(OrderDbContext context) : base(context)
    {
    }

    public IQueryable<CategoryDto> GetOne(int id)
    {
        return _context.Categories.Where(o => o.Id == id).Select(e => new CategoryDto() {Id = e.Id});
    }
}