using FluentValidation;

namespace Ephratria.Authentication.Application.Queries;

public class AuthenticateQueryValidator: AbstractValidator<AuthenticateQuery>
{
    public AuthenticateQueryValidator()
    {
        
    }
}