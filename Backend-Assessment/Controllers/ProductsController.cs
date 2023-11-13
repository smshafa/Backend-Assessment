using Backend_Assessment.Application.Features.Command.Product.CreateOrUpdateProduct;
using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Application.Features.Dto.Pagination;
using Backend_Assessment.Application.Features.Dto.Product;
using Backend_Assessment.Application.Features.Query.Product.GetProduct;
using Backend_Assessment.Application.Features.Query.Product.GetProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public ProductsController(IMediator mediator) => _mediator = mediator;
        
        [HttpPost]
        [Route("CreateProduct")]
        public async Task CreateProduct(CreateOrUpdateProductCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public async Task UpdateProduct(CreateOrUpdateProductCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
        }
        
        [HttpGet]
        [Route("GetProducts")]
        public async Task<ActionResult<PagedResultDto<ProductDto>>> GetProducts(int pageIndex, int pageSize,
            string? filter, string? sorting, CancellationToken cancellationToken)
        {
            GetProductsQuery getCategoriesQuery = new GetProductsQuery()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Filter = filter,
                Sorting = sorting
            };
            var result = await _mediator.Send(getCategoriesQuery, cancellationToken);
        
            return Ok(result);
        }
        
        [HttpGet]
        [Route("GetProduct")]
        public async Task<ActionResult<CategoryDto>> Get(int productId, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetProductQuery(productId), cancellationToken);
            return Ok(result);
        }

    }
}
