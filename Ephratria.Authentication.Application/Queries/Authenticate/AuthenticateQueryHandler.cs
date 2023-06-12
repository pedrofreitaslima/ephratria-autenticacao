using Ephratria.Authentication.Application.Results;
using MediatR;
using ErrorOr;

namespace Ephratria.Authentication.Application.Queries;

public class AuthenticateQueryHandler :
    IRequestHandler<AuthenticateQuery, ErrorOr<AuthenticateResult>>
{
    public async Task<ErrorOr<AuthenticateResult>> Handle(AuthenticateQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}