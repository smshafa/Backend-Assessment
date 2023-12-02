using Backend_Assessment.Models;
using Backend_Assessment.Repositories;
using Moq;

namespace TestProject.Mocks;

internal class MockICategoryRepository
{
    public static Mock<ICategoryRepository> GetMock()
    {
        var mock = new Mock<ICategoryRepository>();
        var categories = new List<Category>()
        {
            new Category()
            {
                Id = 1,
                Name = "John",
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Id = 1,
                        Name = "BMW",
                    }
                }
            }
        };
        
        // Set up
        mock.Setup(m => m.GetAll()).Returns(() => categories);
        mock.Setup(m => m.GetOne(It.IsAny<int>()))
            .Returns((int id) => categories.FirstOrDefault(o => o.Id == id));
        mock.Setup(m => m.Add(It.IsAny<Category>()))
            .Callback(() => { return; });
        mock.Setup(m => m.Update(It.IsAny<Category>()))
            .Callback(() => { return; });
        mock.Setup(m => m.Delete(It.IsAny<Category>()))
            .Callback(() => { return; });

        return mock;
    }
}