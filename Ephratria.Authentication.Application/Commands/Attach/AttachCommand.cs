using Ephratria.Authentication.Application.Results;
using MediatR;
using ErrorOr;

namespace Ephratria.Authentication.Application.Commands;

public record AttachCommand(
    byte[] BiometricFile) : IRequest<ErrorOr<AttachResult>>;