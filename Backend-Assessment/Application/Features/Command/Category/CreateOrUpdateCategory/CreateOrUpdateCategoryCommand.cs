using MediatR;

namespace Backend_Assessment.Application.Features.Command.Category.CreateOrUpdateCategory;

public class CreateOrUpdateCategoryCommand : IRequest
{
    public CreateOrUpdateCategoryCommand()
    {
    }

    public CreateOrUpdateCategoryCommand(string name)
    {
        Name = name;
    }
    
    public string Name { set; get; }
    
}