using ErrorOr;

namespace Ephratria.Authentication.Domain.Commons.Errors;

public static partial class Errors
{
    public static class Attach
    {
        public static Error InvalidFileType => Error.Conflict(
            code: "Attach.InvalidFileType",
            description: "Invalid file type, only attach images"
        );
    }
}