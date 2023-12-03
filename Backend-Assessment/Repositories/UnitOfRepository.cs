using Backend_Assessment.Data;

namespace Backend_Assessment.Repositories;

public class UnitOfRepository : IUnitOfRepository
{
    private readonly IDbContext _context;
    
    public ICountryRepository Countries { get; set; }
    public IHolidayRepository Holidays { get; set; }
    public IWeekendRepository Weekends { get; set; }

    public UnitOfRepository(IDbContext dbContext, ICountryRepository countries, IHolidayRepository holidays,  IWeekendRepository weekends)
    {
        _context = dbContext;

        Countries = countries;
        Holidays = holidays;
        Weekends = weekends;
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