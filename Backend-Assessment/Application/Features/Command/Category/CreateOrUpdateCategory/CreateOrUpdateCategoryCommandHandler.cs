using AutoMapper;
using Backend_Assessment.Repositories;
using MediatR;

namespace Backend_Assessment.Application.Features.Command.Category.CreateOrUpdateCategory;

public class CreateOrUpdateCategoryCommandHandler : IRequestHandler<CreateOrUpdateCategoryCommand>
{
    private readonly IUnitOfRepository _unitOfRepository;
    private readonly IMapper _mapper;
    
    public CreateOrUpdateCategoryCommandHandler(IUnitOfRepository unitOfRepository, IMapper mapper)
    {
        _unitOfRepository = unitOfRepository;
        _mapper = mapper;
    }
    
    public async Task Handle(CreateOrUpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Models.Category>(request);
        var oldCategory = _unitOfRepository.Categories.GetAll().SingleOrDefault(cat => cat.Id == category.Id);
        if (oldCategory is not null)
        {
            oldCategory.Name = category.Name;
            oldCategory.Products = category.Products;
        }
        else
        {
            await _unitOfRepository.Categories.AddAsync(category);
        }

        _unitOfRepository.Complete();
    } 
}