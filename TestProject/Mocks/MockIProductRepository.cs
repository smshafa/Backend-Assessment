using Backend_Assessment.Models;
using Backend_Assessment.Repositories;
using Moq;

namespace TestProject.Mocks;

internal class MockIProductRepository
{
    public static Mock<IProductRepository> GetMock()
    {
        var mock = new Mock<IProductRepository>();
        var products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Car",
                CategoryId = 1,
            }
        };
        
        mock.Setup(m => m.GetAll()).Returns(() => products);
        mock.Setup(m => m.GetOne(It.IsAny<int>()))
            .Returns((int id) => products.FirstOrDefault(o => o.Id == id));
        mock.Setup(m => m.Add(It.IsAny<Product>()))
            .Callback(() => { return; });
        mock.Setup(m => m.Update(It.IsAny<Product>()))
            .Callback(() => { return; });
        mock.Setup(m => m.Delete(It.IsAny<Product>()))
            .Callback(() => { return; });
        return mock;
    }
}