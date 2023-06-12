using ErrorOr;

namespace Ephratria.Authentication.Domain.Commons.Errors;

public static partial class Errors
{
    public static class SignIn
    {
        public static Error InvalidNickname => Error.Conflict(
            code: "SignIn.InvalidNickname",
            description: "Invalid nickname, nickname not found"
        );
    }
}