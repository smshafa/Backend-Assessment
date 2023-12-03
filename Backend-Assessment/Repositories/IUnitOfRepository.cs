namespace Backend_Assessment.Repositories;

public interface IUnitOfRepository : IDisposable
{
    public ICountryRepository Countries { get; }
    public IHolidayRepository Holidays { get; }
    public IWeekendRepository Weekends { get; }
    int Complete();
}