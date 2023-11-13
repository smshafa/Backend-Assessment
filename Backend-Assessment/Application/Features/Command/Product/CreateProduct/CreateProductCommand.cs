using MediatR;

namespace Backend_Assessment.Application.Features.Command.Product.CreateProduct;

public class CreateProductCommand : IRequest
{
    public CreateProductCommand()
    {
    }

    public CreateProductCommand(string title)
    {
        Title = title;
    }
    
    public string Title { set; get; }
    
}