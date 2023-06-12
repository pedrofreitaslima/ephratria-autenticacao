using Ephratria.Authentication.Application.Results;
using MediatR;
using ErrorOr;

namespace Ephratria.Authentication.Application.Commands;

public record SignUpCommand(
    string FirstName,
    string LastName,
    string Email,
    string NickName) : IRequest<ErrorOr<SignUpResult>>;