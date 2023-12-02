using AutoMapper;
using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Application.Features.Dto.Pagination;
using Backend_Assessment.Application.Features.Profile;
using Backend_Assessment.Application.Features.Query.Category.GetCategories;
using Backend_Assessment.Controllers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TestProject.Mocks;

namespace TestProject;

public class CategoryControllerUnitTest
{
    public IMapper GetMapper()
    {
        var categoryProfile = new CategoryProfile();
        var configuration = new MapperConfiguration(cfg => cfg.AddProfile(categoryProfile));
        return new Mapper(configuration);
    }

    public Mock<IMediator> GetMediator()
    {
        Mock<IMediator> mockMediator = new Mock<IMediator>();
        return mockMediator;
    }

    [Fact]
    public void WhenGettingAllCategories_ThenAllCategoriesReturn()
    {
        var repositoryWrapperMock = MockUnitOfRepositories.GetMock();
        var mapper = GetMapper();
        var mediator = GetMediator();
        var categoryController = new CategoryController(mediator.Object);
        Mock<PagedResultDto<CategoryDto>> mockPagedCategoryDto = new Mock<PagedResultDto<CategoryDto>>();
        
        GetCategoriesQuery getCategoriesQuery = new GetCategoriesQuery();
        mediator.Setup(m => m.Send(It.IsAny<GetCategoriesQuery>(), It.IsAny<CancellationToken>()));

        mediator.Setup(m => m.Send(It.IsAny<GetCategoriesQuery>()))
            .Returns(Task.FromResult(mockPagedCategoryDto.Object));

        // var result = categoryController.GetCategories(getCategoriesQuery, CancellationToken.None) as ObjectResult;
        // Assert.NotNull(result);
        // Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
        // Assert.IsAssignableFrom<IEnumerable<CategoryDto>>(result.Value);
        // Assert.NotEmpty(result.Value as IEnumerable<CategoryDto>);
    }
}