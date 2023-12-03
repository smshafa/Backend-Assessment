using Backend_Assessment.Data;
using Backend_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Repositories;

public class HolidayRepository : GenericRepository<Holiday, int>, IHolidayRepository
{
    public HolidayRepository(BookDbContext context) : base(context)
    {
    }

    public Holiday? GetOne(int countryId)
    {
        return _context.Holidays.SingleOrDefault(o => o.CountryId == countryId);
    }

    public IQueryable<Holiday> GetHolidays()
    {
        return _context.Holidays.AsNoTracking();
    }
}