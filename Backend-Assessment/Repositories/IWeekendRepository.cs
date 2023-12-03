using Backend_Assessment.Models;

namespace Backend_Assessment.Repositories;

public interface IWeekendRepository : IGenericRepository<Weekend, int>
{
    Holiday? GetOne(int countryId);
}