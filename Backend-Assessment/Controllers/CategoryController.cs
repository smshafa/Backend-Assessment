using Backend_Assessment.Application.Features.Command.Category.CreateOrUpdateCategory;
using Backend_Assessment.Application.Features.Dto.Category;
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
    [Route("Create")]
    public async Task Create(CreateOrUpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
    }

    [HttpGet]
    public async Task<ActionResult> GetCategories()
    {
        var products = await _mediator.Send(new GetCategoriesQuery());
        return Ok(products);
    }

}