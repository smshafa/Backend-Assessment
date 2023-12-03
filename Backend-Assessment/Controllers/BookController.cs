using Backend_Assessment.Application.Features.Dto.Book;
using Backend_Assessment.Application.Features.Query.Book.PenaltyBussiness;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assessment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IMediator _mediator;
    public BookController(IMediator mediator) => _mediator = mediator;
    
    [AllowAnonymous]
    [HttpPost]
    [Route("GetPenaltyBussinessDay")]
    public async Task<ActionResult<PenaltyBussinessDayDto>> GetPenaltyBussinessDay(GetPenaltyBussinessQuery request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
    
        return Ok(result);
    }
    
}