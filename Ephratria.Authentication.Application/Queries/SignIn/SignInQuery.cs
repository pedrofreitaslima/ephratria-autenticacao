using Ephratria.Authentication.Application.Results;
using MediatR;
using ErrorOr;

namespace Ephratria.Authentication.Application.Queries;

public record SignInQuery(
    string NickName) : IRequest<ErrorOr<SignInResult>>;