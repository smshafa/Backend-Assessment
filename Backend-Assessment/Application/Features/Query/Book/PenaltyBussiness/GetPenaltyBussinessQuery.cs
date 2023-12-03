using Backend_Assessment.Application.Features.Dto.Book;
using MediatR;

namespace Backend_Assessment.Application.Features.Query.Book.PenaltyBussiness;

public class GetPenaltyBussinessQuery : IRequest<PenaltyBussinessDayDto>
{
    public GetPenaltyBussinessQuery(){}
    
    public DateTime DateCheckedOut { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public int CountryId { get; set; }
}