using Backend_Assessment.Repositories;
using Moq;

namespace TestProject.Mocks;

internal class MockUnitOfRepositories
{
    public static Mock<IUnitOfRepository> GetMock()
    {
        var mock = new Mock<IUnitOfRepository>();
//        mock.Setup(m => m.Categories).Returns(() => new Mock<ICategoryRepository>().Object);
//        mock.Setup(m => m.Products).Returns(() => new Mock<IProductRepository>().Object);
        
        var productRepoMock = MockIProductRepository.GetMock();
        var categoryRepoMock = MockICategoryRepository.GetMock();
        
        mock.Setup(m => m.Categories).Returns(() => productRepoMock.Object);
        mock.Setup(m => m.Products).Returns(() => categoryRepoMock.Object);
        mock.Setup(m => m.Complete()).Callback(() => { return; });
        
        return mock;
    }
}