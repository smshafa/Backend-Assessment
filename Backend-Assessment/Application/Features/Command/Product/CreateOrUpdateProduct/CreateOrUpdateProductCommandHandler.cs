using MediatR;

namespace Backend_Assessment.Application.Features.Command.Product.CreateOrUpdateProduct;

public class CreateOrUpdateProductCommandHandler : IRequestHandler<CreateOrUpdateProductCommand> 
{
    public async Task Handle(CreateOrUpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    } 
}