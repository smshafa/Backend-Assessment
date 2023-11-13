using Backend_Assessment.Application.Features.Dto.Pagination;
using Backend_Assessment.Application.Features.Dto.Product;

namespace Backend_Assessment.Application.Features.Query.Product.GetProducts;

public class GetProductsQuery : PagingParamQuery<PagedResultDto<ProductDto>>
{
    public GetProductsQuery(){}
    
    public string? Filter { get; set; }
    public string? Sorting { get; set; }
}