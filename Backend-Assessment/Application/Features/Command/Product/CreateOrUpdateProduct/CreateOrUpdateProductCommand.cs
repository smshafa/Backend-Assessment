using MediatR;

namespace Backend_Assessment.Application.Features.Command.Product.CreateOrUpdateProduct;

public class CreateOrUpdateProductCommand : IRequest
{
    public CreateOrUpdateProductCommand()
    {
    }

    public CreateOrUpdateProductCommand(int? id, string name, int categoryId)
    {
        Id = id;
        Name = name;
        CategoryId = categoryId;
    }
    
    public int? Id { set; get; } 
    public string Name { set; get; }
    public int CategoryId { set; get; }
}