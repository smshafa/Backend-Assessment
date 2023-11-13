using Backend_Assessment.Application.Features.Command.Product.CreateOrUpdateProduct;
using MediatR;

namespace Backend_Assessment.Application.Features.Command.Product.CreateProduct;

public class CreateOrUpdateProductCommandHandler : IRequestHandler<CreateOrUpdateProductCommand> 
{
    public async Task Handle(CreateOrUpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    } 
}