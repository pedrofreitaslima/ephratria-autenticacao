using Ephratria.Authentication.Domain.UserAggregates;

namespace Ephratria.Authentication.Application.Commons.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}