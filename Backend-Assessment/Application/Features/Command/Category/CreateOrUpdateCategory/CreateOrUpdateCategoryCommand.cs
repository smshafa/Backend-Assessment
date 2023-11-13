using MediatR;

namespace Backend_Assessment.Application.Features.Command.Category.CreateOrUpdateCategory;

public class CreateOrUpdateCategoryCommand : IRequest
{
    public CreateOrUpdateCategoryCommand()
    {
    }

    public CreateOrUpdateCategoryCommand(int? id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public int? Id { set; get; }
    public string Name { set; get; }
    
}