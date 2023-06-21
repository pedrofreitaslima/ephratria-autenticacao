using Ephratria.Authentication.Domain.Commons.Enums;
using Ephratria.Authentication.Domain.Commons.Models;
using Ephratria.Authentication.Domain.UserAggregates.ValueObjects;

namespace Ephratria.Authentication.Domain.UserAggregates;

public class User : AggregateRoot<UserId, Guid>
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public FirstName FirstName { get; set; }
    public LastName LastName { get; set; }
    public Email Email { get; set; }
    public NickName NickName { get; set; }
    public BiometryId BiometryId { get; set; }
    public UserStatus Status { get; set; } = UserStatus.PendentEmail;
    public DateTime CreatedDateTime { get; private set; }
    public DateTime UpdatedDateTime { get; private set; }

    private User(FirstName firstName, 
        LastName lastName,
        NickName nickName,
        Email email,
        BiometryId biometryId)
    {
        FirstName = firstName;
        LastName = lastName;
        NickName = nickName;
        Email = email;
        BiometryId = biometryId;
        Status = UserStatus.PendentEmail;
    }
}