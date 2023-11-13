using Backend_Assessment.Application.Features.Dto.Pagination;
using Backend_Assessment.Application.Features.Query.Product.GetProducts;
using MediatR;

namespace Backend_Assessment.Application.Features.Query.Category.GetCategories;

public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, PagedResultDto<Models.Category>>
{
    public GetCategoriesQueryHandler()
    {
        
    }
    
    public async Task<PagedResultDto<Models.Category>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}