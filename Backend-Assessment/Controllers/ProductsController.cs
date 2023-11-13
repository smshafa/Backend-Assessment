using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Assessment.Application.Features.Command.Category.CreateOrUpdateCategory;
using Backend_Assessment.Application.Features.Command.Product.CreateOrUpdateProduct;
using Backend_Assessment.Application.Features.Query.Product.GetProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        public async Task<ActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return Ok(products);
        }
    }
}
