using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Data;
using Backend_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Repositories;

public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
{
    public CategoryRepository(OrderDbContext context) : base(context)
    {
    }

    public Category? GetOne(int id)
    {
        return _context.Categories.AsNoTracking().SingleOrDefault(o => o.Id == id);
    }
}