namespace Backend_Assessment.Repositories;

public interface IUnitOfRepository : IDisposable
{
    IProductRepository Products { get; }
    ICategoryRepository Categories { get; }
    int Complete();
}