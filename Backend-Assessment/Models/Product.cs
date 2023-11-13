namespace Backend_Assessment.Models;

public class Product
{
    public int Id { set; get; }
    public string Name { set; get; }
    public Category Category { get; set; }
}