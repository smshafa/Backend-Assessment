namespace Backend_Assessment.Application.Features.Dto.Category;

public class CategoryDto
{
    public CategoryDto()
    {
    }

    public int Id { set; get; }
    public string Name { set; get; }
    public List<Models.Product> Products { set; get; }
}