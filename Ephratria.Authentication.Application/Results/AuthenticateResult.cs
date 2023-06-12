using Ephratria.Authentication.Domain.UserAggregates;

namespace Ephratria.Authentication.Application.Results;

public record AuthenticateResult(
    User User,
    string Token);