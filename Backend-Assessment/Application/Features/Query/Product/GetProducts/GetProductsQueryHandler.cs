using Backend_Assessment.Application.Features.Dto.Pagination;
using MediatR;

namespace Backend_Assessment.Application.Features.Query.Product.GetProducts;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, PagedResultDto<Models.Product>>
{
    public GetProductsQueryHandler()
    {
        
    }
    
    public async Task<PagedResultDto<Models.Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}