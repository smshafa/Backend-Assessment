using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Application.Features.Dto.Pagination;

namespace Backend_Assessment.Application.Features.Query.Category.GetCategory;

public class GetCategoryQuery : PagingParamQuery<CategoryDto>
{
    public GetCategoryQuery(){}

    public GetCategoryQuery(int id)
    {
        Id = id;
    }
    
    public int Id { set; get; }
}