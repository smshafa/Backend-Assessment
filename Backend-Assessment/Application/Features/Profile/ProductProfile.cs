using Backend_Assessment.Application.Features.Command.Product.CreateOrUpdateProduct;
using Backend_Assessment.Models;

namespace Backend_Assessment.Application.Features.Profile;

public class ProductProfile : AutoMapper.Profile
{
    public ProductProfile()
    {
        CreateMap<CreateOrUpdateProductCommand, Product>();
    }
}