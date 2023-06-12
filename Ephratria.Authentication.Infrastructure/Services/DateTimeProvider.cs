using Ephratria.Authentication.Application.Commons.Interfaces.Services;

namespace Ephratria.Authentication.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}