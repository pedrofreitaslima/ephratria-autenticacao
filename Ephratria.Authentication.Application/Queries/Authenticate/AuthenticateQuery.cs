using Ephratria.Authentication.Application.Results;
using MediatR;
using ErrorOr;

namespace Ephratria.Authentication.Application.Queries;

public record AuthenticateQuery(
    byte[] BiometricFile) :  IRequest<ErrorOr<AuthenticateResult>>;