using MediatR;

namespace Backend_Assessment.Application.Features.Command.Product.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand> 
{
    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    } 
}