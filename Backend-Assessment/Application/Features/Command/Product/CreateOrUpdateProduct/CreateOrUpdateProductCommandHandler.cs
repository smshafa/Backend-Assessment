using AutoMapper;
using Backend_Assessment.Repositories;
using MediatR;

namespace Backend_Assessment.Application.Features.Command.Product.CreateOrUpdateProduct;

public class CreateOrUpdateProductCommandHandler : IRequestHandler<CreateOrUpdateProductCommand> 
{
    private readonly IUnitOfRepository _unitOfRepository;
    private readonly IMapper _mapper;
    
    public CreateOrUpdateProductCommandHandler(IUnitOfRepository unitOfRepository, IMapper mapper)
    {
        _unitOfRepository = unitOfRepository;
        _mapper = mapper;
    }
    
    public async Task Handle(CreateOrUpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = _mapper.Map<Models.Product>(request);
        if (_unitOfRepository.Categories.GetOne(product.CategoryId) is null)
            throw new Exception("The category was not found!");
        
        var oldProduct = _unitOfRepository.Products.GetOne(product.Id);
        if (oldProduct is not null)
        {
            oldProduct.Name = product.Name;
            oldProduct.CategoryId = product.CategoryId;
            _unitOfRepository.Products.Update(oldProduct);
        }
        else
        {
            await _unitOfRepository.Products.AddAsync(product);
        }

        _unitOfRepository.Complete();
    } 
}