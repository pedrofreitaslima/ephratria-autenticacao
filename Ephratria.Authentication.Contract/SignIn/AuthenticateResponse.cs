using Ephratria.Authentication.Domain.UserAggregates;

namespace Ephratria.Authentication.Contract.SignIn;

public record AuthenticateResponse(
    User User,
    string Token);