using Backend_Assessment.Application.Features.Dto.Pagination;
using Backend_Assessment.Application.Features.Dto.Product;

namespace Backend_Assessment.Application.Features.Query.Product.GetProduct;

public class GetProductQuery : PagingParamQuery<ProductDto>
{
    public GetProductQuery() { }

    public GetProductQuery(int id)
    {
        Id = id;
    }

    public int Id { set; get; }
}