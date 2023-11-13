using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Application.Features.Dto.Pagination;

namespace Backend_Assessment.Application.Features.Query.Category.GetCategories;

public class GetCategoriesQuery : PagingParamQuery<PagedResultDto<CategoryDto>>
{
    public GetCategoriesQuery(){}
    
    public string? Filter { get; set; }
    public string? Sorting { get; set; }
}