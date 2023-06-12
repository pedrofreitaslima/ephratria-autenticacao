using FluentValidation;

namespace Ephratria.Authentication.Application.Queries;

public class SignInQueryValidator : AbstractValidator<SignInQuery>
{
    public SignInQueryValidator()
    {
        
    }
}