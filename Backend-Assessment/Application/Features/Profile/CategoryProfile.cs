using Backend_Assessment.Application.Features.Command.Category.CreateOrUpdateCategory;
using Backend_Assessment.Models;

namespace Backend_Assessment.Application.Features.Profile;

public class CategoryProfile : AutoMapper.Profile
{
    public CategoryProfile()
    {
        CreateMap<CreateOrUpdateCategoryCommand, Category>();
    }
}