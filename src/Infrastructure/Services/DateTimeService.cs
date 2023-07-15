using CargoTender.Application.Common.Interfaces;

namespace CargoTender.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
