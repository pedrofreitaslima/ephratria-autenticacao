using ErrorOr;

namespace Ephratria.Authentication.Domain.Commons.Errors;

public static partial class Errors
{
    public static class SignUp
    {
        public static Error DuplicateEmail => Error.Conflict(
            code: "SignUp.DuplicateEmail",
            description: "Email is already is use."
        );
        
        public static Error DuplicateNickname => Error.Conflict(
            code: "SignUp.DuplicateNickname",
            description: "Nickname is already is use."
        );
    }
}