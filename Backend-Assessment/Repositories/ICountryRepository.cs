using Backend_Assessment.Models;

namespace Backend_Assessment.Repositories;

public interface ICountryRepository : IGenericRepository<Country, int>
{
    Country? GetOne(int id);
}