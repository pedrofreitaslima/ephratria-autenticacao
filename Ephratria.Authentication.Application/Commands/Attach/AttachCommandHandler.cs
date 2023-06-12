using Ephratria.Authentication.Application.Results;
using MediatR;
using ErrorOr;

namespace Ephratria.Authentication.Application.Commands;

public class AttachCommandHandler : 
    IRequestHandler<AttachCommand, ErrorOr<AttachResult>>
{
    public async Task<ErrorOr<AttachResult>> Handle(AttachCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}