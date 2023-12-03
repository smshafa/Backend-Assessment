using Backend_Assessment.Models;

namespace Backend_Assessment.Repositories;

public interface IHolidayRepository : IGenericRepository<Holiday, int>
{
    IQueryable<Holiday> GetHolidays();
    Holiday? GetOne(int countryId);
}