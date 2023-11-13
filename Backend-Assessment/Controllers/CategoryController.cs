using Backend_Assessment.Application.Features.Command.Category.CreateOrUpdateCategory;
using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Application.Features.Dto.Pagination;
using Backend_Assessment.Application.Features.Query.Category.GetCategories;
using Backend_Assessment.Application.Features.Query.Product.GetProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assessment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public CategoryController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    [Route("CreateCategory")]
    public async Task CreateCategory(CreateOrUpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
    }

    [HttpPut]
    [Route("UpdateCategory")]
    public async Task UpdateCategory(CreateOrUpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
    }

    [HttpPost]
    [Route("GetCategories")]
    public async Task<ActionResult<PagedResultDto<CategoryDto>>> GetCategories(GetCategoriesQuery getCategoriesQuery,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(getCategoriesQuery, cancellationToken);

        return Ok(result);
    }

    [HttpGet]
    [Route("GetCategories")]
    public async Task<ActionResult<PagedResultDto<CategoryDto>>> GetCategories(int pageIndex, int pageSize,
        string? filter, string? sorting, CancellationToken cancellationToken)
    {
        GetCategoriesQuery getCategoriesQuery = new GetCategoriesQuery()
        {
            PageIndex = pageIndex,
            PageSize = pageSize,
            Filter = filter,
            Sorting = sorting
        };
        var result = await _mediator.Send(getCategoriesQuery, cancellationToken);
        
        return Ok(result);
    }

}