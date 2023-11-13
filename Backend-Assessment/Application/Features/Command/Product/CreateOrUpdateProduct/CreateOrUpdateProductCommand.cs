using MediatR;

namespace Backend_Assessment.Application.Features.Command.Product.CreateOrUpdateProduct;

public class CreateOrUpdateProductCommand : IRequest
{
    public CreateOrUpdateProductCommand()
    {
    }

    public CreateOrUpdateProductCommand(string name, int categoryId)
    {
        Name = name;
        CategoryId = categoryId;
    }
    
    public string Name { set; get; }
    public int CategoryId { set; get; }
}