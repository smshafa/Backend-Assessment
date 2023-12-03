namespace Backend_Assessment.Application.Features.Dto.Book;

public class PenaltyBussinessDayDto
{
    public PenaltyBussinessDayDto()
    {
    }

    public decimal Penalty { get; set; }
    public int BussinessDays { get; set; }
    
    public string CurrencySign { get; set; }
}