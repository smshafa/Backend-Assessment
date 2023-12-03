using Backend_Assessment.Data;
using Backend_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Repositories;

public class CountryRepository : GenericRepository<Country, int>, ICountryRepository
{
    public CountryRepository(BookDbContext context) : base(context)
    {
    }
    
    public Country? GetOne(int id)
    {
        return _context.Countries.AsNoTracking().SingleOrDefault(o => o.Id == id);
    }
}