using Ephratria.Authentication.Domain.Commons.Enums;

namespace Ephratria.Authentication.Domain.UserAggregates;

public class User 
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } =  string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string NickName { get; set; } = string.Empty;
    public string Biometry { get; set; } = string.Empty;
    public UserStatus Status { get; set; } = UserStatus.NotValidEmail;
}