using Backend_Assessment.Data;
using Backend_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Repositories;

public class WeekendRepository : GenericRepository<Weekend, int>, IWeekendRepository
{
    public WeekendRepository(BookDbContext context) : base(context)
    {
    }

    public Holiday? GetOne(int countryId)
    {
        return _context.Holidays.SingleOrDefault(o => o.CountryId == countryId);
    }
}