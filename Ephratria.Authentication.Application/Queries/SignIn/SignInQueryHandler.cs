using Ephratria.Authentication.Application.Results;
using MediatR;
using ErrorOr;


namespace Ephratria.Authentication.Application.Queries;

public class SignInQueryHandler : 
    IRequestHandler<SignInQuery, ErrorOr<SignInResult>>
{
    public async Task<ErrorOr<SignInResult>> Handle(SignInQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}