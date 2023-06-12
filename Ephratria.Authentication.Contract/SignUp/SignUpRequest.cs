namespace Ephratria.Authentication.Contract.SignUp;

public record SignUpRequest(
    string FirstName,
    string LastName,
    string Email,
    string NickName);