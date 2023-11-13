using MediatR;

namespace Backend_Assessment.Application.Features.Command.Category.CreateOrUpdateCategory;

public class CreateOrUpdateCategoryCommandHandler : IRequestHandler<CreateOrUpdateCategoryCommand> 
{
    public async Task Handle(CreateOrUpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    } 
}