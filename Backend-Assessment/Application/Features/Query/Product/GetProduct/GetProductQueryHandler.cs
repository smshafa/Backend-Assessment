using Backend_Assessment.Application.Features.Dto.Product;
using Backend_Assessment.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Backend_Assessment.Application.Features.Query.Product.GetProduct;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductDto>
{
    private readonly IUnitOfRepository _unitOfRepository;

    public GetProductQueryHandler(IUnitOfRepository unitOfRepository)
    {
        _unitOfRepository = unitOfRepository;
    }

    public async Task<ProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var result = _unitOfRepository.Products.GetAll().AsNoTracking()
            .Select(x => new ProductDto()
            {
                Id = x.Id,
                Name = x.Name,
                CategoryId = x.CategoryId
            }).SingleOrDefault(x => x.Id == request.Id);

        return result;
    }
}