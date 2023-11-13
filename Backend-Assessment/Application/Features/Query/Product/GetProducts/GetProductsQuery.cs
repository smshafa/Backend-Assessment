using Backend_Assessment.Application.Features.Dto.Pagination;

namespace Backend_Assessment.Application.Features.Query.Product.GetProducts;

public class GetProductsQuery : PagingParamQuery<PagedResultDto<Models.Product>>
{
    public GetProductsQuery(){}
}