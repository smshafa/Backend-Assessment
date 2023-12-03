namespace Backend_Assessment.Models;

public class Country
{
    public int Id { set; get; }
    public string Name { set; get; }
    public string CurrencySign { set; get; }
    public ICollection<Holiday> Holidays { set; get; }
    public ICollection<Weekend> Weekends { set; get; }
}