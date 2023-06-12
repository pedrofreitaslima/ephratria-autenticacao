using Ephratria.Authentication.Application.Results;
using MediatR;
using ErrorOr;

namespace Ephratria.Authentication.Application.Commands;

public class SignUpCommandHandler : 
    IRequestHandler<SignUpCommand, ErrorOr<SignUpResult>>
{
    public async Task<ErrorOr<SignUpResult>> Handle(SignUpCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}