using FluentValidation;

namespace Ephratria.Authentication.Application.Commands;

public class SignUpCommandValidator : AbstractValidator<SignUpCommand>
{
    public SignUpCommandValidator()
    {
        
    }
}