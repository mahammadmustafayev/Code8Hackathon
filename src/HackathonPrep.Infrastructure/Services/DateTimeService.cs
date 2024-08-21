using HackathonPrep.Application.Common.Interfaces;

namespace HackathonPrep.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
