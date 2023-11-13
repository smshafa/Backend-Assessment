using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Application.Features.Dto.Pagination;
using Backend_Assessment.Extensions;
using Backend_Assessment.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Application.Features.Query.Category.GetCategories;

public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, PagedResultDto<CategoryDto>>
{
    private readonly IUnitOfRepository _unitOfRepository;
    public GetCategoriesQueryHandler(IUnitOfRepository unitOfRepository)
    {
        _unitOfRepository = unitOfRepository;
    }

    public async Task<PagedResultDto<CategoryDto>> Handle(GetCategoriesQuery request,
        CancellationToken cancellationToken)
    {
        var query = GetFilterQuery(request);
        var count = await query.CountAsync();
        var result = PagedResultDto<CategoryDto>.ToPagedList(query, count, request.PageIndex, request.PageSize);

        return result;
    }

    private IQueryable<CategoryDto> GetFilterQuery(GetCategoriesQuery filter)
    {
        var categories = _unitOfRepository.Categories.GetAll().AsNoTracking()
            .Include(x => x.Products)
            .Select(x => new CategoryDto()
            {
                Id = x.Id,
                Name = x.Name,
                Products = x.Products.ToList()
            })
            .WhereIf(!string.IsNullOrEmpty(filter.Filter), p => p.Name.Contains(filter.Filter))
            .OrderByDescending(p => p.Name);

        return categories;
    }
}