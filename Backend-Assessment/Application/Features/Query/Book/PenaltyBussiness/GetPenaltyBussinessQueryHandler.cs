using Backend_Assessment.Application.Features.Dto.Book;
using Backend_Assessment.Repositories;
using MediatR;

namespace Backend_Assessment.Application.Features.Query.Book.PenaltyBussiness;

public class GetPenaltyBussinessQueryHandler : IRequestHandler<GetPenaltyBussinessQuery, PenaltyBussinessDayDto>
{
    private readonly IUnitOfRepository _unitOfRepository;

    public GetPenaltyBussinessQueryHandler(IUnitOfRepository unitOfRepository)
    {
        _unitOfRepository = unitOfRepository;
    }

    public async Task<PenaltyBussinessDayDto> Handle(GetPenaltyBussinessQuery request,
        CancellationToken cancellationToken)
    {
        PenaltyBussinessDayDto penaltyDayDto = new PenaltyBussinessDayDto();
        int businessDays = CalculateBusinessDays(request.DateCheckedOut, request.DateCheckedIn, request.CountryId);
        decimal penalty = CalculatePenalty(businessDays);

        penaltyDayDto.Penalty = penalty;
        penaltyDayDto.BussinessDays = businessDays;
        penaltyDayDto.CurrencySign = _unitOfRepository.Countries.All.SingleOrDefault(c => c.Id == request.CountryId)
            .CurrencySign;
        return penaltyDayDto;
    }
    
    private int CalculateBusinessDays(DateTime dateCheckedOut, DateTime dateCheckedIn, int countryId)
    {
        List<DateOnly> holidays = _unitOfRepository.Holidays.All.Where(h => h.CountryId == countryId)
            .Select(h => h.Date).ToList().Select(d => DateOnly.FromDateTime(d)).ToList();
        var weekendDays = _unitOfRepository.Weekends.All.Where(w => w.CountryId == countryId)
            .Select(w => w.Day).ToList();
        
        int businessDays = 0;
        for (DateTime date = dateCheckedIn; date <= dateCheckedOut; date = date.AddDays(1))
        {
            var ss = date.DayOfWeek.ToString();
            DateOnly dateOnly = DateOnly.FromDateTime(date);
            if (!weekendDays.Contains(date.DayOfWeek.ToString()) && !holidays.Contains(dateOnly))
            {
                businessDays++;
            }
        }

        return businessDays;
    }


    private decimal CalculatePenalty(int businessDays)
    {
        decimal penaltyAmount = 0;
        if (businessDays > 10)
        {
            penaltyAmount = (businessDays - 10) * 5.00m;
        }

        return penaltyAmount;
    }
}