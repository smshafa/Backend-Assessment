using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        
        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return Ok(products);
        }
    }
}
