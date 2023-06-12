using ErrorOr;

namespace Ephratria.Authentication.Domain.Commons.Errors;

public static partial class Errors
{
    public static class Authenticate
    {
        public static Error InvalidBiometrics => Error.Conflict(
            code: "Auth.InvalidBiometrics",
            description: "Invalid biometrics"
        );
    }
}