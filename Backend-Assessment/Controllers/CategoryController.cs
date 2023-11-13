using Backend_Assessment.Application.Features.Query.Category.GetCategories;
using Backend_Assessment.Application.Features.Query.Product.GetProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assessment.Controllers;

public class CategoryController : ControllerBase
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public ProductsController(IMediator mediator) => _mediator = mediator;
        
        [HttpGet]
        public async Task<ActionResult> GetCategories()
        {
            var products = await _mediator.Send(new GetCategoriesQuery());
            return Ok(products);
        }
    }
}