using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Application.Features.Query.Category.GetCategory;

public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, CategoryDto>
{
    private readonly IUnitOfRepository _unitOfRepository;
    
    public GetCategoryQueryHandler(IUnitOfRepository unitOfRepository)
    {
        _unitOfRepository = unitOfRepository;
    }

    public async Task<CategoryDto> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var result = _unitOfRepository.Categories.GetAll().AsNoTracking()
            .Include(x => x.Products)
            .Select(x => new CategoryDto()
            {
                Id = x.Id,
                Name = x.Name,
                Products = x.Products.ToList()
            }).SingleOrDefault(x => x.Id == request.Id);

        return result;
    }
}