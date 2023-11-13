using Backend_Assessment.Application.Features.Dto.Pagination;
using Backend_Assessment.Application.Features.Dto.Product;
using Backend_Assessment.Application.Features.Query.Category.GetCategories;
using Backend_Assessment.Extensions;
using Backend_Assessment.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Application.Features.Query.Product.GetProducts;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, PagedResultDto<ProductDto>>
{
    private readonly IUnitOfRepository _unitOfRepository;
    public GetProductsQueryHandler(IUnitOfRepository unitOfRepository)
    {
        _unitOfRepository = unitOfRepository;
    }

    public async Task<PagedResultDto<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var query = GetFilterQuery(request);
        var count = await query.CountAsync();
        var result = PagedResultDto<ProductDto>.ToPagedList(query, count, request.PageIndex, request.PageSize);

        return result;
    }

    private IQueryable<ProductDto> GetFilterQuery(GetProductsQuery filter)
    {
        var categories = _unitOfRepository.Products.GetAll().AsNoTracking()
            .Select(x => new ProductDto()
            {
                Id = x.Id,
                Name = x.Name,
                CategoryId = x.CategoryId
            })
            .WhereIf(!string.IsNullOrEmpty(filter.Filter), p => p.Name.Contains(filter.Filter))
            .OrderByDescending(p => p.Name);

        return categories;
    }
}