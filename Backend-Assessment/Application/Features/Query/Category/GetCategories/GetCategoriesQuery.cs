using Backend_Assessment.Application.Features.Dto.Pagination;

namespace Backend_Assessment.Application.Features.Query.Category.GetCategories;

public class GetCategoriesQuery : PagingParamQuery<PagedResultDto<Models.Category>>
{
    public GetCategoriesQuery(){}
}